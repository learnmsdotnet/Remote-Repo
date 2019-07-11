using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace LearnProject
{
    public partial class Home : Form
    {
        #region         "Constructor"

        public Home()
        {
            InitializeComponent();

            
        }

        #endregion

        #region         "Private Variables"

        SqlDataAdapter _sqlDataAdapter = null;        
        DataSet _dataSet = null;

        #endregion

        #region         "Event Handlers"

        private void Home_Load(object sender, EventArgs e) {
            //Clear all the controls at the load of the form
            UIHandler.ClearControl(textBoxName, textBoxPrice, dateTimePickerMfgDate);

            //Populate the DataGridView with data from the database
            this.populateRecords();

            //Set properties for the dataGridView (read-only), column width, cell alignment etc..
            string status = UIHandler.DataGridViewProperties(dataGridViewProducts, this.Width);

            //no errors are identified
            if (!string.IsNullOrEmpty(status))
                MessageBox.Show(status, Common.APPLICATION_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Set the focus on the textBox (Name)
            textBoxName.Focus();
        }

        private void Home_Resize(object sender, EventArgs e) {
            //Normal mode: FormWidth: 700
            //Maximize mode: FormWidth: 1376
            UIHandler.DataGridViewProperties(dataGridViewProducts, this.Width);
        }

        private void textBoxPrice_Leave(object sender, EventArgs e) {
            string data = textBoxPrice.Text.Trim();
            //data should not be null (null check) and the given number should be of numeric dataType
            //https://stackoverflow.com/questions/22794356/isnumeric-function-in-c-sharp
            
            if ((data != null) && (long.TryParse(data, out long returnData))) {

                data = string.Format("{0:C}", Convert.ToInt64(data));
                //add the space between $ and value ($44.00) -> $ 44.00
                if (data.StartsWith("$"))
                    data = data.Replace("$", "$ ");
                //assign value back to text box
                textBoxPrice.Text = data;
            }
        }

        private void DataGridViewProducts_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
            DialogResult response = MessageBox.Show(Common.MESSAGE04_DELETE_ROW_CONFIRMATION, Common.APPLICATION_NAME,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.No)
                e.Cancel = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            //validate to check data is available for name and price 
            if (!textBoxNameValidating() || !textBoxPriceValidating())
                return;

            //validation to check the Mfg date of the product should be less than today
            //todo: (validation to check the Mfg date of the product should be less than today)

            string returnData = string.Empty;
            //add the new data to the dataGridView
            if ((returnData = addDataToProductsGrid()) == null) {
                MessageBox.Show(Common.MESSAGE03_New_ROW_ADDED_SUCCESS, Common.APPLICATION_NAME,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Clear the textBoxes and Date Control in the UI
                UIHandler.ClearControl(textBoxName, textBoxPrice, dateTimePickerMfgDate);
            }
            else
                MessageBox.Show(returnData, Common.APPLICATION_NAME,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void Home_KeyDown(object sender, KeyEventArgs e) {
            //On click of escapre close the form
            //Select properties of Form and select 'KeyPreview' and change it from 'false' to 'true'. [By default, its value is false.] 
            //Then write the below code in the KeyUp event of the Form:
            //Ref: https://www.codeproject.com/Tips/218346/Close-form-with-press-of-Escape-button

            if (e.KeyCode == Keys.Escape) 
                Close();            
        }        

        private void Home_FormClosing(object sender, FormClosingEventArgs e) {

            //Ref: https://stackoverflow.com/questions/2683679/how-to-know-user-has-clicked-x-or-the-close-button            
            this.saveDatabase(e);
        }

        #endregion

        #region         "Private Methods"

        private void saveDatabase(FormClosingEventArgs e) {
            DialogResult response = MessageBox.Show(Common.MESSAGE06_CONFIRM_FORM_CLOSE, Common.APPLICATION_NAME,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
                this.saveChangesDatbase();
            else
                e.Cancel = true;
        }

        public bool isNumeric(string value) {
            
            //Ref: https://stackoverflow.com/questions/22794356/isnumeric-function-in-c-sharp
            return value.All(char.IsNumber);
        }

        private bool textBoxNameValidating() {
            
            //check whether the textBox 'Name' is not empty
            if (string.IsNullOrWhiteSpace(textBoxName.Text.Trim())) {
                textBoxName.Focus();
                errorProvider_textBoxName.SetError(textBoxName, Common.MESSAGE01_PRODUCT_NAME_NOT_EMPTY);
                return false;
            }
            else {
                errorProvider_textBoxName.SetError(textBoxName, string.Empty);
                return true;
            }
        }

        private bool textBoxPriceValidating() {
            
            //check whether the textBox 'Price' is not empty
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text.Trim())) {
                textBoxPrice.Focus();
                errorProvider_textBoxPrice.SetError(textBoxPrice, Common.MESSAGE02_PRODUCT_PRICE_NOT_EMPTY);
                return false;
            }
            else {
                errorProvider_textBoxPrice.SetError(textBoxPrice, string.Empty);
                return true;
            }
        }

        private string addDataToProductsGrid() {

            //adding the data to dataGridViewProducts
            string name, price, date = string.Empty;
            name = textBoxName.Text.Trim();
            price = textBoxPrice.Text.Trim();
            date = dateTimePickerMfgDate.Value.ToShortDateString();

            try {
                DataRow dataRowtoAdd = _dataSet.Tables[Common.DATA_TABLE_PRODUCTS].NewRow();
                dataRowtoAdd[Common.COLUMN_NAME] = name;
                dataRowtoAdd[Common.COLUMN_PRICE] = price;
                dataRowtoAdd[Common.COLUMN_DATE] = date;

                _dataSet.Tables[Common.DATA_TABLE_PRODUCTS].Rows.Add(dataRowtoAdd);
                //_dataSet.Tables[Common.DATA_TABLE_PRODUCTS].AcceptChanges();

                //display the product information to the dataGridView
                dataGridViewProducts.DataSource = _dataSet.Tables[Common.DATA_TABLE_PRODUCTS];

                //return null, there is no error in adding the new row
                return null;
            }
            catch (Exception e) {
                return e.ToString();
            }
        }

        public void populateRecords() {

            DatabaseLayer.DBOperations dbOperations = new DatabaseLayer.DBOperations();

            try {
                _sqlDataAdapter = dbOperations.RetrieveRecord(_sqlDataAdapter);
                _sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                _dataSet = new DataSet();
                _sqlDataAdapter.Fill(_dataSet, Common.DATA_TABLE_PRODUCTS);
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), Common.APPLICATION_NAME,
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //display the product information to the dataGridView
            dataGridViewProducts.DataSource = _dataSet.Tables[Common.DATA_TABLE_PRODUCTS];
        }

        private void saveChangesDatbase() {

            try  {
                //int rows = _sqlDataAdapter.Update(_dataSet, Common.DATA_TABLE_PRODUCTS);

                DatabaseLayer.DBOperations dbOperations = new DatabaseLayer.DBOperations();
                string rows = dbOperations.SaveChangesDatabase(_sqlDataAdapter, _dataSet);

                if (isNumeric(rows))
                    MessageBox.Show(string.Format(Common.MESSAGE05_DATA_SUCCESSFUL_DATABASE, rows), Common.APPLICATION_NAME,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(rows, Common.APPLICATION_NAME,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), Common.APPLICATION_NAME,
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}

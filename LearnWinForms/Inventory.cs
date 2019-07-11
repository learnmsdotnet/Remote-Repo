using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LearnWinForms.PresentationLayer;

namespace LearnWinForms
{
    public partial class Inventory : Form
    {
        #region         "Form Constructor"

        public Inventory()
        {
            InitializeComponent();
        }

        #endregion

        #region         "Private Variables"

        private DataSet _dataSet = new DataSet();
        private int _currentRowIndex;
        enum ButtonCaption { Show, Hide }
        private readonly string _show = "Show";
        private readonly string _hide = "Hide";
        private readonly int _dataGridViewDefault = 505;
        private readonly int _dataGridViewExpand = 681;

        #endregion

        #region         "Event Handlers"

        private void DatetimepickerMfgDate_ValueChanged(object sender, EventArgs e)
        {
            datetimepickerMfgDate.Format = DateTimePickerFormat.Short;
        }

        private void DataGridViewProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Operations Insert and Update can be implemented using this event (_CellValueChanged)
            //check whether the current row has a focus (to add a new row of data)
            //Check if the current row is focused in the datagridview. This represets a row is focused or selected in the datagridview
            if (dataGridViewProduct.CurrentRow != null)
            {
                //for the newly created row a DataGridViewRow is created and the data is added
                DataGridViewRow dataGridViewRow = dataGridViewProduct.CurrentRow;
                _currentRowIndex = dataGridViewProduct.CurrentRow.Index;

                //check the Id column is null or having value. If null then new row (insertOperation) not null then (updateOperation)
                if (dataGridViewRow.Cells[0].Value == DBNull.Value)
                    //perform insert operation
                    this.insertDataSet(dataGridViewRow);
                else
                    this.updateDataSet(dataGridViewRow);
            }
        }

        private void DataGridViewProduct_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridViewProduct.CurrentRow.Cells["Name"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure to Delete this record ?", "ABC Corporation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    this.removeRecordDataSet();
                else
                    //this will prevent the default delete operation of the DataGridView Control
                    e.Cancel = true;
            }
            else
                //this will prevent the default delete operation of the DataGridView Control
                e.Cancel = true;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            //PresentationLayer.UIHandler.ClearControl(textboxProductName, textboxCost, datetimepickerMfgDate);
            UIHandler.ClearControl(textboxProductName, textboxCost, datetimepickerMfgDate);

            //Populate DataGridView with records from the database (dbo.Products table)
            this.populateRecords();
        }

        #endregion

        #region         "Button Events"

        private void ButtonToggle_Click(object sender, EventArgs e)
        {
            buttonToggle.Text = toggleCaption(buttonToggle.Text.Trim());
        }

        private void ButtonUpdateData_Click(object sender, EventArgs e)
        {
            DataTable dataTableProduct = null;
            dataTableProduct = new DataTable();

            dataTableProduct = (DataTable)dataGridViewProduct.DataSource;
            _dataSet.Tables.Add(dataTableProduct);
        }

        private void ButtonGetData_Click(object sender, EventArgs e)
        {
            this.populateRecords();
        }

        private void ButtonInsertData_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDeleteData_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.CurrentRow.Cells["Name"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure to Delete this record ?", "ABC Corporation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    this.removeRecordDataSet();
                else
                    //this will prevent the default delete operation of the DataGridView Control
                    dataGridViewProduct.CancelEdit();
            }
            else
                //this will prevent the default delete operation of the DataGridView Control
                dataGridViewProduct.CancelEdit();
        }

        #endregion


        #region         "Private Methods"

        private void insertDataSet(DataGridViewRow dgvCurrentRow)
        {
            DataTable dataTable = new DataTable();
            dataTable = _dataSet.Tables["Product"];

            DataRow dataRow = dataTable.NewRow();
            dataRow["Name"] = dgvCurrentRow.Cells["Name"].Value == DBNull.Value ? "" : dgvCurrentRow.Cells["Name"].Value.ToString();
            dataRow["Price"] = dgvCurrentRow.Cells["Price"].Value == DBNull.Value ? "" : dgvCurrentRow.Cells["Price"].Value.ToString();
            dataRow["Date"] = dgvCurrentRow.Cells["Date"].Value == DBNull.Value ? "1/1/0001" : dgvCurrentRow.Cells["Date"].Value.ToString();

            _dataSet.Tables["Product"].Rows.Add(dataRow);
        }

        //this method will be called when even the DataGridView cell change happens
        private void updateDataSet(DataGridViewRow dgvCurrentRow)
        {
            string name = dgvCurrentRow.Cells["Name"].Value == DBNull.Value ? "" : dgvCurrentRow.Cells["Name"].Value.ToString();
            string price = dgvCurrentRow.Cells["Price"].Value == DBNull.Value ? "" : dgvCurrentRow.Cells["Price"].Value.ToString();
            string mfgDate = dgvCurrentRow.Cells["Date"].Value == DBNull.Value ? "" : dgvCurrentRow.Cells["Date"].Value.ToString();

            _dataSet.Tables["Product"].Rows[_currentRowIndex]["Name"] = name;
            _dataSet.Tables["Product"].Rows[_currentRowIndex]["Price"] = price;
            _dataSet.Tables["Product"].Rows[_currentRowIndex]["Date"] = mfgDate;
        }

        private void removeRecordDataSet()
        {
            //remove this record from the dataset
            //int index = dataGridViewProduct.CurrentRow.Index;

            //Ref: https://stackoverflow.com/questions/18471189/deleting-a-row-completely-from-a-dataset
            _dataSet.Tables["Product"].Rows.RemoveAt(_currentRowIndex);
            _dataSet.AcceptChanges();
        }

        private void assignDataGridView(DataSet dataSet)
        {
            //Display the product information in UI
            dataGridViewProduct.DataSource = dataSet.Tables["Product"];
        }

        private void populateRecords()
        {
            DatabaseLayer.DBOperation dbOperation = new DatabaseLayer.DBOperation();
            _dataSet = new DataSet();
            _dataSet = dbOperation.GetRecord();

            //Display the product information in UI
            dataGridViewProduct.DataSource = _dataSet.Tables["Product"];

            //Readonly column are not editable
            //dataGridViewProduct.ReadOnly = true;

            //--dataGridViewProduct.Columns[0].ReadOnly = true;
            dataGridViewProduct.Columns["ID"].ReadOnly = true;
        }

        private string toggleCaption(string captionText)
        {
            ButtonCaption caption = (ButtonCaption)Enum.Parse(typeof(ButtonCaption), captionText);
            string returnText = string.Empty;

            if (caption == ButtonCaption.Show)
            {
                returnText = _hide;
                groupBoxControls.Visible = true;
                dataGridViewProduct.Width = _dataGridViewDefault;
            }
            else
            {
                returnText = _show;
                groupBoxControls.Visible = false;
                dataGridViewProduct.Width = _dataGridViewExpand;
            }
            return returnText;
        }

        #endregion

       

       

        
    }
}

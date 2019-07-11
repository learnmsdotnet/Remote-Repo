using System;
using System.Windows.Forms;

namespace LearnProject
{
    //static class no need to create a object for this class
    static class UIHandler
    {
        //all members of the static class are static in nature
        public static void ClearControl(TextBox textBoxName, TextBox textBoxPrice, 
            DateTimePicker dateTimePickerMfgDate)
        {
            textBoxName.Clear();
            //textBoxName.Text = string.Empty;
            //textBoxName.Text = "";

            textBoxPrice.Clear();

            //dateTimePickerMfgDate.Format = DateTimePickerFormat.Custom;
            //dateTimePickerMfgDate.CustomFormat = " ";

            dateTimePickerMfgDate.Format = DateTimePickerFormat.Short;
            //dateTimePickerMfgDate.Value = DateTime.Today.AddDays(-1); //yesterday
            dateTimePickerMfgDate.Value = DateTime.Today.AddDays(0); //today
        }
        
        public static string DataGridViewProperties(DataGridView dataGridViewProperties, int formWidth)
        {
            try { 
                //set the first (id) column as read-only as the value is created in database
                dataGridViewProperties.Columns[Common.COLUMN_ID].ReadOnly = true;

                dataGridViewProperties.Columns[Common.COLUMN_ID].Width = 40;
                //total width of the form (700) - ID (40) - PRICE (100) - DATE (100) - ROW SELECTOR (60): 700 - 300 = 400
                //Width of Name column = total width of form - other columns (300)
                dataGridViewProperties.Columns[Common.COLUMN_NAME].Width = formWidth - 300;
                dataGridViewProperties.Columns[Common.COLUMN_PRICE].Width = 100;
                dataGridViewProperties.Columns[Common.COLUMN_DATE].Width = 100;

                //set the alignment for the dataGridView Columns
                dataGridViewProperties.Columns[Common.COLUMN_ID].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewProperties.Columns[Common.COLUMN_NAME].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridViewProperties.Columns[Common.COLUMN_PRICE].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewProperties.Columns[Common.COLUMN_DATE].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                //user should not add new rows to the grid directly
                dataGridViewProperties.AllowUserToAddRows = false;

                //no errors are identified, hence return null
                return null;
            }
            catch (Exception e) {
                return e.ToString();
            }
            
        }
    }
}

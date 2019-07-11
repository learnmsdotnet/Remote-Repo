using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnHRMS
{
    public partial class Employee : Form
    {
        //Ref: http://www.thedevelopertips.com/DotNet/WindowsFormsCSharp/Insert-upate-delete-in-datagridview-in-windows-forms-application.aspx?Id=76

        //SqlConnection: Accepts Connection String as input
        string _connectionString = ConfigurationManager.ConnectionStrings["ConnectLearnDB"].ToString();
        SqlConnection sqlConnection = null;
        //User clicked the 'Return' button in the screen
        bool isReturn = false;

        public Employee()
        {
            InitializeComponent();
        }

        public static string EmpID;

        public string Emp
        {
            get { return EmpID; }
            set { EmpID = value; }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            EmployeeInsert employeeInsertFormCollection =
                   Application.OpenForms["EmployeeInsert"] != null ? (EmployeeInsert)Application.OpenForms["EmployeeInsert"] : null;
            if (employeeInsertFormCollection != null)
                employeeInsertFormCollection.Hide();

            displayDataGridView();

            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Edit";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.HoverUnderline;
            Editlink.Text = "Edit";
            Editlink.Width = 60;
            Editlink.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewEmployee.Columns.Add(Editlink);

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.HoverUnderline;
            Deletelink.Text = "Delete";
            Deletelink.Width = 60;
            Editlink.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewEmployee.Columns.Add(Deletelink);

            this.setDataGridViewProperties();
        }

        private void displayDataGridView()
        {
            sqlConnection = new SqlConnection(_connectionString);
            SqlCommand sqlCommand;

            sqlCommand = new SqlCommand("select * from Employee", sqlConnection);
            sqlCommand.CommandType = CommandType.Text;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            dataGridViewEmployee.DataSource = dataSet.Tables[0];
            dataGridViewEmployee.AutoGenerateColumns = false;
            dataGridViewEmployee.AllowUserToAddRows = false;
        }

        private void setDataGridViewProperties()
        {
            dataGridViewEmployee.Columns["ID"].Width = 50;
            dataGridViewEmployee.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewEmployee.Columns["ID"].ReadOnly = true;

            dataGridViewEmployee.Columns["Name"].Width = 175;
            dataGridViewEmployee.Columns["Name"].ReadOnly = true;

            dataGridViewEmployee.Columns["Designation"].Width = 75;
            dataGridViewEmployee.Columns["Designation"].ReadOnly = true;

            dataGridViewEmployee.Columns["Age"].Width = 50;            
            dataGridViewEmployee.Columns["Age"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewEmployee.Columns["Age"].ReadOnly = true;

            dataGridViewEmployee.Columns["Address"].Width = 210;
            dataGridViewEmployee.Columns["Address"].ReadOnly = true;

            dataGridViewEmployee.Columns["Experience"].Width = 75;
            dataGridViewEmployee.Columns["Experience"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewEmployee.Columns["Experience"].ReadOnly = true;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sqlConnection = new SqlConnection(_connectionString);

            if (e.ColumnIndex == 6)
            {
                EmpID = Convert.ToString(dataGridViewEmployee.Rows[e.RowIndex].Cells["Id"].Value);

                this.Hide();
                EmployeeInsert employeeInsertFormCollection = 
                    Application.OpenForms["EmployeeInsert"] != null ? (EmployeeInsert) Application.OpenForms["EmployeeInsert"] : null;
                if (employeeInsertFormCollection != null)
                {
                    employeeInsertFormCollection.Close();
                    employeeInsertFormCollection.Dispose();
                }
                EmployeeInsert employeeInsert = new EmployeeInsert();
                employeeInsert.Show();
            }
            if (e.ColumnIndex == 7)
            {
                EmpID = Convert.ToString(dataGridViewEmployee.Rows[e.RowIndex].Cells["Id"].Value);
                SqlDataAdapter da = new SqlDataAdapter("delete from employee where Id = '" + EmpID + "'", sqlConnection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                displayDataGridView();
                dataGridViewEmployee.Refresh();
            }
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if ((e.CloseReason == CloseReason.UserClosing) && !isReturn)
            {
                MessageBox.Show("Please use 'Return' button in the screen to close", "ABC Corporation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //don't allow the form to get closed
                e.Cancel = true;
                return;
            }
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            //User has clicked the 'Return' button in the screen
            isReturn = true;

            this.Hide();

            EmployeeInsert employeeInsertFormCollection =
                   Application.OpenForms["EmployeeInsert"] != null ? (EmployeeInsert)Application.OpenForms["EmployeeInsert"] : null;
            if (employeeInsertFormCollection != null)
                employeeInsertFormCollection.Show();
            else
            {
                EmployeeInsert employeeInsert = new EmployeeInsert();
                employeeInsert.Show();
            }
        }
    }
}

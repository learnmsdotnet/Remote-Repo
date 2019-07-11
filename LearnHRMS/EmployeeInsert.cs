using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LearnHRMS
{
    public partial class EmployeeInsert : Form
    {
        public static string EmployeeID;

        string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectLearnDB"].ToString();
        SqlConnection sqlConnection = null;

        public EmployeeInsert()
        {
            if (Employee.EmpID != null)
                EmployeeID = Employee.EmpID;

            InitializeComponent();
        }

        private void EmployeeInsert_Load(object sender, EventArgs e)
        {
            //SqlConnection: Accepts Connection String as input
            sqlConnection = new SqlConnection(ConnectionString);

            if (!string.IsNullOrEmpty(Employee.EmpID))
            {
                try
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("Select * from employee where Id = '" + EmployeeID + "'", sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        if (sqlDataReader.Read())
                        {
                            //textBoxID.Text = sqlDataReader.GetValue(0).ToString();                            
                            //textBoxName.Text = sqlDataReader.GetValue(1).ToString();
                            //textBoxDescgnation.Text = sqlDataReader.GetValue(2).ToString();
                            //textBoxAge.Text = sqlDataReader.GetValue(3).ToString();
                            //textBoxAddress.Text = sqlDataReader.GetValue(4).ToString();
                            //textBoxExperience.Text = sqlDataReader.GetValue(5).ToString();

                            textBoxID.Text = sqlDataReader["ID"].ToString();
                            textBoxName.Text = sqlDataReader["Name"].ToString();
                            textBoxDesignation.Text = sqlDataReader["Designation"].ToString();
                            textBoxAge.Text = sqlDataReader["Age"].ToString();
                            textBoxAddress.Text = sqlDataReader["Address"].ToString();
                            textBoxExperience.Text = sqlDataReader["Experience"].ToString();
                        }
                    }
                }
                catch (SqlException sqle)
                {
                    MessageBox.Show(sqle.ToString(), "ABC Corporation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ABC Corporation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            //SqlConnection: Accepts Connection String as input
            sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("SProc_Insert_Update_Empinfo", sqlConnection);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add("@ID", SqlDbType.VarChar, 50).Value = textBoxID.Text.Trim();
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = textBoxName.Text.Trim();
            sqlCommand.Parameters.Add("@Designation", SqlDbType.NChar, 10).Value = textBoxDesignation.Text.Trim();
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = textBoxAge.Text.Trim();
            sqlCommand.Parameters.Add("@Address", SqlDbType.VarChar, 50).Value = textBoxAddress.Text.Trim();
            sqlCommand.Parameters.Add("@Experience", SqlDbType.Int).Value = textBoxExperience.Text.Trim();

            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Query Executed Successfully..", "ABC Corporation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message, "ABC Corporation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ABC Corporation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            //textBoxID.Text = "";
            //textBoxName.Text = "";
            //textBoxDescgnation.Text = "";
            //textBoxAge.Text = "";
            //textBoxAddress.Text = "";
            //textBoxExperience.Text = "";

            traverseControlsAndSetTextEmpty(this);

            MessageBox.Show("Query Executed Successfully..", "ABC Corporation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonViewData_Click(object sender, EventArgs e)
        {
            this.SendToBack();

            Employee employeeFormCollection =
                   Application.OpenForms["Employee"] != null ? (Employee)Application.OpenForms["Employee"] : null;
            if (employeeFormCollection != null)
                employeeFormCollection.Show();
            else
            {
                Employee employee = new Employee();
                employee.Show();
            }
        }

        private void traverseControlsAndSetTextEmpty(Control control)
        {
            foreach (TextBox c in control.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = String.Empty;
                traverseControlsAndSetTextEmpty(c);
            }
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;

namespace LearnWebProject.DBOperations
{
    public class GetDataCustomer
    {
        public DataSet Get() {

            DataSet dataSet = null;
            SqlDataAdapter sqlDataAdapter = null;
            SqlConnection sqlConnection = null;

            try {
                using (sqlConnection = new SqlConnection(Common.ConnectionString)) {

                    if (sqlConnection.State == ConnectionState.Closed)
                        sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand()) {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = Common.SPROC_SELECT_CUSTOMER;

                        //plan tsql statements
                        //sqlCommand.CommandType = CommandType.Text;
                        //sqlCommand.CommandText = "SELECT Name, Country FROM dbo.Customers";

                        sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                        dataSet = new DataSet();
                        sqlDataAdapter.Fill(dataSet, Common.DATA_TABLE_CUSTOMERS);
                    }
                    return dataSet;
                }
            }
            catch (Exception e) {

                throw e;
            }
            finally {

                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
        }
    }
}
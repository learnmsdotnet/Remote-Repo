using System;
using System.Data;
using System.Data.SqlClient;
using LearnWebProject.Model;

namespace LearnWebProject.DBOperations
{
    public class PostDataCustomer
    {
        //POST: use POST to update resources
        public bool POST(Customer customer) {

            SqlConnection sqlConnection = null;

            try{ 
                using (sqlConnection = new SqlConnection(Common.ConnectionString)) {

                    using (SqlCommand sqlCommand = new SqlCommand()) {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = string.Concat(Common.SPROC_UPDATE_CUSTOMER);

                        sqlCommand.Parameters.AddWithValue("@customerid", customer.CustomerId);
                        sqlCommand.Parameters.AddWithValue("@name", customer.Name); 
                        sqlCommand.Parameters.AddWithValue("@country", customer.Country);

                        if (sqlConnection.State == ConnectionState.Closed)
                            sqlConnection.Open();

                        sqlCommand.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception e) {
                throw e;
            }
            finally {
                //close the open connection (this is always closed because we are using using statement in sqlConnection)
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();               
            }
        }
    }
}
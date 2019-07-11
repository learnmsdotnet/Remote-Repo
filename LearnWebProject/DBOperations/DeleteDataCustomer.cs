using System;
using System.Data;
using System.Data.SqlClient;

namespace LearnWebProject.DBOperations
{
    public class DeleteDataCustomer
    {
        public string Delete(int customerid) {

            SqlConnection sqlConnection = null;

            try {
                using (sqlConnection = new SqlConnection(Common.ConnectionString)) {

                    using (SqlCommand sqlCommand = new SqlCommand()) {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = string.Concat(Common.SPROC_DELETE_CUSTOMER);

                        sqlCommand.Parameters.AddWithValue("@customerid", customerid);

                        if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();

                        sqlCommand.ExecuteNonQuery();

                        //return null, where there are no errors
                        return null;
                    }
                }
            }
            catch (Exception e) {
                throw e;
            }
            finally             {
                //close the open connection
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();

                //Ref: https://stackoverflow.com/questions/36079961/is-it-possible-to-put-only-one-option-on-a-ternary-expression
                //An alternative is to use default for your type 
                //(e.g. null for reference types or default(value_type) for value types. E.g:
                //expression == value ? (int?) null : SomeClass.SomeMethod();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace LearnWebProject.DBOperations
{
    public class PutDataCustomer
    {
        //PUT: for new resources
        public bool Put(string name, string country) {

            SqlConnection sqlConnection = null;

            try {
                using (sqlConnection = new SqlConnection(Common.ConnectionString)) {                   

                    using (SqlCommand sqlCommand = new SqlCommand()) {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.CommandText = string.Concat(Common.SPROC_INSERT_CUSTOMER);

                        sqlCommand.Parameters.AddWithValue("@name", name);
                        sqlCommand.Parameters.AddWithValue("@country", country);

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
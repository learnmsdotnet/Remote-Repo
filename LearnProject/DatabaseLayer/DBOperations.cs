using System.Data;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LearnProject.DatabaseLayer
{
    class DBOperations {

        public SqlDataAdapter RetrieveRecord(SqlDataAdapter sqlDataAdapter) {

            try { 
                SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);

                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = Common.SPROC_SELECTPRODUCT;

                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                SqlCommandBuilder sqlCommandBuilder = sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();

                return sqlDataAdapter;
            }
            catch (Exception e) {
                throw e;
            }
        }

        public string SaveChangesDatabase(SqlDataAdapter sqlDataAdapter, DataSet dataSet) {

            try {                
                return sqlDataAdapter.Update(dataSet, Common.DATA_TABLE_PRODUCTS).ToString();                
            }
            catch (Exception e) {                
                return e.ToString();
            }
        }
    }
}

using System.Data.SqlClient;
using System.Configuration;
using System;

namespace LearnCSharp.LearnADO.TableOperation
{
    class SelectInformationSchemaProc
    {
        public void ListAllStoredProceduresInDatabase()
        {
            //string ConnectionString = "Data Source=PC238395;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectLearnDB"].ToString();

            string sqlSelectQuery = "SELECT ROUTINE_NAME, ROUTINE_CATALOG FROM LEARNDBMP01.INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE'";

            //SqlConnection: Accepts Connection String as input
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();

            //SqlCommand: Accepts two parameter (a) the SQL query and (b) the SQL Connection object
            SqlCommand sqlCommand = new SqlCommand(sqlSelectQuery, sqlConnection);

            //To SQL reader object we are assigning the SQL Command Object
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //Iterate and get the data from the database
            while (sqlDataReader.Read())
            {
                //Read method will read the data from table row by row
                //Data: SProc_InsertProduct, LEARNDBMP01
                //From Read() method a row data will be returned in array format
                /*  [0] = SProc_InsertProduct
                 *  [1] = LEARNDBMP01            
                 */
                //Index position of the array in sqlDataReader object
                Console.WriteLine(sqlDataReader[0].ToString() + " -- " + sqlDataReader[1].ToString());

                //Alternate option, using the table column names with sqlDataReader object
                Console.WriteLine(sqlDataReader["ROUTINE_NAME"].ToString() + " -- " + sqlDataReader["ROUTINE_CATALOG"].ToString());
                
                //OP: SProc_InsertProduct - LEARNDBMP01 (first row)
            }

            //Close and Dispose database objects after use
            sqlCommand.Dispose();
            sqlConnection.Close();
        }
    }
}

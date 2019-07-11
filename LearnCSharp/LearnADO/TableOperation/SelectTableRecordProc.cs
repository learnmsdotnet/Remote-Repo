using System.Data.SqlClient;
using System.Configuration;
using System;

namespace LearnCSharp.LearnADO.TableOperation
{
    class SelectTableRecordProc
    {
        public void SearchProduct(string product)
        {
            //string ConnectionString = "Data Source=PC238395;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectLearnDB"].ToString();

            string sProcName = Constant.SPROC_SELECTSPECIFICPRODUCT;

            //SqlConnection: Accepts Connection String as input
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            //SqlCommand: Accepts two parameter (a) the SQL query and (b) the SQL Connection object
            SqlCommand sqlCommand = new SqlCommand(sProcName, sqlConnection);

            //It is a good and recommended practise to open the sqlConnection inside try/catch block to avoid any exception
            try
            {
                //Open the connection with SQL Server
                sqlConnection.Open();

                //The command type we are using to execute the query (Stored Procedure)
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                //To the command object we pass the parameters of Stored Procedure
                sqlCommand.Parameters.Add(new SqlParameter("@name", product));

                //To SQL reader object we are assigning the SQL Command Object
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                //Iterate and get the data from the database
                while (sqlDataReader.Read())
                {
                    //Read method will read the data from table row by row
                    //Data: 'Monitor 15'	$ 125.00	2019-02-02 00:00:00.000

                    //From Read() method a row data will be returned in array format
                    /*  [0] = Monitor 15
                     *  [1] = $ 125.00
                     *  [2] = 2019-02-02 00:00:00.000
                     */
                    //Index position of the array in sqlDataReader object
                    Console.WriteLine(sqlDataReader[0].ToString() + " -- " + sqlDataReader[1].ToString() + " -- " + sqlDataReader[2].ToString());

                    //Alternate option, using the table column names with sqlDataReader object
                    Console.WriteLine(sqlDataReader["Name"].ToString() + " -- " + sqlDataReader["Price"].ToString() + " -- " + sqlDataReader["Date"].ToString());

                    //OP: Monitor 15	$ 125.00	2019-02-02 00:00:00.000 (only one row will be returned due to the sproc)
                }
            }
            catch (SqlException sqle) //specifically handling the sql related exception
            {
                Logger.LogSQLExceptions(sqle);
            }
            catch (Exception e) //global exception handler
            {
                Logger.LogSQLExceptions(e);
            }
            finally
            {
                //Close and Dispose database objects after use
                sqlCommand.Dispose();
                sqlConnection.Close();
            }
        }
    }
}

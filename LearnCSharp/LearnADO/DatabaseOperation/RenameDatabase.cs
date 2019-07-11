using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace LearnCSharp.LearnADO.DatabaseOperation
{
    class RenameDatabase
    {
        public void RenameTheDatabase()
        {
            //string ConnectionString = "Data Source=PC238395;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectLearnDB"].ToString();

            string sqlQuery = "ALTER DATABASE LEARNDBMP02 MODIFY NAME = LEARNDBMP04";

            //SqlConnection: Accepts Connection String as input
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            //SqlCommand: Accepts two parameter (a) the SQL query and (b) the SQL Connection object
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            //It is a good and recommended practise to open the sqlConnection inside try/catch block to avoid any exception
            try
            {
                //Open the connection with SQL Server
                sqlConnection.Open();

                //Execute the query in the database
                sqlCommand.ExecuteNonQuery();

                //Write the information to console
                Console.WriteLine("Database Renamed Successfully");
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

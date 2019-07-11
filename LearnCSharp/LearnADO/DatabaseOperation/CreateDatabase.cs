using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace LearnCSharp.LearnADO.DatabaseOperation
{
    class CreateDatabase
    {
        public void CreateNewDatabase()
        {
            //string ConnectionString = "Data Source=PC238395;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectLearnDB"].ToString();

            string sqlQuery = "CREATE DATABASE [LEARNDBMP02]";

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

                ////Perform some other calcuations
                //int a = 5;
                //int b = 0;
                //int c = 0;
                //c = a / b;

                //Write the information to console
                Console.WriteLine("Database Created Successfully");
            }
            catch (SqlException sqle) //specifically handling the sql related exception
            {
                logApplicationExceptions(sqle);
            }
            catch (Exception e) //global exception handler
            {
                logApplicationExceptions(e);
            }
            finally
            {
                //Close and Dispose database objects after use
                sqlCommand.Dispose();
                sqlConnection.Close();
            }           
        }

        /// <summary>
        /// Log the error information to file/datasource and share user friendly message with user
        /// </summary>
        /// <param name="e"></param>
        private void logApplicationExceptions(Exception e)
        {
            //Assign the error message to a string variable
            string message = e.Message;

            //Check the message type a give a user friedly information with the business/end user
            if (message.StartsWith("A network-related or instance-specific error"))
                Console.WriteLine("Unable to establish connection with database, please conact application support team");
            else
                Console.WriteLine("Execption occured, please conact application support team");

            File.WriteAllText("error.log",
                string.Concat("Error Information: "
                    , DateTime.Now
                    , Environment.NewLine
                    , "------------------------------------------------------------"
                    , Environment.NewLine
                    , e.ToString()));
        }
    }
}

using System;
using System.Configuration;
using System.Data.SqlClient;

namespace LearnCSharp.LearnADO.TableOperation
{
    class InsertRecordStoredProcedure
    {
        public void InsertNewRecordToTable()
        {
            //string ConnectionString = "Data Source=PC238395;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectLearnDB"].ToString();

            string sProcName = "SProc_InsertProduct";

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
                sqlCommand.Parameters.Add(new SqlParameter("@name", "Monitor 15"));
                sqlCommand.Parameters.Add(new SqlParameter("@price", "$ 125.00"));
                sqlCommand.Parameters.Add(new SqlParameter("@date", "02-Feb-2019"));

                //Used to store the return value from Stored Procedure
                int queryOutput;

                //Execute the query in the database
                queryOutput = sqlCommand.ExecuteNonQuery();

                //Write the information to console
                //  return value from executeNonQuery is greater than or equal to zero some thing is in correct
                if (queryOutput > 0)
                    Console.WriteLine("Record successfully inserted to table");
                else
                    Console.WriteLine("Unable to inserted record in table");
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

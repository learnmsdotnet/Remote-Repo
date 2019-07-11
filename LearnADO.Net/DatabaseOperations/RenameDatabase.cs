using System.Data.SqlClient;
using System.Configuration;

namespace LearnADO.Net.DatabaseOperations
{
    class RenameDatabase
    {
        public void RenameTheDatabase()
        {
            //string ConnectionString = @"Data Source=PC212454\PC212454;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            //string ConnectionString = @"Data Source=PC238395;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectLearnDB"].ToString();

            string SqlQuery = "ALTER DATABASE LEARNDBMP02 MODIFY NAME = LEARNDBMP04";

            //SqlConnection: Accepts Connection String as input
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            //SqlCommand: Accepts Query String and SqlConnection
            SqlCommand sqlCommand = new SqlCommand(SqlQuery, sqlConnection);

            //Good practise to open sqlConnection inside try/catch block to avoid exception
            try
            {
                sqlConnection.Open();

                //run the query string in the database
                sqlCommand.ExecuteNonQuery();

                //write information to console
                System.Console.WriteLine("Database Renamed Successfully");
            }
            catch (SqlException sqle)
            {
                //write error information to output
                System.Console.WriteLine("Error Information: {0}", sqle);
            }
            finally
            {
                //Dispose and Close the object after use
                sqlCommand.Dispose();
                sqlConnection.Close();
            }
        }
    }
}

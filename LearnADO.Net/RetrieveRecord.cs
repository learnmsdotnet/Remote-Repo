using System.Data.SqlClient;

namespace LearnADO.Net
{
    class RetrieveRecord
    {
        public void RetrieveRecordSelect()
        {
            //string ConnectionString = @"Data Source=PC212454\PC212454;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            string ConnectionString = @"Data Source=PC238395;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";

            string SqlQuery = "SELECT * FROM Student";

            //SqlConnection: Accepts Connection String as input
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();

            //SqlCommand: Accepts Query String and SqlConnection
            SqlCommand sqlCommand = new SqlCommand(SqlQuery, sqlConnection);

            //To SqlDataReader object assign the SqlCommand object
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //Iterate and get the data from database
            while (sqlDataReader.Read())
            {
                System.Console.WriteLine(
                    sqlDataReader[0].ToString() + " " +
                    sqlDataReader[1].ToString() + " " +
                    sqlDataReader[2].ToString());
            }

            //Dispose and Close the object after use
            sqlCommand.Dispose();
            sqlConnection.Close();            
        }
    }
}

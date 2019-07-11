using System.Data.SqlClient;
using System.Configuration;
using System.IO;

// compile with:   
// /r:Microsoft.SqlServer.Smo.dll  
// /r:Microsoft.SqlServer.ConnectionInfo.dll  
// /r:Microsoft.SqlServer.Management.Sdk.Sfc.dll  

namespace LearnADO.Net.TableOperations
{
    class CreateTable
    {
        public void CreateNewTable()
        {
            //string ConnectionString = @"Data Source=PC212454\PC212454;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            //string ConnectionString = @"Data Source=PC238395;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectLearnDB"].ToString();

            string SqlQuery =
                @"CREATE TABLE dbo.Products (
	                    ID	 INT			IDENTITY (1, 1) NOT NULL
	                , [Name] NVARCHAR(50)	NULL
	                , Price  NVARCHAR(50)	NULL
	                , [Date] DATETIME		NULL
	                CONSTRAINT pk_id PRIMARY KEY (ID)
                  );";

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
                System.Console.WriteLine("Database Created Successfully");
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


        public void CreateNewTableSqlScriptFile()
        {
            ////string ConnectionString = @"Data Source=PC212454\PC212454;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            ////string ConnectionString = @"Data Source=PC238395;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            //string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectLearnDB"].ToString();

            //string SqlQuery = "";

            //FileInfo file = new FileInfo("C:\\myscript.sql");
            //string script = file.OpenText().ReadToEnd();
            

            ////SqlConnection: Accepts Connection String as input
            //SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            //Server server = new Server(new ServerConnection(sqlConnection));
            //server.ConnectionContext.ExecuteNonQuery(script);

            ////SqlCommand: Accepts Query String and SqlConnection
            //SqlCommand sqlCommand = new SqlCommand(SqlQuery, sqlConnection);

            ////Good practise to open sqlConnection inside try/catch block to avoid exception
            //try
            //{
            //    sqlConnection.Open();

            //    //run the query string in the database
            //    sqlCommand.ExecuteNonQuery();

            //    //write information to console
            //    System.Console.WriteLine("Database Created Successfully");
            //}
            //catch (SqlException sqle)
            //{
            //    //write error information to output
            //    System.Console.WriteLine("Error Information: {0}", sqle);
            //}
            //finally
            //{
            //    //Dispose and Close the object after use
            //    sqlCommand.Dispose();
            //    sqlConnection.Close();
            //}
        }
    }
}

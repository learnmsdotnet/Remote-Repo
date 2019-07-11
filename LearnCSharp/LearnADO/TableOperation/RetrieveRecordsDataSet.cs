using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LearnCSharp.LearnADO.TableOperation
{
    class RetrieveRecordsDataSet
    {
        public DataSet DataSetOperations()
        {
            //string ConnectionString = "Data Source=PC238395;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectLearnDB"].ToString();

            //Query to populate the DataSet
            string tsqlQuery = Constant.TSQL_SELECT_STUDENT;

            //to the DataAdaptor we are passing two parameters (i) SQL Query and (ii) Connection String
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(tsqlQuery, ConnectionString);

            //create new dataset to hold the data locally
            DataSet dataSet = new DataSet();

            //Data from DataAdaptor is loaded to the DataSet (local storage area)
            sqlDataAdapter.Fill(dataSet, "Student");

            return dataSet;
        }        
    }
}

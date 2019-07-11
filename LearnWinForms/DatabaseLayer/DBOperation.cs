using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWinForms.DatabaseLayer
{
    class DBOperation
    {
        public DataSet InsertRecord(string name, string cost, string mfgDate)
        {
            //string ConnectionString = "Data Source=PC238395;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectLearnDB"].ToString();

            string tsqlQuery = Constant.TSQL_SELECT_PRODUCT;

            //create new dataset to hold the data locally
            DataSet dataSet = new DataSet();

            //to the DataAdaptor we are passing two parameters (i) SQL Query and (ii) Connection String
            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(tsqlQuery, ConnectionString))
            {
                //Data from DataAdaptor is loaded to the DataSet (local storage area)
                sqlDataAdapter.Fill(dataSet, "Product");

                //Adding new row to the dataset
                DataRow dataRow = dataSet.Tables["Product"].NewRow();
                dataRow["Name"] = name;
                dataRow["Price"] = cost;
                dataRow["Date"] = mfgDate;

                //adding the datarow to the dataset which has mapping to the table (product) 
                dataSet.Tables["Product"].Rows.Add(dataRow);
            }
            return dataSet;
        }

        public DataSet GetRecord()
        {
            //string ConnectionString = "Data Source=PC238395;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectLearnDB"].ToString();

            //query string to get the records of dbo.product table
            string tsqlQuery = Constant.TSQL_SELECT_PRODUCT;

            //declare a dataSet to hold the records of dbo.product table 
            DataSet dataSet = null;

            //to the DataAdaptor we are passing two parameters (i) SQL Query and (ii) Connection String
            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(tsqlQuery, ConnectionString))
            {
                //create new dataset to hold the data locally
                dataSet = new DataSet();

                //Data from DataAdaptor is loaded to the DataSet (local storage area)
                sqlDataAdapter.Fill(dataSet, "Product");
            }

            return dataSet;
        }
    }
}

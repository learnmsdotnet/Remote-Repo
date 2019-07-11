﻿using System.Data.SqlClient;
using System.Configuration;

namespace LearnCSharp.LearnADO.TableOperation
{
    class RetrieveRecord
    {
        public void RetrieveRecordSelect()
        {
            //string ConnectionString = "Data Source=PC238395;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectLearnDB"].ToString();

            string sqlSelectQuery = "SELECT * FROM STUDENT";

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
                //Data: 1	    Rama	English
                //From Read() method a row data will b returned in array format
                /*  [0] = 1
                 *  [1] = Rama
                 *  [2] = English
                 */
                System.Console.WriteLine(
                    sqlDataReader[0].ToString() + " - " +
                    sqlDataReader[1].ToString() + " - " +
                    sqlDataReader[2].ToString());

                //OP: 1 - Rama - English (first row)
            }

            //Close and Dispose database objects after use
            sqlCommand.Dispose();
            sqlConnection.Close();
        }
    }
}
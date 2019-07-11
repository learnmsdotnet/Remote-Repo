﻿using System;
using System.Configuration;
using System.Data.SqlClient;

namespace LearnCSharp.LearnADO.TableOperation
{
    class CreateTable
    {
        public void CreateNewTable()
        {
            //string ConnectionString = "Data Source=PC238395;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False";
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectLearnDB"].ToString();

            string sqlQuery = @"
            CREATE TABLE LEARNDBMP01.dbo.Products(
                  ID     INT            IDENTITY(1, 1) NOT NULL
                , [Name] NVARCHAR(50)   NULL
                , Price  NVARCHAR(50)   NULL
                , [Date] DATETIME       NULL

                CONSTRAINT pk_id PRIMARY KEY(ID)
            )";

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
                Console.WriteLine("Table created successfully");
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

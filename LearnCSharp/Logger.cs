using System;
using System.IO;

namespace LearnCSharp
{
    public static class Logger
    {
        /// <summary>
        /// Log the error information to file/datasource and share user friendly message with user
        /// </summary>
        /// <param name="e"></param>
        public static void LogSQLExceptions(Exception e)
        {
            //Assign the error message to a string variable
            string message = e.Message;

            //Check the message type a give a user friedly information with the business/end user
            if (message.StartsWith("A network-related or instance-specific error"))
                Console.WriteLine("Unable to establish connection with database, please conact application support team");
            else
                Console.WriteLine("Exception occured, please conact application support team");

            //Prepare error information to write to file
            string consoliateData = string.Concat(
                "Error Information: "
                , DateTime.Now
                , Environment.NewLine
                , e.ToString()
                , Environment.NewLine
                , "------------------------------------------------------------"
                , Environment.NewLine);
            
            //Error infomration will be added to the file rather than recreating the file
            File.AppendAllText("error.log", consoliateData);
        }
    }
}

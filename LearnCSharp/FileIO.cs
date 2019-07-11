using System.IO;

namespace LearnCSharp
{
    public class FileIO
    {
        string scopeOfVariable = "I am visible to all the methods of this class";

        /// <summary>
        /// File handling - FileExist
        /// </summary>
        public void UnderstandFileExists()
        {
            string path = @"D:\Users\Maruthi\Desktop\training\Files\log1.txt";

            //Check of the given file exists in drive or not
            if (File.Exists(path))
            {
                System.Console.WriteLine("the log file exists in the given path");
            }
            else
            {
                System.Console.WriteLine("file does not exists in the given path");
            }

            //make the output console window visible for the user
            System.Console.ReadKey();
        }

        /// <summary>
        /// File handling - ReadAllLines
        /// </summary>
        public void UnderstandFileReadAllLines()
        {
            string path = @"D:\Users\Maruthi\Desktop\training\Files\fileReadAllLines.log";

            //Create a string array to store the data which we will be reading from the file
            string[] fileData;

            fileData = File.ReadAllLines(path);

            System.Console.WriteLine(fileData[0]);
            System.Console.WriteLine(fileData[1]);
            System.Console.WriteLine(fileData[2]);
            System.Console.WriteLine(fileData[3]);
            System.Console.WriteLine(fileData[4]);
            System.Console.WriteLine(fileData[5]);
            System.Console.WriteLine(fileData[6]);
            System.Console.WriteLine(fileData[7]);
            System.Console.WriteLine(fileData[8]);
        }

        /// <summary>
        /// File handling - ReadAllText
        /// </summary>
        public void UnderstandFileReadAllText()
        {
            string path = @"D:\Users\Maruthi\Desktop\training\Files\fileReadAllLines.log";

            string fileData;

            fileData = File.ReadAllText(path);

            System.Console.WriteLine(fileData);
        }

        /// <summary>
        /// File handling - Copy file
        /// </summary>
        public void UnderstandFileCopy()
        {
            string sourcePath = @"D:\Users\Maruthi\Desktop\training\Files\fileCopySource.log";

            string destiantionPath = @"D:\Users\Maruthi\Desktop\training\Files\fileCopyDestination.log";

            File.Copy(sourcePath, destiantionPath);

            System.Console.ReadKey();
        }

        /// <summary>
        /// File handling - Delete file
        /// </summary>
        public void UnderstandFileDelete()
        {
            string path = @"D:\Users\Maruthi\Desktop\training\Files\fileToDelete.log";

            if (File.Exists(path))
                File.Delete(path);
            else
                System.Console.WriteLine("file does not exists in the path");

            System.Console.ReadKey();
        }

        /// <summary>
        /// Understanding StreamReader Class
        /// </summary>
        public void StreamReaderInFiles()
        {
            //define the path of the file which we want to read
            string path = @"D:\Users\Maruthi\Desktop\training\Files\fileStreamReader.log";

            scopeOfVariable = scopeOfVariable + "Hello";

            //we are opening the file and assigning to Stream Reader object
            using (StreamReader streamReader = File.OpenText(path))
            {
                //we define a new string to hold the data
                string readData = string.Empty;

                while ((readData = streamReader.ReadLine()) != null)
                {
                    System.Console.WriteLine(readData);
                }

                streamReader.Close();
            }

            System.Console.ReadLine();
        }

        /// <summary>
        /// Understanding StreamWriter Class
        /// </summary>
        public void StreamWriterInFiles()
        {
            //define the path of the file which we want to write
            string path = @"D:\Users\Maruthi\Desktop\training\Files\fileStreamWriter.log";

            //we are opening the file and assigning to Stream Reader object
            using (StreamWriter streamWriter = File.AppendText(path))
            {
                streamWriter.WriteLine("Hello, Good Morning !!");
                streamWriter.Close();

                System.Console.WriteLine(File.ReadAllText(path));
            }

            System.Console.ReadLine();
        }
    }
}

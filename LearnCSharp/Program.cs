using LearnCSharp.Collections.GenericCollections;
using LearnCSharp.Collections.StandardCollections;
using System;
using System.Data;

namespace LearnCSharp
{
    class Program
    {
        //main() is the entry point for project execuition
        static void Main(string[] args)
        {
            //To keep breakpoint use F9 (key) keyboard

            //#region <tab> (code segment for region will be automatically created)
            #region "Understanding ADO.Net"

            //DataSet Operations
            LearnADO.TableOperation.RetrieveRecordsDataSet retrieveRecordsDataSet = new LearnADO.TableOperation.RetrieveRecordsDataSet();
            DataSet dataSet = retrieveRecordsDataSet.DataSetOperations();
            Console.WriteLine(dataSet.GetXml());

            //understanding reader object in detail
            LearnADO.TableOperation.RetrieveRecord retrieveRec = new LearnADO.TableOperation.RetrieveRecord();
            retrieveRec.RetrieveRecordSelect();

            //get records from table based on search condition
            string serachProduct = "Monitor 15";
            LearnADO.TableOperation.SelectTableRecordProc selectTableRecordProc = new LearnADO.TableOperation.SelectTableRecordProc();
            selectTableRecordProc.SearchProduct(serachProduct);

            //get data from the system table (list all procedures of the database)
            LearnADO.TableOperation.SelectInformationSchemaProc selectInformationSchemaProc = new LearnADO.TableOperation.SelectInformationSchemaProc();
            selectInformationSchemaProc.ListAllStoredProceduresInDatabase();

            //copy all data from a table to another table
            LearnADO.TableOperation.InsertIntoTable insertIntoTable = new LearnADO.TableOperation.InsertIntoTable();
            insertIntoTable.CopyTableDataToAnotherTable();

            //insert record to table using stored procedure
            LearnADO.TableOperation.InsertRecordStoredProcedure insertRecordStoredProcedure = new LearnADO.TableOperation.InsertRecordStoredProcedure();
            insertRecordStoredProcedure.InsertNewRecordToTable();

            //database manupulations
            string sqlQueryCreateDatabase = "CREATE DATABASE [LEARNDBMP02]";
            string sqlQueryRenameDatabase = "ALTER DATABASE LEARNDBMP02 MODIFY NAME = LEARNDBMP04";
            string sqlQueryDeleteDatabase = "DROP DATABASE [LEARNDBMP04]";
            string message = "Action Completed Successfully";

            //table manipulations
            string sqlQueryCreateTable = @"
            CREATE TABLE LEARNDBMP01.dbo.Products(
                  ID     INT            IDENTITY(1, 1) NOT NULL
                , [Name] NVARCHAR(50)   NULL
                , Price  NVARCHAR(50)   NULL
                , [Date] DATETIME       NULL

                CONSTRAINT pk_id PRIMARY KEY(ID)
            )";
            string sqlQueryRenameTable = "Exec sp_rename 'Products', 'Accessories'";
            string sqlQueryAddColumn = "ALTER TABLE Accessories ADD Stock NVARCHAR(50)";
            string sqlQueryModifyColumn = "ALTER TABLE Accessories ALTER COLUMN Stock INT";
            string sqlQueryRemoveColumn = "ALTER TABLE Accessories DROP COLUMN Stock";
            string sqlQueryRemoveTable = "DROP TABLE Accessories";

            string sqlQueryInsertRecord = "INSERT INTO dbo.Products (NAME, Price, [Date]) VALUES ('LED TV', '$ 120.00', '27-January-2019')";

            LearnADO.DatabaseManipulation databaseManipulation = new LearnADO.DatabaseManipulation();

            //adding record to table
            databaseManipulation.DatabaseAction(sqlQueryInsertRecord, message);

            //table manipulation
            databaseManipulation.DatabaseAction(sqlQueryRemoveTable, message);
            databaseManipulation.DatabaseAction(sqlQueryRemoveColumn, message);
            databaseManipulation.DatabaseAction(sqlQueryModifyColumn, message);
            databaseManipulation.DatabaseAction(sqlQueryAddColumn, message);
            databaseManipulation.DatabaseAction(sqlQueryRenameTable, message);
            databaseManipulation.DatabaseAction(sqlQueryCreateTable, message);            

            //database manupulation
            databaseManipulation.DatabaseAction(sqlQueryCreateDatabase, message);
            databaseManipulation.DatabaseAction(sqlQueryRenameDatabase, message);
            databaseManipulation.DatabaseAction(sqlQueryDeleteDatabase, message);

            //adding record to table
            LearnADO.TableOperation.InsertTableRecord insertTableRecord = new LearnADO.TableOperation.InsertTableRecord();
            insertTableRecord.InsertNewRecordToTable();

            LearnADO.TableOperation.InsertTableRecordParameterized insertTableRecordParameterized= new LearnADO.TableOperation.InsertTableRecordParameterized();
            insertTableRecordParameterized.InsertNewRecordToTable();

            //table manipulation
            LearnADO.TableOperation.RenameTable renameTable = new LearnADO.TableOperation.RenameTable();
            renameTable.RenameExistingTable();

            LearnADO.TableOperation.CreateTable createTable = new LearnADO.TableOperation.CreateTable();
            createTable.CreateNewTable();

            //...

            //database manipulation
            LearnADO.DatabaseOperation.DeleteDatabase deleteDatabase = new LearnADO.DatabaseOperation.DeleteDatabase();
            deleteDatabase.RemoveDatabase();

            LearnADO.DatabaseOperation.RenameDatabase renameDatabase = new LearnADO.DatabaseOperation.RenameDatabase();
            renameDatabase.RenameTheDatabase();

            LearnADO.DatabaseOperation.CreateDatabase createDatabase = new LearnADO.DatabaseOperation.CreateDatabase();
            createDatabase.CreateNewDatabase();

            //table reading
            LearnADO.TableOperation.RetrieveRecord retrieveRecord = new LearnADO.TableOperation.RetrieveRecord();
            retrieveRecord.RetrieveRecordSelect();
            
            #endregion

            #region     "Collections"

            SortedDictionaryCollection sortedDictionaryCollection = new SortedDictionaryCollection();
            sortedDictionaryCollection.GenericSortedDictionary();

            HashSetCollection hashSetCollection = new HashSetCollection();
            hashSetCollection.StoreElementsToHashSet();

            StackCollection stackCollection = new StackCollection();
            stackCollection.StackManipulations();

            QueueCollection queueCollection = new QueueCollection();
            queueCollection.QueueManipulation();
            
            DictionaryCollection dictionaryCollections = new DictionaryCollection();
            dictionaryCollections.DictionaryOperations();

            SortedListCollection sortedListCollection = new SortedListCollection();
            sortedListCollection.SortedList();

            ArrayListCollection arrayListCollections = new ArrayListCollection();
            arrayListCollections.AddArrayListElement();

            ListCollection listCollection = new ListCollection();

            Console.ReadLine();

            #endregion

            #region "File Handing in C#"

            FileIO fileIO = new FileIO();

            fileIO.StreamWriterInFiles();
            fileIO.StreamReaderInFiles();

            fileIO.UnderstandFileDelete();
            fileIO.UnderstandFileCopy();
            fileIO.UnderstandFileReadAllText();
            fileIO.UnderstandFileReadAllLines();
            fileIO.UnderstandFileExists();

            #endregion

            #region "Understanding Arrays"

            Arrays objArrays = new Arrays();
            objArrays.MultiDiamentionalArray();

            objArrays.AccessingValuesFromArray();
            objArrays.AcceptValuesFromUserAndDisplayOutput();
            objArrays.ArrayDeclarationAndInitilization();

            #endregion

            #region "StringBuilder and their methods"

            StringBuilders objStringBuilders = new StringBuilders();
            objStringBuilders.StringBuilderFunctions();

            #endregion

            #region "Data types: Value and Reference type"

            ValueTypeReferenceType objValueTypeReferenceType = new ValueTypeReferenceType();
            objValueTypeReferenceType.UnderstandingReferenceType();
            //objValueTypeReferenceType.UnderstandingValueType();

            #endregion

            #region "Understanding Loop Statements"

            LoopStatements objLoopStatements = new LoopStatements();
            objLoopStatements.UnderstandingForLoop();
            objLoopStatements.UnderstandingForLoopCondStmt();
            objLoopStatements.UnderstandingWhileLoop();
            objLoopStatements.WhileLoopWithBreakStmt();
            objLoopStatements.UnderstandingDoWhileLoop();
            objLoopStatements.UnderstandingDoWhileLoopFalseCondition();
            objLoopStatements.DoWhileLoopWithBreakStmt();

            #endregion

            #region "Understanding Conditional Statements"

            //switch statement
            ConditionalStatements objConditionalStatements = new ConditionalStatements();
            objConditionalStatements.SwitchStatement();

            objConditionalStatements.GoToInSwitchStatement();

            #endregion

            #region "How to call a Class"

            //<name of class> <object of the class> <new - allocating memory> <name of the class>
            //MyClass: is class --> Blue Print --> car
            //myClass: is object --> Benz, BMW, Audi, Ford, etc..
            //MyClass myClass = new MyClass();
            MyClass objMyClass = new MyClass();
            //Lets set the value to a property and they get the value from the property
            int valueFromProperty = 0;
            //Set the value to the property
            objMyClass.Counter = 4;
            //Get the value from the property
            valueFromProperty = objMyClass.Counter;
            Console.WriteLine(valueFromProperty);

            objMyClass.PropVariable = 6;                //(setter)
            Console.WriteLine(objMyClass.PropVariable); //(getter) the return value of the private class variable _propVariable

            //try to see if we are able to access 'Count' and private in scope
            //objMyClass.Count; (error since its scope is private)

            //Create an object of newly created class (AnotherClass)
            //Any new class created will have default methods available
            AnotherClass objAnotherClass = new AnotherClass();
            //objAnotherClass.

            //Properties with only getter
            //objMyClass.MarkSheetGrade = "India"; (not possible since it is getter only property)

            //Properties with only setter
            objMyClass.CollegeName = "National Engineering College";
            //Console.WriteLine(objMyClass.CollegeName); get accessor is not exposed for this propery hence data can not be viewed

            #endregion

            #region "Call - Understanding Variables"

            //Understand C# variables and their declarations
            UnderstandVariables();

            //Understanding C# datatypes in detail
            UnderstandDataTypes();

            #endregion

            //Purpose of command: to display the output visiable to user until user selects any key in the keyboard
            Console.ReadKey();            
        }
        
        #region "Understanding Variable"

        /// <summary>
        /// UnderstandVariables(): this method is created to under C# variables and their declarations
        /// </summary>
        private static void UnderstandVariables()
        {
            //declaring a variable
            //todo: declare a string data type and store the value 'Hello' in it
            //understanding: we have declared a variable with the name as message and stored the value hello to it
            string message = "Welcome";

            //todo: display the value of the variable to the output window
            Console.WriteLine(message);

            //todo: how to declare multiple variable and initialize it
            //int varA, varB, varC = 4;
            //(or)
            /*
            int varA = 4;
            int varB = 4;
            int varC = 4;
            */
            int varA, varB, varC;
            varA = 4;
            varB = 2;
            varC = 4;

            //C# is case sensitive varC and varc are different variables
            //varC and varc are two different variables

            //Declaring variable in multiple lines
            int varD, varE,
                varF,
                varG = 4;
            //int varD, varE, varF, varG = 4; (the above and this representation are same)

            //variable assignment (passing the value of 1 variable to another variable)
            int varH = 4;

            int varI = varH;

            //invalid variable assignment
            string varJ = "Hello";

            //int varK = varJ; //not allowed by the compiler - Build error/Compile time error

            int varL; //Declaration of a variable
            int varM = 4; //Declaration and assignment of a variable

            int varN;
            //int varO = varN;

            int varP;
            //varP = "Hello"; //Build error: Cannot convert string to int

            //todo: call the method with the DisplayHello()
            //          understand the difference between F10 (step over) and F11 (step into)
            DisplayHello();
        }

        /// <summary>
        /// when a method of function does not return any value it is called a procedure
        /// </summary>
        private static void DisplayHello()
        {
            Console.WriteLine("Hello");
        }

        /// <summary>
        /// Understanding C# datatypes in detail
        /// </summary>
        private static void UnderstandDataTypes()
        {
            string stringVar = "Hello World";
            int intVar = 400;
            float floatVar = 10.2f;
            char charVar = 'A';
            bool boolVar = true;

            //char data type the storage is 1 byte (8 bits)
            //1 byte = 8 bits
            //unicode char: 2 bytes (16 bytes) of data
            //non-unicode char: 4 bytes (32 bytes) of data [Language set of Chinese, Japanese, Spanish etc..)
            //char charA = '-1'; //compile time error

            //Datatype's have their capacity. 
            int i = 1234567890;
            Int32 j = 1234567890;

            int k = -400;

            //Byte can hold 256 chars (from 0 to 255)
            //This byte data type is also called as unsigned integer (unsigned --> only positive numbers)
            Byte byteA = 1;

            //To store a negative value (or negative and positive numeric value) we need to use singed integer
            //The total size is 8 bits and it can accomodate 256 values the range is from -128 to 127
            sbyte sByteA = -4;


        }

        #endregion
                
    }
}

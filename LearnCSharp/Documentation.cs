using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class Documentation
    {
        private void Document()
        {
            // Single Line Comment

            /* 
             * Multi 
             * Line 
             * Comment 
             */

            /*
             * --> Object Oriented Programming Lang. developed by MS
             * --> Basic, Pascal, COBOL, Fortran 77, C, Ada, Smalltalk etc.. (Structural/Procedural Prog Lang)
             * --> C++ (OOPs) - Real life Entity/Scenario, C#, Java, Phyton, Ruby etc..
             * 
             * till 2001 (VB6 was dominating the world)
             * 1st version - .Net Framework 1.0 - 2002
             * 
             * C# is mainly a prog Lang for Server Side (Backend)
             * Code resides in the server
             * 
             * Working with C#
             *  1. Microsoft .Net Framework
             *  2. IDE (Visual Studio)
             *  
             * Till VB it was a programming lang, from .Net it is considerd as Platform (VB, C#, J#, F#, Python etc..)
             * 
             * .Net Framework (two type of applications can be creted)
             *   1. Windows (WPF, Windows Form, Libraries (dll/components), Console)
             *   2. Web
             *   3. Mobile
             *   
             * Extension of C#  
             *   1. .cs
             *   
             * Editor
             *   1. Easy navigation to project files
             *   2. Debugger
             *   3. Intellisense Support
             *   4. Easy 3rd Party Integration
             *   5. Rapid build and development
             *   
             * Key Words: reserved words (compiler has special meaning)
             *   1. We can not use reserved words as the name of our variable, class, interface etc..
             *   
             * Modifiers:
             *   1. modify type or type members
             *   It allows/prevents certain part of the program being modified by other part of prog
             *      --> abstract, async, const, event, extern, new override, partial, readonly, sealed, static...
             *      
             * Access Specifiers:
             *   Where the access specifiers apply: class, method, properties, fields
             *   --> public
             *   --> private
             *   --> internal
             *   --> protected
             *   
             *   public: any body can access this program with in the assembly or outside the assembly
             *   private: applies restriction. access is granted only with in class/structure
             *   internal: this can be accessed only with in the assembly. This is a default access specifier (if no access
             *      specifier is menthoned)
             *   protected: program which can be accessed with in the class or the class that derives it
             *   
             *   Statements: they are the keywords which compiler understands
             *    if, else, switch, case, do, for, foreach, in, while, break, continue, default, goto, return, yeild,
             *    throw, try, catch, finally, checked, unchecked, fixed, lock
             *   If defined as keywords they can not be used as liternal/variables
             *   In Visual studio editor they are highlighted a blue
             *   
             *   Method Parameters: parameters, ref, out
             *   
             *   Contextual Keywords: they are keywords but used in certain context. (They are not reserved words but can 
             *      be used as names/identifiers). Even though they are keywords they are not auto highlighted to blue color
             *   
             *   Understading my First Project:
             *      1. File that is available with our project is 'Program.cs' (Class file)
             *      2. Main() -- methods are represented using Open and Closed paranthesis
             *          Main method is the starting point of a project and there should be 1 main method per project
             *          
             *   Day 03: (topics)
             *      Variables
             *      Data Types in C#
             *      Compile time and Run time error
             *      Using breakpoints with F10 and F11 keys (Build and Debug purpose)
             *      
             *  Variable: Variable is nothing but a name given to a data to hold a particular value
             *  
             *  F6 is to build a project and F5 is to run a project
             *  Build: the code will compile and check for compilation errors - F6
             *  
             *  Run: execuiting the application code (view the output of the project) - F5
             *  Run: Build + Run 
             *  
             *  F11: using the key F11 we are able to run the execuition of the project line by line
             *  F10: used bypass internal execuition of method
             *  
             *  Syntax of a variable and its declaration"
             *      <datatype> <variable name>;
             *      <datatype> <variable name> = <value>;
             *  
             *  DataTypes: It tells C# compiler what kind of value a variable can hold. C# has many in-built datatypes for different kinds of data
             *  
             *  Class: Class is a blue print of an Object
             *      Ferrari --> Luxury Car Segment
             *      Other cars in Luxury Car Segment --> Audi, BMW, Benz etc..
             *      Properties/Char's for Luxury Car: Speed, Color, Shape, Interior etc.. (qualities -- properties)
             *  
             *  Object: Every single car (Audi, Benz, BMW, Cadillac etc..) are objects of the class Luxury car
             *      
             *  What a class can contain inside: 
             *      Variable declaration, 
             *      Constructor
             *      Properties
             *      Methods etc..
             *  
             *  Field: a variable that is declared inside a class is called Field (E.g: count)
             *      Its a class level variable
             *      The members will have private access specifier
             *      They are used with properties
             *      
             *  Constructor: 2 types: 
             *      Parameterized Constructor
             *      Parameterless Constructor
             *      <access_specifier> <name of the class>
             *      It will be called when we create an instance of the class
             *      
             *  Syntax of defining access specifier for a method
             *      {access modifier} {return type} Method Name (parameterType parameterName)
             *      {
             *      
             *      }
             *      
             *      public void MyMethod(int parameter1, string parameter2)
             *      {
             *      
             *      }
             *
             *  Properties are mainly getters and setters for the class
             *  They encapsulate the private field
             *  get{} -- retrieve the underlying value
             *  set{} -- to set the value to underlying field
             *  private variable field is not accessable outside the class, to acccess we use properties
             *  They are classified under two types auto-implemented property and default property
             *  Auto Implemented Property: Made available from version 3.0
             *      the concept of defining a private variable is not available
             *      the backing field (count the private variable in our eg class) is auto created by the compiler
             *  
             *  if statements: (Conditional Stmt)
             *  make some decission in the program, flow of the program is defined
             *      if statement
             *      if..else statement
             *      switch statement
             *      Ternary operator (:?)
             *  
             *  //if the below boolen expression is evalued to be false then do nothing (simply go to the next line in the program)
             *  if (boolen expression)
             *  {
             *      //execute the code in this block if the expression is evaluated to be true
             *  }
             *  
             *  ternary operator: there is a special type of decission making operator in C# called as ternary operator (?:)
             *  
             *  <Boolean Expression> ? <First Statement> : <Second Statement>
             *  it is of 3 parts:
             *  1. <Boolean Expression> --> Expression to be evaluated
             *  2. <First Statement>    --> Statement which will be returned if the expression is evaluated to be true
             *  3. <Second Statement>   --> Statement which will be returned if the expression is evaluated to be false
             *  
             *  Switch Statement: Braching statement
             *  
             *  switch (expression)
             *  {
             *      case <value1>
             *          //code block
             *          break;
             *      case <value2>
             *          //code block
             *          break;
             *      case <value3>
             *          //code block
             *          break;
             *      default
             *          //code block
             *          break;
             *  }
             *  
             *  switch statement can nested inside another switch statement
             *  
             *  looping statements:
             *      for loop
             *      while loop and
             *      do-while loop
             *      
             *   for loop: 
             *      for (variable initialization; condition; steps)
             *      {
             *          //code that will be execuited as long as the <condition> inside the loop is satisfied
             *      }
             *   
             *   variable initilization: declare and initialize variable used for condition evaluation
             *   condition: boolean express which returns true/false
             *   steps: incremental or decremental part 
             *   
             *   while loop: will not be executed unless the condition is true (if false exit from while loop)
             *      while (boolean expression)
             *      {             
             *          //execute the lines of code as long as the condition or boolean expression is true
             *      }
             *      
             *   do while loop: here the condition will be executed once even if the given condition is not satisfied/false
             *      do 
             *      {
             *          //code block to execute
             *          
             *      } while (boolean expression)
             *
             * 
             *  Value Type and Reference Type:
             *      Data types are categorized mainly based on their storage value in memory (RAM)
             *      C# data type classified in 3 types:
             *          1. Value type
             *          2. Reference type
             *          3. Pointer type
             *          
             *  Value Type: A data type (like int) holds data (value) with in its own memory space (variable 
             *      contains the value directly)
             *      
             *  int i = 100;
             *  
             *  Pass by value: When we pass a variable from one method to another method, the system
             *      cretes a separate copy of the variable in another method. If value gets changed in one method
             *      that won't affect the value of variable of another method
             *      
             *  Reference Type: Unlike value types reference type don't store the values directly. Instead it
             *      stores the addess when the value is being stored. (ref type contains pointer to another memory 
             *      that holds the data)
             *      
             *  Operators: Mathematical or Logical Operations
             *      Arithmetic Operator
             *      Relational Operator
             *      Logical Operator
             *      Bitwise Operator
             *      Assignment Operator
             *      
             *  String: strings are nothing but array of characters
             *  
             *  string a = "india";
             *  String a = "india";
             *  
             *  String Builder: String is immutable, ie. once defined/declared can not be changed. This behavious will hinder the performance of the application/system
             *      which we are developing
             *      
             *  Dynamic object: String Builder --> which allows the expansion of the chars in string. For each of the updated it does not allocate new objects
             *      rather dynamically expands the memory to accomodate the modified string
             *      
             *  Arrays: Declaring an Array
             *      Collection of the variable of same data type
             *      
             *  int a = 1;  //first variable
             *  int b = 2;  //second variable
             *  ..
             *  ..
             *  ..
             *  int zzz = 1000; //thousandth variable
             *  
             *  First index position in an array always starts with Zero
             *  
             *  C# has two types of array, Single Diamentional Array and Multi Diamentional Array
             *  
             *   --> Initialization and Declaration
             *   --> Inline Style
             *   --> Storing values to array
             *   --> Accessing values from array
             *   --> Single Diamentional array
             *   --> Multi Diamentional array
             *          Multi. Diam. array are used to store more than one row of data
             *          They are also called as rectangular arrays as they have the same length for each row
             *          They are of two diam, three diam.. etc
             *          single dim: x   (line)
             *          two diam: x, y  (graph)
             *          three diam: x, y, z (cube)
             *          they are represented by , inside [ (single rectangle brackets) ]    "[, , ,]" - 4 diam array
             *          to store and access elements inside a multidiamentional array we need to use nested loops
             *   
             *   Files: I/O operation
             *      opening - accessing the file from a specific location and open in read, write, read-write mode
             *      reading - data is read from the file
             *      writing - data is written to the file and by default all the existing content will be removed from the file and new content is written
             *      appending - involves writing data to the file, the only diffrent is the existing data in the file will not be overwritten. New
             *          data will be added to the end of the file
             *      
             *      File.Exists
             *      File.ReadAllLines
             *      File.ReadAllText
             *      File.Copy
             *      File.Delete
             *      
             *      Stream 
             *          StreamReader
             *          StreamWriter
             *   
             *      Streams are used to read and write data to the file. Stream is an additional layer which is created between the application and file
             *      They are normally used to read data from large files. By using streams data from large files can be broken down into small chunks of data and 
             *      sent to the stream
             *      
             *      The data which is in small chunks can be then read by the program/application
             *      
             *      Stream write: Data --> Stream --> File
             *      Stream read: Data --> File to Stream --> Read by the application
             *   
             *   Collections: Collections are similar to Arrays, it provides a more flexible ways to work with group of objects
             *      ArrayList
             *      Stack
             *      Queues
             *      Hastable
             *      SortedList and
             *      BitArray
             *      
             *   ArrayList: Collection of similary Array datatypes in C#, they are dynamic in nature when compared to arrays
             *   In array's we need to define the number of elements that the array can hold at the time of array declaration but 
             *      it is not the condition with Arraylist
             *   Elements can be added or removed from arraylist at any time point in time
             *   
                Collections:

                1.	The .NET framework provides specialized classes for data storage and retrieval
                2.	Collections help the developer to perform several operations on objects like the store, update, delete, retrieve, search, sort etc.
                3.	They can also be called as enhancement to arrays
                4.	They are of three types:
                    a.	Standard
                    b.	Generic and 
                    c.	Concurrent

                5.	Standard Collections: (Now deprecated)
                    a.	They are found under the namespace: System.Collections
                    b.	Examples of Standard Collection: ArrayList, Hashtable, Queue and Stack

                6.	Generic Collections: 
                    a.	They are found under the namespace: System.Collections.Generic
                    b.	Generic collections are more flexible and are the preferred way to work with data (they enhance code reuse, type safety and performance)
                    c.	Examples of generic collections include Dictionary<T, T>, List<T>, Queue<T>, SortedList<T>, and Stack<T>
                    (or)
                    List, LinkedList, HashSet, SortedSet, Dictionary, SortedDictionary, SortedList

                7.	Concurrent collections:
                    a.	They are found under the namespace: System.Collections.Concurrent
                    b.	They provide collection classes for thread-safe operations
                    c.	Now multiple threads will not create problem for accessing the collection items
                    d.	Examples of generic collections include BlockingCollection<T>, ConcurrentDictionary<T, T>, ConcurrentQueue<T>, and ConcurrentStack<T>
                    (or)
                    BlockingCollection, ConcurrentBag, ConcurrentStack, ConcurrentQueue, ConcurrentDictionary
                        Partitioner, Partitioner, OrderablePartitioner

                ArrayList:

                1.	It is a dynamic array. 
                2.	An ArrayList automatically expands as data is added. Unlike arrays, an ArrayList can hold data of multiple data types. 
                3.	Elements in the ArrayList are accessed via an integer index. 
                4.	Indexes are zero based (Index always starts with zero)
                5.	Indexing of elements and insertion and deletion at the end of the ArrayList takes constant time. 
                6.	Inserting or deleting an element in the middle of the dynamic array is more costly. It takes linear time.

                List:

                1.	List is a strongly typed list of objects that can be accessed by index. 
                2.	It can be found under System.Collections.Generic namespace.

                SortedList:

                1.	SortedList<T, T> represents a collection of key/value pairs that are sorted.

                Dictionary:

                1.	A dictionary, is a collection of unique keys and a collection of values 
                2.	where each key is associated with one value. 
                3.	Retrieving and adding values is very fast. 
                4.	Dictionaries take more memory because for each value there is also a key

                Queues:

                1.	A queue is a First-In-First-Out (FIFO) data structure. 
                2.	The first element added to the queue will be the first one to be removed. 
                3.	Queues may be used to process messages as they appear or serve customers as they come. 
                4.	The first customer which comes should be served first.

                Stacks:

                1.	A stack is a Last-In-First-Out (LIFO) data structure. 
                2.	The last element added to the queue will be the first one to be removed. 
                3.	The C language uses a stack to store local data in a function. The stack is also used when implementing calculators

                HashSet<T>:

                1.	HashSet class can be used to store, remove or view elements. 
                2.	It does not store duplicate elements. 
                3.	It is suggested to use HashSet class if you have to store only unique elements. 
                4.	It is found in System.Collections.Generic namespace.

                SortedSet<T>:

                1.	C# SortedSet class can be used to store, remove or view elements. 
                2.	It maintains ascending order and does not store duplicate elements. 
                3.	It is suggested to use SortedSet class if you have to store unique elements and maintain ascending order. 
                4.	It is found in System.Collections.Generic namespace

                SortedDictionary<TKey, TValue>:

                1.	C# SortedDictionary<TKey, TValue> class uses the concept of hashtable. 
                2.	It stores values on the basis of key. 
                3.	It contains unique keys and maintains ascending order on the basis of key. 
                4.	By the help of key, we can easily search or remove elements. 
                5.	It is found in System.Collections.Generic namespace

                ADO.Net - Database
                Adv Concepts
                OOPS

                ADO.Net (ActiveX Data Objects)

                Its an data bridge that manages the bridge between applicatin and the database
                Accessing, Selecting, Saving, Deleting the database with in the database

                ADO.NET is a set of classes that allows to connect and work with data sources like 
                    databases, 
                    excel file, 
                    access file, 
                    xml file, 
                    mysql, 
                    sql or notepad. 
                To connect application with different sources of database you need to know the right
                    Data Provider. 
                There are several Data Providers in ADO.NET that connects with different types of sources.
                
                A list of ADO.NET Data Providers:

                1. SQL Server:	
                    Namespace: System.Data.SqlClient 
                    Description: This Data Provider is used to connect with SQL Server Database

                2. OLEDB:
                    Namespace: System.Data.OleDb 
                    Description: This Data Provider is used to connect with SQL Server, Oracle and Microsoft Jet (MS Access) 
                     
                3. ODBC:
                    Namespace: System.Data.Odbc 
                    Description: It is used to connect with SQL Server, Oracle and Microsoft Databases(.mdb).
                
                4. Data Provider for Oracle	
                    Namespace: System.Data.OracleClient
                
                5. EntityClient Provider
                    Namespace: Model (EDM) applications. Uses the System.Data.EntityClient namespace.
                    Description: Provides data access for Entity Data 

                6. SQL Server Compact 4.0
                    Namespace: Uses the System.Data.SqlServerCe namespace.
                    Description: Microsoft SQL Server Compact 4.0. 

                Core Components of .Net Data Providers:
                ---------------------------------------
                1. Connection – This component is used for connecting to the database. The base class is DbConnection.
                
                2. Command – This component executes SQL query against the data source. The base class is DbCommand.
                
                3. DataReader – It reads data from data source. It accesses data read-only and forward-only. The base class is DbDataReader.
    
                4. DataAdapter – It invokes dataset and resolves updates with the data source. The base class is DbDataAdapter.

                Stating ADO.Net: 04/15
                ----------------------
                01. Introduction
                02. Install SQL Server
                03. ADO.Net Program

                04. Connection, Command, DataReader - Connect to database using ADO.Net
                05. Database: Create, Select, Rename and Delete
                06. Table: Create, Rename, Alter and Delete
                07. Insert records uisng simple and parameterized query

                08. Stored Procedure: Creation and Execuition

                09. Results: Data Reader, Data Set Vs Data Adaptor, Data Views


                Connecting Database from Visual Studio:
                ---------------------------------------
                1. View --> Server Explorer
                2. Right Click Data Connection --> Create New SQL Server Database
                3. Enter (SQL Server Name) and Database Name (LEARNDBMP01)
                (New Connection is established with a new database: LEARNDBMP01)
                4. Adding a table to the database 
                Query: table script: (run the script)

                (refer tsql_CreateTable.sql)

                Other method is using design view:
                1. Expand Database (LEARNDBMP01) -- right click on table -- Add New Table
                2. Copy paster the tsql script
                3. Right Click (Student table) -- Show table data, fill some data

                Getting the Connection String:
                ------------------------------
                Right Click Database -- Properties
                Connection String: Data Source=PC238395;Initial Catalog=LEARNDBMP01;Integrated Security=True;Pooling=False

                Database and tables are ready also we have the connection string:
                Next step, retrieve the data using the ADO.Net commands

                Data Readers:
                -------------
                Allows us to retrieve the data from the database in read-only or forward-only mode
                    (means: with reader only display and read of data is possible. Update and Delete is not possible)
                If we want to perform Update and Delete operations on the retrieved data then Data Adaptor need to be used

                DataSet:
                --------
                Behaves like a real database, and represents the complete set of data in the table

                DataAdaptor:
                ------------
                They are used for controlling the DataSet, it provides a communication between the DataSet and DataSource.
                It can also be used to update DataSource with DataSet
                
                C# Front end (UI) <--------> DataSet <--------> DataAdaptor <--------> DataSource (SQL Server -> Database, Tables etc..)

                C# Front end (UI) <--------> DataSet (Disconnected Architecture)

                Properties of DataAdaptor:
                --------------------------
                a. DeleteCommand: Used for DELETING records from DataSource
                b. InsertCommand: Used for ADDING NEW records from DataSource
                c. SelectCommand: Used for SELECTING records from DataSource
                d. UpdateCommand: Used for UPDATING records from DataSource
                e. TableMapping: Mapping actual database tables and datasets

                Methods of DataAdaptor:
                -----------------------
                a. Fill: Fill records from DataAdaptor to DataSet
                b. Update: Updates DataSource with DataSet

                ToDo:
                -----
                Project using Windows application (win forms) --> in progress (dataGridView) -- 1 session
                Project using Web application (asp.net web forms) --> (gridview) -- 3 classes
                Project using MVC web application (asp.net mvc) --> (webGrid) -- 3 classes

                Phone book Project
                .Net Interview FAQ (.Net, SQL, HTML, CSS and JS)
                Mock Interview

                MVC: Model View and Controller
                Pattern for the presentation layer

                routing: (map) consists of three things (name, url and defaults)
                    name: any user friendly name given to the route 
                    url: {controller}/{action}/{id}
                    defaults: controller = "Home", action = "Index", id = UrlParameter.Optional

                versioning: 5.2.7.0 --> Major Minor Build Version
             */
        }

    }//class: Documentation
}

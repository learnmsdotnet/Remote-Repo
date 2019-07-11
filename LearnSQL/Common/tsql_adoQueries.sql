USE LEARNDBMP01;
GO

--Class: RetrieveRecord.cs
SELECT * FROM [STUDENT];
GO

--Class: CreateDatabase.cs
--Syntax: CREATE DATABASE <Name of the database to Create>
CREATE DATABASE LEARNDBMP02;

--Class: RenameDatabase.cs
--Syntax: ALTER DATABASE <Database to Rename> MODIFY NAME = <New Name for the database>;
ALTER DATABASE LEARNDBMP02 MODIFY NAME = LEARNDBMP04;

--Class: DeleteDatabase.cs
--Syntax: DROP DATABASE <Name of the database to delete>
DROP DATABASE LEARNDBMP04;

--Class: CreateTable.cs
USE LEARNDBMP01;
GO 

CREATE TABLE LEARNDBMP01.dbo.Products (
	  ID	 INT			IDENTITY (1, 1) NOT NULL
	, [Name] NVARCHAR(50)	NULL
	, Price  NVARCHAR(50)	NULL
	, [Date] DATETIME		NULL
	CONSTRAINT pk_id PRIMARY KEY (ID)
);
GO

--Class: RenameTable.cs
--Rename a tables to a different name
--sp_rename: is a system stored procedure
--Exec sp_rename <name of the existing table>, <name of the new table>
Exec sp_rename 'Products', 'Accessories';
GO

--Class: AlterTableAddColumn.cs
--Add a new Column with name as 'Stock' (nvarchar(50), null) to the table accessories
ALTER TABLE Accessories ADD Stock NVARCHAR(50);

ALTER TABLE Accessories 
	ADD Stock NVARCHAR(50);

--Class: AlterTableModifyColumn.cs
--Modify the existing datatype of the column [Stock] from nvarchar(50) to int
ALTER TABLE Accessories ALTER COLUMN Stock INT;

ALTER TABLE Accessories 
	ALTER COLUMN Stock INT;

--Class: AlterTableDropColumn.cs
--Delete a column from existing table
ALTER TABLE Accessories DROP COLUMN Stock;

ALTER TABLE Accessories 
	DROP COLUMN Stock;

--Class: DeleteTable.cs
--Syntax: DROP TABLE <tableName>;
DROP TABLE Accessories;

--Insert record to SQL database using 
--	Simple SQL queries (less secure)
--	Parameterized SQL queries
--	Copy 1 table record to another table record

--Simple SQL queries (Insert record)
/*
Syntax: INSERT INTO <table_name> (
			<column_name>
			, <column_name>
			, ... )
		VALUES (
			<value>
			, <value>
			, ...);

		INSERT INTO <table_name>
		VALUES (
			<value>
			, <value>
			, ...);
*/	

INSERT INTO dbo.Products (
	[Name]
	, Price
	, [Date])
VALUES (
	'LED TV'
	, '$ 120.00'
	, '27-January-2019');
GO

INSERT INTO dbo.Products ([Name], Price, [Date]) VALUES ('LED TV', '$ 120.00', '27-January-2019');
GO

SELECT * FROM dbo.Products;

--Parameterized Query
INSERT INTO dbo.Products ([Name], Price, [Date]) VALUES (@name, @price, @date);

--01. Declare the query variable
DECLARE @name nvarchar(50)
DECLARE @price nvarchar(50)
DECLARE @date datetime

--02.Initialize the variable
SET @name = 'Optical Mouse'
SET @price = '$ 15.00'
SET @date = '04-Apr-2019'

--03. Execute the insert command
INSERT INTO dbo.Products ([Name], Price, [Date]) VALUES (@name, @price, @date);

CREATE TABLE LEARNDBMP01.dbo.Items (
	  ID	 INT			IDENTITY (1, 1) NOT NULL
	, [Name] NVARCHAR(50)	NULL
	, Price  NVARCHAR(50)	NULL
	, [Date] DATETIME		NULL
	CONSTRAINT pk_id_Items PRIMARY KEY (ID)
);
GO

--Copying data from one table to another table

/*
Syntax: 
INSERT INTO <Destination table>
	(<column Name>
	, <column Name>
	, <column Name>)
SELECT <column Name>
	, <column Name>
	, <column Name>	
FROM <Source table>;	
*/

INSERT INTO dbo.Items ([Name], Price, [Date]) SELECT [Name], Price, [Date] FROM dbo.Products;
GO

SELECT * FROM dbo.Items;
GO

--Removes all the records/rows from the table
--TRUNCATE is a DDL (Data Definition Language)
--WHERE clause can not be used with TRUNCATE command
--Identity column is reset to its seed value if table contains any identity column
--TRUNCATE uses less transaction space when compared with DELETE
--TRUNCATE is faster than DELETE

--Syntax: TRUNCATE TABLE <table name>;

TRUNCATE TABLE dbo.Items;
GO

--DELETE is a DML command
--WHERE condition can be used with DELETE command
--It maintains the log, slower than TRUNCATE command
--DELETE removes row from table one at a time and records an entry in the transaction log for each of the deleted row
--Identity of the column keep DELETE retain the identity value

DELETE FROM dbo.Items;
GO

INSERT INTO dbo.Items ([Name], Price, [Date]) VALUES ('Lazer Drive', '$ 62.00', '04-September-2019');
GO

--Set the identity value of the table (DBCC Commands are available to reseed table identity values/reset table identity)

--Syntax: DBCC CHECKIDENT (<table name>, RESEED, <reseed value>);

DBCC CHECKIDENT (Items, RESEED, 0);

DBCC CHECKIDENT (Items, RESEED, 29);
/*Output: 
Checking identity information: current identity value '12'.
DBCC execution completed. If DBCC printed error messages, contact your system administrato
*/

--List all the Stored Procedures in a database
SELECT * FROM LEARNDBMP01.INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE';
GO

SELECT ROUTINE_NAME FROM LEARNDBMP01.INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE';
GO

SELECT ROUTINE_NAME, ROUTINE_CATALOG FROM LEARNDBMP01.INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE';
GO

SELECT [Id], [Name], Price, [Date] FROM dbo.Products ORDER BY [ID];

SELECT [Id], [Name], Price, [Date] FROM dbo.Products ORDER BY [Name];

SELECT * FROM dbo.Student;

SELECT * FROM dbo.Items;

INSERT INTO dbo.Products ([Name], Price, [Date]) VALUES ('LED TV', '$ 120.00', '27-January-2019');

SELECT * FROM LEARNDBMP01.dbo.Products;

SELECT * FROM LEARNDBMP01.dbo.Products WHERE ID = 2011;

SELECT * FROM LEARNDBMP01.dbo.Employee (NoLock);

Exec dbo.SProc_SelectProduct;

SELECT * FROM LEARNDBMP01.dbo.Customers (NoLock);

DROP TABLE dbo.Customers;

CREATE TABLE dbo.Customers (
	[CustomerID]	INT	IDENTITY (1, 1) NOT NULL
	, [Name]		VARCHAR(100)	NOT NULL
	, [Country]		VARCHAR(50)		NOT NULL
	, CONSTRAINT [PK_Customers_CustomerID] PRIMARY KEY CLUSTERED ([CustomerID] ASC)
);
GO
--OP: Commands completed successfully.

INSERT INTO dbo.Customers
SELECT 'Rama', 'India'
UNION ALL
SELECT 'Sita', 'India'
UNION ALL
SELECT 'Dharma', 'United States'
UNION ALL
SELECT 'Padma', 'India Bangalore'
UNION ALL
SELECT 'Prithvi', 'United States'
UNION ALL
SELECT 'Harsha', 'United States'
UNION ALL
SELECT 'Santhana', 'Qatar'
UNION ALL
SELECT 'Padma S', 'India Coimbatore'
UNION ALL
SELECT 'Karthik', 'United States'
UNION ALL
SELECT 'Priya', 'Denmark'
UNION ALL
SELECT 'Vijay', 'Australia';
GO
--OP: (11 rows affected)

INSERT INTO dbo.Customers
SELECT 'Renga', 'Addis Abba'
UNION ALL
SELECT 'Gopal', 'Russia';
GO

INSERT INTO dbo.Customers
SELECT 'Sara', 'India';
--OP: (2 rows affected)

SELECT * FROM LEARNDBMP01.dbo.Customers (NoLock);

--TRUNCATE TABLE LEARNDBMP01.dbo.Customers;


UPDATE Products SET [NAME] = @name, Price = @price, [Date] = @date WHERE ID = @id
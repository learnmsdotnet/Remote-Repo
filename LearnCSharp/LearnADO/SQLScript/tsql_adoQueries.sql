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
CREATE TABLE dbo.Products (
	  ID	 INT			IDENTITY (1, 1) NOT NULL
	, [Name] NVARCHAR(50)	NULL
	, Price  NVARCHAR(50)	NULL
	, [Date] DATETIME		NULL
	CONSTRAINT pk_id PRIMARY KEY (ID)
);

--Class: AlterTable.cs
Exec sp_rename 'Products', 'Accessories'
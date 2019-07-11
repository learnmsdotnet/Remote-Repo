--USE [LEARNDBMP01];
--GO

--Create table [Student]

CREATE TABLE [dbo].[Student] (
	  [Id]		INT				NOT NULL
	, [Name]	NVARCHAR (50)	NULL
	, [Subject] NVARCHAR (50)	NULL
	, PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

/*
https://www.sqlshack.com/what-is-the-difference-between-clustered-and-non-clustered-indexes-in-sql-server/

A clustered index defines the order in which data is physically stored in a table. 
Table data can be sorted in only way, therefore, there can be only one clustered 
index per table. In SQL Server, the primary key constraint automatically
creates a clustered index on that particular column.
*/

--USE [LEARNDBMP01];
--GO
					
--EXECUTE sp_helpindex [Student];
--GO 

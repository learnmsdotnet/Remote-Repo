--Create database
CREATE DATABASE [DEMOCSHARP];
GO

--Change it to the current database
USE [DEMOCSHARP];
GO

--Create table (internally they have rows and columns to store data)
CREATE TABLE EMPLOYEE (
	ID			INTEGER NOT NULL PRIMARY KEY
	, FirstName VARCHAR (10)
	, LastName	VARCHAR (10)
	, Salary	DECIMAL (10, 2)
	, City		VARCHAR (20)
);
GO

create table employee1(id integer not null primary key, firstname varchar(10), lastname varchar(10), salary decimal(10, 2), city varchar(20));
CREATE TABLE EMPLOYEE1 (ID INTEGER NOT NULL PRIMARY KEY, FirstName VARCHAR (10), LastName VARCHAR (10), Salary DECIMAL (10, 2), City VARCHAR (20));

--Adding data to the table (Insert data to table rows)
INSERT INTO EMPLOYEE VALUES (2, 'Monu', 'Rathore', 4789, 'Agra');
GO

--Other syntax for insert statement
INSERT INTO EMPLOYEE (ID, FirstName, LastName, Salary, City) VALUES (2, 'Monu', 'Rathore', 4789, 'Agra');
GO

INSERT INTO EMPLOYEE (ID) VALUES (2);
GO

INSERT INTO EMPLOYEE VALUES (4, 'Rahul', 'Saxena', 5567.59, 'London');
GO

INSERT INTO EMPLOYEE VALUES (5, 'Prabath', 'Kumar', 4467, 'Bombay');
GO

INSERT INTO EMPLOYEE VALUES (6, 'Ramu', 'Singh', 3456.78, 'Jammu Kashmir');
GO

--Display the data from the table
SELECT * FROM dbo.EMPLOYEE;
GO

SELECT * FROM EMPLOYEE;
GO

SELECT ID, FirstName, LastName, Salary, City FROM EMPLOYEE;
GO

SELECT ID, FirstName FROM EMPLOYEE;
GO

SELECT * FROM DEMOCSHARP.dbo.EMPLOYEE;
GO

SELECT ID, FirstName, LastName, Salary, City FROM EMPLOYEE;
GO

--Update row of a table
UPDATE EMPLOYEE SET
	  FirstName = 'Sara'
	, LastName  = 'Ethan'
	, Salary	= 45.85
	, City		= 'Phoenix'
WHERE ID		= 2;
GO

UPDATE EMPLOYEE SET
	  Salary	= 50.05
WHERE ID		= 2;
GO

--Remove specific values from a table
DELETE FROM EMPLOYEE WHERE ID = 2;
GO
--Exec SProc_Update_Customer @customerid = 1, @name = N'Muruga', @country = N'India';
--GO

USE [LEARNDBMP01];
GO

--CREATE PROCEDURE dbo.SProc_Update_Customer (
ALTER PROCEDURE dbo.SProc_Update_Customer (
	@customerid int
	, @name varchar(100)
	, @country varchar(50))
AS
BEGIN
	UPDATE dbo.Customers 
	SET [Name] = @name
	, Country = @country
	WHERE CustomerID = @customerid;
END;
GO
/*
--Drop/Delete StoredProcedure

DROP PROCEDURE dbo.SProc_Update_Customer;
GO


--Stored Procedure Output

USE [LEARNDBMP01]
GO


*/
--Exec SProc_Insert_Customer @name = N'Meenakshi', @country = N'India';
--GO

--USE [LEARNDBMP01];
--GO

CREATE PROCEDURE dbo.SProc_Insert_Customer (
	@name varchar(100)
	, @country varchar(50))
AS
BEGIN
	INSERT INTO dbo.Customers (
		[Name]
		, Country)
	VALUES (
		@name
		, @country);
END;
GO
/*
--Drop/Delete StoredProcedure

DROP PROCEDURE SProc_Insert_Customer;
GO


--Stored Procedure Output

USE [LEARNDBMP01]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[SProc_Insert_Customer]
		@name = N'Meenakshi',
		@country = N'India'

SELECT	'Return Value' = @return_value

GO

0: No errors

*/
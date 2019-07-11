--Exec SProc_Delete_Customer @customerid = 4;
--GO

USE [LEARNDBMP01];
GO

CREATE PROCEDURE dbo.SProc_Delete_Customer (
	@customerid int)
AS
BEGIN
	DELETE FROM dbo.Customers 
	WHERE CustomerID = @customerid;
END;
GO
/*
--Drop/Delete StoredProcedure

DROP PROCEDURE SProc_Delete_Customer;
GO


--Stored Procedure Output

USE [LEARNDBMP01]
GO


*/
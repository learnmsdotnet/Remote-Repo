--USE [LEARNDBMP01];
--GO

CREATE PROCEDURE SProc_Select_Customers
--ALTER PROCEDURE SProc_Select_Customers
AS
BEGIN
    SELECT 
		[CustomerId]
        ,[Name]
		, Country
    FROM 
        dbo.Customers
    ORDER BY 
        [CustomerId]
END;

--Exec dbo.SProc_Select_Customers

--DROP PROCEDURE dbo.SProc_Select_Customers
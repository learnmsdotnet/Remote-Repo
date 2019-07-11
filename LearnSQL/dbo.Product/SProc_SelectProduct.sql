--USE [LEARNDBMP01];
--GO

CREATE PROCEDURE SProc_SelectProduct
AS
BEGIN
    SELECT 
		[Id]
        ,[Name]
		, Price
		, [Date]
    FROM 
        dbo.Products
    ORDER BY 
        [ID]
END;

--Exec dbo.SProc_SelectProduct

--DROP PROCEDURE dbo.SProc_SelectProduct
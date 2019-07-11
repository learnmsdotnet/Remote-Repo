USE [LEARNDBMP01];
GO

ALTER PROCEDURE SProc_SelectProduct
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
        [Name];
END;

--Exec dbo.SProc_SelectProduct
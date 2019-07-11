--USE [LEARNDBMP01];
--GO

CREATE PROCEDURE dbo.SProc_SelectSpecificProduct (
	@name NVARCHAR(50))
AS
BEGIN
    SELECT 		
        [Name]
		, Price
		, [Date]
    FROM 
        dbo.Products
    WHERE
        [Name] = @name;
END;
GO

--Exec dbo.SProc_SelectSpecificProduct @name = N'Hard Disk'
--Exec dbo.SProc_SelectSpecificProduct @name = N'Optical Mouse'
--Exec dbo.SProc_SelectSpecificProduct @name = N'Monitor 15'
--Exec SProc_InsertProduct @name = N'Hard Disk', @price = N'$ 50.00', @date = '26-Nov-2018';
--GO

USE [LEARNDBMP01];
GO

CREATE PROCEDURE SProc_InsertProduct (
	@name nvarchar(50)
	, @price nvarchar(50)
	, @date date)
AS
BEGIN
	INSERT INTO dbo.Products (Name, Price, [Date]) VALUES (@name, @price, @date);
END
GO

/*
--Drop/Delete StoredProcedure

DROP PROCEDURE InsertProduct;
GO


--Stored Procedure Output

USE [LEARNDBMP01]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[SProc_InsertProduct]
		@name = N'USB Drive',
		@price = N'$ 10.00',
		@date = '02-Jan-2019'

SELECT	'Return Value' = @return_value

GO

0: No errors

*/
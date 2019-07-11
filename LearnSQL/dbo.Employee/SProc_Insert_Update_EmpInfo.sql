--USE [LEARNDBMP01];
--GO

CREATE procedure [dbo].[SProc_Insert_Update_Empinfo] (   
--ALTER procedure [dbo].[SProc_Insert_Update_Empinfo] (   
	@ID varchar(50)
	, @Name varchar(50)
	, @Designation nchar(10)
	, @Age INT
	, @Address varchar(100)
	, @Experience INT   
)   
As   
BEGIN   
	DECLARE @Count INT
	SET @Count = (SELECT COUNT ('X') FROM Employee WHERE ID = @ID)  
  
	 IF(@Count = 0)  
	 BEGIN  
		INSERT INTO dbo.Employee (
			[Name]
			, Designation
			, Age
			, [Address]
			, Experience) 
		VALUES (
			@Name
			, @Designation
			, @Age
			, @Address
			, @Experience)
	 END  
	 ELSE  
	BEGIN  
		UPDATE dbo.Employee 
		SET [Name]			= @Name
			, Designation	= @Designation
			, Age			= @Age
			, [Address]		= @Address
			, Experience	= @Experience 
		WHERE ID = @ID
	END  
END;
GO
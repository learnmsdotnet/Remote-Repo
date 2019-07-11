--Exec SProc_CURDAction @id = 8, @firstName = N'Henry', @lastName = N'Sara', @salary = 24.54, @city = N'Madurai', @StatementType = N'Insert'
--Exec [SProc_CURDAction] @id = 9, @firstName = N'Isaac', @lastName = N'Peter', @salary = 44.04, @city = N'Hyderabad', @StatementType = N'Insert'
--Exec SProc_CURDAction @StatementType = N'Select'
--Exec SProc_CURDAction @id = 6, @StatementType = N'Delete'
--Exec SProc_CURDAction @id = 8, @firstName = N'Henry', @lastName = N'Sara', @salary = 24.54, @city = N'Madurai', @StatementType = N'Update'
--Exec SProc_CURDAction @id = 8, @firstName = N'Hari', @lastName = N'Abraham', @StatementType = N'Update2'

USE [DEMOCSHARP];
GO

--CREATE PROCEDURE SProc_CURDAction (
ALTER PROCEDURE SProc_CURDAction (
	  @id				INTEGER = 0
	, @firstName		VARCHAR  (10) = ''
	, @lastName			VARCHAR  (10) = ''
	, @salary			DECIMAL	 (10, 2) = 0
	, @city				VARCHAR  (20) = ''
	, @StatementType	NVARCHAR (20) = ''
)
AS
BEGIN
	IF (@StatementType = 'Insert')
    BEGIN  
        INSERT INTO EMPLOYEE (ID, FirstName, LastName , Salary, City) VALUES (@id, @firstName, @lastName, @salary, @city);
    END  

    IF (@StatementType = 'Select')
    BEGIN  
        SELECT * FROM EMPLOYEE;  
    END  

    IF (@StatementType = 'Update')
    BEGIN  
        UPDATE EMPLOYEE SET  
            FirstName = @firstName, 
            LastName = @lastName, 
            Salary = @salary,  
            City = @city  
        WHERE ID = @id;  
    END  

	IF (@StatementType = 'Update2')
    BEGIN  
        UPDATE EMPLOYEE SET  
            FirstName = @firstName, 
            LastName = @lastName
        WHERE ID = @id;  
    END 

    ELSE IF (@StatementType = 'Delete')
    BEGIN  
        DELETE FROM EMPLOYEE WHERE ID = @id;
    END
END

/*
public void UnderstandFileExists(string fileName, int count)
{
	if (statementType == "Insert")
	{
		//do some action
	}
	else if (statementType == "Delete")
	{
		//do some action
	}
}
*/


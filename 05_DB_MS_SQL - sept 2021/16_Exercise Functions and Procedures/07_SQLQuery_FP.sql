--Functions and Procedures--

--Task 01: Employees with Salary Above 35000--
USE [SoftUni]

CREATE PROCEDURE usp_GetEmployeesSalaryAbove35000 
AS 
	BEGIN
		SELECT [FirstName] AS [First Name],
			   [LastName] AS [Last Name]
		  FROM [Employees]
		 WHERE [Salary] > 35000
	END

GO

EXEC usp_GetEmployeesSalaryAbove35000

--Task 02: Employees with Salary Above Number--
CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber @minSalary DECIMAL(18, 4) 
AS 
	BEGIN
		SELECT [FirstName] AS [First Name],
			   [LastName] AS [Last Name]
		  FROM [Employees]
		 WHERE [Salary] >= @minSalary
	END

GO

EXEC usp_GetEmployeesSalaryAboveNumber 48100

--Task 03: Town Names Starting With--
CREATE PROCEDURE usp_GetTownsStartingWith @startLetters NVARCHAR(25) 
AS 
	BEGIN
		SELECT [Name] AS [Town]
		  FROM [Towns]
		 WHERE [NAME] LIKE @startLetters + '%'
	END

GO

EXEC usp_GetTownsStartingWith "b"

--Task 04: Employees from Town--
CREATE PROCEDURE usp_GetEmployeesFromTown @townName VARCHAR(50) 
AS 
	BEGIN
		SELECT e.[FirstName] AS [First Name],
			   e.[LastName] AS [Last Name]
		  FROM [Employees] AS e
	 LEFT JOIN [Addresses] AS a
	        ON e.[AddressID] = a.AddressID
	 LEFT JOIN [Towns]     AS t
	        ON a.[TownID] = t.[TownID]
		 WHERE t.[Name] = @townName
	END

GO

EXEC usp_GetEmployeesFromTown 'Sofia'	

--Task 05: Salary Level Function--
CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4)) RETURNS VARCHAR(7) 
AS
	BEGIN
		DECLARE @salaryLevel VARCHAR(7)	
		IF @salary < 30000
		BEGIN 
			SET @salaryLevel = 'Low'
		END
		ELSE IF @salary BETWEEN 30000 AND 50000 
		BEGIN
			SET @salaryLevel = 'Average'
		END
		ELSE 
		BEGIN
			SET @salaryLevel = 'High'
		END
		
		RETURN @salaryLevel
	END

GO

SELECT [Salary],
	   dbo.ufn_GetSalaryLevel([Salary]) AS [SalaryLevel]
  FROM [Employees]

SELECT dbo.ufn_GetSalaryLevel(13500)
	
--Task 06: Employees by Salary Level--
CREATE PROCEDURE usp_EmployeesBySalaryLevel @salaryLevel VARCHAR(7) 
AS
	BEGIN
		SELECT [FirstName],
			   [LastName]
		  FROM [Employees]
		 WHERE dbo.ufn_GetSalaryLevel([Salary]) = @salaryLevel
	END

GO

EXEC usp_EmployeesBySalaryLevel 'High'

--Task 07: Define Function--
CREATE FUNCTION ufn_IsWordComprised(@setOfLetters NVARCHAR(50), @word NVARCHAR(50))
RETURNS BIT
AS
	BEGIN
		DECLARE @i TINYINT = 1;
		WHILE LEN(@word) >= @i
		BEGIN
			DECLARE @currentLetter NVARCHAR(1) = SUBSTRING(@word, @i, 1);
			IF(@setOfLetters NOT LIKE '%' + @currentLetter + '%') -- IF(CHARINDEX(@currentLetter, @setOfLetters) = 0)
			  RETURN 0
			SET @i += 1;
		END
	  RETURN 1
	END

GO

SELECT dbo.ufn_IsWordComprised('oistmiahf', 'Sofia')
SELECT dbo.ufn_IsWordComprised('oistmiahf', 'halves')
SELECT dbo.ufn_IsWordComprised('bobr', 'Rob')
SELECT dbo.ufn_IsWordComprised('pppp', 'Guy')

SELECT dbo.ufn_IsWordComprised('ryae', 'Erays')

--Task 08: Delete Employees and Departments--
SELECT [EmployeeID] FROM [Employees]
	WHERE [DepartmentID] = 4

GO

CREATE PROCEDURE usp_DeleteEmployeesFromDepartment (@departmentId INT) 
AS
	BEGIN
	DELETE FROM [EmployeesProjects]
		  WHERE [EmployeeID] IN (
			SELECT [EmployeeID]
			FROM [Employees]
			WHERE [DepartmentID] = @departmentId
			)
		UPDATE [Employees]
		SET [ManagerID] = NULL
		WHERE [ManagerID] IN (
			SELECT [EmployeeID]
			FROM [Employees]
			WHERE [DepartmentID] = @departmentId
			)
	ALTER TABLE [Departments]
	ALTER COLUMN [ManagerID] INT --NULL
	
	UPDATE [Departments]
	   SET [ManagerID] = NULL
	   WHERE [ManagerID] IN (
			SELECT [EmployeeID]
			FROM [Employees]
			WHERE [DepartmentID] = @departmentId
			)
	DELETE FROM [Employees]
	      WHERE [DepartmentID] = @departmentId
	
	DELETE FROM [Departments]
	      WHERE [DepartmentID] = @departmentId
	
		  SELECT COUNT(*)
		  FROM [Employees]
		  WHERE [DepartmentID] = @departmentId
	END

EXEC usp_DeleteEmployeesFromDepartment 4

--Task 09: Find Full Name--
CREATE PROC usp_GetHoldersFullName 
AS
	BEGIN  
		SELECT [FirstName] + ' ' + [LastName] AS [Full Name]
		FROM [AccountHolders]
	END

GO

EXEC usp_GetHoldersFullName

--Task 10: People with Balance Higher Than--
CREATE PROC usp_GetHoldersWithBalanceHigherThan(@inputSalary MONEY) 
AS
	BEGIN
		SELECT 
			ah.FirstName,
			ah.LastName
			FROM Accounts a
			JOIN AccountHolders ah ON ah.Id = a.AccountHolderId
			GROUP BY a.AccountHolderId, ah.FirstName, ah.LastName
			HAVING SUM(a.Balance) > @inputSalary
			ORDER BY ah.FirstName, ah.LastName
	END

GO

EXEC usp_GetHoldersWithBalanceHigherThan 50000

--Task 11: Future Value Function--
CREATE FUNCTION ufn_CalculateFutureValue (@sum DECIMAL(18, 4), @yearlyInterestRate FLOAT, @numberOfyears INT)
RETURNS DECIMAL(18, 4)
AS
BEGIN
	DECLARE @x FLOAT = 1 + @yearlyInterestRate;	
	DECLARE @calculate DECIMAL(18,4) = @sum * (POWER(@x, @numberOfyears));	
	RETURN @calculate 
END

GO

SELECT dbo.ufn_CalculateFutureValue(1000, 0.1, 5)

--Task 12: Calculating Interest--
CREATE PROC usp_CalculateFutureValueForAccount (@accountID INT ,@interestRate FLOAT)
AS
BEGIN

	SELECT
		a.Id AS [Account Id],
		ah.FirstName AS [First Name],
		ah.LastName AS [Last Name],
		a.Balance AS [Current Balance],
		dbo.ufn_CalculateFutureValue(a.Balance, @interestRate, 5) AS [Balance in 5 years]
		FROM Accounts a
		JOIN AccountHolders ah ON ah.Id = a.AccountHolderId
		WHERE a.Id = @accountID

END

GO

usp_CalculateFutureValueForAccount 1, 0.1

--Task 13: Scalar Function: Cash in User Games Odd Rows--
USE [Diablo]

SELECT SUM([Cash]) AS [SumCash]
FROM(
		SELECT g.[Name],
			  ug.[Cash],
		ROW_NUMBER() OVER(PARTITION BY g.[Name] ORDER BY ug.[Cash] DESC) AS [RowNumber]
		FROM [UsersGames] AS ug
		JOIN [Games] AS g
		ON ug.[GameId] = g.[Id]
		WHERE g.[Name] = 'Love in a mist'
	) AS [RowNumberSubQuery]
WHERE [RowNumber] % 2 <> 0

CREATE FUNCTION ufn_CashInUsersGames (@gameName NVARCHAR(50))
RETURNS TABLE
AS 
RETURN SELECT (
			SELECT 
				  SUM([Cash]) AS [SumCash]
			FROM(
				  SELECT g.[Name],
						  ug.[Cash],
					ROW_NUMBER() OVER(PARTITION BY g.[Name] ORDER BY ug.[Cash] DESC) AS [RowNumber]
					FROM [UsersGames] AS ug
					JOIN [Games] AS g
					ON ug.[GameId] = g.[Id]
					WHERE g.[Name] = @gameName
				) AS [RowNumberSubQuery]
			WHERE [RowNumber] % 2 <> 0
) AS [SumCash]

SELECT * FROM ufn_CashInUsersGames('Love in a mist')
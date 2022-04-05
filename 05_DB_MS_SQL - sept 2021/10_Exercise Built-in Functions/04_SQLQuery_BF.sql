--Built-in Functions--

USE [SoftUni]

--Task 01: Find Names of All Employees by First Name--
SELECT [FirstName], [LastName] FROM [Employees]
	WHERE LEFT([FirstName], 2) = 'Sa'
--or--
SELECT [FirstName], [LastName] FROM [Employees]
	WHERE SUBSTRING([FirstName], 1, 2) = 'Sa'
--or--
SELECT [FirstName], [LastName] FROM [Employees]
	WHERE [FirstName] LIKE 'Sa%'

--Task 02: Find Names of All Employees by Last Name--
SELECT [FirstName], [LastName] FROM [Employees]
	WHERE CHARINDEX('ei', [LastName]) <> 0
--or--
SELECT [FirstName], [LastName] FROM [Employees]
	WHERE [LastName] LIKE '%ei%'

--Task 03: Find First Names of All Employess--
SELECT [FirstName] FROM [Employees]
	WHERE [DepartmentID] IN (3, 10) AND YEAR([HireDate]) BETWEEN 1995 AND 2005

--Task 04: Find All Employees Except Engineers--
SELECT [FirstName], [LastName] FROM [Employees]	
	WHERE [JobTitle] NOT LIKE '%engineer%'

--Task 05: Find Towns with Name Length--
SELECT [Name] FROM [Towns]
	WHERE LEN([Name]) IN (5, 6)
	ORDER BY [Name]
--or--
SELECT [Name] FROM [Towns]
	WHERE DATALENGTH([Name]) IN (5, 6)
	ORDER BY [Name]

--Task 06: Find Towns Starting With--
SELECT * FROM [Towns]
	WHERE LEFT([Name], 1) IN ('M', 'K', 'B', 'E')
	ORDER BY [Name]
--or--
SELECT * FROM [Towns]
	WHERE [Name] LIKE '[mkbe]%'
	ORDER BY [Name]

--Task 07: Find Towns Not Starting With--
SELECT * FROM [Towns]	
	WHERE [Name] NOT LIKE '[RBD]%'
	ORDER BY [Name]

--Task 08: Create View Employees Hired After--
CREATE VIEW [V_EmployeesHiredAfter2000]	AS (
		SELECT [FirstName], [LastName], [HireDate] FROM [Employees]
		WHERE YEAR([HireDate]) >= 2000)

		SELECT [FirstName], [LastName] FROM [V_EmployeesHiredAfter2000]

--Task 09: Length of Last Name--
SELECT [FirstName], [LastName] FROM [Employees]
	WHERE LEN([LastName]) IN (5)
	
--Task 10: Rank Employees by Salary--
SELECT [EmployeeID], [FirstName], [LastName], [Salary], 
	DENSE_RANK() OVER(PARTITION BY [Salary]
	ORDER BY [EmployeeID]) AS [Rank]
	FROM [Employees]
	WHERE [Salary] BETWEEN 10000 AND 50000
	ORDER BY [Salary] DESC
	
--Task 11: Find All Employees with Rank 2--
SELECT * FROM ( 
			SELECT [EmployeeID], [FirstName], [LastName], [Salary], 
			DENSE_RANK() OVER(PARTITION BY [Salary]
			ORDER BY [EmployeeID]) AS [Rank]
			FROM [Employees]
			WHERE [Salary] BETWEEN 10000 AND 50000
			)
	AS [RankingTable]
	WHERE [Rank] = 2
	ORDER BY [Salary] DESC

--Task 12: Countries Holding 'A'--
USE [Geography]

SELECT [CountryName] AS [Country Name], 
	[IsoCode] AS [Iso Code]
	FROM [Countries]
	WHERE [CountryName] LIKE '%a%a%a%'
	ORDER BY [IsoCode]

--Task 13: Mix of Peak and River Names--
SELECT p.[PeakName], 
	   r.[RiverName],
	   LOWER(CONCAT(LEFT(p.[PeakName], LEN(p.[PeakName]) - 1), r.[RiverName])) 
					AS [Mix]
	FROM [Peaks]	AS [p],
		 [Rivers]	AS [r]
	WHERE LOWER(RIGHT(p.[PeakName], 1)) = LOWER(LEFT(r.[RiverName], 1))
	ORDER BY [Mix]

--Task 14: Games From 2011 and 2012 Year--
USE Diablo

SELECT TOP (50) [Name], FORMAT([Start],'yyyy-MM-dd') AS [Start]
	FROM Games
	WHERE YEAR([Start]) IN (2011, 2012)
	ORDER BY [Start], [Name]

--Task 15: User Email Providers--
SELECT [Username], SUBSTRING([Email], 1 + CHARINDEX('@', Email), LEN(Email) - CHARINDEX('@', Email)) AS [Email Provider]
	FROM [Users]
	ORDER BY [Email Provider], [Username]
	
--Task 16: Get Users with IPAddress Like Pattern--
SELECT [Username], [IpAddress] AS [IP Address] FROM Users
	WHERE IpAddress LIKE '___.1%._%.___'
	ORDER BY [Username]

--Task 17: Show All Games with Duration--
USE [Diablo] 

SELECT [Name] AS [Game],
		CASE
			WHEN DATEPART(HOUR, [Start]) >= 0 AND DATEPART(HOUR, [Start]) < 12 THEN 'Morning'
			WHEN DATEPART(HOUR, [Start]) >= 12 AND DATEPART(HOUR, [Start]) < 18 THEN 'Afternoon'
			ELSE 'Evening'
			END 
				  AS [Part of the Day],

		CASE
			WHEN [Duration] <= 3 THEN 'Extra Short'
			WHEN [Duration] BETWEEN 4 AND 6 THEN 'Short'
			WHEN [Duration] > 6 THEN 'Long'
			ELSE 'Extra Long'
			END 
				  AS [Duration] 
	FROM [Games]

	ORDER BY [Game], [Duration], [Part of the Day]

--Task 18: Orders Table--
USE [Orders]

SELECT [ProductName], [OrderDate], DATEADD(DAY,3, [OrderDate]) AS [Pay Due],
	DATEADD(MONTH,1, [OrderDate]) AS [Deliver Due] FROM [Orders]

--Task 19: People Table--
CREATE TABLE People(
	Id INT IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	[BirthDate] DATETIME NOT NULL
	)

INSERT INTO People VALUES
	('Victor', '2000-12-07 00:00:00.000'),
	('Steven', '1992-09-10 00:00:00.000'),
	('Stephen', '1910-09-19 00:00:00.000'),
	('John', '2010-01-06 00:00:00.000')

SELECT [Name],
	DATEDIFF(YEAR, BirthDate, GETDATE()) AS 'Age in Years',
	DATEDIFF(MONTH, BirthDate, GETDATE()) AS 'Age in Months',
	DATEDIFF(DAY, BirthDate, GETDATE()) AS [Age in Days],
	DATEDIFF(MINUTE, BirthDate, GETDATE()) AS [Age in Minutes]
	FROM People
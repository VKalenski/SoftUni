--CRUD--

--Task 01: Examine the Databases--
--Done--

USE [SoftUni]

--Task 02: Find All Information About Departments--
SELECT * FROM [Departments]

--Task 03: Find all Department Names--
SELECT [Name] FROM [Departments]

--Task 04: Find Salary of Each Employee--
SELECT [FirstName], [LastName], [Salary] FROM [Employees]

--Task 05: Find Full Name of Each Employee--
SELECT [FirstName], [MiddleName], [LastName] FROM [Employees]

--Task 06: Find Email Address of Each Employee--
SELECT CONCAT ([FirstName], '.', [LastName], '@', 'softuni.bg')
	AS [Full Email Address] 
	FROM [Employees]

--Task 07: Find All Different Employee�s Salaries--
SELECT DISTINCT [Salary] FROM [Employees]

--Task 08: Find all Information About Employees--
SELECT * FROM [Employees]
	WHERE [JobTitle] = 'Sales Representative'

--Task 09: Find Names of All Employees by Salary in Range--
SELECT [FirstName], [LastName], [JobTitle] FROM [Employees]
	WHERE [Salary] BETWEEN 20000 AND 30000
--or--
SELECT [FirstName], [LastName], [JobTitle] FROM [Employees]
	WHERE [Salary] >= 20000 AND [Salary] < 30000

--Task 10: Find Names of All Employees--
SELECT CONCAT([FirstName], ' ', [MiddleName], ' ', [LastName])
	AS [Full Name]
	FROM [Employees]
	WHERE [Salary] IN (12500, 14000, 23600, 25000)
--or--
SELECT CONCAT_WS(' ', [FirstName], [MiddleName], [LastName])
	AS [Full Name]
	FROM [Employees]
	WHERE [Salary] IN (12500, 14000, 23600, 25000)

--Task 11: Find All Employees Without Manager--
SELECT [FirstName], [LastName] FROM [Employees]
	WHERE [ManagerID] IS NULL

--Task 12: Find All Employees with Salary More Than--
SELECT [FirstName], [LastName], [Salary] FROM [Employees]
	WHERE [Salary] > 50000
	ORDER BY [Salary] DESC

--Task 13: Find 5 Best Paid Employees--
SELECT TOP(5) [FirstName], [LastName] FROM [Employees]
	ORDER BY [Salary] DESC

--Task 14: Find All Employees Except Marketing--
SELECT [FirstName], [LastName] FROM [Employees]
	WHERE [DepartmentID] != '4'

--Task 15: Sort Employees Table--
SELECT * FROM [Employees]
	ORDER BY [Salary] DESC, [FirstName] ASC, [LastName] DESC, [MiddleName] ASC

GO 

--Task 16: Create View Employees with Salaries--
CREATE VIEW [V_EmployeesSalaries] AS (
SELECT [FirstName], [LastName], [Salary] FROM [Employees])

SELECT * FROM [V_EmployeesSalaries]

GO

--Task 17: Create View Employees with Job Titles--
CREATE VIEW [V_EmployeeNameJobTitle] AS (
SELECT CONCAT([FirstName], ' ', [MiddleName], ' ', [LastName]) AS [Full Name], 
	[JobTitle] AS [Job Title]
	FROM [Employees])

SELECT * FROM [V_EmployeeNameJobTitle]

GO

--Task 18: Distinct Job Titles--
SELECT DISTINCT [JobTitle] FROM [Employees]

--Task 19: Find First 10 Started Projects--
SELECT TOP (10) * FROM [Projects]
	ORDER BY [StartDate] ASC, [Name] ASC 

--Task 20: Last 7 Hired Employees--
SELECT TOP (7) [FirstName], [LastName], [HireDate] FROM [Employees]
	ORDER BY [HireDate] DESC 

--Task 21: Increase Salaries--
SELECT * FROM [Departments]

SELECT * FROM [Employees]
	WHERE [DepartmentID] IN (1, 2, 4, 11)

UPDATE [Employees]
	SET [Salary] += [Salary] * 0.12
	WHERE [DepartmentID] IN (1, 2, 4, 11)

SELECT [Salary] FROM [Employees]

--Task 22: All Mountain Peaks--
USE [Geography]

SELECT [PeakName] FROM [Peaks]
	ORDER BY [PeakName] ASC 

--Task 23: Biggest Countries by Population--
SELECT TOP (30) [CountryName], [Population] FROM [Countries]
	WHERE [ContinentCode] = 'EU'
	ORDER BY [Population] DESC, [CountryName] ASC

--Task 24: Countries and Currency (Euro / Not Euro)--
SELECT [CountryName], [CountryCode], 
		CASE
			WHEN [CurrencyCode] = 'EUR' THEN 'Euro'
			ELSE 'Not Euro'
		END AS [Currency]
	FROM [Countries]
	ORDER BY [CountryName]

--Task 25: All Diablo Characters--
USE [Diablo]

SELECT [Name] FROM [Characters]
	ORDER BY [Name] ASC
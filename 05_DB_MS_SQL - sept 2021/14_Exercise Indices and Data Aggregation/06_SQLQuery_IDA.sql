--Indices and Data Aggregation--

--Task 01: Records’ Count--
USE [Gringotts]

SELECT COUNT(*) AS [COUNT] FROM [WizzardDeposits]

--Task 02: Longest Magic Wand--
SELECT MAX([MagicWandSize]) AS [LongestMagicWand] FROM [WizzardDeposits]

--Task 03: Longest Magic Wand per Deposit Groups--
SELECT [DepositGroup] AS [DepositGroup],
	MAX([MagicWandSize]) AS [LongestMagicWand] 
	FROM [WizzardDeposits]
	GROUP BY [DepositGroup]

--Task 04: Smallest Deposit Group per Magic Wand Size--
SELECT TOP(2) [DepositGroup] AS [DepositGroup]
	FROM [WizzardDeposits]
	GROUP BY [DepositGroup]
	ORDER BY AVG([MagicWandSize])	

--Task 05: Deposits Sum--
SELECT [DepositGroup],
	SUM([DepositAmount]) AS [TotalSum] 
	FROM [WizzardDeposits]
	GROUP BY [DepositGroup]
	
--Task 06: Deposits Sum for Ollivander Family--
SELECT [DepositGroup], 
	SUM([DepositAmount]) AS [TotalSum] 
	FROM [WizzardDeposits]
	WHERE [MagicWandCreator] = 'Ollivander family'    
	GROUP BY [DepositGroup]

--Task 07: Deposits Filter--
SELECT [DepositGroup], 
	SUM([DepositAmount]) AS [TotalSum] 
	FROM [WizzardDeposits]
	WHERE [MagicWandCreator] = 'Ollivander family'    
	GROUP BY [DepositGroup]
	HAVING SUM([DepositAmount]) < 150000
	ORDER BY [TotalSum] DESC

--Task 08: Deposit Charge--
SELECT [DepositGroup], [MagicWandCreator],
	MIN([DepositCharge]) AS [MinDepositCharge]
	FROM [WizzardDeposits] 
	GROUP BY [DepositGroup], [MagicWandCreator]

--Task 09: Age Groups--
SELECT [AgeGroup], COUNT([AgeGroup]) AS [WizzardCountFROM] FROM
	(SELECT 
		CASE 
			WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
			WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
			WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
			WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
			WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
			WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
			ELSE '[61+]'
		END AS [AgeGroup]
		FROM [WizzardDeposits]
	) AS [AgeGroupQuery]
	
	GROUP BY [AgeGroup]

--Task 10: First Letter--
SELECT DISTINCT LEFT(FirstName, 1) AS FirstLetter
	FROM WizzardDeposits
	WHERE DepositGroup = 'Troll Chest'

--Task 11: Average Interest--
SELECT [DepositGroup], [IsDepositExpired], AVG(DepositInterest)
	FROM [WizzardDeposits]
	WHERE [DepositStartDate] > '1985-01-01'
	GROUP BY [IsDepositExpired], [DepositGroup]
	ORDER BY [DepositGroup] DESC, [IsDepositExpired]

--Task 12: Rich Wizard, Poor Wizard--
SELECT 
	SUM([Host Wizard Deposit] - [Guest Wizard Deposit]) AS [SumDifference] FROM
		(SELECT	[FirstName] AS [Host Wizzard],
		[DepositAmount] AS [Host Wizard Deposit],
		LEAD ([FirstName]) OVER ( ORDER BY Id) AS [Guest Wizard],
		LEAD ([DepositAmount]) OVER (ORDER By id) AS [Guest Wizard Deposit]
	FROM [WizzardDeposits]) AS [DepositTable]

--Task 13: Departments Total Salaries--
USE [SoftUni]

SELECT [DepartmentID], SUM(Salary) AS [TotalSalary]
	FROM [Employees]
	GROUP BY [DepartmentID]
	ORDER BY [DepartmentID]
	
--Task 14: Employees Minimum Salaries--
SELECT [DepartmentID], MIN([Salary]) AS [MinimumSalary]
	FROM [Employees]
	WHERE [HireDate] > '2000-01-01'AND [DepartmentID] IN (2,5,7)
	GROUP BY [DepartmentID]

--Task 15: Employees Average Salaries--
SELECT * INTO [AverageSalary]
	FROM [Employees]
	WHERE [Salary] > 30000 

DELETE FROM [AverageSalary] WHERE [ManagerID] = 42

UPDATE [AverageSalary ]
	SET [Salary] += 5000
	WHERE [DepartmentID] = 1

SELECT DepartmentID , AVG(Salary) AS [AverageSalary]
	FROM [AverageSalary]
	GROUP BY [DepartmentID]

--Task 16: Employees Maximum Salaries--
SELECT [DepartmentID], MAX([Salary]) AS [MaxSalary]
	FROM [Employees]
	GROUP BY [DepartmentID]
	HAVING MAX([Salary]) NOT BETWEEN 30000 AND 70000

--Task 17: Employees Count Salaries--
SELECT COUNT([EmployeeID]) AS [Count]
	FROM [Employees]
	WHERE [ManagerID] IS NULL

--Task 18: 3rd Highest Salary--
SELECT DISTINCT [DepartmentID], [Salary] AS [ThirdHighestSalary]
	FROM (SELECT [DepartmentID], [Salary], 
	DENSE_RANK() OVER (PARTITION BY [DepartmentID] ORDER BY  [Salary] DESC) AS [SalaryRank]
	FROM [Employees]) AS [RankingQuery]
	WHERE [SalaryRank] = 3

--Task 19: Salary Challenge--
SELECT TOP(10) [FirstName] , [LastName] , e.[DepartmentID]  FROM [Employees] AS e
	JOIN (SELECT [DepartmentID], AVG ([Salary]) AS [AvgSalary]
	FROM [Employees]
	GROUP BY [DepartmentID]) AS q ON e.DepartmentID = q.[DepartmentID]
	WHERE e.[Salary] > q.[AvgSalary]
	ORDER BY [DepartmentID]



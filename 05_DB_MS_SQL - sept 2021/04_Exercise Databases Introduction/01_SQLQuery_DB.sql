--Databases Introduction--

--Task 01: Create Database--
CREATE DATABASE [Minions]

USE [Minions]

--Task 02: Create Tables--
CREATE TABLE [Minions] (
	[Id] INT PRIMARY KEY NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	[Age] INT
)

CREATE TABLE [Towns] (
	[Id] INT PRIMARY KEY NOT NULL,
	[Names] NVARCHAR(50) NOT NULL
)

--Task 03: Alter Minions Table--
ALTER TABLE [Minions]
	ADD [TownId] INT

ALTER TABLE [Minions]
	ADD CONSTRAINT [FK_MinionsTownId] FOREIGN KEY (TownId) REFERENCES [Towns]([Id])

--Task 04: Insert Records in Both Tables--
INSERT INTO [Towns]([Id], [Names]) VALUES
	(1, 'Sofia'),
	(2, 'Plovdiv'),
	(3, 'Varna')

INSERT INTO [Minions]([Id], [Name], [Age], [TownId]) VALUES
	(1, 'Kevin', 22, 1),
	(2, 'Bob', 15, 3),
	(3, 'Steward', NULL, 2)

--Task 05: Truncate Table Minions--
TRUNCATE TABLE [Minions]	

--Task 06: Drop All Tables--
DROP TABLE [Minions]	
DROP TABLE [Towns]	

--Task 07: Create Table People--
CREATE TABLE [People] (
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(200) NOT NULL,
	[Picture] VARBINARY(MAX),
	CHECK (DATALENGTH([Picture]) <= 2000000),
	[Height] REAL,
	[Weight] REAL,
	[Gender] VARCHAR(1) NOT NULL,
	[Birthdate] DATETIME2 NOT NULL,
	[Biography] VARCHAR(200)
)

--TASK 08: Create Table Users--
CREATE TABLE [Users] (
	[Id] BIGINT PRIMARY KEY IDENTITY,
	[Username] VARCHAR(30) UNIQUE NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	[ProfilePicture] VARBINARY(MAX),
	CHECK (DATALENGTH([ProfilePicture]) <= 900000),
	[LastLoginTime] DATETIME2,
	[IsDeleted] BIT NOT NULL
)

--TASK 09: Change Primary Key--
ALTER TABLE [Users]
	DROP CONSTRAINT [PK__Users__3214EC07E1CAB0E7]

ALTER TABLE [Users]
	ADD CONSTRAINT [PK_UsersCompositeIdUsername] PRIMARY KEY ([Id], [Username])

--TASK 10: Add Check Constraint--
--Done--

--TASK 11: Set Default Value of a Field--
ALTER TABLE Users
ADD CONSTRAINT DF_SETLastLoginTime DEFAULT GETDATE() FOR LastLoginTime

--TASK 12: Set Unique Field--
ALTER TABLE [Users]
DROP CONSTRAINT [PK_UserCompositeIdUser]

ALTER TABLE [Users]
ADD CONSTRAINT [PK_Id]
PRIMARY KEY ([Id])

ALTER TABLE [Users]
ADD CONSTRAINT [CH_UsernameIsAtLeast3Symbols] 
CHECK (LEN([Username]) >= 3)

--TASK 13: Movies Database--
CREATE TABLE Directors(
Id INT PRIMARY KEY,
DirectorName VARCHAR(60) NOT NULL,
Notes VARCHAR(MAX)
)

INSERT INTO Directors([Id], [DirectorName], [Notes]) VALUES 
(1, 'Steven Spillsberg', NULL),
(2, 'Lucke Besson', 'French'),
(3, 'Nikita Mihalkov', 'Russian'),
(4, 'Oodie Allan', 'American'),
(5, 'James Cameron', NULL)

CREATE TABLE Genres(
Id INT PRIMARY KEY,
GenreName VARCHAR(60) NOT NULL,
Notes VARCHAR(MAX)
)

INSERT INTO Genres([Id], [GenreName], [Notes]) VALUES 
(1, 'COMEDY', NULL),
(2, 'ACTION', 'COOL'),
(3, 'ROMANTIC', NULL),
(4, 'HORROR', 'SPOOKY'),
(5, 'SCIENCE FICTION', NULL)

CREATE TABLE Categories(
Id INT PRIMARY KEY,
CategoryName VARCHAR(60) NOT NULL,
Notes VARCHAR(MAX)
)

INSERT INTO Categories([Id], [CategoryName], [Notes]) VALUES
(1, 'A', 'NO RESTRICTS'),
(2, 'B', '10+ YEARS'),
(3, 'C', '12+ YEARS'),
(4, 'D', '16+ YEARS'),
(5, 'E', '18+ YEARS')

CREATE TABLE Movies(
Id INT PRIMARY KEY,
Title VARCHAR(100) NOT NULL,
CopyrightYear CHAR(4) NOT NULL,
[Length] DECIMAL(15,2),
Rating DECIMAL(15,2),
Notes VARCHAR(MAX)
)

ALTER TABLE Movies
ADD [DirectorId] INT

ALTER TABLE Movies
ADD FOREIGN KEY ([DirectorId]) REFERENCES Directors(Id)

ALTER TABLE Movies
ADD [CategoryId] INT

ALTER TABLE Movies
ADD FOREIGN KEY ([CategoryId]) REFERENCES Categories(Id)

ALTER TABLE Movies
ADD [GenreId] INT

ALTER TABLE Movies
ADD FOREIGN KEY ([GenreId]) REFERENCES Genres(Id)

INSERT INTO Movies([Id], [Title], [CopyrightYear], [Length], [Rating], [Notes], [DirectorId], [GenreId], [CategoryId]) VALUES 
('1', 'FAST AND FURIOUS', '2001', NULL, 10, NULL, 1, 2, 3),
('2', 'HARRY POTTER', '2005', NULL, 8, NULL, 3, 5, 2),
('3', 'JASON BORN', '2016', NULL, 9, NULL, 5, 2, 4),
('4', 'TITANIC', '1997', NULL, 10, NULL, 4, 3, 1),
('5', 'LORD OF THE RINGS', '2012', NULL, 10, NULL, 2, 5, 4)


--TASK 14: Car Rental Database--
CREATE DATABASE CarRental

CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(50) UNIQUE NOT NULL, 
	DailyRate DECIMAL(3, 1) NOT NULL, 
	WeeklyRate DECIMAL(3, 1) NOT NULL, 
	MonthlyRate DECIMAL(3, 1) NOT NULL, 
	WeekendRate DECIMAL(3, 1) NOT NULL
)

CREATE TABLE Cars(
	Id INT PRIMARY KEY IDENTITY, 
	PlateNumber NVARCHAR(10) UNIQUE NOT NULL, 
	Manufacturer NVARCHAR(20) NOT NULL, 
	Model NVARCHAR(20) NOT NULL, 
	CarYear DATE NOT NULL, 
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id), 
	Doors INT NOT NULL, 
	Picture VARBINARY, 
	Condition NVARCHAR(200), 
	Available BIT NOT NULL
)

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY, 
	FirstName NVARCHAR(30) NOT NULL, 
	LastName NVARCHAR(30) NOT NULL, 
	Title NVARCHAR(30), 
	Notes NVARCHAR(MAX)
)

CREATE TABLE Customers  (
	Id INT PRIMARY KEY IDENTITY, 
	DriverLicenceNumber INT UNIQUE NOT NULL, 
	FullName NVARCHAR(60) NOT NULL, 
	[Address] NVARCHAR(100), 
	City NVARCHAR(20), 
	ZIPCode INT, 
	Notes NVARCHAR(MAX)
)

CREATE TABLE RentalOrders   (
	Id INT PRIMARY KEY IDENTITY, 
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id), 
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id), 
	CarId INT FOREIGN KEY REFERENCES Cars(Id), 
	TankLevel INT NOT NULL, 
	KilometrageStart INT NOT NULL, 
	KilometrageEnd INT NOT NULL, 
	TotalKilometrage INT NOT NULL, 
	StartDate DATETIME2, 
	EndDate DATETIME2, 
	TotalDays INT NOT NULL, 
	RateApplied DECIMAL(2, 1), 
	TaxRate DECIMAL(2, 1), 
	OrderStatus NVARCHAR(50), 
	Notes NVARCHAR(MAX)
)

INSERT INTO Categories (CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate) 
VALUES		
	('Category1', 5.4, 6.2, 7.2, 10.0),
	('Category2', 4.4, 8.2, 9.2, 12.0),
	('Category3', 2.3, 4.2, 8.2, 5.9)

INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available) 
VALUES
	('1234', 'Mercedes', 'SL500', '2010', 1, 2, NULL, NULL, 1),
	('1442', 'Audi', 'A7', '2018', 2, 5, NULL, NULL, 1),
	('1312', 'BMW', 'E50', '2012', 3, 4, NULL, NULL, 0)

INSERT INTO Employees (FirstName, LastName, Title, Notes)
VALUES 
	('Dimitrichko', 'Kamenov', NULL, NULL),
	('Pesho', 'Peshev', NULL, NULL),
	('Gosho', 'Kazakov', NULL, NULL)

INSERT INTO Customers (DriverLicenceNumber, FullName, [Address], City, ZIPCode, Notes)
VALUES 
	('12345', 'Diyan', NULL, NULL, NULL, NULL),
	('123456', 'Tacho', NULL, NULL, NULL, NULL),
	('1234567', 'Martin', NULL, NULL, NULL, NULL)

INSERT INTO RentalOrders (EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, 
			TotalKilometrage, StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes)
VALUES
	(1, 1, 1, 50, 0, 320, 198000, '2010-05-10', '2010-05-15', 5, NULL, NULL, NULL, NULL),
	(2, 2, 2, 50, 0, 260, 35682, '2012-11-15', '2012-11-21', 6, NULL, NULL, NULL, NULL),
	(3, 3, 3, 50, 0, 220, 67820, '2014-08-31', '2014-09-01', 1, NULL, NULL, NULL, NULL)

--TASK 15: Hotel Database--
CREATE DATABASE Hotel

CREATE TABLE Employees (
Id INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(30) NOT NULL, 
LastName NVARCHAR(30) NOT NULL, 
Title NVARCHAR(30) NOT NULL, 
Notes NVARCHAR(MAX)
)

CREATE TABLE Customers (
AccountNumber INT PRIMARY KEY IDENTITY, 
FirstName NVARCHAR(30) NOT NULL, 
LastName NVARCHAR(30) NOT NULL, 
PhoneNumber INT UNIQUE NOT NULL, 
EmergencyName NVARCHAR(30), 
EmergencyNumber INT, 
Notes NVARCHAR(MAX)
)

CREATE TABLE RoomStatus (
RoomStatus NVARCHAR(20) PRIMARY KEY, 
Notes NVARCHAR(MAX)
)

CREATE TABLE RoomTypes (
RoomType NVARCHAR(20) PRIMARY KEY, 
Notes NVARCHAR(MAX)
)

CREATE TABLE BedTypes (
BedType NVARCHAR(20) PRIMARY KEY, 
Notes NVARCHAR(MAX)
)

CREATE TABLE Rooms (
RoomNumber INT PRIMARY KEY IDENTITY, 
RoomType NVARCHAR(20) FOREIGN KEY REFERENCES RoomTypes(RoomType), 
BedType NVARCHAR(20) FOREIGN KEY REFERENCES BedTypes(BedType), 
Rate DECIMAL(2, 1), 
RoomStatus NVARCHAR(20) FOREIGN KEY REFERENCES RoomStatus(RoomStatus), 
Notes NVARCHAR(MAX)
)

CREATE TABLE Payments (
Id INT PRIMARY KEY IDENTITY, 
EmployeeId INT FOREIGN KEY REFERENCES Employees(Id), 
PaymentDate DATETIME2 NOT NULL, 
AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber), 
FirstDateOccupied DATETIME2 NOT NULL, 
LastDateOccupied DATETIME2 NOT NULL, 
TotalDays INT NOT NULL, 
AmountCharged DECIMAL(10, 2) NOT NULL, 
TaxRate DECIMAL(3, 2) , 
TaxAmount DECIMAL(10, 2) NOT NULL, 
PaymentTotal DECIMAL(10, 2) NOT NULL, 
Notes NVARCHAR(MAX)
)

CREATE TABLE Occupancies (
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	DateOccupied DATETIME2 NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber),
	RoomNumber INT FOREIGN KEY REFERENCES Rooms(RoomNumber),
	RateApplied DECIMAL(3, 2),
	PhoneCharge DECIMAL(10, 2),
	Notes NVARCHAR(MAX)
)

INSERT INTO Employees (FirstName, LastName, Title, Notes)
VALUES	    
	    ('Kiro', 'Kirov', 'employee1', NULL),
	    ('Ivan', 'Ivanov', 'employee2', NULL),
	    ('Pesho', 'Peshev', 'employee3', NULL)

INSERT INTO Customers  (FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes)
VALUES	    
	    ('Toshko', 'Toshkov', 123456, NULL, NULL, NULL),
	    ('Stamat', 'Stamatov', 654321, NULL, NULL, NULL),
	    ('Gosho', 'Goshov', 223341, NULL, NULL, NULL)

INSERT INTO RoomStatus(RoomStatus, Notes)
VALUES	    
		('Status1', NULL),
	    ('Status2', NULL),
	    ('Status3', NULL)

INSERT INTO RoomTypes(RoomType, Notes)
VALUES	    
		('Type1', NULL),
	    ('Type2', NULL),
	    ('Type3', NULL)

INSERT INTO BedTypes(BedType, Notes)
VALUES	    
		('Bed1', NULL),
	    ('Bed2', NULL),
	    ('Bed3', NULL)

INSERT INTO Rooms (RoomType, BedType, Rate, RoomStatus, Notes)
VALUES     
	    ('Type1', 'Bed1', 7.2, 'Status1', NULL),
	    ('Type2', 'Bed2', 8.3, 'Status2', NULL),
	    ('Type3', 'Bed3', 9.2, 'Status3', NULL)

INSERT INTO Payments (EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, 
            TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes)
VALUES            
        (1, '2005-05-10', 1, '2005-05-05', '2005-05-10', 5, 305.50, 5.5, 35.72, 341.22, NULL),
        (2, '2007-07-15', 2, '2007-07-21', '2007-07-15', 6, 301.00, 6.5, 15.20, 316.20, NULL),
        (3, '2012-02-09', 3, '2012-02-16', '2012-02-09', 7, 450.25, 8.3, 25.20, 475.45, NULL)

INSERT INTO Occupancies (EmployeeId, DateOccupied, AccountNumber,
	     RoomNumber, RateApplied, PhoneCharge, Notes)
VALUES    
	    (1, '2019-09-15', 1, 1, NULL, 15.90, NULL),
	    (3, '2015-07-16', 3, 3, 7.50, 16.20, NULL),
	    (2, '1999-05-16', 2, 2, 8.32, 12.35, NULL)


--TASK 16: Create SoftUni Database--
CREATE DATABASE SoftUni

CREATE TABLE Towns (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) NOT NULL
)

CREATE TABLE Addresses (
	Id INT PRIMARY KEY IDENTITY,
	AddressText NVARCHAR(60) NOT NULL,
	TownId INT FOREIGN KEY REFERENCES Towns(Id)
)

CREATE TABLE Departments (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) NOT NULL
)

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	MiddleName NVARCHAR(30),
	LastName NVARCHAR(30) NOT NULL,
	JobTitle NVARCHAR(30) NOT NULL,
	DepartmentId INT FOREIGN KEY REFERENCES Departments(Id),
	HireDate DATE NOT NULL,
	Salary DECIMAL(10, 2) NOT NULL,
	AddressId INT FOREIGN KEY REFERENCES Addresses(Id)
)

INSERT INTO Towns([Name]) VALUES	    
	('Sofia'),
	('Plovdiv'),
	('Varna'),
	('Burgas')

INSERT INTO Departments([Name]) VALUES	    
	('Engineering'),
	('Sales'),
	('Marketing'),
	('Software Development'),
	('Quality Assurance')

INSERT INTO Addresses([AddressText], [TownId]) VALUES	    
	('bul.Bulgaria 156', 1),
	('ul.Ivan Vazov 56', 2),
	('bul.Chataldzha 83', 3),
	('bul.Primorski 133', 4)

INSERT INTO Employees (FirstName, MiddleName, LastName,
	    JobTitle, DepartmentId, HireDate, Salary, AddressId) VALUES	    
	('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013-02-01', 3500.00, 1),
	('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004-03-02', 4000.00, 1),
	('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016-08-28', 525.25, 4),
	('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, '2007-12-09', 3000.00, 2),
	('Peter', 'Pan', 'Pan', 'Intern', 3, '2016-08-28', 599.88, 3)

--TASK 17: Backup Database--
BACKUP DATABASE SoftUni
TO DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\Backup\softuni-backup.bak' 
WITH NOFORMAT, NOINIT,  
NAME = N'SoftUni-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
GO

USE Bank
DROP DATABASE SoftUni

RESTORE DATABASE SoftUni 
FROM DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\Backup\softuni-backup.bak'  WITH  FILE = 1,  NOUNLOAD,  STATS = 5

--TASK 18: Basic Insert--
CREATE TABLE [Towns]
	(
		[Id] INT PRIMARY KEY IDENTITY,
		[Name] NVARCHAR(50) NOT NULL
	)

CREATE TABLE [Addresses]
	(
		[Id] INT PRIMARY KEY IDENTITY, 
		[AddressText] NVARCHAR(100) NOT NULL, 
		[TownId] INT FOREIGN KEY REFERENCES [Towns]([Id]) NOT NULL
	)

CREATE TABLE [Departments]
	(
		[Id]	INT PRIMARY KEY IDENTITY,
		[Name]	NVARCHAR(50) NOT NULL
	)

CREATE TABLE [Employees]
	(
		[Id] INT PRIMARY KEY IDENTITY,
		[FirstName] NVARCHAR(50) NOT NULL, 
		[MiddleName] NVARCHAR(50), 
		[LastName] NVARCHAR(50) NOT NULL, 
		[JobTitle] NVARCHAR(30) NOT NULL, 
		[DepartmentId] INT FOREIGN KEY REFERENCES [Departments]([Id]) NOT NULL,
		[HireDate] DATE NOT NULL, 
		[Salary] DECIMAL(7, 2) NOT NULL, 
		[AddressId] INT FOREIGN KEY REFERENCES [Addresses]([Id]) 
	)

INSERT INTO [Towns]([Name]) VALUES
		('Sofia'), 
		('Plovdiv'), 
		('Varna'), 
		('Burgas')

INSERT INTO [Departments]([Name]) VALUES
		('Engineering'), 
		('Sales'), 
		('Marketing'), 
		('Software Development'), 
		('Quality Assurance')

INSERT INTO [Employees]([FirstName], [MiddleName], [LastName], [JobTitle], [DepartmentId], [HireDate], [Salary]) VALUES		
		('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '02/01/2013', '3500.00'),
		('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1,	'03/02/2004', '4000.00'),
		('Maria', 'Petrova', 'Ivanova',	'Intern', 5, '08/28/2016',	'525.25'),
		('Georgi', 'Teziev', 'Ivanov',	'CEO',	2,	'12/09/2007',	'3000.00'),
		('Peter', 'Pan', 'Pan',	'Intern',	3,	'08/28/2016',	'599.88')

--TASK 19: Basic Select All Fields--
SELECT * FROM [Towns]

SELECT * FROM [Departments]

SELECT * FROM [Employees]

--TASK 20: Basic Select All Fields and Order Them--
SELECT * FROM [Towns]
ORDER BY [Name] ASC

SELECT * FROM [Departments]
ORDER BY [Name] ASC

SELECT * FROM [Employees]
ORDER BY [Salary] DESC

--TASK 21: Basic Select Some Fields--
SELECT [Name] FROM Towns
ORDER BY [Name] ASC

SELECT [Name] FROM [Departments]
ORDER BY [Name] ASC

SELECT [FirstName], [LastName], [JobTitle], [Salary] FROM [Employees]
ORDER BY [Salary] DESC

--TASK 22: Increase Employees Salary--
UPDATE [Employees] 
SET Salary = Salary * 1.1
SELECT [Salary] FROM Employees

--TASK 23: Decrease Tax Rate--
Use Hotel

UPDATE [Payments]
SET [TaxRate] = [TaxRate] * 0.97

SELECT [TaxRate] FROM [Payments]

--TASK 24: Delete All Records--
TRUNCATE TABLE [Occupancies]

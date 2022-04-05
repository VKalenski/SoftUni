--Table Relations--

CREATE DATABASE [EntityRelationsDemo]

USE [EntityRelationsDemo]

--Task 01: One-To-One Relationship--
CREATE TABLE [Passports]
(
	[PassportID] INT PRIMARY KEY NOT NULL,
	[PassportNumber] CHAR(8) NOT NULL
)

CREATE TABLE [Persons]
(
	[PersonID] INT PRIMARY KEY IDENTITY NOT NULL,
	[FirstName] VARCHAR(50) NOT NULL,
	[Salary] DECIMAL(9, 2) NOT NULL,
	[PassportID] INT FOREIGN KEY REFERENCES [Passports]([PassportID]) UNIQUE NOT NULL
)

INSERT INTO [Passports]([PassportID], [PassportNumber])
	VALUES 
	(101, 'N34FG21B'),
	(102, 'K65LO4R7'),
	(103, 'ZE657QP2')

INSERT INTO [Persons]([FirstName], [Salary], [PassportID])
	VALUES
	('Roberto', 43300.00, 102),
	('Tom', 56100.00, 103),
	('Yana', 60200.00, 101)

--Task 02: One-To-Many Relationship--
CREATE TABLE [Manufacturers]
(
	[ManufacturerID] INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	[EstablishedOn] DATE NOT NULL
)

CREATE TABLE [Models]
(
	[ModelID] INT PRIMARY KEY IDENTITY(101, 1) NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	[ManufacturerID] INT FOREIGN KEY REFERENCES [Manufacturers]([ManufacturerID]) NOT NULL
)

INSERT INTO [Manufacturers]([Name], [EstablishedOn])
	VALUES 
	('BMW', '03/07/1916'),
	('Tesla', '01/01/2003'),
	('Lada', '01/05/1966')

INSERT INTO [Models]([Name], [ManufacturerID])
	VALUES
	('X1', 1),
	('i6', 1),
	('Model S', 2),
	('Model X', 2),
	('Model 3', 2),
	('Nova', 3)

SELECT * FROM [Models]

--Task 03: Many-To-Many Relationship--
CREATE TABLE [Students]
(
	[StudentID] INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [Exams](
	[ExamID] INT PRIMARY KEY IDENTITY(101, 1) NOT NULL,
	[Name] NVARCHAR(75) NOT NULL
)

CREATE TABLE [StudentsExams]
(
	[StudentID] INT FOREIGN KEY REFERENCES [Students]([StudentID]) NOT NULL,
	[ExamID] INT FOREIGN KEY REFERENCES [Exams]([ExamID]) NOT NULL,
	PRIMARY KEY ([StudentID], [ExamID])
)

INSERT INTO [Students]([Name])
	VALUES
	('Mila'),
	('Toni'),
	('Ron')

INSERT INTO [Exams]([Name])
	VALUES
	('SpringMVC'),
	('Neo4j'),
	('Oracle 11g')

INSERT INTO [StudentsExams]([StudentID], [ExamID])
	VALUES
	(1, 101),
	(1, 102),
	(2, 101),
	(3, 103),
	(2, 102),
	(2, 103)

SELECT * FROM [Students]
SELECT * FROM [Exams]
SELECT * FROM [StudentsExams]

--Task 04: Self-Referencing--
CREATE TABLE [Teachers]
(
	[TeacherID] INT PRIMARY KEY IDENTITY (101, 1) NOT NULL,		
	[Name] VARCHAR(50) NOT NULL,
	[ManagerID] INT FOREIGN KEY REFERENCES [Teachers]([TeacherID])
)

INSERT INTO [Teachers]([Name], [ManagerID])
	VALUES
	('John', NULL),
	('Maya', 106),
	('Silvia', 106),
	('Ted', 105),
	('Mark', 101),
	('Greta', 101)

--Task 05: Online Store Database--  
CREATE TABLE ItemTypes
(
	ItemTypeID INT PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE Items
(
	ItemID INT PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	ItemTypeID INT FOREIGN KEY REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE Cities
(
	CityID INT PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE Customers
(
	CustomerID INT PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	Birthday DATE,
	CityID INT FOREIGN KEY REFERENCES Cities(CityID)
)

CREATE TABLE Orders
(
	OrderID INT PRIMARY KEY NOT NULL,
	CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID)
)

CREATE TABLE OrderItems
(
	OrderID INT FOREIGN KEY REFERENCES Orders(OrderID) NOT NULL,
	ItemID INT FOREIGN KEY REFERENCES Items(ItemID) NOT NULL,
	PRIMARY KEY (OrderID, ItemID )
)

--Task 06: University Database-- 
CREATE TABLE Subjects
(
	SubjectID INT PRIMARY KEY NOT NULL,
	SubjectName VARCHAR(50) NOT NULL
)
	
CREATE TABLE Majors
(
	MajorID INT PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL
)
	
CREATE TABLE Students
(
	StudentID INT PRIMARY KEY NOT NULL,
	StudentNumber INT NOT NULL,
	StudentName VARCHAR(200) NOT NULL,
	MajorID INT FOREIGN KEY REFERENCES Majors(MajorID)
)
	
CREATE TABLE Payments
(
	PaymentID INT PRIMARY KEY NOT NULL,
	PaymentDate DATE,
	PaymentAmount DECIMAL(7,2) ,
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID)
)
	
CREATE TABLE Agenda
(
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
	SubjectID INT FOREIGN KEY REFERENCES Subjects(SubjectID),
	PRIMARY KEY(StudentID,SubjectID)
)

--Task 07: SoftUni Design--
--Done--

--Task 08: Geography Design--
--Done--

--Task 09: Peaks in Rila--
USE Geography

SELECT Mountains.[MountainRange], Peaks.[PeakName], Peaks.[Elevation]
	FROM [Mountains]
	JOIN [Peaks] ON Peaks.[MountainID] = Mountains.[Id]
	WHERE [MountainRange] = 'Rila'
	ORDER BY [Elevation] DESC
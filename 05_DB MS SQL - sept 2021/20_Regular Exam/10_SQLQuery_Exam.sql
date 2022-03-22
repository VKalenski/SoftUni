--Database Basics MS SQL Exam – 16 Oct 2021--

--Task 01: DDL--
CREATE DATABASE CigarShop

USE CigarShop

GO

CREATE TABLE Sizes
(
    Id INT PRIMARY KEY IDENTITY,
	Length INT CHECK (Length BETWEEN 10 AND 25) NOT NULL,	  
    RingRange DECIMAL(15, 2) NOT NULL	
)

CREATE TABLE Tastes
(
    Id INT PRIMARY KEY IDENTITY,
	TasteType VARCHAR(20) NOT NULL,
	TasteStrength VARCHAR(15) NOT NULL,
	ImageURL NVARCHAR(100) UNIQUE NOT NULL
)

CREATE TABLE Brands
(
    Id INT PRIMARY KEY IDENTITY,
	BrandName VARCHAR(30) UNIQUE NOT NULL,
	BrandDescription VARCHAR(MAX)
)

CREATE TABLE Cigars
(
    Id INT PRIMARY KEY IDENTITY,
	CigarName VARCHAR(80) NOT NULL,
	BrandId INT NOT NULL FOREIGN KEY REFERENCES Brands(Id),
	TastId INT NOT NULL FOREIGN KEY REFERENCES Tastes(Id),
	SizeId INT NOT NULL FOREIGN KEY REFERENCES Sizes(Id),
	PriceForSingleCigar DECIMAL(15, 2) NOT NULL,
	ImageURL NVARCHAR(MAX) NOT NULL
)

CREATE TABLE Addresses
(
    Id INT PRIMARY KEY IDENTITY,
	Town VARCHAR(30) NOT NULL,
	Country NVARCHAR(30) NOT NULL,
	Streat NVARCHAR(100) NOT NULL,
	Zip VARCHAR(20) NOT NULL
)

CREATE TABLE Clients
(
    Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	AddressId INT NOT NULL FOREIGN KEY REFERENCES Addresses(Id)
)

CREATE TABLE ClientsCigars
(
    ClientId INT FOREIGN KEY REFERENCES Clients(Id),
	CigarId INT FOREIGN KEY REFERENCES Cigars(Id),
	PRIMARY KEY (ClientId, CigarId)
)

--Task 02: Insert--
INSERT INTO Cigars(CigarName, BrandId, TastId, SizeId, PriceForSingleCigar, ImageURL)
VALUES
('COHIBA ROBUSTO', '9', '1', '5', '15.50', 'cohiba-robusto-stick_18.jpg'),
('COHIBA SIGLO I', '9', '1', '10', '410.00', 'cohiba-siglo-i-stick_12.jpg'),
('HOYO DE MONTERREY LE HOYO DU MAIRE', '14', '5', '11', '7.50', 'hoyo-du-maire-stick_17.jpg'),
('HOYO DE MONTERREY LE HOYO DE SAN JUAN', '14', '4', '15', '32.00', 'hoyo-de-san-juan-stick_20.jpg'),
('TRINIDAD COLONIALES', '2', '3', '8', '85.21', 'trinidad-coloniales-stick_30.jpg')

INSERT INTO Addresses(Town, Country, Streat, ZIP)
VALUES
('Sofia', 'Bulgaria', '18 Bul. Vasil levski', '1000'),
('Athens', 'Greece', '4342 McDonald Avenue', '10435'),
('Zagreb', 'Croatia', '4333 Lauren Drive', '10000')

--Task 03: Update--	
UPDATE Cigars
	SET PriceForSingleCigar += PriceForSingleCigar * 0.20
	WHERE TastId IN (1)

UPDATE Brands
	SET BrandDescription = 'New description'
	WHERE Id IN (16, 17, 19)

--Task 04: Delete--
DELETE FROM Clients
	WHERE AddressId IN (7, 8 , 10, 23)
	
DELETE FROM Addresses
	WHERE Country LIKE 'C%'

--Task 05: Cigars by Price--
SELECT CigarName, PriceForSingleCigar, ImageURL FROM Cigars
	ORDER BY PriceForSingleCigar ASC, CigarName DESC

--Task 06: Cigars by Price--
SELECT c.Id, c.CigarName, c.PriceForSingleCigar, t.TasteType,
	t.TasteStrength
	FROM Cigars AS c
	JOIN Tastes AS t
	ON t.Id = c.TastId	
	WHERE t.Id = 2 OR t.Id = 3
	ORDER BY c.PriceForSingleCigar DESC

--Task 07: Clients without Cigars--
SELECT DISTINCT c.Id, CONCAT(c.[FirstName], ' ', c.[LastName]) AS ClientName, c.Email FROM Clients AS c	
	JOIN ClientsCigars AS cc
	ON cc.ClientId <> c.Id	
	JOIN Cigars AS cig
	ON cig.Id = cc.CigarId
	WHERE cc.ClientId <> c.Id AND cig.Id = cc.CigarId
	ORDER BY ClientName ASC


	   

SELECT * FROM Cigars
ORDER BY Id
SELECT * FROM Clients
SELECT * FROM ClientsCigars
ORDER BY CigarId
SELECT * FROM Addresses
SELECT * FROM Brands


--Task 08: First 5 Cigars--
SELECT TOP (5) c.CigarName, c.PriceForSingleCigar, c.ImageURL FROM Cigars AS c
	JOIN Sizes AS s
	ON s.Id = c.SizeId
	WHERE ([Length] >= 12 AND (CigarName LIKE '%ci%' OR PriceForSingleCigar > 50) AND RingRange > 2.55)
	ORDER BY c.CigarName ASC, c.PriceForSingleCigar DESC

--Task 09: Clients with ZIP Codes--
SELECT CONCAT(c.FirstName, ' ', c.LastName) AS FullName,
	a.Country,
    a.ZIP,
    CONCAT('$',MAX([PriceForSingleCigar])) AS CigarPrice
	FROM Clients AS c
		JOIN Addresses AS a
		ON c.AddressId = a.Id
		JOIN ClientsCigars AS cl
		ON c.Id = cl.ClientId
		JOIN Cigars AS ci
		ON cl.CigarId = ci.Id
	WHERE a.ZIP  NOT LIKE '%[^0-9]%'
	GROUP BY c.FirstName , c.LastName, a.Country, a.ZIP
	ORDER BY FullName

--Task 10: Clients with ZIP Codes--
SELECT c.LastName, AVG(Length) AS CigarLength, CEILING(AVG(RingRange)) AS CRR
	FROM Clients AS c
	JOIN ClientsCigars AS cc ON c.Id = cc.ClientId
	JOIN Cigars AS cig ON cc.CigarId = cig.Id
	JOIN Sizes AS s ON cig.SizeId = s.Id
	GROUP BY LastName
	ORDER BY CigarLength DESC

--Task 11: Client with Cigars--

SELECT COUNT(*) 
	FROM Clients AS c
	JOIN ClientsCigars AS cc ON c.Id = cc.ClientId
	WHERE FirstName = @name

--Task 12: Search for Cigar with Specific Taste--
	  CREATE OR ALTER PROCEDURE usp_SearchByTaste(@taste VARCHAR(30))
AS
     SELECT c.CigarName,CONCAT('$',c.PriceForSingleCigar) AS Price,t.TasteType, b.BrandName, CONCAT(s.Length,' ' ,'cm') AS CigarLength,
CONCAT(s.RingRange,' ','cm') AS CigarRingRange
       FROM Cigars c
       LEFT JOIN Tastes t ON c.TastId = t.Id
       JOIN Brands b ON b.Id = c.BrandId
       JOIN Sizes s ON s.Id = c.SizeId
       WHERE t.TasteType = @taste
       ORDER BY CigarLength, CigarRingRange DESC
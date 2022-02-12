-- Script to create the structure provided, data initialization and query to return asked data.


IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'HE.Challenge')
BEGIN
	CREATE DATABASE [HE.Challenge]
END
GO

USE [HE.Challenge]
GO

--Customer table creation
IF NOT EXISTS (SELECT TOP 1 1 FROM sysobjects WHERE name = 'Customer' AND xtype = 'U')
BEGIN
    CREATE TABLE Customer (
        PersonID INT PRIMARY KEY IDENTITY (1, 1),
        FirstName VARCHAR(100),
        LastName VARCHAR(100),
        Occupation VARCHAR(100),
        MaritalStatus VARCHAR(1),
		Age SMALLINT,
    )
END
GO

--Orders table creation

IF NOT EXISTS (SELECT TOP 1 1 FROM sysobjects WHERE name = 'Orders' AND xtype = 'U')
BEGIN
    CREATE TABLE Orders (
        OrderID INT PRIMARY KEY IDENTITY (1, 1),
        PersonID INT,--FK
        DateCreated DATE,
        MethodofPurchase VARCHAR(1)
    )
END
GO

--OrderDetails table creation
IF NOT EXISTS (SELECT TOP 1 1 FROM sysobjects WHERE name = 'OrderDetails' AND xtype = 'U')
BEGIN
    CREATE TABLE OrderDetails (
        OrderDetailID INT PRIMARY KEY IDENTITY (1, 1),
        OrderID INT, --FK
        ProductNumber INT,--FK
        ProductID INT,
        ProductOrigin INT
    )
END
GO

--Customer Data Initialization
MERGE Customer AS t  
USING (VALUES
	('Juan', 'Tripi', 'N/A', 'S', 3),
	('Clara', 'Tripi', 'N/A', 'S', 7)
	) AS Source 
	(FirstName, LastName, Occupation, MaritalStatus, Age)  
ON (t.FirstName = Source.FirstName AND t.LastName = Source.LastName )  
WHEN NOT MATCHED THEN  
    INSERT (FirstName, LastName, Occupation, MaritalStatus, Age)  
    VALUES (Source.FirstName, Source.LastName, Source.Occupation, Source.MaritalStatus, Age);

--Orders Data Initialization
MERGE Orders AS t  
USING (VALUES
	(1, GETUTCDATE(), 'B'),
	(2, GETUTCDATE(), 'C'),
	(2, GETUTCDATE(), 'B'),
	(2, GETUTCDATE(), 'C')
	) AS Source 
	(PersonID, DateCreated, MethodofPurchase)  
ON (t.PersonID = Source.PersonID)  
WHEN NOT MATCHED THEN  
    INSERT 	(PersonID, DateCreated, MethodofPurchase)    
    VALUES 	(Source.PersonID, Source.DateCreated, Source.MethodofPurchase);


--OrderDetails Data Initialization
MERGE OrderDetails AS t  
USING (VALUES
	(2, 123, 1112222333, 1),
	(1, 124, 1112222444, 1),
	(1, 125, 1112222555, 1),
	(4, 123, 1112222333, 1)
	) AS Source 
	(OrderID, ProductNumber, ProductID, ProductOrigin)  
ON (t.OrderID = Source.OrderID)  
WHEN NOT MATCHED THEN  
    INSERT 	(OrderID, ProductNumber, ProductID, ProductOrigin)      
    VALUES 	(Source.OrderID, Source.ProductNumber, Source.ProductID, Source.ProductOrigin);


--Result
SELECT
	C.FirstName + ' ' + C.LastName AS FullName,
	C.Age,
	O.OrderID,
	O.DateCreated,
	O.MethodOfPurchase AS PurchaseMethod,
	OD.ProductNumber,
	OD.ProductOrigin
FROM 
	Customer C
INNER JOIN Orders O ON O.PersonID = C.PersonID
INNER JOIN OrderDetails OD ON OD.OrderID = O.OrderID
WHERE
	OD.ProductID = 1112222333
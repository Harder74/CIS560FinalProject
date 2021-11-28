/****************************
 * TableCreationQuery.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Setup Script for Table Creation
 ****************************/
IF NOT EXISTS
 (
	SELECT *
	FROM sys.tables s
	WHERE s.[name] = N'Inventory'
 )
BEGIN
CREATE TABLE IT.Inventory
(
	ItemID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	ItemName NVARCHAR(32) NOT NULL,
	SerialNumber NVARCHAR(32) NOT NULL,
	ItemType NVARCHAR (15) NOT NULL,
	IsCheckedOut BIT NOT NULL,
	IsRemoved BIT NOT NULL

	CONSTRAINT [UK_ItemName_SerialNumber] UNIQUE
	(
		ItemName,
		SerialNumber
	)
)
END;

IF NOT EXISTS
 (
	SELECT *
	FROM sys.tables s
	WHERE s.[name] = N'Customers'
 )
BEGIN
CREATE TABLE IT.Customers
(
	CustomerID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	FirstName NVARCHAR(32) NOT NULL,
	LastName NVARCHAR(32) NOT NULL

	CONSTRAINT [UK_Customer_Name] UNIQUE
	(
		FirstName,
		LastName
	)
)
END;

IF NOT EXISTS
 (
	SELECT *
	FROM sys.tables s
	WHERE s.[name] = N'Employees'
 )
BEGIN
CREATE TABLE IT.Employees
(
	EmployeeID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	FirstName NVARCHAR(32) NOT NULL,
	LastName NVARCHAR(32) NOT NULL

	CONSTRAINT [UK_Employee_Name] UNIQUE
	(
		FirstName,
		LastName
	)
)
END;

IF NOT EXISTS
 (
	SELECT *
	FROM sys.tables s
	WHERE s.[name] = N'CheckOuts'
 )
BEGIN
CREATE TABLE IT.CheckOuts
(
	CheckOutID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	ItemID INT NOT NULL,
	EmployeeID INT NOT NULL,
	CustomerID INT NOT NULL,
	CheckedOutOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET())

	CONSTRAINT [FK_ItemID_CheckOut] FOREIGN KEY(ItemID)
	REFERENCES IT.Inventory(ItemID),

	CONSTRAINT [FK_EmployeeID_CheckOut] FOREIGN KEY(EmployeeID)
	REFERENCES IT.Employees(EmployeeID),

	CONSTRAINT [FK_CustomerID_CheckOut] FOREIGN KEY(CustomerID)
	REFERENCES IT.Customers(CustomerID)
)
END;

IF NOT EXISTS
 (
	SELECT *
	FROM sys.tables s
	WHERE s.[name] = N'Returns'
 )
BEGIN
CREATE TABLE IT.[Returns]
(
	ReturnID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	ItemID INT NOT NULL,
	EmployeeID INT NOT NULL,
	CustomerID INT NOT NULL,
	CheckedOutID INT NOT NULL,
	ReturnedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET())

	CONSTRAINT [FK_ItemID_Returns] FOREIGN KEY(ItemID)
	REFERENCES IT.Inventory(ItemID),

	CONSTRAINT [FK_EmployeeID_Returns] FOREIGN KEY(EmployeeID)
	REFERENCES IT.Employees(EmployeeID),

	CONSTRAINT [FK_CustomerID_Returns] FOREIGN KEY(CustomerID)
	REFERENCES IT.Customers(CustomerID),

	CONSTRAINT [FK_CheckedOutID_Returns] FOREIGN KEY(CheckedOutID)
	REFERENCES IT.CheckOuts(CheckOutID)
)
END;
/****************************
 * IT.AllProcedures.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Creates all procedures
 ****************************/


CREATE OR ALTER PROCEDURE IT.AddCheckOut
	@ItemID INT,
	@EmployeeID INT,
	@CustomerID INT,
	@CheckoutID INT OUTPUT
AS

INSERT IT.CheckOuts(ItemID, EmployeeID, CustomerID, CheckedOutOn)
VALUES(@ItemID, @EmployeeID, @CustomerID, SYSDATETIMEOFFSET());

SET @CheckoutID = SCOPE_IDENTITY()
GO

CREATE PROCEDURE IT.AddEmployee
	@FirstName NVARCHAR(32),
	@LastName NVARCHAR(32),
	@EmployeeID INT OUTPUT
AS

INSERT IT.Employees(FirstName, LastName)
VALUES(@FirstName, @LastName);

SET @EmployeeID = SCOPE_IDENTITY()
GO

CREATE PROCEDURE IT.AddItem
	@ItemName NVARCHAR(32),
	@SerialNumber NVARCHAR(32),
	@ItemType NVARCHAR(15),
	@IsCheckedOut INT,
	@IsRemoved INT,
	@ItemID INT OUTPUT
AS

INSERT IT.Inventory(ItemName, SerialNumber, ItemType, IsCheckedOut, IsRemoved)
VALUES(@ItemName, @SerialNumber, @ItemType, @IsCheckedOut, @IsRemoved);

SET @ItemID = SCOPE_IDENTITY()
GO

CREATE OR ALTER PROCEDURE IT.AddReturn
	@EmployeeID INT,
	@CheckoutID INT ,
	@ReturnID INT OUTPUT
AS

INSERT IT.Returns(ItemID, EmployeeID, CustomerID, ReturnedOn, CheckedOutID)
VALUES(
(
SELECT CO.ItemID
FROM IT.CheckOuts CO
WHERE CO.CheckOutID = @CheckoutID
),
@EmployeeID, 
(
SELECT CO.CustomerID
FROM IT.CheckOuts CO
WHERE CO.CheckOutID = @CheckoutID
), 
SYSDATETIMEOFFSET(), 
@CheckoutID);

SET @ReturnID = SCOPE_IDENTITY()
GO

CREATE OR ALTER   PROCEDURE [IT].[CheckOutsNotReturned]
	@CustomerID INT
AS

SELECT CO.ItemID, I.ItemName, I.SerialNumber, CO.CheckOutID, E.FirstName, E.LastName
FROM IT.CheckOuts CO
	INNER JOIN IT.Inventory I on I.ItemID = CO.ItemID
	INNER JOIN IT.Employees E on E.EmployeeID = CO.EmployeeID
WHERE CO.CustomerID = @CustomerID and NOT EXISTS 
(
	SELECT *
	FROM IT.[Returns] R
	WHERE CO.CheckOutID = R.CheckedOutID
)
ORDER BY CO.CheckedOutOn;
GO

CREATE OR ALTER PROCEDURE IT.GetAvailableItems 
AS

SELECT I.ItemID, I.ItemName, I.ItemType, I.SerialNumber
FROM IT.Inventory I
WHERE I.IsCheckedOut = 0;
GO

CREATE OR ALTER PROCEDURE IT.GetCCheckedOutOn
	@CheckedOutDate DATETIMEOFFSET
AS

SELECT C.CustomerID, C.FirstName, C.LastName
FROM IT.Customers C
	INNER JOIN IT.CheckOuts CO on CO.EmployeeID = C.CustomerID
WHERE DATEDIFF(DAY, CO.CheckedOutOn, @CheckedOutDate) = 0
GROUP BY C.CustomerID, C.FirstName, C.LastName;
GO

CREATE OR ALTER PROCEDURE IT.GetCReturnedOn
	@ReturnedDate DATETIMEOFFSET
AS

SELECT C.CustomerID, C.FirstName, C.LastName
FROM IT.Customers C
	INNER JOIN IT.[Returns] R on R.CustomerID = C.CustomerID
WHERE DATEDIFF(DAY, R.ReturnedOn, @ReturnedDate) = 0
GROUP BY C.CustomerID, C.FirstName, C.LastName;
GO

CREATE OR ALTER PROCEDURE IT.GetCustomerByFirst
	@FirstName NVARCHAR(32)
AS

SELECT C.CustomerID, C.FirstName, C.LastName
FROM IT.Customers C
WHERE C.FirstName = @FirstName
GO

CREATE OR ALTER PROCEDURE IT.GetCustomerByID
	@CustomerID INT
AS

SELECT C.CustomerID, C.FirstName, C.LastName
FROM IT.Customers C
WHERE C.CustomerID = @CustomerID;
GO

CREATE OR ALTER PROCEDURE IT.GetCustomerByLast
	@LastName NVARCHAR(32)
AS

SELECT C.CustomerID, C.FirstName, C.LastName
FROM IT.Customers C
WHERE C.LastName = @LastName;
GO

CREATE OR ALTER PROCEDURE IT.GetCustomerByName
	@FirstName NVARCHAR(32),
	@LastName NVARCHAR(32)
AS

SELECT C.CustomerID, C.FirstName, C.LastName
FROM IT.Customers C
WHERE C.FirstName = @FirstName and C.LastName = @LastName;
GO

CREATE OR ALTER PROCEDURE IT.GetCustomerCheckOuts 
	@CustomerID INT
AS

SELECT CO.CheckOutID, CO.ItemID, CO.EmployeeID, CO.CustomerID, CO.CheckedOutOn
FROM IT.Customers C
	INNER JOIN IT.CheckOuts CO on CO.CustomerID = C.CustomerID
WHERE C.CustomerID = @CustomerID
ORDER BY CO.CheckedOutOn;
GO

CREATE OR ALTER PROCEDURE IT.GetCustomerReturns 
	@CustomerID INT
AS

SELECT R.ReturnID, R.ItemID, R.EmployeeID, R.CustomerID, R.CheckedOutID, R.ReturnedOn
FROM IT.Customers C
	INNER JOIN IT.[Returns] R on R.CustomerID = C.CustomerID
WHERE C.CustomerID = @CustomerID
ORDER BY R.ReturnedOn;
GO

CREATE OR ALTER PROCEDURE IT.GetECheckedOutOn
	@CheckedOutDate DATETIMEOFFSET
AS

SELECT E.EmployeeID, E.FirstName, E.LastName
FROM IT.Employees E
	INNER JOIN IT.CheckOuts CO on CO.EmployeeID = E.EmployeeID
WHERE DATEDIFF(DAY, CO.CheckedOutOn, @CheckedOutDate) = 0
GROUP BY E.EmployeeID, E.FirstName, E.LastName;
GO

CREATE OR ALTER PROCEDURE IT.GetEmployeeByFirst
	@FirstName NVARCHAR(32)
AS

SELECT E.EmployeeID, E.FirstName, E.LastName
FROM IT.Employees E
WHERE E.FirstName = @FirstName;
GO

CREATE OR ALTER PROCEDURE IT.GetEmployeeByID
	@EmployeeID INT
AS

SELECT E.EmployeeID, E.FirstName, E.LastName
FROM IT.Employees E
WHERE E.EmployeeID = @EmployeeID;
GO

CREATE OR ALTER PROCEDURE IT.GetEmployeeByLast
	@LastName NVARCHAR(32)
AS

SELECT E.EmployeeID, E.FirstName, E.LastName
FROM IT.Employees E
WHERE E.LastName = @LastName;
GO

CREATE OR ALTER PROCEDURE IT.GetEmployeeByName
	@FirstName NVARCHAR(32),
	@LastName NVARCHAR(32)
AS

SELECT E.EmployeeID, E.FirstName, E.LastName
FROM IT.Employees E
WHERE E.FirstName = @FirstName and E.LastName = @LastName;
GO

CREATE OR ALTER PROCEDURE IT.GetEmployeeCheckOuts 
	@EmployeeID INT
AS

SELECT CO.CheckOutID, CO.ItemID, CO.EmployeeID, CO.CustomerID, CO.CheckedOutOn
FROM IT.Employees E
	INNER JOIN IT.CheckOuts CO on CO.EmployeeID = E.EmployeeID
WHERE E.EmployeeID = @EmployeeID
ORDER BY CO.CheckedOutOn;
GO

CREATE OR ALTER PROCEDURE IT.GetEmployeeReturns 
	@EmployeeID INT
AS

SELECT R.ReturnID, R.ItemID, R.EmployeeID, R.CustomerID, R.CheckedOutID, R.ReturnedOn
FROM IT.Employees E
	INNER JOIN IT.[Returns] R on R.EmployeeID = E.EmployeeID
WHERE E.EmployeeID = @EmployeeID
ORDER BY R.ReturnedOn;
GO

CREATE OR ALTER PROCEDURE IT.GetEReturnedOn
	@ReturnedDate DATETIMEOFFSET
AS

SELECT E.EmployeeID, E.FirstName, E.LastName
FROM IT.Employees E
	INNER JOIN IT.[Returns] R on R.EmployeeID = E.EmployeeID
WHERE DATEDIFF(DAY, R.ReturnedOn, @ReturnedDate) = 0
GROUP BY E.EmployeeID, E.FirstName, E.LastName;
GO

CREATE OR ALTER PROCEDURE IT.GetItemByID
	@ItemID INT
AS

SELECT I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved
FROM IT.Inventory I
WHERE I.ItemID = @ItemID;
GO

CREATE OR ALTER PROCEDURE IT.GetItemBySerialNumber
	@SerialNumber INT
AS

SELECT I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved
FROM IT.Inventory I
WHERE I.SerialNumber = @SerialNumber;
GO

CREATE OR ALTER PROCEDURE IT.GetItemCheckOuts 
	@ItemID INT
AS

SELECT CO.CheckOutID, CO.ItemID, CO.EmployeeID, CO.CustomerID, CO.CheckedOutOn
FROM IT.Inventory I
	INNER JOIN IT.CheckOuts CO on CO.ItemID = I.ItemID
WHERE I.ItemID = @ItemID
ORDER BY CO.CheckedOutOn;
GO

CREATE OR ALTER PROCEDURE IT.GetItemReturns 
	@ItemID INT
AS

SELECT R.ReturnID, R.ItemID, R.EmployeeID, R.CustomerID, R.CheckedOutID, R.ReturnedOn
FROM IT.Inventory I
	INNER JOIN IT.[Returns] R on R.ItemID = I.ItemID
WHERE I.ItemID = @ItemID
ORDER BY R.ReturnedOn;
GO

CREATE OR ALTER PROCEDURE IT.GetItemsByItemName
	@ItemName NVARCHAR(32)
AS

SELECT I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved
FROM IT.Inventory I
WHERE I.ItemName = @ItemName;
GO

CREATE OR ALTER PROCEDURE IT.GetItemsByItemType
	@ItemType NVARCHAR(15)
AS

SELECT I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved
FROM IT.Inventory I
WHERE I.ItemType = @ItemType;
GO

CREATE OR ALTER PROCEDURE IT.GetItemsByCheckedOut
    @IsCheckedOut INT
AS

SELECT I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved
FROM IT.Inventory I
WHERE I.IsCheckedOut = @IsCheckedOut;
GO

CREATE OR ALTER PROCEDURE IT.GetItemsByCheckedOutCID
	@CustomerID INT
AS

SELECT I.ItemID, I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved
FROM IT.Inventory I
	INNER JOIN IT.CheckOuts CO ON CO.ItemID = I.ItemID
WHERE CO.CustomerID = @CustomerID
GROUP BY I.ItemID, I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved;
GO

CREATE OR ALTER PROCEDURE IT.GetMonthlyReport 
	@Month INT,
	@Year INT
AS

SELECT E.EmployeeID, E.FirstName, E.LastName, COUNT(CO.CheckOutID) as CheckoutAmmount
FROM IT.Employees E
	INNER JOIN IT.CheckOuts CO on CO.EmployeeID = E.EmployeeID
WHERE MONTH(CO.CheckedOutOn) = @Month AND YEAR(CO.CheckedOutOn) = @Year
GROUP BY E.EmployeeID, E.FirstName, E.LastName
ORDER BY CheckoutAmmount DESC;
GO

CREATE OR ALTER PROCEDURE IT.GetPopOfItems 
AS

SELECT I.ItemID, I.ItemName, I.ItemType, I.SerialNumber, COUNT(CO.CheckOutID) as NumberOfCheckouts
FROM IT.Inventory I
	INNER JOIN IT.CheckOuts CO on CO.ItemID = I.ItemID
GROUP BY I.ItemID, I.ItemName, I.ItemType, I.SerialNumber
ORDER BY NumberOfCheckouts DESC;
GO

CREATE OR ALTER PROCEDURE IT.GetRemovedItems 
	@IsRemoved INT
AS

SELECT I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved
FROM IT.Inventory I
WHERE I.IsRemoved = @IsRemoved;
GO

CREATE OR ALTER PROCEDURE IT.ItemCheckedOut
	@ItemID INT
AS

UPDATE IT.Inventory 
SET IsCheckedOut = 1
WHERE ItemID = @ItemID
GO

CREATE OR ALTER PROCEDURE IT.ItemReturned
	@ReturnedID INT
AS

UPDATE IT.Inventory 
SET IsCheckedOut = 0
WHERE ItemID =
(
	SELECT CO.ItemID
	FROM IT.CheckOuts CO
		INNER JOIN IT.[Returns] R ON R.CheckedOutID = CO.CheckOutID
	WHERE R.ReturnID = @ReturnedID
)
GO

CREATE OR ALTER PROCEDURE IT.ItemIsRemoved
	@ItemID INT
AS

UPDATE IT.Inventory 
SET IsRemoved = 1
WHERE ItemID = @ItemID
GO

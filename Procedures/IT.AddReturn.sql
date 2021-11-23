/****************************
 * IT.AddReturn.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for adding return
 ****************************/

CREATE OR ALTER PROCEDURE IT.AddReturn
	@ItemID INT,
	@EmployeeID INT,
	@CustomerID INT,
	@ReturnedOn DATETIMEOFFSET,
	@CheckoutID INT ,
	@ReturnID INT OUTPUT
AS

INSERT IT.Customers(FirstName, LastName)
VALUES(@ItemID, @EmployeeID, @CustomerID, @ReturnedOn, @CheckoutID);

SET @ReturnID = SCOPE_IDENTITY()
GO
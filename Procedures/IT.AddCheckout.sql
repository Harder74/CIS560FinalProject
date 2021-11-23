/****************************
 * IT.AddCheckout.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for adding checkout
 ****************************/

 CREATE OR ALTER PROCEDURE IT.AddCheckOut
	@ItemID INT,
	@EmployeeID INT,
	@CustomerID INT,
	@CheckOutOn DATETIMEOFFSET,
	@CheckoutID INT OUTPUT
AS

INSERT IT.Customers(FirstName, LastName)
VALUES(@ItemID, @EmployeeID, @CustomerID, @CheckOutOn);

SET @CheckoutID = SCOPE_IDENTITY()
GO
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
	@CheckoutID INT OUTPUT
AS

INSERT IT.CheckOuts(ItemID, EmployeeID, CustomerID, CheckedOutOn)
VALUES(@ItemID, @EmployeeID, @CustomerID, SYSDATETIMEOFFSET());

SET @CheckoutID = SCOPE_IDENTITY()
GO
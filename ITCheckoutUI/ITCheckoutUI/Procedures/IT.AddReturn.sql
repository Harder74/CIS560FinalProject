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
	@CheckoutID INT ,
	@ReturnID INT OUTPUT
AS

INSERT IT.Returns(ItemID, EmployeeID, CustomerID, ReturnedOn, CheckedOutID)
VALUES(@ItemID, @EmployeeID, @CustomerID, SYSDATETIMEOFFSET(), @CheckoutID);

SET @ReturnID = SCOPE_IDENTITY()
GO
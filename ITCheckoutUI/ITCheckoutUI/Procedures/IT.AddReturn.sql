/****************************
 * IT.AddReturn.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for adding return
 ****************************/

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
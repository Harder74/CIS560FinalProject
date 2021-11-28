/****************************
 * IT.GetItemReturns.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting returns for item
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetItemReturns 
	@ItemID INT
AS

SELECT R.ReturnID, R.ItemID, R.EmployeeID, R.CustomerID, R.CheckedOutID, R.ReturnedOn
FROM IT.Inventory I
	INNER JOIN IT.[Returns] R on R.ItemID = I.ItemID
WHERE I.ItemID = @ItemID
ORDER BY R.ReturnedOn;
/****************************
 * IT.GetItemCheckOuts.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting checkouts for Item
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetItemCheckOuts 
	@ItemID INT
AS

SELECT CO.CheckOutID, CO.ItemID, CO.EmployeeID, CO.CustomerID, CO.CheckedOutOn
FROM IT.Inventory I
	INNER JOIN IT.CheckOuts CO on CO.ItemID = I.ItemID
WHERE I.ItemID = @ItemID
ORDER BY CO.CheckedOutOn;
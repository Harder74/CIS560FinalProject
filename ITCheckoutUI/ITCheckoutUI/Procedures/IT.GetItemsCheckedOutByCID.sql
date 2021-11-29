/****************************
 * IT.GetItemsByCheckedOutCID.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for showing all items checked out by customer.
 ****************************/

CREATE OR ALTER PROCEDURE IT.GetItemsByCheckedOutCID
	@CustomerID INT
AS

SELECT I.ItemID, I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved
FROM IT.Inventory I
	INNER JOIN IT.CheckOuts CO ON CO.ItemID = I.ItemID
WHERE CO.CustomerID = @CustomerID
GROUP BY I.ItemID, I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved;
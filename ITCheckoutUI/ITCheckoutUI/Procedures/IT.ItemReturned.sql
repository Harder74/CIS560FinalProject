/****************************
 * IT.ItemReturned.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for adding return notice to item
 ****************************/

CREATE OR ALTER PROCEDURE IT.ItemReturned
	@ItemID INT
AS

UPDATE IT.Inventory 
SET IsCheckedOut = 0
WHERE ItemID =
(
	SELECT CO.ItemID
	FROM IT.CheckOuts CO
	WHERE CO.ItemID = @ItemID
)
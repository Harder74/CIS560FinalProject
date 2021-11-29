/****************************
 * IT.ItemIsRemoved.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for adding Removed notice to item
 ****************************/


CREATE OR ALTER PROCEDURE IT.ItemIsRemoved
	@ItemID INT
AS

UPDATE IT.Inventory 
SET IsRemoved = 1
WHERE ItemID = @ItemID
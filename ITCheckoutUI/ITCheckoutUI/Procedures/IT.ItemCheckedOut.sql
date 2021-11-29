/****************************
 * IT.ItemCheckedOut.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for adding checkout notice to item
 ****************************/

CREATE OR ALTER PROCEDURE IT.ItemCheckedOut
	@ItemID INT
AS

UPDATE IT.Inventory 
SET IsCheckedOut = 1
WHERE Invetory.ItemID = @ItemID
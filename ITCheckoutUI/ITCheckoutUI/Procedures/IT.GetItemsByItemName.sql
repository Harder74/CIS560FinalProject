/****************************
 * IT.GetItemsByItemName.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting item by item name
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetItemsByItemName
	@ItemName NVARCHAR(32)
AS

SELECT I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved
FROM IT.Inventory I
WHERE I.ItemName = @ItemName;
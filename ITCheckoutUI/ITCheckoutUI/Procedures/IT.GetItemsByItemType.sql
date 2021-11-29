/****************************
 * IT.GetItemsByItemType.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting item by Item type
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetItemsByItemType
	@ItemType NVARCHAR(15)
AS

SELECT I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved
FROM IT.Inventory I
WHERE I.ItemType = @ItemType;
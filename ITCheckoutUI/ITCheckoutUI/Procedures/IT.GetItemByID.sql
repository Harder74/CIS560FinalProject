/****************************
 * IT.GetItemByID.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting item by ID
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetItemByID
	@ItemID INT
AS

SELECT I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved
FROM IT.Inventory I
WHERE I.ItemID = @ItemID;
/****************************
 * IT.GetItemBySerialNumber.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting item by serial number
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetItemBySerialNumber
	@SerialNumber INT
AS

SELECT I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved
FROM IT.Inventory I
WHERE I.SerialNumber = @SerialNumber;
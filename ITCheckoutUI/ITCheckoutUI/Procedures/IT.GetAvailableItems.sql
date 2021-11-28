/****************************
 * IT.GetAvailableItems.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting available items to checkout
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetAvailableItems 
AS

SELECT I.ItemID, I.ItemName, I.ItemType, I.SerialNumber
FROM IT.Inventory I
WHERE I.IsCheckedOut = 0;

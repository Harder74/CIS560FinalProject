/****************************
 * IT.GetPopOfItems.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting Popularity of items
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetPopOfItems 
AS

SELECT I.ItemID, I.ItemName, I.ItemType, I.SerialNumber, COUNT(CO.CheckOutID) as NumberOfCheckouts
FROM IT.Inventory I
	INNER JOIN IT.CheckOuts CO on CO.ItemID = I.ItemID
GROUP BY I.ItemID, I.ItemName, I.ItemType, I.SerialNumber
ORDER BY NumberOfCheckouts DESC;
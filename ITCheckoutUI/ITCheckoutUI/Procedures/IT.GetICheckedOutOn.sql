/****************************
 * IT.GetICheckedOutOn.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting items that are checked out on date
 ****************************/

CREATE OR ALTER PROCEDURE IT.GetICheckedOutOn
	@CheckedOutOn DATETIMEOFFSET
AS
SELECT I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved
FROM IT.Inventory I
	INNER JOIN IT.CheckOuts CO ON CO.ItemID = I.ItemID
WHERE DATEDIFF(DAY, CO.CheckedOutOn, @CheckedOutOn) = 0
GROUP BY I.ItemID, I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved;
GO
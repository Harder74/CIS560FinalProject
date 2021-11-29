/****************************
 * IT.GetItemsByCheckedOut.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting items that are checked out
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetItemsByCheckedOut
    @IsCheckedOut INT
AS

SELECT I.ItemName, I.SerialNumber, I.ItemType, I.IsCheckedOut, I.IsRemoved
FROM IT.Inventory I
WHERE I.IsCheckedOut = @IsCheckedOut;
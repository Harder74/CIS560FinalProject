/****************************
 * IT.AddItem.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for adding item
 ****************************/

 CREATE OR ALTER PROCEDURE IT.AddItem
	@ItemName NVARCHAR(32),
	@SerialNumber NVARCHAR(32),
	@ItemType NVARCHAR(15),
	@IsCheckedOut BIT,
	@IsRemoved BIT,
	@ItemID INT OUTPUT
AS

INSERT IT.Customers(FirstName, LastName)
VALUES(@ItemName, @SerialNumber, @ItemType, @IsCheckedOut, @IsRemoved);

SET @ItemID = SCOPE_IDENTITY()
GO
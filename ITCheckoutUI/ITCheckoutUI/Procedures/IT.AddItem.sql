/****************************
 * IT.AddItem.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for adding item
 ****************************/

CREATE PROCEDURE IT.AddItem
	@ItemName NVARCHAR(32),
	@SerialNumber NVARCHAR(32),
	@ItemType NVARCHAR(15),
	@IsCheckedOut INT,
	@IsRemoved INT,
	@ItemID INT OUTPUT
AS

INSERT IT.Inventory(ItemName, SerialNumber, ItemType, IsCheckedOut, IsRemoved)
VALUES(@ItemName, @SerialNumber, @ItemType, @IsCheckedOut, @IsRemoved);

SET @ItemID = SCOPE_IDENTITY()

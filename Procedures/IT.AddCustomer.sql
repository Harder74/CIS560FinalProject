/****************************
 * IT.AddCustomer.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for adding customer
 ****************************/

 CREATE OR ALTER PROCEDURE IT.AddCustomer
	@FirstName NVARCHAR(32),
	@LastName NVARCHAR(32),
	@CustomerID INT OUTPUT
AS

INSERT IT.Customers(FirstName, LastName)
VALUES(@FirstName, @LastName);

SET @CustomerID = SCOPE_IDENTITY()
GO
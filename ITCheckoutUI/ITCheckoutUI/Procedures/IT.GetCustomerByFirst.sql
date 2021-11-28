/****************************
 * IT.GetCustomerByFirst.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting Customer by name
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetCustomerByFirst
	@FirstName NVARCHAR(32)
AS

SELECT C.CustomerID, C.FirstName, C.LastName
FROM IT.Customers C
WHERE C.FirstName = @FirstName
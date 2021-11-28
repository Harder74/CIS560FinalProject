/****************************
 * IT.GetCustomerByID.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting customer by ID
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetCustomerByID
	@CustomerID INT
AS

SELECT C.CustomerID, C.FirstName, C.LastName
FROM IT.Customers C
WHERE C.CustomerID = @CustomerID;
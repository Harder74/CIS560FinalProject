/****************************
 * IT.GetCustomerReturns.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting returns for customer
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetCustomerReturns 
	@CustomerID INT
AS

SELECT R.ReturnID, R.ItemID, R.EmployeeID, R.CustomerID, R.CheckedOutID, R.ReturnedOn
FROM IT.Customers C
	INNER JOIN IT.[Returns] R on R.CustomerID = C.CustomerID
WHERE C.CustomerID = @CustomerID
ORDER BY R.ReturnedOn;
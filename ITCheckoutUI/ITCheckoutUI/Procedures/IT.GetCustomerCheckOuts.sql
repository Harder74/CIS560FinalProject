/****************************
 * IT.GetCustomerCheckOuts.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting checkouts for customer
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetCustomerCheckOuts 
	@CustomerID INT
AS

SELECT CO.CheckOutID, CO.ItemID, CO.EmployeeID, CO.CustomerID, CO.CheckedOutOn
FROM IT.Customers C
	INNER JOIN IT.CheckOuts CO on CO.CustomerID = C.CustomerID
WHERE C.CustomerID = @CustomerID
ORDER BY CO.CheckedOutOn;
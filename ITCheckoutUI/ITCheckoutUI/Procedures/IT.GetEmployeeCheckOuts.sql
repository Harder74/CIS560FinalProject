/****************************
 * IT.GetEmployeeCheckOuts.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting checkouts for employee
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetEmployeeCheckOuts 
	@EmployeeID INT
AS

SELECT CO.CheckOutID, CO.ItemID, CO.EmployeeID, CO.CustomerID, CO.CheckedOutOn
FROM IT.Employees E
	INNER JOIN IT.CheckOuts CO on CO.EmployeeID = E.EmployeeID
WHERE E.EmployeeID = @EmployeeID
ORDER BY CO.CheckedOutOn;
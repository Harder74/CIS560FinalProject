/****************************
 * IT.GetEmployeeReturns.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting returns for employee
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetEmployeeReturns 
	@EmployeeID INT
AS

SELECT R.ReturnID, R.ItemID, R.EmployeeID, R.CustomerID, R.CheckedOutID, R.ReturnedOn
FROM IT.Employees E
	INNER JOIN IT.[Returns] R on R.EmployeeID = E.EmployeeID
WHERE E.EmployeeID = @EmployeeID
ORDER BY R.ReturnedOn;
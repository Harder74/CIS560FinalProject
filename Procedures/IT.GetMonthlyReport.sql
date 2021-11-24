/****************************
 * IT.GetMonthlyReport.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting Monthly checkout report for employees
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetMonthlyReport 
	@Month INT,
	@Year INT
AS

SELECT E.EmployeeID, E.FirstName, E.LastName, COUNT(CO.CheckOutID) as CheckoutAmmount
FROM IT.Employees E
	INNER JOIN IT.CheckOuts CO on CO.EmployeeID = E.EmployeeID
WHERE MONTH(CO.CheckedOutOn) = @Month AND YEAR(CO.CheckedOutOn) = @Year
GROUP BY E.EmployeeID, E.FirstName, E.LastName
ORDER BY CheckoutAmmount DESC;
/****************************
 * IT.GetECheckedOutOn.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting employees that chacked out a customer on specific date
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetECheckedOutOn
	@CheckedOutDate DATETIMEOFFSET
AS

SELECT E.EmployeeID, E.FirstName, E.LastName
FROM IT.Employees E
	INNER JOIN IT.CheckOuts CO on CO.EmployeeID = E.EmployeeID
WHERE DATEDIFF(DAY, CO.CheckedOutOn, @CheckedOutDate) = 0
GROUP BY E.EmployeeID, E.FirstName, E.LastName;
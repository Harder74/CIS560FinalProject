/****************************
 * IT.GetEReturnedOn.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting employees that returned an item for a customer on specific date
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetEReturnedOn
	@ReturnedDate DATETIMEOFFSET
AS

SELECT E.EmployeeID, E.FirstName, E.LastName
FROM IT.Employees E
	INNER JOIN IT.[Returns] R on R.EmployeeID = E.EmployeeID
WHERE DATEDIFF(DAY, R.ReturnedOn, @ReturnedDate) = 0
GROUP BY E.EmployeeID, E.FirstName, E.LastName;
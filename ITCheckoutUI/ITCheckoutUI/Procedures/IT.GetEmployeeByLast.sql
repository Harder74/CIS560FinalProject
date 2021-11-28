/****************************
 * IT.GetEmployeeByLast.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting employees by last name
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetEmployeeByLast
	@LastName NVARCHAR(32)
AS

SELECT E.EmployeeID, E.FirstName, E.LastName
FROM IT.Employees E
WHERE E.LastName = @LastName;
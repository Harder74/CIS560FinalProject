/****************************
 * IT.GetEmployeeByName.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting employee by name
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetEmployeeByName
	@FirstName NVARCHAR(32),
	@LastName NVARCHAR(32)
AS

SELECT E.EmployeeID, E.FirstName, E.LastName
FROM IT.Employees E
WHERE E.FirstName = @FirstName and E.LastName = @LastName;
/****************************
 * IT.GetEmployeeByFirst.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting employees by first name
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetEmployeeByFirst
	@FirstName NVARCHAR(32)
AS

SELECT E.EmployeeID, E.FirstName, E.LastName
FROM IT.Employees E
WHERE E.FirstName = @FirstName;
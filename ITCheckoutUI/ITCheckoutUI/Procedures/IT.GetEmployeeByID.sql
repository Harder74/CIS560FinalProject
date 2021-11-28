/****************************
 * IT.CheckoutsNotReturned.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting employee by ID
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetEmployeeByID
	@EmployeeID INT
AS

SELECT E.EmployeeID, E.FirstName, E.LastName
FROM IT.Employees E
WHERE E.EmployeeID = @EmployeeID;
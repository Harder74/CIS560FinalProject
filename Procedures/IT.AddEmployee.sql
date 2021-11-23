/****************************
 * IT.AddEmployee.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for adding employee
 ****************************/

 CREATE OR ALTER PROCEDURE IT.AddEmployee
	@FirstName NVARCHAR(32),
	@LastName NVARCHAR(32),
	@EmployeeID INT OUTPUT
AS

INSERT IT.Employees(FirstName, LastName)
VALUES(@FirstName, @LastName);

SET @EmployeeID = SCOPE_IDENTITY()
GO
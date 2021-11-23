/****************************
 * IT.GetCCheckedOutOn.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting Customer that chacked out a customer on specific date
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetCCheckedOutOn
	@CheckedOutDate DATETIMEOFFSET
AS

SELECT C.CustomerID, C.FirstName, C.LastName
FROM IT.Customers C
	INNER JOIN IT.CheckOuts CO on CO.EmployeeID = C.CustomerID
WHERE CO.CheckedOutOn = @CheckedOutDate
GROUP BY C.CustomerID, C.FirstName, C.LastName;
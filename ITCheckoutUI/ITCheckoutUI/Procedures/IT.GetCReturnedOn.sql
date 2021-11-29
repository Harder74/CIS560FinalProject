/****************************
 * IT.GetCReturnedOn.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for getting customer that returned an item on specific date
 ****************************/


CREATE OR ALTER PROCEDURE IT.GetCReturnedOn
	@ReturnedDate DATETIMEOFFSET
AS

SELECT C.CustomerID, C.FirstName, C.LastName
FROM IT.Customers C
	INNER JOIN IT.[Returns] R on R.CustomerID = C.CustomerID
WHERE DATEDIFF(DAY, R.ReturnedOn, @ReturnedDate) = 0
GROUP BY C.CustomerID, C.FirstName, C.LastName;
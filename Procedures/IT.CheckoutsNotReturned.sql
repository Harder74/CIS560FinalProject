/****************************
 * IT.CheckoutsNotReturned.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Procedure for showing all checkouts for customer that have yet to be returned
 ****************************/

CREATE OR ALTER PROCEDURE IT.CheckoutsNotReturned
	@CustomerID INT
AS

SELECT CO.ItemID, I.ItemName, I.SerialNumber, CO.CheckOutID, E.FirstName, E.LastName
FROM IT.CheckOuts CO
	INNER JOIN IT.Inventory I on I.ItemID = CO.ItemID
	INNER JOIN IT.Employees E on E.EmployeeID = CO.EmployeeID
WHERE CO.CustomerID = @CustomerID and NOT EXISTS 
(
	SELECT *
	FROM IT.[Returns] R
	WHERE CO.CheckOutID = R.CheckedOutID
)
ORDER BY CO.CheckedOutOn;
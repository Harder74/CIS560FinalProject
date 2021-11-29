/****************************
 * IT.DataCreation.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Script for adding data to tables
 ****************************/


BULK INSERT IT.Inventory
FROM 'D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\MockData\MockItems2.csv'
WITH
(
    FIRSTROW = 2, -- as 1st one is header
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
)
GO

BULK INSERT IT.Customers
FROM 'D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\MockData\MockCustomers.csv'
WITH
(
    FIRSTROW = 2, -- as 1st one is header
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
)
GO

BULK INSERT IT.Employees
FROM 'D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\MockData\MockEmployees.csv'
WITH
(
    FIRSTROW = 2, -- as 1st one is header
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
)
GO

BULK INSERT IT.CheckOuts
FROM 'D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\MockData\MockCheckOuts.csv'
WITH
(
	CHECK_CONSTRAINTS, 
    FIRSTROW = 2, -- as 1st one is header
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
)
GO

BULK INSERT IT.[Returns]
FROM 'D:\K-State\CIS560\Final\CIS560FinalProject\ITCheckoutUI\ITCheckoutUI\MockData\MockReturns.csv'
WITH
(
    FIRSTROW = 2, -- as 1st one is header
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
)
GO

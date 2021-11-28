/****************************
 * SchemaCreation.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Script for Schema Creation
 ****************************/
 IF NOT EXISTS
 (
	SELECT *
	FROM sys.schemas s
	WHERE s.[name] = N'IT'
 )
 BEGIN
	EXEC(N'CREATE SCHEMA [IT]')
	GRANT EXECUTE ON DATABASE :: ITDB TO db_execute
END;
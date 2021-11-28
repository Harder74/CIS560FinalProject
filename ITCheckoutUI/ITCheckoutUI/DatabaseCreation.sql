/****************************
 * DatabaseCreation.sql
 * Final Project CIS 560
 * Author: Tyler Harder, Zach Hazen, Eric Kyle
 * Setup Script for Database Creation
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.databases s
      WHERE s.[name] = N'ITDB'
   )
BEGIN
   EXEC(N'CREATE DATABASE ITDB');
END;

USE bucky;

CREATE TABLE [tblContacts]
	(
	 [ID] INT IDENTITY NOT NULL
	,[FIRSTNAME] NVARCHAR(100)
	,[LASTNAME] NVARCHAR(100)
	)

SELECT * FROM [bucky].[dbo].[tblContacts]
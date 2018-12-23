CREATE TABLE [dbo].[People]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(100) NOT NULL, 
    [LastName] NVARCHAR(100) NOT NULL, 
    [EmailAddress] NVARCHAR(100) NOT NULL,
    [CellphoneNumber] VARCHAR(20) NOT NULL,
)

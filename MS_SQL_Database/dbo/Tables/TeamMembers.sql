CREATE TABLE [dbo].[TeamMembers]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TeamId] INT NOT NULL, 
    [PersonId] INT NOT NULL, 
)

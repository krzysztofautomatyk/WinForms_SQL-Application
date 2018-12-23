CREATE TABLE [dbo].[TeamMembers]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TeamId] INT NOT NULL, 
    [PersonId] INT NOT NULL, 
    CONSTRAINT [FK_TeamMembers_ToTable] FOREIGN KEY ([TeamId]) REFERENCES [Teams]([id]), 
    CONSTRAINT [FK_TeamMembers_ToTable_1] FOREIGN KEY ([PersonId]) REFERENCES [People]([id]), 
)

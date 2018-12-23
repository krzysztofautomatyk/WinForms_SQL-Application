CREATE TABLE [dbo].[Matchups]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [WinnerId] INT NOT NULL, 
    [MatchupRound] INT NOT NULL, 
    CONSTRAINT [FK_Matchups_ToTable] FOREIGN KEY ([WinnerId]) REFERENCES [Teams]([id]), 
)

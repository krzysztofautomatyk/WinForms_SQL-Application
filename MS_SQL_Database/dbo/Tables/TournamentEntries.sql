CREATE TABLE [dbo].[TournamentEntries]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TournamentId] INT NOT NULL, 
    [TeamId] INT NOT NULL, 
    CONSTRAINT [FK_TournamentEntries_ToTable] FOREIGN KEY ([TournamentId]) REFERENCES [Tournaments]([id]), 
    CONSTRAINT [FK_TournamentEntries_ToTable_1] FOREIGN KEY ([TeamId]) REFERENCES [Teams]([id]), 
)

CREATE TABLE [dbo].[TournamentEntries]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TournamentId] INT NOT NULL, 
    [TeamId] INT NOT NULL, 
)

CREATE TABLE [dbo].[MatchupEntries]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MatchupId] INT NOT NULL, 
    [ParentMatchupId] INT NOT NULL, 
    [TeamCompetingId] INT NOT NULL,
    [Score] INT NOT NULL, 
)

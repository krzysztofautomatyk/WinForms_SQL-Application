CREATE TABLE [dbo].[MatchupEntries]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MatchupId] INT NOT NULL, 
    [ParentMatchupId] INT NOT NULL, 
    [TeamCompetingId] INT NOT NULL,
    [Score] INT NOT NULL, 
    CONSTRAINT [FK_MatchupEntries_ToTable] FOREIGN KEY ([MatchupId]) REFERENCES [Matchups]([id]), 
    CONSTRAINT [FK_MatchupEntries_ToTable_1] FOREIGN KEY ([ParentMatchupId]) REFERENCES [TeamMembers]([id]), 
    CONSTRAINT [FK_MatchupEntries_ToTable_2] FOREIGN KEY ([TeamCompetingId]) REFERENCES [TeamMembers]([id])

    
)

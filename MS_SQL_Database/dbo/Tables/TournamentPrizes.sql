CREATE TABLE [dbo].[TournamentPrizes]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TournamentId] INT NOT NULL, 
    [PrizeId] INT NOT NULL, 
    CONSTRAINT [FK_TournamentPrizes_ToTable] FOREIGN KEY ([TournamentId]) REFERENCES [Tournaments]([id]), 
    CONSTRAINT [FK_TournamentPrizes_ToTable_1] FOREIGN KEY ([PrizeId]) REFERENCES [Prizes]([id]), 
)

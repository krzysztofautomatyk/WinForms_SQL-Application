CREATE TABLE [dbo].[TournamentPrizes]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TournamentId] INT NOT NULL, 
    [PrizeId] INT NOT NULL, 
)

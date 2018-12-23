CREATE TABLE [dbo].[Tournaments]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TournamentName]  NVARCHAR(100) NOT NULL, 
    [EntryFee] NVARCHAR(100) NOT NULL, 
)

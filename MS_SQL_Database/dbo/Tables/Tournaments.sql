CREATE TABLE [dbo].[Tournaments]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TournamentName]  NVARCHAR(200) NOT NULL, 
    [EntryFee] MONEY NOT NULL, 
    [Active] BIT NOT NULL, 
)

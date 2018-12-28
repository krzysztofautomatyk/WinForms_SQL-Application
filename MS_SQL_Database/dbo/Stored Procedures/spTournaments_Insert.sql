CREATE PROCEDURE [dbo].[spTournaments_Insert]
	@TournamentName NVARCHAR(200),
	@EntryFee MONEY,
	--@Active BIT,	
	@id int=0 output

AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO DBO.Tournaments
			(TournamentName,
			EntryFee,
			Active	)

	VALUES (@TournamentName,
			@EntryFee,
			1);

	SELECT @id = SCOPE_IDENTITY();
END
GO
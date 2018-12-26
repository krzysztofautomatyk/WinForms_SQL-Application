CREATE PROCEDURE [dbo].[spTeamMembers_Insert]
	@TeamId INT,
	@PersonId INT,	
	@id int=0 output

AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO DBO.TeamMembers
			(TeamId,PersonId)

	VALUES (@TeamId,@PersonId);

	SELECT @id = SCOPE_IDENTITY();
END
GO



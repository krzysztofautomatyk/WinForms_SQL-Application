CREATE PROCEDURE [dbo].[spTeam_Insert]
	@TeamName NVARCHAR(100),	
	@id int=0 output

AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO DBO.Teams
			(TeamName)

	VALUES (@TeamName);

	SELECT @id = SCOPE_IDENTITY();
END
GO


 
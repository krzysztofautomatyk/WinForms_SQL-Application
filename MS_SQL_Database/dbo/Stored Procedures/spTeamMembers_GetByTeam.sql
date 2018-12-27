CREATE PROCEDURE [dbo].[spTeamMembers_GetByTeam]


@TeamId INT
AS
BEGIN
	SET NOCOUNT ON;

	SELECT  p. * FROM  DBO.TeamMembers m
	inner join dbo.People p on m.PersonId=p.id
	WHERE m.TeamId = @TeamId;
	

END
GO
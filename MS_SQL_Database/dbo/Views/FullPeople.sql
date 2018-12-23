CREATE VIEW [dbo].[FullPeople]
	AS SELECT [p].[id], [p].[FirstName], [p].[LastName], [p].[EmailAddress], [p].[CellphoneNumber], 
			  [a].[TeamId], [a].[PersonId] 
	From dbo.People p
	left join dbo.TeamMembers a ON p.id = a.PersonId
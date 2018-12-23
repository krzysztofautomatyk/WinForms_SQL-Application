CREATE PROCEDURE [dbo].[spPeople_filter_by_lastName]
	@LastName nvarchar(50)
AS
begin
	select [id], [FirstName], [LastName], [EmailAddress], [CellphoneNumber]
	from dbo.People
	where LastName=@LastName;
end
	
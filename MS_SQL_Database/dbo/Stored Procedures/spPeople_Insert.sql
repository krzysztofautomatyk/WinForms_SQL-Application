CREATE PROCEDURE [dbo].[spPeople_Insert]
	@FirstName NVARCHAR(100),
	@LastName NVARCHAR(100),
	@EmailAddress NVARCHAR(100),
	@CellphoneNumber VARCHAR(20),	
	@id int=0 output

AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO DBO.People
			(FirstName,
			LastName,
			EmailAddress,
			CellphoneNumber	)

	VALUES (@FirstName,
			@LastName,
			@EmailAddress,
			@CellphoneNumber);

	SELECT @id = SCOPE_IDENTITY();
END
GO



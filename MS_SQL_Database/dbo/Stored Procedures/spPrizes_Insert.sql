CREATE PROCEDURE [dbo].[spPrizes_Insert]
	@PlaceNumber int,
	@PlaceName NVARCHAR(50),
	@PrizeAmount MONEY,
	@PrizePercentage FLOAT,
	@id int=0 output

AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO DBO.Prizes (PlaceNumber,PlaceName,PrizeAmount,PrizePercentage)
	VALUES (@PlaceNumber,@PlaceName,@PrizeAmount,@PrizePercentage);

	SELECT @id = SCOPE_IDENTITY();
END
GO

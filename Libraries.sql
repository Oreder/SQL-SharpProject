USE Airlines;
GO

IF OBJECT_ID('fnGetNumberOfSeats') IS NOT NULL
	DROP FUNCTION dbo.fnGetNumberOfSeats;
GO
CREATE FUNCTION [dbo].[fnGetNumberOfSeats](@AirplaneID int)
RETURNS int
BEGIN
	RETURN (SELECT [NumberOfSeats] 
			FROM [dbo].[Airplanes]
			WHERE [dbo].[Airplanes].[AirplaneID] = @AirplaneID
	)
END
GO

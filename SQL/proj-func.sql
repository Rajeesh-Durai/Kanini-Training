-- ================================================
-- Template generated from Template Explorer using:
-- Create Scalar Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Rajeesh
-- Create date: 
-- Description:	
-- =============================================
CREATE or alter FUNCTION nameofsailor (@sailorid int)

RETURNS nvarchar(20)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @name nvarchar(20)

	-- Add the T-SQL statements to compute the return value here
	SELECT @name=sname from SAILOR where sailorid=@sailorid ;

	-- Return the result of the function
	RETURN @name

END
GO


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
CREATE or ALTER FUNCTION udf_EmpNameDisp 
(
	-- Add the parameters for the function here
	@appraisal int, @sal int
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE  @totsal int

	-- Add the T-SQL statements to compute the return value here
	
	set @totsal=@appraisal+@sal;
	
	-- Return the result of the function
	RETURN @totsal

END
GO


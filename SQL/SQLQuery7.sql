-- ================================================
-- Template generated from Template Explorer using:
-- Create Inline Function (New Menu).SQL
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
CREATE or alter FUNCTION udf_EmpName 
(	
	-- Add the parameters for the function here
	@enum int
)
RETURNS  nvarchar(20)
AS
begin
RETURN 
(
	-- Add the SELECT statement with parameter references here
 SELECT sname from student where rno=@enum
)
end
GO

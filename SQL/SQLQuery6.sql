-- ================================================
-- Template generated from Template Explorer using:
-- Create Multi-Statement Function (New Menu).SQL
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
-- Author:		RAja
-- Create date: 
-- Description:	
-- =============================================
CREATE or alter FUNCTION udf_Emp 
(
	-- Add the parameters for the function here

	
)
RETURNS @x TABLE 
(
	-- Add the column definitions for the TABLE variable here
	eno int , ename nvarchar(20)
)
AS
BEGIN
	-- Fill the table variable with the rows for your result set
	with Emp_Temp(num,na)
	AS (SELECT rno,sname from student )
	INSERT @x 
	SELECT num, na From Emp_Temp
	RETURN 
END
GO
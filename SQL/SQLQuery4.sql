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
-- Author:		Raja
-- Create date: 
-- Description:	
-- =============================================
CREATE OR ALTER FUNCTION udf_StaffManager 
(
	-- Add the parameters for the function here

)
RETURNS @staffman TABLE 
(
	-- Add the column definitions for the TABLE variable here
	staffcod int, stafname nvarchar(20),mgcode int, stafadd nvarchr(50);
)
AS
BEGIN WITH Staffman_Temp(v1, v2, v3, v4) AS (
		-- Fill the table variable with the rows for your result set
		select s.staffcod, s.stafname, s.mgcode, m.stafadd
		from staff_Master s join staff_Master m
		on s.Staff_Code=m.Staff_Code
	)

	
	RETURN 
END
GO
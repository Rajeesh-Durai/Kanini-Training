USE [sample]
GO
/****** Object:  StoredProcedure [dbo].[EmplNameDispl]    Script Date: 16-03-2023 05:08:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Rajeesh
-- Create date: 13/3/2022
-- Description:	First Stored Procedure
-- =============================================
ALTER PROCEDURE [dbo].[EmplNameDispl] 
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT rno,sname from student; 
END

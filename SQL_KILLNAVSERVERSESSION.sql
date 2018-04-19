USE [master]
GO

/****** Object:  StoredProcedure [dbo].[SP_SQL_KillNavServerSession]    Script Date: 18/04/2018 15.53.29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author: 	Roberto Stefanetti
-- Create date: 13/10/2015
-- Description:	KILL ALL NAV ACTIVE USER SESSSIONS WITH MULTIPLE INSTANCES (>1)
-- =============================================
CREATE PROCEDURE [dbo].[SP_SQL_KillNavServerSession]
AS
BEGIN
	DECLARE @RowIndex AS INT;
	DECLARE @MaxIndex AS INT;
	----------------------------

	SET @RowIndex = 1;
	SELECT @MaxIndex = 
	 (SELECT top 1 MIN([Session ID])
	  FROM [COMPANY].[dbo].[Active Session] 
	  WHERE [User ID] = 'DOMAIN\SERVICE' 
	  group by [Session ID])

	-- Remove Active Session 
	DELETE FROM [COMPANY][dbo].[Active Session] where [Session ID]>@MaxIndex AND [User ID] = 'DOMAIN\SERVICE' 
END

GO


USE [master]
GO

/****** Object:  StoredProcedure [dbo].[SP_SQL_KillNoNavSession]    Script Date: 18/04/2018 15.53.50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: 	Roberto Stefantti
-- Create date: <13/01/2017>
-- Description:	KILL SLEEPING NO NAV SESSIONS
-- =============================================
CREATE PROCEDURE [dbo].[SP_SQL_KillNoNavSession]
AS
BEGIN
----------------------------------------------------------------------------
-- Variable
----------------------------------------------------------------------------
DECLARE @Session TABLE
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	[sid] int,
	ltime DATETIME,
	hname varchar(MAX),
	uid varchar(100),
	lret datetime,
	etime int
);

DECLARE @NotAffectedUserList TABLE
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	[uid] varchar(MAX)
);

DECLARE	@session_time as int;
DECLARE @vSID as int;
DECLARE @command as varchar(MAX);
DECLARE @RowIndex AS INT;
DECLARE @MaxIndex AS INT;
----------------------------

set @session_time=15; -- Assign Session time in Minutes

-- Assign List of Users who "will not be affected" by this Session Kill
INSERT into @NotAffectedUserList SELECT 'sa'
INSERT into @NotAffectedUserList SELECT 'NT AUTHORITY\SERVIZIO DI RETE'
INSERT into @NotAffectedUserList SELECT 'DOMAIN\SERVICE' 
INSERT into @NotAffectedUserList SELECT 'scheduler'

INSERT into @Session
SELECT 
    session_id as [Session ID],
    login_time as [Login Time],
    host_name as [Host Name],
    LOGIN_NAME as [Login ID],    
    last_request_end_time as [Last Request End Time],
    DATEDIFF(minute,  last_request_end_time,getdate()) as[Elapsed Time (minutes)]
FROM 
    sys.dm_exec_sessions
WHERE 
open_transaction_count = 0 
AND host_name <> 'NAV-SERVER' COLLATE Latin1_General_CI_AS
AND host_name <> 'SQL-SERVER' COLLATE Latin1_General_CI_AS
AND host_name is not NULL
AND DATEDIFF(minute,  last_request_end_time,getdate())>=@session_time
--AND client_version=4
AND login_name COLLATE Latin1_General_CI_AS not in
(
	SELECT DISTINCT uid 
	FROM @NotAffectedUserList
)


SET @RowIndex = 1;
SELECT @MaxIndex = MAX(id) FROM @Session;

WHILE( @RowIndex <= @MaxIndex)
BEGIN
	SELECT @vSID = sid
	FROM @Session 
	WHERE id = @RowIndex;

	-- String together the KILL statement
	SELECT @command = 'KILL ' + CAST(@vSID AS varchar(5))

	BEGIN TRY

		-- Execute the final string to KILL the spids
		EXEC (@command)
		

	END TRY
	BEGIN CATCH
		declare @emsg varchar(500);
		SELECT 
        @emsg=ERROR_MESSAGE();

		print @emsg;
	END CATCH

	SET @RowIndex = @RowIndex + 1;
END;
END
GO


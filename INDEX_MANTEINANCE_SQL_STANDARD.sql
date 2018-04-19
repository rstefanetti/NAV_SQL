USE [master]
GO

/****** Object:  StoredProcedure [dbo].[sp_index_maintenance_standard]    Script Date: 18/04/2018 15.52.52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_index_maintenance_standard]

AS

DECLARE @RowThreshold INT
DECLARE @PercentThreshold DECIMAL(38,10)

/***********************************************************************************************************************************
*************SET PARAMETERS*********************************************************************************************************/

SET @RowThreshold		= 1000	--Threshold for the number of rows.  In the number of rows in the index is less that the threshold 
								--then it will skip it completely.
SET @PercentThreshold	= 50	--FOR THIS SCRIPT 50 = 50%
								--Fragmentation threshold percentage.  If greater than or equal to this amount them REBUILD the Index
								--If less than this amount REORGANIZE the index
						
/************SET PARAMETERS*********************************************************************************************************
************************************************************************************************************************************/

SET NOCOUNT ON

DECLARE @tablename SYSNAME;
DECLARE @index_name SYSNAME;
DECLARE @percentfrag DECIMAL(38,10);
DECLARE @command VARCHAR(8000);
DECLARE @command2 VARCHAR(8000);
DECLARE Index_Maint CURSOR FOR


SELECT
o.name,
i.name,
f.avg_fragmentation_in_percent
FROM SYS.DM_DB_INDEX_PHYSICAL_STATS (DB_ID(), NULL, NULL , NULL, 'LIMITED') f
JOIN sys.objects o on o.object_id = f.object_id
JOIN sys.indexes i on i.object_id = f.object_id and i.index_id = f.index_depth 
WHERE f.index_id > 0

OPEN Index_Maint

FETCH NEXT FROM Index_Maint INTO 
	  @tablename, @index_name, @percentfrag

While @@FETCH_STATUS = 0
BEGIN

	IF @percentfrag >= @PercentThreshold
		BEGIN
			SELECT @command2 = 'ALTER INDEX ' + '[' + @index_name + ']' + ' ON ' + '[' + @tablename + ']' + ' REBUILD WITH(MAXDOP=0)'; --Take advantage of parallelism
			EXEC (@command2);
			PRINT 'Executed ' + @command2;
		END; 
	ELSE
		BEGIN
			SELECT @command = 'ALTER INDEX ' + '[' + @index_name + ']' + ' ON ' + '[' + @tablename + ']' + ' REORGANIZE';
			EXEC (@command);	
			PRINT 'Executed ' + @command;
		END;			
						
FETCH NEXT FROM Index_Maint INTO 
	  @tablename, @index_name, @percentfrag
END 

CLOSE Index_Maint
DEALLOCATE Index_Maint

GO


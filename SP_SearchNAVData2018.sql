USE [Demo Database NAV ITA (11-0)]
GO

/****** Object:  StoredProcedure [dbo].[SP_SearchNAVData2018]    Script Date: 04/04/2018 15:43:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_SearchNAVData2018] 
(
	@SearchStr nvarchar(100)
)


AS
BEGIN  	
	CREATE TABLE #Columns (ColumnID integer not null , ColumnName nvarchar(370));	
	CREATE TABLE #Results (ColumnName nvarchar(370), ColumnValue nvarchar(3630));
	SET NOCOUNT ON
 
	DECLARE @TableName nvarchar(256), @ColumnName nvarchar(128), @SearchStr2 nvarchar(110)
	DECLARE @ColumnID integer ;
	DECLARE @sql_string nvarchar(256);	
	DECLARE @Text AS VARCHAR(100)
	DECLARE @Cmd AS VARCHAR(100)
	DECLARE @CategoryID integer;
	SET @ColumnID = 1 ;
	SET @TableName = '';
	SET @SearchStr2 = QUOTENAME('%' + @SearchStr + '%',''''); 
	SET @ColumnName = ''	
	SET @sql_string = ''
	SET @CategoryID = 0;

	--DELETE LAST SEARCH DATA
	DELETE [dbo].[CRONUS Italia S_p_A_$Privacy Data Search Output]
		
	--TABLE CURSOR
	DECLARE db_cursor CURSOR FOR   
	SELECT [Table] FROM [CRONUS Italia S_p_A_$Privacy Tables Configurator] 				
	
	OPEN db_cursor  
	FETCH NEXT FROM db_cursor INTO @TableName  
	
	WHILE @@FETCH_STATUS = 0 				 		
		BEGIN	
			DECLARE fields_cursor CURSOR FOR  
			SELECT (QUOTENAME(COLUMN_NAME))
			FROM   INFORMATION_SCHEMA.COLUMNS
			WHERE  TABLE_NAME    = PARSENAME(@TableName, 1)
			AND    DATA_TYPE IN ('char', 'varchar', 'nchar', 'nvarchar', 'int', 'decimal')
			
			--FIELD CURSOR
			OPEN fields_cursor  
			FETCH NEXT FROM fields_cursor INTO @ColumnName 
			PRINT @SearchStr + ' Foud IN: ' -- TARGET SEARCH		
			  	
			WHILE @@FETCH_STATUS = 0 
			   BEGIN			   
					IF @ColumnName IS NOT NULL
						BEGIN							
						
						--SQL PREPARE
						SET @sql_string = '';
						SET @sql_string = 'IF EXISTS (SELECT * FROM ' + @TableName + ' WHERE ' + @ColumnName + ' 
							LIKE ''%' + @SearchStr + '%'') PRINT ''' + @TableName + ', ' + @ColumnName + ''''											
							
						-- DATA PRINT RESULTS
						EXECUTE(@sql_string)	
													
						-- DATA WRITE IN TABLE
						DECLARE @DynamicSQl varchar(250);	
						DECLARE @ColumnLocal varchar(50);									
						SET @DynamicSQl = 'SELECT * FROM ' + @TableName + ' WHERE ' + @ColumnName + ' LIKE ''%' + @SearchStr + '%''';
						EXEC (@DynamicSQl)						
						
						If @@RowCount > 0			    
							BEGIN
								PRINT 'Entrato'								
								-- EXEC(@SomeOtherSQLStatement)
								INSERT INTO [dbo].[CRONUS Italia S_p_A_$Privacy Data Search Output]
										([Table]
										,[Field]
										,[Search Results])
								VALUES
										(@TableName
										,@ColumnName
										,@SearchStr)
							END																																	
									
					END	
				
					FETCH NEXT FROM fields_cursor INTO @ColumnName 
				END  -- END  Fields Cursor
				
				CLOSE fields_cursor  
				DEALLOCATE fields_cursor

			FETCH NEXT FROM db_cursor INTO @Tablename
		END --END db Cursor
		
				
		
		CLOSE db_cursor  
		DEALLOCATE db_cursor
		
		RETURN
		
END

GO

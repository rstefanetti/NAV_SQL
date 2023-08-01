//#2 - Create Missing Indexes - exec SQL Stored Procedure
procedure Createmissingindex(parBCEnv: Code[100])
    var
        Query2Exec: Text[1024];
        ShipLineFilters: Text[250];
        WhereFilter: Text[1024];      
        TxtProcess: label 'Processing';
        StartingDateTime: DateTime;    

    begin  
                  
        if IsNull(SQLConnectionDN) then
            SQLConnect(); 

	Query2Exec := ''; 
        Query2Exec := 'sp_CreateMissIndexBC';  //SQL Stored Procedure
        parBCEnv := '';
        parBCEnv := '[' + SQLConnSetup."Database Name" + ']'; 

        Clear(SQLCommand);
        SQLCommand := SQLConnectionDN.CreateCommand();
        SQLCommand.CommandText(Query2Exec);
        SQLCommand.CommandType := SQLCommand.CommandType::StoredProcedure;  
        SQLCommand.CommandTimeout := 180; 
 
        Clear(SQLParameter);
        SQLParameter := SQLParameter.SqlParameter();
        SQLParameter.ParameterName := '@BCEnv';
        SQLParameter.DbType := SQLParameter.DbType::String;
        SQLParameter.Size := 100;
        SQLParameter.Value := parBCEnv;   
        SQLParameter.Direction := SQLParameter.Direction.Input;
        SQLCommand.Parameters.Add(SQLParameter); 
        SQLCommand.ExecuteNonQuery();

        SQLConnectionDN.Close();
        Clear(SQLCommand);
        Clear(SQLConnectionDN); 

    end;

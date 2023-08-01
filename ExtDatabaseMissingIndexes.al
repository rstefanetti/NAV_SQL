//#1 - Extend Page Database Missing Indexes
pageextension 85001 "ExtDatabase Missing Indexes" extends "Database Missing Indexes"
{
    layout
    {
        
    } 

    actions
    {
        addfirst(Processing)
        {
            action(AltERtest)
            {

                ApplicationArea = All;
                Caption = 'Create missing index', Comment = 'Creazione indici mancanti';
                Promoted = true;
                PromotedCategory = Process;
                PromotedIsBig = true;
                Image = Process; 

                trigger OnAction();
                begin
                    CLEAR(AddFunctions);
                    AddFunctions.Createmissingindex('');
                end; 
            }
        }
    }

    var
        AddFunctions: Codeunit AdditionalFunctionSQL

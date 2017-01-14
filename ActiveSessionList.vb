'DECLARE SQL ACCESS OBJECTS
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms


Public Class ActiveSessionList

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
        Me.Active_SessionTableAdapter.Fill(Me._Demo_Database_NAV__10_0_DataSet.Active_Session)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' you can use datagrid if necessary and loop on it to kill process directly  'DataGridView1.Select()
        ' i prefer to build a new sql connection to "Active Session" table starting from textbox (where i can check and input session to kill)

        Dim con As SqlConnection
        Dim cmd As SqlCommand
        Dim row As Integer
        Dim SessionId As Integer

        If TextBox1.Text <> "" Then

            'Sql Server Connection
            'con = New SqlConnection("server=STEFANETTILEN\SQL2012ENT; database=Demo Database NAV (10-0); integrated security=true")        ' Integrated security
            con = New SqlConnection("server= STEFANETTILEN\SQL2012ENT; database=Demo Database NAV (10-0); user id = sa; password= sasa!;")  'User Password security

            con.Open()   'Open Connection
            SessionId = Int(TextBox1.Text)  'Int Session ID
            'MessageBox.Show(SessionId)

            cmd = New SqlCommand("DELETE dbo.[Active Session] WHERE [Session ID] = '" & SessionId & "'", con)
            'SQL Statement (NOT QUERY, ONLY EXECUTIONS STATEMENTS)

            row = cmd.ExecuteNonQuery()  'Execute SQL Statement

            If row > 0 Then
                MessageBox.Show("Session Killed !")   'Print result of DELETE Statement               
            End If

            con.Close()  'Close SQL Connection

            ' refresh\reopen
            Me.Refresh()
            Application.Restart() 'Reopen Project

        Else
            MessageBox.Show("Insert Session ID to Kill (First Column in Datagrid)!")
        End If

    End Sub

  
End Class



<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActiveSessionList
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Active_SessionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Demo_Database_NAV__10_0_DataSet = New NAV_2017_KIll_SQL_Inactive_Sessions._Demo_Database_NAV__10_0_DataSet()
        Me.Active_SessionTableAdapter = New NAV_2017_KIll_SQL_Inactive_Sessions._Demo_Database_NAV__10_0_DataSetTableAdapters.Active_SessionTableAdapter()
        Me.TableAdapterManager = New NAV_2017_KIll_SQL_Inactive_Sessions._Demo_Database_NAV__10_0_DataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SessionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatabaseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServerInstanceNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServerComputerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientComputerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginDatetimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServerInstanceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SessionUniqueIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserSIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Active_SessionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Demo_Database_NAV__10_0_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SessionIDDataGridViewTextBoxColumn, Me.DatabaseNameDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn, Me.ServerInstanceNameDataGridViewTextBoxColumn, Me.ServerComputerNameDataGridViewTextBoxColumn, Me.ClientComputerNameDataGridViewTextBoxColumn, Me.ClientTypeDataGridViewTextBoxColumn, Me.LoginDatetimeDataGridViewTextBoxColumn, Me.ServerInstanceIDDataGridViewTextBoxColumn, Me.SessionUniqueIDDataGridViewTextBoxColumn, Me.UserSIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Active_SessionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1046, 336)
        Me.DataGridView1.TabIndex = 0
        '
        'Active_SessionBindingSource
        '
        Me.Active_SessionBindingSource.DataMember = "Active Session"
        Me.Active_SessionBindingSource.DataSource = Me._Demo_Database_NAV__10_0_DataSet
        '
        '_Demo_Database_NAV__10_0_DataSet
        '
        Me._Demo_Database_NAV__10_0_DataSet.DataSetName = "_Demo_Database_NAV__10_0_DataSet"
        Me._Demo_Database_NAV__10_0_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Active_SessionTableAdapter
        '
        Me.Active_SessionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Active_SessionTableAdapter = Me.Active_SessionTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = NAV_2017_KIll_SQL_Inactive_Sessions._Demo_Database_NAV__10_0_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(190, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 49)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "KILL Session"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(66, 384)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Session ID to Kill"
        '
        'SessionIDDataGridViewTextBoxColumn
        '
        Me.SessionIDDataGridViewTextBoxColumn.DataPropertyName = "Session ID"
        Me.SessionIDDataGridViewTextBoxColumn.HeaderText = "Session ID"
        Me.SessionIDDataGridViewTextBoxColumn.Name = "SessionIDDataGridViewTextBoxColumn"
        '
        'DatabaseNameDataGridViewTextBoxColumn
        '
        Me.DatabaseNameDataGridViewTextBoxColumn.DataPropertyName = "Database Name"
        Me.DatabaseNameDataGridViewTextBoxColumn.HeaderText = "Database Name"
        Me.DatabaseNameDataGridViewTextBoxColumn.Name = "DatabaseNameDataGridViewTextBoxColumn"
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "User ID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "User ID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        '
        'ServerInstanceNameDataGridViewTextBoxColumn
        '
        Me.ServerInstanceNameDataGridViewTextBoxColumn.DataPropertyName = "Server Instance Name"
        Me.ServerInstanceNameDataGridViewTextBoxColumn.HeaderText = "Server Instance Name"
        Me.ServerInstanceNameDataGridViewTextBoxColumn.Name = "ServerInstanceNameDataGridViewTextBoxColumn"
        '
        'ServerComputerNameDataGridViewTextBoxColumn
        '
        Me.ServerComputerNameDataGridViewTextBoxColumn.DataPropertyName = "Server Computer Name"
        Me.ServerComputerNameDataGridViewTextBoxColumn.HeaderText = "Server Computer Name"
        Me.ServerComputerNameDataGridViewTextBoxColumn.Name = "ServerComputerNameDataGridViewTextBoxColumn"
        '
        'ClientComputerNameDataGridViewTextBoxColumn
        '
        Me.ClientComputerNameDataGridViewTextBoxColumn.DataPropertyName = "Client Computer Name"
        Me.ClientComputerNameDataGridViewTextBoxColumn.HeaderText = "Client Computer Name"
        Me.ClientComputerNameDataGridViewTextBoxColumn.Name = "ClientComputerNameDataGridViewTextBoxColumn"
        '
        'ClientTypeDataGridViewTextBoxColumn
        '
        Me.ClientTypeDataGridViewTextBoxColumn.DataPropertyName = "Client Type"
        Me.ClientTypeDataGridViewTextBoxColumn.HeaderText = "Client Type"
        Me.ClientTypeDataGridViewTextBoxColumn.Name = "ClientTypeDataGridViewTextBoxColumn"
        '
        'LoginDatetimeDataGridViewTextBoxColumn
        '
        Me.LoginDatetimeDataGridViewTextBoxColumn.DataPropertyName = "Login Datetime"
        Me.LoginDatetimeDataGridViewTextBoxColumn.HeaderText = "Login Datetime"
        Me.LoginDatetimeDataGridViewTextBoxColumn.Name = "LoginDatetimeDataGridViewTextBoxColumn"
        '
        'ServerInstanceIDDataGridViewTextBoxColumn
        '
        Me.ServerInstanceIDDataGridViewTextBoxColumn.DataPropertyName = "Server Instance ID"
        Me.ServerInstanceIDDataGridViewTextBoxColumn.HeaderText = "Server Instance ID"
        Me.ServerInstanceIDDataGridViewTextBoxColumn.Name = "ServerInstanceIDDataGridViewTextBoxColumn"
        '
        'SessionUniqueIDDataGridViewTextBoxColumn
        '
        Me.SessionUniqueIDDataGridViewTextBoxColumn.DataPropertyName = "Session Unique ID"
        Me.SessionUniqueIDDataGridViewTextBoxColumn.HeaderText = "Session Unique ID"
        Me.SessionUniqueIDDataGridViewTextBoxColumn.Name = "SessionUniqueIDDataGridViewTextBoxColumn"
        '
        'UserSIDDataGridViewTextBoxColumn
        '
        Me.UserSIDDataGridViewTextBoxColumn.DataPropertyName = "User SID"
        Me.UserSIDDataGridViewTextBoxColumn.HeaderText = "User SID"
        Me.UserSIDDataGridViewTextBoxColumn.Name = "UserSIDDataGridViewTextBoxColumn"
        '
        'ActiveSessionList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 440)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ActiveSessionList"
        Me.Text = "Active Sessions List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Active_SessionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Demo_Database_NAV__10_0_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents _Demo_Database_NAV__10_0_DataSet As NAV_2017_KIll_SQL_Inactive_Sessions._Demo_Database_NAV__10_0_DataSet
    Friend WithEvents Active_SessionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Active_SessionTableAdapter As NAV_2017_KIll_SQL_Inactive_Sessions._Demo_Database_NAV__10_0_DataSetTableAdapters.Active_SessionTableAdapter
    Friend WithEvents TableAdapterManager As NAV_2017_KIll_SQL_Inactive_Sessions._Demo_Database_NAV__10_0_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SessionIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatabaseNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServerInstanceNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServerComputerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientComputerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoginDatetimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServerInstanceIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SessionUniqueIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserSIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFileNames
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFileNames))
        DataGridView1 = New DataGridView()
        GroupBox4 = New GroupBox()
        CheckEnabledTeam = New CheckBox()
        Label6 = New Label()
        Label8 = New Label()
        TextTeamName = New TextBox()
        ComboTournament = New ComboBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TableLayoutPanel1.SetColumnSpan(DataGridView1, 2)
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(3, 139)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1298, 588)
        DataGridView1.TabIndex = 0
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(CheckEnabledTeam)
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Controls.Add(Label8)
        GroupBox4.Controls.Add(TextTeamName)
        GroupBox4.Controls.Add(ComboTournament)
        GroupBox4.Location = New Point(3, 3)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(253, 130)
        GroupBox4.TabIndex = 18
        GroupBox4.TabStop = False
        GroupBox4.Text = "Team Filter"
        ' 
        ' CheckEnabledTeam
        ' 
        CheckEnabledTeam.AutoSize = True
        CheckEnabledTeam.CheckAlign = ContentAlignment.MiddleRight
        CheckEnabledTeam.Location = New Point(6, 90)
        CheckEnabledTeam.Name = "CheckEnabledTeam"
        CheckEnabledTeam.Size = New Size(176, 24)
        CheckEnabledTeam.TabIndex = 19
        CheckEnabledTeam.Text = "Show Disabled Teams"
        CheckEnabledTeam.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(39, 57)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 20)
        Label6.TabIndex = 16
        Label6.Text = "Name"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 23)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 20)
        Label8.TabIndex = 14
        Label8.Text = "Tournament"
        ' 
        ' TextTeamName
        ' 
        TextTeamName.Location = New Point(94, 54)
        TextTeamName.Name = "TextTeamName"
        TextTeamName.Size = New Size(150, 27)
        TextTeamName.TabIndex = 4
        ' 
        ' ComboTournament
        ' 
        ComboTournament.FormattingEnabled = True
        ComboTournament.Items.AddRange(New Object() {"None", "International", "Super 14", "European", "Representative"})
        ComboTournament.Location = New Point(94, 20)
        ComboTournament.Name = "ComboTournament"
        ComboTournament.Size = New Size(150, 28)
        ComboTournament.TabIndex = 8
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(DataGridView1, 0, 1)
        TableLayoutPanel1.Controls.Add(GroupBox4, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(1304, 730)
        TableLayoutPanel1.TabIndex = 19
        ' 
        ' FormFileNames
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1304, 730)
        Controls.Add(TableLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormFileNames"
        Text = "Team File Names"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CheckEnabledTeam As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextTeamName As TextBox
    Friend WithEvents ComboTournament As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class

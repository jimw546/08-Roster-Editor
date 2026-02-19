<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ButtonImport = New Button()
        ListBoxTeams = New ListBox()
        ListBoxPlayers = New ListBox()
        ButtonSave = New Button()
        ComboNationality = New ComboBox()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        ComboPosition = New ComboBox()
        TextBoxNameFilter = New TextBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        CheckEnabledTeam = New CheckBox()
        Label6 = New Label()
        Label8 = New Label()
        TextTeamName = New TextBox()
        ComboTournament = New ComboBox()
        ButtonRDF = New Button()
        ButtonTeam = New Button()
        ButtonPlayer = New Button()
        Button1 = New Button()
        ToolTip1 = New ToolTip(components)
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' ButtonImport
        ' 
        ButtonImport.Location = New Point(22, 163)
        ButtonImport.Name = "ButtonImport"
        ButtonImport.Size = New Size(115, 29)
        ButtonImport.TabIndex = 0
        ButtonImport.Text = "Import Roster"
        ButtonImport.UseVisualStyleBackColor = True
        ' 
        ' ListBoxTeams
        ' 
        ListBoxTeams.FormattingEnabled = True
        ListBoxTeams.Location = New Point(6, 20)
        ListBoxTeams.Name = "ListBoxTeams"
        ListBoxTeams.Size = New Size(150, 204)
        ListBoxTeams.TabIndex = 7
        ' 
        ' ListBoxPlayers
        ' 
        ListBoxPlayers.FormattingEnabled = True
        ListBoxPlayers.Location = New Point(6, 20)
        ListBoxPlayers.Name = "ListBoxPlayers"
        ListBoxPlayers.Size = New Size(149, 204)
        ListBoxPlayers.TabIndex = 12
        ' 
        ' ButtonSave
        ' 
        ButtonSave.Location = New Point(22, 318)
        ButtonSave.Name = "ButtonSave"
        ButtonSave.Size = New Size(115, 29)
        ButtonSave.TabIndex = 2
        ButtonSave.Text = "Save Roster"
        ButtonSave.UseVisualStyleBackColor = True
        ' 
        ' ComboNationality
        ' 
        ComboNationality.FormattingEnabled = True
        ComboNationality.Items.AddRange(New Object() {"None", "Argentina", "Australia", "Canada", "UNDEFINED", "England", "Fiji", "France", "Georgia", "Ireland", "Italy", "Japan", "Namibia", "New Zealand", "Romania", "Russia", "Samoa", "Scotland", "South Africa", "Spain", "Tonga", "Chile", "Uruguay", "USA", "Wales", "Portugal"})
        ComboNationality.Location = New Point(94, 20)
        ComboNationality.Name = "ComboNationality"
        ComboNationality.Size = New Size(150, 28)
        ComboNationality.TabIndex = 9
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(ComboPosition)
        GroupBox1.Controls.Add(TextBoxNameFilter)
        GroupBox1.Controls.Add(ComboNationality)
        GroupBox1.Location = New Point(332, 14)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(253, 130)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Player Filter"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 16
        Label3.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 20)
        Label2.TabIndex = 15
        Label2.Text = "Position"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 20)
        Label1.TabIndex = 14
        Label1.Text = "Nationality"
        ' 
        ' ComboPosition
        ' 
        ComboPosition.FormattingEnabled = True
        ComboPosition.Items.AddRange(New Object() {"None", "Prop 1", "Hooker", "Prop 3", "Lock", "Flanker 6", "Flanker 7", "Number 8", "Scrum Half", "Fly Half", "Winger", "Centre", "Full Back"})
        ComboPosition.Location = New Point(94, 54)
        ComboPosition.Name = "ComboPosition"
        ComboPosition.Size = New Size(150, 28)
        ComboPosition.TabIndex = 10
        ' 
        ' TextBoxNameFilter
        ' 
        TextBoxNameFilter.Location = New Point(94, 88)
        TextBoxNameFilter.Name = "TextBoxNameFilter"
        TextBoxNameFilter.Size = New Size(150, 27)
        TextBoxNameFilter.TabIndex = 11
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ListBoxPlayers)
        GroupBox2.Location = New Point(421, 158)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(164, 236)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "Player List"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(ListBoxTeams)
        GroupBox3.Location = New Point(154, 158)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(165, 236)
        GroupBox3.TabIndex = 7
        GroupBox3.TabStop = False
        GroupBox3.Text = "Team List"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(CheckEnabledTeam)
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Controls.Add(Label8)
        GroupBox4.Controls.Add(TextTeamName)
        GroupBox4.Controls.Add(ComboTournament)
        GroupBox4.Location = New Point(66, 14)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(253, 130)
        GroupBox4.TabIndex = 4
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
        CheckEnabledTeam.TabIndex = 6
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
        TextTeamName.TabIndex = 5
        ' 
        ' ComboTournament
        ' 
        ComboTournament.FormattingEnabled = True
        ComboTournament.Items.AddRange(New Object() {"None", "International", "Super 14", "European", "Representative"})
        ComboTournament.Location = New Point(94, 20)
        ComboTournament.Name = "ComboTournament"
        ComboTournament.Size = New Size(150, 28)
        ComboTournament.TabIndex = 4
        ' 
        ' ButtonRDF
        ' 
        ButtonRDF.Location = New Point(22, 363)
        ButtonRDF.Name = "ButtonRDF"
        ButtonRDF.Size = New Size(115, 29)
        ButtonRDF.TabIndex = 3
        ButtonRDF.Text = "Save RDF"
        ButtonRDF.UseVisualStyleBackColor = True
        ' 
        ' ButtonTeam
        ' 
        ButtonTeam.Location = New Point(174, 400)
        ButtonTeam.Name = "ButtonTeam"
        ButtonTeam.Size = New Size(115, 29)
        ButtonTeam.TabIndex = 8
        ButtonTeam.Text = "Edit Team"
        ButtonTeam.UseVisualStyleBackColor = True
        ' 
        ' ButtonPlayer
        ' 
        ButtonPlayer.Location = New Point(439, 400)
        ButtonPlayer.Name = "ButtonPlayer"
        ButtonPlayer.Size = New Size(115, 29)
        ButtonPlayer.TabIndex = 13
        ButtonPlayer.Text = "Edit Player"
        ButtonPlayer.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(22, 233)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 29)
        Button1.TabIndex = 1
        Button1.Text = "Extras"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(619, 442)
        Controls.Add(Button1)
        Controls.Add(ButtonPlayer)
        Controls.Add(ButtonTeam)
        Controls.Add(ButtonRDF)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(ButtonSave)
        Controls.Add(ButtonImport)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        Text = "Roster Editor"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ButtonImport As Button
    Friend WithEvents ListBoxTeams As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxPlayers As ListBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ComboNationality As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBoxNameFilter As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboPosition As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextTeamName As TextBox
    Friend WithEvents ComboTournament As ComboBox
    Friend WithEvents CheckEnabledTeam As CheckBox
    Friend WithEvents ButtonRDF As Button
    Friend WithEvents ButtonTeam As Button
    Friend WithEvents ButtonPlayer As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip

End Class

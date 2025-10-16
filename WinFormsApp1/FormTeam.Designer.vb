<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTeam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTeam))
        ButtonRemovePlayer = New Button()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        ButtonAddPlayer = New Button()
        ButtonSave = New Button()
        ButtonMoveUp = New Button()
        ButtonMoveDown = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label31 = New Label()
        Label32 = New Label()
        Label33 = New Label()
        Label34 = New Label()
        Label35 = New Label()
        Label36 = New Label()
        Label37 = New Label()
        Label38 = New Label()
        Label39 = New Label()
        Label40 = New Label()
        Label41 = New Label()
        Label42 = New Label()
        Label43 = New Label()
        Label44 = New Label()
        Label45 = New Label()
        Label46 = New Label()
        Label47 = New Label()
        Label48 = New Label()
        Label49 = New Label()
        Label50 = New Label()
        ComboStadium = New ComboBox()
        LabelTeamName = New Label()
        Label7 = New Label()
        TextAttack = New TextBox()
        Label8 = New Label()
        TextDefend = New TextBox()
        Label13 = New Label()
        TextLineout = New TextBox()
        Label14 = New Label()
        TextScrum = New TextBox()
        Label15 = New Label()
        TextKick = New TextBox()
        Label16 = New Label()
        TextLoose = New TextBox()
        Label17 = New Label()
        TextStamina = New TextBox()
        Label18 = New Label()
        TextTechnique = New TextBox()
        Label19 = New Label()
        TextOverall = New TextBox()
        Label20 = New Label()
        TextFlair = New TextBox()
        Label21 = New Label()
        NumericPerformance = New NumericUpDown()
        Label22 = New Label()
        ComboSetLeft = New ComboBox()
        ComboSetUp = New ComboBox()
        ComboSetRight = New ComboBox()
        ComboSetDown = New ComboBox()
        GroupBox1 = New GroupBox()
        Label23 = New Label()
        Label24 = New Label()
        Label25 = New Label()
        ComboPosition = New ComboBox()
        TextBoxNameFilter = New TextBox()
        ComboNationality = New ComboBox()
        ComboCaptain = New ComboBox()
        Label26 = New Label()
        Label27 = New Label()
        Label28 = New Label()
        Label29 = New Label()
        ComboVice = New ComboBox()
        Label30 = New Label()
        Label51 = New Label()
        Label52 = New Label()
        ComboLongGoal = New ComboBox()
        Label53 = New Label()
        ComboShortGoal = New ComboBox()
        Label54 = New Label()
        ComboLongPunt = New ComboBox()
        Label55 = New Label()
        ComboShortPunt = New ComboBox()
        Label56 = New Label()
        ComboKickOff = New ComboBox()
        TabControl1 = New TabControl()
        TabPage2 = New TabPage()
        LabelNationality = New Label()
        LabelPosition = New Label()
        LabelName = New Label()
        Label57 = New Label()
        ButtonRemoveAll = New Button()
        Label58 = New Label()
        Label59 = New Label()
        TabPage1 = New TabPage()
        Label60 = New Label()
        Label61 = New Label()
        Label62 = New Label()
        Label63 = New Label()
        Label64 = New Label()
        Label65 = New Label()
        Label66 = New Label()
        CType(NumericPerformance, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ButtonRemovePlayer
        ' 
        ButtonRemovePlayer.Location = New Point(10, 218)
        ButtonRemovePlayer.Name = "ButtonRemovePlayer"
        ButtonRemovePlayer.Size = New Size(111, 29)
        ButtonRemovePlayer.TabIndex = 1
        ButtonRemovePlayer.Text = "Remove →"
        ButtonRemovePlayer.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(66, 58)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(218, 604)
        ListBox1.TabIndex = 35
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.Location = New Point(244, 171)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(218, 364)
        ListBox2.TabIndex = 37
        ' 
        ' ButtonAddPlayer
        ' 
        ButtonAddPlayer.Location = New Point(127, 218)
        ButtonAddPlayer.Name = "ButtonAddPlayer"
        ButtonAddPlayer.Size = New Size(111, 29)
        ButtonAddPlayer.TabIndex = 38
        ButtonAddPlayer.Text = "← Add"
        ButtonAddPlayer.UseVisualStyleBackColor = True
        ' 
        ' ButtonSave
        ' 
        ButtonSave.Location = New Point(173, 668)
        ButtonSave.Name = "ButtonSave"
        ButtonSave.Size = New Size(111, 29)
        ButtonSave.TabIndex = 39
        ButtonSave.Text = "Save"
        ButtonSave.UseVisualStyleBackColor = True
        ' 
        ' ButtonMoveUp
        ' 
        ButtonMoveUp.Location = New Point(70, 186)
        ButtonMoveUp.Name = "ButtonMoveUp"
        ButtonMoveUp.Size = New Size(111, 29)
        ButtonMoveUp.TabIndex = 40
        ButtonMoveUp.Text = "↑ Move Up"
        ButtonMoveUp.UseVisualStyleBackColor = True
        ' 
        ' ButtonMoveDown
        ' 
        ButtonMoveDown.Location = New Point(70, 250)
        ButtonMoveDown.Name = "ButtonMoveDown"
        ButtonMoveDown.Size = New Size(111, 29)
        ButtonMoveDown.TabIndex = 41
        ButtonMoveDown.Text = "↓ Move Down"
        ButtonMoveDown.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 20)
        Label1.TabIndex = 42
        Label1.Text = "1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(17, 20)
        Label2.TabIndex = 43
        Label2.Text = "2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(17, 20)
        Label3.TabIndex = 44
        Label3.Text = "3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(43, 158)
        Label4.Name = "Label4"
        Label4.Size = New Size(17, 20)
        Label4.TabIndex = 47
        Label4.Text = "6"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(43, 138)
        Label5.Name = "Label5"
        Label5.Size = New Size(17, 20)
        Label5.TabIndex = 46
        Label5.Text = "5"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(43, 118)
        Label6.Name = "Label6"
        Label6.Size = New Size(17, 20)
        Label6.TabIndex = 45
        Label6.Text = "4"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(35, 238)
        Label9.Name = "Label9"
        Label9.Size = New Size(25, 20)
        Label9.TabIndex = 51
        Label9.Text = "10"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(43, 218)
        Label10.Name = "Label10"
        Label10.Size = New Size(17, 20)
        Label10.TabIndex = 50
        Label10.Text = "9"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(43, 198)
        Label11.Name = "Label11"
        Label11.Size = New Size(17, 20)
        Label11.TabIndex = 49
        Label11.Text = "8"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(43, 178)
        Label12.Name = "Label12"
        Label12.Size = New Size(17, 20)
        Label12.TabIndex = 48
        Label12.Text = "7"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Location = New Point(42, 638)
        Label31.Name = "Label31"
        Label31.Size = New Size(18, 20)
        Label31.TabIndex = 87
        Label31.Text = "R"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Location = New Point(42, 618)
        Label32.Name = "Label32"
        Label32.Size = New Size(18, 20)
        Label32.TabIndex = 86
        Label32.Text = "R"
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Location = New Point(42, 598)
        Label33.Name = "Label33"
        Label33.Size = New Size(18, 20)
        Label33.TabIndex = 85
        Label33.Text = "R"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Location = New Point(42, 578)
        Label34.Name = "Label34"
        Label34.Size = New Size(18, 20)
        Label34.TabIndex = 84
        Label34.Text = "R"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Location = New Point(42, 558)
        Label35.Name = "Label35"
        Label35.Size = New Size(18, 20)
        Label35.TabIndex = 83
        Label35.Text = "R"
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Location = New Point(42, 538)
        Label36.Name = "Label36"
        Label36.Size = New Size(18, 20)
        Label36.TabIndex = 82
        Label36.Text = "R"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Location = New Point(42, 518)
        Label37.Name = "Label37"
        Label37.Size = New Size(18, 20)
        Label37.TabIndex = 81
        Label37.Text = "R"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Location = New Point(42, 498)
        Label38.Name = "Label38"
        Label38.Size = New Size(18, 20)
        Label38.TabIndex = 80
        Label38.Text = "R"
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Location = New Point(35, 478)
        Label39.Name = "Label39"
        Label39.Size = New Size(25, 20)
        Label39.TabIndex = 79
        Label39.Text = "22"
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Location = New Point(35, 458)
        Label40.Name = "Label40"
        Label40.Size = New Size(25, 20)
        Label40.TabIndex = 78
        Label40.Text = "21"
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Location = New Point(35, 438)
        Label41.Name = "Label41"
        Label41.Size = New Size(25, 20)
        Label41.TabIndex = 97
        Label41.Text = "20"
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.Location = New Point(35, 418)
        Label42.Name = "Label42"
        Label42.Size = New Size(25, 20)
        Label42.TabIndex = 96
        Label42.Text = "19"
        ' 
        ' Label43
        ' 
        Label43.AutoSize = True
        Label43.Location = New Point(35, 398)
        Label43.Name = "Label43"
        Label43.Size = New Size(25, 20)
        Label43.TabIndex = 95
        Label43.Text = "18"
        ' 
        ' Label44
        ' 
        Label44.AutoSize = True
        Label44.Location = New Point(35, 378)
        Label44.Name = "Label44"
        Label44.Size = New Size(25, 20)
        Label44.TabIndex = 94
        Label44.Text = "17"
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.Location = New Point(35, 358)
        Label45.Name = "Label45"
        Label45.Size = New Size(25, 20)
        Label45.TabIndex = 93
        Label45.Text = "16"
        ' 
        ' Label46
        ' 
        Label46.AutoSize = True
        Label46.Location = New Point(35, 338)
        Label46.Name = "Label46"
        Label46.Size = New Size(25, 20)
        Label46.TabIndex = 92
        Label46.Text = "15"
        ' 
        ' Label47
        ' 
        Label47.AutoSize = True
        Label47.Location = New Point(35, 318)
        Label47.Name = "Label47"
        Label47.Size = New Size(25, 20)
        Label47.TabIndex = 91
        Label47.Text = "14"
        ' 
        ' Label48
        ' 
        Label48.AutoSize = True
        Label48.Location = New Point(35, 298)
        Label48.Name = "Label48"
        Label48.Size = New Size(25, 20)
        Label48.TabIndex = 90
        Label48.Text = "13"
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.Location = New Point(35, 278)
        Label49.Name = "Label49"
        Label49.Size = New Size(25, 20)
        Label49.TabIndex = 89
        Label49.Text = "12"
        ' 
        ' Label50
        ' 
        Label50.AutoSize = True
        Label50.Location = New Point(35, 258)
        Label50.Name = "Label50"
        Label50.Size = New Size(25, 20)
        Label50.TabIndex = 88
        Label50.Text = "11"
        ' 
        ' ComboStadium
        ' 
        ComboStadium.FormattingEnabled = True
        ComboStadium.Location = New Point(72, 42)
        ComboStadium.Name = "ComboStadium"
        ComboStadium.Size = New Size(218, 28)
        ComboStadium.TabIndex = 98
        ' 
        ' LabelTeamName
        ' 
        LabelTeamName.AutoSize = True
        LabelTeamName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LabelTeamName.Location = New Point(66, 23)
        LabelTeamName.Name = "LabelTeamName"
        LabelTeamName.Size = New Size(126, 20)
        LabelTeamName.TabIndex = 99
        LabelTeamName.Text = "LabelTeamName"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(57, 146)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 20)
        Label7.TabIndex = 101
        Label7.Text = "Attacking"
        ' 
        ' TextAttack
        ' 
        TextAttack.Location = New Point(135, 143)
        TextAttack.MaxLength = 2
        TextAttack.Name = "TextAttack"
        TextAttack.Size = New Size(46, 27)
        TextAttack.TabIndex = 100
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(50, 179)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 20)
        Label8.TabIndex = 103
        Label8.Text = "Defending"
        ' 
        ' TextDefend
        ' 
        TextDefend.Location = New Point(135, 176)
        TextDefend.MaxLength = 2
        TextDefend.Name = "TextDefend"
        TextDefend.Size = New Size(46, 27)
        TextDefend.TabIndex = 102
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(65, 245)
        Label13.Name = "Label13"
        Label13.Size = New Size(64, 20)
        Label13.TabIndex = 107
        Label13.Text = "Lineouts"
        ' 
        ' TextLineout
        ' 
        TextLineout.Location = New Point(135, 242)
        TextLineout.MaxLength = 2
        TextLineout.Name = "TextLineout"
        TextLineout.Size = New Size(46, 27)
        TextLineout.TabIndex = 106
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(28, 212)
        Label14.Name = "Label14"
        Label14.Size = New Size(101, 20)
        Label14.TabIndex = 105
        Label14.Text = "Scrummaging"
        ' 
        ' TextScrum
        ' 
        TextScrum.Location = New Point(135, 209)
        TextScrum.MaxLength = 2
        TextScrum.Name = "TextScrum"
        TextScrum.Size = New Size(46, 27)
        TextScrum.TabIndex = 104
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(240, 146)
        Label15.Name = "Label15"
        Label15.Size = New Size(57, 20)
        Label15.TabIndex = 111
        Label15.Text = "Kicking"
        ' 
        ' TextKick
        ' 
        TextKick.Location = New Point(303, 143)
        TextKick.MaxLength = 2
        TextKick.Name = "TextKick"
        TextKick.Size = New Size(46, 27)
        TextKick.TabIndex = 110
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(81, 278)
        Label16.Name = "Label16"
        Label16.Size = New Size(48, 20)
        Label16.TabIndex = 109
        Label16.Text = "Loose"
        ' 
        ' TextLoose
        ' 
        TextLoose.Location = New Point(135, 275)
        TextLoose.MaxLength = 2
        TextLoose.Name = "TextLoose"
        TextLoose.Size = New Size(46, 27)
        TextLoose.TabIndex = 108
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(234, 212)
        Label17.Name = "Label17"
        Label17.Size = New Size(63, 20)
        Label17.TabIndex = 115
        Label17.Text = "Stamina"
        ' 
        ' TextStamina
        ' 
        TextStamina.Location = New Point(303, 209)
        TextStamina.MaxLength = 2
        TextStamina.Name = "TextStamina"
        TextStamina.Size = New Size(46, 27)
        TextStamina.TabIndex = 114
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(221, 179)
        Label18.Name = "Label18"
        Label18.Size = New Size(76, 20)
        Label18.TabIndex = 113
        Label18.Text = "Technique"
        ' 
        ' TextTechnique
        ' 
        TextTechnique.Location = New Point(303, 176)
        TextTechnique.MaxLength = 2
        TextTechnique.Name = "TextTechnique"
        TextTechnique.Size = New Size(46, 27)
        TextTechnique.TabIndex = 112
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(241, 278)
        Label19.Name = "Label19"
        Label19.Size = New Size(56, 20)
        Label19.TabIndex = 119
        Label19.Text = "Overall"
        ' 
        ' TextOverall
        ' 
        TextOverall.Location = New Point(303, 275)
        TextOverall.MaxLength = 2
        TextOverall.Name = "TextOverall"
        TextOverall.Size = New Size(46, 27)
        TextOverall.TabIndex = 118
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(260, 245)
        Label20.Name = "Label20"
        Label20.Size = New Size(37, 20)
        Label20.TabIndex = 117
        Label20.Text = "Flair"
        ' 
        ' TextFlair
        ' 
        TextFlair.Location = New Point(303, 242)
        TextFlair.MaxLength = 2
        TextFlair.Name = "TextFlair"
        TextFlair.Size = New Size(46, 27)
        TextFlair.TabIndex = 116
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(98, 79)
        Label21.Name = "Label21"
        Label21.Size = New Size(168, 40)
        Label21.TabIndex = 121
        Label21.Text = "Team Performance (1-5)" & vbCrLf & "1 is High, 5 is Low"
        ' 
        ' NumericPerformance
        ' 
        NumericPerformance.Location = New Point(272, 92)
        NumericPerformance.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        NumericPerformance.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericPerformance.Name = "NumericPerformance"
        NumericPerformance.Size = New Size(46, 27)
        NumericPerformance.TabIndex = 122
        NumericPerformance.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(72, 19)
        Label22.Name = "Label22"
        Label22.Size = New Size(109, 20)
        Label22.TabIndex = 123
        Label22.Text = "Home Stadium"
        ' 
        ' ComboSetLeft
        ' 
        ComboSetLeft.FormattingEnabled = True
        ComboSetLeft.Items.AddRange(New Object() {"Classic", "Pivot", "Pocket", "Dummy Switch", "Miss", "Cross Kick", "Loop", "Miss Pivot"})
        ComboSetLeft.Location = New Point(63, 425)
        ComboSetLeft.Name = "ComboSetLeft"
        ComboSetLeft.Size = New Size(138, 28)
        ComboSetLeft.TabIndex = 124
        ' 
        ' ComboSetUp
        ' 
        ComboSetUp.FormattingEnabled = True
        ComboSetUp.Items.AddRange(New Object() {"Classic", "Pivot", "Pocket", "Dummy Switch", "Miss", "Cross Kick", "Loop", "Miss Pivot"})
        ComboSetUp.Location = New Point(163, 391)
        ComboSetUp.Name = "ComboSetUp"
        ComboSetUp.Size = New Size(138, 28)
        ComboSetUp.TabIndex = 125
        ' 
        ' ComboSetRight
        ' 
        ComboSetRight.FormattingEnabled = True
        ComboSetRight.Items.AddRange(New Object() {"Classic", "Pivot", "Pocket", "Dummy Switch", "Miss", "Cross Kick", "Loop", "Miss Pivot"})
        ComboSetRight.Location = New Point(286, 425)
        ComboSetRight.Name = "ComboSetRight"
        ComboSetRight.Size = New Size(138, 28)
        ComboSetRight.TabIndex = 126
        ' 
        ' ComboSetDown
        ' 
        ComboSetDown.FormattingEnabled = True
        ComboSetDown.Items.AddRange(New Object() {"Classic", "Pivot", "Pocket", "Dummy Switch", "Miss", "Cross Kick", "Loop", "Miss Pivot"})
        ComboSetDown.Location = New Point(163, 459)
        ComboSetDown.Name = "ComboSetDown"
        ComboSetDown.Size = New Size(138, 28)
        ComboSetDown.TabIndex = 127
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label23)
        GroupBox1.Controls.Add(Label24)
        GroupBox1.Controls.Add(Label25)
        GroupBox1.Controls.Add(ComboPosition)
        GroupBox1.Controls.Add(TextBoxNameFilter)
        GroupBox1.Controls.Add(ComboNationality)
        GroupBox1.Location = New Point(217, 23)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(260, 130)
        GroupBox1.TabIndex = 128
        GroupBox1.TabStop = False
        GroupBox1.Text = "Player Filter"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(39, 91)
        Label23.Name = "Label23"
        Label23.Size = New Size(49, 20)
        Label23.TabIndex = 16
        Label23.Text = "Name"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(27, 57)
        Label24.Name = "Label24"
        Label24.Size = New Size(61, 20)
        Label24.TabIndex = 15
        Label24.Text = "Position"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(6, 23)
        Label25.Name = "Label25"
        Label25.Size = New Size(82, 20)
        Label25.TabIndex = 14
        Label25.Text = "Nationality"
        ' 
        ' ComboPosition
        ' 
        ComboPosition.FormattingEnabled = True
        ComboPosition.Items.AddRange(New Object() {"None", "Prop 1", "Hooker", "Prop 3", "Lock", "Flanker 6", "Flanker 7", "Number 8", "Scrum Half", "Fly Half", "Winger", "Centre", "Full Back"})
        ComboPosition.Location = New Point(94, 54)
        ComboPosition.Name = "ComboPosition"
        ComboPosition.Size = New Size(150, 28)
        ComboPosition.TabIndex = 9
        ' 
        ' TextBoxNameFilter
        ' 
        TextBoxNameFilter.Location = New Point(94, 88)
        TextBoxNameFilter.Name = "TextBoxNameFilter"
        TextBoxNameFilter.Size = New Size(150, 27)
        TextBoxNameFilter.TabIndex = 4
        ' 
        ' ComboNationality
        ' 
        ComboNationality.FormattingEnabled = True
        ComboNationality.Items.AddRange(New Object() {"None", "Argentina", "Australia", "Canada", "UNDEFINED", "England", "Fiji", "France", "Georgia", "Ireland", "Italy", "Japan", "Namibia", "New Zealand", "Romania", "Russia", "Samoa", "Scotland", "South Africa", "Spain", "Tonga", "Chile", "Uruguay", "USA", "Wales", "Portugal"})
        ComboNationality.Location = New Point(94, 20)
        ComboNationality.Name = "ComboNationality"
        ComboNationality.Size = New Size(150, 28)
        ComboNationality.TabIndex = 8
        ' 
        ' ComboCaptain
        ' 
        ComboCaptain.FormattingEnabled = True
        ComboCaptain.Location = New Point(57, 302)
        ComboCaptain.Name = "ComboCaptain"
        ComboCaptain.Size = New Size(151, 28)
        ComboCaptain.TabIndex = 129
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(23, 428)
        Label26.Name = "Label26"
        Label26.Size = New Size(34, 20)
        Label26.TabIndex = 130
        Label26.Text = "Left"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(129, 394)
        Label27.Name = "Label27"
        Label27.Size = New Size(28, 20)
        Label27.TabIndex = 131
        Label27.Text = "Up"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(236, 428)
        Label28.Name = "Label28"
        Label28.Size = New Size(44, 20)
        Label28.TabIndex = 132
        Label28.Text = "Right"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Location = New Point(109, 462)
        Label29.Name = "Label29"
        Label29.Size = New Size(48, 20)
        Label29.TabIndex = 133
        Label29.Text = "Down"
        ' 
        ' ComboVice
        ' 
        ComboVice.FormattingEnabled = True
        ComboVice.Location = New Point(57, 336)
        ComboVice.Name = "ComboVice"
        ComboVice.Size = New Size(151, 28)
        ComboVice.TabIndex = 140
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Location = New Point(33, 305)
        Label30.Name = "Label30"
        Label30.Size = New Size(18, 20)
        Label30.TabIndex = 141
        Label30.Text = "C"
        ' 
        ' Label51
        ' 
        Label51.AutoSize = True
        Label51.Location = New Point(24, 339)
        Label51.Name = "Label51"
        Label51.Size = New Size(27, 20)
        Label51.TabIndex = 142
        Label51.Text = "VC"
        ' 
        ' Label52
        ' 
        Label52.AutoSize = True
        Label52.Location = New Point(25, 373)
        Label52.Name = "Label52"
        Label52.Size = New Size(26, 20)
        Label52.TabIndex = 144
        Label52.Text = "LG"
        ' 
        ' ComboLongGoal
        ' 
        ComboLongGoal.FormattingEnabled = True
        ComboLongGoal.Location = New Point(57, 370)
        ComboLongGoal.Name = "ComboLongGoal"
        ComboLongGoal.Size = New Size(151, 28)
        ComboLongGoal.TabIndex = 143
        ' 
        ' Label53
        ' 
        Label53.AutoSize = True
        Label53.Location = New Point(24, 407)
        Label53.Name = "Label53"
        Label53.Size = New Size(27, 20)
        Label53.TabIndex = 146
        Label53.Text = "SG"
        ' 
        ' ComboShortGoal
        ' 
        ComboShortGoal.FormattingEnabled = True
        ComboShortGoal.Location = New Point(57, 404)
        ComboShortGoal.Name = "ComboShortGoal"
        ComboShortGoal.Size = New Size(151, 28)
        ComboShortGoal.TabIndex = 145
        ' 
        ' Label54
        ' 
        Label54.AutoSize = True
        Label54.Location = New Point(27, 441)
        Label54.Name = "Label54"
        Label54.Size = New Size(24, 20)
        Label54.TabIndex = 148
        Label54.Text = "LP"
        ' 
        ' ComboLongPunt
        ' 
        ComboLongPunt.FormattingEnabled = True
        ComboLongPunt.Location = New Point(57, 438)
        ComboLongPunt.Name = "ComboLongPunt"
        ComboLongPunt.Size = New Size(151, 28)
        ComboLongPunt.TabIndex = 147
        ' 
        ' Label55
        ' 
        Label55.AutoSize = True
        Label55.Location = New Point(26, 475)
        Label55.Name = "Label55"
        Label55.Size = New Size(25, 20)
        Label55.TabIndex = 150
        Label55.Text = "SP"
        ' 
        ' ComboShortPunt
        ' 
        ComboShortPunt.FormattingEnabled = True
        ComboShortPunt.Location = New Point(57, 472)
        ComboShortPunt.Name = "ComboShortPunt"
        ComboShortPunt.Size = New Size(151, 28)
        ComboShortPunt.TabIndex = 149
        ' 
        ' Label56
        ' 
        Label56.AutoSize = True
        Label56.Location = New Point(23, 509)
        Label56.Name = "Label56"
        Label56.Size = New Size(28, 20)
        Label56.TabIndex = 152
        Label56.Text = "KO"
        ' 
        ' ComboKickOff
        ' 
        ComboKickOff.FormattingEnabled = True
        ComboKickOff.Location = New Point(57, 506)
        ComboKickOff.Name = "ComboKickOff"
        ComboKickOff.Size = New Size(151, 28)
        ComboKickOff.TabIndex = 151
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Location = New Point(299, 30)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(503, 632)
        TabControl1.TabIndex = 154
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Transparent
        TabPage2.Controls.Add(LabelNationality)
        TabPage2.Controls.Add(LabelPosition)
        TabPage2.Controls.Add(LabelName)
        TabPage2.Controls.Add(Label57)
        TabPage2.Controls.Add(ButtonRemoveAll)
        TabPage2.Controls.Add(Label58)
        TabPage2.Controls.Add(GroupBox1)
        TabPage2.Controls.Add(Label59)
        TabPage2.Controls.Add(ButtonRemovePlayer)
        TabPage2.Controls.Add(ListBox2)
        TabPage2.Controls.Add(ButtonAddPlayer)
        TabPage2.Controls.Add(ButtonMoveUp)
        TabPage2.Controls.Add(Label56)
        TabPage2.Controls.Add(ButtonMoveDown)
        TabPage2.Controls.Add(ComboCaptain)
        TabPage2.Controls.Add(ComboVice)
        TabPage2.Controls.Add(Label30)
        TabPage2.Controls.Add(Label51)
        TabPage2.Controls.Add(ComboLongGoal)
        TabPage2.Controls.Add(ComboShortPunt)
        TabPage2.Controls.Add(ComboKickOff)
        TabPage2.Controls.Add(ComboShortGoal)
        TabPage2.Controls.Add(Label52)
        TabPage2.Controls.Add(Label55)
        TabPage2.Controls.Add(ComboLongPunt)
        TabPage2.Controls.Add(Label54)
        TabPage2.Controls.Add(Label53)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(495, 599)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Players"
        ' 
        ' LabelNationality
        ' 
        LabelNationality.AutoSize = True
        LabelNationality.Location = New Point(91, 77)
        LabelNationality.Name = "LabelNationality"
        LabelNationality.Size = New Size(82, 20)
        LabelNationality.TabIndex = 132
        LabelNationality.Text = "Nationality"
        ' 
        ' LabelPosition
        ' 
        LabelPosition.AutoSize = True
        LabelPosition.Location = New Point(91, 106)
        LabelPosition.Name = "LabelPosition"
        LabelPosition.Size = New Size(61, 20)
        LabelPosition.TabIndex = 131
        LabelPosition.Text = "Position"
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Location = New Point(91, 46)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(49, 20)
        LabelName.TabIndex = 130
        LabelName.Text = "Name"
        ' 
        ' Label57
        ' 
        Label57.AutoSize = True
        Label57.Location = New Point(33, 46)
        Label57.Name = "Label57"
        Label57.Size = New Size(52, 20)
        Label57.TabIndex = 19
        Label57.Text = "Name:"
        ' 
        ' ButtonRemoveAll
        ' 
        ButtonRemoveAll.Location = New Point(350, 550)
        ButtonRemoveAll.Name = "ButtonRemoveAll"
        ButtonRemoveAll.Size = New Size(111, 29)
        ButtonRemoveAll.TabIndex = 129
        ButtonRemoveAll.Text = "Remove All"
        ButtonRemoveAll.UseVisualStyleBackColor = True
        ' 
        ' Label58
        ' 
        Label58.AutoSize = True
        Label58.Location = New Point(0, 77)
        Label58.Name = "Label58"
        Label58.Size = New Size(85, 20)
        Label58.TabIndex = 18
        Label58.Text = "Nationality:"
        ' 
        ' Label59
        ' 
        Label59.AutoSize = True
        Label59.Location = New Point(21, 106)
        Label59.Name = "Label59"
        Label59.Size = New Size(64, 20)
        Label59.TabIndex = 17
        Label59.Text = "Position:"
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Transparent
        TabPage1.Controls.Add(Label21)
        TabPage1.Controls.Add(TextAttack)
        TabPage1.Controls.Add(Label22)
        TabPage1.Controls.Add(ComboStadium)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(ComboSetLeft)
        TabPage1.Controls.Add(TextDefend)
        TabPage1.Controls.Add(ComboSetUp)
        TabPage1.Controls.Add(NumericPerformance)
        TabPage1.Controls.Add(ComboSetRight)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(ComboSetDown)
        TabPage1.Controls.Add(TextScrum)
        TabPage1.Controls.Add(Label19)
        TabPage1.Controls.Add(Label26)
        TabPage1.Controls.Add(Label14)
        TabPage1.Controls.Add(Label27)
        TabPage1.Controls.Add(TextOverall)
        TabPage1.Controls.Add(Label28)
        TabPage1.Controls.Add(TextLineout)
        TabPage1.Controls.Add(Label29)
        TabPage1.Controls.Add(Label20)
        TabPage1.Controls.Add(Label13)
        TabPage1.Controls.Add(TextFlair)
        TabPage1.Controls.Add(TextTechnique)
        TabPage1.Controls.Add(Label15)
        TabPage1.Controls.Add(TextLoose)
        TabPage1.Controls.Add(Label18)
        TabPage1.Controls.Add(TextKick)
        TabPage1.Controls.Add(Label17)
        TabPage1.Controls.Add(TextStamina)
        TabPage1.Controls.Add(Label16)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(495, 599)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Team Info"
        ' 
        ' Label60
        ' 
        Label60.AutoSize = True
        Label60.Location = New Point(870, 437)
        Label60.Name = "Label60"
        Label60.Size = New Size(99, 20)
        Label60.TabIndex = 161
        Label60.Text = "Kick Off Taker"
        Label60.Visible = False
        ' 
        ' Label61
        ' 
        Label61.AutoSize = True
        Label61.Location = New Point(859, 335)
        Label61.Name = "Label61"
        Label61.Size = New Size(110, 20)
        Label61.TabIndex = 158
        Label61.Text = "Short Goal Kick"
        Label61.Visible = False
        ' 
        ' Label62
        ' 
        Label62.AutoSize = True
        Label62.Location = New Point(894, 369)
        Label62.Name = "Label62"
        Label62.Size = New Size(75, 20)
        Label62.TabIndex = 159
        Label62.Text = "Long Punt"
        Label62.Visible = False
        ' 
        ' Label63
        ' 
        Label63.AutoSize = True
        Label63.Location = New Point(892, 403)
        Label63.Name = "Label63"
        Label63.Size = New Size(77, 20)
        Label63.TabIndex = 160
        Label63.Text = "Short Punt"
        Label63.Visible = False
        ' 
        ' Label64
        ' 
        Label64.AutoSize = True
        Label64.Location = New Point(861, 303)
        Label64.Name = "Label64"
        Label64.Size = New Size(108, 20)
        Label64.TabIndex = 157
        Label64.Text = "Long Goal Kick"
        Label64.Visible = False
        ' 
        ' Label65
        ' 
        Label65.AutoSize = True
        Label65.Location = New Point(877, 267)
        Label65.Name = "Label65"
        Label65.Size = New Size(92, 20)
        Label65.TabIndex = 156
        Label65.Text = "Vice Captain"
        Label65.Visible = False
        ' 
        ' Label66
        ' 
        Label66.AutoSize = True
        Label66.Location = New Point(909, 235)
        Label66.Name = "Label66"
        Label66.Size = New Size(60, 20)
        Label66.TabIndex = 155
        Label66.Text = "Captain"
        Label66.Visible = False
        ' 
        ' FormTeam
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(823, 708)
        Controls.Add(Label60)
        Controls.Add(Label61)
        Controls.Add(Label62)
        Controls.Add(Label63)
        Controls.Add(Label64)
        Controls.Add(Label65)
        Controls.Add(Label66)
        Controls.Add(TabControl1)
        Controls.Add(LabelTeamName)
        Controls.Add(Label41)
        Controls.Add(Label42)
        Controls.Add(Label43)
        Controls.Add(Label44)
        Controls.Add(Label45)
        Controls.Add(Label46)
        Controls.Add(Label47)
        Controls.Add(Label48)
        Controls.Add(Label49)
        Controls.Add(Label50)
        Controls.Add(Label31)
        Controls.Add(Label32)
        Controls.Add(Label33)
        Controls.Add(Label34)
        Controls.Add(Label35)
        Controls.Add(Label36)
        Controls.Add(Label37)
        Controls.Add(Label38)
        Controls.Add(Label39)
        Controls.Add(Label40)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ButtonSave)
        Controls.Add(ListBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "FormTeam"
        Text = "Team Editor"
        CType(NumericPerformance, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ButtonRemovePlayer As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ButtonAddPlayer As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonMoveUp As Button
    Friend WithEvents ButtonMoveDown As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents ComboStadium As ComboBox
    Friend WithEvents LabelTeamName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextAttack As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextDefend As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextLineout As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextScrum As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextKick As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextLoose As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextStamina As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextTechnique As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextOverall As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TextFlair As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents NumericPerformance As NumericUpDown
    Friend WithEvents Label22 As Label
    Friend WithEvents ComboSetLeft As ComboBox
    Friend WithEvents ComboSetUp As ComboBox
    Friend WithEvents ComboSetRight As ComboBox
    Friend WithEvents ComboSetDown As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents ComboPosition As ComboBox
    Friend WithEvents TextBoxNameFilter As TextBox
    Friend WithEvents ComboNationality As ComboBox
    Friend WithEvents ComboCaptain As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents ComboVice As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents ComboLongGoal As ComboBox
    Friend WithEvents Label53 As Label
    Friend WithEvents ComboShortGoal As ComboBox
    Friend WithEvents Label54 As Label
    Friend WithEvents ComboLongPunt As ComboBox
    Friend WithEvents Label55 As Label
    Friend WithEvents ComboShortPunt As ComboBox
    Friend WithEvents Label56 As Label
    Friend WithEvents ComboKickOff As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ButtonRemoveAll As Button
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelPosition As Label
    Friend WithEvents LabelNationality As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
End Class

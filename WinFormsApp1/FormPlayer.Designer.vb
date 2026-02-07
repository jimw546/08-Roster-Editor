<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPlayer))
        TextPlayerName = New TextBox()
        ComboPosition1 = New ComboBox()
        TextTend = New TextBox()
        TextAttack = New TextBox()
        ComboPosition2 = New ComboBox()
        ComboPosition3 = New ComboBox()
        ComboNationality = New ComboBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        ComboHands = New ComboBox()
        ComboTapeWrists = New ComboBox()
        ComboTapeThighs = New ComboBox()
        Label41 = New Label()
        Label39 = New Label()
        TextCommentary = New TextBox()
        Label35 = New Label()
        NumericSkin = New NumericUpDown()
        Label34 = New Label()
        Label33 = New Label()
        TextFace = New TextBox()
        Label32 = New Label()
        CheckBoxSocks = New CheckBox()
        TextBoots = New TextBox()
        Label31 = New Label()
        TextHeight = New TextBox()
        Label30 = New Label()
        CheckBoxHand = New CheckBox()
        TextMass = New TextBox()
        Label29 = New Label()
        TextAge = New TextBox()
        Label28 = New Label()
        TabPage2 = New TabPage()
        Label27 = New Label()
        TextGap = New TextBox()
        Label26 = New Label()
        TextCrash = New TextBox()
        Label21 = New Label()
        TextSet = New TextBox()
        Label22 = New Label()
        TextBrave = New TextBox()
        TextCreat = New TextBox()
        Label23 = New Label()
        Label24 = New Label()
        TextTemp = New TextBox()
        TextCons = New TextBox()
        Label25 = New Label()
        Label16 = New Label()
        TextStam = New TextBox()
        Label17 = New Label()
        TextAggro = New TextBox()
        TextDiscip = New TextBox()
        Label18 = New Label()
        Label19 = New Label()
        TextLine = New TextBox()
        TextHook = New TextBox()
        Label20 = New Label()
        Label11 = New Label()
        TextScrum = New TextBox()
        Label12 = New Label()
        TextRuck = New TextBox()
        TextStrength = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        TextTackle = New TextBox()
        TextGoal = New TextBox()
        Label15 = New Label()
        Label6 = New Label()
        TextKickPwr = New TextBox()
        Label7 = New Label()
        TextKick = New TextBox()
        TextPass = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        TextHandl = New TextBox()
        TextAgil = New TextBox()
        Label10 = New Label()
        Label5 = New Label()
        TextAccel = New TextBox()
        Label3 = New Label()
        TextSpeed = New TextBox()
        TextDefend = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage3 = New TabPage()
        CheckTackler = New CheckBox()
        CheckBallWin = New CheckBox()
        CheckDefOrg = New CheckBox()
        CheckScrum = New CheckBox()
        CheckJumper = New CheckBox()
        CheckBox11 = New CheckBox()
        CheckBox10 = New CheckBox()
        CheckInjury = New CheckBox()
        CheckCommand = New CheckBox()
        CheckPassing = New CheckBox()
        CheckPlaymaker = New CheckBox()
        CheckScoring = New CheckBox()
        CheckGoalkick = New CheckBox()
        CheckTacticalKick = New CheckBox()
        CheckCrashBall = New CheckBox()
        CheckTackleBreak = New CheckBox()
        ButtonSave = New Button()
        ButtonCancel = New Button()
        Label36 = New Label()
        Label37 = New Label()
        Label38 = New Label()
        Label40 = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(NumericSkin, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextPlayerName
        ' 
        TextPlayerName.Location = New Point(110, 28)
        TextPlayerName.MaxLength = 16
        TextPlayerName.Name = "TextPlayerName"
        TextPlayerName.Size = New Size(213, 27)
        TextPlayerName.TabIndex = 1
        ' 
        ' ComboPosition1
        ' 
        ComboPosition1.FormattingEnabled = True
        ComboPosition1.Items.AddRange(New Object() {"Prop 1", "Hooker", "Prop 3", "Lock", "Flanker 6", "Flanker 7", "Number 8", "Srum Half", "Fly Half", "Winger", "Centre", "Full Back"})
        ComboPosition1.Location = New Point(111, 61)
        ComboPosition1.Name = "ComboPosition1"
        ComboPosition1.Size = New Size(151, 28)
        ComboPosition1.TabIndex = 3
        ' 
        ' TextTend
        ' 
        TextTend.Location = New Point(76, 16)
        TextTend.MaxLength = 2
        TextTend.Name = "TextTend"
        TextTend.Size = New Size(46, 27)
        TextTend.TabIndex = 7
        ' 
        ' TextAttack
        ' 
        TextAttack.Location = New Point(76, 49)
        TextAttack.MaxLength = 2
        TextAttack.Name = "TextAttack"
        TextAttack.Size = New Size(46, 27)
        TextAttack.TabIndex = 8
        ' 
        ' ComboPosition2
        ' 
        ComboPosition2.FormattingEnabled = True
        ComboPosition2.Items.AddRange(New Object() {"Prop 1", "Hooker", "Prop 3", "Lock", "Flanker 6", "Flanker 7", "Number 8", "Srum Half", "Fly Half", "Winger", "Centre", "Full Back", "None"})
        ComboPosition2.Location = New Point(268, 61)
        ComboPosition2.Name = "ComboPosition2"
        ComboPosition2.Size = New Size(151, 28)
        ComboPosition2.TabIndex = 4
        ' 
        ' ComboPosition3
        ' 
        ComboPosition3.FormattingEnabled = True
        ComboPosition3.Items.AddRange(New Object() {"Prop 1", "Hooker", "Prop 3", "Lock", "Flanker 6", "Flanker 7", "Number 8", "Srum Half", "Fly Half", "Winger", "Centre", "Full Back", "None"})
        ComboPosition3.Location = New Point(425, 61)
        ComboPosition3.Name = "ComboPosition3"
        ComboPosition3.Size = New Size(151, 28)
        ComboPosition3.TabIndex = 5
        ' 
        ' ComboNationality
        ' 
        ComboNationality.FormattingEnabled = True
        ComboNationality.Items.AddRange(New Object() {"Argentina", "Australia", "Canada", "UNDEFINED", "England", "Fiji", "France", "Georgia", "Ireland", "Italy", "Japan", "Namibia", "New Zealand", "Romania", "Russia", "Samoa", "Scotland", "South Africa", "Spain", "Tonga", "Chile", "Uruguay", "USA", "Wales", "Portugal"})
        ComboNationality.Location = New Point(425, 27)
        ComboNationality.Name = "ComboNationality"
        ComboNationality.Size = New Size(151, 28)
        ComboNationality.TabIndex = 2
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(12, 101)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(568, 296)
        TabControl1.TabIndex = 6
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Transparent
        TabPage1.Controls.Add(ComboHands)
        TabPage1.Controls.Add(ComboTapeWrists)
        TabPage1.Controls.Add(ComboTapeThighs)
        TabPage1.Controls.Add(Label41)
        TabPage1.Controls.Add(Label39)
        TabPage1.Controls.Add(TextCommentary)
        TabPage1.Controls.Add(Label35)
        TabPage1.Controls.Add(NumericSkin)
        TabPage1.Controls.Add(Label34)
        TabPage1.Controls.Add(Label33)
        TabPage1.Controls.Add(TextFace)
        TabPage1.Controls.Add(Label32)
        TabPage1.Controls.Add(CheckBoxSocks)
        TabPage1.Controls.Add(TextBoots)
        TabPage1.Controls.Add(Label31)
        TabPage1.Controls.Add(TextHeight)
        TabPage1.Controls.Add(Label30)
        TabPage1.Controls.Add(CheckBoxHand)
        TabPage1.Controls.Add(TextMass)
        TabPage1.Controls.Add(Label29)
        TabPage1.Controls.Add(TextAge)
        TabPage1.Controls.Add(Label28)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(560, 263)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Info"
        ' 
        ' ComboHands
        ' 
        ComboHands.FormattingEnabled = True
        ComboHands.Items.AddRange(New Object() {"None", "Left", "Right", "Both", "Gloves"})
        ComboHands.Location = New Point(390, 180)
        ComboHands.Name = "ComboHands"
        ComboHands.Size = New Size(94, 28)
        ComboHands.TabIndex = 65
        ' 
        ' ComboTapeWrists
        ' 
        ComboTapeWrists.FormattingEnabled = True
        ComboTapeWrists.Items.AddRange(New Object() {"None", "Left", "Right", "Both"})
        ComboTapeWrists.Location = New Point(390, 146)
        ComboTapeWrists.Name = "ComboTapeWrists"
        ComboTapeWrists.Size = New Size(94, 28)
        ComboTapeWrists.TabIndex = 64
        ' 
        ' ComboTapeThighs
        ' 
        ComboTapeThighs.FormattingEnabled = True
        ComboTapeThighs.Items.AddRange(New Object() {"None", "Left", "Right", "Both"})
        ComboTapeThighs.Location = New Point(390, 112)
        ComboTapeThighs.Name = "ComboTapeThighs"
        ComboTapeThighs.Size = New Size(94, 28)
        ComboTapeThighs.TabIndex = 63
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Location = New Point(333, 183)
        Label41.Name = "Label41"
        Label41.Size = New Size(51, 20)
        Label41.TabIndex = 38
        Label41.Text = "Hands"
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Location = New Point(45, 184)
        Label39.Name = "Label39"
        Label39.Size = New Size(94, 20)
        Label39.TabIndex = 34
        Label39.Text = "Commentary"
        ' 
        ' TextCommentary
        ' 
        TextCommentary.BackColor = SystemColors.Window
        TextCommentary.Location = New Point(145, 181)
        TextCommentary.MaxLength = 4
        TextCommentary.Name = "TextCommentary"
        TextCommentary.Size = New Size(94, 27)
        TextCommentary.TabIndex = 33
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Location = New Point(297, 115)
        Label35.Name = "Label35"
        Label35.Size = New Size(87, 20)
        Label35.TabIndex = 31
        Label35.Text = "Tape Thighs"
        ' 
        ' NumericSkin
        ' 
        NumericSkin.Location = New Point(390, 79)
        NumericSkin.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        NumericSkin.Name = "NumericSkin"
        NumericSkin.Size = New Size(46, 27)
        NumericSkin.TabIndex = 29
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Location = New Point(300, 149)
        Label34.Name = "Label34"
        Label34.Size = New Size(84, 20)
        Label34.TabIndex = 28
        Label34.Text = "Tape Wrists"
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Location = New Point(348, 82)
        Label33.Name = "Label33"
        Label33.Size = New Size(36, 20)
        Label33.TabIndex = 26
        Label33.Text = "Skin"
        ' 
        ' TextFace
        ' 
        TextFace.Location = New Point(145, 147)
        TextFace.MaxLength = 5
        TextFace.Name = "TextFace"
        TextFace.Size = New Size(94, 27)
        TextFace.TabIndex = 23
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Location = New Point(101, 150)
        Label32.Name = "Label32"
        Label32.Size = New Size(38, 20)
        Label32.TabIndex = 24
        Label32.Text = "Face"
        ' 
        ' CheckBoxSocks
        ' 
        CheckBoxSocks.AutoSize = True
        CheckBoxSocks.CheckAlign = ContentAlignment.MiddleRight
        CheckBoxSocks.Location = New Point(302, 49)
        CheckBoxSocks.Name = "CheckBoxSocks"
        CheckBoxSocks.Size = New Size(109, 24)
        CheckBoxSocks.TabIndex = 22
        CheckBoxSocks.Text = "Socks down"
        CheckBoxSocks.UseVisualStyleBackColor = True
        ' 
        ' TextBoots
        ' 
        TextBoots.Location = New Point(390, 16)
        TextBoots.MaxLength = 2
        TextBoots.Name = "TextBoots"
        TextBoots.Size = New Size(94, 27)
        TextBoots.TabIndex = 20
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Location = New Point(302, 19)
        Label31.Name = "Label31"
        Label31.Size = New Size(82, 20)
        Label31.TabIndex = 21
        Label31.Text = "Boots Type"
        ' 
        ' TextHeight
        ' 
        TextHeight.Location = New Point(145, 112)
        TextHeight.MaxLength = 3
        TextHeight.Name = "TextHeight"
        TextHeight.Size = New Size(46, 27)
        TextHeight.TabIndex = 18
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Location = New Point(51, 115)
        Label30.Name = "Label30"
        Label30.Size = New Size(88, 20)
        Label30.TabIndex = 19
        Label30.Text = "Height (cm)"
        ' 
        ' CheckBoxHand
        ' 
        CheckBoxHand.AutoSize = True
        CheckBoxHand.CheckAlign = ContentAlignment.MiddleRight
        CheckBoxHand.Location = New Point(51, 49)
        CheckBoxHand.Name = "CheckBoxHand"
        CheckBoxHand.Size = New Size(115, 24)
        CheckBoxHand.TabIndex = 17
        CheckBoxHand.Text = "Left-Handed"
        CheckBoxHand.UseVisualStyleBackColor = True
        ' 
        ' TextMass
        ' 
        TextMass.Location = New Point(145, 79)
        TextMass.MaxLength = 3
        TextMass.Name = "TextMass"
        TextMass.Size = New Size(46, 27)
        TextMass.TabIndex = 15
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Location = New Point(67, 82)
        Label29.Name = "Label29"
        Label29.Size = New Size(72, 20)
        Label29.TabIndex = 16
        Label29.Text = "Mass (kg)"
        ' 
        ' TextAge
        ' 
        TextAge.Location = New Point(145, 16)
        TextAge.MaxLength = 2
        TextAge.Name = "TextAge"
        TextAge.Size = New Size(46, 27)
        TextAge.TabIndex = 13
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(94, 19)
        Label28.Name = "Label28"
        Label28.Size = New Size(36, 20)
        Label28.TabIndex = 14
        Label28.Text = "Age"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Transparent
        TabPage2.Controls.Add(Label27)
        TabPage2.Controls.Add(TextGap)
        TabPage2.Controls.Add(Label26)
        TabPage2.Controls.Add(TextCrash)
        TabPage2.Controls.Add(Label21)
        TabPage2.Controls.Add(TextSet)
        TabPage2.Controls.Add(Label22)
        TabPage2.Controls.Add(TextBrave)
        TabPage2.Controls.Add(TextCreat)
        TabPage2.Controls.Add(Label23)
        TabPage2.Controls.Add(Label24)
        TabPage2.Controls.Add(TextTemp)
        TabPage2.Controls.Add(TextCons)
        TabPage2.Controls.Add(Label25)
        TabPage2.Controls.Add(Label16)
        TabPage2.Controls.Add(TextStam)
        TabPage2.Controls.Add(Label17)
        TabPage2.Controls.Add(TextAggro)
        TabPage2.Controls.Add(TextDiscip)
        TabPage2.Controls.Add(Label18)
        TabPage2.Controls.Add(Label19)
        TabPage2.Controls.Add(TextLine)
        TabPage2.Controls.Add(TextHook)
        TabPage2.Controls.Add(Label20)
        TabPage2.Controls.Add(Label11)
        TabPage2.Controls.Add(TextScrum)
        TabPage2.Controls.Add(Label12)
        TabPage2.Controls.Add(TextRuck)
        TabPage2.Controls.Add(TextStrength)
        TabPage2.Controls.Add(Label13)
        TabPage2.Controls.Add(Label14)
        TabPage2.Controls.Add(TextTackle)
        TabPage2.Controls.Add(TextGoal)
        TabPage2.Controls.Add(Label15)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(TextKickPwr)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(TextKick)
        TabPage2.Controls.Add(TextPass)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(TextHandl)
        TabPage2.Controls.Add(TextAgil)
        TabPage2.Controls.Add(Label10)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(TextAccel)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(TextSpeed)
        TabPage2.Controls.Add(TextDefend)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(TextAttack)
        TabPage2.Controls.Add(TextTend)
        TabPage2.Controls.Add(Label1)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(560, 263)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Stats"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(446, 202)
        Label27.Name = "Label27"
        Label27.Size = New Size(36, 20)
        Label27.TabIndex = 59
        Label27.Text = "Gap"
        ' 
        ' TextGap
        ' 
        TextGap.Location = New Point(488, 199)
        TextGap.MaxLength = 2
        TextGap.Name = "TextGap"
        TextGap.Size = New Size(46, 27)
        TextGap.TabIndex = 58
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(437, 169)
        Label26.Name = "Label26"
        Label26.Size = New Size(45, 20)
        Label26.TabIndex = 57
        Label26.Text = "Crash"
        ' 
        ' TextCrash
        ' 
        TextCrash.Location = New Point(488, 166)
        TextCrash.MaxLength = 2
        TextCrash.Name = "TextCrash"
        TextCrash.Size = New Size(46, 27)
        TextCrash.TabIndex = 56
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(452, 136)
        Label21.Name = "Label21"
        Label21.Size = New Size(30, 20)
        Label21.TabIndex = 55
        Label21.Text = "Set"
        ' 
        ' TextSet
        ' 
        TextSet.Location = New Point(488, 133)
        TextSet.MaxLength = 2
        TextSet.Name = "TextSet"
        TextSet.Size = New Size(46, 27)
        TextSet.TabIndex = 54
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(436, 103)
        Label22.Name = "Label22"
        Label22.Size = New Size(46, 20)
        Label22.TabIndex = 53
        Label22.Text = "Brave"
        ' 
        ' TextBrave
        ' 
        TextBrave.Location = New Point(488, 100)
        TextBrave.MaxLength = 2
        TextBrave.Name = "TextBrave"
        TextBrave.Size = New Size(46, 27)
        TextBrave.TabIndex = 51
        ' 
        ' TextCreat
        ' 
        TextCreat.Location = New Point(488, 67)
        TextCreat.MaxLength = 2
        TextCreat.Name = "TextCreat"
        TextCreat.Size = New Size(46, 27)
        TextCreat.TabIndex = 50
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(436, 70)
        Label23.Name = "Label23"
        Label23.Size = New Size(44, 20)
        Label23.TabIndex = 52
        Label23.Text = "Creat"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(436, 37)
        Label24.Name = "Label24"
        Label24.Size = New Size(46, 20)
        Label24.TabIndex = 49
        Label24.Text = "Temp"
        ' 
        ' TextTemp
        ' 
        TextTemp.Location = New Point(488, 34)
        TextTemp.MaxLength = 2
        TextTemp.Name = "TextTemp"
        TextTemp.Size = New Size(46, 27)
        TextTemp.TabIndex = 47
        ' 
        ' TextCons
        ' 
        TextCons.Location = New Point(350, 214)
        TextCons.MaxLength = 2
        TextCons.Name = "TextCons"
        TextCons.Size = New Size(46, 27)
        TextCons.TabIndex = 46
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(299, 217)
        Label25.Name = "Label25"
        Label25.Size = New Size(41, 20)
        Label25.TabIndex = 48
        Label25.Text = "Cons"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(281, 184)
        Label16.Name = "Label16"
        Label16.Size = New Size(63, 20)
        Label16.TabIndex = 45
        Label16.Text = "Stamina"
        ' 
        ' TextStam
        ' 
        TextStam.Location = New Point(350, 181)
        TextStam.MaxLength = 2
        TextStam.Name = "TextStam"
        TextStam.Size = New Size(46, 27)
        TextStam.TabIndex = 44
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(293, 151)
        Label17.Name = "Label17"
        Label17.Size = New Size(51, 20)
        Label17.TabIndex = 43
        Label17.Text = "Aggro"
        ' 
        ' TextAggro
        ' 
        TextAggro.Location = New Point(350, 148)
        TextAggro.MaxLength = 2
        TextAggro.Name = "TextAggro"
        TextAggro.Size = New Size(46, 27)
        TextAggro.TabIndex = 41
        ' 
        ' TextDiscip
        ' 
        TextDiscip.Location = New Point(350, 115)
        TextDiscip.MaxLength = 2
        TextDiscip.Name = "TextDiscip"
        TextDiscip.Size = New Size(46, 27)
        TextDiscip.TabIndex = 40
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(294, 118)
        Label18.Name = "Label18"
        Label18.Size = New Size(50, 20)
        Label18.TabIndex = 42
        Label18.Text = "Discip"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(308, 85)
        Label19.Name = "Label19"
        Label19.Size = New Size(36, 20)
        Label19.TabIndex = 39
        Label19.Text = "Line"
        ' 
        ' TextLine
        ' 
        TextLine.Location = New Point(350, 82)
        TextLine.MaxLength = 2
        TextLine.Name = "TextLine"
        TextLine.Size = New Size(46, 27)
        TextLine.TabIndex = 37
        ' 
        ' TextHook
        ' 
        TextHook.Location = New Point(350, 49)
        TextHook.MaxLength = 2
        TextHook.Name = "TextHook"
        TextHook.Size = New Size(46, 27)
        TextHook.TabIndex = 36
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(299, 52)
        Label20.Name = "Label20"
        Label20.Size = New Size(45, 20)
        Label20.TabIndex = 38
        Label20.Text = "Hook"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(294, 19)
        Label11.Name = "Label11"
        Label11.Size = New Size(50, 20)
        Label11.TabIndex = 35
        Label11.Text = "Scrum"
        ' 
        ' TextScrum
        ' 
        TextScrum.Location = New Point(350, 16)
        TextScrum.MaxLength = 2
        TextScrum.Name = "TextScrum"
        TextScrum.Size = New Size(46, 27)
        TextScrum.TabIndex = 34
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(157, 217)
        Label12.Name = "Label12"
        Label12.Size = New Size(40, 20)
        Label12.TabIndex = 33
        Label12.Text = "Ruck"
        ' 
        ' TextRuck
        ' 
        TextRuck.Location = New Point(207, 214)
        TextRuck.MaxLength = 2
        TextRuck.Name = "TextRuck"
        TextRuck.Size = New Size(46, 27)
        TextRuck.TabIndex = 31
        ' 
        ' TextStrength
        ' 
        TextStrength.Location = New Point(207, 181)
        TextStrength.MaxLength = 2
        TextStrength.Name = "TextStrength"
        TextStrength.Size = New Size(46, 27)
        TextStrength.TabIndex = 30
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(132, 184)
        Label13.Name = "Label13"
        Label13.Size = New Size(65, 20)
        Label13.TabIndex = 32
        Label13.Text = "Strength"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(148, 151)
        Label14.Name = "Label14"
        Label14.Size = New Size(49, 20)
        Label14.TabIndex = 29
        Label14.Text = "Tackle"
        ' 
        ' TextTackle
        ' 
        TextTackle.Location = New Point(207, 148)
        TextTackle.MaxLength = 2
        TextTackle.Name = "TextTackle"
        TextTackle.Size = New Size(46, 27)
        TextTackle.TabIndex = 27
        ' 
        ' TextGoal
        ' 
        TextGoal.Location = New Point(207, 115)
        TextGoal.MaxLength = 2
        TextGoal.Name = "TextGoal"
        TextGoal.Size = New Size(46, 27)
        TextGoal.TabIndex = 26
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(157, 118)
        Label15.Name = "Label15"
        Label15.Size = New Size(40, 20)
        Label15.TabIndex = 28
        Label15.Text = "Goal"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(137, 85)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 20)
        Label6.TabIndex = 25
        Label6.Text = "KickPwr"
        ' 
        ' TextKickPwr
        ' 
        TextKickPwr.Location = New Point(207, 82)
        TextKickPwr.MaxLength = 2
        TextKickPwr.Name = "TextKickPwr"
        TextKickPwr.Size = New Size(46, 27)
        TextKickPwr.TabIndex = 24
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(161, 52)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 20)
        Label7.TabIndex = 23
        Label7.Text = "Kick"
        ' 
        ' TextKick
        ' 
        TextKick.Location = New Point(207, 49)
        TextKick.MaxLength = 2
        TextKick.Name = "TextKick"
        TextKick.Size = New Size(46, 27)
        TextKick.TabIndex = 21
        ' 
        ' TextPass
        ' 
        TextPass.Location = New Point(207, 16)
        TextPass.MaxLength = 2
        TextPass.Name = "TextPass"
        TextPass.Size = New Size(46, 27)
        TextPass.TabIndex = 20
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(161, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(36, 20)
        Label8.TabIndex = 22
        Label8.Text = "Pass"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(17, 217)
        Label9.Name = "Label9"
        Label9.Size = New Size(49, 20)
        Label9.TabIndex = 19
        Label9.Text = "Handl"
        ' 
        ' TextHandl
        ' 
        TextHandl.Location = New Point(76, 214)
        TextHandl.MaxLength = 2
        TextHandl.Name = "TextHandl"
        TextHandl.Size = New Size(46, 27)
        TextHandl.TabIndex = 13
        ' 
        ' TextAgil
        ' 
        TextAgil.Location = New Point(76, 181)
        TextAgil.MaxLength = 2
        TextAgil.Name = "TextAgil"
        TextAgil.Size = New Size(46, 27)
        TextAgil.TabIndex = 12
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(30, 184)
        Label10.Name = "Label10"
        Label10.Size = New Size(36, 20)
        Label10.TabIndex = 18
        Label10.Text = "Agil"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 151)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 20)
        Label5.TabIndex = 15
        Label5.Text = "Accel"
        ' 
        ' TextAccel
        ' 
        TextAccel.Location = New Point(76, 148)
        TextAccel.MaxLength = 2
        TextAccel.Name = "TextAccel"
        TextAccel.Size = New Size(46, 27)
        TextAccel.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 13
        Label3.Text = "Speed"
        ' 
        ' TextSpeed
        ' 
        TextSpeed.Location = New Point(76, 115)
        TextSpeed.MaxLength = 2
        TextSpeed.Name = "TextSpeed"
        TextSpeed.Size = New Size(46, 27)
        TextSpeed.TabIndex = 10
        ' 
        ' TextDefend
        ' 
        TextDefend.Location = New Point(76, 82)
        TextDefend.MaxLength = 2
        TextDefend.Name = "TextDefend"
        TextDefend.Size = New Size(46, 27)
        TextDefend.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(8, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 20)
        Label4.TabIndex = 12
        Label4.Text = "Defend"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 20)
        Label2.TabIndex = 9
        Label2.Text = "Attack"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 20)
        Label1.TabIndex = 8
        Label1.Text = "Tend"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.Transparent
        TabPage3.Controls.Add(CheckTackler)
        TabPage3.Controls.Add(CheckBallWin)
        TabPage3.Controls.Add(CheckDefOrg)
        TabPage3.Controls.Add(CheckScrum)
        TabPage3.Controls.Add(CheckJumper)
        TabPage3.Controls.Add(CheckBox11)
        TabPage3.Controls.Add(CheckBox10)
        TabPage3.Controls.Add(CheckInjury)
        TabPage3.Controls.Add(CheckCommand)
        TabPage3.Controls.Add(CheckPassing)
        TabPage3.Controls.Add(CheckPlaymaker)
        TabPage3.Controls.Add(CheckScoring)
        TabPage3.Controls.Add(CheckGoalkick)
        TabPage3.Controls.Add(CheckTacticalKick)
        TabPage3.Controls.Add(CheckCrashBall)
        TabPage3.Controls.Add(CheckTackleBreak)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(560, 263)
        TabPage3.TabIndex = 3
        TabPage3.Text = "Perks"
        ' 
        ' CheckTackler
        ' 
        CheckTackler.AutoSize = True
        CheckTackler.CheckAlign = ContentAlignment.MiddleRight
        CheckTackler.Location = New Point(283, 225)
        CheckTackler.Name = "CheckTackler"
        CheckTackler.Size = New Size(76, 24)
        CheckTackler.TabIndex = 49
        CheckTackler.Text = "Tackler"
        CheckTackler.UseVisualStyleBackColor = True
        ' 
        ' CheckBallWin
        ' 
        CheckBallWin.AutoSize = True
        CheckBallWin.CheckAlign = ContentAlignment.MiddleRight
        CheckBallWin.Location = New Point(252, 195)
        CheckBallWin.Name = "CheckBallWin"
        CheckBallWin.Size = New Size(107, 24)
        CheckBallWin.TabIndex = 48
        CheckBallWin.Text = "Ball Winner"
        CheckBallWin.UseVisualStyleBackColor = True
        ' 
        ' CheckDefOrg
        ' 
        CheckDefOrg.AutoSize = True
        CheckDefOrg.CheckAlign = ContentAlignment.MiddleRight
        CheckDefOrg.Location = New Point(245, 165)
        CheckDefOrg.Name = "CheckDefOrg"
        CheckDefOrg.Size = New Size(114, 24)
        CheckDefOrg.TabIndex = 47
        CheckDefOrg.Text = "Defense Org"
        CheckDefOrg.UseVisualStyleBackColor = True
        ' 
        ' CheckScrum
        ' 
        CheckScrum.AutoSize = True
        CheckScrum.CheckAlign = ContentAlignment.MiddleRight
        CheckScrum.Location = New Point(249, 135)
        CheckScrum.Name = "CheckScrum"
        CheckScrum.Size = New Size(110, 24)
        CheckScrum.TabIndex = 46
        CheckScrum.Text = "Scrummage"
        CheckScrum.UseVisualStyleBackColor = True
        ' 
        ' CheckJumper
        ' 
        CheckJumper.AutoSize = True
        CheckJumper.CheckAlign = ContentAlignment.MiddleRight
        CheckJumper.Location = New Point(280, 105)
        CheckJumper.Name = "CheckJumper"
        CheckJumper.Size = New Size(79, 24)
        CheckJumper.TabIndex = 45
        CheckJumper.Text = "Jumper"
        CheckJumper.UseVisualStyleBackColor = True
        ' 
        ' CheckBox11
        ' 
        CheckBox11.AutoSize = True
        CheckBox11.CheckAlign = ContentAlignment.MiddleRight
        CheckBox11.Location = New Point(283, 75)
        CheckBox11.Name = "CheckBox11"
        CheckBox11.Size = New Size(76, 24)
        CheckBox11.TabIndex = 44
        CheckBox11.Text = "Box 11"
        CheckBox11.UseVisualStyleBackColor = True
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.CheckAlign = ContentAlignment.MiddleRight
        CheckBox10.Location = New Point(283, 45)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(76, 24)
        CheckBox10.TabIndex = 43
        CheckBox10.Text = "Box 10"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckInjury
        ' 
        CheckInjury.AutoSize = True
        CheckInjury.CheckAlign = ContentAlignment.MiddleRight
        CheckInjury.Location = New Point(249, 15)
        CheckInjury.Name = "CheckInjury"
        CheckInjury.Size = New Size(109, 24)
        CheckInjury.TabIndex = 42
        CheckInjury.Text = "Injury Resist"
        CheckInjury.UseVisualStyleBackColor = True
        ' 
        ' CheckCommand
        ' 
        CheckCommand.AutoSize = True
        CheckCommand.CheckAlign = ContentAlignment.MiddleRight
        CheckCommand.Location = New Point(86, 225)
        CheckCommand.Name = "CheckCommand"
        CheckCommand.Size = New Size(100, 24)
        CheckCommand.TabIndex = 41
        CheckCommand.Text = "Command"
        CheckCommand.UseVisualStyleBackColor = True
        ' 
        ' CheckPassing
        ' 
        CheckPassing.AutoSize = True
        CheckPassing.CheckAlign = ContentAlignment.MiddleRight
        CheckPassing.Location = New Point(107, 195)
        CheckPassing.Name = "CheckPassing"
        CheckPassing.Size = New Size(79, 24)
        CheckPassing.TabIndex = 40
        CheckPassing.Text = "Passing"
        CheckPassing.UseVisualStyleBackColor = True
        ' 
        ' CheckPlaymaker
        ' 
        CheckPlaymaker.AutoSize = True
        CheckPlaymaker.CheckAlign = ContentAlignment.MiddleRight
        CheckPlaymaker.Location = New Point(89, 165)
        CheckPlaymaker.Name = "CheckPlaymaker"
        CheckPlaymaker.Size = New Size(99, 24)
        CheckPlaymaker.TabIndex = 39
        CheckPlaymaker.Text = "Playmaker"
        CheckPlaymaker.UseVisualStyleBackColor = True
        ' 
        ' CheckScoring
        ' 
        CheckScoring.AutoSize = True
        CheckScoring.CheckAlign = ContentAlignment.MiddleRight
        CheckScoring.Location = New Point(107, 135)
        CheckScoring.Name = "CheckScoring"
        CheckScoring.Size = New Size(81, 24)
        CheckScoring.TabIndex = 38
        CheckScoring.Text = "Scoring"
        CheckScoring.UseVisualStyleBackColor = True
        ' 
        ' CheckGoalkick
        ' 
        CheckGoalkick.AutoSize = True
        CheckGoalkick.CheckAlign = ContentAlignment.MiddleRight
        CheckGoalkick.Location = New Point(82, 105)
        CheckGoalkick.Name = "CheckGoalkick"
        CheckGoalkick.Size = New Size(106, 24)
        CheckGoalkick.TabIndex = 37
        CheckGoalkick.Text = "Goal Kicker"
        CheckGoalkick.UseVisualStyleBackColor = True
        ' 
        ' CheckTacticalKick
        ' 
        CheckTacticalKick.AutoSize = True
        CheckTacticalKick.CheckAlign = ContentAlignment.MiddleRight
        CheckTacticalKick.Location = New Point(77, 75)
        CheckTacticalKick.Name = "CheckTacticalKick"
        CheckTacticalKick.Size = New Size(111, 24)
        CheckTacticalKick.TabIndex = 36
        CheckTacticalKick.Text = "Tactical Kick"
        CheckTacticalKick.UseVisualStyleBackColor = True
        ' 
        ' CheckCrashBall
        ' 
        CheckCrashBall.AutoSize = True
        CheckCrashBall.CheckAlign = ContentAlignment.MiddleRight
        CheckCrashBall.Location = New Point(92, 45)
        CheckCrashBall.Name = "CheckCrashBall"
        CheckCrashBall.Size = New Size(96, 24)
        CheckCrashBall.TabIndex = 35
        CheckCrashBall.Text = "Crash Ball"
        CheckCrashBall.UseVisualStyleBackColor = True
        ' 
        ' CheckTackleBreak
        ' 
        CheckTackleBreak.AutoSize = True
        CheckTackleBreak.CheckAlign = ContentAlignment.MiddleRight
        CheckTackleBreak.Location = New Point(76, 15)
        CheckTackleBreak.Name = "CheckTackleBreak"
        CheckTackleBreak.Size = New Size(112, 24)
        CheckTackleBreak.TabIndex = 33
        CheckTackleBreak.Text = "Tackle Break"
        CheckTackleBreak.UseVisualStyleBackColor = True
        ' 
        ' ButtonSave
        ' 
        ButtonSave.Location = New Point(324, 416)
        ButtonSave.Name = "ButtonSave"
        ButtonSave.Size = New Size(94, 29)
        ButtonSave.TabIndex = 10
        ButtonSave.Text = "Save"
        ButtonSave.UseVisualStyleBackColor = True
        ' 
        ' ButtonCancel
        ' 
        ButtonCancel.Location = New Point(442, 416)
        ButtonCancel.Name = "ButtonCancel"
        ButtonCancel.Size = New Size(94, 29)
        ButtonCancel.TabIndex = 11
        ButtonCancel.Text = "Cancel"
        ButtonCancel.UseVisualStyleBackColor = True
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Location = New Point(55, 31)
        Label36.Name = "Label36"
        Label36.Size = New Size(49, 20)
        Label36.TabIndex = 60
        Label36.Text = "Name"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Location = New Point(337, 31)
        Label37.Name = "Label37"
        Label37.Size = New Size(82, 20)
        Label37.TabIndex = 61
        Label37.Text = "Nationality"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Location = New Point(37, 64)
        Label38.Name = "Label38"
        Label38.Size = New Size(67, 20)
        Label38.TabIndex = 62
        Label38.Text = "Positions"
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Location = New Point(16, 9)
        Label40.Name = "Label40"
        Label40.Size = New Size(61, 20)
        Label40.TabIndex = 63
        Label40.Text = "Label40"
        ' 
        ' FormPlayer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(603, 457)
        Controls.Add(Label40)
        Controls.Add(Label38)
        Controls.Add(Label37)
        Controls.Add(Label36)
        Controls.Add(ButtonCancel)
        Controls.Add(ButtonSave)
        Controls.Add(TabControl1)
        Controls.Add(ComboNationality)
        Controls.Add(ComboPosition3)
        Controls.Add(ComboPosition2)
        Controls.Add(ComboPosition1)
        Controls.Add(TextPlayerName)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "FormPlayer"
        Text = "Player Editor"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(NumericSkin, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextPlayerName As TextBox
    Friend WithEvents ComboPosition1 As ComboBox
    Friend WithEvents TextTend As TextBox
    Friend WithEvents TextAttack As TextBox
    Friend WithEvents ComboPosition2 As ComboBox
    Friend WithEvents ComboPosition3 As ComboBox
    Friend WithEvents ComboNationality As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TextSet As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBrave As TextBox
    Friend WithEvents TextCreat As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents TextTemp As TextBox
    Friend WithEvents TextCons As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextStam As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextAggro As TextBox
    Friend WithEvents TextDiscip As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TextLine As TextBox
    Friend WithEvents TextHook As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextScrum As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextRuck As TextBox
    Friend WithEvents TextStrength As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextTackle As TextBox
    Friend WithEvents TextGoal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextKickPwr As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextKick As TextBox
    Friend WithEvents TextPass As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextHandl As TextBox
    Friend WithEvents TextAgil As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextAccel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextSpeed As TextBox
    Friend WithEvents TextDefend As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TextGap As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextCrash As TextBox
    Friend WithEvents CheckBoxHand As CheckBox
    Friend WithEvents TextMass As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents TextAge As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TextHeight As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents CheckBoxSocks As CheckBox
    Friend WithEvents TextBoots As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents TextFace As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents NumericSkin As NumericUpDown
    Friend WithEvents Label35 As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents CheckTackleBreak As CheckBox
    Friend WithEvents CheckGoalkick As CheckBox
    Friend WithEvents CheckTacticalKick As CheckBox
    Friend WithEvents CheckCrashBall As CheckBox
    Friend WithEvents CheckTackler As CheckBox
    Friend WithEvents CheckBallWin As CheckBox
    Friend WithEvents CheckDefOrg As CheckBox
    Friend WithEvents CheckScrum As CheckBox
    Friend WithEvents CheckJumper As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckInjury As CheckBox
    Friend WithEvents CheckCommand As CheckBox
    Friend WithEvents CheckPassing As CheckBox
    Friend WithEvents CheckPlaymaker As CheckBox
    Friend WithEvents CheckScoring As CheckBox
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents TextCommentary As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents ComboHands As ComboBox
    Friend WithEvents ComboTapeWrists As ComboBox
    Friend WithEvents ComboTapeThighs As ComboBox
    Friend WithEvents Label40 As Label
End Class

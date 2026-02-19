Public Class FormPlayer
    Public PlayerIndex As Integer
    Dim i As Integer
    Dim j As Integer
    Dim Position1var As String
    Dim Position2var As String
    Dim Position3var As String
    Dim Nationalityvar As String
    Dim SkinVar As String
    Dim TapeThigh As String
    Dim TapeWrist As String
    Dim TapeFinger As String
    Dim CreatedPlayer As String
    Dim Perks1 As String
    Dim Perks2 As String
    Dim NewName As String
    Dim NewNat As String
    Dim NewPos1 As String
    Dim PositionArray = New String() {"0001", "0010", "0011", "0100", "0101", "0110",
        "0111", "1000", "1001", "1010", "1011", "1100", "0000"}
    Dim NationalityArray = New String() {"100", "200", "400", "800", "1600", "3200", "6400", "12800",
        "010", "020", "040", "080", "0160", "0320", "0640", "01280",
        "001", "002", "004", "008", "0016", "0032", "0064", "00128", "000"}

    Private Sub Formplayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = PlayerIndex
        Label40.Text = i

        '0 and 1 player address and profile pic
        '2 and 3 commentary
        '4-19 name
        '20 and 21 positions
        '22 weight
        '23? currently all 0s?
        '24-26 nationality
        '27?
        '28 height
        '29 age
        '30?
        '31 handedness
        '32 - 61 skills
        '84 & 85 perks
        '86 and 87?
        '88 boots
        '89 bit 4 and 5 are finger tape, bit 3 is socks up/down
        '90 and 91 face
        '92 extra, but what does it do? extra bits for the face? apparently extra hair for some faces
        '93 bit 6 and 7 are wrist tape, bit 5 is created player yes/no, bit 1 and 2 is skin colour
        '94 bits 1 and 2 are thigh tape, bit 4 is gloves
        '95?
        '96 Not sure, affecting boots?
        '97? currently all 0's think it's meant to be 0
        '98? currently all 0's think it's meant to be 0
        '99? currently all 0's think it's meant to be 0

        'where is player category? forwards-backs
        'where is player type? scrummager, crashballer etc

        'player names
        TextPlayerName.Text = Form1.DataPlayers(i)(100)

        'positions
        Position1var = Strings.Right("0000000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(i)(20)), 2), 4)
        Position2var = Strings.Left(Strings.Right("0000000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(i)(20)), 2), 8), 4)
        Position3var = Strings.Right("0000000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(i)(21)), 2), 4)
        For j = 0 To 11
            If PositionArray(j) = Position1var Then ComboPosition1.SelectedIndex = j
        Next
        For j = 0 To 12
            If PositionArray(j) = Position2var Then ComboPosition2.SelectedIndex = j
            If PositionArray(j) = Position3var Then ComboPosition3.SelectedIndex = j
        Next

        'nationality
        Nationalityvar = Form1.DataPlayers(i)(24) & Form1.DataPlayers(i)(25) & Form1.DataPlayers(i)(26)
        For j = 0 To 23
            If NationalityArray(j) = Nationalityvar Then ComboNationality.SelectedIndex = j
        Next

        TextCommentary.Text = CInt("&H" & Hex(Form1.DataPlayers(i)(3)) & Hex(Form1.DataPlayers(i)(2)))
        TextMass.Text = CInt((100 + Form1.DataPlayers(i)(22)) / 2.2)
        TextHeight.Text = CInt((Form1.DataPlayers(i)(28) + 60) * 2.54)
        TextAge.Text = 2007 - (1900 + Form1.DataPlayers(i)(29))
        If Form1.DataPlayers(i)(31) = 1 Then CheckBoxHand.Checked = True
        TextBoots.Text = Form1.DataPlayers(i)(88)
        TextFace.Text = Form1.DataPlayers(i)(90) + (Form1.DataPlayers(i)(91) * 256)
        '"Extra" would go here 92

        '94 bits 1 and 2 are thigh tape, bit 4 is gloves
        '89 bit 4 and 5 are finger tape, bit 3 is socks up/down
        '93 bit 6 and 7 are wrist tape, bit 5 is created player yes/no, bit 1 and 2 is skin colour

        TapeThigh = Strings.Right("0000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(i)(94)), 2), 4)
        ComboTapeThighs.SelectedIndex = Mid(TapeThigh, 3, 1) * 2 + Mid(TapeThigh, 4, 1)

        If Strings.Left(Strings.Right("0000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(i)(94)), 2), 4), 1) = 1 Then
            ComboHands.SelectedIndex = 4
        Else
            TapeFinger = Strings.Left(Strings.Right("00000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(i)(89)), 2), 5), 2)
            If TapeFinger = "00" Then ComboHands.SelectedIndex = 0
            If TapeFinger = "01" Then ComboHands.SelectedIndex = 2
            If TapeFinger = "10" Then ComboHands.SelectedIndex = 1
            If TapeFinger = "11" Then ComboHands.SelectedIndex = 3
        End If

        If Strings.Right("00000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(i)(89)), 2), 3) = "000" Then CheckBoxSocks.Checked = True

        TapeWrist = Strings.Right("0000000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(i)(93)), 2), 7)
        ComboTapeWrists.SelectedIndex = (Mid(TapeWrist, 1, 1) * 2) + Mid(TapeWrist, 2, 1)

        CreatedPlayer = Strings.Left(Strings.Right("0000000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(i)(93)), 2), 5), 1)
        SkinVar = Strings.Right("0000000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(i)(93)), 2), 2)
        NumericSkin.Text = Mid(SkinVar, 1, 1) * 2 + Mid(SkinVar, 2, 1)

        'stats
        TextTend.Text = Form1.DataPlayers(i)(32) : TextAttack.Text = Form1.DataPlayers(i)(33)
        TextDefend.Text = Form1.DataPlayers(i)(34) : TextSpeed.Text = Form1.DataPlayers(i)(35)
        TextAccel.Text = Form1.DataPlayers(i)(36) : TextAgil.Text = Form1.DataPlayers(i)(37)
        TextHandl.Text = Form1.DataPlayers(i)(38) : TextPass.Text = Form1.DataPlayers(i)(39)
        TextKick.Text = Form1.DataPlayers(i)(40) : TextKickPwr.Text = Form1.DataPlayers(i)(41)
        TextGoal.Text = Form1.DataPlayers(i)(42) : TextTackle.Text = Form1.DataPlayers(i)(43)
        TextStrength.Text = Form1.DataPlayers(i)(44) : TextRuck.Text = Form1.DataPlayers(i)(45)
        TextScrum.Text = Form1.DataPlayers(i)(46) : TextHook.Text = Form1.DataPlayers(i)(47)
        TextLine.Text = Form1.DataPlayers(i)(48) : TextDiscip.Text = Form1.DataPlayers(i)(49)
        TextAggro.Text = Form1.DataPlayers(i)(50) : TextStam.Text = Form1.DataPlayers(i)(54)
        TextCons.Text = Form1.DataPlayers(i)(55) : TextTemp.Text = Form1.DataPlayers(i)(56)
        TextCreat.Text = Form1.DataPlayers(i)(57) : TextBrave.Text = Form1.DataPlayers(i)(58)
        TextSet.Text = Form1.DataPlayers(i)(59) : TextCrash.Text = Form1.DataPlayers(i)(60)
        TextGap.Text = Form1.DataPlayers(i)(61)

        'perks
        Perks1 = Strings.Right("00000000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(i)(84)), 2), 8)
        Perks2 = Strings.Right("00000000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(i)(85)), 2), 8)
        If Mid(Perks1, 1, 1) = 1 Then CheckTackleBreak.Checked = True
        If Mid(Perks1, 2, 1) = 1 Then CheckCrashBall.Checked = True
        If Mid(Perks1, 3, 1) = 1 Then CheckTacticalKick.Checked = True
        If Mid(Perks1, 4, 1) = 1 Then CheckGoalkick.Checked = True
        If Mid(Perks1, 5, 1) = 1 Then CheckScoring.Checked = True
        If Mid(Perks1, 6, 1) = 1 Then CheckPlaymaker.Checked = True
        If Mid(Perks1, 7, 1) = 1 Then CheckPassing.Checked = True
        If Mid(Perks1, 8, 1) = 1 Then CheckCommand.Checked = True
        If Mid(Perks2, 1, 1) = 1 Then CheckInjury.Checked = True
        If Mid(Perks2, 2, 1) = 1 Then CheckBox10.Checked = True
        If Mid(Perks2, 3, 1) = 1 Then CheckBox11.Checked = True
        If Mid(Perks2, 4, 1) = 1 Then CheckJumper.Checked = True
        If Mid(Perks2, 5, 1) = 1 Then CheckScrum.Checked = True
        If Mid(Perks2, 6, 1) = 1 Then CheckDefOrg.Checked = True
        If Mid(Perks2, 7, 1) = 1 Then CheckBallWin.Checked = True
        If Mid(Perks2, 8, 1) = 1 Then CheckTackler.Checked = True
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        NewName = TextPlayerName.Text
        For j = 4 To 19
            Form1.DataPlayers(i)(j) = 0
        Next
        For j = 4 To NewName.Length + 3
            Form1.DataPlayers(i)(j) = Asc(Mid(NewName, j - 3, 1)) 'offset j because the cells start at number 4
        Next
        Form1.DataPlayers(i)(100) = NewName

        'get new positions from the drop-downs and save
        Position1var = PositionArray(ComboPosition1.SelectedIndex)
        Position2var = PositionArray(ComboPosition2.SelectedIndex)
        Position3var = PositionArray(ComboPosition3.SelectedIndex)
        NewPos1 = Position2var & Position1var
        Form1.DataPlayers(i)(20) = Mid(NewPos1, 1, 1) * 128 + Mid(NewPos1, 2, 1) * 64 +
            Mid(NewPos1, 3, 1) * 32 + Mid(NewPos1, 4, 1) * 16 +
            Mid(NewPos1, 5, 1) * 8 + Mid(NewPos1, 6, 1) * 4 +
            Mid(NewPos1, 7, 1) * 2 + Mid(NewPos1, 8, 1)

        Form1.DataPlayers(i)(21) = Strings.Left(Position3var, 1) * 8 + Mid(Position3var, 2, 1) * 4 + Mid(Position3var, 3, 1) * 2 + Mid(Position3var, 4, 1)

        'nationality from the drop down
        NewNat = NationalityArray(ComboNationality.SelectedIndex)
        If Strings.Left(NewNat, 1) = 0 And Strings.Right(NewNat, 1) = 0 Then
            Form1.DataPlayers(i)(24) = 0 : Form1.DataPlayers(i)(26) = 0
            Form1.DataPlayers(i)(25) = NewNat.Replace("0", "")
        ElseIf Strings.Left(NewNat, 1) = 0 Then
            Form1.DataPlayers(i)(24) = 0 : Form1.DataPlayers(i)(25) = 0
            Form1.DataPlayers(i)(26) = NewNat.Replace("0", "")
        Else
            Form1.DataPlayers(i)(25) = 0 : Form1.DataPlayers(i)(26) = 0
            Form1.DataPlayers(i)(24) = NewNat.Replace("0", "")
        End If

        Form1.DataPlayers(i)(2) = CInt("&H" & Mid(Strings.Right("0000" & Hex(TextCommentary.Text), 4), 3, 2))
        Form1.DataPlayers(i)(3) = CInt("&H" & Mid(Strings.Right("0000" & Hex(TextCommentary.Text), 4), 1, 2))

        '94 bits 1 and 2 are thigh tape, bit 4 is gloves
        If ComboHands.SelectedIndex = 4 Then
            Form1.DataPlayers(i)(94) = ComboTapeThighs.SelectedIndex + 8
        Else Form1.DataPlayers(i)(94) = ComboTapeThighs.SelectedIndex
        End If

        '89 bit 4 and 5 are finger tape, bit 3 is socks up/down
        If ComboHands.SelectedIndex = 0 Or ComboHands.SelectedIndex = 4 Then Form1.DataPlayers(i)(89) = 0
        If ComboHands.SelectedIndex = 1 Then Form1.DataPlayers(i)(89) = 16
        If ComboHands.SelectedIndex = 2 Then Form1.DataPlayers(i)(89) = 8
        If ComboHands.SelectedIndex = 3 Then Form1.DataPlayers(i)(89) = 24
        If CheckBoxSocks.Checked = False Then Form1.DataPlayers(i)(89) = CInt(Form1.DataPlayers(i)(89)) + 4

        '93 bit 6 and 7 are wrist tape, bit 5 is created player yes/no, bit 1 is skin colour
        Form1.DataPlayers(i)(93) = (ComboTapeWrists.SelectedIndex * 32) + (CreatedPlayer * 16) + NumericSkin.Value

        'convert the math operators back
        Form1.DataPlayers(i)(22) = CInt((TextMass.Text * 2.2) - 100)
        Form1.DataPlayers(i)(28) = CInt((TextHeight.Text / 2.54) - 60)
        Form1.DataPlayers(i)(29) = CInt(107 - TextAge.Text)
        If CheckBoxHand.Checked = True Then Form1.DataPlayers(i)(31) = 1 Else Form1.DataPlayers(i)(31) = 129
        Form1.DataPlayers(i)(88) = CInt(TextBoots.Text)
        Form1.DataPlayers(i)(90) = CInt(TextFace.Text) Mod 256
        Form1.DataPlayers(i)(91) = CInt(TextFace.Text) \ 256
        '"Extra" would go here 92

        Form1.DataPlayers(i)(32) = CInt(TextTend.Text) : Form1.DataPlayers(i)(33) = CInt(TextAttack.Text)
        Form1.DataPlayers(i)(34) = CInt(TextDefend.Text) : Form1.DataPlayers(i)(35) = CInt(TextSpeed.Text)
        Form1.DataPlayers(i)(36) = CInt(TextAccel.Text) : Form1.DataPlayers(i)(37) = CInt(TextAgil.Text)
        Form1.DataPlayers(i)(38) = CInt(TextHandl.Text) : Form1.DataPlayers(i)(39) = CInt(TextPass.Text)
        Form1.DataPlayers(i)(40) = CInt(TextKick.Text) : Form1.DataPlayers(i)(41) = CInt(TextKickPwr.Text)
        Form1.DataPlayers(i)(42) = CInt(TextGoal.Text) : Form1.DataPlayers(i)(43) = CInt(TextTackle.Text)
        Form1.DataPlayers(i)(44) = CInt(TextStrength.Text) : Form1.DataPlayers(i)(45) = CInt(TextRuck.Text)
        Form1.DataPlayers(i)(46) = CInt(TextScrum.Text) : Form1.DataPlayers(i)(47) = CInt(TextHook.Text)
        Form1.DataPlayers(i)(48) = CInt(TextLine.Text) : Form1.DataPlayers(i)(49) = CInt(TextDiscip.Text)
        Form1.DataPlayers(i)(50) = CInt(TextAggro.Text) : Form1.DataPlayers(i)(54) = CInt(TextStam.Text)
        Form1.DataPlayers(i)(55) = CInt(TextCons.Text) : Form1.DataPlayers(i)(56) = CInt(TextTemp.Text)
        Form1.DataPlayers(i)(57) = CInt(TextCreat.Text) : Form1.DataPlayers(i)(58) = CInt(TextBrave.Text)
        Form1.DataPlayers(i)(59) = CInt(TextSet.Text) : Form1.DataPlayers(i)(60) = CInt(TextCrash.Text)
        Form1.DataPlayers(i)(61) = CInt(TextGap.Text)

        'perks
        Perks1 = "00000000"
        Perks2 = "00000000"
        If CheckTackleBreak.Checked = True Then Mid(Perks1, 1, 1) = 1
        If CheckCrashBall.Checked = True Then Mid(Perks1, 2, 1) = 1
        If CheckTacticalKick.Checked = True Then Mid(Perks1, 3, 1) = 1
        If CheckGoalkick.Checked = True Then Mid(Perks1, 4, 1) = 1
        If CheckScoring.Checked = True Then Mid(Perks1, 5, 1) = 1
        If CheckPlaymaker.Checked = True Then Mid(Perks1, 6, 1) = 1
        If CheckPassing.Checked = True Then Mid(Perks1, 7, 1) = 1
        If CheckCommand.Checked = True Then Mid(Perks1, 8, 1) = 1
        If CheckInjury.Checked = True Then Mid(Perks2, 1, 1) = 1
        If CheckBox10.Checked = True Then Mid(Perks2, 2, 1) = 1
        If CheckBox11.Checked = True Then Mid(Perks2, 3, 1) = 1
        If CheckJumper.Checked = True Then Mid(Perks2, 4, 1) = 1
        If CheckScrum.Checked = True Then Mid(Perks2, 5, 1) = 1
        If CheckDefOrg.Checked = True Then Mid(Perks2, 6, 1) = 1
        If CheckBallWin.Checked = True Then Mid(Perks2, 7, 1) = 1
        If CheckTackler.Checked = True Then Mid(Perks2, 8, 1) = 1
        Form1.DataPlayers(i)(84) = Strings.Left(Perks1, 1) * 128 + Mid(Perks1, 2, 1) * 64 +
            Mid(Perks1, 3, 1) * 32 + Mid(Perks1, 4, 1) * 16 + Mid(Perks1, 5, 1) * 8 +
            Mid(Perks1, 6, 1) * 4 + Mid(Perks1, 7, 1) * 2 + Mid(Perks1, 8, 1)
        Form1.DataPlayers(i)(85) = Strings.Left(Perks2, 1) * 128 + Mid(Perks2, 2, 1) * 64 +
            Mid(Perks2, 3, 1) * 32 + Mid(Perks2, 4, 1) * 16 + Mid(Perks2, 5, 1) * 8 +
            Mid(Perks2, 6, 1) * 4 + Mid(Perks2, 7, 1) * 2 + Mid(Perks2, 8, 1)

        Form1.DataPlayers.AcceptChanges()
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub ComboPosition1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPosition1.SelectedIndexChanged

    End Sub

    Private Sub ComboPosition2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPosition2.SelectedIndexChanged

    End Sub

    Private Sub ComboPosition3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPosition3.SelectedIndexChanged

    End Sub
End Class
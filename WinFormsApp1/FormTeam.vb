Public Class FormTeam

    Public TeamIndex As Integer
    ' Dim Lineup As New List(Of String)
    Dim DataLineup As New DataTable
    Dim i As Integer
    Dim j As Integer
    Dim k As Integer
    Dim NatVal(2) As String
    Dim NatFilter As String
    Dim NameFilter As String
    Dim PosVal As String
    Dim PosFilter As String
    Dim FilterString As String
    Dim PlayerInfoVar
    Dim DataViewPlayers2 As New DataView(Form1.DataPlayers)
    Dim MoveMem1 As Integer
    Dim MoveMem2 As Integer
    Dim MoveMem3 As Integer
    Dim MoveMem4 As Integer
    Dim MoveMem5 As Integer
    Dim MoveMem6 As Integer
    Dim MoveMem7 As Integer

    'Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox2.MouseDown
    '    ListBox2.DoDragDrop(ListBox2.SelectedItem, DragDropEffects.Copy Or DragDropEffects.Move)
    'End Sub
    'Private Sub ListBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragEnter
    '    If (e.Data.GetDataPresent(DataFormats.OemText)) Then
    '        e.Effect = DragDropEffects.Move
    '    Else
    '        e.Effect = DragDropEffects.None
    '    End If
    'End Sub

    Private Sub FormTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        i = TeamIndex

        DataLineup.Columns.Add("ShirtNumber", GetType(Integer))
        DataLineup.Columns.Add("PlayerAddress", GetType(Integer))
        DataLineup.Columns.Add("PlayerName", GetType(String))
        For j = 0 To 29
            DataLineup.Rows.Add()
            For k = 0 To Form1.DataPlayers.Rows.Count - 1
                If CInt("&H" & Hex(Form1.DataTeams(i)((j * 2) + 1)) &
                    Strings.Right("00" & Hex(Form1.DataTeams(i)(j * 2).ToString), 2)) =
                Form1.DataPlayers(k)("PlayerAddress") Then
                    DataLineup.Rows(j)(0) = j
                    DataLineup.Rows(j)(1) = Form1.DataPlayers(k)("PlayerAddress")
                    DataLineup.Rows(j)(2) = Form1.DataPlayers(k)("PlayerName")
                End If
            Next
        Next
        'DataGridView1.DataSource = DataLineup

        ListBox1.DataSource = DataLineup
        ListBox1.DisplayMember = "PlayerName"
        ListBox1.ValueMember = "PlayerAddress"

        ListBox2.DataSource = DataViewPlayers2
        ListBox2.DisplayMember = "PlayerName"
        ListBox2.ValueMember = "PlayerAddress"
        DataViewPlayers2.Sort = "PlayerName"

        LabelTeamName.Text = Form1.DataTeams(i)(104)

        ComboStadium.DataSource = Form1.DataStadiums
        ComboStadium.DisplayMember = "StadiumName"
        ComboStadium.ValueMember = "Index"
        ComboStadium.SelectedValue = Form1.DataTeams(i)(96)

        'import stats
        TextAttack.Text = Form1.DataTeams(i)(78) : TextDefend.Text = Form1.DataTeams(i)(79)
        TextScrum.Text = Form1.DataTeams(i)(80) : TextLineout.Text = Form1.DataTeams(i)(81)
        TextLoose.Text = Form1.DataTeams(i)(82) : TextKick.Text = Form1.DataTeams(i)(83)
        TextTechnique.Text = Form1.DataTeams(i)(84) : TextStamina.Text = Form1.DataTeams(i)(85)
        TextFlair.Text = Form1.DataTeams(i)(86) : TextOverall.Text = Form1.DataTeams(i)(87)
        NumericPerformance.Value = Form1.DataTeams(i)(91)
        ComboSetLeft.SelectedIndex = Form1.DataTeams(i)(92) : ComboSetUp.SelectedIndex = Form1.DataTeams(i)(93)
        ComboSetRight.SelectedIndex = Form1.DataTeams(i)(94) : ComboSetDown.SelectedIndex = Form1.DataTeams(i)(95)

        ''sets captain and kicker boxes
        ComboCaptain.DataSource = DataLineup
        ComboCaptain.BindingContext = New BindingContext()
        ComboCaptain.DisplayMember = "PlayerName"
        ComboCaptain.ValueMember = "PlayerAddress"
        ComboCaptain.SelectedValue = CInt("&H" & Hex(Form1.DataTeams(i)(65)) & Hex(Form1.DataTeams(i)(64)))

        ComboVice.DataSource = DataLineup
        ComboVice.BindingContext = New BindingContext()
        ComboVice.DisplayMember = "PlayerName"
        ComboVice.ValueMember = "PlayerAddress"
        ComboVice.SelectedValue = CInt("&H" & Hex(Form1.DataTeams(i)(67)) & Hex(Form1.DataTeams(i)(66)))

        ComboLongGoal.DataSource = DataLineup
        ComboLongGoal.BindingContext = New BindingContext()
        ComboLongGoal.DisplayMember = "PlayerName"
        ComboLongGoal.ValueMember = "PlayerAddress"
        ComboLongGoal.SelectedValue = CInt("&H" & Hex(Form1.DataTeams(i)(69)) & Hex(Form1.DataTeams(i)(68)))

        ComboShortGoal.DataSource = DataLineup
        ComboShortGoal.BindingContext = New BindingContext()
        ComboShortGoal.DisplayMember = "PlayerName"
        ComboShortGoal.ValueMember = "PlayerAddress"
        ComboShortGoal.SelectedValue = CInt("&H" & Hex(Form1.DataTeams(i)(71)) & Hex(Form1.DataTeams(i)(70)))

        ComboLongPunt.DataSource = DataLineup
        ComboLongPunt.BindingContext = New BindingContext()
        ComboLongPunt.DisplayMember = "PlayerName"
        ComboLongPunt.ValueMember = "PlayerAddress"
        ComboLongPunt.SelectedValue = CInt("&H" & Hex(Form1.DataTeams(i)(73)) & Hex(Form1.DataTeams(i)(72)))

        ComboShortPunt.DataSource = DataLineup
        ComboShortPunt.BindingContext = New BindingContext()
        ComboShortPunt.DisplayMember = "PlayerName"
        ComboShortPunt.ValueMember = "PlayerAddress"
        ComboShortPunt.SelectedValue = CInt("&H" & Hex(Form1.DataTeams(i)(75)) & Hex(Form1.DataTeams(i)(74)))

        ComboKickOff.DataSource = DataLineup
        ComboKickOff.BindingContext = New BindingContext()
        ComboKickOff.DisplayMember = "PlayerName"
        ComboKickOff.ValueMember = "PlayerAddress"
        ComboKickOff.SelectedValue = CInt("&H" & Hex(Form1.DataTeams(i)(77)) & Hex(Form1.DataTeams(i)(76)))

        DataViewPlayers2.RowFilter = "Address1 <> 0 and Address2 <> 0"

    End Sub
    Private Sub ButtonRemovePlayer_Click(sender As Object, e As EventArgs) Handles ButtonRemovePlayer.Click
        If ListBox1.SelectedIndex > -1 Then
            DataLineup.Rows.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub ButtonAddPlayer_Click(sender As Object, e As EventArgs) Handles ButtonAddPlayer.Click
        If ListBox1.Items.Count < 30 And ListBox2.SelectedIndex > -1 Then
            DataLineup.Rows.Add()
            DataLineup.Rows(DataLineup.Rows.Count - 1)(1) = (ListBox2.SelectedValue)
            For j = 0 To Form1.DataPlayers.Rows.Count - 1
                If Form1.DataPlayers(j)("PlayerAddress") = DataLineup.Rows(DataLineup.Rows.Count - 1)(1) Then
                    DataLineup.Rows(DataLineup.Rows.Count - 1)(2) = Form1.DataPlayers(j)("PlayerName")
                End If
            Next
            DataLineup.Rows(DataLineup.Rows.Count - 1)(0) = (ListBox1.SelectedIndex)
            ListBox2.SelectedIndex = -1
            ListBox1.SelectedIndex = DataLineup.Rows.Count - 1
        End If
    End Sub

    Private Sub ButtonMoveUp_Click(sender As Object, e As EventArgs) Handles ButtonMoveUp.Click
        If ListBox1.SelectedIndex > 0 Then
            ListBox1.BeginUpdate()
            ComboCaptain.BeginUpdate()
            ComboVice.BeginUpdate()
            ComboLongGoal.BeginUpdate()
            ComboShortGoal.BeginUpdate()
            ComboLongPunt.BeginUpdate()
            ComboShortPunt.BeginUpdate()
            ComboKickOff.BeginUpdate()
            j = ListBox1.SelectedIndex
            MoveMem1 = ComboCaptain.SelectedValue
            MoveMem2 = ComboVice.SelectedValue
            MoveMem3 = ComboLongGoal.SelectedValue
            MoveMem4 = ComboShortGoal.SelectedValue
            MoveMem5 = ComboLongPunt.SelectedValue
            MoveMem6 = ComboShortPunt.SelectedValue
            MoveMem7 = ComboKickOff.SelectedValue
            Dim aaa(2) As String
            Dim bbb As DataRow = DataLineup.Rows(j)
            aaa(0) = DataLineup(ListBox1.SelectedIndex)(0)
            aaa(1) = DataLineup(ListBox1.SelectedIndex)(1)
            aaa(2) = DataLineup(ListBox1.SelectedIndex)(2)
            DataLineup.Rows.RemoveAt(j)
            DataLineup.Rows.InsertAt(bbb, j - 1)
            DataLineup.Rows(j - 1)(0) = aaa(0)
            DataLineup.Rows(j - 1)(1) = aaa(1)
            DataLineup.Rows(j - 1)(2) = aaa(2)
            ListBox1.SelectedIndex = j - 1
            If MoveMem1 = ListBox1.SelectedValue Then ComboCaptain.SelectedValue = ListBox1.SelectedValue
            If MoveMem2 = ListBox1.SelectedValue Then ComboVice.SelectedValue = ListBox1.SelectedValue
            If MoveMem3 = ListBox1.SelectedValue Then ComboLongGoal.SelectedValue = ListBox1.SelectedValue
            If MoveMem4 = ListBox1.SelectedValue Then ComboShortGoal.SelectedValue = ListBox1.SelectedValue
            If MoveMem5 = ListBox1.SelectedValue Then ComboLongPunt.SelectedValue = ListBox1.SelectedValue
            If MoveMem6 = ListBox1.SelectedValue Then ComboShortPunt.SelectedValue = ListBox1.SelectedValue
            If MoveMem7 = ListBox1.SelectedValue Then ComboKickOff.SelectedValue = ListBox1.SelectedValue
            ListBox1.EndUpdate()
            ComboCaptain.EndUpdate()
            ComboVice.EndUpdate()
            ComboLongGoal.EndUpdate()
            ComboShortGoal.EndUpdate()
            ComboLongPunt.EndUpdate()
            ComboShortPunt.EndUpdate()
            ComboKickOff.EndUpdate()
        End If
    End Sub

    Private Sub ButtonMoveDown_Click(sender As Object, e As EventArgs) Handles ButtonMoveDown.Click
        If ListBox1.SelectedIndex > -1 And ListBox1.SelectedIndex < 29 And ListBox1.SelectedIndex < DataLineup.Rows.Count - 1 Then
            'ListBox1.BeginUpdate()
            ComboCaptain.BeginUpdate()
            ComboVice.BeginUpdate()
            ComboLongPunt.BeginUpdate()
            ComboShortPunt.BeginUpdate()
            ComboLongGoal.BeginUpdate()
            ComboShortGoal.BeginUpdate()
            ComboKickOff.BeginUpdate()
            MoveMem1 = ComboCaptain.SelectedValue
            MoveMem2 = ComboVice.SelectedValue
            MoveMem3 = ComboLongGoal.SelectedValue
            MoveMem4 = ComboShortGoal.SelectedValue
            MoveMem5 = ComboLongPunt.SelectedValue
            MoveMem6 = ComboShortPunt.SelectedValue
            MoveMem7 = ComboKickOff.SelectedValue
            Dim aaa(2) As String
            Dim bbb As DataRow = DataLineup.Rows(ListBox1.SelectedIndex)
            aaa(0) = DataLineup(ListBox1.SelectedIndex)(0)
            aaa(1) = DataLineup(ListBox1.SelectedIndex)(1)
            aaa(2) = DataLineup(ListBox1.SelectedIndex)(2)
            DataLineup.Rows.RemoveAt(ListBox1.SelectedIndex)
            DataLineup.Rows.InsertAt(bbb, ListBox1.SelectedIndex + 1)
            DataLineup.Rows(ListBox1.SelectedIndex + 1)(0) = aaa(0)
            DataLineup.Rows(ListBox1.SelectedIndex + 1)(1) = aaa(1)
            DataLineup.Rows(ListBox1.SelectedIndex + 1)(2) = aaa(2)
            ListBox1.SelectedIndex += 1
            If MoveMem1 = ListBox1.SelectedValue Then ComboCaptain.SelectedValue = ListBox1.SelectedValue
            If MoveMem2 = ListBox1.SelectedValue Then ComboVice.SelectedValue = ListBox1.SelectedValue
            If MoveMem3 = ListBox1.SelectedValue Then ComboLongGoal.SelectedValue = ListBox1.SelectedValue
            If MoveMem4 = ListBox1.SelectedValue Then ComboShortGoal.SelectedValue = ListBox1.SelectedValue
            If MoveMem5 = ListBox1.SelectedValue Then ComboLongPunt.SelectedValue = ListBox1.SelectedValue
            If MoveMem6 = ListBox1.SelectedValue Then ComboShortPunt.SelectedValue = ListBox1.SelectedValue
            If MoveMem7 = ListBox1.SelectedValue Then ComboKickOff.SelectedValue = ListBox1.SelectedValue
            'ListBox1.EndUpdate()
            ComboCaptain.EndUpdate()
            ComboVice.EndUpdate()
            ComboLongPunt.EndUpdate()
            ComboShortPunt.EndUpdate()
            ComboLongGoal.EndUpdate()
            ComboShortGoal.EndUpdate()
            ComboKickOff.EndUpdate()
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        'save new player lineup
        For j = 0 To 29
            Form1.DataTeams(i)(j * 2) = CInt("&H" & Mid(Strings.Right("0000" & Hex(DataLineup(j)(1)), 4), 3, 2))
            Form1.DataTeams(i)((j * 2) + 1) = CInt("&H" & Mid(Strings.Right("0000" & Hex(DataLineup(j)(1)), 4), 1, 2))
        Next

        'save captain and kicker addresses
        Form1.DataTeams(i)(64) = CInt("&H" & Mid(Strings.Right("0" & Hex(ComboCaptain.SelectedValue), 4), 3, 2))
        Form1.DataTeams(i)(65) = CInt("&H" & Mid(Strings.Right("0" & Hex(ComboCaptain.SelectedValue), 4), 1, 2))
        Form1.DataTeams(i)(66) = CInt("&H" & Mid(Strings.Right("0" & Hex(ComboVice.SelectedValue), 4), 3, 2))
        Form1.DataTeams(i)(67) = CInt("&H" & Mid(Strings.Right("0" & Hex(ComboVice.SelectedValue), 4), 1, 2))
        Form1.DataTeams(i)(68) = CInt("&H" & Mid(Strings.Right("0" & Hex(ComboLongGoal.SelectedValue), 4), 3, 2))
        Form1.DataTeams(i)(69) = CInt("&H" & Mid(Strings.Right("0" & Hex(ComboLongGoal.SelectedValue), 4), 1, 2))
        Form1.DataTeams(i)(70) = CInt("&H" & Mid(Strings.Right("0" & Hex(ComboShortGoal.SelectedValue), 4), 3, 2))
        Form1.DataTeams(i)(71) = CInt("&H" & Mid(Strings.Right("0" & Hex(ComboShortGoal.SelectedValue), 4), 1, 2))
        Form1.DataTeams(i)(72) = CInt("&H" & Mid(Strings.Right("0" & Hex(ComboLongPunt.SelectedValue), 4), 3, 2))
        Form1.DataTeams(i)(73) = CInt("&H" & Mid(Strings.Right("0" & Hex(ComboLongPunt.SelectedValue), 4), 1, 2))
        Form1.DataTeams(i)(74) = CInt("&H" & Mid(Strings.Right("0" & Hex(ComboShortPunt.SelectedValue), 4), 3, 2))
        Form1.DataTeams(i)(75) = CInt("&H" & Mid(Strings.Right("0" & Hex(ComboShortPunt.SelectedValue), 4), 1, 2))
        Form1.DataTeams(i)(76) = CInt("&H" & Mid(Strings.Right("0" & Hex(ComboKickOff.SelectedValue), 4), 3, 2))
        Form1.DataTeams(i)(77) = CInt("&H" & Mid(Strings.Right("0" & Hex(ComboKickOff.SelectedValue), 4), 1, 2))

        'save stats
        Form1.DataTeams(i)(78) = TextAttack.Text
        Form1.DataTeams(i)(79) = TextDefend.Text
        Form1.DataTeams(i)(80) = TextScrum.Text
        Form1.DataTeams(i)(81) = TextLineout.Text
        Form1.DataTeams(i)(82) = TextLoose.Text
        Form1.DataTeams(i)(83) = TextKick.Text
        Form1.DataTeams(i)(84) = TextTechnique.Text
        Form1.DataTeams(i)(85) = TextStamina.Text
        Form1.DataTeams(i)(86) = TextFlair.Text
        Form1.DataTeams(i)(87) = TextOverall.Text
        Form1.DataTeams(i)(91) = NumericPerformance.Value
        Form1.DataTeams(i)(92) = ComboSetLeft.SelectedIndex
        Form1.DataTeams(i)(93) = ComboSetUp.SelectedIndex
        Form1.DataTeams(i)(94) = ComboSetRight.SelectedIndex
        Form1.DataTeams(i)(95) = ComboSetDown.SelectedIndex

        'save stadium
        Form1.DataTeams(i)(96) = ComboStadium.SelectedValue


        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'make sure only 1 list is selected
        If ListBox1.SelectedIndex <> -1 Then
            ListBox2.SelectedIndex = -1
        End If
        'PlayerInfo()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedIndex <> -1 Then
            ListBox1.SelectedIndex = -1
        End If
        'PlayerInfo()
    End Sub


    Private Sub Textbox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNameFilter.TextChanged
        'filter the player list by name
        NameFilter = " And PlayerName Like '%" & TextBoxNameFilter.Text & "%'"
        PlayerFilter()
    End Sub

    Private Sub Nationality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboNationality.SelectedIndexChanged
        'data to filter the player list by nationality
        NatVal(0) = 0 : NatVal(1) = 0 : NatVal(2) = 0
        If ComboNationality.SelectedIndex > 0 And ComboNationality.SelectedIndex < 9 Then NatVal(0) = 2 ^ (ComboNationality.SelectedIndex - 1)
        If ComboNationality.SelectedIndex > 8 And ComboNationality.SelectedIndex < 17 Then NatVal(1) = 2 ^ (ComboNationality.SelectedIndex - 9)
        If ComboNationality.SelectedIndex > 16 Then NatVal(2) = 2 ^ (ComboNationality.SelectedIndex - 17)
        If ComboNationality.SelectedIndex = 0 Then
            NatFilter = ""
        Else NatFilter = " and Nationality1 = " & NatVal(0) & " and Nationality2 = " & NatVal(1) & " and Nationality3 = " & NatVal(2)
        End If
        PlayerFilter()
    End Sub

    Private Sub Position_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPosition.SelectedIndexChanged
        'data to filter the player list by position
        PosVal = ComboPosition.SelectedIndex
        PosFilter = " and (Position1 in (" & PosVal & ", " & PosVal + 16 & ", " & PosVal + 32 & ", " & PosVal + 48 & ", " & PosVal + 64 & ", " & PosVal + 80 & ", " & PosVal + 96 & ", " & PosVal + 112 & ", " & PosVal + 128 & ", " & PosVal + 144 & ", " & PosVal + 160 & ", " & PosVal + 176 & ", " & PosVal + 192 & ", " _
            & 16 * PosVal + 1 & ", " & 16 * PosVal + 2 & ", " & 16 * PosVal + 3 & ", " & 16 * PosVal + 4 & ", " & 16 * PosVal + 5 & ", " & 16 * PosVal + 6 & ", " & 16 * PosVal + 7 & ", " & 16 * PosVal + 8 & ", " & 16 * PosVal + 9 & ", " & 16 * PosVal + 10 & ", " & 16 * PosVal + 11 & ", " & 16 * PosVal + 12 _
        & ") or Position2 in (" & PosVal & "))"

        If ComboPosition.SelectedIndex = 0 Then
            PosFilter = ""
        End If
        PlayerFilter()
    End Sub

    Function PlayerFilter()
        'combine all the player filters and apply them
        FilterString = "(Address1 <> 0 or Address2 <> 0) " & NatFilter & NameFilter & PosFilter
        DataViewPlayers2.RowFilter = FilterString
        Return 0
    End Function

    Function PlayerInfo()
        'when a player is selected in the player or lineup lists, display some information about them in the labels
        For j = 0 To Form1.DataPlayers.Rows.Count - 1
            If Form1.DataPlayers(j)("PlayerAddress") = PlayerInfoVar Then
                LabelName.Text = Form1.DataPlayers(j)("playername")

                Dim PositionArray = New String() {"0001", "0010", "0011", "0100", "0101", "0110",
                "0111", "1000", "1001", "1010", "1011", "1100", "0000"}
                Dim PositionNames = New String() {"Prop 1", "Hooker", "Prop 3", "Lock", "Flanker 6",
                    "Flanker 7", "Number 8", "Scrum Half", "Fly Half", "Winger", "Centre", "Full Back", ""}
                Dim Position1var As String = Strings.Right("0000000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(j)(20)), 2), 4)
                Dim Position2var As String = Strings.Left(Strings.Right("0000000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(j)(20)), 2), 8), 4)
                Dim Position3var As String = Strings.Right("0000000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(j)(21)), 2), 4)
                For k = 0 To 11
                    If PositionArray(k) = Position1var Then LabelPosition.Text = PositionNames(k)
                Next
                For k = 0 To 11
                    If PositionArray(k) = Position2var Then LabelPosition.Text &= vbCrLf & PositionNames(k)
                Next
                For k = 0 To 11
                    If PositionArray(k) = Position3var Then LabelPosition.Text &= vbCrLf & PositionNames(k)
                Next
                Dim NationalityArray = New String() {"100", "200", "400", "800", "1600", "3200", "6400", "12800",
                "010", "020", "040", "080", "0160", "0320", "0640", "01280",
                "001", "002", "004", "008", "0016", "0032", "0064", "00128", "000"}
                Dim NationalityNames = New String() {"Argentina", "Australia", "Canada", "UNDEFINED", "England", "Fiji", "France",
                "Georgia", "Ireland", "Italy", "Japan", "Namibia", "New Zealand", "Romania", "Russia", "Samoa", "Scotland", "South Africa",
                "Spain", "Tonga", "Chile", "Uruguay", "USA", "Wales", "Portugal"}
                Dim Nationalityvar = Form1.DataPlayers(j)(24) & Form1.DataPlayers(j)(25) & Form1.DataPlayers(j)(26)
                For k = 0 To 24
                    If NationalityArray(k) = Nationalityvar Then LabelNationality.Text = NationalityNames(k)
                Next
            End If
        Next
        Return 0
    End Function

    Private Sub ButtonRemoveAll_Click(sender As Object, e As EventArgs) Handles ButtonRemoveAll.Click
        If MsgBox("Are you sure you want to remove all players from this team?", 4, "Warning") = 6 Then
            DataLineup.Rows.Clear()
        End If
    End Sub

    Private Sub ListBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseClick
        If ListBox1.SelectedIndex > -1 Then
            PlayerInfoVar = ListBox1.SelectedValue
            PlayerInfo()
        End If
    End Sub

    Private Sub ListBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBox2.MouseClick
        If ListBox2.SelectedIndex > -1 Then
            PlayerInfoVar = ListBox2.SelectedValue
            PlayerInfo()
        End If
    End Sub
End Class
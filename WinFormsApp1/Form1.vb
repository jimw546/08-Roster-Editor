Imports System.IO
Imports System.Text
Public Class Form1
    Public PlayerIndex As Integer
    Public TeamIndex As Integer
    Public DataPlayers As New DataTable
    Public DataTeams As New DataTable
    Public DataTeamNames As New DataTable
    Public DataStadiums As New DataTable
    Dim import1 As OpenFileDialog = New OpenFileDialog
    Dim export1 As SaveFileDialog = New SaveFileDialog
    Dim FileStart(131) As Byte
    Public DataViewPlayers As New DataView(DataPlayers)
    Public DataViewTeams As New DataView(DataTeams)
    Dim NatVal(2) As String
    Dim PosVal As String
    Dim FilterString As String
    Dim NatFilter As String
    Dim NameFilter As String
    Dim PosFilter As String
    Dim EnabledFilter As String
    Dim TeamNameFilter As String
    Dim TournamentFilter As String
    Dim i As Integer
    Dim j As Integer
    Dim fs As FileStream

    Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click

        'initialises all the table columns
        ListBoxPlayers.BeginUpdate()
        ListBoxTeams.BeginUpdate()
        If DataTeams.Columns.IndexOf("Player1-1") = -1 Then
            'For i = 1 To 11
            '    DataTeamNames.Columns.Add()
            'Next
            'For i = 0 To 2
            '    DataStadiums.Columns.Add("", GetType(String))
            '    DataStadiums.Columns.Add("", GetType(Integer))
            '    DataStadiums.Columns.Add("", GetType(String))
            'Next

            DataPlayers.Columns.Add("Address1", GetType(Integer))
            DataPlayers.Columns.Add("Address2", GetType(Integer))
            DataPlayers.Columns.Add("Commentary1", GetType(Integer))
            DataPlayers.Columns.Add("Commentary2", GetType(Integer))
            DataPlayers.Columns.Add("Name1", GetType(Integer))
            DataPlayers.Columns.Add("Name2", GetType(Integer))
            DataPlayers.Columns.Add("Name3", GetType(Integer))
            DataPlayers.Columns.Add("Name4", GetType(Integer))
            DataPlayers.Columns.Add("Name5", GetType(Integer))
            DataPlayers.Columns.Add("Name6", GetType(Integer))
            DataPlayers.Columns.Add("Name7", GetType(Integer))
            DataPlayers.Columns.Add("Name8", GetType(Integer))
            DataPlayers.Columns.Add("Name9", GetType(Integer))
            DataPlayers.Columns.Add("Name10", GetType(Integer))
            DataPlayers.Columns.Add("Name11", GetType(Integer))
            DataPlayers.Columns.Add("Name12", GetType(Integer))
            DataPlayers.Columns.Add("Name13", GetType(Integer))
            DataPlayers.Columns.Add("Name14", GetType(Integer))
            DataPlayers.Columns.Add("Name15", GetType(Integer))
            DataPlayers.Columns.Add("Name16", GetType(Integer))
            DataPlayers.Columns.Add("Position1", GetType(Integer))
            DataPlayers.Columns.Add("Position2", GetType(Integer))
            DataPlayers.Columns.Add("Weight", GetType(Integer))
            DataPlayers.Columns.Add("Column23", GetType(Integer))
            DataPlayers.Columns.Add("Nationality1", GetType(Integer))
            DataPlayers.Columns.Add("Nationality2", GetType(Integer))
            DataPlayers.Columns.Add("Nationality3", GetType(Integer))
            DataPlayers.Columns.Add("Column27", GetType(Integer))
            DataPlayers.Columns.Add("Height", GetType(Integer))
            DataPlayers.Columns.Add("Age", GetType(Integer))
            DataPlayers.Columns.Add("Column30", GetType(Integer))
            DataPlayers.Columns.Add("LeftRightHand", GetType(Integer))
            DataPlayers.Columns.Add("Tend", GetType(Integer))
            DataPlayers.Columns.Add("Attack", GetType(Integer))
            DataPlayers.Columns.Add("Defend", GetType(Integer))
            DataPlayers.Columns.Add("Speed", GetType(Integer))
            DataPlayers.Columns.Add("Accel", GetType(Integer))
            DataPlayers.Columns.Add("Agil", GetType(Integer))
            DataPlayers.Columns.Add("Handl", GetType(Integer))
            DataPlayers.Columns.Add("Pass", GetType(Integer))
            DataPlayers.Columns.Add("Kick", GetType(Integer))
            DataPlayers.Columns.Add("KickPwr", GetType(Integer))
            DataPlayers.Columns.Add("Goal", GetType(Integer))
            DataPlayers.Columns.Add("Tackle", GetType(Integer))
            DataPlayers.Columns.Add("Strength", GetType(Integer))
            DataPlayers.Columns.Add("Ruck", GetType(Integer))
            DataPlayers.Columns.Add("Scrum", GetType(Integer))
            DataPlayers.Columns.Add("Hook", GetType(Integer))
            DataPlayers.Columns.Add("Lineout", GetType(Integer))
            DataPlayers.Columns.Add("Discip", GetType(Integer))
            DataPlayers.Columns.Add("Aggro", GetType(Integer))
            DataPlayers.Columns.Add("Stamina", GetType(Integer))
            DataPlayers.Columns.Add("Column52", GetType(Integer))
            DataPlayers.Columns.Add("Column53", GetType(Integer))
            DataPlayers.Columns.Add("Column54", GetType(Integer))
            DataPlayers.Columns.Add("Cons", GetType(Integer))
            DataPlayers.Columns.Add("Temp", GetType(Integer))
            DataPlayers.Columns.Add("Creat", GetType(Integer))
            DataPlayers.Columns.Add("Brave", GetType(Integer))
            DataPlayers.Columns.Add("Set", GetType(Integer))
            DataPlayers.Columns.Add("Crash", GetType(Integer))
            DataPlayers.Columns.Add("Gap", GetType(Integer))
            DataPlayers.Columns.Add("Column62", GetType(Integer))
            DataPlayers.Columns.Add("Column63", GetType(Integer))
            DataPlayers.Columns.Add("Column64", GetType(Integer))
            DataPlayers.Columns.Add("Column65", GetType(Integer))
            DataPlayers.Columns.Add("Column66", GetType(Integer))
            DataPlayers.Columns.Add("Column67", GetType(Integer))
            DataPlayers.Columns.Add("Column68", GetType(Integer))
            DataPlayers.Columns.Add("Column69", GetType(Integer))
            DataPlayers.Columns.Add("Column70", GetType(Integer))
            DataPlayers.Columns.Add("Column71", GetType(Integer))
            DataPlayers.Columns.Add("Column72", GetType(Integer))
            DataPlayers.Columns.Add("Column73", GetType(Integer))
            DataPlayers.Columns.Add("Column74", GetType(Integer))
            DataPlayers.Columns.Add("Column75", GetType(Integer))
            DataPlayers.Columns.Add("Column76", GetType(Integer))
            DataPlayers.Columns.Add("Column77", GetType(Integer))
            DataPlayers.Columns.Add("Column78", GetType(Integer))
            DataPlayers.Columns.Add("Column79", GetType(Integer))
            DataPlayers.Columns.Add("Column80", GetType(Integer))
            DataPlayers.Columns.Add("Column81", GetType(Integer))
            DataPlayers.Columns.Add("Column82", GetType(Integer))
            DataPlayers.Columns.Add("Column83", GetType(Integer))
            DataPlayers.Columns.Add("Perks1", GetType(Integer))
            DataPlayers.Columns.Add("Perks2", GetType(Integer))
            DataPlayers.Columns.Add("Column86", GetType(Integer))
            DataPlayers.Columns.Add("Column87", GetType(Integer))
            DataPlayers.Columns.Add("Boots", GetType(Integer))
            DataPlayers.Columns.Add("SockandFinger", GetType(Integer))
            DataPlayers.Columns.Add("Face1", GetType(Integer))
            DataPlayers.Columns.Add("Face2", GetType(Integer))
            DataPlayers.Columns.Add("Extra", GetType(Integer))
            DataPlayers.Columns.Add("WristCreateSkin", GetType(Integer))
            DataPlayers.Columns.Add("ThighGlove", GetType(Integer))
            DataPlayers.Columns.Add("Column95", GetType(Integer))
            DataPlayers.Columns.Add("Column96", GetType(Integer))
            DataPlayers.Columns.Add("Column97", GetType(Integer))
            DataPlayers.Columns.Add("Column98", GetType(Integer))
            DataPlayers.Columns.Add("Column99", GetType(Integer))

            DataTeams.Columns.Add("Player1-1", GetType(Integer))
            DataTeams.Columns.Add("Player1-2", GetType(Integer))
            DataTeams.Columns.Add("Player2-1", GetType(Integer))
            DataTeams.Columns.Add("Player2-2", GetType(Integer))
            DataTeams.Columns.Add("Player3-1", GetType(Integer))
            DataTeams.Columns.Add("Player3-2", GetType(Integer))
            DataTeams.Columns.Add("Player4-1", GetType(Integer))
            DataTeams.Columns.Add("Player4-2", GetType(Integer))
            DataTeams.Columns.Add("Player5-1", GetType(Integer))
            DataTeams.Columns.Add("Player5-2", GetType(Integer))
            DataTeams.Columns.Add("Player6-1", GetType(Integer))
            DataTeams.Columns.Add("Player6-2", GetType(Integer))
            DataTeams.Columns.Add("Player7-1", GetType(Integer))
            DataTeams.Columns.Add("Player7-2", GetType(Integer))
            DataTeams.Columns.Add("Player8-1", GetType(Integer))
            DataTeams.Columns.Add("Player8-2", GetType(Integer))
            DataTeams.Columns.Add("Player9-1", GetType(Integer))
            DataTeams.Columns.Add("Player9-2", GetType(Integer))
            DataTeams.Columns.Add("Player10-1", GetType(Integer))
            DataTeams.Columns.Add("Player10-2", GetType(Integer))
            DataTeams.Columns.Add("Player11-1", GetType(Integer))
            DataTeams.Columns.Add("Player11-2", GetType(Integer))
            DataTeams.Columns.Add("Player12-1", GetType(Integer))
            DataTeams.Columns.Add("Player12-2", GetType(Integer))
            DataTeams.Columns.Add("Player13-1", GetType(Integer))
            DataTeams.Columns.Add("Player13-2", GetType(Integer))
            DataTeams.Columns.Add("Player14-1", GetType(Integer))
            DataTeams.Columns.Add("Player14-2", GetType(Integer))
            DataTeams.Columns.Add("Player15-1", GetType(Integer))
            DataTeams.Columns.Add("Player15-2", GetType(Integer))
            DataTeams.Columns.Add("Player16-1", GetType(Integer))
            DataTeams.Columns.Add("Player16-2", GetType(Integer))
            DataTeams.Columns.Add("Player17-1", GetType(Integer))
            DataTeams.Columns.Add("Player17-2", GetType(Integer))
            DataTeams.Columns.Add("Player18-1", GetType(Integer))
            DataTeams.Columns.Add("Player18-2", GetType(Integer))
            DataTeams.Columns.Add("Player19-1", GetType(Integer))
            DataTeams.Columns.Add("Player19-2", GetType(Integer))
            DataTeams.Columns.Add("Player20-1", GetType(Integer))
            DataTeams.Columns.Add("Player20-2", GetType(Integer))
            DataTeams.Columns.Add("Player21-1", GetType(Integer))
            DataTeams.Columns.Add("Player21-2", GetType(Integer))
            DataTeams.Columns.Add("Player22-1", GetType(Integer))
            DataTeams.Columns.Add("Player22-2", GetType(Integer))
            DataTeams.Columns.Add("Player23-1", GetType(Integer))
            DataTeams.Columns.Add("Player23-2", GetType(Integer))
            DataTeams.Columns.Add("Player24-1", GetType(Integer))
            DataTeams.Columns.Add("Player24-2", GetType(Integer))
            DataTeams.Columns.Add("Player25-1", GetType(Integer))
            DataTeams.Columns.Add("Player25-2", GetType(Integer))
            DataTeams.Columns.Add("Player26-1", GetType(Integer))
            DataTeams.Columns.Add("Player26-2", GetType(Integer))
            DataTeams.Columns.Add("Player27-1", GetType(Integer))
            DataTeams.Columns.Add("Player27-2", GetType(Integer))
            DataTeams.Columns.Add("Player28-1", GetType(Integer))
            DataTeams.Columns.Add("Player28-2", GetType(Integer))
            DataTeams.Columns.Add("Player29-1", GetType(Integer))
            DataTeams.Columns.Add("Player29-2", GetType(Integer))
            DataTeams.Columns.Add("Player30-1", GetType(Integer))
            DataTeams.Columns.Add("Player30-2", GetType(Integer))
            DataTeams.Columns.Add("Index", GetType(Integer))
            DataTeams.Columns.Add("Col62", GetType(Integer))
            DataTeams.Columns.Add("Col63", GetType(Integer))
            DataTeams.Columns.Add("Col64", GetType(Integer))
            DataTeams.Columns.Add("Captain1", GetType(Integer))
            DataTeams.Columns.Add("Captain2", GetType(Integer))
            DataTeams.Columns.Add("ViceCap1", GetType(Integer))
            DataTeams.Columns.Add("ViceCap2", GetType(Integer))
            DataTeams.Columns.Add("LongGoal1", GetType(Integer))
            DataTeams.Columns.Add("LongGoal2", GetType(Integer))
            DataTeams.Columns.Add("ShortGoal1", GetType(Integer))
            DataTeams.Columns.Add("ShortGoal2", GetType(Integer))
            DataTeams.Columns.Add("LongPunt1", GetType(Integer))
            DataTeams.Columns.Add("LongPunt2", GetType(Integer))
            DataTeams.Columns.Add("ShortPunt1", GetType(Integer))
            DataTeams.Columns.Add("ShortPunt2", GetType(Integer))
            DataTeams.Columns.Add("KickOff1", GetType(Integer))
            DataTeams.Columns.Add("KickOff2", GetType(Integer))
            DataTeams.Columns.Add("Attack", GetType(Integer))
            DataTeams.Columns.Add("Defend", GetType(Integer))
            DataTeams.Columns.Add("Scrum", GetType(Integer))
            DataTeams.Columns.Add("Lineout", GetType(Integer))
            DataTeams.Columns.Add("Loose", GetType(Integer))
            DataTeams.Columns.Add("Kicking", GetType(Integer))
            DataTeams.Columns.Add("Technique", GetType(Integer))
            DataTeams.Columns.Add("Stamina", GetType(Integer))
            DataTeams.Columns.Add("Flair", GetType(Integer))
            DataTeams.Columns.Add("Overall", GetType(Integer))
            DataTeams.Columns.Add("Column89", GetType(Integer))
            DataTeams.Columns.Add("Column90", GetType(Integer))
            DataTeams.Columns.Add("Column91", GetType(Integer))
            DataTeams.Columns.Add("Performance", GetType(Integer))
            DataTeams.Columns.Add("SetPlayLeft", GetType(Integer))
            DataTeams.Columns.Add("SetPlayUp", GetType(Integer))
            DataTeams.Columns.Add("SetPlayRight", GetType(Integer))
            DataTeams.Columns.Add("SetPlayDown", GetType(Integer))
            DataTeams.Columns.Add("HomeStadium", GetType(Integer))
            DataTeams.Columns.Add("Column98", GetType(Integer))
            DataTeams.Columns.Add("Column99", GetType(Integer))
            DataTeams.Columns.Add("Column100", GetType(Integer))
            DataTeams.Columns.Add("Column101", GetType(Integer))
            DataTeams.Columns.Add("Column102", GetType(Integer))
            DataTeams.Columns.Add("Column103", GetType(Integer))
            DataTeams.Columns.Add("Column104", GetType(Integer))

            DataPlayers.Columns.Add("PlayerName")
            DataPlayers.Columns.Add("PlayerAddress", GetType(Integer))
            DataPlayers.Columns.Add("PlayerIndex", GetType(Integer))
            DataTeams.Columns.Add("TeamName")
            DataTeams.Columns.Add("Enabled")
            DataTeams.Columns.Add("TeamIndex")
            DataTeams.Columns.Add("FeGroup")
            DataTeams.Columns.Add("HomeStadiumName")
        Else
            DataPlayers.Clear()
            DataTeams.Clear()
            'DataStadiums.Clear()
            'DataTeamNames.Clear()
        End If

        Dim xFile1 As String = IO.Path.GetFullPath("be2970b0ada8e42cf891ce60ffe69575.xml")
        Dim dt As New DataSet
        dt.ReadXml(xFile1)
        DataTeamNames = dt.Tables(2)

        Dim xFile2 As String = IO.Path.GetFullPath("119ba3f37fe7a31c2b2ee45ceeafa091.xml")
        Dim dt2 As New DataSet
        dt2.ReadXml(xFile2)
        DataStadiums = dt2.Tables(2)

        import1.ShowDialog()
        Using Reader As BinaryReader = New BinaryReader(File.Open(import1.FileName, FileMode.Open))
            For i = 0 To 131
                FileStart(i) = Reader.ReadByte 'dump the first 132 bytes into a holding array
            Next

            For i = 0 To 141
                DataTeams.Rows.Add()
                For j = 0 To 103
                    DataTeams.Rows(i)(j) = Reader.ReadByte
                Next
            Next
            'reader.ReadBytes(100) 'buffer data between roster and players
            For i = 0 To 2042 '1904 '1904 to check a created player from in-game, should be 1903 '1904 rows, I think this is the max in the file
                DataPlayers.Rows.Add()
                For j = 0 To 99
                    Try
                        DataPlayers.Rows(i)(j) = Reader.ReadByte
                        Exit Try
                    Catch ex As EndOfStreamException
                        i = 3001
                        j = 100
                    Finally
                    End Try
                Next
            Next
        End Using

        ''this deletes unused lines from player data:
        'For i = DataPlayers.Rows.Count - 1 To 0 Step -1
        '    If DataPlayers.Rows(i)("Column1") = 0 And DataPlayers.Rows(i)("Column2") = 0 Then
        '        DataPlayers.Rows(i).Delete()
        '    End If
        'Next
        'DataPlayers.AcceptChanges()


        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        For i = 0 To DataPlayers.Rows.Count - 1
            DataPlayers.Rows(i)("PlayerName") = Chr(DataPlayers.Rows(i)(4)) & Chr(DataPlayers.Rows(i)(5)) _
            & Chr(DataPlayers.Rows(i)(6)) & Chr(DataPlayers.Rows(i)(7)) _
            & Chr(DataPlayers.Rows(i)(8)) & Chr(DataPlayers.Rows(i)(9)) _
            & Chr(DataPlayers.Rows(i)(10)) & Chr(DataPlayers.Rows(i)(11)) _
            & Chr(DataPlayers.Rows(i)(12)) & Chr(DataPlayers.Rows(i)(13)) _
            & Chr(DataPlayers.Rows(i)(14)) & Chr(DataPlayers.Rows(i)(15)) _
            & Chr(DataPlayers.Rows(i)(16)) & Chr(DataPlayers.Rows(i)(17)) _
            & Chr(DataPlayers.Rows(i)(18)) & Chr(DataPlayers.Rows(i)(19))
            DataPlayers.Rows(i)("PlayerIndex") = i
            DataPlayers(i)("PlayerAddress") = CInt("&H" & Hex(DataPlayers(i)(1)) &
            Strings.Right("00" & Hex(DataPlayers(i)(0)).ToString, 2))
        Next

        'add the team name to the data from the be29 file
        For i = 0 To DataTeams.Rows.Count - 1
            If DataTeams(i)(60).ToString <> "" Then
                For j = 0 To DataTeamNames.Rows.Count - 1
                    If DataTeamNames(j)(0).ToString <> "" Then
                        If DataTeams(i)(60) > 0 And DataTeamNames(j)(0) > 0 And DataTeams(i)(60) = DataTeamNames(j)(0) Then
                            DataTeams(i)("TeamName") = DataTeamNames(j)(6)
                            DataTeams(i)("Enabled") = DataTeamNames(j)(1)
                            DataTeams(i)("FeGroup") = DataTeamNames(j)(4)
                            DataTeams(i)("TeamIndex") = i
                        End If
                    End If
                Next
                For j = 0 To DataStadiums.Rows.Count - 1
                    If DataTeams(i)(96) = DataStadiums(j)(1) Then
                        DataTeams(i)("HomeStadiumName") = DataStadiums(j)(4)
                    End If
                Next
            End If
        Next

        DataViewPlayers.Sort = "PlayerName" 'sort the player list alphabetically
        ListBoxPlayers.DataSource = DataViewPlayers
        ListBoxPlayers.DisplayMember = "PlayerName"
        ListBoxPlayers.ValueMember = "PlayerIndex"
        PlayerFilter()

        ListBoxTeams.DataSource = DataViewTeams
        ListBoxTeams.DisplayMember = "TeamName"
        ListBoxTeams.ValueMember = "TeamIndex"
        TeamFilter()

        ListBoxPlayers.SelectedIndex = 0
        ListBoxTeams.SelectedIndex = 0
        ListBoxTeams.EndUpdate()
        ListBoxPlayers.EndUpdate()
    End Sub

    Private Sub ListBoxPlayers_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxPlayers.MouseDoubleClick
        FormPlayer.Close()
        PlayerIndex = ListBoxPlayers.SelectedValue
        FormPlayer.PlayerIndex = PlayerIndex
        FormPlayer.Show()
    End Sub

    Private Sub ButtonPlayer_Click(sender As Object, e As EventArgs) Handles ButtonPlayer.Click
        If ListBoxPlayers.SelectedIndex > -1 Then
            FormPlayer.Close()
            PlayerIndex = ListBoxPlayers.SelectedValue
            FormPlayer.PlayerIndex = PlayerIndex
            FormPlayer.Show()
        End If
    End Sub

    Private Sub ListBoxTeams_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxTeams.MouseDoubleClick
        FormTeam.Close()
        TeamIndex = ListBoxTeams.SelectedValue
        FormTeam.TeamIndex = TeamIndex
        FormTeam.Show()
    End Sub

    Private Sub ButtonTeam_Click(sender As Object, e As EventArgs) Handles ButtonTeam.Click
        If ListBoxTeams.SelectedIndex > -1 Then
            FormTeam.Close()
            TeamIndex = ListBoxTeams.SelectedValue
            FormTeam.TeamIndex = TeamIndex
            FormTeam.Show()
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        export1.DefaultExt = ".ros"
        export1.FileName = ""
        export1.ShowDialog()
        If export1.FileName <> "" Then
            Using writer As BinaryWriter = New BinaryWriter(File.Open(export1.FileName, FileMode.Create))
                writer.Write(FileStart)
                For i = 0 To DataTeams.Rows.Count - 1
                    For j = 0 To 103
                        writer.Write(Byte.Parse(CInt(DataTeams(i)(j))))
                    Next
                Next
                For i = 0 To DataPlayers.Rows.Count - 1
                    For j = 0 To 99
                        If IsDBNull(DataPlayers(i)(j)) = True Then
                            writer.Write(0)
                        Else
                            writer.Write(Byte.Parse(CInt(DataPlayers(i)(j))))
                        End If
                    Next
                Next
                For i = 0 To ((2043 - DataPlayers.Rows.Count) * 25) + 4 ' add extra 0's total file size should be 219220
                    writer.Write(0)
                Next
            End Using
            MsgBox("File saved, file size " & FileLen(export1.FileName) & ", should be 219220", , "Saved")
        Else
            MsgBox("No file saved", , "Warning")
        End If
    End Sub

    Private Sub ButtonRDF_Click(sender As Object, e As EventArgs) Handles ButtonRDF.Click
        export1.DefaultExt = ".rdf"
        export1.FileName = "73cb47d1d69c90f28fd1cc4186ac1926"
        If export1.FileName <> "" And export1.ShowDialog = 1 Then
            fs = File.OpenWrite(export1.FileName)
            fs.SetLength(227592)
            fs.WriteByte(0) : fs.WriteByte(13) : fs.WriteByte(0) : fs.WriteByte(0)
            For i = 0 To DataPlayers.Rows.Count - 1
                For j = 0 To 99
                    If IsDBNull(DataPlayers(i)(j)) = True Then
                        fs.WriteByte(0)
                    Else
                        fs.WriteByte(DataPlayers(i)(j))
                    End If
                Next
            Next
            fs.Seek(200108, 0) 'go to this location and write the teams info
            For i = 0 To DataTeams.Rows.Count - 1
                For j = 0 To 90
                    fs.WriteByte(DataTeams(i)(j))
                Next
                fs.WriteByte(6 - DataTeams(i)(91)) 'inverts team ratings for WL
                For j = 92 To 103
                    fs.WriteByte(DataTeams(i)(j))
                Next
            Next
            'For i = 0 To 12715 '3178 ' add extra 0's total file size should be 227592
            '    fs.WriteByte(0)
            'Next
            fs.Close()
            MsgBox("File saved, file size " & FileLen(export1.FileName) & ", should be 227592", , "Saved")
        Else
            MsgBox("No file saved", , "Warning")
        End If
    End Sub

    Private Sub Textbox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNameFilter.TextChanged
        NameFilter = " and PlayerName Like '%" & TextBoxNameFilter.Text & "%'"
        PlayerFilter()
    End Sub

    Private Sub Nationality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboNationality.SelectedIndexChanged
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
        FilterString = "(Address1 <> 0 or Address2 <> 0) " & NatFilter & NameFilter & PosFilter
        DataViewPlayers.RowFilter = FilterString
        Return 0
    End Function

    Private Sub CheckEnabledTeam_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckEnabledTeam.CheckStateChanged
        If CheckEnabledTeam.Checked = True Then
            EnabledFilter = ""
        Else
            EnabledFilter = " and enabled = 'yes'"
        End If
        TeamFilter()
    End Sub

    Private Sub TextTeamName_TextChanged(sender As Object, e As EventArgs) Handles TextTeamName.TextChanged
        TeamNameFilter = " and TeamName Like '%" & TextTeamName.Text & "%'"
        TeamFilter()
    End Sub

    Private Sub ComboTournament_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTournament.SelectedIndexChanged
        If ComboTournament.SelectedIndex = 0 Then TournamentFilter = ""
        If ComboTournament.SelectedIndex = 1 Then TournamentFilter = " and FeGroup = 'International'"
        If ComboTournament.SelectedIndex = 2 Then TournamentFilter = " and FeGroup = 'super14'"
        If ComboTournament.SelectedIndex = 3 Then TournamentFilter = " and FeGroup = 'european'"
        If ComboTournament.SelectedIndex = 4 Then TournamentFilter = " and FeGroup = 'representative'"
        TeamFilter()
    End Sub

    Function TeamFilter()
        If CheckEnabledTeam.Checked = True Then
            EnabledFilter = ""
        Else
            EnabledFilter = " and enabled = 'yes'"
        End If
        DataViewTeams.RowFilter = "0 = 0" & EnabledFilter & TeamNameFilter & TournamentFilter
        Return 0
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormExtras.Show()
        FormExtras.BringToFront()
    End Sub
End Class


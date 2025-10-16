Imports System.Security.Cryptography
Imports System.Security.Policy
Imports System.Text

Public Class FormFileNames
    Dim DataViewTeamNames As New DataView(Form1.DataTeamNames)
    Dim EnabledFilter As String
    Dim TeamNameFilter As String
    Dim TournamentFilter As String
    Dim i As Integer

    Private Sub FormFileNames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = DataViewTeamNames

        If Form1.DataTeamNames.Columns.IndexOf("KitFrontHome") = -1 Then
            Form1.DataTeamNames.Columns.Add("KitFrontHome")
            Form1.DataTeamNames.Columns.Add("KitBackHome")
            Form1.DataTeamNames.Columns.Add("KitFrontAway")
            Form1.DataTeamNames.Columns.Add("KitBackAway")
            Form1.DataTeamNames.Columns.Add("MinikitL1")
            Form1.DataTeamNames.Columns.Add("MinikitL2")
            Form1.DataTeamNames.Columns.Add("MinikitR1")
            Form1.DataTeamNames.Columns.Add("MinikitR2")
            Form1.DataTeamNames.Columns.Add("MenuLogos")
            Form1.DataTeamNames.Columns.Add("MatchLogos")
            Form1.DataTeamNames.Columns.Add("Ball")
            Form1.DataTeamNames.Columns.Add("Flags")
            Form1.DataTeamNames.Columns.Add("KitFrontHomeRWC")
            Form1.DataTeamNames.Columns.Add("KitBackHomeRWC")
            Form1.DataTeamNames.Columns.Add("KitFrontAwayRWC")
            Form1.DataTeamNames.Columns.Add("KitBackAwayRWC")
            Form1.DataTeamNames.Columns.Add("MinikitL1RWC")
            Form1.DataTeamNames.Columns.Add("MinikitL2RWC")
            Form1.DataTeamNames.Columns.Add("MinikitR1RWC")
            Form1.DataTeamNames.Columns.Add("MinikitR2RWC")
        End If

        For i = 0 To 10
            DataGridView1.Columns(i).Visible = False
        Next

        DataGridView1.Columns("Index").Visible = True
        DataGridView1.Columns("TeamName").Visible = True
        DataGridView1.Columns("Logo").Visible = True

        For i = 0 To Form1.DataTeamNames.Rows.Count - 1
            Form1.DataTeamNames(i)("KitFrontHome") = GetHash("kit/kits/" & Form1.DataTeamNames(i)("Logo") & ".home")
            Form1.DataTeamNames(i)("KitBackHome") = GetHash("kit/kits/" & Form1.DataTeamNames(i)("Logo") & ".home.numbers")
            Form1.DataTeamNames(i)("KitFrontAway") = GetHash("kit/kits/" & Form1.DataTeamNames(i)("Logo") & ".away")
            Form1.DataTeamNames(i)("KitBackAway") = GetHash("kit/kits/" & Form1.DataTeamNames(i)("Logo") & ".away.numbers")
            Form1.DataTeamNames(i)("MinikitL1") = GetHash("frontend/textures/kitlogos/" & Form1.DataTeamNames(i)("Logo") & "_l1")
            Form1.DataTeamNames(i)("MinikitL2") = GetHash("frontend/textures/kitlogos/" & Form1.DataTeamNames(i)("Logo") & "_l2")
            Form1.DataTeamNames(i)("MinikitR1") = GetHash("frontend/textures/kitlogos/" & Form1.DataTeamNames(i)("Logo") & "_r1")
            Form1.DataTeamNames(i)("MinikitR2") = GetHash("frontend/textures/kitlogos/" & Form1.DataTeamNames(i)("Logo") & "_r2")
            Form1.DataTeamNames(i)("MenuLogos") = GetHash("frontend/textures/teams/team_" & Form1.DataTeamNames(i)("Logo"))
            Form1.DataTeamNames(i)("MatchLogos") = GetHash("frontend/textures/ig_teams/ig_" & Form1.DataTeamNames(i)("Logo"))
            Form1.DataTeamNames(i)("Ball") = GetHash("kit/teams/" & Form1.DataTeamNames(i)("Logo") & ".ball")
            Form1.DataTeamNames(i)("Flags") = GetHash("kit/teams/" & Form1.DataTeamNames(i)("Logo"))
            Form1.DataTeamNames(i)("KitFrontHomeRWC") = GetHash("kit/kits/" & Form1.DataTeamNames(i)("Logo") & "_wc.home")
            Form1.DataTeamNames(i)("KitBackHomeRWC") = GetHash("kit/kits/" & Form1.DataTeamNames(i)("Logo") & "_wc.home.numbers")
            Form1.DataTeamNames(i)("KitFrontAwayRWC") = GetHash("kit/kits/" & Form1.DataTeamNames(i)("Logo") & "_wc.away")
            Form1.DataTeamNames(i)("KitBackAwayRWC") = GetHash("kit/kits/" & Form1.DataTeamNames(i)("Logo") & "_wc.away.numbers")
            Form1.DataTeamNames(i)("MinikitL1RWC") = GetHash("frontend/textures/kitlogos/wc_" & Form1.DataTeamNames(i)("Logo") & "_l1")
            Form1.DataTeamNames(i)("MinikitL2RWC") = GetHash("frontend/textures/kitlogos/wc_" & Form1.DataTeamNames(i)("Logo") & "_l2")
            Form1.DataTeamNames(i)("MinikitR1RWC") = GetHash("frontend/textures/kitlogos/wc_" & Form1.DataTeamNames(i)("Logo") & "_r1")
            Form1.DataTeamNames(i)("MinikitR2RWC") = GetHash("frontend/textures/kitlogos/wc_" & Form1.DataTeamNames(i)("Logo") & "_r2")
        Next
        DataGridView1.AutoResizeColumns()
    End Sub

    Function GetHash(theInput As String) As String
        Using hasher As MD5 = MD5.Create()
            Dim dbytes As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))
            Dim sBuilder As New StringBuilder()
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n
            Return sBuilder.ToString().ToLowerInvariant
        End Using
    End Function
    Private Sub DataGridView1_DataBindingComplete(ByVal sender As Object, ByVal e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete

    End Sub

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
            EnabledFilter = " and active = 'yes'"
        End If
        DataViewTeamNames.RowFilter = "0 = 0" & EnabledFilter & TeamNameFilter & TournamentFilter
        DataGridView1.AutoResizeColumns()
        Return 0
    End Function
End Class
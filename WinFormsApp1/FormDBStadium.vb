Public Class FormDBStadium
    Dim EnabledFilter As String
    Dim TeamNameFilter As String
    Dim TournamentFilter As String
    Dim i As Integer
    Dim j As Integer
    Private Sub FormDBStadium_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Form1.DataViewTeams
        DataGridView2.DataSource = Form1.DataStadiums
        For i = 0 To 107
            DataGridView1.Columns(i).Visible = False
        Next
        DataGridView1.Columns("TeamIndex").DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns("TeamName").DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns("HomeStadiumName").DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns("TeamName").ReadOnly = True
        DataGridView1.Columns("HomeStadiumName").ReadOnly = True
        DataGridView1.Columns("TeamIndex").ReadOnly = True

        DataGridView1.Columns("TeamName").Visible = True
        DataGridView1.Columns("HomeStadium").Visible = True
        DataGridView1.Columns("HomeStadiumName").Visible = True
        DataGridView1.Columns("TeamIndex").Visible = True
        DataGridView1.Columns("Performance").Visible = True

        DataGridView1.Columns("TeamIndex").DisplayIndex = 0
        DataGridView1.Columns("TeamName").DisplayIndex = 1
        DataGridView1.AutoResizeColumns()
    End Sub

    'Private Sub DataGridView1_DataBindingComplete(ByVal sender As Object, ByVal e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete

    'End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If DataGridView1.CurrentCellAddress.X = 96 Then
            For i = 0 To Form1.DataTeams.Rows.Count - 1
                For j = 0 To Form1.DataStadiums.Rows.Count - 1
                    If Form1.DataTeams(i)(96) = Form1.DataStadiums(j)(1) Then
                        Form1.DataTeams(i)("HomeStadiumName") = Form1.DataStadiums(j)(4)
                    End If
                Next
            Next
        End If
    End Sub

    'Private Sub CheckEnabledTeam_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckEnabledTeam.CheckStateChanged
    '    If CheckEnabledTeam.Checked = True Then
    '        EnabledFilter = ""
    '    Else
    '        EnabledFilter = " and enabled = 'yes'"
    '    End If
    '    TeamFilter()
    'End Sub

    'Private Sub TextTeamName_TextChanged(sender As Object, e As EventArgs) Handles TextTeamName.TextChanged
    '    TeamNameFilter = " and TeamName Like '%" & TextTeamName.Text & "%'"
    '    TeamFilter()
    'End Sub

    'Private Sub ComboTournament_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTournament.SelectedIndexChanged
    '    If ComboTournament.SelectedIndex = 0 Then TournamentFilter = ""
    '    If ComboTournament.SelectedIndex = 1 Then TournamentFilter = " and FeGroup = 'International'"
    '    If ComboTournament.SelectedIndex = 2 Then TournamentFilter = " and FeGroup = 'super14'"
    '    If ComboTournament.SelectedIndex = 3 Then TournamentFilter = " and FeGroup = 'european'"
    '    If ComboTournament.SelectedIndex = 4 Then TournamentFilter = " and FeGroup = 'representative'"
    '    TeamFilter()
    'End Sub

    'Function TeamFilter()
    '    If CheckEnabledTeam.Checked = True Then
    '        EnabledFilter = ""
    '    Else
    '        EnabledFilter = " and enabled = 'yes'"
    '    End If
    '    FormExtras.DataViewPerformance.RowFilter = "0 = 0" & EnabledFilter & TeamNameFilter & TournamentFilter
    '    Return 0
    'End Function
End Class
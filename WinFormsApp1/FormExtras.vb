Public Class FormExtras
    Dim i As Integer
    Dim Perks2 As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormDBPlayer.Show()
        FormDBPlayer.DataGridView1.DataSource = Form1.DataViewPlayers
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormDBTeam.Show()
        FormDBTeam.DataGridView1.DataSource = Form1.DataViewTeams
    End Sub

    Private Sub ButtonStadium_Click(sender As Object, e As EventArgs) Handles ButtonStadium.Click
        FormDBStadium.Show()
        Me.Close()
    End Sub

    Private Sub ButtonInjuriesOn_Click(sender As Object, e As EventArgs) Handles ButtonInjuriesOn.Click
        If MsgBox("Are you sure you want to switch injuries on for all players?", 4, "Warning") = DialogResult.Yes Then
            For i = 0 To 3000
                If Form1.DataPlayers(i)(0) > 0 Or Form1.DataPlayers(i)(1) > 0 Then
                    Perks2 = Strings.Right("00000000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(i)(85)), 2), 8)
                    Mid(Perks2, 1, 1) = 0
                    Form1.DataPlayers(i)(85) = Strings.Left(Perks2, 1) * 128 + Mid(Perks2, 2, 1) * 64 +
                    Mid(Perks2, 3, 1) * 32 + Mid(Perks2, 4, 1) * 16 + Mid(Perks2, 5, 1) * 8 +
                    Mid(Perks2, 6, 1) * 4 + Mid(Perks2, 7, 1) * 2 + Mid(Perks2, 8, 1)
                Else
                    i = 3001
                End If
            Next
        End If
    End Sub
    Private Sub ButtonInjuriesOff_Click(sender As Object, e As EventArgs) Handles ButtonInjuriesOff.Click
        If MsgBox("Are you sure you want to switch injuries off for all players?", 4, "Warning") = DialogResult.Yes Then
            For i = 0 To 3000
                If Form1.DataPlayers(i)(0) > 0 Or Form1.DataPlayers(i)(1) > 0 Then
                    Perks2 = Strings.Right("00000000" & Convert.ToString(Convert.ToUInt32(Form1.DataPlayers(i)(85)), 2), 8)
                    Mid(Perks2, 1, 1) = 1
                    Form1.DataPlayers(i)(85) = Strings.Left(Perks2, 1) * 128 + Mid(Perks2, 2, 1) * 64 +
                    Mid(Perks2, 3, 1) * 32 + Mid(Perks2, 4, 1) * 16 + Mid(Perks2, 5, 1) * 8 +
                    Mid(Perks2, 6, 1) * 4 + Mid(Perks2, 7, 1) * 2 + Mid(Perks2, 8, 1)
                Else
                    i = 3001
                End If
            Next
        End If
    End Sub

    Private Sub FormExtras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonFileNames_Click(sender As Object, e As EventArgs) Handles ButtonFileNames.Click
        FormFileNames.Show()
    End Sub
End Class
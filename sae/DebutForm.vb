Public Class DebutForm
    Private Shared Function GetPlayerNames() As String()
        Return (From selectedPlayer In GetPlayers() Select selectedPlayer.GetName()).ToArray()
    End Function

    Public Sub FirstLoad()
        Cbx_Chooser.Items.AddRange(GetPlayerNames())
        Cbx_Guesser.Items.AddRange(GetPlayerNames())
        PlayBackgroundMusic()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstLoad()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Play.Click
        If Cbx_Chooser.Text = "" OrElse Cbx_Guesser.Text = "" Then
            MessageBox.Show("Les deux joueurs doivent avoir un nom.", "Erreur", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        ElseIf Cbx_Chooser.Text.ToLower = Cbx_Guesser.Text.ToLower Then
            MessageBox.Show("Les deux joueurs doivent avoir des noms différents.", "Erreur", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Else
            Hide()
            ChoixMotForm.Show()
        End If
    End Sub

    Private Sub Btn_Scores_Click(sender As Object, e As EventArgs) Handles Btn_Scores.Click
        StatsForm.Show()
        Hide()
    End Sub

    Private Sub Btn_Quit_Click(sender As Object, e As EventArgs) Handles Btn_Quit.Click
        If _
            MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Confirmation de sortie",
                            MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Public Function GetIndexFromName(playerName As String)
        For i = 0 To Cbx_Chooser.Items.Count - 1
            If Cbx_Chooser.Items(i) = playerName Then
                Return i
            End If
        Next
        Return - 1
    End Function

    Private Sub Btn_Options_Click(sender As Object, e As EventArgs) Handles Btn_Options.Click
        OptionsForm.Show()
        Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Btn_Help.Click
        Me.Hide()
        HelpForm.Show()
    End Sub
End Class

Public Class ChoixMotForm
    Private _mastermindTextBoxes As MastermindTextBoxes

    Private Sub ChoixMot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim textBoxes = New List(Of TextBox)(5) From {Txt1, Txt2, Txt3, Txt4, Txt5}
        _mastermindTextBoxes = New MastermindTextBoxes(textBoxes, Me, Btn_MakeGuess)
        LoadPlayableCharsInto(Lbl_Playable)
    End Sub

    Private Sub Btn_MakeGuess_Click(sender As Object, e As EventArgs) Handles Btn_MakeGuess.Click
        If _mastermindTextBoxes.AreAllBoxesFilled() Then
            SetNewGame(DebutForm.Cbx_Chooser.Text, DebutForM.Cbx_Guesser.Text,
                       _mastermindTextBoxes.GetSecretWordFromTextBoxes())
            Dispose()
            Close()
            MastermindGameForm.Show()
        End If
    End Sub

    Private Sub Quit() Handles Me.Closed
        Dispose()
        Close()
        DebutForm.Show()
    End Sub
End Class
Public Class MemeForm
    Private _time As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerPopupMeme.Tick
        _time += 1
        If _time = 2 Then
            TimerPopupMeme.Stop()
            Close()
        End If
    End Sub

    Private Sub memeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerPopupMeme.Start()
        TimerPopupMeme.Interval = 1000
    End Sub
End Class
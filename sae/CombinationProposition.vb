Public Class CombinationProposition
    Private Const NumberOfLetters As Integer = 5
    Private Const GapBetweenButtons As Integer = 5
    Private Const BorderSize As Integer = 1
    Private Const ButtonSize = 25
    Public Const GapBetweenProposition As Integer = GapBetweenButtons + ButtonSize
    Private ReadOnly _wordPanel As Panel = Nothing
    Private ReadOnly _buttonList As New List(Of Button)()
    Private Shared _colorIfAbsent As Color
    Private Shared _colorIfLetterPresentInWord As Color
    Private Shared _colorIfLetterGoodPosition As Color

    Public Sub New(givenInput As String, x As Integer, y As Integer)
        UpdateColors()
        _wordPanel = New Panel()
        _wordPanel.Location = New Point(x, y)
        _wordPanel.Size = New Size((NumberOfLetters + GapBetweenButtons)*ButtonSize, ButtonSize)
        _wordPanel.BorderStyle = BorderStyle.None

        For i = 0 To NumberOfLetters - 1
            Dim button As New Button()
            button.Size = New Size(ButtonSize, ButtonSize)
            button.Location = New Point(i*(ButtonSize + GapBetweenButtons), 0)
            button.FlatStyle = FlatStyle.Flat
            button.FlatAppearance.BorderSize = BorderSize
            button.FlatAppearance.BorderColor = _colorIfAbsent
            button.Text = GivenInput(i).ToString()
            button.TextAlign = ContentAlignment.MiddleCenter
            button.Enabled = False
            _buttonList.Add(button)
            _wordPanel.Controls.Add(button)
        Next
        For i = 0 To NumberOfLetters - 1
            Dim letterResult As Game.Game.LetterStatus = GetGame.LetterVerification(i, GivenInput(i))
            If letterResult = Game.Game.LetterStatus.Present Then
                ColorLetterPresent(i)
            ElseIf letterResult = Game.Game.LetterStatus.GoodPosition Then
                ColorLetterGoodPosition(i)
            End If
        Next
    End Sub

    Private Shared Sub UpdateColors()
        _colorIfAbsent = GetAbsentColor()
        _colorIfLetterPresentInWord = GetPresentColor()
        _colorIfLetterGoodPosition = GetGoodPositionColor()
    End Sub

    Public Function GetPanel() As Panel
        Return _wordPanel
    End Function

    Private Sub ColorLetterPresent(index As Integer)
        _buttonList(index).FlatAppearance.BorderColor = _colorIfLetterPresentInWord
    End Sub

    Private Sub ColorLetterGoodPosition(index As Integer)
        _buttonList(index).FlatAppearance.BorderColor = _colorIfLetterGoodPosition
    End Sub
End Class

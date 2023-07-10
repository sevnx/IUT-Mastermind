Public Class TextBoxBorder
    Private ReadOnly _associatedTextBox As TextBox
    Private ReadOnly _borderColor As Color
    Private ReadOnly _borderWidth As Integer

    Private Sub New(associatedTextBox As TextBox, borderColor As Color, borderWidth As Integer)
        _associatedTextBox = associatedTextBox
        _borderColor = borderColor
        _borderWidth = borderWidth
    End Sub

    Private Function GetPanel() As Panel
        Dim panel As New Panel
        panel.Size = New Size(_associatedTextBox.Width + _borderWidth*2, _associatedTextBox.Height + _borderWidth*2)
        panel.Location = New Point(_associatedTextBox.Location.X - _borderWidth,
                                   _associatedTextBox.Location.Y - _borderWidth)
        panel.BackColor = _borderColor
        Return panel
    End Function

    Public Shared Function GetBorderForTextBox(wantedTextBox As TextBox, wantedBorderColor As Color,
                                               wantedBorderWidth As Integer) As Panel
        Dim wantedTextBoxBorder As New TextBoxBorder(wantedTextBox, wantedBorderColor, wantedBorderWidth)
        Return wantedTextBoxBorder.GetPanel()
    End Function
End Class

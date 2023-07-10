Public Class MastermindTextBoxes
    Private ReadOnly _textBoxes As List(Of TextBox) = New List(Of TextBox)(5)
    Private ReadOnly _playableCharacters As String = GetPlayableCharacters()
    Private ReadOnly _borderColorWhenNothingInTextBox As Color = Color.Red
    Private ReadOnly _textBoxBorders As Dictionary(Of TextBox, Panel) = New Dictionary(Of TextBox, Panel)()
    Private ReadOnly _associatedControl As Control
    Private ReadOnly _buttonToFocusAfterLastTextBox As Button

    Public Sub New(textBoxes As List(Of TextBox), associatedControl As Control, buttonToFocusAfterLastTextBox As Button)
        _textBoxes = textBoxes
        _associatedControl = associatedControl
        _buttonToFocusAfterLastTextBox = buttonToFocusAfterLastTextBox
        LoadHandlerForTextBoxes()
        LoadTextBoxBorders()
    End Sub

    Public Sub ClearTextBoxes()
        For Each txtBox As TextBox In _textBoxes
            txtBox.Clear()
        Next
    End Sub

    Private Sub LoadTextBoxBorders()
        For Each txtBox As TextBox In _textBoxes
            Dim borderPanel As Panel = TextBoxBorder.GetBorderForTextBox(txtBox, _borderColorWhenNothingInTextBox, 2)
            _associatedControl.Controls.Add(borderPanel)
            borderPanel.Visible = False
            _textBoxBorders.Add(txtBox, borderPanel)
        Next
    End Sub

    Private Sub LoadHandlerForTextBoxes()
        For Each txt As TextBox In _textBoxes
            AddHandler txt.KeyPress, AddressOf TxtKeyPress
            AddHandler txt.KeyDown, AddressOf TxtKeyDown
        Next
    End Sub

    Private Sub TxtKeyPress(sender As Object, e As KeyPressEventArgs)
        Dim txtBox = CType(sender, TextBox)
        _textBoxBorders(txtBox).Visible = False
        If Char.IsControl(e.KeyChar) Then
            If e.KeyChar = vbBack Then
                If txtBox.SelectionStart = 0 Then
                    FocusPreviousTextBox(_textBoxes.IndexOf(txtBox))
                End If
                Exit Sub
            End If
        ElseIf Not _playableCharacters.Contains(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        ElseIf txtBox.Text.Length = 1 Then
            txtBox.Text = e.KeyChar
            FocusNextTextBox(_textBoxes.IndexOf(txtBox))
        Else
            FocusNextTextBox(_textBoxes.IndexOf(txtBox))
        End If
    End Sub

    Private Sub TxtKeyDown(sender As Object, e As KeyEventArgs)
        Dim txtBox = CType(sender, TextBox)
        If e.KeyCode = Keys.Left And txtBox.SelectionStart = 0 Then
            FocusPreviousTextBox(_textBoxes.IndexOf(txtBox))
        ElseIf _
            e.KeyCode = Keys.Right AndAlso
            (txtBox.SelectionStart = 1 OrElse (txtBox.SelectionStart = 0 AndAlso txtBox.Text.Length = 0)) Then
            FocusNextTextBox(_textBoxes.IndexOf(txtBox))
        End If
    End Sub

    Private Sub SetTextBorderToRed(ByRef selected As TextBox)
        _textBoxBorders(selected).Visible = True
    End Sub

    Private Sub FocusNextTextBox(idOfCurrentTextBox As Integer)
        If idOfCurrentTextBox <> NumberOfLetters - 1 Then
            _textBoxes(idOfCurrentTextBox + 1).Focus()
            If _textBoxes(idOfCurrentTextBox + 1).Text.Length = 1 Then
                _textBoxes(idOfCurrentTextBox + 1).SelectionStart = 1
            End If
        Else
            _buttonToFocusAfterLastTextBox.Focus()
        End If
    End Sub

    Private Sub FocusPreviousTextBox(idOfCurrentTextBox As Integer)
        If idOfCurrentTextBox <> 0 Then
            _textBoxes(idOfCurrentTextBox - 1).Focus()
            If _textBoxes(idOfCurrentTextBox - 1).Text.Length = 1 Then
                _textBoxes(idOfCurrentTextBox - 1).SelectionStart = 1
            End If
        End If
    End Sub

    Public Function AreAllBoxesFilled() As Boolean
        Dim allFilled = True
        For Each txt As TextBox In _textBoxes
            If txt.Text = "" Then
                SetTextBorderToRed(txt)
                allFilled = False
            End If
        Next
        Return allFilled
    End Function

    Public Function GetSecretWordFromTextBoxes() As String
        Return _textBoxes.Aggregate("", Function(current, txt) current & txt.Text)
    End Function
End Class
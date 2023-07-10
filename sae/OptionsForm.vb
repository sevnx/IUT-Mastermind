Imports System.IO

Public Class OptionsForm
    Private ReadOnly _defaultStatsPath As String = Application.StartupPath
    Private ReadOnly _disabledTextColor As Color = Color.Gray
    Private ReadOnly _enabledTextColor As Color = Color.Black
    Private ReadOnly _txtBoxes As List(Of TextBox) = New List(Of TextBox)()
    Private ReadOnly _borderColorWhenNothingInTextBox As Color = Color.Red
    Private ReadOnly _textBoxBorders As Dictionary(Of TextBox, Panel) = New Dictionary(Of TextBox, Panel)()
    Private _marseillaiseEasterEggEnabled As Boolean = False

    Private Sub LoadCurrentOptions()
        Txt_SavePath.Text = GetSavePathForStats()
        If Not File.Exists(Txt_SavePath.Text) Then
            Txt_SavePath.Text = _defaultStatsPath
        End If
        Txt_AbsentColor.BackColor = GetAbsentColor()
        Txt_PresentColor.BackColor = GetPresentColor()
        Txt_GoodPositionColor.BackColor = GetGoodPositionColor()
        Txt_NbCoups.Text = GetMaxGuesses()
        If Txt_NbCoups.Text = 0 Then
            CheckBoxPropositionLimit.Checked = False
        End If
        LoadTimeToGuess()
        If GetTotalTime() = 0 Then
            CheckBoxTimeLimit.Checked = False
        End If
        LoadUsableCharacters()
    End Sub

    Private Sub LoadUsableCharacters()
        Dim usableCharacters As String = GetPlayableCharacters()
        For i = 0 To _txtBoxes.Count - 1
            _txtBoxes(i).Text = usableCharacters(i)
        Next
    End Sub

    Private Sub LoadTimeToGuess()
        Dim time As Integer = GetTime()
        Dim minutes As Integer = time \ 60
        Dim seconds As Integer = time Mod 60
        Txt_Minute.Text = minutes
        Txt_Second.Text = seconds
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Hide()
        ColorPickerForm.Show()
    End Sub

    Private Function GetOtherTextBoxes(firstTextBox As TextBox) As List(Of TextBox)
        Return (From textBox In PanelColor.Controls.OfType(Of TextBox)() Where Not textBox.Equals(firstTextBox)).ToList()
    End Function

    Private Sub Btn_Click(associatedTextBox As TextBox)
        Dim otherTextBoxes As List(Of TextBox) = GetOtherTextBoxes(associatedTextBox)
        ColorPickerForm.LoadColor(associatedTextBox.BackColor)
        If ColorPickerForm.ShowDialog() = DialogResult.OK Then
            Dim chosenColor As Color = ColorPickerForm.GetCurrentColor()
            For Each txtBox As TextBox In otherTextBoxes
                If txtBox.BackColor.ToArgb = chosenColor.ToArgb Then
                    MessageBox.Show("Vous ne pouvez pas utiliser la même couleur pour 2 états différents", "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Next
            associatedTextBox.BackColor = ColorPickerForm.GetCurrentColor()
        End If
        CheckFlagColors()
        ColorPickerForm.Dispose()
    End Sub

    Private Sub CheckFlagColors()
        Dim startBlueColor As Color = Color.FromArgb(0, 0, 255)
        Dim endBlueColor As Color = Color.FromArgb(0, 0, 128)

        Dim startWhiteColor As Color = Color.FromArgb(255, 255, 255)
        Dim endWhiteColor As Color = Color.FromArgb(128, 128, 128)

        Dim startRedColor As Color = Color.FromArgb(255, 0, 0)
        Dim endRedColor As Color = Color.FromArgb(128, 0, 0)

        Dim blueTextBoxColor As Color = Txt_AbsentColor.BackColor
        Dim whiteTextBoxColor As Color = Txt_PresentColor.BackColor
        Dim redTextBoxColor As Color = Txt_GoodPositionColor.BackColor

        Dim bluePercentage As Single = GetColorPercentage(startBlueColor, endBlueColor, blueTextBoxColor)
        Dim whitePercentage As Single = GetColorPercentage(startWhiteColor, endWhiteColor, whiteTextBoxColor)
        Dim redPercentage As Single = GetColorPercentage(startRedColor, endRedColor, redTextBoxColor)

        If bluePercentage >= 0 AndAlso bluePercentage <= 1 AndAlso whitePercentage >= 0 AndAlso whitePercentage <= 1 AndAlso redPercentage >= 0 AndAlso redPercentage <= 1 Then
            PlayMarseillaise()
            _marseillaiseEasterEggEnabled = True
        Else
            If _marseillaiseEasterEggEnabled Then
                PlayBackgroundMusic()
            End If
            _marseillaiseEasterEggEnabled = False
        End If
    End Sub

    Private Shared Function GetColorPercentage(startColor As Color, endColor As Color, currentColor As Color) As Single
        Dim totalDistance As Integer = Math.Abs(CInt(endColor.R) - CInt(startColor.R)) + Math.Abs(CInt(endColor.G) - CInt(startColor.G)) + Math.Abs(CInt(endColor.B) - CInt(startColor.B))
        Dim currentDistance As Integer = Math.Abs(CInt(currentColor.R) - CInt(startColor.R)) + Math.Abs(CInt(currentColor.G) - CInt(startColor.G)) + Math.Abs(CInt(currentColor.B) - CInt(startColor.B))

        If totalDistance = 0 Then
            Return 0
        Else
            Return CSng(currentDistance) / totalDistance
        End If
    End Function

    Private Sub Btn_Absent_Click(sender As Object, e As EventArgs) Handles Btn_Absent.Click
        Btn_Click(Txt_AbsentColor)
    End Sub

    Private Sub Btn_Present_Click(sender As Object, e As EventArgs) Handles Btn_Present.Click
        Btn_Click(Txt_PresentColor)
    End Sub

    Private Sub Btn_GoodPos_Click(sender As Object, e As EventArgs) Handles Btn_GoodPos.Click
        Btn_Click(Txt_GoodPositionColor)
    End Sub

    Private Sub Btn_Annuler_Click(sender As Object, e As EventArgs) Handles Btn_Annuler.Click
        CloseOptions(sender, e)
    End Sub

    Private Sub CloseOptions(sender As Object, e As EventArgs) Handles Me.Closed
        If _marseillaiseEasterEggEnabled Then
            PlayBackgroundMusic()
        End If
        Dispose()
        Close()
        DebutForm.Show()
    End Sub

    Private Sub Txt_Minute_TextChanged(sender As Object, e As KeyPressEventArgs) Handles Txt_Minute.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CheckBoxTimeLimit_CheckedChanged(sender As Object, e As EventArgs) _
        Handles CheckBoxTimeLimit.CheckedChanged
        If CheckBoxTimeLimit.Checked = False Then
            If CheckBoxPropositionLimit.Checked = False Then
                MessageBox.Show("Vous ne pouvez pas désactiver le nombre de coups si le temps est illimité", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                CheckBoxTimeLimit.Checked = True
            Else
                Txt_Minute.Enabled = False
                Txt_Second.Enabled = False
                Btn_PlusTime.Enabled = False
                Btn_MinusTime.Enabled = False
                Lbl_min.ForeColor = _disabledTextColor
                Lbl_sec.ForeColor = _disabledTextColor
                CheckBoxTimeLimit.ForeColor = _disabledTextColor
            End If
        Else
            Txt_Minute.Enabled = True
            Txt_Second.Enabled = True
            Btn_PlusTime.Enabled = True
            Btn_MinusTime.Enabled = True
            Lbl_min.ForeColor = _enabledTextColor
            Lbl_sec.ForeColor = _enabledTextColor
            CheckBoxTimeLimit.ForeColor = _enabledTextColor
        End If
    End Sub

    Private Sub CheckBoxPropositionLimit_CheckedChanged(sender As Object, e As EventArgs) _
        Handles CheckBoxPropositionLimit.CheckedChanged
        If CheckBoxPropositionLimit.Checked = False Then
            If CheckBoxTimeLimit.Checked = False Then
                MessageBox.Show("Vous ne pouvez pas désactiver le nombre de coups si le temps est illimité", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                CheckBoxPropositionLimit.Checked = True
            Else
                Txt_NbCoups.Enabled = False
                Txt_NbCoups.ForeColor = _disabledTextColor
                CheckBoxPropositionLimit.ForeColor = _disabledTextColor
                Lbl_coups.ForeColor = _disabledTextColor
            End If
        Else
            Txt_NbCoups.Enabled = True
            Txt_NbCoups.ForeColor = _enabledTextColor
            CheckBoxPropositionLimit.ForeColor = _enabledTextColor
            Lbl_coups.ForeColor = _enabledTextColor
        End If
    End Sub

    Private Sub Btn_SavePath_Click(sender As Object, e As EventArgs) Handles Btn_SavePath.Click
        Dim folderBrowserDialogSave As New FolderBrowserDialog
        folderBrowserDialogSave.Description = "Choisissez un dossier pour enregistrer les scores"
        folderBrowserDialogSave.SelectedPath = Txt_SavePath.Text
        folderBrowserDialogSave.ShowNewFolderButton = True
        If folderBrowserDialogSave.ShowDialog() = DialogResult.OK Then
            Txt_SavePath.Text = folderBrowserDialogSave.SelectedPath
        End If
    End Sub

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTextBoxes()
        LoadCurrentOptions()
        LoadHandlerForTextBoxes()
        LoadTextBoxBorders()
    End Sub

    Private Sub LoadTextBoxes()
        _txtBoxes.Add(Txt1)
        _txtBoxes.Add(Txt2)
        _txtBoxes.Add(Txt3)
        _txtBoxes.Add(Txt4)
        _txtBoxes.Add(Txt5)
    End Sub

    Private Sub LoadHandlerForTextBoxes()
        For Each txt As TextBox In _txtBoxes
            AddHandler txt.KeyPress, AddressOf TxtKeyPress
            AddHandler txt.KeyDown, AddressOf TxtKeyDown
        Next
    End Sub

    Private Sub TxtKeyPress(sender As Object, e As KeyPressEventArgs)
        Dim textBox = CType(sender, TextBox)
        _textBoxBorders(textBox).Visible = False
        Dim currentText As String = GetPlayableChars()
        If currentText.Contains(e.KeyChar) And textBox.Text <> e.KeyChar Then
            MessageBox.Show("Le caractère " & e.KeyChar & " est déjà utilisée", "Lettre déjà utilisée",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            If e.KeyChar = vbBack Then
                If textBox.SelectionStart = 0 Then
                    FocusPreviousTextBox(_txtBoxes.IndexOf(textBox))
                End If
                Exit Sub
            End If
        ElseIf textBox.Text.Length = 1 Then
            textBox.Text = e.KeyChar
            FocusNextTextBox(_txtBoxes.IndexOf(textBox))
        Else
            FocusNextTextBox(_txtBoxes.IndexOf(textBox))
        End If
    End Sub

    Private Sub TxtKeyDown(sender As Object, e As KeyEventArgs)
        Dim txtBox = CType(sender, TextBox)
        If e.KeyCode = Keys.Left And txtBox.SelectionStart = 0 Then
            FocusPreviousTextBox(_txtBoxes.IndexOf(txtBox))
        ElseIf _
            e.KeyCode = Keys.Right AndAlso
            (txtBox.SelectionStart = 1 OrElse (txtBox.SelectionStart = 0 AndAlso txtBox.Text.Length = 0)) Then
            FocusNextTextBox(_txtBoxes.IndexOf(txtBox))
        End If
    End Sub

    Private Sub LoadTextBoxBorders()
        For Each txtBox As TextBox In _txtBoxes
            Dim borderPanel As Panel = TextBoxBorder.GetBorderForTextBox(txtBox, _borderColorWhenNothingInTextBox, 2)
            Controls.Add(borderPanel)
            borderPanel.Visible = False
            _textBoxBorders.Add(txtBox, borderPanel)
        Next
    End Sub

    Private Sub SetUnfilledTextBoxesToRedBorder()
        For Each txt As TextBox In _txtBoxes
            If txt.Text = "" Then
                _textBoxBorders(txt).Visible = True
            End If
        Next
    End Sub

    Private Sub FocusNextTextBox(idOfCurrentTextBox As Integer)
        If idOfCurrentTextBox <> _txtBoxes.Count - 1 Then
            _txtBoxes(idOfCurrentTextBox + 1).Focus()
            If _txtBoxes(idOfCurrentTextBox + 1).Text.Length = 1 Then
                _txtBoxes(idOfCurrentTextBox + 1).SelectionStart = 1
            End If
        End If
    End Sub

    Private Sub FocusPreviousTextBox(idOfCurrentTextBox As Integer)
        If idOfCurrentTextBox <> 0 Then
            _txtBoxes(idOfCurrentTextBox - 1).Focus()
            If _txtBoxes(idOfCurrentTextBox - 1).Text.Length = 1 Then
                _txtBoxes(idOfCurrentTextBox - 1).SelectionStart = 1
            End If
        End If
    End Sub

    Private Function AreAllBoxesFilled() As Boolean
        For Each txt As TextBox In _txtBoxes
            If txt.Text = "" Then
                SetUnfilledTextBoxesToRedBorder()
                Return False
            End If
        Next
        Return True
    End Function

    Private Function GetPlayableChars() As String
        Dim chars = ""
        For i = 0 To 4
            chars &= _txtBoxes(i).Text
        Next
        Console.WriteLine(chars)
        Return chars
    End Function

    Private Function GetTotalTime() As Integer
        Return Txt_Minute.Text * 60 + Txt_Second.Text
    End Function

    Private Sub Txt_Second_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Second.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If Txt_Second.Text = "" Then
            Exit Sub
        End If
        If Txt_Second.Text > 60 Then
            Txt_Second.Text = 60
        End If
    End Sub

    Private Function VerifyCorrectOptions() As Boolean
        If VerifyPlayableChars() AndAlso VerifyNumberOfPropositions() AndAlso VerifyTime() AndAlso VerifySavePath() Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function VerifyPlayableChars() As Boolean
        If Not AreAllBoxesFilled() Then
            MessageBox.Show("Veuillez remplir tous les champs")
            Return False
        End If
        Return True
    End Function

    Private Function VerifyNumberOfPropositions() As Boolean
        If Not CheckBoxPropositionLimit.Checked Then
            Return True
        End If
        If Not IsNumeric(Txt_NbCoups.Text) Then
            MessageBox.Show("Numérique attendu")
            Return False
        ElseIf Txt_NbCoups.Text < 1 Then
            MessageBox.Show("Nombre de propositions minimum : 1")
            Return False
        End If
        Return True
    End Function

    Private Function VerifyTime() As Boolean
        If Not CheckBoxTimeLimit.Checked Then
            Return True
        End If
        If Not IsNumeric(Txt_Minute.Text) OrElse Not IsNumeric(Txt_Second.Text) Then
            MessageBox.Show("Numérique attendu")
            Return False
        ElseIf Txt_Minute.Text < 0 OrElse Txt_Second.Text < 0 Then
            MessageBox.Show("Temps minimum : 0")
            Return False
        ElseIf Txt_Minute.Text = 0 AndAlso Txt_Second.Text = 0 Then
            MessageBox.Show("Temps minimum : 1 seconde")
            Return False
        End If
        Return True
    End Function

    Private Function VerifySavePath() As Boolean
        If Not Directory.Exists(Txt_SavePath.Text) Then
            MessageBox.Show("Le dossier n'existe pas")
            Return False
        End If
        Return True
    End Function

    Private Sub LoadDefaultIntoTextBox()
        Const chars = "#$%@£"
        Dim i = 0
        For Each txt As TextBox In _txtBoxes
            txt.Text = chars(i)
            i += 1
        Next
    End Sub

    Private Sub RestoreDefaultSettings()
        LoadDefaultIntoTextBox()
        Txt_AbsentColor.BackColor = Color.Black
        Txt_PresentColor.BackColor = Color.Blue
        Txt_GoodPositionColor.BackColor = Color.Green
        CheckFlagColors()
        CheckBoxPropositionLimit.Checked = True
        CheckBoxTimeLimit.Checked = True
        Txt_Minute.Text = 1
        Txt_Second.Text = 30
        Txt_NbCoups.Text = 15
        Txt_SavePath.Text = _defaultStatsPath
    End Sub

    Private Sub SaveOptions()
        SetAbsentColor(Txt_AbsentColor.BackColor)
        SetPresentColor(Txt_PresentColor.BackColor)
        SetGoodPositionColor(Txt_GoodPositionColor.BackColor)
        If CheckBoxPropositionLimit.Checked Then
            SetNumberOfPropositions(Txt_NbCoups.Text)
        Else
            SetNumberOfPropositions(0)
        End If
        SetSavePathForStats(Txt_SavePath.Text)
        If CheckBoxTimeLimit.Checked Then
            SetTime(GetTotalTime())
        Else
            SetTime(0)
        End If
        SetPlayableCharacters(GetPlayableChars())
        SaveSettings()
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        If VerifyCorrectOptions() Then
            SaveOptions()
            CloseOptions(sender, e)
        End If
    End Sub

    Private Sub Btn_Reset_Click(sender As Object, e As EventArgs) Handles Btn_Reset.Click
        RestoreDefaultSettings()
    End Sub

    Private Sub IfTimeEmptyBringToDefault()
        If Txt_Minute.Text = "" Then
            Txt_Minute.Text = 0
        End If
        If Txt_Second.Text = "" Then
            Txt_Second.Text = 0
        End If
    End Sub

    Private Sub Btn_PlusTime_Click(sender As Object, e As EventArgs) Handles Btn_PlusTime.Click
        IfTimeEmptyBringToDefault()
        If Txt_Second.Text = 59 Then
            Txt_Second.Text = 0
            Txt_Minute.Text += 1
        Else
            Txt_Second.Text += 1
        End If
    End Sub

    Private Sub Btn_MinusTime_Click(sender As Object, e As EventArgs) Handles Btn_MinusTime.Click
        IfTimeEmptyBringToDefault()
        If Txt_Second.Text = 0 Then
            If Txt_Minute.Text = 0 Then
                Txt_Second.Text = 0
            Else
                Txt_Second.Text = 59
                Txt_Minute.Text -= 1
            End If
        Else
            Txt_Second.Text -= 1
        End If
    End Sub

    Private Sub Txt_NbCoups_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_NbCoups.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
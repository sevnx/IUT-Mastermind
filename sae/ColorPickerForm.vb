Imports System.Globalization

Public Class ColorPickerForm
    Private Const AllowedCharsForColorHex As String = "1234567890ABCDEF"
    Private _predefinedColorPanels As List(Of Panel)

    Private Sub ColorPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateColor()
        LoadColorsIntoPanels()
        LoadPanelsIntoList()
        LoadHandlersForPanels()
    End Sub

    Public Function GetCurrentColor() As Color
        Return Color.FromArgb(Txt_R.Text, Txt_G.Text, Txt_B.Text)
    End Function

    Public Sub LoadColor(firstLoadedColor As Color)
        Txt_R.Text = firstLoadedColor.R
        Txt_G.Text = firstLoadedColor.G
        Txt_B.Text = firstLoadedColor.B
    End Sub

    Private Sub LoadColorsIntoPanels()
        PanelBlack.BackColor = Color.Black
        PanelWhite.BackColor = Color.White
        PanelBlue.BackColor = Color.Blue
        PanelOrange.BackColor = Color.Orange
        PanelYellow.BackColor = Color.Yellow
        PanelGreen.BackColor = Color.Green
        PanelFusionMauve.BackColor = Color.FromArgb(130, 56, 119)
    End Sub

    Private Sub LoadPanelsIntoList()
        _predefinedColorPanels = PanelPredefined.Controls.OfType (Of Panel)().ToList()
    End Sub

    Private Sub LoadHandlersForPanels()
        For Each panel In _predefinedColorPanels
            AddHandler panel.Click, AddressOf Panel_Click
        Next
    End Sub

    Private Sub Panel_Click(sender As Object, e As EventArgs)
        Dim selectedPanel = DirectCast(sender, Panel)
        LoadColor(selectedPanel.BackColor)
    End Sub

    Private Sub TextBoxRGB_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles Txt_G.KeyPress, Txt_B.KeyPress, Txt_R.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If Not sender.Text = "" Then
            Dim number As Integer = Convert.ToInt32(sender.Text)
            If number = 25 AndAlso Char.IsDigit(e.KeyChar) Then
                If e.KeyChar > "5" Then
                    e.Handled = True
                End If
            ElseIf number > 25 AndAlso Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub HScroll_R_Scroll(sender As Object, e As ScrollEventArgs) Handles HScroll_R.Scroll
        Txt_R.Text = HScroll_R.Value
    End Sub

    Private Sub HScroll_G_Scroll(sender As Object, e As ScrollEventArgs) Handles HScroll_G.Scroll
        Txt_G.Text = HScroll_G.Value
    End Sub

    Private Sub HScroll_B_Scroll(sender As Object, e As ScrollEventArgs) Handles HScroll_B.Scroll
        Txt_B.Text = HScroll_B.Value
    End Sub

    Private Sub TxtRGB_TextChanged(sender As Object, e As EventArgs) _
        Handles Txt_R.TextChanged, Txt_G.TextChanged, Txt_B.TextChanged
        Dim textBox = DirectCast(sender, TextBox)
        Dim associatedScrollBar As ScrollBar

        Select Case textBox.Name
            Case "Txt_R"
                associatedScrollBar = HScroll_R
            Case "Txt_G"
                associatedScrollBar = HScroll_G
            Case "Txt_B"
                associatedScrollBar = HScroll_B
            Case Else
                Return
        End Select
        If textBox.Text = "" Then
            associatedScrollBar.Value = 0
            textBox.Text = 0
        Else
            associatedScrollBar.Value = textBox.Text
        End If
        UpdateAll()
    End Sub

    Private Sub UpdateAll()
        UpdateColor()
        UpdateHex()
    End Sub

    Private Sub UpdateColor()
        Dim r As Integer
        Dim g As Integer
        Dim b As Integer
        If Integer.TryParse(Txt_R.Text, r) AndAlso
           Integer.TryParse(Txt_G.Text, g) AndAlso
           Integer.TryParse(Txt_B.Text, b) Then
            PanelColor.BackColor = Color.FromArgb(r, g, b)
        End If
    End Sub

    Private Sub UpdateHex()
        Dim r As Integer
        Dim g As Integer
        Dim b As Integer
        If Integer.TryParse(Txt_R.Text, r) AndAlso
           Integer.TryParse(Txt_G.Text, g) AndAlso
           Integer.TryParse(Txt_B.Text, b) Then
            Txt_Hex.Text = ToHex(r) & ToHex(g) & ToHex(b)
        End If
    End Sub

    Private Shared Function ToHex(number As Integer) As String
        Dim hexNumber As String = Hex(number)
        If hexNumber.Length = 1 Then
            hexNumber = "0" & hexNumber
        End If
        Return hexNumber
    End Function

    Private Sub Txt_Hex_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Hex.KeyPress
        If Not AllowedCharsForColorHex.Contains(e.KeyChar.ToString.ToUpper) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_Hex_TextChanged(sender As Object, e As EventArgs) Handles Txt_Hex.TextChanged
        Dim hexString As String = Txt_Hex.Text.ToUpper
        If Txt_Hex.Text.Length = 6 Then
            Integer.TryParse(hexString.Substring(0, 2), NumberStyles.HexNumber, Nothing, Txt_R.Text)
            Integer.TryParse(hexString.Substring(2, 2), NumberStyles.HexNumber, Nothing, Txt_G.Text)
            Integer.TryParse(hexString.Substring(4, 2), NumberStyles.HexNumber, Nothing, Txt_B.Text)
        End If
    End Sub

    Private Sub ColorPickerForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        OptionsForm.Show()
    End Sub

    Private Sub Btn_Confirm_Click(sender As Object, e As EventArgs) Handles Btn_Confirm.Click
        DialogResult = DialogResult.OK
        Hide()
        OptionsForm.Show()
    End Sub
End Class
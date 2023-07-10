Public Class MastermindGameForm
    Private WithEvents _timerForStopwatch As New Timer
    Private _maxTimeToGuess As Integer
    Private _maxGuesses As Integer
    Private _nbGuesses As Integer
    Private _scrolls As Integer
    Private _guessingTime As Integer
    Private Const StartXForPropositionHistory As Integer = 47
    Private Const StartYForPropositionHistory As Integer = 33
    Private Const TextWin As String = "Trouvé "
    Private Const TextLose As String = "Perdu "
    Private Const MaxPropositionPanels As Integer = 11
    Private Const TimeRemainingWhenSoundPlays As Integer = 10
    Private _combinationHistoryPanels As List(Of Panel)
    Private _mastermindTextBoxes As MastermindTextBoxes

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim textBoxes = New List(Of TextBox)(5) From {Txt1, Txt2, Txt3, Txt4, Txt5}
        _mastermindTextBoxes = New MastermindTextBoxes(textBoxes, PanelGuess, Btn_Submit_Answer)
        LoadPlayableCharsInto(Lbl_Playable)
        ResetForm()
        Stopwatch(sender, e)
    End Sub

    Private Sub GetValuesFromOptions()
        _maxTimeToGuess = GetTime
        _maxGuesses = GetMaxGuesses()
    End Sub

    Private Sub SetToDefaultVisibilityAndEnable()
        Btn_Replay.Visible = False
        Btn_Quit.Visible = False
        Label_Result.Visible = False
        PanelTitleAndTiMe.Visible = True
    End Sub

    Private Sub LoadColorsIntoPanel()
        PanelAbsent.BackColor = GetAbsentColor
        PanelPresent.BackColor = GetPresentColor
        PanelGoodPlacement.BackColor = GetGoodPositionColor
    End Sub

    Private Sub StartStopwatch()
        Const secondTimerInterval = 1000
        _timerForStopwatch.Start()
        _timerForStopwatch.Interval = secondTimerInterval
    End Sub

    Private Sub DefaultVariables()
        _combinationHistoryPanels = New List(Of Panel)()
        _nbGuesses = 0
        _maxTimeToGuess = GetTime
        _mastermindTextBoxes.ClearTextBoxes()
        _scrolls = 0
        _guessingTime = 0
        LoadColorsIntoPanel()
    End Sub
    
    Private Sub UpdateDisplayForTime()
        TimeLabel.Text = "Temps restant : " & TimeToMinSecStringSeparatedByColon(GetTimeRemaining())
    End Sub

    Private Sub ResetForm()
        GetValuesFromOptions()
        DefaultVariables()
        SetToDefaultVisibilityAndEnable()
        UpdateDisplayForTime()
        UpdateDisplayForNumberOfGuessesLeft()
        StartStopwatch()
    End Sub
    
    Private Function GetTimeRemaining() As Integer
        Dim timeRemaining = _maxTimeToGuess - _guessingTime
        If timeRemaining = 10
            PlayLookAtTheTimeSound()
        End If
        Return _maxTimeToGuess - _guessingTime
    End Function

    Private Sub Stopwatch(sender As Object, e As EventArgs) Handles _timerForStopwatch.Tick
        _guessingTime += 1
        UpdateDisplayForTime()
        If _guessingTime >= _maxTimeToGuess Then
            MastermindEndGame(GameWinner.Chooser)
        End If
    End Sub

    Private Sub UpdateDisplayForNumberOfGuessesLeft()
        If GetGuessesLeft < 0 Then
            Text = "Trouvez la combinaison"
        Else
            Text = "Il vous reste " & GetGuessesLeft & " coups"
        End If
    End Sub

    Private Function GetGuessesLeft() As Integer
        Return _maxGuesses - _nbGuesses
    End Function

    Private Sub SubmitAnswer(sender As Object, e As EventArgs) Handles Btn_Submit_Answer.Click
        If _mastermindTextBoxes.AreAllBoxesFilled() Then
            Dim input As String = _mastermindTextBoxes.GetSecretWordFromTextBoxes()
            AddResult(input)
            If Not GetGame().IsWordSecretWord(input) Then
                UpdateDisplayForNumberOfGuessesLeft()
                If GetGuessesLeft = 0 Then
                    MastermindEndGame(GameWinner.Chooser)
                End If
            Else
                MastermindEndGame(GameWinner.Guesser)
            End If
        End If
    End Sub

    Private Sub EndGameFormManipulation(winner As GameWinner)
        PanelGuess.Enabled = False
        Btn_Submit_Answer.Enabled = False
        PanelGuess.BackColor = Color.Gray
        Label_Result.Visible = True
        PanelTitleAndTime.Visible = False
        Btn_Submit_Answer.Enabled = False
        Select Case winner
            Case GameWinner.Guesser
                Label_Result.Text = TextWin & InfoAboutGameResult()
            Case GameWinner.Chooser
                Label_Result.Text = TextLose & InfoAboutGameResult()
        End Select
    End Sub

    Private Sub MastermindEndGame(winner As GameWinner)
        _timerForStopwatch.Stop()
        EndGameFormManipulation(winner)
        GetGame.EndOfGame(_guessingTime, winner)
        PostGameButtonDisplay()
        Btn_Replay.Focus()
        Select Case winner
            Case GameWinner.Guesser
                If _nbGuesses = 1 Then
                    MemeForm.Show()
                    PlayPerfectSound()
                Else
                    PlayWinningSound()
                End If
            Case GameWinner.Chooser
                If GetTimeRemaining()<>0 AndAlso _nbGuesses = 0 Then
                    PlayFailSound()
                Else
                    PlayLosingSound()
                End If
        End Select
    End Sub

    Private Sub PostGameButtonDisplay()
        Btn_Replay.Visible = True
        Btn_Quit.Visible = True
    End Sub

    Private Sub AddResult(givenInput As String)
        _nbGuesses += 1
        Dim numberOfInputs = _combinationHistoryPanels.Count()
        Dim _
            combination As _
                New CombinationProposition(givenInput, StartXForPropositionHistory,
                                           StartYForPropositionHistory +
                                           IIf(numberOfInputs >= MaxPropositionPanels, MaxPropositionPanels,
                                               numberOfInputs)*CombinationProposition.GapBetweenProposition)
        ScrollBackToDefault()
        Dim associatedPanel As Panel = combination.GetPanel()
        PanelHistory.Controls.Add(associatedPanel)
        _combinationHistoryPanels.Add(associatedPanel)
        If _combinationHistoryPanels.Count() > MaxPropositionPanels Then
            GoUp()
        End If
    End Sub

    Private Sub ScrollBackToDefault()
        If _scrolls > 0 Then
            For i = 0 To _scrolls
                GoUp()
            Next
        Else
            For i = 0 To Math.Abs(_scrolls)
                GoDown()
            Next
        End If
    End Sub

    Private Function InfoAboutGameResult() As String
        Return "après " & _nbGuesses & " coups en " & TimeToMinSecLonger(_guessingTime)
    End Function

    Private Sub Btn_Replay_Click(sender As Object, e As EventArgs) Handles Btn_Replay.Click
        Dispose()
        Close()
        DebutForm.FirstLoad()
        DebutForm.Show()
        DebutForm.Cbx_Chooser.Text = GetGame.GetGuesser
        DebutForm.Cbx_Chooser.SelectedIndex = DebutForm.GetIndexFromName(GetGame.GetGuesser)
        DebutForm.Cbx_Guesser.Text = GetGame.GetChooser
        DebutForm.Cbx_Guesser.SelectedIndex = DebutForm.GetIndexFromName(GetGame.GetChooser)
    End Sub
    
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Label_Result.Visible Then
            e.Cancel = True
            MastermindEndGame(GameWinner.Chooser)
        Else
            Application.Exit()
        End If
    End Sub
    
    Private Sub Btn_Quit_Click(sender As Object, e As EventArgs) Handles Btn_Quit.Click
        Application.Exit()
    End Sub

    Private Sub GoUp()
        Dim maxScroll As Integer = _combinationHistoryPanels.Count() - MaxPropositionPanels
        If _combinationHistoryPanels.Count() <= MaxPropositionPanels Then
            Return
        End If
        If _scrolls >= maxScroll Then
            Return
        End If
        _scrolls += 1
        For Each combination As Panel In _combinationHistoryPanels
            If combination.Location.Y <= StartYForPropositionHistory Then
                combination.Visible = False
            ElseIf _
                combination.Location.Y <=
                StartYForPropositionHistory + CombinationProposition.GapBetweenProposition*(MaxPropositionPanels) _
                Then
                combination.Visible = True
            End If
            combination.Location = New Point(combination.Location.X,
                                             combination.Location.Y - CombinationProposition.GapBetweenProposition)
        Next
    End Sub

    Private Sub GoDown()
        If _
            _combinationHistoryPanels.Any() AndAlso
            _combinationHistoryPanels(0).Location.Y = StartYForPropositionHistory Then
            Return
        End If
        Dim maxScroll = _combinationHistoryPanels.Count() - MaxPropositionPanels
        If Math.Abs(_scrolls) > maxScroll Then
            Return
        End If
        _scrolls -= 1
        For Each combination As Panel In _combinationHistoryPanels
            If combination.Location.Y >= StartYForPropositionHistory - CombinationProposition.GapBetweenProposition Then
                combination.Visible = True
            End If
            If _
                combination.Location.Y >=
                StartYForPropositionHistory + CombinationProposition.GapBetweenProposition*(MaxPropositionPanels - 1) _
                Then
                combination.Visible = False
            End If
            combination.Location = New Point(combination.Location.X,
                                             combination.Location.Y + CombinationProposition.GapBetweenProposition)
        Next
    End Sub

    Private Sub Btn_GoUpTries_Click(sender As Object, e As EventArgs) Handles Btn_GoUpTries.Click
        GoDown()
    End Sub

    Private Sub Btn_GoDownTries_Click(sender As Object, e As EventArgs) Handles Btn_GoDownTries.Click
        GoUp()
    End Sub
End Class
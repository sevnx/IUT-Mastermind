Imports System.IO

Module Game
    Public Const NumberOfLetters As Integer = 5
    Private ReadOnly DefaultStatsPath As String = Application.StartupPath & "\" & "stats.txt"
    Private _players() As Player = {}
    Private _currentGame As Game = Nothing
    Private _statsPath As String

    Public Enum GameWinner
        Chooser = 0
        Guesser = 1
    End Enum

    Class Game
        Private ReadOnly _chooser As String
        Private ReadOnly _guesser As String
        Private ReadOnly _secretWord As String

        Public Sub New(chooser As String, guesser As String, secretWord As String)
            _chooser = chooser
            _guesser = guesser
            _secretWord = secretWord
        End Sub

        Public Enum LetterStatus
            NotPresent = - 1
            Present = 0
            GoodPosition = 1
        End Enum

        Public Function LetterVerification(index As Integer, givenLetter As Char) As LetterStatus
            If _secretWord.Contains(givenLetter) Then
                If _secretWord(index) = givenLetter Then
                    Return LetterStatus.GoodPosition
                Else
                    Return LetterStatus.Present
                End If
            Else
                Return LetterStatus.NotPresent
            End If
        End Function

        Public Function GetChooser() As String
            Return _chooser
        End Function

        Public Function GetGuesser() As String
            Return _guesser
        End Function

        Public Sub EndOfGame(time As Integer, winner As GameWinner)
            AddGameResult(_chooser, _guesser, winner, time)
        End Sub

        Public Function IsWordSecretWord(candidate As String) As Boolean
            Return _secretWord = candidate
        End Function
    End Class

    Structure Player
        Dim Name As String
        Dim Score As Integer
        Dim BestTimeToGuess As Integer
        Dim NumberOfGamesAsGuesser As Integer
        Dim NumberOfGamesAsChooser As Integer
        Dim TotalTimeGuessing As Integer

        Public Sub InitPlayer()
            Score = 0
            BestTimeToGuess = Nothing
            NumberOfGamesAsGuesser = 0
            NumberOfGamesAsChooser = 0
            TotalTimeGuessing = 0
        End Sub

        Public Function GetName() As String
            Return Name
        End Function

        Public Sub AddTime(newTimeToAdd As Integer, won As Boolean)
            TotalTimeGuessing += newTimeToAdd
            If BestTimeToGuess = Nothing OrElse (newTimeToAdd < BestTimeToGuess And won) Then
                BestTimeToGuess = newTimeToAdd
            End If
        End Sub

        Public Sub IncrementScore()
            Score += 1
        End Sub

        Public Sub IncrementNumberOfGamesAsGuesser()
            NumberOfGamesAsGuesser += 1
        End Sub

        Public Sub IncrementNumberOfGamesAsChooser()
            NumberOfGamesAsChooser += 1
        End Sub

        Public Overrides Function ToString() As String
            Dim stringRepresentation As String
            stringRepresentation = Name & " " & Score & " " &
                                   BestTimeToGuess & " " &
                                   NumberOfGamesAsGuesser & " " & NumberOfGamesAsChooser & " " &
                                   TotalTimeGuessing
            Return stringRepresentation
        End Function
    End Structure

    Public Function GetGame() As Game
        Return _currentGame
    End Function

    Public Sub SetNewGame(chooser As String, guesser As String, secretWord As String)
        _currentGame = New Game(chooser, guesser, secretWord)
    End Sub

    Private Sub AddGameResult(chooser As String, guesser As String, winner As GameWinner, time As Integer)
        If Not (DoesPlayerExist(chooser)) Then
            AddPlayer(chooser)
        End If
        If Not (DoesPlayerExist(guesser)) Then
            AddPlayer(guesser)
        End If
        _players(GetPlayerIndexFromName(chooser)).IncrementNumberOfGamesAsChooser()
        _players(GetPlayerIndexFromName(guesser)).IncrementNumberOfGamesAsGuesser()
        If winner Then
            _players(GetPlayerIndexFromName(guesser)).AddTime(time, True)
            _players(GetPlayerIndexFromName(guesser)).IncrementScore()
        Else
            _players(GetPlayerIndexFromName(guesser)).AddTime(time, False)
            _players(GetPlayerIndexFromName(chooser)).IncrementScore()
        End If
    End Sub

    Private Sub SaveStatsToFile()
        Dim fileNumber As Integer = FreeFile()
        FileOpen(fileNumber, _statsPath, OpenMode.Output)
        For Each player As Player In _players
            Print(fileNumber, player.ToString() & vbCrLf)
        Next
        FileClose(fileNumber)
    End Sub

    Private Sub LoadStatsFromFile()
        Dim fileNumber As Integer = FreeFile()
        Dim line As String
        Dim player As Player
        Dim playerStats() As String
        _statsPath = GetSavePathForStats()
        If Not File.Exists(_statsPath) Then
            _statsPath = DefaultStatsPath
            If Not File.Exists(_statsPath) Then
                Exit Sub
            End If
        End If
        FileOpen(fileNumber, _statsPath, OpenMode.Input)
        Try
            Do While Not EOF(fileNumber)
                line = LineInput(fileNumber)
                playerStats = Split(line, " ")
                player.Name = playerStats(0)
                player.Score = playerStats(1)
                player.BestTimeToGuess = playerStats(2)
                player.NumberOfGamesAsGuesser = playerStats(3)
                player.NumberOfGamesAsChooser = playerStats(4)
                player.TotalTimeGuessing = playerStats(5)
                ReDim Preserve _players(_players.Length)
                _players(_players.Length - 1) = player
            Loop
        Catch ex As Exception
            MsgBox("Erreur pendant le chargement du fichier des joueurs" & ex.Message)
            _players = Nothing
        End Try
        FileClose(fileNumber)
    End Sub

    Public Function GetPlayers() As Player()
        Return _players
    End Function

    Private Sub AddPlayer(playerName As String)
        If Not DoesPlayerExist(playerName) Then
            Dim newPlayer As Player
            newPlayer.Name = playerName
            newPlayer.InitPlayer()
            ReDim Preserve _players(_players.Length)
            _players(_players.Length - 1) = newPlayer
        End If
    End Sub

    Private Function DoesPlayerExist(playerName As String) As Boolean
        Return _players.Any(Function(player) player.Name.ToLower = playerName.ToLower)
    End Function

    Private Function GetPlayerIndexFromName(playerName As String) As Integer
        For i = 0 To _players.Length - 1
            If _players(i).GetName.ToLower = playerName.ToLower Then
                Return i
            End If
        Next
        Return - 1
    End Function

    Public Sub LoadPlayableCharsInto(ByRef targetLabel As Label)
        targetLabel.Text = GetPlayableCharacters()
    End Sub

    Sub Main()
        LoadSettings()
        LoadStatsFromFile()
        Application.Run(DebutForm)
        SaveStatsToFile()
    End Sub
End Module
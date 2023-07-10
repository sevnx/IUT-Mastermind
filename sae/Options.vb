Imports System.IO
Imports System.Text

Module Options
    Private Const FileName As String = "options.txt"
    Private Const DividerBetweenNameAndContent As Char = ":"
    Private Const PlayableCharacterName As String = "Caractères jouables"
    Private Const AbsentColorName As String = "Couleur quand caractère absent"
    Private Const PresentColorName As String = "Couleur quand caractère présent"
    Private Const GoodPositionColorName As String = "Couleur quand caractère bien placé"
    Private Const LimiteTempsName As String = "Limite de temps"
    Private Const NombrePropositionsName As String = "Limite de proposition"
    Private Const SavePathName As String = "Chemin vers save"

    Private _playableCharacters As String
    Private _absent As Color
    Private _present As Color
    Private _goodPosition As Color
    Private _time As Integer
    Private _numberOfPropositions As Integer
    Private _savePathForStats As String

    Public Sub SetPlayableCharacters(chars As String)
        _playableCharacters = chars
    End Sub

    Public Sub SetAbsentColor(absentColor As Color)
        _absent = absentColor
    End Sub

    Public Sub SetPresentColor(presentColor As Color)
        _present = presentColor
    End Sub

    Public Sub SetGoodPositionColor(goodPositionColor As Color)
        _goodPosition = goodPositionColor
    End Sub

    Public Sub SetTime(time As Integer)
        _time = time
    End Sub

    Public Sub SetNumberOfPropositions(numberOfPropositions As Integer)
        _numberOfPropositions = numberOfPropositions
    End Sub

    Public Sub SetSavePathForStats(path As String)
        _savePathForStats = path
    End Sub

    Public Sub LoadSettings()
        If Not File.Exists(FileName) Then
            RestoreDefaultSettings()
            SaveSettings()
        End If
        Try
            Dim reader As New StreamReader(FileName, Encoding.UTF8)
            Dim line As String
            While Not reader.EndOfStream
                line = reader.ReadLine
                Dim parts() As String = line.Split(DividerBetweenNameAndContent)
                Select Case Trim(parts(0))
                    Case PlayableCharacterName
                        _playableCharacters = Trim(parts(1))
                    Case AbsentColorName
                        _absent = Color.FromArgb(parts(1))
                    Case PresentColorName
                        _present = Color.FromArgb(parts(1))
                    Case GoodPositionColorName
                        _goodPosition = Color.FromArgb(parts(1))
                    Case LimiteTempsName
                        _time = MinSecStringToTime(parts(1))
                    Case NombrePropositionsName
                        _numberOfPropositions = Trim(parts(1))
                    Case SavePathName
                        _savePathForStats = Trim(parts(1) & DividerBetweenNameAndContent & parts(2))
                End Select
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox("Erreur lors de la lecture du fichier de configuration : " & ex.Message)
            RestoreDefaultSettings()
        End Try
    End Sub

    Private Sub ClearSettingsFile()
        Dim num As Integer = FreeFile()
        FileOpen(num, FileName, OpenMode.Output)
        FileClose(num)
    End Sub

    Public Sub SaveSettings()
        ClearSettingsFile()
        Dim writer As New StreamWriter(FileName, OpenMode.Output, Encoding.UTF8)
        writer.WriteLine(GenerateOutput())
        writer.Close()
    End Sub

    Private Function GenerateOutput() As String
        Dim output = New StringBuilder()
        output.AppendLine("Options :")
        output.AppendLine(String.Join(" ", {PlayableCharacterName, DividerBetweenNameAndContent, _playableCharacters}))
        output.AppendLine(String.Join(" ", {AbsentColorName, DividerBetweenNameAndContent, _absent.ToArgb}))
        output.AppendLine(String.Join(" ", {PresentColorName, DividerBetweenNameAndContent, _present.ToArgb}))
        output.AppendLine(String.Join(" ", {GoodPositionColorName, DividerBetweenNameAndContent, _goodPosition.ToArgb}))
        output.AppendLine(String.Join(" ", {LimiteTempsName, DividerBetweenNameAndContent, TimeToMinSec(_time)}))
        output.AppendLine(String.Join(" ",{NombrePropositionsName, DividerBetweenNameAndContent,
                                       _numberOfPropositions.ToString()}))
        output.AppendLine(String.Join(" ", {SavePathName, DividerBetweenNameAndContent, _savePathForStats}))
        Return output.ToString()
    End Function

    Private Sub RestoreDefaultSettings()
        _playableCharacters = "#$%@£"
        _absent = Color.Black
        _present = Color.Blue
        _goodPosition = Color.Green
        _time = 90
        _numberOfPropositions = 15
        _savePathForStats = Application.StartupPath()
    End Sub

    Public Function GetFileName() As String
        Return FileName
    End Function

    Public Function GetPlayableCharacters() As String
        Return _playableCharacters
    End Function

    Public Function GetAbsentColor() As Color
        Return _absent
    End Function

    Public Function GetPresentColor() As Color
        Return _present
    End Function

    Public Function GetGoodPositionColor() As Color
        Return _goodPosition
    End Function

    Public Function GetTime() As Integer
        Return _time
    End Function

    Public Function GetMaxGuesses() As Integer
        Return _numberOfPropositions
    End Function

    Public Function GetSavePathForStats() As String
        Return _savePathForStats
    End Function
End Module

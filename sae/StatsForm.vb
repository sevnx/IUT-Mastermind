Imports System.ComponentModel

Public Class StatsForm
    Dim _nameSortStatus As SortingStatus = SortingStatus.NotSorted
    Dim _scoreSortStatus As SortingStatus = SortingStatus.NotSorted
    Dim _timeSortStatus As SortingStatus = SortingStatus.NotSorted

    Private Enum SortingStatus
        NotSorted = 0
        Ascending = 1
        Descending = 2
    End Enum

    Private Shared Sub IncrementSortStatus(ByRef status As SortingStatus)
        status += 1
        If status > SortingStatus.Descending Then
            status = SortingStatus.NotSorted
        End If
    End Sub

    Private Shared Function GetPlayerNames() As String()
        Dim players As New List(Of String)
        For Each selectedPlayer As Player In GetPlayers()
            players.Add(selectedPlayer.GetName())
        Next
        Return players.ToArray()
    End Function

    Private Sub DefaultSort()
        DataGrid_PlayerStats.Rows.Clear()
        For Each player As Player In GetPlayers()
            DataGrid_PlayerStats.Rows.Add(player.Name, player.Score, TimeToMinSecStringSeparatedByColon(player.BestTimeToGuess),
                                          player.NumberOfGamesAsGuesser, player.NumberOfGamesAsChooser,
                                          TimeToMinSecStringSeparatedByColon(player.TotalTimeGuessing))
        Next
    End Sub

    Private Sub TabScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cbx_PlayerInfo.Items.AddRange(GetPlayerNames())
        DefaultSort()
    End Sub

    Private Sub NameSort(sender As Object, e As EventArgs) Handles Btn_NameSort.Click
        Sorting(_nameSortStatus, 0)
        ChangeButtonBasedOnSort(Btn_NameSort, _nameSortStatus)
    End Sub

    Private Sub ScoreSort(sender As Object, e As EventArgs) Handles Btn_ScoreSort.Click
        Sorting(_scoreSortStatus, 1)
        ChangeButtonBasedOnSort(Btn_ScoreSort, _scoreSortStatus)
    End Sub

    Private Sub TimeSort(sender As Object, e As EventArgs) Handles Btn_TimeSort.Click
        Sorting(_timeSortStatus, 2)
        ChangeButtonBasedOnSort(Btn_TimeSort, _timeSortStatus)
    End Sub

    Private Sub Sorting(ByRef sorting As SortingStatus, column As Integer)
        IncrementSortStatus(sorting)
        If sorting = SortingStatus.NotSorted Then
            DefaultSort()
        ElseIf sorting = SortingStatus.Descending Then
            DataGrid_PlayerStats.Sort(DataGrid_PlayerStats.Columns(column),
                                      ListSortDirection.Descending)
        Else
            DataGrid_PlayerStats.Sort(DataGrid_PlayerStats.Columns(column),
                                      ListSortDirection.Ascending)
        End If
    End Sub

    Private Sub ResetButtonsText()
        Btn_NameSort.Text = "Tri Nom"
        Btn_ScoreSort.Text = "Tri Score"
        Btn_TimeSort.Text = "Tri Meilleur Temps"
    End Sub

    Private Sub ChangeButtonBasedOnSort(ByRef associatedButton As ButtonBase, status As SortingStatus)
        ResetButtonsText()
        If status = SortingStatus.Ascending Then
            associatedButton.Text &= " ▲"
        ElseIf status = SortingStatus.Descending Then
            associatedButton.Text &= " ▼"
        End If
    End Sub

    Private Sub BtnAccueil_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Close()
        DebutForm.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles Cbx_PlayerInfo.SelectedIndexChanged
        MsgBox(GetPlayerInfo(Cbx_PlayerInfo.SelectedIndex))
    End Sub

    Private Function GetPlayerInfo(playerIndex As Integer) As String
        Dim row As DataGridViewRow = DataGrid_PlayerStats.Rows(playerIndex)
        Return "Nom : " & row.Cells("Nom").Value.ToString & vbCrLf &
               "Score : " & row.Cells("Score").Value.ToString & vbCrLf &
               "Meilleur Temps : " & row.Cells("MeilleurTemps").Value.ToString & vbCrLf &
               "Nombre jeu devineur : " & row.Cells("NbDevineur").Value.ToString & vbCrLf &
               "Nombre jeu sélectionneur : " & row.Cells("NbSelect").Value.ToString & vbCrLf &
               "Temps total deviner : " & row.Cells("TempsTotal").Value.ToString & vbCrLf
    End Function

    Private Sub FormQuit(sender As Object, e As EventArgs) Handles Me.Closed
        Dispose()
        DebutForm.Show()
    End Sub
End Class
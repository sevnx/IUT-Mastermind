Imports System.Media

Module MusicPlayer
    Public Sub PlayWinningSound()
        Dim player As New SoundPlayer(My.Resources.soundwin)
        player.Play()
    End Sub

    Public Sub PlayPerfectSound()
        Dim player As New SoundPlayer(My.Resources.perfect)
        player.Play()
    End Sub

    Public Sub PlayFailSound()
        Dim player As New SoundPlayer(My.Resources.failed)
        player.Play()
    End Sub

    Public Sub PlayLosingSound()
        Dim player As New SoundPlayer(My.Resources.soundlose)
        player.Play()
    End Sub

    Public Sub PlayLookAtTheTimeSound()
        Dim player As New SoundPlayer(My.Resources.countdown)
        player.Play()
    End Sub

    Public Sub PlayBackgroundMusic()
        Dim player As New SoundPlayer(My.Resources.background)
        player.PlayLooping()
    End Sub

    Public Sub PlayMarseillaise()
        Dim player As New SoundPlayer(My.Resources.marseillaise)
        player.PlayLooping()
    End Sub
End Module

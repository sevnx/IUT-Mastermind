Module TimeTools
    Public Function TimeToMinSecLonger(time As Integer) As String
        Dim minutes As Integer = time/60
        Dim seconds As Integer = time Mod 60
        Return minutes.ToString() & " min " & seconds.ToString() & " sec"
    End Function

    Public Function MinSecToTime(min As Integer, sec As Integer) As Integer
        Return min*60 + sec
    End Function

    Public Function MinSecStringToTime(time As String) As Integer
        If time = "0" Then
            Return 0
        End If
        Dim parts() As String = time.Split("m")
        Dim min As Integer = parts(0)
        parts = parts(1).Split("s")
        Dim sec As Integer = parts(0)
        Return min*60 + sec
    End Function

    Public Function TimeToMinSec(time As Integer) As String
        Dim min As Integer = time\60
        Dim sec As Integer = time Mod 60
        If time > 0 Then
            Return min & "m" & sec & "s"
        Else
            Return "0"
        End If
    End Function

    Public Function TimeToMinSecStringSeparatedByColon(time As Integer) As String
        Dim min As Integer = time/60
        Dim sec As Integer = time Mod 60
        Return min.ToString("00") & ":" & sec.ToString("00")
    End Function
End Module

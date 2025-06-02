Public Class Form1

    Dim tracks As List(Of String) = New List(Of String) From {
        "C:\Users\marab\Downloads\Feels So Good.mp3",
        "C:\Users\marab\Downloads\OIIA Cat x Gangnam Style (PSY Remix).mp3",
        "C:\Users\marab\Downloads\rock4.mp3",
        "C:\Users\marab\Downloads\iloveyou.mp3",
        "C:\Users\marab\Downloads\Tell it to my heart.mp3",
        "C:\Users\marab\Downloads\Blue but u ii a i - yung kai.mp3",
        "C:\Users\marab\Downloads\godtier.mp3",
        "C:\Users\marab\Downloads\rock.mp3",
        "C:\Users\marab\Downloads\rock2.mp3",
        "C:\Users\marab\Downloads\rock3.mp3",
        "C:\Users\marab\Downloads\judas.mp3",
        "C:\Users\marab\Downloads\abracadabra.mp3"
    }
    Dim currentTrack As Integer = 0
    Dim isPlaying As Boolean = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Track.Text = ""

        btn_PlayPause.IconChar = FontAwesome.Sharp.IconChar.Play
        btn_Next.IconChar = FontAwesome.Sharp.IconChar.Forward
        btn_Previous.IconChar = FontAwesome.Sharp.IconChar.Backward

    End Sub
    Private Sub btn_PlayPause_Click(sender As Object, e As EventArgs) Handles btn_PlayPause.Click
        If Not isPlaying Then
            ' Play
            AxWindowsMediaPlayer1.URL = tracks(currentTrack)
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            AxWindowsMediaPlayer1.settings.volume = 100
            lbl_Track.Text = " " & (currentTrack + 1).ToString()
            btn_PlayPause.IconChar = FontAwesome.Sharp.IconChar.Pause
            isPlaying = True
        Else
            ' Pause
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            lbl_Track.Text = " " & (currentTrack + 1).ToString()
            btn_PlayPause.IconChar = FontAwesome.Sharp.IconChar.Play
            isPlaying = False
        End If
    End Sub


    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        If tracks.Count > 0 Then
            currentTrack = (currentTrack + 1) Mod tracks.Count
            AxWindowsMediaPlayer1.URL = tracks(currentTrack)
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            AxWindowsMediaPlayer1.settings.volume = 100
            lbl_Track.Text = " " & (currentTrack + 1).ToString()
            btn_PlayPause.IconChar = FontAwesome.Sharp.IconChar.Pause
            isPlaying = True
        End If
    End Sub
    Private Sub btn_Previous_Click(sender As Object, e As EventArgs) Handles btn_Previous.Click
        If tracks.Count > 0 Then
            currentTrack = (currentTrack - 1 + tracks.Count) Mod tracks.Count
            AxWindowsMediaPlayer1.URL = tracks(currentTrack)
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            AxWindowsMediaPlayer1.settings.volume = 100
            lbl_Track.Text = " " & (currentTrack + 1).ToString()
            btn_PlayPause.IconChar = FontAwesome.Sharp.IconChar.Pause
            isPlaying = True
        End If
    End Sub
End Class

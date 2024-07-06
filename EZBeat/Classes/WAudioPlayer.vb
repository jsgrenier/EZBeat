Imports System.IO
Imports System.Net
Imports System.Security.Policy
Imports AxWMPLib
Imports SoundCloudExplode
Imports SpotifyExplode
Imports SpotifyExplode.Search
Imports WMPLib
Imports YoutubeDLSharp
Imports YoutubeExplode
Imports YoutubeExplode.Exceptions
Imports YoutubeExplode.Videos
Imports YoutubeExplode.Videos.Streams


Public Class WAudioPlayer
    Public WithEvents audioplayer As WindowsMediaPlayer = New WindowsMediaPlayer
    Public Event PositionChange As EventHandler(Of PositionChangedEventArgs)
    Public Event OpenStateChange As EventHandler(Of _WMPOCXEvents_OpenStateChangeEvent)
    Private WithEvents positionTimer As Timer = New Timer()

    Public Sub New()
        positionTimer.Interval = 1000 ' Check position every second

    End Sub


    Public Async Sub StreamAudioFromYoutube(videoId As String)

        Try
            If audioplayer.playState = WMPPlayState.wmppsPlaying Then
                audioplayer.controls.stop()
            End If

            Dim youtube = New YoutubeClient()
            Dim streamManifest = Await youtube.Videos.Streams.GetManifestAsync(videoId)

            'For some reasons, GetMuxedStreams() will load the media faster
            Dim streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality


            If streamInfo IsNot Nothing Then
                PlayFile(streamInfo.Url)
            End If
        Catch ex As VideoUnplayableException
            Dim mss As New Guna.UI2.WinForms.Guna2MessageDialog()
            mss.Text = vbNewLine & "Media is unplayable. Try using another source."
            mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
            mss.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
            mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
            mss.Show()
        Catch ex As Exception
            Dim mss As New Guna.UI2.WinForms.Guna2MessageDialog()
            mss.Text = vbNewLine & ex.ToString()
            mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
            mss.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
            mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
            mss.Show()
        End Try
    End Sub


    Public Async Sub StreamAudioFromSoundCloud(songUrl As String)

        Try
            If audioplayer.playState = WMPPlayState.wmppsPlaying Then
                audioplayer.controls.stop()
            End If

            Dim soundcloud = New SoundCloudClient()
            Dim track = Await soundcloud.Tracks.GetAsync(songUrl)
            Dim VideoToPlay As String = Await soundcloud.Tracks.GetDownloadUrlAsync(track)

            If VideoToPlay.Length > 0 Then
                PlayFile(VideoToPlay)
            End If
        Catch ex As Exception
            Dim mss As New Guna.UI2.WinForms.Guna2MessageDialog()
            mss.Text = vbNewLine & ex.ToString()
            mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
            mss.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
            mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
            mss.Show()
        End Try
    End Sub

    Public Sub StreamAudioFromSpotify1(songUrl As String)
        PlayFile(songUrl)
    End Sub

    Public Async Sub StreamAudioFromSpotify(title As String, author As String)

        Try
            If audioplayer.playState = WMPPlayState.wmppsPlaying Then
                audioplayer.controls.stop()
            End If

            Dim spotify = New SpotifyToYoutube()
            Dim youtubeid = Await spotify.GetUrl(title & " ", author) 'spotify.Tracks.GetYoutubeIdAsync(songUrl)
            Dim youtube = New YoutubeClient()
            Dim streamManifest = Await youtube.Videos.Streams.GetManifestAsync(youtubeid)

            'Play between the two one is audio only and the other is video included
            'Dim streamInfo = streamManifest.GetAudioOnlyStreams.GetWithHighestBitrate

            Dim streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality


            'Dim track = Await spotify.Tracks.GetAsync(songUrl)
            'Dim VideoToPlay = Await spotify.Tracks.GetSpotifyDownloaderUrlAsync(songUrl)

            If streamInfo IsNot Nothing Then
                PlayFile(streamInfo.Url)
            End If
        Catch ex As VideoUnplayableException
            Dim mss As New Guna.UI2.WinForms.Guna2MessageDialog()
            mss.Text = vbNewLine & "Media is unplayable. Try using another source."
            mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
            mss.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
            mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
            mss.Show()
            'MsgBox("Video is unplayable")
        Catch ex As Exception
            Dim mss As New Guna.UI2.WinForms.Guna2MessageDialog()
            mss.Text = vbNewLine & ex.ToString()
            mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
            mss.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
            mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
            mss.Show()
        End Try
    End Sub

    Private Sub Audioplayer_PlayStateChange(NewState As Integer) Handles audioplayer.PlayStateChange
        Console.WriteLine(NewState)
        Select Case NewState
            Case WMPPlayState.wmppsPlaying
                positionTimer.Start()
                MainForm.Guna2PictureBox1.Visible = False
                MainForm.PlayBtn.Visible = False
                MainForm.PauseBtn.Visible = True
                MainForm.btnPlayPause.Icon = My.Resources.TaskPause
            Case WMPPlayState.wmppsStopped Or WMPPlayState.wmppsPaused
                positionTimer.Stop()

            Case WMPPlayState.wmppsBuffering
                MainForm.Guna2PictureBox1.Visible = True

            Case WMPPlayState.wmppsUndefined
                MainForm.Guna2PictureBox1.Visible = True

            Case WMPPlayState.wmppsReconnecting
                MainForm.Guna2PictureBox1.Visible = True

            Case WMPPlayState.wmppsTransitioning
                MainForm.Guna2PictureBox1.Visible = True
        End Select
    End Sub


    Private Sub PlayFile(ByVal url As String)
        audioplayer.URL = url
        audioplayer.controls.play()
    End Sub

    Private Sub PositionTimer_Tick(sender As Object, e As EventArgs) Handles positionTimer.Tick
        If audioplayer.playState <> WMPPlayState.wmppsPlaying Then
            positionTimer.Stop()
        Else
            RaiseEvent PositionChange(Me, New PositionChangedEventArgs(audioplayer.controls.currentPosition))
        End If
    End Sub
End Class


Public Class PositionChangedEventArgs
    Inherits EventArgs

    Public Property CurrentPosition As Double

    Public Sub New(currentPosition As Double)
        Me.CurrentPosition = currentPosition
    End Sub
End Class


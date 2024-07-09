Imports System.ComponentModel

Public Class SearchMenu

    Public Enum ButtonSelection
        None
        Youtube
        Soundcloud
        Spotify
    End Enum

    Private _selectedButton As ButtonSelection = ButtonSelection.None

    <Browsable(True), Category("Behavior")>
    Public Property SelectedButton As ButtonSelection
        Get
            Return _selectedButton
        End Get
        Set(value As ButtonSelection)
            _selectedButton = value
            Select Case _selectedButton
                Case ButtonSelection.Youtube
                    Youtube_Click(Nothing, Nothing)
                Case ButtonSelection.Soundcloud
                    Soundcloud_Click(Nothing, Nothing)
                Case ButtonSelection.Spotify
                    Spotify_Click(Nothing, Nothing)
            End Select
        End Set
    End Property

    Public Event YoutubeClick(sender As Object, e As EventArgs)
    Public Event SoundcloudClick(sender As Object, e As EventArgs)
    Public Event SpotifyClick(sender As Object, e As EventArgs)

    Private Sub Youtube_Click(sender As Object, e As EventArgs) Handles Panel1.Click, Label1.Click, Guna2Separator1.Click, PictureBox1.Click
        MainForm.SearchEngine = "Youtube"
        RaiseEvent YoutubeClick(sender, e)
        Label1.ForeColor = Color.FromArgb(138, 180, 248)
        Guna2Separator1.FillColor = Color.FromArgb(138, 180, 248)
        PictureBox1.Image = My.Resources.icons8_youtube_24_red


        Label2.ForeColor = Color.FromArgb(100, 104, 109)
        Guna2Separator2.FillColor = Color.Empty
        PictureBox2.Image = My.Resources.icons8_soundcloud_24

        Label3.ForeColor = Color.FromArgb(100, 104, 109)
        Guna2Separator3.FillColor = Color.Empty
        PictureBox3.Image = My.Resources.icons8_spotify_24_gray
    End Sub

    Private Sub Soundcloud_Click(sender As Object, e As EventArgs) Handles Panel2.Click, Label2.Click, Guna2Separator2.Click, PictureBox2.Click
        MainForm.SearchEngine = "Soundcloud"
        RaiseEvent SoundcloudClick(sender, e)
        Label2.ForeColor = Color.FromArgb(138, 180, 248)
        Guna2Separator2.FillColor = Color.FromArgb(138, 180, 248)
        PictureBox2.Image = My.Resources.icons8_soundcloud_24_orange


        Label1.ForeColor = Color.FromArgb(100, 104, 109)
        Guna2Separator1.FillColor = Color.Empty
        PictureBox1.Image = My.Resources.icons8_youtube_24

        Label3.ForeColor = Color.FromArgb(100, 104, 109)
        Guna2Separator3.FillColor = Color.Empty
        PictureBox3.Image = My.Resources.icons8_spotify_24_gray
    End Sub

    Private Sub Spotify_Click(sender As Object, e As EventArgs) Handles Panel3.Click, Label3.Click, Guna2Separator3.Click, PictureBox3.Click
        MainForm.SearchEngine = "Spotify"
        RaiseEvent SpotifyClick(sender, e)
        Label3.ForeColor = Color.FromArgb(138, 180, 248)
        Guna2Separator3.FillColor = Color.FromArgb(138, 180, 248)
        PictureBox3.Image = My.Resources.icons8_spotify_24


        Label1.ForeColor = Color.FromArgb(100, 104, 109)
        Guna2Separator1.FillColor = Color.Empty
        PictureBox1.Image = My.Resources.icons8_youtube_24

        Label2.ForeColor = Color.FromArgb(100, 104, 109)
        Guna2Separator2.FillColor = Color.Empty
        PictureBox2.Image = My.Resources.icons8_soundcloud_24
    End Sub

End Class

Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Net.Http
Imports EZBeat.SearchMenu
Imports Newtonsoft.Json.Linq
Imports SoundCloudExplode
Imports SoundCloudExplode.Search
Imports SoundCloudExplode.Common
Imports YouTubeApiSharp
Imports YoutubeDLSharp
Imports YoutubeDLSharp.Options
Imports System.IO
Imports System.Text
Imports SpotifyExplode
Imports SpotifyExplode.Tracks
Imports SpotifyExplode.Search
Imports SpotifyExplode.Common
Imports AngleSharp.Common
Imports System.Threading
Imports SpotifyExplode.Albums
Imports YoutubeExplode.Common
Imports YoutubeExplode
Imports Microsoft.WindowsAPICodePack.Taskbar

Public Class SearchForm

    Private url As String
    Private duration As String
    Private thumbnail As String
    Private title As String
    Private id As String
    Private author As String

    Private PB1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Private SuccessImg As PictureBox
    Private Status As Label
    Private Download As Guna.UI2.WinForms.Guna2Button
    Private cts As CancellationTokenSource = New CancellationTokenSource()

#Region "UserActions"
    Private Async Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox1.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Try
                Await PerformSearchQuery(Guna2TextBox1.Text)
            Catch ex As Exception
                Console.WriteLine(ex)
            End Try
        End If
    End Sub
    Private Sub Ctrl_PlayBtn_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Dim clickedControl As Control = DirectCast(sender, Control)
            Dim parentControl As Control = clickedControl

            While Not TypeOf parentControl Is TrackResultControl
                parentControl = parentControl.Parent
            End While

            Dim TrackResult As TrackResultControl = DirectCast(parentControl, TrackResultControl)

            Dim seconds As Double = TrackResult.DurationSeconds
            Dim timeSpan As TimeSpan = TimeSpan.FromSeconds(seconds)
            Dim result As String

            If timeSpan.Hours > 0 Then
                result = String.Format("{0}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds)
            Else
                result = String.Format("{0}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds)
            End If


            MainForm.TBDuration.Value = 0
            MainForm.TBDuration.Maximum = seconds
            MainForm.Label2.Text = result
            MainForm.Thumbnail.ImageLocation = TrackResult.ImgBox.ImageLocation
            MainForm.Title.Text = TrackResult.Title.Text
            MainForm.Author.Text = TrackResult.Author.Text

            MainForm.PlayBtn.Visible = False
            MainForm.PauseBtn.Visible = True


            MainForm.Panel1.Visible = True
            MainForm.MainPanel.BringToFront()
            MainForm.MainPanel.Focus()


            Select Case MainForm.SearchEngine
                Case "Youtube"
                    MainForm.player2.StreamAudioFromYoutube(TrackResult.Url.Text)

                Case "Soundcloud"
                    MainForm.player2.StreamAudioFromSoundCloud(TrackResult.Url.Text)

                Case "Spotify"
                    MainForm.player2.StreamAudioFromSpotify(TrackResult.Title.Text, TrackResult.Author.Text) 'TrackResult.Url.Text)

            End Select
        End If
    End Sub
    Private Sub Ctrl_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            Dim clickedControl As Control = DirectCast(sender, Control)
            Dim parentControl As Control = clickedControl

            While Not TypeOf parentControl Is TrackResultControl
                parentControl = parentControl.Parent
            End While
            Dim TrackResult As TrackResultControl = DirectCast(parentControl, TrackResultControl)


            url = TrackResult.Url.Text
            duration = TrackResult.DurationSeconds
            thumbnail = TrackResult.ImgBox.ImageLocation
            title = TrackResult.Title.Text
            author = TrackResult.Author.Text
            id = TrackResult.id

            PB1 = TrackResult.PB1
            SuccessImg = TrackResult.SuccessImg

            Download = TrackResult.DLBtn

            Dim screenPoint As Point = clickedControl.PointToScreen(e.Location)
            Dim formPoint As Point = Me.PointToClient(screenPoint)
            formPoint.X += 5 ' Adjust the X coordinate
            formPoint.Y += 5 ' Adjust the Y coordinate
            Guna2ContextMenuStrip1.Show(Me, formPoint)

        End If
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        Dim seconds As Double = duration
        Dim timeSpan As TimeSpan = TimeSpan.FromSeconds(seconds)
        Dim result As String

        If timeSpan.Hours > 0 Then
            result = String.Format("{0}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds)
        Else
            result = String.Format("{0}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds)
        End If


        MainForm.TBDuration.Value = 0
        MainForm.TBDuration.Maximum = duration
        MainForm.Label2.Text = result
        MainForm.Thumbnail.ImageLocation = thumbnail
        MainForm.Title.Text = title
        MainForm.Author.Text = author

        MainForm.PlayBtn.Visible = False
        MainForm.PauseBtn.Visible = True


        MainForm.Panel1.Visible = True
        MainForm.MainPanel.BringToFront()
        MainForm.MainPanel.Focus()

        Select Case MainForm.SearchEngine
            Case "Youtube"
                MainForm.player2.StreamAudioFromYoutube(url)

            Case "Soundcloud"
                MainForm.player2.StreamAudioFromSoundCloud(url)

            Case "Spotify"
                MainForm.player2.StreamAudioFromSpotify(title, author)

        End Select

    End Sub

    Private Async Sub SearchMenu1_YoutubeClick(sender As Object, e As EventArgs) Handles SearchMenu1.YoutubeClick
        MainForm.SearchEngine = "Youtube"
        Try
            Await PerformSearchQuery(Guna2TextBox1.Text)
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

    End Sub

    Private Async Sub SearchMenu1_SoundcloudClick(sender As Object, e As EventArgs) Handles SearchMenu1.SoundcloudClick
        MainForm.SearchEngine = "Soundcloud"
        Try
            Await PerformSearchQuery(Guna2TextBox1.Text)
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try


    End Sub

    Private Async Sub SearchMenu1_SpotifyClick(sender As Object, e As EventArgs) Handles SearchMenu1.SpotifyClick
        MainForm.SearchEngine = "Spotify"
        Try
            Await PerformSearchQuery(Guna2TextBox1.Text)
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MainForm.OpenChildFormContentPanel(New OpeningForm)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim settings As New Settings()
        settings.ShowDialog()
    End Sub

    Private Sub Guna2TextBox1_Enter(sender As Object, e As EventArgs) Handles Guna2TextBox1.Enter
        MainForm.textboxFocused = True
    End Sub

    Private Sub Guna2TextBox1_Leave(sender As Object, e As EventArgs) Handles Guna2TextBox1.Leave
        MainForm.textboxFocused = False
    End Sub

    Private Sub Guna2ContextMenuStrip1_Closed(sender As Object, e As ToolStripDropDownClosedEventArgs) Handles Guna2ContextMenuStrip1.Closed

        ' Check if the mouse is not over any of the controls in the FlowLayoutPanel
        For Each ctrl As TrackResultControl In FlowLayoutPanel1.Controls
            If Not ctrl.ClientRectangle.Contains(ctrl.PointToClient(Control.MousePosition)) Then
                ctrl.MainPanel.FillColor = Color.FromArgb(15, 15, 15)
                ctrl.ImgBox.BackColor = Color.FromArgb(15, 15, 15)
                ctrl.Title.BackColor = Color.FromArgb(15, 15, 15)
                ctrl.Author.BackColor = Color.FromArgb(15, 15, 15)
                ctrl.DurationLbl.BackColor = Color.FromArgb(15, 15, 15)
                ctrl.DLBtn.CustomImages.Image = My.Resources.icons8_download_24_dark
                ctrl.PB1.BackColor = Color.FromArgb(15, 15, 15)
            End If
        Next



    End Sub


    Private Async Function Spotify2Youtube(trackname As String, artist As String, ct As CancellationToken) As Task(Of String)
        Dim youtube As New YoutubeExplode.YoutubeClient()
        Dim results = Await youtube.Search.GetVideosAsync(trackname & artist).CollectAsync(1)
        ' Check if a cancellation has been requested
        ct.ThrowIfCancellationRequested()

        For Each result In results
            Try
                If TypeOf result Is YoutubeExplode.Search.VideoSearchResult Then
                    Dim track = DirectCast(result, YoutubeExplode.Search.VideoSearchResult)
                    Return track.Url
                End If
            Catch ex As OperationCanceledException
                ' The operation was cancelled. You can handle this case if needed.
                MsgBox(ex.ToString())
                Return Nothing
            Catch ex As Exception
                'Console.WriteLine(ex)
                Return Nothing
            End Try
        Next

        ' If no video was found
        Return Nothing
    End Function


    Private Async Sub DownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadToolStripMenuItem.Click
        Download.Visible = False
        Try
            If MainForm.SearchEngine = "Spotify" Then
                'Dim spotify = New SpotifyClient()
                'Dim youtubeid = Await spotify.Tracks.GetYoutubeIdAsync(id) 'spotify.Tracks.GetYoutubeIdAsync(id)
                'Dim youtube = New YoutubeClient()
                url = Await Spotify2Youtube(title & " ", author, cts.Token)
                'Console.WriteLine(Await SpotifyDL(title, author, cts.Token))
            End If

            Dim ytdl = New YoutubeDL()
            ytdl.YoutubeDLPath = "yt-dlp.exe"
            'ytdl.FFmpegPath = "ffmpeg.exe"
            ytdl.OutputFolder = My.Settings.SaveLocation
            PB1.Visible = True
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal)

            Dim progressHandler = New Progress(Of DownloadProgress)(Sub(p)
                                                                        PB1.Value = CInt(p.Progress * 100)
                                                                        TaskbarManager.Instance.SetProgressValue(CInt(p.Progress * 100), 100)
                                                                        Select Case p.State
                                                                            Case 1
                                                                            'Status.Text = "Requesting download..."
                                                                            Case 2
                                                                            'Status.Text = "Downloading..."
                                                                            Case 3
                                                                            'Status.Text = "Finalizing..."
                                                                            Case 5
                                                                                'Status.Text = ""
                                                                        End Select
                                                                        'Status.Text = p.State '$"Downloading... {p.Progress * 100}%"
                                                                    End Sub)

            ' Pass the progress handler to the RunAudioDownload method
            Select Case My.Settings.AudioFormat
                Case "WAV"
                    Dim res = Await ytdl.RunAudioDownload(url, AudioConversionFormat.Wav, progress:=progressHandler)
                Case "AAC"
                    Dim res = Await ytdl.RunAudioDownload(url, AudioConversionFormat.Aac, progress:=progressHandler)
                Case "MP3"
                    Dim res = Await ytdl.RunAudioDownload(url, AudioConversionFormat.Mp3, progress:=progressHandler)
            End Select

            PB1.Visible = False
            SuccessImg.Visible = True
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress)
        Catch ex As Exception
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error)
        End Try
    End Sub
    Private Sub Ctrl_MouseLeftControl(sender As Object, e As EventArgs)
        ' Check if the context menu is not open
        If Not Guna2ContextMenuStrip1.Visible Then
            Dim ctrl As TrackResultControl = DirectCast(sender, TrackResultControl)
            ctrl.MainPanel.FillColor = Color.FromArgb(15, 15, 15)
            ctrl.ImgBox.BackColor = Color.FromArgb(15, 15, 15)
            ctrl.Title.BackColor = Color.FromArgb(15, 15, 15)
            ctrl.Author.BackColor = Color.FromArgb(15, 15, 15)
            ctrl.DurationLbl.BackColor = Color.FromArgb(15, 15, 15)
            ctrl.DLBtn.CustomImages.Image = My.Resources.icons8_download_24_dark
            ctrl.PB1.BackColor = Color.FromArgb(15, 15, 15)
        End If
    End Sub
#End Region

#Region "Queries"

    Private Async Function PerformSearchQuery(query As String) As Task
        ' Cancel the previous task
        cts.Cancel()

        ' Create a new CancellationTokenSource
        cts = New CancellationTokenSource()

        Try
            Select Case MainForm.SearchEngine
                Case "Youtube"
                    DotScaling1.Visible = True
                    FlowLayoutPanel1.Controls.Clear()
                    Await SearchYT(query, cts.Token)

                Case "Soundcloud"
                    DotScaling1.Visible = True
                    FlowLayoutPanel1.Controls.Clear()
                    Await SearchSC(query, cts.Token)

                Case "Spotify"
                    DotScaling1.Visible = True
                    FlowLayoutPanel1.Controls.Clear()
                    Await SearchSP(query, cts.Token)
            End Select
        Catch ex As OperationCanceledException
            ' The task was cancelled
        End Try
    End Function




    Private Async Function SearchYT(query As String, ct As CancellationToken) As Task
        Dim youtube As New YoutubeExplode.YoutubeClient()
        Dim results = Await youtube.Search.GetVideosAsync(query).CollectAsync(CInt(CBBox2.Text))
        ' Check if a cancellation has been requested
        ct.ThrowIfCancellationRequested()
        For Each result In results
            Try
                If TypeOf result Is YoutubeExplode.Search.VideoSearchResult Then
                    Dim track = DirectCast(result, YoutubeExplode.Search.VideoSearchResult)
                    Dim id = track.Id
                    Dim title = track.Title
                    Dim duration = track.Duration
                    Dim url = track.Url
                    Dim artist = track.Author
                    Dim img = track.Thumbnails.Last.Url
                    Dim Ctrl As New TrackResultControl()
                    AddHandler Ctrl.MouseDown, AddressOf Ctrl_MouseDown
                    AddHandler Ctrl.Title.MouseDown, AddressOf Ctrl_MouseDown
                    AddHandler Ctrl.Author.MouseDown, AddressOf Ctrl_MouseDown
                    AddHandler Ctrl.MainPanel.MouseDown, AddressOf Ctrl_MouseDown
                    AddHandler Ctrl.DurationLbl.MouseDown, AddressOf Ctrl_MouseDown
                    AddHandler Ctrl.PlayBtn.MouseDown, AddressOf Ctrl_PlayBtn_MouseDown
                    AddHandler Ctrl.MouseLeftControl, AddressOf Ctrl_MouseLeftControl
                    AddHandler Ctrl.DLBtn.MouseDown, AddressOf Ctrl_DL_MouseDown
                    Ctrl.URI = track.Url
                    FlowLayoutPanel1.Controls.Add(Ctrl)
                    DotScaling1.Visible = False
                    Ctrl.Title.Text = title
                    Ctrl.Url.Text = url
                    Ctrl.id = id
                    Ctrl.Author.Text = artist.ChannelTitle
                    Ctrl.ImgBox.ImageLocation = img
                    Ctrl.DurationSeconds = duration.Value.TotalSeconds

                    Dim timeSpan As TimeSpan = TimeSpan.FromSeconds(duration.Value.TotalSeconds)
                    Dim resultstr As String

                    If timeSpan.Hours > 0 Then
                        resultstr = String.Format("{0}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds)
                    Else
                        resultstr = String.Format("{0}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds)
                    End If
                    Ctrl.DurationLbl.Text = resultstr
                End If
            Catch ex As OperationCanceledException
                ' The operation was cancelled. You can handle this case if needed.
                MsgBox(ex.ToString())
            Catch ex As Exception
                Dim lbl As New Label()
                FlowLayoutPanel1.Controls.Add(lbl)
                DotScaling1.Visible = False
                lbl.Text = ex.Message
                'Console.WriteLine(ex)
            End Try
        Next
    End Function



    Private Async Function SearchSC(query As String, ct As CancellationToken) As Task
        Dim soundcloud As New SoundCloudClient()
        Dim results = Await soundcloud.Search.GetTracksAsync(query).CollectAsync(CInt(CBBox2.Text))
        ' Check if a cancellation has been requested
        ct.ThrowIfCancellationRequested()
        For Each result In results
            Try


                If TypeOf result Is SoundCloudExplode.Search.TrackSearchResult Then
                    Dim track = DirectCast(result, SoundCloudExplode.Search.TrackSearchResult)
                    Dim id = track.Id

                    Dim title = If(track.Title, String.Empty)
                    Dim img = If(track.ArtworkUrl, "https://www.gravatar.com/avatar/7771a96494d732c4e34f6895879eebf7?size=192&d=mm")
                    Dim author = If(track.User.Username, String.Empty)
                    Dim Url = If(track.Url, String.Empty)
                    Dim duration As String = If(track.Duration, String.Empty)
                    'Console.WriteLine(title)
                    Dim Ctrl As New TrackResultControl()
                    Ctrl.URI = If(track.Url, String.Empty)
                    AddHandler Ctrl.MouseDown, AddressOf Ctrl_MouseDown
                    AddHandler Ctrl.Title.MouseDown, AddressOf Ctrl_MouseDown
                    AddHandler Ctrl.Author.MouseDown, AddressOf Ctrl_MouseDown
                    AddHandler Ctrl.MainPanel.MouseDown, AddressOf Ctrl_MouseDown
                    AddHandler Ctrl.DurationLbl.MouseDown, AddressOf Ctrl_MouseDown
                    AddHandler Ctrl.PlayBtn.MouseDown, AddressOf Ctrl_PlayBtn_MouseDown
                    AddHandler Ctrl.MouseLeftControl, AddressOf Ctrl_MouseLeftControl
                    AddHandler Ctrl.DLBtn.MouseDown, AddressOf Ctrl_DL_MouseDown
                    If CBBox1.SelectedIndex = 1 Then
                        ' Remove special characters from artist and query
                        Dim sanitizedArtist As String = System.Text.RegularExpressions.Regex.Replace(author, "[^a-zA-Z0-9]", String.Empty)
                        Dim sanitizedQuery As String = System.Text.RegularExpressions.Regex.Replace(query, "[^a-zA-Z0-9]", String.Empty)

                        ' Compare sanitized strings
                        If String.Compare(sanitizedArtist.ToLower(), sanitizedQuery.ToLower()) <> 0 Then
                            Continue For
                        End If
                    End If

                    FlowLayoutPanel1.Controls.Add(Ctrl)
                    DotScaling1.Visible = False
                    Ctrl.Title.Text = title
                    Ctrl.Author.Text = author
                    Ctrl.Url.Text = Url
                    Ctrl.ImgBox.ImageLocation = img.ToString()
                    If duration Is Nothing Then
                        Ctrl.DurationLbl.Text = "Null"
                    Else
                        Dim dr As String = duration / 1000
                        Ctrl.DurationSeconds = Math.Round(CDec(dr), 0) 'dr.Remove(dr.Length - 3)
                        Dim timeSpan As TimeSpan = TimeSpan.FromSeconds(dr.Remove(dr.Length - 3))
                        Dim resultstr As String

                        If timeSpan.Hours > 0 Then
                            If timeSpan.Hours >= 10 Then
                                resultstr = timeSpan.ToString()
                            Else
                                resultstr = timeSpan.ToString().Remove(0, 1)
                            End If
                            'resultstr = String.Format("{0}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds)
                        Else
                            If timeSpan.Minutes >= 10 Then '00:00:00
                                resultstr = timeSpan.ToString().Remove(0, 3)
                            Else
                                resultstr = timeSpan.ToString().Remove(0, 4)
                            End If

                            'resultstr = String.Format("{0}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds)
                        End If

                        'Ctrl.DurationLbl.Text = resultstr 'Math.Round(CDec(dr), 0)
                        Ctrl.DurationLbl.Text = resultstr
                    End If

                End If
            Catch ex As OperationCanceledException
                MsgBox(ex.ToString())
            Catch ex As ArgumentOutOfRangeException
                Console.WriteLine(ex.Message)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                MsgBox(ex.Message)

            End Try
        Next
    End Function

    Private Async Function SearchSP(query As String, ct As CancellationToken) As Task
        Dim spotify As New SpotifyClient()
        ct.ThrowIfCancellationRequested()
        Try
            For Each result In (Await spotify.Search.GetResultsAsync(query)).Take(CInt(CBBox2.Text))

                ' Use pattern matching to handle different results (albums, artists, tracks, playlists)
                Select Case result.GetType()
                    Case GetType(SpotifyExplode.Search.TrackSearchResult)
                        Dim track As SpotifyExplode.Search.TrackSearchResult = DirectCast(result, SpotifyExplode.Search.TrackSearchResult)
                        Dim id = track.Id
                        Dim title = track.Title
                        Dim duration = track.DurationMs
                        Dim url = track.Url
                        Dim artists = track.Artists.ToList()
                        Dim album = track.Album
                        Dim ctrl As New TrackResultControl()
                        AddHandler ctrl.MouseDown, AddressOf Ctrl_MouseDown
                        AddHandler ctrl.Title.MouseDown, AddressOf Ctrl_MouseDown
                        AddHandler ctrl.Author.MouseDown, AddressOf Ctrl_MouseDown
                        AddHandler ctrl.MainPanel.MouseDown, AddressOf Ctrl_MouseDown
                        AddHandler ctrl.DurationLbl.MouseDown, AddressOf Ctrl_MouseDown
                        AddHandler ctrl.PlayBtn.MouseDown, AddressOf Ctrl_PlayBtn_MouseDown
                        AddHandler ctrl.MouseLeftControl, AddressOf Ctrl_MouseLeftControl
                        AddHandler ctrl.DLBtn.MouseDown, AddressOf Ctrl_DL_MouseDown
                        If CBBox1.SelectedIndex = 1 Then 'If Guna2CheckBox1.Checked = True Then
                            Dim artistMatch As Boolean = False
                            For Each artist In artists
                                If String.Equals(artist.Name, query, StringComparison.OrdinalIgnoreCase) Then
                                    artistMatch = True
                                    Exit For
                                End If
                            Next
                            If Not artistMatch Then
                                Continue For
                            End If
                        End If
                        FlowLayoutPanel1.Controls.Add(ctrl)

                        DotScaling1.Visible = False
                        ctrl.Title.Text = title
                        ctrl.Url.Text = url
                        ctrl.id = id

                        Dim dr As String = duration
                        ctrl.DurationSeconds = dr.Remove(dr.Length - 3)
                        Dim timeSpan As TimeSpan = TimeSpan.FromSeconds(dr.Remove(dr.Length - 3))
                        Dim resultstr As String

                        If timeSpan.Hours > 0 Then
                            resultstr = String.Format("{0}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds)
                        Else
                            resultstr = String.Format("{0}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds)
                        End If
                        ctrl.DurationLbl.Text = resultstr

                        For i = 0 To artists.Count - 1
                            ctrl.Author.Text += (artists(i).Name & "$%#").Replace("$%#", ", ")
                        Next
                        ctrl.ImgBox.ImageLocation = album.Images(0).Url
                        Dim lastIndex As Integer = ctrl.Author.Text.LastIndexOf(", ")
                        If lastIndex >= 0 Then
                            ctrl.Author.Text = ctrl.Author.Text.Remove(lastIndex, 2)
                        End If


                End Select
            Next

        Catch ex As OperationCanceledException
            MsgBox(ex.ToString())
        Catch ex As Exception

            Dim lbl As New ResultError()
            FlowLayoutPanel1.Controls.Add(lbl)
            DotScaling1.Visible = False
            Console.WriteLine(ex.Message.ToString())
        End Try
    End Function

    Private Async Sub Ctrl_DL_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Dim spotify As New SpotifyToYoutube()
            Dim clickedControl As Control = DirectCast(sender, Control)
            Dim parentControl As TrackResultControl = clickedControl.Parent.Parent
            parentControl.DLBtn.Visible = False
            Try
                If MainForm.SearchEngine = "Spotify" Then
                    url = Await Spotify2Youtube(parentControl.Title.Text & " ", parentControl.Author.Text, cts.Token)
                Else
                    url = parentControl.URI
                End If

                Dim ytdl = New YoutubeDL()
                ytdl.YoutubeDLPath = "yt-dlp.exe"
                'ytdl.FFmpegPath = "ffmpeg.exe"
                ytdl.OutputFolder = My.Settings.SaveLocation

                parentControl.PB1.Visible = True
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal)

                Dim progressHandler = New Progress(Of DownloadProgress)(Sub(p)
                                                                            parentControl.PB1.Value = CInt(p.Progress * 100)
                                                                            TaskbarManager.Instance.SetProgressValue(CInt(p.Progress * 100), 100)
                                                                            Select Case p.State
                                                                                Case 1
                                                                                'Status.Text = "Requesting download..."
                                                                                Case 2
                                                                                'Status.Text = "Downloading..."
                                                                                Case 3
                                                                                'Status.Text = "Finalizing..."
                                                                                Case 5
                                                                                    'Status.Text = ""
                                                                            End Select
                                                                            'Status.Text = p.State '$"Downloading... {p.Progress * 100}%"
                                                                        End Sub)

                ' Pass the progress handler to the RunAudioDownload method
                Select Case My.Settings.AudioFormat
                    Case "WAV"
                        Dim res = Await ytdl.RunAudioDownload(url, AudioConversionFormat.Wav, progress:=progressHandler)
                    Case "AAC"
                        Dim res = Await ytdl.RunAudioDownload(url, AudioConversionFormat.Aac, progress:=progressHandler)
                    Case "MP3"
                        Dim res = Await ytdl.RunAudioDownload(url, AudioConversionFormat.Mp3, progress:=progressHandler)
                End Select

                parentControl.PB1.Visible = False
                parentControl.SuccessImg.Visible = True
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress)
            Catch ex As Exception
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error)
            End Try
        End If
    End Sub



#End Region

#Region "Other"
    Function FormatNumber(ByVal num As Double) As String
        If num >= 1000000 Then
            Return (num / 1000000).ToString("0.#") & "M"
        ElseIf num >= 1000 Then
            Return (num / 1000).ToString("0.#") & "K"
        Else
            Return num.ToString()
        End If
    End Function

    Function GetDescriptionText(json As String) As String
        Dim jArray As JArray = JArray.Parse(json)
        Dim textValues As List(Of String) = New List(Of String)

        For Each jObject As JObject In jArray
            textValues.Add(jObject("text").ToString())
        Next

        Return String.Join("", textValues)
    End Function
#End Region






    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBBox1.SelectedIndex = MainForm.CategorieSelectedIndex
        CBBox2.SelectedIndex = MainForm.CountSelectedIndex
        DotScaling1.Start()
        Guna2TextBox1.Text = MainForm.SearchQuery
        Select Case MainForm.SearchEngine
            Case "Youtube"
                SearchMenu1.SelectedButton = ButtonSelection.Youtube
            Case "Soundcloud"
                SearchMenu1.SelectedButton = ButtonSelection.Soundcloud
            Case "Spotify"
                SearchMenu1.SelectedButton = ButtonSelection.Spotify
        End Select

    End Sub

End Class
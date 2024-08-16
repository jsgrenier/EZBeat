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
Imports Guna.UI2.WinForms
Imports TagLib

Public Class SearchForm

    Private url As String
    Private duration As String
    Private thumbnail As String
    Private title As String
    Private id As String
    Private author As String

    Private PB1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Private WithEvents SuccessImg As PictureBox
    Private Status As Label
    Private Download As Guna.UI2.WinForms.Guna2Button
    Private cts As CancellationTokenSource = New CancellationTokenSource()
    Public WithEvents ctxTrack As New TrackCtxMenu()
    Public WithEvents ctxArtist As New CtxTrackArtist()
    Public WithEvents ctxCount As New CtxCount()
    Private WithEvents settings As New SettingsCtrl()

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
            TrackResult.Focus()

            url = TrackResult.Url.Text
            duration = TrackResult.DurationSeconds
            thumbnail = TrackResult.ImgBox.ImageLocation
            title = TrackResult.Title.Text
            author = TrackResult.Author.Text
            id = TrackResult.id

            PB1 = TrackResult.PB1
            SuccessImg = TrackResult.SuccessImg

            Download = TrackResult.DLBtn

        End If
    End Sub

    Private Sub CtrlRightClick(sender As Object, e As MouseEventArgs)
        Dim ctrl As Control = DirectCast(sender, Control)
        Dim newpos As Point = ctrl.PointToClient(Control.MousePosition)



        ' Convert the mouse position to client coordinates
        Dim mousePos As Point = PointToClient(Cursor.Position)

        ' Calculate the position to ensure the ctxControl stays within bounds
        Dim x As Integer = mousePos.X
        Dim y As Integer = mousePos.Y

        ' Adjust the X coordinate if necessary
        If x + ctxTrack.Width > ClientSize.Width Then
            x = ClientSize.Width - ctxTrack.Width
        End If

        ' Adjust the Y coordinate if necessary
        If y + ctxTrack.Height > ClientSize.Height Then
            y = ClientSize.Height - ctxTrack.Height
        End If

        ' Set the location of the ctxControl
        ctxTrack.Location = New Point(x, y)

        ' Show the ctxControl
        ctxTrack.BringToFront()
        Guna2Transition1.ShowSync(ctxTrack, True, Guna.UI2.AnimatorNS.Animation.Transparent)
        'ctxTrack.Visible = True
    End Sub

    Private Sub Control2_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Dim ctrl As Control = TryCast(sender, Control)
        If ctrl IsNot ctxTrack Then
            ctxTrack.Visible = False
        End If
        If ctrl IsNot CBBox1 Then
            CBBox1.Checked = False
        End If

        If ctrl IsNot CBBox2 Then
            CBBox2.Checked = False
        End If

        If Not IsChildOf(ctrl, Settings) Then
            Settings.Visible = False
        End If
    End Sub
    Private Function IsChildOf(child As Control, parent As Control) As Boolean
        While child IsNot Nothing
            If child Is parent Then
                Return True
            End If
            child = child.Parent
        End While
        Return False
    End Function

    Private Sub AddMouseDownEventHandlers(parentControl As Control)
        ' Recursively attach the event handler to this control and its children
        For Each ctrl As Control In parentControl.Controls
            AddHandler ctrl.MouseDown, AddressOf Control2_MouseClick
            ' Recursively attach to children controls
            If ctrl.HasChildren Then
                AddMouseDownEventHandlers(ctrl)
            End If
        Next
    End Sub

    Private Sub FlowLayoutPanel1_ControlAdded(sender As Object, e As ControlEventArgs) Handles FlowLayoutPanel1.ControlAdded
        ' Attach the MouseDown event handler to the newly added control
        AddHandler e.Control.MouseDown, AddressOf Control2_MouseClick

        ' If the new control can contain other controls, attach to its children as well
        If e.Control.HasChildren Then
            AddMouseDownEventHandlers(e.Control)
        End If
    End Sub

    Private Sub CtxTrackPlay_Click(sender As Object, e As EventArgs) Handles ctxTrack.PlayClicked
        ctxTrack.Visible = False

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

    Private Async Sub CtxTrackDL_Click(sender As Object, e As EventArgs) Handles ctxTrack.DLClicked
        'ctxTrack.Visible = False
        Download.Visible = False
        Dim filepath As String = String.Empty

        Try
            If MainForm.SearchEngine = "Spotify" Then
                url = Await Spotify2Youtube(title & " ", author, cts.Token)
            End If

            Dim ytdl = New YoutubeDL()
            ytdl.YoutubeDLPath = "yt-dlp.exe"
            ytdl.FFmpegPath = "ffmpeg.exe"
            ytdl.OutputFolder = My.Settings.SaveLocation
            ytdl.OutputFileTemplate = "%(title)s [%(uploader)s].%(ext)s"

            PB1.Visible = True
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal)

            Dim progressHandler = New Progress(Of DownloadProgress)(Sub(p)
                                                                        SuccessImg.Visible = False
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
                                                                                'PB1.Visible = False
                                                                                SuccessImg.Visible = True
                                                                                'Status.Text = ""
                                                                        End Select
                                                                        'Status.Text = p.State '$"Downloading... {p.Progress * 100}%"
                                                                    End Sub)

            ' Pass the progress handler to the RunAudioDownload method
            Select Case My.Settings.AudioFormat
                Case "WAV"
                    Dim res = Await ytdl.RunAudioDownload(url, AudioConversionFormat.Wav, progress:=progressHandler)
                    filepath = res.Data
                Case "AAC"
                    Dim res = Await ytdl.RunAudioDownload(url, AudioConversionFormat.Aac, progress:=progressHandler)
                    filepath = res.Data
                Case "MP3"
                    Dim res = Await ytdl.RunAudioDownload(url, AudioConversionFormat.Mp3, progress:=progressHandler)
                    filepath = res.Data
            End Select

            'PB1.Visible = False
            'SuccessImg.Visible = True
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress)
        Catch ex As Exception
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error)
            Console.WriteLine("Download Error: " & ex.Message)
            Return
        End Try

        Try
            Using file As TagLib.File = TagLib.File.Create(filepath)
                Select Case My.Settings.AudioFormat
                    Case "WAV"
                        ' Ensure RIFF INFO tags are used for WAV files
                        If TypeOf file Is TagLib.Riff.File Then
                            Dim wavFile = CType(file, TagLib.Riff.File)
                            wavFile.Tag.Title = title
                            wavFile.Tag.Performers = New String() {author}
                            wavFile.Tag.AlbumArtists = New String() {author}
                            wavFile.Save()
                        End If
                    Case "MP3"
                        If TypeOf file Is TagLib.Mpeg.AudioFile Then
                            Dim mp3File = CType(file, TagLib.Mpeg.AudioFile)
                            mp3File.Tag.Title = title
                            mp3File.Tag.Performers = New String() {author}
                            mp3File.Tag.AlbumArtists = New String() {author}
                            mp3File.Save()
                        End If
                    Case "AAC"
                        ' Ensure MP4 tags are used for AAC files
                        If TypeOf file Is TagLib.Mpeg4.File Then
                            Dim aacFile = CType(file, TagLib.Mpeg4.File)
                            aacFile.Tag.Title = title
                            aacFile.Tag.Performers = New String() {author}
                            aacFile.Tag.AlbumArtists = New String() {author}
                            aacFile.Save()
                        End If
                End Select
            End Using
        Catch ex As Exception
            MsgBox("TagLib Error: " & ex.Message)
        End Try
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

    Private Sub CenterControl(ctrl As Control)
        ' Calculate the center position
        Dim centerX As Integer = (Me.ClientSize.Width - ctrl.Width) \ 2
        Dim centerY As Integer = (Me.ClientSize.Height - ctrl.Height) \ 2

        ' Set the control's position
        ctrl.Left = centerX
        ctrl.Top = centerY
    End Sub

    Private Sub Guna2Button2_MouseClick(sender As Object, e As MouseEventArgs) Handles Guna2Button2.MouseClick
        If e.Button = MouseButtons.Left Then
            settings.BringToFront()
            CenterControl(settings)
            settings.Location = New Point(settings.Location.X, 112)
            settings.Visible = True
        End If
    End Sub

    Private Sub XClicked(sender As Object, e As EventArgs) Handles settings.XClicked
        settings.Visible = False
    End Sub

    Private Sub Guna2TextBox1_Enter(sender As Object, e As EventArgs) Handles Guna2TextBox1.Enter
        MainForm.textboxFocused = True
    End Sub

    Private Sub Guna2TextBox1_Leave(sender As Object, e As EventArgs) Handles Guna2TextBox1.Leave
        MainForm.textboxFocused = False
    End Sub

    Private Sub Guna2ContextMenuStrip1_Closed(sender As Object, e As EventArgs) Handles ctxTrack.VisibleChanged
        If ctxTrack.Visible = False Then
            ' Check if the mouse is not over any of the controls in the FlowLayoutPanel
            For Each ctrl As TrackResultControl In FlowLayoutPanel1.Controls
                If Not ctrl.ClientRectangle.Contains(ctrl.PointToClient(Control.MousePosition)) Then
                    ctrl.MainPanel.FillColor = Color.FromArgb(30, 31, 34)
                    ctrl.ImgBox.BackColor = Color.FromArgb(30, 31, 34)
                    ctrl.Title.BackColor = Color.FromArgb(30, 31, 34)
                    ctrl.Author.BackColor = Color.FromArgb(30, 31, 34)
                    ctrl.DurationLbl.BackColor = Color.FromArgb(30, 31, 34)
                    ctrl.DLBtn.CustomImages.Image = My.Resources.icons8_download_24_dark
                    ctrl.PB1.BackColor = Color.FromArgb(30, 31, 34)
                    ctrl.MainPanel.BorderThickness = 0
                End If
            Next
        End If




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
                Return Nothing
            End Try
        Next

        ' If no video was found
        Return Nothing
    End Function

    Private Sub Ctrl_MouseLeftControl(sender As Object, e As EventArgs)
        ' Check if the context menu is not open
        If Not ctxTrack.Visible Then
            Dim ctrl As TrackResultControl = DirectCast(sender, TrackResultControl)
            ctrl.MainPanel.FillColor = Color.FromArgb(30, 31, 34)
            ctrl.ImgBox.BackColor = Color.FromArgb(30, 31, 34)
            ctrl.Title.BackColor = Color.FromArgb(30, 31, 34)
            ctrl.Author.BackColor = Color.FromArgb(30, 31, 34)
            ctrl.DurationLbl.BackColor = Color.FromArgb(30, 31, 34)
            ctrl.DLBtn.CustomImages.Image = My.Resources.icons8_download_24_dark
            ctrl.PB1.BackColor = Color.FromArgb(30, 31, 34)
            ctrl.MainPanel.BorderThickness = 0
        End If
    End Sub

    Private Sub Ctrl_MouseEnterControl(sender As Object, e As EventArgs)
        ' Check if the context menu is not open
        If Not ctxTrack.Visible Then
            Dim ctrl As TrackResultControl = DirectCast(sender, TrackResultControl)
            ctrl.MainPanel.FillColor = Color.FromArgb(45, 46, 49)
            ctrl.ImgBox.BackColor = Color.FromArgb(45, 46, 49)
            ctrl.Title.BackColor = Color.FromArgb(45, 46, 49)
            ctrl.Author.BackColor = Color.FromArgb(45, 46, 49)
            ctrl.DurationLbl.BackColor = Color.FromArgb(45, 46, 49)
            ctrl.DLBtn.CustomImages.Image = My.Resources.icons8_download_24
            ctrl.PB1.BackColor = Color.FromArgb(45, 46, 49)
            ctrl.MainPanel.BorderThickness = 1
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

        Dim trackResults As New List(Of YoutubeExplode.Search.VideoSearchResult)()

        For Each result In results
            If TypeOf result Is YoutubeExplode.Search.VideoSearchResult Then
                trackResults.Add(DirectCast(result, YoutubeExplode.Search.VideoSearchResult))
            End If
        Next

        If trackResults.Count = CInt(CBBox2.Text) Then
            ' Create an array to hold the controls
            Dim controlArray(CInt(CBBox2.Text) - 1) As TrackResultControl

            ' Populate the array with controls
            For i As Integer = 0 To controlArray.Length - 1
                Dim track = trackResults(i)
                Dim Ctrl As New TrackResultControl()
                AddHandler Ctrl.MouseDown, AddressOf Ctrl_MouseDown
                AddHandler Ctrl.Title.MouseDown, AddressOf Ctrl_MouseDown
                AddHandler Ctrl.Author.MouseDown, AddressOf Ctrl_MouseDown
                AddHandler Ctrl.MainPanel.MouseDown, AddressOf Ctrl_MouseDown
                AddHandler Ctrl.DurationLbl.MouseDown, AddressOf Ctrl_MouseDown
                AddHandler Ctrl.PlayBtn.MouseDown, AddressOf Ctrl_PlayBtn_MouseDown
                AddHandler Ctrl.MouseLeftControl, AddressOf Ctrl_MouseLeftControl
                AddHandler Ctrl.MouseEnterControl, AddressOf Ctrl_MouseEnterControl
                AddHandler Ctrl.DLBtn.MouseDown, AddressOf Ctrl_DL_MouseDown
                AddHandler Ctrl.RightClicked, AddressOf CtrlRightClick
                Ctrl.URI = track.Url

                Dim title = track.Title
                Dim duration = track.Duration
                Dim url = track.Url
                Dim artist = track.Author
                Dim img = track.Thumbnails.Last.Url

                Ctrl.Title.Text = title

                Ctrl.Url.Text = url
                Ctrl.id = track.Id
                Ctrl.Author.Text = artist.ChannelTitle
                Ctrl.ImgBox.ImageLocation = img
                Ctrl.DurationSeconds = duration.Value.TotalSeconds

                Try
                    Ctrl.Author.Font = New Font(MainForm.lightfont.Families(0), 10)
                    Ctrl.DurationLbl.Font = New Font(MainForm.titlefont.Families(0), 10.5, FontStyle.Regular)
                    Ctrl.Title.Font = New Font(MainForm.titlefont.Families(0), 11, FontStyle.Regular)
                Catch ex As System.IO.FileNotFoundException
                    Ctrl.Title.Font = New Font("Segoe UI", 11, FontStyle.Regular)
                    Ctrl.Author.Font = New Font("Segoe UI", 10)
                    Ctrl.DurationLbl.Font = New Font("Segoe UI", 10.5, FontStyle.Regular)
                Catch ex As IndexOutOfRangeException
                    Ctrl.Title.Font = New Font("Segoe UI", 11, FontStyle.Regular)
                    Ctrl.Author.Font = New Font("Segoe UI", 10)
                    Ctrl.DurationLbl.Font = New Font("Segoe UI", 10.5, FontStyle.Regular)
                End Try


                Dim timeSpan As TimeSpan = TimeSpan.FromSeconds(duration.Value.TotalSeconds)
                Dim resultstr As String

                If timeSpan.Hours > 0 Then
                    resultstr = timeSpan.ToString("hh\:mm\:ss")
                Else
                    resultstr = timeSpan.ToString("mm\:ss")
                End If

                Ctrl.DurationLbl.Text = resultstr

                controlArray(i) = Ctrl
            Next

            ' Add all controls to the FlowLayoutPanel1 at once
            FlowLayoutPanel1.SuspendLayout()
            FlowLayoutPanel1.Controls.AddRange(controlArray)
            FlowLayoutPanel1.ResumeLayout()
            FlowLayoutPanel1.PerformLayout() ' Force layout update

            DotScaling1.Visible = False

            If Guna2VScrollBar1 IsNot Nothing Then
                Guna2VScrollBar1.Maximum = FlowLayoutPanel1.VerticalScroll.Maximum
                Guna2VScrollBar1.LargeChange = FlowLayoutPanel1.VerticalScroll.LargeChange
                Guna2VScrollBar1.SmallChange = FlowLayoutPanel1.VerticalScroll.SmallChange
            End If
        End If
    End Function





    Private Async Function SearchSC(query As String, ct As CancellationToken) As Task
        Try
            Dim soundCloudClient As New SoundCloudClientIDFetcher()
            MainForm.SCClientId = Await soundCloudClient.GetClientIdAsync()
            Console.WriteLine("Client ID: " & MainForm.SCClientId)
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
        Dim soundcloud As New SoundCloudClient(MainForm.SCClientId)
        Dim results = Await soundcloud.Search.GetTracksAsync(query).CollectAsync(CInt(CBBox2.Text))
        ' Check if a cancellation has been requested
        ct.ThrowIfCancellationRequested()

        ' Create a list to hold the results
        Dim resultList As New List(Of SoundCloudExplode.Search.TrackSearchResult)()

        ' Populate the list with the results
        For Each result In results
            If TypeOf result Is SoundCloudExplode.Search.TrackSearchResult Then
                resultList.Add(DirectCast(result, SoundCloudExplode.Search.TrackSearchResult))
            End If
        Next

        ' Check if the list contains the required number of results
        If resultList.Count >= CInt(CBBox2.Text) Then
            FlowLayoutPanel1.SuspendLayout()
            ' Create an array to hold the controls
            Dim controlArray(CInt(CBBox2.Text) - 1) As TrackResultControl

            ' Populate the array with controls
            For i As Integer = 0 To controlArray.Length - 1
                Dim track = resultList(i)
                Dim Ctrl As New TrackResultControl()
                Ctrl.URI = If(track.Url, String.Empty)
                AddHandler Ctrl.MouseDown, AddressOf Ctrl_MouseDown
                AddHandler Ctrl.Title.MouseDown, AddressOf Ctrl_MouseDown
                AddHandler Ctrl.Author.MouseDown, AddressOf Ctrl_MouseDown
                AddHandler Ctrl.MainPanel.MouseDown, AddressOf Ctrl_MouseDown
                AddHandler Ctrl.DurationLbl.MouseDown, AddressOf Ctrl_MouseDown
                AddHandler Ctrl.PlayBtn.MouseDown, AddressOf Ctrl_PlayBtn_MouseDown
                AddHandler Ctrl.MouseLeftControl, AddressOf Ctrl_MouseLeftControl
                AddHandler Ctrl.MouseEnterControl, AddressOf Ctrl_MouseEnterControl
                AddHandler Ctrl.DLBtn.MouseDown, AddressOf Ctrl_DL_MouseDown
                AddHandler Ctrl.RightClicked, AddressOf CtrlRightClick
                Dim title = If(track.Title, String.Empty)
                Dim img = If(track.ArtworkUrl, "https://www.gravatar.com/avatar/7771a96494d732c4e34f6895879eebf7?size=192&d=mm")
                Dim author = If(track.User.Username, String.Empty)
                Dim Url = If(track.Url, String.Empty)
                Dim duration As String = If(track.Duration, String.Empty)

                If CBBox1.Text = "Artist" Then
                    ' Remove special characters from artist and query
                    Dim sanitizedArtist As String = System.Text.RegularExpressions.Regex.Replace(author, "[^a-zA-Z0-9]", String.Empty)
                    Dim sanitizedQuery As String = System.Text.RegularExpressions.Regex.Replace(query, "[^a-zA-Z0-9]", String.Empty)

                    ' Compare sanitized strings
                    If String.Compare(sanitizedArtist.ToLower(), sanitizedQuery.ToLower()) <> 0 Then
                        Continue For
                    End If
                End If

                Ctrl.Title.Text = title
                Ctrl.Author.Text = author
                Ctrl.Url.Text = Url
                Ctrl.ImgBox.ImageLocation = img.ToString()

                Try
                    Ctrl.Author.Font = New Font(MainForm.lightfont.Families(0), 10)
                    Ctrl.DurationLbl.Font = New Font(MainForm.titlefont.Families(0), 10.5, FontStyle.Regular)
                    Ctrl.Title.Font = New Font(MainForm.titlefont.Families(0), 11, FontStyle.Regular)
                Catch ex As System.IO.FileNotFoundException
                    Ctrl.Title.Font = New Font("Segoe UI", 11, FontStyle.Regular)
                    Ctrl.Author.Font = New Font("Segoe UI", 10)
                    Ctrl.DurationLbl.Font = New Font("Segoe UI", 10.5, FontStyle.Regular)
                Catch ex As IndexOutOfRangeException
                    Ctrl.Title.Font = New Font("Segoe UI", 11, FontStyle.Regular)
                    Ctrl.Author.Font = New Font("Segoe UI", 10)
                    Ctrl.DurationLbl.Font = New Font("Segoe UI", 10.5, FontStyle.Regular)
                End Try

                If duration Is Nothing Then
                    Ctrl.DurationLbl.Text = "Null"
                Else
                    Dim dr As String = duration / 1000
                    Ctrl.DurationSeconds = Math.Round(CDec(dr), 0)
                    Dim timeSpan As TimeSpan = TimeSpan.FromSeconds(dr)

                    Dim resultstr As String
                    If timeSpan.Hours > 0 Then
                        resultstr = timeSpan.ToString("hh\:mm\:ss")
                    Else
                        resultstr = timeSpan.ToString("mm\:ss")
                    End If

                    Ctrl.DurationLbl.Text = resultstr
                End If

                controlArray(i) = Ctrl
            Next

            ' Add all controls to the FlowLayoutPanel1 at once
            FlowLayoutPanel1.Controls.AddRange(controlArray)
            DotScaling1.Visible = False
            FlowLayoutPanel1.ResumeLayout()
            FlowLayoutPanel1.PerformLayout() ' Force layout update
            If Guna2VScrollBar1 IsNot Nothing Then
                Guna2VScrollBar1.Maximum = FlowLayoutPanel1.VerticalScroll.Maximum
                Guna2VScrollBar1.LargeChange = FlowLayoutPanel1.VerticalScroll.LargeChange
                Guna2VScrollBar1.SmallChange = FlowLayoutPanel1.VerticalScroll.SmallChange
            End If
        End If
    End Function






    Private Async Function SearchSP(query As String, ct As CancellationToken) As Task
        Dim spotify As New SpotifyClient()
        ct.ThrowIfCancellationRequested()

        Dim trackResults As New List(Of SpotifyExplode.Search.TrackSearchResult)()

        Try
            For Each result In (Await spotify.Search.GetResultsAsync(query)).Take(CInt(CBBox2.Text))
                If TypeOf result Is SpotifyExplode.Search.TrackSearchResult Then
                    trackResults.Add(DirectCast(result, SpotifyExplode.Search.TrackSearchResult))
                End If
            Next

            If trackResults.Count = CInt(CBBox2.Text) Then
                ' Create an array to hold the controls
                Dim controlArray(CInt(CBBox2.Text) - 1) As TrackResultControl

                ' Populate the array with controls
                For i As Integer = 0 To controlArray.Length - 1
                    Dim track = trackResults(i)
                    Dim ctrl As New TrackResultControl()
                    AddHandler ctrl.MouseDown, AddressOf Ctrl_MouseDown
                    AddHandler ctrl.Title.MouseDown, AddressOf Ctrl_MouseDown
                    AddHandler ctrl.Author.MouseDown, AddressOf Ctrl_MouseDown
                    AddHandler ctrl.MainPanel.MouseDown, AddressOf Ctrl_MouseDown
                    AddHandler ctrl.DurationLbl.MouseDown, AddressOf Ctrl_MouseDown
                    AddHandler ctrl.PlayBtn.MouseDown, AddressOf Ctrl_PlayBtn_MouseDown
                    AddHandler ctrl.MouseLeftControl, AddressOf Ctrl_MouseLeftControl
                    AddHandler ctrl.MouseEnterControl, AddressOf Ctrl_MouseEnterControl
                    AddHandler ctrl.DLBtn.MouseDown, AddressOf Ctrl_DL_MouseDown
                    AddHandler ctrl.RightClicked, AddressOf CtrlRightClick
                    Dim id = track.Id
                    Dim title = track.Title
                    Dim duration = track.DurationMs
                    Dim url = track.Url
                    Dim artists = track.Artists.ToList()
                    Dim album = track.Album

                    If CBBox1.Text = "Artist" Then
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

                    ctrl.Title.Text = title
                    ctrl.Url.Text = url
                    ctrl.id = id

                    Try
                        ctrl.Author.Font = New Font(MainForm.lightfont.Families(0), 10)
                        ctrl.DurationLbl.Font = New Font(MainForm.titlefont.Families(0), 10.5, FontStyle.Regular)
                        ctrl.Title.Font = New Font(MainForm.titlefont.Families(0), 11, FontStyle.Regular)
                    Catch ex As System.IO.FileNotFoundException
                        ctrl.Title.Font = New Font("Segoe UI", 11, FontStyle.Regular)
                        ctrl.Author.Font = New Font("Segoe UI", 10)
                        ctrl.DurationLbl.Font = New Font("Segoe UI", 10.5, FontStyle.Regular)
                    Catch ex As IndexOutOfRangeException
                        ctrl.Title.Font = New Font("Segoe UI", 11, FontStyle.Regular)
                        ctrl.Author.Font = New Font("Segoe UI", 10)
                        ctrl.DurationLbl.Font = New Font("Segoe UI", 10.5, FontStyle.Regular)
                    End Try

                    Dim dr As Double = duration / 1000
                    ctrl.DurationSeconds = Math.Round(dr, 0)
                    Dim timeSpan As TimeSpan = TimeSpan.FromSeconds(dr)
                    Dim resultstr As String

                    If timeSpan.Hours > 0 Then
                        resultstr = timeSpan.ToString("hh\:mm\:ss")
                    Else
                        resultstr = timeSpan.ToString("mm\:ss")
                    End If
                    ctrl.DurationLbl.Text = resultstr

                    For j = 0 To artists.Count - 1
                        ctrl.Author.Text += (artists(j).Name & "$%#").Replace("$%#", ", ")
                    Next
                    ctrl.ImgBox.ImageLocation = album.Images(0).Url
                    Dim lastIndex As Integer = ctrl.Author.Text.LastIndexOf(", ")
                    If lastIndex >= 0 Then
                        ctrl.Author.Text = ctrl.Author.Text.Remove(lastIndex, 2)
                    End If

                    controlArray(i) = ctrl
                Next

                ' Add all controls to the FlowLayoutPanel1 at once
                FlowLayoutPanel1.SuspendLayout()
                FlowLayoutPanel1.Controls.AddRange(controlArray)
                FlowLayoutPanel1.ResumeLayout()
                FlowLayoutPanel1.PerformLayout() ' Force layout update

                DotScaling1.Visible = False

                If Guna2VScrollBar1 IsNot Nothing Then
                    Guna2VScrollBar1.Maximum = FlowLayoutPanel1.VerticalScroll.Maximum
                    Guna2VScrollBar1.LargeChange = FlowLayoutPanel1.VerticalScroll.LargeChange
                    Guna2VScrollBar1.SmallChange = FlowLayoutPanel1.VerticalScroll.SmallChange
                End If
            End If

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
            Dim filepath As String = String.Empty
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
                ytdl.FFmpegPath = "ffmpeg.exe"
                ytdl.OutputFolder = My.Settings.SaveLocation
                ytdl.OutputFileTemplate = "%(title)s [%(uploader)s].%(ext)s"

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
                        filepath = res.Data
                    Case "AAC"
                        Dim res = Await ytdl.RunAudioDownload(url, AudioConversionFormat.Aac, progress:=progressHandler)
                        filepath = res.Data
                    Case "MP3"
                        Dim res = Await ytdl.RunAudioDownload(url, AudioConversionFormat.Mp3, progress:=progressHandler)
                        filepath = res.Data
                End Select

                parentControl.PB1.Visible = False
                'parentControl.SuccessImg.Visible = True
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress)
            Catch ex As Exception
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error)
            End Try


            Try
                Using file As TagLib.File = TagLib.File.Create(filepath)
                    Select Case My.Settings.AudioFormat
                        Case "WAV"
                            ' Ensure RIFF INFO tags are used for WAV files
                            If TypeOf file Is TagLib.Riff.File Then
                                Dim wavFile = CType(file, TagLib.Riff.File)
                                wavFile.Tag.Title = title
                                wavFile.Tag.Performers = New String() {author}
                                wavFile.Tag.AlbumArtists = New String() {author}
                                wavFile.Save()
                            End If
                        Case "MP3"
                            If TypeOf file Is TagLib.Mpeg.AudioFile Then
                                Dim mp3File = CType(file, TagLib.Mpeg.AudioFile)
                                mp3File.Tag.Title = title
                                mp3File.Tag.Performers = New String() {author}
                                mp3File.Tag.AlbumArtists = New String() {author}
                                mp3File.Save()
                            End If
                        Case "AAC"
                            ' Ensure MP4 tags are used for AAC files
                            If TypeOf file Is TagLib.Mpeg4.File Then
                                Dim aacFile = CType(file, TagLib.Mpeg4.File)
                                aacFile.Tag.Title = title
                                aacFile.Tag.Performers = New String() {author}
                                aacFile.Tag.AlbumArtists = New String() {author}
                                aacFile.Save()
                            End If
                    End Select
                End Using

            Catch ex As Exception
                MsgBox("TagLib Error: " & ex.Message)
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
        CBBox1.Text = MainForm.CategorieSelected
        CBBox2.Text = MainForm.CountSelected
        DotScaling1.Start()
        Me.Controls.Add(ctxTrack)
        Me.Controls.Add(ctxArtist)
        Me.Controls.Add(ctxCount)
        Me.Controls.Add(settings)
        ctxTrack.Visible = False
        ctxArtist.Visible = False
        ctxCount.Visible = False
        settings.Visible = False
        settings.Anchor = AnchorStyles.Top
        Guna2TextBox1.Text = MainForm.SearchQuery
        Select Case MainForm.SearchEngine
            Case "Youtube"
                SearchMenu1.SelectedButton = ButtonSelection.Youtube
            Case "Soundcloud"
                SearchMenu1.SelectedButton = ButtonSelection.Soundcloud
            Case "Spotify"
                SearchMenu1.SelectedButton = ButtonSelection.Spotify
        End Select

        AddMouseDownEventHandlers(Me)
        AddMouseDownEventHandlers(MainForm.Panel1)

        Try
            SearchMenu1.Label1.Font = New Font(MainForm.boldfont.Families(0), 9.75, FontStyle.Regular)
            SearchMenu1.Label2.Font = New Font(MainForm.boldfont.Families(0), 9.75, FontStyle.Regular)
            SearchMenu1.Label3.Font = New Font(MainForm.boldfont.Families(0), 9.75, FontStyle.Regular)
            CBBox1.Font = New Font(MainForm.titlefont.Families(0), 12, FontStyle.Regular)
            ctxArtist.Guna2Button1.Font = New Font(MainForm.titlefont.Families(0), 12, FontStyle.Regular)
            ctxArtist.Guna2Button3.Font = New Font(MainForm.titlefont.Families(0), 12, FontStyle.Regular)

            CBBox2.Font = New Font(MainForm.titlefont.Families(0), 12, FontStyle.Regular)
            ctxCount.Btn20.Font = New Font(MainForm.titlefont.Families(0), 12, FontStyle.Regular)
            ctxCount.Btn40.Font = New Font(MainForm.titlefont.Families(0), 12, FontStyle.Regular)
            ctxCount.Btn60.Font = New Font(MainForm.titlefont.Families(0), 12, FontStyle.Regular)
            ctxCount.Btn80.Font = New Font(MainForm.titlefont.Families(0), 12, FontStyle.Regular)
            ctxCount.Btn100.Font = New Font(MainForm.titlefont.Families(0), 12, FontStyle.Regular)
            ctxTrack.Guna2Button1.Font = New Font(MainForm.boldfont.Families(0), 9.75, FontStyle.Regular)
            ctxTrack.Guna2Button3.Font = New Font(MainForm.boldfont.Families(0), 9.75, FontStyle.Regular)
        Catch ex As System.IO.FileNotFoundException
            SearchMenu1.Label1.Font = New Font("Segoe UI Semibold", 9.75, FontStyle.Regular)
            SearchMenu1.Label2.Font = New Font("Segoe UI Semibold", 9.75, FontStyle.Regular)
            SearchMenu1.Label3.Font = New Font("Segoe UI Semibold", 9.75, FontStyle.Regular)
        Catch ex As IndexOutOfRangeException
            SearchMenu1.Label1.Font = New Font("Segoe UI Semibold", 9.75, FontStyle.Regular)
            SearchMenu1.Label2.Font = New Font("Segoe UI Semibold", 9.75, FontStyle.Regular)
            SearchMenu1.Label3.Font = New Font("Segoe UI Semibold", 9.75, FontStyle.Regular)
        End Try
    End Sub

    Private Sub FlowLayoutPanel1_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2VScrollBar1.Scroll, FlowLayoutPanel1.Scroll
        ctxTrack.Visible = False
        CBBox1.Checked = False
        ctxArtist.Visible = False
        CBBox2.Checked = False
        ctxCount.Visible = False

        settings.Visible = False
    End Sub

    Private Sub SearchForm_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        ctxTrack.Visible = False
        CBBox1.Checked = False
        ctxArtist.Visible = False
        CBBox2.Checked = False
        ctxCount.Visible = False
    End Sub


    Private Sub ArtistCtx(action As String, Xcoord As Integer, Ycoord As Integer)
        Select Case action
            Case "Open"
                ctxArtist.Location = New Point(Xcoord, Ycoord + 51)
                ctxArtist.BringToFront()
                Guna2Transition1.ShowSync(ctxArtist, True, Guna.UI2.AnimatorNS.Animation.Transparent)
            Case "Close"

        End Select

    End Sub

    Private Sub CountCtx(action As String, Xcoord As Integer, Ycoord As Integer)
        Select Case action
            Case "Open"
                ctxCount.Location = New Point(Xcoord, Ycoord + 51)
                ctxCount.BringToFront()
                Guna2Transition1.ShowSync(ctxCount, True, Guna.UI2.AnimatorNS.Animation.Transparent)
            Case "Close"
        End Select
    End Sub


    Private Sub CBBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CBBox1.CheckedChanged
        If CBBox1.Checked = True Then
            ArtistCtx("Open", CBBox1.Location.X, CBBox1.Location.Y)
        Else
            ctxArtist.Visible = False
        End If
    End Sub

    Private Sub ArtistCtxOption_Clicked(sender As Object, e As EventArgs) Handles ctxArtist.ArtistClicked
        CBBox1.Text = "Artist"
        CBBox1.Checked = False
    End Sub

    Private Sub TrackCtxOption_Clicked(sender As Object, e As EventArgs) Handles ctxArtist.TrackClicked
        CBBox1.Text = "Track"
        CBBox1.Checked = False
    End Sub



    Private Sub CBBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CBBox2.CheckedChanged
        If CBBox2.Checked = True Then
            CountCtx("Open", CBBox2.Location.X, CBBox2.Location.Y)
        Else
            ctxCount.Visible = False
        End If
    End Sub

    Private Sub Btn20_Clicked(sender As Object, e As EventArgs) Handles ctxCount.Btn20Clicked
        CBBox2.Text = "20"
        CBBox2.Checked = False
    End Sub
    Private Sub Btn40_Clicked(sender As Object, e As EventArgs) Handles ctxCount.Btn40Clicked
        CBBox2.Text = "40"
        CBBox2.Checked = False
    End Sub
    Private Sub Btn60_Clicked(sender As Object, e As EventArgs) Handles ctxCount.Btn60Clicked
        CBBox2.Text = "60"
        CBBox2.Checked = False
    End Sub
    Private Sub Btn80_Clicked(sender As Object, e As EventArgs) Handles ctxCount.Btn80Clicked
        CBBox2.Text = "80"
        CBBox2.Checked = False
    End Sub

    Private Sub Btn100_Clicked(sender As Object, e As EventArgs) Handles ctxCount.Btn100Clicked
        CBBox2.Text = "100"
        CBBox2.Checked = False
    End Sub
End Class
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms
Imports System.ComponentModel

Public Class VersionChecker
    Private Const GitHubApiUrl As String = "https://api.github.com/repos/{owner}/{repo}/releases/latest"
    Private CurrentVersion As String = My.Application.Info.Version.ToString() ' Your current application version
    Private client As WebClient ' WebClient instance to handle the download

    Public Sub CheckForUpdate()
        ' Delete any old setup files before checking for updates
        DeleteOldSetupFiles()

        Dim latestVersion As String = GetLatestVersionFromGitHub()

        If IsNewVersionAvailable(CurrentVersion, latestVersion) Then
            Dim result As DialogResult = MessageBox.Show("A new version is available. Do you want to download it?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                DownloadLatestVersion(latestVersion)
            End If
        Else
            Console.WriteLine("You are using the latest version.")
        End If
    End Sub

    Private Function GetLatestVersionFromGitHub() As String
        Dim url As String = GitHubApiUrl.Replace("{owner}", "jsgrenier").Replace("{repo}", "EZBeat")
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.UserAgent = "EZBeat" ' GitHub API requires a user agent

        Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Using reader As New StreamReader(response.GetResponseStream())
                Dim jsonResponse As String = reader.ReadToEnd()
                Dim json As JObject = JObject.Parse(jsonResponse)
                Return json("tag_name").ToString()
            End Using
        End Using
    End Function

    Private Function IsNewVersionAvailable(currentVersion As String, latestVersion As String) As Boolean
        Return String.Compare(currentVersion, latestVersion) < 0
    End Function

    Private Sub DownloadLatestVersion(latestVersion As String)
        Dim url As String = $"https://github.com/jsgrenier/EZBeat/releases/download/{latestVersion}/EZBeat_Setup-{latestVersion}.exe"
        Dim downloadDirectory As String = AppDomain.CurrentDomain.BaseDirectory ' Use the application's directory
        Dim downloadPath As String = Path.Combine(downloadDirectory, $"EZBeat_Setup-{latestVersion}.exe")

        ' Ensure the directory exists
        If Not Directory.Exists(downloadDirectory) Then
            Directory.CreateDirectory(downloadDirectory)
        End If

        ' Create a new form to show the progress bar
        Dim progressForm As New Form With {
            .Text = "Downloading Update",
            .Size = New Size(400, 100),
            .FormBorderStyle = FormBorderStyle.FixedDialog,
            .StartPosition = FormStartPosition.CenterScreen,
            .MaximizeBox = False,
            .MinimizeBox = False,
            .TopMost = True
        }

        Dim progressBar As New ProgressBar With {
            .Dock = DockStyle.Fill,
            .Style = ProgressBarStyle.Continuous
        }

        progressForm.Controls.Add(progressBar)

        ' Handle the FormClosing event to cancel the download if the form is closed
        AddHandler progressForm.FormClosing, Sub(sender As Object, e As FormClosingEventArgs)
                                                 If client IsNot Nothing AndAlso client.IsBusy Then
                                                     client.CancelAsync()
                                                 End If
                                             End Sub

        progressForm.Show()

        client = New WebClient()
        AddHandler client.DownloadProgressChanged, Sub(sender As Object, e As DownloadProgressChangedEventArgs)
                                                       progressBar.Value = e.ProgressPercentage
                                                   End Sub
        AddHandler client.DownloadFileCompleted, Sub(sender As Object, e As AsyncCompletedEventArgs)
                                                     progressForm.Close()
                                                     If e.Error Is Nothing Then
                                                         MessageBox.Show("Download complete. The application will now update.", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                         ' Execute the setup file
                                                         Process.Start(downloadPath)
                                                         ' Close the current application
                                                         Application.Exit()
                                                     ElseIf e.Cancelled Then
                                                         MessageBox.Show("Download canceled.", "Download Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                     Else
                                                         MessageBox.Show("An error occurred during the download. Please try again.", "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                     End If
                                                 End Sub

        client.DownloadFileAsync(New Uri(url), downloadPath)
    End Sub

    Private Sub DeleteOldSetupFiles()
        Dim downloadDirectory As String = AppDomain.CurrentDomain.BaseDirectory
        Dim setupFiles As String() = Directory.GetFiles(downloadDirectory, "EZBeat_Setup-*.exe")

        For Each setupFile As String In setupFiles
            Try
                File.Delete(setupFile)
            Catch ex As Exception
                ' Log the exception or handle it as needed
                Console.WriteLine($"Failed to delete file {setupFile}: {ex.Message}")
            End Try
        Next
    End Sub
End Class

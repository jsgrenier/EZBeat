Imports System.Net
Imports System.IO
Imports Newtonsoft.Json.Linq
Imports System.Windows.Forms
Imports System.ComponentModel
Imports DevExpress.XtraEditors ' Import DevExpress namespace
Imports System.Threading

Public Class VersionChecker
    Private Const GitHubApiUrl As String = "https://api.github.com/repos/{owner}/{repo}/releases/latest"
    Private CurrentVersion As String = My.Application.Info.Version.ToString() ' Your current application version
    Private client As WebClient ' WebClient instance to handle the download

    Public Sub CheckForUpdate()
        ' Check for internet connectivity
        If Not IsInternetAvailable() Then
            Return
        End If

        ' Delete any old setup files before checking for updates
        DeleteOldSetupFiles()

        Dim latestVersion As String = GetLatestVersionFromGitHub()

        If IsNewVersionAvailable(CurrentVersion, latestVersion) Then

            Dim result As DialogResult = CustomYesNoDialog.ShowDialog(MainForm) 'XtraMessageBox.Show("A new version is available. Do you want to download it?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                DownloadLatestVersion(latestVersion)
            End If
        Else
            If MainForm.updatecheck = True Then
                XtraMessageBox.Show("You are using the latest version.", "Up to date", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Function IsInternetAvailable() As Boolean
        Try
            Using client As New WebClient()
                Using stream As Stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

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
        Dim progressForm As New CustomProgressForm With {
        .Text = "Downloading Update...",
        .Size = New Size(400, 100),
        .FormBorderStyle = FormBorderStyle.FixedDialog,
        .StartPosition = FormStartPosition.CenterScreen,
        .MaximizeBox = False,
        .MinimizeBox = False,
        .TopMost = True,
        .BackColor = Color.FromArgb(30, 31, 34)
    }

        Dim progressBar As New Guna.UI2.WinForms.Guna2ProgressBar With {
        .Dock = DockStyle.Fill,
        .Style = ProgressBarStyle.Continuous,
        .FillColor = Color.FromArgb(30, 31, 34),
        .BackColor = Color.FromArgb(30, 31, 34),
        .ShowText = True,
        .ShowPercentage = True
    }

        progressForm.Controls.Add(progressBar)

        ' Handle the FormClosing event to cancel the download if the form is closed
        AddHandler progressForm.FormClosing, Sub(sender As Object, e As FormClosingEventArgs)
                                                 If client IsNot Nothing AndAlso client.IsBusy Then
                                                     client.CancelAsync()
                                                 End If
                                             End Sub

        ' Create a BackgroundWorker to handle the download process
        Dim worker As New BackgroundWorker()
        Dim syncContext As SynchronizationContext = SynchronizationContext.Current

        AddHandler worker.DoWork, Sub(sender As Object, e As DoWorkEventArgs)
                                      client = New WebClient()
                                      AddHandler client.DownloadProgressChanged, Sub(s, ev)
                                                                                     syncContext.Post(Sub()
                                                                                                          If Not progressForm.IsDisposed Then
                                                                                                              progressBar.Value = ev.ProgressPercentage
                                                                                                          End If
                                                                                                      End Sub, Nothing)
                                                                                 End Sub
                                      AddHandler client.DownloadFileCompleted, Sub(s, ev)
                                                                                   syncContext.Post(Sub()
                                                                                                        If Not progressForm.IsDisposed Then
                                                                                                            progressForm.Close()
                                                                                                        End If

                                                                                                        If ev.Error Is Nothing Then
                                                                                                            XtraMessageBox.Show("Download complete. The application will now update.", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                                                                            ' Execute the setup file
                                                                                                            Process.Start(downloadPath)
                                                                                                            ' Close the current application
                                                                                                            Application.Exit()
                                                                                                        ElseIf ev.Cancelled Then
                                                                                                            XtraMessageBox.Show("Download canceled.", "Download Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                                                                        Else
                                                                                                            XtraMessageBox.Show("An error occurred during the download. Please try again.", "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                                                                        End If
                                                                                                    End Sub, Nothing)
                                                                               End Sub

                                      client.DownloadFileAsync(New Uri(url), downloadPath)
                                  End Sub

        ' Start the BackgroundWorker
        worker.RunWorkerAsync()

        ' Show the progress form as a modal dialog
        progressForm.ShowDialog(MainForm)
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

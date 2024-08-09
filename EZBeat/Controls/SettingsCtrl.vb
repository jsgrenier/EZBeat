Imports System.IO
Imports WK.Libraries.BetterFolderBrowserNS
Imports DevExpress.XtraEditors

Public Class SettingsCtrl
    Public Event XClicked As EventHandler
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        RaiseEvent XClicked(Me, e)
    End Sub

    Private Sub Guna2TextBox1_IconRightClick(sender As Object, e As EventArgs) Handles FileLoc.IconRightClick
        ' Create an instance of the FolderBrowserDialog
        Dim folderBrowser As New FolderBrowserDialog()

        ' Set properties of the folder browser
        folderBrowser.Description = "Select folder..."
        folderBrowser.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads"

        ' Show the FolderBrowserDialog and get the selected path.
        If folderBrowser.ShowDialog() = DialogResult.OK Then
            FileLoc.Text = folderBrowser.SelectedPath
            If FileLoc.Text.Length > 1 Then
                Guna2Button1.DialogResult = DialogResult.OK
                MainForm.FileSaveExist = True
            Else
                Guna2Button1.DialogResult = DialogResult.None
                MainForm.FileSaveExist = False
            End If
        Else
            ' If no folder is selected, return from the subroutine.
            Return
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If FileLoc.Text <> "" Then
            My.Settings.SaveLocation = FileLoc.Text
            My.Settings.AudioFormat = AudioForm.Text
            My.Settings.Save()
            Me.Visible = False
        Else
            Guna2Button1.DialogResult = DialogResult.None
            Dim mss As New Guna.UI2.WinForms.Guna2MessageDialog()
            mss.Text = vbNewLine & "You can't save an empty file location!"
            mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
            mss.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark
            mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
            mss.Show()
        End If

    End Sub

    Private Sub SettingsCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SettingsCtrl_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        FileLoc.Text = My.Settings.SaveLocation
        AudioForm.Text = My.Settings.AudioFormat
    End Sub
End Class

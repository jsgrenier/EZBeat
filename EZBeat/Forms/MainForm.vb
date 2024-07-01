﻿Public Class MainForm
    Public currentChildformMainPanel As Form
    Public SearchEngine As String
    Public SearchQuery As String = String.Empty
    Public PlayState As Integer
    Public textboxFocused As Boolean = False
    Public CountSelectedIndex As Integer
    Public CategorieSelectedIndex As Integer
    Public WithEvents player2 As New WAudioPlayer()

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Public FileSaveExist As Boolean

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenChildFormContentPanel(New OpeningForm)
        Dim settingsDialog As Form = Settings
        If My.Settings.SaveLocation = String.Empty Then

            Dim res As DialogResult = settingsDialog.ShowDialog
            If FileSaveExist = True Then
                If My.Settings.SaveLocation = String.Empty Then
                    Close()
                Else
                End If

            Else
                Close()
            End If
        End If

        Dim volume As Single = TBVolume.Value
        ' Set the volume of the audio player
        player2.audioplayer.settings.volume = volume
    End Sub

    Private Sub Player2_PositionChange(sender As Object, e As PositionChangedEventArgs) Handles player2.PositionChange
        Dim currentPosition As Double = e.CurrentPosition
        Dim timeString As String = Label2.Text
        Dim timeParts() As String = timeString.Split(":"c)
        Dim minutes As Integer = Integer.Parse(timeParts(0))
        Dim seconds As Integer = Integer.Parse(timeParts(1))
        Dim totalSeconds As Integer = (minutes * 60) + seconds

        If TBDuration.Value = totalSeconds - 2 Then
            PauseBtn.Visible = False
            PlayBtn.Visible = True
            player2.audioplayer.controls.stop()
            TBDuration.Value = 0
        Else
            TBDuration.Value = CInt(currentPosition)
            Console.WriteLine("currentposition: " & currentPosition)
            Console.WriteLine("tbduration val: " & TBDuration.Value)
            Console.WriteLine("tbduration max: " & TBDuration.Maximum)
            Dim actual As TimeSpan = TimeSpan.FromSeconds(TBDuration.Value)
            Dim timeStr As String

            If actual.Hours > 0 Then
                ' Duration includes hours
                timeStr = $"{actual.Hours}:{actual.Minutes:D2}:{actual.Seconds:D2}"
            Else
                ' Duration includes only minutes and seconds
                timeStr = $"{actual.Minutes}:{actual.Seconds:D2}"
            End If

            Label1.Text = timeStr
        End If
    End Sub


    Private Sub TBDuration_ValueChanged(sender As Object, e As EventArgs) Handles TBDuration.ValueChanged
        Dim seconds As Double = TBDuration.Value
        Dim timeSpan As TimeSpan = TimeSpan.FromSeconds(seconds)
        Dim result As String

        If timeSpan.Hours > 0 Then
            ' Duration includes hours
            result = String.Format("{0}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds)
        Else
            ' Duration includes only minutes and seconds
            result = String.Format("{0}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds)
        End If

        Label1.Text = result

    End Sub

    Private Sub TBDuration_Scroll(sender As Object, e As EventArgs) Handles TBDuration.Scroll
        ' Set the position of the audio player to the value of the trackbar
        If player2 IsNot Nothing Then
            player2.audioplayer.controls.currentPosition = TBDuration.Value
        End If
        'player.SetPosition(TBDuration.Value)
    End Sub

    Private Sub TBVolume_Scroll(sender As Object, e As EventArgs) Handles TBVolume.Scroll
        ' Convert the trackbar value to a volume level between 0 and 1
        Dim volume As Single = TBVolume.Value
        ' Set the volume of the audio player
        player2.audioplayer.settings.volume = volume
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles PauseBtn.Click
        player2.audioplayer.controls.pause()
        'ACTION
        PauseBtn.Visible = False
        PlayBtn.Visible = True
    End Sub

    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles PlayBtn.Click
        player2.audioplayer.controls.play()
        'ACTION
        PlayBtn.Visible = False
        PauseBtn.Visible = True
    End Sub


    Public Sub OpenChildFormContentPanel(childForm As Form)
        If currentChildformMainPanel IsNot Nothing Then
            currentChildformMainPanel.Close()
        End If
        currentChildformMainPanel = childForm
        'end
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        MainPanel.Controls.Add(childForm)
        MainPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub


    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub Title_SizeChanged(sender As Object, e As EventArgs) Handles Title.SizeChanged
        If Title.Size.Height = 20 Then
            Author.Visible = True
            Author.Location = New Point(89, 36)
            'Description.Location = New Point(370, 52)
        Else
            Author.Visible = False
            'Description.Location = New Point(370, 75)
        End If
    End Sub



    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Space
                If textboxFocused = False And Panel1.Visible = True Then
                    If player2.audioplayer.playState = WMPLib.WMPPlayState.wmppsPaused Or player2.audioplayer.playState = WMPLib.WMPPlayState.wmppsStopped Then
                        player2.audioplayer.controls.play()
                        PauseBtn.Visible = True
                        PlayBtn.Visible = False
                        Return True
                    ElseIf player2.audioplayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then
                        player2.audioplayer.controls.pause()
                        PauseBtn.Visible = False
                        PlayBtn.Visible = True
                        Return True
                    End If
                End If

            Case Keys.Left
                If textboxFocused = False And Panel1.Visible = True Then
                    If player2.audioplayer.controls.currentPosition - 1 >= 0 Then
                        player2.audioplayer.controls.currentPosition -= 1
                    End If
                    TBDuration.Value = player2.audioplayer.controls.currentPosition
                    Return True
                End If

            Case Keys.Right
                If textboxFocused = False And Panel1.Visible = True Then
                    If player2.audioplayer.controls.currentPosition + 1 <= player2.audioplayer.currentMedia.duration Then
                        player2.audioplayer.controls.currentPosition += 1
                    End If
                    TBDuration.Value = player2.audioplayer.controls.currentPosition
                    Return True
                End If
        End Select

        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function

    Private Sub TBDuration_Click(sender As Object, e As EventArgs)
        TBDuration.Select()
    End Sub

    Private Sub MuteBtn_Click(sender As Object, e As EventArgs) Handles MuteBtn.Click

        If MuteBtn.Checked = True Then
            TBVolume.Tag = TBVolume.Value
            TBVolume.Value = 0
        Else
            TBVolume.Value = TBVolume.Tag
        End If

    End Sub

    Private Sub TBVolume_ValueChanged(sender As Object, e As EventArgs) Handles TBVolume.ValueChanged
        Dim volume As Single = TBVolume.Value
        ' Set the volume of the audio player
        player2.audioplayer.settings.volume = volume
        If TBVolume.Value > 1 Then
            MuteBtn.Checked = False
        End If
    End Sub

    Private Sub Thumbnail_Click(sender As Object, e As EventArgs) Handles Title.Click, Thumbnail.Click, Panel1.Click, Label2.Click, Label1.Click, Author.Click, TBVolume.Click, TBDuration.Click, PauseBtn.Click, PlayBtn.Click
        If textboxFocused = True Then
            Panel1.Focus()
            textboxFocused = False
        End If
    End Sub

End Class
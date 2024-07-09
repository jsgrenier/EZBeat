Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Public Class TrackResultControl
    Public Event MouseLeftControl As EventHandler
    Public Event MouseEnterControl As EventHandler
    Public id As String
    Public DurationSeconds As Double
    Public URI As String
    Dim titlefont As New PrivateFontCollection()
    Dim lightfont As New PrivateFontCollection()
    Dim boldfont As New PrivateFontCollection()
    Public Event RightClicked As EventHandler


    Private Sub Guna2Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Title.MouseEnter, ImgBox.MouseEnter, MainPanel.MouseEnter, Author.MouseEnter, PlayBtn.MouseEnter, DurationLbl.MouseEnter, DLBtn.MouseEnter, PB1.MouseEnter
        RaiseEvent MouseEnterControl(Me, e)

    End Sub

    Private Sub TrackResultControl_MouseClick(sender As Object, e As MouseEventArgs) Handles Title.MouseClick, ImgBox.MouseClick, MainPanel.MouseClick, Author.MouseClick, PlayBtn.MouseClick, DurationLbl.MouseClick, DLBtn.MouseClick, PB1.MouseClick
        If e.Button = MouseButtons.Right Then
            RaiseEvent RightClicked(Me, e)
        End If
    End Sub

    Private Sub Title_MouseClick(sender As Object, e As EventArgs) Handles Title.Click, ImgBox.Click, MainPanel.Click, Author.Click, PlayBtn.Click, DurationLbl.Click, DLBtn.Click, PB1.Click

        MainPanel.FillColor = Color.FromArgb(45, 46, 49)
        ImgBox.BackColor = Color.FromArgb(45, 46, 49)
        Title.BackColor = Color.FromArgb(45, 46, 49)
        Author.BackColor = Color.FromArgb(45, 46, 49)
        DurationLbl.BackColor = Color.FromArgb(45, 46, 49)
        DLBtn.CustomImages.Image = My.Resources.icons8_download_24
        PB1.BackColor = Color.FromArgb(45, 46, 49)
        MainPanel.BorderThickness = 1

    End Sub

    Private Sub Guna2Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Title.MouseLeave, ImgBox.MouseLeave, MainPanel.MouseLeave, Author.MouseLeave, PlayBtn.MouseLeave, DurationLbl.MouseLeave, DLBtn.MouseLeave, PB1.MouseLeave
        RaiseEvent MouseLeftControl(Me, EventArgs.Empty)
    End Sub

    Private Sub TrackResultControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            titlefont.AddFontFile("Tofino-Regular.ttf")
            lightfont.AddFontFile("Tofino-Light.ttf")

            Title.Font = New Font(MainForm.titlefont.Families(0), 11, FontStyle.Regular)
            Author.Font = New Font(MainForm.lightfont.Families(0), 10)
            DurationLbl.Font = New Font(MainForm.titlefont.Families(0), 10.5, FontStyle.Regular)

        Catch ex As system.IO.FileNotFoundException
            Title.Font = New Font("Segoe UI", 11, FontStyle.Regular)
            Author.Font = New Font("Segoe UI", 10)
            DurationLbl.Font = New Font("Segoe UI", 10.5, FontStyle.Regular)
        Catch ex As IndexOutOfRangeException
            Title.Font = New Font("Segoe UI", 11, FontStyle.Regular)
            Author.Font = New Font("Segoe UI", 10)
            DurationLbl.Font = New Font("Segoe UI", 10.5, FontStyle.Regular)
        End Try
    End Sub
End Class

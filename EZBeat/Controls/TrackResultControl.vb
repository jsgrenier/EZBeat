Imports System.Drawing.Text

Public Class TrackResultControl
    Public Event MouseLeftControl As EventHandler
    'Public Event MouseLeftControl As EventHandler
    Public id As String
    Public DurationSeconds As Double
    Public URI As String
    Dim titlefont As New PrivateFontCollection()
    Dim lightfont As New PrivateFontCollection()
    Dim boldfont As New PrivateFontCollection()


    Private Sub Guna2Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Title.MouseEnter, ImgBox.MouseEnter, MainPanel.MouseEnter, Author.MouseEnter, PlayBtn.MouseEnter, DurationLbl.MouseEnter, DLBtn.MouseEnter, PB1.MouseEnter
        MainPanel.FillColor = Color.FromArgb(39, 39, 39)
        ImgBox.BackColor = Color.FromArgb(39, 39, 39)
        Title.BackColor = Color.FromArgb(39, 39, 39)
        Author.BackColor = Color.FromArgb(39, 39, 39)
        DurationLbl.BackColor = Color.FromArgb(39, 39, 39)
        DLBtn.CustomImages.Image = My.Resources.icons8_download_24
        PB1.BackColor = Color.FromArgb(39, 39, 39)
    End Sub

    Private Sub Title_MouseClick(sender As Object, e As EventArgs) Handles Title.Click, ImgBox.Click, MainPanel.Click, Author.Click, PlayBtn.Click, DurationLbl.Click, DLBtn.Click, PB1.Click

        MainPanel.FillColor = Color.FromArgb(39, 39, 39)
        ImgBox.BackColor = Color.FromArgb(39, 39, 39)
        Title.BackColor = Color.FromArgb(39, 39, 39)
        Author.BackColor = Color.FromArgb(39, 39, 39)
        DurationLbl.BackColor = Color.FromArgb(39, 39, 39)
        DLBtn.CustomImages.Image = My.Resources.icons8_download_24
        PB1.BackColor = Color.FromArgb(39, 39, 39)

    End Sub

    Private Sub Guna2Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Title.MouseLeave, ImgBox.MouseLeave, MainPanel.MouseLeave, Author.MouseLeave, PlayBtn.MouseLeave, DurationLbl.MouseLeave, DLBtn.MouseLeave, PB1.MouseLeave
        RaiseEvent MouseLeftControl(Me, EventArgs.Empty)
    End Sub

    Private Sub TrackResultControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        titlefont.AddFontFile("Tofino-Regular.ttf")
        lightfont.AddFontFile("Tofino-Light.ttf")

        Title.Font = New Font(titlefont.Families(0), 11, FontStyle.Regular)
        Author.Font = New Font(lightfont.Families(0), 10)
        DurationLbl.Font = New Font(titlefont.Families(0), 10.5, FontStyle.Regular)
    End Sub
End Class

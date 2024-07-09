Imports System.Drawing.Text
Imports YouTubeApiSharp
Imports YoutubeExplode.Common

Public Class OpeningForm
    Private titlefont As New PrivateFontCollection()
    Private lightfont As New PrivateFontCollection()
    Private boldfont As New PrivateFontCollection()

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        MainForm.SearchQuery = Guna2TextBox1.Text
        MainForm.CategorieSelectedIndex = CBBox1.SelectedIndex
        MainForm.CountSelectedIndex = CBBox2.SelectedIndex
        MainForm.OpenChildFormContentPanel(New SearchForm)
    End Sub

    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            MainForm.SearchQuery = Guna2TextBox1.Text
            MainForm.CategorieSelectedIndex = CBBox1.SelectedIndex
            MainForm.CountSelectedIndex = CBBox2.SelectedIndex
            MainForm.OpenChildFormContentPanel(New SearchForm)
        End If
    End Sub


    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton2.CheckedChanged, Guna2RadioButton1.CheckedChanged, Guna2RadioButton3.CheckedChanged
        If Guna2RadioButton1.Checked = True Then
            Console.WriteLine("Youtube")
            MainForm.SearchEngine = "Youtube"
        End If
        If Guna2RadioButton2.Checked = True Then
            Console.WriteLine("Soundcloud")
            MainForm.SearchEngine = "Soundcloud"
        End If
        If Guna2RadioButton3.Checked = True Then
            Console.WriteLine("Spotify")
            MainForm.SearchEngine = "Spotify"
        End If
    End Sub



    Private Sub Guna2TextBox1_Enter(sender As Object, e As EventArgs) Handles Guna2TextBox1.Enter
        MainForm.textboxFocused = True
    End Sub

    Private Sub Guna2TextBox1_Leave(sender As Object, e As EventArgs) Handles Guna2TextBox1.Leave
        MainForm.textboxFocused = False
    End Sub

    Private Sub Guna2Button2_MouseClick(sender As Object, e As MouseEventArgs) Handles Guna2Button2.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim settings As New Settings()
            settings.ShowDialog()
        End If

    End Sub

    Private Sub OpeningForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim defaultradiofont As New Font("Segoe UI Semibold", 9.75!, FontStyle.Bold, GraphicsUnit.Point)
        Try
            titlefont.AddFontFile("Tofino-Regular.ttf")
            lightfont.AddFontFile("Tofino-Light.ttf")
            boldfont.AddFontFile("Tofino-Semibold.ttf")


            Guna2RadioButton1.Font = New Font(boldfont.Families(0), 9.75, FontStyle.Regular)
            Guna2RadioButton2.Font = New Font(boldfont.Families(0), 9.75, FontStyle.Regular)
            Guna2RadioButton3.Font = New Font(boldfont.Families(0), 9.75, FontStyle.Regular)
            Label2.Font = New Font(titlefont.Families(0), 11.25, FontStyle.Regular)
            CBBox1.Font = New Font(titlefont.Families(0), 12, FontStyle.Regular)
            CBBox1.TextOffset = New Point(22, 2)
            CBBox2.Font = New Font(titlefont.Families(0), 12, FontStyle.Regular)
            CBBox2.TextOffset = New Point(10, 2)
            Guna2Button1.Font = New Font(boldfont.Families(0), 11.25, FontStyle.Regular)
        Catch ex As System.IO.FileNotFoundException
            Guna2RadioButton1.Font = defaultradiofont
            Guna2RadioButton2.Font = defaultradiofont
            Guna2RadioButton3.Font = defaultradiofont
            Label2.Font = New Font("Segoe UI", 11.25!, FontStyle.Regular, GraphicsUnit.Point)
            CBBox1.Font = New Font("Segoe UI", 12.0!)
            CBBox1.TextOffset = New Point(22, 0)
            CBBox2.Font = New Font("Segoe UI", 12.0!)
            CBBox2.TextOffset = New Point(10, 0)

        Catch ex As IndexOutOfRangeException
            Console.WriteLine(ex)
            Guna2RadioButton1.Font = defaultradiofont
            Guna2RadioButton2.Font = defaultradiofont
            Guna2RadioButton3.Font = defaultradiofont
            Label2.Font = New Font("Segoe UI", 11.25!, FontStyle.Regular, GraphicsUnit.Point)
            CBBox1.Font = New Font("Segoe UI", 12.0!)
            CBBox1.TextOffset = New Point(22, 2)
            CBBox2.Font = New Font("Segoe UI", 12.0!)
            CBBox2.TextOffset = New Point(10, 0)
        End Try

    End Sub

    Private Sub OpeningForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        boldfont.Dispose()
        lightfont.Dispose()
        titlefont.Dispose()
    End Sub
End Class
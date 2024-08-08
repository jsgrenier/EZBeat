Imports System.Drawing.Text
Imports Guna.UI2.WinForms
Imports YouTubeApiSharp
Imports YoutubeExplode.Common

Public Class OpeningForm
    Private titlefont As New PrivateFontCollection()
    Private lightfont As New PrivateFontCollection()
    Private boldfont As New PrivateFontCollection()

    Public WithEvents ctxArtist As New CtxTrackArtist()
    Public WithEvents ctxCount As New CtxCount()
    Private WithEvents settings As New SettingsCtrl()

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        MainForm.SearchQuery = Guna2TextBox1.Text
        MainForm.CategorieSelected = CBBox1.Text
        MainForm.CountSelected = CBBox2.Text
        MainForm.OpenChildFormContentPanel(New SearchForm)
    End Sub

    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            MainForm.SearchQuery = Guna2TextBox1.Text
            MainForm.CategorieSelected = CBBox1.Text
            MainForm.CountSelected = CBBox2.Text
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
            settings.BringToFront()
            CenterControl(settings)
            settings.Location = New Point(settings.Location.X, 112)
            Guna2Transition1.ShowSync(settings, True, Guna.UI2.AnimatorNS.Animation.Transparent)
        End If

    End Sub



    Private Sub CenterControl(ctrl As Control)
        ' Calculate the center position
        Dim centerX As Integer = (Me.ClientSize.Width - ctrl.Width) \ 2
        Dim centerY As Integer = (Me.ClientSize.Height - ctrl.Height) \ 2

        ' Set the control's position
        ctrl.Left = centerX
        ctrl.Top = centerY
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
            LblVersion.Font = New Font(titlefont.Families(0), 11.25, FontStyle.Regular)
            CBBox1.Font = New Font(titlefont.Families(0), 12, FontStyle.Regular)
            ctxArtist.Guna2Button1.Font = New Font(titlefont.Families(0), 12, FontStyle.Regular)
            ctxArtist.Guna2Button3.Font = New Font(titlefont.Families(0), 12, FontStyle.Regular)

            CBBox2.Font = New Font(titlefont.Families(0), 12, FontStyle.Regular)
            ctxCount.Btn20.Font = New Font(titlefont.Families(0), 12, FontStyle.Regular)
            ctxCount.Btn40.Font = New Font(titlefont.Families(0), 12, FontStyle.Regular)
            ctxCount.Btn60.Font = New Font(titlefont.Families(0), 12, FontStyle.Regular)
            ctxCount.Btn80.Font = New Font(titlefont.Families(0), 12, FontStyle.Regular)
            ctxCount.Btn100.Font = New Font(titlefont.Families(0), 12, FontStyle.Regular)
            Guna2Button1.Font = New Font(boldfont.Families(0), 11.25, FontStyle.Regular)
        Catch ex As System.IO.FileNotFoundException
            Guna2RadioButton1.Font = defaultradiofont
            Guna2RadioButton2.Font = defaultradiofont
            Guna2RadioButton3.Font = defaultradiofont
            LblVersion.Font = New Font("Segoe UI", 11.25!, FontStyle.Regular, GraphicsUnit.Point)
            CBBox1.Font = New Font("Segoe UI", 12.0!)
            CBBox1.TextOffset = New Point(22, 0)
            CBBox2.Font = New Font("Segoe UI", 12.0!)
            CBBox2.TextOffset = New Point(10, 0)

        Catch ex As IndexOutOfRangeException
            Console.WriteLine(ex)
            Guna2RadioButton1.Font = defaultradiofont
            Guna2RadioButton2.Font = defaultradiofont
            Guna2RadioButton3.Font = defaultradiofont
            LblVersion.Font = New Font("Segoe UI", 11.25!, FontStyle.Regular, GraphicsUnit.Point)
            CBBox1.Font = New Font("Segoe UI", 12.0!)
            CBBox1.TextOffset = New Point(22, 2)
            CBBox2.Font = New Font("Segoe UI", 12.0!)
            CBBox2.TextOffset = New Point(10, 0)
        End Try
        MainMenu.Controls.Add(ctxArtist)
        MainMenu.Controls.Add(ctxCount)
        Me.Controls.Add(settings)
        ctxArtist.Visible = False
        ctxCount.Visible = False
        settings.Visible = False
        settings.Anchor = AnchorStyles.Top
        AddMouseDownEventHandlers(Me)

        LblVersion.Text = "Version " & My.Application.Info.Version.ToString()

        Dim versioning As New VersionChecker()
        versioning.CheckForUpdate()
    End Sub

    Private Sub OpeningForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        boldfont.Dispose()
        lightfont.Dispose()
        titlefont.Dispose()
    End Sub

    Private Sub Control2_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Dim ctrl As Control = TryCast(sender, Control)

        If ctrl IsNot CBBox1 Then
            CBBox1.Checked = False
        End If
        If ctrl IsNot CBBox2 Then
            CBBox2.Checked = False
        End If

        If Not IsChildOf(ctrl, settings) Then
            settings.Visible = False
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

    Private Sub ArtistCtx(action As String, Xcoord As Integer, Ycoord As Integer)
        Select Case action
            Case "Open"
                ctxArtist.Location = New Point(Xcoord, Ycoord + 51)
                ctxArtist.BringToFront()
                Guna2Transition1.ShowSync(ctxArtist, True, Guna.UI2.AnimatorNS.Animation.Transparent)
            Case "Close"

        End Select

    End Sub

    Private Sub CBBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CBBox1.CheckedChanged
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

    Private Sub CountCtx(action As String, Xcoord As Integer, Ycoord As Integer)
        Select Case action
            Case "Open"
                ctxCount.Location = New Point(Xcoord, Ycoord + 51)
                ctxCount.BringToFront()
                Guna2Transition1.ShowSync(ctxCount, True, Guna.UI2.AnimatorNS.Animation.Transparent)
            Case "Close"
        End Select
    End Sub

    Private Sub CBBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CBBox2.CheckedChanged
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

    Private Sub XClicked(sender As Object, e As EventArgs) Handles settings.XClicked
        settings.Visible = False
    End Sub

End Class
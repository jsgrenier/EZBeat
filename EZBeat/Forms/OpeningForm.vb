Public Class OpeningForm
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

    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
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
End Class
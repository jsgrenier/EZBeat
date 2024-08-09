Imports DevExpress.XtraEditors

Public Class CustomProgressForm
    Inherits XtraForm

    Friend WithEvents Guna2ProgressBar1 As Guna.UI2.WinForms.Guna2ProgressBar

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub InitializeComponent()
        Me.Guna2ProgressBar1 = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.SuspendLayout()
        '
        'Guna2ProgressBar1
        '
        Me.Guna2ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2ProgressBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2ProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2ProgressBar1.Name = "Guna2ProgressBar1"
        Me.Guna2ProgressBar1.ShowText = True
        Me.Guna2ProgressBar1.Size = New System.Drawing.Size(398, 66)
        Me.Guna2ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Guna2ProgressBar1.TabIndex = 0
        Me.Guna2ProgressBar1.Text = "Guna2ProgressBar1"
        Me.Guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'CustomProgressForm
        '
        Me.ClientSize = New System.Drawing.Size(398, 66)
        Me.Controls.Add(Me.Guna2ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomProgressForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Downloading Update"
        Me.ResumeLayout(False)

    End Sub
End Class

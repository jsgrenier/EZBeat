<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrackResultControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.PB1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.SuccessImg = New System.Windows.Forms.PictureBox()
        Me.DLBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DurationLbl = New System.Windows.Forms.Label()
        Me.Url = New System.Windows.Forms.Label()
        Me.PlayBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Author = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.ImgBox = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.MainPanel.SuspendLayout()
        Me.PB1.SuspendLayout()
        CType(Me.SuccessImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MainPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.MainPanel.BorderRadius = 6
        Me.MainPanel.Controls.Add(Me.PB1)
        Me.MainPanel.Controls.Add(Me.DLBtn)
        Me.MainPanel.Controls.Add(Me.DurationLbl)
        Me.MainPanel.Controls.Add(Me.Url)
        Me.MainPanel.Controls.Add(Me.PlayBtn)
        Me.MainPanel.Controls.Add(Me.Author)
        Me.MainPanel.Controls.Add(Me.Title)
        Me.MainPanel.Controls.Add(Me.ImgBox)
        Me.MainPanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(827, 60)
        Me.MainPanel.TabIndex = 0
        '
        'PB1
        '
        Me.PB1.Controls.Add(Me.SuccessImg)
        Me.PB1.FillColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PB1.FillThickness = 5
        Me.PB1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PB1.ForeColor = System.Drawing.Color.White
        Me.PB1.Location = New System.Drawing.Point(782, 15)
        Me.PB1.Minimum = 0
        Me.PB1.Name = "PB1"
        Me.PB1.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.PB1.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.PB1.ProgressThickness = 5
        Me.PB1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PB1.Size = New System.Drawing.Size(30, 30)
        Me.PB1.TabIndex = 18
        Me.PB1.Text = "Guna2CircleProgressBar1"
        Me.PB1.Visible = False
        '
        'SuccessImg
        '
        Me.SuccessImg.Image = Global.EZBeat.My.Resources.Resources.icons8_success_30
        Me.SuccessImg.Location = New System.Drawing.Point(0, 0)
        Me.SuccessImg.Name = "SuccessImg"
        Me.SuccessImg.Size = New System.Drawing.Size(30, 30)
        Me.SuccessImg.TabIndex = 19
        Me.SuccessImg.TabStop = False
        Me.SuccessImg.Visible = False
        '
        'DLBtn
        '
        Me.DLBtn.BackColor = System.Drawing.Color.Transparent
        Me.DLBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DLBtn.CustomImages.Image = Global.EZBeat.My.Resources.Resources.icons8_download_24_dark
        Me.DLBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DLBtn.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.DLBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DLBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DLBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DLBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DLBtn.FillColor = System.Drawing.Color.Empty
        Me.DLBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DLBtn.ForeColor = System.Drawing.Color.White
        Me.DLBtn.Location = New System.Drawing.Point(784, 16)
        Me.DLBtn.Name = "DLBtn"
        Me.DLBtn.PressedDepth = 0
        Me.DLBtn.Size = New System.Drawing.Size(24, 24)
        Me.DLBtn.TabIndex = 7
        Me.DLBtn.UseTransparentBackground = True
        '
        'DurationLbl
        '
        Me.DurationLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DurationLbl.AutoSize = True
        Me.DurationLbl.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.DurationLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.DurationLbl.Location = New System.Drawing.Point(703, 19)
        Me.DurationLbl.Name = "DurationLbl"
        Me.DurationLbl.Size = New System.Drawing.Size(37, 17)
        Me.DurationLbl.TabIndex = 6
        Me.DurationLbl.Text = "4:26"
        '
        'Url
        '
        Me.Url.AutoSize = True
        Me.Url.ForeColor = System.Drawing.Color.White
        Me.Url.Location = New System.Drawing.Point(563, 3)
        Me.Url.Name = "Url"
        Me.Url.Size = New System.Drawing.Size(25, 17)
        Me.Url.TabIndex = 5
        Me.Url.Text = "Url"
        Me.Url.Visible = False
        '
        'PlayBtn
        '
        Me.PlayBtn.Animated = True
        Me.PlayBtn.BackColor = System.Drawing.Color.Transparent
        Me.PlayBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlayBtn.CustomImages.Image = Global.EZBeat.My.Resources.Resources.icons8_play_35
        Me.PlayBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.PlayBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.PlayBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.PlayBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PlayBtn.FillColor = System.Drawing.Color.Empty
        Me.PlayBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PlayBtn.ForeColor = System.Drawing.Color.White
        Me.PlayBtn.Location = New System.Drawing.Point(11, 10)
        Me.PlayBtn.Name = "PlayBtn"
        Me.PlayBtn.PressedDepth = 15
        Me.PlayBtn.Size = New System.Drawing.Size(40, 40)
        Me.PlayBtn.TabIndex = 4
        Me.PlayBtn.UseTransparentBackground = True
        '
        'Author
        '
        Me.Author.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Author.AutoSize = True
        Me.Author.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Author.ForeColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Author.Location = New System.Drawing.Point(66, 29)
        Me.Author.MaximumSize = New System.Drawing.Size(500, 23)
        Me.Author.MinimumSize = New System.Drawing.Size(500, 23)
        Me.Author.Name = "Author"
        Me.Author.Size = New System.Drawing.Size(500, 23)
        Me.Author.TabIndex = 3
        '
        'Title
        '
        Me.Title.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(66, 7)
        Me.Title.MaximumSize = New System.Drawing.Size(500, 22)
        Me.Title.MinimumSize = New System.Drawing.Size(500, 22)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(500, 22)
        Me.Title.TabIndex = 2
        '
        'ImgBox
        '
        Me.ImgBox.BorderRadius = 4
        Me.ImgBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ImgBox.ImageRotate = 0!
        Me.ImgBox.Location = New System.Drawing.Point(11, 10)
        Me.ImgBox.Name = "ImgBox"
        Me.ImgBox.Size = New System.Drawing.Size(40, 40)
        Me.ImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox.TabIndex = 0
        Me.ImgBox.TabStop = False
        '
        'TrackResultControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Controls.Add(Me.MainPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "TrackResultControl"
        Me.Size = New System.Drawing.Size(827, 60)
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.PB1.ResumeLayout(False)
        CType(Me.SuccessImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ImgBox As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents Author As Label
    Friend WithEvents PlayBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Url As Label
    Friend WithEvents DurationLbl As Label
    Friend WithEvents DLBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PB1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents SuccessImg As PictureBox
End Class

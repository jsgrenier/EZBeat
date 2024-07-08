<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Author = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.MuteBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.TBVolume = New EZBeat.VolumeTrackBar()
        Me.PauseBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.TBDuration = New EZBeat.CustomTrackBar()
        Me.Title = New System.Windows.Forms.Label()
        Me.Thumbnail = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlayBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Thumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1078, 530)
        Me.MainPanel.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Author)
        Me.Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel1.Controls.Add(Me.MuteBtn)
        Me.Panel1.Controls.Add(Me.TBVolume)
        Me.Panel1.Controls.Add(Me.PauseBtn)
        Me.Panel1.Controls.Add(Me.TBDuration)
        Me.Panel1.Controls.Add(Me.Title)
        Me.Panel1.Controls.Add(Me.Thumbnail)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PlayBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 530)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1078, 93)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Visible = False
        '
        'Author
        '
        Me.Author.AutoSize = True
        Me.Author.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Author.ForeColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Author.Location = New System.Drawing.Point(89, 36)
        Me.Author.Name = "Author"
        Me.Author.Size = New System.Drawing.Size(19, 15)
        Me.Author.TabIndex = 19
        Me.Author.Text = "12"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2PictureBox1.Image = Global.EZBeat.My.Resources.Resources.Spin_1s_30px
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(88, 54)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.Guna2PictureBox1.TabIndex = 18
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.Visible = False
        '
        'MuteBtn
        '
        Me.MuteBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MuteBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
        Me.MuteBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MuteBtn.CustomImages.CheckedImage = Global.EZBeat.My.Resources.Resources.icons8_mute_24_gray
        Me.MuteBtn.CustomImages.HoveredImage = Global.EZBeat.My.Resources.Resources.icons8_audio_24_gray
        Me.MuteBtn.CustomImages.Image = Global.EZBeat.My.Resources.Resources.icons8_audio_24
        Me.MuteBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MuteBtn.CustomImages.ImageOffset = New System.Drawing.Point(0, -2)
        Me.MuteBtn.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.MuteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.MuteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.MuteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.MuteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.MuteBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MuteBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MuteBtn.ForeColor = System.Drawing.Color.White
        Me.MuteBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MuteBtn.Location = New System.Drawing.Point(1042, 56)
        Me.MuteBtn.Name = "MuteBtn"
        Me.MuteBtn.PressedDepth = 0
        Me.MuteBtn.Size = New System.Drawing.Size(24, 24)
        Me.MuteBtn.TabIndex = 17
        '
        'TBVolume
        '
        Me.TBVolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBVolume.FilledColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.TBVolume.HoverColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.TBVolume.Location = New System.Drawing.Point(919, 56)
        Me.TBVolume.Maximum = 100
        Me.TBVolume.Minimum = 0
        Me.TBVolume.Name = "TBVolume"
        Me.TBVolume.Size = New System.Drawing.Size(115, 23)
        Me.TBVolume.TabIndex = 16
        Me.TBVolume.Text = "CustomTrackBar1"
        Me.TBVolume.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TBVolume.ThumbSize = 15
        Me.TBVolume.TrackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.TBVolume.Value = 50
        '
        'PauseBtn
        '
        Me.PauseBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PauseBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PauseBtn.CustomImages.HoveredImage = Global.EZBeat.My.Resources.Resources.icons8_pause_35_dark
        Me.PauseBtn.CustomImages.Image = Global.EZBeat.My.Resources.Resources.icons8_pause_35
        Me.PauseBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PauseBtn.CustomImages.ImageOffset = New System.Drawing.Point(0, -8)
        Me.PauseBtn.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.PauseBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.PauseBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.PauseBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.PauseBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PauseBtn.FillColor = System.Drawing.Color.Empty
        Me.PauseBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PauseBtn.ForeColor = System.Drawing.Color.White
        Me.PauseBtn.Location = New System.Drawing.Point(522, 16)
        Me.PauseBtn.Name = "PauseBtn"
        Me.PauseBtn.PressedDepth = 0
        Me.PauseBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PauseBtn.Size = New System.Drawing.Size(35, 35)
        Me.PauseBtn.TabIndex = 3
        '
        'TBDuration
        '
        Me.TBDuration.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TBDuration.Cursor = System.Windows.Forms.Cursors.Default
        Me.TBDuration.FilledColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.TBDuration.HoverColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.TBDuration.Location = New System.Drawing.Point(219, 57)
        Me.TBDuration.Maximum = 100
        Me.TBDuration.Minimum = 0
        Me.TBDuration.Name = "TBDuration"
        Me.TBDuration.Size = New System.Drawing.Size(640, 23)
        Me.TBDuration.TabIndex = 13
        Me.TBDuration.Text = "CustomTrackBar1"
        Me.TBDuration.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TBDuration.ThumbSize = 15
        Me.TBDuration.TrackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.TBDuration.Value = 30
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(88, 11)
        Me.Title.MaximumSize = New System.Drawing.Size(351, 40)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(25, 20)
        Me.Title.TabIndex = 11
        Me.Title.Text = "12"
        '
        'Thumbnail
        '
        Me.Thumbnail.BorderRadius = 6
        Me.Thumbnail.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Thumbnail.ImageRotate = 0!
        Me.Thumbnail.Location = New System.Drawing.Point(12, 11)
        Me.Thumbnail.Name = "Thumbnail"
        Me.Thumbnail.Size = New System.Drawing.Size(70, 70)
        Me.Thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Thumbnail.TabIndex = 10
        Me.Thumbnail.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(867, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 26)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "00:00:00"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(154, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "00:00:00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PlayBtn
        '
        Me.PlayBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PlayBtn.BackColor = System.Drawing.Color.Transparent
        Me.PlayBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlayBtn.CustomImages.HoveredImage = Global.EZBeat.My.Resources.Resources.icons8_play_35_dark
        Me.PlayBtn.CustomImages.Image = Global.EZBeat.My.Resources.Resources.icons8_play_35
        Me.PlayBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PlayBtn.CustomImages.ImageOffset = New System.Drawing.Point(0, -8)
        Me.PlayBtn.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.PlayBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.PlayBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.PlayBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.PlayBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PlayBtn.FillColor = System.Drawing.Color.Empty
        Me.PlayBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PlayBtn.ForeColor = System.Drawing.Color.White
        Me.PlayBtn.Location = New System.Drawing.Point(522, 16)
        Me.PlayBtn.Name = "PlayBtn"
        Me.PlayBtn.PressedDepth = 0
        Me.PlayBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PlayBtn.Size = New System.Drawing.Size(35, 35)
        Me.PlayBtn.TabIndex = 2
        Me.PlayBtn.Visible = False
        '
        'MainForm
        '
        Me.ActiveGlowColor = System.Drawing.Color.Black
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Appearance.ForeColor = System.Drawing.Color.Gainsboro
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1078, 623)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.IconOptions.Icon = CType(resources.GetObject("MainForm.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(1080, 657)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EZ Beat"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Thumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PlayBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PauseBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Title As Label
    Friend WithEvents Thumbnail As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TBDuration As CustomTrackBar
    Friend WithEvents TBVolume As VolumeTrackBar
    Friend WithEvents MuteBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Author As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
End Class

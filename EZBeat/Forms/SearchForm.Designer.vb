<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchForm
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchForm))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.CBBox2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.SearchMenu1 = New EZBeat.SearchMenu()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DoubleDotSpin1 = New AnimOfDots.DoubleDotSpin()
        Me.DownloadLink = New System.Windows.Forms.Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DotScaling1 = New AnimOfDots.DotScaling()
        Me.Guna2VScrollBar1 = New Guna.UI2.WinForms.Guna2VScrollBar()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DownloadLink.SuspendLayout()
        Me.Guna2ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.CBBox2)
        Me.Guna2Panel1.Controls.Add(Me.CBBox1)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel1.Controls.Add(Me.SearchMenu1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1080, 133)
        Me.Guna2Panel1.TabIndex = 0
        '
        'CBBox2
        '
        Me.CBBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBox2.AutoRoundedCorners = True
        Me.CBBox2.BackColor = System.Drawing.Color.Transparent
        Me.CBBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.CBBox2.BorderRadius = 24
        Me.CBBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.CBBox2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBBox2.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CBBox2.ForeColor = System.Drawing.Color.White
        Me.CBBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBBox2.ItemHeight = 44
        Me.CBBox2.Items.AddRange(New Object() {"20", "40", "60", "80", "100"})
        Me.CBBox2.Location = New System.Drawing.Point(902, 26)
        Me.CBBox2.Name = "CBBox2"
        Me.CBBox2.Size = New System.Drawing.Size(78, 50)
        Me.CBBox2.StartIndex = 0
        Me.CBBox2.TabIndex = 9
        Me.CBBox2.TextOffset = New System.Drawing.Point(10, 0)
        '
        'CBBox1
        '
        Me.CBBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBox1.AutoRoundedCorners = True
        Me.CBBox1.BackColor = System.Drawing.Color.Transparent
        Me.CBBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.CBBox1.BorderRadius = 24
        Me.CBBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.CBBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBBox1.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CBBox1.ForeColor = System.Drawing.Color.White
        Me.CBBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBBox1.ItemHeight = 44
        Me.CBBox1.Items.AddRange(New Object() {"Track", "Artist"})
        Me.CBBox1.Location = New System.Drawing.Point(775, 26)
        Me.CBBox1.Name = "CBBox1"
        Me.CBBox1.Size = New System.Drawing.Size(109, 50)
        Me.CBBox1.StartIndex = 0
        Me.CBBox1.TabIndex = 8
        Me.CBBox1.TextOffset = New System.Drawing.Point(22, 0)
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.EZBeat.My.Resources.Resources.EZLogo
        Me.PictureBox1.Location = New System.Drawing.Point(6, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button3.AutoRoundedCorners = True
        Me.Guna2Button3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Guna2Button3.BorderRadius = 24
        Me.Guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button3.CustomImages.Image = Global.EZBeat.My.Resources.Resources.icons8_download_30
        Me.Guna2Button3.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2Button3.CustomImages.ImageOffset = New System.Drawing.Point(0, -5)
        Me.Guna2Button3.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2Button3.Location = New System.Drawing.Point(998, 77)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.PressedColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2Button3.PressedDepth = 0
        Me.Guna2Button3.Size = New System.Drawing.Size(50, 50)
        Me.Guna2Button3.TabIndex = 5
        Me.Guna2Button3.Visible = False
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Guna2Button2.BorderRadius = 24
        Me.Guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button2.CustomImages.Image = Global.EZBeat.My.Resources.Resources.icons8_settings_30_white
        Me.Guna2Button2.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2Button2.CustomImages.ImageOffset = New System.Drawing.Point(0, -5)
        Me.Guna2Button2.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Button2.Location = New System.Drawing.Point(998, 26)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.PressedColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2Button2.PressedDepth = 0
        Me.Guna2Button2.Size = New System.Drawing.Size(50, 50)
        Me.Guna2Button2.TabIndex = 4
        '
        'SearchMenu1
        '
        Me.SearchMenu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.SearchMenu1.Location = New System.Drawing.Point(200, 92)
        Me.SearchMenu1.Name = "SearchMenu1"
        Me.SearchMenu1.SelectedButton = EZBeat.SearchMenu.ButtonSelection.None
        Me.SearchMenu1.Size = New System.Drawing.Size(400, 40)
        Me.SearchMenu1.TabIndex = 3
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2TextBox1.AutoRoundedCorners = True
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2TextBox1.BorderRadius = 24
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2TextBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2TextBox1.IconLeft = Global.EZBeat.My.Resources.Resources.iconSearch
        Me.Guna2TextBox1.IconLeftOffset = New System.Drawing.Point(8, 0)
        Me.Guna2TextBox1.Location = New System.Drawing.Point(186, 26)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.BorderRadius = 24
        Me.Guna2TextBox1.ShadowDecoration.Depth = 5
        Me.Guna2TextBox1.ShadowDecoration.Enabled = True
        Me.Guna2TextBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.Guna2TextBox1.Size = New System.Drawing.Size(568, 50)
        Me.Guna2TextBox1.TabIndex = 2
        Me.Guna2TextBox1.TextOffset = New System.Drawing.Point(6, 0)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(155, 529)
        Me.Panel1.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(200, 133)
        Me.FlowLayoutPanel1.MinimumSize = New System.Drawing.Size(850, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(880, 529)
        Me.FlowLayoutPanel1.TabIndex = 4
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'DoubleDotSpin1
        '
        Me.DoubleDotSpin1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DoubleDotSpin1.AnimationSpeed = 50
        Me.DoubleDotSpin1.BackColor = System.Drawing.Color.Transparent
        Me.DoubleDotSpin1.Location = New System.Drawing.Point(520, 267)
        Me.DoubleDotSpin1.Name = "DoubleDotSpin1"
        Me.DoubleDotSpin1.PrimaryColor = System.Drawing.Color.Gainsboro
        Me.DoubleDotSpin1.SecondaryColor = System.Drawing.Color.Gainsboro
        Me.DoubleDotSpin1.Size = New System.Drawing.Size(40, 40)
        Me.DoubleDotSpin1.TabIndex = 2
        Me.DoubleDotSpin1.Visible = False
        '
        'DownloadLink
        '
        Me.DownloadLink.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DownloadLink.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.DownloadLink.Controls.Add(Me.Guna2Button1)
        Me.DownloadLink.Controls.Add(Me.Guna2TextBox2)
        Me.DownloadLink.Location = New System.Drawing.Point(200, 133)
        Me.DownloadLink.Name = "DownloadLink"
        Me.DownloadLink.Size = New System.Drawing.Size(880, 529)
        Me.DownloadLink.TabIndex = 5
        Me.DownloadLink.Visible = False
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Empty
        Me.Guna2Button1.BorderRadius = 4
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2Button1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2Button1.Location = New System.Drawing.Point(26, 120)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedDepth = 0
        Me.Guna2Button1.Size = New System.Drawing.Size(150, 40)
        Me.Guna2Button1.TabIndex = 5
        Me.Guna2Button1.Text = "Download"
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2TextBox2.AutoRoundedCorners = True
        Me.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2TextBox2.BorderRadius = 24
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2TextBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(4, 45)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = "Track URL"
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(808, 50)
        Me.Guna2TextBox2.TabIndex = 4
        Me.Guna2TextBox2.TextOffset = New System.Drawing.Point(6, 0)
        '
        'DotScaling1
        '
        Me.DotScaling1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DotScaling1.AnimationSpeed = 80
        Me.DotScaling1.BackColor = System.Drawing.Color.Transparent
        Me.DotScaling1.Colors = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Color.White}
        Me.DotScaling1.Location = New System.Drawing.Point(481, 276)
        Me.DotScaling1.Name = "DotScaling1"
        Me.DotScaling1.Size = New System.Drawing.Size(119, 22)
        Me.DotScaling1.TabIndex = 7
        Me.DotScaling1.Visible = False
        '
        'Guna2VScrollBar1
        '
        Me.Guna2VScrollBar1.BindingContainer = Me.FlowLayoutPanel1
        Me.Guna2VScrollBar1.BorderRadius = 7
        Me.Guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2VScrollBar1.FillOffset = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Guna2VScrollBar1.InUpdate = False
        Me.Guna2VScrollBar1.LargeChange = 10
        Me.Guna2VScrollBar1.Location = New System.Drawing.Point(1062, 133)
        Me.Guna2VScrollBar1.Name = "Guna2VScrollBar1"
        Me.Guna2VScrollBar1.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Guna2VScrollBar1.ScrollbarSize = 14
        Me.Guna2VScrollBar1.Size = New System.Drawing.Size(18, 529)
        Me.Guna2VScrollBar1.TabIndex = 0
        Me.Guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Guna2VScrollBar1.ThumbSize = 5.0!
        Me.Guna2VScrollBar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayToolStripMenuItem, Me.DownloadToolStripMenuItem})
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(148, 72)
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.AutoSize = False
        Me.PlayToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.PlayToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PlayToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(180, 34)
        Me.PlayToolStripMenuItem.Text = "Play"
        '
        'DownloadToolStripMenuItem
        '
        Me.DownloadToolStripMenuItem.AutoSize = False
        Me.DownloadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.DownloadToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DownloadToolStripMenuItem.Name = "DownloadToolStripMenuItem"
        Me.DownloadToolStripMenuItem.Size = New System.Drawing.Size(180, 34)
        Me.DownloadToolStripMenuItem.Text = "Download"
        '
        'SearchForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1080, 662)
        Me.Controls.Add(Me.Guna2VScrollBar1)
        Me.Controls.Add(Me.DotScaling1)
        Me.Controls.Add(Me.DoubleDotSpin1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.DownloadLink)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "SearchForm"
        Me.Text = "EZBeat"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DownloadLink.ResumeLayout(False)
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchMenu1 As SearchMenu
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents DoubleDotSpin1 As AnimOfDots.DoubleDotSpin
    Friend WithEvents DownloadLink As Panel
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DotScaling1 As AnimOfDots.DotScaling
    Friend WithEvents Guna2VScrollBar1 As Guna.UI2.WinForms.Guna2VScrollBar
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents PlayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DownloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CBBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBBox2 As Guna.UI2.WinForms.Guna2ComboBox
End Class

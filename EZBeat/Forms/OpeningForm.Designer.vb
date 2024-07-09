<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OpeningForm
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
        Dim Animation5 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpeningForm))
        Me.OpeningPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.MainFooter = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MainMenu = New System.Windows.Forms.Panel()
        Me.CBBox2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CBBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2RadioButton3 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2RadioButton2 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Animator1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.OpeningPanel.SuspendLayout()
        Me.MainFooter.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpeningPanel
        '
        Me.OpeningPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.OpeningPanel.Controls.Add(Me.Guna2Button2)
        Me.OpeningPanel.Controls.Add(Me.MainFooter)
        Me.OpeningPanel.Controls.Add(Me.MainMenu)
        Me.Animator1.SetDecoration(Me.OpeningPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.OpeningPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpeningPanel.Location = New System.Drawing.Point(0, 0)
        Me.OpeningPanel.Name = "OpeningPanel"
        Me.OpeningPanel.Size = New System.Drawing.Size(1080, 662)
        Me.OpeningPanel.TabIndex = 2
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
        Me.Animator1.SetDecoration(Me.Guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2Button2.Location = New System.Drawing.Point(998, 26)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.PressedColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2Button2.PressedDepth = 0
        Me.Guna2Button2.Size = New System.Drawing.Size(50, 50)
        Me.Guna2Button2.TabIndex = 5
        '
        'MainFooter
        '
        Me.MainFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MainFooter.Controls.Add(Me.Label2)
        Me.Animator1.SetDecoration(Me.MainFooter, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.MainFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MainFooter.Location = New System.Drawing.Point(0, 612)
        Me.MainFooter.Name = "MainFooter"
        Me.MainFooter.Size = New System.Drawing.Size(1080, 50)
        Me.MainFooter.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Animator1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(25, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Version 1.0.5"
        '
        'MainMenu
        '
        Me.MainMenu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MainMenu.Controls.Add(Me.CBBox2)
        Me.MainMenu.Controls.Add(Me.CBBox1)
        Me.MainMenu.Controls.Add(Me.Guna2RadioButton3)
        Me.MainMenu.Controls.Add(Me.PictureBox1)
        Me.MainMenu.Controls.Add(Me.Guna2RadioButton2)
        Me.MainMenu.Controls.Add(Me.Guna2RadioButton1)
        Me.MainMenu.Controls.Add(Me.Guna2Button1)
        Me.MainMenu.Controls.Add(Me.Guna2TextBox1)
        Me.Animator1.SetDecoration(Me.MainMenu, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.MainMenu.Location = New System.Drawing.Point(208, 12)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(665, 485)
        Me.MainMenu.TabIndex = 0
        '
        'CBBox2
        '
        Me.CBBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBox2.AutoRoundedCorners = True
        Me.CBBox2.BackColor = System.Drawing.Color.Transparent
        Me.CBBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.CBBox2.BorderRadius = 24
        Me.Animator1.SetDecoration(Me.CBBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CBBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.CBBox2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox2.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CBBox2.ForeColor = System.Drawing.Color.White
        Me.CBBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox2.ItemHeight = 44
        Me.CBBox2.Items.AddRange(New Object() {"20", "40", "60", "80", "100"})
        Me.CBBox2.Location = New System.Drawing.Point(357, 261)
        Me.CBBox2.Name = "CBBox2"
        Me.CBBox2.Size = New System.Drawing.Size(78, 50)
        Me.CBBox2.StartIndex = 0
        Me.CBBox2.TabIndex = 11
        Me.CBBox2.TextOffset = New System.Drawing.Point(10, 0)
        '
        'CBBox1
        '
        Me.CBBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBox1.AutoRoundedCorners = True
        Me.CBBox1.BackColor = System.Drawing.Color.Transparent
        Me.CBBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.CBBox1.BorderRadius = 24
        Me.Animator1.SetDecoration(Me.CBBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CBBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.CBBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox1.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CBBox1.ForeColor = System.Drawing.Color.White
        Me.CBBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox1.ItemHeight = 44
        Me.CBBox1.Items.AddRange(New Object() {"Track", "Artist"})
        Me.CBBox1.Location = New System.Drawing.Point(230, 261)
        Me.CBBox1.Name = "CBBox1"
        Me.CBBox1.Size = New System.Drawing.Size(109, 50)
        Me.CBBox1.StartIndex = 0
        Me.CBBox1.TabIndex = 10
        Me.CBBox1.TextOffset = New System.Drawing.Point(22, 2)
        '
        'Guna2RadioButton3
        '
        Me.Guna2RadioButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2RadioButton3.AutoSize = True
        Me.Guna2RadioButton3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2RadioButton3.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2RadioButton3.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton3.CheckedState.InnerOffset = -4
        Me.Animator1.SetDecoration(Me.Guna2RadioButton3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2RadioButton3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2RadioButton3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2RadioButton3.Location = New System.Drawing.Point(402, 339)
        Me.Guna2RadioButton3.Name = "Guna2RadioButton3"
        Me.Guna2RadioButton3.Size = New System.Drawing.Size(68, 21)
        Me.Guna2RadioButton3.TabIndex = 6
        Me.Guna2RadioButton3.Text = "Spotify"
        Me.Guna2RadioButton3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2RadioButton3.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton3.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton3.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Animator1.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.EZBeat.My.Resources.Resources.EZLogo
        Me.PictureBox1.Location = New System.Drawing.Point(212, 99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Guna2RadioButton2
        '
        Me.Guna2RadioButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2RadioButton2.AutoSize = True
        Me.Guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton2.CheckedState.InnerOffset = -4
        Me.Animator1.SetDecoration(Me.Guna2RadioButton2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2RadioButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2RadioButton2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2RadioButton2.Location = New System.Drawing.Point(287, 339)
        Me.Guna2RadioButton2.Name = "Guna2RadioButton2"
        Me.Guna2RadioButton2.Size = New System.Drawing.Size(98, 21)
        Me.Guna2RadioButton2.TabIndex = 4
        Me.Guna2RadioButton2.Text = "Soundcloud"
        Me.Guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2RadioButton2.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2RadioButton1
        '
        Me.Guna2RadioButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2RadioButton1.AutoSize = True
        Me.Guna2RadioButton1.Checked = True
        Me.Guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton1.CheckedState.InnerOffset = -4
        Me.Animator1.SetDecoration(Me.Guna2RadioButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2RadioButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2RadioButton1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2RadioButton1.Location = New System.Drawing.Point(194, 339)
        Me.Guna2RadioButton1.Name = "Guna2RadioButton1"
        Me.Guna2RadioButton1.Size = New System.Drawing.Size(77, 21)
        Me.Guna2RadioButton1.TabIndex = 3
        Me.Guna2RadioButton1.TabStop = True
        Me.Guna2RadioButton1.Text = "Youtube"
        Me.Guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2RadioButton1.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Empty
        Me.Guna2Button1.BorderRadius = 4
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Animator1.SetDecoration(Me.Guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Button1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Button1.Location = New System.Drawing.Point(268, 386)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedDepth = 0
        Me.Guna2Button1.Size = New System.Drawing.Size(129, 40)
        Me.Guna2Button1.TabIndex = 2
        Me.Guna2Button1.Text = "Search Beat"
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(0, -1)
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2TextBox1.AutoRoundedCorners = True
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2TextBox1.BorderRadius = 24
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Animator1.SetDecoration(Me.Guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2TextBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2TextBox1.IconLeft = Global.EZBeat.My.Resources.Resources.iconSearch
        Me.Guna2TextBox1.IconLeftOffset = New System.Drawing.Point(8, 0)
        Me.Guna2TextBox1.Location = New System.Drawing.Point(42, 192)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(580, 50)
        Me.Guna2TextBox1.TabIndex = 1
        Me.Guna2TextBox1.TextOffset = New System.Drawing.Point(6, 0)
        '
        'Animator1
        '
        Me.Animator1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.Animator1.Cursor = Nothing
        Animation5.AnimateOnlyDifferences = True
        Animation5.BlindCoeff = CType(resources.GetObject("Animation5.BlindCoeff"), System.Drawing.PointF)
        Animation5.LeafCoeff = 0!
        Animation5.MaxTime = 1.0!
        Animation5.MinTime = 0!
        Animation5.MosaicCoeff = CType(resources.GetObject("Animation5.MosaicCoeff"), System.Drawing.PointF)
        Animation5.MosaicShift = CType(resources.GetObject("Animation5.MosaicShift"), System.Drawing.PointF)
        Animation5.MosaicSize = 0
        Animation5.Padding = New System.Windows.Forms.Padding(0)
        Animation5.RotateCoeff = 0!
        Animation5.RotateLimit = 0!
        Animation5.ScaleCoeff = CType(resources.GetObject("Animation5.ScaleCoeff"), System.Drawing.PointF)
        Animation5.SlideCoeff = CType(resources.GetObject("Animation5.SlideCoeff"), System.Drawing.PointF)
        Animation5.TimeCoeff = 0!
        Animation5.TransparencyCoeff = 1.0!
        Me.Animator1.DefaultAnimation = Animation5
        '
        'OpeningForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1080, 662)
        Me.Controls.Add(Me.OpeningPanel)
        Me.Animator1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OpeningForm"
        Me.Text = "EZBeat"
        Me.OpeningPanel.ResumeLayout(False)
        Me.MainFooter.ResumeLayout(False)
        Me.MainFooter.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpeningPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MainFooter As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents MainMenu As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2RadioButton2 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2RadioButton3 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents CBBox2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CBBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Animator1 As Guna.UI2.WinForms.Guna2Transition
End Class

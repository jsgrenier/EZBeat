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
        Me.components = New System.ComponentModel.Container()
        Dim Animation7 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpeningForm))
        Me.OpeningPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.MainFooter = New System.Windows.Forms.Panel()
        Me.UpdateBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.MainMenu = New System.Windows.Forms.Panel()
        Me.CBBox2 = New Guna.UI2.WinForms.Guna2Button()
        Me.CBBox1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2RadioButton3 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2RadioButton2 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.LinkUpdate = New Sunny.UI.UILinkLabel()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblChecking = New System.Windows.Forms.Label()
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
        Me.Guna2Transition1.SetDecoration(Me.OpeningPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.OpeningPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpeningPanel.Location = New System.Drawing.Point(0, 0)
        Me.OpeningPanel.Name = "OpeningPanel"
        Me.OpeningPanel.Size = New System.Drawing.Size(1080, 662)
        Me.OpeningPanel.TabIndex = 2
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Guna2Button2.BorderRadius = 24
        Me.Guna2Button2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button2.CustomImages.Image = Global.EZBeat.My.Resources.Resources.icons8_settings_30_white
        Me.Guna2Button2.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2Button2.CustomImages.ImageOffset = New System.Drawing.Point(0, -5)
        Me.Guna2Button2.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Button2.TabStop = False
        '
        'MainFooter
        '
        Me.MainFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MainFooter.Controls.Add(Me.LblChecking)
        Me.MainFooter.Controls.Add(Me.Guna2VSeparator1)
        Me.MainFooter.Controls.Add(Me.LinkUpdate)
        Me.MainFooter.Controls.Add(Me.UpdateBtn)
        Me.MainFooter.Controls.Add(Me.LblVersion)
        Me.Guna2Transition1.SetDecoration(Me.MainFooter, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.MainFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MainFooter.Location = New System.Drawing.Point(0, 612)
        Me.MainFooter.Name = "MainFooter"
        Me.MainFooter.Size = New System.Drawing.Size(1080, 50)
        Me.MainFooter.TabIndex = 1
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateBtn.Animated = True
        Me.UpdateBtn.BorderColor = System.Drawing.Color.Empty
        Me.UpdateBtn.BorderRadius = 4
        Me.UpdateBtn.BorderThickness = 1
        Me.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.UpdateBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.UpdateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.UpdateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.UpdateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.UpdateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.UpdateBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.UpdateBtn.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.UpdateBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.UpdateBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.UpdateBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.UpdateBtn.Location = New System.Drawing.Point(922, 5)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.PressedDepth = 0
        Me.UpdateBtn.Size = New System.Drawing.Size(153, 40)
        Me.UpdateBtn.TabIndex = 3
        Me.UpdateBtn.TabStop = False
        Me.UpdateBtn.Text = "Check for update"
        Me.UpdateBtn.TextOffset = New System.Drawing.Point(0, -1)
        Me.UpdateBtn.Visible = False
        '
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.LblVersion, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LblVersion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.LblVersion.Location = New System.Drawing.Point(25, 15)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(106, 20)
        Me.LblVersion.TabIndex = 0
        Me.LblVersion.Text = "Version X.X.X.X"
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
        Me.Guna2Transition1.SetDecoration(Me.MainMenu, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.MainMenu.Location = New System.Drawing.Point(208, 12)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(665, 594)
        Me.MainMenu.TabIndex = 0
        '
        'CBBox2
        '
        Me.CBBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBox2.Animated = True
        Me.CBBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.CBBox2.BorderRadius = 24
        Me.CBBox2.BorderThickness = 1
        Me.CBBox2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
        Me.CBBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox2.CustomImages.Image = Global.EZBeat.My.Resources.Resources.icons8_expand_arrow_26
        Me.CBBox2.CustomImages.ImageSize = New System.Drawing.Size(12, 12)
        Me.Guna2Transition1.SetDecoration(Me.CBBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CBBox2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CBBox2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CBBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CBBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CBBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.CBBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBBox2.ForeColor = System.Drawing.Color.White
        Me.CBBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox2.Location = New System.Drawing.Point(357, 261)
        Me.CBBox2.Name = "CBBox2"
        Me.CBBox2.PressedDepth = 0
        Me.CBBox2.Size = New System.Drawing.Size(78, 50)
        Me.CBBox2.TabIndex = 7
        Me.CBBox2.TabStop = False
        Me.CBBox2.Text = "20"
        Me.CBBox2.TextOffset = New System.Drawing.Point(-6, -2)
        '
        'CBBox1
        '
        Me.CBBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBox1.Animated = True
        Me.CBBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.CBBox1.BorderRadius = 24
        Me.CBBox1.BorderThickness = 1
        Me.CBBox1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
        Me.CBBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox1.CustomImages.Image = Global.EZBeat.My.Resources.Resources.icons8_expand_arrow_26
        Me.CBBox1.CustomImages.ImageSize = New System.Drawing.Size(12, 12)
        Me.Guna2Transition1.SetDecoration(Me.CBBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CBBox1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CBBox1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CBBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CBBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CBBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.CBBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBBox1.ForeColor = System.Drawing.Color.White
        Me.CBBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.CBBox1.Location = New System.Drawing.Point(230, 261)
        Me.CBBox1.Name = "CBBox1"
        Me.CBBox1.PressedDepth = 0
        Me.CBBox1.Size = New System.Drawing.Size(109, 50)
        Me.CBBox1.TabIndex = 6
        Me.CBBox1.TabStop = False
        Me.CBBox1.Text = "Track"
        Me.CBBox1.TextOffset = New System.Drawing.Point(-6, -2)
        '
        'Guna2RadioButton3
        '
        Me.Guna2RadioButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2RadioButton3.Animated = True
        Me.Guna2RadioButton3.AutoSize = True
        Me.Guna2RadioButton3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2RadioButton3.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2RadioButton3.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton3.CheckedState.InnerOffset = -4
        Me.Guna2Transition1.SetDecoration(Me.Guna2RadioButton3, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Transition1.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2RadioButton2.Animated = True
        Me.Guna2RadioButton2.AutoSize = True
        Me.Guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton2.CheckedState.InnerOffset = -4
        Me.Guna2Transition1.SetDecoration(Me.Guna2RadioButton2, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2RadioButton1.Animated = True
        Me.Guna2RadioButton1.AutoSize = True
        Me.Guna2RadioButton1.Checked = True
        Me.Guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton1.CheckedState.InnerOffset = -4
        Me.Guna2Transition1.SetDecoration(Me.Guna2RadioButton1, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2Button1.TabStop = False
        Me.Guna2Button1.Text = "Search Beat"
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(0, -1)
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2TextBox1.Animated = True
        Me.Guna2TextBox1.AutoRoundedCorners = True
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2TextBox1.BorderRadius = 24
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.Guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
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
        Me.Guna2TextBox1.TabStop = False
        Me.Guna2TextBox1.TextOffset = New System.Drawing.Point(6, 0)
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.Cursor = Nothing
        Animation7.AnimateOnlyDifferences = True
        Animation7.BlindCoeff = CType(resources.GetObject("Animation7.BlindCoeff"), System.Drawing.PointF)
        Animation7.LeafCoeff = 0!
        Animation7.MaxTime = 1.0!
        Animation7.MinTime = 0!
        Animation7.MosaicCoeff = CType(resources.GetObject("Animation7.MosaicCoeff"), System.Drawing.PointF)
        Animation7.MosaicShift = CType(resources.GetObject("Animation7.MosaicShift"), System.Drawing.PointF)
        Animation7.MosaicSize = 0
        Animation7.Padding = New System.Windows.Forms.Padding(0)
        Animation7.RotateCoeff = 0!
        Animation7.RotateLimit = 0!
        Animation7.ScaleCoeff = CType(resources.GetObject("Animation7.ScaleCoeff"), System.Drawing.PointF)
        Animation7.SlideCoeff = CType(resources.GetObject("Animation7.SlideCoeff"), System.Drawing.PointF)
        Animation7.TimeCoeff = 0!
        Animation7.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation7
        Me.Guna2Transition1.Interval = 1
        Me.Guna2Transition1.TimeStep = 0.07!
        '
        'LinkUpdate
        '
        Me.LinkUpdate.ActiveLinkColor = System.Drawing.Color.White
        Me.LinkUpdate.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.LinkUpdate, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LinkUpdate.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.LinkUpdate.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.LinkUpdate.ForeColor = System.Drawing.Color.White
        Me.LinkUpdate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkUpdate.LinkColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.LinkUpdate.Location = New System.Drawing.Point(154, 15)
        Me.LinkUpdate.Name = "LinkUpdate"
        Me.LinkUpdate.Size = New System.Drawing.Size(122, 20)
        Me.LinkUpdate.TabIndex = 4
        Me.LinkUpdate.TabStop = True
        Me.LinkUpdate.Text = "Check for update"
        Me.LinkUpdate.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        '
        'Guna2VSeparator1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2VSeparator1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(139, 15)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 20)
        Me.Guna2VSeparator1.TabIndex = 6
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'LblChecking
        '
        Me.LblChecking.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.LblChecking, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LblChecking.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.LblChecking.ForeColor = System.Drawing.Color.White
        Me.LblChecking.Location = New System.Drawing.Point(154, 15)
        Me.LblChecking.Name = "LblChecking"
        Me.LblChecking.Size = New System.Drawing.Size(78, 20)
        Me.LblChecking.TabIndex = 7
        Me.LblChecking.Text = "Checking..."
        Me.LblChecking.Visible = False
        '
        'OpeningForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1080, 662)
        Me.Controls.Add(Me.OpeningPanel)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
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
    Friend WithEvents LblVersion As Label
    Friend WithEvents MainMenu As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2RadioButton2 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2RadioButton3 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents CBBox2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CBBox1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents UpdateBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LinkUpdate As Sunny.UI.UILinkLabel
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblChecking As Label
End Class

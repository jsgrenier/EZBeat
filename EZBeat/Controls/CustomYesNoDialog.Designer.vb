<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomYesNoDialog
    Inherits DevExpress.XtraEditors.XtraMessageBoxForm

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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Yes_Button = New DevExpress.XtraEditors.SimpleButton()
        Me.No_Button = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Yes_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.No_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(178, 101)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 38)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Yes_Button
        '
        Me.Yes_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Yes_Button.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Yes_Button.Location = New System.Drawing.Point(4, 4)
        Me.Yes_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Yes_Button.Name = "OK_Button"
        Me.Yes_Button.Size = New System.Drawing.Size(89, 30)
        Me.Yes_Button.TabIndex = 0
        Me.Yes_Button.Text = "Yes"
        '
        'No_Button
        '
        Me.No_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.No_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.No_Button.Location = New System.Drawing.Point(101, 4)
        Me.No_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.No_Button.Name = "Cancel_Button"
        Me.No_Button.Size = New System.Drawing.Size(89, 30)
        Me.No_Button.TabIndex = 1
        Me.No_Button.Text = "No"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EZBeat.My.Resources.Resources.icons8_update_48
        Me.PictureBox1.Location = New System.Drawing.Point(38, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 38)
        Me.Label1.MaximumSize = New System.Drawing.Size(413, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "A new version is available. Do you want to download and install it?"
        '
        'CustomYesNoDialog
        '
        Me.AcceptButton = Me.Yes_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.No_Button
        Me.ClientSize = New System.Drawing.Size(550, 155)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomYesNoDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update Available"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Yes_Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents No_Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class

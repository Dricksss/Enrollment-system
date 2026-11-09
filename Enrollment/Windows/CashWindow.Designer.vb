<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CashWindow))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssessmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PaymentRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOut = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(827, 613)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentRecordsToolStripMenuItem, Me.ToolStripSeparator1, Me.StudentRecordsToolStripMenuItem, Me.AssessmentToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(45, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'StudentRecordsToolStripMenuItem
        '
        Me.StudentRecordsToolStripMenuItem.Name = "StudentRecordsToolStripMenuItem"
        Me.StudentRecordsToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.StudentRecordsToolStripMenuItem.Text = "Student Records"
        '
        'AssessmentToolStripMenuItem
        '
        Me.AssessmentToolStripMenuItem.Name = "AssessmentToolStripMenuItem"
        Me.AssessmentToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.AssessmentToolStripMenuItem.Text = "Assessment"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(197, 6)
        '
        'PaymentRecordsToolStripMenuItem
        '
        Me.PaymentRecordsToolStripMenuItem.Name = "PaymentRecordsToolStripMenuItem"
        Me.PaymentRecordsToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.PaymentRecordsToolStripMenuItem.Text = "Payment Records"
        '
        'LogOut
        '
        Me.LogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogOut.AutoSize = True
        Me.LogOut.BackColor = System.Drawing.SystemColors.HotTrack
        Me.LogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LogOut.Location = New System.Drawing.Point(735, 5)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(63, 17)
        Me.LogOut.TabIndex = 9
        Me.LogOut.Text = "Log out"
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(256, 5)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblWelcome.Size = New System.Drawing.Size(86, 20)
        Me.lblWelcome.TabIndex = 8
        Me.lblWelcome.Text = "Welcome"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(827, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 613)
        Me.Panel1.TabIndex = 10
        '
        'CashWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 641)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LogOut)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "CashWindow"
        Me.Text = "CashWindow"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssessmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PaymentRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOut As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class

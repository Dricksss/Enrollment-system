<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menuu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menuu))
        Me.Cashier = New System.Windows.Forms.Button()
        Me.Registrar = New System.Windows.Forms.Button()
        Me.Admin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cashier
        '
        Me.Cashier.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Cashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cashier.Location = New System.Drawing.Point(258, 231)
        Me.Cashier.Name = "Cashier"
        Me.Cashier.Size = New System.Drawing.Size(276, 68)
        Me.Cashier.TabIndex = 4
        Me.Cashier.Text = "Cashier Log In"
        Me.Cashier.UseVisualStyleBackColor = True
        '
        'Registrar
        '
        Me.Registrar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registrar.Location = New System.Drawing.Point(258, 138)
        Me.Registrar.Name = "Registrar"
        Me.Registrar.Size = New System.Drawing.Size(276, 68)
        Me.Registrar.TabIndex = 3
        Me.Registrar.Text = "Registrar Log In"
        Me.Registrar.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin.Location = New System.Drawing.Point(258, 43)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(276, 68)
        Me.Admin.TabIndex = 2
        Me.Admin.Text = "Admin Log In"
        Me.Admin.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 348)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Menuu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(580, 348)
        Me.Controls.Add(Me.Cashier)
        Me.Controls.Add(Me.Registrar)
        Me.Controls.Add(Me.Admin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menuu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menuu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Admin As System.Windows.Forms.Button
    Friend WithEvents Registrar As System.Windows.Forms.Button
    Friend WithEvents Cashier As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class

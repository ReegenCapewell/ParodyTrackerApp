<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picBoxHelpBk = New System.Windows.Forms.PictureBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picBoxHelpBk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "how to setup child tracker"
        '
        'picBoxHelpBk
        '
        Me.picBoxHelpBk.Image = CType(resources.GetObject("picBoxHelpBk.Image"), System.Drawing.Image)
        Me.picBoxHelpBk.Location = New System.Drawing.Point(12, 12)
        Me.picBoxHelpBk.Name = "picBoxHelpBk"
        Me.picBoxHelpBk.Size = New System.Drawing.Size(63, 57)
        Me.picBoxHelpBk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxHelpBk.TabIndex = 1
        Me.picBoxHelpBk.TabStop = False
        '
        'lblInstructions
        '
        Me.lblInstructions.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblInstructions.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.lblInstructions.Location = New System.Drawing.Point(35, 156)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(200, 115)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "1. Set home location 2. Adjust safe radius 3. Pair device           4. Allow Noti" &
    "fications"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 142)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 139)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(276, 414)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.picBoxHelpBk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Help"
        Me.Text = "Help"
        CType(Me.picBoxHelpBk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents picBoxHelpBk As PictureBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

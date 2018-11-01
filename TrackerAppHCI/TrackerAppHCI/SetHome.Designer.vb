<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetHome))
        Me.picBoxBkHome = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxRadius = New System.Windows.Forms.TextBox()
        CType(Me.picBoxBkHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBoxBkHome
        '
        Me.picBoxBkHome.Image = CType(resources.GetObject("picBoxBkHome.Image"), System.Drawing.Image)
        Me.picBoxBkHome.Location = New System.Drawing.Point(12, 12)
        Me.picBoxBkHome.Name = "picBoxBkHome"
        Me.picBoxBkHome.Size = New System.Drawing.Size(58, 57)
        Me.picBoxBkHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxBkHome.TabIndex = 0
        Me.picBoxBkHome.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(5, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 52)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Home Address"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBoxRadius
        '
        Me.txtBoxRadius.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtBoxRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxRadius.Location = New System.Drawing.Point(85, 122)
        Me.txtBoxRadius.Multiline = True
        Me.txtBoxRadius.Name = "txtBoxRadius"
        Me.txtBoxRadius.Size = New System.Drawing.Size(179, 23)
        Me.txtBoxRadius.TabIndex = 2
        '
        'SetHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(276, 414)
        Me.Controls.Add(Me.txtBoxRadius)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picBoxBkHome)
        Me.MaximumSize = New System.Drawing.Size(292, 453)
        Me.MinimumSize = New System.Drawing.Size(292, 453)
        Me.Name = "SetHome"
        Me.Text = "SetHome"
        CType(Me.picBoxBkHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBoxBkHome As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxRadius As TextBox
End Class

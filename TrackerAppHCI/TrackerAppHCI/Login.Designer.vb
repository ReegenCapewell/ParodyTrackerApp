<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoxUsername = New System.Windows.Forms.TextBox()
        Me.txtBoxPass = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.lblCredentials = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(44, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 72)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Media Design Tracker"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(50, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'txtBoxUsername
        '
        Me.txtBoxUsername.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtBoxUsername.Location = New System.Drawing.Point(98, 271)
        Me.txtBoxUsername.Name = "txtBoxUsername"
        Me.txtBoxUsername.Size = New System.Drawing.Size(166, 20)
        Me.txtBoxUsername.TabIndex = 4
        '
        'txtBoxPass
        '
        Me.txtBoxPass.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtBoxPass.Location = New System.Drawing.Point(98, 308)
        Me.txtBoxPass.Name = "txtBoxPass"
        Me.txtBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBoxPass.Size = New System.Drawing.Size(166, 20)
        Me.txtBoxPass.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.Location = New System.Drawing.Point(16, 357)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(103, 40)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'BtnRegister
        '
        Me.BtnRegister.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegister.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRegister.Location = New System.Drawing.Point(163, 357)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(101, 40)
        Me.BtnRegister.TabIndex = 7
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'lblCredentials
        '
        Me.lblCredentials.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblCredentials.Location = New System.Drawing.Point(3, 207)
        Me.lblCredentials.Name = "lblCredentials"
        Me.lblCredentials.Size = New System.Drawing.Size(275, 48)
        Me.lblCredentials.TabIndex = 8
        Me.lblCredentials.Text = "Username or Password is incorrect. Please try again."
        Me.lblCredentials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCredentials.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(276, 414)
        Me.Controls.Add(Me.lblCredentials)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtBoxPass)
        Me.Controls.Add(Me.txtBoxUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(292, 453)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(292, 453)
        Me.Name = "Login"
        Me.Text = "Login Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBoxUsername As TextBox
    Friend WithEvents txtBoxPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents BtnRegister As Button
    Friend WithEvents lblCredentials As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        Me.picBoxRegBk = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.txtBoxFName = New System.Windows.Forms.TextBox()
        Me.txtBoxSName = New System.Windows.Forms.TextBox()
        Me.txtBoxDOB = New System.Windows.Forms.TextBox()
        Me.txtBoxAge = New System.Windows.Forms.TextBox()
        Me.txtBoxRegUser = New System.Windows.Forms.TextBox()
        Me.txtBoxRegPass = New System.Windows.Forms.TextBox()
        Me.comBoxGender = New System.Windows.Forms.ComboBox()
        CType(Me.picBoxRegBk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBoxRegBk
        '
        Me.picBoxRegBk.Image = CType(resources.GetObject("picBoxRegBk.Image"), System.Drawing.Image)
        Me.picBoxRegBk.Location = New System.Drawing.Point(12, 12)
        Me.picBoxRegBk.Name = "picBoxRegBk"
        Me.picBoxRegBk.Size = New System.Drawing.Size(47, 46)
        Me.picBoxRegBk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxRegBk.TabIndex = 0
        Me.picBoxRegBk.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Surname"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 34)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "D.O.B."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 34)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Age"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 34)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Gender"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(12, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 34)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Password"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(12, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 34)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Username"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnSignUp.Location = New System.Drawing.Point(84, 363)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(112, 39)
        Me.btnSignUp.TabIndex = 8
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'txtBoxFName
        '
        Me.txtBoxFName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtBoxFName.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.txtBoxFName.Location = New System.Drawing.Point(114, 89)
        Me.txtBoxFName.Name = "txtBoxFName"
        Me.txtBoxFName.Size = New System.Drawing.Size(150, 28)
        Me.txtBoxFName.TabIndex = 9
        '
        'txtBoxSName
        '
        Me.txtBoxSName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtBoxSName.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.txtBoxSName.Location = New System.Drawing.Point(114, 123)
        Me.txtBoxSName.Name = "txtBoxSName"
        Me.txtBoxSName.Size = New System.Drawing.Size(150, 28)
        Me.txtBoxSName.TabIndex = 10
        '
        'txtBoxDOB
        '
        Me.txtBoxDOB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtBoxDOB.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.txtBoxDOB.Location = New System.Drawing.Point(114, 157)
        Me.txtBoxDOB.Name = "txtBoxDOB"
        Me.txtBoxDOB.Size = New System.Drawing.Size(150, 28)
        Me.txtBoxDOB.TabIndex = 11
        '
        'txtBoxAge
        '
        Me.txtBoxAge.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtBoxAge.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.txtBoxAge.Location = New System.Drawing.Point(114, 191)
        Me.txtBoxAge.Name = "txtBoxAge"
        Me.txtBoxAge.Size = New System.Drawing.Size(150, 28)
        Me.txtBoxAge.TabIndex = 12
        '
        'txtBoxRegUser
        '
        Me.txtBoxRegUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtBoxRegUser.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.txtBoxRegUser.Location = New System.Drawing.Point(114, 282)
        Me.txtBoxRegUser.Name = "txtBoxRegUser"
        Me.txtBoxRegUser.Size = New System.Drawing.Size(150, 28)
        Me.txtBoxRegUser.TabIndex = 14
        '
        'txtBoxRegPass
        '
        Me.txtBoxRegPass.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtBoxRegPass.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.txtBoxRegPass.Location = New System.Drawing.Point(114, 316)
        Me.txtBoxRegPass.Name = "txtBoxRegPass"
        Me.txtBoxRegPass.Size = New System.Drawing.Size(150, 28)
        Me.txtBoxRegPass.TabIndex = 15
        '
        'comBoxGender
        '
        Me.comBoxGender.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.comBoxGender.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.comBoxGender.FormattingEnabled = True
        Me.comBoxGender.Items.AddRange(New Object() {"Male", "Female", "Rather Not Say"})
        Me.comBoxGender.Location = New System.Drawing.Point(114, 225)
        Me.comBoxGender.Name = "comBoxGender"
        Me.comBoxGender.Size = New System.Drawing.Size(150, 28)
        Me.comBoxGender.TabIndex = 16
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(276, 414)
        Me.Controls.Add(Me.comBoxGender)
        Me.Controls.Add(Me.txtBoxRegPass)
        Me.Controls.Add(Me.txtBoxRegUser)
        Me.Controls.Add(Me.txtBoxAge)
        Me.Controls.Add(Me.txtBoxDOB)
        Me.Controls.Add(Me.txtBoxSName)
        Me.Controls.Add(Me.txtBoxFName)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picBoxRegBk)
        Me.Name = "Registration"
        Me.Text = "Registration"
        CType(Me.picBoxRegBk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBoxRegBk As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents txtBoxFName As TextBox
    Friend WithEvents txtBoxSName As TextBox
    Friend WithEvents txtBoxDOB As TextBox
    Friend WithEvents txtBoxAge As TextBox
    Friend WithEvents txtBoxRegUser As TextBox
    Friend WithEvents txtBoxRegPass As TextBox
    Friend WithEvents comBoxGender As ComboBox
End Class

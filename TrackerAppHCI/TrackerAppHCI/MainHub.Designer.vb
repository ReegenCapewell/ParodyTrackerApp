<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainHub
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainHub))
        Me.picBoxSetngs = New System.Windows.Forms.PictureBox()
        Me.picBoxHelp = New System.Windows.Forms.PictureBox()
        Me.picBoxMap = New System.Windows.Forms.PictureBox()
        Me.picBoxPerson = New System.Windows.Forms.PictureBox()
        Me.PicBoxRed = New System.Windows.Forms.PictureBox()
        Me.picBoxGreen = New System.Windows.Forms.PictureBox()
        Me.picBoxAmber = New System.Windows.Forms.PictureBox()
        Me.picBoxDanger = New System.Windows.Forms.PictureBox()
        CType(Me.picBoxSetngs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxAmber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDanger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBoxSetngs
        '
        Me.picBoxSetngs.Image = CType(resources.GetObject("picBoxSetngs.Image"), System.Drawing.Image)
        Me.picBoxSetngs.Location = New System.Drawing.Point(12, 12)
        Me.picBoxSetngs.Name = "picBoxSetngs"
        Me.picBoxSetngs.Size = New System.Drawing.Size(58, 54)
        Me.picBoxSetngs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxSetngs.TabIndex = 0
        Me.picBoxSetngs.TabStop = False
        '
        'picBoxHelp
        '
        Me.picBoxHelp.Image = CType(resources.GetObject("picBoxHelp.Image"), System.Drawing.Image)
        Me.picBoxHelp.Location = New System.Drawing.Point(206, 12)
        Me.picBoxHelp.Name = "picBoxHelp"
        Me.picBoxHelp.Size = New System.Drawing.Size(58, 54)
        Me.picBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxHelp.TabIndex = 1
        Me.picBoxHelp.TabStop = False
        '
        'picBoxMap
        '
        Me.picBoxMap.Image = CType(resources.GetObject("picBoxMap.Image"), System.Drawing.Image)
        Me.picBoxMap.Location = New System.Drawing.Point(-2, 92)
        Me.picBoxMap.Name = "picBoxMap"
        Me.picBoxMap.Size = New System.Drawing.Size(281, 136)
        Me.picBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxMap.TabIndex = 2
        Me.picBoxMap.TabStop = False
        '
        'picBoxPerson
        '
        Me.picBoxPerson.Image = CType(resources.GetObject("picBoxPerson.Image"), System.Drawing.Image)
        Me.picBoxPerson.Location = New System.Drawing.Point(97, 234)
        Me.picBoxPerson.Name = "picBoxPerson"
        Me.picBoxPerson.Size = New System.Drawing.Size(91, 91)
        Me.picBoxPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxPerson.TabIndex = 3
        Me.picBoxPerson.TabStop = False
        '
        'PicBoxRed
        '
        Me.PicBoxRed.BackColor = System.Drawing.Color.Red
        Me.PicBoxRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBoxRed.Location = New System.Drawing.Point(97, 341)
        Me.PicBoxRed.Name = "PicBoxRed"
        Me.PicBoxRed.Size = New System.Drawing.Size(91, 50)
        Me.PicBoxRed.TabIndex = 4
        Me.PicBoxRed.TabStop = False
        '
        'picBoxGreen
        '
        Me.picBoxGreen.BackColor = System.Drawing.Color.Green
        Me.picBoxGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBoxGreen.Location = New System.Drawing.Point(97, 341)
        Me.picBoxGreen.Name = "picBoxGreen"
        Me.picBoxGreen.Size = New System.Drawing.Size(91, 50)
        Me.picBoxGreen.TabIndex = 5
        Me.picBoxGreen.TabStop = False
        '
        'picBoxAmber
        '
        Me.picBoxAmber.BackColor = System.Drawing.Color.Orange
        Me.picBoxAmber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBoxAmber.Location = New System.Drawing.Point(97, 341)
        Me.picBoxAmber.Name = "picBoxAmber"
        Me.picBoxAmber.Size = New System.Drawing.Size(91, 50)
        Me.picBoxAmber.TabIndex = 6
        Me.picBoxAmber.TabStop = False
        '
        'picBoxDanger
        '
        Me.picBoxDanger.BackColor = System.Drawing.Color.Black
        Me.picBoxDanger.Image = CType(resources.GetObject("picBoxDanger.Image"), System.Drawing.Image)
        Me.picBoxDanger.Location = New System.Drawing.Point(123, 283)
        Me.picBoxDanger.Name = "picBoxDanger"
        Me.picBoxDanger.Size = New System.Drawing.Size(39, 42)
        Me.picBoxDanger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxDanger.TabIndex = 7
        Me.picBoxDanger.TabStop = False
        Me.picBoxDanger.Visible = False
        '
        'MainHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(276, 414)
        Me.Controls.Add(Me.PicBoxRed)
        Me.Controls.Add(Me.picBoxDanger)
        Me.Controls.Add(Me.picBoxGreen)
        Me.Controls.Add(Me.picBoxAmber)
        Me.Controls.Add(Me.picBoxPerson)
        Me.Controls.Add(Me.picBoxMap)
        Me.Controls.Add(Me.picBoxHelp)
        Me.Controls.Add(Me.picBoxSetngs)
        Me.MaximumSize = New System.Drawing.Size(292, 453)
        Me.MinimumSize = New System.Drawing.Size(292, 453)
        Me.Name = "MainHub"
        Me.Text = "MainHub"
        CType(Me.picBoxSetngs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxAmber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxDanger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBoxSetngs As PictureBox
    Friend WithEvents picBoxHelp As PictureBox
    Friend WithEvents picBoxMap As PictureBox
    Friend WithEvents picBoxPerson As PictureBox
    Friend WithEvents PicBoxRed As PictureBox
    Friend WithEvents picBoxGreen As PictureBox
    Friend WithEvents picBoxAmber As PictureBox
    Friend WithEvents picBoxDanger As PictureBox
End Class

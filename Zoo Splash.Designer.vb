<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.picStorks = New System.Windows.Forms.PictureBox()
        Me.picIguanas = New System.Windows.Forms.PictureBox()
        Me.tmrExit = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picStorks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIguanas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.PaleGreen
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(180, 70)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(113, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Crighton Zoo"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.BackColor = System.Drawing.Color.PaleGreen
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Red
        Me.lblMsg.Location = New System.Drawing.Point(180, 115)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(206, 20)
        Me.lblMsg.TabIndex = 1
        Me.lblMsg.Text = "Come visit our residents!"
        '
        'picStorks
        '
        Me.picStorks.Image = Global.Splash_Project.My.Resources.Resources.Storks
        Me.picStorks.Location = New System.Drawing.Point(272, 161)
        Me.picStorks.Name = "picStorks"
        Me.picStorks.Size = New System.Drawing.Size(116, 112)
        Me.picStorks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStorks.TabIndex = 3
        Me.picStorks.TabStop = False
        '
        'picIguanas
        '
        Me.picIguanas.Image = Global.Splash_Project.My.Resources.Resources.Iguanas
        Me.picIguanas.Location = New System.Drawing.Point(12, 32)
        Me.picIguanas.Name = "picIguanas"
        Me.picIguanas.Size = New System.Drawing.Size(121, 119)
        Me.picIguanas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIguanas.TabIndex = 2
        Me.picIguanas.TabStop = False
        '
        'tmrExit
        '
        Me.tmrExit.Interval = 6000
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(389, 301)
        Me.Controls.Add(Me.picStorks)
        Me.Controls.Add(Me.picIguanas)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmSplash"
        Me.Text = "Crighton Zoo"
        CType(Me.picStorks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIguanas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblMsg As Label
    Friend WithEvents picIguanas As PictureBox
    Friend WithEvents picStorks As PictureBox
    Friend WithEvents tmrExit As Timer
End Class

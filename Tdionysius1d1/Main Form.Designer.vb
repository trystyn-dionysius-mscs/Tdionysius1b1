<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblStraw = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblRasp = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRasp = New System.Windows.Forms.TextBox()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.txtStraw = New System.Windows.Forms.TextBox()
        Me.txtProjIncrease = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblStraw
        '
        Me.lblStraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStraw.Location = New System.Drawing.Point(214, 80)
        Me.lblStraw.Name = "lblStraw"
        Me.lblStraw.Size = New System.Drawing.Size(83, 20)
        Me.lblStraw.TabIndex = 6
        '
        'lblBlue
        '
        Me.lblBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBlue.Location = New System.Drawing.Point(214, 117)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(83, 20)
        Me.lblBlue.TabIndex = 9
        '
        'lblRasp
        '
        Me.lblRasp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRasp.Location = New System.Drawing.Point(214, 155)
        Me.lblRasp.Name = "lblRasp"
        Me.lblRasp.Size = New System.Drawing.Size(83, 20)
        Me.lblRasp.TabIndex = 12
        '
        'lblS
        '
        Me.lblS.AutoSize = True
        Me.lblS.Location = New System.Drawing.Point(26, 83)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(69, 13)
        Me.lblS.TabIndex = 4
        Me.lblS.Text = "&StrawBerries:"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(26, 124)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(62, 13)
        Me.lblB.TabIndex = 7
        Me.lblB.Text = "&Blueberries:"
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Location = New System.Drawing.Point(26, 162)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(66, 13)
        Me.lblR.TabIndex = 10
        Me.lblR.Text = "&Raspberries:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Projected &increase % (indecimal form):"
        '
        'txtRasp
        '
        Me.txtRasp.Location = New System.Drawing.Point(98, 155)
        Me.txtRasp.Name = "txtRasp"
        Me.txtRasp.Size = New System.Drawing.Size(83, 20)
        Me.txtRasp.TabIndex = 11
        '
        'txtBlue
        '
        Me.txtBlue.Location = New System.Drawing.Point(98, 117)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(83, 20)
        Me.txtBlue.TabIndex = 8
        '
        'txtStraw
        '
        Me.txtStraw.Location = New System.Drawing.Point(98, 80)
        Me.txtStraw.Name = "txtStraw"
        Me.txtStraw.Size = New System.Drawing.Size(83, 20)
        Me.txtStraw.TabIndex = 5
        '
        'txtProjIncrease
        '
        Me.txtProjIncrease.Location = New System.Drawing.Point(249, 23)
        Me.txtProjIncrease.Name = "txtProjIncrease"
        Me.txtProjIncrease.Size = New System.Drawing.Size(48, 20)
        Me.txtProjIncrease.TabIndex = 1
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 192)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 13
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(98, 192)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(179, 192)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(260, 192)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Current Sales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(216, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Projected Sales"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 242)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtProjIncrease)
        Me.Controls.Add(Me.txtStraw)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtRasp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblS)
        Me.Controls.Add(Me.lblRasp)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblStraw)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cranston Berries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStraw As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblRasp As Label
    Friend WithEvents lblS As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblR As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRasp As TextBox
    Friend WithEvents txtBlue As TextBox
    Friend WithEvents txtStraw As TextBox
    Friend WithEvents txtProjIncrease As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class

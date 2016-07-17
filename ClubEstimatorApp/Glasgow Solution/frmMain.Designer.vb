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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkBall = New System.Windows.Forms.CheckBox()
        Me.chkTennis = New System.Windows.Forms.CheckBox()
        Me.chkGolf = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtBasicFee = New System.Windows.Forms.TextBox()
        Me.lblAdditionalFee = New System.Windows.Forms.TextBox()
        Me.lblMonthlyDues = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(113, 137)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Membership"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 69)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Family"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 34)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Single"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkBall)
        Me.GroupBox2.Controls.Add(Me.chkTennis)
        Me.GroupBox2.Controls.Add(Me.chkGolf)
        Me.GroupBox2.Location = New System.Drawing.Point(190, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(129, 137)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional"
        '
        'chkBall
        '
        Me.chkBall.AutoSize = True
        Me.chkBall.Location = New System.Drawing.Point(6, 101)
        Me.chkBall.Name = "chkBall"
        Me.chkBall.Size = New System.Drawing.Size(83, 17)
        Me.chkBall.TabIndex = 4
        Me.chkBall.Text = "Racquetball"
        Me.chkBall.UseVisualStyleBackColor = True
        '
        'chkTennis
        '
        Me.chkTennis.AutoSize = True
        Me.chkTennis.Location = New System.Drawing.Point(6, 69)
        Me.chkTennis.Name = "chkTennis"
        Me.chkTennis.Size = New System.Drawing.Size(58, 17)
        Me.chkTennis.TabIndex = 3
        Me.chkTennis.Text = "Tennis"
        Me.chkTennis.UseVisualStyleBackColor = True
        '
        'chkGolf
        '
        Me.chkGolf.AutoSize = True
        Me.chkGolf.Location = New System.Drawing.Point(6, 34)
        Me.chkGolf.Name = "chkGolf"
        Me.chkGolf.Size = New System.Drawing.Size(45, 17)
        Me.chkGolf.TabIndex = 2
        Me.chkGolf.Text = "Golf"
        Me.chkGolf.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Basic Fee:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Addtional Fee:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Monthly Dues:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(190, 297)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(89, 45)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(285, 297)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(54, 45)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtBasicFee
        '
        Me.txtBasicFee.Location = New System.Drawing.Point(26, 226)
        Me.txtBasicFee.Multiline = True
        Me.txtBasicFee.Name = "txtBasicFee"
        Me.txtBasicFee.Size = New System.Drawing.Size(93, 32)
        Me.txtBasicFee.TabIndex = 6
        '
        'lblAdditionalFee
        '
        Me.lblAdditionalFee.Location = New System.Drawing.Point(190, 226)
        Me.lblAdditionalFee.Multiline = True
        Me.lblAdditionalFee.Name = "lblAdditionalFee"
        Me.lblAdditionalFee.Size = New System.Drawing.Size(100, 32)
        Me.lblAdditionalFee.TabIndex = 7
        '
        'lblMonthlyDues
        '
        Me.lblMonthlyDues.Location = New System.Drawing.Point(26, 297)
        Me.lblMonthlyDues.Multiline = True
        Me.lblMonthlyDues.Name = "lblMonthlyDues"
        Me.lblMonthlyDues.Size = New System.Drawing.Size(100, 34)
        Me.lblMonthlyDues.TabIndex = 8
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 439)
        Me.Controls.Add(Me.lblMonthlyDues)
        Me.Controls.Add(Me.lblAdditionalFee)
        Me.Controls.Add(Me.txtBasicFee)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkBall As System.Windows.Forms.CheckBox
    Friend WithEvents chkTennis As System.Windows.Forms.CheckBox
    Friend WithEvents chkGolf As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtBasicFee As System.Windows.Forms.TextBox
    Friend WithEvents lblAdditionalFee As System.Windows.Forms.TextBox
    Friend WithEvents lblMonthlyDues As System.Windows.Forms.TextBox

End Class

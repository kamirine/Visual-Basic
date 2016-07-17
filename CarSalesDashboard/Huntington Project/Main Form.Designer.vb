<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.TB2 = New System.Windows.Forms.TextBox()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.Lbl6 = New System.Windows.Forms.Label()
        Me.Lbl5 = New System.Windows.Forms.Label()
        Me.Tb3 = New System.Windows.Forms.TextBox()
        Me.Tb4 = New System.Windows.Forms.TextBox()
        Me.Tb5 = New System.Windows.Forms.TextBox()
        Me.Tb6 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualStudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Location = New System.Drawing.Point(177, 25)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(18, 13)
        Me.Lbl1.TabIndex = 1
        Me.Lbl1.Text = "ID"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Location = New System.Drawing.Point(270, 25)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(71, 13)
        Me.Lbl2.TabIndex = 2
        Me.Lbl2.Text = " Number Sold"
        '
        'TB1
        '
        Me.TB1.Location = New System.Drawing.Point(180, 42)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(75, 20)
        Me.TB1.TabIndex = 3
        '
        'TB2
        '
        Me.TB2.Location = New System.Drawing.Point(273, 42)
        Me.TB2.Name = "TB2"
        Me.TB2.Size = New System.Drawing.Size(75, 20)
        Me.TB2.TabIndex = 4
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(180, 88)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 5
        Me.Btn1.Text = "Calculate"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(273, 88)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 23)
        Me.Btn2.TabIndex = 6
        Me.Btn2.Text = "Close"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Location = New System.Drawing.Point(12, 166)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(161, 13)
        Me.Lbl3.TabIndex = 7
        Me.Lbl3.Text = " Cars sold by full-time employees:"
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Location = New System.Drawing.Point(12, 202)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(166, 13)
        Me.Lbl4.TabIndex = 8
        Me.Lbl4.Text = " Cars sold by part-time employees:"
        '
        'Lbl6
        '
        Me.Lbl6.AutoSize = True
        Me.Lbl6.Location = New System.Drawing.Point(12, 279)
        Me.Lbl6.Name = "Lbl6"
        Me.Lbl6.Size = New System.Drawing.Size(167, 13)
        Me.Lbl6.TabIndex = 9
        Me.Lbl6.Text = " Cars sold by used car employees:"
        '
        'Lbl5
        '
        Me.Lbl5.AutoSize = True
        Me.Lbl5.Location = New System.Drawing.Point(12, 241)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(164, 13)
        Me.Lbl5.TabIndex = 10
        Me.Lbl5.Text = " Cars sold by new car employees:"
        '
        'Tb3
        '
        Me.Tb3.Location = New System.Drawing.Point(197, 159)
        Me.Tb3.Name = "Tb3"
        Me.Tb3.ReadOnly = True
        Me.Tb3.Size = New System.Drawing.Size(74, 20)
        Me.Tb3.TabIndex = 11
        '
        'Tb4
        '
        Me.Tb4.Location = New System.Drawing.Point(197, 199)
        Me.Tb4.Name = "Tb4"
        Me.Tb4.ReadOnly = True
        Me.Tb4.Size = New System.Drawing.Size(74, 20)
        Me.Tb4.TabIndex = 12
        '
        'Tb5
        '
        Me.Tb5.Location = New System.Drawing.Point(197, 238)
        Me.Tb5.Name = "Tb5"
        Me.Tb5.ReadOnly = True
        Me.Tb5.Size = New System.Drawing.Size(74, 20)
        Me.Tb5.TabIndex = 13
        '
        'Tb6
        '
        Me.Tb6.Location = New System.Drawing.Point(197, 276)
        Me.Tb6.Name = "Tb6"
        Me.Tb6.ReadOnly = True
        Me.Tb6.Size = New System.Drawing.Size(74, 20)
        Me.Tb6.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Huntington_Project.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(13, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 112)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(373, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MS1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripMenuItem1.Text = "Menu"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveAsToolStripMenuItem.Text = "save as"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualStudioToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "about"
        '
        'VisualStudioToolStripMenuItem
        '
        Me.VisualStudioToolStripMenuItem.Name = "VisualStudioToolStripMenuItem"
        Me.VisualStudioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VisualStudioToolStripMenuItem.Text = "visual studio"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 318)
        Me.Controls.Add(Me.Tb6)
        Me.Controls.Add(Me.Tb5)
        Me.Controls.Add(Me.Tb4)
        Me.Controls.Add(Me.Tb3)
        Me.Controls.Add(Me.Lbl5)
        Me.Controls.Add(Me.Lbl6)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.TB2)
        Me.Controls.Add(Me.TB1)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Huntington Motors"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents Lbl2 As System.Windows.Forms.Label
    Friend WithEvents TB1 As System.Windows.Forms.TextBox
    Friend WithEvents TB2 As System.Windows.Forms.TextBox
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Lbl3 As System.Windows.Forms.Label
    Friend WithEvents Lbl4 As System.Windows.Forms.Label
    Friend WithEvents Lbl6 As System.Windows.Forms.Label
    Friend WithEvents Lbl5 As System.Windows.Forms.Label
    Friend WithEvents Tb3 As System.Windows.Forms.TextBox
    Friend WithEvents Tb4 As System.Windows.Forms.TextBox
    Friend WithEvents Tb5 As System.Windows.Forms.TextBox
    Friend WithEvents Tb6 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualStudioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

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
        Me.lblItemList = New System.Windows.Forms.Label()
        Me.lblShpCrt = New System.Windows.Forms.Label()
        Me.ItemShop = New System.Windows.Forms.TextBox()
        Me.ItemList = New System.Windows.Forms.ListBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnChckout = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSrch = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNotify = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuPassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtPassword = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblItemList
        '
        Me.lblItemList.AutoSize = True
        Me.lblItemList.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemList.Location = New System.Drawing.Point(59, 165)
        Me.lblItemList.Name = "lblItemList"
        Me.lblItemList.Size = New System.Drawing.Size(116, 18)
        Me.lblItemList.TabIndex = 0
        Me.lblItemList.Text = "Items For Sale "
        '
        'lblShpCrt
        '
        Me.lblShpCrt.AutoSize = True
        Me.lblShpCrt.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShpCrt.Location = New System.Drawing.Point(548, 165)
        Me.lblShpCrt.Name = "lblShpCrt"
        Me.lblShpCrt.Size = New System.Drawing.Size(101, 18)
        Me.lblShpCrt.TabIndex = 2
        Me.lblShpCrt.Text = "Shoping Cart"
        '
        'ItemShop
        '
        Me.ItemShop.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ItemShop.Location = New System.Drawing.Point(507, 188)
        Me.ItemShop.Multiline = True
        Me.ItemShop.Name = "ItemShop"
        Me.ItemShop.Size = New System.Drawing.Size(176, 196)
        Me.ItemShop.TabIndex = 3
        '
        'ItemList
        '
        Me.ItemList.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ItemList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemList.FormattingEnabled = True
        Me.ItemList.ItemHeight = 16
        Me.ItemList.Items.AddRange(New Object() {"Cricket Ball", "Cricket Bat", "Batting Gloves", "Batting Pads", "Cricket Helmet", "Cricket Shoes", "Cricket Bags ", "Aero Strippers"})
        Me.ItemList.Location = New System.Drawing.Point(24, 188)
        Me.ItemList.Name = "ItemList"
        Me.ItemList.Size = New System.Drawing.Size(183, 196)
        Me.ItemList.TabIndex = 4
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.GreenYellow
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(226, 247)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(106, 38)
        Me.btnAddItem.TabIndex = 5
        Me.btnAddItem.Text = "Add To Cart"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnChckout
        '
        Me.btnChckout.BackColor = System.Drawing.Color.Salmon
        Me.btnChckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChckout.Location = New System.Drawing.Point(378, 247)
        Me.btnChckout.Name = "btnChckout"
        Me.btnChckout.Size = New System.Drawing.Size(106, 38)
        Me.btnChckout.TabIndex = 6
        Me.btnChckout.Text = "Checkout"
        Me.btnChckout.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(322, 316)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(49, 20)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.SkyBlue
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(301, 339)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 32)
        Me.txtTotal.TabIndex = 8
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(216, 168)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(110, 14)
        Me.lblSearch.TabIndex = 9
        Me.lblSearch.Text = "Enter Search Value"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(348, 169)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(35, 14)
        Me.lblPrice.TabIndex = 10
        Me.lblPrice.Text = "Price"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(409, 172)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(92, 45)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSrch
        '
        Me.txtSrch.Location = New System.Drawing.Point(219, 188)
        Me.txtSrch.Name = "txtSrch"
        Me.txtSrch.Size = New System.Drawing.Size(107, 20)
        Me.txtSrch.TabIndex = 12
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(332, 188)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(69, 20)
        Me.txtPrice.TabIndex = 13
        '
        'PicBox
        '
        Me.PicBox.Image = Global.CricketShopZone.My.Resources.Resources.CricketEquipmens
        Me.PicBox.Location = New System.Drawing.Point(0, 27)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(270, 134)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 14
        Me.PicBox.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Papyrus", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Blue
        Me.lblName.Location = New System.Drawing.Point(291, 55)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(369, 58)
        Me.lblName.TabIndex = 15
        Me.lblName.Text = "Cricket Shop Zone"
        '
        'lblNotify
        '
        Me.lblNotify.AutoSize = True
        Me.lblNotify.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotify.ForeColor = System.Drawing.Color.Firebrick
        Me.lblNotify.Location = New System.Drawing.Point(126, 8)
        Me.lblNotify.Name = "lblNotify"
        Me.lblNotify.Size = New System.Drawing.Size(158, 16)
        Me.lblNotify.TabIndex = 18
        Me.lblNotify.Text = "You have only 3 Attempts"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuPassword, Me.MenuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(695, 25)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuPassword
        '
        Me.MenuPassword.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtPassword, Me.ToolStripMenuItem1})
        Me.MenuPassword.Name = "MenuPassword"
        Me.MenuPassword.Size = New System.Drawing.Size(76, 21)
        Me.MenuPassword.Text = "&Password"
        '
        'txtPassword
        '
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem1.Text = "Submit"
        '
        'MenuExit
        '
        Me.MenuExit.Name = "MenuExit"
        Me.MenuExit.Size = New System.Drawing.Size(40, 21)
        Me.MenuExit.Text = "&Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(695, 439)
        Me.Controls.Add(Me.lblNotify)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PicBox)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtSrch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnChckout)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.ItemList)
        Me.Controls.Add(Me.ItemShop)
        Me.Controls.Add(Me.lblShpCrt)
        Me.Controls.Add(Me.lblItemList)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblItemList As System.Windows.Forms.Label
    Friend WithEvents lblShpCrt As System.Windows.Forms.Label
    Friend WithEvents ItemShop As System.Windows.Forms.TextBox
    Friend WithEvents ItemList As System.Windows.Forms.ListBox
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents btnChckout As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSrch As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblNotify As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuPassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtPassword As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class

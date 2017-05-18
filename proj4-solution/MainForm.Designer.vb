<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.addItemButton = New System.Windows.Forms.Button()
        Me.availableListView = New System.Windows.Forms.ListView()
        Me.itemCHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.priceCHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.deleteItemButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.orderListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.discountsGroupBox = New System.Windows.Forms.GroupBox()
        Me.otherCheck = New System.Windows.Forms.CheckBox()
        Me.discountsCheck = New System.Windows.Forms.CheckBox()
        Me.clubCheck = New System.Windows.Forms.RadioButton()
        Me.staffCheck = New System.Windows.Forms.RadioButton()
        Me.otherDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.discountLabel = New System.Windows.Forms.Label()
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.subTotalLabel = New System.Windows.Forms.Label()
        Me.testLabel = New System.Windows.Forms.Label()
        Me.totalButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.dollarPictureBox = New System.Windows.Forms.PictureBox()
        Me.discountsGroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dollarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(250, 189)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'addItemButton
        '
        Me.addItemButton.Location = New System.Drawing.Point(49, 247)
        Me.addItemButton.Name = "addItemButton"
        Me.addItemButton.Size = New System.Drawing.Size(106, 23)
        Me.addItemButton.TabIndex = 0
        Me.addItemButton.Text = "Add &List Item"
        Me.addItemButton.UseVisualStyleBackColor = True
        '
        'availableListView
        '
        Me.availableListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.itemCHeader, Me.priceCHeader})
        Me.availableListView.Location = New System.Drawing.Point(14, 58)
        Me.availableListView.Name = "availableListView"
        Me.availableListView.Size = New System.Drawing.Size(232, 181)
        Me.availableListView.TabIndex = 1
        Me.availableListView.UseCompatibleStateImageBehavior = False
        Me.availableListView.View = System.Windows.Forms.View.Details
        '
        'itemCHeader
        '
        Me.itemCHeader.Text = "Item"
        Me.itemCHeader.Width = 109
        '
        'priceCHeader
        '
        Me.priceCHeader.Text = "Item Price"
        Me.priceCHeader.Width = 103
        '
        'deleteItemButton
        '
        Me.deleteItemButton.Location = New System.Drawing.Point(49, 275)
        Me.deleteItemButton.Name = "deleteItemButton"
        Me.deleteItemButton.Size = New System.Drawing.Size(106, 23)
        Me.deleteItemButton.TabIndex = 2
        Me.deleteItemButton.Text = "&Delete List Item"
        Me.deleteItemButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(250, 76)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 3
        Me.addButton.Text = "&Add >>"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(250, 104)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(75, 23)
        Me.removeButton.TabIndex = 5
        Me.removeButton.Text = "&Remove"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'orderListView
        '
        Me.orderListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.orderListView.Location = New System.Drawing.Point(332, 58)
        Me.orderListView.Name = "orderListView"
        Me.orderListView.Size = New System.Drawing.Size(223, 181)
        Me.orderListView.TabIndex = 4
        Me.orderListView.UseCompatibleStateImageBehavior = False
        Me.orderListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item"
        Me.ColumnHeader1.Width = 93
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item Price"
        Me.ColumnHeader2.Width = 109
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Subtotal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Discount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tax:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total:"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(250, 132)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 6
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Available Items"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(330, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Order"
        '
        'discountsGroupBox
        '
        Me.discountsGroupBox.Controls.Add(Me.otherCheck)
        Me.discountsGroupBox.Controls.Add(Me.discountsCheck)
        Me.discountsGroupBox.Controls.Add(Me.clubCheck)
        Me.discountsGroupBox.Controls.Add(Me.staffCheck)
        Me.discountsGroupBox.Controls.Add(Me.otherDiscountTextBox)
        Me.discountsGroupBox.Location = New System.Drawing.Point(191, 247)
        Me.discountsGroupBox.Name = "discountsGroupBox"
        Me.discountsGroupBox.Size = New System.Drawing.Size(134, 38)
        Me.discountsGroupBox.TabIndex = 7
        Me.discountsGroupBox.TabStop = False
        Me.discountsGroupBox.Text = "Discounts"
        '
        'otherCheck
        '
        Me.otherCheck.AutoSize = True
        Me.otherCheck.Location = New System.Drawing.Point(10, 76)
        Me.otherCheck.Margin = New System.Windows.Forms.Padding(1)
        Me.otherCheck.Name = "otherCheck"
        Me.otherCheck.Size = New System.Drawing.Size(52, 17)
        Me.otherCheck.TabIndex = 3
        Me.otherCheck.Text = "&Other"
        Me.otherCheck.UseVisualStyleBackColor = True
        Me.otherCheck.Visible = False
        '
        'discountsCheck
        '
        Me.discountsCheck.AutoSize = True
        Me.discountsCheck.Location = New System.Drawing.Point(5, 18)
        Me.discountsCheck.Margin = New System.Windows.Forms.Padding(1)
        Me.discountsCheck.Name = "discountsCheck"
        Me.discountsCheck.Size = New System.Drawing.Size(73, 17)
        Me.discountsCheck.TabIndex = 0
        Me.discountsCheck.Text = "D&iscounts"
        Me.discountsCheck.UseVisualStyleBackColor = True
        '
        'clubCheck
        '
        Me.clubCheck.AutoSize = True
        Me.clubCheck.Location = New System.Drawing.Point(9, 37)
        Me.clubCheck.Margin = New System.Windows.Forms.Padding(1)
        Me.clubCheck.Name = "clubCheck"
        Me.clubCheck.Size = New System.Drawing.Size(114, 17)
        Me.clubCheck.TabIndex = 1
        Me.clubCheck.TabStop = True
        Me.clubCheck.Text = "Cl&ub Discount - 5%"
        Me.clubCheck.UseVisualStyleBackColor = True
        Me.clubCheck.Visible = False
        '
        'staffCheck
        '
        Me.staffCheck.AutoSize = True
        Me.staffCheck.Location = New System.Drawing.Point(10, 56)
        Me.staffCheck.Margin = New System.Windows.Forms.Padding(1)
        Me.staffCheck.Name = "staffCheck"
        Me.staffCheck.Size = New System.Drawing.Size(121, 17)
        Me.staffCheck.TabIndex = 2
        Me.staffCheck.TabStop = True
        Me.staffCheck.Text = "&Staff Discount - 10%"
        Me.staffCheck.UseVisualStyleBackColor = True
        Me.staffCheck.Visible = False
        '
        'otherDiscountTextBox
        '
        Me.otherDiscountTextBox.Location = New System.Drawing.Point(10, 95)
        Me.otherDiscountTextBox.Name = "otherDiscountTextBox"
        Me.otherDiscountTextBox.ReadOnly = True
        Me.otherDiscountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.otherDiscountTextBox.TabIndex = 4
        Me.otherDiscountTextBox.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dollarPictureBox)
        Me.GroupBox2.Controls.Add(Me.totalLabel)
        Me.GroupBox2.Controls.Add(Me.discountLabel)
        Me.GroupBox2.Controls.Add(Me.taxLabel)
        Me.GroupBox2.Controls.Add(Me.subTotalLabel)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(345, 247)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 216)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Sale"
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalLabel.Location = New System.Drawing.Point(80, 121)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(100, 23)
        Me.totalLabel.TabIndex = 7
        Me.totalLabel.Text = "$0.00"
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'discountLabel
        '
        Me.discountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.discountLabel.Location = New System.Drawing.Point(80, 54)
        Me.discountLabel.Name = "discountLabel"
        Me.discountLabel.Size = New System.Drawing.Size(100, 23)
        Me.discountLabel.TabIndex = 7
        Me.discountLabel.Text = "-$0.00"
        Me.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'taxLabel
        '
        Me.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.taxLabel.Location = New System.Drawing.Point(80, 87)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(100, 23)
        Me.taxLabel.TabIndex = 7
        Me.taxLabel.Text = "$0.00"
        Me.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'subTotalLabel
        '
        Me.subTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.subTotalLabel.Location = New System.Drawing.Point(80, 20)
        Me.subTotalLabel.Name = "subTotalLabel"
        Me.subTotalLabel.Size = New System.Drawing.Size(100, 23)
        Me.subTotalLabel.TabIndex = 7
        Me.subTotalLabel.Text = "$0.00"
        Me.subTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'testLabel
        '
        Me.testLabel.AutoSize = True
        Me.testLabel.Location = New System.Drawing.Point(275, 557)
        Me.testLabel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.testLabel.Name = "testLabel"
        Me.testLabel.Size = New System.Drawing.Size(27, 13)
        Me.testLabel.TabIndex = 11
        Me.testLabel.Text = "test "
        '
        'totalButton
        '
        Me.totalButton.Location = New System.Drawing.Point(250, 160)
        Me.totalButton.Name = "totalButton"
        Me.totalButton.Size = New System.Drawing.Size(75, 23)
        Me.totalButton.TabIndex = 8
        Me.totalButton.Text = "To&tal"
        Me.totalButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(247, 524)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Debug Section"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(588, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'fileMenu
        '
        Me.fileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.fileMenu.Name = "fileMenu"
        Me.fileMenu.Size = New System.Drawing.Size(37, 20)
        Me.fileMenu.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'logoPictureBox
        '
        Me.logoPictureBox.Image = Global.proj4_solution.My.Resources.Resources.my
        Me.logoPictureBox.Location = New System.Drawing.Point(34, 339)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(121, 122)
        Me.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logoPictureBox.TabIndex = 15
        Me.logoPictureBox.TabStop = False
        '
        'dollarPictureBox
        '
        Me.dollarPictureBox.Image = Global.proj4_solution.My.Resources.Resources.dollar_sign_PNG21539
        Me.dollarPictureBox.Location = New System.Drawing.Point(52, 160)
        Me.dollarPictureBox.Name = "dollarPictureBox"
        Me.dollarPictureBox.Size = New System.Drawing.Size(100, 50)
        Me.dollarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dollarPictureBox.TabIndex = 8
        Me.dollarPictureBox.TabStop = False
        Me.dollarPictureBox.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 488)
        Me.Controls.Add(Me.logoPictureBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.totalButton)
        Me.Controls.Add(Me.testLabel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.discountsGroupBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.deleteItemButton)
        Me.Controls.Add(Me.orderListView)
        Me.Controls.Add(Me.availableListView)
        Me.Controls.Add(Me.addItemButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "POS"
        Me.discountsGroupBox.ResumeLayout(False)
        Me.discountsGroupBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dollarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitButton As Button
    Friend WithEvents addItemButton As Button
    Friend WithEvents availableListView As ListView
    Friend WithEvents itemCHeader As ColumnHeader
    Friend WithEvents priceCHeader As ColumnHeader
    Friend WithEvents deleteItemButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents removeButton As Button
    Friend WithEvents orderListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents clearButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents discountsGroupBox As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents totalLabel As Label
    Friend WithEvents discountLabel As Label
    Friend WithEvents taxLabel As Label
    Friend WithEvents subTotalLabel As Label
    Friend WithEvents testLabel As Label
    Friend WithEvents otherCheck As CheckBox
    Friend WithEvents discountsCheck As CheckBox
    Friend WithEvents clubCheck As RadioButton
    Friend WithEvents staffCheck As RadioButton
    Friend WithEvents otherDiscountTextBox As TextBox
    Friend WithEvents totalButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents fileMenu As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dollarPictureBox As PictureBox
    Friend WithEvents logoPictureBox As PictureBox
End Class

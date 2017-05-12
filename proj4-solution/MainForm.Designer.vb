<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.addItemButton = New System.Windows.Forms.Button()
        Me.availableList = New System.Windows.Forms.ListView()
        Me.itemCHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.priceCHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.deleteItemButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.orderList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.otherDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.otherCheckBox = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.discountLabel = New System.Windows.Forms.Label()
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.subTotalLabel = New System.Windows.Forms.Label()
        Me.loadButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(250, 184)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'addItemButton
        '
        Me.addItemButton.Location = New System.Drawing.Point(58, 245)
        Me.addItemButton.Name = "addItemButton"
        Me.addItemButton.Size = New System.Drawing.Size(106, 23)
        Me.addItemButton.TabIndex = 1
        Me.addItemButton.Text = "Add List Item"
        Me.addItemButton.UseVisualStyleBackColor = True
        '
        'availableList
        '
        Me.availableList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.itemCHeader, Me.priceCHeader})
        Me.availableList.Location = New System.Drawing.Point(12, 58)
        Me.availableList.Name = "availableList"
        Me.availableList.Size = New System.Drawing.Size(232, 181)
        Me.availableList.TabIndex = 2
        Me.availableList.UseCompatibleStateImageBehavior = False
        Me.availableList.View = System.Windows.Forms.View.Details
        '
        'itemCHeader
        '
        Me.itemCHeader.Text = "Item"
        Me.itemCHeader.Width = 113
        '
        'priceCHeader
        '
        Me.priceCHeader.Text = "Item Price"
        Me.priceCHeader.Width = 112
        '
        'deleteItemButton
        '
        Me.deleteItemButton.Location = New System.Drawing.Point(58, 274)
        Me.deleteItemButton.Name = "deleteItemButton"
        Me.deleteItemButton.Size = New System.Drawing.Size(106, 23)
        Me.deleteItemButton.TabIndex = 3
        Me.deleteItemButton.Text = "Delete List Item"
        Me.deleteItemButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(250, 97)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 4
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(250, 126)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(75, 23)
        Me.removeButton.TabIndex = 5
        Me.removeButton.Text = "Remove"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'orderList
        '
        Me.orderList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.orderList.Location = New System.Drawing.Point(332, 58)
        Me.orderList.Name = "orderList"
        Me.orderList.Size = New System.Drawing.Size(275, 181)
        Me.orderList.TabIndex = 2
        Me.orderList.UseCompatibleStateImageBehavior = False
        Me.orderList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item"
        Me.ColumnHeader1.Width = 117
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item Price"
        Me.ColumnHeader2.Width = 78
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Quantity"
        Me.ColumnHeader3.Width = 61
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
        Me.Label2.Location = New System.Drawing.Point(3, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Discount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tax:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total:"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(250, 155)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Available Items"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(453, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Order"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.otherDiscountTextBox)
        Me.GroupBox1.Controls.Add(Me.otherCheckBox)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(230, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 120)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discounts"
        '
        'otherDiscountTextBox
        '
        Me.otherDiscountTextBox.Location = New System.Drawing.Point(6, 87)
        Me.otherDiscountTextBox.Name = "otherDiscountTextBox"
        Me.otherDiscountTextBox.ReadOnly = True
        Me.otherDiscountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.otherDiscountTextBox.TabIndex = 10
        '
        'otherCheckBox
        '
        Me.otherCheckBox.AutoSize = True
        Me.otherCheckBox.Location = New System.Drawing.Point(7, 68)
        Me.otherCheckBox.Name = "otherCheckBox"
        Me.otherCheckBox.Size = New System.Drawing.Size(52, 17)
        Me.otherCheckBox.TabIndex = 2
        Me.otherCheckBox.Text = "Other"
        Me.otherCheckBox.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(7, 44)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.totalLabel)
        Me.GroupBox2.Controls.Add(Me.discountLabel)
        Me.GroupBox2.Controls.Add(Me.taxLabel)
        Me.GroupBox2.Controls.Add(Me.subTotalLabel)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(373, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 158)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Sale"
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalLabel.Location = New System.Drawing.Point(72, 122)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(100, 23)
        Me.totalLabel.TabIndex = 7
        Me.totalLabel.Text = "$0.00"
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'discountLabel
        '
        Me.discountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.discountLabel.Location = New System.Drawing.Point(72, 88)
        Me.discountLabel.Name = "discountLabel"
        Me.discountLabel.Size = New System.Drawing.Size(100, 23)
        Me.discountLabel.TabIndex = 7
        Me.discountLabel.Text = "$0.00"
        Me.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'taxLabel
        '
        Me.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.taxLabel.Location = New System.Drawing.Point(72, 54)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(100, 23)
        Me.taxLabel.TabIndex = 7
        Me.taxLabel.Text = "$0.00"
        Me.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'subTotalLabel
        '
        Me.subTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.subTotalLabel.Location = New System.Drawing.Point(72, 20)
        Me.subTotalLabel.Name = "subTotalLabel"
        Me.subTotalLabel.Size = New System.Drawing.Size(100, 23)
        Me.subTotalLabel.TabIndex = 7
        Me.subTotalLabel.Text = "$0.00"
        Me.subTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'loadButton
        '
        Me.loadButton.Location = New System.Drawing.Point(58, 303)
        Me.loadButton.Name = "loadButton"
        Me.loadButton.Size = New System.Drawing.Size(106, 23)
        Me.loadButton.TabIndex = 10
        Me.loadButton.Text = "Load List"
        Me.loadButton.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(58, 332)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(106, 23)
        Me.saveButton.TabIndex = 10
        Me.saveButton.Text = "Save List"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 434)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.loadButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.deleteItemButton)
        Me.Controls.Add(Me.orderList)
        Me.Controls.Add(Me.availableList)
        Me.Controls.Add(Me.addItemButton)
        Me.Controls.Add(Me.exitButton)
        Me.Name = "MainForm"
        Me.Text = "POS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitButton As Button
    Friend WithEvents addItemButton As Button
    Friend WithEvents availableList As ListView
    Friend WithEvents itemCHeader As ColumnHeader
    Friend WithEvents priceCHeader As ColumnHeader
    Friend WithEvents deleteItemButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents removeButton As Button
    Friend WithEvents orderList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents clearButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents otherDiscountTextBox As TextBox
    Friend WithEvents otherCheckBox As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents loadButton As Button
    Friend WithEvents saveButton As Button
    Friend WithEvents totalLabel As Label
    Friend WithEvents discountLabel As Label
    Friend WithEvents taxLabel As Label
    Friend WithEvents subTotalLabel As Label
End Class

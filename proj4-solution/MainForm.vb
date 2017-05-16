' Project name:         <project name>
' Project purpose:      <purpose>
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    'Class level variables and constants for totals
    Dim subtotal As Double
    Dim taxTotal As Double
    Dim discountTotalAmount As Double
    Dim total As Double

    Const taxRate As Double = 0.08

    'Discount percentages
    Dim totalDisc As Double
    Dim otherDiscount As Double
    Const staffDisc As Double = 10
    Const clubDisc As Double = 5

    'Counter for index referencing
    Private counter As Integer

    'Lists for holding prices for lists
    Dim pricesA As New List(Of Double)
    Dim pricesO As New List(Of Double)

    Private Sub addinput(ByVal flag As Integer)
        'Saves preset messages and variables to hold user input
        Dim itemTitle, itemMessage, itemName As String
        Dim priceTitle, priceMessage As String
        Dim itemPrice As Double

        'Message box presets
        itemTitle = "Add Item"
        itemMessage = "Enter Item Name"
        priceTitle = "Add item price"
        priceMessage = "Enter item price"

        If (flag = 0) Then
            'Saves user input to itemName
            itemName = InputBox(itemMessage, itemTitle, "Item" & counter)
            'Saves user input to itemPrice
            Double.TryParse(InputBox(priceMessage, priceTitle, "$0.00"), itemPrice)

            'Adds itemName and itemPrice to availableList
            availableList.Items.Add(itemName)
            availableList.Items(counter).SubItems.Add(itemPrice.ToString("C02"))

            'Adds itemPrice to list of doubles
            pricesA.Add(itemPrice)
        ElseIf (flag = 1) Then
            itemName = InputBox(itemMessage, itemTitle, "Item" & counter)
            Double.TryParse(InputBox(priceMessage, priceTitle, "$0.00"), itemPrice)

            availableList.Items(0).Text = itemName
            availableList.Items(0).SubItems(1).Text = itemPrice.ToString("C02")
            pricesA(0) = itemPrice

        End If
    End Sub

    'Adds items to the availableItems list view using input boxes

    Private Sub addItemButton_Click(sender As Object, e As EventArgs) Handles addItemButton.Click

        addinput(0)

        'Updates counter
        counter = availableList.Items.Count

        'Used to confirm counter is working properly
        testLabel.Text = counter.ToString
    End Sub

    'Delete items from the availableItems list view
    Private Sub deleteItemButton_Click(sender As Object, e As EventArgs) Handles deleteItemButton.Click

        Dim button As Integer

        'If list is empty, gives error message
        If (availableList.Items.Count = 0) Then
            MessageBox.Show("List is already empty!", "List Empty",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1)

            'This is to catch the final item error lists get when removing the final item.
        ElseIf (availableList.Items.Count = 1) Then
            button =
            MessageBox.Show("List cannot remove the last item, replace?", "List Empty",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1)

            If button = DialogResult.Yes Then

                addinput(1)
            End If

        Else
            'Gives error if no item is selected for deletion
            If availableList.FocusedItem Is Nothing Then
                MessageBox.Show("Please select an item to be deleted.", "Select an Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'If an item is selected, remove items at the index of the selected item
            Else
                availableList.Items.RemoveAt(availableList.FocusedItem.Index)
                pricesA.RemoveAt(availableList.FocusedItem.Index)
                counter = counter - 1
            End If
        End If
    End Sub

    'Adds items from availableList to orderList
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        'Variables to hold current number of items and reference the name of the items coming from availableList
        Dim count As Integer = orderList.Items.Count
        Dim itemListName As ListViewItem = availableList.FocusedItem

        'Checks that an item is selected to be added to orderList
        If itemListName Is Nothing Then
            MessageBox.Show("Please select an item to add!", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'If an item is selected in availableList
        Else
            'Adds item name and item price to orderList from availableList and adds the prices from orderList to a list of doubles
            orderList.Items.Add(itemListName.Text)
            orderList.Items(count).SubItems.Add(availableList.Items(itemListName.Index).SubItems(1).Text)
            pricesO.Add(pricesA(itemListName.Index))
        End If
    End Sub

    'Removes items from orderList
    Private Sub removeButton_Click(sender As Object, e As EventArgs) Handles removeButton.Click

        'Variables to reference the name of the item being deleted
        Dim itemListName As ListViewItem = orderList.FocusedItem

        'If list is already empty
        If orderList.Items.Count = 0 Then
            MessageBox.Show("Your order list is already empty!", "Order Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'If no item is selected in orderList
        ElseIf itemListName Is Nothing Then
            MessageBox.Show("Select an item to remove!", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'If an item is selected in orderList
        Else
            'To hold the index of the selected item
            Dim orderIndex As Integer = itemListName.Index

            'Removes item at index of selected item
            orderList.Items.RemoveAt(orderIndex)
            pricesO.RemoveAt(orderIndex)
        End If
    End Sub

    'Clears all values from orderList and pricesO as well as the totals
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click

        orderList.Items.Clear()
        pricesO.Clear()
        subtotal = 0
        taxTotal = 0
        total = 0
    End Sub

    'Totals the values of subtotal, taxTotal, is discTotal and displays them in the appropriate labels
    Private Sub totalButton_Click(sender As Object, e As EventArgs) Handles totalButton.Click

        'Subtotal calculation
        subtotal = pricesO.Sum
        subTotalLabel.Text = subtotal.ToString("C02")

        'Discount calculation
        discountTotalAmount = totalDisc * subtotal / 100
        discountLabel.Text = "-" & discountTotalAmount.ToString("C2")

        'Tax calculation
        taxTotal = (subtotal - discountTotalAmount) * taxRate
        taxLabel.Text = taxTotal.ToString("C2")

        'Total calculation
        total = subtotal - discountTotalAmount + taxTotal
        totalLabel.Text = total.ToString("C2")
    End Sub

    'Close Application
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads items to availableList from file
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim itemCount As Integer = availableList.Items.Count
        Dim itemArray(itemCount - 1, 0) As String
        'This array is for the save files. We can recreate the array every time by limiting the scope to the save button.
    End Sub

    'Check that allows user to input a custom discount percentage that is added to existing discounts
    Private Sub otherCheck_CheckedChanged_1(sender As Object, e As EventArgs) Handles otherCheck.CheckedChanged

        If otherCheck.Checked = False Then
            otherDiscountTextBox.Visible = False
            otherDiscountTextBox.Text = ""
        ElseIf otherCheck.Checked = True Then
            otherDiscountTextBox.Visible = True
            otherDiscountTextBox.Text = ""
        End If
    End Sub

    'Allows user to enable discount options
    Private Sub discountsCheck_CheckedChanged(sender As Object, e As EventArgs) Handles discountsCheck.CheckedChanged

        'If unchecked, discount options are unavailable
        If discountsCheck.Checked = False Then
            clubCheck.Visible = False
            clubCheck.Checked = False
            staffCheck.Visible = False
            staffCheck.Checked = False
            otherCheck.Visible = False
            otherCheck.Checked = False
            Label2.Text = "Discount: "
            'If checked, discount options are available
        ElseIf discountsCheck.Checked = True Then
            clubCheck.Visible = True
            staffCheck.Visible = True
            otherCheck.Visible = True
            otherDiscountTextBox.ReadOnly = False
        End If
    End Sub

    'Checks if club discount is checked
    Private Sub clubCheck_CheckedChanged(sender As Object, e As EventArgs) Handles clubCheck.CheckedChanged

        'Discount label shows the current discount percentage. Updates totalDisc variable
        Label2.Text = "Discount: " & otherDiscount + clubDisc & "%"
        Double.TryParse(otherDiscountTextBox.Text, otherDiscount)
        totalDisc = otherDiscount + clubDisc
        testLabel.Text = totalDisc.ToString
    End Sub

    'Checks if staff discount is checked
    Private Sub staffCheck_CheckedChanged(sender As Object, e As EventArgs) Handles staffCheck.CheckedChanged

        'Dicsount label shows the current discount percentage. Updates totalDisc variable
        Label2.Text = "Discount: " & otherDiscount + 10 & "%"
        Double.TryParse(otherDiscountTextBox.Text, otherDiscount)
        totalDisc = otherDiscount + staffDisc
        testLabel.Text = totalDisc.ToString

    End Sub

    'Updates variables based on custom discount percentage
    Private Sub otherDiscountTextBox_TextChanged(sender As Object, e As EventArgs) Handles otherDiscountTextBox.TextChanged

        Double.TryParse(otherDiscountTextBox.Text, otherDiscount)

        If staffCheck.Checked = True Then
            Label2.Text = "Discount: " & otherDiscount + staffDisc & "%"
            totalDisc = otherDiscount + staffDisc
        ElseIf clubCheck.Checked = True Then
            Label2.Text = "Discount: " & otherDiscount + clubDisc & "%"
            totalDisc = otherDiscount + clubDisc
        Else
            Label2.Text = "Discount: " & otherDiscount & "%"
            totalDisc = otherDiscount
        End If
        testLabel.Text = totalDisc.ToString
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class

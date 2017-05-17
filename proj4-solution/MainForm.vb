' Project name:         <project name>
' Project purpose:      <purpose>
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    'Structure for adding new items
    Structure Item
        Public name As String
        Public price As Double
    End Structure

    Dim itemArray() As String
    Const listFileName As String = "aList.csv"

    'Class level variables and constants for totals
    Shared subtotal As Double
    Shared taxTotal As Double
    Shared discountTotalAmount As Double
    Shared total As Double

    Const taxRate As Double = 0.08

    'Discount percentages
    Shared totalDisc As Double
    Shared otherDiscount As Double

    Const staffDisc As Double = 10
    Const clubDisc As Double = 5

    'Counter for index referencing
    Private counter As Integer

    'Lists for holding prices for lists
    Dim pricesA As New List(Of Double)
    Dim pricesO As New List(Of Double)

    'Class for calculations
    Public Class Calculator

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal totalDisc As Double,
                       ByVal subtotal As Double,
                       ByVal pricesO As List(Of Double))
            totalDisc = totalDisc
            subtotal = subtotal
            pricesO = pricesO
            taxTotal = taxTotal
        End Sub

        Public Function GetDiscount(ByVal totalDisc As Double,
                                    ByVal subtotal As Double) As Double
            'Discount calculation
            discountTotalAmount = totalDisc * subtotal / 100
            Return discountTotalAmount
        End Function

        Public Function GetSubtotal(ByVal pricesO As List(Of Double)) As Double
            'Subtotal calculation
            subtotal = pricesO.Sum
            Return subtotal
        End Function

        Public Function GetTaxTotal(ByVal subtotal As Double,
                                    ByVal discountTotalAmount As Double,
                                    ByVal taxRate As Double) As Double
            'Tax calculation
            taxTotal = (subtotal - discountTotalAmount) * taxRate
            Return taxTotal
        End Function

        Public Function GetTotal(ByVal subtotal As Double,
                                 ByVal discountTotalAmount As Double,
                                 ByVal taxTotal As Double) As Double
            total = subtotal - discountTotalAmount + taxTotal
            Return total
        End Function

    End Class

    Private Sub addinput(ByVal flag As Integer)
        'Saves preset messages and variables to hold user input
        Dim itemTitle, itemMessage As String
        Dim priceTitle, priceMessage As String

        'Message box presets
        itemTitle = "Add Item"
        itemMessage = "Enter Item Name"
        priceTitle = "Add item price"
        priceMessage = "Enter item price"

        If (flag = 0) Then
            'Declare new Item
            Dim userItem As Item
            'Saves user input to userItem.name
            userItem.name = InputBox(itemMessage, itemTitle, "Item" & counter)
            'Saves user input to itemPrice
            Double.TryParse(InputBox(priceMessage, priceTitle, "$0.00"), userItem.price)

            'Adds itemName and itemPrice to availableList
            availableList.Items.Add(userItem.name)
            availableList.Items(counter).SubItems.Add(userItem.price.ToString("C02"))

            'Adds itemPrice to list of doubles
            pricesA.Add(userItem.price)
        ElseIf (flag = 1) Then
            'Declare new Item
            Dim userItem As Item
            userItem.name = InputBox(itemMessage, itemTitle, "Item" & counter)
            Double.TryParse(InputBox(priceMessage, priceTitle, "$0.00"), userItem.price)

            availableList.Items(0).Text = userItem.name
            availableList.Items(0).SubItems(1).Text = userItem.price.ToString("C02")
            pricesA(0) = userItem.price

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

        'Instantiate Calculator
        Dim myCalc As New Calculator

        'Subtotal calculation
        subTotalLabel.Text = myCalc.GetSubtotal(pricesO).ToString("C02")

        'Discount calculation
        discountLabel.Text = "-" & myCalc.GetDiscount(totalDisc, subtotal).ToString("C2")

        'Tax calculation
        taxLabel.Text = myCalc.GetTaxTotal(subtotal, discountTotalAmount, taxRate).ToString("C2")

        'Total calculation
        totalLabel.Text = myCalc.GetTotal(subtotal, discountTotalAmount, taxTotal).ToString("C2")
    End Sub

    'Close Application
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads items to availableList from file
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ReDim itemArray(counter - 1)

        For index As Integer = 0 To counter - 1
            itemArray(index) = availableList.Items(index).Text & "," & availableList.Items(index).SubItems(1).Text
        Next index

        'temporary until I get the structure from scott

        Dim outFile As System.IO.StreamWriter
        outFile = IO.File.CreateText(listFileName)
        Dim columnTitles As String = "Item Name,Price"

        outFile.WriteLine(columnTitles)
        For Each member As String In itemArray
            outFile.WriteLine(member)
        Next member
        outFile.Close()
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

    Private Sub orderList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles orderList.SelectedIndexChanged

    End Sub
End Class

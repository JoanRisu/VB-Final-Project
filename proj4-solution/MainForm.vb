' Project name:         <project name>
' Project purpose:      <purpose>
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off



Public Class MainForm
    Private Structure Item
        Public itemName As String
        Public itemPrice As Double
        Public itemQnty As Integer

    End Structure

    Dim subtotal As Double
    Const taxRate As Double = 0.08
    Dim total As Double
    Dim discountClub As Boolean
    Dim discoutStaff As Boolean

    Private counter As Integer
    Dim pricesA As New List(Of Double)
    Dim pricesO As New List(Of Double)

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub otherCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles otherCheckBox.CheckedChanged
        If otherCheckBox.Checked = False Then
            otherDiscountTextBox.ReadOnly = True
            otherDiscountTextBox.Text = ""
        ElseIf otherCheckBox.Checked = True Then
            otherDiscountTextBox.ReadOnly = False
        End If
    End Sub

    'this will add an item using a popup input box
    Private Sub addItemButton_Click(sender As Object, e As EventArgs) Handles addItemButton.Click
        Dim itemTitle, itemMessage, itemName As String
        Dim priceTitle, priceMessage As String
        Dim priceName As Double

        itemTitle = "Add Item"
        itemMessage = "Enter Item Name"

        itemName = InputBox(itemMessage, itemTitle, "[name]")

        priceTitle = "Add item price"
        priceMessage = "Enter item price"

        Double.TryParse(InputBox(priceMessage, priceTitle, "$0.00"), priceName)

        availableList.Items.Add(itemName)
        availableList.Items(counter).SubItems.Add(priceName.ToString("C02"))

        counter += 1

        pricesA.Add(priceName)

    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim count As Integer = orderList.Items.Count
        Dim itemListName As ListViewItem = availableList.FocusedItem

        If itemListName Is Nothing Then
            MessageBox.Show("Please select an item to add!", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            orderList.Items.Add(itemListName.Text)
            orderList.Items(count).SubItems.Add(availableList.Items(itemListName.Index).SubItems(1).Text)
            pricesO.Add(pricesA(itemListName.Index))

            subtotal = pricesO.Sum

            subTotalLabel.Text = subtotal.ToString("C02")


        End If


    End Sub

    Private Sub deleteItemButton_Click(sender As Object, e As EventArgs) Handles deleteItemButton.Click
        Dim itemName As String
        Dim priceName As Double

        'This is to catch any errors that may arise from deleting items
        If (availableList.Items.Count = 0) Then
            MessageBox.Show("List is already empty!", "Delete Item",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
        Else
            Dim listIndex As Integer
            Dim button As DialogResult


            listIndex = availableList.FocusedItem.Index
            If (availableList.Items.Count = 1) Then
                button =
                MessageBox.Show("Cannot delete last entry. Do you want to replace it?", "Item List",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
                If button = DialogResult.Yes Then
                    itemName = InputBox("Enter item name:", "Add Item", "[name]")
                    Double.TryParse(InputBox("Enter item price:", "Add Item", "$0.00"), priceName)


                    availableList.Items(0).Text = itemName
                    availableList.Items(0).SubItems(1).Text = priceName.ToString("C02")
                End If
            Else
                availableList.Items.RemoveAt(listIndex)
                pricesA.RemoveAt(listIndex)
            End If
        End If



    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim itemCount As Integer = availableList.Items.Count
        Dim itemArray(itemCount - 1, 0) As String
        'This array is for the save files. We can recreate the array every time by limiting the scope to the save button.


    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        orderList.Items.Clear()

    End Sub

    Private Sub removeButton_Click(sender As Object, e As EventArgs) Handles removeButton.Click
        If orderList.Items.Count = 0 Then
            MessageBox.Show("Your order list is already empty!", "Order Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf orderList.FocusedItem Is Nothing Then
            MessageBox.Show("Select an item to remove!", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            orderList.FocusedItem.Remove()
        End If

    End Sub
End Class

' Project name:         Flexible POS System
' Project purpose:      To provide a flexible POS for businesses.





Public Class MainForm
    Private counter As Integer
    Private otherDiscount As Double
    Const tax As Double = 0.15
    Const clubDiscount As Double = 0.1
    Const staffDiscount As Double = 0.05
    Private totalDiscount As Double




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

    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
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

            availableList.Items(0).Focused = True

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
            End If
        End If



    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim itemx As Integer = availableList.Items.Count
        Dim itemarray(itemx, 1) As String
        'because the array is for the save files, we can recreate the array every time by limiting the scope to the save button.



    End Sub

    Private Sub otherDiscountTextBox_TextChanged(sender As Object, e As EventArgs) Handles otherDiscountTextBox.TextChanged
        Double.TryParse(otherDiscountTextBox.Text, otherDiscount)
        'this updates otherDiscount automatically before final calculation.
    End Sub


End Class

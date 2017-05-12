Public Class MainForm
    Private counter As Integer

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

        priceName = InputBox(priceMessage, priceTitle, "$0.00")

        availableList.Items.Add(itemName)
        availableList.Items(counter).SubItems.Add(priceName)

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
                    priceName = InputBox("Enter item price:", "Add Item", "$0.00")

                    availableList.Items(0).Text = itemName
                    availableList.Items(0).SubItems(1).Text = priceName
                End If
            Else
                availableList.Items.RemoveAt(listIndex)
            End If
        End If



    End Sub
End Class

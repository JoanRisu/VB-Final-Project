Public Class MainForm
    Private counter As Integer

    Private itemArray(9, 1) As String


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

        itemArray(counter, 0) = InputBox(itemMessage, itemTitle, "[name]")

        priceTitle = "Add item price"
        priceMessage = "Enter item price"

        itemArray(counter, 1) = InputBox(priceMessage, priceTitle, "$0.00")

        availableList.Items.Add(itemArray(counter, 0))
        availableList.Items(counter).SubItems.Add(itemArray(counter, 1))

        counter += 1



    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
    End Sub

    Private Sub deleteItemButton_Click(sender As Object, e As EventArgs) Handles deleteItemButton.Click
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
                    itemArray(0, 0) = InputBox("Enter item name:", "Add Item", "[name]")
                    itemArray(0, 1) = InputBox("Enter item price:", "Add Item", "$0.00")

                    availableList.Items(0).Text = itemArray(0, 0)
                    availableList.Items(0).SubItems(1).Text = itemArray(0, 1)
                End If
            Else
                availableList.Items.RemoveAt(availableList.FocusedItem.Index)
                itemArray(availableList.FocusedItem.Index, 0) = String.Empty
            End If
        End If



    End Sub
End Class

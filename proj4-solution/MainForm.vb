Public Class MainForm
    Private itemListArray As New List(Of List(Of String))


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

        itemName = InputBox(itemMessage, itemTitle, "")

        priceTitle = "Add item price"
        priceMessage = "Enter item price"

        priceName = InputBox(priceMessage, priceTitle, "$0.00")



    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        itemListArray(0).Add("Items")
        itemListArray(0).Add("Prices")
        itemListArray(1).Add("Said Item")
        itemListArray(1).Add("Price of Said Item")

        availableList.Items.Add()

    End Sub
End Class

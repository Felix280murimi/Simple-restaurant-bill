Public Class frmRestaurantBill
    Const pizzaPrice As Double = 180.0
    Const friesPrice As Double = 200.0
    Const drinksPrice As Double = 155.0

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim pizza, fries, drinks As Integer
        Dim total As Double
        If Integer.TryParse(txtPizza.Text, pizza) And Integer.TryParse(txtFries.Text, fries) And Integer.TryParse(txtDrink.Text, drinks) Then
            total = Calculate(pizza, fries, drinks)
            displayBill(pizza, fries, drinks, total)
        Else
            MessageBox.Show("Please correct your input", "Invalid inpit", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Function Calculate(pizza As Integer, fries As Integer, drinks As Integer) As Double
        Dim total As Double
        total = (pizza * pizzaPrice) + (fries * friesPrice) + (drinks * drinksPrice)
        Return total
    End Function

    Private Sub displayBill(pizza As Integer, fries As Integer, drinks As Integer, total As Double)
        ListBoxDisplay.Items.Add("ITEM" + vbTab + "    QUANTITY" + vbTab + "PRICE")
        If pizza > 0 Then
            ListBoxDisplay.Items.Add("pizza" + vbTab + vbTab + pizza.ToString() + vbTab + FormatCurrency(pizza * pizzaPrice))
        End If
        If fries > 0 Then
            ListBoxDisplay.Items.Add("fries" + vbTab + vbTab + fries.ToString() + vbTab + FormatCurrency(fries * friesPrice))
        End If
        If drinks > 0 Then
            ListBoxDisplay.Items.Add("drinks" + vbTab + vbTab + drinks.ToString() + vbTab + FormatCurrency(drinks * drinksPrice))
        End If
        ListBoxDisplay.Items.Add("TOTAL:  " + vbTab + vbTab + FormatCurrency(total))
    End Sub
End Class

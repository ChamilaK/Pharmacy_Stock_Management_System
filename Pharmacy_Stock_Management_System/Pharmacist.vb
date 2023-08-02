Public Class Pharmacist
    Private Sub CustomerDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerDetailsToolStripMenuItem.Click

        Dim newForm As New Customer()
        newForm.Show()

    End Sub

    Private Sub CustomerBillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerBillToolStripMenuItem.Click

        Dim newForm As New Customer_Bill()
        newForm.Show()


    End Sub

    Private Sub PurchaseDrugsItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseDrugsItemsToolStripMenuItem.Click

        Dim newForm As New Purchased_Drugs_and_Items()
        newForm.Show()


    End Sub

    Private Sub StoreDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StoreDetailsToolStripMenuItem.Click

        Dim newForm As New Store()
        newForm.Show()


    End Sub

    Private Sub OrderListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderListToolStripMenuItem.Click

        Dim newForm As New Order_List()
        newForm.Show()


    End Sub

    Private Sub SalesRepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesRepToolStripMenuItem.Click

        Dim newForm As New Sales_Rep()
        newForm.Show()


    End Sub

    Private Sub SearchCustomersByDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchCustomersByDateToolStripMenuItem.Click

        Dim newForm As New Search_Customers_by_Date()
        newForm.Show()

    End Sub

    Private Sub SearchBillByDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchBillByDateToolStripMenuItem.Click

        Dim newForm As New Search_Customer_Bill_by_Date()
        newForm.Show()

    End Sub

    Private Sub SearchDrugsItemsByDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchDrugsItemsByDateToolStripMenuItem.Click

        Dim newForm As New Search_Purchase_Drugs_Items_by_Date()
        newForm.Show()

    End Sub

    Private Sub SearchStoreByDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchStoreByDateToolStripMenuItem.Click

        Dim newForm As New Search_Store_by_Date()
        newForm.Show()

    End Sub

    Private Sub SearchOrdersByDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchOrdersByDateToolStripMenuItem.Click

        Dim newForm As New Search_Orders_by_Date()
        newForm.Show()

    End Sub
End Class
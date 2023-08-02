Imports MySql.Data.MySqlClient
Public Class Admin

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=$safeprojectname$")
    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click

        Dim newForm As New Account()
        newForm.Show()

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click

        Dim newForm As New Customer()
        newForm.Show()

    End Sub

    Private Sub CustomerBillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerBillToolStripMenuItem.Click

        Dim newForm As New Customer_Bill()
        newForm.Show()

    End Sub

    Private Sub OrderListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderListToolStripMenuItem.Click

        Dim newForm As New Order_List()
        newForm.Show()

    End Sub

    Private Sub PurchaseDrugsItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseDrugsItemsToolStripMenuItem.Click

        Dim newForm As New Purchased_Drugs_and_Items()
        newForm.Show()

    End Sub

    Private Sub StoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StoreToolStripMenuItem.Click

        Dim newForm As New Store()
        newForm.Show()

    End Sub

    Private Sub SalesRepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesRepToolStripMenuItem.Click

        Dim newForm As New Sales_Rep()
        newForm.Show()

    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click

        Dim newForm As New User()
        newForm.Show()

    End Sub

    Private Sub SearchOrdersByDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchOrdersByDateToolStripMenuItem.Click

        Dim newForm As New Search_Orders_by_Date()
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

    Private Sub SearchCustomerInformationByDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchCustomerInformationByDateToolStripMenuItem.Click

        Dim newForm As New Search_Customers_by_Date()
        newForm.Show()

    End Sub

    Private Sub SearchBillByDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchBillByDateToolStripMenuItem.Click

        Dim newForm As New Search_Customer_Bill_by_Date()
        newForm.Show()

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub MainPharmacyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainPharmacyToolStripMenuItem.Click

        Dim newForm As New Main_Pharmacy()
        newForm.Show()
    End Sub
End Class
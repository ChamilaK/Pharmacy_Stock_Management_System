<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pharmacist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchCustomersByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchBillByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseDrugsItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchDrugsItemsByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StoreDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchStoreByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchOrdersByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesRepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerDetailsToolStripMenuItem, Me.CustomerBillToolStripMenuItem, Me.PurchaseDrugsItemsToolStripMenuItem, Me.StoreDetailsToolStripMenuItem, Me.OrderListToolStripMenuItem, Me.SalesRepToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1263, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CustomerDetailsToolStripMenuItem
        '
        Me.CustomerDetailsToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.CustomerDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchCustomersByDateToolStripMenuItem})
        Me.CustomerDetailsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerDetailsToolStripMenuItem.Name = "CustomerDetailsToolStripMenuItem"
        Me.CustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.CustomerDetailsToolStripMenuItem.Text = "Customer "
        '
        'SearchCustomersByDateToolStripMenuItem
        '
        Me.SearchCustomersByDateToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchCustomersByDateToolStripMenuItem.Name = "SearchCustomersByDateToolStripMenuItem"
        Me.SearchCustomersByDateToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.SearchCustomersByDateToolStripMenuItem.Text = "Search Customers by Date"
        '
        'CustomerBillToolStripMenuItem
        '
        Me.CustomerBillToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.CustomerBillToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchBillByDateToolStripMenuItem})
        Me.CustomerBillToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerBillToolStripMenuItem.Name = "CustomerBillToolStripMenuItem"
        Me.CustomerBillToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.CustomerBillToolStripMenuItem.Text = "Customer Bill"
        '
        'SearchBillByDateToolStripMenuItem
        '
        Me.SearchBillByDateToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBillByDateToolStripMenuItem.Name = "SearchBillByDateToolStripMenuItem"
        Me.SearchBillByDateToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.SearchBillByDateToolStripMenuItem.Text = "Search Bill by Date"
        '
        'PurchaseDrugsItemsToolStripMenuItem
        '
        Me.PurchaseDrugsItemsToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.PurchaseDrugsItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchDrugsItemsByDateToolStripMenuItem})
        Me.PurchaseDrugsItemsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchaseDrugsItemsToolStripMenuItem.Name = "PurchaseDrugsItemsToolStripMenuItem"
        Me.PurchaseDrugsItemsToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.PurchaseDrugsItemsToolStripMenuItem.Text = "Purchase Drugs / Items"
        '
        'SearchDrugsItemsByDateToolStripMenuItem
        '
        Me.SearchDrugsItemsByDateToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDrugsItemsByDateToolStripMenuItem.Name = "SearchDrugsItemsByDateToolStripMenuItem"
        Me.SearchDrugsItemsByDateToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.SearchDrugsItemsByDateToolStripMenuItem.Text = "Search Drugs / Items by Date"
        '
        'StoreDetailsToolStripMenuItem
        '
        Me.StoreDetailsToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.StoreDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchStoreByDateToolStripMenuItem})
        Me.StoreDetailsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StoreDetailsToolStripMenuItem.Name = "StoreDetailsToolStripMenuItem"
        Me.StoreDetailsToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.StoreDetailsToolStripMenuItem.Text = "Store Details"
        '
        'SearchStoreByDateToolStripMenuItem
        '
        Me.SearchStoreByDateToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchStoreByDateToolStripMenuItem.Name = "SearchStoreByDateToolStripMenuItem"
        Me.SearchStoreByDateToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.SearchStoreByDateToolStripMenuItem.Text = "Search Store by Date"
        '
        'OrderListToolStripMenuItem
        '
        Me.OrderListToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.OrderListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchOrdersByDateToolStripMenuItem})
        Me.OrderListToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderListToolStripMenuItem.Name = "OrderListToolStripMenuItem"
        Me.OrderListToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.OrderListToolStripMenuItem.Text = "Order List"
        '
        'SearchOrdersByDateToolStripMenuItem
        '
        Me.SearchOrdersByDateToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchOrdersByDateToolStripMenuItem.Name = "SearchOrdersByDateToolStripMenuItem"
        Me.SearchOrdersByDateToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.SearchOrdersByDateToolStripMenuItem.Text = "Search Orders by Date"
        '
        'SalesRepToolStripMenuItem
        '
        Me.SalesRepToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.SalesRepToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesRepToolStripMenuItem.Name = "SalesRepToolStripMenuItem"
        Me.SalesRepToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.SalesRepToolStripMenuItem.Text = "Sales Rep"
        '
        'Pharmacist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.side_turkey_october_pharmacy_cabinets_medicines_drugs_tablets_food_additives_105957686
        Me.ClientSize = New System.Drawing.Size(1263, 523)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Pharmacist"
        Me.Text = "Pharmacist"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CustomerDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerBillToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseDrugsItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StoreDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesRepToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchCustomersByDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchBillByDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchOrdersByDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchDrugsItemsByDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchStoreByDateToolStripMenuItem As ToolStripMenuItem
End Class

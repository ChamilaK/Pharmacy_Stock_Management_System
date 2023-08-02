<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchCustomerInformationByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchBillByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchOrdersByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseDrugsItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchDrugsItemsByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchStoreByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesRepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainPharmacyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.CustomerBillToolStripMenuItem, Me.OrderListToolStripMenuItem, Me.PurchaseDrugsItemsToolStripMenuItem, Me.StoreToolStripMenuItem, Me.SalesRepToolStripMenuItem, Me.UserToolStripMenuItem, Me.MainPharmacyToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1037, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(145, 24)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchCustomerInformationByDateToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'SearchCustomerInformationByDateToolStripMenuItem
        '
        Me.SearchCustomerInformationByDateToolStripMenuItem.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchCustomerInformationByDateToolStripMenuItem.Name = "SearchCustomerInformationByDateToolStripMenuItem"
        Me.SearchCustomerInformationByDateToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.SearchCustomerInformationByDateToolStripMenuItem.Text = "Search Customers by Date"
        '
        'CustomerBillToolStripMenuItem
        '
        Me.CustomerBillToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchBillByDateToolStripMenuItem})
        Me.CustomerBillToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerBillToolStripMenuItem.Name = "CustomerBillToolStripMenuItem"
        Me.CustomerBillToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.CustomerBillToolStripMenuItem.Text = "Customer Bill"
        '
        'SearchBillByDateToolStripMenuItem
        '
        Me.SearchBillByDateToolStripMenuItem.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBillByDateToolStripMenuItem.Name = "SearchBillByDateToolStripMenuItem"
        Me.SearchBillByDateToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.SearchBillByDateToolStripMenuItem.Text = "Search Bill by Date"
        '
        'OrderListToolStripMenuItem
        '
        Me.OrderListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchOrdersByDateToolStripMenuItem})
        Me.OrderListToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderListToolStripMenuItem.Name = "OrderListToolStripMenuItem"
        Me.OrderListToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.OrderListToolStripMenuItem.Text = "Order List"
        '
        'SearchOrdersByDateToolStripMenuItem
        '
        Me.SearchOrdersByDateToolStripMenuItem.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchOrdersByDateToolStripMenuItem.Name = "SearchOrdersByDateToolStripMenuItem"
        Me.SearchOrdersByDateToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.SearchOrdersByDateToolStripMenuItem.Text = "Search Orders by Date"
        '
        'PurchaseDrugsItemsToolStripMenuItem
        '
        Me.PurchaseDrugsItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchDrugsItemsByDateToolStripMenuItem})
        Me.PurchaseDrugsItemsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchaseDrugsItemsToolStripMenuItem.Name = "PurchaseDrugsItemsToolStripMenuItem"
        Me.PurchaseDrugsItemsToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.PurchaseDrugsItemsToolStripMenuItem.Text = "Purchase Drugs / Items"
        '
        'SearchDrugsItemsByDateToolStripMenuItem
        '
        Me.SearchDrugsItemsByDateToolStripMenuItem.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDrugsItemsByDateToolStripMenuItem.Name = "SearchDrugsItemsByDateToolStripMenuItem"
        Me.SearchDrugsItemsByDateToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.SearchDrugsItemsByDateToolStripMenuItem.Text = "Search Drugs / Items by Date"
        '
        'StoreToolStripMenuItem
        '
        Me.StoreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchStoreByDateToolStripMenuItem})
        Me.StoreToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StoreToolStripMenuItem.Name = "StoreToolStripMenuItem"
        Me.StoreToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.StoreToolStripMenuItem.Text = "Store"
        '
        'SearchStoreByDateToolStripMenuItem
        '
        Me.SearchStoreByDateToolStripMenuItem.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchStoreByDateToolStripMenuItem.Name = "SearchStoreByDateToolStripMenuItem"
        Me.SearchStoreByDateToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.SearchStoreByDateToolStripMenuItem.Text = "Search Store by Date"
        '
        'SalesRepToolStripMenuItem
        '
        Me.SalesRepToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesRepToolStripMenuItem.Name = "SalesRepToolStripMenuItem"
        Me.SalesRepToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.SalesRepToolStripMenuItem.Text = "Sales Rep"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'MainPharmacyToolStripMenuItem
        '
        Me.MainPharmacyToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainPharmacyToolStripMenuItem.Name = "MainPharmacyToolStripMenuItem"
        Me.MainPharmacyToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.MainPharmacyToolStripMenuItem.Text = "Main Pharmacy"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = Global.$safeprojectname$.My.Resources.Resources.side_turkey_october_pharmacy_cabinets_medicines_drugs_tablets_food_additives_105957686
        Me.ClientSize = New System.Drawing.Size(1037, 497)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerBillToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseDrugsItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesRepToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchOrdersByDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchDrugsItemsByDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchStoreByDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchCustomerInformationByDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchBillByDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainPharmacyToolStripMenuItem As ToolStripMenuItem
End Class

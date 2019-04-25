<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_makeorder_a160195
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
        Me.label = New System.Windows.Forms.Label()
        Me.cmb_category = New System.Windows.Forms.ComboBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lst_product = New System.Windows.Forms.ListBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.grd_shoppingcart = New System.Windows.Forms.DataGridView()
        Me.cmb_customer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_customername = New System.Windows.Forms.Label()
        Me.lbl_staffname = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_shoppingcart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(12, 26)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(50, 13)
        Me.label.TabIndex = 1
        Me.label.Text = "Order ID:"
        '
        'cmb_category
        '
        Me.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_category.FormattingEnabled = True
        Me.cmb_category.Location = New System.Drawing.Point(45, 133)
        Me.cmb_category.Name = "cmb_category"
        Me.cmb_category.Size = New System.Drawing.Size(121, 21)
        Me.cmb_category.TabIndex = 9
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(174, 133)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(231, 187)
        Me.pic_product.TabIndex = 8
        Me.pic_product.TabStop = False
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(174, 322)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(231, 62)
        Me.txt_name.TabIndex = 7
        '
        'lst_product
        '
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.Location = New System.Drawing.Point(45, 159)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(123, 225)
        Me.lst_product.TabIndex = 6
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(330, 394)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 11
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(236, 396)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(71, 20)
        Me.txt_quantity.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 397)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Quantity:"
        '
        'btn_order
        '
        Me.btn_order.Location = New System.Drawing.Point(883, 392)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(75, 23)
        Me.btn_order.TabIndex = 14
        Me.btn_order.Text = "ORDER"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'lbl_orderid
        '
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.Location = New System.Drawing.Point(28, 56)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(59, 22)
        Me.lbl_orderid.TabIndex = 15
        Me.lbl_orderid.Text = "Label2"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(866, 26)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(39, 13)
        Me.lbl_date.TabIndex = 16
        Me.lbl_date.Text = "Label2"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Charlemagne Std", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(685, 390)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(86, 23)
        Me.lbl_total.TabIndex = 18
        Me.lbl_total.Text = "Total:"
        '
        'grd_shoppingcart
        '
        Me.grd_shoppingcart.AllowUserToAddRows = False
        Me.grd_shoppingcart.BackgroundColor = System.Drawing.Color.White
        Me.grd_shoppingcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_shoppingcart.Location = New System.Drawing.Point(411, 133)
        Me.grd_shoppingcart.Name = "grd_shoppingcart"
        Me.grd_shoppingcart.Size = New System.Drawing.Size(547, 251)
        Me.grd_shoppingcart.TabIndex = 22
        '
        'cmb_customer
        '
        Me.cmb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_customer.FormattingEnabled = True
        Me.cmb_customer.Location = New System.Drawing.Point(110, 95)
        Me.cmb_customer.Name = "cmb_customer"
        Me.cmb_customer.Size = New System.Drawing.Size(62, 21)
        Me.cmb_customer.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Customer:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(444, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Staff:"
        '
        'lbl_customername
        '
        Me.lbl_customername.AutoSize = True
        Me.lbl_customername.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customername.Location = New System.Drawing.Point(182, 99)
        Me.lbl_customername.Name = "lbl_customername"
        Me.lbl_customername.Size = New System.Drawing.Size(48, 16)
        Me.lbl_customername.TabIndex = 27
        Me.lbl_customername.Text = "Label4"
        '
        'lbl_staffname
        '
        Me.lbl_staffname.AutoSize = True
        Me.lbl_staffname.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffname.Location = New System.Drawing.Point(480, 94)
        Me.lbl_staffname.Name = "lbl_staffname"
        Me.lbl_staffname.Size = New System.Drawing.Size(111, 16)
        Me.lbl_staffname.TabIndex = 28
        Me.lbl_staffname.Text = "Label4BBBBBBB"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.DarkCyan
        Me.lbl_title.Location = New System.Drawing.Point(431, 26)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(189, 31)
        Me.lbl_title.TabIndex = 29
        Me.lbl_title.Text = "MAKE ORDER"
        '
        'frm_makeorder_a160195
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(1005, 434)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_staffname)
        Me.Controls.Add(Me.lbl_customername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_customer)
        Me.Controls.Add(Me.grd_shoppingcart)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.cmb_category)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lst_product)
        Me.Controls.Add(Me.label)
        Me.Name = "frm_makeorder_a160195"
        Me.Text = "BEST Corporate Gifts and Souvenirs"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_shoppingcart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents cmb_category As System.Windows.Forms.ComboBox
    Friend WithEvents pic_product As System.Windows.Forms.PictureBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents lst_product As System.Windows.Forms.ListBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents txt_quantity As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_order As System.Windows.Forms.Button
    Friend WithEvents lbl_orderid As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents grd_shoppingcart As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_customer As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_customername As System.Windows.Forms.Label
    Friend WithEvents lbl_staffname As System.Windows.Forms.Label
    Friend WithEvents lbl_title As System.Windows.Forms.Label
End Class

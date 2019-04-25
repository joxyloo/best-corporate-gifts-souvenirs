<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menuupdate_a160195
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_product = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.DarkCyan
        Me.lbl_title.Location = New System.Drawing.Point(135, 26)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(177, 23)
        Me.lbl_title.TabIndex = 18
        Me.lbl_title.Text = "UPDATE/DELETE"
        '
        'btn_customer
        '
        Me.btn_customer.BackColor = System.Drawing.Color.White
        Me.btn_customer.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.Location = New System.Drawing.Point(62, 161)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(301, 42)
        Me.btn_customer.TabIndex = 17
        Me.btn_customer.Text = "CUSTOMER"
        Me.btn_customer.UseVisualStyleBackColor = False
        '
        'btn_staff
        '
        Me.btn_staff.BackColor = System.Drawing.Color.White
        Me.btn_staff.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.Location = New System.Drawing.Point(62, 113)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(301, 42)
        Me.btn_staff.TabIndex = 16
        Me.btn_staff.Text = "STAFF"
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'btn_product
        '
        Me.btn_product.BackColor = System.Drawing.Color.White
        Me.btn_product.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_product.Location = New System.Drawing.Point(62, 65)
        Me.btn_product.Name = "btn_product"
        Me.btn_product.Size = New System.Drawing.Size(301, 42)
        Me.btn_product.TabIndex = 15
        Me.btn_product.Text = "PRODUCT"
        Me.btn_product.UseVisualStyleBackColor = False
        '
        'frm_menuupdate_a160195
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(425, 228)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_product)
        Me.Name = "frm_menuupdate_a160195"
        Me.Text = "BEST Corporate Gifts and Souvenirs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents btn_customer As System.Windows.Forms.Button
    Friend WithEvents btn_staff As System.Windows.Forms.Button
    Friend WithEvents btn_product As System.Windows.Forms.Button
End Class

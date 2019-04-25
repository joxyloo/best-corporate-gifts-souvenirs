<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_catalogue_a160195
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
        Me.lst_product = New System.Windows.Forms.ListBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.cmb_category = New System.Windows.Forms.ComboBox()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.DarkCyan
        Me.lbl_title.Location = New System.Drawing.Point(193, 24)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(140, 23)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "CATALOGUE"
        '
        'lst_product
        '
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.Location = New System.Drawing.Point(39, 93)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(123, 160)
        Me.lst_product.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(39, 271)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(409, 95)
        Me.txt_name.TabIndex = 2
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(168, 67)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(280, 187)
        Me.pic_product.TabIndex = 3
        Me.pic_product.TabStop = False
        '
        'cmb_category
        '
        Me.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_category.FormattingEnabled = True
        Me.cmb_category.Location = New System.Drawing.Point(39, 67)
        Me.cmb_category.Name = "cmb_category"
        Me.cmb_category.Size = New System.Drawing.Size(121, 21)
        Me.cmb_category.TabIndex = 5
        '
        'frm_catalogue_a160195
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(494, 422)
        Me.Controls.Add(Me.cmb_category)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lst_product)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_catalogue_a160195"
        Me.Text = "BEST Corporate Gifts and Souvenirs"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents lst_product As System.Windows.Forms.ListBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents pic_product As System.Windows.Forms.PictureBox
    Friend WithEvents cmb_category As System.Windows.Forms.ComboBox
End Class

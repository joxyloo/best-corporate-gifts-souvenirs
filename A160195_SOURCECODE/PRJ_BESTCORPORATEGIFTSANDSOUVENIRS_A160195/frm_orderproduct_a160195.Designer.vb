<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderproduct_a160195
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
        Me.cmb_order = New System.Windows.Forms.ComboBox()
        Me.grd_orderproduct = New System.Windows.Forms.DataGridView()
        Me.btn_done = New System.Windows.Forms.Button()
        CType(Me.grd_orderproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_order
        '
        Me.cmb_order.FormattingEnabled = True
        Me.cmb_order.Location = New System.Drawing.Point(26, 24)
        Me.cmb_order.Name = "cmb_order"
        Me.cmb_order.Size = New System.Drawing.Size(121, 21)
        Me.cmb_order.TabIndex = 0
        Me.cmb_order.Text = "Select order"
        '
        'grd_orderproduct
        '
        Me.grd_orderproduct.BackgroundColor = System.Drawing.Color.White
        Me.grd_orderproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderproduct.Location = New System.Drawing.Point(26, 64)
        Me.grd_orderproduct.Name = "grd_orderproduct"
        Me.grd_orderproduct.Size = New System.Drawing.Size(344, 150)
        Me.grd_orderproduct.TabIndex = 1
        '
        'btn_done
        '
        Me.btn_done.Location = New System.Drawing.Point(306, 241)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.Size = New System.Drawing.Size(75, 23)
        Me.btn_done.TabIndex = 2
        Me.btn_done.Text = "DONE"
        Me.btn_done.UseVisualStyleBackColor = True
        '
        'frm_orderproduct_a160195
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(393, 276)
        Me.Controls.Add(Me.btn_done)
        Me.Controls.Add(Me.grd_orderproduct)
        Me.Controls.Add(Me.cmb_order)
        Me.Name = "frm_orderproduct_a160195"
        Me.Text = "BEST Corporate Gifts and Souvenirs"
        CType(Me.grd_orderproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_order As System.Windows.Forms.ComboBox
    Friend WithEvents grd_orderproduct As System.Windows.Forms.DataGridView
    Friend WithEvents btn_done As System.Windows.Forms.Button
End Class

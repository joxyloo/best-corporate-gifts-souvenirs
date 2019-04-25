Public Class frm_orderproduct_a160195

    Private Sub frm_orderproduct_a160195_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_ORDERLIST_A160195"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        cmb_order.DataSource = mydatatable
        cmb_order.DisplayMember = "FLD_ORDER_NO"

        refresh_grid()

    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_ORDERLIST_A160195"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_orderproduct.DataSource = mydatatable

        grd_orderproduct.Columns(0).HeaderText = "Order No."
        grd_orderproduct.Columns(1).HeaderText = "Product ID"
        grd_orderproduct.Columns(2).HeaderText = "Quantity"


    End Sub

    Private Sub btn_done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_done.Click
        frm_orderinfo_a160195.Show()
        Me.Hide()
    End Sub
End Class
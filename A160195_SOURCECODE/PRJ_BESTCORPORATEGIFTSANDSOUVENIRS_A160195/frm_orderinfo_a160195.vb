Public Class frm_orderinfo_a160195

    Private Sub frm_orderinfo_a160195_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A160195"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_order.DataSource = mydatatable


        grd_order.Columns(0).HeaderText = "Order No."
        grd_order.Columns(1).HeaderText = "Date"
        grd_order.Columns(2).HeaderText = "Customer ID"
        grd_order.Columns(3).HeaderText = "Staff ID"



    End Sub

   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frm_vieworder_a160195.Show()

    End Sub
End Class
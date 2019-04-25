Public Class frm_vieworder_a160195

    Dim orderid As String
    Dim custid As String
    Dim staffid As String
    Dim orderdate As String

    Private Sub frm_vieworder_a160195_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_orderid.DataSource = run_sql_query("SELECT FLD_ORDER_NO FROM TBL_ORDER_A160195")
        cmb_orderid.DisplayMember = "FLD_ORDER_NO"

        grd_details.Columns(0).HeaderText = "Product ID"
        grd_details.Columns(1).HeaderText = "Product Name"
        grd_details.Columns(2).HeaderText = "Quantity"
        grd_details.Columns(3).HeaderText = "Price/Unit(RM)"
        grd_details.Columns(4).HeaderText = "Subtotal price(RM)"

        refresh_details()

    End Sub

    Private Sub cmb_orderid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_orderid.SelectedIndexChanged

        refresh_details()
        refresh_grid()


    End Sub

    Private Sub refresh_details()

        Dim i As Integer = cmb_orderid.SelectedIndex

        Dim orderdatatable = run_sql_query("SELECT * FROM TBL_ORDER_A160195")

        custid = orderdatatable.Rows(i).Item("FLD_CUSTOMER_ID")
        lbl_customerid.Text = custid
        staffid = orderdatatable.Rows(i).Item("FLD_STAFF_ID")
        lbl_staffid.Text = staffid
        orderdate = orderdatatable.Rows(i).Item("FLD_DATE")
        lbl_date.Text = orderdate
       
        Dim customer = run_sql_query("SELECT * FROM TBL_CUSTOMER_A160195 where FLD_CUSTOMER_ID = '" & lbl_customerid.Text & "'")
        lbl_customername.Text = customer.Rows(0).Item("FLD_CUSTOMER_NAME")

        'Dim points = run_sql_query("SELECT * FROM TBL_CUSTOMER_A160195 where FLD_CUSTOMER_ID = '" & lbl_customerid.Text & "'")
        lbl_points.Text = customer.Rows(0).Item("FLD_CUSTOMER_POINTS")

        Dim staff = run_sql_query("SELECT * FROM TBL_STAFF_A160195 where FLD_STAFF_ID = '" & lbl_staffid.Text & "'")
        lbl_staffname.Text = staff.Rows(0).Item("FLD_STAFF_NAME")




    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT TBL_ORDERLIST_A160195.FLD_PRODUCT_ID, TBL_PRODUCT_A160195.FLD_PRODUCT_NAME, TBL_PRODUCT_A160195.FLD_PRICE, TBL_ORDERLIST_A160195.QUANTITY, TBL_ORDERLIST_A160195.TOTAL FROM TBL_PRODUCT_A160195 INNER JOIN (TBL_ORDER_A160195 INNER JOIN TBL_ORDERLIST_A160195 ON TBL_ORDER_A160195.FLD_ORDER_NO = TBL_ORDERLIST_A160195.FLD_ORDER_NO) ON TBL_PRODUCT_A160195.FLD_PRODUCT_ID = TBL_ORDERLIST_A160195.FLD_PRODUCT_ID where TBL_ORDERLIST_A160195.FLD_ORDER_NO like""%" & cmb_orderid.Text & "%"""


        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_details.DataSource = mydatatable

        'grd_details.AutoSizeRowsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        If grd_details.RowCount > 0 Then
            Dim gtotal As Double = 0
            For index As Integer = 0 To grd_details.RowCount - 1
                gtotal += grd_details.Rows(index).Cells(4).Value

            Next
            lbl_total.Text = "Total: RM " & gtotal
        End If

    End Sub

End Class

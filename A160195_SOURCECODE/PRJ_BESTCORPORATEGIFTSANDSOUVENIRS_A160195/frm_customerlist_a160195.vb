Public Class frm_customerlist_a160195

    Private Sub frm_customerlist_a160195_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A160195"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)



        grd_customer.DataSource = mydatatable

        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(1).HeaderText = "Customer Name"
        grd_customer.Columns(2).HeaderText = "Points Collected"
        grd_customer.Columns(3).HeaderText = "Contact"
        grd_customer.Columns(4).HeaderText = "E-mail"





    End Sub

   
End Class
Public Class frm_productdetails_a160195

    Private Sub frm_productdetails_a160195_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A160195"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_productdetails.DataSource = mydatatable

        grd_productdetails.Columns(0).HeaderText = "Product ID"
        grd_productdetails.Columns(1).HeaderText = "Product Name"
        grd_productdetails.Columns(2).HeaderText = "Price"
        grd_productdetails.Columns(3).HeaderText = "Category"
        grd_productdetails.Columns(4).HeaderText = "Material"
        grd_productdetails.Columns(5).HeaderText = "Colour"
        grd_productdetails.Columns(6).HeaderText = "Made In"

    End Sub



End Class
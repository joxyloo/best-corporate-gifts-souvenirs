Public Class frm_catalogue_a160195

    Private Sub frm_catalogue_a160195_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        pic_product.BackgroundImage = Image.FromFile("pictures/noimage.jpg")
    End Sub



    Private Sub frm_catalogue_a160195_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_CATEGORY_NAME FROM TBL_CATEGORY_A160195"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        cmb_category.DataSource = mydatatable
        cmb_category.DisplayMember = "FLD_CATEGORY_NAME"

    End Sub

    Private Sub refresh_list(ByVal cat_name As String)

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCT_A160195 WHERE FLD_CATEGORY='" & cat_name & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_product.DataSource = mydatatable
        lst_product.DisplayMember = "FLD_PRODUCT_ID"


    End Sub

    Private Sub refresh_text(ByVal product As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A160195 WHERE FLD_PRODUCT_ID='" & product & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_name.Text = "Product: " & mydatatable.Rows(0).Item("FLD_PRODUCT_NAME") & Environment.NewLine & _
            "Price: RM " & mydatatable.Rows(0).Item("FLD_PRICE") & Environment.NewLine & _
             "Category: " & mydatatable.Rows(0).Item("FLD_CATEGORY") & Environment.NewLine & _
              "Material: " & mydatatable.Rows(0).Item("FLD_MATERIAL") & Environment.NewLine & _
               "Colour: " & mydatatable.Rows(0).Item("FLD_COLOUR") & Environment.NewLine & _
                "Made In  " & mydatatable.Rows(0).Item("FLD_MADEIN") & Environment.NewLine


        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & mydatatable.Rows(0).Item("FLD_PRODUCT_ID") & ".jpg")

        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/noimage.jpg")

        End Try

    End Sub

    Private Sub cmb_category_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_category.SelectedIndexChanged

        refresh_list(cmb_category.Text)

    End Sub

    Private Sub lst_product_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_product.SelectedIndexChanged
        refresh_text(lst_product.Text)
    End Sub


End Class
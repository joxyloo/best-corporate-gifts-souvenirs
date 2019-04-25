Public Class frm_update_del_product_a160195

    Dim currentID As String

    Private Sub frm_updateproduct_a160195_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        refresh_grid()

        get_currentID()



    End Sub

    Private Sub refresh_grid()

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


    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_category.Text = ""
        txt_material.Text = ""
        txt_colour.Text = ""
        txt_madein.Text = ""


    End Sub

    Private Sub get_currentID()

        Dim current_row As Integer = grd_productdetails.CurrentRow.Index

        currentID = grd_productdetails(0, current_row).Value

        txt_id.Text = currentID
        txt_name.Text = grd_productdetails(1, current_row).Value
        txt_price.Text = grd_productdetails(2, current_row).Value
        txt_category.Text = grd_productdetails(3, current_row).Value
        txt_material.Text = grd_productdetails(4, current_row).Value
        txt_colour.Text = grd_productdetails(5, current_row).Value
        txt_madein.Text = grd_productdetails(6, current_row).Value

      
    End Sub

    Private Sub grd_product_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_productdetails.CellClick

        get_currentID()

    End Sub


    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click

        run_sql_command("update tbl_product_a160195 set fld_product_name='" & txt_name.Text & "' where fld_product_id='" & currentID & "'")

        run_sql_command("update tbl_product_a160195 set fld_price='" & txt_price.Text & "' where fld_product_id='" & currentID & "'")

        run_sql_command("update tbl_product_a160195 set fld_category='" & txt_category.Text & "' where fld_product_id='" & currentID & "'")

        run_sql_command("update tbl_product_a160195 set fld_material='" & txt_material.Text & "' where fld_product_id='" & currentID & "'")

        run_sql_command("update tbl_product_a160195 set fld_colour='" & txt_colour.Text & "' where fld_product_id='" & currentID & "'")

        run_sql_command("update tbl_product_a160195 set fld_madein='" & txt_madein.Text & "' where fld_product_id='" & currentID & "'")

        Beep()
        MsgBox("You have successfully updated the product """ & currentID & """.")

        refresh_grid()

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & currentID & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_PRODUCT_A160195 WHERE FLD_PRODUCT_ID='" & currentID & "'")

            My.Computer.FileSystem.DeleteFile("pictures\" & txt_id.Text & ".jpg")

            Beep()
            MsgBox("The product """ & currentID & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_currentID()

        End If
    End Sub
   
End Class
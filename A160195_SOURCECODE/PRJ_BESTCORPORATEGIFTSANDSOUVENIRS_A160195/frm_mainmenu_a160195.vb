Public Class frm_mainmenu_a160195

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click

        End

    End Sub

    Private Sub frm_mainmenu_a160195_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub


    Private Sub frm_mainmenu_a160195vb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim user = run_sql_query("SELECT FLD_STAFF_NAME FROM TBL_STAFF_A160195 WHERE FLD_STAFF_ID = '" & userid & "'")
        Dim current_date As String = Date.Now
        lbl_date.Text = current_date
        lbl_welcome.Text = user.Rows(0).Item("FLD_STAFF_NAME")
        username = lbl_welcome.Text

    End Sub

  

    Private Sub btn_order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_order.Click

        frm_orderinfo_a160195.Show()


    End Sub

    Private Sub btn_customer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_customer.Click

        frm_customerlist_a160195.Show()

    End Sub

    Private Sub btn_staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_staff.Click

        frm_stafflist_a160195.Show()

    End Sub

    Private Sub btn_catalogue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_catalogue_a160195.Show()
    End Sub

    Private Sub btn_catalogue_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_catalogue.Click

        frm_catalogue_a160195.Show()

    End Sub

    Private Sub btn_product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_product.Click

        frm_productdetails_a160195.Show()
        
    End Sub

    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click

        frm_menuinsert_a160195.Show()
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update_del.Click

        frm_menuupdate_a160195.Show()

    End Sub

   
    Private Sub btn_makeorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_makeorder.Click
        frm_makeorder_a160195.Show()
    End Sub


End Class
Public Class frm_update_del_customer_a160195
    Dim currentID As String

    Private Sub frm_updatecustomer_a160195_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        refresh_grid()

        get_currentID()


    End Sub

    Private Sub refresh_grid()

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


    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_points.Text = ""
        txt_contact.Text = ""
        txt_email.Text = ""

    End Sub

    Private Sub get_currentID()

        Dim current_row As Integer = grd_customer.CurrentRow.Index

        currentID = grd_customer(0, current_row).Value

        txt_id.Text = currentID
        txt_name.Text = grd_customer(1, current_row).Value
        txt_points.Text = grd_customer(2, current_row).Value
        txt_contact.Text = grd_customer(3, current_row).Value
        txt_email.Text = grd_customer(4, current_row).Value


    End Sub

    Private Sub grd_customer_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_customer.CellClick

        get_currentID()

    End Sub


    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_CUSTOMER_A160195 SET FLD_CUSTOMER_NAME='" & txt_name.Text & "' WHERE FLD_CUSTOMER_ID='" & currentID & "'")

        run_sql_command("UPDATE TBL_CUSTOMER_A160195 SET FLD_CUSTOMER_POINTS=" & txt_points.Text & " WHERE FLD_CUSTOMER_ID='" & currentID & "'")

        run_sql_command("UPDATE TBL_CUSTOMER_A160195 SET FLD_CUSTOMER_CONTACT='" & txt_contact.Text & "' WHERE FLD_CUSTOMER_ID='" & currentID & "'")

        run_sql_command("UPDATE TBL_CUSTOMER_A160195 SET FLD_CUSTOMER_EMAIL='" & txt_email.Text & "' WHERE FLD_CUSTOMER_ID='" & currentID & "'")

        Beep()
        MsgBox("You have successfully updated the customer """ & currentID & """.")

        refresh_grid()

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the customer """ & currentID & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_CUSTOMER_A160195 WHERE FLD_CUSTOMER_ID='" & currentID & "'")

            Beep()
            MsgBox("The customer """ & currentID & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_currentID()

        End If

    End Sub
End Class
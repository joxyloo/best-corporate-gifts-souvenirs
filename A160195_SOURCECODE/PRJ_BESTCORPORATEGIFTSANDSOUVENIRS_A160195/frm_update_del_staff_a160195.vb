Public Class frm_update_del_staff_a160195

    Dim currentID As String

    Private Sub frm_updatestaff_a160195_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        refresh_grid()

        get_currentID()


    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A160195"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_staff.DataSource = mydatatable

        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"
        grd_staff.Columns(2).HeaderText = "Title/Position"

    End Sub


    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_title.Text = ""

    End Sub

    Private Sub get_currentID()

        Dim current_row As Integer = grd_staff.CurrentRow.Index

        currentID = grd_staff(0, current_row).Value

        txt_id.Text = currentID
        txt_name.Text = grd_staff(1, current_row).Value
        txt_title.Text = grd_staff(2, current_row).Value

    End Sub

    Private Sub grd_staff_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_staff.CellClick

        get_currentID()

    End Sub


    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_STAFF_A160195 SET FLD_STAFF_NAME='" & txt_name.Text & "' WHERE FLD_STAFF_ID='" & currentID & "'")

        run_sql_command("UPDATE TBL_STAFF_A160195 SET FLD_STAFF_TITLE='" & txt_title.Text & "' WHERE FLD_STAFF_ID='" & currentID & "'")


        Beep()
        MsgBox("You have successfully updated the staff """ & currentID & """.")

        refresh_grid()

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the staff """ & currentID & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_STAFF_A160195 WHERE FLD_STAFF_ID='" & currentID & "'")

            Beep()
            MsgBox("The staff """ & currentID & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_currentID()

        End If
    End Sub

End Class
Public Class frm_login_a160195



    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click

        userid = txt_username.Text

        Dim mysql As String = "SELECT COUNT(*) AS NUM_MATCHES FROM TBL_USER_A160195 WHERE FLD_USERID='" & txt_username.Text & "' and FLD_PASSWORD='" & txt_password.Text & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        Dim num_matches As String = mydatatable.Rows(0).Item("NUM_MATCHES")

        If num_matches = 1 Then

            frm_mainmenu_a160195.Show()
            Me.Hide()

        Else

            txt_username.Text = ""
            txt_password.Text = ""
            MsgBox("Incorrect Username or Password")

        End If

    End Sub

    Private Sub frm_login_a160195_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbl_username_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_username.Click

    End Sub

    Private Sub txt_username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_username.TextChanged

    End Sub
End Class
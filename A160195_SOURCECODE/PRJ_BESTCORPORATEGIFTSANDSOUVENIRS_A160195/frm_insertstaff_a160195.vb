Public Class frm_insertstaff_a160195

    Private Sub frm_insertstaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A160195") 'this is same as refresh_grid()

        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"
        grd_staff.Columns(2).HeaderText = "Title/Position"

        txt_id.Text = generate_id()


    End Sub

    Private Function generate_id() As String

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTID FROM TBL_STAFF_A160195").Rows(0).Item("LASTID")

        'MsgBox(lastid)

        Dim nextid As Integer = Mid(lastid, 2) + 1

        Dim newid As String = "S" & Format(nextid, "000")

        Return newid

    End Function

    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click

        If Mid((txt_id.Text), 1, 1) = "S" Then

            If txt_id.Text.Length = 4 Then

                Dim mysql As String = "INSERT INTO TBL_STAFF_A160195 VALUES ('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_title.Text & "')"

                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

                Try
                    mywriter.Connection.Open()
                    mywriter.ExecuteNonQuery()
                    mywriter.Connection.Close()

                    grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A160195")

                    txt_id.Text = generate_id()
                    txt_name.Text = ""
                    txt_title.Text = ""

                Catch ex As Exception

                    Beep()
                    MsgBox("There is a mistake in the data you entered, as shown below:" & vbCrLf & vbCrLf & ex.Message)

                    mywriter.Connection.Close()



                End Try

            Else
                Beep()
                MsgBox("There is a mistake in the data you entered, as shown below:" & vbCrLf & vbCrLf & "Staff ID entered does not follow format.")

            End If
           
        Else
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below:" & vbCrLf & vbCrLf & "Staff ID entered does not start with ""S"".")
        End If
        

    End Sub

    Private Sub grd_staff_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_staff.CellContentClick

    End Sub
End Class
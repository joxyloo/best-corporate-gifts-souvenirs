Public Class frm_insertcustomer_a160195

    Private Sub frm_insertcustomer_a160195_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        grd_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A160195")

        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(1).HeaderText = "Customer Name"
        grd_customer.Columns(2).HeaderText = "Points Collected"
        grd_customer.Columns(3).HeaderText = "Contact"
        grd_customer.Columns(4).HeaderText = "E-mail"


        txt_id.Text = generate_id()

    End Sub

    Private Function generate_id() As String

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTID FROM TBL_CUSTOMER_A160195").Rows(0).Item("LASTID")

        'MsgBox(Mid(lastid, 3))


        Dim nextid As Integer = Mid(lastid, 2) + 1

        Dim newid As String = "C" & Format(nextid, "000")



        Return newid

    End Function

    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click

        If Mid((txt_id.Text), 1, 1) = "C" Then

            If txt_id.Text.Length = 4 Then
                Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A160195 VALUES ('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_points.Text & "','" & txt_contact.Text & "','" & txt_email.Text & "')"

                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

                Try
                    mywriter.Connection.Open()
                    mywriter.ExecuteNonQuery()
                    mywriter.Connection.Close()

                    grd_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A160195")

                    txt_id.Text = generate_id()
                    txt_name.Text = ""
                    txt_contact.Text = ""
                    txt_email.Text = ""

                Catch ex As Exception

                    Beep()
                    MsgBox("There is a mistake in the data you entered, as shown below:" & vbCrLf & vbCrLf & ex.Message)

                    mywriter.Connection.Close()



                End Try

            Else
                Beep()
                MsgBox("There is a mistake in the data you entered, as shown below:" & vbCrLf & vbCrLf & "Customer ID entered does not follow format.")
            End If

          
        Else
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below:" & vbCrLf & vbCrLf & "Customer ID entered does not start with ""C"".")
        End If


    End Sub
End Class
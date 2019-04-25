Public Class frm_insertproduct_a160195

    Dim defaultpicture As String = Application.StartupPath & "\pictures\noimage.jpg"

    Private Sub frm_insertproduct_a160195_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        grd_productdetails.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCT_A160195")


        grd_productdetails.Columns(0).HeaderText = "Product ID"
        grd_productdetails.Columns(1).HeaderText = "Product Name"
        grd_productdetails.Columns(2).HeaderText = "Price"
        grd_productdetails.Columns(3).HeaderText = "Category"
        grd_productdetails.Columns(4).HeaderText = "Material"
        grd_productdetails.Columns(5).HeaderText = "Colour"
        grd_productdetails.Columns(6).HeaderText = "Made In"
        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

        txt_id.Text = generate_id()

        'combo box

        Dim mysql As String = "SELECT FLD_CATEGORY_NAME FROM TBL_CATEGORY_A160195"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        cmb_category.DataSource = mydatatable
        cmb_category.DisplayMember = "FLD_CATEGORY_NAME"


    End Sub


    Private Function generate_id() As String

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCT_A160195").Rows(0).Item("LASTID")

        'MsgBox(lastid)

        Dim nextid As Integer = Mid(lastid, 2) + 1

        Dim newid As String = "P" & Format(nextid, "000")

        Return newid

    End Function

    

    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        cmb_category.Text = ""
        txt_material.Text = ""
        txt_colour.Text = ""
        txt_madein.Text = ""


    End Sub

    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click

        If Mid((txt_id.Text), 1, 1) = "P" Then

            If txt_id.Text.Length = 4 Then
                Dim mysql As String = "INSERT INTO TBL_PRODUCT_A160195 VALUES ('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_price.Text & "','" & cmb_category.Text & "','" & txt_material.Text & "','" & txt_colour.Text & "','" & txt_madein.Text & "')"

                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)


                Try
                    mywriter.Connection.Open()
                    mywriter.ExecuteNonQuery()
                    mywriter.Connection.Close()

                    My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_id.Text & ".jpg")

                    grd_productdetails.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCT_A160195")
                    clear_fields()

                    txt_id.Text = generate_id()
                    txt_picture.Text = defaultpicture
                    pic_product.BackgroundImage = Image.FromFile(defaultpicture)




                Catch ex As Exception

                    Beep()
                    MsgBox("There is a mistake in the data you entered, as shown below:" & vbCrLf & vbCrLf & ex.Message)

                    mywriter.Connection.Close()




                End Try
            Else
                Beep()
                MsgBox("There is a mistake in the data you entered, as shown below:" & vbCrLf & vbCrLf & "Product ID entered does not follow format.")
            End If

        Else
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below:" & vbCrLf & vbCrLf & "Product ID entered does not start with ""P"".")

        End If


    End Sub

    Private Sub btn_pictue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pictue.Click

        Dim mydekstop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydekstop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName

    End Sub


End Class
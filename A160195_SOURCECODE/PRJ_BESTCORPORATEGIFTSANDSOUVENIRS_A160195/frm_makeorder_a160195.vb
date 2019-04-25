Public Class frm_makeorder_a160195

    Private dateonly As String = Date.Now.ToShortDateString
    Dim gtotal As Double

    Private Sub frm_makeorder_a160195_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbl_orderid.Text = generate_orderid()

        Dim current_date = Date.Now

        lbl_date.Text = current_date

        lbl_staffname.Text = userid & " " & username

        cmb_category.DataSource = run_sql_query("SELECT FLD_CATEGORY_NAME FROM TBL_CATEGORY_A160195")
        cmb_category.DisplayMember = "FLD_CATEGORY_NAME"

        cmb_customer.DataSource = run_sql_query("SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMER_A160195")
        cmb_customer.DisplayMember = "FLD_CUSTOMER_ID"

        'cmb_staff.DataSource = run_sql_query("SELECT FLD_STAFF_ID FROM TBL_STAFF_A160195")
        ' cmb_staff.DisplayMember = "FLD_STAFF_ID"

        ' shopping cart
        grd_shoppingcart.ColumnCount = 5
        grd_shoppingcart.Columns(0).HeaderText = "Product ID"
        grd_shoppingcart.Columns(1).HeaderText = "Product Name"
        grd_shoppingcart.Columns(2).HeaderText = "Quantity"
        grd_shoppingcart.Columns(3).HeaderText = "Price/Unit(RM)"
        grd_shoppingcart.Columns(4).HeaderText = "Subtotal price(RM)"

        ' shopping cart

    End Sub



    Private Function generate_orderid() As String



        Dim lastid As String = run_sql_query("SELECT MAX(FLD_ORDER_NO) AS LASTID FROM TBL_ORDER_A160195").Rows(0).Item("LASTID").ToString


        'MsgBox(lastid)

        If (lastid.Equals("")) Then
            lastid = "0000"


        End If

        Dim nextid As Integer = Mid(lastid, 2) + 1

        Dim newid As String = "D" & Format(nextid, "000")

        Return newid


    End Function

    Private Sub cmb_category_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_category.SelectedIndexChanged

        refresh_list(cmb_category.Text)

    End Sub

    Private Sub refresh_list(ByVal cat_name As String)

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCT_A160195 WHERE FLD_CATEGORY='" & cat_name & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_product.DataSource = mydatatable
        lst_product.DisplayMember = "FLD_PRODUCT_ID"


    End Sub

    Private Sub lst_product_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_product.SelectedIndexChanged
        refresh_text(lst_product.Text)
    End Sub

    Private Sub refresh_text(ByVal product As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A160195 WHERE FLD_PRODUCT_ID='" & product & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME") & Environment.NewLine & _
            "RM " & mydatatable.Rows(0).Item("FLD_PRICE")


        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & mydatatable.Rows(0).Item("FLD_PRODUCT_ID") & ".jpg")

        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/noimage.jpg")

        End Try

    End Sub



    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click

        Dim selectedProductID = lst_product.GetItemText(lst_product.SelectedItem)

        ' data
        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A160195 WHERE FLD_PRODUCT_ID='" & selectedProductID & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)
        ' data

        Dim selectedProductName As String = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")

        Dim quantity As Integer = 0

        Dim current_price = mydatatable.Rows(0).Item("FLD_PRICE")




        Try
            quantity = txt_quantity.Text

            grd_shoppingcart.RowCount = grd_shoppingcart.RowCount + 1
            Dim newrow As Integer = grd_shoppingcart.RowCount - 1
            grd_shoppingcart(0, newrow).Value = selectedProductID
            grd_shoppingcart(1, newrow).Value = selectedProductName
            grd_shoppingcart(2, newrow).Value = quantity
            grd_shoppingcart(3, newrow).Value = current_price
            grd_shoppingcart(4, newrow).Value = quantity * current_price


            If grd_shoppingcart.RowCount > 0 Then
                gtotal = 0
                For index As Integer = 0 To grd_shoppingcart.RowCount - 1
                    gtotal += grd_shoppingcart.Rows(index).Cells(4).Value

                Next
                lbl_total.Text = "Total: RM " & gtotal
            End If

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below:" & vbCrLf & vbCrLf & ex.Message)

        End Try



        'cmb_qty.Text = "1"



    End Sub

    Private Sub btn_order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_order.Click

        If grd_shoppingcart.Rows.Count > 0 Then

            Dim mytransaction As OleDb.OleDbTransaction
            myconnection2.Open()
            mytransaction = myconnection2.BeginTransaction


            Try
                Dim orderid As String = lbl_orderid.Text
                Dim customer As String = cmb_customer.Text
                Dim staff As String = userid
                '
                Dim points As Integer = run_sql_query("SELECT * FROM TBL_CUSTOMER_A160195 WHERE FLD_CUSTOMER_ID ='" & customer & "'").Rows(0).Item("FLD_CUSTOMER_POINTS")
                points = points + gtotal

                Dim mysql2 As String = "UPDATE TBL_CUSTOMER_A160195 SET FLD_CUSTOMER_POINTS=" & points & " WHERE FLD_CUSTOMER_ID='" & customer & "'"
                Dim mywriter2 As New OleDb.OleDbCommand(mysql2, myconnection2, mytransaction)
                mywriter2.ExecuteNonQuery()
                'run_sql_command("UPDATE TBL_CUSTOMER_A160195 SET FLD_CUSTOMER_POINTS=" & points & " WHERE FLD_CUSTOMER_ID='" & customer & "'")
                '
                Dim mysql1 As String = "INSERT INTO TBL_ORDER_A160195 VALUeS ('" & orderid & "', '" & dateonly & "', '" & customer & "','" & staff & "')"
                Dim mywriter As New OleDb.OleDbCommand(mysql1, myconnection2, mytransaction)
                mywriter.ExecuteNonQuery()

                For i As Integer = 0 To grd_shoppingcart.RowCount - 1

                    Dim product As String = grd_shoppingcart(0, i).Value
                    Dim qty As Integer = grd_shoppingcart(2, i).Value
                    Dim total1 As String = grd_shoppingcart(4, i).Value

                    Dim mysql As String = "INSERT INTO TBL_ORDERLIST_A160195 VALUeS ('" & orderid & "', '" & product & "', '" & qty & "','" & total1 & "')"
                    Dim mywriter1 As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)
                    mywriter1.ExecuteNonQuery()

                Next

                mytransaction.Commit()
                myconnection2.Close()
                Beep()
                MsgBox("Transaction Successful!")
                lbl_orderid.Text = generate_orderid()
                grd_shoppingcart.RowCount = 0


            Catch ex As Exception
                Beep()
                MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)

                mytransaction.Rollback()
                myconnection2.Close()
                'refresh_grid()

            End Try

        Else

            MessageBox.Show("Cart is empty.", "BEST Corporate Gifts and Souvenirs")

        End If
       
    End Sub

    Private Sub cmb_customer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_customer.SelectedIndexChanged

        Dim i As Integer = cmb_customer.SelectedIndex
        Dim mydatatable = run_sql_query("SELECT * FROM TBL_CUSTOMER_A160195")
        lbl_customername.Text = mydatatable.Rows(i).Item("FLD_CUSTOMER_NAME")

    End Sub

    Private Sub cmb_staff_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim i As Integer = cmb_staff.SelectedIndex
        'Dim mydatatable = run_sql_query("SELECT * FROM TBL_STAFF_A160195")
        'lbl_staffname.Text = mydatatable.Rows(i).Item("FLD_STAFF_NAME")

    End Sub

    
  
    
End Class
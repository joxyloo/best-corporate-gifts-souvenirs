Public Class frm_splashscreen_a160195

    Private Sub frm_splashscreen_a160195_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

   
    Private Sub btn_start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_start.Click

        username = txt_name.Text

        frm_mainmenu_a160195.Show()
        Me.Hide()

    End Sub


End Class
Public Class frm_splashsreen_a190409
    Private Sub frm_splashsreen_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome!")
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        'MsgBox("Welcome " & txt_name.Text & " to the UKM Faculty Record System")
        fullname = txt_name.Text
        matric = txt_matric.Text
        frm_mainmenu_a190409.Show()
        Me.Hide()
    End Sub
End Class

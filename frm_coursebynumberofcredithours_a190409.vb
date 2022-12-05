Public Class frm_coursebynumberofcredithours_a190409
    Private Sub frm_coursebynumberofcredithours_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid(numeric_box.Value)
    End Sub

    Private Sub refresh_grid(credit As Integer)
        Dim mysql As String = "SELECT * FROM TBL_COURSES_A190409 WHERE FLD_CREDITS=" & credit & ""
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_courses.DataSource = mydatatable

    End Sub

    Private Sub numeric_credit_hours_ValueChanged(sender As Object, e As EventArgs) Handles numeric_box.ValueChanged
        refresh_grid(numeric_box.Value)
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        frm_mainmenu_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub lbl_title_Click(sender As Object, e As EventArgs) Handles lbl_title.Click

    End Sub
End Class
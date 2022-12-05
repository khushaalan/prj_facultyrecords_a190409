Public Class frm_searchcourses_a190409
    Private Sub frm_searchcourses_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
    End Sub


    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_COURSES_A190409 WHERE FLD_COURSE_NAME like '%" & txt_search.Text & "%'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_courses.DataSource = mydatatable
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        refresh_grid()
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        frm_mainmenu_a190409.Show()
        Me.Hide()
    End Sub
End Class
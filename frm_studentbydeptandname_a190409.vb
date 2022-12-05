Public Class frm_studentbydeptandname_a190409
    Private Sub frm_studentbydeptandname_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_DEPT FROM TBL_STUDENTS_A190409"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        cmb_dept.DataSource = mydatatable
        cmb_dept.DisplayMember = "FLD_DEPT"


        refresh_grid(txt_name.Text, cmb_dept.Text)
    End Sub


    Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged
        refresh_grid(txt_name.Text, cmb_dept.Text)

    End Sub

    Private Sub cmb_dept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_dept.SelectedIndexChanged
        refresh_grid(txt_name.Text, cmb_dept.Text)
    End Sub

    Private Sub refresh_grid(name As String, dept As String)
        Dim mysql As String = "SELECT * FROM TBL_STUDENTS_A190409 WHERE FLD_NAME LIKE '%" & name & "%' AND FLD_DEPT ='" & dept & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_student.DataSource = mydatatable
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        frm_mainmenu_a190409.Show()
        Me.Hide()
    End Sub
End Class
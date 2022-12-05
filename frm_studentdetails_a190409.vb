Public Class frm_studentdetails_a190409
    Private Sub frm_studentdetails_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_MATRIC FROM TBL_STUDENTS_A190409"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_matric.DataSource = mydatatable
        lst_matric.DisplayMember = "FLD_MATRIC"

        refresh_text(lst_matric.Text)

    End Sub

    Private Sub refresh_text(matric As String)
        Dim mysql As String = "SELECT * FROM TBL_STUDENTS_A190409 WHERE FLD_MATRIC='" &
        matric & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        txt_matric.Text = mydatatable.Rows(0).Item("FLD_MATRIC")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_NAME")
        txt_dept.Text = mydatatable.Rows(0).Item("FLD_DEPT")

        pic_student.BackgroundImage = Image.FromFile("pictures/" & txt_matric.Text & ".jpg")

    End Sub

    Private Sub lst_matric_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_matric.MouseClick
        refresh_text(lst_matric.Text)
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        frm_mainmenu_a190409.Show()
        Me.Hide()
    End Sub

End Class
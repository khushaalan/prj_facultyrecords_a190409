Public Class frm_studentbycoursesessionandsemester
    Private Sub frm_studentbycoursesessionandsemester_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT DISTINCT FLD_SESSION FROM TBL_REGISTRATION_A190409"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_session.DataSource = mydatatable
        cmb_session.DisplayMember = "FLD_SESSION"

        Dim mysql2 As String = "SELECT DISTINCT FLD_SEMESTER FROM TBL_REGISTRATION_A190409"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)
        cmb_semester.DataSource = mydatatable2
        cmb_semester.DisplayMember = "FLD_SEMESTER"

        Dim mysql3 As String = "SELECT DISTINCT FLD_COURSE_CODE FROM TBL_REGISTRATION_A190409"
        Dim mydatatable3 As New DataTable
        Dim myreader3 As New OleDb.OleDbDataAdapter(mysql3, myconnection)
        myreader3.Fill(mydatatable3)
        cmb_course.DataSource = mydatatable3
        cmb_course.DisplayMember = "FLD_COURSE_CODE"

        refresh_grid(cmb_session.Text, cmb_semester.Text, cmb_course.Text)
    End Sub

    Private Sub refresh_grid(session As String, semester As String, course As String)
        Dim mysql As String = "SELECT TBL_STUDENTS_A190409.FLD_NAME, TBL_REGISTRATION_A190409.FLD_MATRIC FROM TBL_STUDENTS_A190409 INNER JOIN TBL_REGISTRATION_A190409 ON TBL_STUDENTS_A190409.FLD_MATRIC = TBL_REGISTRATION_A190409.FLD_MATRIC WHERE TBL_REGISTRATION_A190409.FLD_SESSION = '" & session & "' AND TBL_REGISTRATION_A190409.FLD_SEMESTER = '" & semester & "' AND TBL_REGISTRATION_A190409.FLD_COURSE_CODE = '" & course & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_registration.DataSource = mydatatable
    End Sub



    Private Sub cmb_session_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_session.SelectedIndexChanged
        refresh_grid(cmb_session.Text, cmb_semester.Text, cmb_course.Text)
    End Sub

    Private Sub cmb_semester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_semester.SelectedIndexChanged
        refresh_grid(cmb_session.Text, cmb_semester.Text, cmb_course.Text)
    End Sub

    Private Sub cmb_course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_course.SelectedIndexChanged
        refresh_grid(cmb_session.Text, cmb_semester.Text, cmb_course.Text)
    End Sub
End Class
Public Class frm_mainmenu_a190409
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        MsgBox("Good Bye!")
        End
    End Sub

    Private Sub frm_mainmenu_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim current_date As String = Date.Now
        lbl_date.Text = current_date
        lbl_welcome.Text = "Welcome " & fullname & " (" & matric & ") to the UKM Faculty Records System"

    End Sub

    Private Sub btn_students_Click(sender As Object, e As EventArgs) Handles btn_student.Click
        frm_studentlist_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_course_Click(sender As Object, e As EventArgs) Handles btn_course.Click
        frm_courselist_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_department_Click(sender As Object, e As EventArgs) Handles btn_department.Click
        frm_departmentlist_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_lecturer_Click(sender As Object, e As EventArgs) Handles btn_lecturer.Click
        frm_lecturerlist_a190409.Show()
        Me.Hide()

    End Sub

    Private Sub btn_registration_Click(sender As Object, e As EventArgs) Handles btn_registration.Click
        frm_registrationlist_a190409.Show()
        Me.Hide()

    End Sub

    Private Sub btn_college_Click(sender As Object, e As EventArgs) Handles btn_college.Click
        frm_collegelist_a190409.Show()
        Me.Hide()

    End Sub

    Private Sub btn_room_Click(sender As Object, e As EventArgs) Handles btn_room.Click
        frm_roomlist_a190409.Show()
        Me.Hide()

    End Sub

    Private Sub btn_room_registration_Click(sender As Object, e As EventArgs) Handles btn_room_registration.Click
        frm_roomregistrationlist_a190409.Show()
        Me.Hide()

    End Sub

    Private Sub btn_studentdetails_Click(sender As Object, e As EventArgs) Handles btn_studentdetails.Click
        frm_studentdetails_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_coursebydept_Click(sender As Object, e As EventArgs) Handles btn_coursebydept.Click
        frm_coursesbydept_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_coursebynumberofcredithours_Click(sender As Object, e As EventArgs) Handles btn_coursebynumberofcredithours.Click
        frm_coursebynumberofcredithours_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_searchcourses_Click(sender As Object, e As EventArgs) Handles btn_searchcourses.Click
        frm_searchcourses_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_studentbydeptandname_Click(sender As Object, e As EventArgs) Handles btn_studentbydeptandname.Click
        frm_studentbydeptandname_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_studentbycoursesessionandsemester_Click(sender As Object, e As EventArgs) Handles btn_studentbycoursesessionandsemester.Click
        frm_studentbycoursesessionandsemester.Show()
        Me.Hide()
    End Sub
End Class
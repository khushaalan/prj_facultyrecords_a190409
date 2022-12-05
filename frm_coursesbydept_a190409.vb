﻿Public Class frm_coursesbydept_a190409
    Private Sub frm_coursesbydept_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_DEPT_ID FROM TBL_DEPARTMENT_A190409"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_dept.DataSource = mydatatable
        cmb_dept.DisplayMember = "FLD_DEPT_ID"

        refresh_grid(cmb_dept.Text)
    End Sub

    Private Sub refresh_grid(dept_id As String)
        'Dim mysql As String = "SELECT * FROM TBL_COURSES_A190409"
        Dim mysql As String = "SELECT * FROM TBL_COURSES_A190409 WHERE FLD_MANAGING_DEPT='" & dept_id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_courses.DataSource = mydatatable

        grd_courses.Columns(0).HeaderText = "Course Code"
        grd_courses.Columns(1).HeaderText = "Course Name"
        grd_courses.Columns(2).HeaderText = "Credits"
        grd_courses.Columns(3).HeaderText = "Managing Department"
    End Sub

    Private Sub cmb_dept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_dept.SelectedIndexChanged
        refresh_grid(cmb_dept.Text)
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        frm_mainmenu_a190409.Show()
        Me.Hide()
    End Sub

End Class
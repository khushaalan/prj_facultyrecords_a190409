Public Class frm_login_a190409
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim mysql As String = "SELECT COUNT(*) AS NUM_MATCHES FROM TBL_USERS_A190409 WHERE FLD_USERNAME='" & txt_username.Text & "' and FLD_PASSWORD='" & txt_password.Text & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        Dim num_matches As String = mydatatable.Rows(0).Item("NUM_MATCHES")
        If num_matches = 1 Then
            Dim check As Boolean
            'While the user doesn't keyin their Full Name, keep asking them to input their username
            fullname = InputBox("Please enter your Full Name : ")
            check = fullname.Equals("")
            While check.Equals(True)
                fullname = InputBox("Warning, please enter your Full Name : ")
                check = fullname.Equals("")
            End While

            matric = InputBox("Please enter your Matric Number : ")
            check = matric.Equals("")
            While check.Equals(True)
                matric = InputBox("Warning, please enter your Matric Number : ")
                check = matric.Equals("")
            End While

            frm_mainmenu_a190409.Show()
            Me.Hide()
        Else
            txt_username.Text = ""
            txt_password.Text = ""
            MsgBox("Incorrect Username or Password")
        End If
    End Sub

    Private Sub frm_login_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome!")
    End Sub
End Class
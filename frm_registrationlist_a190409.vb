Public Class frm_registrationlist_a190409
    Private Sub frm_registrationlist_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_FACULTYRECORDS_A190409.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_REGISTRATION_A190409"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_students.DataSource = mydatatable
    End Sub

    Private Sub grd_students_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_students.CellContentClick

    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        frm_mainmenu_a190409.Show()
        Me.Hide()

    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_studentbycoursesessionandsemester
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmb_session = New System.Windows.Forms.ComboBox()
        Me.cmb_semester = New System.Windows.Forms.ComboBox()
        Me.cmb_course = New System.Windows.Forms.ComboBox()
        Me.grd_registration = New System.Windows.Forms.DataGridView()
        Me.lbl_session = New System.Windows.Forms.Label()
        Me.lbl_semester = New System.Windows.Forms.Label()
        Me.lbl_course = New System.Windows.Forms.Label()
        CType(Me.grd_registration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_session
        '
        Me.cmb_session.FormattingEnabled = True
        Me.cmb_session.Location = New System.Drawing.Point(96, 93)
        Me.cmb_session.Name = "cmb_session"
        Me.cmb_session.Size = New System.Drawing.Size(121, 24)
        Me.cmb_session.TabIndex = 0
        '
        'cmb_semester
        '
        Me.cmb_semester.FormattingEnabled = True
        Me.cmb_semester.Location = New System.Drawing.Point(284, 93)
        Me.cmb_semester.Name = "cmb_semester"
        Me.cmb_semester.Size = New System.Drawing.Size(121, 24)
        Me.cmb_semester.TabIndex = 1
        '
        'cmb_course
        '
        Me.cmb_course.FormattingEnabled = True
        Me.cmb_course.Location = New System.Drawing.Point(470, 93)
        Me.cmb_course.Name = "cmb_course"
        Me.cmb_course.Size = New System.Drawing.Size(121, 24)
        Me.cmb_course.TabIndex = 2
        '
        'grd_registration
        '
        Me.grd_registration.BackgroundColor = System.Drawing.SystemColors.Window
        Me.grd_registration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_registration.Location = New System.Drawing.Point(36, 159)
        Me.grd_registration.Name = "grd_registration"
        Me.grd_registration.RowHeadersWidth = 51
        Me.grd_registration.RowTemplate.Height = 24
        Me.grd_registration.Size = New System.Drawing.Size(723, 270)
        Me.grd_registration.TabIndex = 3
        '
        'lbl_session
        '
        Me.lbl_session.AutoSize = True
        Me.lbl_session.BackColor = System.Drawing.Color.Transparent
        Me.lbl_session.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_session.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_session.Location = New System.Drawing.Point(125, 61)
        Me.lbl_session.Name = "lbl_session"
        Me.lbl_session.Size = New System.Drawing.Size(64, 19)
        Me.lbl_session.TabIndex = 4
        Me.lbl_session.Text = "Session"
        '
        'lbl_semester
        '
        Me.lbl_semester.AutoSize = True
        Me.lbl_semester.BackColor = System.Drawing.Color.Transparent
        Me.lbl_semester.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_semester.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_semester.Location = New System.Drawing.Point(310, 61)
        Me.lbl_semester.Name = "lbl_semester"
        Me.lbl_semester.Size = New System.Drawing.Size(77, 19)
        Me.lbl_semester.TabIndex = 5
        Me.lbl_semester.Text = "Semester"
        '
        'lbl_course
        '
        Me.lbl_course.AutoSize = True
        Me.lbl_course.BackColor = System.Drawing.Color.Transparent
        Me.lbl_course.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_course.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_course.Location = New System.Drawing.Point(495, 61)
        Me.lbl_course.Name = "lbl_course"
        Me.lbl_course.Size = New System.Drawing.Size(62, 19)
        Me.lbl_course.TabIndex = 6
        Me.lbl_course.Text = "Course"
        '
        'frm_studentbycoursesessionandsemester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_facultyrecords_a190409.My.Resources.Resources.geometry_cyberspace_digital_art_lines_wallpaper_preview
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_course)
        Me.Controls.Add(Me.lbl_semester)
        Me.Controls.Add(Me.lbl_session)
        Me.Controls.Add(Me.grd_registration)
        Me.Controls.Add(Me.cmb_course)
        Me.Controls.Add(Me.cmb_semester)
        Me.Controls.Add(Me.cmb_session)
        Me.Name = "frm_studentbycoursesessionandsemester"
        Me.Text = "frm_studentbycoursesessionandsemester"
        CType(Me.grd_registration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_session As ComboBox
    Friend WithEvents cmb_semester As ComboBox
    Friend WithEvents cmb_course As ComboBox
    Friend WithEvents grd_registration As DataGridView
    Friend WithEvents lbl_session As Label
    Friend WithEvents lbl_semester As Label
    Friend WithEvents lbl_course As Label
End Class

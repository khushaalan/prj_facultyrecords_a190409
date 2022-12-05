<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainmenu_a190409
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
        Me.lbl_menutitle = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_welcome = New System.Windows.Forms.Label()
        Me.btn_student = New System.Windows.Forms.Button()
        Me.btn_course = New System.Windows.Forms.Button()
        Me.btn_department = New System.Windows.Forms.Button()
        Me.btn_lecturer = New System.Windows.Forms.Button()
        Me.btn_registration = New System.Windows.Forms.Button()
        Me.btn_college = New System.Windows.Forms.Button()
        Me.btn_room = New System.Windows.Forms.Button()
        Me.btn_room_registration = New System.Windows.Forms.Button()
        Me.btn_studentdetails = New System.Windows.Forms.Button()
        Me.btn_coursebydept = New System.Windows.Forms.Button()
        Me.btn_coursebynumberofcredithours = New System.Windows.Forms.Button()
        Me.btn_searchcourses = New System.Windows.Forms.Button()
        Me.btn_studentbycoursesessionandsemester = New System.Windows.Forms.Button()
        Me.btn_studentbydeptandname = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_menutitle
        '
        Me.lbl_menutitle.AutoSize = True
        Me.lbl_menutitle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_menutitle.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menutitle.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_menutitle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lbl_menutitle.Location = New System.Drawing.Point(8, 9)
        Me.lbl_menutitle.Name = "lbl_menutitle"
        Me.lbl_menutitle.Size = New System.Drawing.Size(265, 45)
        Me.lbl_menutitle.TabIndex = 0
        Me.lbl_menutitle.Text = "MAIN MENU"
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_exit.Location = New System.Drawing.Point(61, 393)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(94, 26)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.Text = "EXIT PROGRAM"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_date.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lbl_date.Location = New System.Drawing.Point(521, 400)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(49, 23)
        Me.lbl_date.TabIndex = 2
        Me.lbl_date.Text = "Date"
        '
        'lbl_welcome
        '
        Me.lbl_welcome.AllowDrop = True
        Me.lbl_welcome.AutoSize = True
        Me.lbl_welcome.BackColor = System.Drawing.Color.Transparent
        Me.lbl_welcome.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_welcome.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_welcome.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lbl_welcome.Location = New System.Drawing.Point(12, 63)
        Me.lbl_welcome.Name = "lbl_welcome"
        Me.lbl_welcome.Size = New System.Drawing.Size(591, 22)
        Me.lbl_welcome.TabIndex = 3
        Me.lbl_welcome.Text = "Welcome ""fullname"" (matricnumber) to the UKM Faculty Records System"
        '
        'btn_student
        '
        Me.btn_student.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_student.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_student.Location = New System.Drawing.Point(105, 122)
        Me.btn_student.Name = "btn_student"
        Me.btn_student.Size = New System.Drawing.Size(125, 37)
        Me.btn_student.TabIndex = 4
        Me.btn_student.Text = "Student List"
        Me.btn_student.UseVisualStyleBackColor = False
        '
        'btn_course
        '
        Me.btn_course.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_course.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_course.Location = New System.Drawing.Point(105, 165)
        Me.btn_course.Name = "btn_course"
        Me.btn_course.Size = New System.Drawing.Size(125, 37)
        Me.btn_course.TabIndex = 5
        Me.btn_course.Text = "Course List"
        Me.btn_course.UseVisualStyleBackColor = False
        '
        'btn_department
        '
        Me.btn_department.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_department.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_department.Location = New System.Drawing.Point(105, 208)
        Me.btn_department.Name = "btn_department"
        Me.btn_department.Size = New System.Drawing.Size(125, 37)
        Me.btn_department.TabIndex = 6
        Me.btn_department.Text = "Department List"
        Me.btn_department.UseVisualStyleBackColor = False
        '
        'btn_lecturer
        '
        Me.btn_lecturer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_lecturer.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_lecturer.Location = New System.Drawing.Point(105, 251)
        Me.btn_lecturer.Name = "btn_lecturer"
        Me.btn_lecturer.Size = New System.Drawing.Size(125, 37)
        Me.btn_lecturer.TabIndex = 7
        Me.btn_lecturer.Text = "Lecturer List"
        Me.btn_lecturer.UseVisualStyleBackColor = False
        '
        'btn_registration
        '
        Me.btn_registration.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_registration.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_registration.Location = New System.Drawing.Point(105, 294)
        Me.btn_registration.Name = "btn_registration"
        Me.btn_registration.Size = New System.Drawing.Size(125, 53)
        Me.btn_registration.TabIndex = 8
        Me.btn_registration.Text = "Registration List"
        Me.btn_registration.UseVisualStyleBackColor = False
        '
        'btn_college
        '
        Me.btn_college.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_college.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_college.Location = New System.Drawing.Point(275, 122)
        Me.btn_college.Name = "btn_college"
        Me.btn_college.Size = New System.Drawing.Size(125, 37)
        Me.btn_college.TabIndex = 9
        Me.btn_college.Text = "College List"
        Me.btn_college.UseVisualStyleBackColor = False
        '
        'btn_room
        '
        Me.btn_room.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_room.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_room.Location = New System.Drawing.Point(275, 165)
        Me.btn_room.Name = "btn_room"
        Me.btn_room.Size = New System.Drawing.Size(125, 37)
        Me.btn_room.TabIndex = 10
        Me.btn_room.Text = "Room List"
        Me.btn_room.UseVisualStyleBackColor = False
        '
        'btn_room_registration
        '
        Me.btn_room_registration.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_room_registration.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_room_registration.Location = New System.Drawing.Point(275, 208)
        Me.btn_room_registration.Name = "btn_room_registration"
        Me.btn_room_registration.Size = New System.Drawing.Size(125, 67)
        Me.btn_room_registration.TabIndex = 11
        Me.btn_room_registration.Text = "Room Registration List"
        Me.btn_room_registration.UseVisualStyleBackColor = False
        '
        'btn_studentdetails
        '
        Me.btn_studentdetails.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_studentdetails.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_studentdetails.Location = New System.Drawing.Point(275, 281)
        Me.btn_studentdetails.Name = "btn_studentdetails"
        Me.btn_studentdetails.Size = New System.Drawing.Size(125, 66)
        Me.btn_studentdetails.TabIndex = 12
        Me.btn_studentdetails.Text = "Student Detail List"
        Me.btn_studentdetails.UseVisualStyleBackColor = False
        '
        'btn_coursebydept
        '
        Me.btn_coursebydept.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_coursebydept.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_coursebydept.Location = New System.Drawing.Point(448, 122)
        Me.btn_coursebydept.Name = "btn_coursebydept"
        Me.btn_coursebydept.Size = New System.Drawing.Size(125, 46)
        Me.btn_coursebydept.TabIndex = 13
        Me.btn_coursebydept.Text = "Course by Department List"
        Me.btn_coursebydept.UseVisualStyleBackColor = False
        '
        'btn_coursebynumberofcredithours
        '
        Me.btn_coursebynumberofcredithours.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_coursebynumberofcredithours.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_coursebynumberofcredithours.Location = New System.Drawing.Point(448, 174)
        Me.btn_coursebynumberofcredithours.Name = "btn_coursebynumberofcredithours"
        Me.btn_coursebynumberofcredithours.Size = New System.Drawing.Size(125, 61)
        Me.btn_coursebynumberofcredithours.TabIndex = 14
        Me.btn_coursebynumberofcredithours.Text = "Course by Number of Credit Hours List"
        Me.btn_coursebynumberofcredithours.UseVisualStyleBackColor = False
        '
        'btn_searchcourses
        '
        Me.btn_searchcourses.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_searchcourses.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_searchcourses.Location = New System.Drawing.Point(448, 241)
        Me.btn_searchcourses.Name = "btn_searchcourses"
        Me.btn_searchcourses.Size = New System.Drawing.Size(125, 37)
        Me.btn_searchcourses.TabIndex = 15
        Me.btn_searchcourses.Text = "Search Courses"
        Me.btn_searchcourses.UseVisualStyleBackColor = False
        '
        'btn_studentbycoursesessionandsemester
        '
        Me.btn_studentbycoursesessionandsemester.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_studentbycoursesessionandsemester.Location = New System.Drawing.Point(621, 122)
        Me.btn_studentbycoursesessionandsemester.Name = "btn_studentbycoursesessionandsemester"
        Me.btn_studentbycoursesessionandsemester.Size = New System.Drawing.Size(125, 66)
        Me.btn_studentbycoursesessionandsemester.TabIndex = 16
        Me.btn_studentbycoursesessionandsemester.Text = "Student by Course, Session and Semester List"
        Me.btn_studentbycoursesessionandsemester.UseVisualStyleBackColor = False
        '
        'btn_studentbydeptandname
        '
        Me.btn_studentbydeptandname.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_studentbydeptandname.Location = New System.Drawing.Point(448, 281)
        Me.btn_studentbydeptandname.Name = "btn_studentbydeptandname"
        Me.btn_studentbydeptandname.Size = New System.Drawing.Size(125, 66)
        Me.btn_studentbydeptandname.TabIndex = 17
        Me.btn_studentbydeptandname.Text = "Student by Department and Name List"
        Me.btn_studentbydeptandname.UseVisualStyleBackColor = False
        '
        'frm_mainmenu_a190409
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_facultyrecords_a190409.My.Resources.Resources.programming
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_studentbydeptandname)
        Me.Controls.Add(Me.btn_studentbycoursesessionandsemester)
        Me.Controls.Add(Me.btn_searchcourses)
        Me.Controls.Add(Me.btn_coursebynumberofcredithours)
        Me.Controls.Add(Me.btn_coursebydept)
        Me.Controls.Add(Me.btn_studentdetails)
        Me.Controls.Add(Me.btn_room_registration)
        Me.Controls.Add(Me.btn_room)
        Me.Controls.Add(Me.btn_college)
        Me.Controls.Add(Me.btn_registration)
        Me.Controls.Add(Me.btn_lecturer)
        Me.Controls.Add(Me.btn_department)
        Me.Controls.Add(Me.btn_course)
        Me.Controls.Add(Me.btn_student)
        Me.Controls.Add(Me.lbl_welcome)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lbl_menutitle)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frm_mainmenu_a190409"
        Me.Text = "frm_mainmenu_a190409"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_menutitle As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_welcome As Label
    Friend WithEvents btn_student As Button
    Friend WithEvents btn_course As Button
    Friend WithEvents btn_department As Button
    Friend WithEvents btn_lecturer As Button
    Friend WithEvents btn_registration As Button
    Friend WithEvents btn_college As Button
    Friend WithEvents btn_room As Button
    Friend WithEvents btn_room_registration As Button
    Friend WithEvents btn_studentdetails As Button
    Friend WithEvents btn_coursebydept As Button
    Friend WithEvents btn_coursebynumberofcredithours As Button
    Friend WithEvents btn_searchcourses As Button
    Friend WithEvents btn_studentbycoursesessionandsemester As Button
    Friend WithEvents btn_studentbydeptandname As Button
End Class

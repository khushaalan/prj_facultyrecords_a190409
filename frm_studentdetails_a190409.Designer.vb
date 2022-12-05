<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_studentdetails_a190409
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.lst_matric = New System.Windows.Forms.ListBox()
        Me.txt_matric = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_dept = New System.Windows.Forms.TextBox()
        Me.pic_student = New System.Windows.Forms.PictureBox()
        CType(Me.pic_student, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(278, 45)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Student Details"
        '
        'btn_return
        '
        Me.btn_return.Location = New System.Drawing.Point(655, 22)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(120, 23)
        Me.btn_return.TabIndex = 3
        Me.btn_return.Text = " < Main Menu"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'lst_matric
        '
        Me.lst_matric.FormattingEnabled = True
        Me.lst_matric.ItemHeight = 16
        Me.lst_matric.Location = New System.Drawing.Point(20, 141)
        Me.lst_matric.Name = "lst_matric"
        Me.lst_matric.Size = New System.Drawing.Size(206, 196)
        Me.lst_matric.TabIndex = 4
        '
        'txt_matric
        '
        Me.txt_matric.Location = New System.Drawing.Point(323, 141)
        Me.txt_matric.Name = "txt_matric"
        Me.txt_matric.Size = New System.Drawing.Size(137, 22)
        Me.txt_matric.TabIndex = 5
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(323, 212)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(137, 22)
        Me.txt_name.TabIndex = 6
        '
        'txt_dept
        '
        Me.txt_dept.Location = New System.Drawing.Point(323, 283)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.Size = New System.Drawing.Size(137, 22)
        Me.txt_dept.TabIndex = 7
        '
        'pic_student
        '
        Me.pic_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_student.Location = New System.Drawing.Point(545, 141)
        Me.pic_student.Name = "pic_student"
        Me.pic_student.Size = New System.Drawing.Size(167, 193)
        Me.pic_student.TabIndex = 8
        Me.pic_student.TabStop = False
        '
        'frm_studentdetails_a190409
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_facultyrecords_a190409.My.Resources.Resources.geometry_cyberspace_digital_art_lines_wallpaper_preview
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pic_student)
        Me.Controls.Add(Me.txt_dept)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_matric)
        Me.Controls.Add(Me.lst_matric)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_studentdetails_a190409"
        Me.Text = "frm_studentdetails_a190409"
        CType(Me.pic_student, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_return As Button
    Friend WithEvents lst_matric As ListBox
    Friend WithEvents txt_matric As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_dept As TextBox
    Friend WithEvents pic_student As PictureBox
End Class

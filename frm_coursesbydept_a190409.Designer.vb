<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_coursesbydept_a190409
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.grd_courses = New System.Windows.Forms.DataGridView()
        Me.cmb_dept = New System.Windows.Forms.ComboBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        CType(Me.grd_courses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_title.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(424, 45)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Courses by Department"
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
        'grd_courses
        '
        Me.grd_courses.AllowUserToAddRows = False
        Me.grd_courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_courses.BackgroundColor = System.Drawing.SystemColors.Window
        Me.grd_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_courses.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.grd_courses.Location = New System.Drawing.Point(91, 196)
        Me.grd_courses.Name = "grd_courses"
        Me.grd_courses.ReadOnly = True
        Me.grd_courses.RowHeadersWidth = 51
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_courses.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_courses.RowTemplate.Height = 24
        Me.grd_courses.RowTemplate.ReadOnly = True
        Me.grd_courses.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_courses.Size = New System.Drawing.Size(604, 130)
        Me.grd_courses.TabIndex = 4
        '
        'cmb_dept
        '
        Me.cmb_dept.FormattingEnabled = True
        Me.cmb_dept.Location = New System.Drawing.Point(91, 148)
        Me.cmb_dept.Name = "cmb_dept"
        Me.cmb_dept.Size = New System.Drawing.Size(251, 24)
        Me.cmb_dept.TabIndex = 5
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_name.Location = New System.Drawing.Point(87, 111)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(218, 22)
        Me.lbl_name.TabIndex = 6
        Me.lbl_name.Text = "Choose the Department : "
        '
        'frm_coursesbydept_a190409
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_facultyrecords_a190409.My.Resources.Resources.geometry_cyberspace_digital_art_lines_wallpaper_preview
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.cmb_dept)
        Me.Controls.Add(Me.grd_courses)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_coursesbydept_a190409"
        Me.Text = "frm_coursesbydept_a190409"
        CType(Me.grd_courses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_return As Button
    Friend WithEvents grd_courses As DataGridView
    Friend WithEvents cmb_dept As ComboBox
    Friend WithEvents lbl_name As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_searchcourses_a190409
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.grd_courses = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grd_courses, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_title.Size = New System.Drawing.Size(357, 45)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Search for a Course"
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
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(20, 102)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(314, 22)
        Me.txt_search.TabIndex = 4
        '
        'grd_courses
        '
        Me.grd_courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_courses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_courses.BackgroundColor = System.Drawing.SystemColors.Window
        Me.grd_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_courses.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.grd_courses.Location = New System.Drawing.Point(12, 155)
        Me.grd_courses.Name = "grd_courses"
        Me.grd_courses.RowHeadersWidth = 51
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_courses.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_courses.RowTemplate.Height = 24
        Me.grd_courses.RowTemplate.ReadOnly = True
        Me.grd_courses.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_courses.Size = New System.Drawing.Size(763, 253)
        Me.grd_courses.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(16, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Type in a Course Name : "
        '
        'frm_searchcourses_a190409
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_facultyrecords_a190409.My.Resources.Resources.geometry_cyberspace_digital_art_lines_wallpaper_preview
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_courses)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_searchcourses_a190409"
        Me.Text = "frm_searchcourses_a190409"
        CType(Me.grd_courses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_return As Button
    Friend WithEvents txt_search As TextBox
    Friend WithEvents grd_courses As DataGridView
    Friend WithEvents Label1 As Label
End Class

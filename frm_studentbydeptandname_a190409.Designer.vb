<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_studentbydeptandname_a190409
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
        Me.cmb_dept = New System.Windows.Forms.ComboBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.grd_student = New System.Windows.Forms.DataGridView()
        Me.lbl_dept = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.btn_return = New System.Windows.Forms.Button()
        CType(Me.grd_student, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_dept
        '
        Me.cmb_dept.FormattingEnabled = True
        Me.cmb_dept.Location = New System.Drawing.Point(247, 111)
        Me.cmb_dept.Name = "cmb_dept"
        Me.cmb_dept.Size = New System.Drawing.Size(121, 24)
        Me.cmb_dept.TabIndex = 0
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(552, 113)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(213, 22)
        Me.txt_name.TabIndex = 1
        '
        'grd_student
        '
        Me.grd_student.BackgroundColor = System.Drawing.SystemColors.Window
        Me.grd_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_student.Location = New System.Drawing.Point(48, 251)
        Me.grd_student.Name = "grd_student"
        Me.grd_student.RowHeadersWidth = 51
        Me.grd_student.RowTemplate.Height = 24
        Me.grd_student.Size = New System.Drawing.Size(717, 117)
        Me.grd_student.TabIndex = 2
        '
        'lbl_dept
        '
        Me.lbl_dept.AutoSize = True
        Me.lbl_dept.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dept.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dept.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_dept.Location = New System.Drawing.Point(29, 111)
        Me.lbl_dept.Name = "lbl_dept"
        Me.lbl_dept.Size = New System.Drawing.Size(194, 19)
        Me.lbl_dept.TabIndex = 3
        Me.lbl_dept.Text = "Choose your department :"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_name.Location = New System.Drawing.Point(397, 116)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(131, 19)
        Me.lbl_name.TabIndex = 4
        Me.lbl_name.Text = "Type your name :"
        '
        'btn_return
        '
        Me.btn_return.Location = New System.Drawing.Point(645, 30)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(120, 23)
        Me.btn_return.TabIndex = 5
        Me.btn_return.Text = " < Main Menu"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'frm_studentbydeptandname_a190409
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_facultyrecords_a190409.My.Resources.Resources.geometry_cyberspace_digital_art_lines_wallpaper_preview
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_dept)
        Me.Controls.Add(Me.grd_student)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.cmb_dept)
        Me.Name = "frm_studentbydeptandname_a190409"
        Me.Text = "frm_studentbydeptandname_a190409"
        CType(Me.grd_student, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_dept As ComboBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents grd_student As DataGridView
    Friend WithEvents lbl_dept As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents btn_return As Button
End Class

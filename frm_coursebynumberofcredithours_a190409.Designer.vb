<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_coursebynumberofcredithours_a190409
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
        Me.numeric_box = New System.Windows.Forms.NumericUpDown()
        Me.grd_courses = New System.Windows.Forms.DataGridView()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        CType(Me.numeric_box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_courses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numeric_box
        '
        Me.numeric_box.Location = New System.Drawing.Point(74, 141)
        Me.numeric_box.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numeric_box.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numeric_box.Name = "numeric_box"
        Me.numeric_box.Size = New System.Drawing.Size(120, 22)
        Me.numeric_box.TabIndex = 0
        Me.numeric_box.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'grd_courses
        '
        Me.grd_courses.BackgroundColor = System.Drawing.SystemColors.Window
        Me.grd_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_courses.Location = New System.Drawing.Point(74, 184)
        Me.grd_courses.Name = "grd_courses"
        Me.grd_courses.RowHeadersWidth = 51
        Me.grd_courses.RowTemplate.Height = 24
        Me.grd_courses.Size = New System.Drawing.Size(668, 205)
        Me.grd_courses.TabIndex = 1
        '
        'btn_return
        '
        Me.btn_return.Location = New System.Drawing.Point(667, 35)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(120, 23)
        Me.btn_return.TabIndex = 4
        Me.btn_return.Text = " < Main Menu"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_title.Location = New System.Drawing.Point(-3, 35)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(621, 45)
        Me.lbl_title.TabIndex = 5
        Me.lbl_title.Text = "Course by Number of Credit Hours"
        '
        'frm_coursebynumberofcredithours_a190409
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_facultyrecords_a190409.My.Resources.Resources.geometry_cyberspace_digital_art_lines_wallpaper_preview
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.grd_courses)
        Me.Controls.Add(Me.numeric_box)
        Me.Name = "frm_coursebynumberofcredithours_a190409"
        Me.Text = "frm_coursebynumberofcredithours_a190409"
        CType(Me.numeric_box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_courses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numeric_box As NumericUpDown
    Friend WithEvents grd_courses As DataGridView
    Friend WithEvents btn_return As Button
    Friend WithEvents lbl_title As Label
End Class

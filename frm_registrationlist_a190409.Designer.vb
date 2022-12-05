<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrationlist_a190409
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
        Me.grd_students = New System.Windows.Forms.DataGridView()
        Me.btn_return = New System.Windows.Forms.Button()
        CType(Me.grd_students, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_title.Size = New System.Drawing.Size(306, 45)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Registration List"
        '
        'grd_students
        '
        Me.grd_students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_students.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_students.BackgroundColor = System.Drawing.SystemColors.Window
        Me.grd_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_students.Location = New System.Drawing.Point(5, 104)
        Me.grd_students.Name = "grd_students"
        Me.grd_students.RowHeadersWidth = 51
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        Me.grd_students.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_students.RowTemplate.Height = 24
        Me.grd_students.Size = New System.Drawing.Size(786, 253)
        Me.grd_students.TabIndex = 2
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
        'frm_registrationlist_a190409
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_facultyrecords_a190409.My.Resources.Resources.geometry_cyberspace_digital_art_lines_wallpaper_preview
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.grd_students)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_registrationlist_a190409"
        Me.Text = "frm_registrationlist_a190409"
        CType(Me.grd_students, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_students As DataGridView
    Friend WithEvents btn_return As Button
End Class

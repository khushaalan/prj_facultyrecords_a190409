<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_splashsreen_a190409
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
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_matric = New System.Windows.Forms.TextBox()
        Me.lbl_matric = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(12, 110)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(253, 22)
        Me.lbl_name.TabIndex = 0
        Me.lbl_name.Text = "Please enter your name below:"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_title.Location = New System.Drawing.Point(211, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(405, 45)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "UKM Faculty Records"
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_start.Location = New System.Drawing.Point(16, 262)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(71, 28)
        Me.btn_start.TabIndex = 2
        Me.btn_start.Text = "START"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_name.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(16, 140)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(234, 27)
        Me.txt_name.TabIndex = 3
        Me.txt_name.Text = "Khushaalan Arjunan"
        '
        'txt_matric
        '
        Me.txt_matric.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_matric.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matric.Location = New System.Drawing.Point(16, 210)
        Me.txt_matric.Name = "txt_matric"
        Me.txt_matric.Size = New System.Drawing.Size(234, 27)
        Me.txt_matric.TabIndex = 5
        Me.txt_matric.Text = "A190409"
        '
        'lbl_matric
        '
        Me.lbl_matric.AutoSize = True
        Me.lbl_matric.BackColor = System.Drawing.Color.Transparent
        Me.lbl_matric.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_matric.Location = New System.Drawing.Point(12, 180)
        Me.lbl_matric.Name = "lbl_matric"
        Me.lbl_matric.Size = New System.Drawing.Size(285, 22)
        Me.lbl_matric.TabIndex = 4
        Me.lbl_matric.Text = "Please enter your matric no below:"
        '
        'frm_splashsreen_a190409
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.prj_facultyrecords_a190409.My.Resources.Resources.Vq7s3cG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_matric)
        Me.Controls.Add(Me.lbl_matric)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_name)
        Me.DoubleBuffered = True
        Me.Name = "frm_splashsreen_a190409"
        Me.Text = "splashscreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_start As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_matric As TextBox
    Friend WithEvents lbl_matric As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login_a190409
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
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.lbl_hint_username = New System.Windows.Forms.Label()
        Me.lbl_hint_password = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_username.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.Color.Black
        Me.lbl_username.Location = New System.Drawing.Point(4, 37)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(107, 23)
        Me.lbl_username.TabIndex = 1
        Me.lbl_username.Text = "Username :"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_password.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.ForeColor = System.Drawing.Color.Black
        Me.lbl_password.Location = New System.Drawing.Point(4, 111)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(102, 23)
        Me.lbl_password.TabIndex = 2
        Me.lbl_password.Text = "Password :"
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_username.Location = New System.Drawing.Point(8, 63)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(174, 22)
        Me.txt_username.TabIndex = 3
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt_password.Location = New System.Drawing.Point(8, 137)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(174, 22)
        Me.txt_password.TabIndex = 4
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_login.Location = New System.Drawing.Point(49, 187)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(71, 28)
        Me.btn_login.TabIndex = 5
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'lbl_hint_username
        '
        Me.lbl_hint_username.AutoSize = True
        Me.lbl_hint_username.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hint_username.Location = New System.Drawing.Point(188, 68)
        Me.lbl_hint_username.Name = "lbl_hint_username"
        Me.lbl_hint_username.Size = New System.Drawing.Size(83, 17)
        Me.lbl_hint_username.TabIndex = 6
        Me.lbl_hint_username.Text = "hint : admin"
        '
        'lbl_hint_password
        '
        Me.lbl_hint_password.AutoSize = True
        Me.lbl_hint_password.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hint_password.Location = New System.Drawing.Point(188, 142)
        Me.lbl_hint_password.Name = "lbl_hint_password"
        Me.lbl_hint_password.Size = New System.Drawing.Size(92, 17)
        Me.lbl_hint_password.TabIndex = 7
        Me.lbl_hint_password.Text = "hint : abc123"
        '
        'frm_login_a190409
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_facultyrecords_a190409.My.Resources.Resources.Vq7s3cG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_hint_password)
        Me.Controls.Add(Me.lbl_hint_username)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_username)
        Me.Name = "frm_login_a190409"
        Me.Text = "frm_login_a190409"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents lbl_hint_username As Label
    Friend WithEvents lbl_hint_password As Label
End Class

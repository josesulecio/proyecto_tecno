<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.lbl_contraseña = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.lbl_login)
        Me.Panel1.Controls.Add(Me.btn_ingresar)
        Me.Panel1.Controls.Add(Me.txt_contraseña)
        Me.Panel1.Controls.Add(Me.lbl_usuario)
        Me.Panel1.Controls.Add(Me.txt_usuario)
        Me.Panel1.Controls.Add(Me.lbl_contraseña)
        Me.Panel1.Location = New System.Drawing.Point(-11, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(307, 266)
        Me.Panel1.TabIndex = 8
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login.Location = New System.Drawing.Point(109, 8)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(80, 31)
        Me.lbl_login.TabIndex = 0
        Me.lbl_login.Text = "Login"
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Location = New System.Drawing.Point(115, 182)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(75, 23)
        Me.btn_ingresar.TabIndex = 4
        Me.btn_ingresar.Text = "ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(77, 131)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(149, 20)
        Me.txt_contraseña.TabIndex = 6
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(125, 64)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_usuario.TabIndex = 1
        Me.lbl_usuario.Text = "Usuario"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(77, 80)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(149, 20)
        Me.txt_usuario.TabIndex = 5
        '
        'lbl_contraseña
        '
        Me.lbl_contraseña.AutoSize = True
        Me.lbl_contraseña.Location = New System.Drawing.Point(125, 115)
        Me.lbl_contraseña.Name = "lbl_contraseña"
        Me.lbl_contraseña.Size = New System.Drawing.Size(61, 13)
        Me.lbl_contraseña.TabIndex = 2
        Me.lbl_contraseña.Text = "Contraseña"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_login As Label
    Friend WithEvents btn_ingresar As Button
    Friend WithEvents txt_contraseña As TextBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents lbl_contraseña As Label
End Class

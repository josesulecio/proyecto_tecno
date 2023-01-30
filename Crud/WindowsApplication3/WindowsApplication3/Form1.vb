Imports System.Data.SqlClient
Public Class Form1
    Public conexion As SqlConnection = New SqlConnection(My.Settings.conexion)
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public cmd As SqlCommand


    Function verificacion(ByVal sql)
        conexion.Open()
        cmd = New SqlCommand(sql, conexion)
        Dim i As Integer = cmd.ExecuteNonQuery
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        Dim f2 = Form2

        Dim verificar As String = "update USUARIOS set rol=rol where nombre = '" + txt_usuario.Text + "' And  Contraseña = '" + txt_contraseña.Text + "' and rol = 'Administrador'"
        Dim verificar1 As String = "update USUARIOS set rol=rol where nombre = '" + txt_usuario.Text + "' And  Contraseña = '" + txt_contraseña.Text + "' and rol = 'Usuario'"
        Dim verificar2 As String = "update USUARIOS set rol=rol where nombre = '" + txt_usuario.Text + "' And  Contraseña = '" + txt_contraseña.Text + "' and rol = 'Secretaria'"
        If verificacion(verificar) Then
            Form2.Show()
        End If
        If verificacion(verificar1) Then
            Form2.Show()
            f2.Button1.Visible = False
            f2.Button2.Visible = False
            f2.Button3.Visible = False
        End If
        If verificacion(verificar2) Then
            Form2.Show()
            f2.Button2.Visible = False
            f2.Button3.Visible = False
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class


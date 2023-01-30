Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class Form2
    Dim con As New SqlConnection(My.Settings.conexion)
    Dim mensaje, sentencia As String

    Sub ingresarsql(ByVal SQL As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(SQL, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim DA As New SqlDataAdapter("select *from Datos where Nombre='" + TextBox2.Text + "'", con)
        Dim ds As New DataSet
        DA.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sentencia = "insert Datos values(" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')"

        mensaje = "Datos ingresados"
        ingresarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select *from Datos ", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim da As New SqlDataAdapter("select *from Datos ", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sentencia = "delete Datos where id= " + TextBox1.Text + ""
        mensaje = "Datos eliminados"
        ingresarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select *from Datos ", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sentencia = "update Datos set nombre = '" + TextBox2.Text + "',apellido = '" + TextBox3.Text + "',edad = '" + TextBox4.Text + "',correo= '" + TextBox5.Text + "' where id = " + TextBox1.Text + ""
        mensaje = "Datos actualizados"
        ingresarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select *from TIPO_REMISION ", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
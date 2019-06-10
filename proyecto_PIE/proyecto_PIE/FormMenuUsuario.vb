
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class FormMenuUsuario
    Dim ipServidor As String = datos_conn.getservidor()
    Dim puerto As String = datos_conn.getpuerto()
    Dim claveBD As String = datos_conn.getpass()
    Dim basededatos As String = datos_conn.getbd()
    Dim usuarioBD As String = datos_conn.getuser()

    Dim strcon As String
    Public dreader As SqlDataReader
    Public nomUsuario As String
    Dim conector As New SqlConnection("server=" + ipServidor + "  ;user='" + usuarioBD + "';password= '" + claveBD + "' ; database=" + basededatos + "")


    Dim dt As DataTable

    Dim nombre_del_usuario_mod As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        conector.Close()

        If (TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "") Then
            MsgBox("No deje campos en blanco", MsgBoxStyle.Critical, "Atencion")
            TextBox1.Select()
            conector.Close()
        Else
            conector.Close()
            conector.Open()
            Dim qry As String = "select * from usuario where nombre_usuario = '" & TextBox1.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                conector.Close()

                MsgBox("Nombre de Usuario ya Registrado", MsgBoxStyle.Critical, "ALERTA")


                conector.Close()

            Else
                Try
                    conector.Close()

                    Dim cadena As String
                    cadena = String.Format("INSERT INTO usuario (nombre_usuario, pass, tipo_usuario , nombre_completo_usuario) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & ComboBox1.SelectedItem & "' , '" & TextBox5.Text & "')")

                    Dim insertar As New SqlCommand(cadena, conector)
                    conector.Open()
                    insertar.ExecuteNonQuery()

                    conector.Close()
                    MsgBox("Usuario Ingresado Correctamente", MsgBoxStyle.Information, "Operacion Exitosa")

                    conector.Close()



                Catch ex As Exception
                    conector.Close()
                    conector.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        conector.Close()

        If (TextBox3.Text = "" Or TextBox3.Text = "" Or ComboBox2.Text = "") Then
            MsgBox("No deje campos en blanco", MsgBoxStyle.Critical, "Atencion")
            TextBox1.Select()
        Else
            Try
                conector.Close()
                Dim cadena As String
                cadena = String.Format("UPDATE usuario SET nombre_usuario = '" & TextBox4.Text & "' , pass ='" & TextBox3.Text & "', tipo_usuario = '" & ComboBox2.SelectedItem & "' , nombre_completo_usuario = '" & TextBox6.Text & "'  WHERE nombre_usuario = '" & nombre_del_usuario_mod & "'")
                Dim insertar As New SqlCommand(cadena, conector)
                conector.Open()
                insertar.ExecuteNonQuery()
                conector.Close()
                MsgBox("Usuario Actualizado Correctamente", MsgBoxStyle.Information, "Operacion Exitosa")
                TextBox3.Enabled = False
                TextBox6.Enabled = False
                ComboBox2.Enabled = False
                Button7.Visible = False



            Catch ex As Exception
                conector.Close()
            End Try
            conector.Close()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            conector.Open()
            Dim qry As String = "select usuario.nombre_usuario, usuario.pass, usuario.tipo_usuario , usuario.nombre_completo_usuario from usuario where usuario.nombre_usuario ='" & TextBox4.Text & "' "
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then
                nombre_del_usuario_mod = dr("nombre_usuario")
                TextBox3.Text = dr("pass")
                ComboBox2.Text = dr("tipo_usuario")
                TextBox6.Text = dr("nombre_completo_usuario")


                conector.Close()
                Button7.Visible = True

                TextBox3.Enabled = True
                TextBox4.Enabled = True
                TextBox6.Enabled = True
                ComboBox2.Enabled = True
            Else

                MsgBox("ERROR NOMBRE USUARIO NO VALIDO", MsgBoxStyle.Critical, "Atencion")
                conector.Close()
            End If
            conector.Close()
        Catch ex As Exception
            conector.Close()
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox5.Text = ""
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
        TextBox3.Enabled = False
        TextBox6.Enabled = False
        ComboBox2.Enabled = False
        Button7.Visible = False

        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        ComboBox2.SelectedIndex = 0

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Enabled = True
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        conector.Close()
        conector.Close()
        conector.Close()
        If MsgBox("¿ Seguro que desea salir ?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            Form1.Enabled = True
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
        conector.Close()
        conector.Close()
    End Sub
End Class
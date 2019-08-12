
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
    Sub MostrarTodosLosEvaluadoresActivos()
        conector.Close()
        conector.Open()
        Dim qry As String = "select profesional_evaluador.nombre_evaluador from profesional_evaluador where profesional_evaluador.estado = 'activo'"
        Dim sqlcmd As New SqlCommand(qry, conector)
        'Dim drc As String
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet()
        Dim drc = sqlcmd.ExecuteReader
        conector.Close()
        da.Fill(ds)
        ComboBox3.DataSource = ds.Tables(0)
        ComboBox3.DisplayMember = "nombre_evaluador"
        ComboBox3.SelectedItem = 0
    End Sub
    Sub MostrarTodosLosApoyosActivos()
        conector.Close()
        conector.Open()
        Dim qry As String = "select profesional_apoyo.nombre_apoyo from profesional_apoyo where profesional_apoyo.estado = 'activo'"
        Dim sqlcmd As New SqlCommand(qry, conector)
        'Dim drc As String
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet()
        Dim drc = sqlcmd.ExecuteReader
        conector.Close()
        da.Fill(ds)
        ComboBox4.DataSource = ds.Tables(0)
        ComboBox4.DisplayMember = "nombre_apoyo"
        ComboBox4.SelectedItem = 0
    End Sub
    Sub MostrarTodosLosUsuariosActivos()
        conector.Close()
        conector.Open()
        Dim qry As String = "select usuario.Nombre_completo_usuario from usuario where usuario.estado = 'activo'"
        Dim sqlcmd As New SqlCommand(qry, conector)
        'Dim drc As String
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet()
        Dim drc = sqlcmd.ExecuteReader
        conector.Close()
        da.Fill(ds)
        ComboBox5.DataSource = ds.Tables(0)
        ComboBox5.DisplayMember = "Nombre_completo_usuario"
        ComboBox5.SelectedItem = 0
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Label13.Visible = False
        Label14.Visible = False
        Label12.Visible = False
        Label15.Visible = False
        MostrarTodosLosEvaluadoresActivos()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(4)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Label18.Visible = False
        Label19.Visible = False
        MostrarTodosLosApoyosActivos()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(5)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Label16.Visible = False
        Label17.Visible = False
        Label20.Visible = False
        Label21.Visible = False
        MostrarTodosLosUsuariosActivos()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(6)
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(3)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(3)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(3)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(3)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            conector.Open()
            Dim qry As String = "select profesional_evaluador.rut_evaluador , profesional_evaluador.profesion from profesional_evaluador where profesional_evaluador.nombre_evaluador = '" & ComboBox3.Text & "' "
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then
                Label13.Visible = True
                Label14.Visible = True
                Label12.Visible = True
                Label15.Visible = True

                Label13.Text = dr("rut_evaluador")
                Label14.Text = dr("profesion")

                conector.Close()
            Else
                MsgBox("ERROR NOMBRE PROFESIONAL NO VALIDO", MsgBoxStyle.Critical, "Atencion")
                conector.Close()
            End If
            conector.Close()
        Catch ex As Exception
            conector.Close()
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Try
            conector.Close()
            Dim cadena As String
            cadena = String.Format("update profesional_evaluador set estado = 'inactivo' where nombre_evaluador = '" & ComboBox3.Text & "'")
            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()
            conector.Close()
            MsgBox("Profesional ha sido eliminado", MsgBoxStyle.Information, "Operacion Exitosa")
            Label13.Visible = False
            Label14.Visible = False
            Label12.Visible = False
            Label15.Visible = False
            MostrarTodosLosEvaluadoresActivos()
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Atencion")
            conector.Close()
        End Try
        conector.Close()
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Try
            conector.Open()
            Dim qry As String = "select profesional_apoyo.rut_apoyo from profesional_apoyo where profesional_apoyo.nombre_apoyo = '" & ComboBox4.Text & "' "
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                Label18.Visible = True
                Label19.Visible = True

                Label18.Text = dr("rut_apoyo")
                conector.Close()
            Else
                MsgBox("ERROR NOMBRE PROFESIONAL NO VALIDO", MsgBoxStyle.Critical, "Atencion")
                conector.Close()
            End If
            conector.Close()
        Catch ex As Exception
            conector.Close()
        End Try
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Try
            conector.Close()
            Dim cadena As String
            cadena = String.Format("update profesional_apoyo set estado = 'inactivo' where nombre_apoyo = '" & ComboBox4.Text & "'")
            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()
            conector.Close()
            MsgBox("Profesional ha sido eliminado", MsgBoxStyle.Information, "Operacion Exitosa")
            Label18.Visible = False
            Label19.Visible = False

            MostrarTodosLosApoyosActivos()
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Atencion")
            conector.Close()
        End Try
        conector.Close()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            conector.Open()
            Dim qry As String = "select usuario.nombre_usuario , usuario.tipo_usuario from usuario where usuario.Nombre_completo_usuario = '" & ComboBox5.Text & "' "
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then
                Label16.Visible = True
                Label17.Visible = True
                Label20.Visible = True
                Label21.Visible = True

                Label20.Text = dr("nombre_usuario")
                Label16.Text = dr("tipo_usuario")

                conector.Close()
            Else
                MsgBox("ERROR NOMBRE Usuario NO VALIDO", MsgBoxStyle.Critical, "Atencion")
                conector.Close()
            End If
            conector.Close()
        Catch ex As Exception
            conector.Close()
        End Try
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Try
            conector.Close()
            Dim cadena As String
            cadena = String.Format("update usuario set estado = 'inactivo' where usuario.nombre_completo_usuario = '" & ComboBox5.Text & "'")
            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()
            conector.Close()
            MsgBox("Usuario ha sido eliminado", MsgBoxStyle.Information, "Operacion Exitosa")
            Label16.Visible = False
            Label17.Visible = False
            Label20.Visible = False
            Label21.Visible = False
            MostrarTodosLosUsuariosActivos()
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Atencion")
            conector.Close()
        End Try
        conector.Close()
    End Sub
End Class
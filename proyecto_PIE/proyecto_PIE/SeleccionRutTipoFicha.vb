Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class SeleccionRutTipoFicha

    Public NombreCompletoAlumno As String
    'Public id_de_tipoFicha As Integer
    Public Fechaemi As Date

    Dim id_de_tipo_ficha As Integer

    Dim ipServidor As String = datos_conn.getservidor()
    Dim puerto As String = datos_conn.getpuerto()
    Dim claveBD As String = datos_conn.getpass()
    Dim basededatos As String = datos_conn.getbd()
    Dim usuarioBD As String = datos_conn.getuser()
    Dim strcon As String
    Public dreader As SqlDataReader
    Dim conector As New SqlConnection("server=" + ipServidor + "  ;user='" + usuarioBD + "';password= '" + claveBD + "' ; database=" + basededatos + "")



    Dim cmd As OleDbDataAdapter
    Dim cnn As OleDbConnection

    Sub MostrarAlumno()

        conector.Close()
        conector.Open()
        Dim qry As String = "select alumno.rut_alumno from alumno where alumno.estado = 'activo'"
        Dim sqlcmd As New SqlCommand(qry, conector)
        'Dim drc As String
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet()

        Dim drc = sqlcmd.ExecuteReader
        conector.Close()
        da.Fill(ds)

        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.DisplayMember = "rut_alumno"
        ComboBox1.SelectedItem = 0



    End Sub

    Sub Mostrartipoficha()

        conector.Close()
        conector.Open()
        Dim qry As String = "select tipo_ficha.nombre_tipo from tipo_ficha"
        Dim sqlcmd As New SqlCommand(qry, conector)
        'Dim drc As String
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet()

        Dim drc = sqlcmd.ExecuteReader
        conector.Close()
        da.Fill(ds)

        ComboBox2.DataSource = ds.Tables(0)
        ComboBox2.DisplayMember = "nombre_tipo"
        ComboBox2.SelectedItem = 0



    End Sub

    Private Sub SeleccionRutTipoFicha_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MostrarAlumno()
        Mostrartipoficha()
    End Sub
    Sub obtener_datos_alumno()
        conector.Close()
        Dim nombre_alumno As String
        Dim apellido_paterno As String
        Dim apellido_materno As String
        Try

            conector.Close()
            conector.Open()
            Dim qry As String = "select alumno.nombres_alumno , alumno.apellido_paterno , alumno.apellido_materno from alumno where alumno.rut_alumno = '" & ComboBox1.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then


                nombre_alumno = dr("nombres_alumno")
                apellido_paterno = dr("apellido_paterno")
                apellido_materno = dr("apellido_materno")

                NombreCompletoAlumno = nombre_alumno + " " + apellido_paterno + " " + apellido_materno

                Menu_Principal.Label21.Text = "COMPLETE LOS CAMPOS PARA LA FICHA " + ComboBox2.Text + vbCr + "PARA EL ALUMNO " + NombreCompletoAlumno

                Menu_Principal.Show()
                Menu_Principal.Enabled = True
                Menu_Principal.TabControl1.SelectedIndex = 7
                Me.Hide()
                TipoEvaluacion.Hide()
                TipoEvaluacion.Close()
                conector.Close()

            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub

    Sub obtener_datos_alumnos()
        conector.Close()
        Dim nombre_alumno As String
        Dim apellido_paterno As String
        Dim apellido_materno As String
        Try

            conector.Close()
            conector.Open()
            Dim qry As String = "select alumno.nombres_alumno , alumno.apellido_paterno , alumno.apellido_materno from alumno where alumno.rut_alumno = '" & ComboBox1.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then


                nombre_alumno = dr("nombres_alumno")
                apellido_paterno = dr("apellido_paterno")
                apellido_materno = dr("apellido_materno")

                NombreCompletoAlumno = nombre_alumno + " " + apellido_paterno + " " + apellido_materno

                Menu_Principal.Label21.Text = "COMPLETE LOS CAMPOS PARA LA FICHA " + ComboBox2.Text + vbCr + "PARA EL ALUMNO " + NombreCompletoAlumno
                conector.Close()


            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub
    Sub obtener_datos_ficha()
        conector.Close()
       
        Try

            conector.Close()
            conector.Open()
            Dim qry As String = "select tipo_ficha.id_tipo from tipo_ficha where tipo_ficha.nombre_tipo = '" & ComboBox2.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then


                Menu_Principal.IdTipoFicha = dr("id_tipo")
                id_de_tipo_ficha = dr("id_tipo")



                conector.Close()

            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Menu_Principal.RutDelAlumno = ComboBox1.Text
        obtener_datos_ficha()
        obtener_datos_alumno()
        Menu_Principal.MostrarApoyo1()
        Menu_Principal.MostrarApoyo2()
        Menu_Principal.MostrarApoyo3()
        Menu_Principal.MostrarApoyo4()
        Menu_Principal.MostrarCursos()
        Menu_Principal.MostrarEvaluador1()
        Menu_Principal.MostrarEvaluador2()
        Menu_Principal.MostrarEvaluador3()
        Menu_Principal.MostrarEvaluador4()
        Menu_Principal.MostrarEvaluador5()

        Menu_Principal.Button35.Visible = False
        Menu_Principal.Button36.Visible = True


    End Sub

    Sub reevaluar_select()
        Dim valor_curso As String
        Dim valor_ev_1 As String
        Dim valor_ev_2 As String
        Dim valor_ev_3 As String
        Dim valor_ev_4 As String
        Dim valor_ev_5 As String

        Dim valor_apo_1 As String
        Dim valor_apo_2 As String
        Dim valor_apo_3 As String
        Dim valor_apo_4 As String




        Try

            conector.Close()
            conector.Open()
            Dim qry As String = "select top 1 ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" & ComboBox1.Text & "' and ficha_diagnostico.id_tipoficha = " & id_de_tipo_ficha & "  ORDER BY ficha_diagnostico.fecha_emision DESC 
  
"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                Menu_Principal.TextBox33.Text = dr("numero_estudiante")
                valor_curso = dr("nombre")

                Menu_Principal.ComboBox8.Text = valor_curso

                Menu_Principal.TextBox18.Text = dr("nuevo_ingreso")
                Menu_Principal.TextBox19.Text = dr("continuidad")
                Menu_Principal.TextBox20.Text = dr("diagnostico")
                Menu_Principal.TextBox21.Text = dr("sindrome_asociado_diagnostico")
                Menu_Principal.TextBox22.Text = dr("observaciones_salud")

                Fechaemi = dr("fecha_emision")
                Menu_Principal.MonthCalendar2.SetDate(Fechaemi)

                valor_ev_1 = dr("nombre_evaluador_1")
                Menu_Principal.ComboBox3.Text = valor_ev_1

                valor_ev_2 = dr("nombre_evaluador_2")
                Menu_Principal.ComboBox4.Text = valor_ev_2

                valor_ev_3 = dr("nombre_evaluador_3")
                Menu_Principal.ComboBox5.Text = valor_ev_3

                valor_ev_4 = dr("nombre_evaluador_4")
                Menu_Principal.ComboBox6.Text = valor_ev_4

                valor_ev_5 = dr("nombre_evaluador_5")
                Menu_Principal.ComboBox7.Text = valor_ev_5

                Menu_Principal.TextBox23.Text = dr("prueba_1")
                Menu_Principal.TextBox24.Text = dr("puntaje_1")

                Menu_Principal.TextBox26.Text = dr("prueba_2")
                Menu_Principal.TextBox25.Text = dr("puntaje_2")

                Menu_Principal.TextBox28.Text = dr("prueba_3")
                Menu_Principal.TextBox27.Text = dr("puntaje_3")

                Menu_Principal.TextBox30.Text = dr("prueba_4")
                Menu_Principal.TextBox29.Text = dr("puntaje_4")

                Menu_Principal.TextBox32.Text = dr("prueba_5")
                Menu_Principal.TextBox31.Text = dr("puntaje_5")


                valor_apo_1 = dr("nombre_apoyo_1")
                Menu_Principal.ComboBox10.Text = valor_apo_1

                valor_apo_2 = dr("nombre_apoyo_2")
                Menu_Principal.ComboBox11.Text = valor_apo_2

                valor_apo_3 = dr("nombre_apoyo_3")
                Menu_Principal.ComboBox12.Text = valor_apo_3

                valor_apo_4 = dr("nombre_apoyo_4")
                Menu_Principal.ComboBox13.Text = valor_apo_4

                Menu_Principal.Show()
                Menu_Principal.Enabled = True
                Menu_Principal.TabControl1.SelectedIndex = 7
                Menu_Principal.Label21.Text = "COMPLETE LOS CAMPOS PARA LA FICHA " + ComboBox2.Text + vbCr + "PARA LA REEVALUACION DEL ALUMNO " + NombreCompletoAlumno

                Me.Hide()
                TipoEvaluacion.Hide()
                TipoEvaluacion.Close()
                conector.Close()

            Else

                MsgBox("Para realizar una Reevaluacion Primero debe haber una Evaluacion del Alumno", MsgBoxStyle.Critical, "Atencion")
            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu_Principal.RutDelAlumno = ComboBox1.Text
        Menu_Principal.MostrarApoyo1()
        Menu_Principal.MostrarApoyo2()
        Menu_Principal.MostrarApoyo3()
        Menu_Principal.MostrarApoyo4()
        Menu_Principal.MostrarCursos()
        Menu_Principal.MostrarEvaluador1()
        Menu_Principal.MostrarEvaluador2()
        Menu_Principal.MostrarEvaluador3()
        Menu_Principal.MostrarEvaluador4()
        Menu_Principal.MostrarEvaluador5()

        obtener_datos_ficha()
        obtener_datos_alumnos()
        reevaluar_select()

        Menu_Principal.Button35.Visible = False
        Menu_Principal.Button36.Visible = True
        conector.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TipoEvaluacion.Show()
        Me.Close()
        Me.Hide()

    End Sub
End Class
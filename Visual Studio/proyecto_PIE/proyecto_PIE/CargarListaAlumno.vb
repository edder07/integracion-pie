﻿
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class CargarListaAlumno

    Dim ipServidor As String = datos_conn.getservidor()
    Dim puerto As String = datos_conn.getpuerto()
    Dim claveBD As String = datos_conn.getpass()
    Dim basededatos As String = datos_conn.getbd()
    Dim usuarioBD As String = datos_conn.getuser()

    Dim strcon As String
    Public dreader As SqlDataReader
    Public nomUsuario As String
    Dim conector As New SqlConnection("server=" + ipServidor + "  ;user='" + usuarioBD + "';password= '" + claveBD + "' ; database=" + basededatos + "")

    Dim cmd As OleDbDataAdapter
    Dim cnn As OleDbConnection

    Dim rut_para_data As String
    Dim fecha_emision_para_data As Date
    Dim tipo_ficha_para_data As String

    Private Sub CargarListaAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        select_cargar_data()
    End Sub
    Sub select_cargar_data()
        conector.Close()

        Try

            Dim da As New SqlDataAdapter("select ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , ficha_diagnostico.fecha_emision 'Fecha Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo  and alumno.estado= 'activo' order by ficha_diagnostico.rut_alumno asc", conector)
            Dim ds As New DataSet
            conector.Open()

            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)

            conector.Close()
            conector.Close()
        Catch ex As Exception
            MsgBox("Rut No Encontrado", MsgBoxStyle.Critical, "Atencion")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TipoBuscador.Enabled = True
        TipoBuscador.Show()
        Menu_Principal.Enabled = False
        Me.Close()
        conector.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Try
            rut_para_data = ""
            tipo_ficha_para_data = ""

            rut_para_data = DataGridView1.Rows(e.RowIndex).Cells("Rut del Alumno").Value.ToString()
            fecha_emision_para_data = DataGridView1.Rows(e.RowIndex).Cells("Fecha Diagnostico").Value.ToString()
            tipo_ficha_para_data = DataGridView1.Rows(e.RowIndex).Cells("Nombre Diagnostico").Value.ToString()


        Catch
            rut_para_data = ""
            tipo_ficha_para_data = ""

            rut_para_data = DataGridView1.Rows(e.RowIndex).Cells("Rut del Alumno").Value.ToString()
            fecha_emision_para_data = DataGridView1.Rows(e.RowIndex).Cells("Fecha Diagnostico").Value.ToString()
            tipo_ficha_para_data = DataGridView1.Rows(e.RowIndex).Cells("Nombre Diagnostico").Value.ToString()
        End Try
    End Sub

    Sub funcion_id_tipo()
        conector.Close()
        conector.Close()
        conector.Open()
        Dim qry As String = "select tipo_ficha.id_tipo from tipo_ficha where nombre_tipo ='" & tipo_ficha_para_data & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
        Dim dr As SqlDataReader
        dr = sqlcmd.ExecuteReader
        If dr.Read() Then

            Menu_Principal.IdTipoFicha = dr("id_tipo")
            conector.Close()
            conector.Close()


        Else
            conector.Close()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conector.Close()
        funcion_id_tipo()
        Dim nombre_evaluador_1 As String
        Dim rut_evaluador_1 As String
        Dim profesion_evaluador_1 As String

        Dim nombre_evaluador_2 As String
        Dim rut_evaluador_2 As String
        Dim profesion_evaluador_2 As String

        Dim nombre_evaluador_3 As String
        Dim rut_evaluador_3 As String
        Dim profesion_evaluador_3 As String

        Dim nombre_evaluador_4 As String
        Dim rut_evaluador_4 As String
        Dim profesion_evaluador_4 As String

        Dim nombre_evaluador_5 As String
        Dim rut_evaluador_5 As String
        Dim profesion_evaluador_5 As String

        Dim nombre_apoyo_1 As String
        Dim rut_apoyo_1 As String

        Dim nombre_apoyo_2 As String
        Dim rut_apoyo_2 As String

        Dim nombre_apoyo_3 As String
        Dim rut_apoyo_3 As String

        Dim nombre_apoyo_4 As String
        Dim rut_apoyo_4 As String

        Dim pruebax_1 As String
        Dim puntajex_1 As String

        Dim pruebax_2 As String
        Dim puntajex_2 As String

        Dim pruebax_3 As String
        Dim puntajex_3 As String

        Dim pruebax_4 As String
        Dim puntajex_4 As String

        Dim pruebax_5 As String
        Dim puntajex_5 As String

        Try
            conector.Close()
            conector.Open()
            Dim qry As String = "select ficha_diagnostico.id_tipoficha , ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" & rut_para_data & "'  and ficha_diagnostico.fecha_emision = '" & fecha_emision_para_data & "' and ficha_diagnostico.id_tipoficha = " & Menu_Principal.IdTipoFicha & " "
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                Menu_Principal.IdTipoFicha = dr("id_tipoficha")
                Menu_Principal.Label55.Text = dr("numero_estudiante")
                Menu_Principal.Label72.Text = dr("apellido_paterno")
                Menu_Principal.Label73.Text = dr("apellido_materno")
                Menu_Principal.Label74.Text = dr("nombres_alumno")
                Menu_Principal.Label75.Text = dr("fecha_nacimiento")
                Menu_Principal.Label76.Text = dr("rut_alumno")
                Menu_Principal.RutDelAlumno = dr("rut_alumno")
                Menu_Principal.Label77.Text = dr("sexo_alumno")
                Menu_Principal.Label100.Text = dr("nacionalidad_alumno")
                Menu_Principal.Label78.Text = dr("nombre")
                Menu_Principal.TextBox44.Text = dr("nuevo_ingreso")
                Menu_Principal.Label80.Text = dr("continuidad")
                Menu_Principal.TextBox34.Text = dr("diagnostico")
                Menu_Principal.TextBox46.Text = dr("sindrome_asociado_diagnostico")
                Menu_Principal.TextBox47.Text = dr("observaciones_salud")
                Menu_Principal.Label84.Text = dr("fecha_emision")
                rut_evaluador_1 = dr("rut_evaluador_1")
                nombre_evaluador_1 = dr("nombre_evaluador_1")
                profesion_evaluador_1 = dr("profesion_evaluador_1")

                rut_evaluador_2 = dr("rut_evaluador_2")
                nombre_evaluador_2 = dr("nombre_evaluador_2")
                profesion_evaluador_2 = dr("profesion_evaluador_2")

                rut_evaluador_3 = dr("rut_evaluador_3")
                nombre_evaluador_3 = dr("nombre_evaluador_3")
                profesion_evaluador_3 = dr("profesion_evaluador_3")

                rut_evaluador_4 = dr("rut_evaluador_4")
                nombre_evaluador_4 = dr("nombre_evaluador_4")
                profesion_evaluador_4 = dr("profesion_evaluador_4")

                rut_evaluador_5 = dr("rut_evaluador_5")
                nombre_evaluador_5 = dr("nombre_evaluador_5")
                profesion_evaluador_5 = dr("profesion_evaluador_5")

                Menu_Principal.Label85.Text = rut_evaluador_1 + " " + nombre_evaluador_1 + "  " + profesion_evaluador_1 + vbCr + rut_evaluador_2 + " " + nombre_evaluador_2 + "  " + profesion_evaluador_2 + vbCr + rut_evaluador_3 + " " + nombre_evaluador_3 + "  " + profesion_evaluador_3 + vbCr + rut_evaluador_4 + " " + nombre_evaluador_4 + "  " + profesion_evaluador_4 + vbCr + rut_evaluador_5 + " " + nombre_evaluador_5 + "  " + profesion_evaluador_5
                pruebax_1 = dr("prueba_1")
                puntajex_1 = dr("puntaje_1")

                pruebax_2 = dr("prueba_2")
                puntajex_2 = dr("puntaje_2")

                pruebax_3 = dr("prueba_3")
                puntajex_3 = dr("puntaje_3")

                pruebax_4 = dr("prueba_4")
                puntajex_4 = dr("puntaje_4")

                pruebax_5 = dr("prueba_5")
                puntajex_5 = dr("puntaje_5")

                Menu_Principal.Label86.Text = "prueba 1  " + pruebax_1 + "  puntaje  " + puntajex_1 + vbCr + "prueba 2  " + pruebax_2 + "  puntaje  " + puntajex_2 + vbCr + "prueba 3  " + pruebax_3 + "  puntaje  " + puntajex_3 + vbCr + "prueba 4  " + pruebax_4 + "  puntaje  " + puntajex_4 + vbCr + "prueba 5  " + pruebax_5 + "  puntaje  " + puntajex_5
                rut_apoyo_1 = dr("rut_apoyo_1")
                nombre_apoyo_1 = dr("nombre_apoyo_1")

                rut_apoyo_2 = dr("rut_apoyo_2")
                nombre_apoyo_2 = dr("nombre_apoyo_2")

                rut_apoyo_3 = dr("rut_apoyo_3")
                nombre_apoyo_3 = dr("nombre_apoyo_3")

                rut_apoyo_4 = dr("rut_apoyo_4")
                nombre_apoyo_4 = dr("nombre_apoyo_4")

                Menu_Principal.Label87.Text = rut_apoyo_1 + "   " + nombre_apoyo_1 + vbCr + rut_apoyo_2 + "   " + nombre_apoyo_2 + vbCr + rut_apoyo_3 + "   " + nombre_apoyo_3 + vbCr + rut_apoyo_4 + "   " + nombre_apoyo_4

                conector.Close()

                Menu_Principal.MostrarApoyo1Todos()
                Menu_Principal.MostrarApoyo2Todos()
                Menu_Principal.MostrarApoyo3Todos()
                Menu_Principal.MostrarApoyo4Todos()

                Menu_Principal.MostrarEvaluador1Todos()
                Menu_Principal.MostrarEvaluador2Todos()
                Menu_Principal.MostrarEvaluador3Todos()
                Menu_Principal.MostrarEvaluador4Todos()
                Menu_Principal.MostrarEvaluador5Todos()

                Menu_Principal.Enabled = True
                Menu_Principal.Show()

                Menu_Principal.TabControl1.SelectedIndex = 11
                Me.Hide()

                Menu_Principal.Button35.Visible = True
                Menu_Principal.Button35.Enabled = True
                Menu_Principal.Button36.Visible = False
                Menu_Principal.Button36.Enabled = False

            Else
                conector.Close()
                conector.Close()
                MsgBox("INTENTE NUEVAMENTE", MsgBoxStyle.Critical, "Atencion")
            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)
            conector.Close()
        End Try
        conector.Close()
    End Sub
End Class
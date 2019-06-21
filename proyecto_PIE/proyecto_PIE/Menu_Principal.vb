Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Net.Mail
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf



Imports System.IO
Imports System.Net

Public Class Menu_Principal

    Public id_prof_apoyo As Integer
    Public ConcatenoDeNuevoIngreso As String
    Public ConcatenoDeSindromeAsociadoAlDiagnostico As String
    Public ConcatenoDeAñoContinuidad As String
    Public RutDelAlumno As String
    Public IdTipoFicha As Integer
    Public IdEvaluador1 As Integer
    Public IdEvaluador2 As Integer
    Public IdEvaluador3 As Integer
    Public IdEvaluador4 As Integer
    Public IdEvaluador5 As Integer
    Public IdApoyo1 As Integer
    Public IdApoyo2 As Integer
    Public IdApoyo3 As Integer
    Public IdApoyo4 As Integer
    Public idCurso As Integer
    Public IdUsuario As Integer



    Public id_tipo_ficha As Integer


    Public profesion_ev_1 As String
    Public profesion_ev_2 As String
    Public profesion_ev_3 As String
    Public profesion_ev_4 As String
    Public profesion_ev_5 As String

    Public rut_ev_1 As String
    Public rut_ev_2 As String
    Public rut_ev_3 As String
    Public rut_ev_4 As String
    Public rut_ev_5 As String

    Public rut_apoyo_1 As String
    Public rut_apoyo_2 As String
    Public rut_apoyo_3 As String
    Public rut_apoyo_4 As String


    Dim ipServidor As String = datos_conn.getservidor()
    Dim puerto As String = datos_conn.getpuerto()
    Dim claveBD As String = datos_conn.getpass()
    Dim basededatos As String = datos_conn.getbd()
    Dim usuarioBD As String = datos_conn.getuser()
    Dim servidorSQL As String
    Dim strcon As String
    Public dreader As SqlDataReader
    Dim conector As New SqlConnection("server=" + ipServidor + "  ;user='" + usuarioBD + "';password= '" + claveBD + "' ; database=" + basededatos + "")


    Dim cmd As OleDbDataAdapter
    Dim cnn As OleDbConnection
    Dim dt As DataTable

    Dim sexo As String
    Dim naci As String
    Dim fecha_nacimiento As String
    Dim fecha_emision As String

    Dim rut_para_data As String
    Dim fecha_emision_para_data As Date
    Dim tipo_ficha_para_data As String

    Private Sub Menu_Principal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        MostrarApoyo1()
        MostrarApoyo2()
        MostrarApoyo3()
        MostrarApoyo4()
        MostrarCursos()
        MostrarEvaluador1()
        MostrarEvaluador2()
        MostrarEvaluador3()
        MostrarEvaluador4()
        MostrarEvaluador5()

    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
        conector.Close()
        conector.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        conector.Close()
        conector.Close()
        conector.Close()
        If MsgBox("¿ Seguro que desea salir ?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            conector.Close()
            conector.Close()

            End
            Me.Close()
        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        funcion_update_alumno()
    End Sub

    Sub funcion_id_apoyo()
        conector.Close()
        conector.Open()
        Dim qry As String = "select id_profapoyo from profesional_apoyo where nombre_apoyo ='" & TextBox11.Text & "'"
        Dim sqlcmd As New SqlCommand(qry, conector)
        Dim dr As SqlDataReader
        dr = sqlcmd.ExecuteReader
        If dr.Read() Then

            id_prof_apoyo = dr("id_profapoyo")
            conector.Close()
            MsgBox("BUENA BUENA", MsgBoxStyle.Information, "Operacion Exitosa")


            conector.Close()
        End If

    End Sub
    Sub ObtenerIdCurso()
        conector.Close()

        Try

            conector.Close()
            conector.Open()
            Dim qry As String = "select curso.id_curso from curso where curso.nombre = '" & ComboBox8.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then


                idCurso = dr("id_curso")



                conector.Close()

            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub

    Sub funcion_insert_alumno()
        conector.Close()
        conector.Close()

        sexo = ComboBox1.Text
        naci = ComboBox2.Text
        fecha_nacimiento = MonthCalendar1.SelectionRange.End

        conector.Close()

        Try
            conector.Close()

            Dim cadena As String
            cadena = String.Format("INSERT INTO alumno VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox4.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & fecha_nacimiento & "','" & sexo & "','" & naci & "' , 'activo')")

            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()

            conector.Close()
            MsgBox("ALUMNO INGRESADO EXITOSAMENTE", MsgBoxStyle.Information, "Operacion Exitosa")
            conector.Close()

        Catch ex As Exception
            MsgBox("Error Alumno" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Atencion")

            conector.Close()
        End Try

    End Sub

    Sub funcion_insert_apoderado()
        conector.Close()

        Try
            conector.Close()

            Dim cadena As String
            cadena = String.Format("INSERT INTO apoderado VALUES ('" & TextBox7.Text & "', '" & TextBox8.Text & "', '" & TextBox9.Text & "','" & TextBox10.Text & "' , '" & ComboBox9.Text & "')")

            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()

            conector.Close()
            MsgBox("APODERADO INGRESADO EXITOSAMENTE", MsgBoxStyle.Information, "Operacion Exitosa")
            conector.Close()

        Catch ex As Exception
            MsgBox("Error Apoderado" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Atencion")

            conector.Close()
        End Try

    End Sub

    Sub funcion_insert_apoyo()
        conector.Close()

        Try
            conector.Close()

            Dim cadena As String
            cadena = String.Format("INSERT INTO profesional_apoyo (rut_apoyo,nombre_apoyo) VALUES ('" & TextBox12.Text & "', '" & TextBox11.Text & "')")

            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()

            conector.Close()
            MsgBox("PROFESIONAL DE APOYO INGRESADO EXITOSAMENTE", MsgBoxStyle.Information, "Operacion Exitosa")
            conector.Close()

        Catch ex As Exception
            MsgBox("Error Ingreso" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Atencion")

            conector.Close()
        End Try

    End Sub

    Sub funcion_insert_evaluador()
        conector.Close()

        Try
            conector.Close()

            Dim cadena As String
            cadena = String.Format("INSERT INTO profesional_evaluador (rut_evaluador,nombre_evaluador,profesion) VALUES ('" & TextBox14.Text & "', '" & TextBox13.Text & "','" & TextBox15.Text & "')")

            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()

            conector.Close()
            MsgBox("PROFESIONAL EVALUADOR INGRESADO EXITOSAMENTE", MsgBoxStyle.Information, "Operacion Exitosa")
            conector.Close()

        Catch ex As Exception
            MsgBox("Error Ingreso" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Atencion")

            conector.Close()
        End Try

    End Sub

    Sub funcion_insert_tipo_ficha()
        conector.Close()

        Try
            conector.Close()

            Dim cadena As String
            cadena = String.Format("INSERT INTO tipo_ficha (nombre_tipo,descripcion_tipoficha) VALUES ('" & TextBox17.Text & "', '" & TextBox16.Text & "')")

            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()

            conector.Close()
            MsgBox("NOMBRE DE FICHA INGRESADO EXITOSAMENTE", MsgBoxStyle.Information, "Operacion Exitosa")
            conector.Close()

        Catch ex As Exception
            MsgBox("Error Ingreso" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Atencion")

            conector.Close()
        End Try

    End Sub
    Sub ObtenerIdEvaluador()
        conector.Close()

        Try

            conector.Close()
            conector.Open()
            Dim qry As String = "select profesional_evaluador.rut_evaluador, profesional_evaluador.profesion , profesional_evaluador.id_evaluador from profesional_evaluador where profesional_evaluador.nombre_evaluador = '" & ComboBox3.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                rut_ev_1 = dr("rut_evaluador")
                profesion_ev_1 = dr("profesion")
                IdEvaluador1 = dr("id_evaluador")



                conector.Close()

            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()

        Try

            conector.Close()
            conector.Open()
            Dim qry As String = "select profesional_evaluador.rut_evaluador, profesional_evaluador.profesion , profesional_evaluador.id_evaluador from profesional_evaluador where profesional_evaluador.nombre_evaluador = '" & ComboBox4.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                rut_ev_2 = dr("rut_evaluador")
                profesion_ev_2 = dr("profesion")
                IdEvaluador2 = dr("id_evaluador")



                conector.Close()

            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
        Try

            conector.Close()
            conector.Open()
            Dim qry As String = "select profesional_evaluador.rut_evaluador, profesional_evaluador.profesion , profesional_evaluador.id_evaluador from profesional_evaluador where profesional_evaluador.nombre_evaluador = '" & ComboBox5.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then


                rut_ev_3 = dr("rut_evaluador")
                profesion_ev_3 = dr("profesion")
                IdEvaluador3 = dr("id_evaluador")



                conector.Close()

            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
        Try

            conector.Close()
            conector.Open()
            Dim qry As String = "select profesional_evaluador.rut_evaluador, profesional_evaluador.profesion , profesional_evaluador.id_evaluador from profesional_evaluador where profesional_evaluador.nombre_evaluador = '" & ComboBox6.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then


                rut_ev_4 = dr("rut_evaluador")
                profesion_ev_4 = dr("profesion")
                IdEvaluador4 = dr("id_evaluador")


                conector.Close()

            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
        Try

            conector.Close()
            conector.Open()
            Dim qry As String = "select profesional_evaluador.rut_evaluador, profesional_evaluador.profesion , profesional_evaluador.id_evaluador from profesional_evaluador where profesional_evaluador.nombre_evaluador = '" & ComboBox7.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                rut_ev_5 = dr("rut_evaluador")
                profesion_ev_5 = dr("profesion")
                IdEvaluador5 = dr("id_evaluador")


                conector.Close()

            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub

    Sub ObtenerIdApoyo()
        conector.Close()
        Try

            conector.Close()
            conector.Open()
            Dim qry As String = "select profesional_apoyo.rut_apoyo , profesional_apoyo.id_profapoyo from profesional_apoyo where profesional_apoyo.nombre_apoyo = '" & ComboBox10.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                rut_apoyo_1 = dr("rut_apoyo")
                IdApoyo1 = dr("id_profapoyo")



                conector.Close()

            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
        Try

            conector.Close()
            conector.Open()
            Dim qry As String = "select profesional_apoyo.rut_apoyo , profesional_apoyo.id_profapoyo from profesional_apoyo where profesional_apoyo.nombre_apoyo = '" & ComboBox11.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                rut_apoyo_2 = dr("rut_apoyo")
                IdApoyo2 = dr("id_profapoyo")



                conector.Close()

            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
        Try

            conector.Close()
            conector.Open()
            Dim qry As String = "select profesional_apoyo.rut_apoyo , profesional_apoyo.id_profapoyo from profesional_apoyo where profesional_apoyo.nombre_apoyo = '" & ComboBox12.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                rut_apoyo_3 = dr("rut_apoyo")
                IdApoyo3 = dr("id_profapoyo")



                conector.Close()

            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
        Try

            conector.Close()
            conector.Open()
            Dim qry As String = "select profesional_apoyo.rut_apoyo , profesional_apoyo.id_profapoyo from profesional_apoyo where profesional_apoyo.nombre_apoyo = '" & ComboBox13.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                rut_apoyo_4 = dr("rut_apoyo")
                IdApoyo4 = dr("id_profapoyo")

                conector.Close()

            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub


    Sub funcion_insert_ficha_diagnostico()
        conector.Close()
        fecha_emision = MonthCalendar2.SelectionRange.Start


        Try
            conector.Close()

            Dim cadena As String
            cadena = String.Format("INSERT INTO ficha_diagnostico (rut_alumno, id_evaluador_1, id_evaluador_2, id_evaluador_3, id_evaluador_4, id_evaluador_5, id_apoyo_1, id_apoyo_2, id_apoyo_3, id_apoyo_4, id_tipoficha, curso_alumno, nuevo_ingreso, continuidad, diagnostico, sindrome_asociado_diagnostico, observaciones_salud, fecha_emision, prueba_1, puntaje_1, prueba_2, puntaje_2, prueba_3, puntaje_3, prueba_4, puntaje_4, prueba_5, puntaje_5,usuario,nombre_apoyo_1,nombre_apoyo_2,nombre_apoyo_3,nombre_apoyo_4,nombre_evaluador_1,nombre_evaluador_2,nombre_evaluador_3,nombre_evaluador_4,nombre_evaluador_5, numero_estudiante,ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.rut_evaluador_3 , ficha_diagnostico.rut_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.profesion_evaluador_1 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.rut_apoyo_4) VALUES ('" & RutDelAlumno & "', " & IdEvaluador1 & ", " & IdEvaluador2 & ", " & IdEvaluador3 & ", " & IdEvaluador4 & ", " & IdEvaluador5 & ", " & IdApoyo1 & ", " & IdApoyo2 & ", " & IdApoyo3 & ", " & IdApoyo4 & ", " & IdTipoFicha & " , " & idCurso & ",'" & ConcatenoDeNuevoIngreso & "','" & ConcatenoDeAñoContinuidad & "','" & TextBox20.Text & "','" & ConcatenoDeSindromeAsociadoAlDiagnostico & "', '" & TextBox22.Text & "','" & fecha_emision & "','" & TextBox23.Text & "','" & TextBox24.Text & "','" & TextBox26.Text & "','" & TextBox25.Text & "','" & TextBox28.Text & "','" & TextBox27.Text & "','" & TextBox30.Text & "','" & TextBox29.Text & "','" & TextBox32.Text & "','" & TextBox31.Text & "'," & IdUsuario & ",'" & ComboBox10.Text & "','" & ComboBox11.Text & "','" & ComboBox12.Text & "','" & ComboBox13.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & ComboBox5.Text & "','" & ComboBox6.Text & "','" & ComboBox7.Text & "', " & TextBox33.Text & " ,'" & rut_ev_1 & "','" & rut_ev_2 & "','" & rut_ev_3 & "','" & rut_ev_4 & "','" & rut_ev_5 & "','" & profesion_ev_1 & "','" & profesion_ev_2 & "','" & profesion_ev_3 & "','" & profesion_ev_4 & "','" & profesion_ev_5 & "','" & rut_apoyo_1 & "','" & rut_apoyo_2 & "','" & rut_apoyo_3 & "','" & rut_apoyo_4 & "')")

            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()

            conector.Close()
            MsgBox("NOMBRE DE FICHA INGRESADO EXITOSAMENTE", MsgBoxStyle.Information, "Operacion Exitosa")
            conector.Close()

        Catch ex As Exception
            MsgBox("Error Ingreso" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Atencion")

            conector.Close()
        End Try

    End Sub

    Sub funcion_update_tipo_ficha()
        conector.Close()

        Try
            conector.Close()
            Dim cadena As String
            cadena = String.Format("UPDATE tipo_ficha SET nombre_tipo = '" & TextBox17.Text & "' , descripcion_tipoficha ='" & TextBox16.Text & "'  WHERE nombre_tipo = '" & TextBox17.Text & "'")
            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()
            conector.Close()
            MsgBox("TIPO DE FICHA MODIFICADO EXITOSAMENTE", MsgBoxStyle.Information, "Operacion Exitosa")
        Catch ex As Exception
            MsgBox("Error Modificar Ficha", MsgBoxStyle.Critical, "Atencion")
            conector.Close()
        End Try
        conector.Close()
    End Sub

    Sub funcion_update_evaluador()
        conector.Close()

        Try
            conector.Close()
            Dim cadena As String
            cadena = String.Format("UPDATE profesional_evaluador SET nombre_evaluador = '" & TextBox13.Text & "' , profesion ='" & TextBox15.Text & "'  WHERE rut_evaluador = '" & TextBox14.Text & "'")
            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()
            conector.Close()
            MsgBox("PROFESIONAL MODIFICADO EXITOSAMENTE", MsgBoxStyle.Information, "Operacion Exitosa")
        Catch ex As Exception
            MsgBox("Error Modificar PROFESIONAL", MsgBoxStyle.Critical, "Atencion")
            conector.Close()
        End Try
        conector.Close()
    End Sub

    Sub funcion_update_apoyo()
        conector.Close()

        Try
            conector.Close()
            Dim cadena As String
            cadena = String.Format("UPDATE profesional_apoyo SET nombre_apoyo = '" & TextBox11.Text & "'  WHERE rut_apoyo = '" & TextBox12.Text & "'")
            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()
            conector.Close()
            MsgBox("PROFESIONAL MODIFICADO EXITOSAMENTE", MsgBoxStyle.Information, "Operacion Exitosa")
        Catch ex As Exception
            MsgBox("Error Modificar PROFESIONAL", MsgBoxStyle.Critical, "Atencion")
            conector.Close()
        End Try

        conector.Close()
    End Sub

    Sub funcion_update_alumno()
        conector.Close()
        fecha_nacimiento = MonthCalendar1.SelectionRange.End

        Try

            Dim cadena As String
            cadena = String.Format("UPDATE alumno SET nombres_alumno = '" & TextBox2.Text & "' , apellido_paterno ='" & TextBox4.Text & "',apellido_materno = '" & TextBox3.Text & "',fono_alumno = " & TextBox5.Text & ", direccion_alumno = '" & TextBox6.Text & "', fecha_nacimiento = '" & fecha_nacimiento & "' , sexo_alumno = '" & ComboBox1.SelectedItem & "', nacionalidad_alumno = '" & ComboBox2.SelectedItem & "' WHERE alumno.rut_alumno = '" & TextBox1.Text & "'")
            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()
            conector.Close()

            MsgBox("ALUMNO MODIFICADO EXITOSAMENTE", MsgBoxStyle.Information, "Operacion Exitosa")
        Catch ex As Exception
            MsgBox("ERROR INTENTE DE NUEVO", MsgBoxStyle.Critical, "Alerta" & vbCrLf & ex.Message)
            conector.Close()
            conector.Close()
        End Try
        conector.Close()

    End Sub

    Sub funcion_update_apoderado()
        conector.Close()
        Try
            conector.Close()
            Dim cadena As String
            cadena = String.Format("UPDATE apoderado SET nombre_apoderado = '" & TextBox8.Text & "', fono_apoderado = '" & TextBox9.Text & "', direccion_apoderado ='" & TextBox10.Text & "'  WHERE rut_apoderado = '" & TextBox7.Text & "'")
            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()
            conector.Close()
            MsgBox("APODERADO MODIFICADO EXITOSAMENTE", MsgBoxStyle.Information, "Operacion Exitosa")
        Catch ex As Exception
            MsgBox("Error Modificar Apoderado", MsgBoxStyle.Critical, "Atencion")
            conector.Close()
        End Try
        conector.Close()
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click

        If (MonthCalendar1.SelectionRange.Start.Year >= Year(Now) Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "") Then
            MsgBox("Verifique campos en blanco O Fecha de Nacimiento invalida", MsgBoxStyle.Critical, "Atencion")
            TextBox1.Select()
            conector.Close()

        Else
            conector.Close()
            conector.Open()
            Dim qry As String = "select alumno.rut_alumno,alumno.nombres_alumno,alumno.apellido_paterno,alumno.apellido_materno,alumno.fecha_nacimiento,alumno.sexo_alumno,alumno.nacionalidad_alumno,alumno.direccion_alumno,alumno.fono_alumno from alumno where alumno.rut_alumno='" & TextBox1.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                TextBox2.Text = dr("nombres_alumno")
                TextBox4.Text = dr("apellido_paterno")
                TextBox3.Text = dr("apellido_materno")
                TextBox5.Text = dr("fono_alumno")
                TextBox6.Text = dr("direccion_alumno")
                fecha_nacimiento = dr("fecha_nacimiento")
                MonthCalendar1.SetDate(fecha_nacimiento)
                ComboBox1.Text = dr("sexo_alumno")
                ComboBox2.Text = dr("nacionalidad_alumno")
                conector.Close()
                conector.Close()
                MsgBox("El Alumno Ya Fue Ingresado", MsgBoxStyle.Information, "Operacion Exitosa")


                conector.Close()

            Else
                Try
                    funcion_insert_alumno()

                Catch ex As Exception
                    MsgBox("error" & vbCrLf & ex.Message)
                    conector.Close()
                End Try
            End If
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        conector.Close()
        If TextBox1.TextLength = 8 Then TextBox1.Text = ValidaRut(TextBox1.Text)
    End Sub
    Public Function ValidaRut(ByVal ElNumero As String) As String
        Try
            Dim Resultado As String = ""
            Dim Multiplicador As Integer = 2
            Dim iNum As Integer = 0
            Dim Suma As Integer = 0

            For i As Integer = 8 To 1 Step -1
                iNum = Mid(ElNumero, i, 1)
                Suma += iNum * Multiplicador
                Multiplicador += 1
                If Multiplicador = 8 Then Multiplicador = 2
            Next
            Resultado = CStr(11 - (Suma Mod 11))
            If Resultado = "10" Then Resultado = "K"
            If Resultado = "11" Then Resultado = "0"
            Return ElNumero & "-" & Resultado
        Catch ex As Exception
            conector.Close()
        End Try
    End Function

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

        TextBox2.Text = UCase(TextBox2.Text)
        TextBox2.SelectionStart = TextBox2.TextLength + 1
    End Sub
    Private Sub textbox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyData
            Case Keys.A To Keys.Z Or Keys.Space

                ' Números del 0 al 9

                e.SuppressKeyPress = True
        End Select
    End Sub
    Private Sub textbox5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox5.KeyDown
        Select Case e.KeyData
            Case Keys.A To Keys.Z Or Keys.Space

                ' Números del 0 al 9

                e.SuppressKeyPress = True
        End Select
    End Sub
    Private Sub textbox9_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox9.KeyDown
        Select Case e.KeyData
            Case Keys.A To Keys.Z Or Keys.Space

                ' Números del 0 al 9

                e.SuppressKeyPress = True
        End Select
    End Sub



    Private Sub TextBox8_KeyPress(ByVal sender As Object,
                         ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                         Handles TextBox8.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object,
                         ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                         Handles TextBox2.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub TextBox3_KeyPress(ByVal sender As Object,
                     ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                     Handles TextBox3.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object,
                     ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                     Handles TextBox4.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        TextBox4.Text = UCase(TextBox4.Text)
        TextBox4.SelectionStart = TextBox4.TextLength + 1
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        TextBox3.Text = UCase(TextBox3.Text)
        TextBox3.SelectionStart = TextBox3.TextLength + 1
    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged
        TextBox6.Text = UCase(TextBox6.Text)
        TextBox6.SelectionStart = TextBox6.TextLength + 1
    End Sub

    Sub MostrarRutAlumno()

        conector.Close()
        conector.Open()
        Dim qry As String = "select alumno.rut_alumno from alumno where alumno.estado= 'activo'"
        Dim sqlcmd As New SqlCommand(qry, conector)
        'Dim drc As String
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet()

        Dim drc = sqlcmd.ExecuteReader
        conector.Close()
        da.Fill(ds)

        ComboBox9.DataSource = ds.Tables(0)
        ComboBox9.DisplayMember = "rut_alumno"
        ComboBox9.SelectedItem = 0

    End Sub
    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click

        If (TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "") Then
            MsgBox("Verifique campos en blanco O Fecha de Nacimiento invalida", MsgBoxStyle.Critical, "Atencion")
            TextBox1.Select()
            conector.Close()


        Else
            conector.Close()
            conector.Open()
            Dim qry As String = "select apoderado.rut_apoderado,apoderado.nombre_apoderado,apoderado.fono_apoderado,apoderado.direccion_apoderado from apoderado where apoderado.rut_apoderado='" & TextBox7.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                TextBox2.Text = dr("nombre_apoderado")
                TextBox4.Text = dr("fono_apoderado")
                TextBox3.Text = dr("direccion_apoderado")

                conector.Close()
                conector.Close()
                MsgBox("El Apoderado Ya Fue Ingresado", MsgBoxStyle.Information, "Operacion Exitosa")


                conector.Close()

            Else
                conector.Close()
                conector.Open()
                Dim qry1 As String = "select apoderado.rut_fk_alumno from apoderado where apoderado.rut_fk_alumno='" & ComboBox9.Text & "'"
                Dim sqlcmd1 As New SqlCommand(qry1, conector)
                Dim dr1 As SqlDataReader
                dr1 = sqlcmd1.ExecuteReader
                If dr1.Read() Then


                    MsgBox("No puede haber un alumnos con dos apoderados ", MsgBoxStyle.Information, "Operacion Exitosa")


                    conector.Close()
                Else
                    Try
                        funcion_insert_apoderado()

                    Catch ex As Exception
                        MsgBox("error" & vbCrLf & ex.Message)
                        conector.Close()
                    End Try
                End If
            End If
        End If

    End Sub



    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        funcion_update_apoderado()
    End Sub

    Private Sub Button22_Click(sender As System.Object, e As System.EventArgs) Handles Button22.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(3)
        MostrarRutAlumno()
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""

    End Sub

    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox7.TextChanged

        TextBox7.Text = UCase(TextBox7.Text)
        TextBox7.SelectionStart = TextBox7.TextLength + 1
    End Sub

    Private Sub TextBox8_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox8.TextChanged

        TextBox8.Text = UCase(TextBox8.Text)
        TextBox8.SelectionStart = TextBox8.TextLength + 1
    End Sub

    Private Sub TextBox10_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox10.TextChanged

        TextBox10.Text = UCase(TextBox10.Text)
        TextBox10.SelectionStart = TextBox10.TextLength + 1
    End Sub

    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        'funcion_id_apoyo()
        funcion_update_apoyo()
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        funcion_insert_apoyo()
    End Sub

    Private Sub Button26_Click(sender As System.Object, e As System.EventArgs) Handles Button26.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(4)
        TextBox11.Text = ""
        TextBox12.Text = ""
    End Sub

    Private Sub Button29_Click(sender As System.Object, e As System.EventArgs) Handles Button29.Click
        funcion_insert_evaluador()
    End Sub

    Private Sub Button28_Click(sender As System.Object, e As System.EventArgs) Handles Button28.Click
        funcion_update_evaluador()
    End Sub

    Private Sub Button30_Click(sender As System.Object, e As System.EventArgs) Handles Button30.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(5)
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
    End Sub

    Private Sub Button33_Click(sender As System.Object, e As System.EventArgs) Handles Button33.Click
        funcion_insert_tipo_ficha()
    End Sub

    Private Sub Button32_Click(sender As System.Object, e As System.EventArgs) Handles Button32.Click
        funcion_update_tipo_ficha()
    End Sub

    Private Sub Button34_Click(sender As System.Object, e As System.EventArgs) Handles Button34.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub TabPage7_Click(sender As System.Object, e As System.EventArgs) Handles TabPage7.Click

    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(6)
        TextBox16.Text = ""
        TextBox17.Text = ""

    End Sub

    Private Sub TextBox11_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox11.TextChanged
        TextBox11.Text = UCase(TextBox11.Text)
        TextBox11.SelectionStart = TextBox11.TextLength + 1
    End Sub

    Private Sub TextBox13_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox13.TextChanged
        TextBox13.Text = UCase(TextBox13.Text)
        TextBox13.SelectionStart = TextBox13.TextLength + 1
    End Sub

    Private Sub TextBox15_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox15.TextChanged
        TextBox15.Text = UCase(TextBox15.Text)
        TextBox15.SelectionStart = TextBox15.TextLength + 1
    End Sub

    Private Sub TextBox17_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox17.TextChanged
        TextBox17.Text = UCase(TextBox17.Text)
        TextBox17.SelectionStart = TextBox17.TextLength + 1
    End Sub

    Private Sub TextBox16_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox16.TextChanged
        TextBox16.Text = UCase(TextBox16.Text)
        TextBox16.SelectionStart = TextBox16.TextLength + 1
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        'TabControl1.SelectedTab = TabControl1.TabPages.Item(1)


        TipoEvaluacion.Show()
        Me.Enabled = False

    End Sub

    Private Sub Button65_Click(sender As System.Object, e As System.EventArgs) Handles Button65.Click

        ObtenerIdCurso()
        ConcatenoDePalabra()

        TabControl1.SelectedTab = TabControl1.TabPages.Item(8)

    End Sub

    Private Sub Button37_Click(sender As System.Object, e As System.EventArgs)
        TabControl1.SelectedTab = TabControl1.TabPages.Item(7)
    End Sub

    Sub MostrarCursos()

        conector.Close()
        conector.Open()
        Dim qry As String = "select curso.nombre from curso"
        Dim sqlcmd As New SqlCommand(qry, conector)
        'Dim drc As String
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet()

        Dim drc = sqlcmd.ExecuteReader
        conector.Close()
        da.Fill(ds)

        ComboBox8.DataSource = ds.Tables(0)
        ComboBox8.DisplayMember = "nombre"
        ComboBox8.SelectedIndex = 0

    End Sub

    Sub MostrarEvaluador1()

        conector.Close()
        conector.Open()
        Dim qry As String = "select profesional_evaluador.nombre_evaluador from profesional_evaluador"
        Dim sqlcmd As New SqlCommand(qry, conector)
        'Dim drc As String
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet()

        Dim drc = sqlcmd.ExecuteReader
        conector.Close()
        da.Fill(ds)

        ComboBox3.DataSource = ds.Tables(0)
        ComboBox3.DisplayMember = "nombre_evaluador"
        ComboBox3.SelectedIndex = 0


    End Sub

    Sub MostrarEvaluador2()

        conector.Close()
        conector.Open()
        Dim qry As String = "select profesional_evaluador.nombre_evaluador from profesional_evaluador"
        Dim sqlcmd As New SqlCommand(qry, conector)
        'Dim drc As String
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet()

        Dim drc = sqlcmd.ExecuteReader
        conector.Close()
        da.Fill(ds)

        ComboBox4.DataSource = ds.Tables(0)
        ComboBox4.DisplayMember = "nombre_evaluador"
        ComboBox4.SelectedIndex = 0


    End Sub
    Sub MostrarEvaluador3()

        conector.Close()
        conector.Open()
        Dim qry As String = "select profesional_evaluador.nombre_evaluador from profesional_evaluador"
        Dim sqlcmd As New SqlCommand(qry, conector)
        'Dim drc As String
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet()

        Dim drc = sqlcmd.ExecuteReader
        conector.Close()
        da.Fill(ds)

        ComboBox5.DataSource = ds.Tables(0)
        ComboBox5.DisplayMember = "nombre_evaluador"
        ComboBox5.SelectedIndex = 0


    End Sub
    Sub MostrarEvaluador4()

        conector.Close()
        conector.Open()
        Dim qry As String = "select profesional_evaluador.nombre_evaluador from profesional_evaluador"
        Dim sqlcmd As New SqlCommand(qry, conector)
        'Dim drc As String
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet()

        Dim drc = sqlcmd.ExecuteReader
        conector.Close()
        da.Fill(ds)

        ComboBox6.DataSource = ds.Tables(0)
        ComboBox6.DisplayMember = "nombre_evaluador"
        ComboBox6.SelectedIndex = 0


    End Sub
    Sub MostrarEvaluador5()

        conector.Close()
        conector.Open()
        Dim qry As String = "select profesional_evaluador.nombre_evaluador from profesional_evaluador"
        Dim sqlcmd As New SqlCommand(qry, conector)
        'Dim drc As String
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet()

        Dim drc = sqlcmd.ExecuteReader
        conector.Close()
        da.Fill(ds)

        ComboBox7.DataSource = ds.Tables(0)
        ComboBox7.DisplayMember = "nombre_evaluador"
        ComboBox7.SelectedIndex = 0


    End Sub

    Sub MostrarApoyo1()

        conector.Close()
        conector.Open()
        Dim qry As String = "select profesional_apoyo.nombre_apoyo from profesional_apoyo"
        Dim sqlcmd As New SqlCommand(qry, conector)
        'Dim drc As String
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet()

        Dim drc = sqlcmd.ExecuteReader
        conector.Close()
        da.Fill(ds)

        ComboBox10.DataSource = ds.Tables(0)
        ComboBox10.DisplayMember = "nombre_apoyo"
        ComboBox10.SelectedIndex = 0


    End Sub
    Sub MostrarApoyo2()

        conector.Close()
        conector.Open()
        Dim qry As String = "select profesional_apoyo.nombre_apoyo from profesional_apoyo"
        Dim sqlcmd As New SqlCommand(qry, conector)
        'Dim drc As String
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet()

        Dim drc = sqlcmd.ExecuteReader
        conector.Close()
        da.Fill(ds)

        ComboBox11.DataSource = ds.Tables(0)
        ComboBox11.DisplayMember = "nombre_apoyo"
        ComboBox11.SelectedIndex = 0


    End Sub
    Sub MostrarApoyo3()

        conector.Close()
        conector.Open()
        Dim qry As String = "select profesional_apoyo.nombre_apoyo from profesional_apoyo"
        Dim sqlcmd As New SqlCommand(qry, conector)
        'Dim drc As String
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet()

        Dim drc = sqlcmd.ExecuteReader
        conector.Close()
        da.Fill(ds)

        ComboBox12.DataSource = ds.Tables(0)
        ComboBox12.DisplayMember = "nombre_apoyo"
        ComboBox12.SelectedIndex = 0
    End Sub

    Sub MostrarApoyo4()
        conector.Close()
        conector.Open()
        Dim qry As String = "select profesional_apoyo.nombre_apoyo from profesional_apoyo"
        Dim sqlcmd As New SqlCommand(qry, conector)
        'Dim drc As String
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet()

        Dim drc = sqlcmd.ExecuteReader
        conector.Close()
        da.Fill(ds)

        ComboBox13.DataSource = ds.Tables(0)
        ComboBox13.DisplayMember = "nombre_apoyo"
        ComboBox13.SelectedIndex = 0


    End Sub

    Sub ConcatenoDePalabra()
        If CheckBox1.Checked = True Then
            ConcatenoDeNuevoIngreso = "SI " + TextBox18.Text
        End If
        If CheckBox2.Checked = True Then
            ConcatenoDeNuevoIngreso = "NO" + TextBox18.Text
        End If
        If CheckBox6.Checked = True Then
            ConcatenoDeSindromeAsociadoAlDiagnostico = "SI " + TextBox21.Text
        End If
        If CheckBox5.Checked = True Then
            ConcatenoDeSindromeAsociadoAlDiagnostico = "NO" + TextBox21.Text
        End If
        If CheckBox4.Checked = True Then
            ConcatenoDeAñoContinuidad = "SI " + TextBox19.Text
        End If
        If CheckBox3.Checked = True Then
            ConcatenoDeAñoContinuidad = "NO " + TextBox19.Text
        End If
    End Sub

    Private Sub Button38_Click(sender As System.Object, e As System.EventArgs) Handles Button38.Click
        ObtenerIdEvaluador()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(9)
    End Sub

    Private Sub Button39_Click(sender As System.Object, e As System.EventArgs) Handles Button39.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(10)
    End Sub

    Private Sub Button37_Click_1(sender As System.Object, e As System.EventArgs) Handles Button37.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(9)
    End Sub

    Private Sub Button40_Click(sender As System.Object, e As System.EventArgs) Handles Button40.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(8)
    End Sub

    Private Sub Button41_Click(sender As System.Object, e As System.EventArgs) Handles Button41.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(7)
    End Sub

    Private Sub Button36_Click(sender As System.Object, e As System.EventArgs) Handles Button36.Click
        ObtenerIdApoyo()
        funcion_insert_ficha_diagnostico()
    End Sub

    Private Sub TextBox18_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox18.TextChanged
        TextBox18.Text = UCase(TextBox18.Text)
        TextBox18.SelectionStart = TextBox18.TextLength + 1
    End Sub

    Private Sub TextBox20_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox20.TextChanged
        TextBox20.Text = UCase(TextBox20.Text)
        TextBox20.SelectionStart = TextBox20.TextLength + 1
    End Sub

    Private Sub TextBox21_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox21.TextChanged
        TextBox21.Text = UCase(TextBox21.Text)
        TextBox21.SelectionStart = TextBox21.TextLength + 1
    End Sub

    Private Sub TextBox22_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox22.TextChanged
        TextBox22.Text = UCase(TextBox22.Text)
        TextBox22.SelectionStart = TextBox22.TextLength + 1
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = CheckState.Checked Then
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            CheckBox5.Checked = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox6.Checked = False
        End If
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0

    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        TextBox11.Text = ""
        TextBox12.Text = ""
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click

    End Sub

    Private Sub TabPage12_Click(sender As Object, e As EventArgs) Handles TabPage12.Click

    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
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
            Dim qry As String = "select ficha_diagnostico.id_tipoficha , ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" & RutDelAlumno & "'  and ficha_diagnostico.fecha_emision = '" & MonthCalendar2.SelectionRange.Start & "' and ficha_diagnostico.id_tipoficha = " & IdTipoFicha & ""
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                IdTipoFicha = dr("id_tipoficha")
                Label55.Text = dr("numero_estudiante")
                Label72.Text = dr("apellido_paterno")
                Label73.Text = dr("apellido_materno")
                Label74.Text = dr("nombres_alumno")
                Label75.Text = dr("fecha_nacimiento")
                Label76.Text = dr("rut_alumno")
                Label77.Text = dr("sexo_alumno")
                Label100.Text = dr("nacionalidad_alumno")
                Label78.Text = dr("nombre")
                TextBox44.Text = dr("nuevo_ingreso")
                Label80.Text = dr("continuidad")
                TextBox34.Text = dr("diagnostico")
                TextBox46.Text = dr("sindrome_asociado_diagnostico")
                TextBox47.Text = dr("observaciones_salud")
                Label84.Text = dr("fecha_emision")
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

                Label85.Text = rut_evaluador_1 + " " + nombre_evaluador_1 + "  " + profesion_evaluador_1 + vbCr + rut_evaluador_2 + " " + nombre_evaluador_2 + "  " + profesion_evaluador_2 + vbCr + rut_evaluador_3 + " " + nombre_evaluador_3 + "  " + profesion_evaluador_3 + vbCr + rut_evaluador_4 + " " + nombre_evaluador_4 + "  " + profesion_evaluador_4 + vbCr + rut_evaluador_5 + " " + nombre_evaluador_5 + "  " + profesion_evaluador_5
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

                Label86.Text = "prueba 1   " + pruebax_1 + "  puntaje   " + puntajex_1 + vbCr + "prueba 2   " + pruebax_2 + "  puntaje   " + puntajex_2 + vbCr + "prueba 3   " + pruebax_3 + "  puntaje   " + puntajex_3 + vbCr + "prueba 4   " + pruebax_4 + "  puntaje   " + puntajex_4 + vbCr + "prueba 5     " + pruebax_5 + "  puntaje   " + puntajex_5
                rut_apoyo_1 = dr("rut_apoyo_1")
                nombre_apoyo_1 = dr("nombre_apoyo_1")

                rut_apoyo_2 = dr("rut_apoyo_2")
                nombre_apoyo_2 = dr("nombre_apoyo_2")

                rut_apoyo_3 = dr("rut_apoyo_3")
                nombre_apoyo_3 = dr("nombre_apoyo_3")

                rut_apoyo_4 = dr("rut_apoyo_4")
                nombre_apoyo_4 = dr("nombre_apoyo_4")

                Label87.Text = rut_apoyo_1 + "   " + nombre_apoyo_1 + vbCr + rut_apoyo_2 + "   " + nombre_apoyo_2 + vbCr + rut_apoyo_3 + "   " + nombre_apoyo_3 + vbCr + rut_apoyo_4 + "   " + nombre_apoyo_4

                conector.Close()
                TabControl1.SelectedTab = TabControl1.TabPages.Item(11)
            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click

        Dim fecha_aqui As Date
        fecha_aqui = Label84.Text

        Dim CrystalReport1 As New CrystalReport1
        Dim rut_para_crystal As New CrystalDecisions.Shared.ParameterDiscreteValue()
        Dim fecha_para_crystal As New CrystalDecisions.Shared.ParameterDiscreteValue()
        rut_para_crystal.Value = Label76.Text
        fecha_para_crystal.Value = fecha_aqui

        CrystalReport1.SetParameterValue("@rut_buscar", rut_para_crystal)
        CrystalReport1.SetParameterValue("@fecha_buscar", fecha_para_crystal)
        Report1.ReportSource = CrystalReport1
        Report1.Zoom(70)




        CrystalReport1.DataSourceConnections(0).SetConnection(servidorSQL, basededatos, usuarioBD, claveBD)
        TabControl1.SelectedTab = TabControl1.TabPages.Item(12)

    End Sub

    Private Sub TabPage13_Click(sender As Object, e As EventArgs) Handles TabPage13.Click

    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click

        TipoEvaluacion.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click

        TipoEvaluacion.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub
    Sub ver_registro_select()
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
            Dim qry As String = "select ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" & Label76.Text & "' and ficha_diagnostico.id_tipoficha = " & IdTipoFicha & " and ficha_diagnostico.fecha_Emision = '" & Label84.Text & "' 
  
"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                TextBox33.Text = dr("numero_estudiante")
                valor_curso = dr("nombre")

                ComboBox8.Text = valor_curso

                TextBox18.Text = dr("nuevo_ingreso")
                TextBox19.Text = dr("continuidad")
                TextBox20.Text = dr("diagnostico")
                TextBox21.Text = dr("sindrome_asociado_diagnostico")
                TextBox22.Text = dr("observaciones_salud")


                SeleccionRutTipoFicha.Fechaemi = dr("fecha_emision")
                MonthCalendar2.SetDate(SeleccionRutTipoFicha.Fechaemi)

                valor_ev_1 = dr("nombre_evaluador_1")
                ComboBox3.Text = valor_ev_1

                valor_ev_2 = dr("nombre_evaluador_2")
                ComboBox4.Text = valor_ev_2

                valor_ev_3 = dr("nombre_evaluador_3")
                ComboBox5.Text = valor_ev_3

                valor_ev_4 = dr("nombre_evaluador_4")
                ComboBox6.Text = valor_ev_4

                valor_ev_5 = dr("nombre_evaluador_5")
                ComboBox7.Text = valor_ev_5

                TextBox23.Text = dr("prueba_1")
                TextBox24.Text = dr("puntaje_1")

                TextBox26.Text = dr("prueba_2")
                TextBox25.Text = dr("puntaje_2")

                TextBox28.Text = dr("prueba_3")
                TextBox27.Text = dr("puntaje_3")

                TextBox30.Text = dr("prueba_4")
                TextBox29.Text = dr("puntaje_4")

                TextBox32.Text = dr("prueba_5")
                TextBox31.Text = dr("puntaje_5")

                valor_apo_1 = dr("nombre_apoyo_1")
                ComboBox10.Text = valor_apo_1

                valor_apo_2 = dr("nombre_apoyo_2")
                ComboBox11.Text = valor_apo_2

                valor_apo_3 = dr("nombre_apoyo_3")
                ComboBox12.Text = valor_apo_3

                valor_apo_4 = dr("nombre_apoyo_4")
                ComboBox13.Text = valor_apo_4


                TabControl1.SelectedTab = TabControl1.TabPages.Item(7)
                Label21.Text = "REGISTRO DEL ALUMNO " + Label74.Text + " " + Label72.Text + " " + Label73.Text

                conector.Close()

            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub
    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        ver_registro_select()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CargarDiagnostico.Enabled = True
        CargarPorRut.Enabled = True
        TipoBuscador.Show()
        TipoBuscador.Enabled = True
        Me.Enabled = False
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(11)
        conector.Close()
    End Sub

    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Button66.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
        conector.Close()
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        select_cargar_primero()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(14)
        conector.Close()
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        select_cargar_segundo()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(15)
        conector.Close()
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        select_cargar_tercero()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(16)
        conector.Close()
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        select_cargar_cuarto()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(17)
        conector.Close()
    End Sub

    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        select_cargar_pre_kimder()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(22)
        conector.Close()
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        select_cargar_kinder()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(23)
        conector.Close()
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        select_cargar_quinto()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(18)
        conector.Close()
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        select_cargar_sexto()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(19)
        conector.Close()
    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        select_cargar_septimo()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(20)
        conector.Close()
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        select_cargar_octavo()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(21)
        conector.Close()
    End Sub
    Sub select_cargar_kinder()
        conector.Close()
        Try


            Dim da As New SqlDataAdapter("select ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , ficha_diagnostico.fecha_emision 'Fecha Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 9 and alumno.estado= 'activo'", conector)
            Dim ds As New DataSet
            conector.Open()

            da.Fill(ds)
            DataGridView9.DataSource = ds.Tables(0)

            conector.Close()
            conector.Close()
        Catch es As Exception
            MsgBox(es)
        End Try

    End Sub
    Sub select_cargar_pre_kimder()
        conector.Close()
        Try

            Dim da As New SqlDataAdapter("select ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , ficha_diagnostico.fecha_emision 'Fecha Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 10 and alumno.estado= 'activo'", conector)
            Dim ds As New DataSet
            conector.Open()

            da.Fill(ds)
            DataGridView8.DataSource = ds.Tables(0)

            conector.Close()
            conector.Close()
        Catch es As Exception
            MsgBox(es)
        End Try

    End Sub

    Sub select_cargar_primero()
        conector.Close()
        Try


            Dim da As New SqlDataAdapter("select ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , ficha_diagnostico.fecha_emision 'Fecha Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 1  and alumno.estado= 'activo'", conector)
            Dim ds As New DataSet
            conector.Open()

            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)

            conector.Close()
            conector.Close()
        Catch es As Exception
            MsgBox(es)
        End Try

    End Sub
    Sub select_cargar_segundo()
        conector.Close()
        Try

            Dim da As New SqlDataAdapter("select ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , ficha_diagnostico.fecha_emision 'Fecha Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 2 and alumno.estado= 'activo'", conector)
            Dim ds As New DataSet
            conector.Open()

            da.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)

            conector.Close()
            conector.Close()
        Catch es As Exception
            MsgBox(es)
        End Try

    End Sub

    Sub select_cargar_tercero()
        conector.Close()
        Try

            Dim da As New SqlDataAdapter("select ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , ficha_diagnostico.fecha_emision 'Fecha Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 3 and alumno.estado= 'activo'", conector)
            Dim ds As New DataSet
            conector.Open()

            da.Fill(ds)
            DataGridView3.DataSource = ds.Tables(0)

            conector.Close()
            conector.Close()
        Catch es As Exception
            MsgBox(es)
        End Try

    End Sub

    Sub select_cargar_cuarto()
        conector.Close()
        Try

            Dim da As New SqlDataAdapter("select ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , ficha_diagnostico.fecha_emision 'Fecha Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 4 and alumno.estado= 'activo'", conector)
            Dim ds As New DataSet
            conector.Open()

            da.Fill(ds)
            DataGridView4.DataSource = ds.Tables(0)

            conector.Close()
            conector.Close()
        Catch es As Exception
            MsgBox(es)
        End Try

    End Sub
    Sub select_cargar_quinto()
        conector.Close()
        Try

            Dim da As New SqlDataAdapter("select ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , ficha_diagnostico.fecha_emision 'Fecha Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 5 and alumno.estado= 'activo'", conector)
            Dim ds As New DataSet
            conector.Open()

            da.Fill(ds)
            DataGridView5.DataSource = ds.Tables(0)

            conector.Close()
            conector.Close()
        Catch es As Exception
            MsgBox(es)
        End Try

    End Sub

    Sub select_cargar_sexto()
        conector.Close()
        Try

            Dim da As New SqlDataAdapter("select ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , ficha_diagnostico.fecha_emision 'Fecha Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 6 and alumno.estado= 'activo'", conector)
            Dim ds As New DataSet
            conector.Open()

            da.Fill(ds)
            DataGridView11.DataSource = ds.Tables(0)

            conector.Close()
            conector.Close()
        Catch es As Exception
            MsgBox(es)
        End Try

    End Sub
    Sub select_cargar_septimo()
        conector.Close()
        Try

            Dim da As New SqlDataAdapter("select ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , ficha_diagnostico.fecha_emision 'Fecha Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 7 and alumno.estado= 'activo'", conector)
            Dim ds As New DataSet
            conector.Open()

            da.Fill(ds)
            DataGridView6.DataSource = ds.Tables(0)

            conector.Close()
            conector.Close()
        Catch es As Exception
            MsgBox(es)
        End Try

    End Sub
    Sub select_cargar_octavo()

        conector.Close()
        Try

            Dim da As New SqlDataAdapter("select ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , ficha_diagnostico.fecha_emision 'Fecha Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 8 and alumno.estado= 'activo'", conector)
            Dim ds As New DataSet
            conector.Open()

            da.Fill(ds)
            DataGridView7.DataSource = ds.Tables(0)

            conector.Close()
            conector.Close()
        Catch es As Exception
            MsgBox(es)
        End Try

    End Sub

    Private Sub Button68_Click(sender As Object, e As EventArgs) Handles Button68.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button71_Click(sender As Object, e As EventArgs) Handles Button71.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button74_Click(sender As Object, e As EventArgs) Handles Button74.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button77_Click(sender As Object, e As EventArgs) Handles Button77.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button80_Click(sender As Object, e As EventArgs) Handles Button80.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button83_Click(sender As Object, e As EventArgs) Handles Button83.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button86_Click(sender As Object, e As EventArgs) Handles Button86.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button89_Click(sender As Object, e As EventArgs) Handles Button89.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button92_Click(sender As Object, e As EventArgs) Handles Button92.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button95_Click(sender As Object, e As EventArgs) Handles Button95.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        rut_para_data = ""
        tipo_ficha_para_data = ""
        Try
            rut_para_data = DataGridView1.Rows(e.RowIndex).Cells("Rut del Alumno").Value.ToString()
            fecha_emision_para_data = DataGridView1.Rows(e.RowIndex).Cells("Fecha Diagnostico").Value.ToString()
            tipo_ficha_para_data = DataGridView1.Rows(e.RowIndex).Cells("Nombre Diagnostico").Value.ToString()
        Catch
        End Try
    End Sub

    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Button67.Click

    End Sub
    Sub funcion_id_tipo()
        conector.Close()
        conector.Open()
        Dim qry As String = "select tipo_ficha.id_tipo from tipo_ficha where nombre_tipo ='" & tipo_ficha_para_data & "'"
        Dim sqlcmd As New SqlCommand(qry, conector)
        Dim dr As SqlDataReader
        dr = sqlcmd.ExecuteReader
        If dr.Read() Then

            IdTipoFicha = dr("id_tipo")
            conector.Close()

            conector.Close()
        End If

    End Sub
    Private Sub Button69_Click(sender As Object, e As EventArgs) Handles Button69.Click
        funcion_id_tipo()
        conector.Close()
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
            conector.Open()
            Dim qry As String = "select ficha_diagnostico.id_tipoficha , ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" & rut_para_data & "'  and ficha_diagnostico.fecha_emision = '" & fecha_emision_para_data & "' and ficha_diagnostico.id_tipoficha = " & IdTipoFicha & "
  
"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                IdTipoFicha = dr("id_tipoficha")
                Label55.Text = dr("numero_estudiante")
                Label72.Text = dr("apellido_paterno")
                Label73.Text = dr("apellido_materno")
                Label74.Text = dr("nombres_alumno")
                Label75.Text = dr("fecha_nacimiento")
                Label76.Text = dr("rut_alumno")
                RutDelAlumno = dr("rut_alumno")
                Label77.Text = dr("sexo_alumno")
                Label100.Text = dr("nacionalidad_alumno")
                Label78.Text = dr("nombre")
                TextBox44.Text = dr("nuevo_ingreso")
                Label80.Text = dr("continuidad")
                TextBox34.Text = dr("diagnostico")
                TextBox46.Text = dr("sindrome_asociado_diagnostico")
                TextBox47.Text = dr("observaciones_salud")
                Label84.Text = dr("fecha_emision")
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

                Label85.Text = rut_evaluador_1 + " " + nombre_evaluador_1 + "  " + profesion_evaluador_1 + vbCr + rut_evaluador_2 + " " + nombre_evaluador_2 + "  " + profesion_evaluador_2 + vbCr + rut_evaluador_3 + " " + nombre_evaluador_3 + "  " + profesion_evaluador_3 + vbCr + rut_evaluador_4 + " " + nombre_evaluador_4 + "  " + profesion_evaluador_4 + vbCr + rut_evaluador_5 + " " + nombre_evaluador_5 + "  " + profesion_evaluador_5
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

                Label86.Text = "prueba 1   " + pruebax_1 + "  puntaje   " + puntajex_1 + vbCr + "prueba 2   " + pruebax_2 + "  puntaje   " + puntajex_2 + vbCr + "prueba 3   " + pruebax_3 + "  puntaje   " + puntajex_3 + vbCr + "prueba 4   " + pruebax_4 + "  puntaje   " + puntajex_4 + vbCr + "prueba 5     " + pruebax_5 + "  puntaje   " + puntajex_5
                rut_apoyo_1 = dr("rut_apoyo_1")
                nombre_apoyo_1 = dr("nombre_apoyo_1")

                rut_apoyo_2 = dr("rut_apoyo_2")
                nombre_apoyo_2 = dr("nombre_apoyo_2")

                rut_apoyo_3 = dr("rut_apoyo_3")
                nombre_apoyo_3 = dr("nombre_apoyo_3")

                rut_apoyo_4 = dr("rut_apoyo_4")
                nombre_apoyo_4 = dr("nombre_apoyo_4")

                Label87.Text = rut_apoyo_1 + "   " + nombre_apoyo_1 + vbCr + rut_apoyo_2 + "   " + nombre_apoyo_2 + vbCr + rut_apoyo_3 + "   " + nombre_apoyo_3 + vbCr + rut_apoyo_4 + "   " + nombre_apoyo_4

                conector.Close()

                TabControl1.SelectedTab = TabControl1.TabPages.Item(11)

                Button35.Visible = True
                Button36.Visible = False

            Else

                MsgBox("INTENTE NUEVAMENTE", MsgBoxStyle.Critical, "Atencion")
            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

        rut_para_data = ""
        tipo_ficha_para_data = ""
        Try
            rut_para_data = DataGridView2.Rows(e.RowIndex).Cells("Rut del Alumno").Value.ToString()
            fecha_emision_para_data = DataGridView2.Rows(e.RowIndex).Cells("Fecha Diagnostico").Value.ToString()
            tipo_ficha_para_data = DataGridView2.Rows(e.RowIndex).Cells("Nombre Diagnostico").Value.ToString()
        Catch
        End Try
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        rut_para_data = ""
        tipo_ficha_para_data = ""
        Try
            rut_para_data = DataGridView3.Rows(e.RowIndex).Cells("Rut del Alumno").Value.ToString()
            fecha_emision_para_data = DataGridView3.Rows(e.RowIndex).Cells("Fecha Diagnostico").Value.ToString()
            tipo_ficha_para_data = DataGridView3.Rows(e.RowIndex).Cells("Nombre Diagnostico").Value.ToString()
        Catch
        End Try
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        rut_para_data = ""
        tipo_ficha_para_data = ""
        Try
            rut_para_data = DataGridView4.Rows(e.RowIndex).Cells("Rut del Alumno").Value.ToString()
            fecha_emision_para_data = DataGridView4.Rows(e.RowIndex).Cells("Fecha Diagnostico").Value.ToString()
            tipo_ficha_para_data = DataGridView4.Rows(e.RowIndex).Cells("Nombre Diagnostico").Value.ToString()
        Catch
        End Try
    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        rut_para_data = ""
        tipo_ficha_para_data = ""
        Try
            rut_para_data = DataGridView5.Rows(e.RowIndex).Cells("Rut del Alumno").Value.ToString()
            fecha_emision_para_data = DataGridView5.Rows(e.RowIndex).Cells("Fecha Diagnostico").Value.ToString()
            tipo_ficha_para_data = DataGridView5.Rows(e.RowIndex).Cells("Nombre Diagnostico").Value.ToString()
        Catch
        End Try
    End Sub

    Private Sub DataGridView11_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView11.CellContentClick
        rut_para_data = ""
        tipo_ficha_para_data = ""
        Try
            rut_para_data = DataGridView11.Rows(e.RowIndex).Cells("Rut del Alumno").Value.ToString()
            fecha_emision_para_data = DataGridView11.Rows(e.RowIndex).Cells("Fecha Diagnostico").Value.ToString()
            tipo_ficha_para_data = DataGridView11.Rows(e.RowIndex).Cells("Nombre Diagnostico").Value.ToString()
        Catch
        End Try
    End Sub

    Private Sub DataGridView6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView6.CellContentClick
        rut_para_data = ""
        tipo_ficha_para_data = ""
        Try
            rut_para_data = DataGridView6.Rows(e.RowIndex).Cells("Rut del Alumno").Value.ToString()
            fecha_emision_para_data = DataGridView6.Rows(e.RowIndex).Cells("Fecha Diagnostico").Value.ToString()
            tipo_ficha_para_data = DataGridView6.Rows(e.RowIndex).Cells("Nombre Diagnostico").Value.ToString()
        Catch
        End Try
    End Sub

    Private Sub DataGridView7_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView7.CellContentClick
        rut_para_data = ""
        tipo_ficha_para_data = ""
        Try
            rut_para_data = DataGridView7.Rows(e.RowIndex).Cells("Rut del Alumno").Value.ToString()
            fecha_emision_para_data = DataGridView7.Rows(e.RowIndex).Cells("Fecha Diagnostico").Value.ToString()
            tipo_ficha_para_data = DataGridView7.Rows(e.RowIndex).Cells("Nombre Diagnostico").Value.ToString()
        Catch
        End Try
    End Sub

    Private Sub DataGridView8_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView8.CellContentClick
        rut_para_data = ""
        tipo_ficha_para_data = ""
        Try
            rut_para_data = DataGridView8.Rows(e.RowIndex).Cells("Rut del Alumno").Value.ToString()
            fecha_emision_para_data = DataGridView8.Rows(e.RowIndex).Cells("Fecha Diagnostico").Value.ToString()
            tipo_ficha_para_data = DataGridView8.Rows(e.RowIndex).Cells("Nombre Diagnostico").Value.ToString()
        Catch
        End Try
    End Sub

    Private Sub DataGridView9_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView9.CellContentClick
        rut_para_data = ""
        tipo_ficha_para_data = ""
        Try
            rut_para_data = DataGridView9.Rows(e.RowIndex).Cells("Rut del Alumno").Value.ToString()
            fecha_emision_para_data = DataGridView9.Rows(e.RowIndex).Cells("Fecha Diagnostico").Value.ToString()
            tipo_ficha_para_data = DataGridView9.Rows(e.RowIndex).Cells("Nombre Diagnostico").Value.ToString()
        Catch
        End Try
    End Sub

    Private Sub Button94_Click(sender As Object, e As EventArgs) Handles Button94.Click
        funcion_id_tipo()
        conector.Close()
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
            conector.Open()
            Dim qry As String = "select ficha_diagnostico.id_tipoficha , ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" & rut_para_data & "'  and ficha_diagnostico.fecha_emision = '" & fecha_emision_para_data & "' and ficha_diagnostico.id_tipoficha = " & IdTipoFicha & "
  
"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                IdTipoFicha = dr("id_tipoficha")
                Label55.Text = dr("numero_estudiante")
                Label72.Text = dr("apellido_paterno")
                Label73.Text = dr("apellido_materno")
                Label74.Text = dr("nombres_alumno")
                Label75.Text = dr("fecha_nacimiento")
                Label76.Text = dr("rut_alumno")
                RutDelAlumno = dr("rut_alumno")
                Label77.Text = dr("sexo_alumno")
                Label100.Text = dr("nacionalidad_alumno")
                Label78.Text = dr("nombre")
                TextBox44.Text = dr("nuevo_ingreso")
                Label80.Text = dr("continuidad")
                TextBox34.Text = dr("diagnostico")
                TextBox46.Text = dr("sindrome_asociado_diagnostico")
                TextBox47.Text = dr("observaciones_salud")
                Label84.Text = dr("fecha_emision")
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

                Label85.Text = rut_evaluador_1 + " " + nombre_evaluador_1 + "  " + profesion_evaluador_1 + vbCr + rut_evaluador_2 + " " + nombre_evaluador_2 + "  " + profesion_evaluador_2 + vbCr + rut_evaluador_3 + " " + nombre_evaluador_3 + "  " + profesion_evaluador_3 + vbCr + rut_evaluador_4 + " " + nombre_evaluador_4 + "  " + profesion_evaluador_4 + vbCr + rut_evaluador_5 + " " + nombre_evaluador_5 + "  " + profesion_evaluador_5
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

                Label86.Text = "prueba 1   " + pruebax_1 + "  puntaje   " + puntajex_1 + vbCr + "prueba 2   " + pruebax_2 + "  puntaje   " + puntajex_2 + vbCr + "prueba 3   " + pruebax_3 + "  puntaje   " + puntajex_3 + vbCr + "prueba 4   " + pruebax_4 + "  puntaje   " + puntajex_4 + vbCr + "prueba 5     " + pruebax_5 + "  puntaje   " + puntajex_5
                rut_apoyo_1 = dr("rut_apoyo_1")
                nombre_apoyo_1 = dr("nombre_apoyo_1")

                rut_apoyo_2 = dr("rut_apoyo_2")
                nombre_apoyo_2 = dr("nombre_apoyo_2")

                rut_apoyo_3 = dr("rut_apoyo_3")
                nombre_apoyo_3 = dr("nombre_apoyo_3")

                rut_apoyo_4 = dr("rut_apoyo_4")
                nombre_apoyo_4 = dr("nombre_apoyo_4")

                Label87.Text = rut_apoyo_1 + "   " + nombre_apoyo_1 + vbCr + rut_apoyo_2 + "   " + nombre_apoyo_2 + vbCr + rut_apoyo_3 + "   " + nombre_apoyo_3 + vbCr + rut_apoyo_4 + "   " + nombre_apoyo_4

                conector.Close()

                TabControl1.SelectedTab = TabControl1.TabPages.Item(11)


                Button35.Visible = True
                Button36.Visible = False

            Else

                MsgBox("INTENTE NUEVAMENTE", MsgBoxStyle.Critical, "Atencion")
            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub

    Private Sub Button91_Click(sender As Object, e As EventArgs) Handles Button91.Click
        funcion_id_tipo()
        conector.Close()
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
            conector.Open()
            Dim qry As String = "select ficha_diagnostico.id_tipoficha , ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" & rut_para_data & "'  and ficha_diagnostico.fecha_emision = '" & fecha_emision_para_data & "' and ficha_diagnostico.id_tipoficha = " & IdTipoFicha & "
  
"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                IdTipoFicha = dr("id_tipoficha")
                Label55.Text = dr("numero_estudiante")
                Label72.Text = dr("apellido_paterno")
                Label73.Text = dr("apellido_materno")
                Label74.Text = dr("nombres_alumno")
                Label75.Text = dr("fecha_nacimiento")
                Label76.Text = dr("rut_alumno")
                RutDelAlumno = dr("rut_alumno")
                Label77.Text = dr("sexo_alumno")
                Label100.Text = dr("nacionalidad_alumno")
                Label78.Text = dr("nombre")
                TextBox44.Text = dr("nuevo_ingreso")
                Label80.Text = dr("continuidad")
                TextBox34.Text = dr("diagnostico")
                TextBox46.Text = dr("sindrome_asociado_diagnostico")
                TextBox47.Text = dr("observaciones_salud")
                Label84.Text = dr("fecha_emision")
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

                Label85.Text = rut_evaluador_1 + " " + nombre_evaluador_1 + "  " + profesion_evaluador_1 + vbCr + rut_evaluador_2 + " " + nombre_evaluador_2 + "  " + profesion_evaluador_2 + vbCr + rut_evaluador_3 + " " + nombre_evaluador_3 + "  " + profesion_evaluador_3 + vbCr + rut_evaluador_4 + " " + nombre_evaluador_4 + "  " + profesion_evaluador_4 + vbCr + rut_evaluador_5 + " " + nombre_evaluador_5 + "  " + profesion_evaluador_5
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

                Label86.Text = "prueba 1   " + pruebax_1 + "  puntaje   " + puntajex_1 + vbCr + "prueba 2   " + pruebax_2 + "  puntaje   " + puntajex_2 + vbCr + "prueba 3   " + pruebax_3 + "  puntaje   " + puntajex_3 + vbCr + "prueba 4   " + pruebax_4 + "  puntaje   " + puntajex_4 + vbCr + "prueba 5     " + pruebax_5 + "  puntaje   " + puntajex_5
                rut_apoyo_1 = dr("rut_apoyo_1")
                nombre_apoyo_1 = dr("nombre_apoyo_1")

                rut_apoyo_2 = dr("rut_apoyo_2")
                nombre_apoyo_2 = dr("nombre_apoyo_2")

                rut_apoyo_3 = dr("rut_apoyo_3")
                nombre_apoyo_3 = dr("nombre_apoyo_3")

                rut_apoyo_4 = dr("rut_apoyo_4")
                nombre_apoyo_4 = dr("nombre_apoyo_4")

                Label87.Text = rut_apoyo_1 + "   " + nombre_apoyo_1 + vbCr + rut_apoyo_2 + "   " + nombre_apoyo_2 + vbCr + rut_apoyo_3 + "   " + nombre_apoyo_3 + vbCr + rut_apoyo_4 + "   " + nombre_apoyo_4

                conector.Close()

                TabControl1.SelectedTab = TabControl1.TabPages.Item(11)



                Button35.Visible = True
                Button36.Visible = False

            Else

                MsgBox("INTENTE NUEVAMENTE", MsgBoxStyle.Critical, "Atencion")
            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub

    Private Sub Button88_Click(sender As Object, e As EventArgs) Handles Button88.Click
        funcion_id_tipo()
        conector.Close()
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
            conector.Open()
            Dim qry As String = "select ficha_diagnostico.id_tipoficha , ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" & rut_para_data & "'  and ficha_diagnostico.fecha_emision = '" & fecha_emision_para_data & "' and ficha_diagnostico.id_tipoficha = " & IdTipoFicha & "
  
"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                IdTipoFicha = dr("id_tipoficha")
                Label55.Text = dr("numero_estudiante")
                Label72.Text = dr("apellido_paterno")
                Label73.Text = dr("apellido_materno")
                Label74.Text = dr("nombres_alumno")
                Label75.Text = dr("fecha_nacimiento")
                Label76.Text = dr("rut_alumno")
                RutDelAlumno = dr("rut_alumno")
                Label77.Text = dr("sexo_alumno")
                Label100.Text = dr("nacionalidad_alumno")
                Label78.Text = dr("nombre")
                TextBox44.Text = dr("nuevo_ingreso")
                Label80.Text = dr("continuidad")
                TextBox34.Text = dr("diagnostico")
                TextBox46.Text = dr("sindrome_asociado_diagnostico")
                TextBox47.Text = dr("observaciones_salud")
                Label84.Text = dr("fecha_emision")
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

                Label85.Text = rut_evaluador_1 + " " + nombre_evaluador_1 + "  " + profesion_evaluador_1 + vbCr + rut_evaluador_2 + " " + nombre_evaluador_2 + "  " + profesion_evaluador_2 + vbCr + rut_evaluador_3 + " " + nombre_evaluador_3 + "  " + profesion_evaluador_3 + vbCr + rut_evaluador_4 + " " + nombre_evaluador_4 + "  " + profesion_evaluador_4 + vbCr + rut_evaluador_5 + " " + nombre_evaluador_5 + "  " + profesion_evaluador_5
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

                Label86.Text = "prueba 1   " + pruebax_1 + "  puntaje   " + puntajex_1 + vbCr + "prueba 2   " + pruebax_2 + "  puntaje   " + puntajex_2 + vbCr + "prueba 3   " + pruebax_3 + "  puntaje   " + puntajex_3 + vbCr + "prueba 4   " + pruebax_4 + "  puntaje   " + puntajex_4 + vbCr + "prueba 5     " + pruebax_5 + "  puntaje   " + puntajex_5
                rut_apoyo_1 = dr("rut_apoyo_1")
                nombre_apoyo_1 = dr("nombre_apoyo_1")

                rut_apoyo_2 = dr("rut_apoyo_2")
                nombre_apoyo_2 = dr("nombre_apoyo_2")

                rut_apoyo_3 = dr("rut_apoyo_3")
                nombre_apoyo_3 = dr("nombre_apoyo_3")

                rut_apoyo_4 = dr("rut_apoyo_4")
                nombre_apoyo_4 = dr("nombre_apoyo_4")

                Label87.Text = rut_apoyo_1 + "   " + nombre_apoyo_1 + vbCr + rut_apoyo_2 + "   " + nombre_apoyo_2 + vbCr + rut_apoyo_3 + "   " + nombre_apoyo_3 + vbCr + rut_apoyo_4 + "   " + nombre_apoyo_4

                conector.Close()

                TabControl1.SelectedTab = TabControl1.TabPages.Item(11)



                Button35.Visible = True
                Button36.Visible = False

            Else

                MsgBox("INTENTE NUEVAMENTE", MsgBoxStyle.Critical, "Atencion")
            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub

    Private Sub Button85_Click(sender As Object, e As EventArgs) Handles Button85.Click
        funcion_id_tipo()
        conector.Close()
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
            conector.Open()
            Dim qry As String = "select ficha_diagnostico.id_tipoficha , ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" & rut_para_data & "'  and ficha_diagnostico.fecha_emision = '" & fecha_emision_para_data & "' and ficha_diagnostico.id_tipoficha = " & IdTipoFicha & "
  
"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                IdTipoFicha = dr("id_tipoficha")
                Label55.Text = dr("numero_estudiante")
                Label72.Text = dr("apellido_paterno")
                Label73.Text = dr("apellido_materno")
                Label74.Text = dr("nombres_alumno")
                Label75.Text = dr("fecha_nacimiento")
                Label76.Text = dr("rut_alumno")
                RutDelAlumno = dr("rut_alumno")
                Label77.Text = dr("sexo_alumno")
                Label100.Text = dr("nacionalidad_alumno")
                Label78.Text = dr("nombre")
                TextBox44.Text = dr("nuevo_ingreso")
                Label80.Text = dr("continuidad")
                TextBox34.Text = dr("diagnostico")
                TextBox46.Text = dr("sindrome_asociado_diagnostico")
                TextBox47.Text = dr("observaciones_salud")
                Label84.Text = dr("fecha_emision")
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

                Label85.Text = rut_evaluador_1 + " " + nombre_evaluador_1 + "  " + profesion_evaluador_1 + vbCr + rut_evaluador_2 + " " + nombre_evaluador_2 + "  " + profesion_evaluador_2 + vbCr + rut_evaluador_3 + " " + nombre_evaluador_3 + "  " + profesion_evaluador_3 + vbCr + rut_evaluador_4 + " " + nombre_evaluador_4 + "  " + profesion_evaluador_4 + vbCr + rut_evaluador_5 + " " + nombre_evaluador_5 + "  " + profesion_evaluador_5
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

                Label86.Text = "prueba 1   " + pruebax_1 + "  puntaje   " + puntajex_1 + vbCr + "prueba 2   " + pruebax_2 + "  puntaje   " + puntajex_2 + vbCr + "prueba 3   " + pruebax_3 + "  puntaje   " + puntajex_3 + vbCr + "prueba 4   " + pruebax_4 + "  puntaje   " + puntajex_4 + vbCr + "prueba 5     " + pruebax_5 + "  puntaje   " + puntajex_5
                rut_apoyo_1 = dr("rut_apoyo_1")
                nombre_apoyo_1 = dr("nombre_apoyo_1")

                rut_apoyo_2 = dr("rut_apoyo_2")
                nombre_apoyo_2 = dr("nombre_apoyo_2")

                rut_apoyo_3 = dr("rut_apoyo_3")
                nombre_apoyo_3 = dr("nombre_apoyo_3")

                rut_apoyo_4 = dr("rut_apoyo_4")
                nombre_apoyo_4 = dr("nombre_apoyo_4")

                Label87.Text = rut_apoyo_1 + "   " + nombre_apoyo_1 + vbCr + rut_apoyo_2 + "   " + nombre_apoyo_2 + vbCr + rut_apoyo_3 + "   " + nombre_apoyo_3 + vbCr + rut_apoyo_4 + "   " + nombre_apoyo_4

                conector.Close()

                TabControl1.SelectedTab = TabControl1.TabPages.Item(11)



                Button35.Visible = True
                Button36.Visible = False

            Else

                MsgBox("INTENTE NUEVAMENTE", MsgBoxStyle.Critical, "Atencion")
            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub

    Private Sub Button82_Click(sender As Object, e As EventArgs) Handles Button82.Click
        funcion_id_tipo()
        conector.Close()
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
            conector.Open()
            Dim qry As String = "select ficha_diagnostico.id_tipoficha , ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" & rut_para_data & "'  and ficha_diagnostico.fecha_emision = '" & fecha_emision_para_data & "' and ficha_diagnostico.id_tipoficha = " & IdTipoFicha & "
  
"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                IdTipoFicha = dr("id_tipoficha")
                Label55.Text = dr("numero_estudiante")
                Label72.Text = dr("apellido_paterno")
                Label73.Text = dr("apellido_materno")
                Label74.Text = dr("nombres_alumno")
                Label75.Text = dr("fecha_nacimiento")
                Label76.Text = dr("rut_alumno")
                RutDelAlumno = dr("rut_alumno")
                Label77.Text = dr("sexo_alumno")
                Label100.Text = dr("nacionalidad_alumno")
                Label78.Text = dr("nombre")
                TextBox44.Text = dr("nuevo_ingreso")
                Label80.Text = dr("continuidad")
                TextBox34.Text = dr("diagnostico")
                TextBox46.Text = dr("sindrome_asociado_diagnostico")
                TextBox47.Text = dr("observaciones_salud")
                Label84.Text = dr("fecha_emision")
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

                Label85.Text = rut_evaluador_1 + " " + nombre_evaluador_1 + "  " + profesion_evaluador_1 + vbCr + rut_evaluador_2 + " " + nombre_evaluador_2 + "  " + profesion_evaluador_2 + vbCr + rut_evaluador_3 + " " + nombre_evaluador_3 + "  " + profesion_evaluador_3 + vbCr + rut_evaluador_4 + " " + nombre_evaluador_4 + "  " + profesion_evaluador_4 + vbCr + rut_evaluador_5 + " " + nombre_evaluador_5 + "  " + profesion_evaluador_5
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

                Label86.Text = "prueba 1   " + pruebax_1 + "  puntaje   " + puntajex_1 + vbCr + "prueba 2   " + pruebax_2 + "  puntaje   " + puntajex_2 + vbCr + "prueba 3   " + pruebax_3 + "  puntaje   " + puntajex_3 + vbCr + "prueba 4   " + pruebax_4 + "  puntaje   " + puntajex_4 + vbCr + "prueba 5     " + pruebax_5 + "  puntaje   " + puntajex_5
                rut_apoyo_1 = dr("rut_apoyo_1")
                nombre_apoyo_1 = dr("nombre_apoyo_1")

                rut_apoyo_2 = dr("rut_apoyo_2")
                nombre_apoyo_2 = dr("nombre_apoyo_2")

                rut_apoyo_3 = dr("rut_apoyo_3")
                nombre_apoyo_3 = dr("nombre_apoyo_3")

                rut_apoyo_4 = dr("rut_apoyo_4")
                nombre_apoyo_4 = dr("nombre_apoyo_4")

                Label87.Text = rut_apoyo_1 + "   " + nombre_apoyo_1 + vbCr + rut_apoyo_2 + "   " + nombre_apoyo_2 + vbCr + rut_apoyo_3 + "   " + nombre_apoyo_3 + vbCr + rut_apoyo_4 + "   " + nombre_apoyo_4

                conector.Close()

                TabControl1.SelectedTab = TabControl1.TabPages.Item(11)



                Button35.Visible = True
                Button36.Visible = False

            Else

                MsgBox("INTENTE NUEVAMENTE", MsgBoxStyle.Critical, "Atencion")
            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub

    Private Sub Button79_Click(sender As Object, e As EventArgs) Handles Button79.Click
        funcion_id_tipo()
        conector.Close()
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
            conector.Open()
            Dim qry As String = "select ficha_diagnostico.id_tipoficha , ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" & rut_para_data & "'  and ficha_diagnostico.fecha_emision = '" & fecha_emision_para_data & "' and ficha_diagnostico.id_tipoficha = " & IdTipoFicha & "
  
"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                IdTipoFicha = dr("id_tipoficha")
                Label55.Text = dr("numero_estudiante")
                Label72.Text = dr("apellido_paterno")
                Label73.Text = dr("apellido_materno")
                Label74.Text = dr("nombres_alumno")
                Label75.Text = dr("fecha_nacimiento")
                Label76.Text = dr("rut_alumno")
                RutDelAlumno = dr("rut_alumno")
                Label77.Text = dr("sexo_alumno")
                Label100.Text = dr("nacionalidad_alumno")
                Label78.Text = dr("nombre")
                TextBox44.Text = dr("nuevo_ingreso")
                Label80.Text = dr("continuidad")
                TextBox34.Text = dr("diagnostico")
                TextBox46.Text = dr("sindrome_asociado_diagnostico")
                TextBox47.Text = dr("observaciones_salud")
                Label84.Text = dr("fecha_emision")
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

                Label85.Text = rut_evaluador_1 + " " + nombre_evaluador_1 + "  " + profesion_evaluador_1 + vbCr + rut_evaluador_2 + " " + nombre_evaluador_2 + "  " + profesion_evaluador_2 + vbCr + rut_evaluador_3 + " " + nombre_evaluador_3 + "  " + profesion_evaluador_3 + vbCr + rut_evaluador_4 + " " + nombre_evaluador_4 + "  " + profesion_evaluador_4 + vbCr + rut_evaluador_5 + " " + nombre_evaluador_5 + "  " + profesion_evaluador_5
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

                Label86.Text = "prueba 1   " + pruebax_1 + "  puntaje   " + puntajex_1 + vbCr + "prueba 2   " + pruebax_2 + "  puntaje   " + puntajex_2 + vbCr + "prueba 3   " + pruebax_3 + "  puntaje   " + puntajex_3 + vbCr + "prueba 4   " + pruebax_4 + "  puntaje   " + puntajex_4 + vbCr + "prueba 5     " + pruebax_5 + "  puntaje   " + puntajex_5
                rut_apoyo_1 = dr("rut_apoyo_1")
                nombre_apoyo_1 = dr("nombre_apoyo_1")

                rut_apoyo_2 = dr("rut_apoyo_2")
                nombre_apoyo_2 = dr("nombre_apoyo_2")

                rut_apoyo_3 = dr("rut_apoyo_3")
                nombre_apoyo_3 = dr("nombre_apoyo_3")

                rut_apoyo_4 = dr("rut_apoyo_4")
                nombre_apoyo_4 = dr("nombre_apoyo_4")

                Label87.Text = rut_apoyo_1 + "   " + nombre_apoyo_1 + vbCr + rut_apoyo_2 + "   " + nombre_apoyo_2 + vbCr + rut_apoyo_3 + "   " + nombre_apoyo_3 + vbCr + rut_apoyo_4 + "   " + nombre_apoyo_4

                conector.Close()

                TabControl1.SelectedTab = TabControl1.TabPages.Item(11)



                Button35.Visible = True
                Button36.Visible = False

            Else

                MsgBox("INTENTE NUEVAMENTE", MsgBoxStyle.Critical, "Atencion")
            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub

    Private Sub Button76_Click(sender As Object, e As EventArgs) Handles Button76.Click
        funcion_id_tipo()
        conector.Close()
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
            conector.Open()
            Dim qry As String = "select ficha_diagnostico.id_tipoficha , ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" & rut_para_data & "'  and ficha_diagnostico.fecha_emision = '" & fecha_emision_para_data & "' and ficha_diagnostico.id_tipoficha = " & IdTipoFicha & "
  
"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                IdTipoFicha = dr("id_tipoficha")
                Label55.Text = dr("numero_estudiante")
                Label72.Text = dr("apellido_paterno")
                Label73.Text = dr("apellido_materno")
                Label74.Text = dr("nombres_alumno")
                Label75.Text = dr("fecha_nacimiento")
                Label76.Text = dr("rut_alumno")
                RutDelAlumno = dr("rut_alumno")
                Label77.Text = dr("sexo_alumno")
                Label100.Text = dr("nacionalidad_alumno")
                Label78.Text = dr("nombre")
                TextBox44.Text = dr("nuevo_ingreso")
                Label80.Text = dr("continuidad")
                TextBox34.Text = dr("diagnostico")
                TextBox46.Text = dr("sindrome_asociado_diagnostico")
                TextBox47.Text = dr("observaciones_salud")
                Label84.Text = dr("fecha_emision")
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

                Label85.Text = rut_evaluador_1 + " " + nombre_evaluador_1 + "  " + profesion_evaluador_1 + vbCr + rut_evaluador_2 + " " + nombre_evaluador_2 + "  " + profesion_evaluador_2 + vbCr + rut_evaluador_3 + " " + nombre_evaluador_3 + "  " + profesion_evaluador_3 + vbCr + rut_evaluador_4 + " " + nombre_evaluador_4 + "  " + profesion_evaluador_4 + vbCr + rut_evaluador_5 + " " + nombre_evaluador_5 + "  " + profesion_evaluador_5
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

                Label86.Text = "prueba 1   " + pruebax_1 + "  puntaje   " + puntajex_1 + vbCr + "prueba 2   " + pruebax_2 + "  puntaje   " + puntajex_2 + vbCr + "prueba 3   " + pruebax_3 + "  puntaje   " + puntajex_3 + vbCr + "prueba 4   " + pruebax_4 + "  puntaje   " + puntajex_4 + vbCr + "prueba 5     " + pruebax_5 + "  puntaje   " + puntajex_5
                rut_apoyo_1 = dr("rut_apoyo_1")
                nombre_apoyo_1 = dr("nombre_apoyo_1")

                rut_apoyo_2 = dr("rut_apoyo_2")
                nombre_apoyo_2 = dr("nombre_apoyo_2")

                rut_apoyo_3 = dr("rut_apoyo_3")
                nombre_apoyo_3 = dr("nombre_apoyo_3")

                rut_apoyo_4 = dr("rut_apoyo_4")
                nombre_apoyo_4 = dr("nombre_apoyo_4")

                Label87.Text = rut_apoyo_1 + "   " + nombre_apoyo_1 + vbCr + rut_apoyo_2 + "   " + nombre_apoyo_2 + vbCr + rut_apoyo_3 + "   " + nombre_apoyo_3 + vbCr + rut_apoyo_4 + "   " + nombre_apoyo_4

                conector.Close()

                TabControl1.SelectedTab = TabControl1.TabPages.Item(11)


                Button35.Visible = True
                Button36.Visible = False

            Else

                MsgBox("INTENTE NUEVAMENTE", MsgBoxStyle.Critical, "Atencion")
            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub

    Private Sub Button73_Click(sender As Object, e As EventArgs) Handles Button73.Click
        funcion_id_tipo()
        conector.Close()
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
            conector.Open()
            Dim qry As String = "select ficha_diagnostico.id_tipoficha , ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" & rut_para_data & "'  and ficha_diagnostico.fecha_emision = '" & fecha_emision_para_data & "' and ficha_diagnostico.id_tipoficha = " & IdTipoFicha & "
  
"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                IdTipoFicha = dr("id_tipoficha")
                Label55.Text = dr("numero_estudiante")
                Label72.Text = dr("apellido_paterno")
                Label73.Text = dr("apellido_materno")
                Label74.Text = dr("nombres_alumno")
                Label75.Text = dr("fecha_nacimiento")
                Label76.Text = dr("rut_alumno")
                RutDelAlumno = dr("rut_alumno")
                Label77.Text = dr("sexo_alumno")
                Label100.Text = dr("nacionalidad_alumno")
                Label78.Text = dr("nombre")
                TextBox44.Text = dr("nuevo_ingreso")
                Label80.Text = dr("continuidad")
                TextBox34.Text = dr("diagnostico")
                TextBox46.Text = dr("sindrome_asociado_diagnostico")
                TextBox47.Text = dr("observaciones_salud")
                Label84.Text = dr("fecha_emision")
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

                Label85.Text = rut_evaluador_1 + " " + nombre_evaluador_1 + "  " + profesion_evaluador_1 + vbCr + rut_evaluador_2 + " " + nombre_evaluador_2 + "  " + profesion_evaluador_2 + vbCr + rut_evaluador_3 + " " + nombre_evaluador_3 + "  " + profesion_evaluador_3 + vbCr + rut_evaluador_4 + " " + nombre_evaluador_4 + "  " + profesion_evaluador_4 + vbCr + rut_evaluador_5 + " " + nombre_evaluador_5 + "  " + profesion_evaluador_5
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

                Label86.Text = "prueba 1   " + pruebax_1 + "  puntaje   " + puntajex_1 + vbCr + "prueba 2   " + pruebax_2 + "  puntaje   " + puntajex_2 + vbCr + "prueba 3   " + pruebax_3 + "  puntaje   " + puntajex_3 + vbCr + "prueba 4   " + pruebax_4 + "  puntaje   " + puntajex_4 + vbCr + "prueba 5     " + pruebax_5 + "  puntaje   " + puntajex_5
                rut_apoyo_1 = dr("rut_apoyo_1")
                nombre_apoyo_1 = dr("nombre_apoyo_1")

                rut_apoyo_2 = dr("rut_apoyo_2")
                nombre_apoyo_2 = dr("nombre_apoyo_2")

                rut_apoyo_3 = dr("rut_apoyo_3")
                nombre_apoyo_3 = dr("nombre_apoyo_3")

                rut_apoyo_4 = dr("rut_apoyo_4")
                nombre_apoyo_4 = dr("nombre_apoyo_4")

                Label87.Text = rut_apoyo_1 + "   " + nombre_apoyo_1 + vbCr + rut_apoyo_2 + "   " + nombre_apoyo_2 + vbCr + rut_apoyo_3 + "   " + nombre_apoyo_3 + vbCr + rut_apoyo_4 + "   " + nombre_apoyo_4

                conector.Close()

                TabControl1.SelectedTab = TabControl1.TabPages.Item(11)



                Button35.Visible = True
                Button36.Visible = False

            Else

                MsgBox("INTENTE NUEVAMENTE", MsgBoxStyle.Critical, "Atencion")
            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub

    Private Sub Button70_Click(sender As Object, e As EventArgs) Handles Button70.Click
        funcion_id_tipo()
        conector.Close()
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
            conector.Open()
            Dim qry As String = "select ficha_diagnostico.id_tipoficha , ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" & rut_para_data & "'  and ficha_diagnostico.fecha_emision = '" & fecha_emision_para_data & "' and ficha_diagnostico.id_tipoficha = " & IdTipoFicha & "
  
"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                IdTipoFicha = dr("id_tipoficha")
                Label55.Text = dr("numero_estudiante")
                Label72.Text = dr("apellido_paterno")
                Label73.Text = dr("apellido_materno")
                Label74.Text = dr("nombres_alumno")
                Label75.Text = dr("fecha_nacimiento")
                Label76.Text = dr("rut_alumno")
                RutDelAlumno = dr("rut_alumno")
                Label77.Text = dr("sexo_alumno")
                Label100.Text = dr("nacionalidad_alumno")
                Label78.Text = dr("nombre")
                TextBox44.Text = dr("nuevo_ingreso")
                Label80.Text = dr("continuidad")
                TextBox34.Text = dr("diagnostico")
                TextBox46.Text = dr("sindrome_asociado_diagnostico")
                TextBox47.Text = dr("observaciones_salud")
                Label84.Text = dr("fecha_emision")
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

                Label85.Text = rut_evaluador_1 + " " + nombre_evaluador_1 + "  " + profesion_evaluador_1 + vbCr + rut_evaluador_2 + " " + nombre_evaluador_2 + "  " + profesion_evaluador_2 + vbCr + rut_evaluador_3 + " " + nombre_evaluador_3 + "  " + profesion_evaluador_3 + vbCr + rut_evaluador_4 + " " + nombre_evaluador_4 + "  " + profesion_evaluador_4 + vbCr + rut_evaluador_5 + " " + nombre_evaluador_5 + "  " + profesion_evaluador_5
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

                Label86.Text = "prueba 1   " + pruebax_1 + "  puntaje   " + puntajex_1 + vbCr + "prueba 2   " + pruebax_2 + "  puntaje   " + puntajex_2 + vbCr + "prueba 3   " + pruebax_3 + "  puntaje   " + puntajex_3 + vbCr + "prueba 4   " + pruebax_4 + "  puntaje   " + puntajex_4 + vbCr + "prueba 5     " + pruebax_5 + "  puntaje   " + puntajex_5
                rut_apoyo_1 = dr("rut_apoyo_1")
                nombre_apoyo_1 = dr("nombre_apoyo_1")

                rut_apoyo_2 = dr("rut_apoyo_2")
                nombre_apoyo_2 = dr("nombre_apoyo_2")

                rut_apoyo_3 = dr("rut_apoyo_3")
                nombre_apoyo_3 = dr("nombre_apoyo_3")

                rut_apoyo_4 = dr("rut_apoyo_4")
                nombre_apoyo_4 = dr("nombre_apoyo_4")

                Label87.Text = rut_apoyo_1 + "   " + nombre_apoyo_1 + vbCr + rut_apoyo_2 + "   " + nombre_apoyo_2 + vbCr + rut_apoyo_3 + "   " + nombre_apoyo_3 + vbCr + rut_apoyo_4 + "   " + nombre_apoyo_4

                conector.Close()

                TabControl1.SelectedTab = TabControl1.TabPages.Item(11)


                Button35.Visible = True
                Button36.Visible = False


            Else

                MsgBox("INTENTE NUEVAMENTE", MsgBoxStyle.Critical, "Atencion")
            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub

    Private Sub Button97_Click(sender As Object, e As EventArgs) Handles Button97.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
        TipoBuscador.Show()
        TipoBuscador.Enabled = True
        Me.Enabled = False


    End Sub
    Sub funcion_update_ficha_diagnostico()

        conector.Close()
        Try

            Dim cadena As String
            cadena = String.Format("UPDATE ficha_diagnostico SET id_evaluador_1 = " & IdEvaluador1 & " , id_evaluador_2 = " & IdEvaluador2 & " , id_evaluador_3 = " & IdEvaluador3 & " ,id_evaluador_4 = " & IdEvaluador4 & " ,id_evaluador_5 = " & IdEvaluador5 & " , id_apoyo_1 = " & IdApoyo1 & " ,  id_apoyo_2 = " & IdApoyo2 & " ,  id_apoyo_3 = " & IdApoyo3 & " ,  id_apoyo_4 = " & IdApoyo4 & " , id_tipoficha = " & IdTipoFicha & " , curso_alumno = " & idCurso & " , nuevo_ingreso = '" & ConcatenoDeNuevoIngreso & "' , diagnostico = '" & TextBox20.Text & "' , sindrome_asociado_diagnostico = '" & ConcatenoDeSindromeAsociadoAlDiagnostico & "' , observaciones_salud = '" & TextBox22.Text & "' , prueba_1 = '" & TextBox23.Text & "' , puntaje_1 = '" & TextBox24.Text & "' , prueba_2 = '" & TextBox26.Text & "' , puntaje_2 = '" & TextBox25.Text & "' , prueba_3 = '" & TextBox28.Text & "' , puntaje_3 = '" & TextBox27.Text & "' , prueba_4 = '" & TextBox30.Text & "' , puntaje_4 = '" & TextBox29.Text & "' , prueba_5 = '" & TextBox32.Text & "' , puntaje_5 = '" & TextBox31.Text & "' , usuario = " & IdUsuario & "  , nombre_apoyo_1 = '" & ComboBox10.Text & "' , nombre_apoyo_2 = '" & ComboBox11.Text & "' , nombre_apoyo_3 = '" & ComboBox12.Text & "' , nombre_apoyo_4 = '" & ComboBox13.Text & "' , nombre_evaluador_1 = '" & ComboBox3.Text & "' , nombre_evaluador_2 = '" & ComboBox4.Text & "'  , nombre_evaluador_3 = '" & ComboBox5.Text & "' , nombre_evaluador_4 = '" & ComboBox6.Text & "' , nombre_evaluador_5 = '" & ComboBox7.Text & "' ,  numero_estudiante = " & TextBox33.Text & " , rut_evaluador_1 = '" & rut_ev_1 & "' , rut_evaluador_2 = '" & rut_ev_2 & "' , rut_evaluador_3 = '" & rut_ev_3 & "' , rut_evaluador_4 = '" & rut_ev_4 & "' , rut_evaluador_5 = '" & rut_ev_5 & "' , profesion_evaluador_1 = '" & profesion_ev_1 & "' , profesion_evaluador_2 = '" & profesion_ev_2 & "' , profesion_evaluador_3 = '" & profesion_ev_3 & "' , profesion_evaluador_4 = '" & profesion_ev_4 & "' , profesion_evaluador_5 = '" & profesion_ev_5 & "' , rut_apoyo_1 = '" & rut_apoyo_1 & "' , rut_apoyo_2 = '" & rut_apoyo_2 & "' , rut_apoyo_3 = '" & rut_apoyo_3 & "' , rut_apoyo_4 = '" & rut_apoyo_4 & "'  WHERE ficha_diagnostico.rut_alumno = '" & RutDelAlumno & "' and ficha_diagnostico.fecha_emision = '" & SeleccionRutTipoFicha.Fechaemi & "' and ficha_diagnostico.id_tipoficha = " & IdTipoFicha & "")
            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()
            conector.Close()

            MsgBox("FICHA MODIFICADA EXITOSAMENTE", MsgBoxStyle.Information, "Operacion Exitosa")
            conector.Close()

        Catch ex As Exception
            MsgBox("ERROR INTENTE DE NUEVO", MsgBoxStyle.Critical, "Alerta" & vbCrLf & ex.Message)
            conector.Close()
            conector.Close()
        End Try
        conector.Close()

    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        ObtenerIdApoyo()
        ObtenerIdEvaluador()
        funcion_update_ficha_diagnostico()
    End Sub


    Private Sub Button98_Click(sender As Object, e As EventArgs) Handles Button98.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        FormCitaciones.Show()
        FormCitaciones.Enabled = True
        Me.Enabled = False
        FormCitaciones.Button48.Visible = False
        FormCitaciones.Label5.Visible = False
    End Sub

    Private Sub Button99_Click(sender As Object, e As EventArgs) Handles Button99.Click
        FormEliminarAlumno.Enabled = True
        FormEliminarAlumno.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button100_Click(sender As Object, e As EventArgs) Handles Button100.Click

        CargarRutNombreContacto.Show()
        CargarRutNombreContacto.Enabled = True
        Me.Enabled = False
    End Sub

    Private Sub Button101_Click(sender As Object, e As EventArgs) Handles Button101.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button102_Click(sender As Object, e As EventArgs) Handles Button102.Click
        conector.Close()
        Dim fechadenacimiento As Date
        conector.Open()
        Dim qry As String = "select alumno.nombres_alumno, alumno.apellido_paterno, alumno.apellido_materno,alumno.fono_alumno, alumno.direccion_alumno , alumno.sexo_alumno , alumno.fecha_nacimiento , alumno.nacionalidad_alumno from alumno where alumno.rut_alumno='" & TextBox1.Text & "'"
        Dim sqlcmd As New SqlCommand(qry, conector)
        Dim dr As SqlDataReader
        dr = sqlcmd.ExecuteReader
        If dr.Read() Then

            TextBox2.Text = dr("nombres_alumno")
            TextBox4.Text = dr("apellido_paterno")
            TextBox3.Text = dr("apellido_materno")
            TextBox5.Text = dr("fono_alumno")
            TextBox6.Text = dr("direccion_alumno")
            ComboBox1.Text = dr("sexo_alumno")
            fechadenacimiento = dr("fecha_nacimiento")
            MonthCalendar1.SetDate(fechadenacimiento)

            ComboBox2.Text = dr("nacionalidad_alumno")

            conector.Close()
            conector.Close()

        Else

            MsgBox("Rut NO existe", MsgBoxStyle.Critical, "Alerta")
        End If
    End Sub

    Private Sub Button103_Click(sender As Object, e As EventArgs) Handles Button103.Click
        conector.Close()
        Dim fechadenacimiento As Date
        conector.Open()
        Dim qry As String = "select apoderado.nombre_apoderado, apoderado.fono_apoderado, apoderado.direccion_apoderado , apoderado.rut_fk_alumno from apoderado where apoderado.rut_apoderado='" & TextBox7.Text & "'"
        Dim sqlcmd As New SqlCommand(qry, conector)
        Dim dr As SqlDataReader
        dr = sqlcmd.ExecuteReader
        If dr.Read() Then

            TextBox8.Text = dr("nombre_apoderado")
            TextBox9.Text = dr("fono_apoderado")
            TextBox10.Text = dr("direccion_apoderado")
            ComboBox9.Text = dr("rut_fk_alumno")


            conector.Close()
            conector.Close()

        Else

            MsgBox("Rut NO existe", MsgBoxStyle.Critical, "Alerta")
        End If
    End Sub

    Private Sub Button104_Click(sender As Object, e As EventArgs) Handles Button104.Click
        conector.Close()
        Dim fechadenacimiento As Date
        conector.Open()
        Dim qry As String = "select profesional_apoyo.nombre_apoyo from profesional_apoyo where profesional_apoyo.rut_apoyo='" & TextBox12.Text & "'"
        Dim sqlcmd As New SqlCommand(qry, conector)
        Dim dr As SqlDataReader
        dr = sqlcmd.ExecuteReader
        If dr.Read() Then

            TextBox11.Text = dr("nombre_apoyo")

            conector.Close()

        Else

            MsgBox("Rut NO existe", MsgBoxStyle.Critical, "Alerta")
        End If
    End Sub

    Private Sub Button105_Click(sender As Object, e As EventArgs) Handles Button105.Click
        conector.Close()
        conector.Open()
        Dim qry As String = "select profesional_evaluador.nombre_evaluador, profesional_evaluador.profesion from profesional_evaluador where profesional_evaluador.rut_evaluador= '" & TextBox14.Text & "'"
        Dim sqlcmd As New SqlCommand(qry, conector)
        Dim dr As SqlDataReader
        dr = sqlcmd.ExecuteReader
        If dr.Read() Then

            TextBox13.Text = dr("nombre_evaluador")
            TextBox15.Text = dr("profesion")

            conector.Close()

        Else

            MsgBox("Rut NO existe", MsgBoxStyle.Critical, "Alerta")
        End If
    End Sub

    Private Sub Button106_Click(sender As Object, e As EventArgs) Handles Button106.Click
        conector.Close()
        Dim fechadenacimiento As Date
        conector.Open()
        Dim qry As String = "select tipo_ficha.descripcion_tipoficha from tipo_ficha where tipo_ficha.nombre_tipo ='" & TextBox17.Text & "'"
        Dim sqlcmd As New SqlCommand(qry, conector)
        Dim dr As SqlDataReader
        dr = sqlcmd.ExecuteReader
        If dr.Read() Then

            TextBox16.Text = dr("descripcion_tipoficha")

            conector.Close()

        Else

            MsgBox("No hay resultados con ese nombre", MsgBoxStyle.Critical, "Alerta")
        End If
    End Sub
End Class
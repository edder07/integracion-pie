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
            cadena = String.Format("INSERT INTO alumno VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox4.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & fecha_nacimiento & "','" & sexo & "','" & naci & "')")

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
            cadena = String.Format("INSERT INTO apoderado VALUES ('" & TextBox7.Text & "', '" & TextBox8.Text & "', '" & TextBox9.Text & "','" & TextBox10.Text & "')")

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
                Try
                    funcion_insert_apoderado()

                Catch ex As Exception
                    MsgBox("error" & vbCrLf & ex.Message)
                    conector.Close()
                End Try
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
            ConcatenoDeNuevoIngreso = "NO"
        End If
        If CheckBox6.Checked = True Then
            ConcatenoDeSindromeAsociadoAlDiagnostico = "SI " + TextBox21.Text
        End If
        If CheckBox5.Checked = True Then
            ConcatenoDeSindromeAsociadoAlDiagnostico = "NO"
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
            Dim qry As String = "select ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" & RutDelAlumno & "'  and ficha_diagnostico.fecha_emision = '" & MonthCalendar2.SelectionRange.Start & "'
  
"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

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

        Dim CrystalReport1 As New CrystalReport1
        Dim rut_para_crystal As New CrystalDecisions.Shared.ParameterDiscreteValue()
        Dim fecha_para_crystal As New CrystalDecisions.Shared.ParameterDiscreteValue()
        rut_para_crystal.Value = RutDelAlumno
        fecha_para_crystal.Value = MonthCalendar2.SelectionRange.Start.ToString("dd-MM-yyyy")

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
End Class
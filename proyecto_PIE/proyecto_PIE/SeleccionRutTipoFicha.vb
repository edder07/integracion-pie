Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class SeleccionRutTipoFicha

    Public NombreCompletoAlumno As String
    'Public id_de_tipoFicha As Integer

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
        Dim qry As String = "select alumno.rut_alumno from alumno"
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


    End Sub
End Class
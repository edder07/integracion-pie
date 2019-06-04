Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class CargarCurso
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



    Private Sub CargarCurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub

    Sub select_cargar_primero()
        conector.Close()
        Try


            Dim da As New SqlDataAdapter("select ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , ficha_diagnostico.fecha_emision 'Fecha Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 1", conector)
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

            Dim da As New SqlDataAdapter("select ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , ficha_diagnostico.fecha_emision 'Fecha Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 2", conector)
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

            Dim da As New SqlDataAdapter("select ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , ficha_diagnostico.fecha_emision 'Fecha Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 3", conector)
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

    Sub select_cargar_cuarto()
        conector.Close()
        Try

            Dim da As New SqlDataAdapter("select ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , ficha_diagnostico.fecha_emision 'Fecha Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 4", conector)
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
    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class
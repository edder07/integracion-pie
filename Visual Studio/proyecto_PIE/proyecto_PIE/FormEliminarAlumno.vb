Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class FormEliminarAlumno
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

    Private Sub FormEliminarAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarAlumno()
    End Sub
    Sub MostrarAlumno()

        conector.Close()
        conector.Open()
        Dim qry As String = "select DISTINCT alumno.rut_alumno from alumno , ficha_diagnostico where alumno.rut_alumno = ficha_diagnostico.rut_alumno and alumno.estado = 'activo' "
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        select_cargar_data()
    End Sub

    Sub select_cargar_data()
        conector.Close()

        Try

            Dim da As New SqlDataAdapter("select distinct ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.rut_alumno = '" & ComboBox1.Text & "'", conector)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        funcion_update_eliminar_alumno()
        MostrarAlumno()
    End Sub
    Sub funcion_update_eliminar_alumno()

        conector.Close()
        Try

            Dim cadena As String
            cadena = String.Format("update alumno set estado ='inactivo' where alumno.rut_alumno = '" & ComboBox1.Text & "'")
            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()
            conector.Close()

            MsgBox("FICHA MODIFICADA EXITOSAMENTE", MsgBoxStyle.Information, "Operacion Exitosa")
            conector.Close()

        Catch ex As Exception
            MsgBox("ERROR INTENTE DE NUEVO" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Alerta")
            conector.Close()
            conector.Close()
        End Try
        conector.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Menu_Principal.Enabled = True
        Menu_Principal.Show()
        Me.Close()
    End Sub
End Class
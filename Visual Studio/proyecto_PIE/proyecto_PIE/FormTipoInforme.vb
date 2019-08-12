Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class FormTipoInforme
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
    Private Sub FormTipoInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub curso_alumnos_primero()
        conector.Close()
        Try
            conector.Close()
            conector.Open()
            Dim qry As String = "SELECT count(distinct alumno.rut_alumno) as num  FROM curso , alumno , ficha_diagnostico where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.curso_alumno = '1' and alumno.estado = 'activo'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As Integer
            dr = sqlcmd.ExecuteScalar
            FormCursos.Button1.Text = "1° Basico" + vbCrLf + "(" + dr.ToString + " Alumnos)"
            conector.Close()
            conector.Close()
        Catch ex As Exception
            conector.Close()
            MsgBox("error fun" & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub curso_alumnos_segundo()
        conector.Close()
        Try
            conector.Close()
            conector.Open()
            Dim qry As String = "SELECT count(distinct alumno.rut_alumno) as num  FROM curso , alumno , ficha_diagnostico where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.curso_alumno = '2' and alumno.estado = 'activo'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As Integer
            dr = sqlcmd.ExecuteScalar
            FormCursos.Button2.Text = "2° Basico" + vbCrLf + "(" + dr.ToString + " Alumnos)"
            conector.Close()
            conector.Close()
        Catch ex As Exception
            conector.Close()
            MsgBox("error fun" & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub curso_alumnos_tercero()
        conector.Close()
        Try
            conector.Close()
            conector.Open()
            Dim qry As String = "SELECT count(distinct alumno.rut_alumno) as num  FROM curso , alumno , ficha_diagnostico where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.curso_alumno = '3' and alumno.estado = 'activo'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As Integer
            dr = sqlcmd.ExecuteScalar
            FormCursos.Button3.Text = "3° Basico" + vbCrLf + "(" + dr.ToString + " Alumnos)"
            conector.Close()
            conector.Close()
        Catch ex As Exception
            conector.Close()
            MsgBox("error fun" & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub curso_alumnos_cuarto()
        conector.Close()
        Try
            conector.Close()
            conector.Open()
            Dim qry As String = "SELECT count(distinct alumno.rut_alumno) as num  FROM curso , alumno , ficha_diagnostico where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.curso_alumno = '4' and alumno.estado = 'activo'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As Integer
            dr = sqlcmd.ExecuteScalar
            FormCursos.Button4.Text = "4° Basico" + vbCrLf + "(" + dr.ToString + " Alumnos)"
            conector.Close()
            conector.Close()
        Catch ex As Exception
            conector.Close()
            MsgBox("error fun" & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub curso_alumnos_quinto()
        conector.Close()
        Try
            conector.Close()
            conector.Open()
            Dim qry As String = "SELECT count(distinct alumno.rut_alumno) as num  FROM curso , alumno , ficha_diagnostico where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.curso_alumno = '5' and alumno.estado = 'activo'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As Integer
            dr = sqlcmd.ExecuteScalar
            FormCursos.Button7.Text = "5° Basico" + vbCrLf + "(" + dr.ToString + " Alumnos)"
            conector.Close()
            conector.Close()
        Catch ex As Exception
            conector.Close()
            MsgBox("error fun" & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub curso_alumnos_sexto()
        conector.Close()
        Try
            conector.Close()
            conector.Open()
            Dim qry As String = "SELECT count(distinct alumno.rut_alumno) as num  FROM curso , alumno , ficha_diagnostico where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.curso_alumno = '6' and alumno.estado = 'activo'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As Integer
            dr = sqlcmd.ExecuteScalar
            FormCursos.Button8.Text = "6° Basico" + vbCrLf + "(" + dr.ToString + " Alumnos)"
            conector.Close()
            conector.Close()
        Catch ex As Exception
            conector.Close()
            MsgBox("error fun" & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub curso_alumnos_septimo()
        conector.Close()
        Try
            conector.Close()
            conector.Open()
            Dim qry As String = "SELECT count(distinct alumno.rut_alumno) as num  FROM curso , alumno , ficha_diagnostico where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.curso_alumno = '7' and alumno.estado = 'activo'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As Integer
            dr = sqlcmd.ExecuteScalar
            FormCursos.Button9.Text = "7° Basico" + vbCrLf + "(" + dr.ToString + " Alumnos)"
            conector.Close()
            conector.Close()
        Catch ex As Exception
            conector.Close()
            MsgBox("error fun" & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub curso_alumnos_octavo()
        conector.Close()
        Try
            conector.Close()
            conector.Open()
            Dim qry As String = "SELECT count(distinct alumno.rut_alumno) as num  FROM curso , alumno , ficha_diagnostico where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.curso_alumno = '8' and alumno.estado = 'activo'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As Integer
            dr = sqlcmd.ExecuteScalar
            FormCursos.Button10.Text = "8° Basico" + vbCrLf + "(" + dr.ToString + " Alumnos)"
            conector.Close()
            conector.Close()
        Catch ex As Exception
            conector.Close()
            MsgBox("error fun" & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub curso_alumnos_kinder()
        conector.Close()
        Try
            conector.Close()
            conector.Open()
            Dim qry As String = "SELECT count(distinct alumno.rut_alumno) as num  FROM curso , alumno , ficha_diagnostico where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.curso_alumno = '9' and alumno.estado = 'activo'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As Integer
            dr = sqlcmd.ExecuteScalar
            FormCursos.Button5.Text = "KINDER" + vbCrLf + "(" + dr.ToString + " Alumnos)"
            conector.Close()
            conector.Close()
        Catch ex As Exception
            conector.Close()
            MsgBox("error fun" & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub curso_alumnos_prekinder()
        conector.Close()
        Try
            conector.Close()
            conector.Open()
            Dim qry As String = "SELECT count(distinct alumno.rut_alumno) as num  FROM curso , alumno , ficha_diagnostico where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.curso_alumno = '10' and alumno.estado = 'activo'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As Integer
            dr = sqlcmd.ExecuteScalar
            FormCursos.Button6.Text = "PRE-KINDER" + vbCrLf + "(" + dr.ToString + " Alumnos)"
            conector.Close()
            conector.Close()
        Catch ex As Exception
            conector.Close()
            MsgBox("error fun" & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Menu_Principal.Hide()
        curso_alumnos_primero()
        curso_alumnos_segundo()
        curso_alumnos_tercero()
        curso_alumnos_cuarto()
        curso_alumnos_quinto()
        curso_alumnos_sexto()
        curso_alumnos_septimo()
        curso_alumnos_octavo()
        curso_alumnos_kinder()
        curso_alumnos_prekinder()
        Me.Close()
        FormCursos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Menu_Principal.Hide()
        Me.Close()
        FormCursos.select_cargar_lista_completa()
        FormCursos.TabControl1.SelectedIndex = 11
        FormCursos.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Menu_Principal.Enabled = True
        Menu_Principal.Show()
        Me.Close()
    End Sub
End Class
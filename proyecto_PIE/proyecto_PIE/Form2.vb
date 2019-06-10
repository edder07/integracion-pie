Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class Form2
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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conector.Close()
        Try
            conector.Open()
            Dim qry As String = "select * from usuario where nombre_usuario = '" & txtuser.Text & "' and pass='" & txtpass.Text & "' and tipo_usuario = 'admin'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader


            If dr.Read() Then
                FormMenuUsuario.Show()
                Me.Hide()
                Form1.Hide()

                conector.Close()

                conector.Close()

            Else
                MsgBox("USUARIO o CONTRASEÑA Incorrecta", MsgBoxStyle.Critical, "Atencion")
                conector.Close()
            End If
            conector.Close()
        Catch ex As Exception
            conector.Close()
            MsgBox("error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Atencion")

        End Try
    End Sub

    Private Sub txtuser_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.Enter
        If txtuser.Text = "NOMBRE DE USUARIO" Then
            txtuser.Text = ""
            txtuser.ForeColor = Color.Black

        End If

    End Sub

    Private Sub txtuser_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.Leave
        If txtuser.Text = "" Then
            txtuser.Text = "NOMBRE DE USUARIO"


        End If
    End Sub


    Private Sub txtpass_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.Enter
        If txtpass.Text = "PASSWORD" Then
            txtpass.Text = ""

        End If
    End Sub

    Private Sub txtpass_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.Leave
        If txtpass.Text = "" Then
            txtpass.Text = "PASSWORD"

        End If
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class
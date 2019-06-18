Imports System.Runtime.InteropServices
Imports System.Data.SqlClient

Public Class Form1
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
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        strcon = "Provider=SQLOLEDB.1;Password=" & claveBD & ";Persist Security Info=True;User ID=" & usuarioBD & ";Initial Catalog=" & basededatos & ";Data Source=" & servidor & ""
        conector.Close()
    End Sub
    Private Shared Sub ReleaseCapture()
    End Sub
    Private Sub txtuser_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.Enter
        If txtuser.Text = "USUARIO" Then
            txtuser.Text = ""
            txtuser.ForeColor = Color.Black

        End If

    End Sub

    Private Sub txtuser_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.Leave
        If txtuser.Text = "" Then
            txtuser.Text = "USUARIO"
            txtuser.ForeColor = Color.LightGray

        End If
    End Sub


    Private Sub txtpass_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.Enter
        If txtpass.Text = "PASSWORD" Then
            txtpass.Text = ""
            txtpass.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtpass_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.Leave
        If txtpass.Text = "" Then
            txtpass.Text = "PASSWORD"
            txtpass.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub test_login_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Sub ObteneRIdUsuario()
        conector.Close()
        Try

            conector.Close()
            conector.Open()
            Dim qry As String = "select usuario.id_usuario from usuario where usuario.nombre_usuario = '" & txtuser.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then


                Menu_Principal.IdUsuario = dr("id_usuario")



                conector.Close()

            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
        conector.Close()
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        conector.Close()
        Dim nombre_para_label As String
        Try
            conector.Open()
            Dim qry As String = "select usuario.nombre_usuario , usuario.nombre_completo_usuario  from usuario where nombre_usuario = '" & txtuser.Text & "' and pass='" & txtpass.Text & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader


            If dr.Read() Then
                nombre_para_label = dr("nombre_completo_usuario")
                ObteneRIdUsuario()
                Menu_Principal.Show()
                Me.Hide()
                nomUsuario = txtuser.Text
                Menu_Principal.Label93.Text = "Bienvenido " + nombre_para_label

                conector.Close()
                conector.Close()


            Else
                MsgBox("Contraseña Incorrecta", MsgBoxStyle.Critical, "Atencion")
                conector.Close()
            End If
            conector.Close()
        Catch ex As Exception
            conector.Close()
            MsgBox("error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Atencion")

        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        End
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.txtpass.Text = "PASSWORD"
        Form2.txtuser.Text = "NOMBRE DE USUARIO"
        Form2.Show()
        Me.Enabled = False
    End Sub
End Class

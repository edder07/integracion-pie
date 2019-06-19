Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class CargarRutNombreContacto

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

    Dim rut_alumno_contacto As String

    Private Sub CargarRutNombreContacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        select_CargarDatosAluumnos_data()
    End Sub
    Sub select_CargarDatosAluumnos_data()
        conector.Close()

        Try

            Dim da As New SqlDataAdapter("select alumno.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombre Alumno' , alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno' from alumno where alumno.estado =  'activo'", conector)
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        rut_alumno_contacto = "-"
        Try
            rut_alumno_contacto = "-"
            rut_alumno_contacto = DataGridView1.Rows(e.RowIndex).Cells("Rut del Alumno").Value.ToString()

        Catch


        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim rut_alumno As String
        Dim nombre_alumno As String
        Dim apellido_paterno As String
        Dim apellido_materno As String
        Dim fono_alumno As String
        Dim direccion_alumno As String
        Dim rut_apoderado As String
        Dim nombre_apoderado As String
        Dim fono_apoderado As String
        Dim direccion_apoderado As String

        Try
            conector.Close()
            conector.Open()
            Dim qry As String = "select alumno.rut_alumno , alumno.nombres_alumno , alumno.apellido_paterno , alumno.apellido_materno , alumno.fono_alumno , alumno.direccion_alumno , apoderado.rut_apoderado , apoderado.nombre_apoderado , apoderado.direccion_apoderado , apoderado.fono_apoderado   from alumno, apoderado where alumno.rut_alumno = apoderado.rut_fk_alumno and alumno.estado = 'activo' and alumno.rut_alumno = '" & rut_alumno_contacto & "'"
            Dim sqlcmd As New SqlCommand(qry, conector)
            Dim dr As SqlDataReader
            dr = sqlcmd.ExecuteReader
            If dr.Read() Then

                rut_alumno = dr("rut_alumno")
                nombre_alumno = dr("nombres_alumno")
                apellido_paterno = dr("apellido_paterno")
                apellido_materno = dr("apellido_materno")
                fono_alumno = dr("fono_alumno")
                direccion_alumno = dr("direccion_alumno")
                rut_apoderado = dr("rut_apoderado")
                nombre_apoderado = dr("nombre_apoderado")
                direccion_apoderado = dr("direccion_apoderado")
                fono_apoderado = dr("fono_apoderado")

                Menu_Principal.Label97.Text = "Rut del Alumno:        " + rut_alumno
                Menu_Principal.Label98.Text = "Nombre Alumno:       " + nombre_alumno
                Menu_Principal.Label99.Text = "Apellido Paterno:       " + apellido_paterno
                Menu_Principal.Label102.Text = "Apellido Materno:      " + apellido_materno
                Menu_Principal.Label103.Text = "Fono de Alumno:       " + fono_alumno
                Menu_Principal.Label104.Text = "Direccion Alumno:      " + direccion_alumno
                Menu_Principal.Label106.Text = "Rut del Apoderado:     " + rut_apoderado
                Menu_Principal.Label107.Text = "Nombre Apoderado:    " + nombre_apoderado
                Menu_Principal.Label108.Text = "Fono Apoderado:         " + fono_apoderado
                Menu_Principal.Label109.Text = "Direccion Apoderado:   " + direccion_apoderado

                conector.Close()
                Menu_Principal.Enabled = True
                Menu_Principal.Show()

                Menu_Principal.TabControl1.SelectedIndex = 24
                rut_alumno_contacto = ""
                Me.Hide()


            Else

                MsgBox("INTENTE NUEVAMENTE", MsgBoxStyle.Critical, "Atencion")
            End If
        Catch ex As Exception
            MsgBox("error" & vbCrLf & ex.Message)

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Menu_Principal.Enabled = True
        Menu_Principal.Show()
        Me.Close()

    End Sub
End Class
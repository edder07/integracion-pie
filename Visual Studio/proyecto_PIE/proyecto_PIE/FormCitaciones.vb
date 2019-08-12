Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class FormCitaciones
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

    Dim servidorSQL As String

    Dim fecha_actual As Date
    Dim fecha_reunion As Date
    Dim hora As String

    Private Sub FormCitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub funcion_insert_citacion()
        conector.Close()
        hora = TextBox1.Text + Label4.Text + TextBox2.Text + " hrs"
        fecha_reunion = MonthCalendar1.SelectionRange.Start
        fecha_actual = DateTime.Now.ToString("dd/MM/yyyy")


        Dim mes_actual = DateTime.Now.ToString("MMMMMMMMMM")
        Dim año_actual = DateTime.Now.ToString("yyyy")
        Dim dia_actual = DateTime.Now.ToString(" dd")

        Dim fecha_completa_palabras = "Llancanao, " + dia_actual + " de " + mes_actual + " del " + año_actual



        Try
            conector.Close()

            Dim cadena As String
            cadena = String.Format("INSERT INTO citaciones (fecha_citacion , fecha_reunion , hora , autoridad , descripcion_fecha) values ('" & fecha_actual & "', '" & fecha_reunion & "', '" & hora & "', '" & ComboBox1.Text & "' , '" & fecha_completa_palabras & "')")

            Dim insertar As New SqlCommand(cadena, conector)
            conector.Open()
            insertar.ExecuteNonQuery()

            conector.Close()
            MsgBox("CITACION INGRESADA EXITOSAMENTE", MsgBoxStyle.Information, "Operacion Exitosa")
            conector.Close()
            Button48.Visible = True
            Label5.Visible = True

        Catch ex As Exception
            MsgBox("Error Ingreso" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Atencion")

            conector.Close()
        End Try

    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click



        Dim CrystalReport2 As New CrystalReport2
        Dim fecha_actual_para_crystal As New CrystalDecisions.Shared.ParameterDiscreteValue()
        Dim fecha_reunion_para_crystal As New CrystalDecisions.Shared.ParameterDiscreteValue()
        fecha_actual_para_crystal.Value = fecha_actual
        fecha_reunion_para_crystal.Value = fecha_reunion

        CrystalReport2.SetParameterValue("@fecha_actual", fecha_actual_para_crystal)
        CrystalReport2.SetParameterValue("@fecha_reunion", fecha_reunion_para_crystal)
        Report2.ReportSource = CrystalReport2
        Report2.Zoom(70)




        CrystalReport2.DataSourceConnections(0).SetConnection(ipServidor, basededatos, usuarioBD, claveBD)
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)

    End Sub

    Private Sub Button36_Click_1(sender As Object, e As EventArgs) Handles Button36.Click

        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Error Ingreso verifique hora", MsgBoxStyle.Critical, "Atencion")

        Else
            If TextBox1.Text >= 21 Or TextBox1.Text < 0 Or TextBox2.Text >= 59 Or TextBox2.Text < 0 Then
                MsgBox("Error Ingreso verifique hora", MsgBoxStyle.Critical, "Atencion")


            Else
                funcion_insert_citacion()

            End If
        End If
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Menu_Principal.Show()
        Menu_Principal.TabControl1.SelectedIndex = 0
        Menu_Principal.Enabled = True
        Me.Close()
        Me.Hide()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
    Private Sub textbox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyData
            Case Keys.A To Keys.Z Or Keys.Space

                ' Números del 0 al 9

                e.SuppressKeyPress = True
        End Select
    End Sub
    Private Sub textbox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        Select Case e.KeyData
            Case Keys.A To Keys.Z Or Keys.Space

                ' Números del 0 al 9

                e.SuppressKeyPress = True
        End Select
    End Sub
End Class
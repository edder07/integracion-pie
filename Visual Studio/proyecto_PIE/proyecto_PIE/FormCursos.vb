Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class FormCursos
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

    Dim id_del_curso As Integer


    Private Sub FormCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub
    Sub select_cargar_primero()
        conector.Close()
        Try
            Dim da As New SqlDataAdapter("select distinct ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 1  and alumno.estado= 'activo'", conector)
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
            Dim da As New SqlDataAdapter("select distinct ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 2  and alumno.estado= 'activo'", conector)
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
            Dim da As New SqlDataAdapter("select distinct ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 3  and alumno.estado= 'activo'", conector)
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
            Dim da As New SqlDataAdapter("select distinct ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 4  and alumno.estado= 'activo'", conector)
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
            Dim da As New SqlDataAdapter("select distinct ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 5  and alumno.estado= 'activo'", conector)
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
            Dim da As New SqlDataAdapter("select distinct ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 6  and alumno.estado= 'activo'", conector)
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
    Sub select_cargar_septimo()
        conector.Close()
        Try
            Dim da As New SqlDataAdapter("select distinct ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 7 and alumno.estado= 'activo'", conector)
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
    Sub select_cargar_octavo()
        conector.Close()
        Try
            Dim da As New SqlDataAdapter("select distinct ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 8 and alumno.estado= 'activo'", conector)
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
    Sub select_cargar_kinder()
        conector.Close()
        Try
            Dim da As New SqlDataAdapter("select distinct ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 9 and alumno.estado= 'activo'", conector)
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
    Sub select_cargar_prekinder()
        conector.Close()
        Try
            Dim da As New SqlDataAdapter("select distinct ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = 10  and alumno.estado= 'activo'", conector)
            Dim ds As New DataSet
            conector.Open()
            da.Fill(ds)
            DataGridView10.DataSource = ds.Tables(0)
            conector.Close()
            conector.Close()
        Catch es As Exception
            MsgBox(es)
        End Try
    End Sub
    Sub select_cargar_lista_completa()
        conector.Close()
        Try
            Dim da As New SqlDataAdapter("select distinct ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , curso.nombre 'Curso Alumno' from ficha_diagnostico , alumno , curso , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = curso.id_curso and alumno.estado= 'activo'", conector)
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        select_cargar_primero()
        id_del_curso = 1
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub Button68_Click(sender As Object, e As EventArgs) Handles Button68.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        select_cargar_segundo()
        id_del_curso = 2
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        select_cargar_tercero()
        id_del_curso = 3
        TabControl1.SelectedTab = TabControl1.TabPages.Item(3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        select_cargar_cuarto()
        id_del_curso = 4
        TabControl1.SelectedTab = TabControl1.TabPages.Item(4)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        select_cargar_quinto()
        id_del_curso = 5
        TabControl1.SelectedTab = TabControl1.TabPages.Item(5)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        select_cargar_sexto()
        id_del_curso = 6
        TabControl1.SelectedTab = TabControl1.TabPages.Item(6)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        select_cargar_septimo()
        id_del_curso = 7
        TabControl1.SelectedTab = TabControl1.TabPages.Item(7)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        select_cargar_octavo()
        id_del_curso = 8
        TabControl1.SelectedTab = TabControl1.TabPages.Item(8)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        select_cargar_kinder()
        id_del_curso = 9
        TabControl1.SelectedTab = TabControl1.TabPages.Item(9)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        select_cargar_prekinder()
        id_del_curso = 10
        TabControl1.SelectedTab = TabControl1.TabPages.Item(10)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        FormTipoInforme.Enabled = True
        FormTipoInforme.Show()
        Menu_Principal.Enabled = False
        Me.Close()
        conector.Close()
    End Sub

    Private Sub TabPage11_Click(sender As Object, e As EventArgs) Handles TabPage11.Click

    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        FormTipoInforme.Enabled = True
        FormTipoInforme.Show()
        Menu_Principal.Enabled = False
        Me.Close()
        conector.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FormTipoInforme.Enabled = True
        FormTipoInforme.Show()
        Menu_Principal.Enabled = False
        Me.Close()
        conector.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
        conector.Close()
        conector.Close()
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click


        Dim CrystalReport3 As New CrystalReport3

        Report3.ReportSource = CrystalReport3
        Report3.Zoom(70)
        CrystalReport3.DataSourceConnections(0).SetConnection(ipServidor, basededatos, usuarioBD, claveBD)
        CrystalReport3.Refresh()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(12)
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(11)
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        Me.Close()
        Menu_Principal.Enabled = True
        Menu_Principal.Show()
    End Sub

    Private Sub Button69_Click(sender As Object, e As EventArgs) Handles Button69.Click

        Dim CrystalReport4 As New CrystalReport4
        Dim curso_para_crystal As New CrystalDecisions.Shared.ParameterDiscreteValue()

        curso_para_crystal.Value = id_del_curso

        CrystalReport4.SetParameterValue("@num_curso", curso_para_crystal)

        Report4.ReportSource = CrystalReport4
        Report4.Zoom(70)
        CrystalReport4.DataSourceConnections(0).SetConnection(ipServidor, basededatos, usuarioBD, claveBD)
        'CrystalReport4.Refresh()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Me.Close()
        Menu_Principal.Enabled = True
        Menu_Principal.Show()
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim CrystalReport4 As New CrystalReport4
        Dim curso_para_crystal As New CrystalDecisions.Shared.ParameterDiscreteValue()

        curso_para_crystal.Value = id_del_curso

        CrystalReport4.SetParameterValue("@num_curso", curso_para_crystal)

        Report4.ReportSource = CrystalReport4
        Report4.Zoom(70)
        CrystalReport4.DataSourceConnections(0).SetConnection(ipServidor, basededatos, usuarioBD, claveBD)
        'CrystalReport4.Refresh()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim CrystalReport4 As New CrystalReport4
        Dim curso_para_crystal As New CrystalDecisions.Shared.ParameterDiscreteValue()

        curso_para_crystal.Value = id_del_curso

        CrystalReport4.SetParameterValue("@num_curso", curso_para_crystal)

        Report4.ReportSource = CrystalReport4
        Report4.Zoom(70)
        CrystalReport4.DataSourceConnections(0).SetConnection(ipServidor, basededatos, usuarioBD, claveBD)
        'CrystalReport4.Refresh()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim CrystalReport4 As New CrystalReport4
        Dim curso_para_crystal As New CrystalDecisions.Shared.ParameterDiscreteValue()

        curso_para_crystal.Value = id_del_curso

        CrystalReport4.SetParameterValue("@num_curso", curso_para_crystal)

        Report4.ReportSource = CrystalReport4
        Report4.Zoom(70)
        CrystalReport4.DataSourceConnections(0).SetConnection(ipServidor, basededatos, usuarioBD, claveBD)
        'CrystalReport4.Refresh()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim CrystalReport4 As New CrystalReport4
        Dim curso_para_crystal As New CrystalDecisions.Shared.ParameterDiscreteValue()

        curso_para_crystal.Value = id_del_curso

        CrystalReport4.SetParameterValue("@num_curso", curso_para_crystal)

        Report4.ReportSource = CrystalReport4
        Report4.Zoom(70)
        CrystalReport4.DataSourceConnections(0).SetConnection(ipServidor, basededatos, usuarioBD, claveBD)
        'CrystalReport4.Refresh()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim CrystalReport4 As New CrystalReport4
        Dim curso_para_crystal As New CrystalDecisions.Shared.ParameterDiscreteValue()

        curso_para_crystal.Value = id_del_curso

        CrystalReport4.SetParameterValue("@num_curso", curso_para_crystal)

        Report4.ReportSource = CrystalReport4
        Report4.Zoom(70)
        CrystalReport4.DataSourceConnections(0).SetConnection(ipServidor, basededatos, usuarioBD, claveBD)
        'CrystalReport4.Refresh()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim CrystalReport4 As New CrystalReport4
        Dim curso_para_crystal As New CrystalDecisions.Shared.ParameterDiscreteValue()

        curso_para_crystal.Value = id_del_curso

        CrystalReport4.SetParameterValue("@num_curso", curso_para_crystal)

        Report4.ReportSource = CrystalReport4
        Report4.Zoom(70)
        CrystalReport4.DataSourceConnections(0).SetConnection(ipServidor, basededatos, usuarioBD, claveBD)
        'CrystalReport4.Refresh()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim CrystalReport4 As New CrystalReport4
        Dim curso_para_crystal As New CrystalDecisions.Shared.ParameterDiscreteValue()

        curso_para_crystal.Value = id_del_curso

        CrystalReport4.SetParameterValue("@num_curso", curso_para_crystal)

        Report4.ReportSource = CrystalReport4
        Report4.Zoom(70)
        CrystalReport4.DataSourceConnections(0).SetConnection(ipServidor, basededatos, usuarioBD, claveBD)
        'CrystalReport4.Refresh()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dim CrystalReport4 As New CrystalReport4
        Dim curso_para_crystal As New CrystalDecisions.Shared.ParameterDiscreteValue()

        curso_para_crystal.Value = id_del_curso

        CrystalReport4.SetParameterValue("@num_curso", curso_para_crystal)

        Report4.ReportSource = CrystalReport4
        Report4.Zoom(70)
        CrystalReport4.DataSourceConnections(0).SetConnection(ipServidor, basededatos, usuarioBD, claveBD)
        'CrystalReport4.Refresh()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Dim CrystalReport4 As New CrystalReport4
        Dim curso_para_crystal As New CrystalDecisions.Shared.ParameterDiscreteValue()

        curso_para_crystal.Value = id_del_curso

        CrystalReport4.SetParameterValue("@num_curso", curso_para_crystal)

        Report4.ReportSource = CrystalReport4
        Report4.Zoom(70)
        CrystalReport4.DataSourceConnections(0).SetConnection(ipServidor, basededatos, usuarioBD, claveBD)
        'CrystalReport4.Refresh()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(13)
    End Sub
End Class
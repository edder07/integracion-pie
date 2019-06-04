Public Class TipoBuscador
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Me.Close()
        CargarDiagnostico.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Menu_Principal.Show()
        Menu_Principal.TabControl1.SelectedIndex = 0
        Menu_Principal.Enabled = True
        Me.Close()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Me.Close()
        Menu_Principal.Enabled = True
        Menu_Principal.Hide()
        Menu_Principal.Close()
        CargarCursoPrimerCiclo.select_cargar_primero()
        CargarCursoPrimerCiclo.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Me.Close()
        CargarCursoPrimerCiclo.select_cargar_primero()
        CargarCursoPrimerCiclo.select_cargar_segundo()
        CargarCursoPrimerCiclo.select_cargar_tercero()
        CargarCursoPrimerCiclo.select_cargar_cuarto()
        CargarPorRut.Show()
    End Sub
End Class
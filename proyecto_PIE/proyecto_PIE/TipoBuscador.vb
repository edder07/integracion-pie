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
        CargarCurso.Show()
    End Sub
End Class
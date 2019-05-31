Public Class TipoEvaluacion

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Menu_Principal.Enabled = False
        SeleccionRutTipoFicha.Show()

        
        Me.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu_Principal.Enabled = False
        SeleccionRutTipoFicha.Show()
    End Sub
End Class
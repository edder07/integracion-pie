﻿Public Class TipoBuscador
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        CargarDiagnostico.Enabled = True
        CargarDiagnostico.Show()
        Menu_Principal.Enabled = False
        Me.Enabled = False
        Me.Hide()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click



        Menu_Principal.Enabled = True
        Menu_Principal.Show()
        Me.Close()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Menu_Principal.Enabled = True
        Menu_Principal.Show()
        Menu_Principal.TabControl1.SelectedIndex = 13
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        CargarPorRut.Show()
        Menu_Principal.Enabled = False
        Me.Enabled = False
        Me.Hide()

    End Sub
End Class
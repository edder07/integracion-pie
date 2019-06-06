Public Class TipoEvaluacion

    Sub limpiar_datos()
        Menu_Principal.TextBox33.Text = ""
        Menu_Principal.TextBox18.Text = ""
        Menu_Principal.TextBox19.Text = ""
        Menu_Principal.TextBox20.Text = ""
        Menu_Principal.TextBox21.Text = ""
        Menu_Principal.TextBox22.Text = ""
        Menu_Principal.TextBox23.Text = ""
        Menu_Principal.TextBox24.Text = ""
        Menu_Principal.TextBox25.Text = ""
        Menu_Principal.TextBox26.Text = ""
        Menu_Principal.TextBox27.Text = ""
        Menu_Principal.TextBox28.Text = ""
        Menu_Principal.TextBox29.Text = ""
        Menu_Principal.TextBox30.Text = ""
        Menu_Principal.TextBox31.Text = ""
        Menu_Principal.TextBox32.Text = ""

        Menu_Principal.ComboBox8.SelectedIndex = 0
        Menu_Principal.ComboBox3.SelectedIndex = 0
        Menu_Principal.ComboBox4.SelectedIndex = 0
        Menu_Principal.ComboBox5.SelectedIndex = 0
        Menu_Principal.ComboBox6.SelectedIndex = 0
        Menu_Principal.ComboBox7.SelectedIndex = 0
        Menu_Principal.ComboBox10.SelectedIndex = 0
        Menu_Principal.ComboBox11.SelectedIndex = 0
        Menu_Principal.ComboBox12.SelectedIndex = 0
        Menu_Principal.ComboBox13.SelectedIndex = 0
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        limpiar_datos()
        Menu_Principal.Enabled = False
        SeleccionRutTipoFicha.Show()
        SeleccionRutTipoFicha.Button1.Visible = True
        SeleccionRutTipoFicha.Button2.Visible = False
        Menu_Principal.Button36.Enabled = True
        Menu_Principal.Button35.Enabled = False

        Me.Close()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu_Principal.Enabled = False
        SeleccionRutTipoFicha.Show()
        SeleccionRutTipoFicha.Button1.Visible = False
        SeleccionRutTipoFicha.Button2.Visible = True

        Me.Close()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Menu_Principal.Show()
        Menu_Principal.TabControl1.SelectedIndex = 0
        Menu_Principal.Enabled = True
        Me.Close()
        Me.Hide()

    End Sub
End Class
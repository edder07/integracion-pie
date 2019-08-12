<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCitaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCitaciones))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button48 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Button53 = New System.Windows.Forms.Button()
        Me.Report2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(983, 561)
        Me.TabControl1.TabIndex = 178
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button36)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Button48)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.MonthCalendar1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(975, 535)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button36
        '
        Me.Button36.FlatAppearance.BorderSize = 0
        Me.Button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button36.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button36.Image = CType(resources.GetObject("Button36.Image"), System.Drawing.Image)
        Me.Button36.Location = New System.Drawing.Point(773, 261)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(109, 135)
        Me.Button36.TabIndex = 190
        Me.Button36.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Guardar"
        Me.Button36.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(743, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 21)
        Me.Label5.TabIndex = 188
        Me.Label5.Text = "Generar Citacion"
        '
        'Button48
        '
        Me.Button48.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button48.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button48.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button48.FlatAppearance.BorderSize = 5
        Me.Button48.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button48.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button48.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button48.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button48.ForeColor = System.Drawing.Color.DarkBlue
        Me.Button48.Image = CType(resources.GetObject("Button48.Image"), System.Drawing.Image)
        Me.Button48.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button48.Location = New System.Drawing.Point(764, 30)
        Me.Button48.Name = "Button48"
        Me.Button48.Size = New System.Drawing.Size(118, 122)
        Me.Button48.TabIndex = 187
        Me.Button48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button48.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button48.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(386, 222)
        Me.TextBox2.MaxLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(33, 22)
        Me.TextBox2.TabIndex = 186
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(365, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 21)
        Me.Label4.TabIndex = 185
        Me.Label4.Text = ":"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Equipo P.I.E.", "Profesora Diferencial", "Psicologo", "Asistente Social", "Fonoaudiologa", "Terapeuta Ocupacional", "Director del Establecimiento"})
        Me.ComboBox1.Location = New System.Drawing.Point(316, 294)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 27)
        Me.ComboBox1.TabIndex = 184
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(19, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 21)
        Me.Label3.TabIndex = 183
        Me.Label3.Text = "¿ Quien emite la Citacion ?"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(326, 222)
        Me.TextBox1.MaxLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(33, 22)
        Me.TextBox1.TabIndex = 182
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(19, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 21)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "Ingrese Hora de la Reunion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 21)
        Me.Label1.TabIndex = 180
        Me.Label1.Text = "Ingrese Fecha de la Reunion"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(316, 30)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 179
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label90)
        Me.TabPage2.Controls.Add(Me.Button53)
        Me.TabPage2.Controls.Add(Me.Report2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(975, 535)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label90
        '
        Me.Label90.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(27, 222)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(73, 28)
        Me.Label90.TabIndex = 84
        Me.Label90.Text = "Volver"
        '
        'Button53
        '
        Me.Button53.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button53.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button53.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button53.FlatAppearance.BorderSize = 5
        Me.Button53.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button53.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button53.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button53.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button53.ForeColor = System.Drawing.Color.DarkBlue
        Me.Button53.Image = CType(resources.GetObject("Button53.Image"), System.Drawing.Image)
        Me.Button53.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button53.Location = New System.Drawing.Point(8, 97)
        Me.Button53.Name = "Button53"
        Me.Button53.Size = New System.Drawing.Size(124, 122)
        Me.Button53.TabIndex = 83
        Me.Button53.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button53.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button53.UseVisualStyleBackColor = False
        '
        'Report2
        '
        Me.Report2.ActiveViewIndex = -1
        Me.Report2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Report2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Report2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Report2.Location = New System.Drawing.Point(148, 3)
        Me.Report2.Name = "Report2"
        Me.Report2.Size = New System.Drawing.Size(824, 529)
        Me.Report2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 27)
        Me.Panel1.TabIndex = 196
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(949, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'FormCitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(983, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCitaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCitaciones"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button36 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button48 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label90 As Label
    Friend WithEvents Button53 As Button
    Friend WithEvents Report2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

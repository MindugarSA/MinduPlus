<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SolicitudAlmuAdicional
    Inherits MetroFramework.Forms.MetroForm 'System.Windows.Forms.Form

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
        Me.panelCentral = New System.Windows.Forms.Panel()
        Me.MonthCalendar2 = New Pabo.Calendar.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_Fecha = New System.Windows.Forms.Label()
        Me.Txt_Fecha = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_ComentAlmNorm = New System.Windows.Forms.TextBox()
        Me.TB_AlmuerzoNormales = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tt_ComentAlmGcial = New System.Windows.Forms.TextBox()
        Me.Tb_Gerencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.panelCentral.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelCentral
        '
        Me.panelCentral.Controls.Add(Me.MonthCalendar2)
        Me.panelCentral.Controls.Add(Me.Label1)
        Me.panelCentral.Controls.Add(Me.Lbl_Fecha)
        Me.panelCentral.Controls.Add(Me.Txt_Fecha)
        Me.panelCentral.Controls.Add(Me.btnVolver)
        Me.panelCentral.Controls.Add(Me.Button1)
        Me.panelCentral.Controls.Add(Me.Label5)
        Me.panelCentral.Controls.Add(Me.TB_ComentAlmNorm)
        Me.panelCentral.Controls.Add(Me.TB_AlmuerzoNormales)
        Me.panelCentral.Controls.Add(Me.Label4)
        Me.panelCentral.Controls.Add(Me.Label3)
        Me.panelCentral.Controls.Add(Me.Tt_ComentAlmGcial)
        Me.panelCentral.Controls.Add(Me.Tb_Gerencia)
        Me.panelCentral.Controls.Add(Me.Label2)
        Me.panelCentral.Controls.Add(Me.MonthCalendar1)
        Me.panelCentral.Controls.Add(Me.TextBox1)
        Me.panelCentral.Location = New System.Drawing.Point(24, 75)
        Me.panelCentral.Name = "panelCentral"
        Me.panelCentral.Size = New System.Drawing.Size(1109, 483)
        Me.panelCentral.TabIndex = 12
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.ActiveMonth.Month = 6
        Me.MonthCalendar2.ActiveMonth.Year = 2017
        Me.MonthCalendar2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.None
        Me.MonthCalendar2.Culture = New System.Globalization.CultureInfo("es-CL")
        Me.MonthCalendar2.Footer.Align = Pabo.Calendar.mcTextAlign.Center
        Me.MonthCalendar2.Footer.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MonthCalendar2.Footer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar2.Footer.Text = "Hoy : "
        Me.MonthCalendar2.Footer.TextColor = System.Drawing.Color.White
        Me.MonthCalendar2.Header.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.MonthCalendar2.Header.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar2.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar2.ImageList = Nothing
        Me.MonthCalendar2.Location = New System.Drawing.Point(9, 40)
        Me.MonthCalendar2.MaxDate = New Date(2027, 6, 6, 12, 38, 9, 504)
        Me.MonthCalendar2.MinDate = New Date(2007, 6, 6, 12, 38, 9, 504)
        Me.MonthCalendar2.Month.BackgroundImage = Nothing
        Me.MonthCalendar2.Month.BorderStyles.Focus = System.Windows.Forms.ButtonBorderStyle.None
        Me.MonthCalendar2.Month.BorderStyles.Selected = System.Windows.Forms.ButtonBorderStyle.None
        Me.MonthCalendar2.Month.Colors.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MonthCalendar2.Month.Colors.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MonthCalendar2.Month.Colors.Focus.BackColor = System.Drawing.Color.LightSkyBlue
        Me.MonthCalendar2.Month.Colors.Focus.Border = System.Drawing.Color.Transparent
        Me.MonthCalendar2.Month.Colors.Selected.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.MonthCalendar2.Month.Colors.Selected.Date = System.Drawing.Color.White
        Me.MonthCalendar2.Month.Colors.Selected.Text = System.Drawing.Color.White
        Me.MonthCalendar2.Month.DateFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar2.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar2.Month.Transparency.Background = 0
        Me.MonthCalendar2.Month.Transparency.Text = 255
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.SelectionMode = Pabo.Calendar.mcSelectionMode.One
        Me.MonthCalendar2.Size = New System.Drawing.Size(370, 259)
        Me.MonthCalendar2.TabIndex = 24
        Me.MonthCalendar2.TodayColor = System.Drawing.Color.Gold
        Me.MonthCalendar2.Weekdays.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.MonthCalendar2.Weekdays.BorderColor = System.Drawing.Color.Transparent
        Me.MonthCalendar2.Weekdays.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar2.Weekdays.TextColor = System.Drawing.Color.White
        Me.MonthCalendar2.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(444, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "      Indique la Cantidad de almuerzos Especiales"
        '
        'Lbl_Fecha
        '
        Me.Lbl_Fecha.AutoSize = True
        Me.Lbl_Fecha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Fecha.Location = New System.Drawing.Point(691, 39)
        Me.Lbl_Fecha.Name = "Lbl_Fecha"
        Me.Lbl_Fecha.Size = New System.Drawing.Size(78, 21)
        Me.Lbl_Fecha.TabIndex = 23
        Me.Lbl_Fecha.Text = "Lbl_Fecha"
        '
        'Txt_Fecha
        '
        Me.Txt_Fecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Txt_Fecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Fecha.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Fecha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_Fecha.Location = New System.Drawing.Point(9, 6)
        Me.Txt_Fecha.Name = "Txt_Fecha"
        Me.Txt_Fecha.ReadOnly = True
        Me.Txt_Fecha.Size = New System.Drawing.Size(370, 22)
        Me.Txt_Fecha.TabIndex = 22
        Me.Txt_Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVolver.Image = Global.RRHH.My.Resources.Resources.home_shape_32
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnVolver.Location = New System.Drawing.Point(9, 310)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(131, 68)
        Me.btnVolver.TabIndex = 21
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Image = Global.RRHH.My.Resources.Resources.save_file_option24
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(649, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 68)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Grabar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(446, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 21)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Motivo"
        '
        'TB_ComentAlmNorm
        '
        Me.TB_ComentAlmNorm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_ComentAlmNorm.Location = New System.Drawing.Point(540, 147)
        Me.TB_ComentAlmNorm.MaxLength = 50
        Me.TB_ComentAlmNorm.Name = "TB_ComentAlmNorm"
        Me.TB_ComentAlmNorm.Size = New System.Drawing.Size(240, 29)
        Me.TB_ComentAlmNorm.TabIndex = 18
        '
        'TB_AlmuerzoNormales
        '
        Me.TB_AlmuerzoNormales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AlmuerzoNormales.Location = New System.Drawing.Point(540, 117)
        Me.TB_AlmuerzoNormales.MaxLength = 2
        Me.TB_AlmuerzoNormales.Name = "TB_AlmuerzoNormales"
        Me.TB_AlmuerzoNormales.Size = New System.Drawing.Size(39, 29)
        Me.TB_AlmuerzoNormales.TabIndex = 17
        Me.TB_AlmuerzoNormales.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(446, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 21)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Normales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(446, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Motivo"
        '
        'Tt_ComentAlmGcial
        '
        Me.Tt_ComentAlmGcial.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tt_ComentAlmGcial.Location = New System.Drawing.Point(540, 69)
        Me.Tt_ComentAlmGcial.MaxLength = 50
        Me.Tt_ComentAlmGcial.Name = "Tt_ComentAlmGcial"
        Me.Tt_ComentAlmGcial.Size = New System.Drawing.Size(240, 29)
        Me.Tt_ComentAlmGcial.TabIndex = 14
        '
        'Tb_Gerencia
        '
        Me.Tb_Gerencia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Gerencia.Location = New System.Drawing.Point(540, 39)
        Me.Tb_Gerencia.MaxLength = 2
        Me.Tb_Gerencia.Name = "Tb_Gerencia"
        Me.Tb_Gerencia.Size = New System.Drawing.Size(39, 29)
        Me.Tb_Gerencia.TabIndex = 13
        Me.Tb_Gerencia.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(446, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Gerenciales"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.MonthCalendar1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(852, 9)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox1.Location = New System.Drawing.Point(379, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(410, 22)
        Me.TextBox1.TabIndex = 25
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_SolicitudGerencial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1156, 583)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelCentral)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_SolicitudGerencial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Solicitud Almuerzo Adicional"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.panelCentral.ResumeLayout(False)
        Me.panelCentral.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelCentral As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_ComentAlmNorm As TextBox
    Friend WithEvents TB_AlmuerzoNormales As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Tt_ComentAlmGcial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Txt_Fecha As TextBox
    Friend WithEvents Tb_Gerencia As TextBox
    Friend WithEvents Lbl_Fecha As Label
    Friend WithEvents MonthCalendar2 As Pabo.Calendar.MonthCalendar
    Friend WithEvents TextBox1 As TextBox
End Class

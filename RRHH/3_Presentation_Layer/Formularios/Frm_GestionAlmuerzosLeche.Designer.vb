<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_GestionAlmuerzosLeche
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblEmpresaInformeHHEE = New System.Windows.Forms.Label()
        Me.BtnVolver2 = New System.Windows.Forms.Button()
        Me.btnAgregarSolicitud = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblModo = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.TxtEmpleado = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New MetroFramework.Controls.MetroLabel()
        Me.MonthCalendar2 = New Pabo.Calendar.MonthCalendar()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox5 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.Rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Modo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox3 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmpresaInformeHHEE
        '
        Me.lblEmpresaInformeHHEE.AutoSize = True
        Me.lblEmpresaInformeHHEE.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresaInformeHHEE.Location = New System.Drawing.Point(20, 16)
        Me.lblEmpresaInformeHHEE.Name = "lblEmpresaInformeHHEE"
        Me.lblEmpresaInformeHHEE.Size = New System.Drawing.Size(208, 30)
        Me.lblEmpresaInformeHHEE.TabIndex = 26
        Me.lblEmpresaInformeHHEE.Text = "Gestión de Almuerzos"
        '
        'BtnVolver2
        '
        Me.BtnVolver2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnVolver2.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BtnVolver2.FlatAppearance.BorderSize = 0
        Me.BtnVolver2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolver2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnVolver2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnVolver2.Image = Global.RRHH.My.Resources.Resources.home_shape64
        Me.BtnVolver2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnVolver2.Location = New System.Drawing.Point(5, 631)
        Me.BtnVolver2.Name = "BtnVolver2"
        Me.BtnVolver2.Size = New System.Drawing.Size(195, 80)
        Me.BtnVolver2.TabIndex = 49
        Me.BtnVolver2.Text = "Volver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Al Inicio"
        Me.BtnVolver2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnVolver2.UseVisualStyleBackColor = False
        '
        'btnAgregarSolicitud
        '
        Me.btnAgregarSolicitud.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnAgregarSolicitud.FlatAppearance.BorderSize = 0
        Me.btnAgregarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarSolicitud.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarSolicitud.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgregarSolicitud.Image = Global.RRHH.My.Resources.Resources.save_file_option64
        Me.btnAgregarSolicitud.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAgregarSolicitud.Location = New System.Drawing.Point(994, 626)
        Me.btnAgregarSolicitud.Name = "btnAgregarSolicitud"
        Me.btnAgregarSolicitud.Size = New System.Drawing.Size(194, 80)
        Me.btnAgregarSolicitud.TabIndex = 48
        Me.btnAgregarSolicitud.Text = "Guardar"
        Me.btnAgregarSolicitud.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAgregarSolicitud.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblModo)
        Me.Panel1.Controls.Add(Me.lblTipo)
        Me.Panel1.Controls.Add(Me.TxtEmpleado)
        Me.Panel1.Controls.Add(Me.lblCantidad)
        Me.Panel1.Controls.Add(Me.MonthCalendar2)
        Me.Panel1.Controls.Add(Me.MetroLabel8)
        Me.Panel1.Controls.Add(Me.MetroComboBox5)
        Me.Panel1.Controls.Add(Me.MetroGrid1)
        Me.Panel1.Controls.Add(Me.MetroLabel7)
        Me.Panel1.Controls.Add(Me.MetroComboBox3)
        Me.Panel1.Controls.Add(Me.MetroLabel5)
        Me.Panel1.Controls.Add(Me.btnAgregarSolicitud)
        Me.Panel1.Controls.Add(Me.BtnVolver2)
        Me.Panel1.Location = New System.Drawing.Point(20, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1216, 714)
        Me.Panel1.TabIndex = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1025, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 160)
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'lblModo
        '
        Me.lblModo.AutoSize = True
        Me.lblModo.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.lblModo.Location = New System.Drawing.Point(764, 213)
        Me.lblModo.Name = "lblModo"
        Me.lblModo.Size = New System.Drawing.Size(73, 30)
        Me.lblModo.TabIndex = 62
        Me.lblModo.Text = "Label2"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.lblTipo.Location = New System.Drawing.Point(764, 175)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(70, 30)
        Me.lblTipo.TabIndex = 61
        Me.lblTipo.Text = "Label1"
        '
        'TxtEmpleado
        '
        Me.TxtEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TxtEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmpleado.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtEmpleado.Location = New System.Drawing.Point(709, 94)
        Me.TxtEmpleado.Name = "TxtEmpleado"
        Me.TxtEmpleado.ReadOnly = True
        Me.TxtEmpleado.Size = New System.Drawing.Size(496, 22)
        Me.TxtEmpleado.TabIndex = 58
        Me.TxtEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(117, 605)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(62, 19)
        Me.lblCantidad.TabIndex = 57
        Me.lblCantidad.Text = "Cantidad"
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
        Me.MonthCalendar2.Location = New System.Drawing.Point(724, 303)
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
        Me.MonthCalendar2.Size = New System.Drawing.Size(464, 295)
        Me.MonthCalendar2.TabIndex = 56
        Me.MonthCalendar2.TodayColor = System.Drawing.Color.Gold
        Me.MonthCalendar2.Weekdays.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.MonthCalendar2.Weekdays.BorderColor = System.Drawing.Color.Transparent
        Me.MonthCalendar2.Weekdays.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar2.Weekdays.TextColor = System.Drawing.Color.White
        Me.MonthCalendar2.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(13, 53)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel8.TabIndex = 55
        Me.MetroLabel8.Text = "Departamento:"
        '
        'MetroComboBox5
        '
        Me.MetroComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MetroComboBox5.FormattingEnabled = True
        Me.MetroComboBox5.ItemHeight = 23
        Me.MetroComboBox5.Location = New System.Drawing.Point(117, 49)
        Me.MetroComboBox5.Name = "MetroComboBox5"
        Me.MetroComboBox5.Size = New System.Drawing.Size(304, 29)
        Me.MetroComboBox5.TabIndex = 54
        Me.MetroComboBox5.UseSelectable = True
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToOrderColumns = True
        Me.MetroGrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.MetroGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Rut, Me.Nombre, Me.Apellido, Me.Tipo, Me.Modo})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(117, 94)
        Me.MetroGrid1.MultiSelect = False
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid1.RowHeadersVisible = False
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(586, 504)
        Me.MetroGrid1.TabIndex = 53
        '
        'Rut
        '
        Me.Rut.DataPropertyName = "rut"
        Me.Rut.HeaderText = "Rut"
        Me.Rut.Name = "Rut"
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "apellido"
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.DisplayStyleForCurrentCellOnly = True
        Me.Tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'Modo
        '
        Me.Modo.DataPropertyName = "Modo"
        Me.Modo.DisplayStyleForCurrentCellOnly = True
        Me.Modo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modo.HeaderText = "Modo"
        Me.Modo.Name = "Modo"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(46, 18)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel7.TabIndex = 52
        Me.MetroLabel7.Text = "Empresa:"
        '
        'MetroComboBox3
        '
        Me.MetroComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MetroComboBox3.FormattingEnabled = True
        Me.MetroComboBox3.ItemHeight = 23
        Me.MetroComboBox3.Location = New System.Drawing.Point(117, 14)
        Me.MetroComboBox3.Name = "MetroComboBox3"
        Me.MetroComboBox3.Size = New System.Drawing.Size(304, 29)
        Me.MetroComboBox3.TabIndex = 51
        Me.MetroComboBox3.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(31, 98)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(77, 19)
        Me.MetroLabel5.TabIndex = 50
        Me.MetroLabel5.Text = "Empleados:"
        '
        'Frm_GestionAlmuerzosLeche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1258, 790)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblEmpresaInformeHHEE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_GestionAlmuerzosLeche"
        Me.Text = "Gestion de Almuerzos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmpresaInformeHHEE As Label
    Friend WithEvents BtnVolver2 As Button
    Friend WithEvents btnAgregarSolicitud As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox5 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox3 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MonthCalendar2 As Pabo.Calendar.MonthCalendar
    Friend WithEvents Rut As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewComboBoxColumn
    Friend WithEvents Modo As DataGridViewComboBoxColumn
    Friend WithEvents lblCantidad As MetroFramework.Controls.MetroLabel
    Friend WithEvents TxtEmpleado As TextBox
    Friend WithEvents lblModo As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

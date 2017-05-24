Partial Class Frm_InformePermisoPersona
	''' <summary>
	''' Variable del diseñador requerida.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Limpiar los recursos que se estén utilizando.
	''' </summary>
	''' <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Código generado por el Diseñador de Windows Forms"

	''' <summary>
	''' Método necesario para admitir el Diseñador. No se puede modificar
	''' el contenido del método con el editor de código.
	''' </summary>
	Private Sub InitializeComponent()
        Me.txbRutInformePermisos = New System.Windows.Forms.TextBox()
        Me.txbNombreInformePermisos = New System.Windows.Forms.TextBox()
        Me.lblRutInformePermisos = New System.Windows.Forms.Label()
        Me.lblNombreInformePermisos = New System.Windows.Forms.Label()
        Me.dgvSolicitudesSalidaInformePermisos = New System.Windows.Forms.DataGridView()
        Me.dtpTerminoInformePermisos = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpInicioInformePermisos = New System.Windows.Forms.DateTimePicker()
        Me.cmbEmpresaInformePermisos = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscarInformePermisos = New System.Windows.Forms.Button()
        Me.btnImprimirInformePermisos = New System.Windows.Forms.Button()
        Me.chkBuscarTodosInformePermisos = New System.Windows.Forms.CheckBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Pnl_InformePermisos = New System.Windows.Forms.Panel()
        Me.colNumeroSolicitudInformePermisos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTrabajadorInformePermisos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDepartamentoInformePermisos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCargoInformePermisos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaSalidaInformePermisos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiaCompletoInformePermisos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraSalidaInformePermisos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraEntradaInformePermisos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHorasTotalesInformePermisos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipoPermisoInformePermisos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvSolicitudesSalidaInformePermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_InformePermisos.SuspendLayout()
        Me.SuspendLayout()
        '
        'txbRutInformePermisos
        '
        Me.txbRutInformePermisos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txbRutInformePermisos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txbRutInformePermisos.Location = New System.Drawing.Point(516, 55)
        Me.txbRutInformePermisos.Name = "txbRutInformePermisos"
        Me.txbRutInformePermisos.Size = New System.Drawing.Size(269, 20)
        Me.txbRutInformePermisos.TabIndex = 21
        '
        'txbNombreInformePermisos
        '
        Me.txbNombreInformePermisos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txbNombreInformePermisos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txbNombreInformePermisos.Location = New System.Drawing.Point(516, 27)
        Me.txbNombreInformePermisos.Name = "txbNombreInformePermisos"
        Me.txbNombreInformePermisos.Size = New System.Drawing.Size(269, 20)
        Me.txbNombreInformePermisos.TabIndex = 20
        '
        'lblRutInformePermisos
        '
        Me.lblRutInformePermisos.AutoSize = True
        Me.lblRutInformePermisos.Location = New System.Drawing.Point(418, 55)
        Me.lblRutInformePermisos.Name = "lblRutInformePermisos"
        Me.lblRutInformePermisos.Size = New System.Drawing.Size(27, 13)
        Me.lblRutInformePermisos.TabIndex = 19
        Me.lblRutInformePermisos.Text = "Rut:"
        '
        'lblNombreInformePermisos
        '
        Me.lblNombreInformePermisos.AutoSize = True
        Me.lblNombreInformePermisos.Location = New System.Drawing.Point(418, 27)
        Me.lblNombreInformePermisos.Name = "lblNombreInformePermisos"
        Me.lblNombreInformePermisos.Size = New System.Drawing.Size(94, 13)
        Me.lblNombreInformePermisos.TabIndex = 18
        Me.lblNombreInformePermisos.Text = "Nombre Completo:"
        '
        'dgvSolicitudesSalidaInformePermisos
        '
        Me.dgvSolicitudesSalidaInformePermisos.AllowUserToAddRows = False
        Me.dgvSolicitudesSalidaInformePermisos.AllowUserToDeleteRows = False
        Me.dgvSolicitudesSalidaInformePermisos.AllowUserToOrderColumns = True
        Me.dgvSolicitudesSalidaInformePermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSolicitudesSalidaInformePermisos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNumeroSolicitudInformePermisos, Me.colTrabajadorInformePermisos, Me.colDepartamentoInformePermisos, Me.colCargoInformePermisos, Me.colFechaSalidaInformePermisos, Me.colDiaCompletoInformePermisos, Me.colHoraSalidaInformePermisos, Me.colHoraEntradaInformePermisos, Me.colHorasTotalesInformePermisos, Me.colTipoPermisoInformePermisos})
        Me.dgvSolicitudesSalidaInformePermisos.Location = New System.Drawing.Point(11, 135)
        Me.dgvSolicitudesSalidaInformePermisos.Name = "dgvSolicitudesSalidaInformePermisos"
        Me.dgvSolicitudesSalidaInformePermisos.Size = New System.Drawing.Size(1034, 396)
        Me.dgvSolicitudesSalidaInformePermisos.TabIndex = 17
        '
        'dtpTerminoInformePermisos
        '
        Me.dtpTerminoInformePermisos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTerminoInformePermisos.Location = New System.Drawing.Point(114, 83)
        Me.dtpTerminoInformePermisos.Name = "dtpTerminoInformePermisos"
        Me.dtpTerminoInformePermisos.Size = New System.Drawing.Size(91, 20)
        Me.dtpTerminoInformePermisos.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Empresa:"
        '
        'dtpInicioInformePermisos
        '
        Me.dtpInicioInformePermisos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicioInformePermisos.Location = New System.Drawing.Point(114, 48)
        Me.dtpInicioInformePermisos.Name = "dtpInicioInformePermisos"
        Me.dtpInicioInformePermisos.Size = New System.Drawing.Size(91, 20)
        Me.dtpInicioInformePermisos.TabIndex = 15
        '
        'cmbEmpresaInformePermisos
        '
        Me.cmbEmpresaInformePermisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpresaInformePermisos.FormattingEnabled = True
        Me.cmbEmpresaInformePermisos.Items.AddRange(New Object() {"Mindugar SA", "Mindugar Industrial", "Mindugar Montajes"})
        Me.cmbEmpresaInformePermisos.Location = New System.Drawing.Point(84, 20)
        Me.cmbEmpresaInformePermisos.Name = "cmbEmpresaInformePermisos"
        Me.cmbEmpresaInformePermisos.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmpresaInformePermisos.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Fecha Termino:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fecha Inicio:"
        '
        'btnBuscarInformePermisos
        '
        Me.btnBuscarInformePermisos.Location = New System.Drawing.Point(585, 599)
        Me.btnBuscarInformePermisos.Name = "btnBuscarInformePermisos"
        Me.btnBuscarInformePermisos.Size = New System.Drawing.Size(223, 40)
        Me.btnBuscarInformePermisos.TabIndex = 22
        Me.btnBuscarInformePermisos.Text = "Buscar"
        Me.btnBuscarInformePermisos.UseVisualStyleBackColor = True
        '
        'btnImprimirInformePermisos
        '
        Me.btnImprimirInformePermisos.Location = New System.Drawing.Point(814, 599)
        Me.btnImprimirInformePermisos.Name = "btnImprimirInformePermisos"
        Me.btnImprimirInformePermisos.Size = New System.Drawing.Size(231, 40)
        Me.btnImprimirInformePermisos.TabIndex = 23
        Me.btnImprimirInformePermisos.Text = "Imprimir"
        Me.btnImprimirInformePermisos.UseVisualStyleBackColor = True
        '
        'chkBuscarTodosInformePermisos
        '
        Me.chkBuscarTodosInformePermisos.AutoSize = True
        Me.chkBuscarTodosInformePermisos.Location = New System.Drawing.Point(308, 26)
        Me.chkBuscarTodosInformePermisos.Name = "chkBuscarTodosInformePermisos"
        Me.chkBuscarTodosInformePermisos.Size = New System.Drawing.Size(92, 17)
        Me.chkBuscarTodosInformePermisos.TabIndex = 24
        Me.chkBuscarTodosInformePermisos.Text = "Buscar Todos"
        Me.chkBuscarTodosInformePermisos.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(32, 561)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(201, 51)
        Me.btnVolver.TabIndex = 25
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Pnl_InformePermisos
        '
        Me.Pnl_InformePermisos.Controls.Add(Me.lblNombreInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.btnVolver)
        Me.Pnl_InformePermisos.Controls.Add(Me.Label2)
        Me.Pnl_InformePermisos.Controls.Add(Me.chkBuscarTodosInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.Label3)
        Me.Pnl_InformePermisos.Controls.Add(Me.btnImprimirInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.cmbEmpresaInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.btnBuscarInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.dtpInicioInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.txbRutInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.Label1)
        Me.Pnl_InformePermisos.Controls.Add(Me.txbNombreInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.dtpTerminoInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.lblRutInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.dgvSolicitudesSalidaInformePermisos)
        Me.Pnl_InformePermisos.Location = New System.Drawing.Point(12, -1)
        Me.Pnl_InformePermisos.Name = "Pnl_InformePermisos"
        Me.Pnl_InformePermisos.Size = New System.Drawing.Size(1057, 762)
        Me.Pnl_InformePermisos.TabIndex = 26
        '
        'colNumeroSolicitudInformePermisos
        '
        Me.colNumeroSolicitudInformePermisos.HeaderText = "N°"
        Me.colNumeroSolicitudInformePermisos.Name = "colNumeroSolicitudInformePermisos"
        Me.colNumeroSolicitudInformePermisos.ReadOnly = True
        Me.colNumeroSolicitudInformePermisos.Width = 30
        '
        'colTrabajadorInformePermisos
        '
        Me.colTrabajadorInformePermisos.HeaderText = "Trabajador"
        Me.colTrabajadorInformePermisos.Name = "colTrabajadorInformePermisos"
        Me.colTrabajadorInformePermisos.ReadOnly = True
        Me.colTrabajadorInformePermisos.Width = 250
        '
        'colDepartamentoInformePermisos
        '
        Me.colDepartamentoInformePermisos.HeaderText = "Departamento"
        Me.colDepartamentoInformePermisos.Name = "colDepartamentoInformePermisos"
        Me.colDepartamentoInformePermisos.ReadOnly = True
        Me.colDepartamentoInformePermisos.Width = 130
        '
        'colCargoInformePermisos
        '
        Me.colCargoInformePermisos.HeaderText = "Cargo"
        Me.colCargoInformePermisos.Name = "colCargoInformePermisos"
        Me.colCargoInformePermisos.ReadOnly = True
        Me.colCargoInformePermisos.Width = 170
        '
        'colFechaSalidaInformePermisos
        '
        Me.colFechaSalidaInformePermisos.HeaderText = "Fecha de Salida"
        Me.colFechaSalidaInformePermisos.Name = "colFechaSalidaInformePermisos"
        Me.colFechaSalidaInformePermisos.ReadOnly = True
        Me.colFechaSalidaInformePermisos.Width = 70
        '
        'colDiaCompletoInformePermisos
        '
        Me.colDiaCompletoInformePermisos.HeaderText = "Dia Completo"
        Me.colDiaCompletoInformePermisos.Name = "colDiaCompletoInformePermisos"
        Me.colDiaCompletoInformePermisos.ReadOnly = True
        Me.colDiaCompletoInformePermisos.Width = 55
        '
        'colHoraSalidaInformePermisos
        '
        Me.colHoraSalidaInformePermisos.HeaderText = "Hora de Salida"
        Me.colHoraSalidaInformePermisos.Name = "colHoraSalidaInformePermisos"
        Me.colHoraSalidaInformePermisos.ReadOnly = True
        Me.colHoraSalidaInformePermisos.Width = 50
        '
        'colHoraEntradaInformePermisos
        '
        Me.colHoraEntradaInformePermisos.HeaderText = "Hora de Entrada"
        Me.colHoraEntradaInformePermisos.Name = "colHoraEntradaInformePermisos"
        Me.colHoraEntradaInformePermisos.ReadOnly = True
        Me.colHoraEntradaInformePermisos.Width = 50
        '
        'colHorasTotalesInformePermisos
        '
        Me.colHorasTotalesInformePermisos.HeaderText = "Horas Totales"
        Me.colHorasTotalesInformePermisos.Name = "colHorasTotalesInformePermisos"
        Me.colHorasTotalesInformePermisos.ReadOnly = True
        Me.colHorasTotalesInformePermisos.Width = 50
        '
        'colTipoPermisoInformePermisos
        '
        Me.colTipoPermisoInformePermisos.HeaderText = "Tipo de Permiso"
        Me.colTipoPermisoInformePermisos.Name = "colTipoPermisoInformePermisos"
        Me.colTipoPermisoInformePermisos.ReadOnly = True
        Me.colTipoPermisoInformePermisos.Width = 135
        '
        'Frm_InformePermisoPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1125, 773)
        Me.Controls.Add(Me.Pnl_InformePermisos)
        Me.Name = "Frm_InformePermisoPersona"
        Me.Text = "Form1"
        CType(Me.dgvSolicitudesSalidaInformePermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_InformePermisos.ResumeLayout(False)
        Me.Pnl_InformePermisos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents txbRutInformePermisos As System.Windows.Forms.TextBox
    Friend WithEvents txbNombreInformePermisos As System.Windows.Forms.TextBox
    Friend lblRutInformePermisos As System.Windows.Forms.Label
    Friend lblNombreInformePermisos As System.Windows.Forms.Label
    Friend dgvSolicitudesSalidaInformePermisos As System.Windows.Forms.DataGridView
    Friend WithEvents dtpTerminoInformePermisos As System.Windows.Forms.DateTimePicker
    Friend Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpInicioInformePermisos As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbEmpresaInformePermisos As System.Windows.Forms.ComboBox
    Friend Label3 As System.Windows.Forms.Label
    Friend Label2 As System.Windows.Forms.Label
    Private WithEvents btnBuscarInformePermisos As System.Windows.Forms.Button
    Private WithEvents btnImprimirInformePermisos As System.Windows.Forms.Button
    Private WithEvents chkBuscarTodosInformePermisos As System.Windows.Forms.CheckBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Pnl_InformePermisos As System.Windows.Forms.Panel
    Friend WithEvents colNumeroSolicitudInformePermisos As DataGridViewTextBoxColumn
    Friend WithEvents colTrabajadorInformePermisos As DataGridViewTextBoxColumn
    Friend WithEvents colDepartamentoInformePermisos As DataGridViewTextBoxColumn
    Friend WithEvents colCargoInformePermisos As DataGridViewTextBoxColumn
    Friend WithEvents colFechaSalidaInformePermisos As DataGridViewTextBoxColumn
    Friend WithEvents colDiaCompletoInformePermisos As DataGridViewTextBoxColumn
    Friend WithEvents colHoraSalidaInformePermisos As DataGridViewTextBoxColumn
    Friend WithEvents colHoraEntradaInformePermisos As DataGridViewTextBoxColumn
    Friend WithEvents colHorasTotalesInformePermisos As DataGridViewTextBoxColumn
    Friend WithEvents colTipoPermisoInformePermisos As DataGridViewTextBoxColumn
End Class


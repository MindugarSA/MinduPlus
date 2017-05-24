Partial Class Frm_InformeHorasExtrasPersona
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvColaboradoresInformeHHEE = New System.Windows.Forms.DataGridView()
        Me.colNumeroInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreColaboradoresInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRutInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDepartamentoInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCargoInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraInicioInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraTerminoInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalHorasExtrasInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaRealInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkBuscarTodosInformeHHEE = New System.Windows.Forms.CheckBox()
        Me.txbRutInformeHHEE = New System.Windows.Forms.TextBox()
        Me.txbNombreInformeHHEE = New System.Windows.Forms.TextBox()
        Me.lblRutInformeHHEE = New System.Windows.Forms.Label()
        Me.lblNombreInformeHHEE = New System.Windows.Forms.Label()
        Me.dtpTerminoInformeHHEE = New System.Windows.Forms.DateTimePicker()
        Me.lblEmpresaInformeHHEE = New System.Windows.Forms.Label()
        Me.dtpInicioInformeHHEE = New System.Windows.Forms.DateTimePicker()
        Me.cmbEmpresaInformeHHEE = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImprimirInformeHHEE = New System.Windows.Forms.Button()
        Me.btnBuscarInformeHHEE = New System.Windows.Forms.Button()
        Me.txbHHEEAcumuladasInformeHHEE = New System.Windows.Forms.TextBox()
        Me.lblHHEEAcumuladasInformeHHEE = New System.Windows.Forms.Label()
        Me.chkTodaEmpresaInformeHHEE = New System.Windows.Forms.CheckBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txbTotalEmpleadosInformeHHEE = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Pnl_InformeHHEE = New System.Windows.Forms.Panel()
        CType(Me.dgvColaboradoresInformeHHEE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_InformeHHEE.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvColaboradoresInformeHHEE
        '
        Me.dgvColaboradoresInformeHHEE.AllowDrop = True
        Me.dgvColaboradoresInformeHHEE.AllowUserToAddRows = False
        Me.dgvColaboradoresInformeHHEE.AllowUserToDeleteRows = False
        Me.dgvColaboradoresInformeHHEE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvColaboradoresInformeHHEE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNumeroInformeHHEE, Me.colNombreColaboradoresInformeHHEE, Me.colRutInformeHHEE, Me.colDepartamentoInformeHHEE, Me.colCargoInformeHHEE, Me.colHoraInicioInformeHHEE, Me.colHoraTerminoInformeHHEE, Me.colTotalHorasExtrasInformeHHEE, Me.colFechaRealInformeHHEE})
        Me.dgvColaboradoresInformeHHEE.Location = New System.Drawing.Point(27, 199)
        Me.dgvColaboradoresInformeHHEE.Name = "dgvColaboradoresInformeHHEE"
        Me.dgvColaboradoresInformeHHEE.Size = New System.Drawing.Size(1063, 301)
        Me.dgvColaboradoresInformeHHEE.TabIndex = 22
        '
        'colNumeroInformeHHEE
        '
        Me.colNumeroInformeHHEE.HeaderText = "N°"
        Me.colNumeroInformeHHEE.Name = "colNumeroInformeHHEE"
        Me.colNumeroInformeHHEE.ReadOnly = True
        Me.colNumeroInformeHHEE.Width = 30
        '
        'colNombreColaboradoresInformeHHEE
        '
        Me.colNombreColaboradoresInformeHHEE.HeaderText = "Nombre Colaborador"
        Me.colNombreColaboradoresInformeHHEE.Name = "colNombreColaboradoresInformeHHEE"
        Me.colNombreColaboradoresInformeHHEE.ReadOnly = True
        Me.colNombreColaboradoresInformeHHEE.Width = 250
        '
        'colRutInformeHHEE
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colRutInformeHHEE.DefaultCellStyle = DataGridViewCellStyle1
        Me.colRutInformeHHEE.HeaderText = "R.U.T."
        Me.colRutInformeHHEE.MaxInputLength = 10
        Me.colRutInformeHHEE.Name = "colRutInformeHHEE"
        Me.colRutInformeHHEE.ReadOnly = True
        '
        'colDepartamentoInformeHHEE
        '
        Me.colDepartamentoInformeHHEE.HeaderText = "Departamento"
        Me.colDepartamentoInformeHHEE.Name = "colDepartamentoInformeHHEE"
        Me.colDepartamentoInformeHHEE.ReadOnly = True
        Me.colDepartamentoInformeHHEE.Width = 130
        '
        'colCargoInformeHHEE
        '
        Me.colCargoInformeHHEE.HeaderText = "Cargo"
        Me.colCargoInformeHHEE.Name = "colCargoInformeHHEE"
        Me.colCargoInformeHHEE.ReadOnly = True
        Me.colCargoInformeHHEE.Width = 175
        '
        'colHoraInicioInformeHHEE
        '
        Me.colHoraInicioInformeHHEE.HeaderText = "Horas Compromiso Inicio"
        Me.colHoraInicioInformeHHEE.Name = "colHoraInicioInformeHHEE"
        Me.colHoraInicioInformeHHEE.ReadOnly = True
        Me.colHoraInicioInformeHHEE.Width = 80
        '
        'colHoraTerminoInformeHHEE
        '
        Me.colHoraTerminoInformeHHEE.HeaderText = "Horas Compromiso Termino"
        Me.colHoraTerminoInformeHHEE.Name = "colHoraTerminoInformeHHEE"
        Me.colHoraTerminoInformeHHEE.ReadOnly = True
        Me.colHoraTerminoInformeHHEE.Width = 80
        '
        'colTotalHorasExtrasInformeHHEE
        '
        Me.colTotalHorasExtrasInformeHHEE.HeaderText = "Total Horas Extras"
        Me.colTotalHorasExtrasInformeHHEE.Name = "colTotalHorasExtrasInformeHHEE"
        Me.colTotalHorasExtrasInformeHHEE.ReadOnly = True
        Me.colTotalHorasExtrasInformeHHEE.Width = 80
        '
        'colFechaRealInformeHHEE
        '
        Me.colFechaRealInformeHHEE.HeaderText = "Fecha Real"
        Me.colFechaRealInformeHHEE.Name = "colFechaRealInformeHHEE"
        Me.colFechaRealInformeHHEE.ReadOnly = True
        '
        'chkBuscarTodosInformeHHEE
        '
        Me.chkBuscarTodosInformeHHEE.AutoSize = True
        Me.chkBuscarTodosInformeHHEE.Location = New System.Drawing.Point(37, 130)
        Me.chkBuscarTodosInformeHHEE.Name = "chkBuscarTodosInformeHHEE"
        Me.chkBuscarTodosInformeHHEE.Size = New System.Drawing.Size(92, 17)
        Me.chkBuscarTodosInformeHHEE.TabIndex = 35
        Me.chkBuscarTodosInformeHHEE.Text = "Buscar Todos"
        Me.chkBuscarTodosInformeHHEE.UseVisualStyleBackColor = True
        '
        'txbRutInformeHHEE
        '
        Me.txbRutInformeHHEE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txbRutInformeHHEE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txbRutInformeHHEE.Location = New System.Drawing.Point(245, 159)
        Me.txbRutInformeHHEE.Name = "txbRutInformeHHEE"
        Me.txbRutInformeHHEE.Size = New System.Drawing.Size(269, 20)
        Me.txbRutInformeHHEE.TabIndex = 34
        '
        'txbNombreInformeHHEE
        '
        Me.txbNombreInformeHHEE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txbNombreInformeHHEE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txbNombreInformeHHEE.Location = New System.Drawing.Point(245, 131)
        Me.txbNombreInformeHHEE.Name = "txbNombreInformeHHEE"
        Me.txbNombreInformeHHEE.Size = New System.Drawing.Size(269, 20)
        Me.txbNombreInformeHHEE.TabIndex = 33
        '
        'lblRutInformeHHEE
        '
        Me.lblRutInformeHHEE.AutoSize = True
        Me.lblRutInformeHHEE.Location = New System.Drawing.Point(147, 159)
        Me.lblRutInformeHHEE.Name = "lblRutInformeHHEE"
        Me.lblRutInformeHHEE.Size = New System.Drawing.Size(27, 13)
        Me.lblRutInformeHHEE.TabIndex = 32
        Me.lblRutInformeHHEE.Text = "Rut:"
        '
        'lblNombreInformeHHEE
        '
        Me.lblNombreInformeHHEE.AutoSize = True
        Me.lblNombreInformeHHEE.Location = New System.Drawing.Point(147, 131)
        Me.lblNombreInformeHHEE.Name = "lblNombreInformeHHEE"
        Me.lblNombreInformeHHEE.Size = New System.Drawing.Size(94, 13)
        Me.lblNombreInformeHHEE.TabIndex = 31
        Me.lblNombreInformeHHEE.Text = "Nombre Completo:"
        '
        'dtpTerminoInformeHHEE
        '
        Me.dtpTerminoInformeHHEE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTerminoInformeHHEE.Location = New System.Drawing.Point(119, 84)
        Me.dtpTerminoInformeHHEE.Name = "dtpTerminoInformeHHEE"
        Me.dtpTerminoInformeHHEE.Size = New System.Drawing.Size(91, 20)
        Me.dtpTerminoInformeHHEE.TabIndex = 30
        '
        'lblEmpresaInformeHHEE
        '
        Me.lblEmpresaInformeHHEE.AutoSize = True
        Me.lblEmpresaInformeHHEE.Location = New System.Drawing.Point(34, 24)
        Me.lblEmpresaInformeHHEE.Name = "lblEmpresaInformeHHEE"
        Me.lblEmpresaInformeHHEE.Size = New System.Drawing.Size(51, 13)
        Me.lblEmpresaInformeHHEE.TabIndex = 25
        Me.lblEmpresaInformeHHEE.Text = "Empresa:"
        '
        'dtpInicioInformeHHEE
        '
        Me.dtpInicioInformeHHEE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicioInformeHHEE.Location = New System.Drawing.Point(119, 49)
        Me.dtpInicioInformeHHEE.Name = "dtpInicioInformeHHEE"
        Me.dtpInicioInformeHHEE.Size = New System.Drawing.Size(91, 20)
        Me.dtpInicioInformeHHEE.TabIndex = 29
        '
        'cmbEmpresaInformeHHEE
        '
        Me.cmbEmpresaInformeHHEE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpresaInformeHHEE.FormattingEnabled = True
        Me.cmbEmpresaInformeHHEE.Items.AddRange(New Object() {"Mindugar SA", "Mindugar Industrial", "Mindugar Montajes"})
        Me.cmbEmpresaInformeHHEE.Location = New System.Drawing.Point(89, 21)
        Me.cmbEmpresaInformeHHEE.Name = "cmbEmpresaInformeHHEE"
        Me.cmbEmpresaInformeHHEE.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmpresaInformeHHEE.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Fecha Termino:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Fecha Inicio:"
        '
        'btnImprimirInformeHHEE
        '
        Me.btnImprimirInformeHHEE.Location = New System.Drawing.Point(777, 508)
        Me.btnImprimirInformeHHEE.Name = "btnImprimirInformeHHEE"
        Me.btnImprimirInformeHHEE.Size = New System.Drawing.Size(231, 48)
        Me.btnImprimirInformeHHEE.TabIndex = 37
        Me.btnImprimirInformeHHEE.Text = "Imprimir"
        Me.btnImprimirInformeHHEE.UseVisualStyleBackColor = True
        '
        'btnBuscarInformeHHEE
        '
        Me.btnBuscarInformeHHEE.Location = New System.Drawing.Point(540, 508)
        Me.btnBuscarInformeHHEE.Name = "btnBuscarInformeHHEE"
        Me.btnBuscarInformeHHEE.Size = New System.Drawing.Size(231, 45)
        Me.btnBuscarInformeHHEE.TabIndex = 36
        Me.btnBuscarInformeHHEE.Text = "Buscar"
        Me.btnBuscarInformeHHEE.UseVisualStyleBackColor = True
        '
        'txbHHEEAcumuladasInformeHHEE
        '
        Me.txbHHEEAcumuladasInformeHHEE.Location = New System.Drawing.Point(748, 131)
        Me.txbHHEEAcumuladasInformeHHEE.Name = "txbHHEEAcumuladasInformeHHEE"
        Me.txbHHEEAcumuladasInformeHHEE.ReadOnly = True
        Me.txbHHEEAcumuladasInformeHHEE.Size = New System.Drawing.Size(129, 20)
        Me.txbHHEEAcumuladasInformeHHEE.TabIndex = 38
        '
        'lblHHEEAcumuladasInformeHHEE
        '
        Me.lblHHEEAcumuladasInformeHHEE.AutoSize = True
        Me.lblHHEEAcumuladasInformeHHEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHHEEAcumuladasInformeHHEE.Location = New System.Drawing.Point(568, 134)
        Me.lblHHEEAcumuladasInformeHHEE.Name = "lblHHEEAcumuladasInformeHHEE"
        Me.lblHHEEAcumuladasInformeHHEE.Size = New System.Drawing.Size(174, 17)
        Me.lblHHEEAcumuladasInformeHHEE.TabIndex = 39
        Me.lblHHEEAcumuladasInformeHHEE.Text = "Horas Extras Acumuladas:"
        '
        'chkTodaEmpresaInformeHHEE
        '
        Me.chkTodaEmpresaInformeHHEE.AutoSize = True
        Me.chkTodaEmpresaInformeHHEE.Location = New System.Drawing.Point(216, 25)
        Me.chkTodaEmpresaInformeHHEE.Name = "chkTodaEmpresaInformeHHEE"
        Me.chkTodaEmpresaInformeHHEE.Size = New System.Drawing.Size(95, 17)
        Me.chkTodaEmpresaInformeHHEE.TabIndex = 40
        Me.chkTodaEmpresaInformeHHEE.Text = "Toda Empresa"
        Me.chkTodaEmpresaInformeHHEE.UseVisualStyleBackColor = True
        Me.chkTodaEmpresaInformeHHEE.Visible = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(571, 165)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(81, 13)
        Me.label4.TabIndex = 41
        Me.label4.Text = "Total Empleado"
        '
        'txbTotalEmpleadosInformeHHEE
        '
        Me.txbTotalEmpleadosInformeHHEE.Location = New System.Drawing.Point(681, 165)
        Me.txbTotalEmpleadosInformeHHEE.Name = "txbTotalEmpleadosInformeHHEE"
        Me.txbTotalEmpleadosInformeHHEE.ReadOnly = True
        Me.txbTotalEmpleadosInformeHHEE.Size = New System.Drawing.Size(100, 20)
        Me.txbTotalEmpleadosInformeHHEE.TabIndex = 42
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(27, 506)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(164, 50)
        Me.btnVolver.TabIndex = 43
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Pnl_InformeHHEE
        '
        Me.Pnl_InformeHHEE.Controls.Add(Me.btnBuscarInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.btnVolver)
        Me.Pnl_InformeHHEE.Controls.Add(Me.dgvColaboradoresInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.txbTotalEmpleadosInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.Label2)
        Me.Pnl_InformeHHEE.Controls.Add(Me.label4)
        Me.Pnl_InformeHHEE.Controls.Add(Me.Label3)
        Me.Pnl_InformeHHEE.Controls.Add(Me.chkTodaEmpresaInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.cmbEmpresaInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.lblHHEEAcumuladasInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.dtpInicioInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.txbHHEEAcumuladasInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.lblEmpresaInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.btnImprimirInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.dtpTerminoInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.lblNombreInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.chkBuscarTodosInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.lblRutInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.txbRutInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.txbNombreInformeHHEE)
        Me.Pnl_InformeHHEE.Location = New System.Drawing.Point(12, 0)
        Me.Pnl_InformeHHEE.Name = "Pnl_InformeHHEE"
        Me.Pnl_InformeHHEE.Size = New System.Drawing.Size(1112, 569)
        Me.Pnl_InformeHHEE.TabIndex = 44
        '
        'Frm_InformeHorasExtrasPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1219, 623)
        Me.Controls.Add(Me.Pnl_InformeHHEE)
        Me.Name = "Frm_InformeHorasExtrasPersona"
        Me.Text = "Frm_InformeHorasExtrasPersona"
        CType(Me.dgvColaboradoresInformeHHEE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_InformeHHEE.ResumeLayout(False)
        Me.Pnl_InformeHHEE.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend dgvColaboradoresInformeHHEE As System.Windows.Forms.DataGridView
    Private WithEvents chkBuscarTodosInformeHHEE As System.Windows.Forms.CheckBox
    Friend WithEvents txbRutInformeHHEE As System.Windows.Forms.TextBox
    Friend WithEvents txbNombreInformeHHEE As System.Windows.Forms.TextBox
    Friend lblRutInformeHHEE As System.Windows.Forms.Label
    Friend lblNombreInformeHHEE As System.Windows.Forms.Label
    Friend WithEvents dtpTerminoInformeHHEE As System.Windows.Forms.DateTimePicker
    Friend lblEmpresaInformeHHEE As System.Windows.Forms.Label
    Friend WithEvents dtpInicioInformeHHEE As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbEmpresaInformeHHEE As System.Windows.Forms.ComboBox
    Friend Label3 As System.Windows.Forms.Label
    Friend Label2 As System.Windows.Forms.Label
    Private WithEvents btnImprimirInformeHHEE As System.Windows.Forms.Button
    Private WithEvents btnBuscarInformeHHEE As System.Windows.Forms.Button
    Private txbHHEEAcumuladasInformeHHEE As System.Windows.Forms.TextBox
    Private lblHHEEAcumuladasInformeHHEE As System.Windows.Forms.Label
    Private WithEvents chkTodaEmpresaInformeHHEE As System.Windows.Forms.CheckBox
    Private label4 As System.Windows.Forms.Label
    Private txbTotalEmpleadosInformeHHEE As System.Windows.Forms.TextBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Pnl_InformeHHEE As System.Windows.Forms.Panel
    Friend WithEvents colNumeroInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colNombreColaboradoresInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colRutInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colDepartamentoInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colCargoInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colHoraInicioInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colHoraTerminoInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colTotalHorasExtrasInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colFechaRealInformeHHEE As DataGridViewTextBoxColumn
End Class

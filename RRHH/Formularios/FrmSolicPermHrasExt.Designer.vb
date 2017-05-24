<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSolicPermHrasExt
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solicitud de Permisos")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solicitud de Hr. Extras")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solicitudes", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autorizaciòn de Permisos")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autorizacion Horas Extras")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autorizaciones", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe Permisos")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe Horas Extras")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8})
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Pnl_InformePermisos = New System.Windows.Forms.Panel()
        Me.lblNombreInformePermisos = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.chkBuscarTodosInformePermisos = New System.Windows.Forms.CheckBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.btnImprimirInformePermisos = New System.Windows.Forms.Button()
        Me.cmbEmpresaInformePermisos = New System.Windows.Forms.ComboBox()
        Me.btnBuscarInformePermisos = New System.Windows.Forms.Button()
        Me.dtpInicioInformePermisos = New System.Windows.Forms.DateTimePicker()
        Me.txbRutInformePermisos = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txbNombreInformePermisos = New System.Windows.Forms.TextBox()
        Me.dtpTerminoInformePermisos = New System.Windows.Forms.DateTimePicker()
        Me.lblRutInformePermisos = New System.Windows.Forms.Label()
        Me.dgvSolicitudesSalidaInformePermisos = New System.Windows.Forms.DataGridView()
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
        Me.Pnl_InformeHHEE = New System.Windows.Forms.Panel()
        Me.btnBuscarInformeHHEE = New System.Windows.Forms.Button()
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
        Me.txbTotalEmpleadosInformeHHEE = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.chkTodaEmpresaInformeHHEE = New System.Windows.Forms.CheckBox()
        Me.cmbEmpresaInformeHHEE = New System.Windows.Forms.ComboBox()
        Me.lblHHEEAcumuladasInformeHHEE = New System.Windows.Forms.Label()
        Me.dtpInicioInformeHHEE = New System.Windows.Forms.DateTimePicker()
        Me.txbHHEEAcumuladasInformeHHEE = New System.Windows.Forms.TextBox()
        Me.lblEmpresaInformeHHEE = New System.Windows.Forms.Label()
        Me.btnImprimirInformeHHEE = New System.Windows.Forms.Button()
        Me.dtpTerminoInformeHHEE = New System.Windows.Forms.DateTimePicker()
        Me.lblNombreInformeHHEE = New System.Windows.Forms.Label()
        Me.chkBuscarTodosInformeHHEE = New System.Windows.Forms.CheckBox()
        Me.lblRutInformeHHEE = New System.Windows.Forms.Label()
        Me.txbRutInformeHHEE = New System.Windows.Forms.TextBox()
        Me.txbNombreInformeHHEE = New System.Windows.Forms.TextBox()
        Me.Pnl_AutHrExt = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTermino = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.chkTodas = New System.Windows.Forms.CheckBox()
        Me.txbSolicitante = New System.Windows.Forms.TextBox()
        Me.txbFecha = New System.Windows.Forms.TextBox()
        Me.btnRechazarTodas = New System.Windows.Forms.Button()
        Me.btnAutorizarTodas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvColaboradores = New System.Windows.Forms.DataGridView()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreColaboradores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horaTermino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaReal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAutorizar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnRechazar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbNumeroSolicitud = New System.Windows.Forms.ComboBox()
        Me.txbDetalle = New System.Windows.Forms.TextBox()
        Me.Pnl_SolHrasExt = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.dgvColaboradoresSHHEE = New System.Windows.Forms.DataGridView()
        Me.numeroSolicitarHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreColaborador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rutSolicitarHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargoSolicitarHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEmpresaSolicitarHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horaInicioSolicitarHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horaTerminoSolicitarHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadHoras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaRealSolicitarHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxtBxDetalleSHX = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txbHorasExtras = New System.Windows.Forms.TextBox()
        Me.txbSupervisorSolicitante = New System.Windows.Forms.TextBox()
        Me.Pnl_SolPermisos = New System.Windows.Forms.Panel()
        Me.Pnl_SolicitudPermisos = New System.Windows.Forms.Panel()
        Me.pnlModificar = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmbModificarTrabajador = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkDiaCompleto = New System.Windows.Forms.CheckBox()
        Me.pnlHora = New System.Windows.Forms.Panel()
        Me.dtpHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpHoraEntrada = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txbTotalHoras = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbJefes = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txbTramite = New System.Windows.Forms.TextBox()
        Me.txbEmpresa = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txbTrabajador = New System.Windows.Forms.TextBox()
        Me.txbCargo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txbRut = New System.Windows.Forms.TextBox()
        Me.txbFechaIngreso = New System.Windows.Forms.TextBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbAreas = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dtpDia = New System.Windows.Forms.DateTimePicker()
        Me.gbTipoPermiso = New System.Windows.Forms.GroupBox()
        Me.rbPermisoParticular = New System.Windows.Forms.RadioButton()
        Me.rbPermisoComisionServicio = New System.Windows.Forms.RadioButton()
        Me.btnAgregarSolicitud = New System.Windows.Forms.Button()
        Me.Pnl_AutPermisos = New System.Windows.Forms.Panel()
        Me.Pnl_Central = New System.Windows.Forms.Panel()
        Me.chkVerPendientes = New System.Windows.Forms.CheckBox()
        Me.dtpFechaTermino = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvSolicitudesSalida = New System.Windows.Forms.DataGridView()
        Me.numeroSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trabajador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaInforme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreSolicitante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rutTrabajador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargoAutorizarPermiso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diaCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horaSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horaEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horasTotales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoPermiso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAutorizarPermiso = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnRechazarPermiso = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnImprimirPermiso = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnVerHistorial = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Pnl_InformePermisos.SuspendLayout()
        CType(Me.dgvSolicitudesSalidaInformePermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_InformeHHEE.SuspendLayout()
        CType(Me.dgvColaboradoresInformeHHEE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_AutHrExt.SuspendLayout()
        CType(Me.dgvColaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_SolHrasExt.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvColaboradoresSHHEE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_SolPermisos.SuspendLayout()
        Me.Pnl_SolicitudPermisos.SuspendLayout()
        Me.pnlModificar.SuspendLayout()
        Me.pnlHora.SuspendLayout()
        Me.gbTipoPermiso.SuspendLayout()
        Me.Pnl_AutPermisos.SuspendLayout()
        Me.Pnl_Central.SuspendLayout()
        CType(Me.dgvSolicitudesSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnVolver)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Pnl_InformePermisos)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Pnl_InformeHHEE)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Pnl_AutHrExt)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Pnl_SolHrasExt)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Pnl_SolPermisos)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Pnl_AutPermisos)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Lbl_Titulo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1908, 1045)
        Me.SplitContainer1.SplitterDistance = 200
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 21)
        Me.Panel1.TabIndex = 2
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Location = New System.Drawing.Point(0, 25)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Nd_SolPermisos"
        TreeNode1.Text = "Solicitud de Permisos"
        TreeNode2.Name = "Nd_SolHrExt"
        TreeNode2.Text = "Solicitud de Hr. Extras"
        TreeNode3.Name = "Nodo0"
        TreeNode3.Text = "Solicitudes"
        TreeNode4.Name = "Nd_AutPermisos"
        TreeNode4.Text = "Autorizaciòn de Permisos"
        TreeNode5.Name = "Nd_AutHrExt"
        TreeNode5.Text = "Autorizacion Horas Extras"
        TreeNode6.Name = "Nodo2"
        TreeNode6.Text = "Autorizaciones"
        TreeNode7.Name = "Nd_InformePermisos"
        TreeNode7.Text = "Informe Permisos"
        TreeNode8.Name = "Nd_InformeHorasExtras"
        TreeNode8.Text = "Informe Horas Extras"
        TreeNode9.Name = "Nodo1"
        TreeNode9.Text = "Informe"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6, TreeNode9})
        Me.TreeView1.Size = New System.Drawing.Size(197, 716)
        Me.TreeView1.TabIndex = 1
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 747)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(110, 44)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Pnl_InformePermisos
        '
        Me.Pnl_InformePermisos.Controls.Add(Me.lblNombreInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.Label34)
        Me.Pnl_InformePermisos.Controls.Add(Me.chkBuscarTodosInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.Label35)
        Me.Pnl_InformePermisos.Controls.Add(Me.btnImprimirInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.cmbEmpresaInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.btnBuscarInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.dtpInicioInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.txbRutInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.Label36)
        Me.Pnl_InformePermisos.Controls.Add(Me.txbNombreInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.dtpTerminoInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.lblRutInformePermisos)
        Me.Pnl_InformePermisos.Controls.Add(Me.dgvSolicitudesSalidaInformePermisos)
        Me.Pnl_InformePermisos.Location = New System.Drawing.Point(4, 52)
        Me.Pnl_InformePermisos.Name = "Pnl_InformePermisos"
        Me.Pnl_InformePermisos.Size = New System.Drawing.Size(240, 193)
        Me.Pnl_InformePermisos.TabIndex = 46
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
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(29, 54)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(68, 13)
        Me.Label34.TabIndex = 13
        Me.Label34.Text = "Fecha Inicio:"
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
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(29, 89)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(81, 13)
        Me.Label35.TabIndex = 14
        Me.Label35.Text = "Fecha Termino:"
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
        'btnBuscarInformePermisos
        '
        Me.btnBuscarInformePermisos.Location = New System.Drawing.Point(585, 599)
        Me.btnBuscarInformePermisos.Name = "btnBuscarInformePermisos"
        Me.btnBuscarInformePermisos.Size = New System.Drawing.Size(223, 40)
        Me.btnBuscarInformePermisos.TabIndex = 22
        Me.btnBuscarInformePermisos.Text = "Buscar"
        Me.btnBuscarInformePermisos.UseVisualStyleBackColor = True
        '
        'dtpInicioInformePermisos
        '
        Me.dtpInicioInformePermisos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicioInformePermisos.Location = New System.Drawing.Point(114, 48)
        Me.dtpInicioInformePermisos.Name = "dtpInicioInformePermisos"
        Me.dtpInicioInformePermisos.Size = New System.Drawing.Size(91, 20)
        Me.dtpInicioInformePermisos.TabIndex = 15
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
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(29, 23)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(51, 13)
        Me.Label36.TabIndex = 11
        Me.Label36.Text = "Empresa:"
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
        'dtpTerminoInformePermisos
        '
        Me.dtpTerminoInformePermisos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTerminoInformePermisos.Location = New System.Drawing.Point(114, 83)
        Me.dtpTerminoInformePermisos.Name = "dtpTerminoInformePermisos"
        Me.dtpTerminoInformePermisos.Size = New System.Drawing.Size(91, 20)
        Me.dtpTerminoInformePermisos.TabIndex = 16
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
        'Pnl_InformeHHEE
        '
        Me.Pnl_InformeHHEE.Controls.Add(Me.btnBuscarInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.dgvColaboradoresInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.txbTotalEmpleadosInformeHHEE)
        Me.Pnl_InformeHHEE.Controls.Add(Me.Label31)
        Me.Pnl_InformeHHEE.Controls.Add(Me.Label32)
        Me.Pnl_InformeHHEE.Controls.Add(Me.Label33)
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
        Me.Pnl_InformeHHEE.Location = New System.Drawing.Point(3, 288)
        Me.Pnl_InformeHHEE.Name = "Pnl_InformeHHEE"
        Me.Pnl_InformeHHEE.Size = New System.Drawing.Size(304, 223)
        Me.Pnl_InformeHHEE.TabIndex = 45
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
        'txbTotalEmpleadosInformeHHEE
        '
        Me.txbTotalEmpleadosInformeHHEE.Location = New System.Drawing.Point(681, 165)
        Me.txbTotalEmpleadosInformeHHEE.Name = "txbTotalEmpleadosInformeHHEE"
        Me.txbTotalEmpleadosInformeHHEE.ReadOnly = True
        Me.txbTotalEmpleadosInformeHHEE.Size = New System.Drawing.Size(100, 20)
        Me.txbTotalEmpleadosInformeHHEE.TabIndex = 42
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(34, 55)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(68, 13)
        Me.Label31.TabIndex = 27
        Me.Label31.Text = "Fecha Inicio:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(571, 165)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(81, 13)
        Me.Label32.TabIndex = 41
        Me.Label32.Text = "Total Empleado"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(34, 90)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(81, 13)
        Me.Label33.TabIndex = 28
        Me.Label33.Text = "Fecha Termino:"
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
        'dtpInicioInformeHHEE
        '
        Me.dtpInicioInformeHHEE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicioInformeHHEE.Location = New System.Drawing.Point(119, 49)
        Me.dtpInicioInformeHHEE.Name = "dtpInicioInformeHHEE"
        Me.dtpInicioInformeHHEE.Size = New System.Drawing.Size(91, 20)
        Me.dtpInicioInformeHHEE.TabIndex = 29
        '
        'txbHHEEAcumuladasInformeHHEE
        '
        Me.txbHHEEAcumuladasInformeHHEE.Location = New System.Drawing.Point(748, 131)
        Me.txbHHEEAcumuladasInformeHHEE.Name = "txbHHEEAcumuladasInformeHHEE"
        Me.txbHHEEAcumuladasInformeHHEE.ReadOnly = True
        Me.txbHHEEAcumuladasInformeHHEE.Size = New System.Drawing.Size(129, 20)
        Me.txbHHEEAcumuladasInformeHHEE.TabIndex = 38
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
        'btnImprimirInformeHHEE
        '
        Me.btnImprimirInformeHHEE.Location = New System.Drawing.Point(777, 508)
        Me.btnImprimirInformeHHEE.Name = "btnImprimirInformeHHEE"
        Me.btnImprimirInformeHHEE.Size = New System.Drawing.Size(231, 48)
        Me.btnImprimirInformeHHEE.TabIndex = 37
        Me.btnImprimirInformeHHEE.Text = "Imprimir"
        Me.btnImprimirInformeHHEE.UseVisualStyleBackColor = True
        '
        'dtpTerminoInformeHHEE
        '
        Me.dtpTerminoInformeHHEE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTerminoInformeHHEE.Location = New System.Drawing.Point(119, 84)
        Me.dtpTerminoInformeHHEE.Name = "dtpTerminoInformeHHEE"
        Me.dtpTerminoInformeHHEE.Size = New System.Drawing.Size(91, 20)
        Me.dtpTerminoInformeHHEE.TabIndex = 30
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
        'lblRutInformeHHEE
        '
        Me.lblRutInformeHHEE.AutoSize = True
        Me.lblRutInformeHHEE.Location = New System.Drawing.Point(147, 159)
        Me.lblRutInformeHHEE.Name = "lblRutInformeHHEE"
        Me.lblRutInformeHHEE.Size = New System.Drawing.Size(27, 13)
        Me.lblRutInformeHHEE.TabIndex = 32
        Me.lblRutInformeHHEE.Text = "Rut:"
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
        'Pnl_AutHrExt
        '
        Me.Pnl_AutHrExt.Controls.Add(Me.Label4)
        Me.Pnl_AutHrExt.Controls.Add(Me.Label2)
        Me.Pnl_AutHrExt.Controls.Add(Me.dtpTermino)
        Me.Pnl_AutHrExt.Controls.Add(Me.dtpInicio)
        Me.Pnl_AutHrExt.Controls.Add(Me.btnImprimir)
        Me.Pnl_AutHrExt.Controls.Add(Me.chkTodas)
        Me.Pnl_AutHrExt.Controls.Add(Me.txbSolicitante)
        Me.Pnl_AutHrExt.Controls.Add(Me.txbFecha)
        Me.Pnl_AutHrExt.Controls.Add(Me.btnRechazarTodas)
        Me.Pnl_AutHrExt.Controls.Add(Me.btnAutorizarTodas)
        Me.Pnl_AutHrExt.Controls.Add(Me.Label1)
        Me.Pnl_AutHrExt.Controls.Add(Me.Label6)
        Me.Pnl_AutHrExt.Controls.Add(Me.dgvColaboradores)
        Me.Pnl_AutHrExt.Controls.Add(Me.Label3)
        Me.Pnl_AutHrExt.Controls.Add(Me.Label5)
        Me.Pnl_AutHrExt.Controls.Add(Me.cmbNumeroSolicitud)
        Me.Pnl_AutHrExt.Controls.Add(Me.txbDetalle)
        Me.Pnl_AutHrExt.Location = New System.Drawing.Point(30, 605)
        Me.Pnl_AutHrExt.Name = "Pnl_AutHrExt"
        Me.Pnl_AutHrExt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Pnl_AutHrExt.Size = New System.Drawing.Size(355, 143)
        Me.Pnl_AutHrExt.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(133, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Termino:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Inicio:"
        '
        'dtpTermino
        '
        Me.dtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTermino.Location = New System.Drawing.Point(187, 136)
        Me.dtpTermino.Name = "dtpTermino"
        Me.dtpTermino.Size = New System.Drawing.Size(86, 20)
        Me.dtpTermino.TabIndex = 40
        Me.dtpTermino.Visible = False
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(187, 99)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(86, 20)
        Me.dtpInicio.TabIndex = 39
        Me.dtpInicio.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(448, 444)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(200, 34)
        Me.btnImprimir.TabIndex = 38
        Me.btnImprimir.Text = "Imprimir Formulario"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'chkTodas
        '
        Me.chkTodas.AutoSize = True
        Me.chkTodas.Location = New System.Drawing.Point(23, 102)
        Me.chkTodas.Name = "chkTodas"
        Me.chkTodas.Size = New System.Drawing.Size(71, 17)
        Me.chkTodas.TabIndex = 37
        Me.chkTodas.Text = "Ver todas"
        Me.chkTodas.UseVisualStyleBackColor = True
        '
        'txbSolicitante
        '
        Me.txbSolicitante.Location = New System.Drawing.Point(131, 63)
        Me.txbSolicitante.Name = "txbSolicitante"
        Me.txbSolicitante.ReadOnly = True
        Me.txbSolicitante.Size = New System.Drawing.Size(242, 20)
        Me.txbSolicitante.TabIndex = 33
        '
        'txbFecha
        '
        Me.txbFecha.Location = New System.Drawing.Point(131, 38)
        Me.txbFecha.Name = "txbFecha"
        Me.txbFecha.ReadOnly = True
        Me.txbFecha.Size = New System.Drawing.Size(100, 20)
        Me.txbFecha.TabIndex = 36
        '
        'btnRechazarTodas
        '
        Me.btnRechazarTodas.Location = New System.Drawing.Point(822, 443)
        Me.btnRechazarTodas.Name = "btnRechazarTodas"
        Me.btnRechazarTodas.Size = New System.Drawing.Size(149, 35)
        Me.btnRechazarTodas.TabIndex = 31
        Me.btnRechazarTodas.Text = "Rechazar Todas Las Filas"
        Me.btnRechazarTodas.UseVisualStyleBackColor = True
        Me.btnRechazarTodas.Visible = False
        '
        'btnAutorizarTodas
        '
        Me.btnAutorizarTodas.Location = New System.Drawing.Point(654, 444)
        Me.btnAutorizarTodas.Name = "btnAutorizarTodas"
        Me.btnAutorizarTodas.Size = New System.Drawing.Size(149, 34)
        Me.btnAutorizarTodas.TabIndex = 30
        Me.btnAutorizarTodas.Text = "Autorizar Todas las Filas"
        Me.btnAutorizarTodas.UseVisualStyleBackColor = True
        Me.btnAutorizarTodas.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Numero de Solicitud:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Fecha"
        '
        'dgvColaboradores
        '
        Me.dgvColaboradores.AllowDrop = True
        Me.dgvColaboradores.AllowUserToAddRows = False
        Me.dgvColaboradores.AllowUserToDeleteRows = False
        Me.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvColaboradores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.nombreColaboradores, Me.rut, Me.cargo, Me.nombreEmpresa, Me.horaInicio, Me.horaTermino, Me.fechaReal, Me.btnAutorizar, Me.btnRechazar})
        Me.dgvColaboradores.Location = New System.Drawing.Point(7, 168)
        Me.dgvColaboradores.Name = "dgvColaboradores"
        Me.dgvColaboradores.Size = New System.Drawing.Size(979, 230)
        Me.dgvColaboradores.TabIndex = 21
        '
        'numero
        '
        Me.numero.Frozen = True
        Me.numero.HeaderText = "N°"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        Me.numero.Width = 30
        '
        'nombreColaboradores
        '
        Me.nombreColaboradores.Frozen = True
        Me.nombreColaboradores.HeaderText = "Nombre Colaborador"
        Me.nombreColaboradores.Name = "nombreColaboradores"
        Me.nombreColaboradores.ReadOnly = True
        Me.nombreColaboradores.Width = 250
        '
        'rut
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.rut.DefaultCellStyle = DataGridViewCellStyle2
        Me.rut.HeaderText = "R.U.T."
        Me.rut.MaxInputLength = 10
        Me.rut.Name = "rut"
        Me.rut.ReadOnly = True
        '
        'cargo
        '
        Me.cargo.HeaderText = "Cargo"
        Me.cargo.Name = "cargo"
        Me.cargo.ReadOnly = True
        Me.cargo.Width = 175
        '
        'nombreEmpresa
        '
        Me.nombreEmpresa.HeaderText = "Nombre Empresa"
        Me.nombreEmpresa.Name = "nombreEmpresa"
        Me.nombreEmpresa.ReadOnly = True
        Me.nombreEmpresa.Width = 125
        '
        'horaInicio
        '
        Me.horaInicio.HeaderText = "Horas Compromiso Inicio"
        Me.horaInicio.Name = "horaInicio"
        Me.horaInicio.ReadOnly = True
        Me.horaInicio.Width = 80
        '
        'horaTermino
        '
        Me.horaTermino.HeaderText = "Horas Compromiso Termino"
        Me.horaTermino.Name = "horaTermino"
        Me.horaTermino.ReadOnly = True
        Me.horaTermino.Width = 80
        '
        'fechaReal
        '
        Me.fechaReal.HeaderText = "Fecha Real"
        Me.fechaReal.Name = "fechaReal"
        Me.fechaReal.ReadOnly = True
        '
        'btnAutorizar
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent
        Me.btnAutorizar.DefaultCellStyle = DataGridViewCellStyle3
        Me.btnAutorizar.HeaderText = "Autorizar"
        Me.btnAutorizar.Name = "btnAutorizar"
        Me.btnAutorizar.Text = "Autorizar"
        Me.btnAutorizar.ToolTipText = "autorizar empleado"
        Me.btnAutorizar.UseColumnTextForButtonValue = True
        '
        'btnRechazar
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.btnRechazar.DefaultCellStyle = DataGridViewCellStyle4
        Me.btnRechazar.HeaderText = "Rechazar"
        Me.btnRechazar.Name = "btnRechazar"
        Me.btnRechazar.Text = "Rechazar"
        Me.btnRechazar.ToolTipText = "rechazar solicitud"
        Me.btnRechazar.UseColumnTextForButtonValue = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(386, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Detalle:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Solicitante:"
        '
        'cmbNumeroSolicitud
        '
        Me.cmbNumeroSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNumeroSolicitud.FormattingEnabled = True
        Me.cmbNumeroSolicitud.Location = New System.Drawing.Point(131, 10)
        Me.cmbNumeroSolicitud.Name = "cmbNumeroSolicitud"
        Me.cmbNumeroSolicitud.Size = New System.Drawing.Size(100, 21)
        Me.cmbNumeroSolicitud.TabIndex = 28
        '
        'txbDetalle
        '
        Me.txbDetalle.Location = New System.Drawing.Point(389, 16)
        Me.txbDetalle.Multiline = True
        Me.txbDetalle.Name = "txbDetalle"
        Me.txbDetalle.ReadOnly = True
        Me.txbDetalle.Size = New System.Drawing.Size(597, 140)
        Me.txbDetalle.TabIndex = 29
        '
        'Pnl_SolHrasExt
        '
        Me.Pnl_SolHrasExt.Controls.Add(Me.Panel6)
        Me.Pnl_SolHrasExt.Location = New System.Drawing.Point(419, 296)
        Me.Pnl_SolHrasExt.Name = "Pnl_SolHrasExt"
        Me.Pnl_SolHrasExt.Size = New System.Drawing.Size(202, 164)
        Me.Pnl_SolHrasExt.TabIndex = 42
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.ComboBox2)
        Me.Panel6.Controls.Add(Me.Label24)
        Me.Panel6.Controls.Add(Me.dtpFecha)
        Me.Panel6.Controls.Add(Me.btnSolicitar)
        Me.Panel6.Controls.Add(Me.ComboBox3)
        Me.Panel6.Controls.Add(Me.dgvColaboradoresSHHEE)
        Me.Panel6.Controls.Add(Me.Label25)
        Me.Panel6.Controls.Add(Me.Label26)
        Me.Panel6.Controls.Add(Me.Label27)
        Me.Panel6.Controls.Add(Me.Label28)
        Me.Panel6.Controls.Add(Me.Label29)
        Me.Panel6.Controls.Add(Me.TxtBxDetalleSHX)
        Me.Panel6.Controls.Add(Me.Label30)
        Me.Panel6.Controls.Add(Me.txbHorasExtras)
        Me.Panel6.Controls.Add(Me.txbSupervisorSolicitante)
        Me.Panel6.Location = New System.Drawing.Point(12, 23)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1191, 474)
        Me.Panel6.TabIndex = 54
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(104, 66)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(259, 21)
        Me.ComboBox2.TabIndex = 61
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(17, 74)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(82, 13)
        Me.Label24.TabIndex = 60
        Me.Label24.Text = "Jefe Encargado"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(592, 15)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(91, 20)
        Me.dtpFecha.TabIndex = 53
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(980, 392)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(205, 50)
        Me.btnSolicitar.TabIndex = 19
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(274, 43)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(167, 21)
        Me.ComboBox3.TabIndex = 52
        '
        'dgvColaboradoresSHHEE
        '
        Me.dgvColaboradoresSHHEE.AllowDrop = True
        Me.dgvColaboradoresSHHEE.AllowUserToDeleteRows = False
        Me.dgvColaboradoresSHHEE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvColaboradoresSHHEE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numeroSolicitarHHEE, Me.nombreColaborador, Me.rutSolicitarHHEE, Me.cargoSolicitarHHEE, Me.nombreEmpresaSolicitarHHEE, Me.horaInicioSolicitarHHEE, Me.horaTerminoSolicitarHHEE, Me.cantidadHoras, Me.fechaRealSolicitarHHEE, Me.btnEliminar})
        Me.dgvColaboradoresSHHEE.Location = New System.Drawing.Point(3, 104)
        Me.dgvColaboradoresSHHEE.Name = "dgvColaboradoresSHHEE"
        Me.dgvColaboradoresSHHEE.Size = New System.Drawing.Size(1184, 266)
        Me.dgvColaboradoresSHHEE.TabIndex = 20
        '
        'numeroSolicitarHHEE
        '
        Me.numeroSolicitarHHEE.HeaderText = "N°"
        Me.numeroSolicitarHHEE.Name = "numeroSolicitarHHEE"
        Me.numeroSolicitarHHEE.ReadOnly = True
        Me.numeroSolicitarHHEE.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.numeroSolicitarHHEE.Width = 30
        '
        'nombreColaborador
        '
        Me.nombreColaborador.HeaderText = "Nombre Colaborador"
        Me.nombreColaborador.Name = "nombreColaborador"
        Me.nombreColaborador.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nombreColaborador.Width = 250
        '
        'rutSolicitarHHEE
        '
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.rutSolicitarHHEE.DefaultCellStyle = DataGridViewCellStyle5
        Me.rutSolicitarHHEE.HeaderText = "R.U.T."
        Me.rutSolicitarHHEE.MaxInputLength = 10
        Me.rutSolicitarHHEE.Name = "rutSolicitarHHEE"
        Me.rutSolicitarHHEE.ReadOnly = True
        Me.rutSolicitarHHEE.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'cargoSolicitarHHEE
        '
        Me.cargoSolicitarHHEE.HeaderText = "Cargo"
        Me.cargoSolicitarHHEE.Name = "cargoSolicitarHHEE"
        Me.cargoSolicitarHHEE.ReadOnly = True
        Me.cargoSolicitarHHEE.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cargoSolicitarHHEE.Width = 175
        '
        'nombreEmpresaSolicitarHHEE
        '
        Me.nombreEmpresaSolicitarHHEE.HeaderText = "Nombre Empresa"
        Me.nombreEmpresaSolicitarHHEE.Name = "nombreEmpresaSolicitarHHEE"
        Me.nombreEmpresaSolicitarHHEE.ReadOnly = True
        Me.nombreEmpresaSolicitarHHEE.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nombreEmpresaSolicitarHHEE.Width = 125
        '
        'horaInicioSolicitarHHEE
        '
        Me.horaInicioSolicitarHHEE.HeaderText = "Horas Compromiso Inicio"
        Me.horaInicioSolicitarHHEE.MaxInputLength = 5
        Me.horaInicioSolicitarHHEE.Name = "horaInicioSolicitarHHEE"
        Me.horaInicioSolicitarHHEE.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.horaInicioSolicitarHHEE.Width = 80
        '
        'horaTerminoSolicitarHHEE
        '
        Me.horaTerminoSolicitarHHEE.HeaderText = "Horas Compromiso Termino"
        Me.horaTerminoSolicitarHHEE.MaxInputLength = 5
        Me.horaTerminoSolicitarHHEE.Name = "horaTerminoSolicitarHHEE"
        Me.horaTerminoSolicitarHHEE.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.horaTerminoSolicitarHHEE.Width = 80
        '
        'cantidadHoras
        '
        Me.cantidadHoras.HeaderText = "Horas Totales"
        Me.cantidadHoras.Name = "cantidadHoras"
        Me.cantidadHoras.ReadOnly = True
        '
        'fechaRealSolicitarHHEE
        '
        Me.fechaRealSolicitarHHEE.HeaderText = "Fecha Real"
        Me.fechaRealSolicitarHHEE.Name = "fechaRealSolicitarHHEE"
        Me.fechaRealSolicitarHHEE.ReadOnly = True
        Me.fechaRealSolicitarHHEE.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'btnEliminar
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Transparent
        Me.btnEliminar.DefaultCellStyle = DataGridViewCellStyle6
        Me.btnEliminar.HeaderText = "Eliminar Filas"
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Text = "eliminar"
        Me.btnEliminar.ToolTipText = "eliminar fila"
        Me.btnEliminar.UseColumnTextForButtonValue = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(14, 12)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(109, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Supervisor Solicitante"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(540, 15)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(37, 13)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Fecha"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(14, 43)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 13)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "Solicito autorizar"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(149, 43)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(120, 13)
        Me.Label28.TabIndex = 4
        Me.Label28.Text = "Horas extra para el area"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(453, 43)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(124, 13)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "para el siguiente destino:"
        '
        'TxtBxDetalleSHX
        '
        Me.TxtBxDetalleSHX.Location = New System.Drawing.Point(709, 24)
        Me.TxtBxDetalleSHX.MaxLength = 100
        Me.TxtBxDetalleSHX.Multiline = True
        Me.TxtBxDetalleSHX.Name = "TxtBxDetalleSHX"
        Me.TxtBxDetalleSHX.Size = New System.Drawing.Size(352, 74)
        Me.TxtBxDetalleSHX.TabIndex = 18
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(706, 8)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(266, 13)
        Me.Label30.TabIndex = 9
        Me.Label30.Text = "Justificación para ejecutar este trabajo en horas extras:"
        '
        'txbHorasExtras
        '
        Me.txbHorasExtras.Location = New System.Drawing.Point(104, 40)
        Me.txbHorasExtras.Name = "txbHorasExtras"
        Me.txbHorasExtras.Size = New System.Drawing.Size(32, 20)
        Me.txbHorasExtras.TabIndex = 13
        Me.txbHorasExtras.Text = "1"
        '
        'txbSupervisorSolicitante
        '
        Me.txbSupervisorSolicitante.Location = New System.Drawing.Point(130, 12)
        Me.txbSupervisorSolicitante.MaxLength = 50
        Me.txbSupervisorSolicitante.Name = "txbSupervisorSolicitante"
        Me.txbSupervisorSolicitante.ReadOnly = True
        Me.txbSupervisorSolicitante.Size = New System.Drawing.Size(366, 20)
        Me.txbSupervisorSolicitante.TabIndex = 10
        '
        'Pnl_SolPermisos
        '
        Me.Pnl_SolPermisos.Controls.Add(Me.Pnl_SolicitudPermisos)
        Me.Pnl_SolPermisos.Location = New System.Drawing.Point(568, 52)
        Me.Pnl_SolPermisos.Name = "Pnl_SolPermisos"
        Me.Pnl_SolPermisos.Size = New System.Drawing.Size(312, 219)
        Me.Pnl_SolPermisos.TabIndex = 41
        '
        'Pnl_SolicitudPermisos
        '
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.pnlModificar)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.chkDiaCompleto)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.pnlHora)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.cmbJefes)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.Label13)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.txbTramite)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.txbEmpresa)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.Label12)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.Label17)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.txbTrabajador)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.txbCargo)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.Label18)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.Label19)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.txbRut)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.txbFechaIngreso)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.lblArea)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.Label20)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.Label21)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.cmbAreas)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.Label22)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.Label23)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.dtpDia)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.gbTipoPermiso)
        Me.Pnl_SolicitudPermisos.Controls.Add(Me.btnAgregarSolicitud)
        Me.Pnl_SolicitudPermisos.Location = New System.Drawing.Point(12, 10)
        Me.Pnl_SolicitudPermisos.Name = "Pnl_SolicitudPermisos"
        Me.Pnl_SolicitudPermisos.Size = New System.Drawing.Size(952, 695)
        Me.Pnl_SolicitudPermisos.TabIndex = 59
        '
        'pnlModificar
        '
        Me.pnlModificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlModificar.Controls.Add(Me.ComboBox1)
        Me.pnlModificar.Controls.Add(Me.cmbModificarTrabajador)
        Me.pnlModificar.Controls.Add(Me.Label16)
        Me.pnlModificar.Controls.Add(Me.Label15)
        Me.pnlModificar.Controls.Add(Me.Label14)
        Me.pnlModificar.Location = New System.Drawing.Point(428, 55)
        Me.pnlModificar.Name = "pnlModificar"
        Me.pnlModificar.Size = New System.Drawing.Size(379, 266)
        Me.pnlModificar.TabIndex = 62
        Me.pnlModificar.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(91, 101)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'cmbModificarTrabajador
        '
        Me.cmbModificarTrabajador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModificarTrabajador.FormattingEnabled = True
        Me.cmbModificarTrabajador.Location = New System.Drawing.Point(91, 76)
        Me.cmbModificarTrabajador.Name = "cmbModificarTrabajador"
        Me.cmbModificarTrabajador.Size = New System.Drawing.Size(247, 21)
        Me.cmbModificarTrabajador.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(26, 103)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "N° Solicitud"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Trabajador"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Opciones Modificar"
        '
        'chkDiaCompleto
        '
        Me.chkDiaCompleto.AutoSize = True
        Me.chkDiaCompleto.Location = New System.Drawing.Point(274, 273)
        Me.chkDiaCompleto.Name = "chkDiaCompleto"
        Me.chkDiaCompleto.Size = New System.Drawing.Size(89, 17)
        Me.chkDiaCompleto.TabIndex = 61
        Me.chkDiaCompleto.Text = "Dia Completo"
        Me.chkDiaCompleto.UseVisualStyleBackColor = True
        '
        'pnlHora
        '
        Me.pnlHora.Controls.Add(Me.dtpHoraSalida)
        Me.pnlHora.Controls.Add(Me.Label10)
        Me.pnlHora.Controls.Add(Me.dtpHoraEntrada)
        Me.pnlHora.Controls.Add(Me.Label9)
        Me.pnlHora.Controls.Add(Me.txbTotalHoras)
        Me.pnlHora.Controls.Add(Me.Label11)
        Me.pnlHora.Location = New System.Drawing.Point(39, 297)
        Me.pnlHora.Name = "pnlHora"
        Me.pnlHora.Size = New System.Drawing.Size(257, 116)
        Me.pnlHora.TabIndex = 60
        '
        'dtpHoraSalida
        '
        Me.dtpHoraSalida.CustomFormat = "HH:mm"
        Me.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraSalida.Location = New System.Drawing.Point(87, 12)
        Me.dtpHoraSalida.Name = "dtpHoraSalida"
        Me.dtpHoraSalida.ShowUpDown = True
        Me.dtpHoraSalida.Size = New System.Drawing.Size(68, 20)
        Me.dtpHoraSalida.TabIndex = 45
        Me.dtpHoraSalida.Value = New Date(2017, 3, 28, 11, 7, 27, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Total Horas"
        '
        'dtpHoraEntrada
        '
        Me.dtpHoraEntrada.CustomFormat = "HH:mm"
        Me.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraEntrada.Location = New System.Drawing.Point(87, 44)
        Me.dtpHoraEntrada.Name = "dtpHoraEntrada"
        Me.dtpHoraEntrada.ShowUpDown = True
        Me.dtpHoraEntrada.Size = New System.Drawing.Size(68, 20)
        Me.dtpHoraEntrada.TabIndex = 46
        Me.dtpHoraEntrada.Value = New Date(2017, 3, 21, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Hora Entrada"
        '
        'txbTotalHoras
        '
        Me.txbTotalHoras.Location = New System.Drawing.Point(87, 75)
        Me.txbTotalHoras.Name = "txbTotalHoras"
        Me.txbTotalHoras.ReadOnly = True
        Me.txbTotalHoras.Size = New System.Drawing.Size(131, 20)
        Me.txbTotalHoras.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Hora Salida"
        '
        'cmbJefes
        '
        Me.cmbJefes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJefes.FormattingEnabled = True
        Me.cmbJefes.Location = New System.Drawing.Point(115, 207)
        Me.cmbJefes.Name = "cmbJefes"
        Me.cmbJefes.Size = New System.Drawing.Size(259, 21)
        Me.cmbJefes.TabIndex = 59
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 210)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Jefe Encargado"
        '
        'txbTramite
        '
        Me.txbTramite.Location = New System.Drawing.Point(428, 343)
        Me.txbTramite.Multiline = True
        Me.txbTramite.Name = "txbTramite"
        Me.txbTramite.ReadOnly = True
        Me.txbTramite.Size = New System.Drawing.Size(216, 64)
        Me.txbTramite.TabIndex = 26
        '
        'txbEmpresa
        '
        Me.txbEmpresa.Location = New System.Drawing.Point(115, 161)
        Me.txbEmpresa.Name = "txbEmpresa"
        Me.txbEmpresa.ReadOnly = True
        Me.txbEmpresa.Size = New System.Drawing.Size(259, 20)
        Me.txbEmpresa.TabIndex = 57
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Trabajador"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(28, 165)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 13)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = "Empresa"
        '
        'txbTrabajador
        '
        Me.txbTrabajador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txbTrabajador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txbTrabajador.Location = New System.Drawing.Point(115, 89)
        Me.txbTrabajador.Name = "txbTrabajador"
        Me.txbTrabajador.ReadOnly = True
        Me.txbTrabajador.Size = New System.Drawing.Size(259, 20)
        Me.txbTrabajador.TabIndex = 8
        '
        'txbCargo
        '
        Me.txbCargo.Location = New System.Drawing.Point(115, 137)
        Me.txbCargo.Name = "txbCargo"
        Me.txbCargo.ReadOnly = True
        Me.txbCargo.Size = New System.Drawing.Size(259, 20)
        Me.txbCargo.TabIndex = 55
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(28, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 13)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "RUT"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(28, 140)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 13)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "Cargo"
        '
        'txbRut
        '
        Me.txbRut.Location = New System.Drawing.Point(115, 113)
        Me.txbRut.Name = "txbRut"
        Me.txbRut.ReadOnly = True
        Me.txbRut.Size = New System.Drawing.Size(259, 20)
        Me.txbRut.TabIndex = 10
        '
        'txbFechaIngreso
        '
        Me.txbFechaIngreso.Location = New System.Drawing.Point(115, 184)
        Me.txbFechaIngreso.Name = "txbFechaIngreso"
        Me.txbFechaIngreso.ReadOnly = True
        Me.txbFechaIngreso.Size = New System.Drawing.Size(100, 20)
        Me.txbFechaIngreso.TabIndex = 53
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(221, 20)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(29, 13)
        Me.lblArea.TabIndex = 11
        Me.lblArea.Text = "Area"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(28, 188)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 13)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "Fecha Ingreso"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(112, 245)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(257, 13)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "ESTA AUTORIZADO PARA SALIR DE FÁBRICA EL"
        '
        'cmbAreas
        '
        Me.cmbAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreas.FormattingEnabled = True
        Me.cmbAreas.Location = New System.Drawing.Point(256, 20)
        Me.cmbAreas.Name = "cmbAreas"
        Me.cmbAreas.Size = New System.Drawing.Size(167, 21)
        Me.cmbAreas.TabIndex = 51
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(36, 277)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(25, 13)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Día"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(380, 343)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 13)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "Tramite:"
        '
        'dtpDia
        '
        Me.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDia.Location = New System.Drawing.Point(115, 271)
        Me.dtpDia.Name = "dtpDia"
        Me.dtpDia.Size = New System.Drawing.Size(99, 20)
        Me.dtpDia.TabIndex = 44
        Me.dtpDia.Value = New Date(2017, 3, 28, 0, 0, 0, 0)
        '
        'gbTipoPermiso
        '
        Me.gbTipoPermiso.Controls.Add(Me.rbPermisoParticular)
        Me.gbTipoPermiso.Controls.Add(Me.rbPermisoComisionServicio)
        Me.gbTipoPermiso.Location = New System.Drawing.Point(28, 6)
        Me.gbTipoPermiso.Name = "gbTipoPermiso"
        Me.gbTipoPermiso.Size = New System.Drawing.Size(161, 77)
        Me.gbTipoPermiso.TabIndex = 34
        Me.gbTipoPermiso.TabStop = False
        Me.gbTipoPermiso.Text = "Tipo de Permiso:"
        '
        'rbPermisoParticular
        '
        Me.rbPermisoParticular.AutoSize = True
        Me.rbPermisoParticular.Checked = True
        Me.rbPermisoParticular.Location = New System.Drawing.Point(6, 27)
        Me.rbPermisoParticular.Name = "rbPermisoParticular"
        Me.rbPermisoParticular.Size = New System.Drawing.Size(69, 17)
        Me.rbPermisoParticular.TabIndex = 29
        Me.rbPermisoParticular.TabStop = True
        Me.rbPermisoParticular.Text = "Particular"
        Me.rbPermisoParticular.UseVisualStyleBackColor = True
        '
        'rbPermisoComisionServicio
        '
        Me.rbPermisoComisionServicio.AutoSize = True
        Me.rbPermisoComisionServicio.Location = New System.Drawing.Point(6, 51)
        Me.rbPermisoComisionServicio.Name = "rbPermisoComisionServicio"
        Me.rbPermisoComisionServicio.Size = New System.Drawing.Size(108, 17)
        Me.rbPermisoComisionServicio.TabIndex = 30
        Me.rbPermisoComisionServicio.Text = "Comisión Servicio"
        Me.rbPermisoComisionServicio.UseVisualStyleBackColor = True
        '
        'btnAgregarSolicitud
        '
        Me.btnAgregarSolicitud.Location = New System.Drawing.Point(444, 8)
        Me.btnAgregarSolicitud.Name = "btnAgregarSolicitud"
        Me.btnAgregarSolicitud.Size = New System.Drawing.Size(239, 32)
        Me.btnAgregarSolicitud.TabIndex = 43
        Me.btnAgregarSolicitud.Text = "Agregar Solicitud"
        Me.btnAgregarSolicitud.UseVisualStyleBackColor = True
        '
        'Pnl_AutPermisos
        '
        Me.Pnl_AutPermisos.Controls.Add(Me.Pnl_Central)
        Me.Pnl_AutPermisos.Location = New System.Drawing.Point(260, 52)
        Me.Pnl_AutPermisos.Name = "Pnl_AutPermisos"
        Me.Pnl_AutPermisos.Size = New System.Drawing.Size(285, 219)
        Me.Pnl_AutPermisos.TabIndex = 40
        '
        'Pnl_Central
        '
        Me.Pnl_Central.Controls.Add(Me.chkVerPendientes)
        Me.Pnl_Central.Controls.Add(Me.dtpFechaTermino)
        Me.Pnl_Central.Controls.Add(Me.dtpFechaInicio)
        Me.Pnl_Central.Controls.Add(Me.Label7)
        Me.Pnl_Central.Controls.Add(Me.Label8)
        Me.Pnl_Central.Controls.Add(Me.dgvSolicitudesSalida)
        Me.Pnl_Central.Location = New System.Drawing.Point(69, 13)
        Me.Pnl_Central.Name = "Pnl_Central"
        Me.Pnl_Central.Size = New System.Drawing.Size(998, 332)
        Me.Pnl_Central.TabIndex = 3
        '
        'chkVerPendientes
        '
        Me.chkVerPendientes.AutoSize = True
        Me.chkVerPendientes.Location = New System.Drawing.Point(297, 42)
        Me.chkVerPendientes.Name = "chkVerPendientes"
        Me.chkVerPendientes.Size = New System.Drawing.Size(122, 17)
        Me.chkVerPendientes.TabIndex = 5
        Me.chkVerPendientes.Text = "Ver Solo Pendientes"
        Me.chkVerPendientes.UseVisualStyleBackColor = True
        '
        'dtpFechaTermino
        '
        Me.dtpFechaTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaTermino.Location = New System.Drawing.Point(669, 61)
        Me.dtpFechaTermino.Name = "dtpFechaTermino"
        Me.dtpFechaTermino.Size = New System.Drawing.Size(98, 20)
        Me.dtpFechaTermino.TabIndex = 4
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(668, 23)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(98, 20)
        Me.dtpFechaInicio.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(570, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Fecha de Termino"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(570, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Fecha de Inicio"
        '
        'dgvSolicitudesSalida
        '
        Me.dgvSolicitudesSalida.AllowUserToAddRows = False
        Me.dgvSolicitudesSalida.AllowUserToDeleteRows = False
        Me.dgvSolicitudesSalida.AllowUserToOrderColumns = True
        Me.dgvSolicitudesSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSolicitudesSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numeroSolicitud, Me.trabajador, Me.fechaInforme, Me.nombreSolicitante, Me.rutTrabajador, Me.cargoAutorizarPermiso, Me.empresa, Me.fechaSalida, Me.diaCompleto, Me.horaSalida, Me.horaEntrada, Me.horasTotales, Me.tipoPermiso, Me.btnAutorizarPermiso, Me.btnRechazarPermiso, Me.btnImprimirPermiso, Me.btnVerHistorial})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSolicitudesSalida.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvSolicitudesSalida.Location = New System.Drawing.Point(3, 87)
        Me.dgvSolicitudesSalida.Name = "dgvSolicitudesSalida"
        Me.dgvSolicitudesSalida.Size = New System.Drawing.Size(981, 314)
        Me.dgvSolicitudesSalida.TabIndex = 0
        '
        'numeroSolicitud
        '
        Me.numeroSolicitud.Frozen = True
        Me.numeroSolicitud.HeaderText = "N°"
        Me.numeroSolicitud.Name = "numeroSolicitud"
        Me.numeroSolicitud.ReadOnly = True
        Me.numeroSolicitud.Width = 30
        '
        'trabajador
        '
        Me.trabajador.Frozen = True
        Me.trabajador.HeaderText = "Trabajador"
        Me.trabajador.Name = "trabajador"
        Me.trabajador.ReadOnly = True
        Me.trabajador.Width = 200
        '
        'fechaInforme
        '
        Me.fechaInforme.HeaderText = "Fecha Solicitud"
        Me.fechaInforme.Name = "fechaInforme"
        Me.fechaInforme.Width = 65
        '
        'nombreSolicitante
        '
        Me.nombreSolicitante.HeaderText = "Solicitante"
        Me.nombreSolicitante.Name = "nombreSolicitante"
        Me.nombreSolicitante.ReadOnly = True
        '
        'rutTrabajador
        '
        Me.rutTrabajador.HeaderText = "RUT Trabajador"
        Me.rutTrabajador.Name = "rutTrabajador"
        Me.rutTrabajador.ReadOnly = True
        Me.rutTrabajador.Width = 65
        '
        'cargoAutorizarPermiso
        '
        Me.cargoAutorizarPermiso.HeaderText = "Cargo"
        Me.cargoAutorizarPermiso.Name = "cargoAutorizarPermiso"
        Me.cargoAutorizarPermiso.ReadOnly = True
        Me.cargoAutorizarPermiso.Width = 140
        '
        'empresa
        '
        Me.empresa.HeaderText = "Empresa"
        Me.empresa.Name = "empresa"
        Me.empresa.ReadOnly = True
        Me.empresa.Width = 80
        '
        'fechaSalida
        '
        Me.fechaSalida.HeaderText = "Fecha Salida"
        Me.fechaSalida.Name = "fechaSalida"
        Me.fechaSalida.ReadOnly = True
        Me.fechaSalida.Width = 65
        '
        'diaCompleto
        '
        Me.diaCompleto.HeaderText = "Dia Completo"
        Me.diaCompleto.Name = "diaCompleto"
        Me.diaCompleto.ReadOnly = True
        Me.diaCompleto.Width = 30
        '
        'horaSalida
        '
        Me.horaSalida.HeaderText = "Hora Salida"
        Me.horaSalida.Name = "horaSalida"
        Me.horaSalida.ReadOnly = True
        Me.horaSalida.Width = 35
        '
        'horaEntrada
        '
        Me.horaEntrada.HeaderText = "Hora Entrada"
        Me.horaEntrada.Name = "horaEntrada"
        Me.horaEntrada.ReadOnly = True
        Me.horaEntrada.Width = 35
        '
        'horasTotales
        '
        Me.horasTotales.HeaderText = "Horas Totales"
        Me.horasTotales.Name = "horasTotales"
        Me.horasTotales.ReadOnly = True
        Me.horasTotales.Width = 35
        '
        'tipoPermiso
        '
        Me.tipoPermiso.HeaderText = "Tipo de Permiso"
        Me.tipoPermiso.Name = "tipoPermiso"
        Me.tipoPermiso.ReadOnly = True
        Me.tipoPermiso.Width = 70
        '
        'btnAutorizarPermiso
        '
        Me.btnAutorizarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutorizarPermiso.HeaderText = "Autorizar"
        Me.btnAutorizarPermiso.Name = "btnAutorizarPermiso"
        Me.btnAutorizarPermiso.Text = "Autorizar"
        Me.btnAutorizarPermiso.UseColumnTextForButtonValue = True
        Me.btnAutorizarPermiso.Width = 68
        '
        'btnRechazarPermiso
        '
        Me.btnRechazarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRechazarPermiso.HeaderText = "Rechazar"
        Me.btnRechazarPermiso.Name = "btnRechazarPermiso"
        Me.btnRechazarPermiso.Text = "Rechazar"
        Me.btnRechazarPermiso.UseColumnTextForButtonValue = True
        Me.btnRechazarPermiso.Width = 68
        '
        'btnImprimirPermiso
        '
        Me.btnImprimirPermiso.HeaderText = "Imprimir"
        Me.btnImprimirPermiso.Name = "btnImprimirPermiso"
        Me.btnImprimirPermiso.ReadOnly = True
        Me.btnImprimirPermiso.Text = "Imprimir"
        Me.btnImprimirPermiso.UseColumnTextForButtonValue = True
        Me.btnImprimirPermiso.Width = 68
        '
        'btnVerHistorial
        '
        Me.btnVerHistorial.HeaderText = "Ver Historial"
        Me.btnVerHistorial.Name = "btnVerHistorial"
        Me.btnVerHistorial.Text = "Ver Historial"
        Me.btnVerHistorial.UseColumnTextForButtonValue = True
        Me.btnVerHistorial.Width = 68
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Titulo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Lbl_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo.Location = New System.Drawing.Point(2, 24)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl_Titulo.Size = New System.Drawing.Size(1699, 25)
        Me.Lbl_Titulo.TabIndex = 5
        Me.Lbl_Titulo.Text = "Lbl_Titulo Seleccion"
        Me.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Location = New System.Drawing.Point(2, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1702, 21)
        Me.Panel3.TabIndex = 39
        '
        'FrmSolicPermHrasExt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1908, 1045)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.Name = "FrmSolicPermHrasExt"
        Me.Text = "FrmSolicPermHrasExt"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Pnl_InformePermisos.ResumeLayout(False)
        Me.Pnl_InformePermisos.PerformLayout()
        CType(Me.dgvSolicitudesSalidaInformePermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_InformeHHEE.ResumeLayout(False)
        Me.Pnl_InformeHHEE.PerformLayout()
        CType(Me.dgvColaboradoresInformeHHEE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_AutHrExt.ResumeLayout(False)
        Me.Pnl_AutHrExt.PerformLayout()
        CType(Me.dgvColaboradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_SolHrasExt.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dgvColaboradoresSHHEE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_SolPermisos.ResumeLayout(False)
        Me.Pnl_SolicitudPermisos.ResumeLayout(False)
        Me.Pnl_SolicitudPermisos.PerformLayout()
        Me.pnlModificar.ResumeLayout(False)
        Me.pnlModificar.PerformLayout()
        Me.pnlHora.ResumeLayout(False)
        Me.pnlHora.PerformLayout()
        Me.gbTipoPermiso.ResumeLayout(False)
        Me.gbTipoPermiso.PerformLayout()
        Me.Pnl_AutPermisos.ResumeLayout(False)
        Me.Pnl_Central.ResumeLayout(False)
        Me.Pnl_Central.PerformLayout()
        CType(Me.dgvSolicitudesSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Pnl_AutHrExt As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTermino As DateTimePicker
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents btnImprimir As Button
    Friend WithEvents chkTodas As CheckBox
    Friend WithEvents txbSolicitante As TextBox
    Friend WithEvents txbFecha As TextBox
    Friend WithEvents btnRechazarTodas As Button
    Friend WithEvents btnAutorizarTodas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvColaboradores As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbNumeroSolicitud As ComboBox
    Friend WithEvents txbDetalle As TextBox
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Lbl_Titulo As Label
    Friend WithEvents Pnl_AutPermisos As Panel
    Friend WithEvents Pnl_Central As Panel
    Friend WithEvents chkVerPendientes As CheckBox
    Friend WithEvents dtpFechaTermino As DateTimePicker
    Friend WithEvents btnVolver As Button
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvSolicitudesSalida As DataGridView
    Friend WithEvents Pnl_SolPermisos As Panel
    Friend WithEvents Pnl_SolHrasExt As Panel
    Friend WithEvents Pnl_SolicitudPermisos As Panel
    Friend WithEvents pnlModificar As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cmbModificarTrabajador As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents chkDiaCompleto As CheckBox
    Friend WithEvents pnlHora As Panel
    Friend WithEvents dtpHoraSalida As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpHoraEntrada As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents txbTotalHoras As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbJefes As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txbTramite As TextBox
    Friend WithEvents txbEmpresa As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txbTrabajador As TextBox
    Friend WithEvents txbCargo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txbRut As TextBox
    Friend WithEvents txbFechaIngreso As TextBox
    Friend WithEvents lblArea As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbAreas As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents dtpDia As DateTimePicker
    Friend WithEvents gbTipoPermiso As GroupBox
    Friend WithEvents rbPermisoParticular As RadioButton
    Friend WithEvents rbPermisoComisionServicio As RadioButton
    Friend WithEvents btnAgregarSolicitud As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents dgvColaboradoresSHHEE As DataGridView
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents TxtBxDetalleSHX As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txbHorasExtras As TextBox
    Friend WithEvents txbSupervisorSolicitante As TextBox
    Friend WithEvents numeroSolicitarHHEE As DataGridViewTextBoxColumn
    Friend WithEvents nombreColaborador As DataGridViewTextBoxColumn
    Friend WithEvents rutSolicitarHHEE As DataGridViewTextBoxColumn
    Friend WithEvents cargoSolicitarHHEE As DataGridViewTextBoxColumn
    Friend WithEvents nombreEmpresaSolicitarHHEE As DataGridViewTextBoxColumn
    Friend WithEvents horaInicioSolicitarHHEE As DataGridViewTextBoxColumn
    Friend WithEvents horaTerminoSolicitarHHEE As DataGridViewTextBoxColumn
    Friend WithEvents cantidadHoras As DataGridViewTextBoxColumn
    Friend WithEvents fechaRealSolicitarHHEE As DataGridViewTextBoxColumn
    Friend WithEvents btnEliminar As DataGridViewButtonColumn
    Friend WithEvents numeroSolicitud As DataGridViewTextBoxColumn
    Friend WithEvents trabajador As DataGridViewTextBoxColumn
    Friend WithEvents fechaInforme As DataGridViewTextBoxColumn
    Friend WithEvents nombreSolicitante As DataGridViewTextBoxColumn
    Friend WithEvents rutTrabajador As DataGridViewTextBoxColumn
    Friend WithEvents cargoAutorizarPermiso As DataGridViewTextBoxColumn
    Friend WithEvents empresa As DataGridViewTextBoxColumn
    Friend WithEvents fechaSalida As DataGridViewTextBoxColumn
    Friend WithEvents diaCompleto As DataGridViewTextBoxColumn
    Friend WithEvents horaSalida As DataGridViewTextBoxColumn
    Friend WithEvents horaEntrada As DataGridViewTextBoxColumn
    Friend WithEvents horasTotales As DataGridViewTextBoxColumn
    Friend WithEvents tipoPermiso As DataGridViewTextBoxColumn
    Friend WithEvents btnAutorizarPermiso As DataGridViewButtonColumn
    Friend WithEvents btnRechazarPermiso As DataGridViewButtonColumn
    Friend WithEvents btnImprimirPermiso As DataGridViewButtonColumn
    Friend WithEvents btnVerHistorial As DataGridViewButtonColumn
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents nombreColaboradores As DataGridViewTextBoxColumn
    Friend WithEvents rut As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents nombreEmpresa As DataGridViewTextBoxColumn
    Friend WithEvents horaInicio As DataGridViewTextBoxColumn
    Friend WithEvents horaTermino As DataGridViewTextBoxColumn
    Friend WithEvents fechaReal As DataGridViewTextBoxColumn
    Friend WithEvents btnAutorizar As DataGridViewButtonColumn
    Friend WithEvents btnRechazar As DataGridViewButtonColumn
    Friend WithEvents Pnl_InformeHHEE As Panel
    Private WithEvents btnBuscarInformeHHEE As Button
    Friend WithEvents dgvColaboradoresInformeHHEE As DataGridView
    Friend WithEvents colNumeroInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colNombreColaboradoresInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colRutInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colDepartamentoInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colCargoInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colHoraInicioInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colHoraTerminoInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colTotalHorasExtrasInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colFechaRealInformeHHEE As DataGridViewTextBoxColumn
    Private WithEvents txbTotalEmpleadosInformeHHEE As TextBox
    Friend WithEvents Label31 As Label
    Private WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Private WithEvents chkTodaEmpresaInformeHHEE As CheckBox
    Friend WithEvents cmbEmpresaInformeHHEE As ComboBox
    Private WithEvents lblHHEEAcumuladasInformeHHEE As Label
    Friend WithEvents dtpInicioInformeHHEE As DateTimePicker
    Private WithEvents txbHHEEAcumuladasInformeHHEE As TextBox
    Friend WithEvents lblEmpresaInformeHHEE As Label
    Private WithEvents btnImprimirInformeHHEE As Button
    Friend WithEvents dtpTerminoInformeHHEE As DateTimePicker
    Friend WithEvents lblNombreInformeHHEE As Label
    Private WithEvents chkBuscarTodosInformeHHEE As CheckBox
    Friend WithEvents lblRutInformeHHEE As Label
    Friend WithEvents txbRutInformeHHEE As TextBox
    Friend WithEvents txbNombreInformeHHEE As TextBox
    Friend WithEvents Pnl_InformePermisos As Panel
    Friend WithEvents lblNombreInformePermisos As Label
    Friend WithEvents Label34 As Label
    Private WithEvents chkBuscarTodosInformePermisos As CheckBox
    Friend WithEvents Label35 As Label
    Private WithEvents btnImprimirInformePermisos As Button
    Friend WithEvents cmbEmpresaInformePermisos As ComboBox
    Private WithEvents btnBuscarInformePermisos As Button
    Friend WithEvents dtpInicioInformePermisos As DateTimePicker
    Friend WithEvents txbRutInformePermisos As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents txbNombreInformePermisos As TextBox
    Friend WithEvents dtpTerminoInformePermisos As DateTimePicker
    Friend WithEvents lblRutInformePermisos As Label
    Friend WithEvents dgvSolicitudesSalidaInformePermisos As DataGridView
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

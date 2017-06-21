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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solicitud de Permisos")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solicitud de Hr. Extras")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solicitudes                            ", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autorizaciòn de Permisos")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autorizacion Horas Extras")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autorizaciones                      ", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe Permisos")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe Horas Extras")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe                                 ", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8})
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSolicPermHrasExt))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New Kesoft.Windows.Forms.Win7StyleTreeView.Win7StyleTreeView(Me.components)
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.pnlCentral = New System.Windows.Forms.Panel()
        Me.BtnVolver2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Pnl_SolPermisos = New System.Windows.Forms.Panel()
        Me.Pnl_SolicitudPermisos = New System.Windows.Forms.Panel()
        Me.pnlModificar = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.cmbModificarTrabajador = New MetroFramework.Controls.MetroComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkDiaCompleto = New MetroFramework.Controls.MetroCheckBox()
        Me.pnlHora = New System.Windows.Forms.Panel()
        Me.dtpHoraSalida = New MetroFramework.Controls.MetroDateTime()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpHoraEntrada = New MetroFramework.Controls.MetroDateTime()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txbTotalHoras = New MetroFramework.Controls.MetroTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbJefes = New MetroFramework.Controls.MetroComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txbTramite = New MetroFramework.Controls.MetroTextBox()
        Me.txbEmpresa = New MetroFramework.Controls.MetroTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txbTrabajador = New MetroFramework.Controls.MetroTextBox()
        Me.txbCargo = New MetroFramework.Controls.MetroTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txbRut = New MetroFramework.Controls.MetroTextBox()
        Me.txbFechaIngreso = New MetroFramework.Controls.MetroTextBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbAreas = New MetroFramework.Controls.MetroComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dtpDia = New MetroFramework.Controls.MetroDateTime()
        Me.gbTipoPermiso = New System.Windows.Forms.GroupBox()
        Me.rbPermisoParticular = New System.Windows.Forms.RadioButton()
        Me.rbPermisoComisionServicio = New System.Windows.Forms.RadioButton()
        Me.btnAgregarSolicitud = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Pnl_SolHrasExt = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dtpfech = New MetroFramework.Controls.MetroDateTime()
        Me.ComboBox2 = New MetroFramework.Controls.MetroComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.ComboBox3 = New MetroFramework.Controls.MetroComboBox()
        Me.dgvColaboradoresSHHEE = New MetroFramework.Controls.MetroGrid()
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
        Me.TxtBxDetalleSHX = New MetroFramework.Controls.MetroTextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txbHorasExtras = New MetroFramework.Controls.MetroTextBox()
        Me.txbSupervisorSolicitante = New MetroFramework.Controls.MetroTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Pnl_AutPermisos = New System.Windows.Forms.Panel()
        Me.Pnl_Central = New System.Windows.Forms.Panel()
        Me.chkVerPendientes = New MetroFramework.Controls.MetroCheckBox()
        Me.dtpFechaTermino = New MetroFramework.Controls.MetroDateTime()
        Me.dtpFechaInicio = New MetroFramework.Controls.MetroDateTime()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvSolicitudesSalida = New MetroFramework.Controls.MetroGrid()
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
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Pnl_AutHrExt = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTermino = New MetroFramework.Controls.MetroDateTime()
        Me.dtpInicio = New MetroFramework.Controls.MetroDateTime()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.chkTodas = New MetroFramework.Controls.MetroCheckBox()
        Me.txbSolicitante = New MetroFramework.Controls.MetroTextBox()
        Me.txbFecha = New MetroFramework.Controls.MetroTextBox()
        Me.btnRechazarTodas = New System.Windows.Forms.Button()
        Me.btnAutorizarTodas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvColaboradores = New MetroFramework.Controls.MetroGrid()
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
        Me.cmbNumeroSolicitud = New MetroFramework.Controls.MetroComboBox()
        Me.txbDetalle = New MetroFramework.Controls.MetroTextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Pnl_InformePermisos = New System.Windows.Forms.Panel()
        Me.btnExportarExcelPermiso = New System.Windows.Forms.Button()
        Me.lblNombreInformePermisos = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.chkBuscarTodosInformePermisos = New MetroFramework.Controls.MetroCheckBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.btnImprimirInformePermisos = New System.Windows.Forms.Button()
        Me.cmbEmpresaInformePermisos = New MetroFramework.Controls.MetroComboBox()
        Me.btnBuscarInformePermisos = New System.Windows.Forms.Button()
        Me.dtpInicioInformePermisos = New MetroFramework.Controls.MetroDateTime()
        Me.txbRutInformePermisos = New MetroFramework.Controls.MetroTextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txbNombreInformePermisos = New MetroFramework.Controls.MetroTextBox()
        Me.dtpTerminoInformePermisos = New MetroFramework.Controls.MetroDateTime()
        Me.lblRutInformePermisos = New System.Windows.Forms.Label()
        Me.dgvSolicitudesSalidaInformePermisos = New MetroFramework.Controls.MetroGrid()
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
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Pnl_InformeHHEE = New System.Windows.Forms.Panel()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.btnBuscarInformeHHEE = New System.Windows.Forms.Button()
        Me.dgvColaboradoresInformeHHEE = New MetroFramework.Controls.MetroGrid()
        Me.colNumeroInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreColaboradoresInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRutInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDepartamentoInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCargoInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraInicioInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraTerminoInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalHorasExtrasInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaRealInformeHHEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txbTotalEmpleadosInformeHHEE = New MetroFramework.Controls.MetroTextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.chkTodaEmpresaInformeHHEE = New MetroFramework.Controls.MetroCheckBox()
        Me.cmbEmpresaInformeHHEE = New MetroFramework.Controls.MetroComboBox()
        Me.lblHHEEAcumuladasInformeHHEE = New System.Windows.Forms.Label()
        Me.dtpInicioInformeHHEE = New MetroFramework.Controls.MetroDateTime()
        Me.txbHHEEAcumuladasInformeHHEE = New MetroFramework.Controls.MetroTextBox()
        Me.lblEmpresaInformeHHEE = New System.Windows.Forms.Label()
        Me.btnImprimirInformeHHEE = New System.Windows.Forms.Button()
        Me.dtpTerminoInformeHHEE = New MetroFramework.Controls.MetroDateTime()
        Me.lblNombreInformeHHEE = New System.Windows.Forms.Label()
        Me.chkBuscarTodosInformeHHEE = New MetroFramework.Controls.MetroCheckBox()
        Me.lblRutInformeHHEE = New System.Windows.Forms.Label()
        Me.txbRutInformeHHEE = New MetroFramework.Controls.MetroTextBox()
        Me.txbNombreInformeHHEE = New MetroFramework.Controls.MetroTextBox()
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlCentral.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Pnl_SolPermisos.SuspendLayout()
        Me.Pnl_SolicitudPermisos.SuspendLayout()
        Me.pnlModificar.SuspendLayout()
        Me.pnlHora.SuspendLayout()
        Me.gbTipoPermiso.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Pnl_SolHrasExt.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvColaboradoresSHHEE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Pnl_AutPermisos.SuspendLayout()
        Me.Pnl_Central.SuspendLayout()
        CType(Me.dgvSolicitudesSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.Pnl_AutHrExt.SuspendLayout()
        CType(Me.dgvColaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.Pnl_InformePermisos.SuspendLayout()
        CType(Me.dgvSolicitudesSalidaInformePermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.Pnl_InformeHHEE.SuspendLayout()
        CType(Me.dgvColaboradoresInformeHHEE, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnVolver)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlCentral)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Lbl_Titulo)
        Me.SplitContainer1.Size = New System.Drawing.Size(1908, 798)
        Me.SplitContainer1.SplitterDistance = 246
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TreeView1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ForeColor = System.Drawing.Color.White
        Me.TreeView1.HotTracking = True
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Nd_SolPermisos"
        TreeNode1.Text = "Solicitud de Permisos"
        TreeNode2.Name = "Nd_SolHrExt"
        TreeNode2.Text = "Solicitud de Hr. Extras"
        TreeNode3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        TreeNode3.ForeColor = System.Drawing.Color.White
        TreeNode3.Name = "Nodo0"
        TreeNode3.Text = "Solicitudes                            "
        TreeNode4.Name = "Nd_AutPermisos"
        TreeNode4.Text = "Autorizaciòn de Permisos"
        TreeNode5.Name = "Nd_AutHrExt"
        TreeNode5.Text = "Autorizacion Horas Extras"
        TreeNode6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        TreeNode6.ForeColor = System.Drawing.Color.White
        TreeNode6.Name = "Nodo2"
        TreeNode6.Text = "Autorizaciones                      "
        TreeNode7.Name = "Nd_InformePermisos"
        TreeNode7.Text = "Informe Permisos"
        TreeNode8.Name = "Nd_InformeHorasExtras"
        TreeNode8.Text = "Informe Horas Extras"
        TreeNode9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        TreeNode9.ForeColor = System.Drawing.Color.White
        TreeNode9.Name = "Nodo1"
        TreeNode9.Text = "Informe                                 "
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6, TreeNode9})
        Me.TreeView1.ShowLines = False
        Me.TreeView1.Size = New System.Drawing.Size(243, 715)
        Me.TreeView1.TabIndex = 1
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVolver.Image = Global.RRHH.My.Resources.Resources.home_shape64
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnVolver.Location = New System.Drawing.Point(1, 716)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(242, 80)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Al Inicio"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'pnlCentral
        '
        Me.pnlCentral.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCentral.Controls.Add(Me.BtnVolver2)
        Me.pnlCentral.Controls.Add(Me.TabControl1)
        Me.pnlCentral.Location = New System.Drawing.Point(4, 53)
        Me.pnlCentral.Name = "pnlCentral"
        Me.pnlCentral.Size = New System.Drawing.Size(1621, 740)
        Me.pnlCentral.TabIndex = 47
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
        Me.BtnVolver2.Location = New System.Drawing.Point(4, 655)
        Me.BtnVolver2.Name = "BtnVolver2"
        Me.BtnVolver2.Size = New System.Drawing.Size(195, 80)
        Me.BtnVolver2.TabIndex = 47
        Me.BtnVolver2.Text = "Volver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Al Inicio"
        Me.BtnVolver2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnVolver2.UseVisualStyleBackColor = False
        Me.BtnVolver2.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(4, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1614, 711)
        Me.TabControl1.TabIndex = 62
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Pnl_SolPermisos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1606, 685)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Solicitud Permiso"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Pnl_SolPermisos
        '
        Me.Pnl_SolPermisos.BackColor = System.Drawing.Color.White
        Me.Pnl_SolPermisos.Controls.Add(Me.Pnl_SolicitudPermisos)
        Me.Pnl_SolPermisos.Location = New System.Drawing.Point(15, 16)
        Me.Pnl_SolPermisos.Name = "Pnl_SolPermisos"
        Me.Pnl_SolPermisos.Size = New System.Drawing.Size(947, 514)
        Me.Pnl_SolPermisos.TabIndex = 41
        '
        'Pnl_SolicitudPermisos
        '
        Me.Pnl_SolicitudPermisos.BackColor = System.Drawing.Color.White
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
        Me.Pnl_SolicitudPermisos.Location = New System.Drawing.Point(6, 5)
        Me.Pnl_SolicitudPermisos.Name = "Pnl_SolicitudPermisos"
        Me.Pnl_SolicitudPermisos.Size = New System.Drawing.Size(952, 565)
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
        Me.pnlModificar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlModificar.Location = New System.Drawing.Point(442, 114)
        Me.pnlModificar.Name = "pnlModificar"
        Me.pnlModificar.Size = New System.Drawing.Size(379, 158)
        Me.pnlModificar.TabIndex = 62
        Me.pnlModificar.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 23
        Me.ComboBox1.Location = New System.Drawing.Point(112, 102)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(247, 29)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.UseSelectable = True
        '
        'cmbModificarTrabajador
        '
        Me.cmbModificarTrabajador.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModificarTrabajador.FormattingEnabled = True
        Me.cmbModificarTrabajador.ItemHeight = 23
        Me.cmbModificarTrabajador.Location = New System.Drawing.Point(112, 68)
        Me.cmbModificarTrabajador.Name = "cmbModificarTrabajador"
        Me.cmbModificarTrabajador.Size = New System.Drawing.Size(247, 29)
        Me.cmbModificarTrabajador.TabIndex = 3
        Me.cmbModificarTrabajador.UseSelectable = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(20, 107)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 17)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "N° Solicitud"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 17)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Trabajador"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Opciones Modificar"
        '
        'chkDiaCompleto
        '
        Me.chkDiaCompleto.AutoSize = True
        Me.chkDiaCompleto.Location = New System.Drawing.Point(273, 338)
        Me.chkDiaCompleto.Name = "chkDiaCompleto"
        Me.chkDiaCompleto.Size = New System.Drawing.Size(96, 15)
        Me.chkDiaCompleto.TabIndex = 61
        Me.chkDiaCompleto.Text = "Dia Completo"
        Me.chkDiaCompleto.UseSelectable = True
        '
        'pnlHora
        '
        Me.pnlHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHora.Controls.Add(Me.dtpHoraSalida)
        Me.pnlHora.Controls.Add(Me.Label10)
        Me.pnlHora.Controls.Add(Me.dtpHoraEntrada)
        Me.pnlHora.Controls.Add(Me.Label9)
        Me.pnlHora.Controls.Add(Me.txbTotalHoras)
        Me.pnlHora.Controls.Add(Me.Label11)
        Me.pnlHora.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlHora.Location = New System.Drawing.Point(41, 370)
        Me.pnlHora.Name = "pnlHora"
        Me.pnlHora.Size = New System.Drawing.Size(362, 120)
        Me.pnlHora.TabIndex = 60
        '
        'dtpHoraSalida
        '
        Me.dtpHoraSalida.CustomFormat = "HH:mm"
        Me.dtpHoraSalida.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraSalida.Location = New System.Drawing.Point(117, 12)
        Me.dtpHoraSalida.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpHoraSalida.Name = "dtpHoraSalida"
        Me.dtpHoraSalida.Size = New System.Drawing.Size(74, 29)
        Me.dtpHoraSalida.TabIndex = 45
        Me.dtpHoraSalida.Value = New Date(2017, 3, 28, 11, 7, 27, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Total Horas"
        '
        'dtpHoraEntrada
        '
        Me.dtpHoraEntrada.CustomFormat = "HH:mm"
        Me.dtpHoraEntrada.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraEntrada.Location = New System.Drawing.Point(117, 47)
        Me.dtpHoraEntrada.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpHoraEntrada.Name = "dtpHoraEntrada"
        Me.dtpHoraEntrada.Size = New System.Drawing.Size(74, 29)
        Me.dtpHoraEntrada.TabIndex = 46
        Me.dtpHoraEntrada.Value = New Date(2017, 3, 21, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Hora Entrada"
        '
        'txbTotalHoras
        '
        '
        '
        '
        Me.txbTotalHoras.CustomButton.Image = Nothing
        Me.txbTotalHoras.CustomButton.Location = New System.Drawing.Point(146, 1)
        Me.txbTotalHoras.CustomButton.Name = ""
        Me.txbTotalHoras.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txbTotalHoras.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbTotalHoras.CustomButton.TabIndex = 1
        Me.txbTotalHoras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbTotalHoras.CustomButton.UseSelectable = True
        Me.txbTotalHoras.CustomButton.Visible = False
        Me.txbTotalHoras.Lines = New String(-1) {}
        Me.txbTotalHoras.Location = New System.Drawing.Point(117, 82)
        Me.txbTotalHoras.MaxLength = 32767
        Me.txbTotalHoras.Name = "txbTotalHoras"
        Me.txbTotalHoras.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbTotalHoras.ReadOnly = True
        Me.txbTotalHoras.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbTotalHoras.SelectedText = ""
        Me.txbTotalHoras.SelectionLength = 0
        Me.txbTotalHoras.SelectionStart = 0
        Me.txbTotalHoras.ShortcutsEnabled = True
        Me.txbTotalHoras.Size = New System.Drawing.Size(170, 25)
        Me.txbTotalHoras.TabIndex = 47
        Me.txbTotalHoras.UseSelectable = True
        Me.txbTotalHoras.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbTotalHoras.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Hora Salida"
        '
        'cmbJefes
        '
        Me.cmbJefes.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJefes.FormattingEnabled = True
        Me.cmbJefes.ItemHeight = 23
        Me.cmbJefes.Location = New System.Drawing.Point(133, 248)
        Me.cmbJefes.Name = "cmbJefes"
        Me.cmbJefes.Size = New System.Drawing.Size(293, 29)
        Me.cmbJefes.TabIndex = 59
        Me.cmbJefes.UseSelectable = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(28, 252)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 17)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Jefe Encargado"
        '
        'txbTramite
        '
        '
        '
        '
        Me.txbTramite.CustomButton.Image = Nothing
        Me.txbTramite.CustomButton.Location = New System.Drawing.Point(255, 2)
        Me.txbTramite.CustomButton.Name = ""
        Me.txbTramite.CustomButton.Size = New System.Drawing.Size(59, 59)
        Me.txbTramite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbTramite.CustomButton.TabIndex = 1
        Me.txbTramite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbTramite.CustomButton.UseSelectable = True
        Me.txbTramite.CustomButton.Visible = False
        Me.txbTramite.Lines = New String(-1) {}
        Me.txbTramite.Location = New System.Drawing.Point(504, 306)
        Me.txbTramite.MaxLength = 32767
        Me.txbTramite.Multiline = True
        Me.txbTramite.Name = "txbTramite"
        Me.txbTramite.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbTramite.ReadOnly = True
        Me.txbTramite.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbTramite.SelectedText = ""
        Me.txbTramite.SelectionLength = 0
        Me.txbTramite.SelectionStart = 0
        Me.txbTramite.ShortcutsEnabled = True
        Me.txbTramite.Size = New System.Drawing.Size(317, 64)
        Me.txbTramite.TabIndex = 26
        Me.txbTramite.UseSelectable = True
        Me.txbTramite.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbTramite.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txbEmpresa
        '
        '
        '
        '
        Me.txbEmpresa.CustomButton.Image = Nothing
        Me.txbEmpresa.CustomButton.Location = New System.Drawing.Point(269, 1)
        Me.txbEmpresa.CustomButton.Name = ""
        Me.txbEmpresa.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txbEmpresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbEmpresa.CustomButton.TabIndex = 1
        Me.txbEmpresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbEmpresa.CustomButton.UseSelectable = True
        Me.txbEmpresa.CustomButton.Visible = False
        Me.txbEmpresa.Lines = New String(-1) {}
        Me.txbEmpresa.Location = New System.Drawing.Point(133, 186)
        Me.txbEmpresa.MaxLength = 32767
        Me.txbEmpresa.Name = "txbEmpresa"
        Me.txbEmpresa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbEmpresa.ReadOnly = True
        Me.txbEmpresa.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbEmpresa.SelectedText = ""
        Me.txbEmpresa.SelectionLength = 0
        Me.txbEmpresa.SelectionStart = 0
        Me.txbEmpresa.ShortcutsEnabled = True
        Me.txbEmpresa.Size = New System.Drawing.Size(293, 25)
        Me.txbEmpresa.TabIndex = 57
        Me.txbEmpresa.UseSelectable = True
        Me.txbEmpresa.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbEmpresa.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(28, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 17)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Trabajador"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(28, 190)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 17)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = "Empresa"
        '
        'txbTrabajador
        '
        Me.txbTrabajador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txbTrabajador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txbTrabajador.CustomButton.Image = Nothing
        Me.txbTrabajador.CustomButton.Location = New System.Drawing.Point(269, 1)
        Me.txbTrabajador.CustomButton.Name = ""
        Me.txbTrabajador.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txbTrabajador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbTrabajador.CustomButton.TabIndex = 1
        Me.txbTrabajador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbTrabajador.CustomButton.UseSelectable = True
        Me.txbTrabajador.CustomButton.Visible = False
        Me.txbTrabajador.Lines = New String(-1) {}
        Me.txbTrabajador.Location = New System.Drawing.Point(133, 93)
        Me.txbTrabajador.MaxLength = 32767
        Me.txbTrabajador.Name = "txbTrabajador"
        Me.txbTrabajador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbTrabajador.ReadOnly = True
        Me.txbTrabajador.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbTrabajador.SelectedText = ""
        Me.txbTrabajador.SelectionLength = 0
        Me.txbTrabajador.SelectionStart = 0
        Me.txbTrabajador.ShortcutsEnabled = True
        Me.txbTrabajador.Size = New System.Drawing.Size(293, 25)
        Me.txbTrabajador.TabIndex = 8
        Me.txbTrabajador.UseSelectable = True
        Me.txbTrabajador.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbTrabajador.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txbCargo
        '
        '
        '
        '
        Me.txbCargo.CustomButton.Image = Nothing
        Me.txbCargo.CustomButton.Location = New System.Drawing.Point(269, 1)
        Me.txbCargo.CustomButton.Name = ""
        Me.txbCargo.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txbCargo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbCargo.CustomButton.TabIndex = 1
        Me.txbCargo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbCargo.CustomButton.UseSelectable = True
        Me.txbCargo.CustomButton.Visible = False
        Me.txbCargo.Lines = New String(-1) {}
        Me.txbCargo.Location = New System.Drawing.Point(133, 155)
        Me.txbCargo.MaxLength = 32767
        Me.txbCargo.Name = "txbCargo"
        Me.txbCargo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbCargo.ReadOnly = True
        Me.txbCargo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbCargo.SelectedText = ""
        Me.txbCargo.SelectionLength = 0
        Me.txbCargo.SelectionStart = 0
        Me.txbCargo.ShortcutsEnabled = True
        Me.txbCargo.Size = New System.Drawing.Size(293, 25)
        Me.txbCargo.TabIndex = 55
        Me.txbCargo.UseSelectable = True
        Me.txbCargo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbCargo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(28, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 17)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "RUT"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(28, 159)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 17)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "Cargo"
        '
        'txbRut
        '
        '
        '
        '
        Me.txbRut.CustomButton.Image = Nothing
        Me.txbRut.CustomButton.Location = New System.Drawing.Point(269, 1)
        Me.txbRut.CustomButton.Name = ""
        Me.txbRut.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txbRut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbRut.CustomButton.TabIndex = 1
        Me.txbRut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbRut.CustomButton.UseSelectable = True
        Me.txbRut.CustomButton.Visible = False
        Me.txbRut.Lines = New String(-1) {}
        Me.txbRut.Location = New System.Drawing.Point(133, 124)
        Me.txbRut.MaxLength = 32767
        Me.txbRut.Name = "txbRut"
        Me.txbRut.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbRut.ReadOnly = True
        Me.txbRut.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbRut.SelectedText = ""
        Me.txbRut.SelectionLength = 0
        Me.txbRut.SelectionStart = 0
        Me.txbRut.ShortcutsEnabled = True
        Me.txbRut.Size = New System.Drawing.Size(293, 25)
        Me.txbRut.TabIndex = 10
        Me.txbRut.UseSelectable = True
        Me.txbRut.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbRut.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txbFechaIngreso
        '
        '
        '
        '
        Me.txbFechaIngreso.CustomButton.Image = Nothing
        Me.txbFechaIngreso.CustomButton.Location = New System.Drawing.Point(98, 1)
        Me.txbFechaIngreso.CustomButton.Name = ""
        Me.txbFechaIngreso.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txbFechaIngreso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbFechaIngreso.CustomButton.TabIndex = 1
        Me.txbFechaIngreso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbFechaIngreso.CustomButton.UseSelectable = True
        Me.txbFechaIngreso.CustomButton.Visible = False
        Me.txbFechaIngreso.Lines = New String(-1) {}
        Me.txbFechaIngreso.Location = New System.Drawing.Point(133, 217)
        Me.txbFechaIngreso.MaxLength = 32767
        Me.txbFechaIngreso.Name = "txbFechaIngreso"
        Me.txbFechaIngreso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbFechaIngreso.ReadOnly = True
        Me.txbFechaIngreso.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbFechaIngreso.SelectedText = ""
        Me.txbFechaIngreso.SelectionLength = 0
        Me.txbFechaIngreso.SelectionStart = 0
        Me.txbFechaIngreso.ShortcutsEnabled = True
        Me.txbFechaIngreso.Size = New System.Drawing.Size(122, 25)
        Me.txbFechaIngreso.TabIndex = 53
        Me.txbFechaIngreso.UseSelectable = True
        Me.txbFechaIngreso.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbFechaIngreso.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(194, 29)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(36, 17)
        Me.lblArea.TabIndex = 11
        Me.lblArea.Text = "Area"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(28, 221)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 17)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "Fecha Ingreso"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(67, 303)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(291, 17)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "ESTA AUTORIZADO PARA SALIR DE FÁBRICA EL"
        '
        'cmbAreas
        '
        Me.cmbAreas.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreas.FormattingEnabled = True
        Me.cmbAreas.ItemHeight = 23
        Me.cmbAreas.Location = New System.Drawing.Point(195, 50)
        Me.cmbAreas.Name = "cmbAreas"
        Me.cmbAreas.Size = New System.Drawing.Size(231, 29)
        Me.cmbAreas.TabIndex = 51
        Me.cmbAreas.UseSelectable = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(45, 335)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(27, 17)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Día"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(442, 306)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 17)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "Tramite:"
        '
        'dtpDia
        '
        Me.dtpDia.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDia.Location = New System.Drawing.Point(80, 331)
        Me.dtpDia.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpDia.Name = "dtpDia"
        Me.dtpDia.Size = New System.Drawing.Size(125, 29)
        Me.dtpDia.TabIndex = 44
        Me.dtpDia.Value = New Date(2017, 3, 28, 0, 0, 0, 0)
        '
        'gbTipoPermiso
        '
        Me.gbTipoPermiso.Controls.Add(Me.rbPermisoParticular)
        Me.gbTipoPermiso.Controls.Add(Me.rbPermisoComisionServicio)
        Me.gbTipoPermiso.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTipoPermiso.Location = New System.Drawing.Point(28, 12)
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
        Me.rbPermisoParticular.Location = New System.Drawing.Point(6, 21)
        Me.rbPermisoParticular.Name = "rbPermisoParticular"
        Me.rbPermisoParticular.Size = New System.Drawing.Size(83, 21)
        Me.rbPermisoParticular.TabIndex = 29
        Me.rbPermisoParticular.TabStop = True
        Me.rbPermisoParticular.Text = "Particular"
        Me.rbPermisoParticular.UseVisualStyleBackColor = True
        '
        'rbPermisoComisionServicio
        '
        Me.rbPermisoComisionServicio.AutoSize = True
        Me.rbPermisoComisionServicio.Location = New System.Drawing.Point(6, 45)
        Me.rbPermisoComisionServicio.Name = "rbPermisoComisionServicio"
        Me.rbPermisoComisionServicio.Size = New System.Drawing.Size(133, 21)
        Me.rbPermisoComisionServicio.TabIndex = 30
        Me.rbPermisoComisionServicio.Text = "Comisión Servicio"
        Me.rbPermisoComisionServicio.UseVisualStyleBackColor = True
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
        Me.btnAgregarSolicitud.Location = New System.Drawing.Point(627, 12)
        Me.btnAgregarSolicitud.Name = "btnAgregarSolicitud"
        Me.btnAgregarSolicitud.Size = New System.Drawing.Size(194, 80)
        Me.btnAgregarSolicitud.TabIndex = 43
        Me.btnAgregarSolicitud.Text = "Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Solicitud"
        Me.btnAgregarSolicitud.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAgregarSolicitud.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Pnl_SolHrasExt)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1606, 685)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Solicitud Hora Extra"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Pnl_SolHrasExt
        '
        Me.Pnl_SolHrasExt.BackColor = System.Drawing.Color.White
        Me.Pnl_SolHrasExt.Controls.Add(Me.Panel6)
        Me.Pnl_SolHrasExt.Location = New System.Drawing.Point(7, 8)
        Me.Pnl_SolHrasExt.Name = "Pnl_SolHrasExt"
        Me.Pnl_SolHrasExt.Size = New System.Drawing.Size(1219, 538)
        Me.Pnl_SolHrasExt.TabIndex = 42
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.dtpfech)
        Me.Panel6.Controls.Add(Me.ComboBox2)
        Me.Panel6.Controls.Add(Me.Label24)
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
        Me.Panel6.Location = New System.Drawing.Point(7, 6)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1191, 518)
        Me.Panel6.TabIndex = 54
        '
        'dtpfech
        '
        Me.dtpfech.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfech.Location = New System.Drawing.Point(673, 8)
        Me.dtpfech.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpfech.Name = "dtpfech"
        Me.dtpfech.Size = New System.Drawing.Size(125, 29)
        Me.dtpfech.TabIndex = 62
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.ItemHeight = 23
        Me.ComboBox2.Location = New System.Drawing.Point(185, 74)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(392, 29)
        Me.ComboBox2.TabIndex = 61
        Me.ComboBox2.UseSelectable = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.Location = New System.Drawing.Point(14, 78)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(113, 20)
        Me.Label24.TabIndex = 60
        Me.Label24.Text = "Jefe Encargado"
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSolicitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnSolicitar.FlatAppearance.BorderSize = 0
        Me.btnSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSolicitar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolicitar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSolicitar.Image = Global.RRHH.My.Resources.Resources.save_file_option64
        Me.btnSolicitar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSolicitar.Location = New System.Drawing.Point(991, 432)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(195, 80)
        Me.btnSolicitar.TabIndex = 19
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnSolicitar.UseVisualStyleBackColor = False
        '
        'ComboBox3
        '
        Me.ComboBox3.ItemHeight = 23
        Me.ComboBox3.Location = New System.Drawing.Point(592, 74)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(207, 29)
        Me.ComboBox3.TabIndex = 63
        Me.ComboBox3.UseSelectable = True
        '
        'dgvColaboradoresSHHEE
        '
        Me.dgvColaboradoresSHHEE.AllowDrop = True
        Me.dgvColaboradoresSHHEE.AllowUserToDeleteRows = False
        Me.dgvColaboradoresSHHEE.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.dgvColaboradoresSHHEE.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvColaboradoresSHHEE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvColaboradoresSHHEE.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvColaboradoresSHHEE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvColaboradoresSHHEE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvColaboradoresSHHEE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvColaboradoresSHHEE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvColaboradoresSHHEE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvColaboradoresSHHEE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numeroSolicitarHHEE, Me.nombreColaborador, Me.rutSolicitarHHEE, Me.cargoSolicitarHHEE, Me.nombreEmpresaSolicitarHHEE, Me.horaInicioSolicitarHHEE, Me.horaTerminoSolicitarHHEE, Me.cantidadHoras, Me.fechaRealSolicitarHHEE, Me.btnEliminar})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvColaboradoresSHHEE.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvColaboradoresSHHEE.EnableHeadersVisualStyles = False
        Me.dgvColaboradoresSHHEE.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvColaboradoresSHHEE.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvColaboradoresSHHEE.Location = New System.Drawing.Point(3, 118)
        Me.dgvColaboradoresSHHEE.Name = "dgvColaboradoresSHHEE"
        Me.dgvColaboradoresSHHEE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvColaboradoresSHHEE.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvColaboradoresSHHEE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvColaboradoresSHHEE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvColaboradoresSHHEE.Size = New System.Drawing.Size(1184, 310)
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
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.rutSolicitarHHEE.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent
        Me.btnEliminar.DefaultCellStyle = DataGridViewCellStyle4
        Me.btnEliminar.HeaderText = "Eliminar Filas"
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Text = "eliminar"
        Me.btnEliminar.ToolTipText = "eliminar fila"
        Me.btnEliminar.UseColumnTextForButtonValue = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label25.Location = New System.Drawing.Point(14, 12)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(158, 20)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Supervisor Solicitante"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label26.Location = New System.Drawing.Point(604, 12)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(49, 20)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Fecha"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label27.Location = New System.Drawing.Point(14, 45)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(125, 20)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "Solicito autorizar"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label28.Location = New System.Drawing.Point(226, 45)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(173, 20)
        Me.Label28.TabIndex = 4
        Me.Label28.Text = "Horas extra para el area"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label29.Location = New System.Drawing.Point(589, 45)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(180, 20)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "para el siguiente destino:"
        '
        'TxtBxDetalleSHX
        '
        '
        '
        '
        Me.TxtBxDetalleSHX.CustomButton.Image = Nothing
        Me.TxtBxDetalleSHX.CustomButton.Location = New System.Drawing.Point(309, 1)
        Me.TxtBxDetalleSHX.CustomButton.Name = ""
        Me.TxtBxDetalleSHX.CustomButton.Size = New System.Drawing.Size(65, 65)
        Me.TxtBxDetalleSHX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtBxDetalleSHX.CustomButton.TabIndex = 1
        Me.TxtBxDetalleSHX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtBxDetalleSHX.CustomButton.UseSelectable = True
        Me.TxtBxDetalleSHX.CustomButton.Visible = False
        Me.TxtBxDetalleSHX.Lines = New String(-1) {}
        Me.TxtBxDetalleSHX.Location = New System.Drawing.Point(808, 36)
        Me.TxtBxDetalleSHX.MaxLength = 100
        Me.TxtBxDetalleSHX.Multiline = True
        Me.TxtBxDetalleSHX.Name = "TxtBxDetalleSHX"
        Me.TxtBxDetalleSHX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBxDetalleSHX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtBxDetalleSHX.SelectedText = ""
        Me.TxtBxDetalleSHX.SelectionLength = 0
        Me.TxtBxDetalleSHX.SelectionStart = 0
        Me.TxtBxDetalleSHX.ShortcutsEnabled = True
        Me.TxtBxDetalleSHX.Size = New System.Drawing.Size(375, 67)
        Me.TxtBxDetalleSHX.TabIndex = 18
        Me.TxtBxDetalleSHX.UseSelectable = True
        Me.TxtBxDetalleSHX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtBxDetalleSHX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label30.Location = New System.Drawing.Point(806, 13)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(382, 20)
        Me.Label30.TabIndex = 9
        Me.Label30.Text = "Justificación para ejecutar este trabajo en horas extras:"
        '
        'txbHorasExtras
        '
        '
        '
        '
        Me.txbHorasExtras.CustomButton.Image = Nothing
        Me.txbHorasExtras.CustomButton.Location = New System.Drawing.Point(8, 1)
        Me.txbHorasExtras.CustomButton.Name = ""
        Me.txbHorasExtras.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txbHorasExtras.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbHorasExtras.CustomButton.TabIndex = 1
        Me.txbHorasExtras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbHorasExtras.CustomButton.UseSelectable = True
        Me.txbHorasExtras.CustomButton.Visible = False
        Me.txbHorasExtras.Lines = New String() {"1"}
        Me.txbHorasExtras.Location = New System.Drawing.Point(183, 43)
        Me.txbHorasExtras.MaxLength = 32767
        Me.txbHorasExtras.Name = "txbHorasExtras"
        Me.txbHorasExtras.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbHorasExtras.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbHorasExtras.SelectedText = ""
        Me.txbHorasExtras.SelectionLength = 0
        Me.txbHorasExtras.SelectionStart = 0
        Me.txbHorasExtras.ShortcutsEnabled = True
        Me.txbHorasExtras.Size = New System.Drawing.Size(32, 25)
        Me.txbHorasExtras.TabIndex = 13
        Me.txbHorasExtras.Text = "1"
        Me.txbHorasExtras.UseSelectable = True
        Me.txbHorasExtras.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbHorasExtras.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txbSupervisorSolicitante
        '
        '
        '
        '
        Me.txbSupervisorSolicitante.CustomButton.Image = Nothing
        Me.txbSupervisorSolicitante.CustomButton.Location = New System.Drawing.Point(368, 1)
        Me.txbSupervisorSolicitante.CustomButton.Name = ""
        Me.txbSupervisorSolicitante.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txbSupervisorSolicitante.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbSupervisorSolicitante.CustomButton.TabIndex = 1
        Me.txbSupervisorSolicitante.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbSupervisorSolicitante.CustomButton.UseSelectable = True
        Me.txbSupervisorSolicitante.CustomButton.Visible = False
        Me.txbSupervisorSolicitante.Lines = New String(-1) {}
        Me.txbSupervisorSolicitante.Location = New System.Drawing.Point(183, 10)
        Me.txbSupervisorSolicitante.MaxLength = 50
        Me.txbSupervisorSolicitante.Name = "txbSupervisorSolicitante"
        Me.txbSupervisorSolicitante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbSupervisorSolicitante.ReadOnly = True
        Me.txbSupervisorSolicitante.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbSupervisorSolicitante.SelectedText = ""
        Me.txbSupervisorSolicitante.SelectionLength = 0
        Me.txbSupervisorSolicitante.SelectionStart = 0
        Me.txbSupervisorSolicitante.ShortcutsEnabled = True
        Me.txbSupervisorSolicitante.Size = New System.Drawing.Size(392, 25)
        Me.txbSupervisorSolicitante.TabIndex = 10
        Me.txbSupervisorSolicitante.UseSelectable = True
        Me.txbSupervisorSolicitante.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbSupervisorSolicitante.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Pnl_AutPermisos)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1606, 685)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Autorizar Permiso"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Pnl_AutPermisos
        '
        Me.Pnl_AutPermisos.Controls.Add(Me.Pnl_Central)
        Me.Pnl_AutPermisos.Location = New System.Drawing.Point(8, 8)
        Me.Pnl_AutPermisos.Name = "Pnl_AutPermisos"
        Me.Pnl_AutPermisos.Size = New System.Drawing.Size(1051, 488)
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
        Me.Pnl_Central.Location = New System.Drawing.Point(7, 3)
        Me.Pnl_Central.Name = "Pnl_Central"
        Me.Pnl_Central.Size = New System.Drawing.Size(998, 472)
        Me.Pnl_Central.TabIndex = 3
        '
        'chkVerPendientes
        '
        Me.chkVerPendientes.AutoSize = True
        Me.chkVerPendientes.Location = New System.Drawing.Point(253, 16)
        Me.chkVerPendientes.Name = "chkVerPendientes"
        Me.chkVerPendientes.Size = New System.Drawing.Size(126, 15)
        Me.chkVerPendientes.TabIndex = 5
        Me.chkVerPendientes.Text = "Ver Solo Pendientes"
        Me.chkVerPendientes.UseSelectable = True
        '
        'dtpFechaTermino
        '
        Me.dtpFechaTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaTermino.Location = New System.Drawing.Point(117, 46)
        Me.dtpFechaTermino.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dtpFechaTermino.Name = "dtpFechaTermino"
        Me.dtpFechaTermino.Size = New System.Drawing.Size(109, 29)
        Me.dtpFechaTermino.TabIndex = 4
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(117, 9)
        Me.dtpFechaInicio.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(108, 29)
        Me.dtpFechaInicio.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Fecha de Termino"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 17)
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
        Me.dgvSolicitudesSalida.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightCyan
        Me.dgvSolicitudesSalida.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvSolicitudesSalida.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvSolicitudesSalida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSolicitudesSalida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvSolicitudesSalida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSolicitudesSalida.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvSolicitudesSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSolicitudesSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numeroSolicitud, Me.trabajador, Me.fechaInforme, Me.nombreSolicitante, Me.rutTrabajador, Me.cargoAutorizarPermiso, Me.empresa, Me.fechaSalida, Me.diaCompleto, Me.horaSalida, Me.horaEntrada, Me.horasTotales, Me.tipoPermiso, Me.btnAutorizarPermiso, Me.btnRechazarPermiso, Me.btnImprimirPermiso, Me.btnVerHistorial})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSolicitudesSalida.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvSolicitudesSalida.EnableHeadersVisualStyles = False
        Me.dgvSolicitudesSalida.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvSolicitudesSalida.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSolicitudesSalida.Location = New System.Drawing.Point(3, 87)
        Me.dgvSolicitudesSalida.Name = "dgvSolicitudesSalida"
        Me.dgvSolicitudesSalida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSolicitudesSalida.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvSolicitudesSalida.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSolicitudesSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
        Me.btnImprimirPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirPermiso.HeaderText = "Imprimir"
        Me.btnImprimirPermiso.Name = "btnImprimirPermiso"
        Me.btnImprimirPermiso.ReadOnly = True
        Me.btnImprimirPermiso.Text = "Imprimir"
        Me.btnImprimirPermiso.UseColumnTextForButtonValue = True
        Me.btnImprimirPermiso.Width = 68
        '
        'btnVerHistorial
        '
        Me.btnVerHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerHistorial.HeaderText = "Ver Historial"
        Me.btnVerHistorial.Name = "btnVerHistorial"
        Me.btnVerHistorial.Text = "Ver Historial"
        Me.btnVerHistorial.UseColumnTextForButtonValue = True
        Me.btnVerHistorial.Width = 68
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Pnl_AutHrExt)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1606, 685)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Autorizar Hora Extra"
        Me.TabPage4.UseVisualStyleBackColor = True
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
        Me.Pnl_AutHrExt.Location = New System.Drawing.Point(6, 6)
        Me.Pnl_AutHrExt.Name = "Pnl_AutHrExt"
        Me.Pnl_AutHrExt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Pnl_AutHrExt.Size = New System.Drawing.Size(1029, 514)
        Me.Pnl_AutHrExt.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Termino:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Inicio:"
        '
        'dtpTermino
        '
        Me.dtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTermino.Location = New System.Drawing.Point(73, 132)
        Me.dtpTermino.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dtpTermino.Name = "dtpTermino"
        Me.dtpTermino.Size = New System.Drawing.Size(125, 29)
        Me.dtpTermino.TabIndex = 40
        Me.dtpTermino.Visible = False
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(73, 98)
        Me.dtpInicio.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(125, 29)
        Me.dtpInicio.TabIndex = 39
        Me.dtpInicio.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnImprimir.Image = Global.RRHH.My.Resources.Resources.printing32
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnImprimir.Location = New System.Drawing.Point(816, 422)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(172, 80)
        Me.btnImprimir.TabIndex = 38
        Me.btnImprimir.Text = "Imprimir Formulario"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'chkTodas
        '
        Me.chkTodas.AutoSize = True
        Me.chkTodas.Location = New System.Drawing.Point(219, 105)
        Me.chkTodas.Name = "chkTodas"
        Me.chkTodas.Size = New System.Drawing.Size(71, 15)
        Me.chkTodas.TabIndex = 37
        Me.chkTodas.Text = "Ver todas"
        Me.chkTodas.UseSelectable = True
        '
        'txbSolicitante
        '
        '
        '
        '
        Me.txbSolicitante.CustomButton.Image = Nothing
        Me.txbSolicitante.CustomButton.Location = New System.Drawing.Point(224, 2)
        Me.txbSolicitante.CustomButton.Name = ""
        Me.txbSolicitante.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txbSolicitante.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbSolicitante.CustomButton.TabIndex = 1
        Me.txbSolicitante.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbSolicitante.CustomButton.UseSelectable = True
        Me.txbSolicitante.CustomButton.Visible = False
        Me.txbSolicitante.Lines = New String(-1) {}
        Me.txbSolicitante.Location = New System.Drawing.Point(131, 67)
        Me.txbSolicitante.MaxLength = 32767
        Me.txbSolicitante.Name = "txbSolicitante"
        Me.txbSolicitante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbSolicitante.ReadOnly = True
        Me.txbSolicitante.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbSolicitante.SelectedText = ""
        Me.txbSolicitante.SelectionLength = 0
        Me.txbSolicitante.SelectionStart = 0
        Me.txbSolicitante.ShortcutsEnabled = True
        Me.txbSolicitante.Size = New System.Drawing.Size(242, 20)
        Me.txbSolicitante.TabIndex = 33
        Me.txbSolicitante.UseSelectable = True
        Me.txbSolicitante.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbSolicitante.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txbFecha
        '
        '
        '
        '
        Me.txbFecha.CustomButton.Image = Nothing
        Me.txbFecha.CustomButton.Location = New System.Drawing.Point(82, 2)
        Me.txbFecha.CustomButton.Name = ""
        Me.txbFecha.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txbFecha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbFecha.CustomButton.TabIndex = 1
        Me.txbFecha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbFecha.CustomButton.UseSelectable = True
        Me.txbFecha.CustomButton.Visible = False
        Me.txbFecha.Lines = New String(-1) {}
        Me.txbFecha.Location = New System.Drawing.Point(131, 38)
        Me.txbFecha.MaxLength = 32767
        Me.txbFecha.Name = "txbFecha"
        Me.txbFecha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbFecha.ReadOnly = True
        Me.txbFecha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbFecha.SelectedText = ""
        Me.txbFecha.SelectionLength = 0
        Me.txbFecha.SelectionStart = 0
        Me.txbFecha.ShortcutsEnabled = True
        Me.txbFecha.Size = New System.Drawing.Size(100, 20)
        Me.txbFecha.TabIndex = 36
        Me.txbFecha.UseSelectable = True
        Me.txbFecha.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbFecha.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnRechazarTodas
        '
        Me.btnRechazarTodas.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnRechazarTodas.FlatAppearance.BorderSize = 0
        Me.btnRechazarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRechazarTodas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRechazarTodas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRechazarTodas.Image = CType(resources.GetObject("btnRechazarTodas.Image"), System.Drawing.Image)
        Me.btnRechazarTodas.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRechazarTodas.Location = New System.Drawing.Point(638, 422)
        Me.btnRechazarTodas.Name = "btnRechazarTodas"
        Me.btnRechazarTodas.Size = New System.Drawing.Size(172, 80)
        Me.btnRechazarTodas.TabIndex = 31
        Me.btnRechazarTodas.Text = "Rechazar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Todas Las Filas"
        Me.btnRechazarTodas.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnRechazarTodas.UseVisualStyleBackColor = False
        Me.btnRechazarTodas.Visible = False
        '
        'btnAutorizarTodas
        '
        Me.btnAutorizarTodas.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnAutorizarTodas.FlatAppearance.BorderSize = 0
        Me.btnAutorizarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutorizarTodas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutorizarTodas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAutorizarTodas.Image = Global.RRHH.My.Resources.Resources.check_mark_white
        Me.btnAutorizarTodas.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAutorizarTodas.Location = New System.Drawing.Point(460, 422)
        Me.btnAutorizarTodas.Name = "btnAutorizarTodas"
        Me.btnAutorizarTodas.Size = New System.Drawing.Size(172, 80)
        Me.btnAutorizarTodas.TabIndex = 30
        Me.btnAutorizarTodas.Text = "Autorizar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Todas las Filas"
        Me.btnAutorizarTodas.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAutorizarTodas.UseVisualStyleBackColor = False
        Me.btnAutorizarTodas.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Numero de Solicitud:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 37)
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
        Me.dgvColaboradores.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.LightCyan
        Me.dgvColaboradores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvColaboradores.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvColaboradores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvColaboradores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvColaboradores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvColaboradores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvColaboradores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.nombreColaboradores, Me.rut, Me.cargo, Me.nombreEmpresa, Me.horaInicio, Me.horaTermino, Me.fechaReal, Me.btnAutorizar, Me.btnRechazar})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvColaboradores.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvColaboradores.EnableHeadersVisualStyles = False
        Me.dgvColaboradores.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvColaboradores.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvColaboradores.Location = New System.Drawing.Point(7, 168)
        Me.dgvColaboradores.Name = "dgvColaboradores"
        Me.dgvColaboradores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvColaboradores.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvColaboradores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvColaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.rut.DefaultCellStyle = DataGridViewCellStyle13
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
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutorizar.DefaultCellStyle = DataGridViewCellStyle14
        Me.btnAutorizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutorizar.HeaderText = "Autorizar"
        Me.btnAutorizar.Name = "btnAutorizar"
        Me.btnAutorizar.Text = "Autorizar"
        Me.btnAutorizar.ToolTipText = "autorizar empleado"
        Me.btnAutorizar.UseColumnTextForButtonValue = True
        '
        'btnRechazar
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        Me.btnRechazar.DefaultCellStyle = DataGridViewCellStyle15
        Me.btnRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        Me.Label5.Location = New System.Drawing.Point(19, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Solicitante:"
        '
        'cmbNumeroSolicitud
        '
        Me.cmbNumeroSolicitud.FormattingEnabled = True
        Me.cmbNumeroSolicitud.ItemHeight = 23
        Me.cmbNumeroSolicitud.Location = New System.Drawing.Point(131, 5)
        Me.cmbNumeroSolicitud.Name = "cmbNumeroSolicitud"
        Me.cmbNumeroSolicitud.Size = New System.Drawing.Size(100, 29)
        Me.cmbNumeroSolicitud.TabIndex = 28
        Me.cmbNumeroSolicitud.UseSelectable = True
        '
        'txbDetalle
        '
        '
        '
        '
        Me.txbDetalle.CustomButton.Image = Nothing
        Me.txbDetalle.CustomButton.Location = New System.Drawing.Point(349, 2)
        Me.txbDetalle.CustomButton.Name = ""
        Me.txbDetalle.CustomButton.Size = New System.Drawing.Size(135, 135)
        Me.txbDetalle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbDetalle.CustomButton.TabIndex = 1
        Me.txbDetalle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbDetalle.CustomButton.UseSelectable = True
        Me.txbDetalle.CustomButton.Visible = False
        Me.txbDetalle.Lines = New String(-1) {}
        Me.txbDetalle.Location = New System.Drawing.Point(389, 16)
        Me.txbDetalle.MaxLength = 32767
        Me.txbDetalle.Multiline = True
        Me.txbDetalle.Name = "txbDetalle"
        Me.txbDetalle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbDetalle.ReadOnly = True
        Me.txbDetalle.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbDetalle.SelectedText = ""
        Me.txbDetalle.SelectionLength = 0
        Me.txbDetalle.SelectionStart = 0
        Me.txbDetalle.ShortcutsEnabled = True
        Me.txbDetalle.Size = New System.Drawing.Size(487, 140)
        Me.txbDetalle.TabIndex = 29
        Me.txbDetalle.UseSelectable = True
        Me.txbDetalle.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbDetalle.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Pnl_InformePermisos)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1606, 685)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Informe Permiso"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Pnl_InformePermisos
        '
        Me.Pnl_InformePermisos.Controls.Add(Me.btnExportarExcelPermiso)
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
        Me.Pnl_InformePermisos.Location = New System.Drawing.Point(3, 3)
        Me.Pnl_InformePermisos.Name = "Pnl_InformePermisos"
        Me.Pnl_InformePermisos.Size = New System.Drawing.Size(1060, 656)
        Me.Pnl_InformePermisos.TabIndex = 46
        '
        'btnExportarExcelPermiso
        '
        Me.btnExportarExcelPermiso.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnExportarExcelPermiso.FlatAppearance.BorderSize = 0
        Me.btnExportarExcelPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarExcelPermiso.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnExportarExcelPermiso.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExportarExcelPermiso.Image = Global.RRHH.My.Resources.Resources.white_ms_excel_32
        Me.btnExportarExcelPermiso.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExportarExcelPermiso.Location = New System.Drawing.Point(361, 570)
        Me.btnExportarExcelPermiso.Name = "btnExportarExcelPermiso"
        Me.btnExportarExcelPermiso.Size = New System.Drawing.Size(223, 80)
        Me.btnExportarExcelPermiso.TabIndex = 25
        Me.btnExportarExcelPermiso.Text = "Exportar a Excel"
        Me.btnExportarExcelPermiso.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnExportarExcelPermiso.UseVisualStyleBackColor = False
        '
        'lblNombreInformePermisos
        '
        Me.lblNombreInformePermisos.AutoSize = True
        Me.lblNombreInformePermisos.Location = New System.Drawing.Point(373, 21)
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
        Me.chkBuscarTodosInformePermisos.Location = New System.Drawing.Point(261, 20)
        Me.chkBuscarTodosInformePermisos.Name = "chkBuscarTodosInformePermisos"
        Me.chkBuscarTodosInformePermisos.Size = New System.Drawing.Size(93, 15)
        Me.chkBuscarTodosInformePermisos.TabIndex = 24
        Me.chkBuscarTodosInformePermisos.Text = "Buscar Todos"
        Me.chkBuscarTodosInformePermisos.UseSelectable = True
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
        Me.btnImprimirInformePermisos.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnImprimirInformePermisos.FlatAppearance.BorderSize = 0
        Me.btnImprimirInformePermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirInformePermisos.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnImprimirInformePermisos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnImprimirInformePermisos.Image = Global.RRHH.My.Resources.Resources.printing32
        Me.btnImprimirInformePermisos.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnImprimirInformePermisos.Location = New System.Drawing.Point(819, 570)
        Me.btnImprimirInformePermisos.Name = "btnImprimirInformePermisos"
        Me.btnImprimirInformePermisos.Size = New System.Drawing.Size(223, 80)
        Me.btnImprimirInformePermisos.TabIndex = 23
        Me.btnImprimirInformePermisos.Text = "Imprimir"
        Me.btnImprimirInformePermisos.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnImprimirInformePermisos.UseVisualStyleBackColor = False
        '
        'cmbEmpresaInformePermisos
        '
        Me.cmbEmpresaInformePermisos.FormattingEnabled = True
        Me.cmbEmpresaInformePermisos.ItemHeight = 23
        Me.cmbEmpresaInformePermisos.Items.AddRange(New Object() {"Mindugar SA", "Mindugar Industrial", "Mindugar Montajes"})
        Me.cmbEmpresaInformePermisos.Location = New System.Drawing.Point(90, 14)
        Me.cmbEmpresaInformePermisos.Name = "cmbEmpresaInformePermisos"
        Me.cmbEmpresaInformePermisos.Size = New System.Drawing.Size(156, 29)
        Me.cmbEmpresaInformePermisos.TabIndex = 12
        Me.cmbEmpresaInformePermisos.UseSelectable = True
        '
        'btnBuscarInformePermisos
        '
        Me.btnBuscarInformePermisos.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnBuscarInformePermisos.FlatAppearance.BorderSize = 0
        Me.btnBuscarInformePermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarInformePermisos.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscarInformePermisos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscarInformePermisos.Image = CType(resources.GetObject("btnBuscarInformePermisos.Image"), System.Drawing.Image)
        Me.btnBuscarInformePermisos.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnBuscarInformePermisos.Location = New System.Drawing.Point(590, 570)
        Me.btnBuscarInformePermisos.Name = "btnBuscarInformePermisos"
        Me.btnBuscarInformePermisos.Size = New System.Drawing.Size(223, 80)
        Me.btnBuscarInformePermisos.TabIndex = 22
        Me.btnBuscarInformePermisos.Text = "Buscar"
        Me.btnBuscarInformePermisos.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnBuscarInformePermisos.UseVisualStyleBackColor = False
        '
        'dtpInicioInformePermisos
        '
        Me.dtpInicioInformePermisos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicioInformePermisos.Location = New System.Drawing.Point(120, 48)
        Me.dtpInicioInformePermisos.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dtpInicioInformePermisos.Name = "dtpInicioInformePermisos"
        Me.dtpInicioInformePermisos.Size = New System.Drawing.Size(126, 29)
        Me.dtpInicioInformePermisos.TabIndex = 15
        '
        'txbRutInformePermisos
        '
        Me.txbRutInformePermisos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txbRutInformePermisos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txbRutInformePermisos.CustomButton.Image = Nothing
        Me.txbRutInformePermisos.CustomButton.Location = New System.Drawing.Point(251, 2)
        Me.txbRutInformePermisos.CustomButton.Name = ""
        Me.txbRutInformePermisos.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txbRutInformePermisos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbRutInformePermisos.CustomButton.TabIndex = 1
        Me.txbRutInformePermisos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbRutInformePermisos.CustomButton.UseSelectable = True
        Me.txbRutInformePermisos.CustomButton.Visible = False
        Me.txbRutInformePermisos.Lines = New String(-1) {}
        Me.txbRutInformePermisos.Location = New System.Drawing.Point(469, 42)
        Me.txbRutInformePermisos.MaxLength = 32767
        Me.txbRutInformePermisos.Name = "txbRutInformePermisos"
        Me.txbRutInformePermisos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbRutInformePermisos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbRutInformePermisos.SelectedText = ""
        Me.txbRutInformePermisos.SelectionLength = 0
        Me.txbRutInformePermisos.SelectionStart = 0
        Me.txbRutInformePermisos.ShortcutsEnabled = True
        Me.txbRutInformePermisos.Size = New System.Drawing.Size(269, 20)
        Me.txbRutInformePermisos.TabIndex = 21
        Me.txbRutInformePermisos.UseSelectable = True
        Me.txbRutInformePermisos.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbRutInformePermisos.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(29, 22)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(51, 13)
        Me.Label36.TabIndex = 11
        Me.Label36.Text = "Empresa:"
        '
        'txbNombreInformePermisos
        '
        Me.txbNombreInformePermisos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txbNombreInformePermisos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txbNombreInformePermisos.CustomButton.Image = Nothing
        Me.txbNombreInformePermisos.CustomButton.Location = New System.Drawing.Point(251, 2)
        Me.txbNombreInformePermisos.CustomButton.Name = ""
        Me.txbNombreInformePermisos.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txbNombreInformePermisos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbNombreInformePermisos.CustomButton.TabIndex = 1
        Me.txbNombreInformePermisos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbNombreInformePermisos.CustomButton.UseSelectable = True
        Me.txbNombreInformePermisos.CustomButton.Visible = False
        Me.txbNombreInformePermisos.Lines = New String(-1) {}
        Me.txbNombreInformePermisos.Location = New System.Drawing.Point(469, 17)
        Me.txbNombreInformePermisos.MaxLength = 32767
        Me.txbNombreInformePermisos.Name = "txbNombreInformePermisos"
        Me.txbNombreInformePermisos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbNombreInformePermisos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbNombreInformePermisos.SelectedText = ""
        Me.txbNombreInformePermisos.SelectionLength = 0
        Me.txbNombreInformePermisos.SelectionStart = 0
        Me.txbNombreInformePermisos.ShortcutsEnabled = True
        Me.txbNombreInformePermisos.Size = New System.Drawing.Size(269, 20)
        Me.txbNombreInformePermisos.TabIndex = 20
        Me.txbNombreInformePermisos.UseSelectable = True
        Me.txbNombreInformePermisos.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbNombreInformePermisos.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dtpTerminoInformePermisos
        '
        Me.dtpTerminoInformePermisos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTerminoInformePermisos.Location = New System.Drawing.Point(120, 83)
        Me.dtpTerminoInformePermisos.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dtpTerminoInformePermisos.Name = "dtpTerminoInformePermisos"
        Me.dtpTerminoInformePermisos.Size = New System.Drawing.Size(126, 29)
        Me.dtpTerminoInformePermisos.TabIndex = 16
        '
        'lblRutInformePermisos
        '
        Me.lblRutInformePermisos.AutoSize = True
        Me.lblRutInformePermisos.Location = New System.Drawing.Point(373, 46)
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
        Me.dgvSolicitudesSalidaInformePermisos.AllowUserToResizeRows = False
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.LightCyan
        Me.dgvSolicitudesSalidaInformePermisos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvSolicitudesSalidaInformePermisos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvSolicitudesSalidaInformePermisos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSolicitudesSalidaInformePermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvSolicitudesSalidaInformePermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSolicitudesSalidaInformePermisos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvSolicitudesSalidaInformePermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSolicitudesSalidaInformePermisos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNumeroSolicitudInformePermisos, Me.colTrabajadorInformePermisos, Me.colDepartamentoInformePermisos, Me.colCargoInformePermisos, Me.colFechaSalidaInformePermisos, Me.colDiaCompletoInformePermisos, Me.colHoraSalidaInformePermisos, Me.colHoraEntradaInformePermisos, Me.colHorasTotalesInformePermisos, Me.colTipoPermisoInformePermisos})
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSolicitudesSalidaInformePermisos.DefaultCellStyle = DataGridViewCellStyle20
        Me.dgvSolicitudesSalidaInformePermisos.EnableHeadersVisualStyles = False
        Me.dgvSolicitudesSalidaInformePermisos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvSolicitudesSalidaInformePermisos.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvSolicitudesSalidaInformePermisos.Location = New System.Drawing.Point(11, 135)
        Me.dgvSolicitudesSalidaInformePermisos.Name = "dgvSolicitudesSalidaInformePermisos"
        Me.dgvSolicitudesSalidaInformePermisos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSolicitudesSalidaInformePermisos.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dgvSolicitudesSalidaInformePermisos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSolicitudesSalidaInformePermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Pnl_InformeHHEE)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1606, 685)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Informe Hora Extra"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Pnl_InformeHHEE
        '
        Me.Pnl_InformeHHEE.Controls.Add(Me.btnExportarExcel)
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
        Me.Pnl_InformeHHEE.Location = New System.Drawing.Point(3, 3)
        Me.Pnl_InformeHHEE.Name = "Pnl_InformeHHEE"
        Me.Pnl_InformeHHEE.Size = New System.Drawing.Size(1103, 598)
        Me.Pnl_InformeHHEE.TabIndex = 45
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnExportarExcel.FlatAppearance.BorderSize = 0
        Me.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarExcel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportarExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExportarExcel.Image = Global.RRHH.My.Resources.Resources.white_ms_excel_32
        Me.btnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExportarExcel.Location = New System.Drawing.Point(406, 508)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(223, 80)
        Me.btnExportarExcel.TabIndex = 43
        Me.btnExportarExcel.Text = "Exportar a Excel"
        Me.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnExportarExcel.UseVisualStyleBackColor = False
        '
        'btnBuscarInformeHHEE
        '
        Me.btnBuscarInformeHHEE.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnBuscarInformeHHEE.FlatAppearance.BorderSize = 0
        Me.btnBuscarInformeHHEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarInformeHHEE.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarInformeHHEE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscarInformeHHEE.Image = CType(resources.GetObject("btnBuscarInformeHHEE.Image"), System.Drawing.Image)
        Me.btnBuscarInformeHHEE.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnBuscarInformeHHEE.Location = New System.Drawing.Point(635, 508)
        Me.btnBuscarInformeHHEE.Name = "btnBuscarInformeHHEE"
        Me.btnBuscarInformeHHEE.Size = New System.Drawing.Size(223, 80)
        Me.btnBuscarInformeHHEE.TabIndex = 36
        Me.btnBuscarInformeHHEE.Text = "Buscar"
        Me.btnBuscarInformeHHEE.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnBuscarInformeHHEE.UseVisualStyleBackColor = False
        '
        'dgvColaboradoresInformeHHEE
        '
        Me.dgvColaboradoresInformeHHEE.AllowDrop = True
        Me.dgvColaboradoresInformeHHEE.AllowUserToAddRows = False
        Me.dgvColaboradoresInformeHHEE.AllowUserToDeleteRows = False
        Me.dgvColaboradoresInformeHHEE.AllowUserToResizeRows = False
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.LightCyan
        Me.dgvColaboradoresInformeHHEE.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.dgvColaboradoresInformeHHEE.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvColaboradoresInformeHHEE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvColaboradoresInformeHHEE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvColaboradoresInformeHHEE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvColaboradoresInformeHHEE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.dgvColaboradoresInformeHHEE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvColaboradoresInformeHHEE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNumeroInformeHHEE, Me.colNombreColaboradoresInformeHHEE, Me.colRutInformeHHEE, Me.colDepartamentoInformeHHEE, Me.colCargoInformeHHEE, Me.colHoraInicioInformeHHEE, Me.colHoraTerminoInformeHHEE, Me.colTotalHorasExtrasInformeHHEE, Me.colFechaRealInformeHHEE})
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvColaboradoresInformeHHEE.DefaultCellStyle = DataGridViewCellStyle25
        Me.dgvColaboradoresInformeHHEE.EnableHeadersVisualStyles = False
        Me.dgvColaboradoresInformeHHEE.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvColaboradoresInformeHHEE.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvColaboradoresInformeHHEE.Location = New System.Drawing.Point(27, 199)
        Me.dgvColaboradoresInformeHHEE.Name = "dgvColaboradoresInformeHHEE"
        Me.dgvColaboradoresInformeHHEE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvColaboradoresInformeHHEE.RowHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.dgvColaboradoresInformeHHEE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvColaboradoresInformeHHEE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
        DataGridViewCellStyle24.Format = "N2"
        DataGridViewCellStyle24.NullValue = Nothing
        Me.colRutInformeHHEE.DefaultCellStyle = DataGridViewCellStyle24
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
        '
        '
        '
        Me.txbTotalEmpleadosInformeHHEE.CustomButton.Image = Nothing
        Me.txbTotalEmpleadosInformeHHEE.CustomButton.Location = New System.Drawing.Point(111, 2)
        Me.txbTotalEmpleadosInformeHHEE.CustomButton.Name = ""
        Me.txbTotalEmpleadosInformeHHEE.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txbTotalEmpleadosInformeHHEE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbTotalEmpleadosInformeHHEE.CustomButton.TabIndex = 1
        Me.txbTotalEmpleadosInformeHHEE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbTotalEmpleadosInformeHHEE.CustomButton.UseSelectable = True
        Me.txbTotalEmpleadosInformeHHEE.CustomButton.Visible = False
        Me.txbTotalEmpleadosInformeHHEE.Lines = New String(-1) {}
        Me.txbTotalEmpleadosInformeHHEE.Location = New System.Drawing.Point(735, 159)
        Me.txbTotalEmpleadosInformeHHEE.MaxLength = 32767
        Me.txbTotalEmpleadosInformeHHEE.Name = "txbTotalEmpleadosInformeHHEE"
        Me.txbTotalEmpleadosInformeHHEE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbTotalEmpleadosInformeHHEE.ReadOnly = True
        Me.txbTotalEmpleadosInformeHHEE.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbTotalEmpleadosInformeHHEE.SelectedText = ""
        Me.txbTotalEmpleadosInformeHHEE.SelectionLength = 0
        Me.txbTotalEmpleadosInformeHHEE.SelectionStart = 0
        Me.txbTotalEmpleadosInformeHHEE.ShortcutsEnabled = True
        Me.txbTotalEmpleadosInformeHHEE.Size = New System.Drawing.Size(129, 20)
        Me.txbTotalEmpleadosInformeHHEE.TabIndex = 42
        Me.txbTotalEmpleadosInformeHHEE.UseSelectable = True
        Me.txbTotalEmpleadosInformeHHEE.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbTotalEmpleadosInformeHHEE.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(34, 55)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(78, 17)
        Me.Label31.TabIndex = 27
        Me.Label31.Text = "Fecha Inicio:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(571, 161)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(99, 17)
        Me.Label32.TabIndex = 41
        Me.Label32.Text = "Total Empleado"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(34, 90)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(95, 17)
        Me.Label33.TabIndex = 28
        Me.Label33.Text = "Fecha Termino:"
        '
        'chkTodaEmpresaInformeHHEE
        '
        Me.chkTodaEmpresaInformeHHEE.AutoSize = True
        Me.chkTodaEmpresaInformeHHEE.Location = New System.Drawing.Point(274, 21)
        Me.chkTodaEmpresaInformeHHEE.Name = "chkTodaEmpresaInformeHHEE"
        Me.chkTodaEmpresaInformeHHEE.Size = New System.Drawing.Size(97, 15)
        Me.chkTodaEmpresaInformeHHEE.TabIndex = 40
        Me.chkTodaEmpresaInformeHHEE.Text = "Toda Empresa"
        Me.chkTodaEmpresaInformeHHEE.UseSelectable = True
        Me.chkTodaEmpresaInformeHHEE.Visible = False
        '
        'cmbEmpresaInformeHHEE
        '
        Me.cmbEmpresaInformeHHEE.FormattingEnabled = True
        Me.cmbEmpresaInformeHHEE.ItemHeight = 23
        Me.cmbEmpresaInformeHHEE.Items.AddRange(New Object() {"Mindugar SA", "Mindugar Industrial", "Mindugar Montajes"})
        Me.cmbEmpresaInformeHHEE.Location = New System.Drawing.Point(105, 14)
        Me.cmbEmpresaInformeHHEE.Name = "cmbEmpresaInformeHHEE"
        Me.cmbEmpresaInformeHHEE.Size = New System.Drawing.Size(152, 29)
        Me.cmbEmpresaInformeHHEE.TabIndex = 26
        Me.cmbEmpresaInformeHHEE.UseSelectable = True
        '
        'lblHHEEAcumuladasInformeHHEE
        '
        Me.lblHHEEAcumuladasInformeHHEE.AutoSize = True
        Me.lblHHEEAcumuladasInformeHHEE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHHEEAcumuladasInformeHHEE.Location = New System.Drawing.Point(571, 133)
        Me.lblHHEEAcumuladasInformeHHEE.Name = "lblHHEEAcumuladasInformeHHEE"
        Me.lblHHEEAcumuladasInformeHHEE.Size = New System.Drawing.Size(159, 17)
        Me.lblHHEEAcumuladasInformeHHEE.TabIndex = 39
        Me.lblHHEEAcumuladasInformeHHEE.Text = "Horas Extras Acumuladas:"
        '
        'dtpInicioInformeHHEE
        '
        Me.dtpInicioInformeHHEE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicioInformeHHEE.Location = New System.Drawing.Point(135, 49)
        Me.dtpInicioInformeHHEE.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpInicioInformeHHEE.Name = "dtpInicioInformeHHEE"
        Me.dtpInicioInformeHHEE.Size = New System.Drawing.Size(122, 29)
        Me.dtpInicioInformeHHEE.TabIndex = 29
        '
        'txbHHEEAcumuladasInformeHHEE
        '
        '
        '
        '
        Me.txbHHEEAcumuladasInformeHHEE.CustomButton.Image = Nothing
        Me.txbHHEEAcumuladasInformeHHEE.CustomButton.Location = New System.Drawing.Point(111, 2)
        Me.txbHHEEAcumuladasInformeHHEE.CustomButton.Name = ""
        Me.txbHHEEAcumuladasInformeHHEE.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txbHHEEAcumuladasInformeHHEE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbHHEEAcumuladasInformeHHEE.CustomButton.TabIndex = 1
        Me.txbHHEEAcumuladasInformeHHEE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbHHEEAcumuladasInformeHHEE.CustomButton.UseSelectable = True
        Me.txbHHEEAcumuladasInformeHHEE.CustomButton.Visible = False
        Me.txbHHEEAcumuladasInformeHHEE.Lines = New String(-1) {}
        Me.txbHHEEAcumuladasInformeHHEE.Location = New System.Drawing.Point(735, 131)
        Me.txbHHEEAcumuladasInformeHHEE.MaxLength = 32767
        Me.txbHHEEAcumuladasInformeHHEE.Name = "txbHHEEAcumuladasInformeHHEE"
        Me.txbHHEEAcumuladasInformeHHEE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbHHEEAcumuladasInformeHHEE.ReadOnly = True
        Me.txbHHEEAcumuladasInformeHHEE.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbHHEEAcumuladasInformeHHEE.SelectedText = ""
        Me.txbHHEEAcumuladasInformeHHEE.SelectionLength = 0
        Me.txbHHEEAcumuladasInformeHHEE.SelectionStart = 0
        Me.txbHHEEAcumuladasInformeHHEE.ShortcutsEnabled = True
        Me.txbHHEEAcumuladasInformeHHEE.Size = New System.Drawing.Size(129, 20)
        Me.txbHHEEAcumuladasInformeHHEE.TabIndex = 38
        Me.txbHHEEAcumuladasInformeHHEE.UseSelectable = True
        Me.txbHHEEAcumuladasInformeHHEE.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbHHEEAcumuladasInformeHHEE.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblEmpresaInformeHHEE
        '
        Me.lblEmpresaInformeHHEE.AutoSize = True
        Me.lblEmpresaInformeHHEE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresaInformeHHEE.Location = New System.Drawing.Point(34, 20)
        Me.lblEmpresaInformeHHEE.Name = "lblEmpresaInformeHHEE"
        Me.lblEmpresaInformeHHEE.Size = New System.Drawing.Size(62, 17)
        Me.lblEmpresaInformeHHEE.TabIndex = 25
        Me.lblEmpresaInformeHHEE.Text = "Empresa:"
        '
        'btnImprimirInformeHHEE
        '
        Me.btnImprimirInformeHHEE.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnImprimirInformeHHEE.FlatAppearance.BorderSize = 0
        Me.btnImprimirInformeHHEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirInformeHHEE.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirInformeHHEE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnImprimirInformeHHEE.Image = Global.RRHH.My.Resources.Resources.printing32
        Me.btnImprimirInformeHHEE.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnImprimirInformeHHEE.Location = New System.Drawing.Point(864, 508)
        Me.btnImprimirInformeHHEE.Name = "btnImprimirInformeHHEE"
        Me.btnImprimirInformeHHEE.Size = New System.Drawing.Size(223, 80)
        Me.btnImprimirInformeHHEE.TabIndex = 37
        Me.btnImprimirInformeHHEE.Text = "Imprimir"
        Me.btnImprimirInformeHHEE.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnImprimirInformeHHEE.UseVisualStyleBackColor = False
        '
        'dtpTerminoInformeHHEE
        '
        Me.dtpTerminoInformeHHEE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTerminoInformeHHEE.Location = New System.Drawing.Point(135, 84)
        Me.dtpTerminoInformeHHEE.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpTerminoInformeHHEE.Name = "dtpTerminoInformeHHEE"
        Me.dtpTerminoInformeHHEE.Size = New System.Drawing.Size(122, 29)
        Me.dtpTerminoInformeHHEE.TabIndex = 30
        '
        'lblNombreInformeHHEE
        '
        Me.lblNombreInformeHHEE.AutoSize = True
        Me.lblNombreInformeHHEE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreInformeHHEE.Location = New System.Drawing.Point(147, 133)
        Me.lblNombreInformeHHEE.Name = "lblNombreInformeHHEE"
        Me.lblNombreInformeHHEE.Size = New System.Drawing.Size(121, 17)
        Me.lblNombreInformeHHEE.TabIndex = 31
        Me.lblNombreInformeHHEE.Text = "Nombre Completo:"
        '
        'chkBuscarTodosInformeHHEE
        '
        Me.chkBuscarTodosInformeHHEE.AutoSize = True
        Me.chkBuscarTodosInformeHHEE.Location = New System.Drawing.Point(37, 133)
        Me.chkBuscarTodosInformeHHEE.Name = "chkBuscarTodosInformeHHEE"
        Me.chkBuscarTodosInformeHHEE.Size = New System.Drawing.Size(93, 15)
        Me.chkBuscarTodosInformeHHEE.TabIndex = 35
        Me.chkBuscarTodosInformeHHEE.Text = "Buscar Todos"
        Me.chkBuscarTodosInformeHHEE.UseSelectable = True
        '
        'lblRutInformeHHEE
        '
        Me.lblRutInformeHHEE.AutoSize = True
        Me.lblRutInformeHHEE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRutInformeHHEE.Location = New System.Drawing.Point(147, 161)
        Me.lblRutInformeHHEE.Name = "lblRutInformeHHEE"
        Me.lblRutInformeHHEE.Size = New System.Drawing.Size(30, 17)
        Me.lblRutInformeHHEE.TabIndex = 32
        Me.lblRutInformeHHEE.Text = "Rut:"
        '
        'txbRutInformeHHEE
        '
        Me.txbRutInformeHHEE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txbRutInformeHHEE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txbRutInformeHHEE.CustomButton.Image = Nothing
        Me.txbRutInformeHHEE.CustomButton.Location = New System.Drawing.Point(251, 2)
        Me.txbRutInformeHHEE.CustomButton.Name = ""
        Me.txbRutInformeHHEE.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txbRutInformeHHEE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbRutInformeHHEE.CustomButton.TabIndex = 1
        Me.txbRutInformeHHEE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbRutInformeHHEE.CustomButton.UseSelectable = True
        Me.txbRutInformeHHEE.CustomButton.Visible = False
        Me.txbRutInformeHHEE.Lines = New String(-1) {}
        Me.txbRutInformeHHEE.Location = New System.Drawing.Point(275, 159)
        Me.txbRutInformeHHEE.MaxLength = 32767
        Me.txbRutInformeHHEE.Name = "txbRutInformeHHEE"
        Me.txbRutInformeHHEE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbRutInformeHHEE.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbRutInformeHHEE.SelectedText = ""
        Me.txbRutInformeHHEE.SelectionLength = 0
        Me.txbRutInformeHHEE.SelectionStart = 0
        Me.txbRutInformeHHEE.ShortcutsEnabled = True
        Me.txbRutInformeHHEE.Size = New System.Drawing.Size(269, 20)
        Me.txbRutInformeHHEE.TabIndex = 34
        Me.txbRutInformeHHEE.UseSelectable = True
        Me.txbRutInformeHHEE.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbRutInformeHHEE.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txbNombreInformeHHEE
        '
        Me.txbNombreInformeHHEE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txbNombreInformeHHEE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txbNombreInformeHHEE.CustomButton.Image = Nothing
        Me.txbNombreInformeHHEE.CustomButton.Location = New System.Drawing.Point(251, 2)
        Me.txbNombreInformeHHEE.CustomButton.Name = ""
        Me.txbNombreInformeHHEE.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txbNombreInformeHHEE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbNombreInformeHHEE.CustomButton.TabIndex = 1
        Me.txbNombreInformeHHEE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbNombreInformeHHEE.CustomButton.UseSelectable = True
        Me.txbNombreInformeHHEE.CustomButton.Visible = False
        Me.txbNombreInformeHHEE.Lines = New String(-1) {}
        Me.txbNombreInformeHHEE.Location = New System.Drawing.Point(275, 131)
        Me.txbNombreInformeHHEE.MaxLength = 32767
        Me.txbNombreInformeHHEE.Name = "txbNombreInformeHHEE"
        Me.txbNombreInformeHHEE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbNombreInformeHHEE.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbNombreInformeHHEE.SelectedText = ""
        Me.txbNombreInformeHHEE.SelectionLength = 0
        Me.txbNombreInformeHHEE.SelectionStart = 0
        Me.txbNombreInformeHHEE.ShortcutsEnabled = True
        Me.txbNombreInformeHHEE.Size = New System.Drawing.Size(269, 20)
        Me.txbNombreInformeHHEE.TabIndex = 33
        Me.txbNombreInformeHHEE.UseSelectable = True
        Me.txbNombreInformeHHEE.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbNombreInformeHHEE.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lbl_Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_Titulo.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Titulo.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_Titulo.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(1658, 48)
        Me.Lbl_Titulo.TabIndex = 5
        Me.Lbl_Titulo.Text = "Lbl_Titulo Seleccion"
        Me.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmSolicPermHrasExt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1908, 798)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FrmSolicPermHrasExt"
        Me.Text = "FrmSolicPermHrasExt"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlCentral.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Pnl_SolPermisos.ResumeLayout(False)
        Me.Pnl_SolicitudPermisos.ResumeLayout(False)
        Me.Pnl_SolicitudPermisos.PerformLayout()
        Me.pnlModificar.ResumeLayout(False)
        Me.pnlModificar.PerformLayout()
        Me.pnlHora.ResumeLayout(False)
        Me.pnlHora.PerformLayout()
        Me.gbTipoPermiso.ResumeLayout(False)
        Me.gbTipoPermiso.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.Pnl_SolHrasExt.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dgvColaboradoresSHHEE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.Pnl_AutPermisos.ResumeLayout(False)
        Me.Pnl_Central.ResumeLayout(False)
        Me.Pnl_Central.PerformLayout()
        CType(Me.dgvSolicitudesSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.Pnl_AutHrExt.ResumeLayout(False)
        Me.Pnl_AutHrExt.PerformLayout()
        CType(Me.dgvColaboradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.Pnl_InformePermisos.ResumeLayout(False)
        Me.Pnl_InformePermisos.PerformLayout()
        CType(Me.dgvSolicitudesSalidaInformePermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.Pnl_InformeHHEE.ResumeLayout(False)
        Me.Pnl_InformeHHEE.PerformLayout()
        CType(Me.dgvColaboradoresInformeHHEE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Pnl_AutHrExt As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTermino As MetroFramework.Controls.MetroDateTime 'DateTimePicker
    Friend WithEvents dtpInicio As MetroFramework.Controls.MetroDateTime 'DateTimePicker
    Friend WithEvents btnImprimir As Button
    Friend WithEvents chkTodas As MetroFramework.Controls.MetroCheckBox ' CheckBox
    Friend WithEvents txbSolicitante As MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents txbFecha As MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents btnRechazarTodas As Button
    Friend WithEvents btnAutorizarTodas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvColaboradores As MetroFramework.Controls.MetroGrid 'DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbNumeroSolicitud As MetroFramework.Controls.MetroComboBox ' ComboBox
    Friend WithEvents txbDetalle As MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents TreeView1 As Kesoft.Windows.Forms.Win7StyleTreeView.Win7StyleTreeView 'TreeView
    Friend WithEvents Lbl_Titulo As Label
    Friend WithEvents Pnl_AutPermisos As Panel
    Friend WithEvents Pnl_Central As Panel
    Friend WithEvents chkVerPendientes As MetroFramework.Controls.MetroCheckBox 'CheckBox
    Friend WithEvents dtpFechaTermino As MetroFramework.Controls.MetroDateTime 'DateTimePicker
    Friend WithEvents btnVolver As Button
    Friend WithEvents dtpFechaInicio As MetroFramework.Controls.MetroDateTime 'DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvSolicitudesSalida As MetroFramework.Controls.MetroGrid 'DataGridView
    Friend WithEvents Pnl_SolPermisos As Panel
    Friend WithEvents Pnl_SolHrasExt As Panel
    Friend WithEvents Pnl_SolicitudPermisos As Panel
    Friend WithEvents pnlModificar As Panel
    Friend WithEvents ComboBox1 As MetroFramework.Controls.MetroComboBox 'ComboBox
    Friend WithEvents cmbModificarTrabajador As MetroFramework.Controls.MetroComboBox 'ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents chkDiaCompleto As MetroFramework.Controls.MetroCheckBox 'CheckBox
    Friend WithEvents pnlHora As Panel
    Friend WithEvents dtpHoraSalida As MetroFramework.Controls.MetroDateTime 'DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpHoraEntrada As MetroFramework.Controls.MetroDateTime 'DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents txbTotalHoras As MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbJefes As MetroFramework.Controls.MetroComboBox 'ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txbTramite As MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents txbEmpresa As MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txbTrabajador As MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents txbCargo As MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txbRut As MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents txbFechaIngreso As MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents lblArea As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbAreas As MetroFramework.Controls.MetroComboBox 'ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents dtpDia As MetroFramework.Controls.MetroDateTime 'DateTimePicker
    Friend WithEvents gbTipoPermiso As GroupBox
    Friend WithEvents rbPermisoParticular As RadioButton
    Friend WithEvents rbPermisoComisionServicio As RadioButton
    Friend WithEvents btnAgregarSolicitud As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ComboBox2 As MetroFramework.Controls.MetroComboBox ' ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents dgvColaboradoresSHHEE As MetroFramework.Controls.MetroGrid 'DataGridView
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents TxtBxDetalleSHX As MetroFramework.Controls.MetroTextBox ' TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txbHorasExtras As New MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents txbSupervisorSolicitante As MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents Pnl_InformeHHEE As Panel
    Private WithEvents btnBuscarInformeHHEE As Button
    Friend WithEvents dgvColaboradoresInformeHHEE As MetroFramework.Controls.MetroGrid 'DataGridView
    Friend WithEvents colNumeroInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colNombreColaboradoresInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colRutInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colDepartamentoInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colCargoInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colHoraInicioInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colHoraTerminoInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colTotalHorasExtrasInformeHHEE As DataGridViewTextBoxColumn
    Friend WithEvents colFechaRealInformeHHEE As DataGridViewTextBoxColumn
    Private WithEvents txbTotalEmpleadosInformeHHEE As MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents Label31 As Label
    Private WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Private WithEvents chkTodaEmpresaInformeHHEE As MetroFramework.Controls.MetroCheckBox 'CheckBox
    Friend WithEvents cmbEmpresaInformeHHEE As MetroFramework.Controls.MetroComboBox ' ComboBox
    Private WithEvents lblHHEEAcumuladasInformeHHEE As Label
    Friend WithEvents dtpInicioInformeHHEE As MetroFramework.Controls.MetroDateTime 'DateTimePicker
    Private WithEvents txbHHEEAcumuladasInformeHHEE As MetroFramework.Controls.MetroTextBox ' TextBox
    Friend WithEvents lblEmpresaInformeHHEE As Label
    Private WithEvents btnImprimirInformeHHEE As Button
    Friend WithEvents dtpTerminoInformeHHEE As MetroFramework.Controls.MetroDateTime 'DateTimePicker
    Friend WithEvents lblNombreInformeHHEE As Label
    Private WithEvents chkBuscarTodosInformeHHEE As MetroFramework.Controls.MetroCheckBox 'CheckBox
    Friend WithEvents lblRutInformeHHEE As Label
    Friend WithEvents txbRutInformeHHEE As MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents txbNombreInformeHHEE As MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents Pnl_InformePermisos As Panel
    Friend WithEvents lblNombreInformePermisos As Label
    Friend WithEvents Label34 As Label
    Private WithEvents chkBuscarTodosInformePermisos As MetroFramework.Controls.MetroCheckBox 'CheckBox
    Friend WithEvents Label35 As Label
    Private WithEvents btnImprimirInformePermisos As Button
    Friend WithEvents cmbEmpresaInformePermisos As MetroFramework.Controls.MetroComboBox ' ComboBox
    Private WithEvents btnBuscarInformePermisos As Button
    Friend WithEvents dtpInicioInformePermisos As MetroFramework.Controls.MetroDateTime 'DateTimePicker
    Friend WithEvents txbRutInformePermisos As MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents txbNombreInformePermisos As MetroFramework.Controls.MetroTextBox 'TextBox
    Friend WithEvents dtpTerminoInformePermisos As MetroFramework.Controls.MetroDateTime 'DateTimePicker
    Friend WithEvents lblRutInformePermisos As Label
    Friend WithEvents dgvSolicitudesSalidaInformePermisos As MetroFramework.Controls.MetroGrid 'DataGridView
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
    Friend WithEvents pnlCentral As Panel
    Friend WithEvents BtnVolver2 As Button
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    'Friend WithEvents dtpFecha As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpfech As MetroFramework.Controls.MetroDateTime
    Friend WithEvents ComboBox3 As MetroFramework.Controls.MetroComboBox
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
    Private WithEvents btnExportarExcel As Button
    Private WithEvents btnExportarExcelPermiso As Button
End Class

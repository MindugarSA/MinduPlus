Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class FrmSolicPermHrasExt
    Dim vDateInfo As DateTime
    Dim dt As New DataTable
    Dim conexion As New SqlConnection
    Dim cmd As SqlCommand
    Dim modoEntrada As Integer
    Dim eventFlag As Boolean
    Private enableBuscarRutHHEE As Boolean = True
    Private enableBuscarNombreHHEE As Boolean = True
    Private enableBuscarHHEE As Boolean = False
    Private trabajadorHHEE As Persona
    Private enableBuscarRutInformePermisos As Boolean = True
    Private enableBuscarNombreInformePermisos As Boolean = True
    Private enableBuscarInformePermisos As Boolean = False
    Private trabajadorInformePermisos As Persona

    Public Sub New(modo As Integer)
        eventFlag = False
        ' Llamada necesaria para el diseñador.
        'lala la comentando
        'Otro comentario mas
        InitializeComponent()
        modoEntrada = modo
        eventFlag = True
        'btnVolver.Location = New Point(3, MDIParent1.Size.Height - btnVolver.Size.Height - 170)
        'TreeView1.Size = New Size(TreeView1.Size.Width, btnVolver.Location.Y - TreeView1.Location.Y - 25)

    End Sub


    Private Sub FrmSolicPermHrasExt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Data Source=FSSAPBO;Initial Catalog = SAC_Mindugar; Persist Security Info=True;User ID = sa; Password=Sqladmin281"
        'MDIParent1.Panel2.Visible = False
        Dim ctl As Control
        For Each ctl In Me.Controls
            AddHandler ctl.KeyDown, AddressOf myEventHandler
        Next
        Me.WindowState = FormWindowState.Maximized
        Me.TreeView1.ExpandAll()
        If modoEntrada = 90001 Then
            TreeView1.SelectedNode = TreeView1.Nodes("Nodo0").Nodes("Nd_SolPermisos")
            TreeView1.Visible = False
            SplitContainer1.Panel1Collapsed = True
            BtnVolver2.Visible = True
            'BtnVolver2.Location = New Point(BtnVolver2.Location.X + 20, pnlCentral.Size.Height - pnlCentral.Location.Y - 20 - BtnVolver2.Size.Height - 444)
            'BtnVolver2.Location = New Point(pnlCentral.Location.X + 20, pnlCentral.Size.Height - pnlCentral.Location.Y - 20 - BtnVolver2.Size.Height - 444)
        End If

        If modoEntrada = 90002 Then
            TreeView1.SelectedNode = TreeView1.Nodes("Nodo0").Nodes("Nd_SolHrExt")
            TreeView1.Visible = False
            SplitContainer1.Panel1Collapsed = True
            BtnVolver2.Visible = True
            BtnVolver2.Location = New Point(BtnVolver2.Location.X, btnSolicitar.Location.Y)
            'BtnVolver2.Location = New Point(pnlCentral.Location.X + 20, pnlCentral.Size.Height - pnlCentral.Location.Y - 20 - BtnVolver2.Size.Height - 444)
        End If
    End Sub
    Private Sub myEventHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If




    End Sub

    '----------------- Menu Principal -----------------------------------------------------------------------------
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Pnl_SolPermisos.Visible = False
        Pnl_SolHrasExt.Visible = False
        Pnl_AutHrExt.Visible = False
        Pnl_AutPermisos.Visible = False
        Pnl_InformeHHEE.Visible = False
        Pnl_InformePermisos.Visible = False

        Lbl_Titulo.Text = "*** Seleccione una Opciòn ***"
        Select Case UCase(TreeView1.SelectedNode.Name)
            Case UCase("Nd_SolPermisos")
                If MDIParent1.RevisaAcceso(90001) Then
                    Lbl_Titulo.Text = "Solicitud de Permisos"
                    Pnl_SolPermisos.Location = New Point(3, 52)
                    Pnl_SolPermisos.Visible = True
                    Pnl_SolPermisos.Dock = DockStyle.Fill
                    Pnl_SolicitudPermisos.Dock = DockStyle.Fill


                    dtpDia.Text = Date.Now
                    dtpHoraEntrada.Text = Date.Now
                    dtpHoraSalida.Text = Date.Now
                    If modoEntrada = 0 Or modoEntrada = 90001 Then
                        cmbAreas.DataSource = listaAreas()
                    End If
                    If modoEntrada = 2 Or modoEntrada = 1 Then
                        pnlModificar.Visible = True
                        txbTrabajador.ReadOnly = True
                        lblArea.Visible = False
                        cmbAreas.Visible = False
                        btnAgregarSolicitud.Visible = False
                        If modoEntrada = 2 Then
                            cmbModificarTrabajador.Visible = False
                            BuscarSolicitudes()
                        Else
                            cmbModificarTrabajador.DataSource = BuscarTrabajadores()
                        End If
                    End If
                End If


            Case UCase("Nd_SolHrExt")
                If MDIParent1.RevisaAcceso(90002) Then
                    Lbl_Titulo.Text = "Solicitud de Horas Extras"
                    Pnl_SolHrasExt.Location = New Point(3, 52)
                    Pnl_SolHrasExt.Visible = True
                    Pnl_SolHrasExt.Dock = DockStyle.Fill
                    Panel6.Dock = DockStyle.Fill

                    txbSupervisorSolicitante.Text = MDIParent1.TxtBx_UserName.Text
                    'MDIParent1.Panel2.Visible = False
                    dtpFecha.Value = Date.Now.ToString("dd-MM-yyyy")

                    ComboBox3.DataSource = listaAreas()
                    If modoEntrada = 90002 Then
                        'btnSolicitar.Location = New Point(pnlCentral.Location.X + 40 + BtnVolver2.Size.Width, pnlCentral.Size.Height - pnlCentral.Location.Y - 20 - btnSolicitar.Size.Height - 444)
                        'If Screen.PrimaryScreen.Bounds.Width - 40 < dgvColaboradoresSHHEE.Width Then
                        '    dgvColaboradoresSHHEE.Size = New Size(Screen.PrimaryScreen.Bounds.Width - 40, btnSolicitar.Location.Y - dgvColaboradoresSHHEE.Location.Y - 40)
                        '    dgvColaboradoresSHHEE.Columns("cargoSolicitarHHEE").DefaultCellStyle.Font = New Font(New FontFamily("Arial"), 6)
                        '    dgvColaboradoresSHHEE.Columns("cargoSolicitarHHEE").Width = 120
                        '    dgvColaboradoresSHHEE.Columns("rutSolicitarHHEE").DefaultCellStyle.Font = New Font(New FontFamily("Arial"), 7)
                        '    dgvColaboradoresSHHEE.Columns("rutSolicitarHHEE").Width = 66
                        '    dgvColaboradoresSHHEE.Columns("nombreColaborador").DefaultCellStyle.Font = New Font(New FontFamily("Arial"), 6)
                        '    dgvColaboradoresSHHEE.Columns("nombreColaborador").Width = 175
                        '    dgvColaboradoresSHHEE.Columns("cantidadHoras").Width = 80
                        'Else
                        '    dgvColaboradoresSHHEE.Size = New Size(dgvColaboradoresSHHEE.Size.Width, btnSolicitar.Location.Y - dgvColaboradoresSHHEE.Location.Y - 40)
                        'End If
                    Else
                        'btnSolicitar.Location = New Point(pnlCentral.Location.X + 20, pnlCentral.Size.Height - pnlCentral.Location.Y - 20 - btnSolicitar.Size.Height)
                        'If Screen.PrimaryScreen.Bounds.Width - dgvColaboradoresSHHEE.Location.X - TreeView1.Size.Width - 50 < 1184 Then
                        '    dgvColaboradoresSHHEE.Size = New Size(Screen.PrimaryScreen.Bounds.Width - dgvColaboradoresSHHEE.Location.X - TreeView1.Size.Width - 50, btnSolicitar.Location.Y - dgvColaboradoresSHHEE.Location.Y - 40)
                        'Else
                        '    'dgvColaboradoresSHHEE.Size = New Size(dgvColaboradoresSHHEE.Size.Width, btnSolicitar.Location.Y - dgvColaboradoresSHHEE.Location.Y - 40)
                        '    dgvColaboradoresSHHEE.Size = New Size(dgvColaboradoresSHHEE.Size.Width, btnSolicitar.Location.Y - dgvColaboradoresSHHEE.Location.Y - 40)
                        'End If
                    End If


                    'Panel6.Size = New Size(100000, 100000)
                End If


            Case UCase("Nd_AutPermisos")
                If MDIParent1.RevisaAcceso(90010) Then
                    Lbl_Titulo.Text = "Autoriza  Permisos"
                    Pnl_AutPermisos.Location = New Point(3, 52)
                    Pnl_AutPermisos.Visible = True
                    Pnl_AutPermisos.Dock = DockStyle.Fill
                    'btnVolver.Location = New Point(20, MDIParent1.Size.Height - btnVolver.Size.Height - 170)
                    Lbl_Titulo.Text += (Screen.PrimaryScreen.Bounds.Width - dgvSolicitudesSalida.Location.X - TreeView1.Size.Width - 25).ToString
                    If Screen.PrimaryScreen.Bounds.Width - dgvSolicitudesSalida.Location.X - TreeView1.Size.Width - 25 < 1270 Then
                        dgvSolicitudesSalida.Size = New Size(Screen.PrimaryScreen.Bounds.Width - dgvSolicitudesSalida.Location.X - TreeView1.Size.Width - 25, pnlCentral.Size.Height - pnlCentral.Location.Y - dgvSolicitudesSalida.Location.Y - 10)
                    Else
                        dgvSolicitudesSalida.Size = New Size(1270, btnVolver.Location.Y - dgvSolicitudesSalida.Location.Y - 10)
                    End If
                    dtpFechaInicio.Value = DateTime.Today
                    dtpFechaTermino.Value = DateTime.Today
                    CargarAreaAutorizador(MDIParent1.TxtBx_UserName.Text, dtpFechaInicio.Value, dtpFechaTermino.Value)
                    Pnl_Central.Size = New Size(100000, 100000)
                End If



            Case UCase("Nd_AutHrExt")
                If MDIParent1.RevisaAcceso(90011) Then
                    Lbl_Titulo.Text = "Autoriza Horas Extras"
                    Pnl_AutHrExt.Location = New Point(3, 52)
                    Pnl_AutHrExt.Visible = True
                    ' MDIParent1.Panel2.Visible = False
                    CargarNumeroSolicitudes()
                    Pnl_AutHrExt.Dock = DockStyle.Fill
                    btnImprimir.Location = New Point(pnlCentral.Location.X + 20, pnlCentral.Size.Height - pnlCentral.Location.Y - btnImprimir.Height - 10)
                    'btnVolver.Location = New Point(20, MDIParent1.Size.Height - btnVolver.Size.Height - 170)
                    Lbl_Titulo.Text += (Screen.PrimaryScreen.Bounds.Width - dgvColaboradores.Location.X - TreeView1.Size.Width - 25).ToString
                    If Screen.PrimaryScreen.Bounds.Width - dgvColaboradores.Location.X - TreeView1.Size.Width - 25 < 1183 Then
                        Lbl_Titulo.Text += "true"
                        dgvColaboradores.Size = New Size(Screen.PrimaryScreen.Bounds.Width - dgvColaboradores.Location.X - TreeView1.Size.Width - 25, btnImprimir.Location.Y - dgvColaboradores.Location.Y - 60)
                    Else
                        dgvColaboradores.Size = New Size(1183, btnImprimir.Location.Y - dgvColaboradores.Location.Y - 60)
                    End If

                End If


            Case UCase("Nd_InformeHorasExtras")
                If MDIParent1.RevisaAcceso(90021) Then
                    Lbl_Titulo.Text = "Informe Horas Extras"
                    Pnl_InformeHHEE.Location = New Point(3, 52)
                    Pnl_InformeHHEE.Dock = DockStyle.Fill
                    Pnl_InformeHHEE.Visible = True
                    ' MDIParent1.Panel2.Visible = False

                    dtpInicioInformeHHEE.Value = DateTime.Now
                    dtpTerminoInformeHHEE.Value = DateTime.Now

                    cmbEmpresaInformeHHEE.SelectedIndex = 0
                    trabajadorHHEE = New Persona()
                    trabajadorHHEE.Rut = ""
                    trabajadorHHEE.Nombre = ""
                    btnImprimirInformeHHEE.Location = New Point(pnlCentral.Location.X + 20, pnlCentral.Size.Height - pnlCentral.Location.Y - btnImprimirInformeHHEE.Height - 10)
                    btnBuscarInformeHHEE.Location = New Point(btnImprimirInformeHHEE.Location.X + btnImprimirInformeHHEE.Width + 20, pnlCentral.Size.Height - pnlCentral.Location.Y - btnBuscarInformeHHEE.Height - 10)
                    If Screen.PrimaryScreen.Bounds.Width - dgvColaboradoresInformeHHEE.Location.X - TreeView1.Size.Width - 25 < 1063 Then
                        dgvColaboradoresInformeHHEE.Size = New Size(Screen.PrimaryScreen.Bounds.Width - dgvColaboradoresInformeHHEE.Location.X - TreeView1.Size.Width - 25, btnBuscarInformeHHEE.Location.Y - dgvColaboradoresInformeHHEE.Location.Y - 20)
                    Else
                        dgvColaboradoresInformeHHEE.Size = New Size(dgvColaboradoresInformeHHEE.Size.Width, btnBuscarInformeHHEE.Location.Y - dgvColaboradoresInformeHHEE.Location.Y - 20)
                    End If
                End If


            Case UCase("Nd_InformePermisos")
                If MDIParent1.RevisaAcceso(90020) Then
                    Pnl_InformePermisos.Location = New Point(3, 52)
                    Pnl_InformePermisos.Dock = DockStyle.Fill
                    Pnl_InformePermisos.Visible = True
                    ' MDIParent1.Panel2.Visible = False

                    dtpInicioInformePermisos.Value = DateTime.Now
                    dtpTerminoInformePermisos.Value = DateTime.Now

                    cmbEmpresaInformePermisos.SelectedIndex = 0
                    trabajadorInformePermisos = New Persona()
                    trabajadorInformePermisos.Rut = ""

                    trabajadorInformePermisos.Nombre = ""
                    btnImprimirInformePermisos.Location = New Point(pnlCentral.Location.X + 20, pnlCentral.Size.Height - pnlCentral.Location.Y - btnImprimirInformePermisos.Height - 10)
                    btnBuscarInformePermisos.Location = New Point(btnImprimirInformePermisos.Location.X + btnImprimirInformePermisos.Width + 20, pnlCentral.Size.Height - pnlCentral.Location.Y - btnBuscarInformePermisos.Height - 10)
                    If Screen.PrimaryScreen.Bounds.Width - dgvColaboradoresInformeHHEE.Location.X - TreeView1.Size.Width - 25 < 1032 Then
                        dgvSolicitudesSalidaInformePermisos.Size = New Size(Screen.PrimaryScreen.Bounds.Width - dgvSolicitudesSalidaInformePermisos.Location.X - TreeView1.Size.Width - 25, btnBuscarInformePermisos.Location.Y - dgvSolicitudesSalidaInformePermisos.Location.Y - 20)
                    Else
                        dgvSolicitudesSalidaInformePermisos.Size = New Size(dgvSolicitudesSalidaInformePermisos.Size.Width, btnBuscarInformePermisos.Location.Y - dgvSolicitudesSalidaInformePermisos.Location.Y - 20)
                    End If
                End If
        End Select
    End Sub


















    ' ------------------------------ Solicitud de Permisos ------------------------------------------------------
    'Ok
    Private Sub btnAgregarSolicitud_Click(sender As Object, e As EventArgs) Handles btnAgregarSolicitud.Click
        If ValidarSolicitud() Then
            Dim cmd As SqlCommand = New SqlCommand()

            cmd.Connection = conexion

            If chkDiaCompleto.Checked Then
                cmd.CommandText = "INSERT INTO dbo.Solicitud_Salida(dia_completo,empresa,cargo,solicitante,rut_solicitante,fecha_solicitud,trabajador, rut, area, permiso_particular, permiso_comision_servicio, dia,tramite,check_basetempo) " +
                                 "VALUES (@dia_completo,@empresa,@cargo,@solicitante,@rut_solicitante,@fecha_solicitud,@trabajador, @rut, @area, @permiso_particular, @permiso_comision_servicio, @dia,@tramite,@check_basetempo)"
            Else
                cmd.CommandText = "INSERT INTO dbo.Solicitud_Salida(dia_completo,empresa,cargo,solicitante,rut_solicitante,fecha_solicitud,trabajador, rut, area, permiso_particular, permiso_comision_servicio, dia, hora_salida, total_horas,tramite,check_basetempo) " +
                                 "VALUES (@dia_completo,@empresa,@cargo,@solicitante,@rut_solicitante,@fecha_solicitud,@trabajador, @rut, @area, @permiso_particular, @permiso_comision_servicio, @dia, @hora_salida, @total_horas,@tramite,@check_basetempo)"
                cmd.Parameters.Add("@hora_salida", SqlDbType.Time).Value = dtpHoraSalida.Value.TimeOfDay
                cmd.Parameters.Add("@total_horas", SqlDbType.Float).Value = (dtpHoraEntrada.Value.TimeOfDay - dtpHoraSalida.Value.TimeOfDay).TotalHours
            End If
            cmd.Parameters.Add("@solicitante", SqlDbType.VarChar).Value = MDIParent1.TxtBx_UserName.Text
            cmd.Parameters.Add("@rut_solicitante", SqlDbType.VarChar).Value = BuscarDatosTrabajador(MDIParent1.TxtBx_UserName.Text).Rows(0)("rut")
            'BuscarDatosTrabajador(MDIParent1.TxtBx_UserName.Text).Rows(0)("rut").ToString
            cmd.Parameters.Add("@fecha_solicitud", SqlDbType.DateTime).Value = Date.Now
            cmd.Parameters.Add("@trabajador", SqlDbType.VarChar).Value = txbTrabajador.Text
            cmd.Parameters.Add("@rut", SqlDbType.VarChar).Value = txbRut.Text
            cmd.Parameters.Add("@empresa", SqlDbType.VarChar).Value = txbEmpresa.Text
            cmd.Parameters.Add("@cargo", SqlDbType.VarChar).Value = txbCargo.Text
            cmd.Parameters.Add("@area", SqlDbType.VarChar).Value = cmbAreas.Text
            cmd.Parameters.Add("@permiso_particular", SqlDbType.Bit).Value = rbPermisoParticular.Checked
            cmd.Parameters.Add("@permiso_comision_servicio", SqlDbType.Bit).Value = rbPermisoComisionServicio.Checked
            cmd.Parameters.Add("@dia", SqlDbType.Date).Value = dtpDia.Value.Date
            cmd.Parameters.Add("@dia_completo", SqlDbType.Bit).Value = chkDiaCompleto.Checked
            cmd.Parameters.Add("@check_basetempo", SqlDbType.Bit).Value = 0

            'cmd.Parameters.Add("@goce_de_sueldo", SqlDbType.Bit).Value = chkGoceDeSueldo.Checked
            If rbPermisoComisionServicio.Checked Then
                cmd.Parameters.Add("@tramite", SqlDbType.VarChar).Value = txbTramite.Text
            Else
                cmd.Parameters.Add("@tramite", SqlDbType.VarChar).Value = ""
            End If
            conexion.Open()
            Try
                cmd.ExecuteReader()

                Dim numeroSolicitud As Integer = BuscarUltimoNumeroDeSolicitud()
                Dim mensaje As String
                If numeroSolicitud = -1 Then
                    mensaje = "No se pudo encontrar el numero de solicitud"
                Else
                    mensaje = "El numero de solicitud es: " + numeroSolicitud.ToString
                End If
                Dim mandado As Boolean = MandarInformeSolicitud(BuscarCorreoResponsable(cmbJefes.Text))
                If mandado Then
                    MsgBox("Solicitud de salida de fabrica enviada." & vbCrLf & mensaje, MsgBoxStyle.Information, "Solicitud de Salida")
                Else
                    MsgBox("La solicitud fue guardada pero pudo ser enviada." & vbCrLf & mensaje, MsgBoxStyle.Information, "Solicitud de Salida")
                End If
            Catch ex As Exception
                MsgBox("Error al operar con la base de datos!" + ex.Message, MsgBoxStyle.Critical, "Error!")
            Finally
                conexion.Close()
            End Try

        End If
    End Sub

    'Ok
    Private Sub cmbAreas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAreas.SelectedIndexChanged
        txbTrabajador.Text = ""
        txbEmpresa.Text = ""
        txbFechaIngreso.Text = ""
        txbRut.Text = ""
    End Sub
    'Ok
    Private Sub cmbAreas_TextChanged(sender As Object, e As EventArgs) Handles cmbAreas.TextChanged
        If cmbAreas.Text <> "" Then
            txbTrabajador.ReadOnly = False
            txbTrabajador.AutoCompleteCustomSource = listaAutocompletadaTrabajadores(cmbAreas.Text)
        Else
            txbTrabajador.ReadOnly = True
            txbTrabajador.Text = ""
            txbRut.Text = ""
        End If
    End Sub
    'Ok
    Private Sub txbTrabajador_TextChanged(sender As Object, e As EventArgs) Handles txbTrabajador.TextChanged
        Dim dt As DataTable = BuscarDatosTrabajador(txbTrabajador.Text)
        txbRut.Text = dt.Rows(0)("rut").ToString()
        txbCargo.Text = dt.Rows(0)("cargo").ToString()
        txbEmpresa.Text = dt.Rows(0)("nombre_emp").ToString()
        cmbJefes.DataSource = BuscarEncargados(txbTrabajador.Text, cmbAreas.Text, txbEmpresa.Text)
        Try
            txbFechaIngreso.Text = Date.Parse(dt.Rows(0)("fecha_ingreso")).ToString("dd-MM-yyyy")
        Catch ex As Exception
        End Try
    End Sub
    'Ok
    Private Sub dtpDia_ValueChanged(sender As Object, e As EventArgs) Handles dtpDia.ValueChanged
        Try
            Dim fecha As DateTime = New DateTime(dtpDia.Value.Year, dtpDia.Value.Month, dtpDia.Value.Day, 0, 0, 0, 0)
            dtpDia.Value = fecha
        Catch ex As Exception
            dtpDia.Value = DateTime.Today
        End Try
    End Sub
    'Ok
    Private Sub chkDiaCompleto_CheckedChanged(sender As Object, e As EventArgs) Handles chkDiaCompleto.CheckedChanged
        If chkDiaCompleto.Checked Then
            pnlHora.Visible = False
        Else
            pnlHora.Visible = True
        End If
    End Sub
    'OK
    Private Sub dtpHoraSalida_ValueChanged(sender As Object, e As EventArgs) Handles dtpHoraSalida.ValueChanged, dtpHoraEntrada.ValueChanged
        ValidarCambioHora()

        'En caso de que se cambie la hora de salida, se tiene que volver a calcular las horas totales solicitadas para salir del campus
        CalcularHorasMinutos()

    End Sub
    'Ok
    Private Sub cmbModificarTrabajador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModificarTrabajador.SelectedIndexChanged
        BuscarSolicitudes()
    End Sub
    'OK
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim comando As SqlCommand = New SqlCommand()
        comando.Connection = conexion
        comando.CommandText = "SELECT rut,permiso_particular,permiso_comision_servicio,dia,hora_salida,total_horas,empresa,cargo,dia_completo,tramite FROM [SAC_Mindugar].[dbo].[Solicitud_Salida] WHERE id_solicitud_salida = @id"
        comando.Parameters.Add("@id", SqlDbType.Int).Value = cmbNumeroSolicitud.Text
        Dim tabla As DataTable = New DataTable()
        Dim adapter As New SqlDataAdapter(comando)
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        Try
            adapter.Fill(tabla)
            txbTrabajador.Text = cmbModificarTrabajador.Text
            dtpDia.Value = tabla.Rows(0)("dia")
            chkDiaCompleto.Checked = tabla.Rows(0)("dia_completo")
            If Not tabla.Rows(0)("dia_completo") Then
                dtpHoraSalida.Value = tabla.Rows(0)("hora_salida")
            End If

            dtpHoraSalida.Value = tabla.Rows(0)("hora_salida")
        Catch ex As Exception
            MsgBox("error: " + ex.Message, MsgBoxStyle.Exclamation, "Error Areas")
        Finally
            conexion.Close()
        End Try

    End Sub
    'Ok btnVolver_Click
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MDIParent1.Panel2.Visible = True
        MDIParent1.TiempoIngreso.Enabled = True
        MDIParent1.Visualizar_Tiles_MDI()
        Me.Close()
    End Sub
    'Ok
    Private Sub rbPermisoComisionServicio_CheckedChanged(sender As Object, e As EventArgs) Handles rbPermisoComisionServicio.CheckedChanged
        If rbPermisoComisionServicio.Checked Then
            txbTramite.ReadOnly = False
        Else
            txbTramite.ReadOnly = True
            txbTramite.Text = ""
        End If
    End Sub
    '*************************************************
    'OK
    Private Function listaAreas() As List(Of [String])
        Dim lista As New List(Of [String])()
        Dim cmd As SqlCommand
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        Try
            cmd = New SqlCommand("SELECT un.[descripcion] FROM (SELECT [descripcion] FROM [GestPer_Mindugar_Industrial].[dbo].[area] UNION ALL SELECT [descripcion] FROM [GestPer_Mindugar_Montajes].[dbo].[area] UNION ALL SELECT [descripcion] FROM [GestPer_Mindugar_sa].[dbo].[area]) un group by [descripcion]", conexion)
            'cmd = New SqlCommand("SELECT descripcion FROM [GestPer_Mindugar_sa].[dbo].[area] group by descripcion", conexion)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            adapter.Fill(dt)
            For i = 0 To dt.Rows.Count - 1
                lista.Add(dt.Rows(i)("descripcion").ToString)
            Next
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("error: " + ex.Message, MsgBoxStyle.Exclamation, "Error Areas")
        Finally
            conexion.Close()
        End Try
        Return lista
    End Function
    'Ok
    Private Sub BuscarSolicitudes()
        Dim comando As SqlCommand = New SqlCommand()
        comando.Connection = conexion
        comando.CommandText = "SELECT id_solicitud_salida As 'id' FROM [SAC_Mindugar].[dbo].[Solicitud_Salida] WHERE trabajador = @nombreCompleto"
        If modoEntrada = 1 Then
            comando.Parameters.Add("@nombreCompleto", SqlDbType.VarChar).Value = cmbModificarTrabajador.Text
        Else
            comando.Parameters.Add("@nombreCompleto", SqlDbType.VarChar).Value = MDIParent1.TxtBx_UserName
        End If
        Dim tabla As DataTable = New DataTable()
        Dim adapter As New SqlDataAdapter(comando)
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        Try
            adapter.Fill(tabla)
            Dim lista As List(Of String) = New List(Of String)
            For i = 0 To tabla.Rows.Count - 1
                lista.Add(tabla.Rows(i)("id").ToString)
            Next
            cmbNumeroSolicitud.DataSource = lista
        Catch ex As Exception
            MsgBox("error: " + ex.Message, MsgBoxStyle.Exclamation, "Error Areas")
        Finally
            conexion.Close()
        End Try
    End Sub
    'Ok
    Public Function BuscarTrabajadores() As List(Of String)
        Dim lista As List(Of String) = New List(Of String)
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("Solicitud_Trabador_Con_Solicitud", conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@nombreCompleto", MDIParent1.TxtBx_UserName.Text))
            Dim adapter As New SqlDataAdapter(command)
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)
            For i = 0 To table.Rows.Count - 1
                lista.Add(table.Rows(i)("trabajador").ToString)
            Next
            command.Dispose()
        Catch ex As Exception
            MsgBox("error: " + ex.Message, MsgBoxStyle.Exclamation, "Area Invalida")
        Finally
            conexion.Close()
        End Try
        Return lista
    End Function
    'OK
    Private Function ValidarSolicitud() As Boolean
        If txbRut.Text = String.Empty Or (rbPermisoComisionServicio.Checked And txbTramite.Text = String.Empty) Then
            MsgBox("El trabajador debe existir para poder pedir permisos.", MsgBoxStyle.Exclamation, "Trabajador Inválido")
            Return False
        End If
        If (dtpHoraEntrada.Value.TimeOfDay - dtpHoraSalida.Value.TimeOfDay).TotalHours = 0 And Not chkDiaCompleto.Checked Then
            MsgBox("Porfavor especifique la hora de inicio y termino del permiso.", MsgBoxStyle.Exclamation, "Hora de Inicio/Termino no Válida")
            Return False
        End If

        Return True
    End Function
    'Ok
    Private Function BuscarDatosTrabajador(ByVal nombre) As DataTable
        Dim tabla As DataTable = New DataTable()
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        Try
            Dim comand As SqlCommand = New SqlCommand("Solicitud_Buscar_Datos_Trabajador", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.Add(New SqlParameter("@nombreCompleto", nombre))
            Dim adapter As New SqlDataAdapter(comand)
            adapter.Fill(tabla)
            'rut = dt.Rows(0)("rut").ToString()
            comand.Dispose()
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try
        Return tabla
    End Function
    'Ok
    Private Function BuscarUltimoNumeroDeSolicitud()
        Dim numeroSolicitud As Integer = -1
        Dim comando As SqlCommand = New SqlCommand()
        comando.Connection = conexion
        comando.CommandText = "Select MAX(id_solicitud_salida) as id_solicitud_salida FROM Solicitud_Salida WHERE trabajador = @trabajador"
        comando.Parameters.Add("@trabajador", SqlDbType.VarChar).Value = txbTrabajador.Text
        Dim tabla As DataTable = New DataTable()
        Dim adapter As New SqlDataAdapter(comando)
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        Try
            adapter.Fill(tabla)
            numeroSolicitud = tabla.Rows(0)("id_solicitud_salida")
        Catch ex As Exception
            MsgBox("error: " + ex.Message, MsgBoxStyle.Exclamation, "Error Areas")
        Finally
            conexion.Close()
        End Try
        Return numeroSolicitud
    End Function
    'OK
    Private Function MandarInformeSolicitud(ByVal correo As String) As Boolean
        Try
            'El mensaje contiene un informe de los datos de la solicitud
            Dim mensaje As String = "El solicitante " & MDIParent1.TxtBx_UserName.Text & " solicita permiso para que el trabajador " & txbTrabajador.Text & " pueda salir de fábrica el día: " & dtpDia.Value.Date.ToString("dd-MM-yyyy") & vbCrLf
            If chkDiaCompleto.Checked Then
                mensaje += "Por el dia completo." & vbCrLf
            Else
                mensaje += "Desde: " + dtpHoraSalida.Value.Hour.ToString & ":" + dtpHoraSalida.Value.Minute.ToString & ", Hasta " & dtpHoraEntrada.Value.Hour.ToString & ":" & dtpHoraEntrada.Value.Minute.ToString & vbCrLf
            End If
            mensaje += "Tipo de permiso: "
            If rbPermisoParticular.Checked Then
                mensaje += "Particular"
            Else
                mensaje += "Comisión Servicio"
            End If
            mensaje += vbCrLf
            If rbPermisoComisionServicio.Checked Then
                mensaje += "Trámite: " + txbTramite.Text
            End If

            'Un correo conteniendo los datos es entonces enviado al responsable de la autorización
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("sys.mindugar@mindugar.cl", "SyS_min281")
            Smtp_Server.Port = 25
            Smtp_Server.EnableSsl = False
            Smtp_Server.Host = "correo.mindugar.cl"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("sys.mindugar@mindugar.cl")
            e_mail.To.Add(correo)
            e_mail.Subject = "Empleado Solicita Permiso"
            e_mail.IsBodyHtml = False
            e_mail.Body = mensaje
            Smtp_Server.Send(e_mail)
            Return True
        Catch error_t As Exception
            MsgBox(error_t.Message)
            Return False
        End Try
    End Function
    'OK
    Private Function BuscarCorreoResponsable(prmNombreCompleto As String) As String
        Dim correoResponsable As String
        Dim comando As SqlCommand = New SqlCommand("Solicitud_Buscar_Correo", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add("@nombreCompleto", SqlDbType.VarChar).Value = prmNombreCompleto
        Dim tabla As DataTable = New DataTable()
        Dim adapter As New SqlDataAdapter(comando)
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        Try
            adapter.Fill(tabla)
            correoResponsable = tabla.Rows(0)("correo")
        Catch ex As Exception
            MsgBox("error: " + ex.Message, MsgBoxStyle.Exclamation, "Error Areas")
            correoResponsable = "N/A"
        Finally
            conexion.Close()
        End Try
        Return correoResponsable
    End Function
    'Ok
    Private Function BuscarEncargados(ByVal nombre As String, ByVal area As String, ByVal empresa As String) As List(Of String)
        Dim lista As List(Of String) = New List(Of String)
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        Try
            Dim comand As SqlCommand = New SqlCommand("Solicitud_Buscar_Responsables_Permisos", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.Add(New SqlParameter("@nombreCompleto", nombre))
            comand.Parameters.Add(New SqlParameter("@area", area))
            comand.Parameters.Add(New SqlParameter("@empresa", empresa))
            Dim adapter As New SqlDataAdapter(comand)
            Dim tabla As DataTable = New DataTable()
            adapter.Fill(tabla)
            comand.Dispose()
            For i = 0 To tabla.Rows.Count - 1
                lista.Add(tabla.Rows(i)("nombreJefe").ToString)
            Next
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try
        Return lista
    End Function
    'Ok
    Private Function listaAutocompletadaTrabajadores(ByVal area As String) As AutoCompleteStringCollection
        Dim lista As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        Try
            Dim cmd As SqlCommand = New SqlCommand("Solicitud_Empleados_Sugeridos_Area", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@area", area))
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            adapter.Fill(dt)
            For i = 0 To dt.Rows.Count - 1
                lista.Add(dt.Rows(i)("nombre").ToString)
            Next
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("error: " + ex.Message, MsgBoxStyle.Exclamation, "Area Invalida")
        Finally
            conexion.Close()
        End Try
        Return lista
    End Function
    'Ok
    Private Sub ValidarCambioHora()
        'Se valida que la hora de entrada sea igual o mayor a la hora de salida

        If dtpHoraEntrada.Value < dtpHoraSalida.Value Then
            dtpHoraEntrada.Value = dtpHoraSalida.Value
        End If
    End Sub
    'Ok
    Private Sub CalcularHorasMinutos()
        'Este metodo calcula la cantidad de minutos y horas que ocupara el trabajador durante su salida
        Dim diferencia As TimeSpan = (dtpHoraEntrada.Value.TimeOfDay - dtpHoraSalida.Value.TimeOfDay)
        Dim horas As String = diferencia.Hours
        Dim minutos As String = diferencia.Minutes
        txbTotalHoras.Text = diferencia.Hours.ToString + " horas y " + diferencia.Minutes.ToString + " minutos"
    End Sub
    'Ok
    Private Sub txbHorasExtras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbHorasExtras.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    '--------------------- Fin Permisos ---------------------------------------------------------



















    ' ----------------------- Solicitud Horas Extras -----------------------------------------
    'ok
    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        For i = 0 To dgvColaboradoresSHHEE.RowCount - 2
            dgvColaboradoresSHHEE.Rows(i).Cells("fechaRealSolicitarHHEE").Value = dtpFecha.Value.ToString("dd-MM-yyyy")
        Next
    End Sub
    ''Ok
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBxDetalleSHX.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgvColaboradoresSHHEE.CurrentCell = dgvColaboradoresSHHEE.Rows(0).Cells(1)
            dgvColaboradoresSHHEE.BeginEdit(True)
        End If
    End Sub
    'Ok
    Private Sub txbHorasExtras_TextChanged(sender As Object, e As EventArgs) Handles txbHorasExtras.TextChanged
        Try
            txbHorasExtras.Text = Convert.ToInt16(txbHorasExtras.Text)
        Catch ex As Exception
            txbHorasExtras.Text = 1
        End Try
    End Sub
    'Ok
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        While dgvColaboradoresSHHEE.Rows.Count > 1
            dgvColaboradoresSHHEE.Rows.RemoveAt(0)
        End While
        OrdenarDGV()
        ComboBox2.DataSource = BuscarEncargados(ComboBox3.Text, MDIParent1.TxtBx_Empresa.Text)
        TxtBxDetalleSHX.Select()
    End Sub
    ' ----------------------------------------------------------------
    'Ok
    Private Sub OrdenarDGV()
        For i = 0 To dgvColaboradoresSHHEE.RowCount - 1
            dgvColaboradoresSHHEE.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub
    'ok
    Private Function BuscarEncargados(ByVal area As String, ByVal empresa As String) As List(Of String)
        Dim lista As List(Of String) = New List(Of String)
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        Try
            Dim comand As SqlCommand = New SqlCommand("Solicitud_Buscar_Responsables_HorasExtras", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.Add(New SqlParameter("@area", area))
            comand.Parameters.Add(New SqlParameter("@empresa", empresa))
            Dim adapter As New SqlDataAdapter(comand)
            Dim tabla As DataTable = New DataTable()
            adapter.Fill(tabla)
            comand.Dispose()
            For i = 0 To tabla.Rows.Count - 1
                lista.Add(tabla.Rows(i)("nombreJefe").ToString)
            Next
        Catch ex As Exception
            MsgBox("error: " + ex.Message, MsgBoxStyle.Exclamation, "Error Areas")
        Finally
            conexion.Close()
        End Try
        Return lista
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MDIParent1.Panel2.Visible = True
        MDIParent1.TiempoIngreso.Enabled = True
        MDIParent1.Visualizar_Tiles_MDI()
        Me.Close()
    End Sub
    'Ok
    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvColaboradoresSHHEE.CellValueChanged
        If eventFlag Then
            If e.ColumnIndex = dgvColaboradoresSHHEE.Columns("nombreColaborador").Index And e.RowIndex >= 0 Then
                For i = 0 To dgvColaboradoresSHHEE.Rows.Count - 2
                    If i <> e.RowIndex And dgvColaboradoresSHHEE.Rows(i).Cells("nombreColaborador").Value.ToString.ToLower = dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells("nombreColaborador").Value.ToString.ToLower Then
                        dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells("nombreColaborador").Value = ""
                        dgvColaboradoresSHHEE.Rows.RemoveAt(e.RowIndex)
                        OrdenarDGV()
                        MsgBox("La persona ya hace parte de los colaboradores", MsgBoxStyle.Exclamation, "Persona Duplicada")
                        Return
                    End If
                Next
                dt = BuscarDatosTrabajador(dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells("nombreColaborador").Value)
                dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells(2).Value = dt.Rows(0)("rut").ToString()
                dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells(3).Value = dt.Rows(0)("cargo").ToString()
                dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells(4).Value = dt.Rows(0)("nombre_emp").ToString()
                eventFlag = False
                dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells("nombreColaborador").Value = dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells("nombreColaborador").Value.ToString.ToUpper
                eventFlag = True
            End If

            If e.RowIndex >= 0 And (e.ColumnIndex = dgvColaboradoresSHHEE.Columns("horaInicioSolicitarHHEE").Index Or e.ColumnIndex = dgvColaboradoresSHHEE.Columns("horaTerminoSolicitarHHEE").Index) Then
                Dim hora As String = dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
                Try
                    hora = Convert.ToInt32(hora).ToString
                    If hora.Length = 1 Or hora.Length = 2 Then
                        If hora.Length = 1 Then
                            dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "0" + hora + ":00"
                        Else
                            dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = hora + ":00"
                        End If
                    ElseIf hora.Length = 3 Or hora.Length = 4 Then
                        If hora.Length = 3 Then
                            Dim derp As String = "0" + hora.Substring(0, 1) + ":" + hora.Substring(1, 2)
                            dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = derp
                        Else
                            dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = hora.Substring(0, 2) + ":" + hora.Substring(2, 2)
                        End If
                    Else
                        If e.ColumnIndex = dgvColaboradoresSHHEE.Columns("horaTerminoSolicitarHHEE").Index Then
                            dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = (Convert.ToInt32(txbHorasExtras.Text) + 18).ToString + ":00"
                        Else
                            dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "18:00"
                        End If
                    End If
                Catch ex1 As Exception
                    Try
                        Convert.ToDateTime(hora)
                        Try
                            If Convert.ToDateTime(dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells("horaInicioSolicitarHHEE").Value) >= Convert.ToDateTime(dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells("horaTerminoSolicitarHHEE").Value) Then
                                dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells("horaTerminoSolicitarHHEE").Value = Convert.ToDateTime(dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells("horaInicioSolicitarHHEE").Value).AddHours(Convert.ToInt32(txbHorasExtras.Text)).ToString("HH:mm")
                            End If
                            dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells("cantidadHoras").Value = CalcularHorasMinutos(Convert.ToDateTime(dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells("horaInicioSolicitarHHEE").Value), Convert.ToDateTime(dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells("horaTerminoSolicitarHHEE").Value))
                        Catch ex As Exception
                        End Try
                    Catch ex2 As Exception
                        If e.ColumnIndex = dgvColaboradoresSHHEE.Columns("horaTerminoSolicitarHHEE").Index Then
                            dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = (Convert.ToInt32(txbHorasExtras.Text) + 18).ToString + ":00"
                        Else
                            dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "18:00"
                        End If
                    End Try
                End Try
            End If
        End If

    End Sub
    'Ok
    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvColaboradoresSHHEE.EditingControlShowing
        If dgvColaboradoresSHHEE.CurrentCell.ColumnIndex = 1 Then
            Dim texbox As TextBox = TryCast(e.Control, TextBox)
            If texbox IsNot Nothing Then
                texbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                texbox.AutoCompleteCustomSource = listaAutocompletadaTrabajadores()
                texbox.AutoCompleteSource = AutoCompleteSource.CustomSource
            End If
        End If
    End Sub
    'ok
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvColaboradoresSHHEE.RowsAdded
        dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells(0).Value = dgvColaboradoresSHHEE.RowCount
        If dgvColaboradoresSHHEE.RowCount > 2 Then
            dgvColaboradoresSHHEE.Rows(e.RowIndex - 1).Cells("horaInicioSolicitarHHEE").Value = dgvColaboradoresSHHEE.Rows(0).Cells("horaInicioSolicitarHHEE").Value
            dgvColaboradoresSHHEE.Rows(e.RowIndex - 1).Cells("horaTerminoSolicitarHHEE").Value = dgvColaboradoresSHHEE.Rows(0).Cells("horaTerminoSolicitarHHEE").Value
            dgvColaboradoresSHHEE.Rows(e.RowIndex - 1).Cells("fechaRealSolicitarHHEE").Value = dgvColaboradoresSHHEE.Rows(0).Cells("fechaRealSolicitarHHEE").Value
        ElseIf dgvColaboradoresSHHEE.RowCount = 2 Then
            dgvColaboradoresSHHEE.Rows(e.RowIndex - 1).Cells("horaInicioSolicitarHHEE").Value = "18:00"
            If (18 + txbHorasExtras.Text) < 24 Then
                dgvColaboradoresSHHEE.Rows(e.RowIndex - 1).Cells("horaTerminoSolicitarHHEE").Value = (18 + txbHorasExtras.Text).ToString + ":00"
            Else
                dgvColaboradoresSHHEE.Rows(e.RowIndex - 1).Cells("horaTerminoSolicitarHHEE").Value = (18 + txbHorasExtras.Text - 24).ToString + ":00"
            End If

            dgvColaboradoresSHHEE.Rows(e.RowIndex - 1).Cells("fechaRealSolicitarHHEE").Value = dtpFecha.Value.ToString("dd-MM-yyyy")
        End If

    End Sub
    'Ok
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvColaboradoresSHHEE.CellClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex > 0 And e.ColumnIndex < dgvColaboradoresSHHEE.Columns("btnEliminar").Index And e.RowIndex >= 0 Then
                dgvColaboradoresSHHEE.CurrentCell = dgvColaboradoresSHHEE.Rows(e.RowIndex).Cells(e.ColumnIndex)
                If e.ColumnIndex = dgvColaboradoresSHHEE.Columns("horaInicioSolicitarHHEE").Index Or e.ColumnIndex = dgvColaboradoresSHHEE.Columns("horaTerminoSolicitarHHEE").Index Then
                    dgvColaboradoresSHHEE.BeginEdit(True)
                Else
                    dgvColaboradoresSHHEE.BeginEdit(False)
                End If


            End If

            'Se ejecuta al realizar un click sobre cualquiera de los botones "eliminar" del datagridview, elimina la fila en la cual se encuentra el boton
            If e.ColumnIndex = dgvColaboradoresSHHEE.Columns("btnEliminar").Index And e.RowIndex <> dgvColaboradoresSHHEE.RowCount - 1 Then
                dgvColaboradoresSHHEE.Rows.RemoveAt(e.RowIndex)
                OrdenarDGV()
            End If
        End If
    End Sub
    'Ok
    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs)

    End Sub
    'Ok

    Private Function MandarInformeSolicitudHrasExt(ByVal correo As String) As Boolean
        Try
            'El mensaje contiene un informe de los datos de la solicitud
            Dim mensaje As String = "El solicitante " & txbSupervisorSolicitante.Text & " pide permiso para hora extra para el area: " & cmbAreas.Text & "."
            mensaje += vbCrLf
            mensaje += "Horas extras: " & txbHorasExtras.Text & "."
            mensaje += vbCrLf
            mensaje += "Detalle del trabajo: " & txbDetalle.Text & "."
            mensaje += vbCrLf
            mensaje += vbCrLf
            mensaje += "Colaboradores:"
            mensaje += vbCrLf
            For i = 0 To dgvColaboradores.RowCount - 2
                mensaje += vbCrLf
                mensaje += "Nombre      : " & dgvColaboradores.Rows(i).Cells("nombreColaborador").Value & "." & vbCrLf
                mensaje += "Rut         : " & dgvColaboradores.Rows(i).Cells("rutSolicitarHHEE").Value & "." & vbCrLf
                mensaje += "Cargo       : " & dgvColaboradores.Rows(i).Cells("cargoSolicitarHHEE").Value & "." & vbCrLf
                mensaje += "Empresa     : " & dgvColaboradores.Rows(i).Cells("nombreEmpresaSolicitarHHEE").Value & "." & vbCrLf
                mensaje += "Hora Inicio : " & dgvColaboradores.Rows(i).Cells("horaInicioSolicitarHHEE").Value & "." & vbCrLf
                mensaje += "Hora Termino: " & dgvColaboradores.Rows(i).Cells("horaTerminoSolicitarHHEE").Value & "." & vbCrLf
                mensaje += "Fecha       : " & dgvColaboradores.Rows(i).Cells("fechaRealSolicitarHHEE").Value & "." & vbCrLf
            Next

            'Un correo conteniendo los datos es entonces enviado al responsable de la autorización
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("sys.mindugar@mindugar.cl", "SyS_min281")
            Smtp_Server.Port = 25
            Smtp_Server.EnableSsl = False
            Smtp_Server.Host = "correo.mindugar.cl"

            'MsgBox("correo es: " + correo, MsgBoxStyle.Information, "correo es:")

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("sys.mindugar@mindugar.cl")
            e_mail.To.Add(correo)
            e_mail.Subject = "Empleado Solicita Hora Extra"
            e_mail.IsBodyHtml = False
            e_mail.Body = mensaje
            Smtp_Server.Send(e_mail)
            Return True
        Catch error_t As Exception
            MsgBox(error_t.ToString)
            Return False
        End Try
    End Function
    'Ok
    Private Function ValidarFormulario() As Boolean
        Try
            If dgvColaboradoresSHHEE.RowCount = 1 Then
                MsgBox("Porfavor ingrese los datos de los colaboradores asociados a la hora extra", MsgBoxStyle.Exclamation, "Datos Faltantes")
                Return False
            End If
            If TxtBxDetalleSHX.Text = "" Then
                MsgBox("Porfavor, ingrese la justificación", MsgBoxStyle.Exclamation, "Datos Ausentes")
                Return False
            End If

            For i = 0 To dgvColaboradoresSHHEE.RowCount - 2
                Convert.ToDateTime(dgvColaboradoresSHHEE.Rows(i).Cells("horaInicioSolicitarHHEE").Value)
                Convert.ToDateTime(dgvColaboradoresSHHEE.Rows(i).Cells("horaTerminoSolicitarHHEE").Value)
                If Convert.ToDateTime(dgvColaboradoresSHHEE.Rows(i).Cells("horaInicioSolicitarHHEE").Value) >= Convert.ToDateTime(dgvColaboradoresSHHEE.Rows(i).Cells("horaTerminoSolicitarHHEE").Value) Then
                    MsgBox("La hora de entrada es menor a la hora de salida", MsgBoxStyle.Exclamation, "Horas invalidas")
                    Return False
                End If
                Convert.ToDateTime(dgvColaboradoresSHHEE.Rows(i).Cells("fechaRealSolicitarHHEE").Value)
                If dgvColaboradoresSHHEE.Rows(i).Cells("horaInicioSolicitarHHEE").Value = String.Empty Or dgvColaboradoresSHHEE.Rows(i).Cells("horaTerminoSolicitarHHEE").Value = String.Empty Or dgvColaboradoresSHHEE.Rows(i).Cells("horaInicioSolicitarHHEE").Value >= dgvColaboradoresSHHEE.Rows(i).Cells("horaTerminoSolicitarHHEE").Value Then
                    Return False
                End If
            Next
            Return ValidarTrabajadores()
        Catch ex As Exception
            MsgBox("El formato de uno o mas integrante se encuentra incorrecto, porfavor verifique los datos ingresados", MsgBoxStyle.Exclamation, "Datos Incorrectos")
            Return False
        End Try
    End Function
    'Ok
    Private Function CalcularHorasMinutos(ByVal salida As DateTime, ByVal entrada As DateTime) As String
        'Este metodo calcula la cantidad de minutos y horas que ocupara el trabajador durante su salida
        Dim diferencia As TimeSpan = (entrada.TimeOfDay - salida.TimeOfDay)
        Dim horas As String = diferencia.Hours
        Dim minutos As String
        If diferencia.Minutes < 10 Then
            minutos = "0" + diferencia.Minutes.ToString
        Else
            minutos = diferencia.Minutes
        End If
        Return horas.ToString + ":" + minutos.ToString
    End Function
    'ok
    Private Function listaAutocompletadaTrabajadores() As AutoCompleteStringCollection
        Dim lista As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        Try
            conexion.Open()
            cmd = New SqlCommand("Solicitud_Empleados_Sugeridos_Area", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@area", ComboBox3.Text))
            Dim adapter As New SqlDataAdapter(cmd)
            dt = New DataTable()
            adapter.Fill(dt)
            For i = 0 To dt.Rows.Count - 1
                lista.Add(dt.Rows(i)("Nombre").ToString)
            Next
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("error: " + ex.Message, MsgBoxStyle.Exclamation, "RUT Invalido")
        Finally
            conexion.Close()
        End Try
        Return lista
    End Function
    'ok
    Private Function ValidarTrabajadores() As Boolean

        For i = 0 To dgvColaboradoresSHHEE.Rows.Count - 2
            'En caso que la conexion este abierta es necesaria cerrarla
            Try
                conexion.Close()
            Catch ex As Exception
            End Try
            conexion.Open()
            Try
                If dgvColaboradoresSHHEE.Rows(i).Cells("rutSolicitarHHEE").Value.ToString.Length < 5 Then
                    Return False
                End If
                Dim comand As SqlCommand = New SqlCommand("Solicitud_Validar_Trabajador_HoraExtra", conexion)
                comand.CommandType = CommandType.StoredProcedure
                comand.Parameters.Add(New SqlParameter("@rut", dgvColaboradoresSHHEE.Rows(i).Cells("rutSolicitarHHEE").Value.ToString))
                Dim fecha As DateTime = Convert.ToDateTime(dgvColaboradoresSHHEE.Rows(i).Cells("fechaRealSolicitarHHEE").Value)
                comand.Parameters.Add(New SqlParameter("@fecha", New DateTime(fecha.Year, fecha.Month, fecha.Day, 0, 0, 0, 0)))
                Dim returnParameter = comand.Parameters.Add("@ReturnVal", SqlDbType.Int)
                returnParameter.Direction = ParameterDirection.ReturnValue
                comand.ExecuteReader()
                If returnParameter.Value <> 1 Then
                    MsgBox("Uno o mas trabajadores ya estan incluido en hora extra para esta fecha", MsgBoxStyle.Critical, "Trabajador ya esta en hora extra!")
                    Return False
                End If
                comand.Dispose()
                Return True
            Catch ex As Exception
                MsgBox("error: " + ex.Message, MsgBoxStyle.Critical, "Error!")
                Return False
            Finally
                conexion.Close()
            End Try
        Next
        Return True
    End Function




    ' ------------------------ Fin Horas Extras----------------------------------------















    ' ------------------------ Autoriza Horas Extras ----------------------------------
    'Ok
    Private Sub cmbNumeroSolicitud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNumeroSolicitud.SelectedIndexChanged
        CargarSolicitud()
        CargarColaboradores()
    End Sub
    ''Ok
    Private Sub chkTodas_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodas.CheckedChanged
        dgvColaboradores.Rows.Clear()
        dtpInicio.Value = New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 0, 0)
        dtpTermino.Value = New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 0, 0)
        CargarNumeroSolicitudes()
        If chkTodas.Checked Then
            Dim columnaAutorizar As DataGridViewButtonColumn = dgvColaboradores.Columns("btnAutorizar")
            columnaAutorizar.FlatStyle = FlatStyle.Flat
            Dim columnaRechazar As DataGridViewButtonColumn = dgvColaboradores.Columns("btnRechazar")
            columnaRechazar.FlatStyle = FlatStyle.Flat
            dtpInicio.Visible = True
            dtpTermino.Visible = True
        Else
            Dim columnaAutorizar As DataGridViewButtonColumn = dgvColaboradores.Columns("btnAutorizar")
            columnaAutorizar.FlatStyle = FlatStyle.Standard
            Dim columnaRechazar As DataGridViewButtonColumn = dgvColaboradores.Columns("btnRechazar")
            columnaRechazar.FlatStyle = FlatStyle.Standard
            dtpInicio.Visible = False
            dtpTermino.Visible = False
        End If

    End Sub
    'ok
    Private Sub dtpInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpTermino.ValueChanged, dtpInicio.ValueChanged
        dtpInicio.Value = New DateTime(dtpInicio.Value.Year, dtpInicio.Value.Month, dtpInicio.Value.Day, 0, 0, 0, 0)
        CargarNumeroSolicitudes()
    End Sub
    'ok
    Private Sub dgvColaboradores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvColaboradores.CellClick
        If e.RowIndex >= 0 Then
            'Se ejecuta al realizar un click sobre cualquiera de los botones "eliminar" del datagridview, elimina la fila en la cual se encuentra el boton
            If e.ColumnIndex = 8 Or e.ColumnIndex = 9 Then
                If e.ColumnIndex = 8 Then
                    AutorizarSolicitud(e.RowIndex)
                    dgvColaboradores.Rows.RemoveAt(e.RowIndex)

                End If
                If e.ColumnIndex = 9 Then
                    RechazarSolicitud(e.RowIndex)
                    dgvColaboradores.Rows.RemoveAt(e.RowIndex)
                End If
                If chkTodas.Checked Then
                    Dim solicitudIndex As String = cmbNumeroSolicitud.SelectedIndex
                    CargarNumeroSolicitudes()
                    cmbNumeroSolicitud.SelectedIndex = solicitudIndex
                    CargarSolicitud()
                    CargarColaboradores()
                End If
            End If
            OrdenarDGV()
            VerficicarResolucionSolucion()
            If dgvColaboradores.Rows.Count = 0 Then
                CargarNumeroSolicitudes()
            End If
        End If

    End Sub
    'ok
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim todosResueltos As Boolean = True
        Dim hayAutorizados As Boolean = False
        For i = 0 To dgvColaboradores.Rows.Count - 1
            If dgvColaboradores.Rows(i).DefaultCellStyle.BackColor <> Color.LightGray Then
                todosResueltos = False
            End If
            If dgvColaboradores.Rows(i).Cells("btnAutorizar").Style.BackColor = Color.Green Then
                hayAutorizados = True
            End If
        Next

        If todosResueltos And hayAutorizados Then
            Dim id As Integer
            Try
                id = Convert.ToInt32(cmbNumeroSolicitud.Text)
                Dim informe As New InformeHoraExtra()
                informe.SetParameterValue("@id", id)
                informe.SetDatabaseLogon("sa", "Sqladmin281")
                Dim formInforme As New Frm_ImprimirReporte(informe)
                formInforme.Show()
            Catch ex As Exception
            End Try
        Else
            MsgBox("No todos los trabajadores han sido autorizados o rechazados (tambien es necesario por lo menos un trabajador autorizado)", MsgBoxStyle.Critical, "Hora extra no resuelta!")
        End If

    End Sub
    'ok
    Private Sub btnAutorizarTodas_Click(sender As Object, e As EventArgs) Handles btnAutorizarTodas.Click
        AutorizarTodasSolicitudes()
        VerficicarResolucionSolucion()
        CargarNumeroSolicitudes()
    End Sub
    'ok
    Private Sub btnRechazarTodas_Click(sender As Object, e As EventArgs) Handles btnRechazarTodas.Click
        RechazarTodasSolicitudes()
        VerficicarResolucionSolucion()
        CargarNumeroSolicitudes()
    End Sub
    '----------------------------------------------------------------------------------
    'OK
    Private Sub CargarNumeroSolicitudes()
        LimparDatos()
        Dim nombreProcedure As String
        If chkTodas.Checked Then
            nombreProcedure = "Solicitud_Buscar_Todas_HoraExtra"
        Else
            nombreProcedure = "Solicitud_Buscar_Solicitudes_HoraExtra"
        End If
        Dim comand As SqlCommand = New SqlCommand(nombreProcedure, conexion)
        comand.Connection = conexion
        comand.CommandType = CommandType.StoredProcedure
        comand.Parameters.Add(New SqlParameter("@nombreCompleto", MDIParent1.TxtBx_UserName.Text))
        If chkTodas.Checked Then
            comand.Parameters.Add(New SqlParameter("@fecha_inicio", dtpInicio.Value))
            comand.Parameters.Add(New SqlParameter("@fecha_termino", dtpTermino.Value.AddDays(1)))
        End If
        If MDIParent1.RevisaAcceso(90012) Then
            comand.Parameters.Add(New SqlParameter("@verTodas", 1))
        End If
        Dim adapter As New SqlDataAdapter(comand)
        Dim table As DataTable = New DataTable()
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        Try
            adapter.Fill(table)
            Dim lista As New List(Of [String])()
            For i = 0 To table.Rows.Count - 1
                lista.Add(table.Rows(i)("id_solicitud_horas_extra").ToString)
            Next
            cmbNumeroSolicitud.DataSource = lista
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos: " + ex.Message, MsgBoxStyle.Critical, "Error!")
        Finally
            conexion.Close()
        End Try
    End Sub
    ''Ok
    Private Sub LimparDatos()
        txbFecha.Text = ""
        txbDetalle.Text = ""
        cmbNumeroSolicitud.Text = ""
        txbSolicitante.Text = ""
        dgvColaboradores.Rows.Clear()
    End Sub
    'ok
    Private Sub CargarSolicitud()
        'En caso que la conexion este abierta es necesaria cerrarla
        Try
            conexion.Close()
        Catch ex As Exception
        End Try

        conexion.Open()
        Dim comand As SqlCommand = New SqlCommand()
        comand.Connection = conexion
        comand.CommandText = "SELECT supervisor_solicitante, rut_solicitante, fecha, detalle FROM [SAC_Mindugar].[dbo].[Solicitud_HorasExtras] WHERE id_solicitud_horas_extra = " + cmbNumeroSolicitud.Text
        Dim adapter As New SqlDataAdapter(comand)
        Dim table As DataTable = New DataTable()
        Try
            adapter.Fill(table)
            txbDetalle.Text = table.Rows(0)("detalle")
            txbSolicitante.Text = table.Rows(0)("supervisor_solicitante")
            txbFecha.Text = table.Rows(0)("fecha")
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos: " + ex.Message, MsgBoxStyle.Critical, "Error!")
        Finally
            conexion.Close()
        End Try
    End Sub
    'ok
    Private Sub CargarColaboradores()
        'En caso que la conexion este abierta es necesaria cerrarla
        Try
            conexion.Close()
        Catch ex As Exception
        End Try

        LimparDataGridView()

        conexion.Open()
        Dim comand As SqlCommand = New SqlCommand()
        comand.Connection = conexion
        If chkTodas.Checked Then
            comand.CommandText = "SELECT nombre_completo, rut, horas_compromiso_inicio, total_horas_compromiso, fecha_real, empresa, cargo, ISNULL(rechazado,0) as rechazado, ISNULL(autorizado,0) as autorizado FROM [SAC_Mindugar].[dbo].[Solicitud_HorasExtras_Colaboradores] WHERE id_solicitud_horas_extra = " + cmbNumeroSolicitud.Text
        Else
            comand.CommandText = "SELECT nombre_completo, rut, horas_compromiso_inicio, total_horas_compromiso, fecha_real, empresa, cargo FROM [SAC_Mindugar].[dbo].[Solicitud_HorasExtras_Colaboradores] WHERE rechazado is null And autorizado is null And id_solicitud_horas_extra = " + cmbNumeroSolicitud.Text
        End If
        Dim adapter As New SqlDataAdapter(comand)
        Dim table As DataTable = New DataTable()
        Try
            adapter.Fill(table)
            For i = 0 To table.Rows.Count - 1
                dgvColaboradores.Rows.Add(1)
                dgvColaboradores.Rows(i).Cells("nombreColaboradores").Value = table.Rows(i)("nombre_completo")
                dgvColaboradores.Rows(i).Cells("rut").Value = table.Rows(i)("rut")
                dgvColaboradores.Rows(i).Cells("horaInicio").Value = DateTime.Parse(table.Rows(i)("horas_compromiso_inicio").ToString).ToString("hh:mm")
                dgvColaboradores.Rows(i).Cells("horaTermino").Value = DateTime.Parse(table.Rows(i)("horas_compromiso_inicio").ToString).AddHours(table.Rows(i)("total_horas_compromiso")).ToString("hh:mm")
                dgvColaboradores.Rows(i).Cells("fechaReal").Value = DateTime.Parse(table.Rows(i)("fecha_real").ToString).ToString("dd-MM-yyyy")
                dgvColaboradores.Rows(i).Cells("nombreEmpresa").Value = table.Rows(i)("empresa")
                dgvColaboradores.Rows(i).Cells("cargo").Value = table.Rows(i)("cargo")
                If chkTodas.Checked Then
                    If table.Rows(i)("rechazado") Or table.Rows(i)("autorizado") Then
                        dgvColaboradores.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                        If table.Rows(i)("rechazado") Then
                            dgvColaboradores.Rows(i).Cells("btnRechazar").Style.ForeColor = Color.Black
                            dgvColaboradores.Rows(i).Cells("btnRechazar").Style.BackColor = Color.Red
                            dgvColaboradores.Rows(i).Cells("btnAutorizar").Style.ForeColor = Color.Black
                            dgvColaboradores.Rows(i).Cells("btnAutorizar").Style.BackColor = Color.White
                        Else
                            dgvColaboradores.Rows(i).Cells("btnAutorizar").Style.ForeColor = Color.Black
                            dgvColaboradores.Rows(i).Cells("btnAutorizar").Style.BackColor = Color.Green
                            dgvColaboradores.Rows(i).Cells("btnRechazar").Style.ForeColor = Color.Black
                            dgvColaboradores.Rows(i).Cells("btnRechazar").Style.BackColor = Color.White
                        End If
                    Else
                        dgvColaboradores.Rows(i).Cells("btnRechazar").Style.ForeColor = Color.Black
                        dgvColaboradores.Rows(i).Cells("btnRechazar").Style.BackColor = Color.White
                        dgvColaboradores.Rows(i).Cells("btnAutorizar").Style.ForeColor = Color.Black
                        dgvColaboradores.Rows(i).Cells("btnAutorizar").Style.BackColor = Color.White
                    End If
                End If
            Next
            OrdenarDGV()
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos: " + ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try

    End Sub
    ''OK
    Private Sub LimparDataGridView()
        dgvColaboradores.Rows.Clear()
    End Sub
    'ok
    Private Function AutorizarSolicitud(ByVal index As Integer) As Boolean
        'En caso que la conexion este abierta es necesaria cerrarla
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        Try
            Dim comand As SqlCommand = New SqlCommand("Solicitud_HoraExtra_Autorizar", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.Add(New SqlParameter("@nombre", dgvColaboradores.Rows(index).Cells("nombreColaboradores").Value.ToString))
            comand.Parameters.Add(New SqlParameter("@id", Convert.ToInt32(cmbNumeroSolicitud.Text)))
            comand.Parameters.Add(New SqlParameter("@responsable_resolucion", MDIParent1.TxtBx_UserName.Text))
            Dim returnParameter = comand.Parameters.Add("@ReturnVal", SqlDbType.Int)
            returnParameter.Direction = ParameterDirection.ReturnValue
            comand.ExecuteReader()
            'MsgBox("return: " + returnParameter.Value.ToString, MsgBoxStyle.Critical, "return!")
            comand.Dispose()
            Return True
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos: " + ex.Message, MsgBoxStyle.Critical, "Error!")
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    'ok
    Private Function RechazarSolicitud(ByVal index As Integer) As Boolean
        'En caso que la conexion este abierta es necesaria cerrarla
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        Try
            Dim comand As SqlCommand = New SqlCommand("Solicitud_HoraExtra_Rechazar", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.Add(New SqlParameter("@nombre", dgvColaboradores.Rows(index).Cells("nombreColaboradores").Value.ToString))
            comand.Parameters.Add(New SqlParameter("@id", Convert.ToInt32(cmbNumeroSolicitud.Text)))
            comand.Parameters.Add(New SqlParameter("@responsable_resolucion", MDIParent1.TxtBx_UserName.Text))
            comand.ExecuteReader()
            comand.Dispose()
            Return True
        Catch ex As Exception
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    'ok
    Private Sub VerficicarResolucionSolucion()
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        Try
            Dim comand As SqlCommand = New SqlCommand("Solicitud_Verificar_Resolucion", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.Add(New SqlParameter("@id", Convert.ToInt32(cmbNumeroSolicitud.Text)))
            comand.ExecuteReader()
            comand.Dispose()
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try
    End Sub
    'ok
    Private Function AutorizarTodasSolicitudes() As Boolean
        'En caso que la conexion este abierta es necesaria cerrarla
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        Try
            Dim comand As SqlCommand = New SqlCommand("Solicitud_HoraExtra_Autorizar", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.Add(New SqlParameter("@id", Convert.ToInt32(cmbNumeroSolicitud.Text)))
            comand.ExecuteReader()
            comand.Dispose()
            Return True
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos: " + ex.Message, MsgBoxStyle.Critical, "Error!")
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    'ok
    Private Function RechazarTodasSolicitudes() As Boolean
        'En caso que la conexion este abierta es necesaria cerrarla
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        Try
            Dim comand As SqlCommand = New SqlCommand("Solicitud_HoraExtra_Rechazar", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.Add(New SqlParameter("@id", Convert.ToInt32(cmbNumeroSolicitud.Text)))
            comand.ExecuteReader()
            comand.Dispose()
            Return True
        Catch ex As Exception
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    ' ------------------------ Fin Autoriza Horas Extras ----------------------------------
























    ' ------------------------ Autoriza Permisos ----------------------------------
    Private Function AutorizarPermiso(ByVal index As Integer) As Boolean
        conexion.Open()
        Dim fechaPermiso As DateTime = DateTime.Parse(dgvSolicitudesSalida.Rows(index).Cells("fechaSalida").Value.ToString).ToString("dd-MM-yyyy")
        If dgvSolicitudesSalida.Rows(index).Cells("diaCompleto").Value = "No" Then
            Dim horaPermiso As DateTime = DateTime.Parse(dgvSolicitudesSalida.Rows(index).Cells("horaSalida").Value.ToString).ToString("HH:mm")
            Dim fechaExactaPermiso As DateTime = New DateTime(fechaPermiso.Year, fechaPermiso.Month, fechaPermiso.Day, horaPermiso.Hour, horaPermiso.Minute, 0, 0)
            If fechaExactaPermiso < DateTime.Now Then
                'MsgBox("La solicitud ya caducó", MsgBoxStyle.Exclamation, "Solicitud Caducada")
                'Return False
            End If
        Else
            Dim fechaExactaPermiso As DateTime = New DateTime(fechaPermiso.Year, fechaPermiso.Month, fechaPermiso.Day, 0, 0, 0, 0)
            If fechaExactaPermiso <= DateTime.Now Then
                'MsgBox("La solicitud ya caducó", MsgBoxStyle.Exclamation, "Solicitud Caducada")
                'Return False
            End If
        End If


        Try
            Dim comand As SqlCommand = New SqlCommand("Solicitud_Permiso_Autorizar", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.Add(New SqlParameter("@id", Convert.ToInt32(dgvSolicitudesSalida.Rows(index).Cells("numeroSolicitud").Value)))
            comand.Parameters.Add(New SqlParameter("@responsable", MDIParent1.TxtBx_UserName.Text))
            comand.ExecuteReader()
            comand.Dispose()
            Return True
        Catch ex As Exception
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Private Function RechazarPermiso(ByVal index As Integer) As Boolean
        conexion.Open()
        Dim fechaPermiso As DateTime = DateTime.Parse(dgvSolicitudesSalida.Rows(index).Cells("fechaSalida").Value.ToString).ToString("dd-MM-yyyy")
        If dgvSolicitudesSalida.Rows(index).Cells("diaCompleto").Value = "No" Then
            Dim horaPermiso As DateTime = DateTime.Parse(dgvSolicitudesSalida.Rows(index).Cells("horaSalida").Value.ToString).ToString("HH:mm")
            Dim fechaExactaPermiso As DateTime = New DateTime(fechaPermiso.Year, fechaPermiso.Month, fechaPermiso.Day, horaPermiso.Hour, horaPermiso.Minute, 0, 0)
            If fechaExactaPermiso < DateTime.Now Then
                'MsgBox("La solicitud ya caducó", MsgBoxStyle.Exclamation, "Solicitud Caducada")
                'Return False
            End If
        Else
            Dim fechaExactaPermiso As DateTime = New DateTime(fechaPermiso.Year, fechaPermiso.Month, fechaPermiso.Day, 0, 0, 0, 0)
            If fechaExactaPermiso <= DateTime.Now Then
                'MsgBox("La solicitud ya caducó", MsgBoxStyle.Exclamation, "Solicitud Caducada")
                'Return False
            End If
        End If

        Try
            Dim comand As SqlCommand = New SqlCommand("Solicitud_Permiso_Rechazar", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.Add(New SqlParameter("@id", Convert.ToInt32(dgvSolicitudesSalida.Rows(index).Cells("numeroSolicitud").Value)))
            comand.Parameters.Add(New SqlParameter("@responsable", MDIParent1.TxtBx_UserName.Text))
            comand.ExecuteReader()
            comand.Dispose()
            Return True
        Catch ex As Exception
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Private Sub chkVerPendientes_CheckedChanged(sender As Object, e As EventArgs) Handles chkVerPendientes.CheckedChanged
        CargarPermisos(MDIParent1.TxtBx_UserName.Text, dtpFechaInicio.Value, dtpFechaTermino.Value)
    End Sub
    Public Sub CargarPermisos(ByVal nombre As String, ByVal inicio As DateTime, ByVal termino As DateTime)
        dgvSolicitudesSalida.Rows.Clear()
        Dim tabla As DataTable = New DataTable()
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        termino.AddDays(2)
        Try
            Dim comand As SqlCommand
            If chkVerPendientes.Checked Then
                comand = New SqlCommand("Solicitud_Buscar_Solicitudes_PermisosPendiente", conexion)

            Else
                comand = New SqlCommand("Solicitud_Buscar_Solicitudes_Permisos", conexion)
            End If
            If MDIParent1.RevisaAcceso(90012) Then
                comand.Parameters.Add(New SqlParameter("@verTodas", 1))
            End If
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.Add(New SqlParameter("@nombreCompleto", nombre))
            comand.Parameters.Add(New SqlParameter("@fecha_inicio", inicio))
            termino = termino.AddDays(1)
            comand.Parameters.Add(New SqlParameter("@fecha_termino", termino))
            Dim adapter As New SqlDataAdapter(comand)
            adapter.Fill(tabla)
            comand.Dispose()

            For i = 0 To tabla.Rows.Count - 1
                dgvSolicitudesSalida.Rows.Add(1)
                dgvSolicitudesSalida.Rows(i).Cells("numeroSolicitud").Value = tabla.Rows(i)("id_solicitud_salida").ToString
                dgvSolicitudesSalida.Rows(i).Cells("trabajador").Value = tabla.Rows(i)("trabajador").ToString
                dgvSolicitudesSalida.Rows(i).Cells("nombreSolicitante").Value = tabla.Rows(i)("solicitante").ToString
                dgvSolicitudesSalida.Rows(i).Cells("rutTrabajador").Value = tabla.Rows(i)("rut").ToString
                dgvSolicitudesSalida.Rows(i).Cells("empresa").Value = tabla.Rows(i)("empresa").ToString
                dgvSolicitudesSalida.Rows(i).Cells("cargoAutorizarPermiso").Value = tabla.Rows(i)("cargo").ToString
                dgvSolicitudesSalida.Rows(i).Cells("fechaSalida").Value = DateTime.Parse(tabla.Rows(i)("dia").ToString).ToString("dd-MM-yyyy")
                If Not tabla.Rows(i)("dia_completo") Then
                    dgvSolicitudesSalida.Rows(i).Cells("diaCompleto").Value = "No"
                    dgvSolicitudesSalida.Rows(i).Cells("horaSalida").Value = DateTime.Parse(tabla.Rows(i)("hora_salida").ToString).ToString("HH:mm")
                    dgvSolicitudesSalida.Rows(i).Cells("horaEntrada").Value = DateTime.Parse(tabla.Rows(i)("hora_salida").ToString).AddHours(tabla.Rows(i)("total_horas")).ToString("hh:mm")
                    dgvSolicitudesSalida.Rows(i).Cells("horasTotales").Value = CalcularHorasMinutos(DateTime.Parse(tabla.Rows(i)("hora_salida").ToString), DateTime.Parse(tabla.Rows(i)("hora_salida").ToString).AddHours(tabla.Rows(i)("total_horas")))
                Else
                    dgvSolicitudesSalida.Rows(i).Cells("diaCompleto").Value = "Si"
                End If
                If tabla.Rows(i)("permiso_particular") <> 0 Then
                    dgvSolicitudesSalida.Rows(i).Cells("tipoPermiso").Value = "Particular"
                ElseIf tabla.Rows(i)("permiso_comision_servicio") <> 0 Then
                    dgvSolicitudesSalida.Rows(i).Cells("tipoPermiso").Value = "Comision Servicio"
                Else
                    dgvSolicitudesSalida.Rows(i).Cells("tipoPermiso").Value = "N/A"
                End If
                dgvSolicitudesSalida.Rows(i).Cells("fechaInforme").Value = DateTime.Parse(tabla.Rows(i)("fecha_solicitud").ToString).ToString("dd-MM-yyyy")
                If tabla.Rows(i)("rechazada") Then
                    dgvSolicitudesSalida.Rows(i).Cells("btnRechazarPermiso").Style.BackColor = Color.Red
                    dgvSolicitudesSalida.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                ElseIf tabla.Rows(i)("autorizada") Then
                    dgvSolicitudesSalida.Rows(i).Cells("btnAutorizarPermiso").Style.BackColor = Color.Green
                    dgvSolicitudesSalida.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                End If
            Next

        Catch ex As Exception
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub dtpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged
        dtpFechaInicio.Value = New DateTime(dtpFechaInicio.Value.Year, dtpFechaInicio.Value.Month, dtpFechaInicio.Value.Day, 0, 0, 0, 0)
        CargarPermisos(MDIParent1.TxtBx_UserName.Text, dtpFechaInicio.Value, dtpFechaTermino.Value)
    End Sub

    Private Sub dtpFechaTermino_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaTermino.ValueChanged
        dtpFechaTermino.Value = New DateTime(dtpFechaTermino.Value.Year, dtpFechaTermino.Value.Month, dtpFechaTermino.Value.Day, 0, 0, 0, 0)
        CargarPermisos(MDIParent1.TxtBx_UserName.Text, dtpFechaInicio.Value, dtpFechaTermino.Value)
    End Sub

    Private Sub dgvSolicitudesSalida_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSolicitudesSalida.CellClick
        If e.RowIndex >= 0 Then
            'Se ejecuta al realizar un click sobre cualquiera de los botones "eliminar" del datagridview, elimina la fila en la cual se encuentra el boton
            If e.ColumnIndex = dgvSolicitudesSalida.Columns("btnAutorizarPermiso").Index Then
                AutorizarPermiso(e.RowIndex)
                CargarPermisos(MDIParent1.TxtBx_UserName.Text, dtpFechaInicio.Value, dtpFechaTermino.Value)
            End If
            If e.ColumnIndex = dgvSolicitudesSalida.Columns("btnRechazarPermiso").Index Then
                RechazarPermiso(e.RowIndex)
                CargarPermisos(MDIParent1.TxtBx_UserName.Text, dtpFechaInicio.Value, dtpFechaTermino.Value)
            End If
            If e.ColumnIndex = dgvSolicitudesSalida.Columns("btnImprimirPermiso").Index Then
                If dgvSolicitudesSalida.Rows(e.RowIndex).Cells("btnAutorizarPermiso").Style.BackColor = Color.Green Then
                    imprimirSP(dgvSolicitudesSalida.Rows(e.RowIndex).Cells("numeroSolicitud").Value)
                Else
                    MsgBox("El permiso tiene que ser autorizado para poder imprimirlo", MsgBoxStyle.Exclamation, "Permiso no Autorizado!")
                End If
            End If
            If e.ColumnIndex = dgvSolicitudesSalida.Columns("btnVerHistorial").Index Then
                Dim historial = New Frm_HistorialPermisoPersona(dgvSolicitudesSalida.Rows(e.RowIndex).Cells("trabajador").Value.ToString)
                historial.Show()
            End If
        End If

    End Sub
    Public Sub CargarAreaAutorizador(ByVal nombre As String, ByVal inicio As DateTime, ByVal termino As DateTime)
        dgvSolicitudesSalida.Rows.Clear()
        Dim tabla As DataTable = New DataTable()
        Try
            conexion.Close()
        Catch ex As Exception
        End Try
        conexion.Open()
        termino.AddDays(2)
        Try
            Dim comand As SqlCommand = New SqlCommand("Solicitud_Buscar_Solicitudes_Permisos", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.Add(New SqlParameter("@nombreCompleto", nombre))
            comand.Parameters.Add(New SqlParameter("@fecha_inicio", inicio))
            termino = termino.AddDays(1)
            comand.Parameters.Add(New SqlParameter("@fecha_termino", termino))
            Dim adapter As New SqlDataAdapter(comand)
            adapter.Fill(tabla)
            comand.Dispose()

            For i = 0 To tabla.Rows.Count - 1
                dgvSolicitudesSalida.Rows.Add(1)
                dgvSolicitudesSalida.Rows(i).Cells("numeroSolicitud").Value = tabla.Rows(i)("id_solicitud_salida").ToString
                dgvSolicitudesSalida.Rows(i).Cells("trabajador").Value = tabla.Rows(i)("trabajador").ToString
                dgvSolicitudesSalida.Rows(i).Cells("nombreSolicitante").Value = tabla.Rows(i)("solicitante").ToString
                dgvSolicitudesSalida.Rows(i).Cells("rutTrabajador").Value = tabla.Rows(i)("rut").ToString
                dgvSolicitudesSalida.Rows(i).Cells("empresa").Value = tabla.Rows(i)("empresa").ToString
                dgvSolicitudesSalida.Rows(i).Cells("cargoAutorizarPermiso").Value = tabla.Rows(i)("cargo").ToString
                dgvSolicitudesSalida.Rows(i).Cells("fechaSalida").Value = DateTime.Parse(tabla.Rows(i)("dia").ToString).ToString("dd-MM-yyyy")
                If Not tabla.Rows(i)("dia_completo") Then
                    dgvSolicitudesSalida.Rows(i).Cells("diaCompleto").Value = "No"
                    dgvSolicitudesSalida.Rows(i).Cells("horaSalida").Value = DateTime.Parse(tabla.Rows(i)("hora_salida").ToString).ToString("HH:mm")
                    dgvSolicitudesSalida.Rows(i).Cells("horaEntrada").Value = DateTime.Parse(tabla.Rows(i)("hora_salida").ToString).AddHours(tabla.Rows(i)("total_horas")).ToString("hh:mm")
                    dgvSolicitudesSalida.Rows(i).Cells("horasTotales").Value = CalcularHorasMinutosSP(DateTime.Parse(tabla.Rows(i)("hora_salida").ToString), DateTime.Parse(tabla.Rows(i)("hora_salida").ToString).AddHours(tabla.Rows(i)("total_horas")))
                Else
                    dgvSolicitudesSalida.Rows(i).Cells("diaCompleto").Value = "Si"
                End If
                If tabla.Rows(i)("permiso_particular") <> 0 Then
                    dgvSolicitudesSalida.Rows(i).Cells("tipoPermiso").Value = "Particular"
                ElseIf tabla.Rows(i)("permiso_comision_servicio") <> 0 Then
                    dgvSolicitudesSalida.Rows(i).Cells("tipoPermiso").Value = "Comision Servicio"
                Else
                    dgvSolicitudesSalida.Rows(i).Cells("tipoPermiso").Value = "N/A"
                End If
                dgvSolicitudesSalida.Rows(i).Cells("fechaInforme").Value = DateTime.Parse(tabla.Rows(i)("fecha_solicitud").ToString).ToString("dd-MM-yyyy")
                If tabla.Rows(i)("rechazada") Then
                    dgvSolicitudesSalida.Rows(i).Cells("btnRechazarPermiso").Style.BackColor = Color.Red
                    dgvSolicitudesSalida.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                ElseIf tabla.Rows(i)("autorizada") Then
                    dgvSolicitudesSalida.Rows(i).Cells("btnAutorizarPermiso").Style.BackColor = Color.Green
                    dgvSolicitudesSalida.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                End If
            Next

        Catch ex As Exception
        Finally
            conexion.Close()
        End Try
    End Sub
    '---------------------------------------------------------------------------------------------
    Private Function CalcularHorasMinutosSP(ByVal salida As DateTime, ByVal entrada As DateTime) As String
        'Este metodo calcula la cantidad de minutos y horas que ocupara el trabajador durante su salida
        Dim diferencia As TimeSpan = (entrada.TimeOfDay - salida.TimeOfDay)
        Dim horas As String = diferencia.Hours
        Dim minutos As String
        If diferencia.Minutes < 10 Then
            minutos = "0" + diferencia.Minutes.ToString
        Else
            minutos = diferencia.Minutes
        End If
        Return horas.ToString + ":" + minutos.ToString
    End Function
    Private Sub imprimirSP(ByVal id_solicitud As String)
        Dim informe As New InformePermiso()
        informe.SetDatabaseLogon("sa", "Sqladmin281")
        informe.SetParameterValue("@id", id_solicitud)
        Dim formInforme As New Frm_ImprimirReporte(informe)
        formInforme.Show()
    End Sub
    ' ------------------------ Fin Autoriza Permisos ----------------------------------










    '------------------------- Informe Horas Extras -----------------------------------
    Private Sub autocompletarNombreRutInformeHHEE(empresa As String)
        Dim listaNombre As New AutoCompleteStringCollection()
        Dim listaRut As New AutoCompleteStringCollection()
        Try
            Dim personas As List(Of Persona) = Persona.ListarPorEmpresa(empresa)

            For Each persona__1 As Persona In personas
                listaNombre.Add(persona__1.Nombre)
                listaRut.Add(persona__1.Rut)
            Next
            txbNombreInformeHHEE.AutoCompleteCustomSource = listaNombre

            txbRutInformeHHEE.AutoCompleteCustomSource = listaRut
        Catch ex As Exception
            MessageBox.Show("error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub cmbEmpresaInformeHHEE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresaInformeHHEE.SelectedIndexChanged
        autocompletarNombreRutInformeHHEE(cmbEmpresaInformeHHEE.Text)
        LimpiarDatosInformeHHEE()
    End Sub

    Public Sub LimpiarDatosInformeHHEE()
        txbNombreInformeHHEE.Text = ""
        dgvColaboradoresInformeHHEE.Rows.Clear()
        txbHHEEAcumuladasInformeHHEE.Text = ""
        enableBuscarHHEE = False
    End Sub

    Private Sub txbNombreInformeHHEE_TextChanged(sender As Object, e As EventArgs) Handles txbNombreInformeHHEE.TextChanged
        If enableBuscarRutHHEE Then
            enableBuscarNombreHHEE = False
            trabajadorHHEE.Nombre = txbNombreInformeHHEE.Text
            trabajadorHHEE.BuscarRutPorNombre()
            txbRutInformeHHEE.Text = trabajadorHHEE.Rut
            dgvColaboradoresInformeHHEE.Rows.Clear()
            txbHHEEAcumuladasInformeHHEE.Text = ""
            enableBuscarHHEE = False
            enableBuscarNombreHHEE = True
        End If
    End Sub

    Private Sub txbRutInformeHHEE_TextChanged(sender As Object, e As EventArgs) Handles txbRutInformeHHEE.TextChanged
        If enableBuscarNombreHHEE Then
            enableBuscarRutHHEE = False
            trabajadorHHEE.Rut = txbRutInformeHHEE.Text
            trabajadorHHEE.BuscarNombrePorRut()
            txbNombreInformeHHEE.Text = trabajadorHHEE.Nombre
            dgvColaboradoresInformeHHEE.Rows.Clear()
            txbHHEEAcumuladasInformeHHEE.Text = ""
            enableBuscarHHEE = False
            enableBuscarRutHHEE = True
        End If
    End Sub

    Private Sub btnBuscarInformeHHEE_Click(sender As Object, e As EventArgs) Handles btnBuscarInformeHHEE.Click
        enableBuscarHHEE = True
        CargarDGVInformeHHEE()
    End Sub


    Public Sub CargarDGVInformeHHEE()
        If enableBuscarHHEE Then
            dgvColaboradoresInformeHHEE.Rows.Clear()
            Dim inicio As New DateTime(dtpInicioInformeHHEE.Value.Year, dtpInicioInformeHHEE.Value.Month, dtpInicioInformeHHEE.Value.Day, 0, 0, 0)
            Dim termino As New DateTime(dtpTerminoInformeHHEE.Value.Year, dtpTerminoInformeHHEE.Value.Month, dtpTerminoInformeHHEE.Value.Day, 0, 0, 0)
            Dim horasExras As List(Of HoraExtraColaboradores)

            If Not chkBuscarTodosInformeHHEE.Checked Then
                horasExras = HoraExtraColaboradores.ListarIntevalo(trabajadorHHEE.Rut, Nothing, inicio, termino)
            Else
                If Not chkTodaEmpresaInformeHHEE.Checked Then
                    horasExras = HoraExtraColaboradores.ListarIntevalo(Nothing, cmbEmpresaInformeHHEE.Text, inicio, termino)
                Else
                    horasExras = HoraExtraColaboradores.ListarIntevalo(Nothing, Nothing, inicio, termino)
                End If
            End If

            Dim i As Integer = 0
            Dim rut As String = ""
            Dim hheeAcumuladas As [Double] = 0
            Dim totalEmpleados As Int16 = 0
            For Each horaExtra As HoraExtraColaboradores In horasExras
                dgvColaboradoresInformeHHEE.Rows.Add(1)
                If rut <> horaExtra.Rut Then
                    totalEmpleados += 1
                End If
                rut = horaExtra.Rut
                dgvColaboradoresInformeHHEE.Rows(i).Cells("colNumeroInformeHHEE").Value = horaExtra.IdSolicitudHHEE.ToString()
                dgvColaboradoresInformeHHEE.Rows(i).Cells("colNombreColaboradoresInformeHHEE").Value = horaExtra.NombreCompleto
                dgvColaboradoresInformeHHEE.Rows(i).Cells("colRutInformeHHEE").Value = horaExtra.Rut
                dgvColaboradoresInformeHHEE.Rows(i).Cells("colCargoInformeHHEE").Value = horaExtra.Cargo
                dgvColaboradoresInformeHHEE.Rows(i).Cells("colFechaRealInformeHHEE").Value = horaExtra.FechaReal.ToString("dd-MM-yyyy")
                dgvColaboradoresInformeHHEE.Rows(i).Cells("colDepartamentoInformeHHEE").Value = horaExtra.Area

                dgvColaboradoresInformeHHEE.Rows(i).Cells("colHoraInicioInformeHHEE").Value = horaExtra.HorasCompromisoInicial.ToString("hh\:mm")
                dgvColaboradoresInformeHHEE.Rows(i).Cells("colHoraTerminoInformeHHEE").Value = Convert.ToDateTime(horaExtra.HorasCompromisoInicial.ToString()).AddHours(horaExtra.TotalHorasCompromiso).ToString("HH:mm")
                dgvColaboradoresInformeHHEE.Rows(i).Cells("colTotalHorasExtrasInformeHHEE").Value = New DateTime(2000, 1, 1, 0, 0, 0).AddHours(horaExtra.TotalHorasCompromiso).ToString("HH:mm")
                '
                '                    dgvColaboradores.Rows[i].Cells["colDiaCompleto"].Value = p.DiaCompleto ? "SI" : "NO";
                '                    if (!permiso.DiaCompleto)
                '                    {
                '                        dgvColaboradores.Rows[i].Cells["colHoraSalida"].Value = permiso.HoraSalida.ToString(@"hh\:mm");
                '                        dgvColaboradores.Rows[i].Cells["colHoraEntrada"].Value = Convert.ToDateTime(permiso.HoraSalida.ToString()).AddHours(permiso.TotalHoras).ToString("HH:mm");
                '                        dgvColaboradores.Rows[i].Cells["colHorasTotales"].Value = new DateTime(2000, 1, 1, 0, 0, 0).AddHours(permiso.TotalHoras).ToString("HH:mm");
                '                    }
                '                    dgvColaboradores.Rows[i].Cells["colTipoPermiso"].Value = permiso.ComisonServicio ? "COMISION SERVICIO" : "PARTICULAR";
                '                    

                hheeAcumuladas += horaExtra.TotalHorasCompromiso
                i += 1
            Next
            txbTotalEmpleadosInformeHHEE.Text = totalEmpleados.ToString
            'txbHHEEAcumuladas.Text = hheeAcumuladas.ToString();
            txbHHEEAcumuladasInformeHHEE.Text = Math.Truncate(hheeAcumuladas) & ":" & (Math.Truncate(60 * (hheeAcumuladas - Math.Truncate(hheeAcumuladas))))
        End If
    End Sub

    Private Sub dtpInicioInformeHHEE_ValueChanged(sender As Object, e As EventArgs) Handles dtpInicioInformeHHEE.ValueChanged
        CargarDGVInformeHHEE()
    End Sub

    Private Sub dtpTerminoInformeHHEE_ValueChanged(sender As Object, e As EventArgs) Handles dtpTerminoInformeHHEE.ValueChanged
        CargarDGVInformeHHEE()
    End Sub

    Private Sub chkBuscarTodosInformeHHEE_CheckedChanged(sender As Object, e As EventArgs) Handles chkBuscarTodosInformeHHEE.CheckedChanged
        If chkBuscarTodosInformeHHEE.Checked Then
            If chkTodaEmpresaInformeHHEE.Checked Then
                lblEmpresaInformeHHEE.Visible = False
                cmbEmpresaInformeHHEE.Visible = False
            End If
            lblNombreInformeHHEE.Visible = False
            lblRutInformeHHEE.Visible = False
            txbNombreInformeHHEE.Visible = False
            txbRutInformeHHEE.Visible = False
            chkTodaEmpresaInformeHHEE.Visible = True
            LimpiarDatosInformeHHEE()
        Else
            lblEmpresaInformeHHEE.Visible = True
            cmbEmpresaInformeHHEE.Visible = True
            lblNombreInformeHHEE.Visible = True
            lblRutInformeHHEE.Visible = True
            txbNombreInformeHHEE.Visible = True
            txbRutInformeHHEE.Visible = True
            chkTodaEmpresaInformeHHEE.Visible = False
            LimpiarDatosInformeHHEE()
        End If
    End Sub

    Private Sub btnImprimirInformeHHEE_Click(sender As Object, e As EventArgs) Handles btnImprimirInformeHHEE.Click
        If chkBuscarTodosInformeHHEE.Checked Then
            If chkTodaEmpresaInformeHHEE.Checked Then
                Dim informe As New InformeHorasExtrasFechas()
                informe.SetParameterValue("@fecha_inicio", dtpInicioInformeHHEE.Value)
                informe.SetParameterValue("@fecha_termino", dtpTerminoInformeHHEE.Value)
                Dim formInforme As New Frm_ImprimirReporte(informe)
                formInforme.Show()
            Else
                Dim informe As New InformeHorasExtrasFechasEmpresa()
                informe.SetParameterValue("@empresa", cmbEmpresaInformeHHEE.Text)
                informe.SetParameterValue("@fecha_inicio", dtpInicioInformeHHEE.Value)
                informe.SetParameterValue("@fecha_termino", dtpTerminoInformeHHEE.Value)
                Dim formInforme As New Frm_ImprimirReporte(informe)

                formInforme.Show()
            End If
        Else
            Dim informe As New InformeHorasExtrasPersonaFechas()
            informe.SetParameterValue("@rut", txbRutInformeHHEE.Text)
            informe.SetParameterValue("@fecha_inicio", dtpInicioInformeHHEE.Value)
            informe.SetParameterValue("@fecha_termino", dtpTerminoInformeHHEE.Value)
            Dim formInforme As New Frm_ImprimirReporte(informe)
            formInforme.Show()
        End If
    End Sub

    Private Sub chkTodaEmpresaInformeHHEE_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodaEmpresaInformeHHEE.CheckedChanged
        If Not chkTodaEmpresaInformeHHEE.Checked Then
            lblEmpresaInformeHHEE.Visible = True
            cmbEmpresaInformeHHEE.Visible = True
        Else
            lblEmpresaInformeHHEE.Visible = False
            cmbEmpresaInformeHHEE.Visible = False
        End If
    End Sub
    '------------------------- Fin Informe Horas Extras -------------------------------















    '------------------------- Informe Permisos ---------------------------------------
    Private Sub autocompletarNombreRutInformePermisos(empresa As String)
        Dim listaNombre As New AutoCompleteStringCollection()
        Dim listaRut As New AutoCompleteStringCollection()
        Try
            Dim personas As List(Of Persona) = Persona.ListarPorEmpresa(empresa)

            For Each persona__1 As Persona In personas
                listaNombre.Add(persona__1.Nombre)
                listaRut.Add(persona__1.Rut)
            Next
            txbNombreInformePermisos.AutoCompleteCustomSource = listaNombre

            txbRutInformePermisos.AutoCompleteCustomSource = listaRut
        Catch ex As Exception
            MessageBox.Show("error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub cmbEmpresaInformePermisos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresaInformePermisos.SelectedIndexChanged
        autocompletarNombreRutInformePermisos(cmbEmpresaInformePermisos.Text)
        LimpiarDatosInformePermisos()
    End Sub

    Public Sub LimpiarDatosInformePermisos()
        txbNombreInformePermisos.Text = ""
        dgvSolicitudesSalidaInformePermisos.Rows.Clear()
        enableBuscarInformePermisos = False
    End Sub

    Private Sub txbNombreInformePermisos_TextChanged(sender As Object, e As EventArgs) Handles txbNombreInformePermisos.TextChanged
        If enableBuscarRutInformePermisos Then
            enableBuscarNombreInformePermisos = False
            trabajadorInformePermisos.Nombre = txbNombreInformePermisos.Text
            trabajadorInformePermisos.BuscarRutPorNombre()
            txbRutInformePermisos.Text = trabajadorInformePermisos.Rut
            dgvSolicitudesSalidaInformePermisos.Rows.Clear()
            enableBuscarInformePermisos = False
            enableBuscarNombreInformePermisos = True
        End If
    End Sub

    Private Sub txbRutInformePermisos_TextChanged(sender As Object, e As EventArgs) Handles txbRutInformePermisos.TextChanged
        If enableBuscarNombreInformePermisos Then
            enableBuscarRutInformePermisos = False
            trabajadorInformePermisos.Rut = txbRutInformePermisos.Text
            trabajadorInformePermisos.BuscarNombrePorRut()
            txbNombreInformePermisos.Text = trabajadorInformePermisos.Nombre
            dgvSolicitudesSalidaInformePermisos.Rows.Clear()
            enableBuscarInformePermisos = False
            enableBuscarRutInformePermisos = True
        End If
    End Sub

    Private Sub btnBuscarInformePermisos_Click(sender As Object, e As EventArgs) Handles btnBuscarInformePermisos.Click
        enableBuscarInformePermisos = True
        CargarDGVInformePermisos()
    End Sub


    Public Sub CargarDGVInformePermisos()
        If enableBuscarInformePermisos Then
            dgvSolicitudesSalidaInformePermisos.Rows.Clear()
            Dim inicio As New DateTime(dtpInicioInformePermisos.Value.Year, dtpInicioInformePermisos.Value.Month, dtpInicioInformePermisos.Value.Day, 0, 0, 0)
            Dim termino As New DateTime(dtpTerminoInformePermisos.Value.Year, dtpTerminoInformePermisos.Value.Month, dtpTerminoInformePermisos.Value.Day, 0, 0, 0)
            Dim permisos As List(Of Permiso)
            If Not chkBuscarTodosInformePermisos.Checked Then
                permisos = Permiso.ListarIntevalo(trabajadorInformePermisos.Rut, Nothing, inicio, termino)
            Else
                permisos = Permiso.ListarIntevalo(Nothing, cmbEmpresaInformePermisos.Text, inicio, termino)
            End If
            Dim i As Integer = 0
            For Each permiso__1 As Permiso In permisos
                dgvSolicitudesSalidaInformePermisos.Rows.Add(1)
                dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colNumeroSolicitudInformePermisos").Value = permiso__1.Id.ToString()
                dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colTrabajadorInformePermisos").Value = permiso__1.Trabajador
                dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colDepartamentoInformePermisos").Value = permiso__1.Departamento
                dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colCargoInformePermisos").Value = permiso__1.Cargo
                dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colFechaSalidaInformePermisos").Value = permiso__1.FechaPermiso.ToString("dd-MM-yyyy")
                dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colDiaCompletoInformePermisos").Value = If(permiso__1.DiaCompleto, "SI", "NO")
                If Not permiso__1.DiaCompleto Then
                    dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colHoraSalidaInformePermisos").Value = permiso__1.HoraSalida.ToString("hh\:mm")
                    dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colHoraEntradaInformePermisos").Value = Convert.ToDateTime(permiso__1.HoraSalida.ToString()).AddHours(permiso__1.TotalHoras).ToString("HH:mm")
                    dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colHorasTotalesInformePermisos").Value = New DateTime(2000, 1, 1, 0, 0, 0).AddHours(permiso__1.TotalHoras).ToString("HH:mm")
                End If
                dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colTipoPermisoInformePermisos").Value = If(permiso__1.ComisonServicio, "COMISION SERVICIO", "PARTICULAR")
                i += 1
            Next
        End If
    End Sub

    Private Sub dtpInicioInformePermisos_ValueChanged(sender As Object, e As EventArgs) Handles dtpInicioInformePermisos.ValueChanged
        CargarDGVInformePermisos()
    End Sub

    Private Sub dtpTerminoInformePermisos_ValueChanged(sender As Object, e As EventArgs) Handles dtpTerminoInformePermisos.ValueChanged
        CargarDGVInformePermisos()
    End Sub

    Private Sub btnImprimirInformePermisos_Click(sender As Object, e As EventArgs) Handles btnImprimirInformePermisos.Click
        If chkBuscarTodosInformePermisos.Checked Then
            Dim informe As New InformePermisos()
            informe.SetParameterValue("@empresa", cmbEmpresaInformePermisos.Text)
            informe.SetParameterValue("@fecha_inicio", dtpInicioInformePermisos.Value)
            informe.SetParameterValue("@fecha_termino", dtpTerminoInformePermisos.Value.AddDays(1))
            Dim formInforme As New Frm_ImprimirReporte(informe)
            formInforme.Show()
        Else
            Dim informe As New InformePermisoPersona()
            informe.SetParameterValue("@rut", txbRutInformePermisos.Text)
            informe.SetParameterValue("@fecha_inicio", dtpInicioInformePermisos.Value)
            informe.SetParameterValue("@fecha_termino", dtpTerminoInformePermisos.Value.AddDays(1))
            Dim formInforme As New Frm_ImprimirReporte(informe)
            formInforme.Show()
        End If
    End Sub

    Private Sub chkBuscarTodosInformePermisos_CheckedChanged(sender As Object, e As EventArgs) Handles chkBuscarTodosInformePermisos.CheckedChanged
        If chkBuscarTodosInformePermisos.Checked Then
            lblNombreInformePermisos.Visible = False
            lblRutInformePermisos.Visible = False
            txbNombreInformePermisos.Visible = False
            txbRutInformePermisos.Visible = False
            LimpiarDatosInformePermisos()
        Else
            lblNombreInformePermisos.Visible = True
            lblRutInformePermisos.Visible = True
            txbNombreInformePermisos.Visible = True
            txbRutInformePermisos.Visible = True
            LimpiarDatosInformePermisos()
        End If
    End Sub
    '------------------------- Fin Informe Permisos -----------------------------------


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        MDIParent1.Panel2.Visible = True
        MDIParent1.TiempoIngreso.Enabled = True
        MDIParent1.Visualizar_Tiles_MDI()
        Me.Close()
    End Sub




    Private Sub btnSolicitarHHEE_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        If ValidarFormulario() Then
            Dim transaction As SqlTransaction
            Using con As New SqlConnection(My.Settings.SBO_COMERCIALConnectionString)
                Try
                    con.Open()
                    transaction = con.BeginTransaction()
                    Dim sqlText = "INSERT INTO Solicitud_HorasExtras(supervisor_solicitante,rut_solicitante,fecha,cantidad_horas_extras,area,detalle)" +
                                                            " VALUES(@supervisor_solicitante,@rut_solicitante,@fecha,@cantidad_horas_extras,@area,@detalle)"
                    cmd = New SqlCommand(sqlText, con, transaction)
                    cmd.Parameters.Add("@supervisor_solicitante", SqlDbType.VarChar).Value = txbSupervisorSolicitante.Text
                    cmd.Parameters.Add("@rut_solicitante", SqlDbType.VarChar).Value = BuscarDatosTrabajador(MDIParent1.TxtBx_UserName.Text).Rows(0)("rut")
                    cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Now
                    cmd.Parameters.Add("@cantidad_horas_extras", SqlDbType.Int).Value = txbHorasExtras.Text
                    cmd.Parameters.Add("@area", SqlDbType.VarChar).Value = ComboBox3.Text
                    cmd.Parameters.Add("@detalle", SqlDbType.VarChar).Value = TxtBxDetalleSHX.Text

                    cmd.ExecuteNonQuery()
                    '-----Esta parte va a buscar el numero identificador de la solicitud de hora extra recien insertada, es importante para especificar el valor de la clave foranea que ocupan los colaboradores
                    cmd = New SqlCommand()
                    cmd.Connection = con
                    cmd.Transaction = transaction
                    cmd.CommandText = "SELECT MAX(id_solicitud_horas_extra) as 'id_solicitud_horas_extra' FROM Solicitud_HorasExtras WHERE supervisor_solicitante=@supervisor_solicitante"
                    cmd.Parameters.Add("@supervisor_solicitante", SqlDbType.VarChar).Value = txbSupervisorSolicitante.Text
                    Dim adapter As New SqlDataAdapter(cmd)
                    dt = New DataTable()
                    adapter.Fill(dt)
                    For i = 0 To dgvColaboradoresSHHEE.RowCount - 2
                        sqlText = "INSERT INTO Solicitud_HorasExtras_Colaboradores(empresa,cargo,rut, nombre_completo, horas_compromiso_inicio, total_horas_compromiso, fecha_real, id_solicitud_horas_extra) VALUES(@empresa,@cargo,@rut, UPPER (@nombre_completo), @horas_compromiso_inicio, @total_horas_compromiso, @fecha_real, @id_solicitud_horas_extra)"
                        cmd = New SqlCommand(sqlText, con, transaction)
                        cmd.Parameters.Add("@rut", SqlDbType.VarChar).Value = dgvColaboradoresSHHEE.Rows(i).Cells("rutSolicitarHHEE").Value
                        cmd.Parameters.Add("@nombre_completo", SqlDbType.VarChar).Value = dgvColaboradoresSHHEE.Rows(i).Cells("nombreColaborador").Value
                        cmd.Parameters.Add("@horas_compromiso_inicio", SqlDbType.Time).Value = Convert.ToDateTime(dgvColaboradoresSHHEE.Rows(i).Cells("horaInicioSolicitarHHEE").Value).TimeOfDay
                        cmd.Parameters.Add("@total_horas_compromiso", SqlDbType.Float).Value = (Convert.ToDateTime(dgvColaboradoresSHHEE.Rows(i).Cells("horaTerminoSolicitarHHEE").Value) - Convert.ToDateTime(dgvColaboradoresSHHEE.Rows(i).Cells("horaInicioSolicitarHHEE").Value)).TotalHours
                        Dim fecha As DateTime = Convert.ToDateTime(dgvColaboradoresSHHEE.Rows(i).Cells("fechaRealSolicitarHHEE").Value)
                        cmd.Parameters.Add("@fecha_real", SqlDbType.Date).Value = New DateTime(fecha.Year, fecha.Month, fecha.Day, 0, 0, 0, 0)
                        cmd.Parameters.Add("@cargo", SqlDbType.VarChar).Value = dgvColaboradoresSHHEE.Rows(i).Cells("cargoSolicitarHHEE").Value
                        cmd.Parameters.Add("@empresa", SqlDbType.VarChar).Value = dgvColaboradoresSHHEE.Rows(i).Cells("nombreEmpresaSolicitarHHEE").Value
                        cmd.Parameters.Add("@id_solicitud_horas_extra", SqlDbType.Int).Value = dt.Rows(0)("id_solicitud_horas_extra")
                        cmd.ExecuteNonQuery()
                    Next
                    Dim mandado As Boolean = MandarInformeSolicitud(BuscarCorreoResponsable(ComboBox2.Text))
                    If mandado Then
                        MsgBox("Solicitud de hora extra enviada", MsgBoxStyle.Information, "Solicitud de hora extra")
                    Else
                        MsgBox("La solicitud fue guardada pero pudo ser enviada", MsgBoxStyle.Information, "Solicitud de hora extra")
                    End If
                    transaction.Commit()
                Catch ex As Exception
                    MsgBox("Error al operar con la base de datos: " + ex.Message, MsgBoxStyle.Critical, "Error!")
                    Try
                        transaction.Rollback()
                    Catch
                    End Try
                    con.Close()
                End Try
            End Using
        End If
    End Sub

    Private Sub BtnVolver2_Click(sender As Object, e As EventArgs) Handles BtnVolver2.Click
        MDIParent1.Panel2.Visible = True
        MDIParent1.TiempoIngreso.Enabled = True
        MDIParent1.Visualizar_Tiles_MDI()
        Me.Close()
    End Sub

End Class
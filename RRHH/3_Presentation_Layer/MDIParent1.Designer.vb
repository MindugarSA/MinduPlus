<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIParent1
    Inherits MetroFramework.Forms.MetroForm 'System.Windows.Forms.Form

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
        Dim PictureBox1 As System.Windows.Forms.PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.TlStrpSttsLbl_Proceso = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TlStrpSttsLbl_SQL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tle_Configuracion = New MetroFramework.Controls.MetroTile()
        Me.Tle_InformesAlmu = New MetroFramework.Controls.MetroTile()
        Me.Tle_MantencionColacione = New MetroFramework.Controls.MetroTile()
        Me.Tle_AlmuAdicional = New MetroFramework.Controls.MetroTile()
        Me.Tle_Permisos = New MetroFramework.Controls.MetroTile()
        Me.Tle_Liquidacion = New MetroFramework.Controls.MetroTile()
        Me.Tle_SolAlmuerzo = New MetroFramework.Controls.MetroTile()
        Me.Tle_Exportador = New MetroFramework.Controls.MetroTile()
        Me.Tle_Solicitar_Permisos = New MetroFramework.Controls.MetroTile()
        Me.TleSolicitar_HHEE = New MetroFramework.Controls.MetroTile()
        Me.Tle_Asistencias_Periodo = New MetroFramework.Controls.MetroTile()
        Me.Tle_Herramientas_Pre = New MetroFramework.Controls.MetroTile()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.Lbl_Cod_Interno = New System.Windows.Forms.Label()
        Me.Lbl_RutEmpresa = New System.Windows.Forms.Label()
        Me.Lbl_RutTrab = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PcturBx_Image = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_Cod_ID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBx_Empresa = New System.Windows.Forms.TextBox()
        Me.TxtBx_UserName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlMovingRight2 = New System.Windows.Forms.Panel()
        Me.pnlMovingRight = New System.Windows.Forms.Panel()
        Me.pnlMovingTop = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TiempoIngreso = New System.Windows.Forms.Timer(Me.components)
        Me.TmrDesplaza = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PcturBx_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlMovingRight2.SuspendLayout()
        Me.pnlMovingRight.SuspendLayout()
        Me.pnlMovingTop.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        PictureBox1.Location = New System.Drawing.Point(3, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(215, 55)
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.White
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlStrpSttsLbl_Proceso, Me.TlStrpSttsLbl_SQL, Me.ToolStripStatusLabel, Me.ToolStripProgressBar1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 880)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1129, 26)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'TlStrpSttsLbl_Proceso
        '
        Me.TlStrpSttsLbl_Proceso.BorderSides = CType(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.TlStrpSttsLbl_Proceso.Name = "TlStrpSttsLbl_Proceso"
        Me.TlStrpSttsLbl_Proceso.Size = New System.Drawing.Size(62, 21)
        Me.TlStrpSttsLbl_Proceso.Text = "Proceso : "
        '
        'TlStrpSttsLbl_SQL
        '
        Me.TlStrpSttsLbl_SQL.BackColor = System.Drawing.Color.AliceBlue
        Me.TlStrpSttsLbl_SQL.BorderSides = CType(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.TlStrpSttsLbl_SQL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlStrpSttsLbl_SQL.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TlStrpSttsLbl_SQL.Name = "TlStrpSttsLbl_SQL"
        Me.TlStrpSttsLbl_SQL.Size = New System.Drawing.Size(832, 21)
        Me.TlStrpSttsLbl_SQL.Spring = True
        Me.TlStrpSttsLbl_SQL.Text = "ToolStripStatusLabel1"
        Me.TlStrpSttsLbl_SQL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(118, 21)
        Me.ToolStripStatusLabel.Text = "Tiempo Desconexión"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripProgressBar1.CausesValidation = False
        Me.ToolStripProgressBar1.MarqueeAnimationSpeed = 1
        Me.ToolStripProgressBar1.Maximum = 240
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 20)
        Me.ToolStripProgressBar1.Value = 30
        '
        'Tle_Configuracion
        '
        Me.Tle_Configuracion.ActiveControl = Nothing
        Me.Tle_Configuracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tle_Configuracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Tle_Configuracion.Location = New System.Drawing.Point(9, 578)
        Me.Tle_Configuracion.Name = "Tle_Configuracion"
        Me.Tle_Configuracion.Size = New System.Drawing.Size(247, 107)
        Me.Tle_Configuracion.TabIndex = 16
        Me.Tle_Configuracion.Text = "Configuraciones"
        Me.Tle_Configuracion.TileImage = Global.RRHH.My.Resources.Resources.settings
        Me.ToolTip.SetToolTip(Me.Tle_Configuracion, "Ingreso de Menu")
        Me.Tle_Configuracion.UseCustomBackColor = True
        Me.Tle_Configuracion.UseSelectable = True
        Me.Tle_Configuracion.UseTileImage = True
        '
        'Tle_InformesAlmu
        '
        Me.Tle_InformesAlmu.ActiveControl = Nothing
        Me.Tle_InformesAlmu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tle_InformesAlmu.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Tle_InformesAlmu.Location = New System.Drawing.Point(137, 465)
        Me.Tle_InformesAlmu.Name = "Tle_InformesAlmu"
        Me.Tle_InformesAlmu.Size = New System.Drawing.Size(119, 107)
        Me.Tle_InformesAlmu.TabIndex = 15
        Me.Tle_InformesAlmu.Text = "Informes Almuerzos"
        Me.Tle_InformesAlmu.TileImage = Global.RRHH.My.Resources.Resources.list_document_interface_symbol
        Me.ToolTip.SetToolTip(Me.Tle_InformesAlmu, "Ingreso de Menu")
        Me.Tle_InformesAlmu.UseCustomBackColor = True
        Me.Tle_InformesAlmu.UseSelectable = True
        Me.Tle_InformesAlmu.UseTileImage = True
        '
        'Tle_MantencionColacione
        '
        Me.Tle_MantencionColacione.ActiveControl = Nothing
        Me.Tle_MantencionColacione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tle_MantencionColacione.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Tle_MantencionColacione.Location = New System.Drawing.Point(137, 239)
        Me.Tle_MantencionColacione.Name = "Tle_MantencionColacione"
        Me.Tle_MantencionColacione.Size = New System.Drawing.Size(119, 107)
        Me.Tle_MantencionColacione.TabIndex = 14
        Me.Tle_MantencionColacione.Text = "Ingreso Menu"
        Me.Tle_MantencionColacione.TileImage = Global.RRHH.My.Resources.Resources.menu1
        Me.ToolTip.SetToolTip(Me.Tle_MantencionColacione, "Ingreso de Menu")
        Me.Tle_MantencionColacione.UseCustomBackColor = True
        Me.Tle_MantencionColacione.UseSelectable = True
        Me.Tle_MantencionColacione.UseTileImage = True
        '
        'Tle_AlmuAdicional
        '
        Me.Tle_AlmuAdicional.ActiveControl = Nothing
        Me.Tle_AlmuAdicional.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tle_AlmuAdicional.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Tle_AlmuAdicional.Location = New System.Drawing.Point(137, 352)
        Me.Tle_AlmuAdicional.Name = "Tle_AlmuAdicional"
        Me.Tle_AlmuAdicional.Size = New System.Drawing.Size(119, 107)
        Me.Tle_AlmuAdicional.TabIndex = 13
        Me.Tle_AlmuAdicional.Text = "Adicionales"
        Me.Tle_AlmuAdicional.TileImage = Global.RRHH.My.Resources.Resources.restaurant
        Me.ToolTip.SetToolTip(Me.Tle_AlmuAdicional, "Solicitar Almuerzos Adicionales")
        Me.Tle_AlmuAdicional.UseCustomBackColor = True
        Me.Tle_AlmuAdicional.UseSelectable = True
        Me.Tle_AlmuAdicional.UseTileImage = True
        '
        'Tle_Permisos
        '
        Me.Tle_Permisos.ActiveControl = Nothing
        Me.Tle_Permisos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tle_Permisos.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Tle_Permisos.Location = New System.Drawing.Point(9, 352)
        Me.Tle_Permisos.Name = "Tle_Permisos"
        Me.Tle_Permisos.Size = New System.Drawing.Size(118, 220)
        Me.Tle_Permisos.TabIndex = 12
        Me.Tle_Permisos.Text = "Informes y " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Autorizaciones"
        Me.Tle_Permisos.TileImage = Global.RRHH.My.Resources.Resources.people_check
        Me.ToolTip.SetToolTip(Me.Tle_Permisos, "Informes y" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Autorizaciones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Horas Extras - Permisos")
        Me.Tle_Permisos.UseCustomBackColor = True
        Me.Tle_Permisos.UseSelectable = True
        Me.Tle_Permisos.UseTileImage = True
        '
        'Tle_Liquidacion
        '
        Me.Tle_Liquidacion.ActiveControl = Nothing
        Me.Tle_Liquidacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tle_Liquidacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Tle_Liquidacion.Location = New System.Drawing.Point(130, 6)
        Me.Tle_Liquidacion.Name = "Tle_Liquidacion"
        Me.Tle_Liquidacion.Size = New System.Drawing.Size(114, 107)
        Me.Tle_Liquidacion.TabIndex = 11
        Me.Tle_Liquidacion.Text = "Liquidacion "
        Me.Tle_Liquidacion.TileImage = Global.RRHH.My.Resources.Resources.money_report
        Me.ToolTip.SetToolTip(Me.Tle_Liquidacion, "Ver o imprimir " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Liquidaciones de Sueldos")
        Me.Tle_Liquidacion.UseCustomBackColor = True
        Me.Tle_Liquidacion.UseSelectable = True
        Me.Tle_Liquidacion.UseTileImage = True
        '
        'Tle_SolAlmuerzo
        '
        Me.Tle_SolAlmuerzo.ActiveControl = Nothing
        Me.Tle_SolAlmuerzo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tle_SolAlmuerzo.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Tle_SolAlmuerzo.Location = New System.Drawing.Point(5, 6)
        Me.Tle_SolAlmuerzo.Name = "Tle_SolAlmuerzo"
        Me.Tle_SolAlmuerzo.Size = New System.Drawing.Size(119, 107)
        Me.Tle_SolAlmuerzo.TabIndex = 10
        Me.Tle_SolAlmuerzo.Text = "Almuerzos"
        Me.Tle_SolAlmuerzo.TileImage = Global.RRHH.My.Resources.Resources.cutlery
        Me.ToolTip.SetToolTip(Me.Tle_SolAlmuerzo, "Solicitar Almuerzos")
        Me.Tle_SolAlmuerzo.UseCustomBackColor = True
        Me.Tle_SolAlmuerzo.UseSelectable = True
        Me.Tle_SolAlmuerzo.UseTileImage = True
        '
        'Tle_Exportador
        '
        Me.Tle_Exportador.ActiveControl = Nothing
        Me.Tle_Exportador.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tle_Exportador.BackColor = System.Drawing.Color.Orange
        Me.Tle_Exportador.Location = New System.Drawing.Point(9, 238)
        Me.Tle_Exportador.Name = "Tle_Exportador"
        Me.Tle_Exportador.Size = New System.Drawing.Size(119, 107)
        Me.Tle_Exportador.TabIndex = 9
        Me.Tle_Exportador.Text = "Exportador"
        Me.Tle_Exportador.TileImage = Global.RRHH.My.Resources.Resources.clockwise_rotation__1_
        Me.ToolTip.SetToolTip(Me.Tle_Exportador, "Traspaso de Temponet a GestPer")
        Me.Tle_Exportador.UseCustomBackColor = True
        Me.Tle_Exportador.UseSelectable = True
        Me.Tle_Exportador.UseTileImage = True
        '
        'Tle_Solicitar_Permisos
        '
        Me.Tle_Solicitar_Permisos.ActiveControl = Nothing
        Me.Tle_Solicitar_Permisos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tle_Solicitar_Permisos.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Tle_Solicitar_Permisos.Location = New System.Drawing.Point(499, 6)
        Me.Tle_Solicitar_Permisos.Name = "Tle_Solicitar_Permisos"
        Me.Tle_Solicitar_Permisos.Size = New System.Drawing.Size(119, 107)
        Me.Tle_Solicitar_Permisos.TabIndex = 17
        Me.Tle_Solicitar_Permisos.Text = "Permisos"
        Me.Tle_Solicitar_Permisos.TileImage = Global.RRHH.My.Resources.Resources.Exit_white_64
        Me.ToolTip.SetToolTip(Me.Tle_Solicitar_Permisos, "Solicitar Permiso")
        Me.Tle_Solicitar_Permisos.UseCustomBackColor = True
        Me.Tle_Solicitar_Permisos.UseSelectable = True
        Me.Tle_Solicitar_Permisos.UseTileImage = True
        '
        'TleSolicitar_HHEE
        '
        Me.TleSolicitar_HHEE.ActiveControl = Nothing
        Me.TleSolicitar_HHEE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TleSolicitar_HHEE.BackColor = System.Drawing.Color.Orange
        Me.TleSolicitar_HHEE.Location = New System.Drawing.Point(374, 6)
        Me.TleSolicitar_HHEE.Name = "TleSolicitar_HHEE"
        Me.TleSolicitar_HHEE.Size = New System.Drawing.Size(119, 107)
        Me.TleSolicitar_HHEE.TabIndex = 18
        Me.TleSolicitar_HHEE.Text = "Hora Extra"
        Me.TleSolicitar_HHEE.TileImage = Global.RRHH.My.Resources.Resources.HoraExtra_iloveimg_resized__1_
        Me.ToolTip.SetToolTip(Me.TleSolicitar_HHEE, "Solicitar Hora Extra")
        Me.TleSolicitar_HHEE.UseCustomBackColor = True
        Me.TleSolicitar_HHEE.UseSelectable = True
        Me.TleSolicitar_HHEE.UseTileImage = True
        '
        'Tle_Asistencias_Periodo
        '
        Me.Tle_Asistencias_Periodo.ActiveControl = Nothing
        Me.Tle_Asistencias_Periodo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tle_Asistencias_Periodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Tle_Asistencias_Periodo.Location = New System.Drawing.Point(249, 6)
        Me.Tle_Asistencias_Periodo.Name = "Tle_Asistencias_Periodo"
        Me.Tle_Asistencias_Periodo.Size = New System.Drawing.Size(119, 107)
        Me.Tle_Asistencias_Periodo.TabIndex = 19
        Me.Tle_Asistencias_Periodo.Text = "Asistencias"
        Me.Tle_Asistencias_Periodo.TileImage = Global.RRHH.My.Resources.Resources.Asistencia64
        Me.ToolTip.SetToolTip(Me.Tle_Asistencias_Periodo, "Solicitar Permiso")
        Me.Tle_Asistencias_Periodo.UseCustomBackColor = True
        Me.Tle_Asistencias_Periodo.UseSelectable = True
        Me.Tle_Asistencias_Periodo.UseTileImage = True
        '
        'Tle_Herramientas_Pre
        '
        Me.Tle_Herramientas_Pre.ActiveControl = Nothing
        Me.Tle_Herramientas_Pre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tle_Herramientas_Pre.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Tle_Herramientas_Pre.Location = New System.Drawing.Point(4, 10)
        Me.Tle_Herramientas_Pre.Name = "Tle_Herramientas_Pre"
        Me.Tle_Herramientas_Pre.Size = New System.Drawing.Size(247, 107)
        Me.Tle_Herramientas_Pre.TabIndex = 10
        Me.Tle_Herramientas_Pre.Text = "Herramientas Precision"
        Me.Tle_Herramientas_Pre.TileImage = Global.RRHH.My.Resources.Resources.Medicion_64
        Me.ToolTip.SetToolTip(Me.Tle_Herramientas_Pre, "Gestion Herramientas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Precision")
        Me.Tle_Herramientas_Pre.UseCustomBackColor = True
        Me.Tle_Herramientas_Pre.UseSelectable = True
        Me.Tle_Herramientas_Pre.UseTileImage = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Empty
        Me.ImageList1.Images.SetKeyName(0, "Btn_Colaciones.jpg")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1129, 63)
        Me.Panel1.TabIndex = 10
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Lbl_Nombre, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Lbl_Cod_Interno, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Lbl_RutEmpresa, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Lbl_RutTrab, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button4, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PcturBx_Image, 3, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(731, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(395, 55)
        Me.TableLayoutPanel2.TabIndex = 14
        Me.TableLayoutPanel2.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Empresa"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.UseWaitCursor = True
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lbl_Nombre.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nombre.Location = New System.Drawing.Point(3, 5)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(244, 16)
        Me.Lbl_Nombre.TabIndex = 0
        Me.Lbl_Nombre.Text = "Nombre"
        Me.Lbl_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Lbl_Nombre.UseWaitCursor = True
        '
        'Lbl_Cod_Interno
        '
        Me.Lbl_Cod_Interno.AutoSize = True
        Me.Lbl_Cod_Interno.Location = New System.Drawing.Point(253, 0)
        Me.Lbl_Cod_Interno.Name = "Lbl_Cod_Interno"
        Me.Lbl_Cod_Interno.Size = New System.Drawing.Size(2, 27)
        Me.Lbl_Cod_Interno.TabIndex = 4
        Me.Lbl_Cod_Interno.Text = "Cod_Int"
        Me.Lbl_Cod_Interno.UseWaitCursor = True
        '
        'Lbl_RutEmpresa
        '
        Me.Lbl_RutEmpresa.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Lbl_RutEmpresa, 2)
        Me.Lbl_RutEmpresa.Location = New System.Drawing.Point(253, 27)
        Me.Lbl_RutEmpresa.Name = "Lbl_RutEmpresa"
        Me.Lbl_RutEmpresa.Size = New System.Drawing.Size(11, 28)
        Me.Lbl_RutEmpresa.TabIndex = 5
        Me.Lbl_RutEmpresa.Text = "RutEmpresa"
        Me.Lbl_RutEmpresa.UseWaitCursor = True
        Me.Lbl_RutEmpresa.Visible = False
        '
        'Lbl_RutTrab
        '
        Me.Lbl_RutTrab.AutoSize = True
        Me.Lbl_RutTrab.Location = New System.Drawing.Point(261, 0)
        Me.Lbl_RutTrab.Name = "Lbl_RutTrab"
        Me.Lbl_RutTrab.Size = New System.Drawing.Size(3, 27)
        Me.Lbl_RutTrab.TabIndex = 6
        Me.Lbl_RutTrab.Text = "RutTrab"
        Me.Lbl_RutTrab.UseWaitCursor = True
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(332, 0)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.TableLayoutPanel2.SetRowSpan(Me.Button4, 2)
        Me.Button4.Size = New System.Drawing.Size(58, 54)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Cerrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sesión"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.UseWaitCursor = True
        '
        'PcturBx_Image
        '
        Me.PcturBx_Image.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PcturBx_Image.Location = New System.Drawing.Point(270, 3)
        Me.PcturBx_Image.Name = "PcturBx_Image"
        Me.TableLayoutPanel2.SetRowSpan(Me.PcturBx_Image, 2)
        Me.PcturBx_Image.Size = New System.Drawing.Size(55, 49)
        Me.PcturBx_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PcturBx_Image.TabIndex = 13
        Me.PcturBx_Image.TabStop = False
        Me.PcturBx_Image.UseWaitCursor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Lbl_Cod_ID, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(224, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.09091!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.90909!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(504, 55)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'Lbl_Cod_ID
        '
        Me.Lbl_Cod_ID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lbl_Cod_ID.AutoSize = True
        Me.Lbl_Cod_ID.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Cod_ID.Location = New System.Drawing.Point(3, 40)
        Me.Lbl_Cod_ID.Name = "Lbl_Cod_ID"
        Me.Lbl_Cod_ID.Size = New System.Drawing.Size(64, 13)
        Me.Lbl_Cod_ID.TabIndex = 1
        Me.Lbl_Cod_ID.Text = "Lbl_Cod_ID"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(498, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sistema Integrado de Aplicaciones"
        '
        'TxtBx_Empresa
        '
        Me.TxtBx_Empresa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TxtBx_Empresa.Location = New System.Drawing.Point(972, 35)
        Me.TxtBx_Empresa.Name = "TxtBx_Empresa"
        Me.TxtBx_Empresa.ReadOnly = True
        Me.TxtBx_Empresa.Size = New System.Drawing.Size(149, 20)
        Me.TxtBx_Empresa.TabIndex = 1
        Me.TxtBx_Empresa.UseWaitCursor = True
        Me.TxtBx_Empresa.Visible = False
        '
        'TxtBx_UserName
        '
        Me.TxtBx_UserName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TxtBx_UserName.Location = New System.Drawing.Point(972, 12)
        Me.TxtBx_UserName.Name = "TxtBx_UserName"
        Me.TxtBx_UserName.ReadOnly = True
        Me.TxtBx_UserName.Size = New System.Drawing.Size(149, 20)
        Me.TxtBx_UserName.TabIndex = 3
        Me.TxtBx_UserName.UseWaitCursor = True
        Me.TxtBx_UserName.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Controls.Add(Me.pnlMovingRight2)
        Me.Panel2.Controls.Add(Me.pnlMovingRight)
        Me.Panel2.Controls.Add(Me.pnlMovingTop)
        Me.Panel2.Controls.Add(Me.TxtBx_Empresa)
        Me.Panel2.Controls.Add(Me.TxtBx_UserName)
        Me.Panel2.Location = New System.Drawing.Point(0, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1129, 790)
        Me.Panel2.TabIndex = 11
        '
        'pnlMovingRight2
        '
        Me.pnlMovingRight2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlMovingRight2.Controls.Add(Me.Tle_Herramientas_Pre)
        Me.pnlMovingRight2.Location = New System.Drawing.Point(3, 668)
        Me.pnlMovingRight2.Name = "pnlMovingRight2"
        Me.pnlMovingRight2.Size = New System.Drawing.Size(640, 120)
        Me.pnlMovingRight2.TabIndex = 21
        '
        'pnlMovingRight
        '
        Me.pnlMovingRight.Controls.Add(Me.Tle_Asistencias_Periodo)
        Me.pnlMovingRight.Controls.Add(Me.Tle_SolAlmuerzo)
        Me.pnlMovingRight.Controls.Add(Me.Tle_Liquidacion)
        Me.pnlMovingRight.Controls.Add(Me.TleSolicitar_HHEE)
        Me.pnlMovingRight.Controls.Add(Me.Tle_Solicitar_Permisos)
        Me.pnlMovingRight.Location = New System.Drawing.Point(5, 0)
        Me.pnlMovingRight.Name = "pnlMovingRight"
        Me.pnlMovingRight.Size = New System.Drawing.Size(640, 120)
        Me.pnlMovingRight.TabIndex = 20
        '
        'pnlMovingTop
        '
        Me.pnlMovingTop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMovingTop.Controls.Add(Me.Tle_InformesAlmu)
        Me.pnlMovingTop.Controls.Add(Me.Tle_Exportador)
        Me.pnlMovingTop.Controls.Add(Me.Tle_Permisos)
        Me.pnlMovingTop.Controls.Add(Me.Tle_Configuracion)
        Me.pnlMovingTop.Controls.Add(Me.Tle_AlmuAdicional)
        Me.pnlMovingTop.Controls.Add(Me.Tle_MantencionColacione)
        Me.pnlMovingTop.Location = New System.Drawing.Point(864, 99)
        Me.pnlMovingTop.Name = "pnlMovingTop"
        Me.pnlMovingTop.Size = New System.Drawing.Size(262, 688)
        Me.pnlMovingTop.TabIndex = 19
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(-3, 89)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1139, 4)
        Me.FlowLayoutPanel1.TabIndex = 13
        '
        'TiempoIngreso
        '
        Me.TiempoIngreso.Interval = 1000
        '
        'TmrDesplaza
        '
        Me.TmrDesplaza.Interval = 25
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RRHH.My.Resources.Resources.plus
        Me.PictureBox2.Location = New System.Drawing.Point(4, 7)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 906)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MDIParent1"
        Me.Padding = New System.Windows.Forms.Padding(0, 60, 0, 0)
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PcturBx_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlMovingRight2.ResumeLayout(False)
        Me.pnlMovingRight.ResumeLayout(False)
        Me.pnlMovingTop.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl_Nombre As Label
    Friend WithEvents TxtBx_Empresa As TextBox
    Friend WithEvents TxtBx_UserName As TextBox
    Friend WithEvents PcturBx_Image As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents TiempoIngreso As Timer
    Friend WithEvents TlStrpSttsLbl_SQL As ToolStripStatusLabel
    Friend WithEvents TlStrpSttsLbl_Proceso As ToolStripStatusLabel
    Friend WithEvents Lbl_Cod_ID As Label
    Friend WithEvents Lbl_Cod_Interno As Label
    Friend WithEvents Lbl_RutEmpresa As Label
    Friend WithEvents Lbl_RutTrab As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button4 As Button 'MetroFramework.Controls.MetroButton '
    Friend WithEvents Tle_Exportador As MetroFramework.Controls.MetroTile
    Friend WithEvents Tle_SolAlmuerzo As MetroFramework.Controls.MetroTile
    Friend WithEvents Tle_Liquidacion As MetroFramework.Controls.MetroTile
    Friend WithEvents Tle_Permisos As MetroFramework.Controls.MetroTile
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Tle_MantencionColacione As MetroFramework.Controls.MetroTile
    Friend WithEvents Tle_AlmuAdicional As MetroFramework.Controls.MetroTile
    Friend WithEvents Tle_Configuracion As MetroFramework.Controls.MetroTile
    Friend WithEvents Tle_InformesAlmu As MetroFramework.Controls.MetroTile
    Friend WithEvents TmrDesplaza As Timer
    Friend WithEvents TleSolicitar_HHEE As MetroFramework.Controls.MetroTile
    Friend WithEvents Tle_Solicitar_Permisos As MetroFramework.Controls.MetroTile
    Friend WithEvents pnlMovingTop As Panel
    Friend WithEvents pnlMovingRight As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Tle_Asistencias_Periodo As MetroFramework.Controls.MetroTile
    Friend WithEvents pnlMovingRight2 As Panel
    Friend WithEvents Tle_Herramientas_Pre As MetroFramework.Controls.MetroTile
End Class

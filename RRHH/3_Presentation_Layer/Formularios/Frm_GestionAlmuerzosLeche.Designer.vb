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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblEmpresaInformeHHEE = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox4 = New MetroFramework.Controls.MetroComboBox()
        Me.txtBusqueda = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MonthCalendar3 = New Pabo.Calendar.MonthCalendar()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox2 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.lblModo = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.TxtEmpleado = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New MetroFramework.Controls.MetroLabel()
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnRecarga = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnVolver2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.MetroLabel4)
        Me.Panel1.Controls.Add(Me.MetroComboBox4)
        Me.Panel1.Controls.Add(Me.btnRecarga)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtBusqueda)
        Me.Panel1.Controls.Add(Me.MetroLabel3)
        Me.Panel1.Controls.Add(Me.MonthCalendar3)
        Me.Panel1.Controls.Add(Me.MetroLabel1)
        Me.Panel1.Controls.Add(Me.MetroLabel2)
        Me.Panel1.Controls.Add(Me.MetroComboBox2)
        Me.Panel1.Controls.Add(Me.MetroComboBox1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblModo)
        Me.Panel1.Controls.Add(Me.lblTipo)
        Me.Panel1.Controls.Add(Me.TxtEmpleado)
        Me.Panel1.Controls.Add(Me.lblCantidad)
        Me.Panel1.Controls.Add(Me.MetroLabel8)
        Me.Panel1.Controls.Add(Me.MetroComboBox5)
        Me.Panel1.Controls.Add(Me.MetroGrid1)
        Me.Panel1.Controls.Add(Me.MetroLabel7)
        Me.Panel1.Controls.Add(Me.MetroComboBox3)
        Me.Panel1.Controls.Add(Me.MetroLabel5)
        Me.Panel1.Controls.Add(Me.BtnVolver2)
        Me.Panel1.Location = New System.Drawing.Point(20, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1322, 770)
        Me.Panel1.TabIndex = 50
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(742, 55)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(96, 19)
        Me.MetroLabel4.TabIndex = 75
        Me.MetroLabel4.Text = "Informes Excel:"
        '
        'MetroComboBox4
        '
        Me.MetroComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MetroComboBox4.FormattingEnabled = True
        Me.MetroComboBox4.ItemHeight = 23
        Me.MetroComboBox4.Items.AddRange(New Object() {"Empleados con Almuerzos", "Empleados con Leche", "Almuerzos / Leche Calendario"})
        Me.MetroComboBox4.Location = New System.Drawing.Point(878, 49)
        Me.MetroComboBox4.Name = "MetroComboBox4"
        Me.MetroComboBox4.Size = New System.Drawing.Size(366, 29)
        Me.MetroComboBox4.TabIndex = 74
        Me.MetroComboBox4.UseSelectable = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.AcceptsReturn = False
        Me.txtBusqueda.AcceptsTab = False
        Me.txtBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtBusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtBusqueda.Depth = 0
        Me.txtBusqueda.Hint = ""
        Me.txtBusqueda.Location = New System.Drawing.Point(878, 6)
        Me.txtBusqueda.MaxLength = 32767
        Me.txtBusqueda.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtBusqueda.Multiline = False
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusqueda.ReadOnly = False
        Me.txtBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBusqueda.SelectedText = ""
        Me.txtBusqueda.SelectionLength = 0
        Me.txtBusqueda.SelectionStart = 0
        Me.txtBusqueda.Size = New System.Drawing.Size(280, 23)
        Me.txtBusqueda.TabIndex = 71
        Me.txtBusqueda.TabStop = False
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtBusqueda.UseSystemPasswordChar = False
        Me.txtBusqueda.WordWrap = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(741, 18)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(128, 19)
        Me.MetroLabel3.TabIndex = 70
        Me.MetroLabel3.Text = "Nombre / Apellido :"
        '
        'MonthCalendar3
        '
        Me.MonthCalendar3.ActiveMonth.Month = 7
        Me.MonthCalendar3.ActiveMonth.Year = 2018
        Me.MonthCalendar3.BorderStyle = System.Windows.Forms.ButtonBorderStyle.None
        Me.MonthCalendar3.Culture = New System.Globalization.CultureInfo("es-CL")
        Me.MonthCalendar3.Footer.Align = Pabo.Calendar.mcTextAlign.Center
        Me.MonthCalendar3.Footer.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MonthCalendar3.Footer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar3.Footer.TextColor = System.Drawing.Color.White
        Me.MonthCalendar3.Header.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.MonthCalendar3.Header.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar3.Header.TextColor = System.Drawing.Color.White
        Me.MonthCalendar3.ImageList = Nothing
        Me.MonthCalendar3.Location = New System.Drawing.Point(723, 309)
        Me.MonthCalendar3.MaxDate = New Date(2028, 7, 18, 13, 23, 7, 845)
        Me.MonthCalendar3.MinDate = New Date(2008, 7, 18, 13, 23, 7, 845)
        Me.MonthCalendar3.Month.BackgroundImage = Nothing
        Me.MonthCalendar3.Month.DateFont = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar3.Month.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendar3.Name = "MonthCalendar3"
        Me.MonthCalendar3.SelectionMode = Pabo.Calendar.mcSelectionMode.One
        Me.MonthCalendar3.Size = New System.Drawing.Size(586, 399)
        Me.MonthCalendar3.TabIndex = 69
        Me.MonthCalendar3.TodayColor = System.Drawing.Color.Transparent
        Me.MonthCalendar3.Weekdays.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.MonthCalendar3.Weekdays.BorderColor = System.Drawing.Color.Transparent
        Me.MonthCalendar3.Weekdays.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MonthCalendar3.Weekdays.TextColor = System.Drawing.Color.White
        Me.MonthCalendar3.Weeknumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(516, 53)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel1.TabIndex = 67
        Me.MetroLabel1.Text = "Modo:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(526, 18)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel2.TabIndex = 66
        Me.MetroLabel2.Text = "Tipo:"
        '
        'MetroComboBox2
        '
        Me.MetroComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MetroComboBox2.FormattingEnabled = True
        Me.MetroComboBox2.ItemHeight = 23
        Me.MetroComboBox2.Location = New System.Drawing.Point(570, 49)
        Me.MetroComboBox2.Name = "MetroComboBox2"
        Me.MetroComboBox2.Size = New System.Drawing.Size(133, 29)
        Me.MetroComboBox2.TabIndex = 65
        Me.MetroComboBox2.UseSelectable = True
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(570, 14)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(133, 29)
        Me.MetroComboBox1.TabIndex = 64
        Me.MetroComboBox1.UseSelectable = True
        '
        'lblModo
        '
        Me.lblModo.AutoSize = True
        Me.lblModo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModo.Location = New System.Drawing.Point(779, 219)
        Me.lblModo.Name = "lblModo"
        Me.lblModo.Size = New System.Drawing.Size(84, 32)
        Me.lblModo.TabIndex = 62
        Me.lblModo.Text = "Label2"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(779, 176)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(84, 32)
        Me.lblTipo.TabIndex = 61
        Me.lblTipo.Text = "Label1"
        '
        'TxtEmpleado
        '
        Me.TxtEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TxtEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEmpleado.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.TxtEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtEmpleado.Location = New System.Drawing.Point(709, 94)
        Me.TxtEmpleado.Name = "TxtEmpleado"
        Me.TxtEmpleado.ReadOnly = True
        Me.TxtEmpleado.Size = New System.Drawing.Size(607, 25)
        Me.TxtEmpleado.TabIndex = 58
        Me.TxtEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(117, 661)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(62, 19)
        Me.lblCantidad.TabIndex = 57
        Me.lblCantidad.Text = "Cantidad"
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
        Me.MetroGrid1.Size = New System.Drawing.Size(586, 560)
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 26)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.RRHH.My.Resources.Resources.stopwatch
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(1258, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox2.TabIndex = 77
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'btnRecarga
        '
        Me.btnRecarga.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnRecarga.BackgroundImage = Global.RRHH.My.Resources.Resources.refresh_24
        Me.btnRecarga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRecarga.FlatAppearance.BorderSize = 0
        Me.btnRecarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecarga.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecarga.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRecarga.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRecarga.Location = New System.Drawing.Point(1209, 11)
        Me.btnRecarga.Name = "btnRecarga"
        Me.btnRecarga.Size = New System.Drawing.Size(35, 34)
        Me.btnRecarga.TabIndex = 73
        Me.btnRecarga.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnRecarga.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnBuscar.BackgroundImage = Global.RRHH.My.Resources.Resources.search24
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnBuscar.Location = New System.Drawing.Point(1168, 11)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(35, 34)
        Me.btnBuscar.TabIndex = 72
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1130, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 175)
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
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
        Me.BtnVolver2.Location = New System.Drawing.Point(5, 687)
        Me.BtnVolver2.Name = "BtnVolver2"
        Me.BtnVolver2.Size = New System.Drawing.Size(195, 80)
        Me.BtnVolver2.TabIndex = 49
        Me.BtnVolver2.Text = "Volver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Al Inicio"
        Me.BtnVolver2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnVolver2.UseVisualStyleBackColor = False
        '
        'Frm_GestionAlmuerzosLeche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1364, 846)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblEmpresaInformeHHEE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_GestionAlmuerzosLeche"
        Me.Text = "Gestion de Almuerzos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmpresaInformeHHEE As Label
    Friend WithEvents BtnVolver2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox5 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox3 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
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
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MonthCalendar3 As Pabo.Calendar.MonthCalendar
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBusqueda As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnRecarga As Button
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox4 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PictureBox2 As PictureBox
End Class

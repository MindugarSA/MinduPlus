Partial Class Form1
    ''' <summary>
    ''' Variable del diseñador necesaria.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Limpiar los recursos que se estén usando.
    ''' </summary>
    ''' <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Código generado por el Diseñador de Windows Forms"

    ''' <summary>
    ''' Método necesario para admitir el Diseñador. No se puede modificar
    ''' el contenido de este método con el editor de código.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.backgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.backgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.contextVerSelec = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextOcultarSelec = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.gradientTab1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabPage0 = New System.Windows.Forms.TabPage()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroProgressSpinner1 = New MetroFramework.Controls.MetroProgressSpinner()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.progressBar3 = New MetroFramework.Controls.MetroProgressBar()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.dataGridView1 = New MetroFramework.Controls.MetroGrid()
        Me.comboBox2 = New System.Windows.Forms.ComboBox()
        Me.progressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.label14 = New System.Windows.Forms.Label()
        Me.button8 = New System.Windows.Forms.Button()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.comboBox6 = New System.Windows.Forms.ComboBox()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.button5 = New System.Windows.Forms.Button()
        Me.dataGridView2 = New MetroFramework.Controls.MetroGrid()
        Me.button4 = New System.Windows.Forms.Button()
        Me.label8 = New System.Windows.Forms.Label()
        Me.comboBox3 = New System.Windows.Forms.ComboBox()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.button9 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.comboBox5 = New System.Windows.Forms.ComboBox()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.dataGridView3 = New MetroFramework.Controls.MetroGrid()
        Me.button6 = New System.Windows.Forms.Button()
        Me.label9 = New System.Windows.Forms.Label()
        Me.comboBox4 = New System.Windows.Forms.ComboBox()
        Me.tabPage3 = New System.Windows.Forms.TabPage()
        Me.groupBox6 = New System.Windows.Forms.GroupBox()
        Me.groupBox9 = New System.Windows.Forms.GroupBox()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.button10 = New System.Windows.Forms.Button()
        Me.label20 = New System.Windows.Forms.Label()
        Me.progressBar2 = New MetroFramework.Controls.MetroProgressBar()
        Me.groupBox8 = New System.Windows.Forms.GroupBox()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.label19 = New System.Windows.Forms.Label()
        Me.comboBox8 = New System.Windows.Forms.ComboBox()
        Me.button14 = New System.Windows.Forms.Button()
        Me.comboBox7 = New System.Windows.Forms.ComboBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.button11 = New System.Windows.Forms.Button()
        Me.label16 = New System.Windows.Forms.Label()
        Me.button12 = New System.Windows.Forms.Button()
        Me.button13 = New System.Windows.Forms.Button()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.groupBox7 = New System.Windows.Forms.GroupBox()
        Me.dataGridView4 = New MetroFramework.Controls.MetroGrid()
        Me.Label21 = New System.Windows.Forms.Label()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextVerSelec.SuspendLayout()
        Me.contextOcultarSelec.SuspendLayout()
        Me.gradientTab1.SuspendLayout()
        Me.tabPage0.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        CType(Me.dataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage3.SuspendLayout()
        Me.groupBox6.SuspendLayout()
        Me.groupBox9.SuspendLayout()
        Me.groupBox8.SuspendLayout()
        CType(Me.dataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backgroundWorker1
        '
        Me.backgroundWorker1.WorkerReportsProgress = True
        '
        'backgroundWorker2
        '
        Me.backgroundWorker2.WorkerSupportsCancellation = True
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'contextVerSelec
        '
        Me.contextVerSelec.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1})
        Me.contextVerSelec.Name = "contextVerSelec"
        Me.contextVerSelec.Size = New System.Drawing.Size(230, 26)
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Image = Global.ImportarExcelSQLServer.Resources.magnifier_zoom_in
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(229, 22)
        Me.toolStripMenuItem1.Text = "Mostrar Todos los Empleados"
        '
        'contextOcultarSelec
        '
        Me.contextOcultarSelec.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem2})
        Me.contextOcultarSelec.Name = "contextOcultarSelec"
        Me.contextOcultarSelec.Size = New System.Drawing.Size(274, 26)
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Image = Global.ImportarExcelSQLServer.Resources.magifier_zoom_out
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(273, 22)
        Me.toolStripMenuItem2.Text = "Ocultar Empleados NO Seleccionados"
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVolver.Image = Global.ImportarExcelSQLServer.Resources.home_shape32
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnVolver.Location = New System.Drawing.Point(15, 540)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(0)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(170, 52)
        Me.btnVolver.TabIndex = 10
        Me.btnVolver.Text = "Volver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A Inicio"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'gradientTab1
        '
        Me.gradientTab1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gradientTab1.Controls.Add(Me.tabPage0)
        Me.gradientTab1.Controls.Add(Me.tabPage1)
        Me.gradientTab1.Controls.Add(Me.tabPage2)
        Me.gradientTab1.Controls.Add(Me.tabPage3)
        Me.gradientTab1.Location = New System.Drawing.Point(12, 34)
        Me.gradientTab1.Name = "gradientTab1"
        Me.gradientTab1.SelectedIndex = 3
        Me.gradientTab1.Size = New System.Drawing.Size(1333, 508)
        Me.gradientTab1.TabIndex = 9
        Me.gradientTab1.UseSelectable = True
        '
        'tabPage0
        '
        Me.tabPage0.BackgroundImage = CType(resources.GetObject("tabPage0.BackgroundImage"), System.Drawing.Image)
        Me.tabPage0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabPage0.Controls.Add(Me.groupBox1)
        Me.tabPage0.Location = New System.Drawing.Point(4, 38)
        Me.tabPage0.Name = "tabPage0"
        Me.tabPage0.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage0.Size = New System.Drawing.Size(1325, 466)
        Me.tabPage0.TabIndex = 0
        Me.tabPage0.Text = "Importar Excel    "
        Me.tabPage0.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.White
        Me.groupBox1.Controls.Add(Me.MetroProgressSpinner1)
        Me.groupBox1.Controls.Add(Me.pictureBox1)
        Me.groupBox1.Controls.Add(Me.progressBar3)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.button3)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.textBox2)
        Me.groupBox1.Controls.Add(Me.dataGridView1)
        Me.groupBox1.Controls.Add(Me.comboBox2)
        Me.groupBox1.Controls.Add(Me.progressBar1)
        Me.groupBox1.Controls.Add(Me.comboBox1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.textBox1)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBox1.Location = New System.Drawing.Point(3, 3)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.groupBox1.Size = New System.Drawing.Size(1319, 460)
        Me.groupBox1.TabIndex = 7
        Me.groupBox1.TabStop = False
        '
        'MetroProgressSpinner1
        '
        Me.MetroProgressSpinner1.Location = New System.Drawing.Point(80, 8)
        Me.MetroProgressSpinner1.Maximum = 100
        Me.MetroProgressSpinner1.Name = "MetroProgressSpinner1"
        Me.MetroProgressSpinner1.Size = New System.Drawing.Size(30, 30)
        Me.MetroProgressSpinner1.Speed = 6.0!
        Me.MetroProgressSpinner1.TabIndex = 20
        Me.MetroProgressSpinner1.UseSelectable = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.ImportarExcelSQLServer.Resources.Loader
        Me.pictureBox1.Location = New System.Drawing.Point(31, 7)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.pictureBox1.TabIndex = 19
        Me.pictureBox1.TabStop = False
        '
        'progressBar3
        '
        Me.progressBar3.Location = New System.Drawing.Point(113, 59)
        Me.progressBar3.Name = "progressBar3"
        Me.progressBar3.Size = New System.Drawing.Size(436, 14)
        Me.progressBar3.TabIndex = 18
        '
        'label6
        '
        Me.label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(110, 15)
        Me.label6.Name = "label6"
        Me.label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label6.Size = New System.Drawing.Size(19, 13)
        Me.label6.TabIndex = 15
        Me.label6.Text = "..."
        '
        'label7
        '
        Me.label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.label7.Location = New System.Drawing.Point(15, 422)
        Me.label7.Name = "label7"
        Me.label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label7.Size = New System.Drawing.Size(102, 19)
        Me.label7.TabIndex = 16
        Me.label7.Text = "Total Registros"
        '
        'button3
        '
        Me.button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button3.FlatAppearance.BorderSize = 0
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Image = Global.ImportarExcelSQLServer.Resources.search_white16
        Me.button3.Location = New System.Drawing.Point(962, 31)
        Me.button3.Name = "button3"
        Me.button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button3.Size = New System.Drawing.Size(27, 27)
        Me.button3.TabIndex = 14
        Me.button3.UseVisualStyleBackColor = False
        '
        'label5
        '
        Me.label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.label5.Location = New System.Drawing.Point(870, 15)
        Me.label5.Name = "label5"
        Me.label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label5.Size = New System.Drawing.Size(101, 19)
        Me.label5.TabIndex = 13
        Me.label5.Text = "- Buscar RUT -"
        '
        'textBox2
        '
        Me.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.textBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.textBox2.Location = New System.Drawing.Point(858, 34)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(100, 23)
        Me.textBox2.TabIndex = 12
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.AllowUserToOrderColumns = True
        Me.dataGridView1.AllowUserToResizeColumns = False
        Me.dataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.dataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridView1.EnableHeadersVisualStyles = False
        Me.dataGridView1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dataGridView1.Location = New System.Drawing.Point(15, 77)
        Me.dataGridView1.MultiSelect = False
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataGridView1.RowHeadersVisible = False
        Me.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView1.Size = New System.Drawing.Size(1278, 342)
        Me.dataGridView1.TabIndex = 7
        Me.dataGridView1.UseCustomBackColor = True
        Me.dataGridView1.UseCustomForeColor = True
        Me.dataGridView1.UseStyleColors = True
        '
        'comboBox2
        '
        Me.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.comboBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.comboBox2.FormattingEnabled = True
        Me.comboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.comboBox2.Location = New System.Drawing.Point(754, 32)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.comboBox2.Size = New System.Drawing.Size(52, 23)
        Me.comboBox2.TabIndex = 11
        '
        'progressBar1
        '
        Me.progressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progressBar1.Location = New System.Drawing.Point(15, 59)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(1278, 14)
        Me.progressBar1.TabIndex = 4
        '
        'comboBox1
        '
        Me.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.comboBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.comboBox1.Location = New System.Drawing.Point(643, 32)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.comboBox1.Size = New System.Drawing.Size(65, 23)
        Me.comboBox1.TabIndex = 10
        '
        'label4
        '
        Me.label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.label4.Location = New System.Drawing.Point(670, 15)
        Me.label4.Name = "label4"
        Me.label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label4.Size = New System.Drawing.Size(77, 19)
        Me.label4.TabIndex = 3
        Me.label4.Text = "- Periodo -"
        '
        'textBox1
        '
        Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBox1.Enabled = False
        Me.textBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.textBox1.Location = New System.Drawing.Point(113, 33)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.textBox1.Size = New System.Drawing.Size(436, 23)
        Me.textBox1.TabIndex = 9
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.label1.Location = New System.Drawing.Point(15, 35)
        Me.label1.Name = "label1"
        Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label1.Size = New System.Drawing.Size(96, 19)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Archivo Excel:"
        '
        'button2
        '
        Me.button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button2.Enabled = False
        Me.button2.FlatAppearance.BorderSize = 0
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.button2.Image = Global.ImportarExcelSQLServer.Resources.profile_user_white16
        Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button2.Location = New System.Drawing.Point(1130, 31)
        Me.button2.Name = "button2"
        Me.button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button2.Size = New System.Drawing.Size(163, 27)
        Me.button2.TabIndex = 2
        Me.button2.Text = "Exportar a SQL"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button1.FlatAppearance.BorderSize = 0
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.button1.Location = New System.Drawing.Point(555, 31)
        Me.button1.Name = "button1"
        Me.button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button1.Size = New System.Drawing.Size(27, 27)
        Me.button1.TabIndex = 7
        Me.button1.Text = "..."
        Me.button1.UseVisualStyleBackColor = False
        '
        'label3
        '
        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.label3.Location = New System.Drawing.Point(717, 34)
        Me.label3.Name = "label3"
        Me.label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label3.Size = New System.Drawing.Size(38, 19)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Mes:"
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.label2.Location = New System.Drawing.Point(608, 34)
        Me.label2.Name = "label2"
        Me.label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label2.Size = New System.Drawing.Size(37, 19)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Año:"
        '
        'tabPage1
        '
        Me.tabPage1.BackgroundImage = CType(resources.GetObject("tabPage1.BackgroundImage"), System.Drawing.Image)
        Me.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabPage1.Controls.Add(Me.groupBox2)
        Me.tabPage1.Location = New System.Drawing.Point(4, 38)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(1325, 466)
        Me.tabPage1.TabIndex = 1
        Me.tabPage1.Text = "Consultar Asistencias    "
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.White
        Me.groupBox2.Controls.Add(Me.Button15)
        Me.groupBox2.Controls.Add(Me.label14)
        Me.groupBox2.Controls.Add(Me.button8)
        Me.groupBox2.Controls.Add(Me.textBox4)
        Me.groupBox2.Controls.Add(Me.label12)
        Me.groupBox2.Controls.Add(Me.label13)
        Me.groupBox2.Controls.Add(Me.comboBox6)
        Me.groupBox2.Controls.Add(Me.groupBox5)
        Me.groupBox2.Controls.Add(Me.button5)
        Me.groupBox2.Controls.Add(Me.dataGridView2)
        Me.groupBox2.Controls.Add(Me.button4)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.comboBox3)
        Me.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox2.Location = New System.Drawing.Point(3, 3)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(1319, 460)
        Me.groupBox2.TabIndex = 0
        Me.groupBox2.TabStop = False
        '
        'Button15
        '
        Me.Button15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button15.Enabled = False
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button15.Image = Global.ImportarExcelSQLServer.Resources.ms_excel_white16
        Me.Button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button15.Location = New System.Drawing.Point(1047, 19)
        Me.Button15.Name = "Button15"
        Me.Button15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button15.Size = New System.Drawing.Size(137, 27)
        Me.Button15.TabIndex = 28
        Me.Button15.Text = "Ver Archivo Origen"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button15.UseVisualStyleBackColor = False
        '
        'label14
        '
        Me.label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label14.AutoSize = True
        Me.label14.BackColor = System.Drawing.Color.Transparent
        Me.label14.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.label14.Location = New System.Drawing.Point(15, 422)
        Me.label14.Name = "label14"
        Me.label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label14.Size = New System.Drawing.Size(102, 19)
        Me.label14.TabIndex = 27
        Me.label14.Text = "Total Registros"
        '
        'button8
        '
        Me.button8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button8.FlatAppearance.BorderSize = 0
        Me.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button8.Image = CType(resources.GetObject("button8.Image"), System.Drawing.Image)
        Me.button8.Location = New System.Drawing.Point(854, 20)
        Me.button8.Name = "button8"
        Me.button8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button8.Size = New System.Drawing.Size(27, 27)
        Me.button8.TabIndex = 25
        Me.button8.UseVisualStyleBackColor = False
        '
        'textBox4
        '
        Me.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.textBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.textBox4.Location = New System.Drawing.Point(746, 22)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(100, 23)
        Me.textBox4.TabIndex = 21
        '
        'label12
        '
        Me.label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(603, 26)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(141, 15)
        Me.label12.TabIndex = 24
        Me.label12.Text = "Rut o Nombre Empleado:"
        '
        'label13
        '
        Me.label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.Location = New System.Drawing.Point(383, 26)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(55, 15)
        Me.label13.TabIndex = 23
        Me.label13.Text = "Empresa:"
        '
        'comboBox6
        '
        Me.comboBox6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.comboBox6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboBox6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.comboBox6.FormattingEnabled = True
        Me.comboBox6.Location = New System.Drawing.Point(442, 22)
        Me.comboBox6.Name = "comboBox6"
        Me.comboBox6.Size = New System.Drawing.Size(155, 23)
        Me.comboBox6.TabIndex = 22
        '
        'groupBox5
        '
        Me.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.groupBox5.BackColor = System.Drawing.Color.Transparent
        Me.groupBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox5.Location = New System.Drawing.Point(340, 9)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(557, 42)
        Me.groupBox5.TabIndex = 26
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "FIltros"
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.button5.FlatAppearance.BorderSize = 0
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button5.Image = CType(resources.GetObject("button5.Image"), System.Drawing.Image)
        Me.button5.Location = New System.Drawing.Point(229, 19)
        Me.button5.Name = "button5"
        Me.button5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button5.Size = New System.Drawing.Size(27, 27)
        Me.button5.TabIndex = 15
        Me.button5.UseVisualStyleBackColor = False
        '
        'dataGridView2
        '
        Me.dataGridView2.AllowUserToAddRows = False
        Me.dataGridView2.AllowUserToDeleteRows = False
        Me.dataGridView2.AllowUserToOrderColumns = True
        Me.dataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue
        Me.dataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridView2.DefaultCellStyle = DataGridViewCellStyle7
        Me.dataGridView2.EnableHeadersVisualStyles = False
        Me.dataGridView2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dataGridView2.Location = New System.Drawing.Point(16, 56)
        Me.dataGridView2.MultiSelect = False
        Me.dataGridView2.Name = "dataGridView2"
        Me.dataGridView2.ReadOnly = True
        Me.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dataGridView2.RowHeadersVisible = False
        Me.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView2.Size = New System.Drawing.Size(1278, 363)
        Me.dataGridView2.TabIndex = 5
        '
        'button4
        '
        Me.button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button4.Enabled = False
        Me.button4.FlatAppearance.BorderSize = 0
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.button4.Location = New System.Drawing.Point(1190, 19)
        Me.button4.Name = "button4"
        Me.button4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button4.Size = New System.Drawing.Size(101, 27)
        Me.button4.TabIndex = 3
        Me.button4.Text = "Exportar a Excel"
        Me.button4.UseVisualStyleBackColor = False
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(16, 25)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(110, 15)
        Me.label8.TabIndex = 1
        Me.label8.Text = "Periodo Registrado:"
        '
        'comboBox3
        '
        Me.comboBox3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.comboBox3.FormattingEnabled = True
        Me.comboBox3.Location = New System.Drawing.Point(122, 21)
        Me.comboBox3.Name = "comboBox3"
        Me.comboBox3.Size = New System.Drawing.Size(102, 23)
        Me.comboBox3.TabIndex = 0
        '
        'tabPage2
        '
        Me.tabPage2.BackgroundImage = CType(resources.GetObject("tabPage2.BackgroundImage"), System.Drawing.Image)
        Me.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabPage2.Controls.Add(Me.groupBox3)
        Me.tabPage2.Location = New System.Drawing.Point(4, 38)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(1325, 466)
        Me.tabPage2.TabIndex = 2
        Me.tabPage2.Text = "Consultar Resumen    "
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'groupBox3
        '
        Me.groupBox3.BackColor = System.Drawing.Color.White
        Me.groupBox3.Controls.Add(Me.label15)
        Me.groupBox3.Controls.Add(Me.button9)
        Me.groupBox3.Controls.Add(Me.button7)
        Me.groupBox3.Controls.Add(Me.textBox3)
        Me.groupBox3.Controls.Add(Me.label11)
        Me.groupBox3.Controls.Add(Me.label10)
        Me.groupBox3.Controls.Add(Me.comboBox5)
        Me.groupBox3.Controls.Add(Me.groupBox4)
        Me.groupBox3.Controls.Add(Me.dataGridView3)
        Me.groupBox3.Controls.Add(Me.button6)
        Me.groupBox3.Controls.Add(Me.label9)
        Me.groupBox3.Controls.Add(Me.comboBox4)
        Me.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox3.Location = New System.Drawing.Point(3, 3)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(1319, 460)
        Me.groupBox3.TabIndex = 0
        Me.groupBox3.TabStop = False
        '
        'label15
        '
        Me.label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label15.AutoSize = True
        Me.label15.BackColor = System.Drawing.Color.Transparent
        Me.label15.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.label15.Location = New System.Drawing.Point(15, 422)
        Me.label15.Name = "label15"
        Me.label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label15.Size = New System.Drawing.Size(102, 19)
        Me.label15.TabIndex = 28
        Me.label15.Text = "Total Registros"
        '
        'button9
        '
        Me.button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button9.Enabled = False
        Me.button9.FlatAppearance.BorderSize = 0
        Me.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.button9.Location = New System.Drawing.Point(1190, 21)
        Me.button9.Name = "button9"
        Me.button9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button9.Size = New System.Drawing.Size(101, 27)
        Me.button9.TabIndex = 27
        Me.button9.Text = "Exportar a Excel"
        Me.button9.UseVisualStyleBackColor = False
        '
        'button7
        '
        Me.button7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button7.FlatAppearance.BorderSize = 0
        Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button7.Image = CType(resources.GetObject("button7.Image"), System.Drawing.Image)
        Me.button7.Location = New System.Drawing.Point(854, 20)
        Me.button7.Name = "button7"
        Me.button7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button7.Size = New System.Drawing.Size(27, 27)
        Me.button7.TabIndex = 25
        Me.button7.UseVisualStyleBackColor = False
        '
        'textBox3
        '
        Me.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.textBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.textBox3.Location = New System.Drawing.Point(746, 22)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(100, 23)
        Me.textBox3.TabIndex = 21
        '
        'label11
        '
        Me.label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label11.Location = New System.Drawing.Point(602, 26)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(141, 15)
        Me.label11.TabIndex = 24
        Me.label11.Text = "Rut o Nombre Empleado:"
        '
        'label10
        '
        Me.label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label10.Location = New System.Drawing.Point(372, 26)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(55, 15)
        Me.label10.TabIndex = 23
        Me.label10.Text = "Empresa:"
        '
        'comboBox5
        '
        Me.comboBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.comboBox5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.comboBox5.FormattingEnabled = True
        Me.comboBox5.Location = New System.Drawing.Point(433, 22)
        Me.comboBox5.Name = "comboBox5"
        Me.comboBox5.Size = New System.Drawing.Size(155, 23)
        Me.comboBox5.TabIndex = 22
        '
        'groupBox4
        '
        Me.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.groupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.groupBox4.Location = New System.Drawing.Point(340, 9)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(557, 42)
        Me.groupBox4.TabIndex = 26
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "FIltros"
        '
        'dataGridView3
        '
        Me.dataGridView3.AllowUserToAddRows = False
        Me.dataGridView3.AllowUserToDeleteRows = False
        Me.dataGridView3.AllowUserToOrderColumns = True
        Me.dataGridView3.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.AliceBlue
        Me.dataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dataGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridView3.DefaultCellStyle = DataGridViewCellStyle11
        Me.dataGridView3.EnableHeadersVisualStyles = False
        Me.dataGridView3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dataGridView3.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridView3.Location = New System.Drawing.Point(16, 56)
        Me.dataGridView3.MultiSelect = False
        Me.dataGridView3.Name = "dataGridView3"
        Me.dataGridView3.ReadOnly = True
        Me.dataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView3.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dataGridView3.RowHeadersVisible = False
        Me.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView3.Size = New System.Drawing.Size(1278, 363)
        Me.dataGridView3.TabIndex = 19
        '
        'button6
        '
        Me.button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button6.FlatAppearance.BorderSize = 0
        Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button6.Image = CType(resources.GetObject("button6.Image"), System.Drawing.Image)
        Me.button6.Location = New System.Drawing.Point(229, 18)
        Me.button6.Name = "button6"
        Me.button6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button6.Size = New System.Drawing.Size(27, 27)
        Me.button6.TabIndex = 18
        Me.button6.UseVisualStyleBackColor = False
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label9.Location = New System.Drawing.Point(16, 25)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(110, 15)
        Me.label9.TabIndex = 17
        Me.label9.Text = "Periodo Registrado:"
        '
        'comboBox4
        '
        Me.comboBox4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.comboBox4.FormattingEnabled = True
        Me.comboBox4.Location = New System.Drawing.Point(122, 21)
        Me.comboBox4.Name = "comboBox4"
        Me.comboBox4.Size = New System.Drawing.Size(102, 23)
        Me.comboBox4.TabIndex = 16
        '
        'tabPage3
        '
        Me.tabPage3.BackgroundImage = CType(resources.GetObject("tabPage3.BackgroundImage"), System.Drawing.Image)
        Me.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabPage3.Controls.Add(Me.groupBox6)
        Me.tabPage3.Location = New System.Drawing.Point(4, 38)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage3.Size = New System.Drawing.Size(1325, 466)
        Me.tabPage3.TabIndex = 3
        Me.tabPage3.Text = "GESTPER    "
        Me.tabPage3.UseVisualStyleBackColor = True
        '
        'groupBox6
        '
        Me.groupBox6.BackColor = System.Drawing.Color.White
        Me.groupBox6.Controls.Add(Me.groupBox9)
        Me.groupBox6.Controls.Add(Me.button10)
        Me.groupBox6.Controls.Add(Me.label20)
        Me.groupBox6.Controls.Add(Me.progressBar2)
        Me.groupBox6.Controls.Add(Me.groupBox8)
        Me.groupBox6.Controls.Add(Me.button11)
        Me.groupBox6.Controls.Add(Me.label16)
        Me.groupBox6.Controls.Add(Me.button12)
        Me.groupBox6.Controls.Add(Me.button13)
        Me.groupBox6.Controls.Add(Me.textBox5)
        Me.groupBox6.Controls.Add(Me.label17)
        Me.groupBox6.Controls.Add(Me.groupBox7)
        Me.groupBox6.Controls.Add(Me.dataGridView4)
        Me.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox6.Location = New System.Drawing.Point(3, 3)
        Me.groupBox6.Margin = New System.Windows.Forms.Padding(0)
        Me.groupBox6.Name = "groupBox6"
        Me.groupBox6.Size = New System.Drawing.Size(1319, 460)
        Me.groupBox6.TabIndex = 1
        Me.groupBox6.TabStop = False
        '
        'groupBox9
        '
        Me.groupBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox9.Controls.Add(Me.checkBox2)
        Me.groupBox9.Controls.Add(Me.checkBox1)
        Me.groupBox9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.groupBox9.Location = New System.Drawing.Point(767, 421)
        Me.groupBox9.Name = "groupBox9"
        Me.groupBox9.Size = New System.Drawing.Size(527, 35)
        Me.groupBox9.TabIndex = 27
        Me.groupBox9.TabStop = False
        Me.groupBox9.Text = "Filtros Exportacion"
        '
        'checkBox2
        '
        Me.checkBox2.AutoSize = True
        Me.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.checkBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.checkBox2.Location = New System.Drawing.Point(73, 14)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(202, 19)
        Me.checkBox2.TabIndex = 34
        Me.checkBox2.Text = "Seleccionar Conceptos a Exportar"
        Me.checkBox2.UseVisualStyleBackColor = True
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.checkBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.checkBox1.Location = New System.Drawing.Point(304, 14)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(204, 19)
        Me.checkBox1.TabIndex = 33
        Me.checkBox1.Text = "Seleccionar Empleados a Exportar"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'button10
        '
        Me.button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button10.Enabled = False
        Me.button10.FlatAppearance.BorderSize = 0
        Me.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.button10.Location = New System.Drawing.Point(1036, 19)
        Me.button10.Name = "button10"
        Me.button10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button10.Size = New System.Drawing.Size(101, 27)
        Me.button10.TabIndex = 32
        Me.button10.Text = "Exportar a Excel"
        Me.button10.UseVisualStyleBackColor = False
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(665, 55)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(16, 13)
        Me.label20.TabIndex = 31
        Me.label20.Text = "..."
        '
        'progressBar2
        '
        Me.progressBar2.Location = New System.Drawing.Point(18, 56)
        Me.progressBar2.Name = "progressBar2"
        Me.progressBar2.Size = New System.Drawing.Size(1276, 10)
        Me.progressBar2.TabIndex = 30
        '
        'groupBox8
        '
        Me.groupBox8.Controls.Add(Me.radioButton2)
        Me.groupBox8.Controls.Add(Me.radioButton1)
        Me.groupBox8.Controls.Add(Me.label19)
        Me.groupBox8.Controls.Add(Me.comboBox8)
        Me.groupBox8.Controls.Add(Me.button14)
        Me.groupBox8.Controls.Add(Me.comboBox7)
        Me.groupBox8.Controls.Add(Me.label18)
        Me.groupBox8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.groupBox8.Location = New System.Drawing.Point(16, 9)
        Me.groupBox8.Name = "groupBox8"
        Me.groupBox8.Size = New System.Drawing.Size(694, 42)
        Me.groupBox8.TabIndex = 27
        Me.groupBox8.TabStop = False
        Me.groupBox8.Text = "Parametros"
        '
        'radioButton2
        '
        Me.radioButton2.AutoSize = True
        Me.radioButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.radioButton2.Location = New System.Drawing.Point(552, 15)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(75, 19)
        Me.radioButton2.TabIndex = 25
        Me.radioButton2.TabStop = True
        Me.radioButton2.Text = "Consultar"
        Me.radioButton2.UseVisualStyleBackColor = True
        '
        'radioButton1
        '
        Me.radioButton1.AutoSize = True
        Me.radioButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.radioButton1.Location = New System.Drawing.Point(482, 15)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(69, 19)
        Me.radioButton1.TabIndex = 24
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Generar "
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label19.Location = New System.Drawing.Point(24, 17)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(110, 15)
        Me.label19.TabIndex = 17
        Me.label19.Text = "Periodo Registrado:"
        '
        'comboBox8
        '
        Me.comboBox8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboBox8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.comboBox8.FormattingEnabled = True
        Me.comboBox8.Location = New System.Drawing.Point(130, 13)
        Me.comboBox8.Name = "comboBox8"
        Me.comboBox8.Size = New System.Drawing.Size(102, 23)
        Me.comboBox8.TabIndex = 16
        '
        'button14
        '
        Me.button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button14.FlatAppearance.BorderSize = 0
        Me.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button14.Image = Global.ImportarExcelSQLServer.Resources.search_white16
        Me.button14.Location = New System.Drawing.Point(639, 11)
        Me.button14.Name = "button14"
        Me.button14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button14.Size = New System.Drawing.Size(27, 27)
        Me.button14.TabIndex = 18
        Me.button14.UseVisualStyleBackColor = False
        '
        'comboBox7
        '
        Me.comboBox7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboBox7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.comboBox7.FormattingEnabled = True
        Me.comboBox7.Items.AddRange(New Object() {"MINDUGAR S.A. - 96588890-K", "MINDUGAR INDUSTRIAL - 83073600-K", "MINDUGAR MONTAJES - 76033420-0"})
        Me.comboBox7.Location = New System.Drawing.Point(301, 13)
        Me.comboBox7.Name = "comboBox7"
        Me.comboBox7.Size = New System.Drawing.Size(155, 23)
        Me.comboBox7.TabIndex = 22
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label18.Location = New System.Drawing.Point(247, 17)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(55, 15)
        Me.label18.TabIndex = 23
        Me.label18.Text = "Empresa:"
        '
        'button11
        '
        Me.button11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button11.BackgroundImage = Global.ImportarExcelSQLServer.Resources.Bnt
        Me.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button11.Image = Global.ImportarExcelSQLServer.Resources._1491870612_icons_user2
        Me.button11.Location = New System.Drawing.Point(1256, 72)
        Me.button11.Name = "button11"
        Me.button11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button11.Size = New System.Drawing.Size(25, 25)
        Me.button11.TabIndex = 29
        Me.button11.UseVisualStyleBackColor = True
        '
        'label16
        '
        Me.label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label16.AutoSize = True
        Me.label16.BackColor = System.Drawing.Color.Transparent
        Me.label16.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.label16.Location = New System.Drawing.Point(15, 422)
        Me.label16.Name = "label16"
        Me.label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label16.Size = New System.Drawing.Size(102, 19)
        Me.label16.TabIndex = 28
        Me.label16.Text = "Total Registros"
        '
        'button12
        '
        Me.button12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button12.FlatAppearance.BorderSize = 0
        Me.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.button12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.button12.Image = Global.ImportarExcelSQLServer.Resources.profile_user_white16
        Me.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button12.Location = New System.Drawing.Point(1143, 19)
        Me.button12.Name = "button12"
        Me.button12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button12.Size = New System.Drawing.Size(138, 27)
        Me.button12.TabIndex = 27
        Me.button12.Text = "Exportar a GESTPER"
        Me.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button12.UseVisualStyleBackColor = False
        '
        'button13
        '
        Me.button13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button13.FlatAppearance.BorderSize = 0
        Me.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button13.Image = Global.ImportarExcelSQLServer.Resources.search_white16
        Me.button13.Location = New System.Drawing.Point(977, 20)
        Me.button13.Name = "button13"
        Me.button13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button13.Size = New System.Drawing.Size(27, 27)
        Me.button13.TabIndex = 25
        Me.button13.UseVisualStyleBackColor = False
        '
        'textBox5
        '
        Me.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.textBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.textBox5.Location = New System.Drawing.Point(869, 23)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(100, 23)
        Me.textBox5.TabIndex = 21
        '
        'label17
        '
        Me.label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label17.AutoSize = True
        Me.label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label17.Location = New System.Drawing.Point(728, 27)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(141, 15)
        Me.label17.TabIndex = 24
        Me.label17.Text = "Rut o Nombre Empleado:"
        '
        'groupBox7
        '
        Me.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.groupBox7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.groupBox7.Location = New System.Drawing.Point(716, 9)
        Me.groupBox7.Name = "groupBox7"
        Me.groupBox7.Size = New System.Drawing.Size(304, 42)
        Me.groupBox7.TabIndex = 26
        Me.groupBox7.TabStop = False
        Me.groupBox7.Text = "FIltros"
        '
        'dataGridView4
        '
        Me.dataGridView4.AllowUserToAddRows = False
        Me.dataGridView4.AllowUserToDeleteRows = False
        Me.dataGridView4.AllowUserToOrderColumns = True
        Me.dataGridView4.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.AliceBlue
        Me.dataGridView4.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dataGridView4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView4.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridView4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.dataGridView4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridView4.DefaultCellStyle = DataGridViewCellStyle15
        Me.dataGridView4.EnableHeadersVisualStyles = False
        Me.dataGridView4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dataGridView4.GridColor = System.Drawing.Color.Gray
        Me.dataGridView4.Location = New System.Drawing.Point(16, 56)
        Me.dataGridView4.MultiSelect = False
        Me.dataGridView4.Name = "dataGridView4"
        Me.dataGridView4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView4.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dataGridView4.RowHeadersVisible = False
        Me.dataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView4.Size = New System.Drawing.Size(1278, 361)
        Me.dataGridView4.TabIndex = 19
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(14, 10)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(206, 21)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Exportar Datos a SQL Server"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1351, 599)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.gradientTab1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextVerSelec.ResumeLayout(False)
        Me.contextOcultarSelec.ResumeLayout(False)
        Me.gradientTab1.ResumeLayout(False)
        Me.tabPage0.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage2.ResumeLayout(False)
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.dataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage3.ResumeLayout(False)
        Me.groupBox6.ResumeLayout(False)
        Me.groupBox6.PerformLayout()
        Me.groupBox9.ResumeLayout(False)
        Me.groupBox9.PerformLayout()
        Me.groupBox8.ResumeLayout(False)
        Me.groupBox8.PerformLayout()
        CType(Me.dataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Friend WithEvents backgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dataGridView2 As MetroFramework.Controls.MetroGrid 'System.Windows.Forms.DataGridView
    Friend WithEvents button4 As System.Windows.Forms.Button
    Friend WithEvents comboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents button5 As System.Windows.Forms.Button
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents button8 As System.Windows.Forms.Button
    Friend WithEvents textBox4 As System.Windows.Forms.TextBox
    Friend WithEvents label12 As System.Windows.Forms.Label
    Friend WithEvents label13 As System.Windows.Forms.Label
    Friend WithEvents comboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents label14 As System.Windows.Forms.Label
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents button3 As System.Windows.Forms.Button
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents textBox2 As System.Windows.Forms.TextBox
    Friend WithEvents dataGridView1 As MetroFramework.Controls.MetroGrid ' System.Windows.Forms.DataGridView
    Friend WithEvents comboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents progressBar1 As MetroFramework.Controls.MetroProgressBar 'System.Windows.Forms.ProgressBar
    Friend WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents label15 As System.Windows.Forms.Label
    Friend WithEvents button9 As System.Windows.Forms.Button
    Friend WithEvents button7 As System.Windows.Forms.Button
    Friend WithEvents textBox3 As System.Windows.Forms.TextBox
    Friend WithEvents label11 As System.Windows.Forms.Label
    Friend WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents comboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dataGridView3 As MetroFramework.Controls.MetroGrid ' System.Windows.Forms.DataGridView
    Friend WithEvents button6 As System.Windows.Forms.Button
    Friend WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents comboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents gradientTab1 As New MetroFramework.Controls.MetroTabControl '_2_Business_Layer.GradientTab
    Friend WithEvents tabPage0 As System.Windows.Forms.TabPage
    Friend WithEvents tabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents backgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents tabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents groupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents label19 As System.Windows.Forms.Label
    Friend WithEvents comboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents button14 As System.Windows.Forms.Button
    Friend WithEvents comboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents label18 As System.Windows.Forms.Label
    Friend WithEvents button11 As System.Windows.Forms.Button
    Friend WithEvents label16 As System.Windows.Forms.Label
    Friend WithEvents button12 As System.Windows.Forms.Button
    Friend WithEvents button13 As System.Windows.Forms.Button
    Friend WithEvents textBox5 As System.Windows.Forms.TextBox
    Friend WithEvents label17 As System.Windows.Forms.Label
    Friend WithEvents groupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents dataGridView4 As MetroFramework.Controls.MetroGrid 'System.Windows.Forms.DataGridView
    Friend WithEvents errorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents radioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents radioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents progressBar2 As MetroFramework.Controls.MetroProgressBar 'System.Windows.Forms.ProgressBar
    Friend WithEvents label20 As System.Windows.Forms.Label
    Friend WithEvents button10 As System.Windows.Forms.Button
    Friend WithEvents progressBar3 As MetroFramework.Controls.MetroProgressBar 'System.Windows.Forms.ProgressBar
    Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents groupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents contextVerSelec As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents contextOcultarSelec As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button15 As Windows.Forms.Button
    Friend WithEvents btnVolver As Windows.Forms.Button 'MetroFramework.Controls.MetroButton 
    Friend WithEvents Label21 As Windows.Forms.Label
    Friend WithEvents MetroProgressSpinner1 As MetroFramework.Controls.MetroProgressSpinner
End Class


#Region "Respaldo Components"

'Partial Class Form1
'    ''' <summary>
'    ''' Variable del diseñador necesaria.
'    ''' </summary>
'    Private components As System.ComponentModel.IContainer = Nothing

'    ''' <summary>
'    ''' Limpiar los recursos que se estén usando.
'    ''' </summary>
'    ''' <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
'    Protected Overrides Sub Dispose(disposing As Boolean)
'        If disposing AndAlso (components IsNot Nothing) Then
'            components.Dispose()
'        End If
'        MyBase.Dispose(disposing)
'    End Sub

'#Region "Código generado por el Diseñador de Windows Forms"

'    ''' <summary>
'    ''' Método necesario para admitir el Diseñador. No se puede modificar
'    ''' el contenido de este método con el editor de código.
'    ''' </summary>
'    Private Sub InitializeComponent()
'        Me.components = New System.ComponentModel.Container()
'        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
'        Dim dataGridViewCellStyle1 As New System.Windows.Forms.DataGridViewCellStyle()
'        Dim dataGridViewCellStyle2 As New System.Windows.Forms.DataGridViewCellStyle()
'        Dim dataGridViewCellStyle3 As New System.Windows.Forms.DataGridViewCellStyle()
'        Dim dataGridViewCellStyle4 As New System.Windows.Forms.DataGridViewCellStyle()
'        Me.backgroundWorker1 = New System.ComponentModel.BackgroundWorker()
'        Me.backgroundWorker2 = New System.ComponentModel.BackgroundWorker()
'        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
'        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
'        Me.contextVerSelec = New System.Windows.Forms.ContextMenuStrip(Me.components)
'        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
'        Me.contextOcultarSelec = New System.Windows.Forms.ContextMenuStrip(Me.components)
'        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
'        Me.gradientTab1 = New ImportarExcelSQLServer._2_Business_Layer.GradientTab()
'        Me.tabPage4 = New System.Windows.Forms.TabPage()
'        Me.groupBox1 = New System.Windows.Forms.GroupBox()
'        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
'        Me.progressBar3 = New System.Windows.Forms.ProgressBar()
'        Me.label6 = New System.Windows.Forms.Label()
'        Me.label7 = New System.Windows.Forms.Label()
'        Me.button3 = New System.Windows.Forms.Button()
'        Me.label5 = New System.Windows.Forms.Label()
'        Me.textBox2 = New System.Windows.Forms.TextBox()
'        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
'        Me.comboBox2 = New System.Windows.Forms.ComboBox()
'        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
'        Me.comboBox1 = New System.Windows.Forms.ComboBox()
'        Me.label4 = New System.Windows.Forms.Label()
'        Me.textBox1 = New System.Windows.Forms.TextBox()
'        Me.label1 = New System.Windows.Forms.Label()
'        Me.button2 = New System.Windows.Forms.Button()
'        Me.button1 = New System.Windows.Forms.Button()
'        Me.label3 = New System.Windows.Forms.Label()
'        Me.label2 = New System.Windows.Forms.Label()
'        Me.tabPage5 = New System.Windows.Forms.TabPage()
'        Me.groupBox2 = New System.Windows.Forms.GroupBox()
'        Me.label14 = New System.Windows.Forms.Label()
'        Me.button8 = New System.Windows.Forms.Button()
'        Me.textBox4 = New System.Windows.Forms.TextBox()
'        Me.label12 = New System.Windows.Forms.Label()
'        Me.label13 = New System.Windows.Forms.Label()
'        Me.comboBox6 = New System.Windows.Forms.ComboBox()
'        Me.groupBox5 = New System.Windows.Forms.GroupBox()
'        Me.button5 = New System.Windows.Forms.Button()
'        Me.dataGridView2 = New System.Windows.Forms.DataGridView()
'        Me.button4 = New System.Windows.Forms.Button()
'        Me.label8 = New System.Windows.Forms.Label()
'        Me.comboBox3 = New System.Windows.Forms.ComboBox()
'        Me.tabPage6 = New System.Windows.Forms.TabPage()
'        Me.groupBox3 = New System.Windows.Forms.GroupBox()
'        Me.label15 = New System.Windows.Forms.Label()
'        Me.button9 = New System.Windows.Forms.Button()
'        Me.button7 = New System.Windows.Forms.Button()
'        Me.textBox3 = New System.Windows.Forms.TextBox()
'        Me.label11 = New System.Windows.Forms.Label()
'        Me.label10 = New System.Windows.Forms.Label()
'        Me.comboBox5 = New System.Windows.Forms.ComboBox()
'        Me.groupBox4 = New System.Windows.Forms.GroupBox()
'        Me.dataGridView3 = New System.Windows.Forms.DataGridView()
'        Me.button6 = New System.Windows.Forms.Button()
'        Me.label9 = New System.Windows.Forms.Label()
'        Me.comboBox4 = New System.Windows.Forms.ComboBox()
'        Me.tabPage1 = New System.Windows.Forms.TabPage()
'        Me.groupBox6 = New System.Windows.Forms.GroupBox()
'        Me.groupBox9 = New System.Windows.Forms.GroupBox()
'        Me.checkBox2 = New System.Windows.Forms.CheckBox()
'        Me.checkBox1 = New System.Windows.Forms.CheckBox()
'        Me.button10 = New System.Windows.Forms.Button()
'        Me.label20 = New System.Windows.Forms.Label()
'        Me.progressBar2 = New System.Windows.Forms.ProgressBar()
'        Me.groupBox8 = New System.Windows.Forms.GroupBox()
'        Me.radioButton2 = New System.Windows.Forms.RadioButton()
'        Me.radioButton1 = New System.Windows.Forms.RadioButton()
'        Me.label19 = New System.Windows.Forms.Label()
'        Me.comboBox8 = New System.Windows.Forms.ComboBox()
'        Me.button14 = New System.Windows.Forms.Button()
'        Me.comboBox7 = New System.Windows.Forms.ComboBox()
'        Me.label18 = New System.Windows.Forms.Label()
'        Me.button11 = New System.Windows.Forms.Button()
'        Me.label16 = New System.Windows.Forms.Label()
'        Me.button12 = New System.Windows.Forms.Button()
'        Me.button13 = New System.Windows.Forms.Button()
'        Me.textBox5 = New System.Windows.Forms.TextBox()
'        Me.label17 = New System.Windows.Forms.Label()
'        Me.groupBox7 = New System.Windows.Forms.GroupBox()
'        Me.dataGridView4 = New System.Windows.Forms.DataGridView()
'        DirectCast(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.contextVerSelec.SuspendLayout()
'        Me.contextOcultarSelec.SuspendLayout()
'        Me.gradientTab1.SuspendLayout()
'        Me.tabPage4.SuspendLayout()
'        Me.groupBox1.SuspendLayout()
'        DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
'        DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.tabPage5.SuspendLayout()
'        Me.groupBox2.SuspendLayout()
'        DirectCast(Me.dataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.tabPage6.SuspendLayout()
'        Me.groupBox3.SuspendLayout()
'        DirectCast(Me.dataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.tabPage1.SuspendLayout()
'        Me.groupBox6.SuspendLayout()
'        Me.groupBox9.SuspendLayout()
'        Me.groupBox8.SuspendLayout()
'        DirectCast(Me.dataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.SuspendLayout()
'        ' 
'        ' backgroundWorker1
'        ' 
'        Me.backgroundWorker1.WorkerReportsProgress = True
'        AddHandler Me.backgroundWorker1.DoWork, New System.ComponentModel.DoWorkEventHandler(AddressOf Me.backgroundWorker1_DoWork)
'        AddHandler Me.backgroundWorker1.ProgressChanged, New System.ComponentModel.ProgressChangedEventHandler(AddressOf Me.backgroundWorker1_ProgressChanged)
'        ' 
'        ' backgroundWorker2
'        ' 
'        Me.backgroundWorker2.WorkerSupportsCancellation = True
'        AddHandler Me.backgroundWorker2.DoWork, New System.ComponentModel.DoWorkEventHandler(AddressOf Me.backgroundWorker2_DoWork)
'        AddHandler Me.backgroundWorker2.ProgressChanged, New System.ComponentModel.ProgressChangedEventHandler(AddressOf Me.backgroundWorker2_ProgressChanged)
'        AddHandler Me.backgroundWorker2.RunWorkerCompleted, New System.ComponentModel.RunWorkerCompletedEventHandler(AddressOf Me.backgroundWorker2_RunWorkerCompleted)
'        ' 
'        ' errorIcono
'        ' 
'        Me.errorIcono.ContainerControl = Me
'        ' 
'        ' contextVerSelec
'        ' 
'        Me.contextVerSelec.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1})
'        Me.contextVerSelec.Name = "contextVerSelec"
'        Me.contextVerSelec.Size = New System.Drawing.Size(230, 26)
'        ' 
'        ' toolStripMenuItem1
'        ' 
'        Me.toolStripMenuItem1.Image = Global.ImportarExcelSQLServer.Resources.magnifier_zoom_in
'        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
'        Me.toolStripMenuItem1.Size = New System.Drawing.Size(229, 22)
'        Me.toolStripMenuItem1.Text = "Mostrar Todos los Empleados"
'        AddHandler Me.toolStripMenuItem1.Click, New System.EventHandler(AddressOf Me.toolStripMenuItem1_Click)
'        ' 
'        ' contextOcultarSelec
'        ' 
'        Me.contextOcultarSelec.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem2})
'        Me.contextOcultarSelec.Name = "contextOcultarSelec"
'        Me.contextOcultarSelec.Size = New System.Drawing.Size(274, 26)
'        ' 
'        ' toolStripMenuItem2
'        ' 
'        Me.toolStripMenuItem2.Image = Global.ImportarExcelSQLServer.Resources.magifier_zoom_out
'        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
'        Me.toolStripMenuItem2.Size = New System.Drawing.Size(273, 22)
'        Me.toolStripMenuItem2.Text = "Ocultar Empleados NO Seleccionados"
'        AddHandler Me.toolStripMenuItem2.Click, New System.EventHandler(AddressOf Me.toolStripMenuItem2_Click)
'        ' 
'        ' gradientTab1
'        ' 
'        Me.gradientTab1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.gradientTab1.Controls.Add(Me.tabPage4)
'        Me.gradientTab1.Controls.Add(Me.tabPage5)
'        Me.gradientTab1.Controls.Add(Me.tabPage6)
'        Me.gradientTab1.Controls.Add(Me.tabPage1)
'        Me.gradientTab1.Location = New System.Drawing.Point(12, 12)
'        Me.gradientTab1.Name = "gradientTab1"
'        Me.gradientTab1.PageEndColor = System.Drawing.Color.Empty
'        Me.gradientTab1.PageStartColor = System.Drawing.Color.Empty
'        Me.gradientTab1.SelectedIndex = 0
'        Me.gradientTab1.Size = New System.Drawing.Size(1333, 640)
'        Me.gradientTab1.TabIndex = 9
'        ' 
'        ' tabPage4
'        ' 
'        Me.tabPage4.BackgroundImage = DirectCast(resources.GetObject("tabPage4.BackgroundImage"), System.Drawing.Image)
'        Me.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.tabPage4.Controls.Add(Me.groupBox1)
'        Me.tabPage4.Location = New System.Drawing.Point(4, 22)
'        Me.tabPage4.Name = "tabPage4"
'        Me.tabPage4.Padding = New System.Windows.Forms.Padding(3)
'        Me.tabPage4.Size = New System.Drawing.Size(1325, 614)
'        Me.tabPage4.TabIndex = 0
'        Me.tabPage4.Text = "Importar Excel"
'        Me.tabPage4.UseVisualStyleBackColor = True
'        ' 
'        ' groupBox1
'        ' 
'        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
'        Me.groupBox1.Controls.Add(Me.pictureBox1)
'        Me.groupBox1.Controls.Add(Me.progressBar3)
'        Me.groupBox1.Controls.Add(Me.label6)
'        Me.groupBox1.Controls.Add(Me.label7)
'        Me.groupBox1.Controls.Add(Me.button3)
'        Me.groupBox1.Controls.Add(Me.label5)
'        Me.groupBox1.Controls.Add(Me.textBox2)
'        Me.groupBox1.Controls.Add(Me.dataGridView1)
'        Me.groupBox1.Controls.Add(Me.comboBox2)
'        Me.groupBox1.Controls.Add(Me.progressBar1)
'        Me.groupBox1.Controls.Add(Me.comboBox1)
'        Me.groupBox1.Controls.Add(Me.label4)
'        Me.groupBox1.Controls.Add(Me.textBox1)
'        Me.groupBox1.Controls.Add(Me.label1)
'        Me.groupBox1.Controls.Add(Me.button2)
'        Me.groupBox1.Controls.Add(Me.button1)
'        Me.groupBox1.Controls.Add(Me.label3)
'        Me.groupBox1.Controls.Add(Me.label2)
'        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
'        Me.groupBox1.Location = New System.Drawing.Point(3, 3)
'        Me.groupBox1.Name = "groupBox1"
'        Me.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.groupBox1.Size = New System.Drawing.Size(1319, 608)
'        Me.groupBox1.TabIndex = 7
'        Me.groupBox1.TabStop = False
'        ' 
'        ' pictureBox1
'        ' 
'        Me.pictureBox1.Image = Global.ImportarExcelSQLServer.Resources.Loader
'        Me.pictureBox1.Location = New System.Drawing.Point(78, 5)
'        Me.pictureBox1.Name = "pictureBox1"
'        Me.pictureBox1.Size = New System.Drawing.Size(30, 30)
'        Me.pictureBox1.TabIndex = 19
'        Me.pictureBox1.TabStop = False
'        ' 
'        ' progressBar3
'        ' 
'        Me.progressBar3.Location = New System.Drawing.Point(113, 59)
'        Me.progressBar3.Name = "progressBar3"
'        Me.progressBar3.Size = New System.Drawing.Size(436, 14)
'        Me.progressBar3.TabIndex = 18
'        ' 
'        ' label6
'        ' 
'        Me.label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.label6.AutoSize = True
'        Me.label6.BackColor = System.Drawing.Color.Transparent
'        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
'        Me.label6.Location = New System.Drawing.Point(110, 15)
'        Me.label6.Name = "label6"
'        Me.label6.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.label6.Size = New System.Drawing.Size(19, 13)
'        Me.label6.TabIndex = 15
'        Me.label6.Text = "..."
'        ' 
'        ' label7
'        ' 
'        Me.label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
'        Me.label7.AutoSize = True
'        Me.label7.BackColor = System.Drawing.Color.Transparent
'        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
'        Me.label7.Location = New System.Drawing.Point(15, 586)
'        Me.label7.Name = "label7"
'        Me.label7.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.label7.Size = New System.Drawing.Size(104, 15)
'        Me.label7.TabIndex = 16
'        Me.label7.Text = "Total Registros"
'        ' 
'        ' button3
'        ' 
'        Me.button3.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.button3.BackgroundImage = Global.ImportarExcelSQLServer.Resources.Bnt
'        Me.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.button3.Image = Global.ImportarExcelSQLServer.Resources.LupaP2
'        Me.button3.Location = New System.Drawing.Point(962, 33)
'        Me.button3.Name = "button3"
'        Me.button3.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.button3.Size = New System.Drawing.Size(25, 23)
'        Me.button3.TabIndex = 14
'        Me.button3.Text = "..."
'        Me.button3.UseVisualStyleBackColor = True
'        AddHandler Me.button3.Click, New System.EventHandler(AddressOf Me.button3_Click)
'        ' 
'        ' label5
'        ' 
'        Me.label5.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.label5.AutoSize = True
'        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
'        Me.label5.Location = New System.Drawing.Point(861, 15)
'        Me.label5.Name = "label5"
'        Me.label5.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.label5.Size = New System.Drawing.Size(92, 13)
'        Me.label5.TabIndex = 13
'        Me.label5.Text = "- Buscar RUT -"
'        ' 
'        ' textBox2
'        ' 
'        Me.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.textBox2.Location = New System.Drawing.Point(858, 35)
'        Me.textBox2.Name = "textBox2"
'        Me.textBox2.Size = New System.Drawing.Size(100, 20)
'        Me.textBox2.TabIndex = 12
'        ' 
'        ' dataGridView1
'        ' 
'        Me.dataGridView1.AllowUserToAddRows = False
'        Me.dataGridView1.AllowUserToDeleteRows = False
'        Me.dataGridView1.AllowUserToOrderColumns = True
'        Me.dataGridView1.AllowUserToResizeColumns = False
'        Me.dataGridView1.AllowUserToResizeRows = False
'        Me.dataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
'        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
'        dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
'        dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
'        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
'        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold
'        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
'        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
'        Me.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1
'        Me.dataGridView1.Location = New System.Drawing.Point(15, 77)
'        Me.dataGridView1.MultiSelect = False
'        Me.dataGridView1.Name = "dataGridView1"
'        Me.dataGridView1.[ReadOnly] = True
'        Me.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.dataGridView1.RowHeadersVisible = False
'        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
'        Me.dataGridView1.Size = New System.Drawing.Size(1278, 506)
'        Me.dataGridView1.TabIndex = 7
'        ' 
'        ' comboBox2
'        ' 
'        Me.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.comboBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
'        Me.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.comboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
'        Me.comboBox2.FormattingEnabled = True
'        Me.comboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6",
'            "7", "8", "9", "10", "11", "12"})
'        Me.comboBox2.Location = New System.Drawing.Point(754, 33)
'        Me.comboBox2.Name = "comboBox2"
'        Me.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.comboBox2.Size = New System.Drawing.Size(52, 23)
'        Me.comboBox2.TabIndex = 11
'        ' 
'        ' progressBar1
'        ' 
'        Me.progressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.progressBar1.Location = New System.Drawing.Point(15, 59)
'        Me.progressBar1.Name = "progressBar1"
'        Me.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.progressBar1.Size = New System.Drawing.Size(1278, 14)
'        Me.progressBar1.TabIndex = 4
'        ' 
'        ' comboBox1
'        ' 
'        Me.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.comboBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
'        Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.comboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
'        Me.comboBox1.FormattingEnabled = True
'        Me.comboBox1.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022",
'            "2023", "2024", "2025"})
'        Me.comboBox1.Location = New System.Drawing.Point(643, 33)
'        Me.comboBox1.Name = "comboBox1"
'        Me.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.comboBox1.Size = New System.Drawing.Size(65, 23)
'        Me.comboBox1.TabIndex = 10
'        ' 
'        ' label4
'        ' 
'        Me.label4.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.label4.AutoSize = True
'        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
'        Me.label4.Location = New System.Drawing.Point(681, 15)
'        Me.label4.Name = "label4"
'        Me.label4.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.label4.Size = New System.Drawing.Size(66, 13)
'        Me.label4.TabIndex = 3
'        Me.label4.Text = "- Periodo -"
'        ' 
'        ' textBox1
'        ' 
'        Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
'        Me.textBox1.Enabled = False
'        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
'        Me.textBox1.Location = New System.Drawing.Point(113, 34)
'        Me.textBox1.Name = "textBox1"
'        Me.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.textBox1.Size = New System.Drawing.Size(436, 21)
'        Me.textBox1.TabIndex = 9
'        ' 
'        ' label1
'        ' 
'        Me.label1.AutoSize = True
'        Me.label1.BackColor = System.Drawing.Color.Transparent
'        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
'        Me.label1.Location = New System.Drawing.Point(15, 36)
'        Me.label1.Name = "label1"
'        Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.label1.Size = New System.Drawing.Size(96, 15)
'        Me.label1.TabIndex = 8
'        Me.label1.Text = "Archivo Excel:"
'        ' 
'        ' button2
'        ' 
'        Me.button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.button2.BackgroundImage = Global.ImportarExcelSQLServer.Resources.Bnt
'        Me.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.button2.Enabled = False
'        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.button2.Location = New System.Drawing.Point(1130, 33)
'        Me.button2.Name = "button2"
'        Me.button2.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.button2.Size = New System.Drawing.Size(163, 23)
'        Me.button2.TabIndex = 2
'        Me.button2.Text = "Exportar a SQL"
'        Me.button2.UseVisualStyleBackColor = True
'        AddHandler Me.button2.Click, New System.EventHandler(AddressOf Me.button2_Click_1)
'        ' 
'        ' button1
'        ' 
'        Me.button1.BackgroundImage = Global.ImportarExcelSQLServer.Resources.Bnt
'        Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.button1.Location = New System.Drawing.Point(555, 33)
'        Me.button1.Name = "button1"
'        Me.button1.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.button1.Size = New System.Drawing.Size(25, 23)
'        Me.button1.TabIndex = 7
'        Me.button1.Text = "..."
'        Me.button1.UseVisualStyleBackColor = True
'        AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click_1)
'        ' 
'        ' label3
'        ' 
'        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.label3.AutoSize = True
'        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
'        Me.label3.Location = New System.Drawing.Point(717, 37)
'        Me.label3.Name = "label3"
'        Me.label3.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.label3.Size = New System.Drawing.Size(38, 15)
'        Me.label3.TabIndex = 1
'        Me.label3.Text = "Mes:"
'        ' 
'        ' label2
'        ' 
'        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.label2.AutoSize = True
'        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
'        Me.label2.Location = New System.Drawing.Point(608, 36)
'        Me.label2.Name = "label2"
'        Me.label2.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.label2.Size = New System.Drawing.Size(35, 15)
'        Me.label2.TabIndex = 0
'        Me.label2.Text = "Año:"
'        ' 
'        ' tabPage5
'        ' 
'        Me.tabPage5.BackgroundImage = DirectCast(resources.GetObject("tabPage5.BackgroundImage"), System.Drawing.Image)
'        Me.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.tabPage5.Controls.Add(Me.groupBox2)
'        Me.tabPage5.Location = New System.Drawing.Point(4, 22)
'        Me.tabPage5.Name = "tabPage5"
'        Me.tabPage5.Padding = New System.Windows.Forms.Padding(3)
'        Me.tabPage5.Size = New System.Drawing.Size(1325, 614)
'        Me.tabPage5.TabIndex = 1
'        Me.tabPage5.Text = "Consultar Asistencias"
'        Me.tabPage5.UseVisualStyleBackColor = True
'        ' 
'        ' groupBox2
'        ' 
'        Me.groupBox2.Controls.Add(Me.label14)
'        Me.groupBox2.Controls.Add(Me.button8)
'        Me.groupBox2.Controls.Add(Me.textBox4)
'        Me.groupBox2.Controls.Add(Me.label12)
'        Me.groupBox2.Controls.Add(Me.label13)
'        Me.groupBox2.Controls.Add(Me.comboBox6)
'        Me.groupBox2.Controls.Add(Me.groupBox5)
'        Me.groupBox2.Controls.Add(Me.button5)
'        Me.groupBox2.Controls.Add(Me.dataGridView2)
'        Me.groupBox2.Controls.Add(Me.button4)
'        Me.groupBox2.Controls.Add(Me.label8)
'        Me.groupBox2.Controls.Add(Me.comboBox3)
'        Me.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill
'        Me.groupBox2.Location = New System.Drawing.Point(3, 3)
'        Me.groupBox2.Name = "groupBox2"
'        Me.groupBox2.Size = New System.Drawing.Size(1319, 608)
'        Me.groupBox2.TabIndex = 0
'        Me.groupBox2.TabStop = False
'        ' 
'        ' label14
'        ' 
'        Me.label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
'        Me.label14.AutoSize = True
'        Me.label14.BackColor = System.Drawing.Color.Transparent
'        Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
'        Me.label14.Location = New System.Drawing.Point(15, 586)
'        Me.label14.Name = "label14"
'        Me.label14.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.label14.Size = New System.Drawing.Size(104, 15)
'        Me.label14.TabIndex = 27
'        Me.label14.Text = "Total Registros"
'        ' 
'        ' button8
'        ' 
'        Me.button8.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.button8.BackgroundImage = Global.ImportarExcelSQLServer.Resources.Bnt
'        Me.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.button8.Image = Global.ImportarExcelSQLServer.Resources.LupaP2
'        Me.button8.Location = New System.Drawing.Point(854, 21)
'        Me.button8.Name = "button8"
'        Me.button8.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.button8.Size = New System.Drawing.Size(25, 23)
'        Me.button8.TabIndex = 25
'        Me.button8.Text = "..."
'        Me.button8.UseVisualStyleBackColor = True
'        AddHandler Me.button8.Click, New System.EventHandler(AddressOf Me.button8_Click)
'        ' 
'        ' textBox4
'        ' 
'        Me.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.textBox4.Location = New System.Drawing.Point(746, 23)
'        Me.textBox4.Name = "textBox4"
'        Me.textBox4.Size = New System.Drawing.Size(100, 20)
'        Me.textBox4.TabIndex = 21
'        ' 
'        ' label12
'        ' 
'        Me.label12.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.label12.AutoSize = True
'        Me.label12.Location = New System.Drawing.Point(615, 27)
'        Me.label12.Name = "label12"
'        Me.label12.Size = New System.Drawing.Size(126, 13)
'        Me.label12.TabIndex = 24
'        Me.label12.Text = "Rut o Nombre Empleado:"
'        ' 
'        ' label13
'        ' 
'        Me.label13.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.label13.AutoSize = True
'        Me.label13.Location = New System.Drawing.Point(383, 28)
'        Me.label13.Name = "label13"
'        Me.label13.Size = New System.Drawing.Size(51, 13)
'        Me.label13.TabIndex = 23
'        Me.label13.Text = "Empresa:"
'        ' 
'        ' comboBox6
'        ' 
'        Me.comboBox6.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.comboBox6.BackColor = System.Drawing.SystemColors.ControlLightLight
'        Me.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.comboBox6.FormattingEnabled = True
'        Me.comboBox6.Location = New System.Drawing.Point(444, 24)
'        Me.comboBox6.Name = "comboBox6"
'        Me.comboBox6.Size = New System.Drawing.Size(155, 21)
'        Me.comboBox6.TabIndex = 22
'        ' 
'        ' groupBox5
'        ' 
'        Me.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.groupBox5.Location = New System.Drawing.Point(340, 9)
'        Me.groupBox5.Name = "groupBox5"
'        Me.groupBox5.Size = New System.Drawing.Size(557, 42)
'        Me.groupBox5.TabIndex = 26
'        Me.groupBox5.TabStop = False
'        Me.groupBox5.Text = "FIltros"
'        ' 
'        ' button5
'        ' 
'        Me.button5.BackgroundImage = Global.ImportarExcelSQLServer.Resources.Bnt
'        Me.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.button5.Image = Global.ImportarExcelSQLServer.Resources.LupaP2
'        Me.button5.Location = New System.Drawing.Point(229, 19)
'        Me.button5.Name = "button5"
'        Me.button5.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.button5.Size = New System.Drawing.Size(25, 23)
'        Me.button5.TabIndex = 15
'        Me.button5.Text = "..."
'        Me.button5.UseVisualStyleBackColor = True
'        AddHandler Me.button5.Click, New System.EventHandler(AddressOf Me.button5_Click)
'        ' 
'        ' dataGridView2
'        ' 
'        Me.dataGridView2.AllowUserToAddRows = False
'        Me.dataGridView2.AllowUserToDeleteRows = False
'        Me.dataGridView2.AllowUserToOrderColumns = True
'        Me.dataGridView2.AllowUserToResizeRows = False
'        Me.dataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
'        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
'        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
'        dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
'        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
'        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold
'        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
'        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
'        Me.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2
'        Me.dataGridView2.Location = New System.Drawing.Point(16, 56)
'        Me.dataGridView2.MultiSelect = False
'        Me.dataGridView2.Name = "dataGridView2"
'        Me.dataGridView2.[ReadOnly] = True
'        Me.dataGridView2.RowHeadersVisible = False
'        Me.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
'        Me.dataGridView2.Size = New System.Drawing.Size(1278, 527)
'        Me.dataGridView2.TabIndex = 5
'        ' 
'        ' button4
'        ' 
'        Me.button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.button4.BackgroundImage = Global.ImportarExcelSQLServer.Resources.Bnt
'        Me.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.button4.Enabled = False
'        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.button4.Location = New System.Drawing.Point(1190, 21)
'        Me.button4.Name = "button4"
'        Me.button4.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.button4.Size = New System.Drawing.Size(101, 23)
'        Me.button4.TabIndex = 3
'        Me.button4.Text = "Exportar a Excel"
'        Me.button4.UseVisualStyleBackColor = True
'        AddHandler Me.button4.Click, New System.EventHandler(AddressOf Me.button4_Click)
'        ' 
'        ' label8
'        ' 
'        Me.label8.AutoSize = True
'        Me.label8.Location = New System.Drawing.Point(16, 23)
'        Me.label8.Name = "label8"
'        Me.label8.Size = New System.Drawing.Size(100, 13)
'        Me.label8.TabIndex = 1
'        Me.label8.Text = "Periodo Registrado:"
'        ' 
'        ' comboBox3
'        ' 
'        Me.comboBox3.BackColor = System.Drawing.SystemColors.ControlLightLight
'        Me.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.comboBox3.FormattingEnabled = True
'        Me.comboBox3.Location = New System.Drawing.Point(122, 20)
'        Me.comboBox3.Name = "comboBox3"
'        Me.comboBox3.Size = New System.Drawing.Size(102, 21)
'        Me.comboBox3.TabIndex = 0
'        ' 
'        ' tabPage6
'        ' 
'        Me.tabPage6.BackgroundImage = DirectCast(resources.GetObject("tabPage6.BackgroundImage"), System.Drawing.Image)
'        Me.tabPage6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.tabPage6.Controls.Add(Me.groupBox3)
'        Me.tabPage6.Location = New System.Drawing.Point(4, 22)
'        Me.tabPage6.Name = "tabPage6"
'        Me.tabPage6.Padding = New System.Windows.Forms.Padding(3)
'        Me.tabPage6.Size = New System.Drawing.Size(1325, 614)
'        Me.tabPage6.TabIndex = 2
'        Me.tabPage6.Text = "Consultar Resumen"
'        Me.tabPage6.UseVisualStyleBackColor = True
'        ' 
'        ' groupBox3
'        ' 
'        Me.groupBox3.Controls.Add(Me.label15)
'        Me.groupBox3.Controls.Add(Me.button9)
'        Me.groupBox3.Controls.Add(Me.button7)
'        Me.groupBox3.Controls.Add(Me.textBox3)
'        Me.groupBox3.Controls.Add(Me.label11)
'        Me.groupBox3.Controls.Add(Me.label10)
'        Me.groupBox3.Controls.Add(Me.comboBox5)
'        Me.groupBox3.Controls.Add(Me.groupBox4)
'        Me.groupBox3.Controls.Add(Me.dataGridView3)
'        Me.groupBox3.Controls.Add(Me.button6)
'        Me.groupBox3.Controls.Add(Me.label9)
'        Me.groupBox3.Controls.Add(Me.comboBox4)
'        Me.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill
'        Me.groupBox3.Location = New System.Drawing.Point(3, 3)
'        Me.groupBox3.Name = "groupBox3"
'        Me.groupBox3.Size = New System.Drawing.Size(1319, 608)
'        Me.groupBox3.TabIndex = 0
'        Me.groupBox3.TabStop = False
'        ' 
'        ' label15
'        ' 
'        Me.label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
'        Me.label15.AutoSize = True
'        Me.label15.BackColor = System.Drawing.Color.Transparent
'        Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
'        Me.label15.Location = New System.Drawing.Point(15, 586)
'        Me.label15.Name = "label15"
'        Me.label15.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.label15.Size = New System.Drawing.Size(104, 15)
'        Me.label15.TabIndex = 28
'        Me.label15.Text = "Total Registros"
'        ' 
'        ' button9
'        ' 
'        Me.button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.button9.BackgroundImage = Global.ImportarExcelSQLServer.Resources.Bnt
'        Me.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.button9.Enabled = False
'        Me.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.button9.Location = New System.Drawing.Point(1190, 21)
'        Me.button9.Name = "button9"
'        Me.button9.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.button9.Size = New System.Drawing.Size(101, 23)
'        Me.button9.TabIndex = 27
'        Me.button9.Text = "Exportar a Excel"
'        Me.button9.UseVisualStyleBackColor = True
'        AddHandler Me.button9.Click, New System.EventHandler(AddressOf Me.button9_Click)
'        ' 
'        ' button7
'        ' 
'        Me.button7.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.button7.BackgroundImage = Global.ImportarExcelSQLServer.Resources.Bnt
'        Me.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.button7.Image = Global.ImportarExcelSQLServer.Resources.LupaP2
'        Me.button7.Location = New System.Drawing.Point(854, 21)
'        Me.button7.Name = "button7"
'        Me.button7.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.button7.Size = New System.Drawing.Size(25, 23)
'        Me.button7.TabIndex = 25
'        Me.button7.Text = "..."
'        Me.button7.UseVisualStyleBackColor = True
'        AddHandler Me.button7.Click, New System.EventHandler(AddressOf Me.button7_Click)
'        ' 
'        ' textBox3
'        ' 
'        Me.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.textBox3.Location = New System.Drawing.Point(746, 23)
'        Me.textBox3.Name = "textBox3"
'        Me.textBox3.Size = New System.Drawing.Size(100, 20)
'        Me.textBox3.TabIndex = 21
'        ' 
'        ' label11
'        ' 
'        Me.label11.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.label11.AutoSize = True
'        Me.label11.Location = New System.Drawing.Point(615, 27)
'        Me.label11.Name = "label11"
'        Me.label11.Size = New System.Drawing.Size(126, 13)
'        Me.label11.TabIndex = 24
'        Me.label11.Text = "Rut o Nombre Empleado:"
'        ' 
'        ' label10
'        ' 
'        Me.label10.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.label10.AutoSize = True
'        Me.label10.Location = New System.Drawing.Point(383, 28)
'        Me.label10.Name = "label10"
'        Me.label10.Size = New System.Drawing.Size(51, 13)
'        Me.label10.TabIndex = 23
'        Me.label10.Text = "Empresa:"
'        ' 
'        ' comboBox5
'        ' 
'        Me.comboBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.comboBox5.BackColor = System.Drawing.SystemColors.ControlLightLight
'        Me.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.comboBox5.FormattingEnabled = True
'        Me.comboBox5.Location = New System.Drawing.Point(444, 24)
'        Me.comboBox5.Name = "comboBox5"
'        Me.comboBox5.Size = New System.Drawing.Size(155, 21)
'        Me.comboBox5.TabIndex = 22
'        ' 
'        ' groupBox4
'        ' 
'        Me.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.groupBox4.Location = New System.Drawing.Point(340, 9)
'        Me.groupBox4.Name = "groupBox4"
'        Me.groupBox4.Size = New System.Drawing.Size(557, 42)
'        Me.groupBox4.TabIndex = 26
'        Me.groupBox4.TabStop = False
'        Me.groupBox4.Text = "FIltros"
'        ' 
'        ' dataGridView3
'        ' 
'        Me.dataGridView3.AllowUserToAddRows = False
'        Me.dataGridView3.AllowUserToDeleteRows = False
'        Me.dataGridView3.AllowUserToOrderColumns = True
'        Me.dataGridView3.AllowUserToResizeRows = False
'        Me.dataGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
'        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
'        dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
'        dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
'        dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
'        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold
'        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
'        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
'        Me.dataGridView3.DefaultCellStyle = dataGridViewCellStyle3
'        Me.dataGridView3.Location = New System.Drawing.Point(16, 56)
'        Me.dataGridView3.MultiSelect = False
'        Me.dataGridView3.Name = "dataGridView3"
'        Me.dataGridView3.[ReadOnly] = True
'        Me.dataGridView3.RowHeadersVisible = False
'        Me.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
'        Me.dataGridView3.Size = New System.Drawing.Size(1278, 527)
'        Me.dataGridView3.TabIndex = 19
'        ' 
'        ' button6
'        ' 
'        Me.button6.BackgroundImage = Global.ImportarExcelSQLServer.Resources.Bnt
'        Me.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.button6.Image = Global.ImportarExcelSQLServer.Resources.LupaP2
'        Me.button6.Location = New System.Drawing.Point(229, 19)
'        Me.button6.Name = "button6"
'        Me.button6.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.button6.Size = New System.Drawing.Size(25, 23)
'        Me.button6.TabIndex = 18
'        Me.button6.Text = "..."
'        Me.button6.UseVisualStyleBackColor = True
'        AddHandler Me.button6.Click, New System.EventHandler(AddressOf Me.button6_Click)
'        ' 
'        ' label9
'        ' 
'        Me.label9.AutoSize = True
'        Me.label9.Location = New System.Drawing.Point(16, 23)
'        Me.label9.Name = "label9"
'        Me.label9.Size = New System.Drawing.Size(100, 13)
'        Me.label9.TabIndex = 17
'        Me.label9.Text = "Periodo Registrado:"
'        ' 
'        ' comboBox4
'        ' 
'        Me.comboBox4.BackColor = System.Drawing.SystemColors.ControlLightLight
'        Me.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.comboBox4.FormattingEnabled = True
'        Me.comboBox4.Location = New System.Drawing.Point(122, 20)
'        Me.comboBox4.Name = "comboBox4"
'        Me.comboBox4.Size = New System.Drawing.Size(102, 21)
'        Me.comboBox4.TabIndex = 16
'        ' 
'        ' tabPage1
'        ' 
'        Me.tabPage1.BackgroundImage = DirectCast(resources.GetObject("tabPage1.BackgroundImage"), System.Drawing.Image)
'        Me.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.tabPage1.Controls.Add(Me.groupBox6)
'        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
'        Me.tabPage1.Name = "tabPage1"
'        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
'        Me.tabPage1.Size = New System.Drawing.Size(1325, 614)
'        Me.tabPage1.TabIndex = 3
'        Me.tabPage1.Text = "GESTPER"
'        Me.tabPage1.UseVisualStyleBackColor = True
'        ' 
'        ' groupBox6
'        ' 
'        Me.groupBox6.Controls.Add(Me.groupBox9)
'        Me.groupBox6.Controls.Add(Me.button10)
'        Me.groupBox6.Controls.Add(Me.label20)
'        Me.groupBox6.Controls.Add(Me.progressBar2)
'        Me.groupBox6.Controls.Add(Me.groupBox8)
'        Me.groupBox6.Controls.Add(Me.button11)
'        Me.groupBox6.Controls.Add(Me.label16)
'        Me.groupBox6.Controls.Add(Me.button12)
'        Me.groupBox6.Controls.Add(Me.button13)
'        Me.groupBox6.Controls.Add(Me.textBox5)
'        Me.groupBox6.Controls.Add(Me.label17)
'        Me.groupBox6.Controls.Add(Me.groupBox7)
'        Me.groupBox6.Controls.Add(Me.dataGridView4)
'        Me.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill
'        Me.groupBox6.Location = New System.Drawing.Point(3, 3)
'        Me.groupBox6.Name = "groupBox6"
'        Me.groupBox6.Size = New System.Drawing.Size(1319, 608)
'        Me.groupBox6.TabIndex = 1
'        Me.groupBox6.TabStop = False
'        ' 
'        ' groupBox9
'        ' 
'        Me.groupBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.groupBox9.Controls.Add(Me.checkBox2)
'        Me.groupBox9.Controls.Add(Me.checkBox1)
'        Me.groupBox9.Location = New System.Drawing.Point(767, 571)
'        Me.groupBox9.Name = "groupBox9"
'        Me.groupBox9.Size = New System.Drawing.Size(527, 33)
'        Me.groupBox9.TabIndex = 27
'        Me.groupBox9.TabStop = False
'        Me.groupBox9.Text = "Filtros Exportacion"
'        ' 
'        ' checkBox2
'        ' 
'        Me.checkBox2.AutoSize = True
'        Me.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
'        Me.checkBox2.Location = New System.Drawing.Point(100, 13)
'        Me.checkBox2.Name = "checkBox2"
'        Me.checkBox2.Size = New System.Drawing.Size(187, 17)
'        Me.checkBox2.TabIndex = 34
'        Me.checkBox2.Text = "Seleccionar Conceptos a Exportar"
'        Me.checkBox2.UseVisualStyleBackColor = True
'        AddHandler Me.checkBox2.CheckedChanged, New System.EventHandler(AddressOf Me.checkBox2_CheckedChanged)
'        AddHandler Me.checkBox2.Click, New System.EventHandler(AddressOf Me.checkBox2_Click)
'        ' 
'        ' checkBox1
'        ' 
'        Me.checkBox1.AutoSize = True
'        Me.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
'        Me.checkBox1.Location = New System.Drawing.Point(324, 13)
'        Me.checkBox1.Name = "checkBox1"
'        Me.checkBox1.Size = New System.Drawing.Size(188, 17)
'        Me.checkBox1.TabIndex = 33
'        Me.checkBox1.Text = "Seleccionar Empleados a Exportar"
'        Me.checkBox1.UseVisualStyleBackColor = True
'        AddHandler Me.checkBox1.CheckedChanged, New System.EventHandler(AddressOf Me.checkBox1_CheckedChanged)
'        ' 
'        ' button10
'        ' 
'        Me.button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.button10.BackgroundImage = Global.ImportarExcelSQLServer.Resources.Bnt
'        Me.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.button10.Enabled = False
'        Me.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.button10.Location = New System.Drawing.Point(1036, 21)
'        Me.button10.Name = "button10"
'        Me.button10.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.button10.Size = New System.Drawing.Size(101, 23)
'        Me.button10.TabIndex = 32
'        Me.button10.Text = "Exportar a Excel"
'        Me.button10.UseVisualStyleBackColor = True
'        AddHandler Me.button10.Click, New System.EventHandler(AddressOf Me.button10_Click)
'        ' 
'        ' label20
'        ' 
'        Me.label20.AutoSize = True
'        Me.label20.Location = New System.Drawing.Point(665, 55)
'        Me.label20.Name = "label20"
'        Me.label20.Size = New System.Drawing.Size(16, 13)
'        Me.label20.TabIndex = 31
'        Me.label20.Text = "..."
'        ' 
'        ' progressBar2
'        ' 
'        Me.progressBar2.Location = New System.Drawing.Point(18, 56)
'        Me.progressBar2.Name = "progressBar2"
'        Me.progressBar2.Size = New System.Drawing.Size(1276, 10)
'        Me.progressBar2.TabIndex = 30
'        ' 
'        ' groupBox8
'        ' 
'        Me.groupBox8.Controls.Add(Me.radioButton2)
'        Me.groupBox8.Controls.Add(Me.radioButton1)
'        Me.groupBox8.Controls.Add(Me.label19)
'        Me.groupBox8.Controls.Add(Me.comboBox8)
'        Me.groupBox8.Controls.Add(Me.button14)
'        Me.groupBox8.Controls.Add(Me.comboBox7)
'        Me.groupBox8.Controls.Add(Me.label18)
'        Me.groupBox8.Location = New System.Drawing.Point(16, 9)
'        Me.groupBox8.Name = "groupBox8"
'        Me.groupBox8.Size = New System.Drawing.Size(694, 42)
'        Me.groupBox8.TabIndex = 27
'        Me.groupBox8.TabStop = False
'        Me.groupBox8.Text = "Parametros"
'        ' 
'        ' radioButton2
'        ' 
'        Me.radioButton2.AutoSize = True
'        Me.radioButton2.Location = New System.Drawing.Point(552, 15)
'        Me.radioButton2.Name = "radioButton2"
'        Me.radioButton2.Size = New System.Drawing.Size(69, 17)
'        Me.radioButton2.TabIndex = 25
'        Me.radioButton2.TabStop = True
'        Me.radioButton2.Text = "Consultar"
'        Me.radioButton2.UseVisualStyleBackColor = True
'        ' 
'        ' radioButton1
'        ' 
'        Me.radioButton1.AutoSize = True
'        Me.radioButton1.Location = New System.Drawing.Point(482, 15)
'        Me.radioButton1.Name = "radioButton1"
'        Me.radioButton1.Size = New System.Drawing.Size(66, 17)
'        Me.radioButton1.TabIndex = 24
'        Me.radioButton1.TabStop = True
'        Me.radioButton1.Text = "Generar "
'        Me.radioButton1.UseVisualStyleBackColor = True
'        ' 
'        ' label19
'        ' 
'        Me.label19.AutoSize = True
'        Me.label19.Location = New System.Drawing.Point(24, 16)
'        Me.label19.Name = "label19"
'        Me.label19.Size = New System.Drawing.Size(100, 13)
'        Me.label19.TabIndex = 17
'        Me.label19.Text = "Periodo Registrado:"
'        ' 
'        ' comboBox8
'        ' 
'        Me.comboBox8.BackColor = System.Drawing.SystemColors.ControlLightLight
'        Me.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.comboBox8.FormattingEnabled = True
'        Me.comboBox8.Location = New System.Drawing.Point(130, 12)
'        Me.comboBox8.Name = "comboBox8"
'        Me.comboBox8.Size = New System.Drawing.Size(102, 21)
'        Me.comboBox8.TabIndex = 16
'        AddHandler Me.comboBox8.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBox8_SelectedIndexChanged)
'        ' 
'        ' button14
'        ' 
'        Me.button14.BackgroundImage = Global.ImportarExcelSQLServer.Resources.Bnt
'        Me.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.button14.Image = Global.ImportarExcelSQLServer.Resources.LupaP2
'        Me.button14.Location = New System.Drawing.Point(639, 12)
'        Me.button14.Name = "button14"
'        Me.button14.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.button14.Size = New System.Drawing.Size(25, 23)
'        Me.button14.TabIndex = 18
'        Me.button14.Text = "..."
'        Me.button14.UseVisualStyleBackColor = True
'        AddHandler Me.button14.Click, New System.EventHandler(AddressOf Me.button14_Click)
'        ' 
'        ' comboBox7
'        ' 
'        Me.comboBox7.BackColor = System.Drawing.SystemColors.ControlLightLight
'        Me.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.comboBox7.FormattingEnabled = True
'        Me.comboBox7.Items.AddRange(New Object() {"MINDUGAR S.A. - 96588890-K", "MINDUGAR INDUSTRIAL - 83073600-K", "MINDUGAR MONTAJES - 76033420-0"})
'        Me.comboBox7.Location = New System.Drawing.Point(301, 12)
'        Me.comboBox7.Name = "comboBox7"
'        Me.comboBox7.Size = New System.Drawing.Size(155, 21)
'        Me.comboBox7.TabIndex = 22
'        AddHandler Me.comboBox7.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBox7_SelectedIndexChanged)
'        ' 
'        ' label18
'        ' 
'        Me.label18.AutoSize = True
'        Me.label18.Location = New System.Drawing.Point(247, 16)
'        Me.label18.Name = "label18"
'        Me.label18.Size = New System.Drawing.Size(51, 13)
'        Me.label18.TabIndex = 23
'        Me.label18.Text = "Empresa:"
'        ' 
'        ' button11
'        ' 
'        Me.button11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.button11.BackgroundImage = Global.ImportarExcelSQLServer.Resources.Bnt
'        Me.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.button11.Image = Global.ImportarExcelSQLServer.Resources._1491870612_icons_user2
'        Me.button11.Location = New System.Drawing.Point(1256, 72)
'        Me.button11.Name = "button11"
'        Me.button11.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.button11.Size = New System.Drawing.Size(25, 25)
'        Me.button11.TabIndex = 29
'        Me.button11.UseVisualStyleBackColor = True
'        AddHandler Me.button11.Click, New System.EventHandler(AddressOf Me.button11_Click)
'        ' 
'        ' label16
'        ' 
'        Me.label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
'        Me.label16.AutoSize = True
'        Me.label16.BackColor = System.Drawing.Color.Transparent
'        Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
'        Me.label16.Location = New System.Drawing.Point(15, 580)
'        Me.label16.Name = "label16"
'        Me.label16.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.label16.Size = New System.Drawing.Size(104, 15)
'        Me.label16.TabIndex = 28
'        Me.label16.Text = "Total Registros"
'        ' 
'        ' button12
'        ' 
'        Me.button12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.button12.BackgroundImage = Global.ImportarExcelSQLServer.Resources.Bnt
'        Me.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.button12.Image = Global.ImportarExcelSQLServer.Resources._1491870612_icons_user2
'        Me.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
'        Me.button12.Location = New System.Drawing.Point(1143, 21)
'        Me.button12.Name = "button12"
'        Me.button12.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.button12.Size = New System.Drawing.Size(138, 23)
'        Me.button12.TabIndex = 27
'        Me.button12.Text = "Exportar a GESTPER"
'        Me.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
'        Me.button12.UseVisualStyleBackColor = True
'        AddHandler Me.button12.Click, New System.EventHandler(AddressOf Me.button12_Click)
'        ' 
'        ' button13
'        ' 
'        Me.button13.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.button13.BackgroundImage = Global.ImportarExcelSQLServer.Resources.Bnt
'        Me.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
'        Me.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.button13.Image = Global.ImportarExcelSQLServer.Resources.LupaP2
'        Me.button13.Location = New System.Drawing.Point(977, 21)
'        Me.button13.Name = "button13"
'        Me.button13.RightToLeft = System.Windows.Forms.RightToLeft.No
'        Me.button13.Size = New System.Drawing.Size(25, 23)
'        Me.button13.TabIndex = 25
'        Me.button13.Text = "..."
'        Me.button13.UseVisualStyleBackColor = True
'        AddHandler Me.button13.Click, New System.EventHandler(AddressOf Me.button13_Click)
'        ' 
'        ' textBox5
'        ' 
'        Me.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.textBox5.Location = New System.Drawing.Point(869, 23)
'        Me.textBox5.Name = "textBox5"
'        Me.textBox5.Size = New System.Drawing.Size(100, 20)
'        Me.textBox5.TabIndex = 21
'        ' 
'        ' label17
'        ' 
'        Me.label17.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.label17.AutoSize = True
'        Me.label17.Location = New System.Drawing.Point(738, 27)
'        Me.label17.Name = "label17"
'        Me.label17.Size = New System.Drawing.Size(126, 13)
'        Me.label17.TabIndex = 24
'        Me.label17.Text = "Rut o Nombre Empleado:"
'        ' 
'        ' groupBox7
'        ' 
'        Me.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Top
'        Me.groupBox7.Location = New System.Drawing.Point(716, 9)
'        Me.groupBox7.Name = "groupBox7"
'        Me.groupBox7.Size = New System.Drawing.Size(304, 42)
'        Me.groupBox7.TabIndex = 26
'        Me.groupBox7.TabStop = False
'        Me.groupBox7.Text = "FIltros"
'        ' 
'        ' dataGridView4
'        ' 
'        Me.dataGridView4.AllowUserToAddRows = False
'        Me.dataGridView4.AllowUserToDeleteRows = False
'        Me.dataGridView4.AllowUserToOrderColumns = True
'        Me.dataGridView4.AllowUserToResizeRows = False
'        Me.dataGridView4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
'        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
'        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
'        dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
'        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
'        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold
'        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
'        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
'        Me.dataGridView4.DefaultCellStyle = dataGridViewCellStyle4
'        Me.dataGridView4.Location = New System.Drawing.Point(16, 56)
'        Me.dataGridView4.MultiSelect = False
'        Me.dataGridView4.Name = "dataGridView4"
'        Me.dataGridView4.RowHeadersVisible = False
'        Me.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
'        Me.dataGridView4.Size = New System.Drawing.Size(1278, 509)
'        Me.dataGridView4.TabIndex = 19
'        AddHandler Me.dataGridView4.DataSourceChanged, New System.EventHandler(AddressOf Me.dataGridView4_DataSourceChanged)
'        AddHandler Me.dataGridView4.CellContentClick, New System.Windows.Forms.DataGridViewCellEventHandler(AddressOf Me.dataGridView4_CellContentClick)
'        AddHandler Me.dataGridView4.CellContentDoubleClick, New System.Windows.Forms.DataGridViewCellEventHandler(AddressOf Me.dataGridView4_CellContentDoubleClick)
'        AddHandler Me.dataGridView4.CurrentCellDirtyStateChanged, New System.EventHandler(AddressOf Me.dataGridView4_CurrentCellDirtyStateChanged)
'        AddHandler Me.dataGridView4.Sorted, New System.EventHandler(AddressOf Me.dataGridView4_Sorted)
'        AddHandler Me.dataGridView4.MouseClick, New System.Windows.Forms.MouseEventHandler(AddressOf Me.dataGridView4_MouseClick)
'        ' 
'        ' Form1
'        ' 
'        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
'        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
'        Me.ClientSize = New System.Drawing.Size(1351, 664)
'        Me.Controls.Add(Me.gradientTab1)
'        Me.Name = "Form1"
'        Me.Text = "Exportar Datos a SQL Server"
'        AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
'        AddHandler Me.Paint, New System.Windows.Forms.PaintEventHandler(AddressOf Me.Form1_Paint)
'        DirectCast(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.contextVerSelec.ResumeLayout(False)
'        Me.contextOcultarSelec.ResumeLayout(False)
'        Me.gradientTab1.ResumeLayout(False)
'        Me.tabPage4.ResumeLayout(False)
'        Me.groupBox1.ResumeLayout(False)
'        Me.groupBox1.PerformLayout()
'        DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
'        DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.tabPage5.ResumeLayout(False)
'        Me.groupBox2.ResumeLayout(False)
'        Me.groupBox2.PerformLayout()
'        DirectCast(Me.dataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.tabPage6.ResumeLayout(False)
'        Me.groupBox3.ResumeLayout(False)
'        Me.groupBox3.PerformLayout()
'        DirectCast(Me.dataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.tabPage1.ResumeLayout(False)
'        Me.groupBox6.ResumeLayout(False)
'        Me.groupBox6.PerformLayout()
'        Me.groupBox9.ResumeLayout(False)
'        Me.groupBox9.PerformLayout()
'        Me.groupBox8.ResumeLayout(False)
'        Me.groupBox8.PerformLayout()
'        DirectCast(Me.dataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.ResumeLayout(False)

'    End Sub

'#End Region
'    Private WithEvents backgroundWorker1 As System.ComponentModel.BackgroundWorker
'    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
'    Private WithEvents dataGridView2 As System.Windows.Forms.DataGridView
'    Private WithEvents button4 As System.Windows.Forms.Button
'    Private WithEvents comboBox3 As System.Windows.Forms.ComboBox
'    Private WithEvents button5 As System.Windows.Forms.Button
'    Private WithEvents label8 As System.Windows.Forms.Label
'    Private WithEvents button8 As System.Windows.Forms.Button
'    Private WithEvents textBox4 As System.Windows.Forms.TextBox
'    Private WithEvents label12 As System.Windows.Forms.Label
'    Private WithEvents label13 As System.Windows.Forms.Label
'    Private WithEvents comboBox6 As System.Windows.Forms.ComboBox
'    Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
'    Private WithEvents label14 As System.Windows.Forms.Label
'    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
'    Private WithEvents label7 As System.Windows.Forms.Label
'    Private WithEvents label6 As System.Windows.Forms.Label
'    Private WithEvents button3 As System.Windows.Forms.Button
'    Private WithEvents label5 As System.Windows.Forms.Label
'    Private WithEvents textBox2 As System.Windows.Forms.TextBox
'    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
'    Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
'    Private WithEvents progressBar1 As System.Windows.Forms.ProgressBar
'    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
'    Private WithEvents label4 As System.Windows.Forms.Label
'    Private WithEvents textBox1 As System.Windows.Forms.TextBox
'    Private WithEvents label1 As System.Windows.Forms.Label
'    Private WithEvents button2 As System.Windows.Forms.Button
'    Private WithEvents button1 As System.Windows.Forms.Button
'    Private WithEvents label3 As System.Windows.Forms.Label
'    Private WithEvents label2 As System.Windows.Forms.Label
'    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
'    Private WithEvents label15 As System.Windows.Forms.Label
'    Private WithEvents button9 As System.Windows.Forms.Button
'    Private WithEvents button7 As System.Windows.Forms.Button
'    Private WithEvents textBox3 As System.Windows.Forms.TextBox
'    Private WithEvents label11 As System.Windows.Forms.Label
'    Private WithEvents label10 As System.Windows.Forms.Label
'    Private WithEvents comboBox5 As System.Windows.Forms.ComboBox
'    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
'    Private WithEvents dataGridView3 As System.Windows.Forms.DataGridView
'    Private WithEvents button6 As System.Windows.Forms.Button
'    Private WithEvents label9 As System.Windows.Forms.Label
'    Private WithEvents comboBox4 As System.Windows.Forms.ComboBox
'    Private WithEvents gradientTab1 As _2_Business_Layer.GradientTab
'    Private WithEvents tabPage4 As System.Windows.Forms.TabPage
'    Private WithEvents tabPage5 As System.Windows.Forms.TabPage
'    Private WithEvents tabPage6 As System.Windows.Forms.TabPage
'    Private WithEvents backgroundWorker2 As System.ComponentModel.BackgroundWorker
'    Private WithEvents tabPage1 As System.Windows.Forms.TabPage
'    Private WithEvents groupBox6 As System.Windows.Forms.GroupBox
'    Private WithEvents groupBox8 As System.Windows.Forms.GroupBox
'    Private WithEvents label19 As System.Windows.Forms.Label
'    Private WithEvents comboBox8 As System.Windows.Forms.ComboBox
'    Private WithEvents button14 As System.Windows.Forms.Button
'    Private WithEvents comboBox7 As System.Windows.Forms.ComboBox
'    Private WithEvents label18 As System.Windows.Forms.Label
'    Private WithEvents button11 As System.Windows.Forms.Button
'    Private WithEvents label16 As System.Windows.Forms.Label
'    Private WithEvents button12 As System.Windows.Forms.Button
'    Private WithEvents button13 As System.Windows.Forms.Button
'    Private WithEvents textBox5 As System.Windows.Forms.TextBox
'    Private WithEvents label17 As System.Windows.Forms.Label
'    Private WithEvents groupBox7 As System.Windows.Forms.GroupBox
'    Private WithEvents dataGridView4 As System.Windows.Forms.DataGridView
'    Private WithEvents errorIcono As System.Windows.Forms.ErrorProvider
'    Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
'    Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
'    Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
'    Private WithEvents progressBar2 As System.Windows.Forms.ProgressBar
'    Private WithEvents label20 As System.Windows.Forms.Label
'    Private WithEvents button10 As System.Windows.Forms.Button
'    Private WithEvents progressBar3 As System.Windows.Forms.ProgressBar
'    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
'    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
'    Private WithEvents groupBox9 As System.Windows.Forms.GroupBox
'    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
'    Private WithEvents contextVerSelec As System.Windows.Forms.ContextMenuStrip
'    Private WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
'    Private WithEvents contextOcultarSelec As System.Windows.Forms.ContextMenuStrip
'    Private WithEvents toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
'End Class


#End Region

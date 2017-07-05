<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Parametros2
    Inherits System.Windows.Forms.Form

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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Permisos")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informes de Almuerzos")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asistencia")
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Bttn_Actualiza = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtBx_FechaMod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbBx_Perfil = New MetroFramework.Controls.MetroComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBx_Empleado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbBx_Usuarios = New MetroFramework.Controls.MetroComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtGrdVw_PermisosSi = New MetroFramework.Controls.MetroGrid()
        Me.SelSi = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdAtributoSi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AtributoSi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtGrdVw_PermisosNo = New MetroFramework.Controls.MetroGrid()
        Me.SelNo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdAtributoNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AtributoNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SbO_COMERCIALDataSet1 = New RRHH.SBO_COMERCIALDataSet()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DtGrdVw_PermisosSi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtGrdVw_PermisosNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SbO_COMERCIALDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1290, 674)
        Me.SplitContainer1.SplitterDistance = 332
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        TreeNode1.ForeColor = System.Drawing.Color.White
        TreeNode1.Name = "Nd_Permisos"
        TreeNode1.Text = "Permisos"
        TreeNode2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        TreeNode2.ForeColor = System.Drawing.Color.White
        TreeNode2.Name = "Nodo4"
        TreeNode2.Text = "Informes de Almuerzos"
        TreeNode3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        TreeNode3.ForeColor = System.Drawing.Color.White
        TreeNode3.Name = "Nodo5"
        TreeNode3.Text = "Asistencia"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Me.TreeView1.Size = New System.Drawing.Size(332, 674)
        Me.TreeView1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lbl_Titulo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(954, 42)
        Me.Panel2.TabIndex = 2
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lbl_Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Titulo.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_Titulo.Margin = New System.Windows.Forms.Padding(0)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(954, 42)
        Me.Lbl_Titulo.TabIndex = 5
        Me.Lbl_Titulo.Text = "Lbl_Titulo Seleccion"
        Me.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Bttn_Actualiza)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DtGrdVw_PermisosSi)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DtGrdVw_PermisosNo)
        Me.Panel1.Location = New System.Drawing.Point(6, 74)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(716, 549)
        Me.Panel1.TabIndex = 1
        '
        'Bttn_Actualiza
        '
        Me.Bttn_Actualiza.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Bttn_Actualiza.FlatAppearance.BorderSize = 0
        Me.Bttn_Actualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bttn_Actualiza.Image = Global.RRHH.My.Resources.Resources.indicators__1_
        Me.Bttn_Actualiza.Location = New System.Drawing.Point(322, 233)
        Me.Bttn_Actualiza.Name = "Bttn_Actualiza"
        Me.Bttn_Actualiza.Size = New System.Drawing.Size(68, 57)
        Me.Bttn_Actualiza.TabIndex = 9
        Me.Bttn_Actualiza.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TxtBx_FechaMod)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.CmbBx_Perfil)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.TxtBx_Empleado)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.CmbBx_Usuarios)
        Me.Panel3.Location = New System.Drawing.Point(19, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(675, 140)
        Me.Panel3.TabIndex = 8
        '
        'TxtBx_FechaMod
        '
        Me.TxtBx_FechaMod.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx_FechaMod.Location = New System.Drawing.Point(534, 105)
        Me.TxtBx_FechaMod.Name = "TxtBx_FechaMod"
        Me.TxtBx_FechaMod.ReadOnly = True
        Me.TxtBx_FechaMod.Size = New System.Drawing.Size(130, 25)
        Me.TxtBx_FechaMod.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(548, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Fecha Acualización"
        '
        'CmbBx_Perfil
        '
        Me.CmbBx_Perfil.Enabled = False
        Me.CmbBx_Perfil.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBx_Perfil.FormattingEnabled = True
        Me.CmbBx_Perfil.ItemHeight = 23
        Me.CmbBx_Perfil.Items.AddRange(New Object() {"RRHH"})
        Me.CmbBx_Perfil.Location = New System.Drawing.Point(93, 66)
        Me.CmbBx_Perfil.Name = "CmbBx_Perfil"
        Me.CmbBx_Perfil.Size = New System.Drawing.Size(315, 29)
        Me.CmbBx_Perfil.TabIndex = 6
        Me.CmbBx_Perfil.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Perfil"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Empleado"
        '
        'TxtBx_Empleado
        '
        Me.TxtBx_Empleado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx_Empleado.Location = New System.Drawing.Point(93, 37)
        Me.TxtBx_Empleado.Name = "TxtBx_Empleado"
        Me.TxtBx_Empleado.ReadOnly = True
        Me.TxtBx_Empleado.Size = New System.Drawing.Size(315, 25)
        Me.TxtBx_Empleado.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Usuario/RUT"
        '
        'CmbBx_Usuarios
        '
        Me.CmbBx_Usuarios.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBx_Usuarios.FormattingEnabled = True
        Me.CmbBx_Usuarios.ItemHeight = 23
        Me.CmbBx_Usuarios.Location = New System.Drawing.Point(93, 5)
        Me.CmbBx_Usuarios.Name = "CmbBx_Usuarios"
        Me.CmbBx_Usuarios.Size = New System.Drawing.Size(126, 29)
        Me.CmbBx_Usuarios.TabIndex = 0
        Me.CmbBx_Usuarios.UseSelectable = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Image = Global.RRHH.My.Resources.Resources.home_shape_32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(7, 484)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 59)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Volver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Al Inicio"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(410, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Permisos sin Otorgar"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DtGrdVw_PermisosSi
        '
        Me.DtGrdVw_PermisosSi.AllowUserToAddRows = False
        Me.DtGrdVw_PermisosSi.AllowUserToResizeRows = False
        Me.DtGrdVw_PermisosSi.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DtGrdVw_PermisosSi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DtGrdVw_PermisosSi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DtGrdVw_PermisosSi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtGrdVw_PermisosSi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtGrdVw_PermisosSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtGrdVw_PermisosSi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelSi, Me.IdAtributoSi, Me.AtributoSi})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtGrdVw_PermisosSi.DefaultCellStyle = DataGridViewCellStyle2
        Me.DtGrdVw_PermisosSi.EnableHeadersVisualStyles = False
        Me.DtGrdVw_PermisosSi.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DtGrdVw_PermisosSi.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DtGrdVw_PermisosSi.Location = New System.Drawing.Point(410, 170)
        Me.DtGrdVw_PermisosSi.MultiSelect = False
        Me.DtGrdVw_PermisosSi.Name = "DtGrdVw_PermisosSi"
        Me.DtGrdVw_PermisosSi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtGrdVw_PermisosSi.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DtGrdVw_PermisosSi.RowHeadersVisible = False
        Me.DtGrdVw_PermisosSi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DtGrdVw_PermisosSi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DtGrdVw_PermisosSi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtGrdVw_PermisosSi.Size = New System.Drawing.Size(284, 201)
        Me.DtGrdVw_PermisosSi.TabIndex = 5
        '
        'SelSi
        '
        Me.SelSi.HeaderText = ""
        Me.SelSi.MinimumWidth = 20
        Me.SelSi.Name = "SelSi"
        Me.SelSi.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SelSi.Width = 20
        '
        'IdAtributoSi
        '
        Me.IdAtributoSi.HeaderText = "Id"
        Me.IdAtributoSi.Name = "IdAtributoSi"
        Me.IdAtributoSi.ReadOnly = True
        Me.IdAtributoSi.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdAtributoSi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IdAtributoSi.Width = 40
        '
        'AtributoSi
        '
        Me.AtributoSi.HeaderText = "Atributos"
        Me.AtributoSi.Name = "AtributoSi"
        Me.AtributoSi.Width = 220
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(19, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Permisos sin Otorgar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DtGrdVw_PermisosNo
        '
        Me.DtGrdVw_PermisosNo.AllowUserToAddRows = False
        Me.DtGrdVw_PermisosNo.AllowUserToResizeRows = False
        Me.DtGrdVw_PermisosNo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DtGrdVw_PermisosNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DtGrdVw_PermisosNo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DtGrdVw_PermisosNo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtGrdVw_PermisosNo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DtGrdVw_PermisosNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtGrdVw_PermisosNo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelNo, Me.IdAtributoNo, Me.AtributoNo})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtGrdVw_PermisosNo.DefaultCellStyle = DataGridViewCellStyle5
        Me.DtGrdVw_PermisosNo.EnableHeadersVisualStyles = False
        Me.DtGrdVw_PermisosNo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DtGrdVw_PermisosNo.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DtGrdVw_PermisosNo.Location = New System.Drawing.Point(19, 170)
        Me.DtGrdVw_PermisosNo.MultiSelect = False
        Me.DtGrdVw_PermisosNo.Name = "DtGrdVw_PermisosNo"
        Me.DtGrdVw_PermisosNo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtGrdVw_PermisosNo.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DtGrdVw_PermisosNo.RowHeadersVisible = False
        Me.DtGrdVw_PermisosNo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DtGrdVw_PermisosNo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DtGrdVw_PermisosNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtGrdVw_PermisosNo.Size = New System.Drawing.Size(284, 201)
        Me.DtGrdVw_PermisosNo.TabIndex = 3
        '
        'SelNo
        '
        Me.SelNo.HeaderText = ""
        Me.SelNo.MinimumWidth = 20
        Me.SelNo.Name = "SelNo"
        Me.SelNo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SelNo.Width = 20
        '
        'IdAtributoNo
        '
        Me.IdAtributoNo.HeaderText = "Id"
        Me.IdAtributoNo.Name = "IdAtributoNo"
        Me.IdAtributoNo.ReadOnly = True
        Me.IdAtributoNo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdAtributoNo.Width = 40
        '
        'AtributoNo
        '
        Me.AtributoNo.HeaderText = "Atributos"
        Me.AtributoNo.Name = "AtributoNo"
        Me.AtributoNo.Width = 220
        '
        'SbO_COMERCIALDataSet1
        '
        Me.SbO_COMERCIALDataSet1.DataSetName = "SBO_COMERCIALDataSet"
        Me.SbO_COMERCIALDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Frm_Parametros2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1290, 674)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Parametros2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frm_Parametros2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DtGrdVw_PermisosSi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtGrdVw_PermisosNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SbO_COMERCIALDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DtGrdVw_PermisosSi As MetroFramework.Controls.MetroGrid 'DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents DtGrdVw_PermisosNo As MetroFramework.Controls.MetroGrid 'DataGridView
    Friend WithEvents Lbl_Titulo As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtBx_FechaMod As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbBx_Perfil As MetroFramework.Controls.MetroComboBox 'ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBx_Empleado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbBx_Usuarios As MetroFramework.Controls.MetroComboBox 'ComboBox
    Friend WithEvents Bttn_Actualiza As Button
    Friend WithEvents SbO_COMERCIALDataSet1 As SBO_COMERCIALDataSet
    Friend WithEvents SelNo As DataGridViewCheckBoxColumn
    Friend WithEvents IdAtributoNo As DataGridViewTextBoxColumn
    Friend WithEvents AtributoNo As DataGridViewTextBoxColumn
    Friend WithEvents SelSi As DataGridViewCheckBoxColumn
    Friend WithEvents IdAtributoSi As DataGridViewTextBoxColumn
    Friend WithEvents AtributoSi As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class

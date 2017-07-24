<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Parametros
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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Permisos")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Valores Colaciones")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mantención ", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Apagado de Computador")
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Pnl_ValoresCol = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Lbl_ID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Bttn_Grabar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtGridVw_ValoresCol = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsrActualizacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecActualizacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColacionesParametrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SACMindugarDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SAC_MindugarDataSet = New RRHH.SAC_MindugarDataSet()
        Me.DtTm_FechaCol = New System.Windows.Forms.DateTimePicker()
        Me.TxtBx_ValorCol = New System.Windows.Forms.TextBox()
        Me.TxtBx_ValorDec = New System.Windows.Forms.TextBox()
        Me.Bttn_Nuevo = New System.Windows.Forms.Button()
        Me.TxtBx_Id = New System.Windows.Forms.TextBox()
        Me.Pnl_Permisos = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.Bttn_GrabaPermisos = New System.Windows.Forms.Button()
        Me.ChckBx_MantAlmuerzos = New System.Windows.Forms.CheckBox()
        Me.ChckBx_Parametros = New System.Windows.Forms.CheckBox()
        Me.ChckBx_ImpLiquidaciones = New System.Windows.Forms.CheckBox()
        Me.ChckBx_SolicitudAlm = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DtGridVw_Permisos = New System.Windows.Forms.DataGridView()
        Me.RutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodinternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MantParamDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SolAlmDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MantAlmDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ImpLiquiDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FechaGrabaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserGrabaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermisosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bttn_Volver = New System.Windows.Forms.Button()
        Me.PermisosTableAdapter = New RRHH.SAC_MindugarDataSetTableAdapters.PermisosTableAdapter()
        Me.Colaciones_ParametrosTableAdapter = New RRHH.SAC_MindugarDataSetTableAdapters.Colaciones_ParametrosTableAdapter()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Pnl_ValoresCol.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DtGridVw_ValoresCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColacionesParametrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SACMindugarDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAC_MindugarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Permisos.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DtGridVw_Permisos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermisosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.Pnl_ValoresCol)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Pnl_Permisos)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Bttn_Volver)
        Me.SplitContainer1.Size = New System.Drawing.Size(1063, 445)
        Me.SplitContainer1.SplitterDistance = 240
        Me.SplitContainer1.TabIndex = 4
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Nd_Permisos"
        TreeNode1.Text = "Permisos"
        TreeNode2.Name = "Nd_ValCol"
        TreeNode2.Text = "Valores Colaciones"
        TreeNode3.Name = "Nd_Mantencion"
        TreeNode3.Text = "Mantención "
        TreeNode4.Name = "Nd_Apagado"
        TreeNode4.Text = "Apagado de Computador"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4})
        Me.TreeView1.Size = New System.Drawing.Size(240, 445)
        Me.TreeView1.TabIndex = 0
        '
        'Pnl_ValoresCol
        '
        Me.Pnl_ValoresCol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pnl_ValoresCol.Controls.Add(Me.TableLayoutPanel2)
        Me.Pnl_ValoresCol.Location = New System.Drawing.Point(708, 12)
        Me.Pnl_ValoresCol.Name = "Pnl_ValoresCol"
        Me.Pnl_ValoresCol.Size = New System.Drawing.Size(590, 416)
        Me.Pnl_ValoresCol.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Lbl_ID, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Bttn_Grabar, 2, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.DtGridVw_ValoresCol, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DtTm_FechaCol, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtBx_ValorCol, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtBx_ValorDec, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Bttn_Nuevo, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtBx_Id, 1, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(445, 403)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(3, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 25)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Volver al Inicio"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Lbl_ID
        '
        Me.Lbl_ID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_ID.AutoSize = True
        Me.Lbl_ID.Location = New System.Drawing.Point(3, 272)
        Me.Lbl_ID.Name = "Lbl_ID"
        Me.Lbl_ID.Size = New System.Drawing.Size(148, 22)
        Me.Lbl_ID.TabIndex = 13
        Me.Lbl_ID.Text = "Id"
        Me.Lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label3, 6)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(439, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Label1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bttn_Grabar
        '
        Me.Bttn_Grabar.Location = New System.Drawing.Point(294, 375)
        Me.Bttn_Grabar.Name = "Bttn_Grabar"
        Me.Bttn_Grabar.Size = New System.Drawing.Size(148, 25)
        Me.Bttn_Grabar.TabIndex = 4
        Me.Bttn_Grabar.Text = "Grabar"
        Me.Bttn_Grabar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha desde"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Valor Almuerzo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 22)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Valor a Desdcontar"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DtGridVw_ValoresCol
        '
        Me.DtGridVw_ValoresCol.AllowUserToAddRows = False
        Me.DtGridVw_ValoresCol.AllowUserToDeleteRows = False
        Me.DtGridVw_ValoresCol.AutoGenerateColumns = False
        Me.DtGridVw_ValoresCol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtGridVw_ValoresCol.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.ClaveDataGridViewTextBoxColumn, Me.ValorTotalDataGridViewTextBoxColumn, Me.ValorDescDataGridViewTextBoxColumn, Me.IdUsrActualizacionDataGridViewTextBoxColumn, Me.FecActualizacionDataGridViewTextBoxColumn})
        Me.TableLayoutPanel2.SetColumnSpan(Me.DtGridVw_ValoresCol, 3)
        Me.DtGridVw_ValoresCol.DataSource = Me.ColacionesParametrosBindingSource
        Me.DtGridVw_ValoresCol.Location = New System.Drawing.Point(3, 33)
        Me.DtGridVw_ValoresCol.Name = "DtGridVw_ValoresCol"
        Me.DtGridVw_ValoresCol.ReadOnly = True
        Me.DtGridVw_ValoresCol.Size = New System.Drawing.Size(439, 236)
        Me.DtGridVw_ValoresCol.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 50
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClaveDataGridViewTextBoxColumn
        '
        Me.ClaveDataGridViewTextBoxColumn.DataPropertyName = "Clave"
        Me.ClaveDataGridViewTextBoxColumn.HeaderText = "Clave"
        Me.ClaveDataGridViewTextBoxColumn.Name = "ClaveDataGridViewTextBoxColumn"
        Me.ClaveDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClaveDataGridViewTextBoxColumn.Visible = False
        '
        'ValorTotalDataGridViewTextBoxColumn
        '
        Me.ValorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal"
        Me.ValorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal"
        Me.ValorTotalDataGridViewTextBoxColumn.Name = "ValorTotalDataGridViewTextBoxColumn"
        Me.ValorTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorDescDataGridViewTextBoxColumn
        '
        Me.ValorDescDataGridViewTextBoxColumn.DataPropertyName = "ValorDesc"
        Me.ValorDescDataGridViewTextBoxColumn.HeaderText = "ValorDesc"
        Me.ValorDescDataGridViewTextBoxColumn.Name = "ValorDescDataGridViewTextBoxColumn"
        Me.ValorDescDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdUsrActualizacionDataGridViewTextBoxColumn
        '
        Me.IdUsrActualizacionDataGridViewTextBoxColumn.DataPropertyName = "IdUsrActualizacion"
        Me.IdUsrActualizacionDataGridViewTextBoxColumn.HeaderText = "IdUsrActualizacion"
        Me.IdUsrActualizacionDataGridViewTextBoxColumn.Name = "IdUsrActualizacionDataGridViewTextBoxColumn"
        Me.IdUsrActualizacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdUsrActualizacionDataGridViewTextBoxColumn.Visible = False
        '
        'FecActualizacionDataGridViewTextBoxColumn
        '
        Me.FecActualizacionDataGridViewTextBoxColumn.DataPropertyName = "FecActualizacion"
        Me.FecActualizacionDataGridViewTextBoxColumn.HeaderText = "FecActualizacion"
        Me.FecActualizacionDataGridViewTextBoxColumn.Name = "FecActualizacionDataGridViewTextBoxColumn"
        Me.FecActualizacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FecActualizacionDataGridViewTextBoxColumn.Visible = False
        '
        'ColacionesParametrosBindingSource
        '
        Me.ColacionesParametrosBindingSource.DataMember = "Colaciones_Parametros"
        Me.ColacionesParametrosBindingSource.DataSource = Me.SACMindugarDataSetBindingSource
        '
        'SACMindugarDataSetBindingSource
        '
        Me.SACMindugarDataSetBindingSource.DataSource = Me.SAC_MindugarDataSet
        Me.SACMindugarDataSetBindingSource.Position = 0
        '
        'SAC_MindugarDataSet
        '
        Me.SAC_MindugarDataSet.DataSetName = "SAC_MindugarDataSet"
        Me.SAC_MindugarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtTm_FechaCol
        '
        Me.DtTm_FechaCol.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtTm_FechaCol.Location = New System.Drawing.Point(157, 297)
        Me.DtTm_FechaCol.Name = "DtTm_FechaCol"
        Me.DtTm_FechaCol.Size = New System.Drawing.Size(110, 20)
        Me.DtTm_FechaCol.TabIndex = 8
        '
        'TxtBx_ValorCol
        '
        Me.TxtBx_ValorCol.Location = New System.Drawing.Point(157, 319)
        Me.TxtBx_ValorCol.Name = "TxtBx_ValorCol"
        Me.TxtBx_ValorCol.Size = New System.Drawing.Size(79, 20)
        Me.TxtBx_ValorCol.TabIndex = 9
        Me.TxtBx_ValorCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtBx_ValorDec
        '
        Me.TxtBx_ValorDec.Location = New System.Drawing.Point(157, 345)
        Me.TxtBx_ValorDec.Name = "TxtBx_ValorDec"
        Me.TxtBx_ValorDec.Size = New System.Drawing.Size(79, 20)
        Me.TxtBx_ValorDec.TabIndex = 10
        Me.TxtBx_ValorDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Bttn_Nuevo
        '
        Me.Bttn_Nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bttn_Nuevo.Location = New System.Drawing.Point(367, 297)
        Me.Bttn_Nuevo.Name = "Bttn_Nuevo"
        Me.TableLayoutPanel2.SetRowSpan(Me.Bttn_Nuevo, 2)
        Me.Bttn_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.Bttn_Nuevo.TabIndex = 11
        Me.Bttn_Nuevo.Text = "Nuevo"
        Me.Bttn_Nuevo.UseVisualStyleBackColor = True
        '
        'TxtBx_Id
        '
        Me.TxtBx_Id.Location = New System.Drawing.Point(157, 275)
        Me.TxtBx_Id.Name = "TxtBx_Id"
        Me.TxtBx_Id.ReadOnly = True
        Me.TxtBx_Id.Size = New System.Drawing.Size(25, 20)
        Me.TxtBx_Id.TabIndex = 12
        '
        'Pnl_Permisos
        '
        Me.Pnl_Permisos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Pnl_Permisos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pnl_Permisos.Controls.Add(Me.TableLayoutPanel1)
        Me.Pnl_Permisos.Location = New System.Drawing.Point(2, 0)
        Me.Pnl_Permisos.Name = "Pnl_Permisos"
        Me.Pnl_Permisos.Size = New System.Drawing.Size(702, 409)
        Me.Pnl_Permisos.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Lbl_Titulo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Bttn_GrabaPermisos, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ChckBx_MantAlmuerzos, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ChckBx_Parametros, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ChckBx_ImpLiquidaciones, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ChckBx_SolicitudAlm, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DtGridVw_Permisos, 4, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.620689!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.37931!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(690, 403)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(3, 374)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 26)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Volver al Inicio"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Titulo.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Lbl_Titulo, 5)
        Me.Lbl_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo.Location = New System.Drawing.Point(3, 0)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(684, 23)
        Me.Lbl_Titulo.TabIndex = 0
        Me.Lbl_Titulo.Text = "Label1"
        Me.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bttn_GrabaPermisos
        '
        Me.Bttn_GrabaPermisos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bttn_GrabaPermisos.Location = New System.Drawing.Point(529, 374)
        Me.Bttn_GrabaPermisos.Name = "Bttn_GrabaPermisos"
        Me.Bttn_GrabaPermisos.Size = New System.Drawing.Size(158, 26)
        Me.Bttn_GrabaPermisos.TabIndex = 1
        Me.Bttn_GrabaPermisos.Text = "Grabar"
        Me.Bttn_GrabaPermisos.UseVisualStyleBackColor = True
        '
        'ChckBx_MantAlmuerzos
        '
        Me.ChckBx_MantAlmuerzos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChckBx_MantAlmuerzos.AutoSize = True
        Me.ChckBx_MantAlmuerzos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChckBx_MantAlmuerzos.Location = New System.Drawing.Point(103, 347)
        Me.ChckBx_MantAlmuerzos.Name = "ChckBx_MantAlmuerzos"
        Me.ChckBx_MantAlmuerzos.Size = New System.Drawing.Size(114, 17)
        Me.ChckBx_MantAlmuerzos.TabIndex = 4
        Me.ChckBx_MantAlmuerzos.Text = "Mantencion Almuerzos"
        Me.ChckBx_MantAlmuerzos.UseVisualStyleBackColor = True
        '
        'ChckBx_Parametros
        '
        Me.ChckBx_Parametros.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChckBx_Parametros.AutoSize = True
        Me.ChckBx_Parametros.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChckBx_Parametros.Location = New System.Drawing.Point(103, 319)
        Me.ChckBx_Parametros.Name = "ChckBx_Parametros"
        Me.ChckBx_Parametros.Size = New System.Drawing.Size(114, 17)
        Me.ChckBx_Parametros.TabIndex = 3
        Me.ChckBx_Parametros.Text = "Parametros"
        Me.ChckBx_Parametros.UseVisualStyleBackColor = True
        '
        'ChckBx_ImpLiquidaciones
        '
        Me.ChckBx_ImpLiquidaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChckBx_ImpLiquidaciones.AutoSize = True
        Me.ChckBx_ImpLiquidaciones.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChckBx_ImpLiquidaciones.Location = New System.Drawing.Point(343, 347)
        Me.ChckBx_ImpLiquidaciones.Name = "ChckBx_ImpLiquidaciones"
        Me.ChckBx_ImpLiquidaciones.Size = New System.Drawing.Size(114, 17)
        Me.ChckBx_ImpLiquidaciones.TabIndex = 6
        Me.ChckBx_ImpLiquidaciones.Text = "Imp.Liquidaciones"
        Me.ChckBx_ImpLiquidaciones.UseVisualStyleBackColor = True
        '
        'ChckBx_SolicitudAlm
        '
        Me.ChckBx_SolicitudAlm.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChckBx_SolicitudAlm.AutoSize = True
        Me.ChckBx_SolicitudAlm.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChckBx_SolicitudAlm.Location = New System.Drawing.Point(343, 319)
        Me.ChckBx_SolicitudAlm.Name = "ChckBx_SolicitudAlm"
        Me.ChckBx_SolicitudAlm.Size = New System.Drawing.Size(114, 17)
        Me.ChckBx_SolicitudAlm.TabIndex = 5
        Me.ChckBx_SolicitudAlm.Text = "Solicitud Almuerzo"
        Me.ChckBx_SolicitudAlm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox1, 3)
        Me.TextBox1.Location = New System.Drawing.Point(103, 280)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(354, 20)
        Me.TextBox1.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(463, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 31)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Borrar Contraceña"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DtGridVw_Permisos
        '
        Me.DtGridVw_Permisos.AutoGenerateColumns = False
        Me.DtGridVw_Permisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtGridVw_Permisos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RutDataGridViewTextBoxColumn, Me.CodinternoDataGridViewTextBoxColumn, Me.PassDataGridViewTextBoxColumn, Me.MantParamDataGridViewCheckBoxColumn, Me.SolAlmDataGridViewCheckBoxColumn, Me.MantAlmDataGridViewCheckBoxColumn, Me.ImpLiquiDataGridViewCheckBoxColumn, Me.FechaGrabaDataGridViewTextBoxColumn, Me.UserGrabaDataGridViewTextBoxColumn})
        Me.TableLayoutPanel1.SetColumnSpan(Me.DtGridVw_Permisos, 5)
        Me.DtGridVw_Permisos.DataSource = Me.PermisosBindingSource
        Me.DtGridVw_Permisos.Location = New System.Drawing.Point(3, 26)
        Me.DtGridVw_Permisos.Name = "DtGridVw_Permisos"
        Me.DtGridVw_Permisos.ReadOnly = True
        Me.DtGridVw_Permisos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DtGridVw_Permisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtGridVw_Permisos.Size = New System.Drawing.Size(679, 248)
        Me.DtGridVw_Permisos.TabIndex = 2
        '
        'RutDataGridViewTextBoxColumn
        '
        Me.RutDataGridViewTextBoxColumn.DataPropertyName = "rut"
        Me.RutDataGridViewTextBoxColumn.HeaderText = "rut"
        Me.RutDataGridViewTextBoxColumn.Name = "RutDataGridViewTextBoxColumn"
        Me.RutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodinternoDataGridViewTextBoxColumn
        '
        Me.CodinternoDataGridViewTextBoxColumn.DataPropertyName = "cod_interno"
        Me.CodinternoDataGridViewTextBoxColumn.HeaderText = "cod_interno"
        Me.CodinternoDataGridViewTextBoxColumn.Name = "CodinternoDataGridViewTextBoxColumn"
        Me.CodinternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodinternoDataGridViewTextBoxColumn.Visible = False
        '
        'PassDataGridViewTextBoxColumn
        '
        Me.PassDataGridViewTextBoxColumn.DataPropertyName = "Pass"
        Me.PassDataGridViewTextBoxColumn.HeaderText = "Pass"
        Me.PassDataGridViewTextBoxColumn.Name = "PassDataGridViewTextBoxColumn"
        Me.PassDataGridViewTextBoxColumn.ReadOnly = True
        Me.PassDataGridViewTextBoxColumn.Visible = False
        '
        'MantParamDataGridViewCheckBoxColumn
        '
        Me.MantParamDataGridViewCheckBoxColumn.DataPropertyName = "Mant_Param"
        Me.MantParamDataGridViewCheckBoxColumn.HeaderText = "Mant_Param"
        Me.MantParamDataGridViewCheckBoxColumn.Name = "MantParamDataGridViewCheckBoxColumn"
        Me.MantParamDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'SolAlmDataGridViewCheckBoxColumn
        '
        Me.SolAlmDataGridViewCheckBoxColumn.DataPropertyName = "Sol_Alm"
        Me.SolAlmDataGridViewCheckBoxColumn.HeaderText = "Sol_Alm"
        Me.SolAlmDataGridViewCheckBoxColumn.Name = "SolAlmDataGridViewCheckBoxColumn"
        Me.SolAlmDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'MantAlmDataGridViewCheckBoxColumn
        '
        Me.MantAlmDataGridViewCheckBoxColumn.DataPropertyName = "Mant_Alm"
        Me.MantAlmDataGridViewCheckBoxColumn.HeaderText = "Mant_Alm"
        Me.MantAlmDataGridViewCheckBoxColumn.Name = "MantAlmDataGridViewCheckBoxColumn"
        Me.MantAlmDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ImpLiquiDataGridViewCheckBoxColumn
        '
        Me.ImpLiquiDataGridViewCheckBoxColumn.DataPropertyName = "Imp_Liqui"
        Me.ImpLiquiDataGridViewCheckBoxColumn.HeaderText = "Imp_Liqui"
        Me.ImpLiquiDataGridViewCheckBoxColumn.Name = "ImpLiquiDataGridViewCheckBoxColumn"
        Me.ImpLiquiDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FechaGrabaDataGridViewTextBoxColumn
        '
        Me.FechaGrabaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Graba"
        Me.FechaGrabaDataGridViewTextBoxColumn.HeaderText = "Fecha_Graba"
        Me.FechaGrabaDataGridViewTextBoxColumn.Name = "FechaGrabaDataGridViewTextBoxColumn"
        Me.FechaGrabaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaGrabaDataGridViewTextBoxColumn.Visible = False
        '
        'UserGrabaDataGridViewTextBoxColumn
        '
        Me.UserGrabaDataGridViewTextBoxColumn.DataPropertyName = "User_Graba"
        Me.UserGrabaDataGridViewTextBoxColumn.HeaderText = "User_Graba"
        Me.UserGrabaDataGridViewTextBoxColumn.Name = "UserGrabaDataGridViewTextBoxColumn"
        Me.UserGrabaDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserGrabaDataGridViewTextBoxColumn.Visible = False
        '
        'PermisosBindingSource
        '
        Me.PermisosBindingSource.DataMember = "Permisos"
        Me.PermisosBindingSource.DataSource = Me.SAC_MindugarDataSet
        '
        'Bttn_Volver
        '
        Me.Bttn_Volver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bttn_Volver.Location = New System.Drawing.Point(14, 411)
        Me.Bttn_Volver.Name = "Bttn_Volver"
        Me.Bttn_Volver.Size = New System.Drawing.Size(94, 26)
        Me.Bttn_Volver.TabIndex = 2
        Me.Bttn_Volver.Text = "Volver al Inicio"
        Me.Bttn_Volver.UseVisualStyleBackColor = True
        '
        'PermisosTableAdapter
        '
        Me.PermisosTableAdapter.ClearBeforeFill = True
        '
        'Colaciones_ParametrosTableAdapter
        '
        Me.Colaciones_ParametrosTableAdapter.ClearBeforeFill = True
        '
        'Frm_Parametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1063, 445)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Frm_Parametros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frm_Parametros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Pnl_ValoresCol.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.DtGridVw_ValoresCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColacionesParametrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SACMindugarDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAC_MindugarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Permisos.ResumeLayout(False)
        Me.Pnl_Permisos.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DtGridVw_Permisos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermisosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Pnl_Permisos As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Lbl_Titulo As Label
    Friend WithEvents DtGridVw_Permisos As DataGridView
    Friend WithEvents ChckBx_MantAlmuerzos As CheckBox
    Friend WithEvents ChckBx_Parametros As CheckBox
    Friend WithEvents ChckBx_ImpLiquidaciones As CheckBox
    Friend WithEvents ChckBx_SolicitudAlm As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Bttn_GrabaPermisos As Button
    Friend WithEvents Pnl_ValoresCol As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents DtGridVw_ValoresCol As DataGridView
    Friend WithEvents Bttn_Grabar As Button
    'Friend WithEvents _Min_Colaciones_ParametrosTableAdapter As SBO_COMERCIALDataSet1TableAdapters._Min_Colaciones_ParametrosTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DtTm_FechaCol As DateTimePicker
    Friend WithEvents TxtBx_ValorCol As TextBox
    Friend WithEvents TxtBx_ValorDec As TextBox
    Friend WithEvents Bttn_Nuevo As Button
    Friend WithEvents Lbl_ID As Label
    Friend WithEvents TxtBx_Id As TextBox
    Friend WithEvents SAC_MindugarDataSet As SAC_MindugarDataSet
    Friend WithEvents PermisosBindingSource As BindingSource
    Friend WithEvents PermisosTableAdapter As SAC_MindugarDataSetTableAdapters.PermisosTableAdapter
    Friend WithEvents RutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodinternoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MantParamDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SolAlmDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents MantAlmDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ImpLiquiDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FechaGrabaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserGrabaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SACMindugarDataSetBindingSource As BindingSource
    Friend WithEvents ColacionesParametrosBindingSource As BindingSource
    Friend WithEvents Colaciones_ParametrosTableAdapter As SAC_MindugarDataSetTableAdapters.Colaciones_ParametrosTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorDescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdUsrActualizacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FecActualizacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Public WithEvents Bttn_Volver As Button
    Public WithEvents Button2 As Button
    Public WithEvents Button3 As Button
End Class

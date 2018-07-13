<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Informes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbBx_Informe = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CmbBx_Informe_Orden = New System.Windows.Forms.ComboBox()
        Me.DtTimPickr_Fecha_Ini = New System.Windows.Forms.DateTimePicker()
        Me.Bttn_GenerarInf = New System.Windows.Forms.Button()
        Me.DataGridView1 = New MetroFramework.Controls.MetroGrid()
        Me.DtTimPickr_Fecha_Fin = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBx_TotLeche = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TB_Total = New System.Windows.Forms.TextBox()
        Me.TxtBx_TotCol = New System.Windows.Forms.TextBox()
        Me.TB_Tot_ExtGcial = New System.Windows.Forms.TextBox()
        Me.TB_Tot_ExtNorm = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbBx_Informe_Empresa = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbBx_Informe_TipColac = New System.Windows.Forms.ComboBox()
        Me.CmbBx_Periodos = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CmbBx_ResumDetall = New System.Windows.Forms.ComboBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(384, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ordenado Por : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Informe :"
        '
        'CmbBx_Informe
        '
        Me.CmbBx_Informe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBx_Informe.FormattingEnabled = True
        Me.CmbBx_Informe.Items.AddRange(New Object() {"Informe de Colaciones Diarias", "Informe de Colaciones Entre Fechas", "Informe de Descuentos GESPER", "Informes de Colaciones Emitidas Reloj Control"})
        Me.CmbBx_Informe.Location = New System.Drawing.Point(83, 10)
        Me.CmbBx_Informe.Name = "CmbBx_Informe"
        Me.CmbBx_Informe.Size = New System.Drawing.Size(289, 25)
        Me.CmbBx_Informe.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Image = Global.RRHH.My.Resources.Resources.home_shape_32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(18, 430)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 57)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Volver"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CmbBx_Informe_Orden
        '
        Me.CmbBx_Informe_Orden.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBx_Informe_Orden.FormattingEnabled = True
        Me.CmbBx_Informe_Orden.Items.AddRange(New Object() {"R.U.T", "Nombre", "Apellidos"})
        Me.CmbBx_Informe_Orden.Location = New System.Drawing.Point(511, 10)
        Me.CmbBx_Informe_Orden.Name = "CmbBx_Informe_Orden"
        Me.CmbBx_Informe_Orden.Size = New System.Drawing.Size(162, 25)
        Me.CmbBx_Informe_Orden.TabIndex = 5
        '
        'DtTimPickr_Fecha_Ini
        '
        Me.DtTimPickr_Fecha_Ini.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtTimPickr_Fecha_Ini.Location = New System.Drawing.Point(82, 38)
        Me.DtTimPickr_Fecha_Ini.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.DtTimPickr_Fecha_Ini.Name = "DtTimPickr_Fecha_Ini"
        Me.DtTimPickr_Fecha_Ini.Size = New System.Drawing.Size(289, 25)
        Me.DtTimPickr_Fecha_Ini.TabIndex = 6
        '
        'Bttn_GenerarInf
        '
        Me.Bttn_GenerarInf.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Bttn_GenerarInf.FlatAppearance.BorderSize = 0
        Me.Bttn_GenerarInf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bttn_GenerarInf.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Bttn_GenerarInf.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bttn_GenerarInf.Image = Global.RRHH.My.Resources.Resources.list_document_interface_symbol32
        Me.Bttn_GenerarInf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bttn_GenerarInf.Location = New System.Drawing.Point(695, 10)
        Me.Bttn_GenerarInf.Margin = New System.Windows.Forms.Padding(0)
        Me.Bttn_GenerarInf.Name = "Bttn_GenerarInf"
        Me.Bttn_GenerarInf.Size = New System.Drawing.Size(189, 53)
        Me.Bttn_GenerarInf.TabIndex = 7
        Me.Bttn_GenerarInf.Text = "Generar"
        Me.Bttn_GenerarInf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bttn_GenerarInf.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(18, 96)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(866, 289)
        Me.DataGridView1.TabIndex = 8
        '
        'DtTimPickr_Fecha_Fin
        '
        Me.DtTimPickr_Fecha_Fin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtTimPickr_Fecha_Fin.Location = New System.Drawing.Point(385, 38)
        Me.DtTimPickr_Fecha_Fin.Name = "DtTimPickr_Fecha_Fin"
        Me.DtTimPickr_Fecha_Fin.Size = New System.Drawing.Size(289, 25)
        Me.DtTimPickr_Fecha_Fin.TabIndex = 9
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 12
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.174312!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.82569!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 10, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBx_TotLeche, 11, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TB_Total, 9, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBx_TotCol, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TB_Tot_ExtGcial, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TB_Tot_ExtNorm, 7, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(18, 394)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(866, 27)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Extras Gcia."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(3, 27)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Almuerzos"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Almuerzos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(702, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Lecha/ 3 Panes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtBx_TotLeche
        '
        Me.TxtBx_TotLeche.Location = New System.Drawing.Point(799, 3)
        Me.TxtBx_TotLeche.Name = "TxtBx_TotLeche"
        Me.TxtBx_TotLeche.ReadOnly = True
        Me.TxtBx_TotLeche.Size = New System.Drawing.Size(52, 20)
        Me.TxtBx_TotLeche.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(534, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Total"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(231, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Extras Gcia."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(362, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Extras Norm."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TB_Total
        '
        Me.TB_Total.Location = New System.Drawing.Point(613, 3)
        Me.TB_Total.Name = "TB_Total"
        Me.TB_Total.ReadOnly = True
        Me.TB_Total.Size = New System.Drawing.Size(54, 20)
        Me.TB_Total.TabIndex = 2
        '
        'TxtBx_TotCol
        '
        Me.TxtBx_TotCol.Location = New System.Drawing.Point(170, 3)
        Me.TxtBx_TotCol.Name = "TxtBx_TotCol"
        Me.TxtBx_TotCol.ReadOnly = True
        Me.TxtBx_TotCol.Size = New System.Drawing.Size(45, 20)
        Me.TxtBx_TotCol.TabIndex = 8
        '
        'TB_Tot_ExtGcial
        '
        Me.TB_Tot_ExtGcial.Location = New System.Drawing.Point(307, 3)
        Me.TB_Tot_ExtGcial.Name = "TB_Tot_ExtGcial"
        Me.TB_Tot_ExtGcial.ReadOnly = True
        Me.TB_Tot_ExtGcial.Size = New System.Drawing.Size(45, 20)
        Me.TB_Tot_ExtGcial.TabIndex = 13
        '
        'TB_Tot_ExtNorm
        '
        Me.TB_Tot_ExtNorm.Location = New System.Drawing.Point(479, 3)
        Me.TB_Tot_ExtNorm.Name = "TB_Tot_ExtNorm"
        Me.TB_Tot_ExtNorm.ReadOnly = True
        Me.TB_Tot_ExtNorm.Size = New System.Drawing.Size(45, 20)
        Me.TB_Tot_ExtNorm.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Empresa"
        '
        'CmbBx_Informe_Empresa
        '
        Me.CmbBx_Informe_Empresa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBx_Informe_Empresa.FormattingEnabled = True
        Me.CmbBx_Informe_Empresa.Items.AddRange(New Object() {"Todas Las Empresas", "096588890-K          Mindugar S.A", "083073600-K          Mindugar Industrial", "076033420-0          Mindugar Montajes", "Solo Gerentes"})
        Me.CmbBx_Informe_Empresa.Location = New System.Drawing.Point(82, 66)
        Me.CmbBx_Informe_Empresa.Name = "CmbBx_Informe_Empresa"
        Me.CmbBx_Informe_Empresa.Size = New System.Drawing.Size(289, 25)
        Me.CmbBx_Informe_Empresa.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(384, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Tipo de Colaciones"
        '
        'CmbBx_Informe_TipColac
        '
        Me.CmbBx_Informe_TipColac.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBx_Informe_TipColac.FormattingEnabled = True
        Me.CmbBx_Informe_TipColac.Items.AddRange(New Object() {"Todas", "Almuerzo", "Colacione"})
        Me.CmbBx_Informe_TipColac.Location = New System.Drawing.Point(510, 66)
        Me.CmbBx_Informe_TipColac.Name = "CmbBx_Informe_TipColac"
        Me.CmbBx_Informe_TipColac.Size = New System.Drawing.Size(163, 25)
        Me.CmbBx_Informe_TipColac.TabIndex = 14
        '
        'CmbBx_Periodos
        '
        Me.CmbBx_Periodos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBx_Periodos.FormattingEnabled = True
        Me.CmbBx_Periodos.Location = New System.Drawing.Point(220, 430)
        Me.CmbBx_Periodos.Name = "CmbBx_Periodos"
        Me.CmbBx_Periodos.Size = New System.Drawing.Size(289, 25)
        Me.CmbBx_Periodos.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Image = Global.RRHH.My.Resources.Resources.white_ms_excel_32
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(734, 430)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 57)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Exportar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " a EXCEL"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(201, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(45, 20)
        Me.TextBox1.TabIndex = 6
        '
        'CmbBx_ResumDetall
        '
        Me.CmbBx_ResumDetall.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBx_ResumDetall.FormattingEnabled = True
        Me.CmbBx_ResumDetall.Items.AddRange(New Object() {"Resumida ", "Detallada por Día"})
        Me.CmbBx_ResumDetall.Location = New System.Drawing.Point(220, 461)
        Me.CmbBx_ResumDetall.Name = "CmbBx_ResumDetall"
        Me.CmbBx_ResumDetall.Size = New System.Drawing.Size(289, 25)
        Me.CmbBx_ResumDetall.TabIndex = 18
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel1.Controls.Add(Me.DtTimPickr_Fecha_Ini)
        Me.MetroPanel1.Controls.Add(Me.Button2)
        Me.MetroPanel1.Controls.Add(Me.CmbBx_ResumDetall)
        Me.MetroPanel1.Controls.Add(Me.CmbBx_Informe)
        Me.MetroPanel1.Controls.Add(Me.CmbBx_Periodos)
        Me.MetroPanel1.Controls.Add(Me.CmbBx_Informe_TipColac)
        Me.MetroPanel1.Controls.Add(Me.Label2)
        Me.MetroPanel1.Controls.Add(Me.Label7)
        Me.MetroPanel1.Controls.Add(Me.CmbBx_Informe_Empresa)
        Me.MetroPanel1.Controls.Add(Me.Button1)
        Me.MetroPanel1.Controls.Add(Me.CmbBx_Informe_Orden)
        Me.MetroPanel1.Controls.Add(Me.TableLayoutPanel1)
        Me.MetroPanel1.Controls.Add(Me.DtTimPickr_Fecha_Fin)
        Me.MetroPanel1.Controls.Add(Me.Bttn_GenerarInf)
        Me.MetroPanel1.Controls.Add(Me.DataGridView1)
        Me.MetroPanel1.Controls.Add(Me.Label1)
        Me.MetroPanel1.Controls.Add(Me.Label3)
        Me.MetroPanel1.Controls.Add(Me.Label6)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(23, 63)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(906, 498)
        Me.MetroPanel1.TabIndex = 19
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'Frm_Informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 685)
        Me.Controls.Add(Me.MetroPanel1)
        Me.MaximizeBox = False
        Me.Name = "Frm_Informes"
        Me.Text = "Informes de Colaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbBx_Informe As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CmbBx_Informe_Orden As ComboBox
    Friend WithEvents DtTimPickr_Fecha_Ini As DateTimePicker
    Friend WithEvents Bttn_GenerarInf As Button
    Friend WithEvents DataGridView1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents DtTimPickr_Fecha_Fin As DateTimePicker
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_Total As TextBox
    Friend WithEvents TxtBx_TotLeche As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbBx_Informe_Empresa As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CmbBx_Informe_TipColac As ComboBox
    Friend WithEvents CmbBx_Periodos As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtBx_TotCol As TextBox
    Friend WithEvents TB_Tot_ExtGcial As TextBox
    Friend WithEvents TB_Tot_ExtNorm As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CmbBx_ResumDetall As ComboBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
End Class

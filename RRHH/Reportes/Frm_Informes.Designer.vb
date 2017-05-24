<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Informes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbBx_Informe = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CmbBx_Informe_Orden = New System.Windows.Forms.ComboBox()
        Me.DtTimPickr_Fecha_Ini = New System.Windows.Forms.DateTimePicker()
        Me.Bttn_GenerarInf = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(374, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ordenado Por : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Informe :"
        '
        'CmbBx_Informe
        '
        Me.CmbBx_Informe.FormattingEnabled = True
        Me.CmbBx_Informe.Items.AddRange(New Object() {"Informe de Colaciones Diarias", "Informe de Colaciones Entre Fechas", "Informe de Descuentos GESPER"})
        Me.CmbBx_Informe.Location = New System.Drawing.Point(142, 9)
        Me.CmbBx_Informe.Name = "CmbBx_Informe"
        Me.CmbBx_Informe.Size = New System.Drawing.Size(226, 21)
        Me.CmbBx_Informe.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CmbBx_Informe_Orden
        '
        Me.CmbBx_Informe_Orden.FormattingEnabled = True
        Me.CmbBx_Informe_Orden.Items.AddRange(New Object() {"R.U.T", "Nombre", "Apellidos"})
        Me.CmbBx_Informe_Orden.Location = New System.Drawing.Point(471, 9)
        Me.CmbBx_Informe_Orden.Name = "CmbBx_Informe_Orden"
        Me.CmbBx_Informe_Orden.Size = New System.Drawing.Size(121, 21)
        Me.CmbBx_Informe_Orden.TabIndex = 5
        '
        'DtTimPickr_Fecha_Ini
        '
        Me.DtTimPickr_Fecha_Ini.Location = New System.Drawing.Point(142, 36)
        Me.DtTimPickr_Fecha_Ini.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.DtTimPickr_Fecha_Ini.Name = "DtTimPickr_Fecha_Ini"
        Me.DtTimPickr_Fecha_Ini.Size = New System.Drawing.Size(200, 20)
        Me.DtTimPickr_Fecha_Ini.TabIndex = 6
        '
        'Bttn_GenerarInf
        '
        Me.Bttn_GenerarInf.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bttn_GenerarInf.Location = New System.Drawing.Point(647, 62)
        Me.Bttn_GenerarInf.Name = "Bttn_GenerarInf"
        Me.Bttn_GenerarInf.Size = New System.Drawing.Size(152, 23)
        Me.Bttn_GenerarInf.TabIndex = 7
        Me.Bttn_GenerarInf.Text = "Generar"
        Me.Bttn_GenerarInf.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Location = New System.Drawing.Point(30, 89)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(769, 257)
        Me.DataGridView1.TabIndex = 8
        '
        'DtTimPickr_Fecha_Fin
        '
        Me.DtTimPickr_Fecha_Fin.Location = New System.Drawing.Point(392, 36)
        Me.DtTimPickr_Fecha_Fin.Name = "DtTimPickr_Fecha_Fin"
        Me.DtTimPickr_Fecha_Fin.Size = New System.Drawing.Size(200, 20)
        Me.DtTimPickr_Fecha_Fin.TabIndex = 9
        '
        'TableLayoutPanel1
        '
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(30, 360)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(769, 27)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(5, 27)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Extras Gcia."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Almuerzos"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 7)
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
        Me.Label5.Location = New System.Drawing.Point(615, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Lecha/ 3 Panes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtBx_TotLeche
        '
        Me.TxtBx_TotLeche.Location = New System.Drawing.Point(712, 3)
        Me.TxtBx_TotLeche.Name = "TxtBx_TotLeche"
        Me.TxtBx_TotLeche.ReadOnly = True
        Me.TxtBx_TotLeche.Size = New System.Drawing.Size(52, 20)
        Me.TxtBx_TotLeche.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(447, 7)
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
        Me.Label9.Location = New System.Drawing.Point(144, 7)
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
        Me.Label12.Location = New System.Drawing.Point(275, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Extras Norm."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TB_Total
        '
        Me.TB_Total.Location = New System.Drawing.Point(526, 3)
        Me.TB_Total.Name = "TB_Total"
        Me.TB_Total.ReadOnly = True
        Me.TB_Total.Size = New System.Drawing.Size(54, 20)
        Me.TB_Total.TabIndex = 2
        '
        'TxtBx_TotCol
        '
        Me.TxtBx_TotCol.Location = New System.Drawing.Point(83, 3)
        Me.TxtBx_TotCol.Name = "TxtBx_TotCol"
        Me.TxtBx_TotCol.ReadOnly = True
        Me.TxtBx_TotCol.Size = New System.Drawing.Size(45, 20)
        Me.TxtBx_TotCol.TabIndex = 8
        '
        'TB_Tot_ExtGcial
        '
        Me.TB_Tot_ExtGcial.Location = New System.Drawing.Point(220, 3)
        Me.TB_Tot_ExtGcial.Name = "TB_Tot_ExtGcial"
        Me.TB_Tot_ExtGcial.ReadOnly = True
        Me.TB_Tot_ExtGcial.Size = New System.Drawing.Size(45, 20)
        Me.TB_Tot_ExtGcial.TabIndex = 13
        '
        'TB_Tot_ExtNorm
        '
        Me.TB_Tot_ExtNorm.Location = New System.Drawing.Point(392, 3)
        Me.TB_Tot_ExtNorm.Name = "TB_Tot_ExtNorm"
        Me.TB_Tot_ExtNorm.ReadOnly = True
        Me.TB_Tot_ExtNorm.Size = New System.Drawing.Size(45, 20)
        Me.TB_Tot_ExtNorm.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Empresa"
        '
        'CmbBx_Informe_Empresa
        '
        Me.CmbBx_Informe_Empresa.FormattingEnabled = True
        Me.CmbBx_Informe_Empresa.Items.AddRange(New Object() {"Todas Las Empresas", "096588890-K          Mindugar S.A", "083073600-K          Mindugar Industrial", "076033420-0          Mindugar Montajes"})
        Me.CmbBx_Informe_Empresa.Location = New System.Drawing.Point(142, 62)
        Me.CmbBx_Informe_Empresa.Name = "CmbBx_Informe_Empresa"
        Me.CmbBx_Informe_Empresa.Size = New System.Drawing.Size(200, 21)
        Me.CmbBx_Informe_Empresa.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(374, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Tipo de Colaciones"
        '
        'CmbBx_Informe_TipColac
        '
        Me.CmbBx_Informe_TipColac.FormattingEnabled = True
        Me.CmbBx_Informe_TipColac.Items.AddRange(New Object() {"Todas", "Almuerzo", "Colacione"})
        Me.CmbBx_Informe_TipColac.Location = New System.Drawing.Point(506, 62)
        Me.CmbBx_Informe_TipColac.Name = "CmbBx_Informe_TipColac"
        Me.CmbBx_Informe_TipColac.Size = New System.Drawing.Size(121, 21)
        Me.CmbBx_Informe_TipColac.TabIndex = 14
        '
        'CmbBx_Periodos
        '
        Me.CmbBx_Periodos.FormattingEnabled = True
        Me.CmbBx_Periodos.Location = New System.Drawing.Point(647, 12)
        Me.CmbBx_Periodos.Name = "CmbBx_Periodos"
        Me.CmbBx_Periodos.Size = New System.Drawing.Size(162, 21)
        Me.CmbBx_Periodos.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(564, 395)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(235, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Exportar vista a EXCELL"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.CmbBx_ResumDetall.FormattingEnabled = True
        Me.CmbBx_ResumDetall.Items.AddRange(New Object() {"Resumida ", "Detallada por Día"})
        Me.CmbBx_ResumDetall.Location = New System.Drawing.Point(647, 33)
        Me.CmbBx_ResumDetall.Name = "CmbBx_ResumDetall"
        Me.CmbBx_ResumDetall.Size = New System.Drawing.Size(162, 21)
        Me.CmbBx_ResumDetall.TabIndex = 18
        '
        'Frm_Informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 430)
        Me.Controls.Add(Me.CmbBx_ResumDetall)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CmbBx_Periodos)
        Me.Controls.Add(Me.CmbBx_Informe_TipColac)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CmbBx_Informe_Empresa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DtTimPickr_Fecha_Fin)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Bttn_GenerarInf)
        Me.Controls.Add(Me.DtTimPickr_Fecha_Ini)
        Me.Controls.Add(Me.CmbBx_Informe_Orden)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CmbBx_Informe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Frm_Informes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Informes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbBx_Informe As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CmbBx_Informe_Orden As ComboBox
    Friend WithEvents DtTimPickr_Fecha_Ini As DateTimePicker
    Friend WithEvents Bttn_GenerarInf As Button
    Friend WithEvents DataGridView1 As DataGridView
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
End Class

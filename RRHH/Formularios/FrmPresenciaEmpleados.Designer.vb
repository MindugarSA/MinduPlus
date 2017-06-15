<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPresenciaEmpleados
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvPresencias = New MetroFramework.Controls.MetroGrid()
        Me.cmbEmpresas = New MetroFramework.Controls.MetroComboBox()
        Me.cmbDepartamentos = New MetroFramework.Controls.MetroComboBox()
        Me.cmbCargos = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.chkAusentes = New MetroFramework.Controls.MetroCheckBox()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        CType(Me.dgvPresencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPresencias
        '
        Me.dgvPresencias.AllowUserToResizeRows = False
        Me.dgvPresencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPresencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.dgvPresencias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPresencias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPresencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvPresencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPresencias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPresencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPresencias.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPresencias.EnableHeadersVisualStyles = False
        Me.dgvPresencias.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvPresencias.GridColor = System.Drawing.Color.Black
        Me.dgvPresencias.Location = New System.Drawing.Point(49, 113)
        Me.dgvPresencias.Name = "dgvPresencias"
        Me.dgvPresencias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPresencias.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPresencias.RowHeadersVisible = False
        Me.dgvPresencias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPresencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPresencias.Size = New System.Drawing.Size(1092, 411)
        Me.dgvPresencias.TabIndex = 0
        '
        'cmbEmpresas
        '
        Me.cmbEmpresas.FormattingEnabled = True
        Me.cmbEmpresas.ItemHeight = 23
        Me.cmbEmpresas.Location = New System.Drawing.Point(118, 38)
        Me.cmbEmpresas.Name = "cmbEmpresas"
        Me.cmbEmpresas.Size = New System.Drawing.Size(260, 29)
        Me.cmbEmpresas.TabIndex = 1
        Me.cmbEmpresas.UseSelectable = True
        '
        'cmbDepartamentos
        '
        Me.cmbDepartamentos.FormattingEnabled = True
        Me.cmbDepartamentos.ItemHeight = 23
        Me.cmbDepartamentos.Location = New System.Drawing.Point(488, 37)
        Me.cmbDepartamentos.Name = "cmbDepartamentos"
        Me.cmbDepartamentos.Size = New System.Drawing.Size(236, 29)
        Me.cmbDepartamentos.TabIndex = 2
        Me.cmbDepartamentos.UseSelectable = True
        '
        'cmbCargos
        '
        Me.cmbCargos.FormattingEnabled = True
        Me.cmbCargos.ItemHeight = 23
        Me.cmbCargos.Location = New System.Drawing.Point(796, 38)
        Me.cmbCargos.Name = "cmbCargos"
        Me.cmbCargos.Size = New System.Drawing.Size(238, 29)
        Me.cmbCargos.TabIndex = 3
        Me.cmbCargos.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(49, 47)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Empresa:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(384, 47)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Departamento:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(741, 47)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Cargo:"
        '
        'chkAusentes
        '
        Me.chkAusentes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAusentes.AutoSize = True
        Me.chkAusentes.Location = New System.Drawing.Point(514, 92)
        Me.chkAusentes.Name = "chkAusentes"
        Me.chkAusentes.Size = New System.Drawing.Size(174, 15)
        Me.chkAusentes.TabIndex = 7
        Me.chkAusentes.Text = "Mostrar Solamente Ausentes"
        Me.chkAusentes.UseSelectable = True
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportarExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnExportarExcel.FlatAppearance.BorderSize = 0
        Me.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarExcel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportarExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExportarExcel.Image = Global.RRHH.My.Resources.Resources.white_ms_excel_32
        Me.btnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExportarExcel.Location = New System.Drawing.Point(479, 530)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(223, 80)
        Me.btnExportarExcel.TabIndex = 44
        Me.btnExportarExcel.Text = "Exportar a Excel"
        Me.btnExportarExcel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnExportarExcel.UseVisualStyleBackColor = False
        '
        'FrmPresenciaEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 622)
        Me.Controls.Add(Me.btnExportarExcel)
        Me.Controls.Add(Me.chkAusentes)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.cmbCargos)
        Me.Controls.Add(Me.cmbDepartamentos)
        Me.Controls.Add(Me.cmbEmpresas)
        Me.Controls.Add(Me.dgvPresencias)
        Me.Name = "FrmPresenciaEmpleados"
        Me.Text = "FrmPresenciaEmpleados"
        CType(Me.dgvPresencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPresencias As MetroFramework.Controls.MetroGrid
    Friend WithEvents cmbEmpresas As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbDepartamentos As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbCargos As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkAusentes As MetroFramework.Controls.MetroCheckBox
    Private WithEvents btnExportarExcel As Button
End Class

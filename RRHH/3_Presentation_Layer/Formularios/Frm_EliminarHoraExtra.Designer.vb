<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EliminarHoraExtra
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmbSolicitud = New MetroFramework.Controls.MetroComboBox()
        Me.dgvColaboradores = New MetroFramework.Controls.MetroGrid()
        Me.lblColaboradores = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txbDetalle = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txbSolicitante = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txbFechaSolicitud = New MetroFramework.Controls.MetroTextBox()
        Me.btnEliminar = New MetroFramework.Controls.MetroTile()
        CType(Me.dgvColaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbSolicitud
        '
        Me.cmbSolicitud.FormattingEnabled = True
        Me.cmbSolicitud.ItemHeight = 23
        Me.cmbSolicitud.Location = New System.Drawing.Point(130, 22)
        Me.cmbSolicitud.Name = "cmbSolicitud"
        Me.cmbSolicitud.Size = New System.Drawing.Size(126, 29)
        Me.cmbSolicitud.TabIndex = 0
        Me.cmbSolicitud.UseSelectable = True
        '
        'dgvColaboradores
        '
        Me.dgvColaboradores.AllowUserToResizeRows = False
        Me.dgvColaboradores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvColaboradores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvColaboradores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvColaboradores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvColaboradores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvColaboradores.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvColaboradores.EnableHeadersVisualStyles = False
        Me.dgvColaboradores.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvColaboradores.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvColaboradores.Location = New System.Drawing.Point(13, 201)
        Me.dgvColaboradores.Name = "dgvColaboradores"
        Me.dgvColaboradores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvColaboradores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvColaboradores.RowHeadersVisible = False
        Me.dgvColaboradores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvColaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvColaboradores.Size = New System.Drawing.Size(751, 220)
        Me.dgvColaboradores.TabIndex = 1
        '
        'lblColaboradores
        '
        Me.lblColaboradores.AutoSize = True
        Me.lblColaboradores.Location = New System.Drawing.Point(12, 170)
        Me.lblColaboradores.Name = "lblColaboradores"
        Me.lblColaboradores.Size = New System.Drawing.Size(100, 19)
        Me.lblColaboradores.TabIndex = 2
        Me.lblColaboradores.Text = "Colaboradores:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(13, 32)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Numero Solicitud:"
        '
        'txbDetalle
        '
        '
        '
        '
        Me.txbDetalle.CustomButton.Image = Nothing
        Me.txbDetalle.CustomButton.Location = New System.Drawing.Point(172, 2)
        Me.txbDetalle.CustomButton.Name = ""
        Me.txbDetalle.CustomButton.Size = New System.Drawing.Size(75, 75)
        Me.txbDetalle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbDetalle.CustomButton.TabIndex = 1
        Me.txbDetalle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbDetalle.CustomButton.UseSelectable = True
        Me.txbDetalle.CustomButton.Visible = False
        Me.txbDetalle.Lines = New String(-1) {}
        Me.txbDetalle.Location = New System.Drawing.Point(355, 32)
        Me.txbDetalle.MaxLength = 32767
        Me.txbDetalle.Multiline = True
        Me.txbDetalle.Name = "txbDetalle"
        Me.txbDetalle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbDetalle.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbDetalle.SelectedText = ""
        Me.txbDetalle.SelectionLength = 0
        Me.txbDetalle.SelectionStart = 0
        Me.txbDetalle.ShortcutsEnabled = True
        Me.txbDetalle.Size = New System.Drawing.Size(250, 80)
        Me.txbDetalle.TabIndex = 4
        Me.txbDetalle.UseSelectable = True
        Me.txbDetalle.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbDetalle.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(297, 33)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Detalle:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(13, 65)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Solicitante:"
        '
        'txbSolicitante
        '
        '
        '
        '
        Me.txbSolicitante.CustomButton.Image = Nothing
        Me.txbSolicitante.CustomButton.Location = New System.Drawing.Point(170, 1)
        Me.txbSolicitante.CustomButton.Name = ""
        Me.txbSolicitante.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txbSolicitante.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbSolicitante.CustomButton.TabIndex = 1
        Me.txbSolicitante.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbSolicitante.CustomButton.UseSelectable = True
        Me.txbSolicitante.CustomButton.Visible = False
        Me.txbSolicitante.Lines = New String(-1) {}
        Me.txbSolicitante.Location = New System.Drawing.Point(116, 65)
        Me.txbSolicitante.MaxLength = 32767
        Me.txbSolicitante.Name = "txbSolicitante"
        Me.txbSolicitante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbSolicitante.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbSolicitante.SelectedText = ""
        Me.txbSolicitante.SelectionLength = 0
        Me.txbSolicitante.SelectionStart = 0
        Me.txbSolicitante.ShortcutsEnabled = True
        Me.txbSolicitante.Size = New System.Drawing.Size(192, 23)
        Me.txbSolicitante.TabIndex = 7
        Me.txbSolicitante.UseSelectable = True
        Me.txbSolicitante.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbSolicitante.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(13, 107)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(96, 19)
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "Fecha Solicitud"
        '
        'txbFechaSolicitud
        '
        '
        '
        '
        Me.txbFechaSolicitud.CustomButton.Image = Nothing
        Me.txbFechaSolicitud.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txbFechaSolicitud.CustomButton.Name = ""
        Me.txbFechaSolicitud.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txbFechaSolicitud.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txbFechaSolicitud.CustomButton.TabIndex = 1
        Me.txbFechaSolicitud.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txbFechaSolicitud.CustomButton.UseSelectable = True
        Me.txbFechaSolicitud.CustomButton.Visible = False
        Me.txbFechaSolicitud.Lines = New String(-1) {}
        Me.txbFechaSolicitud.Location = New System.Drawing.Point(116, 107)
        Me.txbFechaSolicitud.MaxLength = 32767
        Me.txbFechaSolicitud.Name = "txbFechaSolicitud"
        Me.txbFechaSolicitud.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbFechaSolicitud.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbFechaSolicitud.SelectedText = ""
        Me.txbFechaSolicitud.SelectionLength = 0
        Me.txbFechaSolicitud.SelectionStart = 0
        Me.txbFechaSolicitud.ShortcutsEnabled = True
        Me.txbFechaSolicitud.Size = New System.Drawing.Size(75, 23)
        Me.txbFechaSolicitud.TabIndex = 9
        Me.txbFechaSolicitud.UseSelectable = True
        Me.txbFechaSolicitud.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txbFechaSolicitud.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnEliminar
        '
        Me.btnEliminar.ActiveControl = Nothing
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEliminar.Location = New System.Drawing.Point(623, 458)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(142, 87)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar Registro"
        Me.btnEliminar.TileImage = Global.RRHH.My.Resources.Resources.close_button32
        Me.btnEliminar.UseCustomBackColor = True
        Me.btnEliminar.UseSelectable = True
        Me.btnEliminar.UseTileImage = True
        '
        'Frm_EliminarHoraExtra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(785, 565)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txbFechaSolicitud)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txbSolicitante)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txbDetalle)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.lblColaboradores)
        Me.Controls.Add(Me.dgvColaboradores)
        Me.Controls.Add(Me.cmbSolicitud)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_EliminarHoraExtra"
        Me.Text = "Frm_EliminarHoraExtra"
        CType(Me.dgvColaboradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbSolicitud As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dgvColaboradores As MetroFramework.Controls.MetroGrid
    Friend WithEvents lblColaboradores As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txbDetalle As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txbSolicitante As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txbFechaSolicitud As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroTile
End Class

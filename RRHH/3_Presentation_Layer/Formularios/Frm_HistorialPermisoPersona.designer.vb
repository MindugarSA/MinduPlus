Partial Class Frm_HistorialPermisoPersona
    ''' <summary>
    ''' Variable del diseñador requerida.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Limpiar los recursos que se estén utilizando.
    ''' </summary>
    ''' <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Código generado por el Diseñador de Windows Forms"

    ''' <summary>
    ''' Método necesario para admitir el Diseñador. No se puede modificar
    ''' el contenido del método con el editor de código.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.dgvSolicitudesSalida = New System.Windows.Forms.DataGridView()
        Me.colNumeroSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDepartamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiaCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHorasTotales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipoPermiso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalHoras = New System.Windows.Forms.TextBox()
        CType(Me.dgvSolicitudesSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSolicitudesSalida
        '
        Me.dgvSolicitudesSalida.AllowUserToAddRows = False
        Me.dgvSolicitudesSalida.AllowUserToDeleteRows = False
        Me.dgvSolicitudesSalida.AllowUserToOrderColumns = True
        Me.dgvSolicitudesSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSolicitudesSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNumeroSolicitud, Me.colDepartamento, Me.colCargo, Me.colFechaSalida, Me.colDiaCompleto, Me.colHoraSalida, Me.colHoraEntrada, Me.colHorasTotales, Me.colTipoPermiso})
        Me.dgvSolicitudesSalida.Location = New System.Drawing.Point(1, 1)
        Me.dgvSolicitudesSalida.Name = "dgvSolicitudesSalida"
        Me.dgvSolicitudesSalida.Size = New System.Drawing.Size(785, 250)
        Me.dgvSolicitudesSalida.TabIndex = 17
        '
        'colNumeroSolicitud
        '
        Me.colNumeroSolicitud.HeaderText = "N°"
        Me.colNumeroSolicitud.Name = "colNumeroSolicitud"
        Me.colNumeroSolicitud.ReadOnly = True
        Me.colNumeroSolicitud.Width = 30
        '
        'colDepartamento
        '
        Me.colDepartamento.HeaderText = "Departamento"
        Me.colDepartamento.Name = "colDepartamento"
        Me.colDepartamento.ReadOnly = True
        Me.colDepartamento.Width = 130
        '
        'colCargo
        '
        Me.colCargo.HeaderText = "Cargo"
        Me.colCargo.Name = "colCargo"
        Me.colCargo.ReadOnly = True
        Me.colCargo.Width = 170
        '
        'colFechaSalida
        '
        Me.colFechaSalida.HeaderText = "Fecha de Salida"
        Me.colFechaSalida.Name = "colFechaSalida"
        Me.colFechaSalida.ReadOnly = True
        Me.colFechaSalida.Width = 70
        '
        'colDiaCompleto
        '
        Me.colDiaCompleto.HeaderText = "Dia Completo"
        Me.colDiaCompleto.Name = "colDiaCompleto"
        Me.colDiaCompleto.ReadOnly = True
        Me.colDiaCompleto.Width = 55
        '
        'colHoraSalida
        '
        Me.colHoraSalida.HeaderText = "Hora de Salida"
        Me.colHoraSalida.Name = "colHoraSalida"
        Me.colHoraSalida.ReadOnly = True
        Me.colHoraSalida.Width = 50
        '
        'colHoraEntrada
        '
        Me.colHoraEntrada.HeaderText = "Hora de Entrada"
        Me.colHoraEntrada.Name = "colHoraEntrada"
        Me.colHoraEntrada.ReadOnly = True
        Me.colHoraEntrada.Width = 50
        '
        'colHorasTotales
        '
        Me.colHorasTotales.HeaderText = "Horas Totales"
        Me.colHorasTotales.Name = "colHorasTotales"
        Me.colHorasTotales.ReadOnly = True
        Me.colHorasTotales.Width = 50
        '
        'colTipoPermiso
        '
        Me.colTipoPermiso.HeaderText = "Tipo de Permiso"
        Me.colTipoPermiso.Name = "colTipoPermiso"
        Me.colTipoPermiso.ReadOnly = True
        Me.colTipoPermiso.Width = 135
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(295, 257)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(187, 46)
        Me.btnOk.TabIndex = 18
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Total horas ausente en ultimos 10 permisos:"
        '
        'txtTotalHoras
        '
        Me.txtTotalHoras.Location = New System.Drawing.Point(231, 333)
        Me.txtTotalHoras.Name = "txtTotalHoras"
        Me.txtTotalHoras.ReadOnly = True
        Me.txtTotalHoras.Size = New System.Drawing.Size(87, 20)
        Me.txtTotalHoras.TabIndex = 20
        '
        'Frm_HistorialPermisoPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(785, 358)
        Me.Controls.Add(Me.txtTotalHoras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.dgvSolicitudesSalida)
        Me.Name = "Frm_HistorialPermisoPersona"
        Me.Text = "Form1"
        CType(Me.dgvSolicitudesSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Friend dgvSolicitudesSalida As System.Windows.Forms.DataGridView
    Friend WithEvents colNumeroSolicitud As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDepartamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaSalida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDiaCompleto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraSalida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraEntrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHorasTotales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoPermiso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotalHoras As System.Windows.Forms.TextBox

End Class


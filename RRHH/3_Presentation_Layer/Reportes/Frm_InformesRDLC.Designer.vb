<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_InformesRDLC
    Inherits MetroFramework.Forms.MetroForm

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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SpPRE_LIQUIDACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MINDU_INTERMEDIA = New RRHH.MINDU_INTERMEDIA()
        Me.reportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SpPRE_LIQUIDACIONTableAdapter = New RRHH.MINDU_INTERMEDIATableAdapters.SpPRE_LIQUIDACIONTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.SpPRE_LIQUIDACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MINDU_INTERMEDIA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpPRE_LIQUIDACIONBindingSource
        '
        Me.SpPRE_LIQUIDACIONBindingSource.DataMember = "SpPRE_LIQUIDACION"
        Me.SpPRE_LIQUIDACIONBindingSource.DataSource = Me.MINDU_INTERMEDIA
        '
        'MINDU_INTERMEDIA
        '
        Me.MINDU_INTERMEDIA.DataSetName = "MINDU_INTERMEDIA"
        Me.MINDU_INTERMEDIA.EnforceConstraints = False
        Me.MINDU_INTERMEDIA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'reportViewer1
        '
        Me.reportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.SpPRE_LIQUIDACIONBindingSource
        Me.reportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.reportViewer1.LocalReport.ReportEmbeddedResource = "RRHH.RptPreLiquidacion.rdlc"
        Me.reportViewer1.Location = New System.Drawing.Point(20, 60)
        Me.reportViewer1.Name = "reportViewer1"
        Me.reportViewer1.ServerReport.BearerToken = Nothing
        Me.reportViewer1.Size = New System.Drawing.Size(1075, 454)
        Me.reportViewer1.TabIndex = 1
        '
        'SpPRE_LIQUIDACIONTableAdapter
        '
        Me.SpPRE_LIQUIDACIONTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Image = Global.RRHH.My.Resources.Resources.printing_64
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(905, 407)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 89)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Imprimir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Image = Global.RRHH.My.Resources.Resources.home_shape64
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(21, 407)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 89)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Volver " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Al Inicio"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Frm_InformesRDLC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 534)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.reportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_InformesRDLC"
        Me.Text = "Frm_InformesRDLC"
        CType(Me.SpPRE_LIQUIDACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MINDU_INTERMEDIA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents reportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SpPRE_LIQUIDACIONBindingSource As BindingSource
    Friend WithEvents MINDU_INTERMEDIA As MINDU_INTERMEDIA
    Friend WithEvents SpPRE_LIQUIDACIONTableAdapter As MINDU_INTERMEDIATableAdapters.SpPRE_LIQUIDACIONTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class

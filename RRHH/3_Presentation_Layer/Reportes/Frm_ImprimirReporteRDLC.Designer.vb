<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ImprimirReporteRDLC
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SpPRELIQUIDACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MINDU_INTERMEDIA = New RRHH.MINDU_INTERMEDIA()
        Me.reportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SpPRE_LIQUIDACIONTableAdapter = New RRHH.MINDU_INTERMEDIATableAdapters.SpPRE_LIQUIDACIONTableAdapter()
        CType(Me.SpPRELIQUIDACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MINDU_INTERMEDIA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpPRELIQUIDACIONBindingSource
        '
        Me.SpPRELIQUIDACIONBindingSource.DataMember = "SpPRE_LIQUIDACION"
        Me.SpPRELIQUIDACIONBindingSource.DataSource = Me.MINDU_INTERMEDIA
        '
        'MINDU_INTERMEDIA
        '
        Me.MINDU_INTERMEDIA.DataSetName = "MINDU_INTERMEDIA"
        Me.MINDU_INTERMEDIA.EnforceConstraints = False
        Me.MINDU_INTERMEDIA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'reportViewer1
        '
        Me.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SpPRELIQUIDACIONBindingSource
        Me.reportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.reportViewer1.LocalReport.ReportEmbeddedResource = "RRHH.RptPreLiquidacion.rdlc"
        Me.reportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.reportViewer1.Name = "reportViewer1"
        Me.reportViewer1.ServerReport.BearerToken = Nothing
        Me.reportViewer1.Size = New System.Drawing.Size(1057, 533)
        Me.reportViewer1.TabIndex = 2
        '
        'SpPRE_LIQUIDACIONTableAdapter
        '
        Me.SpPRE_LIQUIDACIONTableAdapter.ClearBeforeFill = True
        '
        'Frm_ImprimirReporteRDLC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 533)
        Me.Controls.Add(Me.reportViewer1)
        Me.Name = "Frm_ImprimirReporteRDLC"
        Me.Text = "Imprimir Reporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SpPRELIQUIDACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MINDU_INTERMEDIA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents reportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SpPRELIQUIDACIONBindingSource As BindingSource
    Friend WithEvents MINDU_INTERMEDIA As MINDU_INTERMEDIA
    Friend WithEvents SpPRE_LIQUIDACIONTableAdapter As MINDU_INTERMEDIATableAdapters.SpPRE_LIQUIDACIONTableAdapter
End Class

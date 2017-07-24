Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine


Public Class Frm_ImprimirReporte

    Private reporte As ReportDocument
    Public Sub New(prmReporte As ReportDocument)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        reporte = prmReporte
        prmReporte.SetDatabaseLogon("sa", "Sqladmin281")
    End Sub

    Private Sub Frm_ImprimirPermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ReportSource = reporte
        CrystalReportViewer1.Zoom(140)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Frm_ImprimirReporte_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        reporte.Dispose()
        reporte.Close()
        Me.Dispose()
    End Sub

    Private Sub Frm_ImprimirReporte_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Visible = True
        Me.Refresh()
    End Sub

End Class
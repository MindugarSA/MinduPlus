Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class Frm_VisualizarReporte
    Private reporte As ReportDocument

    Public Sub New(prmReporte As ReportDocument)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        prmReporte.SetDatabaseLogon("sa", "Sqladmin281")
        reporte = prmReporte
    End Sub
    Private Sub Frm_VisualizarReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ReportSource = reporte
        CrystalReportViewer1.Zoom(140)
    End Sub
End Class
﻿Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine


Public Class Frm_ImprimirReporte

    Private reporte As ReportDocument
    Public Sub New(prmReporte As ReportDocument)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        prmReporte.SetDatabaseLogon("sa", "Sqladmin281")
        reporte = prmReporte
    End Sub

    Private Sub Frm_ImprimirPermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ReportSource = reporte
    End Sub
End Class
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms

Public Class Frm_ImprimirReporteRDLC
    Public Property TipoReporte As String
    Public Property Rut As String
    Public Property Año As String
    Public Property Mes As String
    Public Property RutEmp As String
    Public Property CallFrom As String
    Public Property ExternalWidth As Integer
    Public Property ExternalHeight As Integer

    Private Sub Frm_ImprimirReporteRDLC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case CallFrom
            Case "MDIParent1"
                Me.Width = MDIParent1.Panel2.Width
                Me.Height = MDIParent1.Panel2.Height
                Exit Select
            Case "Frm_InformePreLiquidaciones"
                Me.Width = ExternalWidth
                Me.Height = ExternalHeight
        End Select

        'TODO: esta línea de código carga datos en la tabla 'MINDU_INTERMEDIA.SpPRE_LIQUIDACION' Puede moverla o quitarla según sea necesario.
        Me.SpPRE_LIQUIDACIONTableAdapter.Fill(Me.MINDU_INTERMEDIA.SpPRE_LIQUIDACION, Rut, Año, Mes, RutEmp)

        Dim CurrentReportDataSource As New ReportDataSource()
        reportViewer1.LocalReport.DataSources.Clear()

        Select Case TipoReporte
            Case "PreLiquidacion"
                Me.Text = "Reporte de Preliquidacion"
                reportViewer1.LocalReport.ReportEmbeddedResource = "RRHH.RptPreLiquidacion.rdlc"
                CurrentReportDataSource.Name = "DataSet1"
                CurrentReportDataSource.Value = SpPRELIQUIDACIONBindingSource
                reportViewer1.LocalReport.DataSources.Add(CurrentReportDataSource)
                Exit Select
        End Select

        Me.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.reportViewer1.ZoomMode = ZoomMode.Percent
        Me.reportViewer1.ZoomPercent = 125
        Me.reportViewer1.RefreshReport()

    End Sub
End Class
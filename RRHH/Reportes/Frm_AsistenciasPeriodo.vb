Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class Frm_AsistenciasPeriodo

    Private reporte As ReportDocument
    Dim conexion As New SqlConnection
    Dim cmd As SqlCommand
    Dim dtPeriodos As New DataTable
    Dim iLoad As Integer = 0

    Public Sub New(prmReporte As ReportDocument)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        prmReporte.SetDatabaseLogon("sa", "Sqladmin281")
        reporte = prmReporte
    End Sub
    Private Sub Frm_AsistenciasPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CrystalReportViewer1.ReportSource = reporte
        CrystalReportViewer1.Zoom(140)

        conexion.ConnectionString = "Data Source=FSSAPBO;Initial Catalog = SAC_Mindugar; Persist Security Info=True;User ID = sa; Password=Sqladmin281"

        cmd = New SqlCommand("[MINDU_INTERMEDIA].[dbo].[SpASISTENCIA_Periodos_Registrados_Fechas]", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            conexion.Open()

            Dim adaptador As New SqlDataAdapter(cmd)
            Dim dt1 As New DataTable
            adaptador.Fill(dtPeriodos)
            If dtPeriodos.Rows.Count > 0 Then
                With MetroComboBox1
                    .DataSource = dtPeriodos
                    .DisplayMember = "PeriodoC"
                    .ValueMember = "PeriodoI"
                    .SelectedIndex = 0
                End With
            End If


        Catch ex As Exception
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        MDIParent1.Panel2.Visible = True
        MDIParent1.TiempoIngreso.Enabled = True
        MDIParent1.Visualizar_Tiles_MDI()
        MDIParent1.Desplazamiento_Tiles()
        Me.Close()

    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged

        iLoad += 1

        If iLoad > 1 Then

            Dim sPeriodo As String = MetroComboBox1.SelectedIndex
            Dim RutTrab As String = MDIParent1.Lbl_RutTrab.Text
            RutTrab = RutTrab.Remove(RutTrab.Length - 2)
            RutTrab = If(RutTrab.StartsWith("0"), RutTrab.Substring(1), RutTrab)
            Dim dFechaIni As Date = dtPeriodos.Rows(MetroComboBox1.SelectedIndex)(2)
            Dim dFechaFin As Date = dtPeriodos.Rows(MetroComboBox1.SelectedIndex)(3)

            reporte.SetParameterValue("@id", RutTrab)
            reporte.SetParameterValue("@fechaInicio", dFechaIni)
            reporte.SetParameterValue("@fechaTermino", dFechaFin)
            CrystalReportViewer1.ReportSource = reporte
            CrystalReportViewer1.Refresh()

            'informe.SetParameterValue("@id", "24869475")
            'informe.SetParameterValue("@fechaInicio", New DateTime(2017, 5, 21))
            'informe.SetParameterValue("@fechaTermino", New DateTime(2017, 6, 20))
        End If

    End Sub

    Private Sub MetroComboBox1_Click(sender As Object, e As EventArgs) Handles MetroComboBox1.Click
        iLoad = 3
    End Sub
End Class
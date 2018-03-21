Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports ImportarExcelSQLServer._2_Business_Layer

Public Class Form5

    Private dtDetalleHorasTrabajadas As DataTable
    Public Property sPeriodo As String

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Close()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarResumenHoras()
        FormatearGridResumen()
    End Sub

    Private Sub CargarResumenHoras()
        dtDetalleHorasTrabajadas = BAsistenciaPeriodo.ConsultarAsistenciaResumenHoras(sPeriodo)
        dataGridView1.DataSource = dtDetalleHorasTrabajadas
    End Sub

    Private Sub FormatearGridResumen()
        dataGridView1.AutoResizeColumns()
        For Each Col As DataGridViewTextBoxColumn In dataGridView1.Columns
            Col.[ReadOnly] = True
        Next
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        If dataGridView1.RowCount > 0 Then
            dataGridView1.ExportToExcel()
        End If
    End Sub
End Class
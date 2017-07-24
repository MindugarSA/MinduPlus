Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Partial Public Class Frm_HistorialPermisoPersona
    Inherits Form
    Private trabajador As Persona


    Public Sub New(ByVal nombreCompleto As String)
        InitializeComponent()
        trabajador = New Persona()
        trabajador.Nombre = nombreCompleto
        trabajador.BuscarRutPorNombre()
        CargarDGV()
        Me.Text = "Historial de " + nombreCompleto
    End Sub


    Public Sub CargarDGV()
        dgvSolicitudesSalida.Rows.Clear()
        Dim permisos As List(Of Permiso)
        permisos = Permiso.ListarPorPersonaTop(trabajador.Rut, 10)
        Dim i As Integer = 0
        Dim totalHoras As Integer = 0
        Dim minutos As Integer = 0
        For Each permiso__1 As Permiso In permisos
            dgvSolicitudesSalida.Rows.Add(1)
            dgvSolicitudesSalida.Rows(i).Cells("colNumeroSolicitud").Value = permiso__1.Id.ToString()
            dgvSolicitudesSalida.Rows(i).Cells("colDepartamento").Value = permiso__1.Departamento
            dgvSolicitudesSalida.Rows(i).Cells("colCargo").Value = permiso__1.Cargo
            dgvSolicitudesSalida.Rows(i).Cells("colFechaSalida").Value = permiso__1.FechaPermiso.ToString("dd-MM-yyyy")
            dgvSolicitudesSalida.Rows(i).Cells("colDiaCompleto").Value = If(permiso__1.DiaCompleto, "SI", "NO")
            If Not permiso__1.DiaCompleto Then
                dgvSolicitudesSalida.Rows(i).Cells("colHoraSalida").Value = permiso__1.HoraSalida.ToString("hh\:mm")
                dgvSolicitudesSalida.Rows(i).Cells("colHoraEntrada").Value = Convert.ToDateTime(permiso__1.HoraSalida.ToString()).AddHours(Math.Truncate(permiso__1.TotalHoras)).AddMinutes(Math.Round(60 * (permiso__1.TotalHoras - Math.Truncate(permiso__1.TotalHoras)))).ToString("HH:mm")
                dgvSolicitudesSalida.Rows(i).Cells("colHorasTotales").Value = New DateTime(2000, 1, 1, 0, 0, 0).AddHours(permiso__1.TotalHoras).ToString("HH:mm")
            End If
            dgvSolicitudesSalida.Rows(i).Cells("colTipoPermiso").Value = If(permiso__1.ComisonServicio, "COMISION SERVICIO", "PARTICULAR")
            i += 1
            totalHoras += Math.Truncate(permiso__1.TotalHoras)
            minutos += Math.Round(60 * (permiso__1.TotalHoras - Math.Truncate(permiso__1.TotalHoras)))
            If minutos >= 60 Then
                totalHoras += 1
                minutos -= 60
            End If
        Next
        If (minutos < 10) Then
            txtTotalHoras.Text = totalHoras & ":0" & minutos
        Else
            txtTotalHoras.Text = totalHoras & ":" & minutos
        End If

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub
End Class

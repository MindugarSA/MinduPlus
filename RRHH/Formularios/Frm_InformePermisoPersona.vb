Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports RRHH_Lib
Imports RRHH_Vista.Reportes

Public Partial Class Frm_InformePermisoPersona
	Inherits Form
    Private enableBuscarRutInformePermisos As Boolean = True
    Private enableBuscarNombreInformePermisos As Boolean = True
    Private enableBuscarInformePermisos As Boolean = False
    Private trabajadorInformePermisos As Persona
    Private parentPanel As Panel


    Public Sub New(prmParentPanel As Panel, altura As Integer, ancho As Integer)
        InitializeComponent()
        parentPanel = prmParentPanel
        If parentPanel IsNot Nothing Then
            parentPanel.Visible = False
        End If
        dtpInicioInformePermisos.Value = DateTime.Now
        dtpTerminoInformePermisos.Value = DateTime.Now

        cmbEmpresaInformePermisos.SelectedIndex = 0
        trabajadorInformePermisos = New Persona()
        trabajadorInformePermisos.Rut = ""

        trabajadorInformePermisos.Nombre = ""
        btnVolver.Location = New Point(20, altura - btnVolver.Size.Height - 40)
        btnImprimirInformePermisos.Location = New Point(btnVolver.Location.X + 800, btnVolver.Location.Y)
        btnBuscarInformePermisos.Location = New Point(btnVolver.Location.X + 400, btnVolver.Location.Y)
        Pnl_InformePermisos.Location = New Point(Convert.ToInt32(ancho / 2 - Pnl_InformePermisos.Width / 2), 0)
        dgvSolicitudesSalidaInformePermisos.Size = New Size(dgvSolicitudesSalidaInformePermisos.Size.Width, btnVolver.Location.Y - dgvSolicitudesSalidaInformePermisos.Location.Y - 20)

        Pnl_InformePermisos.Size = New Size(Pnl_InformePermisos.Size.Width, altura - btnVolver.Size.Height + 20)
    End Sub

    Private Sub autocompletarNombreRutInformePermisos(empresa As String)
        Dim listaNombre As New AutoCompleteStringCollection()
        Dim listaRut As New AutoCompleteStringCollection()
        Try
            Dim personas As List(Of Persona) = Persona.ListarPorEmpresa(empresa)

            For Each persona__1 As Persona In personas
                listaNombre.Add(persona__1.Nombre)
                listaRut.Add(persona__1.Rut)
            Next
            txbNombreInformePermisos.AutoCompleteCustomSource = listaNombre

            txbRutInformePermisos.AutoCompleteCustomSource = listaRut
        Catch ex As Exception
            MessageBox.Show("error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub cmbEmpresaInformePermisos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresaInformePermisos.SelectedIndexChanged
        autocompletarNombreRutInformePermisos(cmbEmpresaInformePermisos.Text)
        LimpiarDatosInformePermisos()
    End Sub

    Public Sub LimpiarDatosInformePermisos()
        txbNombreInformePermisos.Text = ""
        dgvSolicitudesSalidaInformePermisos.Rows.Clear()
        enableBuscarInformePermisos = False
    End Sub

    Private Sub txbNombreInformePermisos_TextChanged(sender As Object, e As EventArgs) Handles txbNombreInformePermisos.TextChanged
        If enableBuscarRutInformePermisos Then
            enableBuscarNombreInformePermisos = False
            trabajadorInformePermisos.Nombre = txbNombreInformePermisos.Text
            trabajadorInformePermisos.BuscarRutPorNombre()
            txbRutInformePermisos.Text = trabajadorInformePermisos.Rut
            dgvSolicitudesSalidaInformePermisos.Rows.Clear()
            enableBuscarInformePermisos = False
            enableBuscarNombreInformePermisos = True
        End If
    End Sub

    Private Sub txbRutInformePermisos_TextChanged(sender As Object, e As EventArgs) Handles txbRutInformePermisos.TextChanged
        If enableBuscarNombreInformePermisos Then
            enableBuscarRutInformePermisos = False
            trabajadorInformePermisos.Rut = txbRutInformePermisos.Text
            trabajadorInformePermisos.BuscarNombrePorRut()
            txbNombreInformePermisos.Text = trabajadorInformePermisos.Nombre
            dgvSolicitudesSalidaInformePermisos.Rows.Clear()
            enableBuscarInformePermisos = False
            enableBuscarRutInformePermisos = True
        End If
    End Sub

    Private Sub btnBuscarInformePermisos_Click(sender As Object, e As EventArgs) Handles btnBuscarInformePermisos.Click
        enableBuscarInformePermisos = True
        CargarDGVInformePermisos()
    End Sub


    Public Sub CargarDGVInformePermisos()
        If enableBuscarInformePermisos Then
            dgvSolicitudesSalidaInformePermisos.Rows.Clear()
            Dim inicio As New DateTime(dtpInicioInformePermisos.Value.Year, dtpInicioInformePermisos.Value.Month, dtpInicioInformePermisos.Value.Day, 0, 0, 0)
            Dim termino As New DateTime(dtpTerminoInformePermisos.Value.Year, dtpTerminoInformePermisos.Value.Month, dtpTerminoInformePermisos.Value.Day, 0, 0, 0)
            Dim permisos As List(Of Permiso)
            If Not chkBuscarTodosInformePermisos.Checked Then
                permisos = Permiso.ListarIntevalo(trabajadorInformePermisos.Rut, Nothing, inicio, termino)
            Else
                permisos = Permiso.ListarIntevalo(Nothing, cmbEmpresaInformePermisos.Text, inicio, termino)
            End If
            Dim i As Integer = 0
            For Each permiso__1 As Permiso In permisos
                dgvSolicitudesSalidaInformePermisos.Rows.Add(1)
                dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colNumeroSolicitudInformePermisos").Value = permiso__1.Id.ToString()
                dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colTrabajadorInformePermisos").Value = permiso__1.Trabajador
                dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colDepartamentoInformePermisos").Value = permiso__1.Departamento
                dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colCargoInformePermisos").Value = permiso__1.Cargo
                dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colFechaSalidaInformePermisos").Value = permiso__1.FechaPermiso.ToString("dd-MM-yyyy")
                dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colDiaCompletoInformePermisos").Value = If(permiso__1.DiaCompleto, "SI", "NO")
                If Not permiso__1.DiaCompleto Then
                    dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colHoraSalidaInformePermisos").Value = permiso__1.HoraSalida.ToString("hh\:mm")
                    dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colHoraEntradaInformePermisos").Value = Convert.ToDateTime(permiso__1.HoraSalida.ToString()).AddHours(permiso__1.TotalHoras).ToString("HH:mm")
                    dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colHorasTotalesInformePermisos").Value = New DateTime(2000, 1, 1, 0, 0, 0).AddHours(permiso__1.TotalHoras).ToString("HH:mm")
                End If
                dgvSolicitudesSalidaInformePermisos.Rows(i).Cells("colTipoPermisoInformePermisos").Value = If(permiso__1.ComisonServicio, "COMISION SERVICIO", "PARTICULAR")
                i += 1
            Next
        End If
    End Sub

    Private Sub dtpInicioInformePermisos_ValueChanged(sender As Object, e As EventArgs) Handles dtpInicioInformePermisos.ValueChanged
        CargarDGVInformePermisos()
    End Sub

    Private Sub dtpTerminoInformePermisos_ValueChanged(sender As Object, e As EventArgs) Handles dtpTerminoInformePermisos.ValueChanged
        CargarDGVInformePermisos()
    End Sub

    Private Sub btnImprimirInformePermisos_Click(sender As Object, e As EventArgs) Handles btnImprimirInformePermisos.Click
        If chkBuscarTodosInformePermisos.Checked Then
            Dim informe As New InformePermisos()
            informe.SetParameterValue("@empresa", cmbEmpresaInformePermisos.Text)
            informe.SetParameterValue("@fecha_inicio", dtpInicioInformePermisos.Value)
            informe.SetParameterValue("@fecha_termino", dtpTerminoInformePermisos.Value.AddDays(1))
            Dim formInforme As New Frm_ImprimirReporte(informe)
            formInforme.Show()
        Else
            Dim informe As New InformePermisoPersona()
            informe.SetParameterValue("@rut", txbRutInformePermisos.Text)
            informe.SetParameterValue("@fecha_inicio", dtpInicioInformePermisos.Value)
            informe.SetParameterValue("@fecha_termino", dtpTerminoInformePermisos.Value.AddDays(1))
            Dim formInforme As New Frm_ImprimirReporte(informe)
            formInforme.Show()
        End If
    End Sub

    Private Sub chkBuscarTodosInformePermisos_CheckedChanged(sender As Object, e As EventArgs) Handles chkBuscarTodosInformePermisos.CheckedChanged
        If chkBuscarTodosInformePermisos.Checked Then
            lblNombreInformePermisos.Visible = False
            lblRutInformePermisos.Visible = False
            txbNombreInformePermisos.Visible = False
            txbRutInformePermisos.Visible = False
            LimpiarDatosInformePermisos()
        Else
            lblNombreInformePermisos.Visible = True
            lblRutInformePermisos.Visible = True
            txbNombreInformePermisos.Visible = True
            txbRutInformePermisos.Visible = True
            LimpiarDatosInformePermisos()
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If parentPanel IsNot Nothing Then
            parentPanel.Visible = True
        End If
        Me.Close()
    End Sub
End Class

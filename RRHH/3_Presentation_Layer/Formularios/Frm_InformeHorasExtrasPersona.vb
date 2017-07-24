Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms



Public Partial Class Frm_InformeHorasExtrasPersona
	Inherits Form
    Private enableBuscarRutHHEE As Boolean = True
    Private enableBuscarNombreHHEE As Boolean = True
    Private enableBuscarHHEE As Boolean = False
    Private trabajadorHHEE As Persona
    Private parentPanel As Panel

    Public Sub New(prmParentPanel As Panel, altura As Integer, ancho As Double)
        InitializeComponent()
        parentPanel = prmParentPanel
        If parentPanel IsNot Nothing Then
            parentPanel.Visible = False
        End If
        dtpInicioInformeHHEE.Value = DateTime.Now
        dtpTerminoInformeHHEE.Value = DateTime.Now

        cmbEmpresaInformeHHEE.SelectedIndex = 0
        trabajadorHHEE = New Persona()
        trabajadorHHEE.Rut = ""
        trabajadorHHEE.Nombre = ""
        btnVolver.Location = New Point(20, altura - btnVolver.Size.Height - 40)
        btnImprimirInformeHHEE.Location = New Point(btnVolver.Location.X + 800, btnVolver.Location.Y)
        btnBuscarInformeHHEE.Location = New Point(btnVolver.Location.X + 400, btnVolver.Location.Y)
        dgvColaboradoresInformeHHEE.Size = New Size(dgvColaboradoresInformeHHEE.Size.Width, btnVolver.Location.Y - dgvColaboradoresInformeHHEE.Location.Y - 20)
        Pnl_InformeHHEE.Location = New Point(Convert.ToInt32(ancho / 2 - Pnl_InformeHHEE.Width / 2), 0)
        Pnl_InformeHHEE.Size = New Size(Pnl_InformeHHEE.Size.Width, altura - btnVolver.Size.Height + 20)
    End Sub



    Private Sub autocompletarNombreRutInformeHHEE(empresa As String)
        Dim listaNombre As New AutoCompleteStringCollection()
        Dim listaRut As New AutoCompleteStringCollection()
        Try
            Dim personas As List(Of Persona) = Persona.ListarPorEmpresa(empresa)

            For Each persona__1 As Persona In personas
                listaNombre.Add(persona__1.Nombre)
                listaRut.Add(persona__1.Rut)
            Next
            txbNombreInformeHHEE.AutoCompleteCustomSource = listaNombre

            txbRutInformeHHEE.AutoCompleteCustomSource = listaRut
        Catch ex As Exception
            MessageBox.Show("error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub cmbEmpresaInformeHHEE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresaInformeHHEE.SelectedIndexChanged
        autocompletarNombreRutInformeHHEE(cmbEmpresaInformeHHEE.Text)
        LimpiarDatosInformeHHEE()
    End Sub

    Public Sub LimpiarDatosInformeHHEE()
        txbNombreInformeHHEE.Text = ""
        dgvColaboradoresInformeHHEE.Rows.Clear()
        txbHHEEAcumuladasInformeHHEE.Text = ""
        enableBuscarHHEE = False
    End Sub

    Private Sub txbNombreInformeHHEE_TextChanged(sender As Object, e As EventArgs) Handles txbNombreInformeHHEE.TextChanged
        If enableBuscarRutHHEE Then
            enableBuscarNombreHHEE = False
            trabajadorHHEE.Nombre = txbNombreInformeHHEE.Text
            trabajadorHHEE.BuscarRutPorNombre()
            txbRutInformeHHEE.Text = trabajadorHHEE.Rut
            dgvColaboradoresInformeHHEE.Rows.Clear()
            txbHHEEAcumuladasInformeHHEE.Text = ""
            enableBuscarHHEE = False
            enableBuscarNombreHHEE = True
        End If
    End Sub

    Private Sub txbRutInformeHHEE_TextChanged(sender As Object, e As EventArgs) Handles txbRutInformeHHEE.TextChanged
        If enableBuscarNombreHHEE Then
            enableBuscarRutHHEE = False
            trabajadorHHEE.Rut = txbRutInformeHHEE.Text
            trabajadorHHEE.BuscarNombrePorRut()
            txbNombreInformeHHEE.Text = trabajadorHHEE.Nombre
            dgvColaboradoresInformeHHEE.Rows.Clear()
            txbHHEEAcumuladasInformeHHEE.Text = ""
            enableBuscarHHEE = False
            enableBuscarRutHHEE = True
        End If
    End Sub

    Private Sub btnBuscarInformeHHEE_Click(sender As Object, e As EventArgs) Handles btnBuscarInformeHHEE.Click
        enableBuscarHHEE = True
        CargarDGVInformeHHEE()
    End Sub


    Public Sub CargarDGVInformeHHEE()
        If enableBuscarHHEE Then
            dgvColaboradoresInformeHHEE.Rows.Clear()
            Dim inicio As New DateTime(dtpInicioInformeHHEE.Value.Year, dtpInicioInformeHHEE.Value.Month, dtpInicioInformeHHEE.Value.Day, 0, 0, 0)
            Dim termino As New DateTime(dtpTerminoInformeHHEE.Value.Year, dtpTerminoInformeHHEE.Value.Month, dtpTerminoInformeHHEE.Value.Day, 0, 0, 0)
            Dim horasExras As List(Of HoraExtraColaboradores)

            If Not chkBuscarTodosInformeHHEE.Checked Then
                horasExras = HoraExtraColaboradores.ListarIntevalo(trabajadorHHEE.Rut, Nothing, inicio, termino)
            Else
                If Not chkTodaEmpresaInformeHHEE.Checked Then
                    horasExras = HoraExtraColaboradores.ListarIntevalo(Nothing, cmbEmpresaInformeHHEE.Text, inicio, termino)
                Else
                    horasExras = HoraExtraColaboradores.ListarIntevalo(Nothing, Nothing, inicio, termino)
                End If
            End If

            Dim i As Integer = 0
            Dim hheeAcumuladas As [Double] = 0
            For Each horaExtra As HoraExtraColaboradores In horasExras
                dgvColaboradoresInformeHHEE.Rows.Add(1)
                dgvColaboradoresInformeHHEE.Rows(i).Cells("colNumeroInformeHHEE").Value = horaExtra.IdSolicitudHHEE.ToString()
                dgvColaboradoresInformeHHEE.Rows(i).Cells("colNombreColaboradoresInformeHHEE").Value = horaExtra.NombreCompleto
                dgvColaboradoresInformeHHEE.Rows(i).Cells("colRutInformeHHEE").Value = horaExtra.Rut
                dgvColaboradoresInformeHHEE.Rows(i).Cells("colCargoInformeHHEE").Value = horaExtra.Cargo
                dgvColaboradoresInformeHHEE.Rows(i).Cells("colFechaRealInformeHHEE").Value = horaExtra.FechaReal.ToString("dd-MM-yyyy")
                dgvColaboradoresInformeHHEE.Rows(i).Cells("colDepartamentoInformeHHEE").Value = horaExtra.Area

                dgvColaboradoresInformeHHEE.Rows(i).Cells("colHoraInicioInformeHHEE").Value = horaExtra.HorasCompromisoInicial.ToString("hh\:mm")
                dgvColaboradoresInformeHHEE.Rows(i).Cells("colHoraTerminoInformeHHEE").Value = Convert.ToDateTime(horaExtra.HorasCompromisoInicial.ToString()).AddHours(horaExtra.TotalHorasCompromiso).ToString("HH:mm")
                dgvColaboradoresInformeHHEE.Rows(i).Cells("colTotalHorasExtrasInformeHHEE").Value = New DateTime(2000, 1, 1, 0, 0, 0).AddHours(horaExtra.TotalHorasCompromiso).ToString("HH:mm")
                '
                '                    dgvColaboradores.Rows[i].Cells["colDiaCompleto"].Value = p.DiaCompleto ? "SI" : "NO";
                '                    if (!permiso.DiaCompleto)
                '                    {
                '                        dgvColaboradores.Rows[i].Cells["colHoraSalida"].Value = permiso.HoraSalida.ToString(@"hh\:mm");
                '                        dgvColaboradores.Rows[i].Cells["colHoraEntrada"].Value = Convert.ToDateTime(permiso.HoraSalida.ToString()).AddHours(permiso.TotalHoras).ToString("HH:mm");
                '                        dgvColaboradores.Rows[i].Cells["colHorasTotales"].Value = new DateTime(2000, 1, 1, 0, 0, 0).AddHours(permiso.TotalHoras).ToString("HH:mm");
                '                    }
                '                    dgvColaboradores.Rows[i].Cells["colTipoPermiso"].Value = permiso.ComisonServicio ? "COMISION SERVICIO" : "PARTICULAR";
                '                    

                hheeAcumuladas += horaExtra.TotalHorasCompromiso
                i += 1
            Next
            txbTotalEmpleadosInformeHHEE.Text = i.ToString()
            'txbHHEEAcumuladas.Text = hheeAcumuladas.ToString();
            txbHHEEAcumuladasInformeHHEE.Text = Math.Truncate(hheeAcumuladas) & ":" & (Math.Truncate(60 * (hheeAcumuladas - Math.Truncate(hheeAcumuladas))))
        End If
    End Sub

    Private Sub dtpInicioInformeHHEE_ValueChanged(sender As Object, e As EventArgs) Handles dtpInicioInformeHHEE.ValueChanged
        CargarDGVInformeHHEE()
    End Sub

    Private Sub dtpTerminoInformeHHEE_ValueChanged(sender As Object, e As EventArgs) Handles dtpTerminoInformeHHEE.ValueChanged
        CargarDGVInformeHHEE()
    End Sub

    Private Sub chkBuscarTodosInformeHHEE_CheckedChanged(sender As Object, e As EventArgs) Handles chkBuscarTodosInformeHHEE.CheckedChanged
        If chkBuscarTodosInformeHHEE.Checked Then
            If chkTodaEmpresaInformeHHEE.Checked Then
                lblEmpresaInformeHHEE.Visible = False
                cmbEmpresaInformeHHEE.Visible = False
            End If
            lblNombreInformeHHEE.Visible = False
            lblRutInformeHHEE.Visible = False
            txbNombreInformeHHEE.Visible = False
            txbRutInformeHHEE.Visible = False
            chkTodaEmpresaInformeHHEE.Visible = True
            LimpiarDatosInformeHHEE()
        Else
            lblEmpresaInformeHHEE.Visible = True
            cmbEmpresaInformeHHEE.Visible = True
            lblNombreInformeHHEE.Visible = True
            lblRutInformeHHEE.Visible = True
            txbNombreInformeHHEE.Visible = True
            txbRutInformeHHEE.Visible = True
            chkTodaEmpresaInformeHHEE.Visible = False
            LimpiarDatosInformeHHEE()
        End If
    End Sub

    Private Sub btnImprimirInformeHHEE_Click(sender As Object, e As EventArgs) Handles btnImprimirInformeHHEE.Click
        If chkBuscarTodosInformeHHEE.Checked Then
            If chkTodaEmpresaInformeHHEE.Checked Then
                Dim informe As New InformeHorasExtrasFechas()
                informe.SetParameterValue("@fecha_inicio", dtpInicioInformeHHEE.Value)
                informe.SetParameterValue("@fecha_termino", dtpTerminoInformeHHEE.Value)
                Dim formInforme As New Frm_ImprimirReporte(informe)
                formInforme.Show()
            Else
                Dim informe As New InformeHorasExtrasFechasEmpresa()
                informe.SetParameterValue("@empresa", cmbEmpresaInformeHHEE.Text)
                informe.SetParameterValue("@fecha_inicio", dtpInicioInformeHHEE.Value)
                informe.SetParameterValue("@fecha_termino", dtpTerminoInformeHHEE.Value)
                Dim formInforme As New Frm_ImprimirReporte(informe)

                formInforme.Show()
            End If
        Else
            Dim informe As New InformeHorasExtrasPersonaFechas()
            informe.SetParameterValue("@rut", txbRutInformeHHEE.Text)
            informe.SetParameterValue("@fecha_inicio", dtpInicioInformeHHEE.Value)
            informe.SetParameterValue("@fecha_termino", dtpTerminoInformeHHEE.Value)
            Dim formInforme As New Frm_ImprimirReporte(informe)
            formInforme.Show()
        End If
    End Sub

    Private Sub chkTodaEmpresaInformeHHEE_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodaEmpresaInformeHHEE.CheckedChanged
        If Not chkTodaEmpresaInformeHHEE.Checked Then
            lblEmpresaInformeHHEE.Visible = True
            cmbEmpresaInformeHHEE.Visible = True
        Else
            lblEmpresaInformeHHEE.Visible = False
            cmbEmpresaInformeHHEE.Visible = False
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If parentPanel IsNot Nothing Then
            parentPanel.Visible = True
        End If
        Me.Close()
    End Sub
End Class

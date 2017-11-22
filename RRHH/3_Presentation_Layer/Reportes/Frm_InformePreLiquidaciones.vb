Imports System.Data.SqlClient

Public Class Frm_InformePreLiquidaciones

    Private enableBuscarRutInforme As Boolean = True
    Private enableBuscarNombreInforme As Boolean = True
    Private enableBuscarInforme As Boolean = False
    Private trabajadorInforme As Persona
    Private Property bSelecTodos As Boolean = False
    Public Property dtEmpleados As DataTable
    Public Property conexion As New SqlConnection
    Public Property cmd As SqlCommand
    Public Property dtPeriodos As New DataTable
    Public Property dtEstadoPL As New DataTable
    Property ListPersona As List(Of Persona)
    Property EmpleadoActual As Persona

    'Private Declare Function GetClassName Lib "user32" Alias "GetClassNameA" _
    '(ByVal hWnd As Long, ByVal lpClassName As String, ByVal nMaxCount As Long) As Long

    'Private Declare Function FindWindow _
    'Lib "user32" _
    'Alias "FindWindowA" (
    '    ByVal lpClassName As String,
    '    ByVal lpWindowName As String) As Long

    'Private Declare Function ShowWindow _
    'Lib "user32" (
    '    ByVal hwnd As Long,
    '    ByVal nCmdShow As Long) As Long

    Private Sub Frm_InformePreLiquidaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            trabajadorInforme = New Persona()
            trabajadorInforme.Rut = ""
            trabajadorInforme.Nombre = ""

            CargarDTPeriodos(dtPeriodos)
            MetroComboBox1.LoadFromDataTable(dtPeriodos, "PeriodoC", "PeriodoI")
            MetroComboBox2.LoadFromDataTable(dtPeriodos, "PeriodoC", "PeriodoI")

            ConsultarEstadoPreLiquidacion(dtEstadoPL)
            If (dtEstadoPL.Rows(0)(0).ToString.Trim() = "Y") Then
                MetroToggle1.Checked = True
            Else
                MetroToggle1.Checked = False
            End If

            AutocompletarNombreRut("")

        Catch ex As Exception
        End Try

    End Sub

    Private Sub MetroTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBox1.TextChanged
        If enableBuscarRutInforme Then
            Try
                enableBuscarNombreInforme = False
                trabajadorInforme.Nombre = MetroTextBox1.Text
                trabajadorInforme.BuscarRutPorNombre()
                MetroTextBox2.Text = trabajadorInforme.Rut
                enableBuscarInforme = False
                enableBuscarNombreInforme = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub MetroToggle1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroToggle1.CheckedChanged

        If (MetroToggle1.Checked) Then
            Label1.Text = "ACTIVADO"
            Label1.ForeColor = Color.Green
            ModificarEstadoPreLiquidacion("Y", MetroComboBox1.SelectedValue.ToString())
        Else
            Label1.Text = "DESACTIVADO"
            Label1.ForeColor = Color.Red
            ModificarEstadoPreLiquidacion("N", "")
        End If

    End Sub

    Private Sub CargarDTPeriodos(DTdata As DataTable)

        conexion.ConnectionString = Conection.Cn

        cmd = New SqlCommand("[MINDU_INTERMEDIA].[dbo].[SpASISTENCIA_Periodos_Registrados_Fechas]", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            conexion.Open()

            Dim adaptador As New SqlDataAdapter(cmd)
            adaptador.Fill(DTdata)

        Catch ex As Exception
        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub ConsultarEstadoPreLiquidacion(DTdata As DataTable)

        conexion.ConnectionString = Conection.Cn

        cmd = New SqlCommand("[MINDU_INTERMEDIA].[dbo].[SpPRE_LIQUIDACIONConsultar]", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            conexion.Open()

            Dim adaptador As New SqlDataAdapter(cmd)
            DTdata.Clear()
            adaptador.Fill(DTdata)

        Catch ex As Exception
        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub ModificarEstadoPreLiquidacion(Estado As String, Periodo As String)

        Dim rpta As String = ""
        conexion.ConnectionString = Conection.Cn

        cmd = New SqlCommand("[MINDU_INTERMEDIA].[dbo].[SpPRE_LIQUIDACIONModificar]", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            conexion.Open()

            cmd.Parameters.AddWithValue("@Periodo", Periodo)
            cmd.Parameters.AddWithValue("@Estado", Estado)

            rpta = If(cmd.ExecuteNonQuery() = 1, "OK", "NO se Ingreso el Registro")

        Catch ex As Exception
            rpta = ex.Message
        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub AutocompletarNombreRut(empresa As String)
        Dim listaNombre As New AutoCompleteStringCollection()
        Dim listaRut As New AutoCompleteStringCollection()
        Try
            Dim personas As List(Of Persona) = Persona.ListarTodos()
            ListPersona = personas

            For Each persona__1 As Persona In personas
                listaNombre.Add(persona__1.Nombre)
                listaRut.Add(persona__1.Rut)
            Next
            MetroTextBox1.AutoCompleteCustomSource = listaNombre

            MetroTextBox2.AutoCompleteCustomSource = listaRut
        Catch ex As Exception
            MessageBox.Show("error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub MetroTextBox2_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBox2.TextChanged
        If enableBuscarNombreInforme Then
            Try
                enableBuscarRutInforme = False
                trabajadorInforme.Rut = MetroTextBox2.Text
                trabajadorInforme.BuscarNombrePorRut()
                MetroTextBox1.Text = trabajadorInforme.Nombre
                enableBuscarInforme = False
                enableBuscarRutInforme = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnImprimirInforme_Click(sender As Object, e As EventArgs) Handles btnImprimirInforme.Click

        Try
            If (MetroComboBox1.SelectedIndex > -1 And MetroTextBox2.Text.Trim().Length > 0) Then

                EmpleadoActual = ListPersona.FirstOrDefault(Function(x) x.Rut = MetroTextBox2.Text.Trim())
                Dim Empresa As String = EmpleadoActual.Empresa

                Dim sPeriodo As String = MetroComboBox1.SelectedValue.ToString()
                Dim RutTrab As String = MetroTextBox2.Text
                RutTrab = RutTrab.Remove(RutTrab.Length - 2)
                RutTrab = If(RutTrab.StartsWith("0"), RutTrab.Substring(1), RutTrab)
                RutTrab = If(RutTrab.StartsWith("0"), RutTrab.Substring(1), RutTrab)
                RutTrab = If(RutTrab.StartsWith("0"), RutTrab.Substring(1), RutTrab)
                'Dim dFechaIni As Date = dtPeriodos.Rows(MetroComboBox1.SelectedIndex)(2)
                'Dim dFechaFin As Date = dtPeriodos.Rows(MetroComboBox1.SelectedIndex)(3)

                Dim formInforme As New Frm_ImprimirReporteRDLC()
                formInforme.TipoReporte = "PreLiquidacion"
                formInforme.Rut = RutTrab
                formInforme.Año = sPeriodo.Substring(0, 4)
                formInforme.Mes = sPeriodo.Substring(4, 2)
                formInforme.RutEmp = If(Empresa.StartsWith("0"), Empresa.Substring(1), Empresa)
                formInforme.CallFrom = "Frm_InformePreLiquidaciones"
                formInforme.ExternalHeight = Panel1.Height
                formInforme.ExternalWidth = Panel1.Width

                MostrarFormExterno_en_Panel(Me, Panel1, formInforme)

                'formInforme.Show()

            Else
                MetroFramework.MetroMessageBox.Show(Me, "Debe Seleccionar un Trabajador",
                                                        "Imprimir Reporte",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub MostrarFormExterno_en_Panel(FormPadre As Form, PanelAsignado As Panel, FormExterno As Form)

        FormExterno.TopLevel = False
        FormExterno.Visible = False
        FormExterno.MdiParent = FormPadre.MdiParent
        'FormExterno.WindowState = FormWindowState.Normal
        FormExterno.Dock = DockStyle.Fill
        PanelAsignado.Controls.Add(FormExterno)
        PanelAsignado.Tag = FormExterno
        FormExterno.Visible = True
        FormExterno.BringToFront()
        FormExterno.Show()
        FormExterno.Refresh()

    End Sub


End Class
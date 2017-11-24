Imports System.Data.SqlClient
Imports System.IO

Public Class Frm_InformeLiquidaciones

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

            AutocompletarNombreRut("")
            enableBuscarRutInforme = True


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
                Dim Año As String = sPeriodo.Substring(0, 4)
                Dim Mes As String = sPeriodo.Substring(4, 2)
                Dim RutEmp As String = Empresa 'If(Empresa.StartsWith("0"), Empresa.Substring(1), Empresa)
                Dim RutTrab As String = MetroTextBox2.Text
                'RutTrab = RutTrab.Remove(RutTrab.Length - 2)
                'RutTrab = If(RutTrab.StartsWith("0"), RutTrab.Substring(1), RutTrab)
                'RutTrab = If(RutTrab.StartsWith("0"), RutTrab.Substring(1), RutTrab)
                'RutTrab = If(RutTrab.StartsWith("0"), RutTrab.Substring(1), RutTrab)

                CargaLiqudacion(RutTrab, Año, Mes, RutEmp)

            Else
                MetroFramework.MetroMessageBox.Show(Me, "Debe Seleccionar un Trabajador",
                                                        "Imprimir Reporte",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CargaLiqudacion(Rut As String, Año As String, Mes As String, RutEmp As String)

        'Dim vMes As Integer = Month(DateAdd("m", -1, Date.Now))
        'Dim vAno As Integer = Year(DateAdd("m", -1, Date.Now))
        cmd = New SqlCommand("Colaciones_Liquidaciones_Info", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            conexion.Open()
            cmd.Parameters.Add(New SqlParameter("@RutEmp", RutEmp))
            cmd.Parameters.Add(New SqlParameter("@Rut", Rut))
            cmd.Parameters.Add(New SqlParameter("@Mes", Mes))
            cmd.Parameters.Add(New SqlParameter("@Ano", Año))
            Dim adaptador As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adaptador.Fill(dt)
            Dim ArchivoTMP As String = Path.GetTempPath().ToString
            ArchivoTMP = ArchivoTMP + "Liqudaciones.html"
            File.Delete(ArchivoTMP)
            If dt.Rows(0)("IdEstado") = 0 Then
                Dim texto As String = dt.Rows(0)("liquidacion_txt")
                Dim sw As New System.IO.StreamWriter(ArchivoTMP)

                Dim Encabezado1 As String = "<table width = " & Chr(34) & "100%" & Chr(34) & " border= " & Chr(34) & "0" & Chr(34) & " align = " & Chr(34) & "center" & Chr(34) & " cellpadding= " & Chr(34) & "0" & Chr(34) & ">"
                Dim Encabezado2 As String = "<tr><td width =" & Chr(34) & "33%" & Chr(34) & " > Empresa <br> Rut <br> direccion  </td>"
                Dim Encabezado3 As String = "<td width =" & Chr(34) & "33%" & Chr(34) & " > <div align = " & Chr(34) & "center" & Chr(34) & "> autoconsulta </div></td>"
                Dim Encabezado4 As String = "<td width =" & Chr(34) & "33%" & Chr(34) & " > <div align = " & Chr(34) & "right" & Chr(34) & ">" &
                                            "<img src=" & Chr(34) & "file:///\\FSSAPBO\gestper\LOGOMIND.BMP" & Chr(34) & "width = " & Chr(34) & "247" & Chr(34) & "height=" & Chr(34) & "60" & Chr(34) & "></div></td> "
                Dim Encabezado As String = Encabezado1 & Encabezado2 & Encabezado3 & Encabezado4
                sw.WriteLine(Encabezado)
                sw.WriteLine(texto)
                sw.WriteLine("<style> *{font-size: 100%;}</style>")
                sw.WriteLine("</tr> </table>")
                sw.Close()
                WebBrowser1.Navigate(ArchivoTMP)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
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
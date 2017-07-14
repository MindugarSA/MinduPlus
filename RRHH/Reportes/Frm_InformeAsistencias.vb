Imports System.Data.SqlClient

Public Class Frm_InformeAsistencias

    Private enableBuscarRutInforme As Boolean = True
    Private enableBuscarNombreInforme As Boolean = True
    Private enableBuscarInforme As Boolean = False
    Private trabajadorInforme As Persona
    Public Property conexion As New SqlConnection
    Public Property cmd As SqlCommand
    Public Property dtPeriodos As New DataTable

    Private Sub Frm_InformeAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            trabajadorInforme = New Persona()
            trabajadorInforme.Rut = ""
            trabajadorInforme.Nombre = ""

            CargarDTPeriodos(dtPeriodos)
            MetroComboBox1.LoadFromDataTable(dtPeriodos, "PeriodoC", "PeriodoI")
            MetroComboBox2.LoadFromDataTable(dtPeriodos, "PeriodoC", "PeriodoI")
            CargarComboEmpresas()

            AutocompletarNombreRut("")
            MetroCheckBox1.Visible = False

        Catch ex As Exception
        End Try

    End Sub

    Private Sub MetroTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBox1.TextChanged
        If enableBuscarRutInforme Then
            enableBuscarNombreInforme = False
            trabajadorInforme.Nombre = MetroTextBox1.Text
            trabajadorInforme.BuscarRutPorNombre()
            MetroTextBox2.Text = trabajadorInforme.Rut
            enableBuscarInforme = False
            enableBuscarNombreInforme = True
        End If
    End Sub

    Private Sub MetroTextBox2_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBox2.TextChanged
        If enableBuscarNombreInforme Then
            enableBuscarRutInforme = False
            trabajadorInforme.Rut = MetroTextBox2.Text
            trabajadorInforme.BuscarNombrePorRut()
            MetroTextBox1.Text = trabajadorInforme.Nombre
            enableBuscarInforme = False
            enableBuscarRutInforme = True
        End If
    End Sub

    Private Sub btnImprimirInformePermisos_Click(sender As Object, e As EventArgs) Handles btnImprimirInforme.Click
        Try
            If (MetroComboBox1.SelectedIndex > -1 And MetroTextBox2.Text.Trim().Length > 0) Then

                Dim sPeriodo As String = MetroComboBox1.SelectedIndex
                Dim RutTrab As String = MetroTextBox2.Text
                RutTrab = RutTrab.Remove(RutTrab.Length - 2)
                RutTrab = If(RutTrab.StartsWith("0"), RutTrab.Substring(1), RutTrab)
                RutTrab = If(RutTrab.StartsWith("0"), RutTrab.Substring(1), RutTrab)
                RutTrab = If(RutTrab.StartsWith("0"), RutTrab.Substring(1), RutTrab)
                Dim dFechaIni As Date = dtPeriodos.Rows(MetroComboBox1.SelectedIndex)(2)
                Dim dFechaFin As Date = dtPeriodos.Rows(MetroComboBox1.SelectedIndex)(3)


                Dim informe As New InformePlanillaAsistencia()
                informe.SetParameterValue("@id", RutTrab)
                informe.SetParameterValue("@fechaInicio", dFechaIni)
                informe.SetParameterValue("@fechaTermino", dFechaFin)
                Dim formInforme As New Frm_ImprimirReporte(informe)

                MostrarFormExterno_en_Panel(Me, MetroPanel1, formInforme)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (MetroComboBox2.SelectedIndex > -1 And MetroComboBox3.SelectedValue.Trim().Length > 0) Then

                Dim RutEmp As String = MetroComboBox3.SelectedValue
                Dim dFechaIni As Date = dtPeriodos.Rows(MetroComboBox2.SelectedIndex)(2)
                Dim dFechaFin As Date = dtPeriodos.Rows(MetroComboBox2.SelectedIndex)(3)


                Dim informe As New InformePlanillaAsistenciaGrp()
                informe.SetParameterValue("@Empresa", RutEmp)
                informe.SetParameterValue("@fechaInicio", dFechaIni)
                informe.SetParameterValue("@fechaTermino", dFechaFin)
                Dim formInforme As New Frm_ImprimirReporte(informe)

                MostrarFormExterno_en_Panel(Me, MetroPanel1, formInforme)

                'For Each Form As Form In Application.OpenForms
                '    If Form.IsMdiContainer Then
                '        Form.WindowState = FormWindowState.Minimized
                '        Form.WindowState = FormWindowState.Maximized
                '    End If
                'Next


            Else
                MetroFramework.MetroMessageBox.Show(Me, "Debe Seleccionar una Empresa",
                                                        "Imprimir Reporte",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MetroCheckBox1_CheckStateChanged(sender As Object, e As EventArgs) Handles MetroCheckBox1.CheckStateChanged
        If MetroCheckBox1.Checked Then
            For Each row As DataGridViewRow In MetroGrid1.Rows
                'row.DefaultCellStyle.BackColor = Color.Gold
                DirectCast(row.Cells("chk"), DataGridViewCheckBoxCell).Value = True
                ' lConceptos.Add(row.Cells(0).Value.ToString())
            Next
        Else
            For Each row As DataGridViewRow In MetroGrid1.Rows
                'row.DefaultCellStyle.BackColor = Color.White
                DirectCast(row.Cells("chk"), DataGridViewCheckBoxCell).Value = False
                'lConceptos.Clear()
            Next
        End If
    End Sub

    Private Sub MetroComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox3.SelectedIndexChanged

        If MetroComboBox3.SelectedIndex > -1 And MetroComboBox3.SelectedValue IsNot Nothing Then

            If MetroGrid1.DataSource IsNot Nothing Then
                MetroGrid1.Columns.Clear()
            End If

            Dim dFechaIni As Date = dtPeriodos.Rows(MetroComboBox2.SelectedIndex)(2)
            Dim dFechaFin As Date = dtPeriodos.Rows(MetroComboBox2.SelectedIndex)(3)
            Dim RutEmp As String = MetroComboBox3.SelectedValue

            Dim dt As DataTable = Persona.ListarPorEmpresaPeriodo(RutEmp, dFechaIni, dFechaFin)

            MetroGrid1.DataSource = dt

            FormatearGridEmpleados()
            AgregarColumnaCheckEmplados()
            CargarComboAreas(dt)
            CargarComboDepartamentos(dt)

            MetroCheckBox1.Checked = True
            MetroCheckBox1.Visible = True
            MetroLabel6.Visible = True
            MetroLabel8.Visible = True
            MetroComboBox4.Visible = True
            MetroComboBox5.Visible = True

        Else

            MetroCheckBox1.Visible = False
            MetroLabel6.Visible = False
            MetroLabel8.Visible = False
            MetroComboBox4.Visible = False
            MetroComboBox5.Visible = False
            MetroGrid1.Columns.Clear()
        End If

    End Sub

    ''' <summary>
    ''' FUNCIONES Y PROCEDIMIENTOS
    ''' </summary>
    ''' 

    Private Sub CargarComboAreas(dtDatosGeneral As DataTable)
        Dim dtCargos As DataTable = Nothing

        Dim rows = dtDatosGeneral.AsEnumerable().[Select](Function(row) New With {
            Key .Codigo = row.Field(Of String)(2),
            Key .Descripcion = row.Field(Of String)(2)
        }).Distinct().OrderBy(Function(o) o.Codigo)


        dtCargos = dtCargos.LINQResultToDataTable(Of Object)(rows)
        Dim CargoRow As DataRow = dtCargos.NewRow()
        CargoRow(0) = ""
        CargoRow(1) = ""
        dtCargos.Rows.InsertAt(CargoRow, 0)
        MetroComboBox4.LoadFromDataTable(dtCargos, "Codigo", "Descripcion")
    End Sub

    Private Sub CargarComboDepartamentos(dtDatosGeneral As DataTable)
        Dim dtDeptos As DataTable = Nothing

        Dim rows = dtDatosGeneral.AsEnumerable().[Select](Function(row) New With {
            Key .Codigo = row.Field(Of String)(3),
            Key .Descripcion = row.Field(Of String)(3)
        }).Distinct().OrderBy(Function(o) o.Codigo)

        dtDeptos = dtDeptos.LINQResultToDataTable(Of Object)(rows)
        Dim DeptoRow As DataRow = dtDeptos.NewRow()
        DeptoRow(0) = ""
        DeptoRow(1) = ""
        dtDeptos.Rows.InsertAt(DeptoRow, 0)
        MetroComboBox5.LoadFromDataTable(dtDeptos, "Codigo", "Descripcion")
    End Sub

    Private Sub FormatearGridEmpleados()
        For Each Col As DataGridViewTextBoxColumn In MetroGrid1.Columns
            Col.[ReadOnly] = True
        Next

        MetroGrid1.Columns(0).HeaderText = "RUT"
        MetroGrid1.Columns(1).HeaderText = "NOMBRE EMPLEADO"
        MetroGrid1.Columns(2).HeaderText = "CARGO"
        MetroGrid1.Columns(3).HeaderText = "DEPARTAMENTO"

        MetroGrid1.Columns(0).Width = 150
        MetroGrid1.Columns(1).Width = 500
        MetroGrid1.Columns(2).Width = 300
        MetroGrid1.Columns(3).Width = 300

        MetroGrid1.Columns(4).Visible = False
        MetroGrid1.Columns(5).Visible = False

        'MetroGrid1.AutoResizeColumns()

    End Sub
    Private Sub AgregarColumnaCheckEmplados()
        Dim chk As New DataGridViewCheckBoxColumn()
        chk.[ReadOnly] = False
        chk.HeaderText = "Selec."
        chk.Name = "chk"
        chk.Width = 100
        MetroGrid1.Columns.Add(chk)
    End Sub

    Private Sub CargarComboEmpresas()

        Dim empresa As List(Of Empresas) = Empresas.ListarEmpresas
        empresa.Insert(0, New Empresas())

        With MetroComboBox3
            .DisplayMember = "Nombre"
            .ValueMember = "RUT"
            .DataSource = empresa
            .SelectedIndex = -1
        End With

    End Sub

    Private Sub CargarDTPeriodos(DTdata As DataTable)

        conexion.ConnectionString = "Data Source=FSSAPBO;Initial Catalog = SAC_Mindugar; Persist Security Info=True;User ID = sa; Password=Sqladmin281"

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

    Public Sub MostrarFormExterno_en_Panel(FormPadre As Form, PanelAsignado As Panel, FormExterno As Form)

        FormExterno.TopLevel = False
        FormExterno.Visible = False
        FormExterno.MdiParent = FormPadre.MdiParent
        FormExterno.WindowState = FormWindowState.Maximized
        FormExterno.Dock = DockStyle.Fill
        PanelAsignado.Controls.Add(FormExterno)
        PanelAsignado.Tag = FormExterno
        FormExterno.Visible = True
        FormExterno.BringToFront()
        FormExterno.Show()
        FormExterno.Refresh()

    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, btnImprimirInforme.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.Location = New Point(btn.Location.X + 5, btn.Location.Y + 5)
        btn.Size = New Size(btn.Width - 10, btn.Height - 10)
    End Sub

    Private Sub bButton_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, btnImprimirInforme.MouseEnter
        Dim btn As Button = CType(sender, Button)
        btn.Location = New Point(btn.Location.X - 5, btn.Location.Y - 5)
        btn.Size = New Size(btn.Width + 10, btn.Height + 10)
    End Sub



End Class
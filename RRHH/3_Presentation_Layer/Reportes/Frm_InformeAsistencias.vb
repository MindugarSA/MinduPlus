Imports System.Data.SqlClient

Public Class Frm_InformeAsistencias

    Private enableBuscarRutInforme As Boolean = True
    Private enableBuscarNombreInforme As Boolean = True
    Private enableBuscarInforme As Boolean = False
    Private trabajadorInforme As Persona
    Private Property bSelecTodos As Boolean = False
    Public Property dtEmpleados As DataTable
    Public Property conexion As New SqlConnection
    Public Property cmd As SqlCommand
    Public Property dtPeriodos As New DataTable

    Private Declare Function GetClassName Lib "user32" Alias "GetClassNameA" _
    (ByVal hWnd As Long, ByVal lpClassName As String, ByVal nMaxCount As Long) As Long

    Private Declare Function FindWindow _
    Lib "user32" _
    Alias "FindWindowA" (
        ByVal lpClassName As String,
        ByVal lpWindowName As String) As Long

    Private Declare Function ShowWindow _
    Lib "user32" (
        ByVal hwnd As Long,
        ByVal nCmdShow As Long) As Long

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
            MetroLabel9.Visible = False

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

                Dim dtEmple As DataTable = CType(MetroGrid1.DataSource, DataTable)
                Dim dtResult As DataTable = Nothing
                Dim results As EnumerableRowCollection(Of System.Data.DataRow) = From myRow In dtEmple.AsEnumerable()
                                                                                 Where (myRow.Field(Of Boolean)("chk"))
                                                                                 Order By myRow(0)
                                                                                 Select myRow

                If results.Any() Then
                    dtResult = results.CopyToDataTable()
                    While dtResult.Columns.Count > 2
                        dtResult.Columns.RemoveAt(dtResult.Columns.Count - 1)
                    End While
                    dtResult.Columns(0).ColumnName = "RutId"
                    dtResult.Columns(1).ColumnName = "Nombre"
                    For Each row As DataRow In dtResult.Rows
                        Dim RutTrab As String = row(0)
                        RutTrab = RutTrab.Remove(RutTrab.Length - 2)
                        RutTrab = If(RutTrab.StartsWith("0"), RutTrab.Substring(1), RutTrab)
                        RutTrab = If(RutTrab.StartsWith("0"), RutTrab.Substring(1), RutTrab)
                        RutTrab = If(RutTrab.StartsWith("0"), RutTrab.Substring(1), RutTrab)
                        row(0) = RutTrab
                    Next
                End If

                Dim RutEmp As String = MetroComboBox3.SelectedValue
                Dim dFechaIni As Date = dtPeriodos.Rows(MetroComboBox2.SelectedIndex)(2)
                Dim dFechaFin As Date = dtPeriodos.Rows(MetroComboBox2.SelectedIndex)(3)


                Dim informe As New InformePlanillaAsistenciaGrp()
                informe.SetParameterValue("@Empresa", RutEmp)
                informe.SetParameterValue("@fechaInicio", dFechaIni)
                informe.SetParameterValue("@fechaTermino", dFechaFin)
                'informe.SetParameterValue("@GrupoEmple", dtResult)
                Dim formInforme As New Frm_ImprimirReporte(informe)

                MostrarFormExterno_en_Panel(Me, MetroPanel1, formInforme)

                'Dim hWnd As Long
                'Dim sClassName As String
                'Dim ClassName As String
                'Dim nMaxCount As Long

                'hWnd = FindWindow(sClassName, Me.Text)
                'hWnd = FindWindow(vbNullString, "")
                'nMaxCount = 256
                'sClassName = Space$(nMaxCount)
                'nMaxCount = GetClassName(hWnd, sClassName, nMaxCount)
                'ClassName = Strings.Left(sClassName, nMaxCount)

                'Handle = FindWindow(vbNullString, "MSN Messenger")

                'Call ShowWindow(hWnd, 0)
                'Call ShowWindow(hWnd, 1)

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

        MetroCheckBox1.Checked = False
        If MetroComboBox3.SelectedIndex > -1 And MetroComboBox3.SelectedValue IsNot Nothing Then

            If MetroGrid1.DataSource IsNot Nothing Then
                MetroGrid1.Columns.Clear()
            End If

            Dim dFechaIni As Date = dtPeriodos.Rows(MetroComboBox2.SelectedIndex)(2)
            Dim dFechaFin As Date = dtPeriodos.Rows(MetroComboBox2.SelectedIndex)(3)
            Dim RutEmp As String = MetroComboBox3.SelectedValue

            dtEmpleados = Persona.ListarPorEmpresaPeriodo(RutEmp, dFechaIni, dFechaFin)

            MetroGrid1.DataSource = dtEmpleados

            FormatearGridEmpleados()
            AgregarColumnaCheckEmplados()
            CargarComboAreas(dtEmpleados)
            CargarComboDepartamentos(dtEmpleados)

            MetroCheckBox1.Checked = True
            MetroCheckBox1.Visible = True
            MetroLabel6.Visible = True
            MetroLabel8.Visible = True
            MetroComboBox4.Visible = True
            MetroComboBox5.Visible = True
            MetroLabel9.Visible = True
            MetroLabel9.Text = "Cantidad : " + dtEmpleados.Rows.Count.ToString()
            bSelecTodos = True

        Else

            MetroCheckBox1.Visible = False
            MetroLabel6.Visible = False
            MetroLabel8.Visible = False
            MetroComboBox4.Visible = False
            MetroComboBox5.Visible = False
            MetroGrid1.Columns.Clear()
        End If

    End Sub

    Private Sub MetroComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox4.SelectedIndexChanged

        If MetroComboBox4.Text.ToString.Trim.Length > 0 Then
            FiltrarPorCargo(MetroComboBox4.SelectedValue)
        Else
            MetroGrid1.DataSource = dtEmpleados
        End If
        MetroCheckBox1.Checked = False
        MetroCheckBox1.Checked = True
        MetroLabel9.Text = "Cantidad : " + MetroGrid1.DataSource.Rows.Count.ToString()

    End Sub

    Private Sub MetroComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox5.SelectedIndexChanged

        If MetroComboBox5.Text.ToString.Trim.Length > 0 Then
            FiltrarPorDepto(MetroComboBox5.SelectedValue)
        Else
            MetroGrid1.DataSource = dtEmpleados
        End If
        MetroCheckBox1.Checked = False
        MetroCheckBox1.Checked = True
        MetroLabel9.Text = "Cantidad : " + MetroGrid1.DataSource.Rows.Count.ToString()

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

        Dim dt As DataTable = DirectCast(MetroGrid1.DataSource, DataTable)

        If Not DirectCast(MetroGrid1.DataSource, DataTable).Columns.Contains("chk") Then
            DirectCast(MetroGrid1.DataSource, DataTable).Columns.Add(New DataColumn("chk", GetType(Boolean)))
        End If

        For Each row As DataRow In DirectCast(MetroGrid1.DataSource, DataTable).Rows
            row("chk") = False
        Next

        DirectCast(MetroGrid1.DataSource, DataTable).AcceptChanges()
        'dataGridView4.DataSource 

        Dim chk As DataGridViewCheckBoxColumn = DirectCast(MetroGrid1.Columns("chk"), DataGridViewCheckBoxColumn)
        chk.Visible = True
        chk.[ReadOnly] = False
        chk.HeaderText = "Selec."
        chk.Name = "chk"
        chk.Width = 100

        'Dim chk As New DataGridViewCheckBoxColumn()
        'chk.[ReadOnly] = False
        'chk.HeaderText = "Selec."
        'chk.Name = "chk"
        'chk.Width = 100
        'MetroGrid1.Columns.Add(chk)
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

    Private Sub FiltrarPorCargo(Cargo As String)
        Dim results As EnumerableRowCollection(Of System.Data.DataRow) = From myRow In dtEmpleados.AsEnumerable()
                                                                         Where (myRow.Field(Of String)("cargo").Trim.Equals(Cargo.Trim))
                                                                         Order By myRow(0)
                                                                         Select myRow

        If results.Any() Then
            Dim dtf As DataTable = results.CopyToDataTable()
            If dtf.Rows.Count > 0 Then
                'dtf.DefaultView.Sort = "P_CI";
                MetroGrid1.DataSource = dtf
            End If
        End If
    End Sub

    Private Sub FiltrarPorDepto(Cargo As String)
        Dim results As EnumerableRowCollection(Of System.Data.DataRow) = From myRow In dtEmpleados.AsEnumerable()
                                                                         Where (myRow.Field(Of String)("AREA").Trim.Equals(Cargo.Trim))
                                                                         Order By myRow(0)
                                                                         Select myRow

        If results.Any() Then
            Dim dtf As DataTable = results.CopyToDataTable()
            If dtf.Rows.Count > 0 Then
                'dtf.DefaultView.Sort = "P_CI";
                MetroGrid1.DataSource = dtf
            End If
        End If
    End Sub

    Private Sub MetroGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellClick

        If (e.ColumnIndex = 6) Then
            Dim chkCell = TryCast(MetroGrid1(e.ColumnIndex, e.RowIndex), DataGridViewCheckBoxCell)
            If Not CBool(chkCell.EditedFormattedValue) Then

            End If
        End If


    End Sub


End Class
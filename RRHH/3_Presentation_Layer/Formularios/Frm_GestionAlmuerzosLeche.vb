Imports System.Data.SqlClient
Imports Pabo.Calendar

Public Class Frm_GestionAlmuerzosLeche
    Private ModoInicial As String
    Public Property dtEmpleados As DataTable
    Public Property dtTipos As DataTable
    Public Property dtModos As DataTable
    Public Property DiaActual As DateTime
    Property conexion As New SqlConnection
    Property cmd As SqlCommand
    Public Property rutEmpleado As String
    Public Property rutEmpresa As String
    Public Property tipoAlmuerzo As String
    Public Property ModoAlmuerzo As String

    Private Sub Frm_GestionAlmuerzosLeche_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SuspendLayout()
        conexion.ConnectionString = Conection.Cn
        lblModo.Visible = False
        lblTipo.Visible = False

        DiaActual = Date.Now
        MonthCalendar3.ActiveMonth.Month = DiaActual.Month
        MonthCalendar3.ActiveMonth.Year = DiaActual.Year

    End Sub

    Private Sub Frm_GestionAlmuerzosLeche_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        dtEmpleados = MindugarConexion.SelectDataTable("EXEC [SAC_Mindugar].[dbo].[Colaciones_Empleados_Tipos_Listar]")

        CargarDTCombosGrid()
        CargarGridEmpleados()
        CargarComboFiltros()

        lblModo.Visible = True
        lblTipo.Visible = True
        Me.ResumeLayout()

    End Sub

    Private Sub BtnVolver2_Click(sender As Object, e As EventArgs) Handles BtnVolver2.Click

        MDIParent1.Panel2.Visible = True
        MDIParent1.TiempoIngreso.Enabled = True
        MDIParent1.ToolStripProgressBar1.ProgressBar.Maximum = MDIParent1.TiempoActivo
        MDIParent1.ToolStripProgressBar1.ProgressBar.Value = MDIParent1.TiempoActivo
        MDIParent1.Visualizar_Tiles_MDI()
        MDIParent1.Desplazamiento_Tiles()
        Me.Close()

    End Sub

    Private Sub MetroComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox3.SelectedIndexChanged

        If MetroComboBox3.SelectedIndex > -1 And MetroComboBox3.SelectedValue IsNot Nothing Then

            Dim RutEmp As String = MetroComboBox3.SelectedValue

            Dim dtEmpleadosGrid As DataTable = dtEmpleados

            If (MetroComboBox3.Text <> "TODAS") Then
                dtEmpleadosGrid = (From n In dtEmpleados.AsEnumerable()
                                   Where n.Field(Of String)("RutEmp") = MetroComboBox3.SelectedValue.ToString()
                                   Select n).CopyToDataTable()
            End If

            MetroGrid1.DataSource = dtEmpleadosGrid

            'Array.ForEach(dtEmpleados.Rows.Cast(Of DataRow).ToArray, Function(dr) If(dr("MyField") = "", dr("MyField") = 77, True))

            lblCantidad.Text = "Cantidad : " + MetroGrid1.Rows.Count.ToString()

        End If
    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged
        If (MetroComboBox1.SelectedIndex > -1 And MetroComboBox1.SelectedValue IsNot Nothing) Then

            Dim RutEmp As String = MetroComboBox3.SelectedValue

            Dim dtEmpleadosGrid As DataTable = dtEmpleados

            If (MetroComboBox3.Text <> "TODAS") Then
                dtEmpleadosGrid = (From n In dtEmpleados.AsEnumerable()
                                   Where n.Field(Of String)("RutEmp") = MetroComboBox3.SelectedValue.ToString()
                                   Select n).CopyToDataTable()
            End If

            Try
                dtEmpleadosGrid = (From n In dtEmpleadosGrid.AsEnumerable()
                                   Where n.Field(Of String)("Tipo").Trim() = MetroComboBox1.SelectedValue.ToString.Trim
                                   Select n).CopyToDataTable()
            Catch ex As Exception
            End Try


            MetroGrid1.DataSource = dtEmpleadosGrid

            lblCantidad.Text = "Cantidad : " + MetroGrid1.Rows.Count.ToString()

        End If
    End Sub

    Private Sub MetroComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox2.SelectedIndexChanged
        If (MetroComboBox2.SelectedIndex > -1 And MetroComboBox2.SelectedValue IsNot Nothing) Then

            Dim RutEmp As String = MetroComboBox3.SelectedValue

            Dim dtEmpleadosGrid As DataTable = dtEmpleados

            If (MetroComboBox3.Text <> "TODAS") Then
                dtEmpleadosGrid = (From n In dtEmpleados.AsEnumerable()
                                   Where n.Field(Of String)("RutEmp") = MetroComboBox3.SelectedValue.ToString()
                                   Select n).CopyToDataTable()
            End If

            Try
                dtEmpleadosGrid = (From n In dtEmpleadosGrid.AsEnumerable()
                                   Where n.Field(Of String)("Modo").Trim() = MetroComboBox2.SelectedValue.ToString.Trim
                                   Select n).CopyToDataTable()
            Catch ex As Exception
            End Try


            MetroGrid1.DataSource = dtEmpleadosGrid

            lblCantidad.Text = "Cantidad : " + MetroGrid1.Rows.Count.ToString()

        End If
    End Sub

    Private Sub CargarGridEmpleados()

        Dim cmbTipo As DataGridViewComboBoxColumn = CType(MetroGrid1.Columns(3), DataGridViewComboBoxColumn)

        cmbTipo.DataSource = dtTipos
        cmbTipo.DisplayMember = "TipoDesc"
        cmbTipo.ValueMember = "Tipo"

        Dim cmbModo As DataGridViewComboBoxColumn = CType(MetroGrid1.Columns(4), DataGridViewComboBoxColumn)

        cmbModo.DataSource = dtModos
        cmbModo.DisplayMember = "ModoDesc"
        cmbModo.ValueMember = "Modo"

        MetroGrid1.AutoGenerateColumns = False
        MetroGrid1.Columns(0).ReadOnly = True
        MetroGrid1.Columns(1).ReadOnly = True
        MetroGrid1.Columns(2).ReadOnly = True

        MetroGrid1.DataSource = dtEmpleados

        MetroGrid1.AutoResizeColumns()

        'For row = 0 To MetroGrid1.Rows.Count - 1
        '    Dim cmbAlmu As DataGridViewComboBoxCell = MetroGrid1.Rows(row).Cells(3)
        '    If (cmbAlmu.Value = "Almuerzo") Then
        '        MetroGrid1.CurrentCell.Style.BackColor = Color.FromArgb(213, 220, 186)
        '    Else
        '        MetroGrid1.CurrentCell.Style.BackColor = Color.FromArgb(85, 66, 221)
        '    End If
        'Next

        lblCantidad.Text = "Cantidad : " + MetroGrid1.Rows.Count.ToString()

    End Sub

    Private Sub FormatearGridEmpleados()

    End Sub

    Private Sub CargarComboFiltros()
        '--- COMBOX EMPRESAS
        Dim empresa As List(Of Empresas) = Empresas.ListarEmpresas
        Dim EmpTodas As Empresas = New Empresas()
        EmpTodas.Nombre = "TODAS"
        EmpTodas.RUT = "0"
        empresa.Insert(0, EmpTodas)

        With MetroComboBox3
            .DisplayMember = "Nombre"
            .ValueMember = "RUT"
            .DataSource = empresa
            '.SelectedIndex = -1
        End With

        '--- COMBOX TIPO
        With MetroComboBox1
            .DataSource = dtTipos.Copy()
            .DisplayMember = "TipoDesc"
            .ValueMember = "Tipo"
            .SelectedIndex = -1
        End With

        '--- COMBOX MODO
        With MetroComboBox2
            .DataSource = dtModos.Copy()
            .DisplayMember = "ModoDesc"
            .ValueMember = "Modo"
            .SelectedIndex = -1
        End With

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

    Private Sub CargarDTCombosGrid()

        dtTipos = New DataTable
        dtTipos.Columns.Add("Tipo", GetType(String))
        dtTipos.Columns.Add("TipoDesc", GetType(String))

        dtTipos.Rows.Add("A", "Almuerzo")
        dtTipos.Rows.Add("L", "Leche")

        dtModos = New DataTable
        dtModos.Columns.Add("Modo", GetType(String))
        dtModos.Columns.Add("ModoDesc", GetType(String))

        dtModos.Rows.Add("LV", "L-V")
        dtModos.Rows.Add("LJ", "L-J")
        dtModos.Rows.Add("-", "-")


    End Sub

    Private Sub MetroTile1_MouseEnter(sender As Object, e As EventArgs) Handles BtnVolver2.MouseEnter, btnRecarga.MouseEnter, btnBuscar.MouseEnter
        sender.Left = sender.Left - 4
        sender.Top = sender.Top - 4
        sender.Height = sender.Height + 8
        sender.Width = sender.Width + 8
    End Sub

    Private Sub MetroTile1_MouseLeave(sender As Object, e As EventArgs) Handles BtnVolver2.MouseLeave, btnRecarga.MouseLeave, btnBuscar.MouseLeave
        sender.Left = sender.Left + 4
        sender.Top = sender.Top + 4
        sender.Height = sender.Height - 8
        sender.Width = sender.Width - 8
    End Sub

    Private Sub MetroGrid1_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGrid1.SelectionChanged

        Try
            If (MetroGrid1.CurrentCell.RowIndex > -1) Then
                CargarPropiedadesEmpleado()

                TxtEmpleado.Text = MetroGrid1.Rows(MetroGrid1.CurrentCell.RowIndex).Cells(0).Value.ToString().Trim + " - " +
                               MetroGrid1.Rows(MetroGrid1.CurrentCell.RowIndex).Cells(1).Value.ToString().Trim + ", " +
                               MetroGrid1.Rows(MetroGrid1.CurrentCell.RowIndex).Cells(2).Value.ToString().Trim

                CargarInfoEmpleado()
                CargarCalendario(MonthCalendar3.ActiveMonth.Month)
            End If
        Catch

        End Try


    End Sub

    Private Sub CargarPropiedadesEmpleado()

        rutEmpleado = MetroGrid1.Rows(MetroGrid1.CurrentCell.RowIndex).Cells(0).Value.ToString().Trim
        rutEmpresa = CType(MetroGrid1.DataSource, DataTable).Rows(MetroGrid1.CurrentCell.RowIndex)(5).ToString().Trim
        tipoAlmuerzo = MetroGrid1.Rows(MetroGrid1.CurrentCell.RowIndex).Cells(3).Value.ToString().Trim
        ModoAlmuerzo = MetroGrid1.Rows(MetroGrid1.CurrentCell.RowIndex).Cells(4).Value.ToString().Trim

    End Sub

    Private Sub CargarCalendario(iMes As Integer)
        Dim Mes As Int16 = MonthCalendar3.ActiveMonth.Month
        Dim Anio As Int16 = MonthCalendar3.ActiveMonth.Year
        Dim fechaIniMes As Date = New Date(Anio, Mes, 1)
        Dim DiasMes = System.DateTime.DaysInMonth(Anio, Mes)
        Dim fechaFinMes As Date = New Date(Anio, Mes, DiasMes)
        Dim di() As DateItem '= New DateItem(30) {}
        Dim index As Int16 = 0
        Dim WeekEnd As New List(Of DayOfWeek)(New DayOfWeek() {DayOfWeek.Saturday, DayOfWeek.Sunday})
        Dim esFeriado As Boolean = False
        If (ModoAlmuerzo = "LJ") Then WeekEnd.Add(DayOfWeek.Friday)

        MonthCalendar3.ResetDateInfo()
        ReDim Preserve di(index)
        di.Initialize()

        Try
            Do While (fechaIniMes <= fechaFinMes And tipoAlmuerzo.Trim = "A")
                esFeriado = ConsultaDiaFeriado(fechaIniMes)
                If (Not WeekEnd.Contains(fechaIniMes.DayOfWeek) And Not esFeriado) Then
                    ReDim Preserve di(index)
                    di.Initialize()
                    di(index) = New DateItem()
                    di(index).Date = fechaIniMes
                    di(index).DateColor = Color.Black
                    di(index).BackColor1 = Color.FromArgb(0, 174, 219)
                    di(index).Text = "A"
                    di(index).TextColor = Color.White
                    di(index).DateColor = Color.White
                    If (fechaIniMes.Date = Date.Now.Date) Then MonthCalendar3.TodayColor = Color.FromArgb(80, 199, 230)
                    index += 1
                End If
                fechaIniMes = fechaIniMes.AddDays(1)
            Loop

            If (di.Length > 0) Then MonthCalendar3.AddDateInfo(di)

            If (tipoAlmuerzo.Trim = "L") Then MonthCalendar3.TodayColor = Color.White

            Dim m_dates As DateItem() = MonthCalendar3.GetDateInfo()

            CargarCambioFechasCalendario()
            CargarDiasFeriadosCalendario()

        Catch ex As Exception
        End Try

    End Sub

    Private Sub CargarDiasFeriadosCalendario()
        Dim Mes As Int16 = MonthCalendar3.ActiveMonth.Month
        Dim Anio As Int16 = MonthCalendar3.ActiveMonth.Year
        Dim fechaIniMes As Date = New Date(Anio, Mes, 1)
        Dim DiasMes = System.DateTime.DaysInMonth(Anio, Mes)
        Dim fechaFinMes As Date = New Date(Anio, Mes, DiasMes)
        Dim di() As DateItem '= New DateItem(30) {}
        Dim index As Int16 = 0
        Dim WeekEnd As New List(Of DayOfWeek)(New DayOfWeek() {DayOfWeek.Saturday, DayOfWeek.Sunday})
        Dim esFeriado As Boolean = False
        'If (ModoAlmuerzo = "LJ") Then WeekEnd.Add(DayOfWeek.Friday)

        ReDim Preserve di(index)
        di.Initialize()

        Try
            Do While (fechaIniMes <= fechaFinMes)
                esFeriado = ConsultaDiaFeriado(fechaIniMes)
                If (Not WeekEnd.Contains(fechaIniMes.DayOfWeek) And esFeriado) Then
                    ReDim Preserve di(index)
                    di.Initialize()
                    di(index) = New DateItem()
                    di(index).Date = fechaIniMes
                    di(index).DateColor = Color.Black
                    di(index).BackColor1 = Color.FromArgb(255, 104, 17)
                    di(index).Text = "FERIADO"
                    di(index).TextColor = Color.White
                    di(index).DateColor = Color.White
                    index += 1
                End If
                fechaIniMes = fechaIniMes.AddDays(1)
            Loop

            If (di.Length > 0) Then MonthCalendar3.AddDateInfo(di)

            If (ConsultaDiaFeriado(Date.Now.Date)) Then MonthCalendar3.TodayColor = Color.FromArgb(255, 104, 17)

        Catch ex As Exception
        End Try
    End Sub

    Function ConsultaDiaFeriado(dateInfo As Date) As Boolean

        Dim esFeriado As Boolean = False
        Dim dt As New DataTable()

        dt.Reset()
        cmd = New SqlCommand("Feriados_Info", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd.Parameters.Add(New SqlParameter("@FechaIni", dateInfo.ToString("yyyyMMdd")))
        cmd.Parameters.Add(New SqlParameter("@FechaFin", dateInfo.ToString("yyyyMMdd")))
        Try
            dt.Load(cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try

        If (dt.Rows(0)("DiasFer") > 0) Then
            esFeriado = True
        End If

        Return esFeriado

    End Function

    Private Sub CargarCambioFechasCalendario()

        Dim di2() As DateItem
        Dim index As Int16 = 0
        Dim Almu_Viernes_Modo_LJ As Boolean = False
        Dim dt As New DataTable()

        cmd = New SqlCommand("Colaciones_Empleados_Cambio_Fechas", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd.Parameters.Add(New SqlParameter("@rut", rutEmpleado))
        cmd.Parameters.Add(New SqlParameter("@rutEmp", rutEmpresa))
        cmd.Parameters.Add(New SqlParameter("@mes", MonthCalendar3.ActiveMonth.Month))
        cmd.Parameters.Add(New SqlParameter("@anio", MonthCalendar3.ActiveMonth.Year))

        ReDim Preserve di2(index)
        di2.Initialize()

        Try
            dt.Reset()
            dt.Load(cmd.ExecuteReader())

            index = 0
            If (dt.Rows.Count > 0) Then
                For Each row As DataRow In dt.Rows
                    Almu_Viernes_Modo_LJ = IIf((CType(row("fecha"), Date).DayOfWeek = DayOfWeek.Friday And ModoAlmuerzo = "LJ"), True, False)
                    If (row("Tipo") <> tipoAlmuerzo Or Almu_Viernes_Modo_LJ) Then

                        If (tipoAlmuerzo = "L" Or (Almu_Viernes_Modo_LJ And row("Tipo") = "A")) Then
                            ReDim Preserve di2(index)
                            di2.Initialize()
                            di2(index) = New DateItem()
                            di2(index).Date = row("fecha")
                            di2(index).DateColor = Color.Black
                            di2(index).BackColor1 = Color.FromArgb(0, 174, 219)
                            di2(index).Text = "A"
                            di2(index).TextColor = Color.White
                            di2(index).DateColor = Color.White

                            If (row("fecha") = Date.Now.Date) Then MonthCalendar3.TodayColor = Color.FromArgb(80, 199, 230)
                            index += 1
                        Else
                            MonthCalendar3.RemoveDateInfo(row("fecha"))
                        End If

                    End If
                Next
                If (di2.Length > 0) Then MonthCalendar3.AddDateInfo(di2)
            End If

        Catch ex As Exception
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub CargarInfoEmpleado()

        'Dim tipoAlmuerzo As String = MetroGrid1.Rows(MetroGrid1.CurrentCell.RowIndex).Cells(3).Value.ToString().Trim
        'Dim Modo As String = MetroGrid1.Rows(MetroGrid1.CurrentCell.RowIndex).Cells(4).Value.ToString().Trim

        Select Case Me.tipoAlmuerzo
            Case "A"
                lblTipo.Text = "Tipo : ALMUERZO"
                If (ModoAlmuerzo = "LV") Then
                    lblModo.Text = "Modo : LUNES A VIERNES"
                Else
                    lblModo.Text = "Modo : LUNES A JUEVES"
                End If
                PictureBox1.BackgroundImage = My.Resources.breakfast
            Case "L"
                lblTipo.Text = "Tipo : LECHE"
                lblModo.Text = ""
                PictureBox1.BackgroundImage = My.Resources.milk
        End Select

    End Sub

    Private Sub MetroGrid1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles MetroGrid1.EditingControlShowing
        Dim combo As ComboBox = CType(e.Control, ComboBox)
        If (combo IsNot Nothing) Then
            ' Remove an existing event-handler, if present, to avoid 
            ' adding multiple handlers when the editing control is reused.
            RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)

            ' Add the event handler. 
            AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
        End If
    End Sub

    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As Object, ByVal e As EventArgs)

        Dim cb As ComboBox = CType(sender, ComboBox)

        Select Case MetroGrid1.CurrentCell.ColumnIndex
            Case 3
                Dim cmbModo As DataGridViewComboBoxCell = MetroGrid1.Rows(MetroGrid1.CurrentCell.RowIndex).Cells(4)
                If (cb.Text = "Leche") Then
                    cmbModo.Value = "-"
                    lblTipo.Text = "Tipo : LECHE"
                    lblModo.Text = ""
                    PictureBox1.BackgroundImage = My.Resources.milk
                    tipoAlmuerzo = "L"
                    ModoAlmuerzo = "-"
                Else
                    cmbModo.Value = "LV"
                    lblTipo.Text = "Tipo : ALMUERZO"
                    lblModo.Text = "Modo : LUNES A VIERNES"
                    PictureBox1.BackgroundImage = My.Resources.breakfast
                    tipoAlmuerzo = "A"
                    ModoAlmuerzo = "LV"
                End If
            Case 4
                Dim cmbModo As DataGridViewComboBoxCell = MetroGrid1.Rows(MetroGrid1.CurrentCell.RowIndex).Cells(3)
                If (cb.SelectedValue = "LV" And cmbModo.Value.ToString.Trim = "A") Then
                    lblModo.Text = "Modo : LUNES A VIERNES"
                    'tipoAlmuerzo = "A"
                    ModoAlmuerzo = "LV"
                ElseIf (cb.SelectedValue = "LJ" And cmbModo.Value.ToString.Trim = "A") Then
                    lblModo.Text = "Modo : LUNES A JUEVES"
                    'tipoAlmuerzo = "A"
                    ModoAlmuerzo = "LJ"
                ElseIf (cmbModo.Value.ToString.Trim = "A") Then
                    cb.SelectedValue = ModoInicial
                    ModoAlmuerzo = ModoInicial
                Else
                    cb.SelectedValue = ""
                    'tipoAlmuerzo = "L"
                    ModoAlmuerzo = "-"
                End If
        End Select

        ModificarTipoModoEmpleado()
        CargarCalendario(MonthCalendar3.ActiveMonth.Month)

        'Actualiza ROW en DataTable dtEmpleados
        Dim myRow() As Data.DataRow
        myRow = dtEmpleados.Select("Rut = '" + rutEmpleado.Trim + "' and RutEmp = '" + rutEmpresa.Trim + "'")
        myRow(0)("Tipo") = tipoAlmuerzo
        myRow(0)("Modo") = ModoAlmuerzo

    End Sub

    Private Sub ModificarTipoModoEmpleado()

        cmd = New SqlCommand("[Colaciones_Empleados_Tipos_Update]", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd.Parameters.Add(New SqlParameter("@Rut", rutEmpleado))
        cmd.Parameters.Add(New SqlParameter("@RutEmp", rutEmpresa))
        cmd.Parameters.Add(New SqlParameter("@Tipo", tipoAlmuerzo))
        cmd.Parameters.Add(New SqlParameter("@Modo", ModoAlmuerzo))
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub ModificarCambioFechaEmpleado(FechaCambio As Date)

        Dim TipoCambio As String = ""
        Dim d2 As DateItem() = MonthCalendar3.GetDateInfo(FechaCambio)

        If (d2.Length = 0) Then
            TipoCambio = "L"
        Else
            TipoCambio = "A"
        End If

        cmd = New SqlCommand("[Colaciones_Empleados_Cambio_Fechas_Insertar]", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd.Parameters.Add(New SqlParameter("@Rut", rutEmpleado))
        cmd.Parameters.Add(New SqlParameter("@RutEmp", rutEmpresa))
        cmd.Parameters.Add(New SqlParameter("@Fecha", FechaCambio.ToString("yyyyMMdd")))
        cmd.Parameters.Add(New SqlParameter("@Tipo", TipoCambio))
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub MetroGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellClick
        If (MetroGrid1.CurrentCell.ColumnIndex = 4) Then
            ModoInicial = MetroGrid1.CurrentCell.Value.ToString
        End If
    End Sub

    Private Sub btnAgregarSolicitud_Click(sender As Object, e As EventArgs)

        Dim dt As DataTable = MetroGrid1.DataSource
        Dim rut As String
        Dim rutemp As String
        Dim tipo As String
        Dim modo As String

        For Each row As DataRow In dt.Rows
            rut = row("RUT")
            rutemp = row("rutEmp")
            tipo = row("Tipo")
            modo = row("Modo")
        Next row


    End Sub

    Private Sub MonthCalendar3_DayClick(sender As Object, e As DayClickEventArgs) Handles MonthCalendar3.DayClick
        Dim DiaActual As DateTime = CType(e.Date, DateTime)

        Dim MesCalendario = MonthCalendar3.ActiveMonth.Month
        Dim WeekEnd As New List(Of DayOfWeek)(New DayOfWeek() {DayOfWeek.Saturday, DayOfWeek.Sunday})

        Dim esFeriado As Boolean
        esFeriado = ConsultaDiaFeriado(DiaActual)

        If (DiaActual.Month = MesCalendario And Not WeekEnd.Contains(DiaActual.DayOfWeek) And Not esFeriado) Then

            Dim di As New DateItem

            di.Date = DiaActual
            di.DateColor = Color.Black
            di.BackColor1 = Color.FromArgb(0, 174, 219)
            di.Text = "A"
            di.TextColor = Color.White
            di.DateColor = Color.White

            Dim d2 As DateItem() = MonthCalendar3.GetDateInfo(DiaActual)

            If (d2.Length = 0) Then
                MonthCalendar3.AddDateInfo(di)
                If (DiaActual.Date = Date.Now.Date) Then MonthCalendar3.TodayColor = Color.FromArgb(80, 199, 230)
            Else
                MonthCalendar3.RemoveDateInfo(DiaActual)
                If (DiaActual.Date = Date.Now.Date) Then MonthCalendar3.TodayColor = Color.Transparent
            End If

            Dim m_dates As DateItem() = MonthCalendar3.GetDateInfo()

            ModificarCambioFechaEmpleado(DiaActual)

        End If

    End Sub

    Private Sub MonthCalendar3_MonthChanged(sender As Object, e As MonthChangedEventArgs) Handles MonthCalendar3.MonthChanged
        CargarCalendario(e.Month)
    End Sub

    Private Sub btnAutorizarTodas_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If (txtBusqueda.Text.Trim.Length > 0) Then

            Try
                Dim dtEmpleadosGrid As DataTable = dtEmpleados

                dtEmpleadosGrid = (From n In dtEmpleados.AsEnumerable()
                                   Where (n.Field(Of String)("Nombre").ToUpper.Contains(txtBusqueda.Text.Trim.ToUpper) Or
                                          n.Field(Of String)("Apellido").ToUpper.Contains(txtBusqueda.Text.Trim.ToUpper))
                                   Select n).CopyToDataTable()

                MetroGrid1.DataSource = dtEmpleadosGrid

                lblCantidad.Text = "Cantidad : " + MetroGrid1.Rows.Count.ToString()
            Catch ex As Exception
            End Try


        End If
    End Sub

    Private Sub txtBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnBuscar.PerformClick()
        End If
    End Sub

    Private Sub btnRecarga_Click(sender As Object, e As EventArgs) Handles btnRecarga.Click
        MetroGrid1.DataSource = dtEmpleados
        lblCantidad.Text = "Cantidad : " + MetroGrid1.Rows.Count.ToString()
    End Sub

    Private Sub MetroComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox4.SelectedIndexChanged
        Try
            PictureBox2.Visible = True

            Select Case MetroComboBox4.SelectedIndex
                Case 0
                    Dim dt As DataTable = CrearDTExcel()
                    Dim dtRows = (dt.AsEnumerable().
                                  Where(Function(x) x.Field(Of String)("Tipo").Trim = "Almuerzo").
                                  ToList())
                    If (dtRows.Any()) Then
                        dt = dtRows.CopyToDataTable()
                        dt.ExportToExcel()
                    End If
                Case 1
                    Dim dt As DataTable = CrearDTExcel()
                    Dim dtRows = (dt.AsEnumerable().
                                  Where(Function(x) x.Field(Of String)("Tipo").Trim = "Leche").
                                  ToList())
                    If (dtRows.Any()) Then
                        dt = dtRows.CopyToDataTable()
                        dt.ExportToExcel()
                    End If
                Case 2
                    Dim Mes As Integer = MonthCalendar3.ActiveMonth.Month
                    Dim Anio As Integer = MonthCalendar3.ActiveMonth.Year
                    Dim dt As DataTable = MindugarConexion.SelectDataTable("EXEC [SAC_Mindugar].[dbo].[Colaciones_Empleados_Tipos_Listar_Calendario] @Mes = " + Mes.ToString.Trim + ", @Anio = " + Anio.ToString.Trim + "")
                    If (dt.Rows.Count > 0) Then
                        dt.ExportToExcel()
                    End If
            End Select
        Catch ex As Exception
        Finally
            PictureBox2.Visible = False
        End Try


    End Sub

    Private Function CrearDTExcel() As DataTable


        Dim dtExcel As New DataTable()
        dtExcel.Columns.Add("Rut_Empresa", GetType(String))
        dtExcel.Columns.Add("Empresa", GetType(String))
        dtExcel.Columns.Add("Rut", GetType(String))
        dtExcel.Columns.Add("Nombre", GetType(String))
        dtExcel.Columns.Add("Apellido", GetType(String))
        dtExcel.Columns.Add("Tipo", GetType(String))
        dtExcel.Columns.Add("Modo", GetType(String))
        Dim newRow As DataRow = dtExcel.NewRow()

        For Each row As DataRow In CType(MetroGrid1.DataSource, DataTable).Rows
            newRow("Rut_Empresa") = row("rutEmp")
            newRow("Empresa") = row("Empresa")
            newRow("Rut") = row("RUT")
            newRow("Nombre") = row("nombre")
            newRow("Apellido") = row("apellido")
            newRow("Tipo") = IIf(row("Tipo").ToString.Trim = "A", "Almuerzo", "Leche")
            newRow("Modo") = IIf(row("Modo").ToString.Trim = "LV", "L-V", IIf(row("Modo").ToString.Trim = "LJ", "L-J", ""))


            dtExcel.Rows.Add(newRow)
            newRow = dtExcel.NewRow()
        Next

        Return dtExcel

    End Function

End Class
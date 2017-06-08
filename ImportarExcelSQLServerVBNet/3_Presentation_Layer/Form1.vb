Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Data.SqlClient

Imports ImportarExcelSQLServer._2_Business_Layer
Imports ImportarExcelSQLServer._3_Presentation_Layer

Public Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm
    Implements IComunication
	Private dtDatosExcel As DataTable
	Private dtDetallePeriodo As DataTable
	Private dtResumenPeriodo As DataTable
	Private dtConceptos As DataTable
	Private sPathBook As String
	Private bEmpOcultos As Boolean
	Private iEmpSelec As Integer
    Private pnlParent As Panel
    Private StatusBarBottom As StatusStrip
    Private Id As String
    Private Tab_gradient As Integer

    Public Delegate Sub LaunchEvent()
    Public Event EnviarEvento As LaunchEvent

    Public Property bAcceso() As Boolean
		Get
			Return m_bAcceso
		End Get
		Set
			m_bAcceso = Value
		End Set
	End Property
	Private m_bAcceso As Boolean
	Public Property bFiltroConcepto() As Boolean
		Get
			Return m_bFiltroConcepto
		End Get
		Set
			m_bFiltroConcepto = Value
		End Set
	End Property
    Private m_bFiltroConcepto As Boolean

    Private m_sUsuario As String
    Public Property sUsuario() As String
        Get
            Return m_sUsuario
        End Get
        Set(ByVal value As String)
            m_sUsuario = value
        End Set
    End Property

    Public Sub New(prmPnlParent As Panel, parentHeight As Integer, prmStatusBarBottom As StatusStrip, Id As String)
        Me.Id = Id
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        InitializeComponent()
        Me.pnlParent = prmPnlParent
        Me.StatusBarBottom = prmStatusBarBottom
        ' To report progress from the background worker we need to set this property
        backgroundWorker1.WorkerReportsProgress = True
        ' This event will be raised on the worker thread when the worker starts
        AddHandler backgroundWorker1.DoWork, New DoWorkEventHandler(AddressOf backgroundWorker1_DoWork)
        ' This event will be raised when we call ReportProgress
        AddHandler backgroundWorker1.ProgressChanged, New ProgressChangedEventHandler(AddressOf backgroundWorker1_ProgressChanged)
        'Me.Size = New Size(prmPnlParent.Size.Width, prmPnlParent.Size.Height + prmPnlParent.Location.Y - Me.Location.Y - 70)
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.SuspendLayout()
        Me.DoubleBuffered = True

        gradientTab1.SelectedIndex = -1
        bEmpOcultos = False
        iEmpSelec = 0
        InicializarControles()
        CargarCombosPeriodosRegistrados()
        CargarComboEmpresas()
        gradientTab1.SelectedIndex = 0
        'progressBar1.BackColor = Color.FromArgb(153, 180, 51)

        Me.ResumeLayout()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub backgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs)
        dtDatosExcel = ExcelExtensions.LoadDataTableFromExcel(sPathBook, 0)
    End Sub
    Private Sub backgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        progressBar1.Value = e.ProgressPercentage
    End Sub
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Styles.DegradeBackGround(Me, e)
        Styles.HeaderLine(Me, e)
    End Sub
    Private Sub comboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox8.SelectedIndexChanged
        If comboBox8.SelectedIndex >= 0 Then
            errorIcono.SetError(comboBox8, "")
        End If
    End Sub
    Private Sub comboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox7.SelectedIndexChanged
        If comboBox7.SelectedIndex >= 0 Then
            errorIcono.SetError(comboBox7, "")
        End If
    End Sub
    Private Sub button1_Click_1(sender As Object, e As EventArgs) Handles button1.Click
        Dim oFD As New OpenFileDialog()
        oFD.Title = "Seleccionar Archivo"
        oFD.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
        'Determina el filtro para el tipo de archivo a abrir si es "" abre cuaquier tipo;
        oFD.FileName = Me.textBox1.Text

        Try
            If oFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                sPathBook = oFD.FileName
                Me.textBox1.Text = oFD.FileName

                label6.Visible = True
                label6.Text = "Cargando Datos Desde Archivo Excel " & Path.GetFileName(sPathBook)
                'pictureBox1.Visible = True
                MetroProgressSpinner1.Visible = True
                VerificarArchivoExcelXlsx()
                If (dtDatosExcel IsNot Nothing) Then
                    dtDatosExcel.Columns.Clear()
                    dataGridView1.Refresh()
                End If
                CargarDatosExcelenDataGridBGW()
            End If
        Catch generatedExceptionName As Exception
        End Try
    End Sub
    Private Sub button2_Click_1(sender As Object, e As EventArgs) Handles button2.Click

        Dim AccesoUsuario As New Form3()
        'AccesoUsuario.MdiParent = Me.MdiParent
        AccesoUsuario.Opener = Me
        AccesoUsuario.ShowDialog(Me)

        If ValidarPeridoComboBox() And bAcceso Then
            RegistrarAsistenciasEnSQL()
            CargarCombosPeriodosRegistrados()
        ElseIf Not ValidarPeridoComboBox() Then
            MessageBox.Show("El Periodo Seleccionado NO Coincide con las Fechas del Archivo", "Periodo Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If

        bAcceso = False

    End Sub
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        dataGridView1.SearchAndSelectValue(textBox2.Text, "1")
    End Sub
    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        If dataGridView2.RowCount > 0 Then
            dataGridView2.ExportToExcel()
        End If
    End Sub
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        If comboBox3.SelectedIndex <> -1 Then
            CargarDatosDetallePeriodoGrid()
            Dim dtEmpDet As DataTable = ListarEmpresas(dtDetallePeriodo)
            dtEmpDet.Rows.InsertAt(dtEmpDet.NewRow(), 0)
            comboBox6.DataSource = dtEmpDet
            comboBox6.DisplayMember = "Empresa"
            comboBox6.ValueMember = "Empresa"
            comboBox6.SelectedIndex = -1
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList
            button4.Enabled = True
            label14.Visible = True
            label14.Text = "Total Registros : " & dataGridView2.RowCount.ToString()
        End If

    End Sub
    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        If comboBox4.SelectedIndex <> -1 Then
            CargarDatosResumenPeriodoGrid()
            Dim dtEmpRes As DataTable = ListarEmpresas(dtResumenPeriodo)
            dtEmpRes.Rows.InsertAt(dtEmpRes.NewRow(), 0)
            comboBox5.DataSource = dtEmpRes
            comboBox5.DisplayMember = "Empresa"
            comboBox5.ValueMember = "Empresa"
            comboBox5.SelectedIndex = -1
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList
            button9.Enabled = True
            label15.Visible = True
            label15.Text = "Total Registros : " & dataGridView3.RowCount.ToString()
        End If
    End Sub
    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        If If(dtResumenPeriodo Is Nothing, False, dtResumenPeriodo.Rows.Count > 0) Then
            FiltrarResumenPeriodoGrid()
            label15.Visible = True
            label15.Text = "Total Registros : " & dataGridView3.RowCount.ToString()
        End If
    End Sub
    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        If If(dtDetallePeriodo Is Nothing, False, dtDetallePeriodo.Rows.Count > 0) Then
            FiltrarDetallePeriodoGrid()
            label14.Visible = True
            label14.Text = "Total Registros : " & dataGridView2.RowCount.ToString()
        End If
    End Sub
    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        If dataGridView3.RowCount > 0 Then
            dataGridView3.ExportToExcel()
        End If
    End Sub
    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        If dataGridView4.RowCount > 0 Then
            dataGridView4.ExportToExcel()
        End If
    End Sub
    Private Sub button11_Click(sender As Object, e As EventArgs) Handles button11.Click
        Dim AccesoUsuario As New Form3()
        AccesoUsuario.ShowDialog(Me)
    End Sub
    Private Sub button12_Click(sender As Object, e As EventArgs) Handles button12.Click
        Dim AccesoUsuario As New Form3()
        AccesoUsuario.Opener = Me
        AccesoUsuario.ShowDialog(Me)

        Dim dtConcepGrid As DataTable = DirectCast(dataGridView4.DataSource, DataTable)

        If dtConcepGrid IsNot Nothing AndAlso bAcceso Then
            If dtConcepGrid.Rows.Count > 0 Then
                Dim resp As String = MessageBox.Show("La Exportación Borrará los Registros de los Conceptos Asociados en GESTPER al Periodo '" & dtConceptos.Rows(0)(0).ToString() & "' de " & comboBox7.Text & "." & vbLf & vbCr & "¿Continuar Exportación?", "Expostar Datos a GESTPER", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question).ToString()

                If resp = "Yes" Then
                    ExportarConceptosSQLHistorico()
                    ExportarConceptosGESTPER()
                End If
            End If
        End If
        Me.bAcceso = False
    End Sub
    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        If If(dtConceptos Is Nothing, False, dtConceptos.Rows.Count > 0) Then
            FiltrarResumenConceptosGrid()
            label16.Visible = True
            label16.Text = "Total Registros : " & dataGridView4.Rows.Count.ToString()
        End If
    End Sub
    Private Sub button14_Click(sender As Object, e As EventArgs) Handles button14.Click
        If comboBox8.SelectedIndex >= 0 Then
            If comboBox7.SelectedIndex >= 0 Then
                checkBox2.Checked = False
                If radioButton1.Checked Then
                    button11.Enabled = True
                    button12.Enabled = True
                Else
                    button11.Enabled = False
                    button12.Enabled = False
                End If

                dataGridView4.Columns.Clear()
                CargarDatosConceptoPeriodoGrid()

                label16.Visible = True
                label16.Text = "Total Registros : " & dataGridView4.Rows.Count.ToString()
                button10.Enabled = True
            Else
                errorIcono.SetError(comboBox7, "Debe Seleccionar Una Empresa")
            End If
        Else
            errorIcono.SetError(comboBox8, "Debe Seleccionar Un Periodo")
        End If

    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        If (IsDBNull(CType(dataGridView2.DataSource, DataTable).Rows(0)("RegistroDB")) = False) Then
            Dim Origen As Integer = Convert.ToInt32(CType(dataGridView2.DataSource, DataTable).Rows(0)("RegistroDB"))

            Dim dtOrigen As DataTable = BAsistenciaPeriodoFile.ConsultarRegistro(Origen)

            Dim sFilePath As String
            Dim buffer As Byte() = dtOrigen.Rows(0)("FileStream")

            sFilePath = System.IO.Path.GetTempFileName()
            System.IO.File.Move(sFilePath, System.IO.Path.ChangeExtension(sFilePath, ".xlsx"))
            sFilePath = System.IO.Path.ChangeExtension(sFilePath, ".xlsx")
            System.IO.File.WriteAllBytes(sFilePath, buffer)
            Dim act As Action(Of String) = New Action(Of String)(AddressOf OpenFile)
            act.BeginInvoke(sFilePath, Nothing, Nothing)

        End If
    End Sub
    Private Sub textBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            button3.PerformClick()
        End If
    End Sub
    Private Sub textBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox4.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            button8.PerformClick()
        End If
    End Sub
    Private Sub textBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox3.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            button7.PerformClick()
        End If
    End Sub
    Private Sub textBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox5.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            button13.PerformClick()
        End If
    End Sub
    Private Shared Sub OpenFile(ByVal sFilePath)
        Using p As New System.Diagnostics.Process
            p.StartInfo = New System.Diagnostics.ProcessStartInfo(sFilePath)
            p.Start()
            'p.WaitForExit()
            Try
                System.IO.File.Delete(sFilePath)
            Catch
            End Try
        End Using
    End Sub
    Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged
        If checkBox1.Checked AndAlso dataGridView4.RowCount > 0 Then
            AgregarColumnaCheckConceptos()
        ElseIf dataGridView4.RowCount > 0 Then
            Try
                dataGridView4.Columns("chk").Visible = False
                'Cambia todos los valores de la columna "chk" a false
                CType(dataGridView4.DataSource, DataTable).Rows.Cast(Of DataRow).ToList().ForEach(Sub(x) x.SetField("chk", False))

                For Each row As DataGridViewRow In dataGridView4.Rows
                    row.DefaultCellStyle.BackColor = Color.White
                Next
            Catch ex As Exception
            End Try
        End If

    End Sub
    Private Sub checkBox2_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox2.CheckedChanged
        If checkBox2.Checked AndAlso dataGridView4.RowCount > 0 Then
            Dim dtConceptosSelec As DataTable = Nothing

            Dim rows = dtConceptos.AsEnumerable().[Select](Function(row) New With {
                Key .Codigo = row.Field(Of String)(7),
                Key .Descripcion = row.Field(Of String)(8)
            }).Distinct()

            dtConceptosSelec = dtConceptosSelec.LINQResultToDataTable(Of Object)(rows)

            Dim SeleccionarConceptos As New Form4()
            AddHandler SeleccionarConceptos.EnviarEvento, New Form4.LaunchEvent(AddressOf FiltrarConceptosGestper)
            ' Metodo Delegate para enviar datos desde SeleccionarConceptos
            SeleccionarConceptos.dtConceptos = dtConceptosSelec
            SeleccionarConceptos.Opener = Me
            SeleccionarConceptos.ShowDialog(Me)
        ElseIf dataGridView4.RowCount > 0 Then
            dataGridView4.DataSource = dtConceptos
            bFiltroConcepto = False
        Else
            checkBox2.Checked = False
        End If

    End Sub
    Private Sub checkBox2_Click(sender As Object, e As EventArgs) Handles checkBox2.Click
        'if (bFiltroConcepto && !checkBox2.Checked) //Si existe Filtro de Conceptos se mantiene activo el check
        '    checkBox2.Checked = true;
    End Sub
    Private Sub dataGridView4_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dataGridView4.CurrentCellDirtyStateChanged
        If dataGridView4.IsCurrentCellDirty Then
            dataGridView4.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub dataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView4.CellContentClick
        If e.RowIndex = -1 Then
            Return
        End If

        If dataGridView4.Columns(e.ColumnIndex).Name = "chk" Then
            Dim row As DataGridViewRow = dataGridView4.Rows(e.RowIndex)

            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells(e.ColumnIndex), DataGridViewCheckBoxCell)

            SeleccionarEmpleadoChk(row.Cells(3).Value.ToString(), Convert.ToBoolean(cellSelecion.Value))
        End If
    End Sub
    Private Sub dataGridView4_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView4.CellContentDoubleClick
        If e.RowIndex = -1 Then
            Return
        End If

        If dataGridView4.Columns(e.ColumnIndex).Name = "chk" Then
            Dim row As DataGridViewRow = dataGridView4.Rows(e.RowIndex)

            Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells(e.ColumnIndex), DataGridViewCheckBoxCell)

            SeleccionarEmpleadoChk(row.Cells(3).Value.ToString(), Convert.ToBoolean(cellSelecion.Value))
        End If
    End Sub
    Private Sub dataGridView4_Sorted(sender As Object, e As EventArgs) Handles dataGridView4.Sorted
        If iEmpSelec > 0 Then
            For Each row As DataGridViewRow In dataGridView4.Rows
                If CBool(row.Cells("chk").Value) Then
                    row.DefaultCellStyle.BackColor = Color.LightBlue
                    DirectCast(row.Cells("chk"), DataGridViewCheckBoxCell).Value = True
                End If
            Next
        End If
    End Sub
    Private Sub dataGridView4_MouseClick(sender As Object, e As MouseEventArgs) Handles dataGridView4.MouseClick
        If e.Button = MouseButtons.Right And checkBox1.Checked And iEmpSelec > 0 Then
            Dim currentMouseOverRow As Integer = dataGridView4.HitTest(e.X, e.Y).RowIndex
            Dim currentMouseOverCol As Integer = dataGridView4.HitTest(e.X, e.Y).ColumnIndex

            Try
                If Not bEmpOcultos Then
                    dataGridView4.Rows((currentMouseOverRow)).Selected = True
                    'Me.contextOcultarSelec.Show(dataGridView4, New Point(e.X, e.Y))
                    Me.contextOcultarSelec.Show(Cursor.Position)
                Else
                    dataGridView4.Rows((currentMouseOverRow)).Selected = True
                    'Me.contextVerSelec.Show(dataGridView4, New Point(e.X, e.Y))
                    Me.contextVerSelec.Show(Cursor.Position)
                End If
            Catch generatedExceptionName As Exception
            End Try
        End If
    End Sub
    Private Sub dataGridView4_DataSourceChanged(sender As Object, e As EventArgs) Handles dataGridView4.DataSourceChanged
        label16.Text = "Total Registros : " & dataGridView4.Rows.Count.ToString()
        If iEmpSelec > 0 Then
            For Each row As DataGridViewRow In dataGridView4.Rows
                Try
                    If CBool(row.Cells("chk").Value) Then
                        row.DefaultCellStyle.BackColor = Color.LightBlue
                        DirectCast(row.Cells("chk"), DataGridViewCheckBoxCell).Value = True
                    End If
                Catch ex As Exception
                    row.DefaultCellStyle.BackColor = Color.White
                End Try
            Next
        End If
    End Sub
    Private Sub toolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles contextVerSelec.Click
        MostrarFilasNoSeleccionadas(dataGridView4)
        bEmpOcultos = False
    End Sub
    Private Sub toolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles contextOcultarSelec.Click
        OcultarFilasNoSeleccionadas(dataGridView4)
        bEmpOcultos = True
    End Sub

    ''' <summary>
    ''' PROEDIMIENTOS Y FUNCIONES
    ''' </summary>
    Private Sub InicializarControles()
        progressBar1.Visible = False
        progressBar2.Visible = False
        progressBar3.Visible = False
        pictureBox1.Visible = False
        MetroProgressSpinner1.Visible = False
        button11.Visible = False
        'transparentTabControl1.MakeTransparent();
        label6.Visible = False
        label7.Visible = False
        label14.Visible = False
        label15.Visible = False
        label16.Visible = False
        label20.Visible = False

        comboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        comboBox1.SelectedIndex = -1
        comboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        comboBox2.SelectedIndex = -1

        radioButton1.Checked = True
    End Sub
    Private Sub RegistrarAsistenciasEnSQL()

        progressBar1.Visible = True
        'label6.Visible = true;
        progressBar1.Maximum = dataGridView1.Rows.Count
        progressBar1.Minimum = 0
        progressBar1.[Step] = 1
        progressBar1.Value = 0

        Dim dRegistro As DateTime = DateTime.Now
        Dim sUser As String = sUsuario
        Dim sHost As String = SystemInformation.ComputerName()
        Dim nProxReg As Integer = BAsistenciaPeriodoFile.ObtenerProximoIngreso

        BAsistenciaPeriodoFile.Insertar(dataGridView1.Rows(0).Cells("Periodo").Value.ToString() _
                                        , nProxReg.ToString() _
                                        , dRegistro _
                                        , sUser _
                                        , textBox1.Text _
                                        , FilestoBinary.GenerateByteArrayFileStream(textBox1.Text) _
                                        , sHost)

        BAsistenciaPeriodo.Eliminar(dataGridView1.Rows(0).Cells("Periodo").Value.ToString())

        For Each row As DataGridViewRow In dataGridView1.Rows
            BAsistenciaPeriodo.Insertar(row.Cells("Periodo").Value.ToString() _
                                        , row.Cells(1).Value.ToString() _
                                        , row.Cells(2).Value.ToString() _
                                        , row.Cells(3).Value.ToString() _
                                        , row.Cells(4).Value.ToString() _
                                        , row.Cells(5).Value.ToString() _
                                        , row.Cells(6).Value.ToString() _
                                        , row.Cells(7).Value.ToString() _
                                        , row.Cells(8).Value.ToString() _
                                        , row.Cells(9).Value.ToString() _
                                        , row.Cells(10).Value.ToString() _
                                        , row.Cells(11).Value.ToString() _
                                        , row.Cells(12).Value.ToString() _
                                        , row.Cells(13).Value.ToString() _
                                        , row.Cells(14).Value.ToString() _
                                        , row.Cells(15).Value.ToString() _
                                        , row.Cells(16).Value.ToString() _
                                        , row.Cells(17).Value.ToString() _
                                        , row.Cells(18).Value.ToString() _
                                        , "" _
                                        , dRegistro _
                                        , nProxReg _
                                        , row.Cells(19).Value.ToString() _
                                        , row.Cells(20).Value.ToString())
            progressBar1.PerformStep()
            label6.Text = progressBar1.Value.ToString() & " / " & progressBar1.Maximum.ToString()
        Next
        MessageBox.Show(progressBar1.Value.ToString() & " Registros Exportados", "Exportacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        progressBar1.Visible = False
        label6.Visible = False
    End Sub
    Private Sub VerificarArchivoExcelXlsx()
        ' Verifica si existe el archivo en formato XLSX sino lo crea
        If Path.GetExtension(sPathBook).ToLower() = ".xls" Then
            If Not File.Exists(Path.ChangeExtension(sPathBook, ".xlsx")) Then
                ExcelExtensions.SaveXSLtoXLSX(sPathBook)
            End If
        End If
        'Solo se trabaja con archivos XSLX
        sPathBook = Path.ChangeExtension(sPathBook, ".xlsx")
    End Sub
    Private Sub CargarFormatearExcelenDataTable()
        Try
            'Cargar dtDatosExcel 
            dtDatosExcel = ExcelExtensions.LoadDataTableFromExcel(sPathBook, 0)

            'Cambiar Nombres de Columnas por las descripciones de la fila 5
            Dim results As EnumerableRowCollection(Of DataRow) = From myRow In dtDatosExcel.AsEnumerable() Where (myRow.Field(Of String)(0) = "ID") Select myRow

            Dim dtCabecera As DataTable = results.CopyToDataTable()
            For Each row As DataRow In dtCabecera.Rows
                For Each dc As DataColumn In dtCabecera.Columns
                    Dim field1 = row(dc).ToString()
                    field1 = If(dc.ColumnName = "F5" OrElse dc.ColumnName = "F111", field1 & "2", field1)
                    dtDatosExcel.Columns(dc.ColumnName).ColumnName = field1
                Next
            Next

            'Eliminar Columnas vacias o con informacion no relevantehec
            Dim toDelete = dtDatosExcel.Rows.OfType(Of DataRow)() _
                          .Where(Function(r) [String].IsNullOrEmpty(r.Field(Of String)(0)) _
                                 OrElse [String].IsNullOrEmpty(r.Field(Of String)(2)) _
                                 OrElse (r.Field(Of String)("ID").Length < 3) _
                                 OrElse (r.Field(Of String)(0)) = "ID") _
                          .ToList() '.ForEach(Function(r As DataRow) r.Delete())


            For Each row As DataRow In toDelete
                row.Delete()
            Next

            'Agregar Columna con numero de Registro y Periodo
            dtDatosExcel.Columns.Add("N°", GetType(Integer))
            dtDatosExcel.Columns.Add("Periodo", GetType(Integer))
            dtDatosExcel.SetColumnsOrder("N°")

            Dim Deleted As Integer = dtDatosExcel.AsEnumerable().Where(Function(dataRow) dataRow.RowState = DataRowState.Deleted AndAlso dtDatosExcel.Rows.IndexOf(dataRow) < 20).Count()

            Dim toAssing = dtDatosExcel.Rows.OfType(Of DataRow)().Where(Function(dataRow) dataRow.RowState <> DataRowState.Deleted).ToList() '.ForEach(Function(r) InlineAssignHelper(r(0), dtDatosExcel.Rows.IndexOf(r) - (Deleted - 1)))

            For Each row As DataRow In toAssing
                row(0) = dtDatosExcel.Rows.IndexOf(row) - (Deleted - 1)
            Next

        Catch generatedExceptionName As Exception
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub
    Private Sub CargarDatosExcelenDataGrid()
        Try
            'Asignar DataTable a Grid
            dataGridView1.DataSource = dtDatosExcel
            dataGridView1.AutoResizeColumns()
            label7.Visible = True
            label7.Text = "Total Registros : " & dataGridView1.Rows.Count.ToString()

            If dtDatosExcel.Rows.Count > 0 Then
                button2.Enabled = True
            Else
                button2.Enabled = False
            End If
        Catch generatedExceptionName As Exception
        End Try
    End Sub
    Private Sub CargarDatosExcelenDataGridBGW()
        backgroundWorker2.RunWorkerAsync()
    End Sub
    Private Sub CargarDatosDetallePeriodoGrid()
        If comboBox3.SelectedIndex <> -1 Then
            Dim sPeriodo As String = comboBox3.SelectedValue.ToString()
            dtDetallePeriodo = BAsistenciaPeriodo.ConsultarAsistenciaDetallada(sPeriodo)

            'dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
            dataGridView2.DataSource = dtDetallePeriodo

            If (IsDBNull(dtDetallePeriodo.Rows(0)("RegistroDB")) = False) Then
                Button15.Enabled = True
            Else
                Button15.Enabled = False
            End If

        End If
    End Sub
    Private Sub CargarDatosResumenPeriodoGrid()
        If comboBox4.SelectedIndex <> -1 Then
            Dim sPeriodo As String = comboBox4.SelectedValue.ToString()
            dtResumenPeriodo = BAsistenciaPeriodo.ConsultarAsistenciaResumen(sPeriodo)


            'dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
            dataGridView3.DataSource = dtResumenPeriodo
        End If
    End Sub
    Private Sub CargarDatosConceptoPeriodoGrid()
        If radioButton1.Checked Then
            dtConceptos = BAsistenciaConceptos.GenerarResumenConceptos(comboBox8.SelectedValue.ToString(), comboBox7.SelectedValue.ToString())
            Dim dtAlmuerzos As DataTable = BAsistenciaConceptos.GenerarResumenAlmuerzos(comboBox8.SelectedValue.ToString(), comboBox7.SelectedValue.ToString())
            dtConceptos.Merge(dtAlmuerzos)

            If dtConceptos IsNot Nothing Then
                Dim results As EnumerableRowCollection(Of System.Data.DataRow) = From myRow In dtConceptos.AsEnumerable() Order By myRow(0), myRow(1), myRow(5), myRow(7) Select myRow

                If results IsNot Nothing Then
                    dtConceptos = results.CopyToDataTable() '.CopyToDataTable()
                End If
            Else
                MessageBox.Show("La Consulta No Retorno Ningun Resultado", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            dtConceptos = BAsistenciaConceptos.ConsultarResumenConceptosUltimo(comboBox8.SelectedValue.ToString(), comboBox7.SelectedValue.ToString())
        End If

        If dtConceptos IsNot Nothing Then
            'Asignar DataTable a Grid
            dataGridView4.DataSource = dtConceptos
            dataGridView4.AutoResizeColumns()
            Try
                For Each Col As DataGridViewTextBoxColumn In dataGridView4.Columns
                    Col.[ReadOnly] = True
                Next
            Catch generatedExceptionName As Exception
            End Try

            If checkBox1.Checked Then
                AgregarColumnaCheckConceptos()
            End If

            If dtConceptos.Rows.Count = 0 Then
                MessageBox.Show("No Existen Registros en la BD", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub
    Private Sub CargarCombosPeriodoExcel()
        'Ubica la Mayor fecha de registro para determinar el Periodo
        Dim levels As List(Of DateTime) = dtDatosExcel.AsEnumerable() _
                                          .Where(Function(dataRow) dataRow.RowState <> DataRowState.Deleted) _
                                          .TakeWhile(Function(p) Not [String].IsNullOrEmpty(p.Field(Of String)(3))) _
                                          .[Select](Function(al) Convert.ToDateTime(al.Field(Of String)(3))) _
                                          .Distinct().ToList()

        'levels = levels.Where(x => !String.IsNullOrEmpty(x.Trim())).ToList();
        levels.RemoveAll(Function(item) [String].IsNullOrEmpty(item.ToString()))
        'while (levels.Remove(null)) { };
        'levels.ForEach(q => levels.RemoveAll(o => o == null));
        Dim min As String = levels.Min().ToString()
        Dim max As String = levels.Max().ToString()

        Dim Año As Integer = Convert.ToDateTime(max).Year
        Dim Mes As Integer = Convert.ToDateTime(max).Month
        comboBox1.SelectedItem = Año.ToString()
        comboBox2.SelectedItem = Mes.ToString()
    End Sub
    Private Sub CargarCombosPeriodosRegistrados()
        Dim dtPeriodos1 As DataTable = BAsistenciaPeriodo.ConsultarPeriodosRegistrados()
        Dim dtPeriodos2 As DataTable = dtPeriodos1.Copy()
        Dim dtPeriodos3 As DataTable = dtPeriodos1.Copy()

        comboBox3.DataSource = dtPeriodos1
        comboBox3.DisplayMember = "PeriodoT"
        comboBox3.ValueMember = "PeriodoI"

        comboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        comboBox3.SelectedIndex = -1

        comboBox4.DataSource = dtPeriodos2
        comboBox4.DisplayMember = "PeriodoT"
        comboBox4.ValueMember = "PeriodoI"

        comboBox4.DropDownStyle = ComboBoxStyle.DropDownList
        comboBox4.SelectedIndex = -1

        comboBox8.DataSource = dtPeriodos3
        comboBox8.DisplayMember = "PeriodoT"
        comboBox8.ValueMember = "PeriodoI"

        comboBox8.DropDownStyle = ComboBoxStyle.DropDownList
        comboBox8.SelectedIndex = -1
    End Sub
    Private Sub CargarComboEmpresas()
        Dim dtEmpresas1 As DataTable = BEmpresas.ListarEmpresas()
        comboBox7.DataSource = dtEmpresas1
        comboBox7.DisplayMember = "Nombre"
        comboBox7.ValueMember = "RUT"

        comboBox7.DropDownStyle = ComboBoxStyle.DropDownList
        comboBox7.SelectedIndex = -1
    End Sub
    Private Sub InsertarPeriodoenDataTable(Año As String, Mes As String)
        'Colocar Periodo en Columna de DataTable
        Dim toInsert = dtDatosExcel.Rows.OfType(Of DataRow)().Where(Function(dataRow) dataRow.RowState <> DataRowState.Deleted).ToList()

        For Each row As DataRow In toInsert
            row("Periodo") = Año.ToString().Trim() & Mes.ToString().Trim().PadLeft(2, "0"c)
        Next

    End Sub
    Private Function ValidarPeridoComboBox() As Boolean
        Dim Año As String = comboBox1.SelectedItem.ToString()
        Dim Mes As String = comboBox2.SelectedItem.ToString()
        Dim PeriodoExcel As String = dataGridView1.Rows(0).Cells("Periodo").Value.ToString()
        'dtDatosExcel.Rows[0]["Periodo"].ToString();
        Return If(PeriodoExcel = Año.Trim() & Mes.Trim().PadLeft(2, "0"c), True, False)
    End Function
    Private Function ListarEmpresas(dtConsulta As DataTable) As DataTable
        Dim dt As DataTable = Nothing

        Dim distinctValues = dtConsulta.AsEnumerable().[Select](Function(row) New With {
            Key .Empresa = row.Field(Of String)("Empresa").ToUpper()
        }).Distinct().ToList()

        dt = dt.LINQResultToDataTable(Of Object)(distinctValues)

        Return dt
    End Function
    Private Sub FiltrarDetallePeriodoGrid()
        Dim dtf As DataTable

        If textBox4.Text.Trim().Length > 0 Then
            If comboBox6.SelectedIndex > 0 Then
                Dim results As EnumerableRowCollection(Of System.Data.DataRow) = From myRow In dtDetallePeriodo.AsEnumerable()
                                                                                 Where (myRow.Field(Of String)("Empresa").ToUpper() = comboBox6.SelectedValue.ToString() _
                                                                                        AndAlso ((Not [String].IsNullOrEmpty(myRow.Field(Of String)("Nombre")) _
                                                                                        AndAlso myRow.Field(Of String)("Nombre").ToUpper().Contains(textBox4.Text.Trim().ToUpper())) _
                                                                                                OrElse (Not [String].IsNullOrEmpty(myRow.Field(Of String)("Rut")) _
                                                                                                        AndAlso myRow.Field(Of String)("Rut").ToUpper().Contains(textBox4.Text.Trim().ToUpper()))))
                                                                                 Order By myRow(29), myRow(1), myRow(4), myRow(7)
                                                                                 Select myRow

                If results.Any() Then
                    dtf = results.CopyToDataTable()
                    If dtf.Rows.Count > 0 Then
                        dataGridView2.DataSource = dtf
                    End If
                End If
            Else
                Dim results As EnumerableRowCollection(Of System.Data.DataRow) = From myRow In dtDetallePeriodo.AsEnumerable() Where ((Not [String].IsNullOrEmpty(myRow.Field(Of String)("Nombre")) AndAlso myRow.Field(Of String)("Nombre").ToUpper().Contains(textBox4.Text.Trim().ToUpper())) OrElse (Not [String].IsNullOrEmpty(myRow.Field(Of String)("Rut")) AndAlso myRow.Field(Of String)("Rut").ToUpper().Contains(textBox4.Text.Trim().ToUpper()))) Order By myRow(29), myRow(1), myRow(4), myRow(7) Select myRow

                If results.Any() Then
                    dtf = results.CopyToDataTable()
                    If dtf.Rows.Count > 0 Then
                        dataGridView2.DataSource = dtf
                    End If
                End If
            End If
        ElseIf comboBox6.SelectedIndex > 0 Then
            Dim results As EnumerableRowCollection(Of System.Data.DataRow) = From myRow In dtDetallePeriodo.AsEnumerable() Where (myRow.Field(Of String)("Empresa").ToUpper() = comboBox6.SelectedValue.ToString()) Order By myRow(29), myRow(1), myRow(4), myRow(7) Select myRow

            If results.Any() Then
                dtf = results.CopyToDataTable()
                If dtf.Rows.Count > 0 Then
                    dataGridView2.DataSource = dtf
                End If
            End If
        Else
            Dim results As EnumerableRowCollection(Of System.Data.DataRow) = From myRow In dtDetallePeriodo.AsEnumerable() Order By myRow(29), myRow(1), myRow(4), myRow(7) Select myRow

            If results.Any() Then
                dtf = results.CopyToDataTable()
                If dtf.Rows.Count > 0 Then
                    dataGridView2.DataSource = dtf
                End If
            End If
        End If
    End Sub
    Private Sub FiltrarResumenPeriodoGrid()
        Dim dtf As DataTable

        If textBox3.Text.Trim().Length > 0 Then
            If comboBox5.SelectedIndex > 0 Then
                Dim results As EnumerableRowCollection(Of System.Data.DataRow) = From myRow In dtResumenPeriodo.AsEnumerable() Where (myRow.Field(Of String)("Empresa").ToUpper() = comboBox5.SelectedValue.ToString() AndAlso ((Not [String].IsNullOrEmpty(myRow.Field(Of String)("Nombre")) AndAlso myRow.Field(Of String)("Nombre").ToUpper().Contains(textBox3.Text.Trim().ToUpper())) OrElse (Not [String].IsNullOrEmpty(myRow.Field(Of String)("Rut")) AndAlso myRow.Field(Of String)("Rut").ToUpper().Contains(textBox3.Text.Trim().ToUpper())))) Order By myRow(19), myRow(4) Select myRow

                If results.Any() Then
                    dtf = results.CopyToDataTable()
                    If dtf.Rows.Count > 0 Then
                        dataGridView3.DataSource = dtf
                    End If
                End If
            Else
                Dim results As EnumerableRowCollection(Of System.Data.DataRow) = From myRow In dtResumenPeriodo.AsEnumerable() Where ((Not [String].IsNullOrEmpty(myRow.Field(Of String)("Nombre")) AndAlso myRow.Field(Of String)("Nombre").ToUpper().Contains(textBox3.Text.Trim().ToUpper())) OrElse (Not [String].IsNullOrEmpty(myRow.Field(Of String)("Rut")) AndAlso myRow.Field(Of String)("Rut").ToUpper().Contains(textBox3.Text.Trim().ToUpper()))) Order By myRow(19), myRow(4) Select myRow

                If results.Any() Then
                    dtf = results.CopyToDataTable()
                    If dtf.Rows.Count > 0 Then
                        dataGridView3.DataSource = dtf
                    End If
                End If
            End If
        ElseIf comboBox5.SelectedIndex > 0 Then
            Dim results As EnumerableRowCollection(Of System.Data.DataRow) = From myRow In dtResumenPeriodo.AsEnumerable() Where (myRow.Field(Of String)("Empresa").ToUpper() = comboBox5.SelectedValue.ToString()) Order By myRow(19), myRow(4) Select myRow

            If results.Any() Then
                dtf = results.CopyToDataTable()
                If dtf.Rows.Count > 0 Then
                    dataGridView3.DataSource = dtf
                End If
            End If
        Else
            Dim results As EnumerableRowCollection(Of System.Data.DataRow) = From myRow In dtResumenPeriodo.AsEnumerable() Order By myRow(19), myRow(4) Select myRow

            If results.Any() Then
                dtf = results.CopyToDataTable()
                If dtf.Rows.Count > 0 Then
                    dataGridView3.DataSource = dtf
                End If
            End If
        End If
    End Sub
    Private Sub FiltrarResumenConceptosGrid()
        Dim dtf As DataTable

        If textBox5.Text.Trim().Length > 0 AndAlso dtConceptos.Rows.Count > 0 Then
            Dim results As EnumerableRowCollection(Of System.Data.DataRow) = From myRow In dtConceptos.AsEnumerable() Where (((Not [String].IsNullOrEmpty(myRow.Field(Of String)("Nombre")) AndAlso myRow.Field(Of String)("Nombre").ToUpper().Contains(textBox5.Text.Trim().ToUpper())) OrElse (Not [String].IsNullOrEmpty(myRow.Field(Of String)("Rut")) AndAlso myRow.Field(Of String)("Rut").ToUpper().Contains(textBox5.Text.Trim().ToUpper())))) Order By myRow(1), myRow(2), myRow(6), myRow(8) Select myRow

            If results.Any() Then
                dtf = results.CopyToDataTable()
                If dtf.Rows.Count > 0 Then
                    dataGridView4.DataSource = dtf
                End If
            End If
        ElseIf dtConceptos.Rows.Count > 0 Then
            dataGridView4.DataSource = dtConceptos
        End If
    End Sub
    Private Sub ExportarConceptosSQLHistorico()
        Dim dFechaActual As DateTime = DateTime.Now


        'BAsistenciaConceptos.Eliminar(dataGridView4.Rows[0].Cells["Periodo"].Value.ToString());
        Dim ProxRegistro As Integer = BAsistenciaConceptos.ObtenerProximoIngreso()

        For Each row As DataGridViewRow In dataGridView4.Rows

            Dim RegistroOrigen As Object = row.Cells("RegistroDB").Value
            If (RegistroOrigen Is DBNull.Value) Then
                RegistroOrigen = 0
            End If

            BAsistenciaConceptos.Insertar(row.Cells("Periodo").Value.ToString(), row.Cells(1).Value.ToString(), row.Cells(2).Value.ToString(), row.Cells(3).Value.ToString(), row.Cells(4).Value.ToString(), Convert.ToInt32(row.Cells(5).Value),
                row.Cells(6).Value.ToString(), row.Cells(7).Value.ToString(), row.Cells(8).Value.ToString(), row.Cells(9).Value.ToString(), Convert.ToDouble(row.Cells(10).Value.ToString()), row.Cells(11).Value.ToString(),
                dFechaActual, ProxRegistro, Convert.ToInt32(RegistroOrigen), sUsuario)
        Next

    End Sub
    Private Sub ExportarConceptosGESTPER()
        progressBar2.Style = ProgressBarStyle.Continuous
        progressBar2.Visible = True
        label20.Visible = True
        progressBar2.Minimum = 0
        progressBar2.[Step] = 1
        progressBar2.Value = 0

        Dim sRutEmp As String = DirectCast(dataGridView4.DataSource, DataTable).Rows(0)(2).ToString()
        Dim sPeriodo As String = DirectCast(dataGridView4.DataSource, DataTable).Rows(0)(0).ToString()
        Dim sConcepto As String
        Dim sRutTrab As String

        Dim dtGestPer As DataTable = DirectCast(dataGridView4.DataSource, DataTable)

        If bFiltroConcepto OrElse iEmpSelec > 0 Then
            If iEmpSelec > 0 Then
                Dim results As EnumerableRowCollection(Of System.Data.DataRow) = From myRow In dtGestPer.AsEnumerable()
                                                                                 Where (myRow.Field(Of Boolean)("chk"))
                                                                                 Order By myRow(5), myRow(7)
                                                                                 Select myRow

                If results.Any() Then
                    dtGestPer = results.CopyToDataTable()
                End If
            End If

            progressBar2.Maximum = dtGestPer.Rows.Count
            For Each row As DataRow In dtGestPer.Rows
                sConcepto = row("Concepto").ToString()
                sRutTrab = row("RUT").ToString()
                BGestPer.EliminarConceptosPeriodoCodigoTrab(sPeriodo, sRutEmp, sConcepto, sRutTrab)
                'Eliminar Conceptos del Periodo y Trabajador Existentes en GESTPER 
                BGestPer.InsertarResumenConceptosCodigoTrab(sPeriodo, sRutEmp, sConcepto, sRutTrab)
                'Insertar Conceptos del Periodo Existentes en GESTPER 
                progressBar2.PerformStep()
                label20.Text = progressBar1.Value.ToString() & " / " & progressBar1.Maximum.ToString()

            Next
        ElseIf Not bFiltroConcepto AndAlso iEmpSelec = 0 Then
            BGestPer.EliminarConceptosPeriodo(sPeriodo, sRutEmp)
            'Eliminar Conceptos del Periodo Existentes en GESTPER 
            BGestPer.InsertarResumenConceptos(sPeriodo, sRutEmp)
            'Insertar Conceptos del Periodo Existentes en GESTPER 
            For Each row As DataRow In dtGestPer.Rows
                progressBar2.PerformStep()
                label20.Text = progressBar1.Value.ToString() & " / " & progressBar1.Maximum.ToString()
            Next
        End If

        MessageBox.Show(progressBar2.Value.ToString() & " Registros Exportados", "Exportacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        progressBar2.Visible = False
        label20.Visible = False
    End Sub
    Private Sub backgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles backgroundWorker2.DoWork
        CargarFormatearExcelenDataTable()
    End Sub
    Private Sub backgroundWorker2_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles backgroundWorker2.ProgressChanged
        label6.Text = label6.Text & "."
    End Sub
    Private Sub backgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles backgroundWorker2.RunWorkerCompleted
        label6.Visible = False
        pictureBox1.Visible = False
        MetroProgressSpinner1.Visible = False
        'progressBar3.Visible = false;
        'progressBar3.Style = ProgressBarStyle.Continuous;

        CargarDatosExcelenDataGrid()
        CargarCombosPeriodoExcel()
        InsertarPeriodoenDataTable(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString())

    End Sub
    Private Sub progressWorker_DoWork(sender As Object, e As DoWorkEventArgs)
        'for (int i = 1; i <= 50; i++)
        '{
        '    if (progressWorker.CancellationPending)
        '    {
        '        e.Cancel = true;
        '        break;
        '    }
        '    // simulate long operation
        '    System.Threading.Thread.Sleep(10);
        '    progressWorker.ReportProgress(i);
        '}
    End Sub
    Private Sub progressWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        'Console.WriteLine(e.ProgressPercentage);
    End Sub
    Private Sub progressWorker_RunCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        'progressWorker.Reset();
        'progressWorker.Visible = false;
    End Sub
    Private Sub AgregarColumnaCheckConceptos()
        Dim dt As DataTable = DirectCast(dataGridView4.DataSource, DataTable)

        If Not DirectCast(dataGridView4.DataSource, DataTable).Columns.Contains("chk") Then
            DirectCast(dataGridView4.DataSource, DataTable).Columns.Add(New DataColumn("chk", GetType(Boolean)))
        End If

        For Each row As DataRow In DirectCast(dataGridView4.DataSource, DataTable).Rows
            row("chk") = False
        Next

        DirectCast(dataGridView4.DataSource, DataTable).AcceptChanges()
        'dataGridView4.DataSource 

        Dim chk As DataGridViewCheckBoxColumn = DirectCast(dataGridView4.Columns("chk"), DataGridViewCheckBoxColumn)
        chk.Visible = True
        chk.[ReadOnly] = False
        chk.HeaderText = "Selec."
        chk.Name = "chk"
        chk.Width = 50

    End Sub
    Private Sub SeleccionarEmpleadoChk(EmpRut As String, ValorChk As Boolean)
        For Each row As DataGridViewRow In dataGridView4.Rows
            Dim eRut As String = row.Cells(3).Value.ToString()
            If EmpRut = eRut Then
                If ValorChk Then
                    row.DefaultCellStyle.BackColor = Color.LightBlue
                    DirectCast(row.Cells("chk"), DataGridViewCheckBoxCell).Value = True
                    iEmpSelec += 1
                Else
                    row.DefaultCellStyle.BackColor = Color.White
                    DirectCast(row.Cells("chk"), DataGridViewCheckBoxCell).Value = False
                    iEmpSelec -= 1
                End If
            End If
        Next
    End Sub
    Private Sub OcultarFilasNoSeleccionadas(Grid As DataGridView)
        dataGridView4.CurrentCell = Nothing
        For Each row As DataGridViewRow In dataGridView4.Rows
            If Not Convert.ToBoolean(row.Cells("chk").Value) Then
                row.Visible = False
            End If
        Next
    End Sub
    Private Sub MostrarFilasNoSeleccionadas(Grid As DataGridView)
        For Each row As DataGridViewRow In dataGridView4.Rows
            If Not Convert.ToBoolean(row.Cells("chk").Value) Then
                row.Visible = True
            End If
        Next
    End Sub
    Private Sub FiltrarConceptosGestper(lConceptos As List(Of String))
        Dim results As EnumerableRowCollection(Of System.Data.DataRow) = From myRow In dtConceptos.AsEnumerable() Where (lConceptos.Contains(myRow.Field(Of String)("Concepto"))) Order By myRow(5), myRow(7) Select myRow

        If results.Any() Then
            Dim dtf As DataTable = results.CopyToDataTable()
            If dtf.Rows.Count > 0 Then
                'dtf.DefaultView.Sort = "P_CI";
                dataGridView4.DataSource = dtf
            End If
        End If
    End Sub

#Region "Definicion de Interface IComunication"

    '''Definicion de Interface
    '''IComunication
    Public Sub ChangeButtonEnabled(Status As Boolean, IDButton As String) Implements IComunication.ChangeButtonEnabled
        Dim oButton As Control = ManipulateForm.GetControl(Of Button)(Me, IDButton)
        DirectCast(oButton, Button).Enabled = Status

        'var cList = this.GetAllControlList().ToList();//GetSelfAndChildrenRecursive(this).ToList();

        'foreach (Control control in cList)
        '{
        '    if (control.GetType() == typeof(Button) && control.Name == IDButton)
        '    {
        '        ((Button)control).Enabled = Status;
        '    }
        '}
    End Sub
    Public Sub ChangeCheckBoxStatus(Status As Boolean, IDCheck As String) Implements IComunication.ChangeCheckBoxStatus
        Dim oCheckBox As Control = ManipulateForm.GetControl(Of CheckBox)(Me, IDCheck)
        DirectCast(oCheckBox, CheckBox).Checked = Status
    End Sub
    Public Sub ChangeTextLabel(Text As String, IDLabel As String) Implements IComunication.ChangeTextLabel
        Dim oLabel As Control = ManipulateForm.GetControl(Of Label)(Me, IDLabel)
        DirectCast(oLabel, Label).Text = Text
    End Sub
    Public Sub ChangeBoolProperty(bStatus As Boolean, sPropertyName As String) Implements IComunication.ChangeBoolProperty
        ManipulateForm.ChangeBoolProperty(Me, bStatus, sPropertyName)
        'this.bAcceso = bStatus;
        'var cList = this.GetType().GetProperties().ToList();//GetSelfAndChildrenRecursive(this).ToList();

        'Type t = this.GetType();
        'PropertyInfo[] props = t.GetProperties();
        'PropertyInfo[] aPropertyInfo = this.GetType().GetProperties();

        'foreach (PropertyInfo propertyInfo in cList)
        '{
        '    if (propertyInfo.Name == sPropertyName)
        '        try
        '        {
        '            if (propertyInfo.PropertyType.Equals(typeof(Boolean)))
        '            propertyInfo.SetValue(this, (bool)bStatus);
        '        }
        '        catch (Exception) { }
        '}
    End Sub
    Public Sub ChangeStringProperty(sValor As String, sPropertyName As String) Implements IComunication.ChangeStringProperty
        ManipulateForm.ChangeStringProperty(Me, sValor, sPropertyName)
    End Sub
    Public Sub ExecuteProcedure(Name As String, Parameters As List(Of Object)) Implements IComunication.ExecuteProcedure

    End Sub
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        Me.Close()

    End Sub

    Private Sub gradientTab1_Deselected(sender As Object, e As TabControlEventArgs) Handles gradientTab1.Deselected

        Tab_gradient = gradientTab1.SelectedIndex
    End Sub

    Private Sub gradientTab1_Selected(sender As Object, e As TabControlEventArgs) Handles gradientTab1.Selected
        Select Case e.TabPageIndex
            Case 0
                If Not RevisaAcceso(91010) Then gradientTab1.SelectedIndex = Tab_gradient
            Case 1
                If Not RevisaAcceso(91011) Then gradientTab1.SelectedIndex = Tab_gradient
            Case 2
                If Not RevisaAcceso(91012) Then gradientTab1.SelectedIndex = Tab_gradient
            Case 3
                If Not RevisaAcceso(91013) Then gradientTab1.SelectedIndex = Tab_gradient
        End Select
    End Sub


    Function RevisaAcceso(Campo As Integer) As Boolean
        Dim conexion As New SqlConnection
        Dim dt As New DataTable
        Dim cmd As SqlCommand

        conexion.ConnectionString = "Data Source=FSSAPBO;Initial Catalog = SAC_Mindugar; Persist Security Info=True;User ID = sa; Password=Sqladmin281"
        cmd = New SqlCommand("PassAtributosUsuarioInfo", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd.Parameters.Add(New SqlParameter("@IdUsuario", Id))
        cmd.Parameters.Add(New SqlParameter("@IdAtributo", Campo))
        Try
            dt.Load(cmd.ExecuteReader())
        Catch ex As Exception

            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
        Finally
            conexion.Close()
        End Try

        Return If(dt.Rows.Count = 0, False, CType(dt.Rows(0)("Acceso"), Boolean))

    End Function

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If pnlParent IsNot Nothing Then
            Me.StatusBarBottom.Visible = True
            RaiseEvent EnviarEvento()
            pnlParent.Visible = True
        End If

    End Sub




#End Region




    'private void button15_Click(object sender, EventArgs e)
    '{
    '    if (progressWorker.IsBusy)
    '    {
    '        progressWorker.CancelAsync();
    '    }
    '    else // start
    '    {
    '        progressWorker.RunAsync();
    '    }
    '}
End Class


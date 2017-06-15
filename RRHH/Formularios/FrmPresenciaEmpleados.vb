Public Class FrmPresenciaEmpleados

    Private loadGrid As Boolean
    Private modificar As Boolean
    Private configuracion As ReadConfigPresencias
    Private idUsuario As String

    Private Sub FrmPresenciaEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadGrid = True
        modificar = True
        idUsuario = "19936726-9"
        Dim dt As DataTable = SelectDataTable("select empresa from [SAC_Mindugar].[dbo].[DepartamentosPorEmpresa] group by Empresa")
        PopulateDataTable(cmbEmpresas, dt)
        dt = SelectDataTable("EXEC [SAC_Mindugar].[dbo].[PresenciaEmpleado_Departamentos]")
        PopulateDataTable(cmbDepartamentos, dt)
        dt = SelectDataTable("EXEC [SAC_Mindugar].[dbo].[PresenciaEmpleado_CargosPorDepartamento]")
        PopulateDataTable(cmbCargos, dt)
        Me.WindowState = FormWindowState.Maximized
        CargarConfiguracion()
        AsociarGridView()
    End Sub

    Private Sub cmbEmpresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresas.SelectedIndexChanged
        Dim dt As DataTable
        Dim query As String = "EXEC [SAC_Mindugar].[dbo].[PresenciaEmpleado_Departamentos] "
        If cmbEmpresas.SelectedItem <> "" Then
            query += "@empresa = N'" + cmbEmpresas.SelectedItem + "'"
        End If
        dt = SelectDataTable(query)
        PopulateDataTable(cmbDepartamentos, dt)
        cmbDepartamentos.SelectedIndex = 0
    End Sub

    Private Sub cmbDepartamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamentos.SelectedIndexChanged
        Dim dt As DataTable
        Dim query As String = "EXEC [SAC_Mindugar].[dbo].[PresenciaEmpleado_CargosPorDepartamento] "
        If cmbDepartamentos.SelectedItem <> "" Then
            query += "@departamento = N'" + cmbDepartamentos.SelectedItem + "'"
            If cmbEmpresas.SelectedItem <> "" Then
                query += ",@empresa = N'" + cmbEmpresas.SelectedItem + "'"
            End If
        Else
            If cmbEmpresas.SelectedItem <> "" Then
                query += "@empresa = N'" + cmbEmpresas.SelectedItem + "'"
            End If
        End If
        dt = SelectDataTable(query)
        PopulateDataTable(cmbCargos, dt)
        cmbCargos.SelectedIndex = 0
    End Sub

    Private Sub cmbCargos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCargos.SelectedIndexChanged
        modificarConfiguracion()
        AsociarGridView()
    End Sub

    Private Sub AsociarGridView()
        If loadGrid Then
            Dim primer As Boolean = True
            Dim where As String = ""
            If cmbEmpresas.SelectedItem <> "" Then
                If primer Then
                    where = "@where = N'"
                    primer = False
                End If
                where += "AND empresa = ''" + cmbEmpresas.SelectedItem + "'' "
            End If
            If cmbDepartamentos.SelectedItem <> "" Then
                If primer Then
                    where = "@where = N'"
                    primer = False
                End If
                where += "AND departamento = ''" + cmbDepartamentos.SelectedItem + "'' "
            End If
            If cmbCargos.SelectedItem <> "" Then
                If primer Then
                    where = "@where = N'"
                    primer = False
                End If
                where += "AND cargo = ''" + cmbCargos.SelectedItem + "'' "
            End If
            If chkAusentes.Checked Then
                If primer Then
                    where = "@where = N'"
                    primer = False
                End If
                where += "AND CAST(GETDATE() AS DATE) != CAST(MP_MOV AS DATE) AND I_CI IS NULL "
            End If
            If Not primer Then
                where += "'"
            End If
            Dim dt As DataTable
            dt = SelectDataTable("Exec [SAC_Mindugar].[dbo].[PresenciaEmpleado_Buscar_Presencias] " + where)
            dgvPresencias.DataSource = dt
            ResizeGrid()
        End If
    End Sub

    Private Sub chkAusentes_CheckedChanged(sender As Object, e As EventArgs) Handles chkAusentes.CheckedChanged
        modificarConfiguracion()
        AsociarGridView()
    End Sub

    Private Sub CargarConfiguracion()
        configuracion = New ReadConfigPresencias(Me.idUsuario)
        Dim comboArray(3) As String
        Dim checked As Boolean
        configuracion.BuscarConfigUsuario(comboArray, checked)
        loadGrid = False
        modificar = False
        If comboArray(0) <> "0" Then
            cmbEmpresas.SelectedItem = comboArray(0)
        Else
            cmbEmpresas.SelectedIndex = 0
        End If
        If comboArray(1) <> "0" Then
            cmbDepartamentos.SelectedItem = comboArray(1)
        Else
            cmbDepartamentos.SelectedIndex = 0
        End If
        If comboArray(2) <> "0" Then
            cmbCargos.SelectedItem = comboArray(2)
        Else
            cmbCargos.SelectedIndex = 0
        End If
        If checked Then
            chkAusentes.Checked = True
        End If
        loadGrid = True
        modificar = True
    End Sub
    Private Sub modificarConfiguracion()
        If modificar Then
            Try
                configuracion.ModificarConfigUsuario(cmbEmpresas.SelectedItem, cmbDepartamentos.SelectedItem, cmbCargos.SelectedItem, chkAusentes.Checked)
            Catch ex As Exception
                MessageBox.Show("Error al modificar configuracion")
            End Try
        End If
    End Sub



    Private Sub btnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click
        If dgvPresencias.Rows.Count > 0 Then
            dgvPresencias.ExportToExcel
        End If
    End Sub

    Private Sub btnExportarExcel_MouseEnter(sender As Object, e As EventArgs) Handles btnExportarExcel.MouseEnter
        btnExportarExcel.Location = New Point(btnExportarExcel.Location.X - 5, btnExportarExcel.Location.Y - 5)
        btnExportarExcel.Size = New Size(btnExportarExcel.Width + 10, btnExportarExcel.Height + 10)
    End Sub

    Private Sub btnExportarExcel_MouseLeave(sender As Object, e As EventArgs) Handles btnExportarExcel.MouseLeave
        btnExportarExcel.Location = New Point(btnExportarExcel.Location.X + 5, btnExportarExcel.Location.Y + 5)
        btnExportarExcel.Size = New Size(btnExportarExcel.Width - 10, btnExportarExcel.Height - 10)
    End Sub

    Private Sub ResizeGrid()
        'MessageBox.Show("count: " + dgvPresencias.ColumnCount.ToString)
        dgvPresencias.AutoResizeColumns()
        Dim width As Integer = 20
        For index = 0 To dgvPresencias.ColumnCount - 1
            width += dgvPresencias.Columns(index).Width
        Next
        dgvPresencias.Size = New Size(width, dgvPresencias.Height)

        While Screen.PrimaryScreen.Bounds.Width < dgvPresencias.Width + dgvPresencias.Location.X
            Dim oldFont = dgvPresencias.DefaultCellStyle.Font
            dgvPresencias.DefaultCellStyle.Font = New Font(New FontFamily(oldFont.Name), oldFont.Size - 1)
            dgvPresencias.ColumnHeadersDefaultCellStyle.Font = New Font(New FontFamily(oldFont.Name), oldFont.Size - 1)
            dgvPresencias.AutoResizeColumns()
            width = 20
            For index = 0 To dgvPresencias.ColumnCount - 1
                width += dgvPresencias.Columns(index).Width
            Next
            dgvPresencias.Size = New Size(width, dgvPresencias.Height)
        End While





        'Using graphics As System.Drawing.Graphics = Me.CreateGraphics
        '    Dim size As SizeF = graphics.MeasureString("Hello there", New Font("Segoe UI", 11, FontStyle.Regular, GraphicsUnit.Point))
        'End Using


    End Sub


End Class
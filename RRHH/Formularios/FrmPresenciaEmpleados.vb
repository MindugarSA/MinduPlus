Public Class FrmPresenciaEmpleados

    Private loadGrid As Boolean

    Private Sub FrmPresenciaEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadGrid = True
        Dim dt As DataTable = SelectDataTable("select empresa from [SAC_Mindugar].[dbo].[DepartamentosPorEmpresa] group by Empresa")
        PopulateDataTable(cmbEmpresas, dt)
        dt = SelectDataTable("EXEC [SAC_Mindugar].[dbo].[PresenciaEmpleado_Departamentos]")
        PopulateDataTable(cmbDepartamentos, dt)
        dt = SelectDataTable("EXEC [SAC_Mindugar].[dbo].[PresenciaEmpleado_CargosPorDepartamento]")
        PopulateDataTable(cmbCargos, dt)

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
        End If
    End Sub

    Private Sub chkAusentes_CheckedChanged(sender As Object, e As EventArgs) Handles chkAusentes.CheckedChanged
        AsociarGridView()
    End Sub
End Class
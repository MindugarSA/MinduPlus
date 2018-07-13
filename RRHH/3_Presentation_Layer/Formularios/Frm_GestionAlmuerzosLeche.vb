Public Class Frm_GestionAlmuerzosLeche

    Public Property dtEmpleados As DataTable
    Public Property dtTipos As DataTable
    Public Property dtModos As DataTable

    Private Sub Frm_GestionAlmuerzosLeche_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Frm_GestionAlmuerzosLeche_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Me.SuspendLayout()

        dtEmpleados = MindugarConexion.SelectDataTable("EXEC [SAC_Mindugar].[dbo].[Colaciones_Empleados_Tipos_Listar]")

        CargarDTCombosGrid()
        CargarGridEmpleados()
        CargarComboEmpresas()

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


        lblCantidad.Text = "Cantidad : " + MetroGrid1.Rows.Count.ToString()

    End Sub

    Private Sub FormatearGridEmpleados()

    End Sub

    Private Sub CargarComboEmpresas()

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

    Private Sub MetroTile1_MouseEnter(sender As Object, e As EventArgs)
        sender.Left = sender.Left - 4
        sender.Top = sender.Top - 4
        sender.Height = sender.Height + 8
        sender.Width = sender.Width + 8
    End Sub

    Private Sub MetroTile1_MouseLeave(sender As Object, e As EventArgs)
        sender.Left = sender.Left + 4
        sender.Top = sender.Top + 4
        sender.Height = sender.Height - 8
        sender.Width = sender.Width - 8
    End Sub

    Private Sub MetroGrid1_SelectionChanged(sender As Object, e As EventArgs) Handles MetroGrid1.SelectionChanged

        Try
            If (MetroGrid1.CurrentCell.RowIndex > -1) Then
                TxtEmpleado.Text = MetroGrid1.Rows(MetroGrid1.CurrentCell.RowIndex).Cells(0).Value.ToString().Trim + " - " +
                               MetroGrid1.Rows(MetroGrid1.CurrentCell.RowIndex).Cells(1).Value.ToString().Trim + ", " +
                               MetroGrid1.Rows(MetroGrid1.CurrentCell.RowIndex).Cells(2).Value.ToString().Trim

                CargarInfoEmpleado()
            End If
        Catch

        End Try


    End Sub

    Private Sub CargarInfoEmpleado()

        Dim Tipo As String = MetroGrid1.Rows(MetroGrid1.CurrentCell.RowIndex).Cells(3).Value.ToString().Trim
        Dim Modo As String = MetroGrid1.Rows(MetroGrid1.CurrentCell.RowIndex).Cells(4).Value.ToString().Trim

        Select Case Tipo
            Case "A"
                lblTipo.Text = "Tipo : ALMUERZO"
                If (Modo = "LV") Then
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

End Class
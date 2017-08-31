Imports System.Data
Imports System.Data.SqlClient
Public Class Frm_Parametros
    Dim vDateInfo As DateTime
    Dim dt As New DataTable
    Dim conexion As New SqlConnection
    Dim cmd As SqlCommand
    Dim SelLin As Integer

    Private Sub Frm_Parametros_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.ConnectionString = Conection.Cn


        'TODO: esta línea de código carga datos en la tabla 'SAC_MindugarDataSet.Colaciones_Parametros' Puede moverla o quitarla según sea necesario.
        Me.Colaciones_ParametrosTableAdapter.Fill(Me.SAC_MindugarDataSet.Colaciones_Parametros)
        'TODO: esta línea de código carga datos en la tabla 'SAC_MindugarDataSet.Permisos' Puede moverla o quitarla según sea necesario.
        Me.PermisosTableAdapter.Fill(Me.SAC_MindugarDataSet.Permisos)
        Me.Height = 500
        Me.Width = 900
        MDIParent1.Panel2.Visible = False
        Pnl_Permisos.Visible = False
        'TODO: esta línea de código carga datos en la tabla 'SBO_COMERCIALDataSet1.__Min_Colaciones_Parametros' Puede moverla o quitarla según sea necesario.
        'Me._Min_Colaciones_ParametrosTableAdapter.Fill(Me.SBO_COMERCIALDataSet1.__Min_Colaciones_Parametros)
        'TODO: esta línea de código carga datos en la tabla 'SBO_COMERCIALDataSet.__Min_Colaciones_Pass' Puede moverla o quitarla según sea necesario.
        'Me._Min_Colaciones_ParametrosTableAdapter.Fill(Me.SBO_COMERCIALDataSet.__Min_Colaciones_Pass)

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Pnl_Permisos.Visible = False
        Pnl_ValoresCol.Visible = False

        If UCase(TreeView1.SelectedNode.Name) = UCase("Nd_Permisos") Then
            Lbl_Titulo.Text = "Mantención de permisos"
            Pnl_Permisos.Dock = DockStyle.Fill
            Pnl_Permisos.Visible = True
            DtGridVw_Permisos.CurrentCell = DtGridVw_Permisos.Rows(0).Cells(0)
            ActualizaDatos(DtGridVw_Permisos.CurrentRow.Index)
        End If
        If UCase(TreeView1.SelectedNode.Name) = UCase("Nd_ValCol") Then
            Lbl_Titulo.Text = "Mantención de permisos"
            Pnl_ValoresCol.Dock = DockStyle.Fill
            Pnl_ValoresCol.Visible = True
            DtGridVw_ValoresCol.CurrentCell = DtGridVw_Permisos.Rows(0).Cells(0)
            ActualizaDatos(DtGridVw_ValoresCol.CurrentRow.Index)
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtGridVw_Permisos.CellClick, DtGridVw_ValoresCol.CellClick
        ActualizaDatos(e.RowIndex)
    End Sub
    Private Sub Bttn_Nuevo_Click(sender As Object, e As EventArgs) Handles Bttn_Nuevo.Click
        If UCase(TreeView1.SelectedNode.Name) = UCase("Nd_ValCol") Then
            TxtBx_Id.Text = "0"
            DtTm_FechaCol.Text = DateTime.Now
            TxtBx_ValorCol.Text = "0"
            TxtBx_ValorDec.Text = "0"
        End If
    End Sub

    Private Sub ActualizaDatos(Linea As Integer)

        If UCase(TreeView1.SelectedNode.Name) = UCase("Nd_Permisos") Then
            If DtGridVw_Permisos.CurrentRow.Cells(3).Value Is DBNull.Value Then ChckBx_Parametros.Checked = "False" Else ChckBx_Parametros.Checked = DtGridVw_Permisos.CurrentRow.Cells(3).Value
            If DtGridVw_Permisos.CurrentRow.Cells(4).Value Is DBNull.Value Then ChckBx_SolicitudAlm.Checked = "False" Else ChckBx_SolicitudAlm.Checked = DtGridVw_Permisos.CurrentRow.Cells(4).Value
            If DtGridVw_Permisos.CurrentRow.Cells(5).Value Is DBNull.Value Then ChckBx_MantAlmuerzos.Checked = "False" Else ChckBx_MantAlmuerzos.Checked = DtGridVw_Permisos.CurrentRow.Cells(5).Value
            If DtGridVw_Permisos.CurrentRow.Cells(6).Value Is DBNull.Value Then ChckBx_ImpLiquidaciones.Checked = "False" Else ChckBx_ImpLiquidaciones.Checked = DtGridVw_Permisos.CurrentRow.Cells(6).Value
        End If
        If UCase(TreeView1.SelectedNode.Name) = UCase("Nd_ValCol") Then
            If DtGridVw_ValoresCol.CurrentRow.Cells(0).Value Is DBNull.Value Then DtTm_FechaCol.Text = DateTime.Now Else TxtBx_Id.Text = (DtGridVw_ValoresCol.CurrentRow.Cells(0).Value)
            If DtGridVw_ValoresCol.CurrentRow.Cells(1).Value Is DBNull.Value Then DtTm_FechaCol.Text = DateTime.Now Else DtTm_FechaCol.Text = (DtGridVw_ValoresCol.CurrentRow.Cells(1).Value)
            If DtGridVw_ValoresCol.CurrentRow.Cells(2).Value Is DBNull.Value Then TxtBx_ValorCol.Text = "0" Else TxtBx_ValorCol.Text = DtGridVw_ValoresCol.CurrentRow.Cells(2).Value
            If DtGridVw_ValoresCol.CurrentRow.Cells(3).Value Is DBNull.Value Then TxtBx_ValorDec.Text = "0" Else TxtBx_ValorDec.Text = DtGridVw_ValoresCol.CurrentRow.Cells(3).Value
        End If
    End Sub

    Private Sub Bttn_Graba_Click(sender As Object, e As EventArgs) Handles Bttn_GrabaPermisos.Click, Bttn_Grabar.Click
        If UCase(TreeView1.SelectedNode.Name) = UCase("Nd_Permisos") Then
            DtGridVw_Permisos.Item(3, DtGridVw_Permisos.CurrentRow.Index).Value = ChckBx_Parametros.Checked
            DtGridVw_Permisos.Item(4, DtGridVw_Permisos.CurrentRow.Index).Value = ChckBx_SolicitudAlm.Checked
            DtGridVw_Permisos.Item(5, DtGridVw_Permisos.CurrentRow.Index).Value = ChckBx_MantAlmuerzos.Checked
            DtGridVw_Permisos.Item(6, DtGridVw_Permisos.CurrentRow.Index).Value = ChckBx_ImpLiquidaciones.Checked
            cmd = New SqlCommand("Colaciones_Pass_Ges", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            conexion.Open()
            cmd.Parameters.Add(New SqlParameter("@Rut", DtGridVw_Permisos.Item(0, DtGridVw_Permisos.CurrentRow.Index).Value))
            cmd.Parameters.Add(New SqlParameter("@Mant_Param", DtGridVw_Permisos.Item(3, DtGridVw_Permisos.CurrentRow.Index).Value))
            cmd.Parameters.Add(New SqlParameter("@Sol_Alm", DtGridVw_Permisos.Item(4, DtGridVw_Permisos.CurrentRow.Index).Value))
            cmd.Parameters.Add(New SqlParameter("@Mant_Alm", DtGridVw_Permisos.Item(5, DtGridVw_Permisos.CurrentRow.Index).Value))
            cmd.Parameters.Add(New SqlParameter("@Imp_Liqui", DtGridVw_Permisos.Item(6, DtGridVw_Permisos.CurrentRow.Index).Value))
            cmd.Parameters.Add(New SqlParameter("@User", MDIParent1.Lbl_RutTrab.Text))
            Try
                dt.Load(cmd.ExecuteReader())

            Catch ex As Exception
                MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
            Finally


                If dt.Rows(0)("IdEstado").ToString = 0 Then
                    MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.White
                    MDIParent1.TlStrpSttsLbl_SQL.ForeColor = Color.Black
                    MDIParent1.TlStrpSttsLbl_SQL.Text = dt.Rows(0)("EstadoUsr").ToString
                Else
                    MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.Red
                    MDIParent1.TlStrpSttsLbl_SQL.ForeColor = Color.White
                    MDIParent1.TlStrpSttsLbl_SQL.Text = dt.Rows(0)("EstadoUsr").ToString
                End If

                conexion.Close()
            End Try
            'Me._Min_Colaciones_PassTableAdapter.Fill(Me.SBO_COMERCIALDataSet.__Min_Colaciones_Pass)
            DtGridVw_Permisos.Refresh()
        End If
        If UCase(TreeView1.SelectedNode.Name) = UCase("Nd_ValCol") Then
            cmd = New SqlCommand("Colaciones_Parametros_Ges", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            conexion.Open()
            cmd.Parameters.Add(New SqlParameter("@Id", TxtBx_Id.Text))
            cmd.Parameters.Add(New SqlParameter("@Clave", "Valor_Alm"))
            cmd.Parameters.Add(New SqlParameter("@FechaCol", (Convert.ToDateTime(DtTm_FechaCol.Text)).ToString("yyyyMMdd")))
            cmd.Parameters.Add(New SqlParameter("@ValorCol", TxtBx_ValorCol.Text))
            cmd.Parameters.Add(New SqlParameter("@ValorDec", TxtBx_ValorDec.Text))
            cmd.Parameters.Add(New SqlParameter("@IdUsrActualizacion", MDIParent1.Lbl_RutTrab.Text))
            Try
                dt.Load(cmd.ExecuteReader())

            Catch ex As Exception
                MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
            Finally
                conexion.Close()
            End Try
            'Me._Min_Colaciones_ParametrosTableAdapter.Fill(Me.SBO_COMERCIALDataSet1.__Min_Colaciones_Parametros)
        End If

    End Sub

    Private Sub Bttn_Volver_Click(sender As Object, e As EventArgs) Handles Bttn_Volver.Click, Button3.Click, Button2.Click
        MDIParent1.Panel2.Visible = True
        MDIParent1.TiempoIngreso.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MDIParent1.Panel2.Visible = True
        MDIParent1.TiempoIngreso.Enabled = True
        Me.Close()
    End Sub
    Private Sub Bttn_Grabar_Click(sender As Object, e As EventArgs) 
        'Pendiente
    End Sub

    Private Sub TextNumerico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBx_ValorCol.KeyPress, TxtBx_ValorDec.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub

    Private Sub SACMindugarDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles SACMindugarDataSetBindingSource.CurrentChanged

    End Sub

    Private Sub ColacionesParametrosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ColacionesParametrosBindingSource.CurrentChanged

    End Sub
End Class
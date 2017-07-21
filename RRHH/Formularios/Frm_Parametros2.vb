Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_Parametros2
    Dim vDateInfo As DateTime
    Dim dt As New DataTable
    Dim conexion As New SqlConnection
    Dim cmd As SqlCommand
    Dim SelLin As Integer
    Private Sub Frm_Parametros2_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.ConnectionString = Conection.Cn
        Dim ctl As Control
        For Each ctl In Me.Controls
            AddHandler ctl.KeyDown, AddressOf myEventHandler
        Next
        'Me.WindowState = FormWindowState.Maximized
        CargaUsuarios(1)
        LLenaDatosUsuario()

    End Sub

    Private Sub myEventHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub
    Private Sub TreeView1_Click(sender As Object, e As EventArgs) Handles TreeView1.Click
        If UCase(TreeView1.SelectedNode.Name) = UCase("Nd_Permisos") Then
            Lbl_Titulo.Text = "Mantención de permisos"
            LLenaDatosUsuario
        End If
    End Sub

    Private Sub CargaUsuarios(Sistema As Integer)
        cmd = New SqlCommand("PassUsuariosInfo", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd.Parameters.Add(New SqlParameter("@Id_Entidades", Sistema))
        Dim dtUser As New DataTable
        Try
            dt.Load(cmd.ExecuteReader())
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
        Finally
            conexion.Close()
            Dim adaptador As New SqlDataAdapter(cmd)
            adaptador.Fill(dtUser)
            If dtUser.Rows(0)("IdEstado") = 0 Then
                With CmbBx_Usuarios
                    .DataSource = dtUser
                    .DisplayMember = "Usuario"
                    .ValueMember = "IdUsuario"
                    .SelectedIndex = 0
                End With
            End If
        End Try
    End Sub
    Private Sub LLenaDatosUsuario()
        DtGrdVw_PermisosNo.Rows.Clear()
        DtGrdVw_PermisosSi.Rows.Clear()
        cmd = New SqlCommand("PassUsuariosInfo", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd.Parameters.Add(New SqlParameter("@IdUsuario", CmbBx_Usuarios.SelectedValue))
        Dim dtUser As New DataTable
        Try
            dtUser.Load(cmd.ExecuteReader())
            TxtBx_Empleado.Text = dtUser.Rows(0)("Nombre").ToString()
            TxtBx_FechaMod.Text = dtUser.Rows(0)("FecModif").ToString()


        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error!")
        Finally
            conexion.Close()
        End Try




        Dim cmd1 As SqlCommand
        cmd1 = New SqlCommand("PassAtributosUsuarioAutorizadoNoInfo", conexion)
        cmd1.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd1.Parameters.Add(New SqlParameter("@IdUsuario", CmbBx_Usuarios.SelectedValue))
        cmd1.Parameters.Add(New SqlParameter("@IdEntidad", 1))
        Dim adapter As New SqlDataAdapter(cmd1)
        Dim table1 As DataTable = New DataTable()

        adapter.Fill(table1)

        If table1.Rows(0)("IdEstado") = 0 Then

            For i = 0 To table1.Rows.Count - 1
                DtGrdVw_PermisosNo.Rows.Add(1)
                DtGrdVw_PermisosNo.Rows(i).Cells("SelNo").Value = "False"
                DtGrdVw_PermisosNo.Rows(i).Cells("IdAtributoNo").Value = table1.Rows(i)("IdAtributo")
                DtGrdVw_PermisosNo.Rows(i).Cells("AtributoNo").Value = table1.Rows(i)("Atributo")

            Next
        Else
            DtGrdVw_PermisosNo.Rows.Clear()
        End If
        conexion.Close()
        adapter.Dispose()
        cmd = New SqlCommand("PassAtributosUsuarioAutorizadoSiInfo", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd.Parameters.Add(New SqlParameter("@IdUsuario", CmbBx_Usuarios.SelectedValue))
        adapter = New SqlDataAdapter(cmd)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        If table.Rows(0)("IdEstado") = 0 Then
            For i = 0 To table.Rows.Count - 1
                DtGrdVw_PermisosSi.Rows.Add(1)
                DtGrdVw_PermisosSi.Rows(i).Cells("SelSi").Value = "False"
                DtGrdVw_PermisosSi.Rows(i).Cells("IdAtributoSi").Value = table.Rows(i)("IdAtributo")
                DtGrdVw_PermisosSi.Rows(i).Cells("AtributoSi").Value = table.Rows(i)("Atributo")
            Next
        Else
            DtGrdVw_PermisosSi.Rows.Clear()
        End If

        conexion.Close()
        adapter.Dispose()

    End Sub

    Private Sub Bttn_Actualiza_Click(sender As Object, e As EventArgs) Handles Bttn_Actualiza.Click
        Dim vlstId As String = ObtenerActivosGvPermPend()
        Dim dt As New DataTable
        If vlstId.Length > 0 Then
            cmd = New SqlCommand("PassAtributosUsuarioAgregaGes", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            conexion.Open()
            cmd.Parameters.Add(New SqlParameter("@IdUsuario", CmbBx_Usuarios.SelectedValue))
            cmd.Parameters.Add(New SqlParameter("@IdAtributo", vlstId))
            Try
                dt.Load(cmd.ExecuteReader())
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error!")
            Finally
                conexion.Close()
            End Try
        End If
        'Borra los Marcados
        vlstId = ObtenerActivosGvPermDados()
        If vlstId.Length > 0 Then
            cmd = New SqlCommand("PassAtributosUsuarioDeleteGes", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            conexion.Open()
            cmd.Parameters.Add(New SqlParameter("@IdUsuario", CmbBx_Usuarios.SelectedValue))
            cmd.Parameters.Add(New SqlParameter("@IdAtributo", vlstId))
            Try
                dt.Load(cmd.ExecuteReader())
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error!")
            Finally
                conexion.Close()
            End Try
        End If
        LLenaDatosUsuario()

    End Sub

    Function ObtenerActivosGvPermPend() As String
        'Obtiene identificadores de elementos marcados con ticket activo en GridView
        Dim vActivos As String = ""
        For i = 0 To DtGrdVw_PermisosNo.RowCount - 1
            If DtGrdVw_PermisosNo.Rows(i).Cells("SelNo").Value = True Then
                vActivos = vActivos & ", " & DtGrdVw_PermisosNo.Rows(i).Cells("IdAtributoNo").Value
            End If
        Next


        If vActivos.Length > 0 Then vActivos = Mid(vActivos, 3) + ","

        ObtenerActivosGvPermPend = vActivos
    End Function


    Function ObtenerActivosGvPermDados() As String
        Dim vActivos As String = ""
        For i = 0 To DtGrdVw_PermisosSi.RowCount - 1
            If DtGrdVw_PermisosSi.Rows(i).Cells("SelSi").Value = True Then
                vActivos = vActivos & ", " & DtGrdVw_PermisosSi.Rows(i).Cells("IdAtributoSi").Value
            End If
        Next
        If vActivos.Length > 0 Then vActivos = Mid(vActivos, 3) + ","
        ObtenerActivosGvPermDados = vActivos
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MDIParent1.Visualizar_Tiles_MDI()
        MDIParent1.Desplazamiento_Tiles()
        MDIParent1.TiempoIngreso.Enabled = True
        Me.Close()
    End Sub

    Private Sub CmbBx_Usuarios_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbBx_Usuarios.SelectionChangeCommitted
        LLenaDatosUsuario()
    End Sub


End Class
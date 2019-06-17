Imports System.Data.SqlClient

Public Class Frm_EliminarHoraExtra
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        CargarNumeroSolicitudes()
        If cmbSolicitud.Items.Count > 0 Then
            CargarSolicitud()
            CargarColaboradores()
        End If
    End Sub



    Private Sub CargarNumeroSolicitudes()
        LimparDatos()
        Using conexion As New SqlConnection(My.Settings.SBO_COMERCIALConnectionString)
            Dim comand As SqlCommand = New SqlCommand("Solicitud_Buscar_HoraExtra_Eliminar", conexion)
            comand.Connection = conexion
            comand.CommandType = CommandType.StoredProcedure
            Dim adapter As New SqlDataAdapter(comand)
            Dim table As DataTable = New DataTable()
            Try
                adapter.Fill(table)
                Dim lista As New List(Of [String])()
                For i = 0 To table.Rows.Count - 1
                    lista.Add(table.Rows(i)("id_solicitud_horas_extra").ToString)
                Next
                cmbSolicitud.DataSource = lista
            Catch ex As Exception
                MsgBox("Error al operar con la base de datos: " + ex.Message, MsgBoxStyle.Critical, "Error!")
            Finally
                conexion.Close()
            End Try


        End Using
    End Sub
    ''Ok
    Private Sub LimparDatos()
        txbFechaSolicitud.Text = ""
        txbDetalle.Text = ""
        cmbSolicitud.Text = ""
        txbSolicitante.Text = ""
        dgvColaboradores.DataSource = Nothing
        dgvColaboradores.Rows.Clear()
    End Sub
    'ok
    Private Sub CargarSolicitud()
        'En caso que la conexion este abierta es necesaria cerrarla
        Using conexion As New SqlConnection(My.Settings.SBO_COMERCIALConnectionString)
            Dim comand As SqlCommand = New SqlCommand()
            comand.Connection = conexion
            conexion.Open()
            comand.CommandText = "SELECT supervisor_solicitante, rut_solicitante, Convert(Date,fecha) as fecha, detalle FROM [SAC_Mindugar].[dbo].[Solicitud_HorasExtras] WHERE id_solicitud_horas_extra = " + cmbSolicitud.Text
            Dim adapter As New SqlDataAdapter(comand)
            Dim table As DataTable = New DataTable()
            Try
                adapter.Fill(table)
                txbDetalle.Text = table.Rows(0)("detalle")
                txbSolicitante.Text = table.Rows(0)("supervisor_solicitante")
                txbFechaSolicitud.Text = table.Rows(0)("fecha")
            Catch ex As Exception
                MsgBox("Error al operar con la base de datos: " + ex.Message, MsgBoxStyle.Critical, "Error!")
            Finally
                conexion.Close()
            End Try
        End Using
    End Sub
    'ok
    Private Sub CargarColaboradores()
        'En caso que la conexion este abierta es necesaria cerrarla
        Using conexion As New SqlConnection(My.Settings.SBO_COMERCIALConnectionString)

            LimparDataGridView()

            conexion.Open()
            Dim comand As SqlCommand = New SqlCommand()
            comand.Connection = conexion
            comand.CommandText = "SELECT id_solicitud_horas_extra as 'N°' , nombre_completo as Nombre, rut as Rut, horas_compromiso_inicio 'Hora Inicio', total_horas_compromiso as 'Total Horas', fecha_real as Fecha, empresa as Empresa, cargo as Cargo FROM [SAC_Mindugar].[dbo].[Solicitud_HorasExtras_Colaboradores] WHERE id_solicitud_horas_extra = " + cmbSolicitud.Text

            Dim adapter As New SqlDataAdapter(comand)
            Dim table As DataTable = New DataTable()
            Try
                adapter.Fill(table)
                dgvColaboradores.DataSource = table
                ResizeGrid()
            Catch ex As Exception
                MsgBox("Error al operar con la base de datos: " + ex.Message, MsgBoxStyle.Critical, "Error!")
            End Try
        End Using
    End Sub
    ''OK
    Private Sub LimparDataGridView()
        dgvColaboradores.DataSource = Nothing
        dgvColaboradores.Rows.Clear()
    End Sub

    Private Sub cmbSolicitud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSolicitud.SelectedIndexChanged
        CargarSolicitud()
        CargarColaboradores()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Using conexion As New SqlConnection(My.Settings.SBO_COMERCIALConnectionString)
            Dim comand As SqlCommand = New SqlCommand("Solicitud_Eliminar_HoraExtra", conexion)
            comand.Connection = conexion
            comand.CommandType = CommandType.StoredProcedure
            conexion.Open()
            comand.Parameters.Add(New SqlParameter("@id", Convert.ToInt32(cmbSolicitud.Text)))
            Dim returnParameter = comand.Parameters.Add("@ReturnVal", SqlDbType.Int)
            returnParameter.Direction = ParameterDirection.ReturnValue
            Try
                comand.ExecuteReader()
                If returnParameter.Value = 0 Then
                    MsgBox("El registro de Hora Extra fue eliminado", MsgBoxStyle.Information, "Registro Eliminado")
                ElseIf returnParameter.Value = -1 Then
                    MsgBox("El registro de Hora Extra fue aprobado o rechazado y por lo tanto no puede ser eliminado", MsgBoxStyle.Critical, "No Permitido!")
                ElseIf returnParameter.Value = -2 Then
                    MsgBox("Ocurrio un error al momento de eliminar el registro de Hora Extra", MsgBoxStyle.Critical, "Error!")
                End If

            Catch ex As Exception
                MsgBox("Error al operar con la base de datos: " + ex.Message, MsgBoxStyle.Critical, "Error!")
            Finally
                conexion.Close()
            End Try
        End Using
        CargarNumeroSolicitudes()
        If cmbSolicitud.Items.Count > 0 Then
            CargarSolicitud()
            CargarColaboradores()
        End If
    End Sub

    Public Sub ResizeGrid()
        dgvColaboradores.AutoResizeColumns()
        Dim width As Integer = 20
        For index = 0 To dgvColaboradores.ColumnCount - 1
            width += dgvColaboradores.Columns(index).Width
        Next
        dgvColaboradores.Size = New Size(width, dgvColaboradores.Height)
    End Sub

    Private Sub Frm_EliminarHoraExtra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
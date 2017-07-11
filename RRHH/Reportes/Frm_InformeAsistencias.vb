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

            CargarComboPeriodos(MetroComboBox1)
            CargarComboPeriodos(MetroComboBox2)
            AutocompletarNombreRutInformePermisos("")
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

    Private Sub btnImprimirInformePermisos_Click(sender As Object, e As EventArgs) Handles btnImprimirInformePermisos.Click
        Dim informe As New InformePlanillaAsistencia()
        Dim formInforme As New Frm_AsistenciasPeriodo(informe)

        formInforme.Show()
    End Sub

    Private Sub CargarComboPeriodos(cmbPeriodo As MetroFramework.Controls.MetroComboBox)

        conexion.ConnectionString = "Data Source=FSSAPBO;Initial Catalog = SAC_Mindugar; Persist Security Info=True;User ID = sa; Password=Sqladmin281"

        cmd = New SqlCommand("[MINDU_INTERMEDIA].[dbo].[SpASISTENCIA_Periodos_Registrados_Fechas]", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            conexion.Open()

            Dim adaptador As New SqlDataAdapter(cmd)
            Dim dt1 As New DataTable
            adaptador.Fill(dtPeriodos)
            If dtPeriodos.Rows.Count > 0 Then
                With cmbPeriodo
                    .DataSource = dtPeriodos
                    .DisplayMember = "PeriodoC"
                    .ValueMember = "PeriodoI"
                    .SelectedIndex = 0
                End With
            End If


        Catch ex As Exception
        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub AutocompletarNombreRutInformePermisos(empresa As String)
        Dim listaNombre As New AutoCompleteStringCollection()
        Dim listaRut As New AutoCompleteStringCollection()
        Try
            Dim personas As List(Of Persona) = Persona.ListarPorEmpresa(empresa)

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
End Class
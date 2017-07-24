Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Frm_Informes
    Dim dt As New DataTable
    Dim conexion As New SqlConnection
    Dim cmd As SqlCommand


    Private Sub Frm_Informes_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.ConnectionString = Conection.Cn
        CmbBx_Informe.SelectedIndex = 0
        CmbBx_Informe_Orden.SelectedIndex = 0
        CmbBx_Informe_Empresa.SelectedIndex = 0
        CmbBx_Informe_TipColac.SelectedIndex = 0
        'llena periodos " CmbBx_Periodos " desde agosto del 2016 hasta la fecha actual
        Dim FechaIni As Date = Date.Now
        For i = 0 To Microsoft.VisualBasic.DateAndTime.DateDiff(DateInterval.Month, #2016-01-01#, FechaIni) + 1
            CmbBx_Periodos.Items.Add(FechaIni.ToString("yyyy - MM"))
            FechaIni = DateAdd("m", -1, FechaIni)
        Next
        CmbBx_Periodos.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MDIParent1.Visualizar_Tiles_MDI()
        MDIParent1.Desplazamiento_Tiles()
        MDIParent1.TiempoIngreso.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Bttn_GenerarInf.Click
        'Dim FechaIni As String = DtTimPickr_Fecha_Ini.Value.ToString("yyyyMMdd")
        Dim TotLeche As Integer = 0
        Dim TotCol As Integer = 0
        dt.Reset()
        DataGridView1.DataSource = dt
        If CmbBx_Informe.SelectedIndex = 0 Then
            cmd = New SqlCommand("RRHH_Colaciones_Solicitudes_Info", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Try
                conexion.Open()
                If CmbBx_Informe.SelectedIndex = 0 Then
                    cmd.Parameters.Add(New SqlParameter("@TipoInforme", CmbBx_Informe.SelectedIndex))
                    cmd.Parameters.Add(New SqlParameter("@Fecha_SolicitudIni", DtTimPickr_Fecha_Ini.Value.ToString("yyyyMMdd")))
                    cmd.Parameters.Add(New SqlParameter("@Fecha_SolicitudFin", DtTimPickr_Fecha_Ini.Value.ToString("yyyyMMdd")))
                    If CmbBx_Informe_Orden.SelectedIndex = 0 Then
                        cmd.Parameters.Add(New SqlParameter("@Orden", "Per.rut"))
                    ElseIf CmbBx_Informe_Orden.SelectedIndex = 1 Then
                        cmd.Parameters.Add(New SqlParameter("@Orden", "LTRIM(Per.nombre),RTRIM(Per.apellido)"))
                    ElseIf CmbBx_Informe_Orden.SelectedIndex = 2 Then
                        cmd.Parameters.Add(New SqlParameter("@Orden", "RTRIM(Per.apellido),LTRIM(Per.nombre)"))
                    End If

                    If CmbBx_Informe_Empresa.SelectedIndex >= 1 Then
                        Dim Paso As String = Mid(CmbBx_Informe_Empresa.Text, 1, 11)
                        cmd.Parameters.Add(New SqlParameter("@Id_RutEmpresa", Paso))
                    End If
                    If CmbBx_Informe_TipColac.SelectedIndex >= 1 Then
                        cmd.Parameters.Add(New SqlParameter("@TipColac", CmbBx_Informe_TipColac.SelectedIndex))
                    End If


                    Dim adaptador As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    adaptador.Fill(dt)

                    DataGridView1.DataSource = dt
                    If dt.Rows(0)("IdEstado") = 0 Then
                        'dt.Load(cmd.ExecuteReader())
                        'DataGridView1.DataSource = dt
                        DataGridView1.RowHeadersWidth = 25
                        DataGridView1.Columns("IDEstado").Visible = False
                        DataGridView1.Columns("EstadoUsr").Visible = False
                        DataGridView1.Columns("EstadoTec").Visible = False
                        DataGridView1.Columns("Cat_Col").Visible = False
                        DataGridView1.Columns("Cat_LP").Visible = False
                        DataGridView1.Columns("RutEmp11").Width = 80
                        DataGridView1.Columns("Rut").Width = 80
                        'DataGridView1.Columns("Codigo").Width = 50
                        'DataGridView1.Columns("Codigo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGridView1.Columns("Nombre").Width = 200
                        'DataGridView1.Columns("Fin").Width = 20
                        DataGridView1.Columns("Fecha").Width = 70
                        DataGridView1.Columns("Almuerzo").Width = 30
                        DataGridView1.Columns("Almuerzo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        'DataGridView1.Columns("Postre").Width = 30
                        'DataGridView1.Columns("Postre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGridView1.Columns("Colación").Width = 270
                        'DataGridView1.Columns("Colación").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGridView1.Columns("Cat_Col").Width = 30
                        DataGridView1.Columns("Cat_LP").Width = 30

                        DataGridView1.Width = DataGridView1.RowHeadersWidth +
                                        DataGridView1.FirstDisplayedScrollingColumnHiddenWidth +
                                        DataGridView1.Columns("RutEmp11").Width +
                                        DataGridView1.Columns("Rut").Width +
                                        DataGridView1.Columns("Nombre").Width +
                                        DataGridView1.Columns("Fecha").Width +
                                        DataGridView1.Columns("Almuerzo").Width +
                                        DataGridView1.Columns("Colación").Width + (11 * 2)
                        'DataGridView1.Columns("Codigo").Width +
                        'DataGridView1.Columns("Fin").Width +
                        'DataGridView1.Columns("Postre").Width +
                        conexion.Close()

                        Dim dt_A As New DataTable
                        Dim cmd_A As SqlCommand
                        Dim Errores As String
                        cmd_A = New SqlCommand("RRHH_Colaciones_SolAdicional_Info", conexion)
                        cmd_A.CommandType = CommandType.StoredProcedure
                        Dim vFechaIni As String = DtTimPickr_Fecha_Ini.Value.ToString("yyyyMMdd")
                        Dim vFechaFin As String = DtTimPickr_Fecha_Fin.Value.ToString("yyyyMMdd")
                        Try

                            conexion.Open()
                            cmd_A.Parameters.Add(New SqlParameter("@Rut", "96588890-K"))
                            cmd_A.Parameters.Add(New SqlParameter("@Fecha_SolicitudIni", vFechaIni)) 'DtTimPickr_Fecha_Ini.Value.ToString("yyyyMMdd")))
                            cmd_A.Parameters.Add(New SqlParameter("@Fecha_SolicitudFin", vFechaIni)) 'DtTimPickr_Fecha_Ini.Value.ToString("yyyyMMdd")))
                            Dim adaptador2 As New SqlDataAdapter(cmd)
                            adaptador2 = New SqlDataAdapter(cmd_A)
                            adaptador2.Fill(dt_A)
                            If dt_A.Rows(0)("IdEstado") = 0 Then
                                TB_Tot_ExtGcial.Text = dt_A.Rows(0)("Gcia")
                                TB_Tot_ExtNorm.Text = dt_A.Rows(0)("Nor")
                            Else
                                TB_Tot_ExtGcial.Text = "0"
                                TB_Tot_ExtNorm.Text = "0"
                            End If



                        Catch ex As Exception
                            Errores = ex.ToString
                        Finally
                            conexion.Close()
                        End Try
                        For i = 0 To DataGridView1.Rows.Count - 1

                            TotLeche = TotLeche + Double.Parse(Me.DataGridView1("Cat_LP", i).Value)
                            TotCol = TotCol + Double.Parse(Me.DataGridView1("Cat_Col", i).Value)
                            TB_Total.Text = TotCol + Val(TB_Tot_ExtGcial.Text) + Val(TB_Tot_ExtNorm.Text)
                        Next
                    ElseIf dt.Rows(0)("IdEstado") < 0 Then
                        MsgBox("Error de SQL")
                    End If

                End If
            Catch ex As Exception
                MsgBox("Error de Conexion")
            Finally
                conexion.Close()
                TxtBx_TotLeche.Text = TotLeche
                TxtBx_TotCol.Text = TotCol
            End Try
        End If




        If CmbBx_Informe.SelectedIndex = 1 Or CmbBx_Informe.SelectedIndex = 2 Then
            cmd = New SqlCommand("RRHH_Colaciones_Solicitudes_TotPeriodo", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Try
                conexion.Open()
                Dim Periodo As String = CmbBx_Periodos.Text
                Dim fechaFin As Date
                Dim fechaIni As Date
                If CmbBx_Informe.SelectedIndex = 2 Then

                    fechaFin = FormatDateTime(CmbBx_Periodos.Text + "-20")
                    fechaIni = DateAdd("d", 1, DateAdd("m", -1, fechaFin))
                Else
                    fechaIni = DtTimPickr_Fecha_Ini.Value
                    fechaFin = DtTimPickr_Fecha_Fin.Value
                End If

                'cmd.Parameters.Add(New SqlParameter("@TipoInforme", CmbBx_Informe.SelectedIndex))
                cmd.Parameters.Add(New SqlParameter("@FechaIni", fechaIni.ToString("yyyyMMdd")))
                cmd.Parameters.Add(New SqlParameter("@FechaFin", fechaFin.ToString("yyyyMMdd")))
                If CmbBx_ResumDetall.SelectedIndex = 0 Then
                    cmd.Parameters.Add(New SqlParameter("@TipoInforme", 0))
                Else
                    cmd.Parameters.Add(New SqlParameter("@TipoInforme", 1))
                End If
                Dim adaptador As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                adaptador.Fill(dt)

                If dt.Rows.Count > 0 Then
                    DataGridView1.DataSource = dt
                    DataGridView1.Columns(1).Frozen = True
                    DataGridView1.Columns(3).Frozen = True
                End If


            Catch ex As Exception
                MsgBox("Error de Conexion")
            Finally
                conexion.Close()
                TxtBx_TotLeche.Text = TotLeche
                TB_Total.Text = TotCol
            End Try
        End If

    End Sub

    'Private Sub DtTimPickr_Fecha_Ini_ValueChanged(sender As Object, e As EventArgs) Handles DtTimPickr_Fecha_Ini.ValueChanged
    '    DtTimPickr_Fecha_Fin.Value = DtTimPickr_Fecha_Ini.Value
    'End Sub

    Private Sub CmbBx_Informe_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbBx_Informe.SelectedValueChanged

        If CmbBx_Informe.SelectedIndex = 0 Then
            CmbBx_Periodos.Visible = False
            CmbBx_ResumDetall.Visible = False
            DtTimPickr_Fecha_Ini.Visible = True
            DtTimPickr_Fecha_Fin.Visible = False
            Label1.Text = "Fecha     : "
            Label5.Visible = True
            TxtBx_TotLeche.Visible = True


            Label7.Visible = True
            CmbBx_Informe_TipColac.Visible = True
            Label2.Visible = True
            CmbBx_Informe_Orden.Visible = True
            Label6.Visible = True
            CmbBx_Informe_Empresa.Visible = True
        ElseIf CmbBx_Informe.SelectedIndex = 1 Then
            CmbBx_Periodos.Visible = False
            CmbBx_ResumDetall.Visible = False
            Label1.Text = "Desde  : "
            DtTimPickr_Fecha_Ini.Visible = True
            DtTimPickr_Fecha_Fin.Visible = True
            Label5.Visible = True

            Label7.Visible = True
            CmbBx_Informe_TipColac.Visible = True
            Label2.Visible = True
            CmbBx_Informe_Orden.Visible = True
            Label6.Visible = True
            CmbBx_Informe_Empresa.Visible = True

        ElseIf CmbBx_Informe.SelectedIndex = 2 Then
            CmbBx_Periodos.Visible = True
            CmbBx_ResumDetall.Visible = True
            CmbBx_Periodos.Location = DtTimPickr_Fecha_Ini.Location
            CmbBx_ResumDetall.Location = DtTimPickr_Fecha_Fin.Location
            CmbBx_ResumDetall.SelectedIndex = 0
            Label1.Text = "Periodos  : "
            DtTimPickr_Fecha_Ini.Visible = False
            DtTimPickr_Fecha_Fin.Visible = False

            Label5.Visible = False
            TxtBx_TotLeche.Visible = False



            Label7.Visible = False
            CmbBx_Informe_TipColac.Visible = False
            Label2.Visible = False
            CmbBx_Informe_Orden.Visible = False
            Label6.Visible = False
            CmbBx_Informe_Empresa.Visible = False

        End If
    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        worksheet = workbook.Sheets("Hoja1")
        worksheet = workbook.ActiveSheet
        'Aca se agregan las cabeceras de nuestro datagrid.

        For i As Integer = 1 To Me.DataGridView1.Columns.Count
            worksheet.Cells(1, i) = Me.DataGridView1.Columns(i - 1).HeaderText
        Next

        'Aca se ingresa el detalle recorrera la tabla celda por celda

        For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
            For j As Integer = 0 To Me.DataGridView1.Columns.Count - 1
                worksheet.Cells(i + 2, j + 1) = Me.DataGridView1.Rows(i).Cells(j).Value.ToString()
            Next
        Next

        'Aca le damos el formato a nuestro excel

        worksheet.Rows.Item(1).Font.Bold = 1
        worksheet.Rows.Item(1).HorizontalAlignment = 3
        worksheet.Columns.AutoFit()
        worksheet.Columns.HorizontalAlignment = 2

        app.Visible = True
        app = Nothing
        workbook = Nothing
        worksheet = Nothing
        FileClose(1)
        GC.Collect()

    End Sub

End Class
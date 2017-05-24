Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Frm_MantencionColaciones
    Dim vDateInfo As DateTime
    Dim dt As New DataTable
    Dim conexion As New SqlConnection
    Dim cmd As SqlCommand


    Private Sub Frm_MantencionColaciones_Load(sender As Object, e As EventArgs) Handles Me.Load

        conexion.ConnectionString = "Data Source=FSSAPBO;Initial Catalog = SAC_Mindugar; Persist Security Info=True;User ID = sa; Password=Sqladmin281"

        MDIParent1.Panel2.Visible = False
        Dim ctl As Control
        For Each ctl In Me.Controls
            AddHandler ctl.KeyDown, AddressOf myEventHandler
        Next
        Me.WindowState = FormWindowState.Maximized
        '--------------------------------------------------

        Dim vDateFin As DateTime

        vDateInfo = FormatDateTime(DateSerial(Year(Date.Now), Month(Date.Now), Microsoft.VisualBasic.DateAndTime.Day(Date.Now)), DateFormat.LongDate) + " 09:00"
        Dim vDiaNum As Integer = Weekday(vDateInfo)
        'Dim vDay As Integer = Weekday(vDateInf)
        While vDiaNum <> 2
            vDateInfo = DateAdd("d", -1, vDateInfo)
            vDiaNum = Weekday(vDateInfo)
        End While
        vDateFin = DateAdd("d", 7 - 1, vDateInfo)
        lbl_Fecha.ForeColor = Drawing.Color.Blue
        LLenaFechasColaciones(vDateInfo)
        CargarColaciones(vDateInfo)
        VisiblePostres()
    End Sub
    Private Sub VisiblePostres()
        TxtBx_Pos_A1.Visible = True
        TxtBx_Pos_A1.Enabled = False
        TxtBx_Pos_B1.Visible = False
        TxtBx_Pos_C1.Visible = False
        TxtBx_Pos_D1.Visible = False
        TxtBx_Pos_A2.Visible = True
        TxtBx_Pos_A2.Enabled = False
        TxtBx_Pos_B2.Visible = False
        TxtBx_Pos_C2.Visible = False
        TxtBx_Pos_D2.Visible = False
        TxtBx_Pos_A3.Visible = True
        TxtBx_Pos_A3.Enabled = False
        TxtBx_Pos_B3.Visible = False
        TxtBx_Pos_C3.Visible = False
        TxtBx_Pos_D3.Visible = False
        TxtBx_Pos_A4.Visible = True
        TxtBx_Pos_A4.Enabled = False
        TxtBx_Pos_B4.Visible = False
        TxtBx_Pos_C4.Visible = False
        TxtBx_Pos_D4.Visible = False
        TxtBx_Pos_A5.Visible = True
        TxtBx_Pos_A5.Enabled = False
        TxtBx_Pos_B5.Visible = False
        TxtBx_Pos_C5.Visible = False
        TxtBx_Pos_D5.Visible = False
    End Sub

    Private Sub myEventHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Bttn_Cancelar_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MDIParent1.Panel2.Visible = True
        MDIParent1.TiempoIngreso.Enabled = True
        Me.Close()
    End Sub



    Sub LLenaFechasColaciones(DateInfo As Date)

        Lbl_A1.ForeColor = Color.Black
        Lbl_A2.ForeColor = Color.Black
        Lbl_A3.ForeColor = Color.Black
        Lbl_A4.ForeColor = Color.Black
        Lbl_A5.ForeColor = Color.Black
        Lbl_A1.Text = ""
        Lbl_A2.Text = ""
        Lbl_A3.Text = ""
        Lbl_A4.Text = ""
        Lbl_A5.Text = ""

        Dim FechaIni As Date = DateInfo
        Dim FechaFin As Date = DateAdd("d", 7 - 1, DateInfo)
        lbl_Fecha.Text = FormatDateTime(DateSerial(Year(FechaIni), Month(FechaIni), Microsoft.VisualBasic.DateAndTime.Day(FechaIni)), DateFormat.LongDate) + Space(3) + "hasta  el " + Space(3) + FormatDateTime(DateSerial(Year(FechaFin), Month(FechaFin), Microsoft.VisualBasic.DateAndTime.Day(FechaFin)), DateFormat.LongDate)

        ControlEnable(FechaIni)


        'Coloca dias
        Lbl_A1.Text = FormatDateTime(DateSerial(Year(DateInfo), Month(DateInfo), Microsoft.VisualBasic.DateAndTime.Day(DateInfo)), DateFormat.LongDate)
        DateInfo = DateAdd("d", 1, DateInfo)
        Lbl_A2.Text = FormatDateTime(DateSerial(Year(DateInfo), Month(DateInfo), Microsoft.VisualBasic.DateAndTime.Day(DateInfo)), DateFormat.LongDate)
        DateInfo = DateAdd("d", 1, DateInfo)
        Lbl_A3.Text = FormatDateTime(DateSerial(Year(DateInfo), Month(DateInfo), Microsoft.VisualBasic.DateAndTime.Day(DateInfo)), DateFormat.LongDate)
        DateInfo = DateAdd("d", 1, DateInfo)
        Lbl_A4.Text = FormatDateTime(DateSerial(Year(DateInfo), Month(DateInfo), Microsoft.VisualBasic.DateAndTime.Day(DateInfo)), DateFormat.LongDate)
        DateInfo = DateAdd("d", 1, DateInfo)
        Lbl_A5.Text = FormatDateTime(DateSerial(Year(DateInfo), Month(DateInfo), Microsoft.VisualBasic.DateAndTime.Day(DateInfo)), DateFormat.LongDate)


        'Pinta Dias feriado
        dt.Reset()
        cmd = New SqlCommand("Feriados_Info", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd.Parameters.Add(New SqlParameter("@FechaIni", FechaIni.ToString("yyyyMMdd")))
        cmd.Parameters.Add(New SqlParameter("@FechaFin", FechaFin.ToString("yyyyMMdd")))
        Try
            dt.Load(cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try
        If dt.Rows(0)("DiasFer") > 0 Then
            Dim str As String
            Dim controlLabel As Label
            For i As Integer = 1 To 5
                str = String.Format("Lbl_A{0}", i)
                controlLabel = CType(Me.TableLayoutPanel2.Controls(str), Label)
                'controlLabel.Text =FormatDateTime(DateSerial(Year(DateInfo), Month(DateInfo), Microsoft.VisualBasic.DateAndTime.Day(DateInfo)), DateFormat.LongDate)
                If (Not (controlLabel Is Nothing)) Then
                    dt.Reset()
                    cmd = New SqlCommand("Comi_Feriados_Info", conexion)
                    cmd.CommandType = CommandType.StoredProcedure
                    conexion.Open()
                    cmd.Parameters.Add(New SqlParameter("@FechaIni", FechaIni.ToString("yyyyMMdd")))
                    cmd.Parameters.Add(New SqlParameter("@FechaFin", FechaIni.ToString("yyyyMMdd")))
                    Try
                        dt.Load(cmd.ExecuteReader())
                    Catch ex As Exception
                    Finally
                        conexion.Close()
                    End Try
                    If dt.Rows(0)("DiasFer") <> 0 Then
                        controlLabel.ForeColor = Color.Red
                    Else
                        controlLabel.ForeColor = Color.Black
                    End If

                End If
                FechaIni = DateAdd("d", 1, FechaIni)
            Next

        End If
    End Sub

    Sub ControlEnable(DateInfo As Date)
        For Linea = 1 To 5
            If Linea = 1 Then
                If DateInfo < Date.Now Then
                    TxtBx_Alm_A1.Enabled = False
                    TxtBx_Alm_B1.Enabled = False
                    TxtBx_Alm_C1.Enabled = False
                    'TxtBx_Alm_D1.Enabled = False
                    'TxtBx_Pos_A1.Enabled = False
                    'TxtBx_Pos_B1.Enabled = False
                    'TxtBx_Pos_C1.Enabled = False
                    'TxtBx_Pos_D1.Enabled = False

                Else
                    TxtBx_Alm_A1.Enabled = True
                    TxtBx_Alm_B1.Enabled = True
                    TxtBx_Alm_C1.Enabled = True
                    'TxtBx_Alm_D1.Enabled = True
                    'TxtBx_Pos_A1.Enabled = True
                    'TxtBx_Pos_B1.Enabled = True
                    'TxtBx_Pos_C1.Enabled = True
                    'TxtBx_Pos_D1.Enabled = True
                End If
            End If
            If Linea = 2 Then
                If DateInfo < Date.Now Then
                    TxtBx_Alm_A2.Enabled = False
                    TxtBx_Alm_B2.Enabled = False
                    TxtBx_Alm_C2.Enabled = False
                    'TxtBx_Alm_D2.Enabled = False
                    'TxtBx_Pos_A2.Enabled = False
                    'TxtBx_Pos_B2.Enabled = False
                    'TxtBx_Pos_C2.Enabled = False
                    'TxtBx_Pos_D2.Enabled = False

                Else
                    TxtBx_Alm_A2.Enabled = True
                    TxtBx_Alm_B2.Enabled = True
                    TxtBx_Alm_C2.Enabled = True
                    'TxtBx_Alm_D2.Enabled = True
                    'TxtBx_Pos_A2.Enabled = True
                    'TxtBx_Pos_B2.Enabled = True
                    'TxtBx_Pos_C2.Enabled = True
                    'TxtBx_Pos_D2.Enabled = True
                End If
            End If
            If Linea = 3 Then
                If DateInfo < Date.Now Then
                    TxtBx_Alm_A3.Enabled = False
                    TxtBx_Alm_B3.Enabled = False
                    TxtBx_Alm_C3.Enabled = False
                    'TxtBx_Alm_D3.Enabled = False
                    'TxtBx_Pos_A3.Enabled = False
                    'TxtBx_Pos_B3.Enabled = False
                    'TxtBx_Pos_C3.Enabled = False
                    'TxtBx_Pos_D3.Enabled = False

                Else
                    TxtBx_Alm_A3.Enabled = True
                    TxtBx_Alm_B3.Enabled = True
                    TxtBx_Alm_C3.Enabled = True
                    'TxtBx_Alm_D3.Enabled = True
                    'TxtBx_Pos_A3.Enabled = True
                    'TxtBx_Pos_B3.Enabled = True
                    'TxtBx_Pos_C3.Enabled = True
                    'TxtBx_Pos_D3.Enabled = True
                End If
            End If
            If Linea = 4 Then
                If DateInfo < Date.Now Then
                    TxtBx_Alm_A4.Enabled = False
                    TxtBx_Alm_B4.Enabled = False
                    TxtBx_Alm_C4.Enabled = False
                    'TxtBx_Alm_D4.Enabled = False
                    'TxtBx_Pos_A4.Enabled = False
                    'TxtBx_Pos_B4.Enabled = False
                    'TxtBx_Pos_C4.Enabled = False
                    'TxtBx_Pos_D4.Enabled = False

                Else
                    TxtBx_Alm_A4.Enabled = True
                    TxtBx_Alm_B4.Enabled = True
                    TxtBx_Alm_C4.Enabled = True
                    'TxtBx_Alm_D4.Enabled = True
                    'TxtBx_Pos_A4.Enabled = True
                    'TxtBx_Pos_B4.Enabled = True
                    'TxtBx_Pos_C4.Enabled = True
                    'TxtBx_Pos_D4.Enabled = True
                End If
            End If
            If Linea = 5 Then
                If DateInfo < Date.Now Then
                    TxtBx_Alm_A5.Enabled = False
                    TxtBx_Alm_B5.Enabled = False
                    TxtBx_Alm_C5.Enabled = False
                    'TxtBx_Alm_D5.Enabled = False
                    'TxtBx_Pos_A5.Enabled = False
                    'TxtBx_Pos_B5.Enabled = False
                    'TxtBx_Pos_C5.Enabled = False
                    'TxtBx_Pos_D5.Enabled = False

                Else
                    TxtBx_Alm_A5.Enabled = True
                    TxtBx_Alm_B5.Enabled = True
                    TxtBx_Alm_C5.Enabled = True
                    'TxtBx_Alm_D5.Enabled = True
                    'TxtBx_Pos_A5.Enabled = True
                    'TxtBx_Pos_B5.Enabled = True
                    'TxtBx_Pos_C5.Enabled = True
                    'TxtBx_Pos_D5.Enabled = True
                End If
            End If
            DateInfo = DateAdd("d", 1, DateInfo)
        Next
    End Sub



    Sub CargarColaciones(DateInfo As DateTime)
        Dim FechaIni As Date = DateInfo
        LimpiarColaciones()

        For vDiaNum As Integer = 1 To 5
            cmd = New SqlCommand("Colaciones_Info", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            conexion.Open()
            cmd.Parameters.Add(New SqlParameter("@FechaIni", FechaIni.ToString("yyyyMMdd")))
            Try
                dt.Reset()
                dt.Load(cmd.ExecuteReader())
            Catch ex As Exception
            Finally
                conexion.Close()
            End Try


            If dt.Rows(0)("IdEstado") = 0 Then
                If vDiaNum = 1 Then
                    TxtBx_Alm_A1.Text = dt.Rows(0)("Almuerzo_A")
                    TxtBx_Alm_B1.Text = dt.Rows(0)("Almuerzo_B")
                    TxtBx_Alm_C1.Text = dt.Rows(0)("Almuerzo_C")
                    'TxtBx_Alm_D1.Text = dt.Rows(0)("Almuerzo_D")

                    'TxtBx_Pos_A1.Text = dt.Rows(0)("Postre_A")
                    'TxtBx_Pos_B1.Text = dt.Rows(0)("Postre_B")
                    'TxtBx_Pos_C1.Text = dt.Rows(0)("Postre_C")
                    'TxtBx_Pos_D1.Text = dt.Rows(0)("Postre_D")
                End If
                If vDiaNum = 2 Then
                    TxtBx_Alm_A2.Text = dt.Rows(0)("Almuerzo_A")
                    TxtBx_Alm_B2.Text = dt.Rows(0)("Almuerzo_B")
                    TxtBx_Alm_C2.Text = dt.Rows(0)("Almuerzo_C")
                    'TxtBx_Alm_D2.Text = dt.Rows(0)("Almuerzo_D")

                    'TxtBx_Pos_A2.Text = dt.Rows(0)("Postre_A")
                    'TxtBx_Pos_B2.Text = dt.Rows(0)("Postre_B")
                    'TxtBx_Pos_C2.Text = dt.Rows(0)("Postre_C")
                    'TxtBx_Pos_D2.Text = dt.Rows(0)("Postre_D")
                End If
                If vDiaNum = 3 Then
                    TxtBx_Alm_A3.Text = dt.Rows(0)("Almuerzo_A")
                    TxtBx_Alm_B3.Text = dt.Rows(0)("Almuerzo_B")
                    TxtBx_Alm_C3.Text = dt.Rows(0)("Almuerzo_C")
                    'TxtBx_Alm_D3.Text = dt.Rows(0)("Almuerzo_D")

                    'TxtBx_Pos_A3.Text = dt.Rows(0)("Postre_A")
                    'TxtBx_Pos_B3.Text = dt.Rows(0)("Postre_B")
                    'TxtBx_Pos_C3.Text = dt.Rows(0)("Postre_C")
                    'TxtBx_Pos_D3.Text = dt.Rows(0)("Postre_D")
                End If
                If vDiaNum = 4 Then
                    TxtBx_Alm_A4.Text = dt.Rows(0)("Almuerzo_A")
                    TxtBx_Alm_B4.Text = dt.Rows(0)("Almuerzo_B")
                    TxtBx_Alm_C4.Text = dt.Rows(0)("Almuerzo_C")
                    'TxtBx_Alm_D4.Text = dt.Rows(0)("Almuerzo_D")

                    'TxtBx_Pos_A4.Text = dt.Rows(0)("Postre_A")
                    'TxtBx_Pos_B4.Text = dt.Rows(0)("Postre_B")
                    'TxtBx_Pos_C4.Text = dt.Rows(0)("Postre_C")
                    'TxtBx_Pos_D4.Text = dt.Rows(0)("Postre_D")
                End If
                If vDiaNum = 5 Then
                    TxtBx_Alm_A5.Text = dt.Rows(0)("Almuerzo_A")
                    TxtBx_Alm_B5.Text = dt.Rows(0)("Almuerzo_B")
                    TxtBx_Alm_C5.Text = dt.Rows(0)("Almuerzo_C")
                    'TxtBx_Alm_D5.Text = dt.Rows(0)("Almuerzo_D")

                    'TxtBx_Pos_A5.Text = dt.Rows(0)("Postre_A")
                    'TxtBx_Pos_B5.Text = dt.Rows(0)("Postre_B")
                    'TxtBx_Pos_C5.Text = dt.Rows(0)("Postre_C")
                    'TxtBx_Pos_D5.Text = dt.Rows(0)("Postre_D")
                End If

            End If
            FechaIni = DateAdd("d", 1, FechaIni)
        Next
    End Sub

    Sub LimpiarColaciones()




        TxtBx_Alm_A1.Text = ""
        TxtBx_Alm_B1.Text = ""
        TxtBx_Alm_C1.Text = ""
        'TxtBx_Alm_D1.Text = ""
        'TxtBx_Pos_A1.Text = ""
        'TxtBx_Pos_B1.Text = ""
        'TxtBx_Pos_C1.Text = ""
        'TxtBx_Pos_D1.Text = ""

        TxtBx_Alm_A2.Text = ""
        TxtBx_Alm_B2.Text = ""
        TxtBx_Alm_C2.Text = ""
        'TxtBx_Alm_D2.Text = ""
        'TxtBx_Pos_A2.Text = ""
        'TxtBx_Pos_B2.Text = ""
        'TxtBx_Pos_C2.Text = ""
        'TxtBx_Pos_D2.Text = ""

        TxtBx_Alm_A3.Text = ""
        TxtBx_Alm_B3.Text = ""
        TxtBx_Alm_C3.Text = ""
        'TxtBx_Alm_D3.Text = ""
        'TxtBx_Pos_A3.Text = ""
        'TxtBx_Pos_B3.Text = ""
        'TxtBx_Pos_C3.Text = ""
        'TxtBx_Pos_D3.Text = ""

        TxtBx_Alm_A4.Text = ""
        TxtBx_Alm_B4.Text = ""
        TxtBx_Alm_C4.Text = ""
        'TxtBx_Alm_D4.Text = ""
        'TxtBx_Pos_A4.Text = ""
        'TxtBx_Pos_B4.Text = ""
        'TxtBx_Pos_C4.Text = ""
        'TxtBx_Pos_D4.Text = ""

        TxtBx_Alm_A5.Text = ""
        TxtBx_Alm_B5.Text = ""
        TxtBx_Alm_C5.Text = ""
        'TxtBx_Alm_D5.Text = ""
        'TxtBx_Pos_A5.Text = ""
        'TxtBx_Pos_B5.Text = ""
        'TxtBx_Pos_C5.Text = ""
        'TxtBx_Pos_D5.Text = ""
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ActuakizarColaciones(vDateInfo)
    End Sub

    Sub ActuakizarColaciones(DateInfo As DateTime)
        Dim FechaIni As Date = DateInfo
        For vDiaNum As Integer = 1 To 5
            dt.Reset()
            If vDiaNum = 1 Then
                cmd = New SqlCommand("Colaciones_Ges", conexion)
                cmd.CommandType = CommandType.StoredProcedure
                conexion.Open()
                cmd.Parameters.Add(New SqlParameter("@Id", FechaIni.ToString("yyyyMMdd")))
                cmd.Parameters.Add(New SqlParameter("@Col_B", TxtBx_Alm_A1.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_C", TxtBx_Alm_B1.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_D", TxtBx_Alm_C1.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_E", TxtBx_Alm_D1.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_F", TxtBx_Pos_A1.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_G", TxtBx_Pos_B1.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_H", TxtBx_Pos_C1.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_I", TxtBx_Pos_D1.Text))
            End If
            If vDiaNum = 2 Then
                cmd = New SqlCommand("Colaciones_Ges", conexion)
                cmd.CommandType = CommandType.StoredProcedure
                conexion.Open()
                cmd.Parameters.Add(New SqlParameter("@Id", FechaIni.ToString("yyyyMMdd")))
                cmd.Parameters.Add(New SqlParameter("@Col_B", TxtBx_Alm_A2.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_C", TxtBx_Alm_B2.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_D", TxtBx_Alm_C2.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_E", TxtBx_Alm_D2.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_F", TxtBx_Pos_A2.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_G", TxtBx_Pos_B2.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_H", TxtBx_Pos_C2.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_I", TxtBx_Pos_D2.Text))
            End If
            If vDiaNum = 3 Then
                cmd = New SqlCommand("Colaciones_Ges", conexion)
                cmd.CommandType = CommandType.StoredProcedure
                conexion.Open()
                cmd.Parameters.Add(New SqlParameter("@Id", FechaIni.ToString("yyyyMMdd")))
                cmd.Parameters.Add(New SqlParameter("@Col_B", TxtBx_Alm_A3.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_C", TxtBx_Alm_B3.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_D", TxtBx_Alm_C3.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_E", TxtBx_Alm_D3.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_F", TxtBx_Pos_A3.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_G", TxtBx_Pos_B3.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_H", TxtBx_Pos_C3.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_I", TxtBx_Pos_D3.Text))
            End If
            If vDiaNum = 4 Then
                cmd = New SqlCommand("Colaciones_Ges", conexion)
                cmd.CommandType = CommandType.StoredProcedure
                conexion.Open()
                cmd.Parameters.Add(New SqlParameter("@Id", FechaIni.ToString("yyyyMMdd")))
                cmd.Parameters.Add(New SqlParameter("@Col_B", TxtBx_Alm_A4.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_C", TxtBx_Alm_B4.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_D", TxtBx_Alm_C4.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_E", TxtBx_Alm_D4.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_F", TxtBx_Pos_A4.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_G", TxtBx_Pos_B4.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_H", TxtBx_Pos_C4.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_I", TxtBx_Pos_D4.Text))
            End If
            If vDiaNum = 5 Then
                cmd = New SqlCommand("Colaciones_Ges", conexion)
                cmd.CommandType = CommandType.StoredProcedure
                conexion.Open()
                cmd.Parameters.Add(New SqlParameter("@Id", FechaIni.ToString("yyyyMMdd")))
                cmd.Parameters.Add(New SqlParameter("@Col_B", TxtBx_Alm_A5.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_C", TxtBx_Alm_B5.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_D", TxtBx_Alm_C5.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_E", TxtBx_Alm_D5.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_F", TxtBx_Pos_A5.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_G", TxtBx_Pos_B5.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_H", TxtBx_Pos_C5.Text))
                cmd.Parameters.Add(New SqlParameter("@Col_I", TxtBx_Pos_D5.Text))
            End If



            Try
                dt.Load(cmd.ExecuteReader())
                MDIParent1.TlStrpSttsLbl_SQL.Text = dt.Rows(0)("Estado_Usr")

            Catch ex As Exception

            Finally

                conexion.Close()
            End Try
            FechaIni = DateAdd("d", 1, FechaIni)
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        vDateInfo = DateAdd("d", -7, vDateInfo)
        LLenaFechasColaciones(vDateInfo)
        CargarColaciones(vDateInfo)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        vDateInfo = DateAdd("d", 7, vDateInfo)
        LLenaFechasColaciones(vDateInfo)
        CargarColaciones(vDateInfo)
    End Sub
End Class
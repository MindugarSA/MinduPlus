Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement



Public Class Frm_SolicitudGerencial

    Dim vDateInfo As DateTime
    Dim dt As New DataTable
    Dim conexion As New SqlConnection
    Dim cmd As SqlCommand
    Dim gRut As String = MDIParent1.Lbl_RutTrab.Text


    Private Sub Frm_SolicitudGerencial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Data Source=FSSAPBO;Initial Catalog = SAC_Mindugar; Persist Security Info=True;User ID = sa; Password=Sqladmin281"

        Dim ctl As Control
        For Each ctl In Me.Controls
            AddHandler ctl.KeyDown, AddressOf myEventHandler
        Next

        Txt_Fecha.Text = Format(MonthCalendar1.TodayDate, "dddd  dd-MMM-yyyy")
        Lbl_Fecha.Text = Format(MonthCalendar1.TodayDate, "yyyyMMdd")
        Lbl_Fecha.Visible = False
        MonthCalendar1.Visible = False

        Me.WindowState = FormWindowState.Maximized


    End Sub

    Private Sub myEventHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        MDIParent1.Visualizar_Tiles_MDI()
        MDIParent1.Desplazamiento_Tiles()
        MDIParent1.TiempoIngreso.Enabled = True
        Me.Close()
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected

        Txt_Fecha.Text = Format(sender.SelectionStart, "dddd  dd-MMM-yyyy")
        Lbl_Fecha.Text = Format(sender.SelectionStart, "yyyyMMdd")
        cmd = New SqlCommand("Colaciones_SolAdicional_Info", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd.Parameters.Add(New SqlParameter("@Rut", "96588890-K"))
        cmd.Parameters.Add(New SqlParameter("@Fecha_SolicitudIni", Lbl_Fecha.Text))
        cmd.Parameters.Add(New SqlParameter("@Fecha_SolicitudFin", Lbl_Fecha.Text))
        Try

            dt.Reset()
            dt.Load(cmd.ExecuteReader())
            If dt.Rows(0)("IdEstado") = 0 Then
                Tb_Gerencia.Text = dt.Rows(0)("Gcia")
                Tt_ComentAlmGcial.Text = dt.Rows(0)("ComentAlmGcial")
                TB_AlmuerzoNormales.Text = dt.Rows(0)("Nor")
                TB_ComentAlmNorm.Text = dt.Rows(0)("ComentAlmNorm")
            Else
                Tb_Gerencia.Text = "0"
                Tt_ComentAlmGcial.Text = ""
                TB_AlmuerzoNormales.Text = "0"
                TB_ComentAlmNorm.Text = ""
            End If

        Catch ex As Exception

        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tb_Gerencia.KeyPress, TB_AlmuerzoNormales.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Errores As String = ""
        Dim vFecha As String
        If TB_AlmuerzoNormales.Text = "" Then TB_AlmuerzoNormales.Text = 0
        If Tb_Gerencia.Text = "" Then Tb_Gerencia.Text = 0
        cmd = New SqlCommand("Colaciones_SolAdicional_Ges", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        vFecha = Lbl_Fecha.Text
        conexion.Open()

        cmd.Parameters.Add(New SqlParameter("@Rut", "96588890-K")) ' MDIParent1.Lbl_RutTrab.Text))
        cmd.Parameters.Add(New SqlParameter("@Fecha_Graba", Date.Now.ToString("yyyyMMdd")))
        cmd.Parameters.Add(New SqlParameter("@Fecha_Solicitud", Lbl_Fecha.Text))
        cmd.Parameters.Add(New SqlParameter("@AlmuerzoGerencial", Integer.Parse(Tb_Gerencia.Text)))
        cmd.Parameters.Add(New SqlParameter("@ComentAlmGcial", Tt_ComentAlmGcial.Text))
        cmd.Parameters.Add(New SqlParameter("@AlmuerzoNormales", Integer.Parse(TB_AlmuerzoNormales.Text)))
        cmd.Parameters.Add(New SqlParameter("@ComentAlmNorm", TB_ComentAlmNorm.Text))
        cmd.Parameters.Add(New SqlParameter("@RutGraba", MDIParent1.Lbl_RutTrab.Text))

        Try
            dt.Reset()
            dt.Load(cmd.ExecuteReader())
        Catch ex As Exception
            Errores = ex.ToString
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub MonthCalendar2_DaySelected(sender As Object, e As Pabo.Calendar.DaySelectedEventArgs) Handles MonthCalendar2.DaySelected

        Txt_Fecha.Text = Format(MonthCalendar2.SelectedDates.Item(0), "dddd  dd-MMM-yyyy")
        Lbl_Fecha.Text = Format(MonthCalendar2.SelectedDates.Item(0), "yyyyMMdd")

        cmd = New SqlCommand("Colaciones_SolAdicional_Info", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd.Parameters.Add(New SqlParameter("@Rut", "96588890-K"))
        cmd.Parameters.Add(New SqlParameter("@Fecha_SolicitudIni", Lbl_Fecha.Text))
        cmd.Parameters.Add(New SqlParameter("@Fecha_SolicitudFin", Lbl_Fecha.Text))
        Try

            dt.Reset()
            dt.Load(cmd.ExecuteReader())
            If dt.Rows(0)("IdEstado") = 0 Then
                Tb_Gerencia.Text = dt.Rows(0)("Gcia")
                Tt_ComentAlmGcial.Text = dt.Rows(0)("ComentAlmGcial")
                TB_AlmuerzoNormales.Text = dt.Rows(0)("Nor")
                TB_ComentAlmNorm.Text = dt.Rows(0)("ComentAlmNorm")
            Else
                Tb_Gerencia.Text = "0"
                Tt_ComentAlmGcial.Text = ""
                TB_AlmuerzoNormales.Text = "0"
                TB_ComentAlmNorm.Text = ""
            End If

        Catch ex As Exception

        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub MonthCalendar2_DayDeselected(sender As Object, e As Pabo.Calendar.DaySelectedEventArgs) Handles MonthCalendar2.DayDeselected

    End Sub
End Class
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic


Public Class Frm_SolicitudColacion

    Property vDateAct As DateTime
    Property vDateIni As DateTime
    Property vDateFin As DateTime
    Property dt As New DataTable
    Property conexion As New SqlConnection
    Property cmd As SqlCommand
    Property gRut As String = MDIParent1.Lbl_RutTrab.Text
    Property ImagenAlmuerzo As Image = Global.RRHH.My.Resources.Resources.check_mark_white
    Property BackColorAlmuerzo As Color = Color.White
    Property FechaDBServer As Date


    Private WithEvents timer As Timer
    Private listaControl As List(Of Control)
    Private Const DESPLAZAMIENTO As Integer = 100
    Private time As Integer = 0
    Private maxTime As Integer = 0
    Private originalPos As Point
    Private bitmap As Bitmap
    Private panelAntiguo As PictureBox
    Private sentido As Integer
    Private clickPictureBoxActivo As Boolean

    Public Delegate Sub LaunchEvent()
    Public Event EnviarEvento As LaunchEvent

    Private Const WM_SETREDRAW As Integer = 11

    <DllImport("user32.dll", EntryPoint:="SendMessage")>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    End Function

    Private Sub Frm_SolicitudColacion_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.SuspendLayout()

        Iniciar_Form_Almuerzos()

        Me.ResumeLayout()
        timer = New Timer()
        timer.Interval = 30
        listaControl = New List(Of Control)
        CrearListaControles()
    End Sub

    Private Sub Frm_SolicitudColación_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.DoubleBuffered = True
        clickPictureBoxActivo = True
    End Sub

    Private Sub myEventHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Bttn_Cancelar_Click(sender As Object, e As EventArgs) Handles Bttn_Cancelar.Click
        MDIParent1.Panel2.Visible = True
        MDIParent1.ToolStripProgressBar1.ProgressBar.Maximum = MDIParent1.TiempoActivo
        RaiseEvent EnviarEvento()
        Me.Close()
        MDIParent1.TiempoIngreso.Enabled = True
    End Sub

    Private Sub Almuerzos_Click(sender As Object, e As EventArgs) Handles Lbl_A1.Click, Lbl_D1.Click, Lbl_C1.Click, Lbl_B1.Click, Lbl_B2.Click, Lbl_A2.Click, Lbl_D5.Click, Lbl_A5.Click, Lbl_B5.Click, Lbl_C5.Click, Lbl_D4.Click, Lbl_A4.Click, Lbl_B4.Click, Lbl_C4.Click, Lbl_D3.Click, Lbl_C3.Click, Lbl_B3.Click, Lbl_A3.Click, Lbl_C2.Click, Lbl_D2.Click

        Dim controlLabel_Fecha, controlLabel_A, controlLabel_B, controlLabel_C, controlLabel_D As Label
        Dim Linea As String = VBRight(sender.name.ToString, 1)
        Dim esFeriado, esLeche, EsAlmuerzo As Boolean

        controlLabel_Fecha = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_0{0}", Linea)), Label)

        esFeriado = ConsultaDiaFeriado(vDateIni.AddDays(Convert.ToInt32(Linea) - 1))
        esLeche = ConsultaDiaLeche(vDateIni.AddDays(Convert.ToInt32(Linea) - 1))
        EsAlmuerzo = IIf(esFeriado Or esLeche, False, True)

        If (EsAlmuerzo) Then
            controlLabel_A = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_A{0}", Linea)), Label)
            controlLabel_B = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_B{0}", Linea)), Label)
            controlLabel_C = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_C{0}", Linea)), Label)
            controlLabel_D = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_D{0}", Linea)), Label)
            If sender.name <> controlLabel_A.Name.ToString Then InicializarLabelAlmuerzo(controlLabel_A)
            If sender.name <> controlLabel_B.Name.ToString Then InicializarLabelAlmuerzo(controlLabel_B)
            If sender.name <> controlLabel_C.Name.ToString Then InicializarLabelAlmuerzo(controlLabel_C)
            If sender.name <> controlLabel_D.Name.ToString Then InicializarLabelAlmuerzo(controlLabel_D)

            If sender.Image Is Nothing Then
                SeleccionarLabelAlmuerzo(CType(sender, Label))
            Else
                InicializarLabelAlmuerzo(CType(sender, Label))
                'Borrar Postres
                Dim TblLyutPnl As TableLayoutPanel
                Dim controlLabel_E, controlLabel_F, controlLabel_G, controlLabel_H As Label

                TblLyutPnl = CType(Me.TableLayoutPanel2.Controls(String.Format("TblLyutPnl_{0}", Linea)), TableLayoutPanel)
                controlLabel_E = CType(TblLyutPnl.Controls(String.Format("Lbl_P_A{0}", Linea)), Label)
                controlLabel_F = CType(TblLyutPnl.Controls(String.Format("Lbl_P_B{0}", Linea)), Label)
                controlLabel_G = CType(TblLyutPnl.Controls(String.Format("Lbl_P_C{0}", Linea)), Label)
                controlLabel_H = CType(TblLyutPnl.Controls(String.Format("Lbl_P_D{0}", Linea)), Label)
                If sender.name <> controlLabel_E.Name.ToString Then InicializarLabelAlmuerzo(controlLabel_E)
                If sender.name <> controlLabel_F.Name.ToString Then InicializarLabelAlmuerzo(controlLabel_F)
                If sender.name <> controlLabel_G.Name.ToString Then InicializarLabelAlmuerzo(controlLabel_G)
                If sender.name <> controlLabel_H.Name.ToString Then InicializarLabelAlmuerzo(controlLabel_H)
            End If

            MDIParent1.TiempoActivo = MDIParent1.Tiempo_Str
            MDIParent1.ToolStripProgressBar1.ProgressBar.Value = MDIParent1.TiempoActivo
        End If

    End Sub

    Private Sub Postres_Click(sender As Object, e As EventArgs) Handles Lbl_P_A1.Click, Lbl_P_D1.Click, Lbl_P_C1.Click, Lbl_P_B1.Click, Lbl_P_D5.Click, Lbl_P_D4.Click, Lbl_P_D3.Click, Lbl_P_D2.Click, Lbl_P_C5.Click, Lbl_P_C4.Click, Lbl_P_C3.Click, Lbl_P_C2.Click, Lbl_P_B5.Click, Lbl_P_B4.Click, Lbl_P_B3.Click, Lbl_P_B2.Click, Lbl_P_A5.Click, Lbl_P_A4.Click, Lbl_P_A3.Click, Lbl_P_A2.Click

        Dim controlLabel_Fecha, controlLabel_A, controlLabel_B, controlLabel_C, controlLabel_D As Label
        Dim Linea As String = VBRight(sender.name.ToString, 1)
        Dim esFeriado, esLeche, EsAlmuerzo As Boolean

        controlLabel_Fecha = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_0{0}", Linea)), Label)

        esFeriado = ConsultaDiaFeriado(vDateIni.AddDays(Convert.ToInt32(Linea) - 1))
        esLeche = ConsultaDiaLeche(vDateIni.AddDays(Convert.ToInt32(Linea) - 1))
        EsAlmuerzo = IIf(esFeriado Or esLeche, False, True)

        If (EsAlmuerzo) Then
            'Revisar si esta seleccionado un almuerzo
            controlLabel_A = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_A{0}", Linea)), Label)
            controlLabel_B = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_B{0}", Linea)), Label)
            controlLabel_C = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_C{0}", Linea)), Label)
            controlLabel_D = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_D{0}", Linea)), Label)
            If IsNothing(controlLabel_A.Image) And IsNothing(controlLabel_B.Image) And IsNothing(controlLabel_C.Image) And IsNothing(controlLabel_D.Image) Then
                Beep()
                Exit Sub
            End If
            'Fin ............Revisar si esta seleccionado un almuerzo

            Dim TblLyutPnl As TableLayoutPanel
            Dim controlLabel_E, controlLabel_F, controlLabel_G, controlLabel_H As Label
            TblLyutPnl = CType(Me.TableLayoutPanel2.Controls(String.Format("TblLyutPnl_{0}", Linea)), TableLayoutPanel)
            controlLabel_E = CType(TblLyutPnl.Controls(String.Format("Lbl_P_A{0}", Linea)), Label)
            controlLabel_F = CType(TblLyutPnl.Controls(String.Format("Lbl_P_B{0}", Linea)), Label)
            controlLabel_G = CType(TblLyutPnl.Controls(String.Format("Lbl_P_C{0}", Linea)), Label)
            controlLabel_H = CType(TblLyutPnl.Controls(String.Format("Lbl_P_D{0}", Linea)), Label)
            If sender.name <> controlLabel_E.Name.ToString Then InicializarLabelAlmuerzo(controlLabel_E)
            If sender.name <> controlLabel_F.Name.ToString Then InicializarLabelAlmuerzo(controlLabel_F)
            If sender.name <> controlLabel_G.Name.ToString Then InicializarLabelAlmuerzo(controlLabel_G)
            If sender.name <> controlLabel_H.Name.ToString Then InicializarLabelAlmuerzo(controlLabel_H)
            If sender.Image Is Nothing Then
                SeleccionarLabelAlmuerzo(CType(sender, Label))
            Else
                sender.Image = Nothing
            End If
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If clickPictureBoxActivo Then
            clickPictureBoxActivo = False
            SuspendDrawing()
            vDateIni = DateAdd("d", -7, vDateIni)
            tb_FechaIni.Text = vDateIni.ToString("yyyyMMdd")
            txbTrabajador.AutoCompleteCustomSource.Clear()
            txbTrabajador.AutoCompleteCustomSource = listaAutocompletadaTrabajadores()

            LLenarFechasAlmuerzos(vDateIni)
            HabilitarDiasAcceso(vDateIni)
            CargarMenuAlmuerzos(vDateIni)

            MDIParent1.TiempoActivo = MDIParent1.Tiempo_Str
            MDIParent1.ToolStripProgressBar1.ProgressBar.Value = MDIParent1.TiempoActivo

            sentido = 1
            generarMove()

            ResumeDrawing()
            CargaFechaSemana(vDateIni)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If clickPictureBoxActivo Then
            clickPictureBoxActivo = False
            SuspendDrawing()
            vDateIni = DateAdd("d", 7, vDateIni)
            tb_FechaIni.Text = vDateIni.ToString("yyyyMMdd")
            txbTrabajador.AutoCompleteCustomSource.Clear()
            txbTrabajador.AutoCompleteCustomSource = listaAutocompletadaTrabajadores()

            LLenarFechasAlmuerzos(vDateIni)
            HabilitarDiasAcceso(vDateIni)
            CargarMenuAlmuerzos(vDateIni)

            MDIParent1.TiempoActivo = MDIParent1.Tiempo_Str
            MDIParent1.ToolStripProgressBar1.ProgressBar.Value = MDIParent1.TiempoActivo

            sentido = -1
            generarMove()

            ResumeDrawing()
            CargaFechaSemana(vDateIni)
        End If
    End Sub

    Private Sub CargaFechaSemana(FechaIni)

        Dim FechaFin As Date = DateAdd("d", 7 - 1, FechaIni)
        Me.lbl_Fecha.Text = ""
        lbl_Fecha.Text = (FormatDateTime(DateSerial(Year(FechaIni), Month(FechaIni), DateAndTime.Day(FechaIni)), DateFormat.LongDate) +
                         Space(2) +
                         "hasta el" +
                         Space(2) +
                         FormatDateTime(DateSerial(Year(FechaFin), Month(FechaFin), DateAndTime.Day(FechaFin)), DateFormat.LongDate)).ToUpper()
    End Sub

    Public Sub generarMove()
        bitmap = New Bitmap(TableLayoutPanel2.ClientSize.Width, TableLayoutPanel2.ClientSize.Height)
        Dim rec As Rectangle = New Rectangle(0, 0, bitmap.Width, bitmap.Height)
        TableLayoutPanel2.DrawToBitmap(bitmap, rec)
        originalPos = TableLayoutPanel2.Location
        TableLayoutPanel2.Left -= sentido * TableLayoutPanel2.Width
        time = 0
        maxTime = TableLayoutPanel2.Width / DESPLAZAMIENTO
        panelAntiguo = New PictureBox()
        panelAntiguo.Image = bitmap
        panelAntiguo.Location = originalPos
        panelAntiguo.Size = TableLayoutPanel2.Size
        panelAntiguo.Visible = True
        Me.Controls.Add(panelAntiguo)

        timer.Start()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Errores As String = ""
        Dim controlLabel_A, controlLabel_B, controlLabel_C, controlLabel_D As Label
        Dim SelectAlmuerzo, SelectPostre As String
        Dim TblLyutPnl As TableLayoutPanel
        Dim controlLabel_E, controlLabel_F, controlLabel_G, controlLabel_H As Label
        Dim FechaIni = vDateIni
        For Linea = 1 To 5
            SelectAlmuerzo = "-"
            controlLabel_A = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_A{0}", Linea)), Label)
            controlLabel_B = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_B{0}", Linea)), Label)
            controlLabel_C = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_C{0}", Linea)), Label)
            controlLabel_D = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_D{0}", Linea)), Label)
            If Not controlLabel_A.Image Is Nothing Then SelectAlmuerzo = VBLeft(VBRight(controlLabel_A.Name.ToString, 2), 1)
            If Not controlLabel_B.Image Is Nothing Then SelectAlmuerzo = VBLeft(VBRight(controlLabel_B.Name.ToString, 2), 1)
            If Not controlLabel_C.Image Is Nothing Then SelectAlmuerzo = VBLeft(VBRight(controlLabel_C.Name.ToString, 2), 1)
            If Not controlLabel_D.Image Is Nothing Then SelectAlmuerzo = VBLeft(VBRight(controlLabel_D.Name.ToString, 2), 1)

            SelectPostre = "-"
            TblLyutPnl = CType(Me.TableLayoutPanel2.Controls(String.Format("TblLyutPnl_{0}", Linea)), TableLayoutPanel)
            controlLabel_E = CType(TblLyutPnl.Controls(String.Format("Lbl_P_A{0}", Linea)), Label)
            controlLabel_F = CType(TblLyutPnl.Controls(String.Format("Lbl_P_B{0}", Linea)), Label)
            controlLabel_G = CType(TblLyutPnl.Controls(String.Format("Lbl_P_C{0}", Linea)), Label)
            controlLabel_H = CType(TblLyutPnl.Controls(String.Format("Lbl_P_D{0}", Linea)), Label)
            If Not controlLabel_E.Image Is Nothing Then SelectPostre = VBLeft(VBRight(controlLabel_E.Name.ToString, 2), 1)
            If Not controlLabel_F.Image Is Nothing Then SelectPostre = VBLeft(VBRight(controlLabel_F.Name.ToString, 2), 1)
            If Not controlLabel_G.Image Is Nothing Then SelectPostre = VBLeft(VBRight(controlLabel_G.Name.ToString, 2), 1)
            If Not controlLabel_H.Image Is Nothing Then SelectPostre = VBLeft(VBRight(controlLabel_H.Name.ToString, 2), 1)

            If (MDIParent1.RevisaAcceso(30001) And vDateAct <= Date.Now) Then
                If (SelectAlmuerzo = "-") Then SelectAlmuerzo = "N"
            End If

            cmd = New SqlCommand("Colaciones_Solicitudes_Ges", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            conexion.Open()
            cmd.Parameters.Add(New SqlParameter("@Rut", gRut)) ' MDIParent1.Lbl_RutTrab.Text))
            cmd.Parameters.Add(New SqlParameter("@cod_interno", MDIParent1.Lbl_Cod_Interno.Text))
            cmd.Parameters.Add(New SqlParameter("@Fecha_Graba", Date.Now.ToString("yyyyMMdd")))
            cmd.Parameters.Add(New SqlParameter("@Fecha_Solicitud", FechaIni.ToString("yyyyMMdd")))
            cmd.Parameters.Add(New SqlParameter("@Almuerzo", SelectAlmuerzo))
            cmd.Parameters.Add(New SqlParameter("@Postre", SelectPostre))
            cmd.Parameters.Add(New SqlParameter("@Id_RutEmpresa", MDIParent1.Lbl_RutEmpresa.Text))
            Try
                dt.Reset()
                dt.Load(cmd.ExecuteReader())
            Catch ex As Exception
                Errores = Errores + " | Fecha = " + FechaIni.ToString("yyyyMMdd")
            Finally
                conexion.Close()
            End Try
            FechaIni = DateAdd("d", 1, FechaIni)
        Next
        If Errores <> "" Then
            MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.Red
            MDIParent1.TlStrpSttsLbl_SQL.Text = Errores
        Else
            MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.FromArgb(85, 170, 74)
            MDIParent1.TlStrpSttsLbl_SQL.Text = "Almuerzos Registrados"
        End If
        'If Month(vDateInfo) = Month(Date.Now) Then
        '    MsgBox("Recuerde  : " & vbCrLf & vbCrLf &
        '    "    Para aquellos colaboradores que por algún motivo no seleccionen " & vbCrLf &
        '    "el almuerzo mensual y lo hagan sólo esporádicamente en forma diaria, " & vbCrLf &
        '    "ya no se contará con la opción de escoger su  preferencia, sino que  " & vbCrLf &
        '    "la alternativa preparada dependerá  del stock disponible del " & vbCrLf &
        '    "proveedor del casino " & vbCrLf & vbCrLf &
        '    "Comunicado de fecha 27 de mayo del 2016", MsgBoxStyle.Exclamation, "Advertencia")
        'End If
    End Sub

    Private Function VBRight(v1 As String, v2 As Integer) As String
        Return Microsoft.VisualBasic.Right(v1, v2)
    End Function

    Private Function VBLeft(v1 As String, v2 As Integer) As String
        Return Microsoft.VisualBasic.Left(v1, v2)
    End Function

    Private Sub Frm_SolicitudColacion_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick

    End Sub

    Private Sub txbTrabajador_TextChanged(sender As Object, e As EventArgs) Handles txbTrabajador.TextChanged
        dt = BuscarDatosTrabajador(txbTrabajador.Text)
        'MDIParent1.TxtBx_Empresa.Text = dt.Rows(0)("nombre_emp").ToString()
        'MDIParent1.TxtBx_UserName.Text = txbTrabajador.Text
        'MDIParent1.Lbl_RutTrab.Text = dt.Rows(0)("rut").ToString()
        'MDIParent1.Lbl_Cod_Interno.Text = ""

        txbRut.Text = dt.Rows(0)("rut").ToString()
        gRut = dt.Rows(0)("rut").ToString()
        txbCargo.Text = dt.Rows(0)("cargo").ToString()
        txbEmpresa.Text = dt.Rows(0)("nombre_emp").ToString()

        Try
            txbFechaIngreso.Text = Date.Parse(dt.Rows(0)("fecha_ingreso")).ToString("dd-MM-yyyy")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txbTrabajador_MouseCaptureChanged(sender As Object, e As EventArgs) Handles txbTrabajador.MouseCaptureChanged

    End Sub

    Private Sub txbRut_ModifiedChanged(sender As Object, e As EventArgs) Handles txbRut.ModifiedChanged
        LLenarFechasAlmuerzos(vDateIni)
        CargarMenuAlmuerzos(vDateIni)
        HabilitarDiasAcceso(vDateIni)
    End Sub

    Private Sub txbTrabajador_Validated(sender As Object, e As EventArgs) Handles txbTrabajador.Validated
        LLenarFechasAlmuerzos(vDateIni)
        CargarMenuAlmuerzos(vDateIni)
        HabilitarDiasAcceso(vDateIni)
    End Sub

    Private Sub txbTrabajador_ModifiedChanged(sender As Object, e As EventArgs) Handles txbTrabajador.ModifiedChanged

    End Sub

    ''' <summary>
    '''  FUNCIONES Y PROCEDIMIENTOS
    ''' </summary>
    Private Sub Iniciar_Form_Almuerzos()

        conexion.ConnectionString = Conection.Cn
        'MDIParent1.Panel2.Visible = False
        Dim ctl As Control
        For Each ctl In Me.Controls
            AddHandler ctl.KeyDown, AddressOf myEventHandler
        Next
        Me.WindowState = FormWindowState.Maximized
        '--------------------------------------------------
        vDateAct = FormatDateTime(DateSerial(Year(Date.Now), Month(Date.Now), DateAndTime.Day(Date.Now)), DateFormat.LongDate) + " 09:00"
        vDateIni = vDateAct.AddDays(1 - Convert.ToDouble(vDateAct.DayOfWeek))   'Lunes de la Semana
        vDateFin = vDateAct.AddDays(7 - Convert.ToDouble(vDateAct.DayOfWeek))   'Domingo de la semana
        tb_FechaIni.Text = vDateIni.ToString("yyyyMMdd")

        FechaDBServer = FechaServidorSAP()
        lbl_FechaDB.Text = FechaServidorSAP().ToShortDateString()

        If Not MDIParent1.RevisaAcceso(30001) Then
            Pnl_Modf.Visible = False
            'TableLayoutPanel2.Top = 50
        Else
            Pnl_Modf.Visible = True
            'TableLayoutPanel2.Top = 70

            txbTrabajador.AutoCompleteCustomSource = listaAutocompletadaTrabajadores()
            txbTrabajador.Text = MDIParent1.TxtBx_UserName.Text
            gRut = MDIParent1.Lbl_RutTrab.Text
        End If

        'lbl_Fecha.ForeColor = Drawing.Color.Blue
        LLenarFechasAlmuerzos(vDateIni)
        CargarMenuAlmuerzos(vDateIni)
        'Verificar Accesos (Bloquear/Habilitar Dias)
        HabilitarDiasAcceso(vDateIni)
        VisiblePostres(False)

    End Sub

    Private Function FechaServidorSAP() As Date

        Dim fecha As Date = Date.Now.Date

        cmd = New SqlCommand("[FechaHora_DBServer]", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        Try
            dt.Reset()
            dt.Load(cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try

        If (dt.Rows.Count > 0) Then
            fecha = Convert.ToDateTime(dt.Rows(0)("FechaActual"))
        End If

        Return fecha

    End Function

    Private Function listaAutocompletadaTrabajadores() As AutoCompleteStringCollection
        Dim lista As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        conexion.Open()
        Try
            cmd = New SqlCommand("Solicitud_Empleados_Sugeridos", conexion)
            cmd.Parameters.Add(New SqlParameter("@Fecha_SolicitudIni", tb_FechaIni.Text))
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add(New SqlParameter("@area", area))
            Dim adapter As New SqlDataAdapter(cmd)
            dt = New DataTable()
            adapter.Fill(dt)
            For i = 0 To dt.Rows.Count - 1
                lista.Add(dt.Rows(i)("nombre").ToString)
            Next
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("error: " + ex.Message, MsgBoxStyle.Exclamation, "Area Invalida")
        Finally
            conexion.Close()
        End Try
        Return lista
    End Function

    Private Function BuscarDatosTrabajador(ByVal nombre) As DataTable
        Dim tabla As DataTable = New DataTable()
        conexion.Open()
        Try
            Dim comand As SqlCommand = New SqlCommand("Solicitud_Buscar_Datos_Trabajador", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.Add(New SqlParameter("@nombreCompleto", nombre))
            Dim adapter As New SqlDataAdapter(comand)
            adapter.Fill(tabla)
            'rut = dt.Rows(0)("rut").ToString()
            comand.Dispose()
        Catch ex As Exception

        Finally
            conexion.Close()
        End Try
        Return tabla
    End Function

    Private Sub CargarSolicitudesAlmuerzos(DateInfo As DateTime)

        Dim Errores As String = ""
        Dim FechaIni As Date = DateInfo
        Dim esFeriado, esLeche, EsAlmuerzo As Boolean
        Dim ModoAlmu As String = ""

        For Linea = 1 To 5
            esFeriado = ConsultaDiaFeriado(FechaIni)
            esLeche = ConsultaDiaLeche(FechaIni)
            EsAlmuerzo = IIf(esFeriado Or esLeche, False, True)

            If (EsAlmuerzo) Then
                cmd = New SqlCommand("[Colaciones_Empleados_Tipos_Listar_RUT]", conexion)
                cmd.CommandType = CommandType.StoredProcedure
                conexion.Open()
                cmd.Parameters.Add(New SqlParameter("@Rut", gRut)) 'MDIParent1.Lbl_RutTrab.Text))
                Try
                    dt.Reset()
                    dt.Load(cmd.ExecuteReader())
                    ModoAlmu = dt.Rows(0)("Modo")
                Catch ex As Exception
                    Errores =
                    Errores = Errores + " | Fecha = " + FechaIni.ToString("yyyyMMdd")
                Finally
                    conexion.Close()
                End Try

                cmd = New SqlCommand("Colaciones_Solicitudes_Info", conexion)
                cmd.CommandType = CommandType.StoredProcedure
                conexion.Open()
                cmd.Parameters.Add(New SqlParameter("@Rut", gRut)) 'MDIParent1.Lbl_RutTrab.Text))
                cmd.Parameters.Add(New SqlParameter("@Fecha_Solicitud", FechaIni.ToString("yyyyMMdd")))
                Try
                    dt.Reset()
                    dt.Load(cmd.ExecuteReader())
                Catch ex As Exception
                    Errores =
                    Errores = Errores + " | Fecha = " + FechaIni.ToString("yyyyMMdd")
                Finally
                    conexion.Close()
                End Try

                Dim controlLabel_A, controlLabel_B, controlLabel_C, controlLabel_D As Label
                Dim TblLyutPnl As TableLayoutPanel
                Dim controlLabel_E, controlLabel_F, controlLabel_G, controlLabel_H As Label

                controlLabel_A = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_A{0}", Linea)), Label)
                controlLabel_B = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_B{0}", Linea)), Label)
                controlLabel_C = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_C{0}", Linea)), Label)
                controlLabel_D = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_D{0}", Linea)), Label)

                TblLyutPnl = CType(Me.TableLayoutPanel2.Controls(String.Format("TblLyutPnl_{0}", Linea)), TableLayoutPanel)
                controlLabel_E = CType(TblLyutPnl.Controls(String.Format("Lbl_P_A{0}", Linea)), Label)
                controlLabel_F = CType(TblLyutPnl.Controls(String.Format("Lbl_P_B{0}", Linea)), Label)
                controlLabel_G = CType(TblLyutPnl.Controls(String.Format("Lbl_P_C{0}", Linea)), Label)
                controlLabel_H = CType(TblLyutPnl.Controls(String.Format("Lbl_P_D{0}", Linea)), Label)

                Dim LblAlumerzos() As Label = {controlLabel_A, controlLabel_B, controlLabel_C, controlLabel_D,
                                               controlLabel_E, controlLabel_F, controlLabel_G, controlLabel_H}

                If dt.Rows(0)("IdEstado") = 0 Then
                    If dt.Rows(0)("Almuerzo") = "A" Then SeleccionarLabelAlmuerzo(controlLabel_A) Else InicializarLabelAlmuerzo(controlLabel_A)
                    If dt.Rows(0)("Almuerzo") = "B" Then SeleccionarLabelAlmuerzo(controlLabel_B) Else InicializarLabelAlmuerzo(controlLabel_B)
                    If dt.Rows(0)("Almuerzo") = "C" Then SeleccionarLabelAlmuerzo(controlLabel_C) Else InicializarLabelAlmuerzo(controlLabel_C)
                    If dt.Rows(0)("Almuerzo") = "D" Then SeleccionarLabelAlmuerzo(controlLabel_D) Else InicializarLabelAlmuerzo(controlLabel_D)

                    If dt.Rows(0)("Postre") = "A" Then SeleccionarLabelAlmuerzo(controlLabel_E) Else InicializarLabelAlmuerzo(controlLabel_E)
                    If dt.Rows(0)("Postre") = "B" Then SeleccionarLabelAlmuerzo(controlLabel_F) Else InicializarLabelAlmuerzo(controlLabel_F)
                    If dt.Rows(0)("Postre") = "C" Then SeleccionarLabelAlmuerzo(controlLabel_G) Else InicializarLabelAlmuerzo(controlLabel_G)
                    If dt.Rows(0)("Postre") = "D" Then SeleccionarLabelAlmuerzo(controlLabel_H) Else InicializarLabelAlmuerzo(controlLabel_H)
                Else
                    For Each LblAlmu As Label In LblAlumerzos
                        InicializarLabelAlmuerzo(LblAlmu)
                    Next
                    If (ModoAlmu.Trim = "LV" Or ModoAlmu.Trim = "LJ") Then SeleccionarLabelAlmuerzo(controlLabel_D) Else InicializarLabelAlmuerzo(controlLabel_D)
                End If
            End If
            FechaIni = DateAdd("d", 1, FechaIni)
        Next
    End Sub

    Sub LLenarFechasAlmuerzos(DateInfo As Date)

        Dim LabelFecha() As Label = {Lbl_01, Lbl_02, Lbl_03, Lbl_04, Lbl_05}
        ' Incializar Lbl_01 - Lbl_05
        For Each LblFecha As Label In LabelFecha
            LblFecha.Text = ""
        Next


        Dim FechaIni As Date = DateInfo
        Dim FechaFin As Date = DateAdd("d", 7 - 1, DateInfo)
        lbl_Fecha.Text = (FormatDateTime(DateSerial(Year(FechaIni), Month(FechaIni), DateAndTime.Day(FechaIni)), DateFormat.LongDate) +
                         Space(2) +
                         "hasta el" +
                         Space(2) +
                         FormatDateTime(DateSerial(Year(FechaFin), Month(FechaFin), DateAndTime.Day(FechaFin)), DateFormat.LongDate)).ToUpper()

        'Coloca dias Lbl_01 - Lbl_05
        For Each LblFecha As Label In LabelFecha
            LblFecha.Text = FormatDateTime(DateSerial(Year(DateInfo), Month(DateInfo), DateAndTime.Day(DateInfo)), DateFormat.LongDate).ToUpper
            DateInfo = DateAdd("d", 1, DateInfo)
        Next

    End Sub


    Sub HabilitarDiasAcceso(DateInfo As Date)
        Dim TblLyutPnl As TableLayoutPanel
        Dim controlLabel_A, controlLabel_B, controlLabel_C, controlLabel_D As Label
        'Dim controlLabel_PA, controlLabel_PB, controlLabel_PC, controlLabel_PD As Label

        'RECORRER TODOS LOS DIAS DE LA SEMANA Y LOS HABILITA/BLOQUEA LABELS(OPCION ALMUERZO) SEGUN ACCESO Y CONDICION
        'DE QUE SOLO SE PUEDE SELECCIONAR UN ALMUERZO CON 2 DIAS DE ANTICIPACION
        For Linea = 1 To 5
            TblLyutPnl = CType(Me.TableLayoutPanel2.Controls(String.Format("TblLyutPnl_{0}", Linea)), TableLayoutPanel)
            controlLabel_A = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_A{0}", Linea)), Label)
            controlLabel_B = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_B{0}", Linea)), Label)
            controlLabel_C = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_C{0}", Linea)), Label)
            controlLabel_D = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_D{0}", Linea)), Label)
            Dim LabelAlmuerzo() As Label = {controlLabel_A, controlLabel_B, controlLabel_C, controlLabel_D}
            'controlLabel_PA = CType(TblLyutPnl.Controls(String.Format("Lbl_P_A{0}", Linea)), Label)
            'controlLabel_PB = CType(TblLyutPnl.Controls(String.Format("Lbl_P_B{0}", Linea)), Label)
            'controlLabel_PC = CType(TblLyutPnl.Controls(String.Format("Lbl_P_C{0}", Linea)), Label)
            'controlLabel_PD = CType(TblLyutPnl.Controls(String.Format("Lbl_P_D{0}", Linea)), Label)


            If DateInfo < DateAdd("d", +1, FechaDBServer) Then 'BLOQUEAR FECHAS < HOY + 1
                For Each LblAlmu As Label In LabelAlmuerzo
                    LblAlmu.Enabled = False
                Next
            Else
                For Each LblAlmu As Label In LabelAlmuerzo
                    LblAlmu.Enabled = True
                Next
            End If
            If MDIParent1.RevisaAcceso(30001) Then
                For Each LblAlmu As Label In LabelAlmuerzo
                    LblAlmu.Enabled = True
                Next
            End If

            If (ConsultaDiaFeriado(DateInfo)) Then
                For Each LblAlmu As Label In LabelAlmuerzo
                    LblAlmu.Enabled = False
                Next
            End If

            DateInfo = DateAdd("d", 1, DateInfo)
        Next
    End Sub

    Function ConsultaDiaFeriado(dateInfo As Date) As Boolean

        Dim esFeriado As Boolean = False

        dt.Reset()
        cmd = New SqlCommand("Feriados_Info", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd.Parameters.Add(New SqlParameter("@FechaIni", dateInfo.ToString("yyyyMMdd")))
        cmd.Parameters.Add(New SqlParameter("@FechaFin", dateInfo.ToString("yyyyMMdd")))
        Try
            dt.Load(cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try

        If (dt.Rows(0)("DiasFer") > 0) Then
            esFeriado = True
        End If

        Return esFeriado

    End Function

    Private Function ConsultaDiaLeche(fechaIni As Date) As Boolean
        Dim diaLeche As Boolean = False

        dt.Reset()
        cmd = New SqlCommand("[Colaciones_Empleados_Consultar_Fecha]", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd.Parameters.Add(New SqlParameter("@rut", gRut))
        cmd.Parameters.Add(New SqlParameter("@Fecha", fechaIni.ToString("yyyyMMdd")))
        Try
            dt.Load(cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try

        If (dt.Rows(0)("Tipo").ToString.Trim = "L") Then
            diaLeche = True
        End If

        Return diaLeche
    End Function


    Sub CargarMenuAlmuerzos(DateInfo As DateTime)
        Dim FechaIni As Date = DateInfo
        Dim esFeriado As Boolean = False
        Dim diaLeche As Boolean = False
        Dim controlLabel_Fecha, controlLabel_A, controlLabel_B, controlLabel_C, controlLabel_D As Label

        LimpiarColaciones()

        For vDiaNum As Integer = 1 To 5

            If ConsultaDiaFeriado(FechaIni) Then
                CargarDTFeriado(dt)
                esFeriado = True
            ElseIf (ConsultaDiaLeche(FechaIni)) Then
                CargarDTLeche(dt)
                diaLeche = True
            Else
                CargarDTAlmuerzos(dt, FechaIni)
            End If

            controlLabel_A = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_A{0}", vDiaNum)), Label)
            controlLabel_B = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_B{0}", vDiaNum)), Label)
            controlLabel_C = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_C{0}", vDiaNum)), Label)
            controlLabel_D = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_D{0}", vDiaNum)), Label)
            controlLabel_Fecha = CType(Me.TableLayoutPanel2.Controls(String.Format("Lbl_0{0}", vDiaNum)), Label)
            Dim LabelAlmuerzo() As Label = {controlLabel_A, controlLabel_B, controlLabel_C, controlLabel_D}

            If (dt.Rows(0)("IdEstado") = 0 Or esFeriado Or diaLeche) Then

                'controlLabel_A.Text = dt.Rows(0)("Almuerzo_A")
                'controlLabel_B.Text = dt.Rows(0)("Almuerzo_B")
                'controlLabel_C.Text = dt.Rows(0)("Almuerzo_C")
                'controlLabel_D.Text = IIf(esFeriado Or diaLeche, dt.Rows(0)("Almuerzo_D"), "VALE CASINO")

                If (esFeriado) Then
                    AsignarDiaFeriado(LabelAlmuerzo)
                    controlLabel_Fecha.BackColor = Color.FromArgb(149, 149, 149)
                ElseIf (diaLeche) Then
                    AsignarDiaLeche(LabelAlmuerzo)
                    controlLabel_Fecha.BackColor = Color.FromArgb(0, 174, 219)
                Else
                    AsignarDiaAlmuerzo(LabelAlmuerzo)
                    controlLabel_Fecha.BackColor = Color.FromArgb(45, 137, 239)
                End If

                esFeriado = False
                diaLeche = False
                'If vDiaNum = 1 Then
                '    Lbl_A1.Text = dt.Rows(0)("Almuerzo_A")
                '    Lbl_B1.Text = dt.Rows(0)("Almuerzo_B")
                '    Lbl_C1.Text = dt.Rows(0)("Almuerzo_C")
                '    'Lbl_D1.Text = dt.Rows(0)("Almuerzo_D")
                '    'Lbl_P_A1.Text = dt.Rows(0)("Postre_A")
                '    'Lbl_P_B1.Text = dt.Rows(0)("Postre_B")
                '    'Lbl_P_C1.Text = dt.Rows(0)("Postre_C")
                '    'Lbl_P_D1.Text = dt.Rows(0)("Postre_D")
                'End If
            Else
                controlLabel_A.Text = ""
                controlLabel_B.Text = ""
                controlLabel_C.Text = ""
                controlLabel_D.Text = "VALE CASINO"
                controlLabel_Fecha.BackColor = Color.FromArgb(45, 137, 239)
            End If
            FechaIni = DateAdd("d", 1, FechaIni)
        Next
        CargarSolicitudesAlmuerzos(vDateIni)
    End Sub

    Private Sub CargarDTFeriado(dt As DataTable)
        Try
            dt.Reset()
            dt.Columns.Add("Almuerzo_A", GetType(String))
            dt.Columns.Add("Almuerzo_B", GetType(String))
            dt.Columns.Add("Almuerzo_C", GetType(String))
            dt.Columns.Add("Almuerzo_D", GetType(String))
            dt.Columns.Add("IdEstado", GetType(Integer))

            dt.Rows.Add("FERIADO", "FERIADO", "FERIADO", "FERIADO", 0)
        Catch
        End Try
    End Sub

    Private Sub CargarDTLeche(dt As DataTable)
        Try
            dt.Reset()
            dt.Columns.Add("Almuerzo_A", GetType(String))
            dt.Columns.Add("Almuerzo_B", GetType(String))
            dt.Columns.Add("Almuerzo_C", GetType(String))
            dt.Columns.Add("Almuerzo_D", GetType(String))
            dt.Columns.Add("IdEstado", GetType(Integer))

            dt.Rows.Add("LECHE", "LECHE", "LECHE", "LECHE", 0)
        Catch
        End Try
    End Sub

    Private Sub CargarDTAlmuerzos(dt As DataTable, Fecha As DateTime)

        cmd = New SqlCommand("Colaciones_Info", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd.Parameters.Add(New SqlParameter("@FechaIni", Fecha.ToString("yyyyMMdd")))
        Try
            dt.Reset()
            dt.Load(cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub AsignarDiaLeche(LabelDia As Label())
        Dim Menu As String() = {"Almuerzo_A", "Almuerzo_B", "Almuerzo_C", "Almuerzo_D"}
        Dim index As Int16 = 0

        For Each LblAlmu As Label In LabelDia
            LblAlmu.Text = dt.Rows(0)(Menu(index)).ToString.Trim.ToUpper()
            If (index = 3) Then SeleccionarLabelLeche(LblAlmu, True) Else SeleccionarLabelLeche(LblAlmu, False)
            index += 1
        Next
    End Sub

    Private Sub AsignarDiaFeriado(LabelDia As Label())
        Dim Menu As String() = {"Almuerzo_A", "Almuerzo_B", "Almuerzo_C", "Almuerzo_D"}
        Dim index As Int16 = 0

        For Each LblAlmu As Label In LabelDia
            InicializarLabelAlmuerzo(LblAlmu)
            LblAlmu.Text = dt.Rows(0)(Menu(index)).ToString.Trim.ToUpper()
            index += 1
        Next
    End Sub

    Private Sub AsignarDiaAlmuerzo(LabelDia As Label())
        Dim Menu As String() = {"Almuerzo_A", "Almuerzo_B", "Almuerzo_C", "Almuerzo_D"}
        Dim index As Int16 = 0

        For Each LblAlmu As Label In LabelDia
            InicializarLabelAlmuerzo(LblAlmu)
            LblAlmu.Text = dt.Rows(0)(Menu(index)).ToString.Trim.ToUpper()
            index += 1
        Next
    End Sub

    Private Sub SeleccionarLabelLeche(ControlLabel As Label, CargaImagen As Boolean)

        If (CargaImagen) Then ControlLabel.Image = Global.RRHH.My.Resources.Resources.milk_box
        ControlLabel.BackColor = Color.FromArgb(0, 174, 219)
        ControlLabel.ForeColor = Color.White

    End Sub

    Private Sub SeleccionarLabelFeriado(ControlLabel As Label)

        ControlLabel.Image = Global.RRHH.My.Resources.Resources.milk_box
        ControlLabel.BackColor = Color.FromArgb(0, 174, 219)
        ControlLabel.ForeColor = Color.White

    End Sub

    Private Sub SeleccionarLabelAlmuerzo(ControlLabel As Label)

        ControlLabel.Image = Global.RRHH.My.Resources.Resources.check_mark_white
        ControlLabel.BackColor = Color.FromArgb(153, 180, 51)
        ControlLabel.ForeColor = Color.White

    End Sub

    Private Sub InicializarLabelAlmuerzo(ControlLabel As Label)

        ControlLabel.Image = Nothing
        ControlLabel.BackColor = BackColorAlmuerzo
        ControlLabel.ForeColor = Color.Black

    End Sub

    Sub LimpiarColaciones()

        Me.SuspendLayout()

        Dim LabelAlmuerzo() As Label = {Lbl_A1, Lbl_A2, Lbl_A3, Lbl_A4, Lbl_A5,
                                        Lbl_B1, Lbl_B2, Lbl_B3, Lbl_B4, Lbl_B5,
                                        Lbl_C1, Lbl_C2, Lbl_C3, Lbl_C4, Lbl_C5}

        For Each LblAlmu As Label In LabelAlmuerzo
            LblAlmu.Text = ""
            InicializarLabelAlmuerzo(LblAlmu)
        Next

        Me.ResumeLayout()
        'Lbl_D1.Text = ""
        'Lbl_P_A1.Text = ""
        'Lbl_P_B1.Text = ""
        'Lbl_P_C1.Text = ""
        'Lbl_P_D1.Text = ""

    End Sub

    Private Sub VisiblePostres(Visible As Boolean)
        Dim LabelPostres() As Label = {Lbl_P_B1, Lbl_P_B2, Lbl_P_B3, Lbl_P_B4, Lbl_P_B5,
                                       Lbl_P_C1, Lbl_P_C2, Lbl_P_C3, Lbl_P_C4, Lbl_P_C5,
                                       Lbl_P_D1, Lbl_P_D2, Lbl_P_D3, Lbl_P_D4, Lbl_P_D5}

        For Each LblAlmu As Label In LabelPostres
            LblAlmu.Visible = Visible
        Next

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter, PictureBox1.MouseEnter
        CType(sender, PictureBox).BackColor = Color.FromArgb(255, 194, 31)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave, PictureBox1.MouseLeave
        CType(sender, PictureBox).BackColor = Color.FromArgb(227, 162, 26)
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    If Month(vDateInfo) = Month(Date.Now) Then
    '        MsgBox("Recuerde  : " & vbCrLf & vbCrLf &
    '        "    Para aquellos colaboradores que por algún motivo no seleccionen " & vbCrLf &
    '        "el almuerzo mensual y lo hagan sólo esporádicamente en forma diaria, " & vbCrLf &
    '        "ya no se contará con la opción de escoger su  preferencia, sino que  " & vbCrLf &
    '        "la alternativa preparada dependerá  del stock disponible del " & vbCrLf &
    '        "proveedor del casino " & vbCrLf & vbCrLf &
    '        "Comunicado de fecha 27 de mayo del 2016", MsgBoxStyle.Exclamation, "Advertencia")
    '    End If
    'End Sub

    'Function RevisaAcceso(Campo As String) As Boolean
    '    dt.Reset()
    '    cmd = New SqlCommand("Colaciones_Pass_Info", conexion)
    '    cmd.CommandType = CommandType.StoredProcedure
    '    conexion.Open()
    '    cmd.Parameters.Add(New SqlParameter("@Rut", MDIParent1.Lbl_RutTrab.Text))

    '    cmd.Parameters.Add(New SqlParameter("@Campo", Campo))
    '    Try
    '        dt.Load(cmd.ExecuteReader())
    '    Catch ex As Exception

    '        MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
    '    Finally
    '        conexion.Close()
    '    End Try
    '    If dt.Rows(0)("IdEstado") = 0 Then
    '        Return dt.Rows(0)("Acceso")
    '    Else
    '        Return 0
    '    End If
    'End Function


    Private Sub DoTheTimer() Handles timer.Tick

        If time <> maxTime Then
            panelAntiguo.Left += sentido * DESPLAZAMIENTO
            TableLayoutPanel2.Left += sentido * DESPLAZAMIENTO
            time += 1
        Else
            TableLayoutPanel2.Location = originalPos
            panelAntiguo.Dispose()
            bitmap.Dispose()
            clickPictureBoxActivo = True
            timer.Stop()
        End If

    End Sub

    Private Sub CrearListaControles()

        Dim LstControl() As Control = {Lbl_A1, Lbl_A2, Lbl_A3, Lbl_A4, Lbl_A5,
                                        Lbl_B1, Lbl_B2, Lbl_B3, Lbl_B4, Lbl_B5,
                                        Lbl_C1, Lbl_C2, Lbl_C3, Lbl_C4, Lbl_C5,
                                        Lbl_D1, Lbl_D2, Lbl_D3, Lbl_D4, Lbl_D5,
                                        Lbl_01, Lbl_02, Lbl_03, Lbl_04, Lbl_05,
                                        TblLyutPnl_1, TblLyutPnl_2, TblLyutPnl_3, TblLyutPnl_4, TblLyutPnl_5}

        For Each cltControl As Control In LstControl
            listaControl.Add(cltControl)
        Next

    End Sub

    Private Sub SuspendDrawing()
        SendMessage(Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero)
    End Sub

    Private Sub ResumeDrawing()
        SendMessage(Handle, WM_SETREDRAW, New IntPtr(1), IntPtr.Zero)
    End Sub

End Class
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Frm_SolicitudColacion

    Property vDateInfo As DateTime
    Property dt As New DataTable
    Property conexion As New SqlConnection
    Property cmd As SqlCommand
    Property gRut As String = MDIParent1.Lbl_RutTrab.Text
    Property ImagenAlmuerzo As Image = Global.RRHH.My.Resources.Resources.check_mark_white
    Property BackColorAlmuerzo As Color = Color.White

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

    Private Sub Frm_SolicitudColacion_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.SuspendLayout()

        Iniciar_Form_Almuerzos()


        Me.ResumeLayout()
        timer = New Timer()
        timer.Interval = 30
        listaControl = New List(Of Control)
        makeList()
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
        RaiseEvent EnviarEvento()
        Me.Close()
        MDIParent1.TiempoIngreso.Enabled = True
    End Sub

    Private Sub Almuerzos_Click(sender As Object, e As EventArgs) Handles Lbl_A1.Click, Lbl_D1.Click, Lbl_C1.Click, Lbl_B1.Click, Lbl_B2.Click, Lbl_A2.Click, Lbl_D5.Click, Lbl_A5.Click, Lbl_B5.Click, Lbl_C5.Click, Lbl_D4.Click, Lbl_A4.Click, Lbl_B4.Click, Lbl_C4.Click, Lbl_D3.Click, Lbl_C3.Click, Lbl_B3.Click, Lbl_A3.Click, Lbl_C2.Click, Lbl_D2.Click
        'If sender.text = "" Then
        '    MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.Red
        '    MDIParent1.TlStrpSttsLbl_SQL.Text = "No existe descripción de Almuerzo.... No es posible su seleción"
        '    Beep()
        '    Exit Sub
        'End If
        Dim controlLabel_A, controlLabel_B, controlLabel_C, controlLabel_D As Label
        Dim Linea As String = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
        Dim str_a As String = String.Format("Lbl_A{0}", Linea)
        Dim str_b As String = String.Format("Lbl_B{0}", Linea)
        Dim str_c As String = String.Format("Lbl_C{0}", Linea)
        Dim str_d As String = String.Format("Lbl_D{0}", Linea)
        controlLabel_A = CType(Me.TableLayoutPanel2.Controls(str_a), Label)
        controlLabel_B = CType(Me.TableLayoutPanel2.Controls(str_b), Label)
        controlLabel_C = CType(Me.TableLayoutPanel2.Controls(str_c), Label)
        controlLabel_D = CType(Me.TableLayoutPanel2.Controls(str_d), Label)
        If sender.name <> controlLabel_A.Name.ToString Then Inicializar_Label_Almuerzo(controlLabel_A)
        If sender.name <> controlLabel_B.Name.ToString Then Inicializar_Label_Almuerzo(controlLabel_B)
        If sender.name <> controlLabel_C.Name.ToString Then Inicializar_Label_Almuerzo(controlLabel_C)
        If sender.name <> controlLabel_D.Name.ToString Then Inicializar_Label_Almuerzo(controlLabel_D)

        If sender.Image Is Nothing Then
            Seleccionar_Label_Almuerzo(CType(sender, Label))
        Else
            Inicializar_Label_Almuerzo(CType(sender, Label))
            'Borrar Postres
            Dim TblLyutPnl As TableLayoutPanel
            Dim controlLabel_E, controlLabel_F, controlLabel_G, controlLabel_H As Label
            'Dim Linea As String = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
            Dim str_T As String = String.Format("TblLyutPnl_{0}", Linea)
            Dim str_e As String = String.Format("Lbl_P_A{0}", Linea)
            Dim str_f As String = String.Format("Lbl_P_B{0}", Linea)
            Dim str_g As String = String.Format("Lbl_P_C{0}", Linea)
            Dim str_h As String = String.Format("Lbl_P_D{0}", Linea)
            TblLyutPnl = CType(Me.TableLayoutPanel2.Controls(str_T), TableLayoutPanel)
            controlLabel_E = CType(TblLyutPnl.Controls(str_e), Label)
            controlLabel_F = CType(TblLyutPnl.Controls(str_f), Label)
            controlLabel_G = CType(TblLyutPnl.Controls(str_g), Label)
            controlLabel_H = CType(TblLyutPnl.Controls(str_h), Label)
            If sender.name <> controlLabel_E.Name.ToString Then Inicializar_Label_Almuerzo(controlLabel_E)
            If sender.name <> controlLabel_F.Name.ToString Then Inicializar_Label_Almuerzo(controlLabel_F)
            If sender.name <> controlLabel_G.Name.ToString Then Inicializar_Label_Almuerzo(controlLabel_G)
            If sender.name <> controlLabel_H.Name.ToString Then Inicializar_Label_Almuerzo(controlLabel_H)
        End If

        MDIParent1.TiempoActivo = MDIParent1.Tiempo_Str
        MDIParent1.ToolStripProgressBar1.ProgressBar.Value = MDIParent1.TiempoActivo
    End Sub

    Private Sub Seleccionar_Label_Almuerzo(ControlLabel As Label)

        ControlLabel.Image = Global.RRHH.My.Resources.Resources.check_mark_white
        ControlLabel.BackColor = Color.FromArgb(153, 180, 51)
        ControlLabel.ForeColor = Color.White

    End Sub

    Private Sub Inicializar_Label_Almuerzo(ControlLabel As Label)

        ControlLabel.Image = Nothing
        ControlLabel.BackColor = BackColorAlmuerzo
        ControlLabel.ForeColor = Color.Black

    End Sub

    Private Sub Postres_Click(sender As Object, e As EventArgs) Handles Lbl_P_A1.Click, Lbl_P_D1.Click, Lbl_P_C1.Click, Lbl_P_B1.Click, Lbl_P_D5.Click, Lbl_P_D4.Click, Lbl_P_D3.Click, Lbl_P_D2.Click, Lbl_P_C5.Click, Lbl_P_C4.Click, Lbl_P_C3.Click, Lbl_P_C2.Click, Lbl_P_B5.Click, Lbl_P_B4.Click, Lbl_P_B3.Click, Lbl_P_B2.Click, Lbl_P_A5.Click, Lbl_P_A4.Click, Lbl_P_A3.Click, Lbl_P_A2.Click
        'If sender.text = "" Then
        '    MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.Red
        '    MDIParent1.TlStrpSttsLbl_SQL.Text = "No existe descripción de Postre.... No es posible su seleción"
        '    Beep()
        '    Exit Sub
        'End If
        'Revisar si esta seleccionado un almuerzo
        Dim controlLabel_A, controlLabel_B, controlLabel_C, controlLabel_D As Label
        Dim Linea As String = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
        Dim str_a As String = String.Format("Lbl_A{0}", Linea)
        Dim str_b As String = String.Format("Lbl_B{0}", Linea)
        Dim str_c As String = String.Format("Lbl_C{0}", Linea)
        Dim str_d As String = String.Format("Lbl_D{0}", Linea)
        controlLabel_A = CType(Me.TableLayoutPanel2.Controls(str_a), Label)
        controlLabel_B = CType(Me.TableLayoutPanel2.Controls(str_b), Label)
        controlLabel_C = CType(Me.TableLayoutPanel2.Controls(str_c), Label)
        controlLabel_D = CType(Me.TableLayoutPanel2.Controls(str_d), Label)
        If IsNothing(controlLabel_A.Image) And IsNothing(controlLabel_B.Image) And IsNothing(controlLabel_C.Image) And IsNothing(controlLabel_D.Image) Then
            Beep()
            Exit Sub
        End If
        'Fin ............Revisar si esta seleccionado un almuerzo

        Dim TblLyutPnl As TableLayoutPanel
        Dim controlLabel_E, controlLabel_F, controlLabel_G, controlLabel_H As Label
        'Dim Linea As String = Microsoft.VisualBasic.Right(sender.name.ToString, 1)
        Dim str_T As String = String.Format("TblLyutPnl_{0}", Linea)
        Dim str_e As String = String.Format("Lbl_P_A{0}", Linea)
        Dim str_f As String = String.Format("Lbl_P_B{0}", Linea)
        Dim str_g As String = String.Format("Lbl_P_C{0}", Linea)
        Dim str_h As String = String.Format("Lbl_P_D{0}", Linea)
        TblLyutPnl = CType(Me.TableLayoutPanel2.Controls(str_T), TableLayoutPanel)
        controlLabel_E = CType(TblLyutPnl.Controls(str_e), Label)
        controlLabel_F = CType(TblLyutPnl.Controls(str_f), Label)
        controlLabel_G = CType(TblLyutPnl.Controls(str_g), Label)
        controlLabel_H = CType(TblLyutPnl.Controls(str_h), Label)
        If sender.name <> controlLabel_E.Name.ToString Then Inicializar_Label_Almuerzo(controlLabel_E)
        If sender.name <> controlLabel_F.Name.ToString Then Inicializar_Label_Almuerzo(controlLabel_F)
        If sender.name <> controlLabel_G.Name.ToString Then Inicializar_Label_Almuerzo(controlLabel_G)
        If sender.name <> controlLabel_H.Name.ToString Then Inicializar_Label_Almuerzo(controlLabel_H)
        If sender.Image Is Nothing Then
            Seleccionar_Label_Almuerzo(CType(sender, Label))
        Else
            sender.Image = Nothing
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If clickPictureBoxActivo Then
            clickPictureBoxActivo = False
            Me.SuspendLayout()
            vDateInfo = DateAdd("d", -7, vDateInfo)
            tb_FechaIni.Text = vDateInfo.ToString("yyyyMMdd")
            txbTrabajador.AutoCompleteCustomSource.Clear()
            txbTrabajador.AutoCompleteCustomSource = listaAutocompletadaTrabajadores()

            LLenaFechasColaciones(vDateInfo)
            CargarColaciones(vDateInfo)

            MDIParent1.TiempoActivo = MDIParent1.Tiempo_Str
            MDIParent1.ToolStripProgressBar1.ProgressBar.Value = MDIParent1.TiempoActivo

            sentido = 1
            generarMove()

            Me.ResumeLayout()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If clickPictureBoxActivo Then
            clickPictureBoxActivo = False
            Me.SuspendLayout()
            vDateInfo = DateAdd("d", 7, vDateInfo)
            tb_FechaIni.Text = vDateInfo.ToString("yyyyMMdd")
            txbTrabajador.AutoCompleteCustomSource.Clear()
            txbTrabajador.AutoCompleteCustomSource = listaAutocompletadaTrabajadores()

            LLenaFechasColaciones(vDateInfo)
            CargarColaciones(vDateInfo)

            MDIParent1.TiempoActivo = MDIParent1.Tiempo_Str
            MDIParent1.ToolStripProgressBar1.ProgressBar.Value = MDIParent1.TiempoActivo

            sentido = -1
            generarMove()
            Me.ResumeLayout()
        End If
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
        Dim FechaIni As Date = vDateInfo
        Dim controlLabel_A, controlLabel_B, controlLabel_C, controlLabel_D As Label
        Dim SelectAlmuerzo, SelectPostre As String
        Dim TblLyutPnl As TableLayoutPanel
        Dim controlLabel_E, controlLabel_F, controlLabel_G, controlLabel_H As Label
        For Linea = 1 To 5
            SelectAlmuerzo = "-"
            Dim str_a As String = String.Format("Lbl_A{0}", Linea)
            Dim str_b As String = String.Format("Lbl_B{0}", Linea)
            Dim str_c As String = String.Format("Lbl_C{0}", Linea)
            Dim str_d As String = String.Format("Lbl_D{0}", Linea)
            controlLabel_A = CType(Me.TableLayoutPanel2.Controls(str_a), Label)
            controlLabel_B = CType(Me.TableLayoutPanel2.Controls(str_b), Label)
            controlLabel_C = CType(Me.TableLayoutPanel2.Controls(str_c), Label)
            controlLabel_D = CType(Me.TableLayoutPanel2.Controls(str_d), Label)
            If Not controlLabel_A.Image Is Nothing Then SelectAlmuerzo = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(controlLabel_A.Name.ToString, 2), 1)
            If Not controlLabel_B.Image Is Nothing Then SelectAlmuerzo = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(controlLabel_B.Name.ToString, 2), 1)
            If Not controlLabel_C.Image Is Nothing Then SelectAlmuerzo = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(controlLabel_C.Name.ToString, 2), 1)
            If Not controlLabel_D.Image Is Nothing Then SelectAlmuerzo = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(controlLabel_D.Name.ToString, 2), 1)


            SelectPostre = "-"
            Dim str_T As String = String.Format("TblLyutPnl_{0}", Linea)
            Dim str_e As String = String.Format("Lbl_P_A{0}", Linea)
            Dim str_f As String = String.Format("Lbl_P_B{0}", Linea)
            Dim str_g As String = String.Format("Lbl_P_C{0}", Linea)
            Dim str_h As String = String.Format("Lbl_P_D{0}", Linea)
            TblLyutPnl = CType(Me.TableLayoutPanel2.Controls(str_T), TableLayoutPanel)
            controlLabel_E = CType(TblLyutPnl.Controls(str_e), Label)
            controlLabel_F = CType(TblLyutPnl.Controls(str_f), Label)
            controlLabel_G = CType(TblLyutPnl.Controls(str_g), Label)
            controlLabel_H = CType(TblLyutPnl.Controls(str_h), Label)
            If Not controlLabel_E.Image Is Nothing Then SelectPostre = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(controlLabel_E.Name.ToString, 2), 1)
            If Not controlLabel_F.Image Is Nothing Then SelectPostre = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(controlLabel_F.Name.ToString, 2), 1)
            If Not controlLabel_G.Image Is Nothing Then SelectPostre = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(controlLabel_G.Name.ToString, 2), 1)
            If Not controlLabel_H.Image Is Nothing Then SelectPostre = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Right(controlLabel_H.Name.ToString, 2), 1)
            Dim Rut As String = gRut 'MDIParent1.Lbl_RutTrab.ToString
            Dim e_cod_interno As String = MDIParent1.Lbl_Cod_Interno.ToString
            Dim e_Fecha_Graba As String = Date.Now.ToString("yyyyMMdd")
            Dim e_Fecha_Solicitu As String = vDateInfo.ToString("yyyyMMdd")
            Dim e_Almuerzo As String = SelectAlmuerzo
            Dim e_Postre As String = SelectPostre
            Dim e_Id_RutEmpresa As String = MDIParent1.Lbl_RutEmpresa.Text



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
            MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.CornflowerBlue
            MDIParent1.TlStrpSttsLbl_SQL.Text = "Grabado con exito"
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
        LLenaFechasColaciones(vDateInfo)
        CargarColaciones(vDateInfo)
    End Sub

    Private Sub txbTrabajador_Validated(sender As Object, e As EventArgs) Handles txbTrabajador.Validated
        LLenaFechasColaciones(vDateInfo)
        CargarColaciones(vDateInfo)
    End Sub

    Private Sub txbTrabajador_ModifiedChanged(sender As Object, e As EventArgs) Handles txbTrabajador.ModifiedChanged

    End Sub

    ''' <summary>
    '''  FUNCIONES Y PROCEDIMIENTOS
    ''' </summary>
    Private Sub Iniciar_Form_Almuerzos()

        conexion.ConnectionString = "Data Source=FSSAPBO;Initial Catalog = SAC_Mindugar; Persist Security Info=True;User ID = sa; Password=Sqladmin281"
        'MDIParent1.Panel2.Visible = False
        Dim ctl As Control
        For Each ctl In Me.Controls
            AddHandler ctl.KeyDown, AddressOf myEventHandler
        Next
        Me.WindowState = FormWindowState.Maximized
        '--------------------------------------------------
        vDateInfo = FormatDateTime(DateSerial(Year(Date.Now), Month(Date.Now), Microsoft.VisualBasic.DateAndTime.Day(Date.Now)), DateFormat.LongDate) + " 09:00"
        Dim vDateFin As DateTime

        Dim vDiaNum As Integer = Weekday(vDateInfo)
        'Dim vDay As Integer = Weekday(vDateInf)
        While vDiaNum <> 2
            vDateInfo = DateAdd("d", -1, vDateInfo)
            vDiaNum = Weekday(vDateInfo)
        End While
        tb_FechaIni.Text = vDateInfo.ToString("yyyyMMdd")
        vDateFin = DateAdd("d", 7 - 1, vDateInfo)

        If Not MDIParent1.RevisaAcceso(30001) Then
            Pnl_Modf.Visible = False
            'TableLayoutPanel2.Top = 50
        Else
            Pnl_Modf.Visible = True
            'TableLayoutPanel2.Top = 70

            txbTrabajador.AutoCompleteCustomSource = listaAutocompletadaTrabajadores()
            txbTrabajador.Text = MDIParent1.TxtBx_UserName.Text

        End If

        'lbl_Fecha.ForeColor = Drawing.Color.Blue
        LLenaFechasColaciones(vDateInfo)
        CargarColaciones(vDateInfo)
        VisiblePostres()

    End Sub

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

    Private Sub BuscaSolicitudes(DateInfo As DateTime)
        Dim Errores As String = ""
        Dim FechaIni As Date = DateInfo
        For Linea = 1 To 5
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
            Dim str_a As String = String.Format("Lbl_A{0}", Linea)
            Dim str_b As String = String.Format("Lbl_B{0}", Linea)
            Dim str_c As String = String.Format("Lbl_C{0}", Linea)
            Dim str_d As String = String.Format("Lbl_D{0}", Linea)

            Dim TblLyutPnl As TableLayoutPanel
            Dim controlLabel_E, controlLabel_F, controlLabel_G, controlLabel_H As Label

            Dim str_T As String = String.Format("TblLyutPnl_{0}", Linea)
            Dim str_e As String = String.Format("Lbl_P_A{0}", Linea)
            Dim str_f As String = String.Format("Lbl_P_B{0}", Linea)
            Dim str_g As String = String.Format("Lbl_P_C{0}", Linea)
            Dim str_h As String = String.Format("Lbl_P_D{0}", Linea)

            controlLabel_A = CType(Me.TableLayoutPanel2.Controls(str_a), Label)
            controlLabel_B = CType(Me.TableLayoutPanel2.Controls(str_b), Label)
            controlLabel_C = CType(Me.TableLayoutPanel2.Controls(str_c), Label)
            controlLabel_D = CType(Me.TableLayoutPanel2.Controls(str_d), Label)

            TblLyutPnl = CType(Me.TableLayoutPanel2.Controls(str_T), TableLayoutPanel)
            controlLabel_E = CType(TblLyutPnl.Controls(str_e), Label)
            controlLabel_F = CType(TblLyutPnl.Controls(str_f), Label)
            controlLabel_G = CType(TblLyutPnl.Controls(str_g), Label)
            controlLabel_H = CType(TblLyutPnl.Controls(str_h), Label)
            If dt.Rows(0)("IdEstado") = 0 Then
                If dt.Rows(0)("Almuerzo") = "A" Then Seleccionar_Label_Almuerzo(controlLabel_A) Else Inicializar_Label_Almuerzo(controlLabel_A)
                If dt.Rows(0)("Almuerzo") = "B" Then Seleccionar_Label_Almuerzo(controlLabel_B) Else Inicializar_Label_Almuerzo(controlLabel_B)
                If dt.Rows(0)("Almuerzo") = "C" Then Seleccionar_Label_Almuerzo(controlLabel_C) Else Inicializar_Label_Almuerzo(controlLabel_C)
                If dt.Rows(0)("Almuerzo") = "D" Then Seleccionar_Label_Almuerzo(controlLabel_D) Else Inicializar_Label_Almuerzo(controlLabel_D)

                If dt.Rows(0)("Postre") = "A" Then Seleccionar_Label_Almuerzo(controlLabel_E) Else Inicializar_Label_Almuerzo(controlLabel_E)
                If dt.Rows(0)("Postre") = "B" Then Seleccionar_Label_Almuerzo(controlLabel_F) Else Inicializar_Label_Almuerzo(controlLabel_F)
                If dt.Rows(0)("Postre") = "C" Then Seleccionar_Label_Almuerzo(controlLabel_G) Else Inicializar_Label_Almuerzo(controlLabel_G)
                If dt.Rows(0)("Postre") = "D" Then Seleccionar_Label_Almuerzo(controlLabel_H) Else Inicializar_Label_Almuerzo(controlLabel_H)
            Else
                Inicializar_Label_Almuerzo(controlLabel_A)
                Inicializar_Label_Almuerzo(controlLabel_B)
                Inicializar_Label_Almuerzo(controlLabel_C)
                Inicializar_Label_Almuerzo(controlLabel_D)
                Inicializar_Label_Almuerzo(controlLabel_E)
                Inicializar_Label_Almuerzo(controlLabel_F)
                Inicializar_Label_Almuerzo(controlLabel_G)
                Inicializar_Label_Almuerzo(controlLabel_H)
            End If
            FechaIni = DateAdd("d", 1, FechaIni)
        Next
    End Sub

    Sub LLenaFechasColaciones(DateInfo As Date)
        'Lbl_01.ForeColor = Color.Black
        'Lbl_02.ForeColor = Color.Black
        'Lbl_03.ForeColor = Color.Black
        'Lbl_04.ForeColor = Color.Black
        'Lbl_05.ForeColor = Color.Black
        Lbl_01.Text = ""
        Lbl_02.Text = ""
        Lbl_03.Text = ""
        Lbl_04.Text = ""
        Lbl_05.Text = ""

        Dim FechaIni As Date = DateInfo
        'tb_FechaIni.Text = DateInfo.ToString("yyyyMMdd")
        Dim FechaFin As Date = DateAdd("d", 7 - 1, DateInfo)
        lbl_Fecha.Text = (FormatDateTime(DateSerial(Year(FechaIni), Month(FechaIni), Microsoft.VisualBasic.DateAndTime.Day(FechaIni)), DateFormat.LongDate) +
                         Space(2) +
                         "hasta el" +
                         Space(2) +
                         FormatDateTime(DateSerial(Year(FechaFin), Month(FechaFin), Microsoft.VisualBasic.DateAndTime.Day(FechaFin)), DateFormat.LongDate)).ToUpper()
        'REVISAR
        ControlEnable(FechaIni)
        'Coloca dias
        Lbl_01.Text = FormatDateTime(DateSerial(Year(DateInfo), Month(DateInfo), Microsoft.VisualBasic.DateAndTime.Day(DateInfo)), DateFormat.LongDate).ToUpper
        DateInfo = DateAdd("d", 1, DateInfo)
        Lbl_02.Text = FormatDateTime(DateSerial(Year(DateInfo), Month(DateInfo), Microsoft.VisualBasic.DateAndTime.Day(DateInfo)), DateFormat.LongDate).ToUpper
        DateInfo = DateAdd("d", 1, DateInfo)
        Lbl_03.Text = FormatDateTime(DateSerial(Year(DateInfo), Month(DateInfo), Microsoft.VisualBasic.DateAndTime.Day(DateInfo)), DateFormat.LongDate).ToUpper
        DateInfo = DateAdd("d", 1, DateInfo)
        Lbl_04.Text = FormatDateTime(DateSerial(Year(DateInfo), Month(DateInfo), Microsoft.VisualBasic.DateAndTime.Day(DateInfo)), DateFormat.LongDate).ToUpper
        DateInfo = DateAdd("d", 1, DateInfo)
        Lbl_05.Text = FormatDateTime(DateSerial(Year(DateInfo), Month(DateInfo), Microsoft.VisualBasic.DateAndTime.Day(DateInfo)), DateFormat.LongDate).ToUpper


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
                str = String.Format("Lbl_0{0}", i)
                controlLabel = CType(Me.TableLayoutPanel2.Controls(str), Label)
                'controlLabel.Text =FormatDateTime(DateSerial(Year(DateInfo), Month(DateInfo), Microsoft.VisualBasic.DateAndTime.Day(DateInfo)), DateFormat.LongDate)
                If (Not (controlLabel Is Nothing)) Then
                    dt.Reset()
                    cmd = New SqlCommand("Feriados_Info", conexion)
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
        Dim TblLyutPnl As TableLayoutPanel
        Dim controlLabel_A, controlLabel_B, controlLabel_C, controlLabel_D As Label
        Dim controlLabel_PA, controlLabel_PB, controlLabel_PC, controlLabel_PD As Label
        For Linea = 1 To 5
            Dim str_T As String = String.Format("TblLyutPnl_{0}", Linea)
            Dim str_a As String = String.Format("Lbl_A{0}", Linea)
            Dim str_b As String = String.Format("Lbl_B{0}", Linea)
            Dim str_c As String = String.Format("Lbl_C{0}", Linea)
            'Dim str_d As String = String.Format("Lbl_D{0}", Linea)
            'Dim str_Pa As String = String.Format("Lbl_P_A{0}", Linea)
            'Dim str_Pb As String = String.Format("Lbl_P_B{0}", Linea)
            'Dim str_Pc As String = String.Format("Lbl_P_C{0}", Linea)
            'Dim str_Pd As String = String.Format("Lbl_P_D{0}", Linea)
            TblLyutPnl = CType(Me.TableLayoutPanel2.Controls(str_T), TableLayoutPanel)
            controlLabel_A = CType(Me.TableLayoutPanel2.Controls(str_a), Label)
            controlLabel_B = CType(Me.TableLayoutPanel2.Controls(str_b), Label)
            controlLabel_C = CType(Me.TableLayoutPanel2.Controls(str_c), Label)
            'controlLabel_D = CType(Me.TableLayoutPanel2.Controls(str_d), Label)
            'controlLabel_PA = CType(TblLyutPnl.Controls(str_Pa), Label)
            'controlLabel_PB = CType(TblLyutPnl.Controls(str_Pb), Label)
            'controlLabel_PC = CType(TblLyutPnl.Controls(str_Pc), Label)
            'controlLabel_PD = CType(TblLyutPnl.Controls(str_Pd), Label)


            If DateInfo < DateAdd("d", +1, Date.Now) Then
                controlLabel_A.Enabled = False
                controlLabel_B.Enabled = False
                controlLabel_C.Enabled = False
                'controlLabel_D.Enabled = False
                'controlLabel_PA.Enabled = False
                'controlLabel_PB.Enabled = False
                'controlLabel_PC.Enabled = False
                'controlLabel_PD.Enabled = False

            Else
                controlLabel_A.Enabled = True
                controlLabel_B.Enabled = True
                controlLabel_C.Enabled = True
                'controlLabel_D.Enabled = True
                'controlLabel_PA.Enabled = True
                'controlLabel_PB.Enabled = True
                'controlLabel_PC.Enabled = True
                'controlLabel_PD.Enabled = True
            End If
            If MDIParent1.RevisaAcceso(30001) Then
                controlLabel_A.Enabled = True
                controlLabel_B.Enabled = True
                controlLabel_C.Enabled = True
                'controlLabel_D.Enabled = True
                'controlLabel_PA.Enabled = True
                'controlLabel_PB.Enabled = True
                'controlLabel_PC.Enabled = True
                'controlLabel_PD.Enabled = True
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
                    Lbl_A1.Text = dt.Rows(0)("Almuerzo_A")
                    Lbl_B1.Text = dt.Rows(0)("Almuerzo_B")
                    Lbl_C1.Text = dt.Rows(0)("Almuerzo_C")
                    'Lbl_D1.Text = dt.Rows(0)("Almuerzo_D")
                    'Lbl_P_A1.Text = dt.Rows(0)("Postre_A")
                    'Lbl_P_B1.Text = dt.Rows(0)("Postre_B")
                    'Lbl_P_C1.Text = dt.Rows(0)("Postre_C")
                    'Lbl_P_D1.Text = dt.Rows(0)("Postre_D")
                End If
                If vDiaNum = 2 Then
                    Lbl_A2.Text = dt.Rows(0)("Almuerzo_A")
                    Lbl_B2.Text = dt.Rows(0)("Almuerzo_B")
                    Lbl_C2.Text = dt.Rows(0)("Almuerzo_C")
                    'Lbl_D2.Text = dt.Rows(0)("Almuerzo_D")
                    'Lbl_P_A2.Text = dt.Rows(0)("Postre_A")
                    'Lbl_P_B2.Text = dt.Rows(0)("Postre_B")
                    'Lbl_P_C2.Text = dt.Rows(0)("Postre_C")
                    'Lbl_P_D2.Text = dt.Rows(0)("Postre_D")
                End If
                If vDiaNum = 3 Then
                    Lbl_A3.Text = dt.Rows(0)("Almuerzo_A")
                    Lbl_B3.Text = dt.Rows(0)("Almuerzo_B")
                    Lbl_C3.Text = dt.Rows(0)("Almuerzo_C")
                    'Lbl_D3.Text = dt.Rows(0)("Almuerzo_D")
                    'Lbl_P_A3.Text = dt.Rows(0)("Postre_A")
                    'Lbl_P_B3.Text = dt.Rows(0)("Postre_B")
                    'Lbl_P_C3.Text = dt.Rows(0)("Postre_C")
                    'Lbl_P_D3.Text = dt.Rows(0)("Postre_D")
                End If
                If vDiaNum = 4 Then
                    Lbl_A4.Text = dt.Rows(0)("Almuerzo_A")
                    Lbl_B4.Text = dt.Rows(0)("Almuerzo_B")
                    Lbl_C4.Text = dt.Rows(0)("Almuerzo_C")
                    'Lbl_D4.Text = dt.Rows(0)("Almuerzo_D")
                    'Lbl_P_A4.Text = dt.Rows(0)("Postre_A")
                    'Lbl_P_B4.Text = dt.Rows(0)("Postre_B")
                    'Lbl_P_C4.Text = dt.Rows(0)("Postre_C")
                    'Lbl_P_D4.Text = dt.Rows(0)("Postre_D")
                End If
                If vDiaNum = 5 Then
                    Lbl_A5.Text = dt.Rows(0)("Almuerzo_A")
                    Lbl_B5.Text = dt.Rows(0)("Almuerzo_B")
                    Lbl_C5.Text = dt.Rows(0)("Almuerzo_C")
                    'Lbl_D5.Text = dt.Rows(0)("Almuerzo_D")
                    'Lbl_P_A5.Text = dt.Rows(0)("Postre_A")
                    'Lbl_P_B5.Text = dt.Rows(0)("Postre_B")
                    'Lbl_P_C5.Text = dt.Rows(0)("Postre_C")
                    'Lbl_P_D5.Text = dt.Rows(0)("Postre_D")
                End If



            End If
            FechaIni = DateAdd("d", 1, FechaIni)
        Next
        BuscaSolicitudes(vDateInfo)
    End Sub

    Sub LimpiarColaciones()
        Lbl_A1.Text = ""
        Lbl_B1.Text = ""
        Lbl_C1.Text = ""
        Inicializar_Label_Almuerzo(Lbl_A1)
        Inicializar_Label_Almuerzo(Lbl_B1)
        Inicializar_Label_Almuerzo(Lbl_C1)
        'Lbl_D1.Text = ""
        'Lbl_P_A1.Text = ""
        'Lbl_P_B1.Text = ""
        'Lbl_P_C1.Text = ""
        'Lbl_P_D1.Text = ""

        Lbl_A2.Text = ""
        Lbl_B2.Text = ""
        Lbl_C2.Text = ""
        Inicializar_Label_Almuerzo(Lbl_A2)
        Inicializar_Label_Almuerzo(Lbl_B2)
        Inicializar_Label_Almuerzo(Lbl_C2)
        'Lbl_D2.Text = ""
        'Lbl_P_A2.Text = ""
        'Lbl_P_B2.Text = ""
        'Lbl_P_C2.Text = ""
        'Lbl_P_D2.Text = ""

        Lbl_A3.Text = ""
        Lbl_B3.Text = ""
        Lbl_C3.Text = ""
        Inicializar_Label_Almuerzo(Lbl_A3)
        Inicializar_Label_Almuerzo(Lbl_B3)
        Inicializar_Label_Almuerzo(Lbl_C3)
        'Lbl_D3.Text = ""
        'Lbl_P_A3.Text = ""
        'Lbl_P_B3.Text = ""
        'Lbl_P_C3.Text = ""
        'Lbl_P_D3.Text = ""

        Lbl_A4.Text = ""
        Lbl_B4.Text = ""
        Lbl_C4.Text = ""
        Inicializar_Label_Almuerzo(Lbl_A4)
        Inicializar_Label_Almuerzo(Lbl_B4)
        Inicializar_Label_Almuerzo(Lbl_C4)
        'Lbl_D4.Text = ""
        'Lbl_P_A4.Text = ""
        'Lbl_P_B4.Text = ""
        'Lbl_P_C4.Text = ""
        'Lbl_P_D4.Text = ""

        Lbl_A5.Text = ""
        Lbl_B5.Text = ""
        Lbl_C5.Text = ""
        Inicializar_Label_Almuerzo(Lbl_A5)
        Inicializar_Label_Almuerzo(Lbl_B5)
        Inicializar_Label_Almuerzo(Lbl_C5)
        'Lbl_D5.Text = ""
        'Lbl_P_A5.Text = ""
        'Lbl_P_B5.Text = ""
        'Lbl_P_C5.Text = ""
        'Lbl_P_D5.Text = ""
    End Sub

    Private Sub VisiblePostres()
        Lbl_P_B1.Visible = False
        Lbl_P_C1.Visible = False
        Lbl_P_D1.Visible = False
        Lbl_P_B2.Visible = False
        Lbl_P_C2.Visible = False
        Lbl_P_D2.Visible = False
        Lbl_P_B3.Visible = False
        Lbl_P_C3.Visible = False
        Lbl_P_D3.Visible = False
        Lbl_P_B4.Visible = False
        Lbl_P_C4.Visible = False
        Lbl_P_D4.Visible = False
        Lbl_P_B5.Visible = False
        Lbl_P_C5.Visible = False
        Lbl_P_D5.Visible = False
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

    Private Sub makeList()
        listaControl.Add(Me.Lbl_A1)
        listaControl.Add(Me.Lbl_A2)
        listaControl.Add(Me.Lbl_A3)
        listaControl.Add(Me.Lbl_A4)
        listaControl.Add(Me.Lbl_A5)
        listaControl.Add(Me.Lbl_B1)
        listaControl.Add(Me.Lbl_B2)
        listaControl.Add(Me.Lbl_B3)
        listaControl.Add(Me.Lbl_B4)
        listaControl.Add(Me.Lbl_B5)
        listaControl.Add(Me.Lbl_C1)
        listaControl.Add(Me.Lbl_C2)
        listaControl.Add(Me.Lbl_C3)
        listaControl.Add(Me.Lbl_C4)
        listaControl.Add(Me.Lbl_C5)
        listaControl.Add(Me.Lbl_D1)
        listaControl.Add(Me.Lbl_D2)
        listaControl.Add(Me.Lbl_D3)
        listaControl.Add(Me.Lbl_D4)
        listaControl.Add(Me.Lbl_D5)
        listaControl.Add(Me.Lbl_01)
        listaControl.Add(Me.Lbl_02)
        listaControl.Add(Me.Lbl_03)
        listaControl.Add(Me.Lbl_04)
        listaControl.Add(Me.Lbl_05)
        listaControl.Add(TblLyutPnl_1)
        listaControl.Add(TblLyutPnl_2)
        listaControl.Add(TblLyutPnl_3)
        listaControl.Add(TblLyutPnl_4)
        listaControl.Add(TblLyutPnl_5)
    End Sub


End Class
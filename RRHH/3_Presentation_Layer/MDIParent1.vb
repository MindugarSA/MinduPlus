Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class MDIParent1
    Dim conexion As New SqlConnection
    Dim dt As New DataTable
    Dim cmd As SqlCommand
    Dim dtPL As New DataTable

    Public Property RutUsuario As String
    Public Property NombreUsuario As String
    Public Property RutEmpresa As String
    Public Property NombreEmpresa As String

    Private Entrada As Integer = 0
    Public TiempoActivo As Integer
    Private m_ChildFormNumber As Integer
    Public Tiempo_Str As Integer = 30
    Public Tiempo_Animacion As Integer = 0
    Private ToolStripVisible As Boolean = True

    Private Const DESPLAZAMIENTO As Integer = 25
    Private Const CANTIDAD_DESPLAZO As Integer = 25

    Private AnimationType As BunifuAnimatorNS.AnimationType = 10

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Configurar_MeterialSkin_Styles_Inicio()

        conexion.ConnectionString = Conection.Cn
        Me.ShowInTaskbar = True

    End Sub

    Private Sub MDIParent1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Me.WindowState = FormWindowState.Minimized
        Me.WindowState = FormWindowState.Maximized

        PictureBox3.Top = (Panel2.Height / 2) - (PictureBox3.Height / 2)
        PictureBox3.Left = (Panel2.Width / 2) - (PictureBox3.Width / 2)

        'PictureBox4.Top = PictureBox3.Top
        'PictureBox4.Left = PictureBox3.Left - 250

        'PictureBox5.Top = PictureBox3.Top
        'PictureBox5.Left = PictureBox3.Left + 200

        'PictureBox4.Visible = True
        'PictureBox5.Visible = True

        PictureBox2_Click(sender, e)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PcturBx_Image.Click
        TiempoIngreso.Enabled = False
        Cerrar_Forms_Children()
        TlStrpSttsLbl_SQL.BackColor = Color.White
        TlStrpSttsLbl_SQL.Text = ""

        Dim NewMDIChild As New Login()
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()

        TiempoIngreso.Enabled = True
        TiempoActivo = Tiempo_Str
        ToolStripProgressBar1.ProgressBar.Maximum = TiempoActivo
        ToolStripProgressBar1.ProgressBar.Value = TiempoActivo


    End Sub

    Private Sub Btt_SolAlmuerzo_Click(sender As Object, e As EventArgs)
        If RevisaAcceso(31001) Then
            Dim NewMDIChild As New Frm_SolicitudColacion()
            Cerrar_Forms_Children()
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()

            NewMDIChild.ControlBox = False
            If RevisaAcceso(30001) Then
                TiempoIngreso.Enabled = False
            Else
                TiempoIngreso.Enabled = True
            End If
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
            NewMDIChild.WindowState = FormWindowState.Maximized
        Else
            MsgBox("Lo lamento !" & vbNewLine & "Solicite autorización en Dto. RRHH", MsgBoxStyle.Exclamation, "Error!")
        End If
    End Sub

    Private Sub Bttn_MantencionColacione_Click(sender As Object, e As EventArgs)
        If RevisaAcceso(31002) Then
            Dim NewMDIChild As New Frm_MantencionColaciones()
            Cerrar_Forms_Children()
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()

            NewMDIChild.ControlBox = False
            TiempoIngreso.Enabled = False
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
            NewMDIChild.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If RevisaAcceso(30003) Then
            Dim NewMDIChild As New Frm_Informes()

            Cerrar_Forms_Children()
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()

            NewMDIChild.ControlBox = False
            TiempoIngreso.Enabled = False
            'TiempoIngreso.Enabled = True
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
            NewMDIChild.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If RevisaAcceso(31003) Then
            Dim NewMDIChild As New Frm_Liquidaciones()

            Cerrar_Forms_Children()
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()

            NewMDIChild.ControlBox = False
            TiempoIngreso.Enabled = True
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
            NewMDIChild.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub Bttn_Parametros_Click(sender As Object, e As EventArgs)
        If RevisaAcceso(30002) Then

            Dim NewMDIChild As New Frm_Parametros2()
            Cerrar_Forms_Children()
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()

            NewMDIChild.ControlBox = False
            TiempoIngreso.Enabled = False
            'TiempoIngreso.Enabled = True
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
            NewMDIChild.WindowState = FormWindowState.Maximized
        End If




        'If RevisaAcceso(30002) Then




        '    Dim NewMDIChild As New Frm_Parametros()
        '    For Each ChildForm As Form In Me.MdiChildren
        '        ChildForm.Close()
        '    Next
        '    NewMDIChild.MdiParent = Me
        '    NewMDIChild.Show()

        '    NewMDIChild.ControlBox = False
        '    TiempoIngreso.Enabled = False
        '    'TiempoIngreso.Enabled = True
        '    TiempoActivo = Tiempo_Str
        '    ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
        '    'NewMDIChild.WindowState = FormWindowState.Maximized
        'End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        If RevisaAcceso(30001) Then

            Dim NewMDIChild As New Frm_SolicitudGerencial()
            Cerrar_Forms_Children()
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()

            NewMDIChild.ControlBox = False
            TiempoIngreso.Enabled = False
            'TiempoIngreso.Enabled = True
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
            NewMDIChild.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Function RevisaAcceso(Campo As Integer) As Boolean
        dt.Reset()
        cmd = New SqlCommand("PassAtributosUsuarioInfo", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd.Parameters.Add(New SqlParameter("@IdUsuario", Lbl_Cod_ID.Text))
        cmd.Parameters.Add(New SqlParameter("@IdAtributo", Campo))
        Try
            dt.Load(cmd.ExecuteReader())
        Catch ex As Exception

            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
        Finally
            conexion.Close()
        End Try
        Return dt.Rows(0)("Acceso")

    End Function

    Private Sub TiempoIngreso_Tick(sender As Object, e As EventArgs) Handles TiempoIngreso.Tick
        Try
            TiempoActivo = TiempoActivo - 1
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
            If TiempoActivo = 0 Then
                TiempoIngreso.Enabled = False
                Cerrar_Forms_Children()
                Visualizar_Tiles_MDI()
                Dim NewMDIChild As New Login()
                NewMDIChild.MdiParent = Me
                NewMDIChild.Show()
                NewMDIChild.ControlBox = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TiempoIngreso.Enabled = False

        Cerrar_Forms_Children()
        Visualizar_Tiles_MDI()
        Configurar_MeterialSkin_Styles_Inicio()

        Dim NewMDIChild As New Login()
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.ControlBox = False

        TiempoIngreso.Enabled = True
        TiempoActivo = Tiempo_Str
        ToolStripProgressBar1.ProgressBar.Maximum = TiempoActivo
        ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
        TlStrpSttsLbl_SQL.BackColor = Color.White
        TlStrpSttsLbl_SQL.Text = ""

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        If RevisaAcceso(90000) Then
            TiempoIngreso.Enabled = False
            Cerrar_Forms_Children()
            Dim NewMDIChild As New FrmSolicPermHrasExt(0)
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
            NewMDIChild.ControlBox = False
            TiempoIngreso.Enabled = False
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
        End If
    End Sub

    Private Sub Bttn_Pendiente_Click(sender As Object, e As EventArgs)
        If RevisaAcceso(91000) Then
            TiempoIngreso.Enabled = False
            Cerrar_Forms_Children()
            Dim newMDIChild As New ImportarExcelSQLServer.Form1(Me.Panel2, Me.Size.Height, Me.StatusStrip, Lbl_Cod_ID.Text)
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
            newMDIChild.ControlBox = False

            TiempoIngreso.Enabled = False
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
            'newMDIChild.WindowState = FormWindowState.Maximized
            Me.Panel2.Visible = False
        End If

    End Sub

    Private Sub Exportador_Click(sender As Object, e As EventArgs) Handles Tle_Exportador.Click
        If RevisaAcceso(91000) Then
            TiempoIngreso.Enabled = False
            Cerrar_Forms_Children()

            Dim newMDIChild As New ImportarExcelSQLServer.Form1(Me.Panel2, Me.Size.Height, Me.StatusStrip, Lbl_Cod_ID.Text)
            AddHandler newMDIChild.EnviarEvento, New ImportarExcelSQLServer.Form1.LaunchEvent(AddressOf Visualizar_Tiles_MDI)
            AddHandler newMDIChild.EnviarEvento, New ImportarExcelSQLServer.Form1.LaunchEvent(AddressOf Desplazamiento_Tiles)

            newMDIChild.MdiParent = Me
            'newMDIChild.WindowState = FormWindowState.Maximized
            newMDIChild.Dock = DockStyle.Fill
            Me.Panel2.Controls.Add(newMDIChild)
            Me.Panel2.Tag = newMDIChild
            Ocultar_Tiles_MDI()
            newMDIChild.ControlBox = False
            StatusStrip.Dock = DockStyle.None
            StatusStrip.Visible = False
            ToolStripVisible = False
            Panel2.Height += StatusStrip.Height
            newMDIChild.Show()

            TiempoIngreso.Enabled = False
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo

        End If
    End Sub

    Private Sub Tle_SolAlmuerzo_Click(sender As Object, e As EventArgs) Handles Tle_SolAlmuerzo.Click
        If RevisaAcceso(31001) Then
            Dim NewMDIChild As New Frm_SolicitudColacion()
            AddHandler NewMDIChild.EnviarEvento, New Frm_SolicitudColacion.LaunchEvent(AddressOf Visualizar_Tiles_MDI)
            AddHandler NewMDIChild.EnviarEvento, New Frm_SolicitudColacion.LaunchEvent(AddressOf Desplazamiento_Tiles)

            Cerrar_Forms_Children()
            NewMDIChild.MdiParent = Me

            If RevisaAcceso(30001) Then
                TiempoIngreso.Enabled = False
            Else
                TiempoIngreso.Enabled = True
            End If

            TiempoActivo = Tiempo_Str + 60
            ToolStripProgressBar1.ProgressBar.Maximum = TiempoActivo
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
            NewMDIChild.WindowState = FormWindowState.Maximized
            NewMDIChild.Dock = DockStyle.Fill
            Me.Panel2.Controls.Add(NewMDIChild)
            Me.Panel2.Tag = NewMDIChild
            Ocultar_Tiles_MDI()
            NewMDIChild.ControlBox = False
            NewMDIChild.Show()

        Else
            MsgBox("Lo lamento !" & vbNewLine & "Solicite autorización en Dto. RRHH", MsgBoxStyle.Exclamation, "Error!")
        End If
    End Sub

    Private Sub Tle_Permisos_Click(sender As Object, e As EventArgs) Handles Tle_Permisos.Click
        If RevisaAcceso(90000) Then
            TiempoIngreso.Enabled = False
            Cerrar_Forms_Children()
            Configurar_MeterialSkin_Styles_Pantallas()
            Dim NewMDIChild As New FrmSolicPermHrasExt(0)
            NewMDIChild.MdiParent = Me
            NewMDIChild.Dock = DockStyle.Fill
            Me.Panel2.Controls.Add(NewMDIChild)
            Me.Panel2.Tag = NewMDIChild
            Ocultar_Tiles_MDI()
            NewMDIChild.Show()
            NewMDIChild.ControlBox = False
            TiempoIngreso.Enabled = False
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
            TmrDesplaza.Enabled = False
        End If
    End Sub

    Private Sub Tle_Liquidacion_Click(sender As Object, e As EventArgs) Handles Tle_Liquidacion.Click

        If RevisaAcceso(31003) Then

            ConsultarEstadoPreLiquidacion(dtPL)
            If (dtPL.Rows(0)(0).ToString.Trim() = "Y") Then

                Dim FrmSelecLiqui As New Frm_SeleccionaTiporLiquidacion()

                If (FrmSelecLiqui.ShowDialog() = DialogResult.OK) Then

                    Dim sPantalla As String = FrmSelecLiqui.TipoReporte


                    Select Case sPantalla
                        Case "PreLiquidacion"

                            Abrir_Pantalla_Preliquidaciones()

                        Case "Liquidacion"

                            Abrir_Pantalla_Liquidaciones()

                    End Select

                End If

            Else

                Abrir_Pantalla_Liquidaciones()

            End If


        End If
    End Sub

    Private Sub Abrir_Pantalla_Liquidaciones()

        Dim NewMDIChild As New Frm_Liquidaciones()
        AddHandler NewMDIChild.EnviarEvento, New Frm_Liquidaciones.LaunchEvent(AddressOf Visualizar_Tiles_MDI)
        AddHandler NewMDIChild.EnviarEvento, New Frm_Liquidaciones.LaunchEvent(AddressOf Desplazamiento_Tiles)

        Cerrar_Forms_Children()
        NewMDIChild.MdiParent = Me
        NewMDIChild.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(NewMDIChild)
        Me.Panel2.Tag = NewMDIChild
        Ocultar_Tiles_MDI()
        NewMDIChild.Show()

        NewMDIChild.ControlBox = False

        TiempoIngreso.Enabled = True
        TiempoActivo = Tiempo_Str + 60
        ToolStripProgressBar1.ProgressBar.Maximum = TiempoActivo
        ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
        'NewMDIChild.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Abrir_Pantalla_Preliquidaciones()

        Dim sPeriodo As String = dtPL.Rows(0)(1).ToString.Trim()
        Dim formInforme As New Frm_InformesRDLC()
        formInforme.TipoReporte = "PreLiquidacion"
        formInforme.Rut = Lbl_RutTrab.Text
        formInforme.Año = sPeriodo.Substring(0, 4)
        formInforme.Mes = sPeriodo.Substring(4, 2)
        formInforme.RutEmp = RutEmpresa
        formInforme.CallFrom = "MDIParent1"


        Cerrar_Forms_Children()
        formInforme.MdiParent = Me
        formInforme.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(formInforme)
        Me.Panel2.Tag = formInforme
        Ocultar_Tiles_MDI()
        formInforme.Show()

        TiempoIngreso.Enabled = True
        TiempoActivo = Tiempo_Str + 60
        ToolStripProgressBar1.ProgressBar.Maximum = TiempoActivo
        ToolStripProgressBar1.ProgressBar.Value = TiempoActivo

    End Sub

    Private Sub ConsultarEstadoPreLiquidacion(DTdata As DataTable)

        conexion.ConnectionString = Conection.Cn

        cmd = New SqlCommand("[MINDU_INTERMEDIA].[dbo].[SpPRE_LIQUIDACIONConsultar]", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            conexion.Open()

            Dim adaptador As New SqlDataAdapter(cmd)
            DTdata.Clear()
            adaptador.Fill(DTdata)

        Catch ex As Exception
        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub Tle_MantencionColacione_Click(sender As Object, e As EventArgs) Handles Tle_MantencionColacione.Click

        If RevisaAcceso(31002) Then
            Dim NewMDIChild As New Frm_MantencionColaciones()
            Cerrar_Forms_Children()
            NewMDIChild.MdiParent = Me
            'NewMDIChild.WindowState = FormWindowState.Maximized
            NewMDIChild.Dock = DockStyle.Fill
            Me.Panel2.Controls.Add(NewMDIChild)
            Me.Panel2.Tag = NewMDIChild
            Ocultar_Tiles_MDI()
            NewMDIChild.ControlBox = False
            NewMDIChild.Show()

            TiempoIngreso.Enabled = False
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo

        End If

    End Sub

    Private Sub Tle_AlmuAdicional_Click(sender As Object, e As EventArgs) Handles Tle_AlmuAdicional.Click
        If RevisaAcceso(30001) Then

            Dim NewMDIChild As New Frm_SolicitudGerencial()
            Cerrar_Forms_Children()
            NewMDIChild.MdiParent = Me
            NewMDIChild.WindowState = FormWindowState.Maximized
            NewMDIChild.Dock = DockStyle.Fill
            Me.Panel2.Controls.Add(NewMDIChild)
            Me.Panel2.Tag = NewMDIChild
            Ocultar_Tiles_MDI()
            NewMDIChild.Show()

            NewMDIChild.ControlBox = False
            TiempoIngreso.Enabled = False
            'TiempoIngreso.Enabled = True
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
        End If
    End Sub

    Private Sub Tle_InformesAlmu_Click(sender As Object, e As EventArgs) Handles Tle_InformesAlmu.Click
        If RevisaAcceso(30003) Then
            Dim NewMDIChild As New Frm_Informes()

            Cerrar_Forms_Children()
            NewMDIChild.MdiParent = Me
            NewMDIChild.WindowState = FormWindowState.Maximized
            NewMDIChild.Dock = DockStyle.Fill
            Me.Panel2.Controls.Add(NewMDIChild)
            Me.Panel2.Tag = NewMDIChild
            Ocultar_Tiles_MDI()
            NewMDIChild.Show()

            NewMDIChild.ControlBox = False
            TiempoIngreso.Enabled = False
            'TiempoIngreso.Enabled = True
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
        End If
    End Sub

    Private Sub Tle_Configuracion_Click(sender As Object, e As EventArgs) Handles Tle_Configuracion.Click

        If RevisaAcceso(30002) Then

            Dim NewMDIChild As New Frm_Parametros2()
            Cerrar_Forms_Children()
            NewMDIChild.MdiParent = Me
            NewMDIChild.WindowState = FormWindowState.Maximized
            NewMDIChild.Dock = DockStyle.Fill
            Me.Panel2.Controls.Add(NewMDIChild)
            Me.Panel2.Tag = NewMDIChild
            Ocultar_Tiles_MDI()
            NewMDIChild.Show()

            NewMDIChild.ControlBox = False
            TiempoIngreso.Enabled = False
            'TiempoIngreso.Enabled = True
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo

        End If

    End Sub

    Private Sub Cerrar_Forms_Children()
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next

        Cerrar_Forms_Dentro_de_Panel(Me.Panel2)

    End Sub
    Public Sub Cerrar_Forms_Dentro_de_Panel(PanelName As Panel)
        Dim listaForm As List(Of Form) =
          (From frm As Form In PanelName.Controls.OfType(Of Form)()
           Select frm).ToList()

        For Each frm As Form In listaForm
            frm.Close()
        Next
    End Sub

    Public Sub Ocultar_Tiles_MDI()
        pnlMovingRight.Visible = False
        pnlMovingRight2.Visible = False
        pnlMovingTop.Visible = False
        Hide_BackLogo()
        'Dim listaTiles As List(Of MetroFramework.Controls.MetroTile) =
        '  (From tb As MetroFramework.Controls.MetroTile In Me.Panel2.Controls.OfType(Of MetroFramework.Controls.MetroTile)()
        '   Select tb).ToList()

        'For Each Tle As MetroFramework.Controls.MetroTile In listaTiles
        '    Tle.Visible = False
        'Next
    End Sub

    Public Sub Visualizar_Tiles_MDI()

        If (ToolStripVisible = False) Then
            ToolStripVisible = True
            Panel2.Height -= StatusStrip.Height
            StatusStrip.Visible = True
            StatusStrip.Dock = DockStyle.Bottom
        End If

        pnlMovingRight.Visible = True
        pnlMovingRight2.Visible = True
        pnlMovingTop.Visible = True


        'Dim listaTiles As List(Of MetroFramework.Controls.MetroTile) =
        '  (From tb As MetroFramework.Controls.MetroTile In Panel2.Controls.OfType(Of MetroFramework.Controls.MetroTile)()
        '   Select tb).ToList()

        'For Each Tle As MetroFramework.Controls.MetroTile In listaTiles
        '    Tle.Visible = True
        'Next
    End Sub

    Private Sub Tle_Exportador_MouseEnter(sender As Object, e As EventArgs) Handles Tle_SolAlmuerzo.MouseEnter, Tle_Permisos.MouseEnter, Tle_MantencionColacione.MouseEnter, Tle_Liquidacion.MouseEnter, Tle_InformesAlmu.MouseEnter, Tle_Exportador.MouseEnter, Tle_Configuracion.MouseEnter, Tle_AlmuAdicional.MouseEnter, TleSolicitar_HHEE.MouseEnter, Tle_Solicitar_Permisos.MouseEnter, Tle_Asistencias_Periodo.MouseEnter, Tle_Herramientas_Pre.MouseEnter, PictureBox3.MouseEnter, Tle_Ticket_Solicitud.MouseEnter
        sender.Left = sender.Left - 4
        sender.Top = sender.Top - 4
        sender.Height = sender.Height + 8
        sender.Width = sender.Width + 8
    End Sub

    Private Sub Tle_Exportador_MouseLeave(sender As Object, e As EventArgs) Handles Tle_SolAlmuerzo.MouseLeave, Tle_Permisos.MouseLeave, Tle_MantencionColacione.MouseLeave, Tle_Liquidacion.MouseLeave, Tle_InformesAlmu.MouseLeave, Tle_Exportador.MouseLeave, Tle_Configuracion.MouseLeave, Tle_AlmuAdicional.MouseLeave, TleSolicitar_HHEE.MouseLeave, Tle_Solicitar_Permisos.MouseLeave, Tle_Asistencias_Periodo.MouseLeave, Tle_Herramientas_Pre.MouseLeave, PictureBox3.MouseLeave, Tle_Ticket_Solicitud.MouseLeave
        sender.Left = sender.Left + 4
        sender.Top = sender.Top + 4
        sender.Height = sender.Height - 8
        sender.Width = sender.Width - 8
    End Sub

    Private Sub TmrDesplaza_Tick(sender As Object, e As EventArgs) Handles TmrDesplaza.Tick
        pnlMovingRight.Left += DESPLAZAMIENTO
        pnlMovingRight2.Left += DESPLAZAMIENTO
        pnlMovingTop.Top -= DESPLAZAMIENTO

        Tiempo_Animacion += 1

        If Tiempo_Animacion = CANTIDAD_DESPLAZO Then
            TmrDesplaza.Stop()
            TmrDesplaza.Enabled = False
            Tiempo_Animacion = 0
            If Entrada > 1 Then
                Animate_BackLogo()
            End If
        End If
    End Sub

    Public Sub Desplazamiento_Tiles()

        Entrada += 1
        pnlMovingRight.Left -= DESPLAZAMIENTO * CANTIDAD_DESPLAZO
        pnlMovingRight2.Left -= DESPLAZAMIENTO * CANTIDAD_DESPLAZO
        pnlMovingTop.Top += DESPLAZAMIENTO * CANTIDAD_DESPLAZO

        TmrDesplaza.Enabled = True
        TmrDesplaza.Start()


    End Sub

    Private Sub Animate_BackLogo()

        If (PictureBox3.Visible = True) Then
            BunifuTransition1.HideSync(PictureBox3)
        End If

        PictureBox3.Visible = False
        PictureBox3.BringToFront()

        BunifuTransition1.AnimationType = AnimationType
        BunifuTransition1.ShowSync(PictureBox3)
        'BunifuTransition1.ShowSync(PictureBox4, True)
        'BunifuTransition1.ShowSync(PictureBox5, True)

        If AnimationType = 13 Then
            AnimationType = 1
        Else
            AnimationType += 1
        End If

        'TmrBackAnimation.Enabled = True
        'TmrBackAnimation.Start()

    End Sub

    Private Sub Hide_BackLogo()
        TmrBackAnimation.Stop()
        TmrBackAnimation.Enabled = False
        Try
            BunifuTransition1.HideSync(PictureBox3)
            PictureBox3.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TmrBackAnimation_Tick(sender As Object, e As EventArgs) Handles TmrBackAnimation.Tick

        If TmrBackAnimation.Interval = 5000 Then
            TmrBackAnimation.Stop()
            TmrBackAnimation.Enabled = False
            If Entrada > 1 Then
                Animate_BackLogo()
            End If
        End If

    End Sub

    Private Sub Panel2_VisibleChanged(sender As Object, e As EventArgs) Handles Panel2.VisibleChanged

        If Panel2.Visible = True Then
            Desplazamiento_Tiles()
        End If

    End Sub

    Private Sub Tle_Solicitar_Permisos_Click(sender As Object, e As EventArgs) Handles Tle_Solicitar_Permisos.Click
        If RevisaAcceso(90001) Then
            Try
                TiempoIngreso.Enabled = False
                Cerrar_Forms_Children()
                Dim NewMDIChild As New FrmSolicPermHrasExt(90001)
                NewMDIChild.MdiParent = Me
                NewMDIChild.WindowState = FormWindowState.Maximized
                NewMDIChild.Dock = DockStyle.Fill
                Me.Panel2.Controls.Add(NewMDIChild)
                Me.Panel2.Tag = NewMDIChild
                Ocultar_Tiles_MDI()
                NewMDIChild.Show()
                NewMDIChild.ControlBox = False
                TiempoIngreso.Enabled = False
                TiempoActivo = Tiempo_Str + 120
                ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub TleSolicitar_HHEE_Click(sender As Object, e As EventArgs) Handles TleSolicitar_HHEE.Click
        If RevisaAcceso(90001) Then
            Try
                TiempoIngreso.Enabled = False
                Cerrar_Forms_Children()
                Dim NewMDIChild As New FrmSolicPermHrasExt(90002)
                NewMDIChild.MdiParent = Me
                NewMDIChild.WindowState = FormWindowState.Maximized
                NewMDIChild.Dock = DockStyle.Fill
                Me.Panel2.Controls.Add(NewMDIChild)
                Me.Panel2.Tag = NewMDIChild
                Ocultar_Tiles_MDI()
                NewMDIChild.Show()
                NewMDIChild.ControlBox = False
                TiempoIngreso.Enabled = False
                TiempoActivo = Tiempo_Str + 120
                ToolStripProgressBar1.ProgressBar.Maximum = TiempoActivo
                ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.BackColor = Color.FromArgb(255, 196, 37)
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.FromArgb(45, 137, 239)
    End Sub

    Private Sub Tle_Asistencias_Periodo_Click(sender As Object, e As EventArgs) Handles Tle_Asistencias_Periodo.Click

        MetroFramework.MetroMessageBox.Show(Me, "Informe Deshabilitado, Diríjase a las Oficinas de RR.HH para solicitar Información sobre sus Asistencias.",
                                                        "Informe No Disponible",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information,
                                                        370)

        'Dim informe As New InformePlanillaAsistencia()

        'Dim formInforme As New Frm_AsistenciasPeriodo(informe)
        'Cerrar_Forms_Children()
        'formInforme.MdiParent = Me
        'formInforme.Dock = DockStyle.Fill
        'Me.Panel2.Controls.Add(formInforme)
        'Me.Panel2.Tag = formInforme
        'Ocultar_Tiles_MDI()
        'formInforme.Show()

        'TiempoIngreso.Enabled = True
        'TiempoActivo = Tiempo_Str + 60
        'ToolStripProgressBar1.ProgressBar.Maximum = TiempoActivo
        'ToolStripProgressBar1.ProgressBar.Value = TiempoActivo

    End Sub

    Private Sub Tle_Ticket_Solicitud_Click(sender As Object, e As EventArgs) Handles Tle_Ticket_Solicitud.Click

        Dim NewMDIChild As New Frm_TicketSolicitudes()
        Cerrar_Forms_Children()
        NewMDIChild.MdiParent = Me
        NewMDIChild.WindowState = FormWindowState.Maximized
        NewMDIChild.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(NewMDIChild)
        Me.Panel2.Tag = NewMDIChild
        Ocultar_Tiles_MDI()
        NewMDIChild.Show()

        NewMDIChild.ControlBox = False
        TiempoIngreso.Enabled = False
        'TiempoIngreso.Enabled = True
        TiempoActivo = Tiempo_Str
        ToolStripProgressBar1.ProgressBar.Value = TiempoActivo

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim FormPrueba As New CapaPresentacion.FrmInstrumentosPrecision(Me.Panel2, Me.StatusStrip, "")
        'FormPrueba.MdiParent = Me
        'FormPrueba.Text = "PRUEBA DE LLAMADA"
        FormPrueba.Show()
    End Sub

    Private Sub Tle_Herramientas_Pre_Click(sender As Object, e As EventArgs) Handles Tle_Herramientas_Pre.Click
        If RevisaAcceso(95000) Then
            TiempoIngreso.Enabled = False
            Cerrar_Forms_Children()

            Dim newMDIChild As New CapaPresentacion.FrmInstrumentosPrecision(Me.Panel2, Me.StatusStrip, Lbl_Cod_ID.Text)
            AddHandler newMDIChild.EnviarEvento, New CapaPresentacion.FrmInstrumentosPrecision.LaunchEvent(AddressOf Visualizar_Tiles_MDI)
            AddHandler newMDIChild.EnviarEvento, New CapaPresentacion.FrmInstrumentosPrecision.LaunchEvent(AddressOf Desplazamiento_Tiles)

            newMDIChild.MdiParent = Me
            'newMDIChild.WindowState = FormWindowState.Maximized
            newMDIChild.Dock = DockStyle.Fill
            Me.Panel2.Controls.Add(newMDIChild)
            Me.Panel2.Tag = newMDIChild
            Ocultar_Tiles_MDI()
            newMDIChild.ControlBox = False
            StatusStrip.Dock = DockStyle.None
            StatusStrip.Visible = False
            Panel2.Height += StatusStrip.Height
            ToolStripVisible = False
            newMDIChild.Show()

            TiempoIngreso.Enabled = False
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
        End If
    End Sub

    Private Sub Configurar_MeterialSkin_Styles_Inicio()

        Dim skinManager As MaterialSkin.MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance
        skinManager.ROBOTO_MEDIUM_10 = New Font("Segoe UI Light", 10)
        skinManager.ROBOTO_MEDIUM_11 = New Font("Segoe UI Light", 11)
        skinManager.ROBOTO_MEDIUM_12 = New Font("Segoe UI Light", 12)
        skinManager.ROBOTO_REGULAR_11 = New Font("Segoe UI Light", 16)
        skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT
        skinManager.ColorScheme = New MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500, MaterialSkin.Primary.LightBlue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE)

    End Sub

    Private Sub Configurar_MeterialSkin_Styles_Pantallas()

        Dim skinManager As MaterialSkin.MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance
        skinManager.ROBOTO_MEDIUM_10 = New Font("Segoe UI Light", 10)
        skinManager.ROBOTO_MEDIUM_11 = New Font("Segoe UI Light", 11)
        skinManager.ROBOTO_MEDIUM_12 = New Font("Segoe UI Light", 12)
        skinManager.ROBOTO_REGULAR_11 = New Font("Segoe UI Light", 11)
        skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT
        skinManager.ColorScheme = New MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500, MaterialSkin.Primary.LightBlue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Animate_BackLogo()
    End Sub

End Class

Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class MDIParent1
    Dim conexion As New SqlConnection
    Dim dt As New DataTable
    Dim cmd As SqlCommand

    Public TiempoActivo As Integer
    Private m_ChildFormNumber As Integer
    Public Tiempo_Str As Integer = 30
    Public Tiempo_Animacion As Integer = 0

    Private Const DESPLAZAMIENTO As Integer = 25
    Private Const CANTIDAD_DESPLAZO As Integer = 25

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Data Source=FSSAPBO;Initial Catalog = SAC_Mindugar; Persist Security Info=True;User ID = sa; Password=Sqladmin281"
        Me.ShowInTaskbar = True
    End Sub

    Private Sub MDIParent1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Me.WindowState = FormWindowState.Minimized
        Me.WindowState = FormWindowState.Maximized

        PictureBox2_Click(sender, e)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PcturBx_Image.Click
        TiempoIngreso.Enabled = False
        Cerrar_Forms_Children()
        Dim NewMDIChild As New Login()
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()

        TiempoIngreso.Enabled = True
        TiempoActivo = Tiempo_Str
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





        'dt.Reset()
        'cmd = New SqlCommand("Colaciones_Pass_Info", conexion)
        'cmd.CommandType = CommandType.StoredProcedure
        'conexion.Open()
        'cmd.Parameters.Add(New SqlParameter("@Rut", Lbl_RutTrab.Text))
        'cmd.Parameters.Add(New SqlParameter("@Campo", Campo))
        'Try
        '    dt.Load(cmd.ExecuteReader())
        'Catch ex As Exception

        '    MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
        'Finally
        '    conexion.Close()
        'End Try
        'If dt.Rows(0)("IdEstado") = 0 Then
        '    Return dt.Rows(0)("Acceso")
        'Else
        '    Return 0
        'End If
    End Function



    Private Sub TiempoIngreso_Tick(sender As Object, e As EventArgs) Handles TiempoIngreso.Tick
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

    End Sub


    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        '' Cree una nueva instancia del formulario secundario.
        'Panel2.Visible = False
        'Dim ChildForm As New System.Windows.Forms.Form
        '' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        'ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Ventana " & m_ChildFormNumber

        'ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        'Panel2.Visible = False
        'Dim OpenFileDialog As New OpenFileDialog
        'OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        'OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        'If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
        '    Dim FileName As String = OpenFileDialog.FileName
        '    ' TODO: agregue código aquí para abrir el archivo.
        'End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Dim SaveFileDialog As New SaveFileDialog
        'SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        'SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        'If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
        '    Dim FileName As String = SaveFileDialog.FileName
        '    ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        'End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        'For Each ChildForm As Form In Me.MdiChildren
        '    ChildForm.Close()
        'Next


    End Sub



    Private Sub ResulucionToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim desktopSize As Size
        'desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        'Dim height As Integer = desktopSize.Height
        'Dim width As Integer = desktopSize.Width
        'MsgBox("Resoluicion =" + width.ToString + " -  " + height.ToString)
    End Sub

    Private Sub TlStrpSttsLbl_SQL_Click(sender As Object, e As EventArgs) Handles TlStrpSttsLbl_SQL.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TiempoIngreso.Enabled = False

        Cerrar_Forms_Children()
        Visualizar_Tiles_MDI()

        Dim NewMDIChild As New Login()
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.ControlBox = False

        TiempoIngreso.Enabled = True
        TiempoActivo = Tiempo_Str
        ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
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
            StatusStrip.Visible = False
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

            TiempoActivo = Tiempo_Str
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
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
            'NewMDIChild.WindowState = FormWindowState.Maximized
        End If
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
        pnlMovingTop.Visible = False
        'Dim listaTiles As List(Of MetroFramework.Controls.MetroTile) =
        '  (From tb As MetroFramework.Controls.MetroTile In Me.Panel2.Controls.OfType(Of MetroFramework.Controls.MetroTile)()
        '   Select tb).ToList()

        'For Each Tle As MetroFramework.Controls.MetroTile In listaTiles
        '    Tle.Visible = False
        'Next
    End Sub

    Public Sub Visualizar_Tiles_MDI()
        pnlMovingRight.Visible = True
        pnlMovingTop.Visible = True

        'Dim listaTiles As List(Of MetroFramework.Controls.MetroTile) =
        '  (From tb As MetroFramework.Controls.MetroTile In Panel2.Controls.OfType(Of MetroFramework.Controls.MetroTile)()
        '   Select tb).ToList()

        'For Each Tle As MetroFramework.Controls.MetroTile In listaTiles
        '    Tle.Visible = True
        'Next
    End Sub

    Private Sub Tle_Exportador_MouseEnter(sender As Object, e As EventArgs) Handles Tle_SolAlmuerzo.MouseEnter, Tle_Permisos.MouseEnter, Tle_MantencionColacione.MouseEnter, Tle_Liquidacion.MouseEnter, Tle_InformesAlmu.MouseEnter, Tle_Exportador.MouseEnter, Tle_Configuracion.MouseEnter, Tle_AlmuAdicional.MouseEnter, TleSolicitar_HHEE.MouseEnter, Tle_Solicitar_Permisos.MouseEnter, Tle_Asistencias_Periodo.MouseEnter
        sender.Left = sender.Left - 4
        sender.Top = sender.Top - 4
        sender.Height = sender.Height + 8
        sender.Width = sender.Width + 8
    End Sub

    Private Sub Tle_Exportador_MouseLeave(sender As Object, e As EventArgs) Handles Tle_SolAlmuerzo.MouseLeave, Tle_Permisos.MouseLeave, Tle_MantencionColacione.MouseLeave, Tle_Liquidacion.MouseLeave, Tle_InformesAlmu.MouseLeave, Tle_Exportador.MouseLeave, Tle_Configuracion.MouseLeave, Tle_AlmuAdicional.MouseLeave, TleSolicitar_HHEE.MouseLeave, Tle_Solicitar_Permisos.MouseLeave, Tle_Asistencias_Periodo.MouseLeave
        sender.Left = sender.Left + 4
        sender.Top = sender.Top + 4
        sender.Height = sender.Height - 8
        sender.Width = sender.Width - 8
    End Sub

    Private Sub TmrDesplaza_Tick(sender As Object, e As EventArgs) Handles TmrDesplaza.Tick
        pnlMovingRight.Left += DESPLAZAMIENTO
        pnlMovingTop.Top -= DESPLAZAMIENTO

        Tiempo_Animacion += 1

        If Tiempo_Animacion = CANTIDAD_DESPLAZO Then
            TmrDesplaza.Stop()
            TmrDesplaza.Enabled = False
            Tiempo_Animacion = 0
        End If

    End Sub

    Public Sub Desplazamiento_Tiles()
        pnlMovingRight.Left -= DESPLAZAMIENTO * CANTIDAD_DESPLAZO
        pnlMovingTop.Top += DESPLAZAMIENTO * CANTIDAD_DESPLAZO

        TmrDesplaza.Enabled = True
        TmrDesplaza.Start()

    End Sub

    Private Sub Panel2_VisibleChanged(sender As Object, e As EventArgs) Handles Panel2.VisibleChanged

        If Panel2.Visible = True Then
            Desplazamiento_Tiles()
        End If

    End Sub

    Private Sub Tle_Solicitar_Permisos_Click(sender As Object, e As EventArgs) Handles Tle_Solicitar_Permisos.Click
        If RevisaAcceso(90001) Then
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
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
        End If
    End Sub

    Private Sub TleSolicitar_HHEE_Click(sender As Object, e As EventArgs) Handles TleSolicitar_HHEE.Click
        If RevisaAcceso(90001) Then
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
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
        End If
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.BackColor = Color.FromArgb(255, 196, 37)
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.FromArgb(45, 137, 239)
    End Sub

    Private Sub Tle_Asistencias_Periodo_Click(sender As Object, e As EventArgs) Handles Tle_Asistencias_Periodo.Click

        Dim informe As New InformePlanillaAsistencia()

        Dim formInforme As New Frm_AsistenciasPeriodo(informe)
        Cerrar_Forms_Children()
        formInforme.MdiParent = Me
        formInforme.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(formInforme)
        Me.Panel2.Tag = formInforme
        Ocultar_Tiles_MDI()
        formInforme.Show()

        TiempoIngreso.Enabled = True
        TiempoActivo = Tiempo_Str
        ToolStripProgressBar1.ProgressBar.Value = TiempoActivo

    End Sub

End Class

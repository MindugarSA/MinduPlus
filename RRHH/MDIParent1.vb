Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class MDIParent1
    Dim conexion As New SqlConnection
    Dim dt As New DataTable
    Dim cmd As SqlCommand

    Public TiempoActivo As Integer
    Private m_ChildFormNumber As Integer
    Public Tiempo_Str As Integer = 30



    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox2_Click(sender, e)
        conexion.ConnectionString = "Data Source=FSSAPBO;Initial Catalog = SAC_Mindugar; Persist Security Info=True;User ID = sa; Password=Sqladmin281"
        'MenuStrip.Visible = False
        'ToolStrip.Visible = False
        'Dim NewMDIChild As New Principal()
        'NewMDIChild.MdiParent = Me
        'NewMDIChild.Show()
        'NewMDIChild.WindowState = FormWindowState.Maximized
        'NewMDIChild.ControlBox = False
        'Lbl_Cod_Interno1.Visible = False
        'Bttn_Pendiente.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PcturBx_Image.Click
        TiempoIngreso.Enabled = False
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        Dim NewMDIChild As New Login()
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.ControlBox = False

        TiempoIngreso.Enabled = True
        TiempoActivo = Tiempo_Str
        ToolStripProgressBar1.ProgressBar.Value = TiempoActivo


    End Sub

    Private Sub Btt_SolAlmuerzo_Click(sender As Object, e As EventArgs) Handles Btt_SolAlmuerzo.Click
        If RevisaAcceso(31001) Then
            Dim NewMDIChild As New Frm_SolicitudColacion()
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
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

    Private Sub Bttn_MantencionColacione_Click(sender As Object, e As EventArgs) Handles Bttn_MantencionColacione.Click
        If RevisaAcceso(31002) Then
            Dim NewMDIChild As New Frm_MantencionColaciones()
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()

            NewMDIChild.ControlBox = False
            TiempoIngreso.Enabled = False
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
            NewMDIChild.WindowState = FormWindowState.Maximized
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RevisaAcceso(30003) Then
            Dim NewMDIChild As New Frm_Informes()

            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RevisaAcceso(31003) Then
            Dim NewMDIChild As New Frm_Liquidaciones()



            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()

            NewMDIChild.ControlBox = False
            TiempoIngreso.Enabled = True
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
            NewMDIChild.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub Bttn_Parametros_Click(sender As Object, e As EventArgs) Handles Bttn_Parametros.Click
        If RevisaAcceso(30002) Then




            Dim NewMDIChild As New Frm_Parametros2()
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
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



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If RevisaAcceso(30001) Then

            Dim NewMDIChild As New Frm_SolicitudGerencial()
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
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
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
            Dim NewMDIChild As New Login()
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
            NewMDIChild.ControlBox = False
        End If

    End Sub


    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click
        '' Cree una nueva instancia del formulario secundario.
        'Panel2.Visible = False
        'Dim ChildForm As New System.Windows.Forms.Form
        '' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        'ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Ventana " & m_ChildFormNumber

        'ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        'Panel2.Visible = False
        'Dim OpenFileDialog As New OpenFileDialog
        'OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        'OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        'If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
        '    Dim FileName As String = OpenFileDialog.FileName
        '    ' TODO: agregue código aquí para abrir el archivo.
        'End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        'Dim SaveFileDialog As New SaveFileDialog
        'SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        'SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        'If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
        '    Dim FileName As String = SaveFileDialog.FileName
        '    ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        'End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        'Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
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







    Private Sub ResulucionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResulucionToolStripMenuItem.Click
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
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        Dim NewMDIChild As New Login()
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        NewMDIChild.ControlBox = False

        TiempoIngreso.Enabled = True
        TiempoActivo = Tiempo_Str
        ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If RevisaAcceso(90000) Then
            TiempoIngreso.Enabled = False
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
            Dim NewMDIChild As New FrmSolicPermHrasExt(0)
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
            NewMDIChild.ControlBox = False
            TiempoIngreso.Enabled = False
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
        End If
    End Sub

    Private Sub Bttn_Pendiente_Click(sender As Object, e As EventArgs) Handles Bttn_Pendiente.Click
        If RevisaAcceso(91000) Then
            TiempoIngreso.Enabled = False
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
            Dim newMDIChild As New ImportarExcelSQLServer.Form1(Me.Panel2, Me.Size.Height, Lbl_Cod_ID.Text)
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
            newMDIChild.ControlBox = False

            TiempoIngreso.Enabled = False
            TiempoActivo = Tiempo_Str
            ToolStripProgressBar1.ProgressBar.Value = TiempoActivo
            newMDIChild.WindowState = FormWindowState.Maximized
            Me.Panel2.Visible = False
        End If

    End Sub
End Class

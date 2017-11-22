Imports System.Data
Imports System.Data.SqlClient


Public Class Login

    Dim conexion As New SqlConnection
    Dim dt As New DataTable
    Dim cmd As SqlCommand
    Private p_User_Pass As String
    Public NewSystem As Boolean
    Private FocusedTxt As Integer = 0

    Private AnimationType As BunifuAnimatorNS.AnimationType = 8

    Private Sub Login_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        'Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        'Me.SuspendLayout()

        conexion.ConnectionString = Conection.Cn
        TxtBx_ConfPass.Visible = False

        MDIParent1.Panel2.Visible = False
        Dim ctl As Control
        For Each ctl In Me.Controls
            AddHandler ctl.KeyDown, AddressOf myEventHandler
        Next
        MDIParent1.Lbl_Nombre.Visible = False
        MDIParent1.Label2.Visible = False
        MDIParent1.TxtBx_Empresa.Text = ""
        MDIParent1.TxtBx_UserName.Text = ""
        MDIParent1.Lbl_RutTrab.Text = ""
        MDIParent1.Lbl_Cod_Interno.Text = ""
        MDIParent1.Lbl_Cod_ID.Visible = False
        MDIParent1.TiempoIngreso.Enabled = False
        MDIParent1.TiempoActivo = MDIParent1.Tiempo_Str
        MDIParent1.ToolStripProgressBar1.ProgressBar.Value = MDIParent1.TiempoActivo
        TxtBx_UserID.Focus()
        TxtBx_UserID.Tag = 1

        'Me.ResumeLayout()
        Animate_BackLogoIni()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        'Me.DoubleBuffered = True
        'Me.FadeInAsync()

    End Sub

    Private Sub Login_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize  ' Ubicar la Etiqueta Que Hace de Hint en la posicion correcta
        UsernameLabel.Top = TxtBx_UserID.Top + 5
        PictureBox3.Top = TxtBx_UserID.Top + 5
        PictureBox4.Top = TxtBx_Password.Top + 5
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Try
            TmrBackAnimation.Enabled = False
            TmrBackAnimation.Stop()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub UsernameTextBox_Validated(sender As Object, e As EventArgs) Handles TxtBx_UserID.Validated
        Dim Errores As String = ""

        If (Me.ActiveControl.Equals(sender)) Then ' Si se esta cerrando el Form, se salta la validacion.
            Exit Sub
        End If

        If (Len(TxtBx_UserID.Text) >= 2 And UsernameLabel.Visible = False) Then

            dt.Reset()
            Dim Num As String
            Dim DV As String
            If InStr(TxtBx_UserID.Text, "-") = 0 Then
                DV = Microsoft.VisualBasic.Right(TxtBx_UserID.Text, 1)
                Num = Microsoft.VisualBasic.Left(TxtBx_UserID.Text, Len(TxtBx_UserID.Text) - 1)
                TxtBx_UserID.Text = Num + "-" + DV
                p_User_Pass = ""
            End If
            cmd = New SqlCommand("PassIniciarSesion", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            conexion.Open()
            cmd.Parameters.Add(New SqlParameter("@Sistema", "RRHH"))
            cmd.Parameters.Add(New SqlParameter("@Usuario", TxtBx_UserID.Text))
            Try
                dt.Load(cmd.ExecuteReader())

                If dt.Rows.Count > 0 Then
                    If dt.Rows(0)("IdEstado") >= 0 Then
                        NewSystem = True

                        MDIParent1.Lbl_Nombre.Visible = True
                        MDIParent1.Label2.Visible = True
                        MDIParent1.Lbl_Nombre.Text = dt.Rows(0)("Nombre").ToString.ToUpper
                        MDIParent1.Label2.Text = dt.Rows(0)("Empresa").ToString.ToUpper

                        MDIParent1.TxtBx_UserName.Text = dt.Rows(0)("Nombre").ToString.ToUpper
                        MDIParent1.TxtBx_Empresa.Text = dt.Rows(0)("Empresa").ToString.ToUpper
                        MDIParent1.Lbl_Cod_ID.Text = dt.Rows(0)("IdUsuario").ToString
                        MDIParent1.Lbl_RutEmpresa.Text = dt.Rows(0)("RutEmp").ToString

                        MDIParent1.NombreUsuario = dt.Rows(0)("Nombre").ToString.ToUpper
                        MDIParent1.NombreEmpresa = dt.Rows(0)("Empresa").ToString.ToUpper
                        MDIParent1.RutUsuario = dt.Rows(0)("Rut").ToString
                        MDIParent1.RutEmpresa = dt.Rows(0)("RutEmp").ToString

                    End If
                Else
                    MetroFramework.MetroMessageBox.Show(MdiParent, "Numero de RUT No Registrado en la Base de Datos",
                                                        "RUT Sin Coincidencia",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information,
                                                        370)
                    TxtBx_UserID.Focus()
                End If

            Catch ex As Exception
                MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
            Finally
                conexion.Close()
            End Try


            If (dt.Rows.Count > 0) Then

                If (dt.Rows(0)("IdEstado") < 0) Then
                    MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.Red
                    MDIParent1.TlStrpSttsLbl_SQL.ForeColor = Color.White
                    MDIParent1.TlStrpSttsLbl_SQL.Text = dt.Rows(0)("EstadoUsr").ToString
                    TxtBx_UserID.Text = ""
                    TxtBx_UserID.Focus()
                    TxtBx_Password.Text = ""
                    p_User_Pass = ""

                ElseIf Format("{0}", dt.Rows(0)("f_finiquito") < Date.Now) Then
                    MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.Red
                    MDIParent1.TlStrpSttsLbl_SQL.ForeColor = Color.White
                    MDIParent1.TlStrpSttsLbl_SQL.Text = "Favor de Pasar al Depto. de Personal"
                    TxtBx_UserID.Text = ""
                    TxtBx_Password.Text = ""
                    p_User_Pass = ""
                    TxtBx_UserID.Focus()
                Else

                    MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.White
                    MDIParent1.TlStrpSttsLbl_SQL.ForeColor = Color.Black
                    MDIParent1.TlStrpSttsLbl_SQL.Text = "Consulta Realizada con Exito"
                    TxtBx_UserID.Text = dt.Rows(0)("Rut").ToString
                    'TxtBx_Password.Text = Trim(dt.Rows(0)("Pass").ToString)

                    'p_User_Pass = Trim(dt.Rows(0)("Pass").ToString)
                    TxtBx_Password.Focus()
                    TxtBx_Password.Tag = 1
                    If MDIParent1.Lbl_Cod_ID.Text = "0" Then
                        TxtBx_ConfPass.Visible = True
                        TxtBx_ConfPass.Tag = 1
                        'p_User_Pass = ""
                    End If

                    MDIParent1.Lbl_Nombre.Visible = True
                    MDIParent1.Label2.Visible = True
                    MDIParent1.Lbl_Nombre.Text = dt.Rows(0)("Nombre").ToString.ToUpper
                    MDIParent1.Label2.Text = dt.Rows(0)("Empresa").ToString.ToUpper

                    MDIParent1.TxtBx_UserName.Text = dt.Rows(0)("Nombre").ToString.ToUpper
                    MDIParent1.TxtBx_Empresa.Text = dt.Rows(0)("Empresa").ToString.ToUpper
                    MDIParent1.Lbl_Cod_ID.Text = dt.Rows(0)("IdUsuario").ToString
                    MDIParent1.Lbl_Cod_ID.Refresh()
                    MDIParent1.Lbl_RutTrab.Text = TxtBx_UserID.Text
                    MDIParent1.Lbl_RutEmpresa.Text = dt.Rows(0)("RutEmp").ToString

                    MDIParent1.NombreUsuario = dt.Rows(0)("Nombre").ToString.ToUpper
                    MDIParent1.NombreEmpresa = dt.Rows(0)("Empresa").ToString.ToUpper
                    MDIParent1.RutUsuario = dt.Rows(0)("Rut").ToString
                    MDIParent1.RutEmpresa = dt.Rows(0)("RutEmp").ToString
                    Try
                        MDIParent1.PcturBx_Image.Image = Image.FromFile("\\FSSAPBO\gestper\Mindugar_sa\Images\" + dt.Rows(0)("Rut_Empleado").ToString + ".jpg")
                    Catch ex As Exception
                    End Try
                End If
            End If
        Else
            TxtBx_UserID.Focus()
        End If
    End Sub

    '----------Funcion Declare tecla Enter--------
    Private Sub myEventHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub
    '----------Fin Funcion Declare tecla Entrer--------
    Private Sub Bttn_Login_Click(sender As Object, e As EventArgs) Handles Bttn_Login.Click
        'UsernameTextBox_Validated(sender, e)
        If NewSystem = True Then
            If TxtBx_ConfPass.Tag = 0 Then
                dt.Reset()
                cmd = New SqlCommand("PassIniciarSesion", conexion)
                cmd.CommandType = CommandType.StoredProcedure
                conexion.Open()
                Dim Usuario = MDIParent1.Lbl_RutTrab.Text
                cmd.Parameters.Add(New SqlParameter("@Usuario", MDIParent1.Lbl_RutTrab.Text))
                cmd.Parameters.Add(New SqlParameter("@Contraseña", TxtBx_Password.Text))
                cmd.Parameters.Add(New SqlParameter("@Sistema", "RRHH"))
                Try
                    dt.Load(cmd.ExecuteReader())

                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error!")
                Finally
                    conexion.Close()
                End Try


                If dt.Rows(0)("IdEstado") = 0 Then

                    MDIParent1.Panel2.Visible = True
                    MDIParent1.TiempoIngreso.Enabled = True
                    MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.White
                    MDIParent1.TlStrpSttsLbl_SQL.Text = ""

                    'MDIParent1.ToolStripVisible = False
                    Me.Close()
                Else
                    TxtBx_Password.Text = ""
                    TxtBx_Password.Focus()
                End If

            Else
                If (TxtBx_ConfPass.Text = TxtBx_Password.Text) And Trim(TxtBx_ConfPass.Text) <> "" Then
                    dt.Reset()
                    cmd = New SqlCommand("PassUsuariosGes", conexion)
                    cmd.CommandType = CommandType.StoredProcedure
                    conexion.Open()
                    cmd.Parameters.Add(New SqlParameter("@IdUsuario", 0))
                    cmd.Parameters.Add(New SqlParameter("@Usuario", MDIParent1.Lbl_RutTrab.Text))
                    cmd.Parameters.Add(New SqlParameter("@Activo", 0))
                    cmd.Parameters.Add(New SqlParameter("@Nombre", MDIParent1.TxtBx_UserName.Text))
                    cmd.Parameters.Add(New SqlParameter("@IdPerfilPred", 1))
                    cmd.Parameters.Add(New SqlParameter("@NumSerie", "-"))
                    cmd.Parameters.Add(New SqlParameter("@Contraseña", TxtBx_Password.Text))
                    Try
                        dt.Load(cmd.ExecuteReader())
                        If dt.Rows(0)("IdEstado") = 0 Then
                            MDIParent1.Lbl_Cod_ID.Text = dt.Rows(0)("IdUsuario").ToString()

                            MDIParent1.Panel2.Visible = True
                            MDIParent1.TiempoIngreso.Enabled = True
                            MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.White
                            MDIParent1.TlStrpSttsLbl_SQL.Text = ""
                            Me.Close()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error!")
                    Finally
                        conexion.Close()
                    End Try
                    'Permisos otorgados al grear clave
                    Dim vlstId As String = "31001,31003," 'Solicitar almuerzos e Imprimir Liquidaciones
                    If vlstId.Length > 0 Then
                        cmd = New SqlCommand("PassAtributosUsuarioAgregaGes", conexion)
                        cmd.CommandType = CommandType.StoredProcedure
                        conexion.Open()
                        cmd.Parameters.Add(New SqlParameter("@IdUsuario", MDIParent1.Lbl_Cod_ID.Text))
                        cmd.Parameters.Add(New SqlParameter("@IdAtributo", vlstId))
                        Try
                            dt.Load(cmd.ExecuteReader())
                        Catch ex As Exception
                            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error!")
                        Finally
                            conexion.Close()
                        End Try
                    End If

                End If
            End If
        Else
            If TxtBx_ConfPass.Tag = 1 Then
                If (TxtBx_ConfPass.Text = TxtBx_Password.Text) And Trim(TxtBx_ConfPass.Text) <> "" Then

                    dt.Reset()
                    cmd = New SqlCommand("Colaciones_Empresa_Ges", conexion)
                    cmd.CommandType = CommandType.StoredProcedure
                    conexion.Open()
                    cmd.Parameters.Add(New SqlParameter("@RutEmpleado", MDIParent1.Lbl_RutTrab.Text))
                    cmd.Parameters.Add(New SqlParameter("IdUsuario", MDIParent1.Lbl_Cod_Interno.Text))
                    cmd.Parameters.Add(New SqlParameter("@Password", TxtBx_ConfPass.Text))
                    Try
                        dt.Load(cmd.ExecuteReader())

                    Catch ex As Exception
                        MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
                    Finally
                        conexion.Close()
                    End Try

                    If dt.Rows(0)("IdEstado") = 0 Then
                        MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.White
                        MDIParent1.TlStrpSttsLbl_SQL.ForeColor = Color.Black
                        MDIParent1.TlStrpSttsLbl_SQL.Text = dt.Rows(0)("EstadoUsr")
                        TxtBx_ConfPass.Visible = False
                        TxtBx_ConfPass.Tag = 0
                        p_User_Pass = TxtBx_ConfPass.Text

                    End If
                    UsernameTextBox_Validated(sender, e)
                    If p_User_Pass <> "" And p_User_Pass = TxtBx_Password.Text Then
                        'Pendiente Guarda fecha y hora de ingreso

                        MDIParent1.Panel2.Visible = True
                        MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.White
                        MDIParent1.TlStrpSttsLbl_SQL.Text = ""

                        Me.Close()
                    End If
                End If
            Else
                If p_User_Pass <> "" And p_User_Pass = TxtBx_Password.Text Then

                    MDIParent1.Panel2.Visible = True
                    MDIParent1.TiempoIngreso.Enabled = True
                    MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.White
                    MDIParent1.TlStrpSttsLbl_SQL.Text = ""
                    Me.Close()
                Else
                    TxtBx_Password.Text = ""
                    TxtBx_Password.Focus()
                    FocusedTxt = 2
                End If
            End If

        End If

    End Sub

    Private Sub Bttn_1_Enter(sender As Object, e As EventArgs) Handles Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click, Label12.Click, Label11.Click, Label10.Click, Label1.Click

        Select Case FocusedTxt
            Case 1 'TxtBx_UserID

                If sender.text = "C" And TxtBx_UserID.Text <> "" Then
                    SendKeys.Send("{BACKSPACE}")
                ElseIf sender.text <> "C" Then
                    SendKeys.Send(sender.text)
                End If

                TxtBx_UserID.Focus()

            Case 2 'TxtBx_Password

                If sender.text = "C" And TxtBx_Password.Text <> "" Then
                    SendKeys.Send("{BACKSPACE}")
                ElseIf sender.text <> "C" Then
                    SendKeys.Send(sender.text)
                End If
                TxtBx_Password.Focus()

            Case 3 'TxtBx_ConfPass

                If sender.text = "C" And TxtBx_ConfPass.Text <> "" Then
                    SendKeys.Send("{BACKSPACE}")
                ElseIf sender.text <> "C" Then
                    SendKeys.Send(sender.text)
                End If
                TxtBx_ConfPass.Focus()

        End Select

    End Sub

    Private Sub Bttn_Login_MouseEnter(sender As Object, e As EventArgs) Handles Bttn_Login.MouseEnter

        Bttn_Login.Left = Bttn_Login.Left - 3
        Bttn_Login.Top = Bttn_Login.Top - 3
        Bttn_Login.Height = Bttn_Login.Height + 6
        Bttn_Login.Width = Bttn_Login.Width + 6

    End Sub

    Private Sub Bttn_Login_MouseLeave(sender As Object, e As EventArgs) Handles Bttn_Login.MouseLeave

        Bttn_Login.Left = Bttn_Login.Left + 3
        Bttn_Login.Top = Bttn_Login.Top + 3
        Bttn_Login.Height = Bttn_Login.Height - 6
        Bttn_Login.Width = Bttn_Login.Width - 6

    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label2.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter

        'Segoe UI, 14,25pt, style=Bold
        CType(sender, Label).Font = New Font("Segoe UI", 19, FontStyle.Bold)

    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave, Label8.MouseLeave, Label7.MouseLeave, Label6.MouseLeave, Label5.MouseLeave, Label4.MouseLeave, Label3.MouseLeave, Label2.MouseLeave, Label12.MouseLeave, Label11.MouseLeave, Label10.MouseLeave, Label1.MouseLeave

        CType(sender, Label).Font = New Font("Segoe UI", 14.25, FontStyle.Bold)

    End Sub

    Private Sub TxtBx_UserID_Enter(sender As Object, e As EventArgs) Handles TxtBx_UserID.Enter

        FocusedTxt = 1
        If (TxtBx_UserID.Text.Trim = "") Then
            UsernameLabel.Visible = True
        End If


    End Sub

    Private Sub TxtBx_UserID_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBx_UserID.KeyDown

        If (UsernameLabel.Visible = True And TxtBx_UserID.Text.Trim().Length > 0) Then
            UsernameLabel.Visible = False
        ElseIf (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            Parent.SelectNextControl(TxtBx_UserID, True, True, True, True)
            e.Handled = True
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub TxtBx_UserID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBx_UserID.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Back) OrElse
            e.KeyChar = Convert.ToChar(Keys.Delete) OrElse
            e.KeyChar = Convert.ToChar(Keys.Left) OrElse
            e.KeyChar = Convert.ToChar(Keys.Right) OrElse
            e.KeyChar.ToString.ToUpper() = Convert.ToChar("K") OrElse
            IsNumber(e.KeyChar.ToString()) Then

            Dim tbtmp As TextBox = TryCast(sender, TextBox)
            If e.KeyChar = "."c Then
                e.Handled = True
            Else
                e.Handled = False
            End If

        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TxtBx_UserID_TextChanged(sender As Object, e As EventArgs) Handles TxtBx_UserID.TextChanged  ' Oculta la Etiqueta que hace de Hint
        If (UsernameLabel.Visible = True) Then
            UsernameLabel.Visible = False
        ElseIf (UsernameLabel.Visible = False And TxtBx_UserID.Text.Trim().Length = 0) Then
            UsernameLabel.Visible = True
        End If
    End Sub

    Private Sub TxtBx_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBx_Password.KeyDown  ' Al presionar enter, envia TAB
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
            e.Handled = e.SuppressKeyPress = True
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TxtBx_Password_Enter(sender As Object, e As EventArgs) Handles TxtBx_Password.Enter  ' Al hacer Focus se cambia el Tag
        FocusedTxt = 2
    End Sub

    Private Sub TxtBx_ConfPass_Enter(sender As Object, e As EventArgs) Handles TxtBx_ConfPass.Enter
        FocusedTxt = 3
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TmrBackAnimation.Tick  'Ejecuta la Animacion en cada TICK

        If TmrBackAnimation.Interval = 5000 Then
            TmrBackAnimation.Stop()
            TmrBackAnimation.Enabled = False
            'If Entrada > 1 Then
            Animate_BackLogo()
            ' End If
        End If

    End Sub

    Private Sub Animate_BackLogoIni() ' Animacion Inicial SHOW

        Try
            PictureBox1.Visible = False
            PictureBox1.BringToFront()

            BunifuTransition1.AnimationType = AnimationType
            BunifuTransition1.ShowSync(PictureBox1)

            Select Case AnimationType
                Case 4
                    AnimationType = 8
            'Case 7
            '    AnimationType = 8
                Case 8
                    AnimationType = 4
            End Select

            TmrBackAnimation.Enabled = True
            TmrBackAnimation.Start()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Animate_BackLogo() ' Animacion Activada por el TIMER

        Try
            If (PictureBox1.Visible = True) Then
                BunifuTransition1.HideSync(PictureBox1)
            End If

            PictureBox1.Visible = False
            PictureBox1.BringToFront()

            BunifuTransition1.AnimationType = AnimationType
            BunifuTransition1.ShowSync(PictureBox1)

            Select Case AnimationType
                Case 4
                    AnimationType = 8
            'Case 7
            '    AnimationType = 8
                Case 8
                    AnimationType = 4
            End Select

            TmrBackAnimation.Enabled = True
            TmrBackAnimation.Start()
        Catch ex As Exception

        End Try

    End Sub

    Public Function IsNumber(inputvalue As String) As Boolean

        Dim isnumber__1 As New System.Text.RegularExpressions.Regex("^[0-9]*$")
        'Dim isnumber__1 As New System.Text.RegularExpressions.Regex("^-?[0-9]+(\.?[0-9]+)?$")
        Return isnumber__1.IsMatch(inputvalue)

    End Function

End Class
Imports System.Data
Imports System.Data.SqlClient



Public Class Login
    Dim conexion As New SqlConnection
    Dim dt As New DataTable
    Dim cmd As SqlCommand
    Private p_User_Pass As String
    Public NewSystem As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.ConnectionString = "Data Source=FSSAPBO;Initial Catalog = SAC_Mindugar; Persist Security Info=True;User ID = sa; Password=Sqladmin281"
        Lbl__ConfPass.Visible = False
        TxtBx_ConfPass.Visible = False

        MDIParent1.Panel2.Visible = False
        Dim ctl As Control
        For Each ctl In Me.Controls
            AddHandler ctl.KeyDown, AddressOf myEventHandler
        Next
        MDIParent1.TxtBx_Empresa.Text = ""
        MDIParent1.TxtBx_UserName.Text = ""
        MDIParent1.Lbl_RutTrab.Text = ""
        MDIParent1.Lbl_Cod_Interno.Text = ""
        MDIParent1.Lbl_Cod_ID.Text = ""
        MDIParent1.TiempoIngreso.Enabled = False
        MDIParent1.TiempoActivo = MDIParent1.Tiempo_Str
        MDIParent1.ToolStripProgressBar1.ProgressBar.Value = MDIParent1.TiempoActivo
        TxtBx_UserID.Focus()
        TxtBx_UserID.Tag = 1
    End Sub

    Private Sub UsernameTextBox_Validated(sender As Object, e As EventArgs) Handles TxtBx_UserID.Validated
        Dim Errores As String = ""
        If Len(TxtBx_UserID.Text) >= 2 Then

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

                If dt.Rows(0)("IdEstado") >= 0 Then
                    NewSystem = True
                    MDIParent1.TxtBx_UserName.Text = dt.Rows(0)("Nombre").ToString
                    MDIParent1.TxtBx_Empresa.Text = dt.Rows(0)("Empresa").ToString
                    MDIParent1.Lbl_Cod_ID.Text = dt.Rows(0)("IdUsuario").ToString
                    MDIParent1.Lbl_RutEmpresa.Text = dt.Rows(0)("RutEmp").ToString
                End If


            Catch ex As Exception
                MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
            Finally
                conexion.Close()
            End Try


            'If NewSystem = False Then
            '    cmd = New SqlCommand("Colaciones_Empresa", conexion)
            '    cmd.CommandType = CommandType.StoredProcedure
            '    conexion.Open()
            '    cmd.Parameters.Add(New SqlParameter("@RutBuscado", TxtBx_UserID.Text))
            '    Try
            '        dt.Load(cmd.ExecuteReader())

            '    Catch ex As Exception
            '        Errores = ex.ToString
            '        'MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")

            '    Finally
            '        conexion.Close()
            '    End Try
            'End If
            'Dim value As String = String.Format("{0}", dt.Rows(0)("f_finiquito"))
            'value = String.Format("{0}", dt.Rows(0)("fecingreso"))


            If dt.Rows(0)("IdEstado") < 0 Then
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

                MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.AliceBlue
                MDIParent1.TlStrpSttsLbl_SQL.ForeColor = Color.Black
                MDIParent1.TlStrpSttsLbl_SQL.Text = "Consulta Realizada con exito"
                TxtBx_UserID.Text = dt.Rows(0)("Rut").ToString
                'TxtBx_Password.Text = Trim(dt.Rows(0)("Pass").ToString)

                'p_User_Pass = Trim(dt.Rows(0)("Pass").ToString)
                TxtBx_Password.Focus()
                If MDIParent1.Lbl_Cod_ID.Text = "0" Then
                    Lbl__ConfPass.Visible = True
                    TxtBx_ConfPass.Visible = True
                    TxtBx_ConfPass.Tag = 1
                    'p_User_Pass = ""
                End If
                MDIParent1.TxtBx_UserName.Text = dt.Rows(0)("Nombre").ToString
                MDIParent1.TxtBx_Empresa.Text = dt.Rows(0)("Empresa").ToString
                MDIParent1.Lbl_Cod_ID.Text = dt.Rows(0)("IdUsuario").ToString
                MDIParent1.Lbl_Cod_ID.Refresh()
                MDIParent1.Lbl_RutTrab.Text = TxtBx_UserID.Text
                MDIParent1.Lbl_RutEmpresa.Text = dt.Rows(0)("RutEmp").ToString
                Try
                    MDIParent1.PcturBx_Image.Image = Image.FromFile("\\FSSAPBO\gestper\Mindugar_sa\Images\" + dt.Rows(0)("Rut_Empleado").ToString + ".jpg")
                Catch ex As Exception
                End Try
            End If
        Else
            TxtBx_UserID.Focus()
        End If
    End Sub




























    '----------Funcion Declare tecla Entrer--------
    Private Sub myEventHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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
                        MDIParent1.TlStrpSttsLbl_SQL.BackColor = Color.AliceBlue
                        MDIParent1.TlStrpSttsLbl_SQL.ForeColor = Color.Black
                        MDIParent1.TlStrpSttsLbl_SQL.Text = dt.Rows(0)("EstadoUsr")
                        Lbl__ConfPass.Visible = False
                        TxtBx_ConfPass.Visible = False
                        TxtBx_ConfPass.Tag = 0
                        p_User_Pass = TxtBx_ConfPass.Text




                    End If
                    UsernameTextBox_Validated(sender, e)
                    If p_User_Pass <> "" And p_User_Pass = TxtBx_Password.Text Then
                        'Pendiente Guarda fecha y hora de ingreso

                        MDIParent1.Panel2.Visible = True
                        Me.Close()
                    End If
                End If
            Else
                If p_User_Pass <> "" And p_User_Pass = TxtBx_Password.Text Then
                    MDIParent1.Panel2.Visible = True
                    MDIParent1.TiempoIngreso.Enabled = True
                    Me.Close()
                Else
                    TxtBx_Password.Text = ""
                    TxtBx_Password.Focus()
                End If
            End If

        End If




    End Sub






    Private Sub TxtBx_Select_Click(sender As Object, e As EventArgs) Handles TxtBx_Password.Click
        If TxtBx_UserID.Tag = 1 Then
            TxtBx_UserID.Tag = 0
            TxtBx_Password.Tag = 1
        ElseIf TxtBx_Password.Tag = 1 Then
            TxtBx_UserID.Tag = 1
            TxtBx_Password.Tag = 0
        End If
    End Sub







    Private Sub Bttn_1_Enter(sender As Object, e As EventArgs) Handles Label1.Click, Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click, Label12.Click, Label11.Click, Label10.Click
        If TxtBx_UserID.Tag = 1 Then
            If sender.text = "C" And TxtBx_UserID.Text <> "" Then
                TxtBx_UserID.Text = Mid(TxtBx_UserID.Text, 1, Len(TxtBx_UserID.Text) - 1)
            ElseIf sender.text <> "C" Then
                TxtBx_UserID.Text = TxtBx_UserID.Text + sender.text
            End If

            TxtBx_UserID.Focus()

        ElseIf TxtBx_Password.Tag = 1 Then
            If sender.text = "C" And TxtBx_Password.Text <> "" Then
                TxtBx_Password.Text = Mid(TxtBx_Password.Text, 1, Len(TxtBx_Password.Text) - 1)
            ElseIf sender.text <> "C" Then
                TxtBx_Password.Text = TxtBx_Password.Text + sender.text
            End If
            TxtBx_Password.Focus()
        End If
    End Sub

End Class
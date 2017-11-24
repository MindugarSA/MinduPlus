Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_Parametros2

    Private enableBuscarRutInforme As Boolean = True
    Private enableBuscarNombreInforme As Boolean = True
    Private enableBuscarInforme As Boolean = False
    Private trabajadorInforme As New Persona()
    Private DtUsuariosPass As DataTable
    Private ListaPersonas As List(Of Persona)
    Private EmpleadoActual As Persona

    Dim vDateInfo As DateTime
    Dim dt As New DataTable
    Dim conexion As New SqlConnection
    Dim cmd As SqlCommand
    Dim SelLin As Integer

    Public Sub New()

        Dim skinManager As MaterialSkin.MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance
        skinManager.ROBOTO_MEDIUM_10 = New Font("Segoe UI Light", 10)
        skinManager.ROBOTO_MEDIUM_11 = New Font("Segoe UI Light", 11)
        skinManager.ROBOTO_MEDIUM_12 = New Font("Segoe UI Light", 12)
        skinManager.ROBOTO_REGULAR_11 = New Font("Segoe UI Light", 10)
        skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT
        skinManager.ColorScheme = New MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500, MaterialSkin.Primary.LightBlue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE)

        InitializeComponent()
        MetroTabControl1.SelectedIndex = 0

    End Sub

    Private Sub Frm_Parametros2_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.ConnectionString = Conection.Cn
        Dim ctl As Control
        For Each ctl In Me.Controls
            AddHandler ctl.KeyDown, AddressOf myEventHandler
        Next

        CmbBx_Usuarios.Visible = False
        TxtBx_Empleado.Visible = False
        Label13.Visible = False
        PictureBox1.Visible = False
        PictureBox2.Visible = False

        AutocompletarNombreRut("")
        CargaUsuarios(1)
        MetroTextBox2.Focus()
        'LLenaDatosUsuario()


    End Sub

    Private Sub myEventHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub
    Private Sub TreeView1_Click(sender As Object, e As EventArgs) Handles TreeView1.Click
        Try
            If UCase(TreeView1.SelectedNode.Name) = UCase("Nd_Permisos") Then
                Lbl_Titulo.Text = "   Gestion de Usuarios"
                LLenaDatosUsuario()

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CargaUsuarios(Sistema As Integer)
        cmd = New SqlCommand("PassUsuariosInfo", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.Open()
        cmd.Parameters.Add(New SqlParameter("@Id_Entidades", Sistema))
        Dim dtUser As New DataTable
        Try
            dt.Load(cmd.ExecuteReader())
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
        Finally
            conexion.Close()
            Dim adaptador As New SqlDataAdapter(cmd)
            adaptador.Fill(dtUser)
            If dtUser.Rows(0)("IdEstado") = 0 Then
                With CmbBx_Usuarios
                    .DataSource = dtUser
                    .DisplayMember = "Usuario"
                    .ValueMember = "IdUsuario"
                    .SelectedIndex = 0
                End With
            End If
        End Try



    End Sub
    Private Sub LLenaDatosUsuario(Optional IDUsuario As Integer = 0)

        DtGrdVw_PermisosNo.DataSource = Nothing
        DtGrdVw_PermisosSi.DataSource = Nothing
        DtGrdVw_PermisosNo.Rows.Clear()
        DtGrdVw_PermisosSi.Rows.Clear()

        If (IDUsuario = 0) Then

            IDUsuario = CmbBx_Usuarios.SelectedValue

        ElseIf (IDUsuario > 0) Then

            cmd = New SqlCommand("PassUsuariosInfo", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            conexion.Open()
            cmd.Parameters.Add(New SqlParameter("@IdUsuario", IDUsuario))
            Dim dtUser As New DataTable
            Try
                dtUser.Load(cmd.ExecuteReader())
                TxtBx_Empleado.Text = dtUser.Rows(0)("Nombre").ToString()
                TxtBx_FechaMod.Text = dtUser.Rows(0)("FecModif").ToString()


            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error!")
            Finally
                conexion.Close()
            End Try

            Dim cmd1 As SqlCommand
            cmd1 = New SqlCommand("PassAtributosUsuarioAutorizadoNoInfo", conexion)
            cmd1.CommandType = CommandType.StoredProcedure
            conexion.Open()
            cmd1.Parameters.Add(New SqlParameter("@IdUsuario", IDUsuario))
            cmd1.Parameters.Add(New SqlParameter("@IdEntidad", 1))
            Dim adapter As New SqlDataAdapter(cmd1)
            Dim table1 As DataTable = New DataTable()

            adapter.Fill(table1)

            If table1.Rows(0)("IdEstado") = 0 Then

                For i = 0 To table1.Rows.Count - 1
                    DtGrdVw_PermisosNo.Rows.Add(1)
                    DtGrdVw_PermisosNo.Rows(i).Cells("SelNo").Value = "False"
                    DtGrdVw_PermisosNo.Rows(i).Cells("IdAtributoNo").Value = table1.Rows(i)("IdAtributo")
                    DtGrdVw_PermisosNo.Rows(i).Cells("AtributoNo").Value = table1.Rows(i)("Atributo")

                Next
            Else
                DtGrdVw_PermisosNo.Rows.Clear()
            End If
            conexion.Close()
            adapter.Dispose()
            cmd = New SqlCommand("PassAtributosUsuarioAutorizadoSiInfo", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            conexion.Open()
            cmd.Parameters.Add(New SqlParameter("@IdUsuario", IDUsuario))
            adapter = New SqlDataAdapter(cmd)
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)
            If table.Rows(0)("IdEstado") = 0 Then
                For i = 0 To table.Rows.Count - 1
                    DtGrdVw_PermisosSi.Rows.Add(1)
                    DtGrdVw_PermisosSi.Rows(i).Cells("SelSi").Value = "False"
                    DtGrdVw_PermisosSi.Rows(i).Cells("IdAtributoSi").Value = table.Rows(i)("IdAtributo")
                    DtGrdVw_PermisosSi.Rows(i).Cells("AtributoSi").Value = table.Rows(i)("Atributo")
                Next
            Else
                DtGrdVw_PermisosSi.Rows.Clear()
            End If

            conexion.Close()
            adapter.Dispose()

        End If

    End Sub

    Private Sub Bttn_Actualiza_Click(sender As Object, e As EventArgs) Handles Bttn_Actualiza.Click
        Dim vlstId As String = ObtenerActivosGvPermPend()
        Dim dt As New DataTable
        If vlstId.Length > 0 Then
            cmd = New SqlCommand("PassAtributosUsuarioAgregaGes", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            conexion.Open()
            cmd.Parameters.Add(New SqlParameter("@IdUsuario", CmbBx_Usuarios.SelectedValue))
            cmd.Parameters.Add(New SqlParameter("@IdAtributo", vlstId))
            Try
                dt.Load(cmd.ExecuteReader())
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error!")
            Finally
                conexion.Close()
            End Try
        End If
        'Borra los Marcados
        vlstId = ObtenerActivosGvPermDados()
        If vlstId.Length > 0 Then
            cmd = New SqlCommand("PassAtributosUsuarioDeleteGes", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            conexion.Open()
            cmd.Parameters.Add(New SqlParameter("@IdUsuario", CmbBx_Usuarios.SelectedValue))
            cmd.Parameters.Add(New SqlParameter("@IdAtributo", vlstId))
            Try
                dt.Load(cmd.ExecuteReader())
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error!")
            Finally
                conexion.Close()
            End Try
        End If
        LLenaDatosUsuario(CmbBx_Usuarios.SelectedValue)

    End Sub

    Function ObtenerActivosGvPermPend() As String
        'Obtiene identificadores de elementos marcados con ticket activo en GridView
        Dim vActivos As String = ""
        For i = 0 To DtGrdVw_PermisosNo.RowCount - 1
            If DtGrdVw_PermisosNo.Rows(i).Cells("SelNo").Value = True Then
                vActivos = vActivos & ", " & DtGrdVw_PermisosNo.Rows(i).Cells("IdAtributoNo").Value
            End If
        Next


        If vActivos.Length > 0 Then vActivos = Mid(vActivos, 3) + ","

        ObtenerActivosGvPermPend = vActivos
    End Function


    Function ObtenerActivosGvPermDados() As String
        Dim vActivos As String = ""
        For i = 0 To DtGrdVw_PermisosSi.RowCount - 1
            If DtGrdVw_PermisosSi.Rows(i).Cells("SelSi").Value = True Then
                vActivos = vActivos & ", " & DtGrdVw_PermisosSi.Rows(i).Cells("IdAtributoSi").Value
            End If
        Next
        If vActivos.Length > 0 Then vActivos = Mid(vActivos, 3) + ","
        ObtenerActivosGvPermDados = vActivos
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MDIParent1.Visualizar_Tiles_MDI()
        MDIParent1.Desplazamiento_Tiles()
        MDIParent1.TiempoIngreso.Enabled = True
        Me.Close()
    End Sub

    Private Sub CmbBx_Usuarios_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbBx_Usuarios.SelectionChangeCommitted
        'LLenaDatosUsuario()
    End Sub

    Private Sub AutocompletarNombreRut(empresa As String)
        Dim listaNombre As New AutoCompleteStringCollection()
        Dim listaRut As New AutoCompleteStringCollection()
        Try
            ListaPersonas = Persona.ListarTodos()
            ListaPersonas = ListaPersonas.Where(Function(s) s.Estado = "A").ToList()

            For Each persona__1 As Persona In ListaPersonas
                listaNombre.Add(persona__1.Nombre)
                listaRut.Add(persona__1.Rut)
            Next
            MetroTextBox1.AutoCompleteCustomSource = listaNombre

            MetroTextBox2.AutoCompleteCustomSource = listaRut
        Catch ex As Exception
            MessageBox.Show("error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub MetroTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBox1.TextChanged
        If enableBuscarRutInforme Then
            Try
                enableBuscarNombreInforme = False
                trabajadorInforme.Nombre = MetroTextBox1.Text
                trabajadorInforme.BuscarRutPorNombre()
                MetroTextBox2.Text = trabajadorInforme.Rut
                enableBuscarInforme = False
                enableBuscarNombreInforme = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub MetroTextBox2_TextChanged(sender As Object, e As EventArgs) Handles MetroTextBox2.TextChanged
        If enableBuscarNombreInforme Then
            Try
                enableBuscarRutInforme = False
                trabajadorInforme.Rut = MetroTextBox2.Text
                trabajadorInforme.BuscarNombrePorRut()
                MetroTextBox1.Text = trabajadorInforme.Nombre
                enableBuscarInforme = False
                enableBuscarRutInforme = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub MetroTextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles MetroTextBox2.KeyUp, MetroTextBox1.KeyUp
        If (e.KeyData = Keys.Return) Then
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (MetroTextBox2.Text.Trim().Length = 11) Then
            '    Dim IDuser As Integer = dt.Select(String.Format("ItemID = '{0}'", MetroTextBox2.Text.Trim()))

            Dim IdUsuario = dt.AsEnumerable() _
                        .Where(Function(row) Convert.ToString(row("Usuario")).Trim() = MetroTextBox2.Text.Trim()) _
                        .[Select](Function(row) row.Field(Of Integer)("IdUsuario")) _
                        .FirstOrDefault().ToString()

            EmpleadoActual = ListaPersonas.FirstOrDefault(Function(x) x.Rut = MetroTextBox2.Text.Trim())
            EmpleadoActual.IDUsuario = IdUsuario
            Dim Estado As String = EmpleadoActual.Estado

            FormatearTabControl(IdUsuario, EmpleadoActual)
            LLenaDatosUsuario(IdUsuario)


        End If
    End Sub

    Private Sub FormatearTabControl(IdUsuario As Integer, Empleado As Persona)

        If (IdUsuario <> 0) Then
            CmbBx_Usuarios.SelectedValue = IdUsuario
            Label13.Visible = False
            Label12.Text = MetroTextBox2.Text.Trim()
            Label11.Text = MetroTextBox1.Text.Trim()
            Label19.Text = "---"
            Label17.Text = "---"
            MaterialSingleLineTextField3.Text = ""
            MaterialSingleLineTextField3.Text = ""
            MaterialSingleLineTextField1.Text = ""
            MaterialSingleLineTextField2.Text = ""
            MaterialSingleLineTextField3.Enabled = True
            MaterialSingleLineTextField4.Enabled = True
            MaterialSingleLineTextField1.Enabled = False
            MaterialSingleLineTextField2.Enabled = False
            Bttn_Actualiza.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = False
            MetroTabControl1.SelectedIndex = 0

        Else
            IdUsuario = -1
            Label13.Visible = True
            Label12.Text = "---"
            Label11.Text = "---"
            Label19.Text = MetroTextBox2.Text.Trim()
            Label17.Text = MetroTextBox1.Text.Trim()
            MaterialSingleLineTextField3.Text = ""
            MaterialSingleLineTextField4.Text = ""
            MaterialSingleLineTextField1.Text = ""
            MaterialSingleLineTextField2.Text = ""
            MaterialSingleLineTextField3.Enabled = False
            MaterialSingleLineTextField4.Enabled = False
            MaterialSingleLineTextField1.Enabled = True
            MaterialSingleLineTextField2.Enabled = True
            Bttn_Actualiza.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = True
            MetroTabControl1.SelectedIndex = 2
            MaterialSingleLineTextField2.Focus()

        End If
    End Sub

    Private Sub MaterialSingleLineTextField3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialSingleLineTextField3.KeyPress, MaterialSingleLineTextField4.KeyPress, MaterialSingleLineTextField2.KeyPress, MaterialSingleLineTextField1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) OrElse
            e.KeyChar = Convert.ToChar(Keys.Delete) OrElse
            e.KeyChar = Convert.ToChar(Keys.Left) OrElse
            e.KeyChar = Convert.ToChar(Keys.Right) OrElse
            IsNumber(e.KeyChar.ToString()) Then

            If e.KeyChar = "."c Then
                e.Handled = True
            Else
                e.Handled = False
                Dim tbtmp As TextBox = TryCast(sender, TextBox)

            End If

        Else
            e.Handled = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MaterialSingleLineTextField3.Text.Trim.Length = 0) Then
            MetroFramework.MetroMessageBox.Show(Me, "La Contraseña Numerica no puede estar Vacia",
                                       "Cambio de Clave",
                                       MessageBoxButtons.YesNoCancel,
                                       MessageBoxIcon.Exclamation,
                                       370)
        ElseIf (MaterialSingleLineTextField3.Text <> MaterialSingleLineTextField4.Text) Then
            MetroFramework.MetroMessageBox.Show(Me, "No Coinciden la Contraseña y su Verificación",
                                       "Cambio de Clave",
                                       MessageBoxButtons.YesNoCancel,
                                       MessageBoxIcon.Exclamation,
                                       370)
        ElseIf (MetroFramework.MetroMessageBox.Show(Me, "¿Cambiar Clave del Usuario " + MetroTextBox2.Text.Trim() + "  " + MetroTextBox1.Text.Trim() + "?",
                                       "Cambio de Clave",
                                       MessageBoxButtons.YesNoCancel,
                                       MessageBoxIcon.Question,
                                       370) = DialogResult.Yes) Then

            CambiarContraseña(MaterialSingleLineTextField3.Text.Trim())
            PictureBox1.Visible = False
            MaterialSingleLineTextField3.Text = ""
            MaterialSingleLineTextField4.Text = ""
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (MaterialSingleLineTextField2.Text.Trim.Length = 0) Then
            MetroFramework.MetroMessageBox.Show(Me, "La Contraseña Numerica no puede estar Vacia",
                                       "Registro de Usuario",
                                       MessageBoxButtons.YesNoCancel,
                                       MessageBoxIcon.Exclamation,
                                       370)
        ElseIf (MaterialSingleLineTextField2.Text <> MaterialSingleLineTextField1.Text) Then
            MetroFramework.MetroMessageBox.Show(Me, "No Coinciden la Contraseña y su Verificación",
                                       "Registro de Usuario",
                                       MessageBoxButtons.YesNoCancel,
                                       MessageBoxIcon.Exclamation,
                                       370)
        ElseIf (MetroFramework.MetroMessageBox.Show(Me, "¿Registrar El Usuario " + MetroTextBox2.Text.Trim() + "  " + MetroTextBox1.Text.Trim() + "?",
                                       "Registro de Usuario",
                                       MessageBoxButtons.YesNoCancel,
                                       MessageBoxIcon.Question,
                                       370) = DialogResult.Yes) Then

            RegistrarUsuario(CmbBx_Usuarios.SelectedValue)
            PictureBox2.Visible = False
            MaterialSingleLineTextField1.Text = ""
            MaterialSingleLineTextField2.Text = ""
            Button2.PerformClick()
        End If
    End Sub

    Private Sub MaterialSingleLineTextField3_TextChanged(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField3.TextChanged, MaterialSingleLineTextField4.TextChanged, MaterialSingleLineTextField2.TextChanged, MaterialSingleLineTextField1.TextChanged
        If (MaterialSingleLineTextField3.Text = MaterialSingleLineTextField4.Text And MaterialSingleLineTextField4.Text.Trim.Length > 0) Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If

        If (MaterialSingleLineTextField1.Text = MaterialSingleLineTextField2.Text And MaterialSingleLineTextField2.Text.Trim.Length > 0) Then
            PictureBox2.Visible = True
        Else
            PictureBox2.Visible = False
        End If
    End Sub

    Private Sub CambiarContraseña(Password As String)

        EmpleadoActual.Password = Password
        EmpleadoActual.ActualizarContraseña()

    End Sub
    Private Sub RegistrarUsuario(IDUsuario As String)

    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave, Button1.MouseLeave, Bttn_Actualiza.MouseLeave, Button3.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.Location = New Point(btn.Location.X + 5, btn.Location.Y + 5)
        btn.Size = New Size(btn.Width - 10, btn.Height - 10)
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter, Button1.MouseEnter, Bttn_Actualiza.MouseEnter, Button3.MouseEnter
        Dim btn As Button = CType(sender, Button)
        btn.Location = New Point(btn.Location.X - 5, btn.Location.Y - 5)
        btn.Size = New Size(btn.Width + 10, btn.Height + 10)
    End Sub
    Public Function IsNumber(inputvalue As String) As Boolean

        Dim isnumber_1 As New System.Text.RegularExpressions.Regex("^[0-9]*$")
        'Dim isnumber__1 As New System.Text.RegularExpressions.Regex("^-?[0-9]+(\.?[0-9]+)?$")
        Return isnumber_1.IsMatch(inputvalue)

    End Function



End Class
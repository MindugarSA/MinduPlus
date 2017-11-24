Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement



Public Class Frm_Liquidaciones
    Dim dt As New DataTable
    Dim conexion As New SqlConnection
    Dim cmd As SqlCommand
    Dim ContSelect As Integer

    Public Delegate Sub LaunchEvent()
    Public Event EnviarEvento As LaunchEvent

    Private Sub Frm_Liquidaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = Conection.Cn
        ContSelect = 0

        cmd = New SqlCommand("Colaciones_Liquidaciones_Info_Meses", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            conexion.Open()

            cmd.Parameters.Add(New SqlParameter("@RutEmp", MDIParent1.Lbl_RutEmpresa.Text))
            Dim adaptador As New SqlDataAdapter(cmd)
            Dim dt1 As New DataTable
            adaptador.Fill(dt1)
            If dt1.Rows(0)("IdEstado") = 0 Then

                With CmbBx_Meses
                    .DataSource = dt1
                    .DisplayMember = "fecha"
                    .ValueMember = "Mes"
                    .SelectedIndex = 0
                End With
            End If

        Catch ex As Exception
        Finally
            conexion.Close()
            ContSelect = 1
            CargaLiqudacion()
        End Try




        'Dim vMes As Integer = Month(DateAdd("m", -1, Date.Now))
        'Dim vAno As Integer = Year(DateAdd("m", -1, Date.Now))
        'cmd = New SqlCommand("Min_Colaciones_Liquidaciones_Info", conexion)
        'cmd.CommandType = CommandType.StoredProcedure
        'Try
        '    conexion.Open()
        '    cmd.Parameters.Add(New SqlParameter("@RutEmp", MDIParent1.Lbl_RutEmpresa.Text))
        '    cmd.Parameters.Add(New SqlParameter("@Rut", MDIParent1.Lbl_RutTrab.Text))
        '    cmd.Parameters.Add(New SqlParameter("@Mes", CmbBx_Meses.SelectedValue))
        '    cmd.Parameters.Add(New SqlParameter("@Ano", CmbBx_Meses.Text.Substring(0, 4)))
        '    Dim adaptador As New SqlDataAdapter(cmd)
        '    Dim dt As New DataTable
        '    adaptador.Fill(dt)
        '    Dim ArchivoTMP As String = Path.GetTempPath().ToString
        '    ArchivoTMP = ArchivoTMP + "Liqudaciones.html"
        '    File.Delete(ArchivoTMP)
        '    If dt.Rows(0)("IdEstado") = 0 Then
        '        Dim texto As String = dt.Rows(0)("liquidacion_txt")
        '        Dim sw As New System.IO.StreamWriter(ArchivoTMP)
        '        Const quote As String = """"
        '        Dim Encabezado1 As String = "<table width = " & Chr(34) & "100%" & Chr(34) & " border= " & Chr(34) & "0" & Chr(34) & " align = " & Chr(34) & "center" & Chr(34) & " cellpadding= " & Chr(34) & "0" & Chr(34) & ">"
        '        Dim Encabezado2 As String = "<tr><td width =" & Chr(34) & "33%" & Chr(34) & " > Empresa <br> Rut <br> direcciom  </td>"
        '        Dim Encabezado3 As String = "<td width =" & Chr(34) & "33%" & Chr(34) & " > <div align = " & Chr(34) & "center" & Chr(34) & "> autoconsulta </div></td>"
        '        Dim Encabezado4 As String = "<td width =" & Chr(34) & "33%" & Chr(34) & " > <div align = " & Chr(34) & "right" & Chr(34) & ">" &
        '                                    "<img src=" & Chr(34) & "file:///\\FSSAPBO\gestper\LOGOMIND.PNG" & Chr(34) & "width = " & Chr(34) & "247" & Chr(34) & "height=" & Chr(34) & "65" & Chr(34) & "></div></td> "
        '        Dim Encabezado As String = Encabezado1 & Encabezado2 & Encabezado3 & Encabezado4
        '        sw.WriteLine(Encabezado)
        '        sw.WriteLine(texto)
        '        sw.WriteLine("</tr> </table>")
        '        sw.Close()
        '        WebBrowser1.Navigate(ArchivoTMP)

        '    End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    conexion.Close()
        'End Try

        'MDIParent1.Panel2.Visible = False

    End Sub


    Private Sub CargaLiqudacion()

        'Dim vMes As Integer = Month(DateAdd("m", -1, Date.Now))
        'Dim vAno As Integer = Year(DateAdd("m", -1, Date.Now))
        cmd = New SqlCommand("Colaciones_Liquidaciones_Info", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            conexion.Open()
            Dim empresa = MDIParent1.Lbl_RutEmpresa.Text
            Dim rut = MDIParent1.Lbl_RutTrab.Text
            cmd.Parameters.Add(New SqlParameter("@RutEmp", MDIParent1.Lbl_RutEmpresa.Text))
            cmd.Parameters.Add(New SqlParameter("@Rut", MDIParent1.Lbl_RutTrab.Text))
            cmd.Parameters.Add(New SqlParameter("@Mes", CmbBx_Meses.SelectedValue))
            cmd.Parameters.Add(New SqlParameter("@Ano", CmbBx_Meses.Text.Substring(0, 4)))
            Dim adaptador As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adaptador.Fill(dt)
            Dim ArchivoTMP As String = Path.GetTempPath().ToString
            ArchivoTMP = ArchivoTMP + "Liqudaciones.html"
            File.Delete(ArchivoTMP)
            If dt.Rows(0)("IdEstado") = 0 Then
                Dim texto As String = dt.Rows(0)("liquidacion_txt")
                Dim sw As New System.IO.StreamWriter(ArchivoTMP)

                Dim Encabezado1 As String = "<table width = " & Chr(34) & "100%" & Chr(34) & " border= " & Chr(34) & "0" & Chr(34) & " align = " & Chr(34) & "center" & Chr(34) & " cellpadding= " & Chr(34) & "0" & Chr(34) & ">"
                Dim Encabezado2 As String = "<tr><td width =" & Chr(34) & "33%" & Chr(34) & " > Empresa <br> Rut <br> direccion  </td>"
                Dim Encabezado3 As String = "<td width =" & Chr(34) & "33%" & Chr(34) & " > <div align = " & Chr(34) & "center" & Chr(34) & "> autoconsulta </div></td>"
                Dim Encabezado4 As String = "<td width =" & Chr(34) & "33%" & Chr(34) & " > <div align = " & Chr(34) & "right" & Chr(34) & ">" &
                                            "<img src=" & Chr(34) & "file:///\\FSSAPBO\gestper\LOGOMIND.BMP" & Chr(34) & "width = " & Chr(34) & "247" & Chr(34) & "height=" & Chr(34) & "60" & Chr(34) & "></div></td> "
                Dim Encabezado As String = Encabezado1 & Encabezado2 & Encabezado3 & Encabezado4
                sw.WriteLine(Encabezado)
                sw.WriteLine(texto)
                sw.WriteLine("<style> *{font-size: 100%;}</style>")
                sw.WriteLine("</tr> </table>")
                sw.Close()
                WebBrowser1.Navigate(ArchivoTMP)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MDIParent1.Panel2.Visible = True
        MDIParent1.ToolStripProgressBar1.ProgressBar.Maximum = MDIParent1.TiempoActivo
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        WebBrowser1.Print()

        'MDIParent1.Panel2.Visible = True
        Me.Close()
    End Sub

    Private Sub RevisaDirectorios()
        Dim objFSO, strFolder
        strFolder = "C:\Users\Temp\Gesper"
        objFSO = CreateObject("Scripting.FileSystemObject")
        If Not objFSO.FolderExists(strFolder) Then
            objFSO.CreateFolder(strFolder)
        End If
    End Sub

    Private Sub CmbBx_Meses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBx_Meses.SelectedIndexChanged
        If ContSelect = 1 Then CargaLiqudacion()
    End Sub

    Private Sub Frm_Liquidaciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        RaiseEvent EnviarEvento()
    End Sub
End Class
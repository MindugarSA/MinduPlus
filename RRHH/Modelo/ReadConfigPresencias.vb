Public Class ReadConfigPresencias
    Property Id As String
    Private dt As DataTable
    Public Sub New(id As String)
        Me.Id = id
    End Sub

    Public Function CheckExiste() As Boolean
        dt = SelectDataTable("SELECT * FROM [SAC_Mindugar].[dbo].[Configuracion_PresenciaEmpleado] WHERE rut = '" + Id.ToString + "'")
        If dt.Rows.Count = 0 Then
            ExecuteSql("INSERT INTO [SAC_Mindugar].[dbo].[Configuracion_PresenciaEmpleado](rut,config) VALUES('" + Id + "','cmb0=0,cmb1=0,cmb2=0,chk=0')")
            Return False
        End If
        Return True
    End Function

    Public Sub BuscarConfigUsuario(ByRef cmb() As String, ByRef chk As Boolean)
        If CheckExiste() Then
            Dim config() As String = Split(dt.Rows(0)(1), ",")
            For index = 0 To 3
                Dim start As Integer = config(index).IndexOf("=") + 1
                Dim length As Integer = config(index).Length - start
                If index = 3 Then
                    If config(index).Substring(start, length) = "0" Then
                        chk = False
                    Else
                        chk = True
                    End If
                Else
                    cmb(index) = config(index).Substring(start, length)
                End If
            Next
        Else
            cmb(0) = "0"
            cmb(1) = "0"
            cmb(2) = "0"
            chk = False
        End If
    End Sub

    Public Sub ModificarConfigUsuario(ByVal empresa As String, ByVal departamento As String, ByVal cargo As String, ByVal verAusentes As Boolean)
        If empresa = "" Then
            empresa = "0"
        End If
        If departamento = "" Then
            departamento = "0"
        End If
        If cargo = "" Then
            cargo = "0"
        End If
        Dim config As String = "cmb0=" + empresa + ",cmb1=" + departamento + ",cmb2=" + cargo + ",chk=" + If(verAusentes, "1", "0")
        ExecuteSql("UPDATE [SAC_Mindugar].[dbo].[Configuracion_PresenciaEmpleado] SET config = '" + config + "' WHERE rut = '" + Id + "'")
    End Sub
End Class

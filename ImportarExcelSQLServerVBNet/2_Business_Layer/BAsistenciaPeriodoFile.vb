Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Imports ImportarExcelSQLServer._1_Data_Layer
Imports System.Data

Public Class BAsistenciaPeriodoFile

    Public Shared Function Insertar(Periodo As String, inc As String, Registro As Date, Usuario As String, FileName As String, FileStream As Byte(), Host As String) As String

        Dim Obj As New DAsistenciaPeriodoFile()

        Obj.Periodo = Periodo
        Obj.Inc = inc
        Obj.Registro = Registro
        Obj.Usuario = Usuario
        Obj.FileName = FileName
        Obj.FileStream = FileStream
        Obj.Host = Host

        Return Obj.Insertar(Obj)
    End Function

    Public Shared Function ObtenerProximoIngreso() As Integer

        Dim Obj As New DAsistenciaPeriodoFile()
        Return Obj.ObtenerProximoIngreso()

    End Function

    Public Shared Function ConsultarRegistro(Registro As Integer) As DataTable

        Dim Obj As New DAsistenciaPeriodoFile()
        Return Obj.ConsultarRegistro(Registro)

    End Function


End Class

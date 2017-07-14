Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.Entity.Core.Objects

Public Class Empresas

    Public Shared Function ListarEmpresas() As List(Of Empresas)
        Dim lista As New List(Of Empresas)()
        Try
            Dim results As ObjectResult(Of Solicitud_Buscar_Empresas_Result) = CommonBC.EntidadesSAC.Solicitud_Buscar_Empresas()
            For Each result As Solicitud_Buscar_Empresas_Result In results
                Dim empresa As New Empresas()
                empresa.Id = result.Id
                empresa.RUT = result.RUT
                empresa.Nombre = result.Nombre
                empresa.DB_Name = result.DB_Name

                lista.Add(empresa)
            Next
        Catch
        End Try
        Return lista
    End Function


End Class

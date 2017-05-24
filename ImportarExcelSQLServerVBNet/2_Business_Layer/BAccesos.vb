Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Imports ImportarExcelSQLServer._1_Data_Layer

Namespace _2_Business_Layer
    Public Class BAccesos

        Public Shared Function Verificar(Usuario As String, Pass As String) As Boolean
            Dim Obj As New DAccesos()

            Obj.Usuario = Usuario
            Obj.Pass = Pass

            Return Obj.Verificar(Obj)
        End Function

    End Class

End Namespace

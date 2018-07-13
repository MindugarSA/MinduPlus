Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.Entity.Core.Objects

Public Class EmpleadoConect

    Property Nombre As String
    Property Rut As [String]
    Property RutEmp As [String]
    Property Empresa As [String]
    Property DirecEmp As [String]
    Property Cargo As [String]
    Property FechaIngreso As DateTime
    Property Departamento As [String]
    Property Area As [String]
    Property Estado As String
    Property IDUsuario As Integer
    Property Password As Integer

    Private Sub New()
    End Sub

    Public Shared ReadOnly Property Instance As EmpleadoConect
        Get
            Static _Instance As EmpleadoConect = New EmpleadoConect
            Return _Instance
        End Get
    End Property

End Class

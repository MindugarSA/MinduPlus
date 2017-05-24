Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
'Imports System.Data.Object
Imports System.Data.Entity.Core.Objects

Public Class Persona
    Private _nombre As [String]

    Public Property Nombre() As [String]
        Get
            Return _nombre
        End Get
        Set
            _nombre = Value
        End Set
    End Property

    Private _rut As [String]

    Public Property Rut() As [String]
        Get
            Return _rut
        End Get
        Set
            _rut = Value
        End Set
    End Property

    Private _empresa As [String]

    Public Property Empresa() As [String]
        Get
            Return _empresa
        End Get
        Set
            _empresa = Value
        End Set
    End Property

    Private _cargo As [String]

    Public Property Cargo() As [String]
        Get
            Return _cargo
        End Get
        Set
            _cargo = Value
        End Set
    End Property

    Private _fechaIngreso As DateTime

    Public Property FechaIngreso() As DateTime
        Get
            Return _fechaIngreso
        End Get
        Set
            _fechaIngreso = Value
        End Set
    End Property



    Private _departamento As [String]

    Public Property Departamento() As [String]
        Get
            Return _departamento
        End Get
        Set
            _departamento = Value
        End Set
    End Property

    Public Function BuscarDatos() As Boolean
        Try
            Dim results As ObjectResult(Of Solicitud_Buscar_Datos_Trabajador_Result) = CommonBC.EntidadesSAC.Solicitud_Buscar_Datos_Trabajador(Nombre)
            For Each result As Solicitud_Buscar_Datos_Trabajador_Result In results
                Cargo = result.cargo
                Empresa = result.nombre_emp
                Rut = result.rut
                FechaIngreso = CType(result.fecha_ingreso, DateTime)
            Next
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function BuscarRutPorNombre() As Boolean
        Try
            Dim results As ObjectResult(Of String) = CommonBC.EntidadesSAC.Solicitud_Buscar_Empleado_PorNombre(Nombre)
            Rut = ""
            For Each result As String In results
                Rut = result
            Next
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function BuscarNombrePorRut() As Boolean
        Try
            Dim results As ObjectResult(Of String) = CommonBC.EntidadesSAC.Solicitud_Buscar_Empleado_PorRut(Rut)
            Nombre = ""
            For Each result As String In results
                Nombre = result
            Next
            Return True
        Catch
            Return False
        End Try
    End Function

#Region "metodosEstaticos"
    Public Shared Function ListarPorEmpresa(empresa As [String]) As List(Of Persona)
        Dim lista As New List(Of Persona)()
        Try
            Dim results As ObjectResult(Of Solicitud_Empleados_Sugeridos_Empresa_Result) = CommonBC.EntidadesSAC.Solicitud_Empleados_Sugeridos_Empresa(empresa)
            For Each result As Solicitud_Empleados_Sugeridos_Empresa_Result In results
                Dim persona As New Persona()
                persona.Nombre = result.nombre
                persona.Rut = result.rut
                lista.Add(persona)
            Next
        Catch
        End Try
        Return lista
    End Function
#End Region
End Class

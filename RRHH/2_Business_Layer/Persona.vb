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

    Private _Estado As String
    Public Property Estado() As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property

    Private _IDUsuario As Integer
    Public Property IDUsuario() As Integer
        Get
            Return _IDUsuario
        End Get
        Set(ByVal value As Integer)
            _IDUsuario = value
        End Set
    End Property

    Private _Password As Integer
    Public Property Password() As Integer
        Get
            Return _Password
        End Get
        Set(ByVal value As Integer)
            _Password = value
        End Set
    End Property

    Public Function BuscarDatos() As Boolean
        Try
            Dim results As ObjectResult(Of Solicitud_Buscar_Datos_Trabajador_Result) = CommonBC.EntidadesSAC.Solicitud_Buscar_Datos_Trabajador(Nombre, Estado)
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

    Public Shared Function ListarPorEmpresaPeriodo(empresa As [String], FecInicio As DateTime, FecFin As DateTime) As DataTable
        'Dim lista As New List(Of Persona)()
        Dim dt As DataTable = Nothing
        Try
            Dim results As ObjectResult(Of Solicitud_Empleados_Empresa_Periodo_Result) = CommonBC.EntidadesSAC.Solicitud_Empleados_Empresa_Periodo(empresa, FecInicio, FecFin)

            dt = dt.LINQResultToDataTable(Of Object)(results)

        Catch
        End Try
        Return dt
    End Function

    Public Shared Function ListarTodos() As List(Of Persona)
        Dim lista As New List(Of Persona)()
        Try
            Dim results As ObjectResult(Of Solicitud_Empleados_Sugeridos_Todos_Result) = CommonBC.EntidadesSAC.Solicitud_Empleados_Sugeridos_Todos()
            For Each result As Solicitud_Empleados_Sugeridos_Todos_Result In results
                Dim persona As New Persona()
                persona.Nombre = result.nombre
                persona.Rut = result.rut
                persona.Estado = result.Estado
                persona.Empresa = result.RutEmp
                lista.Add(persona)
            Next
        Catch
        End Try
        Return lista
    End Function

    Public Function ActualizarContraseña() As Boolean
        Try
            CommonBC.EntidadesSAC.PassUsuariosCambiarContraseña(IDUsuario, Password)
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function PassUsuariosGes() As DataTable
        'Dim lista As New List(Of Persona)()
        Dim dt As DataTable = Nothing
        Try
            Dim results As ObjectResult(Of PassUsuariosGes_Result) = CommonBC.EntidadesSAC.PassUsuariosGes(0, Rut, False, Nombre, 1, Date.Now(), Date.Now(), "", vbNull, "-", Password)

            dt = dt.LINQResultToDataTable(Of Object)(results)

        Catch
        End Try
        Return dt
    End Function

#End Region
End Class

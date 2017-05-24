Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class HoraExtra
	Private _id As Integer
	Private _solicitante As [String]
	Private _rutSolicitante As [String]
	Private _fechaSolicitud As DateTime
	Private _cantidadHorasExtras As Integer
	Private _area As [String]
	Private _detalle As [String]
	Private _fechaResolucion As DateTime
	Private _colaboradores As List(Of HoraExtraColaboradores)

	Public Property Colaboradores() As List(Of HoraExtraColaboradores)
		Get
			If _colaboradores Is Nothing Then
				_colaboradores = New List(Of HoraExtraColaboradores)()
			End If
			Return _colaboradores
		End Get
		Set
			_colaboradores = value
		End Set
	End Property

	Public Property FechaResolucion() As DateTime
		Get
			Return _fechaResolucion
		End Get
		Set
			_fechaResolucion = value
		End Set
	End Property


	Public Property Detalle() As [String]
		Get
			Return _detalle
		End Get
		Set
			_detalle = value
		End Set
	End Property


	Public Property Area() As [String]
		Get
			Return _area
		End Get
		Set
			_area = value
		End Set
	End Property


	Public Property CantidadHorasExtras() As Integer
		Get
			Return _cantidadHorasExtras
		End Get
		Set
			_cantidadHorasExtras = value
		End Set
	End Property


	Public Property FechaSolicitud() As DateTime
		Get
			Return _fechaSolicitud
		End Get
		Set
			_fechaSolicitud = value
		End Set
	End Property


	Public Property RutSolicitante() As [String]
		Get
			Return _rutSolicitante
		End Get
		Set
			_rutSolicitante = value
		End Set
	End Property




	Public Property Solicitante() As [String]
		Get
			Return _solicitante
		End Get
		Set
			_solicitante = value
		End Set
	End Property


	Public Property Id() As Integer
		Get
			Return _id
		End Get
		Set
			_id = value
		End Set
	End Property


	Public Shared Function BuscarArea(id As Integer) As [String]
		Try
            Dim result As Solicitud_HorasExtras = CommonBC.EntidadesSAC.Solicitud_HorasExtras.Where(Function(P) P.id_solicitud_horas_extra = id).First()
            Return result.area
		Catch
			Return Nothing
		End Try
	End Function


End Class

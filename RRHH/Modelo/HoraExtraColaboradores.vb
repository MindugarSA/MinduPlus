Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports RRHH_VisualDALC

Public Class HoraExtraColaboradores
	Private _rut As [String]
	'
	Private _nombre_completo As [String]
	'
	Private _horasCompromisoInicio As TimeSpan
	'
	Private _totalHorasCompromiso As [Double]
	'
	Private _fechaReal As DateTime
	'
	Private _horasEfectivasInicio As TimeSpan
	'
	Private _totalHorasEfectivas As [Double]
	'
	Private _empresa As [String]
	'
	Private _cargo As [String]
	'
	Private _autorizado As [Boolean]
	'
	Private _rechazado As [Boolean]
	'
	Private _fechaResolucion As DateTime
	'
	Private _responsableResolucion As [String]
	'
	Private _idSolicitudHHEE As Integer
	Private _area As [String]
	Private _horaExtra As HoraExtra

	#Region "Getters And Setters"
	Public Property BaseHoraExtra() As HoraExtra
		Get
			If _horaExtra Is Nothing Then
				_horaExtra = New HoraExtra()
			End If
			Return _horaExtra
		End Get
		Set
			_horaExtra = value
		End Set
	End Property


	Public Property Area() As [String]
		Get
			If _area Is Nothing AndAlso _horaExtra IsNot Nothing Then
				Return BaseHoraExtra.Area
			End If
			Return _area
		End Get
		Set
			_area = value
		End Set
	End Property


	Public Property IdSolicitudHHEE() As Integer
		Get
			Return _idSolicitudHHEE
		End Get
		Set
			_idSolicitudHHEE = value
		End Set
	End Property


	Public Property ResponsableResolucion() As [String]
		Get
			Return _responsableResolucion
		End Get
		Set
			_responsableResolucion = value
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


	Public Property Rechazado() As [Boolean]
		Get
			Return _rechazado
		End Get
		Set
			_rechazado = value
		End Set
	End Property


	Public Property Autorizado() As [Boolean]
		Get
			Return _autorizado
		End Get
		Set
			_autorizado = value
		End Set
	End Property


	Public Property Cargo() As [String]
		Get
			Return _cargo
		End Get
		Set
			_cargo = value
		End Set
	End Property


	Public Property Empresa() As [String]
		Get
			Return _empresa
		End Get
		Set
			_empresa = value
		End Set
	End Property


	Public Property TotalHorasEfectivas() As [Double]
		Get
			Return _totalHorasEfectivas
		End Get
		Set
			_totalHorasEfectivas = value
		End Set
	End Property


	Public Property HorasEfectivasInicio() As TimeSpan
		Get
			Return _horasEfectivasInicio
		End Get
		Set
			_horasEfectivasInicio = value
		End Set
	End Property


	Public Property FechaReal() As DateTime
		Get
			Return _fechaReal
		End Get
		Set
			_fechaReal = value
		End Set
	End Property


	Public Property TotalHorasCompromiso() As [Double]
		Get
			Return _totalHorasCompromiso
		End Get
		Set
			_totalHorasCompromiso = value
		End Set
	End Property


	Public Property HorasCompromisoInicial() As TimeSpan
		Get
			Return _horasCompromisoInicio
		End Get
		Set
			_horasCompromisoInicio = value
		End Set
	End Property


	Public Property Rut() As [String]
		Get
			Return _rut
		End Get
		Set
			_rut = value
		End Set
	End Property


	Public Property NombreCompleto() As [String]
		Get
			Return _nombre_completo
		End Get
		Set
			_nombre_completo = value
		End Set
	End Property
	#End Region

	Public Shared Function ListarIntevalo(rut As [String], empresa As [String], inicio As DateTime, termino As DateTime) As List(Of HoraExtraColaboradores)
		Dim lista As New List(Of HoraExtraColaboradores)()
		Try
            Dim results As List(Of Solicitud_HorasExtras_Colaboradores)
			inicio = inicio.[Date]
			termino = termino.[Date]
			If rut IsNot Nothing Then
				results = CommonBC.EntidadesSAC.Solicitud_HorasExtras_Colaboradores.Where(Function(SS) SS.rut = rut AndAlso SS.fecha_real >= inicio AndAlso SS.fecha_real <= termino AndAlso CBool(SS.autorizado)).ToList()
			ElseIf empresa IsNot Nothing Then
				results = CommonBC.EntidadesSAC.Solicitud_HorasExtras_Colaboradores.Where(Function(SS) SS.empresa = empresa AndAlso SS.fecha_real >= inicio.[Date] AndAlso SS.fecha_real <= termino AndAlso CBool(SS.autorizado)).ToList()
			Else
				results = CommonBC.EntidadesSAC.Solicitud_HorasExtras_Colaboradores.Where(Function(SS) SS.fecha_real >= inicio.[Date] AndAlso SS.fecha_real <= termino AndAlso CBool(SS.autorizado)).ToList()
			End If

            For Each result As Solicitud_HorasExtras_Colaboradores In results
                Dim hhee As New HoraExtraColaboradores()
                hhee.Rut = result.rut
                hhee.NombreCompleto = result.nombre_completo
                hhee.TotalHorasCompromiso = Convert.ToDouble(result.total_horas_compromiso)
                hhee.ResponsableResolucion = result.responsable_resolucion
                hhee.Rechazado = Convert.ToBoolean(result.rechazado)
                hhee.IdSolicitudHHEE = result.id_solicitud_horas_extra
                If result.horas_compromiso_inicio <> Nothing Then
                    hhee.HorasCompromisoInicial = TimeSpan.Parse(result.horas_compromiso_inicio.ToString())
                End If
                If result.horas_efectivas_inicio IsNot Nothing Then
                    hhee.HorasEfectivasInicio = TimeSpan.Parse(result.horas_efectivas_inicio.ToString())
                End If
                hhee.TotalHorasEfectivas = Convert.ToDouble(result.total_horas_efectivas)
                hhee.FechaResolucion = Convert.ToDateTime(result.fecha_resolucion)
                hhee.FechaReal = Convert.ToDateTime(result.fecha_real)
                hhee.Empresa = result.empresa
                hhee.Cargo = result.cargo
                hhee.Autorizado = Convert.ToBoolean(result.autorizado)
                hhee.Area = HoraExtra.BuscarArea(result.id_solicitud_horas_extra).Trim()
                lista.Add(hhee)

            Next
		Catch
		End Try
		Return lista
	End Function


End Class

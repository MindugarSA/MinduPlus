Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
'Imports RRHH_VisualDALC

Public Class Permiso
	Private _id As Integer
	Private _trabajador As [String]
	Private _solicitante As [String]
	Private _rut As [String]
	Private _particular As [Boolean]
	Private _comision_servicio As [Boolean]
	Private _fechaPermiso As DateTime
	Private _horaSalida As TimeSpan
	Private _totalHoras As [Double]
	Private _fechaReal As DateTime
	Private _fechaSolicitud As DateTime
	Private _empresa As [String]
	Private _cargo As [String]
	Private _rechazada As [Boolean]
	Private _autorizado As [Boolean]
	Private _diaCompleto As [Boolean]
	Private _tramite As [String]
	Private _fechaResolucion As DateTime
	Private _responsableResolucion As [String]
	Private _checkBasetempo As [Boolean]
	Private _rutSolicitante As [String]
	Private _departamento As [String]

	Public Property Departamento() As [String]
		Get
			Return _departamento
		End Get
		Set
			_departamento = value
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


	Public Property CheckBasetempo() As [Boolean]
		Get
			Return _checkBasetempo
		End Get
		Set
			_checkBasetempo = value
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


	Public Property Tramite() As [String]
		Get
			Return _tramite
		End Get
		Set
			_tramite = value
		End Set
	End Property


	Public Property DiaCompleto() As [Boolean]
		Get
			Return _diaCompleto
		End Get
		Set
			_diaCompleto = value
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


	Public Property Rechazada() As [Boolean]
		Get
			Return _rechazada
		End Get
		Set
			_rechazada = value
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



	Public Property FechaSolicitud() As DateTime
		Get
			Return _fechaSolicitud
		End Get
		Set
			_fechaSolicitud = value
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


	Public Property TotalHoras() As [Double]
		Get
			Return _totalHoras
		End Get
		Set
			_totalHoras = value
		End Set
	End Property



	Public Property HoraSalida() As TimeSpan
		Get
			Return _horaSalida
		End Get
		Set
			_horaSalida = value
		End Set
	End Property




	Public Property FechaPermiso() As DateTime
		Get
			Return _fechaPermiso
		End Get
		Set
			_fechaPermiso = value
		End Set
	End Property


	Public Property ComisonServicio() As [Boolean]
		Get
			Return _comision_servicio
		End Get
		Set
			_comision_servicio = value
		End Set
	End Property


	Public Property PermisoParticular() As [Boolean]
		Get
			Return _particular
		End Get
		Set
			_particular = value
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


	Public Property Solicitante() As [String]
		Get
			Return _solicitante
		End Get
		Set
			_solicitante = value
		End Set
	End Property


	Public Property Trabajador() As [String]
		Get
			Return _trabajador
		End Get
		Set
			_trabajador = value
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


	Public Shared Function ListarIntevalo(rut As [String], empresa As [String], inicio As DateTime, termino As DateTime) As List(Of Permiso)
		Dim lista As New List(Of Permiso)()
		Try
			inicio = inicio.[Date]
			termino = termino.[Date]
            Dim results As List(Of Solicitud_Salida)
			If rut IsNot Nothing Then
				results = CommonBC.EntidadesSAC.Solicitud_Salida.Where(Function(SS) SS.rut = rut AndAlso SS.dia >= inicio AndAlso SS.dia <= termino AndAlso CBool(SS.autorizada)).ToList()
			ElseIf empresa IsNot Nothing Then
				results = CommonBC.EntidadesSAC.Solicitud_Salida.Where(Function(SS) SS.empresa = empresa AndAlso SS.dia >= inicio AndAlso SS.dia <= termino AndAlso CBool(SS.autorizada)).ToList()
			Else
				results = CommonBC.EntidadesSAC.Solicitud_Salida.Where(Function(SS) SS.dia >= inicio AndAlso SS.dia <= termino AndAlso CBool(SS.autorizada)).ToList()
			End If

            For Each result As Solicitud_Salida In results
                Dim per As New Permiso()
                per.Rut = result.rut
                per.RutSolicitante = result.rut_solicitante
                per.Tramite = result.tramite
                per.Trabajador = result.trabajador
                per.TotalHoras = Convert.ToDouble(result.total_horas)
                per.Solicitante = result.solicitante
                per.ResponsableResolucion = result.responsable_resolucion
                per.Rechazada = Convert.ToBoolean(result.rechazada)
                per.PermisoParticular = Convert.ToBoolean(result.permiso_particular)
                per.Id = result.id_solicitud_salida
                If result.hora_salida IsNot Nothing Then
                    per.HoraSalida = TimeSpan.Parse(result.hora_salida.ToString())
                End If
                per.FechaSolicitud = result.fecha_solicitud
                per.FechaResolucion = Convert.ToDateTime(result.fecha_resolucion)
                per.FechaReal = Convert.ToDateTime(result.fecha_real)
                per.FechaPermiso = result.dia
                per.Empresa = result.empresa
                per.DiaCompleto = result.dia_completo
                per.ComisonServicio = Convert.ToBoolean(result.permiso_comision_servicio)
                per.CheckBasetempo = Convert.ToBoolean(result.check_basetempo)
                per.Cargo = result.cargo
                per.Autorizado = Convert.ToBoolean(result.autorizada)
                per.Departamento = result.area.Trim()
                lista.Add(per)

            Next
		Catch
		End Try
		Return lista
	End Function

    Public Shared Function ListarPorPersonaTop(rut As [String], cantidad As Integer) As List(Of Permiso)
        Dim lista As New List(Of Permiso)()
        Try
            Dim results As List(Of Solicitud_Salida) = CommonBC.EntidadesSAC.Solicitud_Salida.Where(Function(SS) SS.rut = rut AndAlso CBool(SS.autorizada)).OrderByDescending(Function(SS) SS.dia).Take(cantidad).ToList()

            For Each result As Solicitud_Salida In results
                Dim per As New Permiso()
                per.Rut = result.rut
                per.RutSolicitante = result.rut_solicitante
                per.Tramite = result.tramite
                per.Trabajador = result.trabajador
                per.TotalHoras = Convert.ToDouble(result.total_horas)
                per.Solicitante = result.solicitante
                per.ResponsableResolucion = result.responsable_resolucion
                per.Rechazada = Convert.ToBoolean(result.rechazada)
                per.PermisoParticular = Convert.ToBoolean(result.permiso_particular)
                per.Id = result.id_solicitud_salida
                If result.hora_salida IsNot Nothing Then
                    per.HoraSalida = TimeSpan.Parse(result.hora_salida.ToString())
                End If
                per.FechaSolicitud = result.fecha_solicitud
                per.FechaResolucion = Convert.ToDateTime(result.fecha_resolucion)
                per.FechaReal = Convert.ToDateTime(result.fecha_real)
                per.FechaPermiso = result.dia
                per.Empresa = result.empresa
                per.DiaCompleto = result.dia_completo
                per.ComisonServicio = Convert.ToBoolean(result.permiso_comision_servicio)
                per.CheckBasetempo = Convert.ToBoolean(result.check_basetempo)
                per.Cargo = result.cargo
                per.Autorizado = Convert.ToBoolean(result.autorizada)
                per.Departamento = result.area.Trim()
                lista.Add(per)
            Next
        Catch
        End Try
        Return lista
    End Function

End Class

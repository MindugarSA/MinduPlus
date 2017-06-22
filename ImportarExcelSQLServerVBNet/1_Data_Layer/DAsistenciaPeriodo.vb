Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace _1_Data_Layer
	Public Class DAsistenciaPeriodo
		Private mPeriodo As String
		Private mId As String
		Private mHorario As String
		Private mFecha As String
		Private mMarcajes As String
		Private mMarcajes2 As String
		Private mPresencia As String
		Private mTrabajo As String
		Private mRetraso As String
		Private mExtras As String
		Private mMov As String
		Private mTrabajo2 As String
		Private mAusencia As String
        Private mAus As String
        Private mTotDesc As String
        Private mLicencia As String
        Private mVacaciones As String
        Private mBonoMeta As String
        Private mBonoNoche As String
        Private mInc As String
        Private mRegistro As DateTime
        Private mNumReg As Integer
        Private mHorarioE As String
        Private mHorarioS As String
        Private mFechaFiniquito As String


        Public Property Periodo() As [String]
            Get
                Return mPeriodo
            End Get
            Set
                mPeriodo = Value
            End Set
        End Property

        Public Property Id() As [String]
            Get
                Return mId
            End Get
            Set
                mId = Value
            End Set
        End Property

        Public Property Horario() As [String]
            Get
                Return mHorario
            End Get
            Set
                mHorario = Value
            End Set
        End Property

        Public Property Fecha() As [String]
            Get
                Return mFecha
            End Get
            Set
                mFecha = Value
            End Set
        End Property

        Public Property Marcajes() As [String]
            Get
                Return mMarcajes
            End Get
            Set
                mMarcajes = Value
            End Set
        End Property

        Public Property Marcajes2() As [String]
            Get
                Return mMarcajes2
            End Get
            Set
                mMarcajes2 = Value
            End Set
        End Property

        Public Property Presencia() As [String]
            Get
                Return mPresencia
            End Get
            Set
                mPresencia = Value
            End Set
        End Property

        Public Property Trabajo() As [String]
            Get
                Return mTrabajo
            End Get
            Set
                mTrabajo = Value
            End Set
        End Property

        Public Property Retraso() As [String]
            Get
                Return mRetraso
            End Get
            Set
                mRetraso = Value
            End Set
        End Property

        Public Property Extras() As [String]
            Get
                Return mExtras
            End Get
            Set
                mExtras = Value
            End Set
        End Property

        Public Property Mov() As [String]
            Get
                Return mMov
            End Get
            Set
                mMov = Value
            End Set
        End Property

        Public Property Trabajo2() As [String]
            Get
                Return mTrabajo2
            End Get
            Set
                mTrabajo2 = Value
            End Set
        End Property

        Public Property Ausencia() As [String]
            Get
                Return mAusencia
            End Get
            Set
                mAusencia = Value
            End Set
        End Property

        Public Property Aus() As [String]
            Get
                Return mAus
            End Get
            Set
                mAus = Value
            End Set
        End Property

        Public Property Inc() As [String]
            Get
                Return mInc
            End Get
            Set
                mInc = Value
            End Set
        End Property

        Public Property Registro() As DateTime
            Get
                Return mRegistro
            End Get
            Set
                mRegistro = Value
            End Set
        End Property

        Public Property NumReg As Integer
            Get
                Return mNumReg
            End Get
            Set(value As Integer)
                mNumReg = value
            End Set
        End Property

        Public Property TotDesc As String
            Get
                Return mTotDesc
            End Get
            Set(value As String)
                mTotDesc = value
            End Set
        End Property

        Public Property Licencia As String
            Get
                Return mLicencia
            End Get
            Set(value As String)
                mLicencia = value
            End Set
        End Property

        Public Property Vacaciones As String
            Get
                Return mVacaciones
            End Get
            Set(value As String)
                mVacaciones = value
            End Set
        End Property

        Public Property BonoMeta As String
            Get
                Return mBonoMeta
            End Get
            Set(value As String)
                mBonoMeta = value
            End Set
        End Property

        Public Property BonoNoche As String
            Get
                Return mBonoNoche
            End Get
            Set(value As String)
                mBonoNoche = value
            End Set
        End Property

        Public Property HorarioE As String
            Get
                Return mHorarioE
            End Get
            Set(value As String)
                mHorarioE = value
            End Set
        End Property

        Public Property HorarioS As String
            Get
                Return mHorarioS
            End Get
            Set(value As String)
                mHorarioS = value
            End Set
        End Property

        Public Property FechaFiniquito As String
            Get
                Return mFechaFiniquito
            End Get
            Set(value As String)
                mFechaFiniquito = value
            End Set
        End Property

        Public Sub New()
        End Sub

        Public Sub New(Periodo As String, Id As String, Horario As String, Fecha As String, Marcajes As String, Marcajes2 As String,
            Presencia As String, Trabajo As String, Retraso As String, Extras As String, Mov As String, Trabajo2 As String,
            Ausencia As String, Aus As String, TotDesc As String, Licencia As String, Vacaciones As String, BonoMeta As String,
            BonoNoche As String, Inc As String, Registro As DateTime, NumReg As Integer, HorarioE As String, HorarioS As String,
            FechaFiniquito As String)

            mPeriodo = Periodo
            mId = Id
            mHorario = Horario
            mFecha = Fecha
            mMarcajes = Marcajes
            mMarcajes2 = Marcajes2
            mPresencia = Presencia
            mTrabajo = Trabajo
            mRetraso = Retraso
            mExtras = Extras
            mMov = Mov
            mTrabajo2 = Trabajo2
            mAusencia = Ausencia
            mAus = Aus
            mTotDesc = TotDesc
            mLicencia = Licencia
            mVacaciones = Vacaciones
            mBonoMeta = BonoMeta
            mBonoNoche = BonoNoche
            mInc = Inc
            mRegistro = Registro
            mNumReg = NumReg
            mHorarioE = HorarioE
            mHorarioS = HorarioS
            mFechaFiniquito = FechaFiniquito

        End Sub

        Public Function Insertar(Asistencia As DAsistenciaPeriodo) As String
			Dim rpta As String = ""
			Dim SlqCon As New SqlConnection()

			Try
				Dim sp As String = "SpASISTENCIA_PERIODOInsertar"
				SlqCon.ConnectionString = Conection.Cn
				Dim SqlCmd As New SqlCommand(sp, SlqCon)
				SqlCmd.CommandType = CommandType.StoredProcedure

				SlqCon.Open()

				SqlCmd.Parameters.AddWithValue("@Periodo", Asistencia.Periodo)
				SqlCmd.Parameters.AddWithValue("@Id", Asistencia.Id)
				SqlCmd.Parameters.AddWithValue("@Horario", Asistencia.Horario)
				SqlCmd.Parameters.AddWithValue("@Fecha", Asistencia.Fecha)
				SqlCmd.Parameters.AddWithValue("@Marcajes", Asistencia.Marcajes)
				SqlCmd.Parameters.AddWithValue("@Marcajes2", Asistencia.Marcajes2)
				SqlCmd.Parameters.AddWithValue("@Presencia", Asistencia.Presencia)
				SqlCmd.Parameters.AddWithValue("@Trabajo", Asistencia.Trabajo)
				SqlCmd.Parameters.AddWithValue("@Retraso", Asistencia.Retraso)
				SqlCmd.Parameters.AddWithValue("@Extras", Asistencia.Extras)
				SqlCmd.Parameters.AddWithValue("@Mov", Asistencia.Mov)
				SqlCmd.Parameters.AddWithValue("@Trabajo2", Asistencia.Trabajo2)
				SqlCmd.Parameters.AddWithValue("@Ausencia", Asistencia.Ausencia)
                SqlCmd.Parameters.AddWithValue("@Aus", Asistencia.Aus)
                SqlCmd.Parameters.AddWithValue("@TotDesc", Asistencia.TotDesc)
                SqlCmd.Parameters.AddWithValue("@Licencia", Asistencia.Licencia)
                SqlCmd.Parameters.AddWithValue("@Vacaciones", Asistencia.Vacaciones)
                SqlCmd.Parameters.AddWithValue("@BonoMeta", Asistencia.BonoMeta)
                SqlCmd.Parameters.AddWithValue("@BonoNoche", Asistencia.BonoNoche)
                SqlCmd.Parameters.AddWithValue("@Inc", Asistencia.Inc)
                SqlCmd.Parameters.AddWithValue("@Registro", Asistencia.Registro)
                SqlCmd.Parameters.AddWithValue("@NumReg", Asistencia.NumReg)
                SqlCmd.Parameters.AddWithValue("@HorarioE", Asistencia.HorarioE)
                SqlCmd.Parameters.AddWithValue("@HorarioS", Asistencia.HorarioS)
                SqlCmd.Parameters.AddWithValue("@FechaFiniquito", Asistencia.FechaFiniquito)

                rpta = If(SqlCmd.ExecuteNonQuery() = 1, "OK", "NO se Ingreso el Registro")
			Catch ex As Exception
				rpta = ex.Message
			Finally
				If SlqCon.State = ConnectionState.Open Then
					SlqCon.Close()
				End If
			End Try

			Return rpta
		End Function

		Public Function Eliminar(Asistencia As DAsistenciaPeriodo) As String
			Dim rpta As String = ""
			Dim SlqCon As New SqlConnection()

			Try
				Dim sp As String = "SpASISTENCIA_PERIODOEliminar"

				SlqCon.ConnectionString = Conection.Cn
				Dim SqlCmd As New SqlCommand(sp, SlqCon)
				SqlCmd.CommandType = CommandType.StoredProcedure

				SlqCon.Open()

				SqlCmd.Parameters.AddWithValue("@Periodo", Asistencia.Periodo)

				rpta = If(SqlCmd.ExecuteNonQuery() = 1, "OK", "NO se Elimino el Registro")


				Return rpta
			Catch ex As Exception
				rpta = ex.Message
			Finally
				If SlqCon.State = ConnectionState.Open Then
					SlqCon.Close()
				End If
			End Try

			Return rpta
		End Function

		Public Function Buscar(Asistencia As DAsistenciaPeriodo) As Boolean
			Dim DtResultado As New DataTable()
			Dim SlqCon As New SqlConnection()
			Dim Existe As Boolean = False

			Try
				Dim sp As String = "SpASISTENCIA_PERIODOOExiste"

				SlqCon.ConnectionString = Conection.Cn
				Dim SqlCmd As New SqlCommand(sp, SlqCon)

				SlqCon.Open()
				SqlCmd.CommandType = CommandType.StoredProcedure
				SqlCmd.Parameters.AddWithValue("@Periodo", Asistencia.Periodo)

				Dim SqlDat As New SqlDataAdapter(SqlCmd)
				SqlDat.Fill(DtResultado)

				If DtResultado IsNot Nothing AndAlso DtResultado.Rows.Count > 0 Then
					Existe = True

				End If
			Catch
			Finally
				If SlqCon.State = ConnectionState.Open Then
					SlqCon.Close()
				End If
			End Try
			Return Existe

		End Function

		Public Function ConsultarPeriodosRegistrados() As DataTable

			Dim DtResultado As New DataTable()
			Dim SlqCon As New SqlConnection()

			Try
				Dim sp As String = "SpASISTENCIA_Periodos_Registrados"

				SlqCon.ConnectionString = Conection.Cn
				Dim SqlCmd As New SqlCommand(sp, SlqCon)

				SlqCon.Open()
				SqlCmd.CommandType = CommandType.StoredProcedure

				Dim SqlDat As New SqlDataAdapter(SqlCmd)

				SqlDat.Fill(DtResultado)
			Catch e As Exception
				DtResultado = Nothing
			Finally
				If SlqCon.State = ConnectionState.Open Then
					SlqCon.Close()
				End If
			End Try
			Return DtResultado

		End Function

		Public Function ConsultarAsistenciaDetallada(Asistencia As DAsistenciaPeriodo) As DataTable

			Dim DtResultado As New DataTable()
			Dim SlqCon As New SqlConnection()

			Try
				Dim sp As String = "SpASISTENCIA_DETALLADA_PERIODO"

				SlqCon.ConnectionString = Conection.Cn
				Dim SqlCmd As New SqlCommand(sp, SlqCon)

				SlqCon.Open()
				SqlCmd.CommandType = CommandType.StoredProcedure
				SqlCmd.Parameters.AddWithValue("@Periodo", Asistencia.Periodo)

				Dim SqlDat As New SqlDataAdapter(SqlCmd)

				SqlDat.Fill(DtResultado)
			Catch
				DtResultado = Nothing
			Finally
				If SlqCon.State = ConnectionState.Open Then
					SlqCon.Close()
				End If
			End Try
			Return DtResultado

		End Function

		Public Function ConsultarAsistenciaResumen(Asistencia As DAsistenciaPeriodo) As DataTable

			Dim DtResultado As New DataTable()
			Dim SlqCon As New SqlConnection()

			Try
				Dim sp As String = "SpASISTENCIA_RESUMEN_PERIODO"

				SlqCon.ConnectionString = Conection.Cn
				Dim SqlCmd As New SqlCommand(sp, SlqCon)

				SlqCon.Open()
				SqlCmd.CommandType = CommandType.StoredProcedure
				SqlCmd.Parameters.AddWithValue("@Periodo", Asistencia.Periodo)

				Dim SqlDat As New SqlDataAdapter(SqlCmd)

				SqlDat.Fill(DtResultado)
			Catch
				DtResultado = Nothing
			Finally
				If SlqCon.State = ConnectionState.Open Then
					SlqCon.Close()
				End If
			End Try
			Return DtResultado

		End Function

	End Class
End Namespace

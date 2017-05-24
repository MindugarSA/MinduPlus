Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace _1_Data_Layer
	Class DAsistenciaConceptos
		Private mPERIODO As String
		Private mEMPRESA As String
		Private mRutEmp As String
		Private mRUT As String
		Private mRUT_TN As String
		Private mP_CI As Integer = 0
		Private mNOMBRE As String
		Private mConcepto As String
		Private mDescripcion As String
		Private mValorTempoNet As String
		Private mValor_GestPer As Double
		Private mCCOSTOS As String
		Private mCreateDate As DateTime
        Private mNumRegistro As Integer
        Private mRegistroOrigen As Integer
        Private mUsuario As String

        Public Property PERIODO() As [String]
			Get
				Return mPERIODO
			End Get
			Set
				mPERIODO = value
			End Set
		End Property
		Public Property EMPRESA() As [String]
			Get
				Return mEMPRESA
			End Get
			Set
				mEMPRESA = value
			End Set
		End Property
		Public Property RutEmp() As [String]
			Get
				Return mRutEmp
			End Get
			Set
				mRutEmp = value
			End Set
		End Property
		Public Property RUT() As [String]
			Get
				Return mRUT
			End Get
			Set
				mRUT = value
			End Set
		End Property
		Public Property RUT_TN() As [String]
			Get
				Return mRUT_TN
			End Get
			Set
				mRUT_TN = value
			End Set
		End Property
		Public Property P_CI() As Integer
			Get
				Return mP_CI
			End Get
			Set
				mP_CI = value
			End Set
		End Property
		Public Property NOMBRE() As [String]
			Get
				Return mNOMBRE
			End Get
			Set
				mNOMBRE = value
			End Set
		End Property
		Public Property Concepto() As [String]
			Get
				Return mConcepto
			End Get
			Set
				mConcepto = value
			End Set
		End Property
		Public Property Descripcion() As [String]
			Get
				Return mDescripcion
			End Get
			Set
				mDescripcion = value
			End Set
		End Property
		Public Property ValorTempoNet() As [String]
			Get
				Return mValorTempoNet
			End Get
			Set
				mValorTempoNet = value
			End Set
		End Property
		Public Property Valor_GestPer() As [Double]
			Get
				Return mValor_GestPer
			End Get
			Set
				mValor_GestPer = value
			End Set
		End Property
		Public Property CCOSTOS() As [String]
			Get
				Return mCCOSTOS
			End Get
			Set
				mCCOSTOS = value
			End Set
		End Property
		Public Property CreateDate() As DateTime
			Get
				Return mCreateDate
			End Get
			Set
				mCreateDate = value
			End Set
		End Property
		Public Property NumRegistro() As Integer
			Get
				Return mNumRegistro
			End Get

			Set
				mNumRegistro = value
			End Set
		End Property

        Public Property RegistroOrigen As Integer
            Get
                Return mRegistroOrigen
            End Get
            Set(value As Integer)
                mRegistroOrigen = value
            End Set
        End Property

        Public Property Usuario As String
            Get
                Return mUsuario
            End Get
            Set(value As String)
                mUsuario = value
            End Set
        End Property

        Public Sub New()
        End Sub

        Public Sub New(PERIODO As String, EMPRESA As String, RutEmp As String, RUT As String, RUT_TN As String, P_CI As Integer,
            NOMBRE As String, Concepto As String, Descripcion As String, ValorTempoNet As String, Valor_GestPer As Double, CCOSTOS As String,
            CreateDate As DateTime, NumRegistro As Integer, RegistroOrigen As Integer, Usuario As String)
            mPERIODO = PERIODO
            mEMPRESA = EMPRESA
            mRutEmp = RutEmp
            mRUT = RUT
            mRUT_TN = RUT_TN
            mP_CI = P_CI
            mNOMBRE = NOMBRE
            mConcepto = Concepto
            mDescripcion = Descripcion
            mValorTempoNet = ValorTempoNet
            mValor_GestPer = Valor_GestPer
            mCCOSTOS = CCOSTOS
            mCreateDate = CreateDate
            mNumRegistro = NumRegistro
            mRegistroOrigen = RegistroOrigen
            mUsuario = Usuario
        End Sub
        Public Function Insertar(Conceptos As DAsistenciaConceptos) As String
			Dim rpta As String = ""
			Dim SlqCon As New SqlConnection()

			Try
				Dim sp As String = "SpASISTENCIA_CONCEPTOInsertar"
				SlqCon.ConnectionString = Conection.Cn
				Dim SqlCmd As New SqlCommand(sp, SlqCon)
				SqlCmd.CommandType = CommandType.StoredProcedure

				SlqCon.Open()

				SqlCmd.Parameters.AddWithValue("@PERIODO", Conceptos.PERIODO)
				SqlCmd.Parameters.AddWithValue("@EMPRESA", Conceptos.EMPRESA)
				SqlCmd.Parameters.AddWithValue("@RutEmp", Conceptos.RutEmp)
				SqlCmd.Parameters.AddWithValue("@RUT", Conceptos.RUT)
				SqlCmd.Parameters.AddWithValue("@RUT_TN", Conceptos.RUT_TN)
				SqlCmd.Parameters.AddWithValue("@P_CI", Conceptos.P_CI)
				SqlCmd.Parameters.AddWithValue("@NOMBRE", Conceptos.NOMBRE)
				SqlCmd.Parameters.AddWithValue("@Concepto", Conceptos.Concepto)
				SqlCmd.Parameters.AddWithValue("@Descripcion", Conceptos.Descripcion)
				SqlCmd.Parameters.AddWithValue("@ValorTempoNet", Conceptos.ValorTempoNet)
				SqlCmd.Parameters.AddWithValue("@Valor_GestPer", Conceptos.Valor_GestPer)
				SqlCmd.Parameters.AddWithValue("@CCOSTOS", Conceptos.CCOSTOS)
				SqlCmd.Parameters.AddWithValue("@CreateDate", Conceptos.CreateDate)
                SqlCmd.Parameters.AddWithValue("@NumProximo", Conceptos.NumRegistro)
                SqlCmd.Parameters.AddWithValue("@RegistroOrigen", Conceptos.RegistroOrigen)
                SqlCmd.Parameters.AddWithValue("@Usuario", Conceptos.Usuario)



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
		Public Function ObtenerProximoIngreso() As Integer

			Dim DtResultado As New DataTable()
			Dim SlqCon As New SqlConnection()
			Dim nProximo As Integer = 0

			Try
				Dim sp As String = "SpASISTENCIA_CONCEPTOProximo"

				SlqCon.ConnectionString = Conection.Cn
				Dim SqlCmd As New SqlCommand(sp, SlqCon)

				SlqCon.Open()
				SqlCmd.CommandType = CommandType.StoredProcedure

				Dim SqlDat As New SqlDataAdapter(SqlCmd)
				SqlDat.Fill(DtResultado)

				nProximo = Convert.ToInt32(DtResultado.Rows(0)(0))
			Catch
				DtResultado = Nothing
			Finally
				If SlqCon.State = ConnectionState.Open Then
					SlqCon.Close()
				End If
			End Try
			Return nProximo
		End Function
		Public Function GenerarResumenConceptos(Conceptos As DAsistenciaConceptos) As DataTable

			Dim DtResultado As New DataTable()
			Dim SlqCon As New SqlConnection()

			Try
				Dim sp As String = "SpASISTENCIA_CONCEPTOS_PERIODO"

				SlqCon.ConnectionString = Conection.Cn
				Dim SqlCmd As New SqlCommand(sp, SlqCon)

				SlqCon.Open()
				SqlCmd.CommandType = CommandType.StoredProcedure
				SqlCmd.Parameters.AddWithValue("@Periodo", Conceptos.PERIODO)
				SqlCmd.Parameters.AddWithValue("@RutEmp", Conceptos.RutEmp)

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
		Public Function GenerarResumenAlmuerzos(Conceptos As DAsistenciaConceptos) As DataTable
			Dim DtResultado As New DataTable()
			Dim SlqCon As New SqlConnection()

			Try
				Dim sp As String = "SpASISTENCIA_ALMUERZOS"

				SlqCon.ConnectionString = Conection.Cn
				Dim SqlCmd As New SqlCommand(sp, SlqCon)

				SlqCon.Open()
				SqlCmd.CommandType = CommandType.StoredProcedure
				SqlCmd.Parameters.AddWithValue("@Periodo", Conceptos.PERIODO)
				SqlCmd.Parameters.AddWithValue("@RutEmp", Conceptos.RutEmp)

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
		Public Function ConsultarResumenConceptos(Conceptos As DAsistenciaConceptos) As DataTable

			Dim DtResultado As New DataTable()
			Dim SlqCon As New SqlConnection()

			Try
				Dim sp As String = "SpASISTENCIA_CONCEPTOObtener"

				SlqCon.ConnectionString = Conection.Cn
				Dim SqlCmd As New SqlCommand(sp, SlqCon)

				SlqCon.Open()
				SqlCmd.CommandType = CommandType.StoredProcedure
				SqlCmd.Parameters.AddWithValue("@Periodo", Conceptos.PERIODO)
				SqlCmd.Parameters.AddWithValue("@RutEmp", Conceptos.RutEmp)

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
		Public Function ConsultarResumenConceptosUltimo(Conceptos As DAsistenciaConceptos) As DataTable

			Dim DtResultado As New DataTable()
			Dim SlqCon As New SqlConnection()

			Try
				Dim sp As String = "SpASISTENCIA_CONCEPTOObtenerUltimo"

				SlqCon.ConnectionString = Conection.Cn
				Dim SqlCmd As New SqlCommand(sp, SlqCon)

				SlqCon.Open()
				SqlCmd.CommandType = CommandType.StoredProcedure
				SqlCmd.Parameters.AddWithValue("@Periodo", Conceptos.PERIODO)
				SqlCmd.Parameters.AddWithValue("@RutEmp", Conceptos.RutEmp)

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

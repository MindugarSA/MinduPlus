Imports System.Data
Imports System.Data.SqlClient

Namespace _1_Data_Layer
    Public Class DAsistenciaPeriodoFile


        Private mPeriodo As String
        Private mInc As String
        Private mRegistro As Date
        Private mUsuario As String
        Private mFileName As String
        Private mFileStream As Byte()
        Private mHost As String

        Public Property Periodo() As String
            Get
                Return mPeriodo
            End Get
            Set(Value As String)
                mPeriodo = Value
            End Set
        End Property

        Public Property Inc() As String
            Get
                Return mInc
            End Get
            Set(Value As String)
                mInc = Value
            End Set
        End Property

        Public Property Registro() As Date
            Get
                Return mRegistro
            End Get
            Set(Value As Date)
                mRegistro = Value
            End Set
        End Property

        Public Property Usuario() As String
            Get
                Return mUsuario
            End Get
            Set(Value As String)
                mUsuario = Value
            End Set
        End Property

        Public Property FileName() As String
            Get
                Return mFileName
            End Get
            Set(Value As String)
                mFileName = Value
            End Set
        End Property

        Public Property FileStream() As Byte()
            Get
                Return mFileStream
            End Get
            Set(Value As Byte())
                mFileStream = Value
            End Set
        End Property

        Public Property Host() As String
            Get
                Return mHost
            End Get
            Set(Value As String)
                mHost = Value
            End Set
        End Property

        Sub New()
        End Sub

        Sub New(Periodo As String, inc As String, Registro As Date, Usuario As String, FileName As String, FileStream As Byte(), Host As String)
            mPeriodo = Periodo
            mInc = inc
            mRegistro = Registro
            mUsuario = Usuario
            mFileName = FileName
            mFileStream = FileStream
            mHost = Host
        End Sub

        Public Function Insertar(Asistencia As DAsistenciaPeriodoFile) As String
            Dim rpta As String = ""
            Dim SlqCon As New SqlConnection()

            Try
                Dim sp As String = "SpASISTENCIA_PERIODO_FILEInsertar"
                SlqCon.ConnectionString = Conection.Cn
                Dim SqlCmd As New SqlCommand(sp, SlqCon)
                SqlCmd.CommandType = CommandType.StoredProcedure

                SlqCon.Open()

                SqlCmd.Parameters.Add(New SqlClient.SqlParameter("@PERIODO", Asistencia.Periodo))
                SqlCmd.Parameters.Add(New SqlClient.SqlParameter("@INC", Asistencia.Inc))
                SqlCmd.Parameters.Add(New SqlClient.SqlParameter("@REGISTRO", Asistencia.Registro))
                SqlCmd.Parameters.Add(New SqlClient.SqlParameter("@USUARIO", Asistencia.Usuario))
                SqlCmd.Parameters.Add(New SqlClient.SqlParameter("@FILENAME", Asistencia.FileName))
                'SqlCmd.Parameters.Add(New SqlClient.SqlParameter("@FILESTREAM", SqlDbType.VarBinary,))
                SqlCmd.Parameters.Add("@FILESTREAM", SqlDbType.VarBinary).Value = Asistencia.FileStream
                SqlCmd.Parameters.Add(New SqlClient.SqlParameter("@HOST", Asistencia.Host))

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
                Dim sp As String = "SpASISTENCIA_PERIODO_FILEProximo"

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

        Public Function ConsultarRegistro(Registro As Integer) As DataTable

            Dim DtResultado As New DataTable()
            Dim SlqCon As New SqlConnection()

            Try
                Dim sp As String = "SpASISTENCIA_PERIODO_FILEBuscar"

                SlqCon.ConnectionString = Conection.Cn
                Dim SqlCmd As New SqlCommand(sp, SlqCon)

                SlqCon.Open()
                SqlCmd.CommandType = CommandType.StoredProcedure
                SqlCmd.Parameters.AddWithValue("@Registro", Registro)

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

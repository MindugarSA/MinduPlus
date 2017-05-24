Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace _1_Data_Layer
    Public Class DAccesos

        Private _Usuario As String
        Private _Pass As String
        Private _Estado As String

        Public Property Usuario() As String
            Get
                Return _Usuario
            End Get
            Set(ByVal value As String)
                _Usuario = value
            End Set
        End Property
        Public Property Pass As String
            Get
                Return _Pass
            End Get
            Set(value As String)
                _Pass = value
            End Set
        End Property
        Public Property Estado As String
            Get
                Return _Estado
            End Get
            Set(value As String)
                _Estado = value
            End Set
        End Property

        Public Sub New()
        End Sub

        Public Sub New(Usuario As String, Pass As String, Estado As String)
            _Usuario = Usuario
            _Pass = Pass
            _Estado = Estado
        End Sub

        Public Function Verificar(Acceso As DAccesos) As Boolean
            Dim DtResultado As New DataTable()
            Dim SlqCon As New SqlConnection()
            Dim Existe As Boolean = False

            Try
                Dim sp As String = "SpASISTENCIA_ACCESOSExiste"

                SlqCon.ConnectionString = Conection.Cn
                Dim SqlCmd As New SqlCommand(sp, SlqCon)

                SlqCon.Open()
                SqlCmd.CommandType = CommandType.StoredProcedure
                SqlCmd.Parameters.AddWithValue("@Usuario", Acceso.Usuario)
                SqlCmd.Parameters.AddWithValue("@Pass", Acceso.Pass)

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

    End Class

End Namespace


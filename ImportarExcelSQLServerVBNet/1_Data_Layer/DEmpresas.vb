Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace _1_Data_Layer
	Class DEmpresas
		Private mId As String
		Private mRUT As String
		Private mNombre As String
		Private mDB_Name As String

		Public Property Id() As String
			Get
				Return mId
			End Get

			Set
				mId = value
			End Set
		End Property
		Public Property RUT() As String
			Get
				Return mRUT
			End Get

			Set
				mRUT = value
			End Set
		End Property
		Public Property Nombre() As String
			Get
				Return mNombre
			End Get

			Set
				mNombre = value
			End Set
		End Property
		Public Property DB_Name() As String
			Get
				Return mDB_Name
			End Get

			Set
				mDB_Name = value
			End Set
		End Property

		Public Sub New()
		End Sub

		Public Sub New(Id As String, RUT As String, IdNombre As String, DB_Name As String)
			mId = Id
			mRUT = RUT
			mNombre = Nombre
			mDB_Name = DB_Name
		End Sub

		Public Function ListarEmpresas() As DataTable

			Dim DtResultado As New DataTable()
			Dim SlqCon As New SqlConnection()

			Try
				Dim sp As String = "SpASISTENCIA_EMPRESASListar"

				SlqCon.ConnectionString = Conection.Cn
				Dim SqlCmd As New SqlCommand(sp, SlqCon)

				SlqCon.Open()
				SqlCmd.CommandType = CommandType.StoredProcedure

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

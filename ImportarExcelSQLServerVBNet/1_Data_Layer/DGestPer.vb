Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace _1_Data_Layer
	Class DGestPer
		Public Shared Function InsertarResumenConceptos(Conceptos As DAsistenciaConceptos) As DataTable

			Dim DtResultado As New DataTable()
			Dim SlqCon As New SqlConnection()

			Try
				Dim sp As String = "SpASISTENCIA_CONCEPTOS_GESTPERInsertar"

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

		Public Shared Function InsertarResumenConceptosCodigoTrab(Conceptos As DAsistenciaConceptos) As DataTable

			Dim DtResultado As New DataTable()
			Dim SlqCon As New SqlConnection()

			Try
				Dim sp As String = "SpASISTENCIA_CONCEPTOS_GESTPER_DETInsertar"

				SlqCon.ConnectionString = Conection.Cn
				Dim SqlCmd As New SqlCommand(sp, SlqCon)

				SlqCon.Open()
				SqlCmd.CommandType = CommandType.StoredProcedure
				SqlCmd.Parameters.AddWithValue("@Periodo", Conceptos.PERIODO)
				SqlCmd.Parameters.AddWithValue("@RutEmp", Conceptos.RutEmp)
				SqlCmd.Parameters.AddWithValue("@Concepto", Conceptos.Concepto)
				SqlCmd.Parameters.AddWithValue("@RutTrab", Conceptos.RUT)

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
		Public Shared Function EliminarConceptosPeriodo(Conceptos As DAsistenciaConceptos) As String
			Dim rpta As String = ""
			Dim SlqCon As New SqlConnection()

			Try
				Dim sp As String = "SpASISTENCIA_CONCEPTOS_GESTPEREliminar"

				SlqCon.ConnectionString = Conection.Cn
				Dim SqlCmd As New SqlCommand(sp, SlqCon)
				SqlCmd.CommandType = CommandType.StoredProcedure

				SlqCon.Open()
				SqlCmd.Parameters.AddWithValue("@Periodo", Conceptos.PERIODO)
				SqlCmd.Parameters.AddWithValue("@RutEmp", Conceptos.RutEmp)

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

		Public Shared Function EliminarConceptosPeriodoCodigoTrab(Conceptos As DAsistenciaConceptos) As String
			Dim rpta As String = ""
			Dim SlqCon As New SqlConnection()

			Try
				Dim sp As String = "SpASISTENCIA_CONCEPTOS_GESTPER_DETEliminar"

				SlqCon.ConnectionString = Conection.Cn
				Dim SqlCmd As New SqlCommand(sp, SlqCon)
				SqlCmd.CommandType = CommandType.StoredProcedure

				SlqCon.Open()
				SqlCmd.Parameters.AddWithValue("@Periodo", Conceptos.PERIODO)
				SqlCmd.Parameters.AddWithValue("@RutEmp", Conceptos.RutEmp)
				SqlCmd.Parameters.AddWithValue("@Concepto", Conceptos.Concepto)
				SqlCmd.Parameters.AddWithValue("@RutTrab", Conceptos.RUT)

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
	End Class
End Namespace

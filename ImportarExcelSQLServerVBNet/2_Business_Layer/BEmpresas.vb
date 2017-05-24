Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Imports ImportarExcelSQLServer._1_Data_Layer

Namespace _2_Business_Layer
	Class BEmpresas
		Public Shared Function ListarEmpresas() As DataTable
			Dim Obj As New DEmpresas()
			Return Obj.ListarEmpresas()
		End Function
	End Class
End Namespace

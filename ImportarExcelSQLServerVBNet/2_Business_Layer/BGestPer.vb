Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Imports ImportarExcelSQLServer._1_Data_Layer
Imports System.Data

Namespace _2_Business_Layer
	Class BGestPer
		Public Shared Function InsertarResumenConceptos(Periodo As String, RutEmpresa As String) As DataTable
			Dim Obj As New DAsistenciaConceptos()
			Obj.PERIODO = Periodo
			Obj.RutEmp = RutEmpresa
			Return DGestPer.InsertarResumenConceptos(Obj)
		End Function
		Public Shared Function InsertarResumenConceptosCodigoTrab(Periodo As String, RutEmpresa As String, Concepto As String, RutTrabajador As String) As DataTable
			Dim Obj As New DAsistenciaConceptos()
			Obj.PERIODO = Periodo
			Obj.RutEmp = RutEmpresa
			Obj.Concepto = Concepto
			Obj.RUT = RutTrabajador

			Return DGestPer.InsertarResumenConceptosCodigoTrab(Obj)
		End Function
		Public Shared Function EliminarConceptosPeriodo(Periodo As String, RutEmpresa As String) As String
			Dim Obj As New DAsistenciaConceptos()
			Obj.PERIODO = Periodo
			Obj.RutEmp = RutEmpresa

			Return DGestPer.EliminarConceptosPeriodo(Obj)
		End Function

		Public Shared Function EliminarConceptosPeriodoCodigoTrab(Periodo As String, RutEmpresa As String, Concepto As String, RutTrabajador As String) As String
			Dim Obj As New DAsistenciaConceptos()
			Obj.PERIODO = Periodo
			Obj.RutEmp = RutEmpresa
			Obj.Concepto = Concepto
			Obj.RUT = RutTrabajador

			Return DGestPer.EliminarConceptosPeriodoCodigoTrab(Obj)
		End Function
	End Class
End Namespace

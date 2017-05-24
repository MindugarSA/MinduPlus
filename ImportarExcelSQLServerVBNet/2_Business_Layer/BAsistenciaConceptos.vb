Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Imports ImportarExcelSQLServer._1_Data_Layer

Namespace _2_Business_Layer
	Class BAsistenciaConceptos
        Public Shared Function Insertar(PERIODO As String, EMPRESA As String, RutEmp As String, RUT As String, RUT_TN As String, P_CI As Integer,
            NOMBRE As String, Concepto As String, Descripcion As String, ValorTempoNet As String, Valor_GestPer As Double, CCOSTOS As String,
            CreateDate As DateTime, NumRegistro As Integer, RegistroOrigen As Integer, Usuario As String) As String

            Dim Obj As New DAsistenciaConceptos()

            Obj.PERIODO = PERIODO
            Obj.EMPRESA = EMPRESA
            Obj.RutEmp = RutEmp
            Obj.RUT = RUT
            Obj.RUT_TN = RUT_TN
            Obj.P_CI = P_CI
            Obj.NOMBRE = NOMBRE
            Obj.Concepto = Concepto
            Obj.Descripcion = Descripcion
            Obj.ValorTempoNet = ValorTempoNet
            Obj.Valor_GestPer = Valor_GestPer
            Obj.CCOSTOS = CCOSTOS
            Obj.CreateDate = CreateDate
            Obj.NumRegistro = NumRegistro
            Obj.RegistroOrigen = RegistroOrigen
            Obj.Usuario = Usuario

            Return Obj.Insertar(Obj)
        End Function
        Public Shared Function ObtenerProximoIngreso() As Integer
			Dim Obj As New DAsistenciaConceptos()
			Return Obj.ObtenerProximoIngreso()
		End Function
		Public Shared Function GenerarResumenConceptos(Periodo As String, RutEmpresa As String) As DataTable
			Dim Obj As New DAsistenciaConceptos()
			Obj.PERIODO = Periodo
			Obj.RutEmp = RutEmpresa
			Return Obj.GenerarResumenConceptos(Obj)
		End Function
		Public Shared Function GenerarResumenAlmuerzos(Periodo As String, RutEmpresa As String) As DataTable
			Dim Obj As New DAsistenciaConceptos()
			Obj.PERIODO = Periodo
			Obj.RutEmp = RutEmpresa
			Return Obj.GenerarResumenAlmuerzos(Obj)
		End Function
		Public Shared Function ConsultarResumenConceptos(Periodo As String, RutEmpresa As String) As DataTable
			Dim Obj As New DAsistenciaConceptos()
			Obj.PERIODO = Periodo
			Obj.RutEmp = RutEmpresa
			Return Obj.ConsultarResumenConceptos(Obj)
		End Function
		Public Shared Function ConsultarResumenConceptosUltimo(Periodo As String, RutEmpresa As String) As DataTable
			Dim Obj As New DAsistenciaConceptos()
			Obj.PERIODO = Periodo
			Obj.RutEmp = RutEmpresa
			Return Obj.ConsultarResumenConceptosUltimo(Obj)
		End Function
	End Class
End Namespace

Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Imports ImportarExcelSQLServer._1_Data_Layer
Imports System.Data

Namespace _2_Business_Layer
    Class BAsistenciaPeriodo
        Public Shared Function Insertar(Periodo As String, Id As String, Horario As String, Fecha As String, Marcajes As String, Marcajes2 As String,
            Presencia As String, Trabajo As String, Retraso As String, Extras As String, Mov As String, Trabajo2 As String,
            Ausencia As String, Aus As String, TotDesc As String, Licencia As String, Vacaciones As String, BonoMeta As String,
            BonoNoche As String, Inc As String, Registro As DateTime, NumReg As Integer, HorarioE As String, HorarioS As String,
            FechaFiniquito As String) As String

            Dim Obj As New DAsistenciaPeriodo()

            Obj.Periodo = Periodo
            Obj.Id = Id
            Obj.Horario = Horario
            Obj.Fecha = Fecha
            Obj.Marcajes = Marcajes
            Obj.Marcajes2 = Marcajes2
            Obj.Presencia = Presencia
            Obj.Trabajo = Trabajo
            Obj.Retraso = Retraso
            Obj.Extras = Extras
            Obj.Mov = Mov
            Obj.Trabajo2 = Trabajo2
            Obj.Ausencia = Ausencia
            Obj.Aus = Aus
            Obj.TotDesc = TotDesc
            Obj.Licencia = Licencia
            Obj.Vacaciones = Vacaciones
            Obj.BonoMeta = BonoMeta
            Obj.BonoNoche = BonoNoche
            Obj.Inc = Inc
            Obj.Registro = Registro
            Obj.NumReg = NumReg
            Obj.HorarioE = HorarioE
            Obj.HorarioS = HorarioS
            Obj.FechaFiniquito = FechaFiniquito

            Return Obj.Insertar(Obj)
        End Function

        Public Shared Function Eliminar(Periodo As String) As String
            Dim Obj As New DAsistenciaPeriodo()

            Obj.Periodo = Periodo

            Return Obj.Eliminar(Obj)
        End Function

        Public Shared Function ConsultarAsistenciaDetallada(Periodo As String) As DataTable
            Dim Obj As New DAsistenciaPeriodo()
            Obj.Periodo = Periodo
            Return Obj.ConsultarAsistenciaDetallada(Obj)
        End Function

        Public Shared Function ConsultarAsistenciaResumen(Periodo As String) As DataTable
            Dim Obj As New DAsistenciaPeriodo()
            Obj.Periodo = Periodo
            Return Obj.ConsultarAsistenciaResumen(Obj)
        End Function

        Public Shared Function ConsultarPeriodosRegistrados() As DataTable
            Dim Obj As New DAsistenciaPeriodo()
            Return Obj.ConsultarPeriodosRegistrados()
        End Function
    End Class
End Namespace

Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace _3_Presentation_Layer
	Public Interface IComunication
		Sub ChangeButtonEnabled(Status As Boolean, IDButton As String)
		Sub ChangeCheckBoxStatus(Status As Boolean, IDCheck As String)
		Sub ChangeTextLabel(Text As String, IDLabel As String)
        Sub ChangeBoolProperty(Status As Boolean, IDButton As String)
        Sub ChangeStringProperty(sValor As String, IDButton As String)
        Sub ExecuteProcedure(Name As String, Parameters As List(Of Object))
	End Interface
End Namespace

Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports RRHH_VisualDALC

Public NotInheritable Class CommonBC
	Private Sub New()
	End Sub
    Shared _entidades As SAC_MindugarEntitiesVisual

    Public Shared ReadOnly Property EntidadesSAC() As SAC_MindugarEntitiesVisual
        Get
            If _entidades Is Nothing Then
                _entidades = New SAC_MindugarEntitiesVisual()
            End If
            Return _entidades
        End Get
    End Property
End Class

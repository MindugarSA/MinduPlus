Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public NotInheritable Class CommonBC
	Private Sub New()
	End Sub
    Shared _entidades As SAC_MindugarEntitiesVisual
    Shared _entidadesMI As MINDU_INTERMEDIAEntities

    Public Shared ReadOnly Property EntidadesSAC() As SAC_MindugarEntitiesVisual
        Get
            If _entidades Is Nothing Then
                _entidades = New SAC_MindugarEntitiesVisual()
            End If
            Return _entidades
        End Get
    End Property

    Public Shared ReadOnly Property EntidadesMI() As MINDU_INTERMEDIAEntities
        Get
            If _entidadesMI Is Nothing Then
                _entidadesMI = New MINDU_INTERMEDIAEntities()
            End If
            Return _entidadesMI
        End Get
    End Property

End Class

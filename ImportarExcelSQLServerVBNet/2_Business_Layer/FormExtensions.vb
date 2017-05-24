Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace _2_Business_Layer
    Module FormExtensions

        <System.Runtime.CompilerServices.Extension>
        Public Function GetAllControlList(parent As Control) As IEnumerable(Of Control)
            Dim controls As New List(Of Control)()

            For Each child As Control In parent.Controls
                controls.AddRange(GetAllControlList(child))
            Next

            controls.Add(parent)

            Return controls
        End Function
    End Module
End Namespace

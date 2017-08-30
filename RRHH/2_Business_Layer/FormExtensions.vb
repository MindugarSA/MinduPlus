Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

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

    <System.Runtime.CompilerServices.Extension>
    Public Async Sub FadeInAsync(o As Form, Optional interval As Integer = 80)
        'Object is not fully invisible. Fade it in
        While o.Opacity < 1.0
            Await Task.Delay(interval)
            o.Opacity += 0.05
        End While
        o.Opacity = 1
        'make fully visible       
    End Sub

    <System.Runtime.CompilerServices.Extension>
    Public Async Sub FadeOutAsync(o As Form, Optional interval As Integer = 80)
        'Object is fully visible. Fade it out
        While o.Opacity > 0.0
            Await Task.Delay(interval)
            o.Opacity -= 0.05
        End While
        o.Opacity = 0
        'make fully invisible       
    End Sub

End Module

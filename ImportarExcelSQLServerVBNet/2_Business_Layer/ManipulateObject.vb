Imports System.Collections.Generic
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace _2_Business_Layer
	Public NotInheritable Class ManipulateForm
		Private Sub New()
		End Sub
		Public Shared Function GetControl(Of T)(oForm As Form, IDControl As String) As Control
            Dim cList As List(Of Control) = oForm.GetAllControlList().ToList()
            'GetSelfAndChildrenRecursive(this).ToList();
            Dim cControl As Control = Nothing

			Try
				For Each control As Control In cList
					If control.[GetType]() Is GetType(T) AndAlso control.Name = IDControl Then
						cControl = control
						Return cControl
					End If
				Next
			Catch generatedExceptionName As Exception
			End Try

			Return cControl
		End Function

        Public Shared Sub ChangeBoolProperty(oForm As Object, bStatus As Boolean, sPropertyName As String)
            'this.bAcceso = bStatus;
            Dim cList As List(Of PropertyInfo) = oForm.[GetType]().GetProperties().ToList()
            'GetSelfAndChildrenRecursive(this).ToList();
            Dim t As Type = oForm.[GetType]()
            Dim props As PropertyInfo() = t.GetProperties()
            Dim aPropertyInfo As PropertyInfo() = oForm.[GetType]().GetProperties()

            For Each propertyInfo As PropertyInfo In cList
                If propertyInfo.Name = sPropertyName Then
                    Try
                        If propertyInfo.PropertyType.Equals(GetType([Boolean])) Then
                            propertyInfo.SetValue(oForm, CBool(bStatus))
                        End If
                    Catch generatedExceptionName As Exception
                    End Try
                End If
            Next
        End Sub

        Public Shared Sub ChangeStringProperty(oForm As Object, sString As String, sPropertyName As String)
            'this.bAcceso = bStatus;
            Dim cList As List(Of PropertyInfo) = oForm.[GetType]().GetProperties().ToList()
            'GetSelfAndChildrenRecursive(this).ToList();
            Dim t As Type = oForm.[GetType]()
            Dim props As PropertyInfo() = t.GetProperties()
            Dim aPropertyInfo As PropertyInfo() = oForm.[GetType]().GetProperties()

            For Each propertyInfo As PropertyInfo In cList
                If propertyInfo.Name = sPropertyName Then
                    Try
                        If propertyInfo.PropertyType.Equals(GetType(String)) Then
                            propertyInfo.SetValue(oForm, CStr(sString))
                        End If
                    Catch generatedExceptionName As Exception
                    End Try
                End If
            Next
        End Sub

    End Class
End Namespace

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading.Tasks

Module DataTableExtensions

    <Extension()>
    Public Sub SetColumnsOrder(dtbl As DataTable, ParamArray columnNames As [String]())
        Dim listColNames As List(Of String) = columnNames.ToList()

        'Remove invalid column names.
        For Each colName As String In columnNames
            If Not dtbl.Columns.Contains(colName) Then
                listColNames.Remove(colName)
            End If
        Next

        For Each colName As String In listColNames
            dtbl.Columns(colName).SetOrdinal(listColNames.IndexOf(colName))
        Next
    End Sub

    <System.Runtime.CompilerServices.Extension>
    Public Function LINQResultToDataTable(Of T)(dtbl As DataTable, Linqlist As IEnumerable(Of T)) As DataTable
        Dim dt As New DataTable()
        Dim columns As PropertyInfo() = Nothing

        Try

            If Linqlist Is Nothing Then
                Return dt
            End If

            For Each Record As T In Linqlist

                If columns Is Nothing Then
                    columns = DirectCast(Record.[GetType](), Type).GetProperties()
                    For Each GetProperty As PropertyInfo In columns
                        Dim colType As Type = GetProperty.PropertyType

                        If (colType.IsGenericType) AndAlso (colType.GetGenericTypeDefinition() Is GetType(Nullable(Of ))) Then
                            colType = colType.GetGenericArguments()(0)
                        End If

                        dt.Columns.Add(New DataColumn(GetProperty.Name, colType))
                    Next
                End If

                Dim dr As DataRow = dt.NewRow()

                For Each pinfo As PropertyInfo In columns
                    dr(pinfo.Name) = If(pinfo.GetValue(Record, Nothing) Is Nothing, DBNull.Value, pinfo.GetValue(Record, Nothing))
                Next

                dt.Rows.Add(dr)
            Next
        Catch ex As Exception

        End Try

        Return dt
    End Function

    <System.Runtime.CompilerServices.Extension>
    Public Function ListToDataTable(Of T)(dtbl As DataTable, data As IList(Of T)) As DataTable
        Dim table As New DataTable()

        'special handling for value types and string
        If GetType(T).IsValueType OrElse GetType(T).Equals(GetType(String)) Then

            Dim dc As New DataColumn("Value")
            table.Columns.Add(dc)
            For Each item As T In data
                Dim dr As DataRow = table.NewRow()
                dr(0) = item
                table.Rows.Add(dr)
            Next
        Else
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
            For Each prop As PropertyDescriptor In properties
                table.Columns.Add(prop.Name, If(Nullable.GetUnderlyingType(prop.PropertyType), prop.PropertyType))
            Next
            For Each item As T In data
                Dim row As DataRow = table.NewRow()
                For Each prop As PropertyDescriptor In properties
                    Try
                        row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
                    Catch ex As Exception
                        row(prop.Name) = DBNull.Value
                    End Try
                Next
                table.Rows.Add(row)
            Next
        End If
        Return table
    End Function
End Module

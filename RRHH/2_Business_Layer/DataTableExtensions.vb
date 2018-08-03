Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading.Tasks
Imports Microsoft.Office.Interop
Imports Spire.Xls

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

    <Extension()>
    Public Sub ExportToExcel(dtbl As DataTable)

        Dim xlexcel As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

        Dim misValue As Object = System.Reflection.Missing.Value
        xlexcel = New Excel.Application()

        xlexcel.DisplayAlerts = False
        ' Without this you will get two confirm overwrite prompts
        xlWorkBook = xlexcel.Workbooks.Add(misValue)
        xlWorkSheet = CType(xlWorkBook.Worksheets.Item(1), Excel.Worksheet)
        xlWorkSheet = xlWorkBook.ActiveSheet()

        Dim dc As System.Data.DataColumn
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0
        'Nombre de mesures
        Dim Nbligne As Integer = dtbl.Rows.Count

        'Ecriture des entêtes de colonne et des mesures
        '(Write column headers and data)

        For Each dc In dtbl.Columns
            colIndex = colIndex + 1
            xlWorkSheet.Cells(1, colIndex) = dc.ColumnName
            xlWorkSheet.Cells(2, colIndex).Resize(Nbligne, ).Value = xlexcel.transpose(dtbl.Rows.OfType(Of DataRow)().[Select](Function(k) CObj(k(dc.ColumnName))).ToArray())
        Next

        Dim style As Excel.Style = xlWorkSheet.Application.ActiveWorkbook.Styles.Add("NewStyle")
        style.Font.Bold = False
        style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)

        Dim tRange As Excel.Range
        Dim LastColumn As Long
        Dim LastRow As Long
        With xlWorkSheet
            LastRow = .Cells(.Rows.Count, 1).End(Excel.XlDirection.xlUp).Row
            LastColumn = .Cells(1, .Columns.Count).End(Excel.XlDirection.xlToLeft).Column
            tRange = .Range("A1", .Cells(1, LastColumn).Address)
        End With

        'tRange.EntireRow.Style = "NewStyle"
        tRange.Style = "NewStyle"
        tRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        tRange.Borders.Weight = Excel.XlBorderWeight.xlThin
        'tRange.BorderAround(, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic)
        xlWorkSheet.Cells.EntireColumn.AutoFit()

        xlexcel.Visible = True


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

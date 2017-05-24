Imports Microsoft.Office.Interop.Excel
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Module ExcelExtensions
    Public Function LoadDataTableFromExcel(sPathBook As String, Optional SheetNumBase0 As Integer = 0) As System.Data.DataTable
        Dim dtDatos As New System.Data.DataTable()

        Dim csXlsx As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & sPathBook & ";Extended Properties=""Excel 12.0;HDR=YES;IMEX=1"";"
        Dim csXls As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & sPathBook & ";Extended Properties=""Excel 8.0;HDR=YES;IMEX=1"";"
        Dim ext As String = Path.GetExtension(sPathBook)
        sPathBook = If(ext.ToLower() = ".xls", sPathBook & "x", sPathBook)
        Dim cs As String = If(ext.ToLower() = ".xls", csXls, csXlsx)

        Try
            If Not System.IO.File.Exists(sPathBook) Then
                MessageBox.Show("No se encontro el Libro: " & sPathBook, "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return Nothing
            End If
            'Conectar con la sheet 1
            Dim cn As New OleDb.OleDbConnection(cs)
            cn.Open()
            ' Get the data table containg the schema guid.
            Dim dt As System.Data.DataTable = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            Dim firstSheetName As String = dt.Rows(SheetNumBase0)("TABLE_NAME").ToString()
            Dim dAdapter As New OleDbDataAdapter("select * from [" & firstSheetName & "]", cs)
            'Agregar los datos
            dAdapter.Fill(dtDatos)

            dtDatos.TableName = "CargaMasiva"
        Catch e As Exception
        End Try

        Return dtDatos

    End Function

    Public Sub SaveXSLtoXLSX(fileName As String)
        Try
            Dim svfileName As String = Path.GetDirectoryName(fileName) & "/" & Path.GetFileNameWithoutExtension(fileName)
            'Path.ChangeExtension(fileName, ".xlsx");
            Dim oMissing As Object = Type.Missing
            Dim app = New Microsoft.Office.Interop.Excel.Application()
            Dim wb = app.Workbooks.Open(fileName, oMissing, oMissing, oMissing, oMissing, oMissing,
                oMissing, oMissing, oMissing, oMissing, oMissing, oMissing,
                oMissing, oMissing, oMissing)
            app.DisplayAlerts = False
            wb.SaveAs(svfileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, Missing.Value, Missing.Value, False, False,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlUserResolution, True, Missing.Value, Missing.Value, Missing.Value)
            'wb.SaveAs(svfileName, XlFileFormat.xlExcel8, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app)
            app = Nothing
            GC.Collect()
            GC.WaitForPendingFinalizers()
        Catch generatedExceptionName As Exception
        End Try

    End Sub

    Public Function GetFirtsSheetName(sPathBook As String) As String

        Dim app As Microsoft.Office.Interop.Excel.Application = Nothing
        app = New Microsoft.Office.Interop.Excel.Application()
        Dim wb As Microsoft.Office.Interop.Excel.Workbook = app.Workbooks.Open(sPathBook)
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet = DirectCast(wb.Worksheets.Item(1), Microsoft.Office.Interop.Excel.Worksheet)
        Dim name As String = ""

        Try
            name = ws.Name
            ws = Nothing
            wb.Close(False, Missing.Value, Missing.Value)
            wb = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(ws)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb)
        Catch ex As Exception
        Finally
            If ((app IsNot Nothing)) Then
                app.Quit()
            End If
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app)
            app = Nothing
        End Try
        Return name
    End Function
End Module

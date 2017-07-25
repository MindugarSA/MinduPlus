Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Configuration
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Module DataGridViewExtensions
    <System.Runtime.CompilerServices.Extension>
    Public Sub ExportToExcel(dgvItems As DataGridView)

        ' Copy DataGridView results to clipboard
        Dim CurrentMultiSelect As Boolean = dgvItems.MultiSelect
        dgvItems.MultiSelect = True
        dgvItems.SelectAll()
        Dim dataObj As DataObject = dgvItems.GetClipboardContent()
        If dataObj IsNot Nothing Then
            Clipboard.SetDataObject(dataObj)
        End If
        dgvItems.MultiSelect = CurrentMultiSelect

        Dim xlexcel As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

        Dim misValue As Object = System.Reflection.Missing.Value
        xlexcel = New Excel.Application()
        xlexcel.Visible = True

        xlexcel.DisplayAlerts = False
        ' Without this you will get two confirm overwrite prompts
        xlWorkBook = xlexcel.Workbooks.Add(misValue)
        xlWorkSheet = CType(xlWorkBook.Worksheets.Item(1), Excel.Worksheet)

        '' storing header part in Excel
        'for (int i = 1; i < dgvItems.Columns.Count + 1; i++)
        '{
        '    xlWorkSheet.Cells[1, i] = dgvItems.Columns[i - 1].HeaderText;
        '}

        '' storing Each row and column value to excel sheet
        'for (int i = 0; i < dgvItems.Rows.Count - 1; i++)
        '{
        '    for (int j = 0; j < dgvItems.Columns.Count; j++)
        '    {
        '        xlWorkSheet.Cells[i + 2, j + 1] = dgvItems.Rows[i].Cells[j].Value.ToString();
        '    }
        '}


        ' Format column D as text before pasting results, this was required for my data
        'Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
        'rng.NumberFormat = "@";

        'Paste clipboard results to worksheet range
        Dim CR As Excel.Range = DirectCast(xlWorkSheet.Cells(1, 1), Excel.Range)
        CR.[Select]()
        xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            True)

        ' For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
        ' Delete blank column A and select cell A1
        'Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
        'delRng.Delete(Type.Missing);
        'xlWorkSheet.get_Range("A1").Select();

        '' Save the excel file under the captured location from the SaveFileDialog
        ''xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
        'xlexcel.DisplayAlerts = false;
        'xlWorkBook.Close(true, misValue, misValue);
        'xlexcel.Quit();

        'releaseObject(xlWorkSheet);
        'releaseObject(xlWorkBook);
        'releaseObject(xlexcel);

        '' Clear Clipboard and DataGridView selection
        'Clipboard.Clear();
        'dgvItems.ClearSelection();

        ''Open the newly saved excel file
        'if (File.Exists(sfd.FileName))
        '    System.Diagnostics.Process.Start(sfd.FileName);

    End Sub

    Private Sub releaseObject(obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occurred while releasing object " & ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub
    ''' <summary>
    '''   Buscar la primera coincidencia de una cadena en un DataGrid en una columna determinada
    '''   selecciona el row y ubica el scroll en dicha linea.
    ''' </summary>
    ''' <param name="TextoABuscar"></param>
    ''' <param name="Columna"></param>
    ''' <param name="grid"></param>
    ''' 
    <System.Runtime.CompilerServices.Extension>
    Public Sub SearchAndSelectValue(grid As DataGridView, TextoABuscar As String, Columna As String)
        'BuscandoenDGV = true;
        'bool encontrado = false;
        If TextoABuscar = String.Empty Then
            Return
        End If
        If grid.RowCount = 0 Then
            Return
        End If
        'grid.ClearSelection();
        If Columna = String.Empty Then
            Dim obj As IEnumerable(Of DataGridViewRow) = (From row In grid.Rows.Cast(Of DataGridViewRow)() From cells As DataGridViewCell In row.Cells Where cells.OwningRow.Equals(row) AndAlso Convert.ToString(cells.Value).Contains(TextoABuscar) Select row)
            If obj.Any() Then
                'BuscandoenDGV = false;
                grid.Rows(obj.FirstOrDefault().Index).Selected = True
                grid.FirstDisplayedScrollingRowIndex = obj.FirstOrDefault().Index
                'return true;
                grid.CurrentCell = grid(Convert.ToInt32(Columna), obj.FirstOrDefault().Index)

            End If
        Else
            Dim obj As IEnumerable(Of DataGridViewRow) = (From row In grid.Rows.Cast(Of DataGridViewRow)() Where Convert.ToString(row.Cells(Convert.ToInt32(Columna)).Value).Contains(TextoABuscar) Select row)
            If obj.Any() Then
                'BuscandoenDGV = false;
                grid.Rows(obj.FirstOrDefault().Index).Selected = True
                grid.FirstDisplayedScrollingRowIndex = obj.FirstOrDefault().Index
                'return true;
                grid.CurrentCell = grid(Convert.ToInt32(Columna), obj.FirstOrDefault().Index)

            End If
        End If
        'BuscandoenDGV = false;
        'return encontrado;

    End Sub

    <System.Runtime.CompilerServices.Extension>
    Public Sub AjustColumnsWidthForGridWidth(oDataGridView As DataGridView)

        Dim iVisibleCount As Integer = 0
        Dim iWidth As Integer
        Dim iLastColumn As Integer

        With oDataGridView

            If .RowCount > 0 Then
                For Each columna As DataGridViewColumn In .Columns
                    iVisibleCount += IIf(columna.Visible, 1, 0)
                    iLastColumn = columna.Index
                Next

                For Each columna As DataGridViewColumn In .Columns
                    If columna.Visible Then
                        columna.AutoSizeMode = IIf(columna.Index = iLastColumn, DataGridViewAutoSizeColumnMode.Fill _
                                                    , DataGridViewAutoSizeColumnMode.AllCells)
                        iWidth = columna.Width
                        columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        columna.Width = iWidth

                        'columna.MinimumWidth = Int((.Width - .RowHeadersWidth) / iVisibleCount)
                        'columna.Width = Int((.Width - .RowHeadersWidth) / iVisibleCount)
                    End If
                Next
            End If


            'For i As Integer = 0 To .Columns.Count - 1
            '    If iLastColumn = i Then
            '        .Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            '    Else
            '        .Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            '    End If
            'Next

            'For i As Integer = 0 To .Columns.Count - 1
            '    Dim colw As Integer = .Columns(i).Width
            '    .Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            '    .Columns(i).Width = colw
            'Next
        End With

    End Sub
End Module

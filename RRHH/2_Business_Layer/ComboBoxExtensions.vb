Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Configuration
Imports System.IO
Public Module ComboBoxExtensions
    <Runtime.CompilerServices.Extension>
    Public Sub LoadFromDataTable(cmbLoad As ComboBox, dtData As DataTable, nDisplayMember As String, nValueMember As String)
        If dtData.Rows.Count > 0 Then
            With cmbLoad
                .DisplayMember = nDisplayMember
                .ValueMember = nValueMember
                .DataSource = dtData
                .SelectedIndex = 0
            End With
        End If
    End Sub

End Module

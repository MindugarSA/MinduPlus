Imports System.Data.SqlClient

Public Module MindugarConexion

    Public Function SelectDataTable(stringSelect As String) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(My.Settings.SBO_COMERCIALConnectionString)
            Dim cmd As New SqlCommand(stringSelect, con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    Public Sub PopulateDataTable(ByRef cmb As ComboBox, ByRef dt As DataTable, ByVal Optional firstBlank As Boolean = True)
        cmb.Items.Clear()
        If firstBlank Then
            cmb.Items.Add("")
        End If
        For index = 0 To dt.Rows.Count - 1
            cmb.Items.Add(dt.Rows(index)(0).ToString)
        Next
    End Sub
End Module

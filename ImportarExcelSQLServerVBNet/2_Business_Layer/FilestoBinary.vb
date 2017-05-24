Imports System.IO

Public Class FilestoBinary

    Public Shared Function GenerateByteArray(ubicacion As String) As Byte()

        Dim contenido() As Byte = Nothing

        If File.Exists(ubicacion) Then
            contenido = File.ReadAllBytes(ubicacion)
        End If

        Return contenido

    End Function

    Public Shared Sub CreateFileFromBinary(FileByte() As Byte, ubicacion As String)

        If Directory.Exists(ubicacion) Then
            File.WriteAllBytes(ubicacion, FileByte)
        End If

    End Sub

    Public Shared Function GenerateByteArrayFileStream(ubicacion As String) As Byte()

        Dim contenido() As Byte = Nothing

        If File.Exists(ubicacion) Then

            Dim finfo As New FileInfo(ubicacion)
            Dim fstream As New FileStream(ubicacion, FileMode.Open, FileAccess.Read)

            Dim br As New BinaryReader(fstream)

            contenido = br.ReadBytes(Convert.ToInt32(finfo.Length))

            br.Close()
            fstream.Close()
            fstream.Dispose()

        End If

        Return contenido

    End Function

End Class

'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Solicitud_HorasExtras
    Public Property id_solicitud_horas_extra As Integer
    Public Property supervisor_solicitante As String
    Public Property rut_solicitante As String
    Public Property fecha As Date
    Public Property cantidad_horas_extras As Integer
    Public Property area As String
    Public Property detalle As String
    Public Property resuelto As Nullable(Of Boolean)
    Public Property fecha_resolucion As Nullable(Of Date)

    Public Overridable Property Solicitud_HorasExtras_Colaboradores As ICollection(Of Solicitud_HorasExtras_Colaboradores) = New HashSet(Of Solicitud_HorasExtras_Colaboradores)

End Class

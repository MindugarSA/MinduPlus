Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Frm_SeleccionaTiporLiquidacion

    Private _TipoReporte As String
    Public Property TipoReporte() As String
        Get
            Return _TipoReporte
        End Get
        Set(ByVal value As String)
            _TipoReporte = value
        End Set
    End Property

    Private Sub Tle_Herramientas_Pre_Click(sender As Object, e As EventArgs) Handles Tle_Herramientas_Pre.Click
        TipoReporte = "PreLiquidacion"
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        TipoReporte = "Liquidacion"
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub MetroTile1_MouseEnter(sender As Object, e As EventArgs) Handles MetroTile1.MouseEnter, Tle_Herramientas_Pre.MouseEnter
        sender.Left = sender.Left - 4
        sender.Top = sender.Top - 4
        sender.Height = sender.Height + 8
        sender.Width = sender.Width + 8
    End Sub

    Private Sub MetroTile1_MouseLeave(sender As Object, e As EventArgs) Handles MetroTile1.MouseLeave, Tle_Herramientas_Pre.MouseLeave
        sender.Left = sender.Left + 4
        sender.Top = sender.Top + 4
        sender.Height = sender.Height - 8
        sender.Width = sender.Width - 8
    End Sub
End Class
Public Class Frm_SeleccionGestionAlmuerzos

    Property TipoReporte As String

    Private Sub SeleccionGestionAlmuerzos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroTile1_MouseEnter(sender As Object, e As EventArgs) Handles Tle_MantencionColacione.MouseEnter, Tle_Configuracion.MouseEnter, Tle_AlmuAdicional.MouseEnter, Tle_InformesAlmu.MouseEnter
        sender.Left = sender.Left - 4
        sender.Top = sender.Top - 4
        sender.Height = sender.Height + 8
        sender.Width = sender.Width + 8
    End Sub

    Private Sub MetroTile1_MouseLeave(sender As Object, e As EventArgs) Handles Tle_MantencionColacione.MouseLeave, Tle_Configuracion.MouseLeave, Tle_AlmuAdicional.MouseLeave, Tle_InformesAlmu.MouseLeave
        sender.Left = sender.Left + 4
        sender.Top = sender.Top + 4
        sender.Height = sender.Height - 8
        sender.Width = sender.Width - 8
    End Sub

    Private Sub Tle_MantencionColacione_Click(sender As Object, e As EventArgs) Handles Tle_MantencionColacione.Click
        TipoReporte = "MenuAlmuerzo"
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Tle_AlmuAdicional_Click(sender As Object, e As EventArgs) Handles Tle_AlmuAdicional.Click
        TipoReporte = "Adicionales"
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Tle_Configuracion_Click(sender As Object, e As EventArgs) Handles Tle_Configuracion.Click
        TipoReporte = "Configuracion"
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Tle_InformesAlmu_Click(sender As Object, e As EventArgs) Handles Tle_InformesAlmu.Click
        TipoReporte = "InformesAlmuerzo"
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
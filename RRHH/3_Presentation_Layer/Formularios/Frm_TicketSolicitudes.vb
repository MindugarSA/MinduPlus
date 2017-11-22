Public Class Frm_TicketSolicitudes

    Private Sub Frm_TicketSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtObserva_Leave(sender As Object, e As EventArgs) Handles txtObserva.Leave
        panel2.BackColor = Color.FromArgb(224, 224, 224)
        panel2.Height -= 1
    End Sub

    Private Sub txtObserva_Enter(sender As Object, e As EventArgs) Handles txtObserva.Enter
        panel2.BackColor = Color.FromArgb(255, 152, 0)
        panel2.Height += 1
    End Sub


End Class
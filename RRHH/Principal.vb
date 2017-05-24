Public Class Principal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmx As New Form1
        frmx.MdiParent = Me.MdiParent
        frmx.Show()
        'frmx.ControlBox = True
    End Sub





End Class

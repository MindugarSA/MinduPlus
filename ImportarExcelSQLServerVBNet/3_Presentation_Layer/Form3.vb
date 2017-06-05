Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Imports ImportarExcelSQLServer._2_Business_Layer

Namespace _3_Presentation_Layer
	Public Partial Class Form3
        Inherits MetroFramework.Forms.MetroForm 'Form

        Public Property Opener As IComunication

        Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub Form3_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
            Styles.DegradeBackGround(Me, e)
            Styles.HeaderLine(Me, e)
        End Sub

        Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
            Me.Close()
        End Sub

        Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
            ' Dim formInterface As IComunication = CType(Me.Opener, IComunication)

            If (BAccesos.Verificar(textBox1.Text, textBox2.Text)) Then
                'If formInterface IsNot Nothing Then
                Me.Opener.ChangeBoolProperty(True, "bAcceso")
                Me.Opener.ChangeStringProperty(textBox1.Text, "sUsuario")
                'End If

                Me.Close()
            Else
                MessageBox.Show("Usuario o Contraseña Incorrectas", "Accesos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        End Sub

        Private Sub textBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox1.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                SendKeys.Send("{Tab}")
            End If
        End Sub

        Private Sub textBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox2.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                button1.PerformClick()
            End If
        End Sub

    End Class
End Namespace

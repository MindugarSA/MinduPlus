Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace _3_Presentation_Layer
	Public Partial Class Form2
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form2_Paint(sender As Object, e As PaintEventArgs)
			Styles.DegradeBackGround(Me, e)
			Styles.HeaderLine(Me, e)

			Me.gradientTab1.PageEndColor = System.Drawing.Color.LightGray
			Me.gradientTab1.PageStartColor = System.Drawing.Color.White
		End Sub

		Private Sub Form2_Load(sender As Object, e As EventArgs)
			' this.tabControl1.TabPages[0].BackColor = Color.Transparent;
			' transparentTabControl1.MakeTransparent();
		End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            Dim Xm As Int16 = 33
        End Sub

        Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        End Sub
    End Class
End Namespace

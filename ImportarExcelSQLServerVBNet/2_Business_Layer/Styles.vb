Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Class Styles
	Public Shared Sub DegradeBackGround(formulario As Form, e As PaintEventArgs)
		'Fondo Degradado
		Dim Rect As New Rectangle(0, 0, formulario.Width, formulario.Height)
		Dim LinearBrush As New LinearGradientBrush(Rect, Color.White, Color.LightGray, LinearGradientMode.Vertical)
		Dim g As Graphics = e.Graphics
		g.FillRectangle(LinearBrush, 0, 0, formulario.Width, formulario.Height)

	End Sub

	Public Shared Sub HeaderLine(formulario As Form, e As PaintEventArgs)
		'Linea Cabecera
		Dim Col As New SolidBrush(ColorTranslator.FromHtml("#FCB712"))
		e.Graphics.FillRectangle(Col, 0, 0, formulario.Width, 5)
	End Sub

End Class

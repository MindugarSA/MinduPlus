Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace _2_Business_Layer

	Class GradientTab
		Inherits System.Windows.Forms.TabControl

		' member variables
		Private StartColor As System.Drawing.Color
		Private EndColor As System.Drawing.Color

		Public Sub New()
			InitializeComponent()
			RepaintControls()
		End Sub

		Protected Overrides Sub OnPaint(pe As PaintEventArgs)
			' TODO: Add custom paint code here

			' Calling the base class OnPaint
			'base.OnPaint(pe);
			RepaintControls()
		End Sub


		Private Sub RepaintControls()
			For Each ctl As TabPage In Me.TabPages
				Try
					'System.Drawing.Drawing2D.LinearGradientBrush gradBrush;
					'gradBrush = new System.Drawing.Drawing2D.LinearGradientBrush(new Point(0, 0),PageStartColor, PageEndColor, LinearGradientMode.Vertical);

					Dim bmp As New Bitmap(ctl.Width, ctl.Height)

					'Graphics g = Graphics.FromImage(bmp);
					'g.FillRectangle(gradBrush, new Rectangle(0, 0, ctl.Width, ctl.Height));

					Dim Rect As New Rectangle(0, 0, ctl.Width, ctl.Height)
					Dim LinearBrush As New LinearGradientBrush(Rect, Color.White, Color.LightGray, LinearGradientMode.Vertical)
					Dim g As Graphics = Graphics.FromImage(bmp)
					g.FillRectangle(LinearBrush, 0, 0, ctl.Width, ctl.Height)

					ctl.BackgroundImage = bmp
					ctl.BackgroundImageLayout = ImageLayout.Stretch
				Catch generatedExceptionName As Exception
				End Try
			Next
		End Sub

		Private Sub GradientTab_Resize(sender As Object, e As EventArgs)
			RepaintControls()
		End Sub


		Public Property PageStartColor() As System.Drawing.Color
			Get
				Return StartColor
			End Get
			Set
				StartColor = value
				RepaintControls()
			End Set
		End Property


		Public Property PageEndColor() As System.Drawing.Color
			Get
				Return EndColor
			End Get
			Set
				EndColor = value
				RepaintControls()
			End Set
		End Property

		Private components As System.ComponentModel.IContainer = Nothing

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Sub InitializeComponent()
			Me.SuspendLayout()
            ' 
            ' GradientTab
            ' 
            'AddHandler Me.Resize, New System.EventHandler(AddressOf Me.GradientTab_Resize)
            AddHandler Resize, AddressOf Me.GradientTab_Resize
            Me.ResumeLayout(False)

		End Sub

	End Class
End Namespace

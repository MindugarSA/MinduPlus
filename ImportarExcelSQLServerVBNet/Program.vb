Imports ImportarExcelSQLServer._3_Presentation_Layer
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms

NotInheritable Class Program
	Private Sub New()
	End Sub
	''' <summary>
	''' Punto de entrada principal para la aplicación.
	''' </summary>
	<STAThread> _
	Friend Shared Sub Main()
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1(New Panel(), 1000, 0))
    End Sub
End Class

Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace _2_Business_Layer
	''' <summary>
	''' Specifies the style that a WinForms.ProgressWorker uses to indicate
	''' the progress of an operation.
	''' </summary>
	Public Enum ProgressWorkerStyle
		''' <summary>
		''' Indicates progress by increasing the number of segmented blocks in a WinForms.ProgressWorker.
		''' </summary>
		Blocks = 0
		''' <summary>
		''' Indicates progress by increasing the size of a smooth, continuous bar in a WinForms.ProgressWorker.
		''' </summary>
		Continuous = 1
	End Enum
End Namespace

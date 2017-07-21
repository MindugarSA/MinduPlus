Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace _2_Business_Layer
	Class ResizeControls

		Private _arr_control_storage As New List(Of System.Drawing.Rectangle)()
		Private showRowHeader As Boolean = False
		Public Sub New(_form_ As Form)
			form = _form_
			'the calling form
			_formSize = _form_.ClientSize
			'Save initial form size
				'Font size
			_fontsize = _form_.Font.Size
		End Sub

		Private Property _fontsize() As Single
			Get
				Return m__fontsize
			End Get
			Set
				m__fontsize = Value
			End Set
		End Property
		Private m__fontsize As Single

		Private Property _formSize() As System.Drawing.SizeF
			Get
				Return m__formSize
			End Get
			Set
				m__formSize = Value
			End Set
		End Property
		Private m__formSize As System.Drawing.SizeF

		Private Property form() As Form
			Get
				Return m_form
			End Get
			Set
				m_form = Value
			End Set
		End Property
		Private m_form As Form

		Public Sub _get_initial_size()
            'get initial size//
            Dim _controls As IEnumerable(Of Control) = _get_all_controls(form)
            'call the enumerator
            For Each control As Control In _controls
				'Loop through the controls
				_arr_control_storage.Add(control.Bounds)
				'saves control bounds/dimension            
				'If you have datagridview
				If control.[GetType]() Is GetType(DataGridView) Then
					_dgv_Column_Adjust(DirectCast(control, DataGridView), showRowHeader)
				End If
			Next
		End Sub

		Public Sub _resize()
		'Set the resize
			Dim _form_ratio_width As Double = CDbl(form.ClientSize.Width) / CDbl(_formSize.Width)
			'ratio could be greater or less than 1
			Dim _form_ratio_height As Double = CDbl(form.ClientSize.Height) / CDbl(_formSize.Height)
            ' this one too
            Dim _controls As IEnumerable(Of Control) = _get_all_controls(form)
            'reenumerate the control collection
            Dim _pos As Integer = -1
			'do not change this value unless you know what you are doing
			For Each control As Control In _controls
				' do some math calc
				_pos += 1
				'increment by 1;
				Dim _controlSize As New System.Drawing.Size(CInt(Math.Truncate(_arr_control_storage(_pos).Width * _form_ratio_width)), CInt(Math.Truncate(_arr_control_storage(_pos).Height * _form_ratio_height)))
				'use for sizing
				Dim _controlposition As New System.Drawing.Point(CInt(Math.Truncate(_arr_control_storage(_pos).X * _form_ratio_width)), CInt(Math.Truncate(_arr_control_storage(_pos).Y * _form_ratio_height)))
				'use for location
				'set bounds
				control.Bounds = New System.Drawing.Rectangle(_controlposition, _controlSize)
				'Put together
				'Assuming you have a datagridview inside a form()
				'if you want to show the row header, replace the false statement of 
				'showRowHeader on top/public declaration to true;
				If control.[GetType]() Is GetType(DataGridView) Then
					_dgv_Column_Adjust(DirectCast(control, DataGridView), showRowHeader)
				End If


				'Font AutoSize

				control.Font = New System.Drawing.Font(form.Font.FontFamily, CSng(((Convert.ToDouble(_fontsize) * _form_ratio_width) / 2) + ((Convert.ToDouble(_fontsize) * _form_ratio_height) / 2)))
			Next
		End Sub

		Private Sub _dgv_Column_Adjust(dgv As DataGridView, _showRowHeader As Boolean)
		'if you have Datagridview 
		'and want to resize the column base on its dimension.
			Dim intRowHeader As Integer = 0
			Const  Hscrollbarwidth As Integer = 5
			If _showRowHeader Then
				intRowHeader = dgv.RowHeadersWidth
			Else
				dgv.RowHeadersVisible = False
			End If

			For i As Integer = 0 To dgv.ColumnCount - 1
				If dgv.Dock = DockStyle.Fill Then
					'in case the datagridview is docked
					dgv.Columns(i).Width = ((dgv.Width - intRowHeader) \ dgv.ColumnCount)
				Else
					dgv.Columns(i).Width = ((dgv.Width - intRowHeader - Hscrollbarwidth) \ dgv.ColumnCount)
				End If
			Next
		End Sub




		Private Shared Function _get_all_controls(c As Control) As IEnumerable(Of Control)
			Return c.Controls.Cast(Of Control)().SelectMany(Function(item) _get_all_controls(item)).Concat(c.Controls.Cast(Of Control)()).Where(Function(control) control.Name <> String.Empty)
		End Function
	End Class

End Namespace

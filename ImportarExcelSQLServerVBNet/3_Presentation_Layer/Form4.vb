Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace _3_Presentation_Layer
	Public Partial Class Form4
		Inherits Form
		Public Delegate Sub LaunchEvent(lConceptos As List(Of String))
        Public Event EnviarEvento As LaunchEvent
        Public Property Opener As IComunication
        Public Property dtConceptos() As DataTable
			Get
				Return m_dtConceptos
			End Get
			Set
				m_dtConceptos = Value
			End Set
		End Property
		Private m_dtConceptos As DataTable

		Private lConceptos As New List(Of String)() From { _
		}
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            dataGridView1.DataSource = dtConceptos
            FormatearGridConceptos()
            AgregarColumnaCheckConceptos()
            dataGridView1.AutoResizeColumns()

        End Sub
        Private Sub Form4_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
            Styles.DegradeBackGround(Me, e)
            Styles.HeaderLine(Me, e)
        End Sub
        Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            'Dim formInterface As IComunication = TryCast(Me.Owner, IComunication)
            If Not DirectCast(Me.Opener, Form1).bFiltroConcepto AndAlso e.CloseReason = CloseReason.UserClosing Then
                DirectCast(Me.Opener, Form1).ChangeCheckBoxStatus(False, "checkBox2")
            End If
        End Sub
        Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
            'Dim formInterface As IComunication = TryCast(Me.Owner, IComunication)
            If Not DirectCast(Me.Opener, Form1).bFiltroConcepto Then
                DirectCast(Me.Opener, Form1).ChangeCheckBoxStatus(False, "checkBox2")
            End If
            Me.Close()
        End Sub
        Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
            'Dim formInterface As IComunication = TryCast(Me.Owner, IComunication)

            If lConceptos IsNot Nothing AndAlso lConceptos.Count > 0 Then
                If lConceptos.Count = dataGridView1.RowCount Then
                    ' Si se seleccionan TODOS los conceptos se asume que no hay filtros aplicados.
                    Me.Opener.ChangeBoolProperty(False, "bFiltroConcepto")
                    DirectCast(Me.Opener, Form1).ChangeCheckBoxStatus(False, "checkBox2")
                Else
                    Me.Opener.ChangeBoolProperty(True, "bFiltroConcepto")
                    RaiseEvent EnviarEvento(lConceptos)
                End If
            End If

            Me.Close()
        End Sub
        Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged
            If checkBox1.Checked Then
                For Each row As DataGridViewRow In dataGridView1.Rows
                    row.DefaultCellStyle.BackColor = Color.Gold
                    DirectCast(row.Cells("chk"), DataGridViewCheckBoxCell).Value = True
                    lConceptos.Add(row.Cells(0).Value.ToString())
                Next
            Else
                For Each row As DataGridViewRow In dataGridView1.Rows
                    row.DefaultCellStyle.BackColor = Color.White
                    DirectCast(row.Cells("chk"), DataGridViewCheckBoxCell).Value = False
                    lConceptos.Clear()
                Next
            End If
        End Sub
        Private Sub dataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dataGridView1.CurrentCellDirtyStateChanged
            If dataGridView1.IsCurrentCellDirty Then
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        End Sub
        Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellContentClick
            'if (e.RowIndex == -1)
            '    return;
            If dataGridView1.Columns(e.ColumnIndex).Name = "chk" Then
                SeleccionRowCheckBox(e.RowIndex)
            End If
        End Sub
        Private Sub dataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellContentDoubleClick
            'if (e.RowIndex == -1)
            '    return;
            If dataGridView1.Columns(e.ColumnIndex).Name = "chk" Then
                SeleccionRowCheckBox(e.RowIndex)
            End If
        End Sub
        Private Sub dataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles dataGridView1.SelectionChanged
            dataGridView1.ClearSelection()
        End Sub
        Private Sub FormatearGridConceptos()
			For Each Col As DataGridViewTextBoxColumn In dataGridView1.Columns
				Col.[ReadOnly] = True
			Next
		End Sub
		Private Sub AgregarColumnaCheckConceptos()
			Dim chk As New DataGridViewCheckBoxColumn()
			chk.[ReadOnly] = False
			chk.HeaderText = "Selec."
			chk.Name = "chk"
			chk.Width = 50
			dataGridView1.Columns.Add(chk)
		End Sub
		Private Sub SeleccionRowCheckBox(nRow As Integer)
			Dim row As DataGridViewRow = dataGridView1.Rows(nRow)
			Dim cellSelecion As DataGridViewCheckBoxCell = TryCast(row.Cells("chk"), DataGridViewCheckBoxCell)

			If Convert.ToBoolean(cellSelecion.Value) Then
				row.DefaultCellStyle.BackColor = Color.Gold
				lConceptos.Add(row.Cells(0).Value.ToString())
			Else
				row.DefaultCellStyle.BackColor = Color.White
				lConceptos.RemoveAll(Function(x) x.Contains(row.Cells(0).Value.ToString()))
			End If
		End Sub


	End Class
End Namespace

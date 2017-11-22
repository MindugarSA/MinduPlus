<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TicketSolicitudes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRadioButton1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MaterialRadioButton2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton3 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.btnAgregarSolicitud = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.txtObserva = New System.Windows.Forms.TextBox()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.AcceptsReturn = False
        Me.MaterialSingleLineTextField1.AcceptsTab = False
        Me.MaterialSingleLineTextField1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialSingleLineTextField1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.MaterialSingleLineTextField1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.MaterialSingleLineTextField1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = ""
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(197, 121)
        Me.MaterialSingleLineTextField1.MaxLength = 32767
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Multiline = False
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.ReadOnly = False
        Me.MaterialSingleLineTextField1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(508, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 0
        Me.MaterialSingleLineTextField1.TabStop = False
        Me.MaterialSingleLineTextField1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        Me.MaterialSingleLineTextField1.WordWrap = True
        '
        'MaterialRadioButton1
        '
        Me.MaterialRadioButton1.AutoSize = True
        Me.MaterialRadioButton1.Depth = 0
        Me.MaterialRadioButton1.Font = New System.Drawing.Font("Segoe UI Light", 11.25!)
        Me.MaterialRadioButton1.Location = New System.Drawing.Point(452, 33)
        Me.MaterialRadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton1.Name = "MaterialRadioButton1"
        Me.MaterialRadioButton1.Ripple = True
        Me.MaterialRadioButton1.Size = New System.Drawing.Size(84, 30)
        Me.MaterialRadioButton1.TabIndex = 1
        Me.MaterialRadioButton1.TabStop = True
        Me.MaterialRadioButton1.Text = "Consulta"
        Me.MaterialRadioButton1.UseVisualStyleBackColor = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(18, 282)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 1
        Me.MetroTabControl1.Size = New System.Drawing.Size(687, 209)
        Me.MetroTabControl1.TabIndex = 2
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.White
        Me.MetroPanel1.Controls.Add(Me.panel2)
        Me.MetroPanel1.Controls.Add(Me.txtObserva)
        Me.MetroPanel1.Controls.Add(Me.Label4)
        Me.MetroPanel1.Controls.Add(Me.btnAgregarSolicitud)
        Me.MetroPanel1.Controls.Add(Me.Label3)
        Me.MetroPanel1.Controls.Add(Me.MetroComboBox1)
        Me.MetroPanel1.Controls.Add(Me.Label2)
        Me.MetroPanel1.Controls.Add(Me.Label1)
        Me.MetroPanel1.Controls.Add(Me.MaterialRadioButton3)
        Me.MetroPanel1.Controls.Add(Me.MaterialRadioButton2)
        Me.MetroPanel1.Controls.Add(Me.MaterialRadioButton1)
        Me.MetroPanel1.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.MetroPanel1.Controls.Add(Me.MetroTabControl1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(22, 13)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(793, 503)
        Me.MetroPanel1.TabIndex = 3
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MaterialRadioButton2
        '
        Me.MaterialRadioButton2.AutoSize = True
        Me.MaterialRadioButton2.Depth = 0
        Me.MaterialRadioButton2.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialRadioButton2.Location = New System.Drawing.Point(199, 32)
        Me.MaterialRadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton2.Name = "MaterialRadioButton2"
        Me.MaterialRadioButton2.Ripple = True
        Me.MaterialRadioButton2.Size = New System.Drawing.Size(92, 30)
        Me.MaterialRadioButton2.TabIndex = 3
        Me.MaterialRadioButton2.TabStop = True
        Me.MaterialRadioButton2.Text = "Incidencia"
        Me.MaterialRadioButton2.UseVisualStyleBackColor = True
        '
        'MaterialRadioButton3
        '
        Me.MaterialRadioButton3.AutoSize = True
        Me.MaterialRadioButton3.Depth = 0
        Me.MaterialRadioButton3.Font = New System.Drawing.Font("Segoe UI Light", 11.25!)
        Me.MaterialRadioButton3.Location = New System.Drawing.Point(330, 32)
        Me.MaterialRadioButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton3.Name = "MaterialRadioButton3"
        Me.MaterialRadioButton3.Ripple = True
        Me.MaterialRadioButton3.Size = New System.Drawing.Size(83, 30)
        Me.MaterialRadioButton3.TabIndex = 4
        Me.MaterialRadioButton3.TabStop = True
        Me.MaterialRadioButton3.Text = "Solicitud"
        Me.MaterialRadioButton3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(64, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tipo de Solicitud"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(14, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Departamento a Solicitar"
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(195, 75)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(258, 29)
        Me.MetroComboBox1.TabIndex = 7
        Me.MetroComboBox1.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(123, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Asunto"
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(679, 167)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "   Tickets Abiertos   "
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.BackColor = System.Drawing.Color.White
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(679, 167)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "   Tickets Cerrados   "
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'btnAgregarSolicitud
        '
        Me.btnAgregarSolicitud.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarSolicitud.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnAgregarSolicitud.FlatAppearance.BorderSize = 0
        Me.btnAgregarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarSolicitud.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarSolicitud.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgregarSolicitud.Image = Global.RRHH.My.Resources.Resources.save_file_option64
        Me.btnAgregarSolicitud.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAgregarSolicitud.Location = New System.Drawing.Point(611, 19)
        Me.btnAgregarSolicitud.Name = "btnAgregarSolicitud"
        Me.btnAgregarSolicitud.Size = New System.Drawing.Size(167, 80)
        Me.btnAgregarSolicitud.TabIndex = 44
        Me.btnAgregarSolicitud.Text = "Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Solicitud"
        Me.btnAgregarSolicitud.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAgregarSolicitud.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(93, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Descripcion"
        '
        'panel2
        '
        Me.panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.panel2.Location = New System.Drawing.Point(197, 278)
        Me.panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(508, 1)
        Me.panel2.TabIndex = 47
        '
        'txtObserva
        '
        Me.txtObserva.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObserva.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObserva.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.txtObserva.Location = New System.Drawing.Point(197, 175)
        Me.txtObserva.Multiline = True
        Me.txtObserva.Name = "txtObserva"
        Me.txtObserva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObserva.Size = New System.Drawing.Size(508, 101)
        Me.txtObserva.TabIndex = 46
        '
        'Frm_TicketSolicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 528)
        Me.Controls.Add(Me.MetroPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_TicketSolicitudes"
        Me.Text = "Frm_TicketSolicitudes"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRadioButton1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialRadioButton3 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAgregarSolicitud As Button
    Private WithEvents panel2 As Panel
    Private WithEvents txtObserva As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_InformePreLiquidaciones
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroTextBox2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MetroTextBox1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnImprimirInforme = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroToggle1 = New MetroFramework.Controls.MetroToggle()
        Me.MetroComboBox2 = New MetroFramework.Controls.MetroComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox2)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroComboBox1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.btnImprimirInforme)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(965, 170)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Impresion de Recibos Liquidacion"
        '
        'MetroTextBox2
        '
        Me.MetroTextBox2.AcceptsReturn = False
        Me.MetroTextBox2.AcceptsTab = False
        Me.MetroTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MetroTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.MetroTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MetroTextBox2.Depth = 0
        Me.MetroTextBox2.Hint = ""
        Me.MetroTextBox2.Location = New System.Drawing.Point(164, 111)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MetroTextBox2.Multiline = False
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ReadOnly = False
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.Size = New System.Drawing.Size(276, 23)
        Me.MetroTextBox2.TabIndex = 31
        Me.MetroTextBox2.TabStop = False
        Me.MetroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MetroTextBox2.UseSystemPasswordChar = False
        Me.MetroTextBox2.WordWrap = True
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.AcceptsReturn = False
        Me.MetroTextBox1.AcceptsTab = False
        Me.MetroTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MetroTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.MetroTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MetroTextBox1.Depth = 0
        Me.MetroTextBox1.Hint = ""
        Me.MetroTextBox1.Location = New System.Drawing.Point(164, 75)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MetroTextBox1.Multiline = False
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ReadOnly = False
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.Size = New System.Drawing.Size(276, 23)
        Me.MetroTextBox1.TabIndex = 30
        Me.MetroTextBox1.TabStop = False
        Me.MetroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MetroTextBox1.UseSystemPasswordChar = False
        Me.MetroTextBox1.WordWrap = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(97, 41)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel3.TabIndex = 29
        Me.MetroLabel3.Text = "Periodo:"
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(163, 36)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(276, 29)
        Me.MetroComboBox1.TabIndex = 28
        Me.MetroComboBox1.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(30, 76)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(125, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Nombre Completo:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(113, 111)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(42, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "R.U.T:"
        '
        'btnImprimirInforme
        '
        Me.btnImprimirInforme.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnImprimirInforme.FlatAppearance.BorderSize = 0
        Me.btnImprimirInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirInforme.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnImprimirInforme.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnImprimirInforme.Image = Global.RRHH.My.Resources.Resources.printing32
        Me.btnImprimirInforme.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnImprimirInforme.Location = New System.Drawing.Point(468, 44)
        Me.btnImprimirInforme.Name = "btnImprimirInforme"
        Me.btnImprimirInforme.Size = New System.Drawing.Size(115, 80)
        Me.btnImprimirInforme.TabIndex = 27
        Me.btnImprimirInforme.Text = "Imprimir"
        Me.btnImprimirInforme.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnImprimirInforme.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(985, 562)
        Me.Panel1.TabIndex = 30
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.MetroLabel4)
        Me.GroupBox2.Controls.Add(Me.MetroToggle1)
        Me.GroupBox2.Controls.Add(Me.MetroComboBox2)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(965, 126)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Activacion de Recibo PreLiquidacion"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(97, 60)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel4.TabIndex = 33
        Me.MetroLabel4.Text = "Periodo:"
        '
        'MetroToggle1
        '
        Me.MetroToggle1.AutoSize = True
        Me.MetroToggle1.Location = New System.Drawing.Point(455, 57)
        Me.MetroToggle1.Name = "MetroToggle1"
        Me.MetroToggle1.Size = New System.Drawing.Size(80, 24)
        Me.MetroToggle1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroToggle1.TabIndex = 4
        Me.MetroToggle1.Text = "Off"
        Me.MetroToggle1.UseCustomBackColor = True
        Me.MetroToggle1.UseCustomForeColor = True
        Me.MetroToggle1.UseSelectable = True
        Me.MetroToggle1.UseStyleColors = True
        '
        'MetroComboBox2
        '
        Me.MetroComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MetroComboBox2.FormattingEnabled = True
        Me.MetroComboBox2.ItemHeight = 23
        Me.MetroComboBox2.Location = New System.Drawing.Point(163, 55)
        Me.MetroComboBox2.Name = "MetroComboBox2"
        Me.MetroComboBox2.Size = New System.Drawing.Size(276, 29)
        Me.MetroComboBox2.TabIndex = 32
        Me.MetroComboBox2.UseSelectable = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(932, 83)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(557, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DESACTIVADO"
        '
        'Frm_InformePreLiquidaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(985, 562)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_InformePreLiquidaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents MetroTextBox2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MetroTextBox1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Private WithEvents btnImprimirInforme As Button
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MetroToggle1 As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
End Class

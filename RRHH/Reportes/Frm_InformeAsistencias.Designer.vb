﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_InformeAsistencias
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox3 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox2 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.btnImprimirInformePermisos = New System.Windows.Forms.Button()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.CachedInformeHoraExtra1 = New RRHH.CachedInformeHoraExtra()
        Me.MetroPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.GroupBox2)
        Me.MetroPanel1.Controls.Add(Me.GroupBox1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(12, 24)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1053, 539)
        Me.MetroPanel1.TabIndex = 26
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroGrid1)
        Me.GroupBox2.Controls.Add(Me.MetroLabel7)
        Me.GroupBox2.Controls.Add(Me.MetroComboBox3)
        Me.GroupBox2.Controls.Add(Me.MetroLabel4)
        Me.GroupBox2.Controls.Add(Me.MetroComboBox2)
        Me.GroupBox2.Controls.Add(Me.MetroLabel5)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1026, 337)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asitencia Grupo"
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle14
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(164, 119)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(419, 202)
        Me.MetroGrid1.TabIndex = 32
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(92, 83)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel7.TabIndex = 31
        Me.MetroLabel7.Text = "Empresa:"
        '
        'MetroComboBox3
        '
        Me.MetroComboBox3.FormattingEnabled = True
        Me.MetroComboBox3.ItemHeight = 23
        Me.MetroComboBox3.Location = New System.Drawing.Point(163, 79)
        Me.MetroComboBox3.Name = "MetroComboBox3"
        Me.MetroComboBox3.Size = New System.Drawing.Size(276, 29)
        Me.MetroComboBox3.TabIndex = 30
        Me.MetroComboBox3.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(97, 48)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel4.TabIndex = 29
        Me.MetroLabel4.Text = "Periodo:"
        '
        'MetroComboBox2
        '
        Me.MetroComboBox2.FormattingEnabled = True
        Me.MetroComboBox2.ItemHeight = 23
        Me.MetroComboBox2.Location = New System.Drawing.Point(163, 44)
        Me.MetroComboBox2.Name = "MetroComboBox2"
        Me.MetroComboBox2.Size = New System.Drawing.Size(276, 29)
        Me.MetroComboBox2.TabIndex = 28
        Me.MetroComboBox2.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(78, 123)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(77, 19)
        Me.MetroLabel5.TabIndex = 2
        Me.MetroLabel5.Text = "Empleados:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Image = Global.RRHH.My.Resources.Resources.printing32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(468, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 80)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Imprimir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroComboBox1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox1)
        Me.GroupBox1.Controls.Add(Me.btnImprimirInformePermisos)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1026, 170)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asitencia Individual"
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
        'MetroTextBox1
        '
        Me.MetroTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MetroTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(254, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(163, 75)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(276, 23)
        Me.MetroTextBox1.TabIndex = 3
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnImprimirInformePermisos
        '
        Me.btnImprimirInformePermisos.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnImprimirInformePermisos.FlatAppearance.BorderSize = 0
        Me.btnImprimirInformePermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirInformePermisos.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnImprimirInformePermisos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnImprimirInformePermisos.Image = Global.RRHH.My.Resources.Resources.printing32
        Me.btnImprimirInformePermisos.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnImprimirInformePermisos.Location = New System.Drawing.Point(468, 44)
        Me.btnImprimirInformePermisos.Name = "btnImprimirInformePermisos"
        Me.btnImprimirInformePermisos.Size = New System.Drawing.Size(115, 80)
        Me.btnImprimirInformePermisos.TabIndex = 27
        Me.btnImprimirInformePermisos.Text = "Imprimir"
        Me.btnImprimirInformePermisos.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnImprimirInformePermisos.UseVisualStyleBackColor = False
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
        'MetroTextBox2
        '
        Me.MetroTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MetroTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(254, 1)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(163, 109)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.ShortcutsEnabled = True
        Me.MetroTextBox2.Size = New System.Drawing.Size(276, 23)
        Me.MetroTextBox2.TabIndex = 5
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Frm_InformeAsistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1111, 575)
        Me.Controls.Add(Me.MetroPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_InformeAsistencias"
        Me.Text = "Frm_InformeAsistencias"
        Me.MetroPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Private WithEvents btnImprimirInformePermisos As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Private WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CachedInformeHoraExtra1 As CachedInformeHoraExtra
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox3 As MetroFramework.Controls.MetroComboBox
End Class
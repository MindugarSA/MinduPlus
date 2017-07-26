<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Liquidaciones
    Inherits MetroFramework.Forms.MetroForm 'System.Windows.Forms.Form

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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.CmbBx_Meses = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 46)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(979, 467)
        Me.WebBrowser1.TabIndex = 0
        '
        'CmbBx_Meses
        '
        Me.CmbBx_Meses.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbBx_Meses.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.CmbBx_Meses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbBx_Meses.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBx_Meses.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmbBx_Meses.FormattingEnabled = True
        Me.CmbBx_Meses.Location = New System.Drawing.Point(778, 45)
        Me.CmbBx_Meses.Name = "CmbBx_Meses"
        Me.CmbBx_Meses.Size = New System.Drawing.Size(196, 28)
        Me.CmbBx_Meses.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Image = Global.RRHH.My.Resources.Resources.printing32
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(856, 517)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 56)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Imprimir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Image = Global.RRHH.My.Resources.Resources.home_shape_32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(5, 517)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 56)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Volver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Al Inicio"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Recibo de Liquidaciones"
        '
        'Frm_Liquidaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 578)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbBx_Meses)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Liquidaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CmbBx_Meses As ComboBox
    Friend WithEvents Label1 As Label
End Class

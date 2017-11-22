<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SeleccionaTiporLiquidacion
    Inherits MetroFramework.Forms.MetroForm

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
        Me.Tle_Herramientas_Pre = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'Tle_Herramientas_Pre
        '
        Me.Tle_Herramientas_Pre.ActiveControl = Nothing
        Me.Tle_Herramientas_Pre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tle_Herramientas_Pre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Tle_Herramientas_Pre.Location = New System.Drawing.Point(29, 64)
        Me.Tle_Herramientas_Pre.Name = "Tle_Herramientas_Pre"
        Me.Tle_Herramientas_Pre.Size = New System.Drawing.Size(241, 107)
        Me.Tle_Herramientas_Pre.TabIndex = 11
        Me.Tle_Herramientas_Pre.Text = "Pre Liquidacion"
        Me.Tle_Herramientas_Pre.TileImage = Global.RRHH.My.Resources.Resources.file
        Me.Tle_Herramientas_Pre.UseCustomBackColor = True
        Me.Tle_Herramientas_Pre.UseSelectable = True
        Me.Tle_Herramientas_Pre.UseTileImage = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroTile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.MetroTile1.Location = New System.Drawing.Point(285, 64)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(241, 107)
        Me.MetroTile1.TabIndex = 12
        Me.MetroTile1.Text = "Liquidacion"
        Me.MetroTile1.TileImage = Global.RRHH.My.Resources.Resources.money_report
        Me.MetroTile1.UseCustomBackColor = True
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseTileImage = True
        '
        'Frm_SeleccionaTiporLiquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 194)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.Tle_Herramientas_Pre)
        Me.Name = "Frm_SeleccionaTiporLiquidacion"
        Me.Text = "Seleccionar Tipo de Informe"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tle_Herramientas_Pre As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
End Class

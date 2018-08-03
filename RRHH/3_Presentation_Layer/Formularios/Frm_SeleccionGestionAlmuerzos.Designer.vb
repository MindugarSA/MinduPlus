<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SeleccionGestionAlmuerzos
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
        Me.Tle_AlmuAdicional = New MetroFramework.Controls.MetroTile()
        Me.Tle_MantencionColacione = New MetroFramework.Controls.MetroTile()
        Me.Tle_Configuracion = New MetroFramework.Controls.MetroTile()
        Me.Tle_InformesAlmu = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'Tle_AlmuAdicional
        '
        Me.Tle_AlmuAdicional.ActiveControl = Nothing
        Me.Tle_AlmuAdicional.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Tle_AlmuAdicional.Location = New System.Drawing.Point(162, 64)
        Me.Tle_AlmuAdicional.Name = "Tle_AlmuAdicional"
        Me.Tle_AlmuAdicional.Size = New System.Drawing.Size(123, 111)
        Me.Tle_AlmuAdicional.TabIndex = 15
        Me.Tle_AlmuAdicional.Text = "Adicionales"
        Me.Tle_AlmuAdicional.TileImage = Global.RRHH.My.Resources.Resources.restaurant
        Me.Tle_AlmuAdicional.UseCustomBackColor = True
        Me.Tle_AlmuAdicional.UseSelectable = True
        Me.Tle_AlmuAdicional.UseTileImage = True
        '
        'Tle_MantencionColacione
        '
        Me.Tle_MantencionColacione.ActiveControl = Nothing
        Me.Tle_MantencionColacione.BackColor = System.Drawing.Color.Orange
        Me.Tle_MantencionColacione.Location = New System.Drawing.Point(33, 64)
        Me.Tle_MantencionColacione.Name = "Tle_MantencionColacione"
        Me.Tle_MantencionColacione.Size = New System.Drawing.Size(123, 111)
        Me.Tle_MantencionColacione.TabIndex = 16
        Me.Tle_MantencionColacione.Text = "Ingreso Menu"
        Me.Tle_MantencionColacione.TileImage = Global.RRHH.My.Resources.Resources.menu1
        Me.Tle_MantencionColacione.UseCustomBackColor = True
        Me.Tle_MantencionColacione.UseSelectable = True
        Me.Tle_MantencionColacione.UseTileImage = True
        '
        'Tle_Configuracion
        '
        Me.Tle_Configuracion.ActiveControl = Nothing
        Me.Tle_Configuracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Tle_Configuracion.Location = New System.Drawing.Point(33, 181)
        Me.Tle_Configuracion.Name = "Tle_Configuracion"
        Me.Tle_Configuracion.Size = New System.Drawing.Size(252, 111)
        Me.Tle_Configuracion.TabIndex = 17
        Me.Tle_Configuracion.Text = "Configurar Almuerzos / Leche"
        Me.Tle_Configuracion.TileImage = Global.RRHH.My.Resources.Resources.settings
        Me.Tle_Configuracion.UseCustomBackColor = True
        Me.Tle_Configuracion.UseSelectable = True
        Me.Tle_Configuracion.UseTileImage = True
        '
        'Tle_InformesAlmu
        '
        Me.Tle_InformesAlmu.ActiveControl = Nothing
        Me.Tle_InformesAlmu.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Tle_InformesAlmu.Location = New System.Drawing.Point(290, 64)
        Me.Tle_InformesAlmu.Name = "Tle_InformesAlmu"
        Me.Tle_InformesAlmu.Size = New System.Drawing.Size(119, 228)
        Me.Tle_InformesAlmu.TabIndex = 18
        Me.Tle_InformesAlmu.Text = "Informes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Almuerzos"
        Me.Tle_InformesAlmu.TileImage = Global.RRHH.My.Resources.Resources.list_document_interface_symbol
        Me.Tle_InformesAlmu.UseCustomBackColor = True
        Me.Tle_InformesAlmu.UseSelectable = True
        Me.Tle_InformesAlmu.UseTileImage = True
        '
        'Frm_SeleccionGestionAlmuerzos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 320)
        Me.Controls.Add(Me.Tle_InformesAlmu)
        Me.Controls.Add(Me.Tle_Configuracion)
        Me.Controls.Add(Me.Tle_AlmuAdicional)
        Me.Controls.Add(Me.Tle_MantencionColacione)
        Me.Name = "Frm_SeleccionGestionAlmuerzos"
        Me.Text = "Gestion de Almuerzos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tle_AlmuAdicional As MetroFramework.Controls.MetroTile
    Friend WithEvents Tle_MantencionColacione As MetroFramework.Controls.MetroTile
    Friend WithEvents Tle_Configuracion As MetroFramework.Controls.MetroTile
    Friend WithEvents Tle_InformesAlmu As MetroFramework.Controls.MetroTile
End Class

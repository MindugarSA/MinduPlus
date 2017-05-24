<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SolicitudGerencial
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
        Me.panelCentral = New System.Windows.Forms.Panel()
        Me.Lbl_Fecha = New System.Windows.Forms.Label()
        Me.Txt_Fecha = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_ComentAlmNorm = New System.Windows.Forms.TextBox()
        Me.TB_AlmuerzoNormales = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tt_ComentAlmGcial = New System.Windows.Forms.TextBox()
        Me.Tb_Gerencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.panelCentral.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelCentral
        '
        Me.panelCentral.Controls.Add(Me.Lbl_Fecha)
        Me.panelCentral.Controls.Add(Me.Txt_Fecha)
        Me.panelCentral.Controls.Add(Me.btnVolver)
        Me.panelCentral.Controls.Add(Me.Button1)
        Me.panelCentral.Controls.Add(Me.Label5)
        Me.panelCentral.Controls.Add(Me.TB_ComentAlmNorm)
        Me.panelCentral.Controls.Add(Me.TB_AlmuerzoNormales)
        Me.panelCentral.Controls.Add(Me.Label4)
        Me.panelCentral.Controls.Add(Me.Label3)
        Me.panelCentral.Controls.Add(Me.Tt_ComentAlmGcial)
        Me.panelCentral.Controls.Add(Me.Tb_Gerencia)
        Me.panelCentral.Controls.Add(Me.Label2)
        Me.panelCentral.Controls.Add(Me.Label1)
        Me.panelCentral.Controls.Add(Me.MonthCalendar1)
        Me.panelCentral.Location = New System.Drawing.Point(38, 12)
        Me.panelCentral.Name = "panelCentral"
        Me.panelCentral.Size = New System.Drawing.Size(655, 279)
        Me.panelCentral.TabIndex = 12
        '
        'Lbl_Fecha
        '
        Me.Lbl_Fecha.AutoSize = True
        Me.Lbl_Fecha.Location = New System.Drawing.Point(544, 36)
        Me.Lbl_Fecha.Name = "Lbl_Fecha"
        Me.Lbl_Fecha.Size = New System.Drawing.Size(57, 13)
        Me.Lbl_Fecha.TabIndex = 23
        Me.Lbl_Fecha.Text = "Lbl_Fecha"
        '
        'Txt_Fecha
        '
        Me.Txt_Fecha.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Txt_Fecha.Location = New System.Drawing.Point(9, 4)
        Me.Txt_Fecha.Name = "Txt_Fecha"
        Me.Txt_Fecha.ReadOnly = True
        Me.Txt_Fecha.Size = New System.Drawing.Size(248, 20)
        Me.Txt_Fecha.TabIndex = 22
        Me.Txt_Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(9, 237)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(131, 23)
        Me.btnVolver.TabIndex = 21
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(513, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Grabar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(295, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Motivo"
        '
        'TB_ComentAlmNorm
        '
        Me.TB_ComentAlmNorm.Location = New System.Drawing.Point(389, 168)
        Me.TB_ComentAlmNorm.MaxLength = 50
        Me.TB_ComentAlmNorm.Name = "TB_ComentAlmNorm"
        Me.TB_ComentAlmNorm.Size = New System.Drawing.Size(240, 20)
        Me.TB_ComentAlmNorm.TabIndex = 18
        '
        'TB_AlmuerzoNormales
        '
        Me.TB_AlmuerzoNormales.Location = New System.Drawing.Point(389, 142)
        Me.TB_AlmuerzoNormales.MaxLength = 2
        Me.TB_AlmuerzoNormales.Name = "TB_AlmuerzoNormales"
        Me.TB_AlmuerzoNormales.Size = New System.Drawing.Size(39, 20)
        Me.TB_AlmuerzoNormales.TabIndex = 17
        Me.TB_AlmuerzoNormales.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(295, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Normales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(295, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Motivo"
        '
        'Tt_ComentAlmGcial
        '
        Me.Tt_ComentAlmGcial.Location = New System.Drawing.Point(389, 90)
        Me.Tt_ComentAlmGcial.MaxLength = 50
        Me.Tt_ComentAlmGcial.Name = "Tt_ComentAlmGcial"
        Me.Tt_ComentAlmGcial.Size = New System.Drawing.Size(240, 20)
        Me.Tt_ComentAlmGcial.TabIndex = 14
        '
        'Tb_Gerencia
        '
        Me.Tb_Gerencia.Location = New System.Drawing.Point(389, 64)
        Me.Tb_Gerencia.MaxLength = 2
        Me.Tb_Gerencia.Name = "Tb_Gerencia"
        Me.Tb_Gerencia.Size = New System.Drawing.Size(39, 20)
        Me.Tb_Gerencia.TabIndex = 13
        Me.Tb_Gerencia.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(295, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Gerenciales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(329, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Indique la Cantidad de almuerzos Especiales"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(9, 26)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 10
        '
        'Frm_SolicitudGerencial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1023, 570)
        Me.Controls.Add(Me.panelCentral)
        Me.Name = "Frm_SolicitudGerencial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frm_SolicitudGerencial"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.panelCentral.ResumeLayout(False)
        Me.panelCentral.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelCentral As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_ComentAlmNorm As TextBox
    Friend WithEvents TB_AlmuerzoNormales As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Tt_ComentAlmGcial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Txt_Fecha As TextBox
    Friend WithEvents Tb_Gerencia As TextBox
    Friend WithEvents Lbl_Fecha As Label
End Class

Namespace _3_Presentation_Layer
	Partial Class Form3
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.textBox2 = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.button1 = New System.Windows.Forms.Button()
            Me.button2 = New System.Windows.Forms.Button()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pictureBox1
            '
            Me.pictureBox1.BackgroundImage = Global.ImportarExcelSQLServer.Resources.user
            Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.pictureBox1.Location = New System.Drawing.Point(10, 64)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(129, 121)
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(146, 70)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(54, 17)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Usuario"
            '
            'textBox1
            '
            Me.textBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox1.Location = New System.Drawing.Point(199, 66)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(139, 25)
            Me.textBox1.TabIndex = 1
            '
            'textBox2
            '
            Me.textBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox2.Location = New System.Drawing.Point(199, 95)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.textBox2.Size = New System.Drawing.Size(139, 25)
            Me.textBox2.TabIndex = 2
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(146, 99)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(40, 17)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Clave"
            '
            'button1
            '
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
            Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.button1.FlatAppearance.BorderSize = 0
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
            Me.button1.Location = New System.Drawing.Point(184, 148)
            Me.button1.Margin = New System.Windows.Forms.Padding(0)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 35)
            Me.button1.TabIndex = 3
            Me.button1.Text = "OK"
            Me.button1.UseVisualStyleBackColor = False
            '
            'button2
            '
            Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
            Me.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.button2.FlatAppearance.BorderSize = 0
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
            Me.button2.Location = New System.Drawing.Point(263, 148)
            Me.button2.Margin = New System.Windows.Forms.Padding(0)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(75, 35)
            Me.button2.TabIndex = 4
            Me.button2.Text = "Cancelar"
            Me.button2.UseVisualStyleBackColor = False
            '
            'Form3
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(353, 197)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.textBox2)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.pictureBox1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form3"
            Me.Text = "Acceso"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents label1 As System.Windows.Forms.Label
        Friend WithEvents textBox1 As System.Windows.Forms.TextBox
        Friend WithEvents textBox2 As System.Windows.Forms.TextBox
        Friend WithEvents label2 As System.Windows.Forms.Label
        Friend WithEvents button1 As System.Windows.Forms.Button
        Friend WithEvents button2 As System.Windows.Forms.Button

    End Class
End Namespace

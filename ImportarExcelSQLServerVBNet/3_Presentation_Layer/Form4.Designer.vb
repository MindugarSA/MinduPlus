Namespace _3_Presentation_Layer
	Partial Class Form4
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.dataGridView1 = New System.Windows.Forms.DataGridView()
            Me.button2 = New System.Windows.Forms.Button()
            Me.button1 = New System.Windows.Forms.Button()
            Me.groupBox1.SuspendLayout()
            CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'groupBox1
            '
            Me.groupBox1.BackColor = System.Drawing.Color.Transparent
            Me.groupBox1.Controls.Add(Me.checkBox1)
            Me.groupBox1.Controls.Add(Me.dataGridView1)
            Me.groupBox1.Location = New System.Drawing.Point(13, 13)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(480, 270)
            Me.groupBox1.TabIndex = 0
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Conceptos a Exportar"
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.checkBox1.Location = New System.Drawing.Point(397, 13)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(56, 17)
            Me.checkBox1.TabIndex = 1
            Me.checkBox1.Text = "Todos"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'dataGridView1
            '
            Me.dataGridView1.AllowUserToAddRows = False
            Me.dataGridView1.AllowUserToDeleteRows = False
            Me.dataGridView1.AllowUserToOrderColumns = True
            Me.dataGridView1.AllowUserToResizeRows = False
            Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dataGridView1.DefaultCellStyle = DataGridViewCellStyle1
            Me.dataGridView1.Location = New System.Drawing.Point(14, 34)
            Me.dataGridView1.Name = "dataGridView1"
            Me.dataGridView1.RowHeadersVisible = False
            Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
            Me.dataGridView1.Size = New System.Drawing.Size(451, 220)
            Me.dataGridView1.TabIndex = 0
            '
            'button2
            '
            Me.button2.BackgroundImage = Global.ImportarExcelSQLServer.Resources.BtnDfto1
            Me.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button2.Location = New System.Drawing.Point(338, 289)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(75, 23)
            Me.button2.TabIndex = 6
            Me.button2.Text = "OK"
            Me.button2.UseVisualStyleBackColor = True
            '
            'button1
            '
            Me.button1.BackgroundImage = Global.ImportarExcelSQLServer.Resources.Bnt
            Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button1.Location = New System.Drawing.Point(418, 289)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 7
            Me.button1.Text = "Cancelar"
            Me.button1.UseVisualStyleBackColor = True
            '
            'Form4
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.AliceBlue
            Me.ClientSize = New System.Drawing.Size(510, 319)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.groupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form4"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Conceptos"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
        Private WithEvents button2 As System.Windows.Forms.Button
        Private WithEvents button1 As System.Windows.Forms.Button
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    End Class
End Namespace

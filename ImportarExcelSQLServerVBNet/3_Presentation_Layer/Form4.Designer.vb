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
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.dataGridView1 = New MetroFramework.Controls.MetroGrid()
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
            Me.groupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(13, 60)
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
            Me.checkBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox1.Location = New System.Drawing.Point(397, 13)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(63, 21)
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
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
            Me.dataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
            Me.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
            Me.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dataGridView1.DefaultCellStyle = DataGridViewCellStyle3
            Me.dataGridView1.EnableHeadersVisualStyles = False
            Me.dataGridView1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.dataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.dataGridView1.Location = New System.Drawing.Point(14, 34)
            Me.dataGridView1.Name = "dataGridView1"
            Me.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dataGridView1.RowHeadersVisible = False
            Me.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
            Me.dataGridView1.Size = New System.Drawing.Size(451, 220)
            Me.dataGridView1.TabIndex = 0
            '
            'button2
            '
            Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
            Me.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.button2.FlatAppearance.BorderSize = 0
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
            Me.button2.Location = New System.Drawing.Point(338, 336)
            Me.button2.Margin = New System.Windows.Forms.Padding(0)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(75, 35)
            Me.button2.TabIndex = 6
            Me.button2.Text = "OK"
            Me.button2.UseVisualStyleBackColor = False
            '
            'button1
            '
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(26, Byte), Integer))
            Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.button1.FlatAppearance.BorderSize = 0
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
            Me.button1.Location = New System.Drawing.Point(418, 336)
            Me.button1.Margin = New System.Windows.Forms.Padding(0)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 35)
            Me.button1.TabIndex = 7
            Me.button1.Text = "Cancelar"
            Me.button1.UseVisualStyleBackColor = False
            '
            'Form4
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(510, 380)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.groupBox1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form4"
            Me.Text = "Conceptos"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents dataGridView1 As MetroFramework.Controls.MetroGrid 'System.Windows.Forms.DataGridView
        Private WithEvents button2 As System.Windows.Forms.Button
        Private WithEvents button1 As System.Windows.Forms.Button
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    End Class
End Namespace

Namespace _3_Presentation_Layer
	Partial Class Form2
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
            Me.gradientTab1 = New ImportarExcelSQLServer._2_Business_Layer.GradientTab()
            Me.tabPage1 = New System.Windows.Forms.TabPage()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.button2 = New System.Windows.Forms.Button()
            Me.button1 = New System.Windows.Forms.Button()
            Me.tabPage2 = New System.Windows.Forms.TabPage()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.GradientTab2 = New ImportarExcelSQLServer._2_Business_Layer.GradientTab()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.TabPage4 = New System.Windows.Forms.TabPage()
            Me.gradientTab1.SuspendLayout()
            Me.tabPage1.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.GradientTab2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gradientTab1
            '
            Me.gradientTab1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gradientTab1.Controls.Add(Me.tabPage1)
            Me.gradientTab1.Controls.Add(Me.tabPage2)
            Me.gradientTab1.Location = New System.Drawing.Point(12, 12)
            Me.gradientTab1.Name = "gradientTab1"
            Me.gradientTab1.PageEndColor = System.Drawing.Color.Empty
            Me.gradientTab1.PageStartColor = System.Drawing.Color.Empty
            Me.gradientTab1.SelectedIndex = 0
            Me.gradientTab1.Size = New System.Drawing.Size(802, 410)
            Me.gradientTab1.TabIndex = 0
            '
            'tabPage1
            '
            Me.tabPage1.BackColor = System.Drawing.Color.AliceBlue
            Me.tabPage1.BackgroundImage = CType(resources.GetObject("tabPage1.BackgroundImage"), System.Drawing.Image)
            Me.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tabPage1.Controls.Add(Me.groupBox1)
            Me.tabPage1.Location = New System.Drawing.Point(4, 22)
            Me.tabPage1.Name = "tabPage1"
            Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage1.Size = New System.Drawing.Size(794, 384)
            Me.tabPage1.TabIndex = 0
            Me.tabPage1.Text = "tabPage1"
            '
            'groupBox1
            '
            Me.groupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.groupBox1.BackColor = System.Drawing.Color.AliceBlue
            Me.groupBox1.Controls.Add(Me.button2)
            Me.groupBox1.Controls.Add(Me.button1)
            Me.groupBox1.Location = New System.Drawing.Point(7, 7)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(690, 329)
            Me.groupBox1.TabIndex = 0
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "groupBox1"
            '
            'button2
            '
            Me.button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button2.Location = New System.Drawing.Point(605, 294)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(75, 23)
            Me.button2.TabIndex = 1
            Me.button2.Text = "button2"
            Me.button2.UseVisualStyleBackColor = True
            '
            'button1
            '
            Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button1.Location = New System.Drawing.Point(587, 20)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 0
            Me.button1.Text = "button1"
            Me.button1.UseVisualStyleBackColor = True
            '
            'tabPage2
            '
            Me.tabPage2.BackgroundImage = CType(resources.GetObject("tabPage2.BackgroundImage"), System.Drawing.Image)
            Me.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.tabPage2.Location = New System.Drawing.Point(4, 22)
            Me.tabPage2.Name = "tabPage2"
            Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage2.Size = New System.Drawing.Size(794, 384)
            Me.tabPage2.TabIndex = 1
            Me.tabPage2.Text = "tabPage2"
            Me.tabPage2.UseVisualStyleBackColor = True
            '
            'Button3
            '
            Me.Button3.Location = New System.Drawing.Point(735, 5)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(75, 23)
            Me.Button3.TabIndex = 1
            Me.Button3.Text = "Button3"
            Me.Button3.UseVisualStyleBackColor = True
            '
            'GradientTab2
            '
            Me.GradientTab2.Controls.Add(Me.TabPage3)
            Me.GradientTab2.Controls.Add(Me.TabPage4)
            Me.GradientTab2.Location = New System.Drawing.Point(310, 9)
            Me.GradientTab2.Name = "GradientTab2"
            Me.GradientTab2.PageEndColor = System.Drawing.Color.Empty
            Me.GradientTab2.PageStartColor = System.Drawing.Color.Empty
            Me.GradientTab2.SelectedIndex = 0
            Me.GradientTab2.Size = New System.Drawing.Size(97, 18)
            Me.GradientTab2.TabIndex = 2
            '
            'TabPage3
            '
            Me.TabPage3.Location = New System.Drawing.Point(4, 22)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage3.Size = New System.Drawing.Size(89, 0)
            Me.TabPage3.TabIndex = 0
            Me.TabPage3.Text = "TabPage3"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'TabPage4
            '
            Me.TabPage4.Location = New System.Drawing.Point(4, 22)
            Me.TabPage4.Name = "TabPage4"
            Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage4.Size = New System.Drawing.Size(89, 0)
            Me.TabPage4.TabIndex = 1
            Me.TabPage4.Text = "TabPage4"
            Me.TabPage4.UseVisualStyleBackColor = True
            '
            'Form2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.AliceBlue
            Me.ClientSize = New System.Drawing.Size(838, 434)
            Me.Controls.Add(Me.GradientTab2)
            Me.Controls.Add(Me.Button3)
            Me.Controls.Add(Me.gradientTab1)
            Me.Name = "Form2"
            Me.Text = "Form2"
            Me.gradientTab1.ResumeLayout(False)
            Me.tabPage1.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            Me.GradientTab2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents gradientTab1 As _2_Business_Layer.GradientTab
        Private WithEvents tabPage1 As System.Windows.Forms.TabPage
        Private WithEvents tabPage2 As System.Windows.Forms.TabPage
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents button2 As System.Windows.Forms.Button
        Private WithEvents button1 As System.Windows.Forms.Button
        Friend WithEvents Button3 As Windows.Forms.Button
        Friend WithEvents GradientTab2 As _2_Business_Layer.GradientTab
        Friend WithEvents TabPage3 As Windows.Forms.TabPage
        Friend WithEvents TabPage4 As Windows.Forms.TabPage
    End Class
End Namespace

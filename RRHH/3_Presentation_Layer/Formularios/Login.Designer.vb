﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TxtBx_Password = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TxtBx_UserID = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.Bttn_Login = New MetroFramework.Controls.MetroButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBx_ConfPass = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.TmrBackAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtBx_Password
        '
        Me.TxtBx_Password.AcceptsReturn = False
        Me.TxtBx_Password.AcceptsTab = False
        Me.TxtBx_Password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtBx_Password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtBx_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTransition1.SetDecoration(Me.TxtBx_Password, BunifuAnimatorNS.DecorationType.None)
        Me.TxtBx_Password.Depth = 0
        Me.TxtBx_Password.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtBx_Password.Hint = " Contraseña"
        Me.TxtBx_Password.Location = New System.Drawing.Point(33, 232)
        Me.TxtBx_Password.MaxLength = 4
        Me.TxtBx_Password.MouseState = MaterialSkin.MouseState.HOVER
        Me.TxtBx_Password.Multiline = False
        Me.TxtBx_Password.Name = "TxtBx_Password"
        Me.TxtBx_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtBx_Password.ReadOnly = False
        Me.TxtBx_Password.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtBx_Password.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtBx_Password.SelectedText = ""
        Me.TxtBx_Password.SelectionLength = 0
        Me.TxtBx_Password.SelectionStart = 0
        Me.TxtBx_Password.Size = New System.Drawing.Size(233, 23)
        Me.TxtBx_Password.TabIndex = 2
        Me.TxtBx_Password.TabStop = False
        Me.TxtBx_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtBx_Password.UseSystemPasswordChar = False
        Me.TxtBx_Password.WordWrap = True
        '
        'TxtBx_UserID
        '
        Me.TxtBx_UserID.AcceptsReturn = False
        Me.TxtBx_UserID.AcceptsTab = False
        Me.TxtBx_UserID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtBx_UserID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtBx_UserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BunifuTransition1.SetDecoration(Me.TxtBx_UserID, BunifuAnimatorNS.DecorationType.None)
        Me.TxtBx_UserID.Depth = 0
        Me.TxtBx_UserID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx_UserID.Hint = ""
        Me.TxtBx_UserID.Location = New System.Drawing.Point(33, 180)
        Me.TxtBx_UserID.MaxLength = 11
        Me.TxtBx_UserID.MouseState = MaterialSkin.MouseState.HOVER
        Me.TxtBx_UserID.Multiline = False
        Me.TxtBx_UserID.Name = "TxtBx_UserID"
        Me.TxtBx_UserID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBx_UserID.ReadOnly = False
        Me.TxtBx_UserID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtBx_UserID.SelectedText = ""
        Me.TxtBx_UserID.SelectionLength = 0
        Me.TxtBx_UserID.SelectionStart = 0
        Me.TxtBx_UserID.Size = New System.Drawing.Size(233, 23)
        Me.TxtBx_UserID.TabIndex = 1
        Me.TxtBx_UserID.TabStop = False
        Me.TxtBx_UserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtBx_UserID.UseSystemPasswordChar = False
        Me.TxtBx_UserID.WordWrap = True
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.UsernameLabel, BunifuAnimatorNS.DecorationType.None)
        Me.UsernameLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.UsernameLabel.Location = New System.Drawing.Point(35, 176)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(66, 23)
        Me.UsernameLabel.TabIndex = 4
        Me.UsernameLabel.Text = "R.U.T"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Bttn_Login
        '
        Me.BunifuTransition1.SetDecoration(Me.Bttn_Login, BunifuAnimatorNS.DecorationType.None)
        Me.Bttn_Login.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.Bttn_Login.Location = New System.Drawing.Point(154, 323)
        Me.Bttn_Login.Name = "Bttn_Login"
        Me.Bttn_Login.Size = New System.Drawing.Size(112, 35)
        Me.Bttn_Login.TabIndex = 8
        Me.Bttn_Login.Text = "Entrar"
        Me.Bttn_Login.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.RRHH.My.Resources.Resources.Logo1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.BunifuTransition1.SetDecoration(Me.TableLayoutPanel2, BunifuAnimatorNS.DecorationType.None)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(300, 154)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(183, 207)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuTransition1.SetDecoration(Me.Label12, BunifuAnimatorNS.DecorationType.None)
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(122, 153)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 54)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "K"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuTransition1.SetDecoration(Me.Label11, BunifuAnimatorNS.DecorationType.None)
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(61, 153)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 54)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "0"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuTransition1.SetDecoration(Me.Label10, BunifuAnimatorNS.DecorationType.None)
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(0, 153)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 54)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "C"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuTransition1.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(122, 102)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 51)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuTransition1.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(61, 102)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 51)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "8"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuTransition1.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(0, 102)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 51)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuTransition1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(122, 51)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 51)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuTransition1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(61, 51)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 51)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(0, 51)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 51)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(122, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 51)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(61, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 51)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 51)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtBx_ConfPass
        '
        Me.TxtBx_ConfPass.AcceptsReturn = False
        Me.TxtBx_ConfPass.AcceptsTab = False
        Me.TxtBx_ConfPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TxtBx_ConfPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TxtBx_ConfPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTransition1.SetDecoration(Me.TxtBx_ConfPass, BunifuAnimatorNS.DecorationType.None)
        Me.TxtBx_ConfPass.Depth = 0
        Me.TxtBx_ConfPass.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtBx_ConfPass.Hint = " Repita contraseña"
        Me.TxtBx_ConfPass.Location = New System.Drawing.Point(33, 285)
        Me.TxtBx_ConfPass.MaxLength = 4
        Me.TxtBx_ConfPass.MouseState = MaterialSkin.MouseState.HOVER
        Me.TxtBx_ConfPass.Multiline = False
        Me.TxtBx_ConfPass.Name = "TxtBx_ConfPass"
        Me.TxtBx_ConfPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtBx_ConfPass.ReadOnly = False
        Me.TxtBx_ConfPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtBx_ConfPass.SelectedText = ""
        Me.TxtBx_ConfPass.SelectionLength = 0
        Me.TxtBx_ConfPass.SelectionStart = 0
        Me.TxtBx_ConfPass.Size = New System.Drawing.Size(233, 23)
        Me.TxtBx_ConfPass.TabIndex = 3
        Me.TxtBx_ConfPass.TabStop = False
        Me.TxtBx_ConfPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtBx_ConfPass.UseSystemPasswordChar = False
        Me.TxtBx_ConfPass.WordWrap = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label13, BunifuAnimatorNS.DecorationType.None)
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(190, 110)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(167, 30)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Login del Sistema"
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Nothing
        '
        'PictureBox2
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = Global.RRHH.My.Resources.Resources.plus
        Me.PictureBox2.Location = New System.Drawing.Point(157, 109)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation3
        Me.BunifuTransition1.Interval = 40
        Me.BunifuTransition1.MaxAnimationTime = 4000
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.RRHH.My.Resources.Resources.user__2_
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BunifuTransition1.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox3.Location = New System.Drawing.Point(242, 175)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.RRHH.My.Resources.Resources.lock__2_
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BunifuTransition1.SetDecoration(Me.PictureBox4, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox4.Location = New System.Drawing.Point(242, 227)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.TabIndex = 17
        Me.PictureBox4.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TxtBx_Password)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Bttn_Login)
        Me.Panel1.Controls.Add(Me.UsernameLabel)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.TxtBx_ConfPass)
        Me.Panel1.Controls.Add(Me.TxtBx_UserID)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(15, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 384)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(170, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(201, 201)
        Me.Panel2.TabIndex = 19
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.panel3, BunifuAnimatorNS.DecorationType.None)
        Me.panel3.Location = New System.Drawing.Point(12, 107)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(516, 390)
        Me.panel3.TabIndex = 23
        '
        'TmrBackAnimation
        '
        Me.TmrBackAnimation.Enabled = True
        Me.TmrBackAnimation.Interval = 5000
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 35
        Me.BunifuElipse1.TargetControl = Me.Panel2
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 30
        Me.BunifuElipse2.TargetControl = Me.Panel1
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 30
        Me.BunifuElipse3.TargetControl = Me.panel3
        '
        'Login
        '
        Me.AcceptButton = Me.Bttn_Login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 502)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panel3)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtBx_Password As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TxtBx_UserID As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TxtBx_ConfPass As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Bttn_Login As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents TmrBackAnimation As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents panel3 As Panel
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
End Class

namespace CapaPresentacion
{
    partial class FrmCalibracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataItemCalibracion = new MetroFramework.Controls.MetroGrid();
            this.Aplica = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Analisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Med_Espe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Med_Obte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dif_Med_Esp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dif_Med_Obte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluacion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtItemSelec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpProxCalib = new MetroFramework.Controls.MetroDateTime();
            this.txtEstado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCertificado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpFecCalib = new MetroFramework.Controls.MetroDateTime();
            this.txtCalibra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescInstru = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodInstru = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNomEmp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodEmp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataItemCalibracion)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataItemCalibracion);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(17, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calibracion por Items";
            // 
            // dataItemCalibracion
            // 
            this.dataItemCalibracion.AllowUserToAddRows = false;
            this.dataItemCalibracion.AllowUserToDeleteRows = false;
            this.dataItemCalibracion.AllowUserToOrderColumns = true;
            this.dataItemCalibracion.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.dataItemCalibracion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dataItemCalibracion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataItemCalibracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataItemCalibracion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataItemCalibracion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataItemCalibracion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataItemCalibracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataItemCalibracion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aplica,
            this.Item,
            this.Tipo_Analisis,
            this.Med_Espe,
            this.Med_Obte,
            this.Dif_Med_Esp,
            this.Dif_Med_Obte,
            this.Evaluacion});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataItemCalibracion.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataItemCalibracion.EnableHeadersVisualStyles = false;
            this.dataItemCalibracion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataItemCalibracion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataItemCalibracion.Location = new System.Drawing.Point(19, 24);
            this.dataItemCalibracion.MultiSelect = false;
            this.dataItemCalibracion.Name = "dataItemCalibracion";
            this.dataItemCalibracion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataItemCalibracion.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataItemCalibracion.RowHeadersVisible = false;
            this.dataItemCalibracion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataItemCalibracion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataItemCalibracion.Size = new System.Drawing.Size(971, 240);
            this.dataItemCalibracion.TabIndex = 1;
            this.dataItemCalibracion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataItemCalibracion_CellClick);
            this.dataItemCalibracion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataItemCalibracion_CellContentClick);
            this.dataItemCalibracion.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataItemCalibracion_CellLeave);
            this.dataItemCalibracion.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataItemCalibracion_CurrentCellDirtyStateChanged);
            this.dataItemCalibracion.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataItemCalibracion_EditingControlShowing);
            this.dataItemCalibracion.SelectionChanged += new System.EventHandler(this.dataItemCalibracion_SelectionChanged);
            // 
            // Aplica
            // 
            this.Aplica.HeaderText = "Aplica";
            this.Aplica.Name = "Aplica";
            this.Aplica.Width = 45;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Codigo";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Item.DefaultCellStyle = dataGridViewCellStyle21;
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 45;
            // 
            // Tipo_Analisis
            // 
            this.Tipo_Analisis.DataPropertyName = "Metodo";
            this.Tipo_Analisis.HeaderText = "Tipo Analisis";
            this.Tipo_Analisis.Name = "Tipo_Analisis";
            this.Tipo_Analisis.ReadOnly = true;
            this.Tipo_Analisis.Width = 350;
            // 
            // Med_Espe
            // 
            this.Med_Espe.DataPropertyName = "Rango";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N2";
            dataGridViewCellStyle22.NullValue = null;
            this.Med_Espe.DefaultCellStyle = dataGridViewCellStyle22;
            this.Med_Espe.HeaderText = "Medicion Esperada";
            this.Med_Espe.Name = "Med_Espe";
            this.Med_Espe.ReadOnly = true;
            // 
            // Med_Obte
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.NullValue = "0,00";
            this.Med_Obte.DefaultCellStyle = dataGridViewCellStyle23;
            this.Med_Obte.HeaderText = "Medicion Obtenida";
            this.Med_Obte.Name = "Med_Obte";
            // 
            // Dif_Med_Esp
            // 
            this.Dif_Med_Esp.DataPropertyName = "Criterio";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Format = "N2";
            dataGridViewCellStyle24.NullValue = null;
            this.Dif_Med_Esp.DefaultCellStyle = dataGridViewCellStyle24;
            this.Dif_Med_Esp.HeaderText = "Diferencia Med Esperada";
            this.Dif_Med_Esp.Name = "Dif_Med_Esp";
            this.Dif_Med_Esp.ReadOnly = true;
            this.Dif_Med_Esp.Width = 120;
            // 
            // Dif_Med_Obte
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.Format = "N2";
            dataGridViewCellStyle25.NullValue = "0,00";
            this.Dif_Med_Obte.DefaultCellStyle = dataGridViewCellStyle25;
            this.Dif_Med_Obte.HeaderText = "Diferencia Med Obtenida";
            this.Dif_Med_Obte.Name = "Dif_Med_Obte";
            this.Dif_Med_Obte.ReadOnly = true;
            this.Dif_Med_Obte.Width = 120;
            // 
            // Evaluacion
            // 
            this.Evaluacion.DisplayStyleForCurrentCellOnly = true;
            this.Evaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Evaluacion.HeaderText = "Evaluacion";
            this.Evaluacion.Items.AddRange(new object[] {
            "Aprobado",
            "Rechazado"});
            this.Evaluacion.Name = "Evaluacion";
            this.Evaluacion.Width = 87;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(130, 538);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 42);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(15, 538);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 42);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtItemSelec);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpProxCalib);
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMarca);
            this.groupBox2.Controls.Add(this.txtCertificado);
            this.groupBox2.Controls.Add(this.dtpFecCalib);
            this.groupBox2.Controls.Add(this.txtCalibra);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.txtDescInstru);
            this.groupBox2.Controls.Add(this.txtCodInstru);
            this.groupBox2.Controls.Add(this.txtNomEmp);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCodEmp);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(20, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1004, 177);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Calibracion Instrumento";
            // 
            // txtItemSelec
            // 
            this.txtItemSelec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemSelec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(158)))));
            this.txtItemSelec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemSelec.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtItemSelec.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSelec.ForeColor = System.Drawing.Color.White;
            this.txtItemSelec.Location = new System.Drawing.Point(5, 21);
            this.txtItemSelec.Margin = new System.Windows.Forms.Padding(0);
            this.txtItemSelec.Name = "txtItemSelec";
            this.txtItemSelec.ReadOnly = true;
            this.txtItemSelec.Size = new System.Drawing.Size(994, 26);
            this.txtItemSelec.TabIndex = 44;
            this.txtItemSelec.TabStop = false;
            this.txtItemSelec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(785, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fecha Proxima";
            // 
            // dtpProxCalib
            // 
            this.dtpProxCalib.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProxCalib.Location = new System.Drawing.Point(876, 112);
            this.dtpProxCalib.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpProxCalib.Name = "dtpProxCalib";
            this.dtpProxCalib.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpProxCalib.Size = new System.Drawing.Size(111, 29);
            this.dtpProxCalib.TabIndex = 42;
            this.dtpProxCalib.Value = new System.DateTime(2016, 3, 9, 0, 0, 0, 0);
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtEstado.Location = new System.Drawing.Point(876, 54);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(111, 25);
            this.txtEstado.TabIndex = 41;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Marca Instrumento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "N° Serie Instrumento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Usuario Responsable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(768, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Fecha Calibracion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(828, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Calibracion N°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Codigo Identificador";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtMarca.Location = new System.Drawing.Point(138, 135);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(257, 25);
            this.txtMarca.TabIndex = 33;
            // 
            // txtCertificado
            // 
            this.txtCertificado.Enabled = false;
            this.txtCertificado.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtCertificado.Location = new System.Drawing.Point(138, 108);
            this.txtCertificado.Name = "txtCertificado";
            this.txtCertificado.Size = new System.Drawing.Size(257, 25);
            this.txtCertificado.TabIndex = 32;
            // 
            // dtpFecCalib
            // 
            this.dtpFecCalib.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecCalib.Location = new System.Drawing.Point(876, 81);
            this.dtpFecCalib.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFecCalib.Name = "dtpFecCalib";
            this.dtpFecCalib.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpFecCalib.Size = new System.Drawing.Size(111, 29);
            this.dtpFecCalib.TabIndex = 31;
            this.dtpFecCalib.Value = new System.DateTime(2016, 3, 9, 0, 0, 0, 0);
            // 
            // txtCalibra
            // 
            this.txtCalibra.Enabled = false;
            this.txtCalibra.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtCalibra.Location = new System.Drawing.Point(292, 54);
            this.txtCalibra.Name = "txtCalibra";
            this.txtCalibra.Size = new System.Drawing.Size(50, 25);
            this.txtCalibra.TabIndex = 30;
            this.txtCalibra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtId.Location = new System.Drawing.Point(138, 54);
            this.txtId.Name = "txtId";
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.Size = new System.Drawing.Size(62, 25);
            this.txtId.TabIndex = 29;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescInstru
            // 
            this.txtDescInstru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescInstru.Enabled = false;
            this.txtDescInstru.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtDescInstru.Location = new System.Drawing.Point(292, 22);
            this.txtDescInstru.Name = "txtDescInstru";
            this.txtDescInstru.Size = new System.Drawing.Size(341, 25);
            this.txtDescInstru.TabIndex = 28;
            // 
            // txtCodInstru
            // 
            this.txtCodInstru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodInstru.Enabled = false;
            this.txtCodInstru.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtCodInstru.Location = new System.Drawing.Point(138, 22);
            this.txtCodInstru.Name = "txtCodInstru";
            this.txtCodInstru.Size = new System.Drawing.Size(148, 25);
            this.txtCodInstru.TabIndex = 27;
            // 
            // txtNomEmp
            // 
            this.txtNomEmp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNomEmp.Enabled = false;
            this.txtNomEmp.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtNomEmp.Location = new System.Drawing.Point(292, 81);
            this.txtNomEmp.Name = "txtNomEmp";
            this.txtNomEmp.ReadOnly = true;
            this.txtNomEmp.Size = new System.Drawing.Size(341, 25);
            this.txtNomEmp.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.label1.Location = new System.Drawing.Point(54, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Instrumento ";
            // 
            // txtCodEmp
            // 
            this.txtCodEmp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodEmp.Enabled = false;
            this.txtCodEmp.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtCodEmp.Location = new System.Drawing.Point(138, 81);
            this.txtCodEmp.Name = "txtCodEmp";
            this.txtCodEmp.ReadOnly = true;
            this.txtCodEmp.Size = new System.Drawing.Size(148, 25);
            this.txtCodEmp.TabIndex = 24;
            // 
            // FrmCalibracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 591);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalibracion";
            this.Text = "Registro de Calibracion y Mantencion por Instrumento";
            this.Load += new System.EventHandler(this.FrmCalibracion_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmCalibracion_Paint);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataItemCalibracion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private MetroFramework.Controls.MetroGrid dataItemCalibracion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroDateTime dtpProxCalib;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMarca;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCertificado;
        private MetroFramework.Controls.MetroDateTime dtpFecCalib;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCalibra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtId;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescInstru;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodInstru;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomEmp;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodEmp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aplica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Analisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Med_Espe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Med_Obte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dif_Med_Esp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dif_Med_Obte;
        private System.Windows.Forms.DataGridViewComboBoxColumn Evaluacion;
        private System.Windows.Forms.TextBox txtItemSelec;
    }
}
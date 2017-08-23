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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataItemCalibracion = new MetroFramework.Controls.MetroGrid();
            this.Aplica = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Analisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Med_Espe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Med_Obte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dif_Med_Esp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dif_Med_Obte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluacion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtObserva = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DtpFecVenc = new MetroFramework.Controls.MetroDateTime();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textOtros = new System.Windows.Forms.TextBox();
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataItemCalibracion)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dataItemCalibracion);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtObserva);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(17, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verificacion por Items";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(121, 327);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 1);
            this.panel1.TabIndex = 48;
            // 
            // dataItemCalibracion
            // 
            this.dataItemCalibracion.AllowUserToAddRows = false;
            this.dataItemCalibracion.AllowUserToDeleteRows = false;
            this.dataItemCalibracion.AllowUserToOrderColumns = true;
            this.dataItemCalibracion.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.dataItemCalibracion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataItemCalibracion.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataItemCalibracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataItemCalibracion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataItemCalibracion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataItemCalibracion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataItemCalibracion.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataItemCalibracion.EnableHeadersVisualStyles = false;
            this.dataItemCalibracion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataItemCalibracion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataItemCalibracion.Location = new System.Drawing.Point(19, 24);
            this.dataItemCalibracion.MultiSelect = false;
            this.dataItemCalibracion.Name = "dataItemCalibracion";
            this.dataItemCalibracion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataItemCalibracion.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataItemCalibracion.RowHeadersVisible = false;
            this.dataItemCalibracion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataItemCalibracion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataItemCalibracion.Size = new System.Drawing.Size(971, 206);
            this.dataItemCalibracion.TabIndex = 1;
            this.dataItemCalibracion.UseCustomBackColor = true;
            this.dataItemCalibracion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataItemCalibracion_CellClick);
            this.dataItemCalibracion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataItemCalibracion_CellContentClick);
            this.dataItemCalibracion.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataItemCalibracion_CellLeave);
            this.dataItemCalibracion.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataItemCalibracion_CurrentCellDirtyStateChanged);
            this.dataItemCalibracion.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataItemCalibracion_EditingControlShowing);
            this.dataItemCalibracion.SelectionChanged += new System.EventHandler(this.dataItemCalibracion_SelectionChanged);
            // 
            // Aplica
            // 
            this.Aplica.FalseValue = "false";
            this.Aplica.HeaderText = "Aplica";
            this.Aplica.Name = "Aplica";
            this.Aplica.TrueValue = "true";
            this.Aplica.Width = 45;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Codigo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Item.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Med_Espe.DefaultCellStyle = dataGridViewCellStyle4;
            this.Med_Espe.HeaderText = "Medicion Esperada";
            this.Med_Espe.Name = "Med_Espe";
            this.Med_Espe.ReadOnly = true;
            // 
            // Med_Obte
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.NullValue = "0,00";
            this.Med_Obte.DefaultCellStyle = dataGridViewCellStyle5;
            this.Med_Obte.HeaderText = "Medicion Obtenida";
            this.Med_Obte.Name = "Med_Obte";
            // 
            // Dif_Med_Esp
            // 
            this.Dif_Med_Esp.DataPropertyName = "Criterio";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Dif_Med_Esp.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dif_Med_Esp.HeaderText = "Diferencia Med Esperada";
            this.Dif_Med_Esp.Name = "Dif_Med_Esp";
            this.Dif_Med_Esp.ReadOnly = true;
            this.Dif_Med_Esp.Width = 120;
            // 
            // Dif_Med_Obte
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0,00";
            this.Dif_Med_Obte.DefaultCellStyle = dataGridViewCellStyle7;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "Observaciones";
            // 
            // TxtObserva
            // 
            this.TxtObserva.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtObserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtObserva.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.TxtObserva.Location = new System.Drawing.Point(121, 242);
            this.TxtObserva.Multiline = true;
            this.TxtObserva.Name = "TxtObserva";
            this.TxtObserva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtObserva.Size = new System.Drawing.Size(869, 83);
            this.TxtObserva.TabIndex = 50;
            this.TxtObserva.Enter += new System.EventHandler(this.TxtObserva_Enter);
            this.TxtObserva.Leave += new System.EventHandler(this.TxtObserva_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(130, 603);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 42);
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
            this.btnAgregar.Location = new System.Drawing.Point(15, 603);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 42);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.DtpFecVenc);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textOtros);
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
            this.groupBox2.Size = new System.Drawing.Size(1004, 185);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Verificacion Instrumento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(759, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 17);
            this.label11.TabIndex = 49;
            this.label11.Text = "Fecha Vencimiento";
            // 
            // DtpFecVenc
            // 
            this.DtpFecVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecVenc.Location = new System.Drawing.Point(876, 142);
            this.DtpFecVenc.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpFecVenc.Name = "DtpFecVenc";
            this.DtpFecVenc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DtpFecVenc.Size = new System.Drawing.Size(111, 29);
            this.DtpFecVenc.TabIndex = 48;
            this.DtpFecVenc.Value = new System.DateTime(2016, 3, 9, 0, 0, 0, 0);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(486, 167);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 1);
            this.panel2.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(409, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 46;
            this.label12.Text = "Otros Datos";
            // 
            // textOtros
            // 
            this.textOtros.BackColor = System.Drawing.Color.White;
            this.textOtros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOtros.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.textOtros.Location = new System.Drawing.Point(486, 113);
            this.textOtros.Multiline = true;
            this.textOtros.Name = "textOtros";
            this.textOtros.ReadOnly = true;
            this.textOtros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOtros.Size = new System.Drawing.Size(263, 53);
            this.textOtros.TabIndex = 47;
            this.textOtros.Enter += new System.EventHandler(this.textOtros_Enter);
            this.textOtros.Leave += new System.EventHandler(this.textOtros_Leave);
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
            this.label4.Location = new System.Drawing.Point(785, 118);
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
            this.txtEstado.Depth = 0;
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtEstado.Hint = "";
            this.txtEstado.Location = new System.Drawing.Point(876, 55);
            this.txtEstado.MaxLength = 32767;
            this.txtEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PasswordChar = '\0';
            this.txtEstado.ReadOnly = true;
            this.txtEstado.SelectedText = "";
            this.txtEstado.SelectionLength = 0;
            this.txtEstado.SelectionStart = 0;
            this.txtEstado.Size = new System.Drawing.Size(111, 23);
            this.txtEstado.TabIndex = 41;
            this.txtEstado.TabStop = false;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEstado.UseSystemPasswordChar = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Marca Instrumento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "N° Serie Instrumento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Usuario Responsable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(765, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Fecha Verificacion";
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
            this.label3.Location = new System.Drawing.Point(211, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Verificacion N°";
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
            this.txtMarca.Depth = 0;
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtMarca.Hint = "";
            this.txtMarca.Location = new System.Drawing.Point(138, 145);
            this.txtMarca.MaxLength = 32767;
            this.txtMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.ReadOnly = true;
            this.txtMarca.SelectedText = "";
            this.txtMarca.SelectionLength = 0;
            this.txtMarca.SelectionStart = 0;
            this.txtMarca.Size = new System.Drawing.Size(257, 23);
            this.txtMarca.TabIndex = 33;
            this.txtMarca.TabStop = false;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMarca.UseSystemPasswordChar = false;
            // 
            // txtCertificado
            // 
            this.txtCertificado.Depth = 0;
            this.txtCertificado.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtCertificado.Hint = "";
            this.txtCertificado.Location = new System.Drawing.Point(138, 115);
            this.txtCertificado.MaxLength = 32767;
            this.txtCertificado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCertificado.Name = "txtCertificado";
            this.txtCertificado.PasswordChar = '\0';
            this.txtCertificado.ReadOnly = true;
            this.txtCertificado.SelectedText = "";
            this.txtCertificado.SelectionLength = 0;
            this.txtCertificado.SelectionStart = 0;
            this.txtCertificado.Size = new System.Drawing.Size(257, 23);
            this.txtCertificado.TabIndex = 32;
            this.txtCertificado.TabStop = false;
            this.txtCertificado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCertificado.UseSystemPasswordChar = false;
            // 
            // dtpFecCalib
            // 
            this.dtpFecCalib.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecCalib.Location = new System.Drawing.Point(876, 82);
            this.dtpFecCalib.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFecCalib.Name = "dtpFecCalib";
            this.dtpFecCalib.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpFecCalib.Size = new System.Drawing.Size(111, 29);
            this.dtpFecCalib.TabIndex = 31;
            this.dtpFecCalib.Value = new System.DateTime(2016, 3, 9, 0, 0, 0, 0);
            // 
            // txtCalibra
            // 
            this.txtCalibra.Depth = 0;
            this.txtCalibra.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtCalibra.Hint = "";
            this.txtCalibra.Location = new System.Drawing.Point(299, 55);
            this.txtCalibra.MaxLength = 32767;
            this.txtCalibra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCalibra.Name = "txtCalibra";
            this.txtCalibra.PasswordChar = '\0';
            this.txtCalibra.ReadOnly = true;
            this.txtCalibra.SelectedText = "";
            this.txtCalibra.SelectionLength = 0;
            this.txtCalibra.SelectionStart = 0;
            this.txtCalibra.Size = new System.Drawing.Size(50, 23);
            this.txtCalibra.TabIndex = 30;
            this.txtCalibra.TabStop = false;
            this.txtCalibra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCalibra.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            this.txtId.Depth = 0;
            this.txtId.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtId.Hint = "";
            this.txtId.Location = new System.Drawing.Point(138, 55);
            this.txtId.MaxLength = 32767;
            this.txtId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ReadOnly = true;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.Size = new System.Drawing.Size(62, 23);
            this.txtId.TabIndex = 29;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // txtDescInstru
            // 
            this.txtDescInstru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescInstru.Depth = 0;
            this.txtDescInstru.Enabled = false;
            this.txtDescInstru.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtDescInstru.Hint = "";
            this.txtDescInstru.Location = new System.Drawing.Point(292, 23);
            this.txtDescInstru.MaxLength = 32767;
            this.txtDescInstru.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescInstru.Name = "txtDescInstru";
            this.txtDescInstru.PasswordChar = '\0';
            this.txtDescInstru.ReadOnly = false;
            this.txtDescInstru.SelectedText = "";
            this.txtDescInstru.SelectionLength = 0;
            this.txtDescInstru.SelectionStart = 0;
            this.txtDescInstru.Size = new System.Drawing.Size(341, 23);
            this.txtDescInstru.TabIndex = 28;
            this.txtDescInstru.TabStop = false;
            this.txtDescInstru.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescInstru.UseSystemPasswordChar = false;
            // 
            // txtCodInstru
            // 
            this.txtCodInstru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodInstru.Depth = 0;
            this.txtCodInstru.Enabled = false;
            this.txtCodInstru.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtCodInstru.Hint = "";
            this.txtCodInstru.Location = new System.Drawing.Point(138, 23);
            this.txtCodInstru.MaxLength = 32767;
            this.txtCodInstru.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodInstru.Name = "txtCodInstru";
            this.txtCodInstru.PasswordChar = '\0';
            this.txtCodInstru.ReadOnly = false;
            this.txtCodInstru.SelectedText = "";
            this.txtCodInstru.SelectionLength = 0;
            this.txtCodInstru.SelectionStart = 0;
            this.txtCodInstru.Size = new System.Drawing.Size(148, 23);
            this.txtCodInstru.TabIndex = 27;
            this.txtCodInstru.TabStop = false;
            this.txtCodInstru.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodInstru.UseSystemPasswordChar = false;
            // 
            // txtNomEmp
            // 
            this.txtNomEmp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNomEmp.Depth = 0;
            this.txtNomEmp.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtNomEmp.Hint = "";
            this.txtNomEmp.Location = new System.Drawing.Point(292, 85);
            this.txtNomEmp.MaxLength = 32767;
            this.txtNomEmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomEmp.Name = "txtNomEmp";
            this.txtNomEmp.PasswordChar = '\0';
            this.txtNomEmp.ReadOnly = true;
            this.txtNomEmp.SelectedText = "";
            this.txtNomEmp.SelectionLength = 0;
            this.txtNomEmp.SelectionStart = 0;
            this.txtNomEmp.Size = new System.Drawing.Size(341, 23);
            this.txtNomEmp.TabIndex = 26;
            this.txtNomEmp.TabStop = false;
            this.txtNomEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNomEmp.UseSystemPasswordChar = false;
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
            this.txtCodEmp.Depth = 0;
            this.txtCodEmp.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.txtCodEmp.Hint = "";
            this.txtCodEmp.Location = new System.Drawing.Point(138, 85);
            this.txtCodEmp.MaxLength = 32767;
            this.txtCodEmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodEmp.Name = "txtCodEmp";
            this.txtCodEmp.PasswordChar = '\0';
            this.txtCodEmp.ReadOnly = true;
            this.txtCodEmp.SelectedText = "";
            this.txtCodEmp.SelectionLength = 0;
            this.txtCodEmp.SelectionStart = 0;
            this.txtCodEmp.Size = new System.Drawing.Size(148, 23);
            this.txtCodEmp.TabIndex = 24;
            this.txtCodEmp.TabStop = false;
            this.txtCodEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodEmp.UseSystemPasswordChar = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::CapaPresentacion.Properties.Resources.document_lines;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(915, 603);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 42);
            this.button2.TabIndex = 15;
            this.button2.Text = "Imprimir Etiquetas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::CapaPresentacion.Properties.Resources.barcode_tag__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(800, 604);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "Agregar a\r\nEtiquetas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // FrmCalibracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalibracion";
            this.Text = "Registro de Verificacion y Mantencion por Instrumento";
            this.Load += new System.EventHandler(this.FrmCalibracion_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmCalibracion_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtItemSelec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textOtros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtObserva;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aplica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Analisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Med_Espe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Med_Obte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dif_Med_Esp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dif_Med_Obte;
        private System.Windows.Forms.DataGridViewComboBoxColumn Evaluacion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroDateTime DtpFecVenc;
    }
}
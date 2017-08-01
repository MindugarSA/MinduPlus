namespace CapaPresentacion
{
    partial class FrmItemsComprobacion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCriterio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtResolucion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRango = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUnidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMetodo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtItem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataItems = new MetroFramework.Controls.MetroGrid();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.MenuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.MenuContextual.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCriterio);
            this.groupBox1.Controls.Add(this.txtResolucion);
            this.groupBox1.Controls.Add(this.txtRango);
            this.groupBox1.Controls.Add(this.txtUnidad);
            this.groupBox1.Controls.Add(this.txtMetodo);
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Controls.Add(this.dataItems);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(16, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenedor Item de Comprobacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label4.Location = new System.Drawing.Point(541, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Criterio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label5.Location = new System.Drawing.Point(519, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Resolucion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label6.Location = new System.Drawing.Point(464, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rango a Medir Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label3.Location = new System.Drawing.Point(50, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Unidad de Medicion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label2.Location = new System.Drawing.Point(32, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Metodo Comprobacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label1.Location = new System.Drawing.Point(148, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item";
            // 
            // txtCriterio
            // 
            this.txtCriterio.Depth = 0;
            this.txtCriterio.Hint = "";
            this.txtCriterio.Location = new System.Drawing.Point(605, 374);
            this.txtCriterio.MaxLength = 32767;
            this.txtCriterio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.PasswordChar = '\0';
            this.txtCriterio.ReadOnly = false;
            this.txtCriterio.SelectedText = "";
            this.txtCriterio.SelectionLength = 0;
            this.txtCriterio.SelectionStart = 0;
            this.txtCriterio.Size = new System.Drawing.Size(100, 23);
            this.txtCriterio.TabIndex = 7;
            this.txtCriterio.TabStop = false;
            this.txtCriterio.Text = "0,00";
            this.txtCriterio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCriterio.UseSystemPasswordChar = false;
            this.txtCriterio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRango_KeyPress);
            this.txtCriterio.Validated += new System.EventHandler(this.txtRango_Validated);
            // 
            // txtResolucion
            // 
            this.txtResolucion.Depth = 0;
            this.txtResolucion.Hint = "";
            this.txtResolucion.Location = new System.Drawing.Point(605, 346);
            this.txtResolucion.MaxLength = 32767;
            this.txtResolucion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtResolucion.Name = "txtResolucion";
            this.txtResolucion.PasswordChar = '\0';
            this.txtResolucion.ReadOnly = false;
            this.txtResolucion.SelectedText = "";
            this.txtResolucion.SelectionLength = 0;
            this.txtResolucion.SelectionStart = 0;
            this.txtResolucion.Size = new System.Drawing.Size(100, 23);
            this.txtResolucion.TabIndex = 6;
            this.txtResolucion.TabStop = false;
            this.txtResolucion.Text = "0,00";
            this.txtResolucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResolucion.UseSystemPasswordChar = false;
            this.txtResolucion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRango_KeyPress);
            this.txtResolucion.Validated += new System.EventHandler(this.txtRango_Validated);
            // 
            // txtRango
            // 
            this.txtRango.Depth = 0;
            this.txtRango.Hint = "";
            this.txtRango.Location = new System.Drawing.Point(605, 318);
            this.txtRango.MaxLength = 32767;
            this.txtRango.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRango.Name = "txtRango";
            this.txtRango.PasswordChar = '\0';
            this.txtRango.ReadOnly = false;
            this.txtRango.SelectedText = "";
            this.txtRango.SelectionLength = 0;
            this.txtRango.SelectionStart = 0;
            this.txtRango.Size = new System.Drawing.Size(100, 23);
            this.txtRango.TabIndex = 5;
            this.txtRango.TabStop = false;
            this.txtRango.Text = "0.00";
            this.txtRango.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRango.UseSystemPasswordChar = false;
            this.txtRango.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRango_KeyPress);
            this.txtRango.Validated += new System.EventHandler(this.txtRango_Validated);
            // 
            // txtUnidad
            // 
            this.txtUnidad.Depth = 0;
            this.txtUnidad.Hint = "";
            this.txtUnidad.Location = new System.Drawing.Point(188, 374);
            this.txtUnidad.MaxLength = 32767;
            this.txtUnidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.PasswordChar = '\0';
            this.txtUnidad.ReadOnly = false;
            this.txtUnidad.SelectedText = "";
            this.txtUnidad.SelectionLength = 0;
            this.txtUnidad.SelectionStart = 0;
            this.txtUnidad.Size = new System.Drawing.Size(100, 23);
            this.txtUnidad.TabIndex = 4;
            this.txtUnidad.TabStop = false;
            this.txtUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUnidad.UseSystemPasswordChar = false;
            this.txtUnidad.TextChanged += new System.EventHandler(this.txtUnidad_TextChanged);
            // 
            // txtMetodo
            // 
            this.txtMetodo.Depth = 0;
            this.txtMetodo.Hint = "";
            this.txtMetodo.Location = new System.Drawing.Point(188, 346);
            this.txtMetodo.MaxLength = 32767;
            this.txtMetodo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMetodo.Name = "txtMetodo";
            this.txtMetodo.PasswordChar = '\0';
            this.txtMetodo.ReadOnly = false;
            this.txtMetodo.SelectedText = "";
            this.txtMetodo.SelectionLength = 0;
            this.txtMetodo.SelectionStart = 0;
            this.txtMetodo.Size = new System.Drawing.Size(277, 23);
            this.txtMetodo.TabIndex = 3;
            this.txtMetodo.TabStop = false;
            this.txtMetodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMetodo.UseSystemPasswordChar = false;
            this.txtMetodo.TextChanged += new System.EventHandler(this.txtMetodo_TextChanged);
            // 
            // txtItem
            // 
            this.txtItem.Depth = 0;
            this.txtItem.Enabled = false;
            this.txtItem.Hint = "";
            this.txtItem.Location = new System.Drawing.Point(188, 318);
            this.txtItem.MaxLength = 32767;
            this.txtItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItem.Name = "txtItem";
            this.txtItem.PasswordChar = '\0';
            this.txtItem.ReadOnly = false;
            this.txtItem.SelectedText = "";
            this.txtItem.SelectionLength = 0;
            this.txtItem.SelectionStart = 0;
            this.txtItem.Size = new System.Drawing.Size(100, 23);
            this.txtItem.TabIndex = 2;
            this.txtItem.TabStop = false;
            this.txtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItem.UseSystemPasswordChar = false;
            // 
            // dataItems
            // 
            this.dataItems.AllowUserToAddRows = false;
            this.dataItems.AllowUserToDeleteRows = false;
            this.dataItems.AllowUserToOrderColumns = true;
            this.dataItems.AllowUserToResizeColumns = false;
            this.dataItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.dataItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataItems.EnableHeadersVisualStyles = false;
            this.dataItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataItems.Location = new System.Drawing.Point(25, 36);
            this.dataItems.MultiSelect = false;
            this.dataItems.Name = "dataItems";
            this.dataItems.ReadOnly = true;
            this.dataItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataItems.RowHeadersVisible = false;
            this.dataItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataItems.Size = new System.Drawing.Size(775, 275);
            this.dataItems.TabIndex = 1;
            this.dataItems.SelectionChanged += new System.EventHandler(this.dataItems_SelectionChanged);
            this.dataItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataItems_MouseClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(162)))), ((int)(((byte)(26)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(228, 490);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 42);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnCancelar_Paint);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(162)))), ((int)(((byte)(26)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(16, 490);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 42);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(162)))), ((int)(((byte)(26)))));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Enabled = false;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(122, 490);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(96, 42);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnNuevo.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // MenuContextual
            // 
            this.MenuContextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarItemToolStripMenuItem});
            this.MenuContextual.Name = "MenuContextual";
            this.MenuContextual.Size = new System.Drawing.Size(145, 26);
            // 
            // eliminarItemToolStripMenuItem
            // 
            this.eliminarItemToolStripMenuItem.Name = "eliminarItemToolStripMenuItem";
            this.eliminarItemToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.eliminarItemToolStripMenuItem.Text = "Eliminar Item";
            this.eliminarItemToolStripMenuItem.Click += new System.EventHandler(this.eliminarItemToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Location = new System.Drawing.Point(23, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 28);
            this.panel1.TabIndex = 9;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(11, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(219, 17);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Mantenedor Item de Comprobacion";
            // 
            // FrmItemsComprobacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmItemsComprobacion";
            this.Text = "Items de Comprobacion";
            this.Load += new System.EventHandler(this.FrmItemsComprobacion_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmItemsComprobacion_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.MenuContextual.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCriterio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtResolucion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRango;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUnidad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMetodo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItem;
        private MetroFramework.Controls.MetroGrid dataItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ContextMenuStrip MenuContextual;
        private System.Windows.Forms.ToolStripMenuItem eliminarItemToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
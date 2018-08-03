namespace OtrasAppsMindumas
{
    partial class Frm_DiasFeriados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MonthCalendar3 = new Pabo.Calendar.MonthCalendar();
            this.MetroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComentario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.MetroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.duplicarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MetroGrid1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // MonthCalendar3
            // 
            this.MonthCalendar3.ActiveMonth.Month = 7;
            this.MonthCalendar3.ActiveMonth.Year = 2018;
            this.MonthCalendar3.BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.MonthCalendar3.Culture = new System.Globalization.CultureInfo("es-CL");
            this.MonthCalendar3.Footer.Align = Pabo.Calendar.mcTextAlign.Center;
            this.MonthCalendar3.Footer.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.MonthCalendar3.Footer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MonthCalendar3.Footer.TextColor = System.Drawing.Color.White;
            this.MonthCalendar3.Header.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(162)))), ((int)(((byte)(26)))));
            this.MonthCalendar3.Header.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MonthCalendar3.Header.TextColor = System.Drawing.Color.White;
            this.MonthCalendar3.ImageList = null;
            this.MonthCalendar3.Location = new System.Drawing.Point(557, 291);
            this.MonthCalendar3.MaxDate = new System.DateTime(2028, 7, 18, 13, 23, 7, 845);
            this.MonthCalendar3.MinDate = new System.DateTime(2008, 7, 18, 13, 23, 7, 845);
            this.MonthCalendar3.Month.BackgroundImage = null;
            this.MonthCalendar3.Month.DateFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthCalendar3.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MonthCalendar3.Name = "MonthCalendar3";
            this.MonthCalendar3.SelectionMode = Pabo.Calendar.mcSelectionMode.One;
            this.MonthCalendar3.Size = new System.Drawing.Size(574, 335);
            this.MonthCalendar3.TabIndex = 70;
            this.MonthCalendar3.TodayColor = System.Drawing.Color.Transparent;
            this.MonthCalendar3.Weekdays.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(162)))), ((int)(((byte)(26)))));
            this.MonthCalendar3.Weekdays.BorderColor = System.Drawing.Color.Transparent;
            this.MonthCalendar3.Weekdays.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.MonthCalendar3.Weekdays.TextColor = System.Drawing.Color.White;
            this.MonthCalendar3.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MonthCalendar3.MonthChanged += new Pabo.Calendar.MonthChangedEventHandler(this.MonthCalendar3_MonthChanged);
            this.MonthCalendar3.DayClick += new Pabo.Calendar.DayClickEventHandler(this.MonthCalendar3_DayClick);
            // 
            // MetroGrid1
            // 
            this.MetroGrid1.AllowUserToAddRows = false;
            this.MetroGrid1.AllowUserToDeleteRows = false;
            this.MetroGrid1.AllowUserToOrderColumns = true;
            this.MetroGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            this.MetroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.MetroGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MetroGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MetroGrid1.DefaultCellStyle = dataGridViewCellStyle7;
            this.MetroGrid1.EnableHeadersVisualStyles = false;
            this.MetroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MetroGrid1.Location = new System.Drawing.Point(28, 86);
            this.MetroGrid1.MultiSelect = false;
            this.MetroGrid1.Name = "MetroGrid1";
            this.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.MetroGrid1.RowHeadersVisible = false;
            this.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MetroGrid1.Size = new System.Drawing.Size(513, 640);
            this.MetroGrid1.TabIndex = 71;
            this.MetroGrid1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MetroGrid1_CellMouseClick);
            this.MetroGrid1.SelectionChanged += new System.EventHandler(this.MetroGrid1_SelectionChanged);
            // 
            // TxtFecha
            // 
            this.TxtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(51)))));
            this.TxtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.TxtFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtFecha.Location = new System.Drawing.Point(557, 86);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.ReadOnly = true;
            this.TxtFecha.Size = new System.Drawing.Size(574, 29);
            this.TxtFecha.TabIndex = 73;
            this.TxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.Label3.Location = new System.Drawing.Point(575, 145);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(82, 20);
            this.Label3.TabIndex = 75;
            this.Label3.Text = "Descripcion";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.AcceptsReturn = false;
            this.TxtDescripcion.AcceptsTab = false;
            this.TxtDescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtDescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtDescripcion.Depth = 0;
            this.TxtDescripcion.Hint = "";
            this.TxtDescripcion.Location = new System.Drawing.Point(668, 145);
            this.TxtDescripcion.MaxLength = 32767;
            this.TxtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDescripcion.Multiline = false;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.PasswordChar = '\0';
            this.TxtDescripcion.ReadOnly = false;
            this.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDescripcion.SelectedText = "";
            this.TxtDescripcion.SelectionLength = 0;
            this.TxtDescripcion.SelectionStart = 0;
            this.TxtDescripcion.Size = new System.Drawing.Size(434, 23);
            this.TxtDescripcion.TabIndex = 74;
            this.TxtDescripcion.TabStop = false;
            this.TxtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtDescripcion.UseSystemPasswordChar = false;
            this.TxtDescripcion.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label1.Location = new System.Drawing.Point(576, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.AcceptsReturn = false;
            this.txtComentario.AcceptsTab = false;
            this.txtComentario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtComentario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtComentario.Depth = 0;
            this.txtComentario.Hint = "";
            this.txtComentario.Location = new System.Drawing.Point(667, 185);
            this.txtComentario.MaxLength = 32767;
            this.txtComentario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComentario.Multiline = false;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.PasswordChar = '\0';
            this.txtComentario.ReadOnly = false;
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComentario.SelectedText = "";
            this.txtComentario.SelectionLength = 0;
            this.txtComentario.SelectionStart = 0;
            this.txtComentario.Size = new System.Drawing.Size(434, 23);
            this.txtComentario.TabIndex = 76;
            this.txtComentario.TabStop = false;
            this.txtComentario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtComentario.UseSystemPasswordChar = false;
            this.txtComentario.WordWrap = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label2.Location = new System.Drawing.Point(621, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "Tipo";
            // 
            // MetroComboBox2
            // 
            this.MetroComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MetroComboBox2.FormattingEnabled = true;
            this.MetroComboBox2.ItemHeight = 23;
            this.MetroComboBox2.Location = new System.Drawing.Point(667, 225);
            this.MetroComboBox2.Name = "MetroComboBox2";
            this.MetroComboBox2.Size = new System.Drawing.Size(196, 29);
            this.MetroComboBox2.TabIndex = 79;
            this.MetroComboBox2.UseSelectable = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duplicarRegistroToolStripMenuItem,
            this.eliminarRegistroToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 48);
            // 
            // duplicarRegistroToolStripMenuItem
            // 
            this.duplicarRegistroToolStripMenuItem.Image = global::OtrasAppsMindumas.Properties.Resources.plus_sign_in_a_black_circle;
            this.duplicarRegistroToolStripMenuItem.Name = "duplicarRegistroToolStripMenuItem";
            this.duplicarRegistroToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.duplicarRegistroToolStripMenuItem.Text = "Agregar Feriado";
            // 
            // eliminarRegistroToolStripMenuItem
            // 
            this.eliminarRegistroToolStripMenuItem.Image = global::OtrasAppsMindumas.Properties.Resources.blocked_sign;
            this.eliminarRegistroToolStripMenuItem.Name = "eliminarRegistroToolStripMenuItem";
            this.eliminarRegistroToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.eliminarRegistroToolStripMenuItem.Text = "Eliminar Feriado";
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Image = global::OtrasAppsMindumas.Properties.Resources.home_shape32;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVolver.Location = new System.Drawing.Point(557, 674);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(170, 52);
            this.btnVolver.TabIndex = 72;
            this.btnVolver.Text = "Volver\r\nA Inicio";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            this.btnVolver.MouseEnter += new System.EventHandler(this.PopUp_MouseEnter);
            this.btnVolver.MouseLeave += new System.EventHandler(this.PopUp_MouseLeave);
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.BackgroundImage = global::OtrasAppsMindumas.Properties.Resources.blocked_sign;
            this.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox16.Location = new System.Drawing.Point(1097, 248);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(34, 34);
            this.pictureBox16.TabIndex = 127;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Click += new System.EventHandler(this.pictureBox16_Click);
            this.pictureBox16.MouseEnter += new System.EventHandler(this.PopUp_MouseEnter);
            this.pictureBox16.MouseLeave += new System.EventHandler(this.PopUp_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::OtrasAppsMindumas.Properties.Resources.plus_symbol_round_button;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(1054, 248);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 34);
            this.pictureBox5.TabIndex = 126;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseEnter += new System.EventHandler(this.PopUp_MouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.PopUp_MouseLeave);
            // 
            // Frm_DiasFeriados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 749);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.MetroComboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.MetroGrid1);
            this.Controls.Add(this.MonthCalendar3);
            this.Name = "Frm_DiasFeriados";
            this.Text = "Gestion de Dias Feriados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_DiasFeriados_FormClosing);
            this.Load += new System.EventHandler(this.Frm_DiasFeriados_Load);
            this.LocationChanged += new System.EventHandler(this.Frm_DiasFeriados_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.MetroGrid1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Pabo.Calendar.MonthCalendar MonthCalendar3;
        internal MetroFramework.Controls.MetroGrid MetroGrid1;
        internal System.Windows.Forms.Button btnVolver;
        internal System.Windows.Forms.TextBox TxtFecha;
        internal System.Windows.Forms.Label Label3;
        internal MaterialSkin.Controls.MaterialSingleLineTextField TxtDescripcion;
        internal System.Windows.Forms.Label label1;
        internal MaterialSkin.Controls.MaterialSingleLineTextField txtComentario;
        internal System.Windows.Forms.Label label2;
        internal MetroFramework.Controls.MetroComboBox MetroComboBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem duplicarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRegistroToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}
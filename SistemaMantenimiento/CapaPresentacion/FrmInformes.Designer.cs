namespace CapaPresentacion
{
    partial class FrmInformes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SpInformeEtiquetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new CapaPresentacion.DataSet1();
            this.SpInformeEtiquetasTableAdapter = new CapaPresentacion.DataSet1TableAdapters.SpInformeEtiquetasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SpInformeEtiquetasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SpInformeEtiquetasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RptEtiquetas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1096, 620);
            this.reportViewer1.TabIndex = 0;
            // 
            // SpInformeEtiquetasBindingSource
            // 
            this.SpInformeEtiquetasBindingSource.DataMember = "SpInformeEtiquetas";
            this.SpInformeEtiquetasBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SpInformeEtiquetasTableAdapter
            // 
            this.SpInformeEtiquetasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 700);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmInformes";
            this.Text = "FrmInformes";
            this.Load += new System.EventHandler(this.FrmInformes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpInformeEtiquetasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SpInformeEtiquetasBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.SpInformeEtiquetasTableAdapter SpInformeEtiquetasTableAdapter;
    }
}
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmInformes : MetroFramework.Forms.MetroForm
    {
        public string TipoReporte { get; set; }
        public int Id_instrumento { get; set; }
        public int Id_identidad { get; set; }
        public FrmInformes()
        {
            InitializeComponent();
        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.SpInformeEtiquetas' Puede moverla o quitarla según sea necesario.
            this.SpInformeEtiquetasTableAdapter.Fill(this.DataSet1.SpInformeEtiquetas);
            this.SpInformeActaBajaTableAdapter.Fill(this.DataSet1.SpInformeActaBaja,Id_instrumento,Id_identidad);
            this.SpInformeEntregaInstrumentoTableAdapter.Fill(this.DataSet1.SpInformeEntregaInstrumento, Id_instrumento, Id_identidad);


            ReportDataSource CurrentReportDataSource = new ReportDataSource();
            reportViewer1.LocalReport.DataSources.Clear();

            switch (TipoReporte)
            {
                case "Etiquetas":
                    this.Text = "Formato de Etiquetas";
                    reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RptEtiquetas.rdlc";
                    CurrentReportDataSource.Name = "DataSet1";
                    CurrentReportDataSource.Value = SpInformeEtiquetasBindingSource;
                    reportViewer1.LocalReport.DataSources.Add(CurrentReportDataSource);
                    break;
                case "ActaBaja":
                    this.Text = "Acta de Baja de Instrumento";
                    reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RptActaBaja.rdlc";
                    CurrentReportDataSource.Name = "DataSet1";
                    CurrentReportDataSource.Value = SpInformeActaBajaBindingSource;
                    //ReportParameter[] parms = new ReportParameter[2];
                    //parms[0] = new ReportParameter("title", "Clients");
                    //parms[2] = new ReportParameter("title", "Clients");
                    //reportViewer1.LocalReport.SetParameters(parms);
                    reportViewer1.LocalReport.DataSources.Add(CurrentReportDataSource);
                    break;
                case "EntregaInstru":
                    this.Text = "Formato de Entrega Instrumento";
                    reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RptEntregaInstru.rdlc";
                    CurrentReportDataSource.Name = "DataSet1";
                    CurrentReportDataSource.Value = SpInformeEntregaInstrumentoBindingSource;
                    reportViewer1.LocalReport.DataSources.Add(CurrentReportDataSource);
                    break;
            }

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 125;
            this.reportViewer1.RefreshReport();

        }
    }
}

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
        public FrmInformes()
        {
            InitializeComponent();
        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.SpInformeEtiquetas' Puede moverla o quitarla según sea necesario.
            this.SpInformeEtiquetasTableAdapter.Fill(this.DataSet1.SpInformeEtiquetas);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 150;
            this.reportViewer1.RefreshReport();
        }
    }
}

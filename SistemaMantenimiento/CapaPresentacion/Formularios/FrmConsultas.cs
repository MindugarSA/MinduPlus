using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocios;

namespace CapaPresentacion.Formularios
{
    public partial class FrmConsultas : MetroFramework.Forms.MetroForm
    {
        public string TipoConsulta { get; set; }
        public DataTable DTInstruConsulta { get; set; }
        public string[] DatosEmpleadoSelecc { get; set; }
        public FrmConsultas()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            switch (TipoConsulta)
            {
                case "Vencimiento":
                    this.Text = "Instrumentos por Verificar a una Fecha";
                    DateTime fecha = DateTime.Now.AddDays(7);
                    dtpFecVenc.Text = fecha.ToString();
                    CargarConsulta(fecha, "Vencimiento");
                    break;
                case "Activos":
                    label1.Visible = false;
                    dtpFecVenc.Visible = false;
                    BtnConsultar.Visible = false;
                    this.Text = "Instrumentos Activos";
                    CargarConsulta(DateTime.Now, "Activos");
                    break;
                case "Baja":
                    label1.Visible = false;
                    dtpFecVenc.Visible = false;
                    BtnConsultar.Visible = false;
                    this.Text = "Instrumentos Dados de Baja";
                    CargarConsulta(DateTime.Now, "Baja");
                    break;
                case "Todos":
                    label1.Visible = false;
                    dtpFecVenc.Visible = false;
                    BtnConsultar.Visible = false;
                    this.Text = "Todos los Instrumentos";
                    CargarConsulta(DateTime.Now, "Todos");
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInstru.Text = "";
            if (comboBox2.SelectedIndex == 1)
            {
                FrmEmpleado Empleado = new FrmEmpleado();
                Empleado.EnvEmple += new FrmEmpleado.EnviarEmpleado(CargarDatosEmpleado); // Metodo Delegate para enviar datos desde FrmEmplado
                Empleado.TextButtton = "Filtrar";
                Empleado.TipoListado = "Consulta";
                Empleado.ShowDialog();
            }
        }
        private void txtInstru_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnBuscarInstru.PerformClick();
            }
        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            CargarConsulta(dtpFecVenc.Value, TipoConsulta);
        }

        private void btnBuscarInstru_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                if (this.txtInstru.Text == string.Empty)
                    CargarDTInicial();
                else
                    FiltrarInstrumentos("Busqueda");
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                txtInstru.Text = "";
                FrmEmpleado Empleado = new FrmEmpleado();
                Empleado.EnvEmple += new FrmEmpleado.EnviarEmpleado(CargarDatosEmpleado); // Metodo Delegate para enviar datos desde FrmEmplado
                Empleado.TextButtton = "Filtrar";
                Empleado.TipoListado = "Consulta";
                Empleado.ShowDialog();
            }
        }


        /// <summary>
        /// FUNCIONES Y PROCEDIMIENTOS
        /// </summary>

        private void CargarConsulta(DateTime fecha, string Condicion)
        {
            DTInstruConsulta = NIdentInstrumento.Consultar(fecha, Condicion);
            metroGrid1.DataSource = DTInstruConsulta;
            metroGrid1.AutoResizeColumns();
            label3.Text = "Total Instrumentos : " + metroGrid1.RowCount.ToString();
        }
        private void CargarDTInicial()
        {
            metroGrid1.DataSource = DTInstruConsulta;
            label3.Text = "Total Instrumentos : " + metroGrid1.RowCount.ToString();
        }

        private void FormatearGrid()
        {
            metroGrid1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            metroGrid1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            metroGrid1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            metroGrid1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            metroGrid1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        private void CargarDatosEmpleado(string[] DatosEmpleado)
        {
            DatosEmpleadoSelecc = DatosEmpleado;

            txtInstru.Text = DatosEmpleado[0] + " ; " + DatosEmpleado[1];
            FiltrarInstrumentos("Empleado");
        }
        private void FiltrarInstrumentos(String TipoFiltro = null)
        {
            DataTable dtf = null;
            var results = from myRow in DTInstruConsulta.AsEnumerable()
                          where (1 == 2)
                          select myRow; // Inicializar en vacio

            if (TipoFiltro == null || TipoFiltro == "Busqueda")
            {
                results = from myRow in DTInstruConsulta.AsEnumerable()
                          where ((!String.IsNullOrEmpty(myRow.Field<string>("Codigo"))
                                  && myRow.Field<string>("Codigo").ToUpper().Contains(txtInstru.Text.Trim().ToUpper()))
                                  || (!String.IsNullOrEmpty(myRow.Field<string>("Descripcion"))
                                      && myRow.Field<string>("Descripcion").ToUpper().Contains(txtInstru.Text.Trim().ToUpper())))
                          orderby myRow[0]
                          select myRow;
            }
            else if (TipoFiltro == "Empleado")
            {
                results = from myRow in DTInstruConsulta.AsEnumerable()
                          where ((!String.IsNullOrEmpty(myRow.Field<string>("RUT"))
                                  && myRow.Field<string>("RUT").ToUpper().Contains(DatosEmpleadoSelecc[0].Trim()))
                                  || (!String.IsNullOrEmpty(myRow.Field<string>("Empleado"))
                                      && myRow.Field<string>("Empleado").ToUpper().Contains(DatosEmpleadoSelecc[1].Trim())))
                          orderby myRow[0]
                          select myRow;
            }

            if (results.Any())
            {
                dtf = results.CopyToDataTable();
                if (dtf.Rows.Count > 0)
                    metroGrid1.DataSource = dtf;
                label3.Text = "Total Instrumentos : " + metroGrid1.RowCount.ToString();
            }
        }
        private void comboBox2_DrawItem(object sender, DrawItemEventArgs e)
        {
            var combo = sender as ComboBox;

            try
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 174, 219)), e.Bounds);
                else
                    e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);

                e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                              e.Font,
                                              new SolidBrush(Color.Black),
                                              new Point(e.Bounds.X, e.Bounds.Y));
                e.DrawFocusRectangle();
            }
            catch (Exception) { }


        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var Obj = (dynamic)sender;
            Obj.Left = Obj.Left - 4;
            Obj.Top = Obj.Top - 4;
            Obj.Height = Obj.Height + 8;
            Obj.Width = Obj.Width + 8;
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var Obj = (dynamic)sender;
            Obj.Left = Obj.Left + 4;
            Obj.Top = Obj.Top + 4;
            Obj.Height = Obj.Height - 8;
            Obj.Width = Obj.Width - 8;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            metroGrid1.ExportToExcel();
        }
    }
}

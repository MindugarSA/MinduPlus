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

namespace CapaPresentacion
{
    public partial class FrmBajaIndividualizacion : MetroFramework.Forms.MetroForm
    {
        private DataGridViewRow DataIdentidad;
        private string TipoAcceso;
        private DataTable DTDatosBaja;
        private string[] DatosEmpleadoSel;

        public FrmBajaIndividualizacion(DataGridViewRow DataIdent, String Acceso)
        {
            DataIdentidad = DataIdent;
            TipoAcceso = Acceso;
            InitializeComponent();
        }

        private void FrmBajaIndividualizacion_Load(object sender, EventArgs e)
        {
            CargarEncabezado();
            if (TipoAcceso == "Consulta")
            {
                panel4.BackColor = Color.FromArgb(0, 123, 158);
                bunifuCustomLabel1.Text = "Consulta de Baja";
                btnAgregar.Text = "Modificar";
                CargarActaBaja();
            }
        }

        private void FrmBajaIndividualizacion_Paint(object sender, PaintEventArgs e)
        {
            Visuales.FondoDegradado(this, e);
            Visuales.LineaCabecera(this, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmEmpleado Empleado = new FrmEmpleado();
            Empleado.EnvEmple += new FrmEmpleado.EnviarEmpleado(CargarDatosEmpleado); // Metodo Delegate para enviar datos desde FrmEmplado
            Empleado.ShowDialog();
        }

        private void CargarEncabezado()
        {
            DataTable DTInstru = new DataTable();
            DTInstru = NInstrumento.Buscar(Convert.ToInt32(DataIdentidad.Cells[0].Value));
            txtCodInstru.Text = Convert.ToString(DTInstru.Rows[0][1]);
            txtDescInstru.Text = Convert.ToString(DTInstru.Rows[0][2]);

            txtId.Text = Convert.ToString(DataIdentidad.Cells[1].Value);
            //txtEstado.Text = Convert.ToString(DataIdentidad.Cells[3].Value);
            txtCodEmp.Text = Convert.ToString(DataIdentidad.Cells[4].Value);
            txtNomEmp.Text = Convert.ToString(DataIdentidad.Cells[5].Value);
            txtCertificado.Text = Convert.ToString(DataIdentidad.Cells[9].Value);
            txtMarca.Text = Convert.ToString(DataIdentidad.Cells[10].Value);
        }

        private void CargarActaBaja()
        {
            try
            {
                DTDatosBaja = NIdentBaja.Obtener(Convert.ToInt32(DataIdentidad.Cells[0].Value), Convert.ToInt32(DataIdentidad.Cells[1].Value));
                txtCodIns.Text = DTDatosBaja.Rows[0][3].ToString();
                TxtNomIns.Text = DTDatosBaja.Rows[0][4].ToString();

                txtObserva.Text = DTDatosBaja.Rows[0][7].ToString();
                dtpIngreso.Text = DTDatosBaja.Rows[0][5].ToString();

            }
            catch (Exception){}
        }

        public void CargarDatosEmpleado(string[] DatosEmpleado)
        {
            DatosEmpleadoSel = DatosEmpleado;

            txtCodIns.Text = DatosEmpleado[0];
            TxtNomIns.Text = DatosEmpleado[1];
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Height -= 1;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(255, 152, 0);
            panel3.Height += 1;
        }

        private void txtCalibra_Leave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Height -= 1;
        }

        private void txtCalibra_Enter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, 152, 0);
            panel2.Height += 1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodIns.Text.Trim().Length > 0)
            {
                if (TipoAcceso == "Consulta")
                {
                    NIdentBaja.Actualizar(Convert.ToInt32(DTDatosBaja.Rows[0][0])
                                          , Convert.ToInt32(DTDatosBaja.Rows[0][1])
                                          , Convert.ToInt32(DTDatosBaja.Rows[0][2])
                                          , txtCodIns.Text
                                          , TxtNomIns.Text
                                          , dtpIngreso.Text
                                          , txtObserva.Text.Trim()
                                          , DatosEmpleadoSel == null ? DTDatosBaja.Rows[0][8].ToString() : DatosEmpleadoSel[2]);


                }
                else if (TipoAcceso == "Registro")
                {
                    NIdentBaja.Insertar(Convert.ToInt32(DTDatosBaja.Rows[0][1])
                                          , Convert.ToInt32(DTDatosBaja.Rows[0][2])
                                          , txtCodIns.Text
                                          , TxtNomIns.Text
                                          , dtpIngreso.Text
                                          , txtObserva.Text.Trim()
                                          , DatosEmpleadoSel == null ? DTDatosBaja.Rows[0][8].ToString() : DatosEmpleadoSel[2]);

                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Debe Seleccionar un Inspector para registrar una Baja",
                                                    "Seleccionar Inspector",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information,
                                                    370);

        }
    }
}

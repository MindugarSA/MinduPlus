using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocios;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CapaPresentacion
{
    public partial class FrmEmpleado : MetroFramework.Forms.MetroForm
    {
        public delegate void EnviarEmpleado(String[] Empleado);
        public event EnviarEmpleado EnvEmple;

        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmplado_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void FrmEmplado_Paint(object sender, PaintEventArgs e)
        {
            Visuales.FondoDegradado(this, e);
            Visuales.LineaCabecera(this, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listar()
        {
            this.dataGridView1.DataSource = NEmpleadoIndustrial.Listar();
            if (dataGridView1.RowCount > 0)
                FormatearGrid();

        }

        private void FormatearGrid()
        {
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
            //dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.AjustColumnsWidthForGridWidth();
            dataGridView1.Columns[6].Width = 80;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtItem.Text == string.Empty)
            {
                errorIcono.SetError(txtItem, "Ingrese Parte del Rut o Nombre a Buscar");
            }
            else
            {
                this.dataGridView1.DataSource = NEmpleadoIndustrial.Buscar(txtItem.Text.Trim() == "*" ? "" : txtItem.Text.Trim());
                if (dataGridView1.RowCount > 0)
                    FormatearGrid();
            }
        }

        private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorIcono.SetError(txtItem, "");
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] DatosEmpleado = new string[]
            {
                Convert.ToString(dataGridView1[0,dataGridView1.CurrentRow.Index].Value.ToString().Trim()),
                Convert.ToString(dataGridView1[1,dataGridView1.CurrentRow.Index].Value.ToString().Trim()),
                Convert.ToString(dataGridView1[6,dataGridView1.CurrentRow.Index].Value.ToString().Trim())
            };

            EnvEmple(DatosEmpleado);
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnAgregar.PerformClick();
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
    }
}

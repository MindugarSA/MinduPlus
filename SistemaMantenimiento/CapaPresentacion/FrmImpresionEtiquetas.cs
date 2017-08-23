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

    public partial class FrmImpresionEtiquetas : MetroFramework.Forms.MetroForm
    {
        private DataTable _DtEtiquetas;

        public DataTable DtEtiquetas
        {
            get { return _DtEtiquetas; }
            set { _DtEtiquetas = value; }
        }


        public FrmImpresionEtiquetas()
        {
            InitializeComponent();
        }
        private void FrmImpresionEtiquetas_Load(object sender, EventArgs e)
        {
            ListarEtiquetas();
        }
        private void metroGrid1_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = metroGrid1.HitTest(e.X, e.Y).RowIndex;
            int currentMouseOverCol = metroGrid1.HitTest(e.X, e.Y).ColumnIndex;

            if (currentMouseOverCol > -1)
            {
                metroGrid1.CurrentCell = metroGrid1[currentMouseOverCol, currentMouseOverRow < 0 ? 0 : currentMouseOverRow];

                if (e.Button == MouseButtons.Right)
                {
                    try
                    {
                        metroGrid1.Rows[(currentMouseOverRow)].Selected = true;
                        this.metroContextMenu1.Show(metroGrid1, new Point(e.X, e.Y));
                        this.metroContextMenu1.Show(Cursor.Position);
                    }
                    catch (Exception) { }
                }
            }
        }
        private void eliminarItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in metroGrid1.SelectedRows)
            {
                metroGrid1.Rows.RemoveAt(row.Index);
                NEtiquetas.InsertarDTtoDB();
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (metroGrid1.Rows.Count > 0)
            {
                FrmInformes frm = new FrmInformes()
                {
                    TipoReporte = "Etiquetas"
                };
                frm.ShowDialog();
            }
        }
        private void metroGrid1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (metroGrid1.Rows.Count > 0)
            //{
            //    if (e.ColumnIndex == 10)
            //        NEtiquetas.InsertarDTtoDB();
            //}
        }

        /// <summary>
        /// FUNCIONES Y PROCEDIMIENTOS
        /// </summary>

        private void ListarEtiquetas()
        {
            metroGrid1.DataSource = NEtiquetas.BsEtiquetas;
            if (metroGrid1.RowCount > 0)
                FormatearGrid();

        }

        private void FormatearGrid()
        {
            metroGrid1.Columns[0].Visible = false;
            metroGrid1.Columns[9].Visible = false;

            metroGrid1.Columns[3].HeaderText = "Ident.";
            metroGrid1.Columns[4].HeaderText = "Calibracion.";
            metroGrid1.Columns[5].HeaderText = "Emision";
            metroGrid1.Columns[6].HeaderText = "Vencto.";
            metroGrid1.Columns[7].HeaderText = "RUT";
            metroGrid1.Columns[8].HeaderText = "Empleado";
            metroGrid1.Columns[10].HeaderText = "Resolucion";

            metroGrid1.Columns[3].ReadOnly = true;
            metroGrid1.Columns[4].ReadOnly = true;
            metroGrid1.Columns[5].ReadOnly = true;
            metroGrid1.Columns[6].ReadOnly = true;
            metroGrid1.Columns[7].ReadOnly = true;
            metroGrid1.Columns[8].ReadOnly = true;
            metroGrid1.Columns[10].ReadOnly = false;

            metroGrid1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            metroGrid1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            metroGrid1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            metroGrid1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            metroGrid1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            metroGrid1.AjustColumnsWidthForGridWidth();
            metroGrid1.Columns[10].Width = 70;
            //dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // dataGridView1.Columns[6].Width = 80;
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

        private void metroGrid1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (metroGrid1.CurrentCell.ColumnIndex == 10)
            {
                e.Control.KeyPress += new KeyPressEventHandler(CheckKey);
            }
        }

        private void CheckKey(object sender, KeyPressEventArgs e)
        {
            TextBox TxtActual = (TextBox)sender;
            Funciones.Formato_Decimal(TxtActual, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NEtiquetas.InsertarDTtoDB();
        }
    }
}

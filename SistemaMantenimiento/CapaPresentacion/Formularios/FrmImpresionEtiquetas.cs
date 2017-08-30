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

            try
            {
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
                    else
                    {
                        if (metroGrid1.SelectedRows.Count == 1)
                        {
                            metroGrid1.CurrentCell = metroGrid1.Rows[metroGrid1.CurrentCell.RowIndex].Cells["Resolucion"];
                            metroGrid1.BeginEdit(true);
                        }
                    }
                }
            }
            catch (Exception){}
        }
        private void eliminarItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in metroGrid1.SelectedRows)
            {
                metroGrid1.Rows.RemoveAt(row.Index);
                NEtiquetas.InsertarDTtoDB();
                label3.Text = "Total Verificaciones para Imprimir : " + metroGrid1.RowCount.ToString();
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
                Double SumaRes = metroGrid1.Rows.Cast<DataGridViewRow>()
                             .Sum(t => Convert.ToDouble(t.Cells["Resolucion"].Value == DBNull.Value ? 0.0 : t.Cells["Resolucion"].Value));

                if (SumaRes == 0)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "No se ha Registrado ningún Valor en las Resoluciones de las Etiquetas,¿Continuar con la Impresión?",
                                                   "Resolución de Etiquetas",
                                                   MessageBoxButtons.YesNoCancel,
                                                   MessageBoxIcon.Question,
                                                   370) == DialogResult.Yes)
                    {
                        NEtiquetas.InsertarDTtoDB();
                        FrmInformes frm = new FrmInformes()
                        {
                            TipoReporte = "Etiquetas"
                        };
                        frm.ShowDialog();
                    }
                }
                else
                {
                    NEtiquetas.InsertarDTtoDB();
                    FrmInformes frm = new FrmInformes()
                    {
                        TipoReporte = "Etiquetas"
                    };
                    frm.ShowDialog();
                }

            }
        }
        private void metroGrid1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void metroGrid1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Context == DataGridViewDataErrorContexts.Commit)
            {
                //DataGridView view = (DataGridView)sender;
                //view.Rows[e.RowIndex].ErrorText = "an error";
                //view.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "an error";
                //MessageBox.Show("Commit error");
            }
        }

        private void metroGrid1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
                try
                {
                    string Obtenido = Convert.ToString(metroGrid1[e.ColumnIndex, e.RowIndex].Value).Trim();
                    if (Obtenido == string.Empty) Obtenido = "0,00";
                    metroGrid1[e.ColumnIndex, e.RowIndex].Value = string.Format("{0:#,0.00###}", Convert.ToDecimal(Obtenido));

                }
                catch (Exception)
                {
                    //throw;
                }
        }

        /// <summary>
        /// FUNCIONES Y PROCEDIMIENTOS
        /// </summary>

        private void ListarEtiquetas()
        {
            metroGrid1.DataSource = NEtiquetas.BsEtiquetas;
            if (metroGrid1.RowCount > 0)
                FormatearGrid();

            label3.Text = "Total Verificaciones para Imprimir : " + metroGrid1.RowCount.ToString();

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

            //metroGrid1.Columns[10].DefaultCellStyle.BackColor = Color.FromArgb(103, 184, 69);
            //metroGrid1.Columns[10].DefaultCellStyle.SelectionBackColor = Color.FromArgb(103, 184, 69);
            //metroGrid1.Columns[10].ce. = Color.FromArgb(103, 184, 69);

            metroGrid1.AjustColumnsWidthForGridWidth();
            metroGrid1.Columns[10].Width = 70;
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
            if (TxtActual.SelectedText == TxtActual.Text)
                TxtActual.Text = "";
            Funciones.Formato_Decimal(TxtActual, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NEtiquetas.InsertarDTtoDB();
        }

      
    }
}

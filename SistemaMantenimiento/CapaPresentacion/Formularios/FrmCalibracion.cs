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
    public partial class FrmCalibracion : MetroFramework.Forms.MetroForm
    {
        public delegate void EnvEvent(int i = 0);
        public event EnvEvent EnviarEvento;
        public int IdentidadGridRow { get; set; }

        private DataGridViewRow DataIdentidad;
        private DataTable DataItemsCalibracion;
        private DataTable DataDetalleCalibracion;
        private DataGridViewRow DataCalibracion;
        private string AccionEnviada;
        public FrmCalibracion(DataGridViewRow DataIdent, DataTable DataItemCalib, DataGridViewRow DataCalibra, string Accion)
        {
            DataIdentidad = DataIdent;
            DataItemsCalibracion = DataItemCalib;
            DataCalibracion = DataCalibra;
            AccionEnviada = Accion;
            InitializeComponent();
            CargarEncabezado();
            CargarDetalles();
            //DataIdentidad.DefaultCellStyle.SelectionBackColor = DataIdentidad.DefaultCellStyle.BackColor;
        }

        private void FrmCalibracion_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in dataItemCalibracion.Rows)
            {
                //DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)Row.Cells[0];
                //chk.Value = chk.TrueValue;//!(chk.Value == null ? false : (bool)chk.Value); //because chk.Value is initialy null
                //Row.Cells["Aplica"].Value = true;
                if (Convert.ToBoolean(Row.Cells["Aplica"].Value))
                {
                    Row.Cells["Aplica"].Value = true;
                    dataItemCalibracion.DefaultCellStyle.SelectionBackColor = Color.FromArgb(153, 180, 51);
                    Row.DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 51);
                }
                else
                {
                    Row.Cells["Aplica"].Value = false;
                    Row.DefaultCellStyle.BackColor = Color.White;
                    dataItemCalibracion.DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }
        }

        private void FrmCalibracion_Paint(object sender, PaintEventArgs e)
        {
            Visuales.FondoDegradado(this, e);
            Visuales.LineaCabecera(this, e);
        }

        private void dataItemCalibracion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            // Detecta si se ha seleccionado el header de la grilla
            //
            if (e.RowIndex == -1)
                return;

            if (dataItemCalibracion.Columns[e.ColumnIndex].Name == "Aplica")
            {

                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = dataItemCalibracion.Rows[e.RowIndex];

                //
                // Se selecciona la celda del checkbox
                //
                DataGridViewCheckBoxCell cellSelecion = row.Cells["Aplica"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellSelecion.Value == DBNull.Value ? false : cellSelecion.Value))
                {
                    dataItemCalibracion.DefaultCellStyle.SelectionBackColor = Color.FromArgb(153, 180, 51);
                    row.DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 51);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    dataItemCalibracion.DefaultCellStyle.SelectionBackColor = Color.White;
                }

            }
        }

        private void dataItemCalibracion_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataItemCalibracion.IsCurrentCellDirty)
            {
                dataItemCalibracion.CommitEdit(DataGridViewDataErrorContexts.Commit);
                if (dataItemCalibracion.CurrentRow.Index == -1)
                    return;

                DataGridViewCheckBoxCell cellSelecion = (DataGridViewCheckBoxCell)dataItemCalibracion[0, dataItemCalibracion.CurrentRow.Index];
                if (Convert.ToBoolean(cellSelecion.Value == DBNull.Value ? false : cellSelecion.Value))
                    dataItemCalibracion.DefaultCellStyle.SelectionBackColor = Color.FromArgb(153, 180, 51);
                else
                    dataItemCalibracion.DefaultCellStyle.SelectionBackColor = Color.White;

                dataItemCalibracion[4, dataItemCalibracion.CurrentRow.Index].Style.BackColor = dataItemCalibracion.DefaultCellStyle.SelectionBackColor;
                dataItemCalibracion[6, dataItemCalibracion.CurrentRow.Index].Style.BackColor = dataItemCalibracion.DefaultCellStyle.SelectionBackColor;
                dataItemCalibracion[7, dataItemCalibracion.CurrentRow.Index].Style.BackColor = dataItemCalibracion.DefaultCellStyle.SelectionBackColor;
            }
        }

        private void dataItemCalibracion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == 4 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                dataItemCalibracion[e.ColumnIndex, dataItemCalibracion.CurrentRow.Index].Style.BackColor = Color.White;
                dataItemCalibracion[e.ColumnIndex, dataItemCalibracion.CurrentRow.Index].Selected = true;
                dataItemCalibracion.BeginEdit(true);
            }
        }

        private void dataItemCalibracion_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == 4 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
                dataItemCalibracion[e.ColumnIndex, dataItemCalibracion.CurrentRow.Index].Style.BackColor = dataItemCalibracion.DefaultCellStyle.SelectionBackColor;

            if (e.ColumnIndex == 4)
                try
                {
                    string Obtenido = Convert.ToString(dataItemCalibracion[e.ColumnIndex, e.RowIndex].Value);
                    if (Obtenido == string.Empty) Obtenido = "0,00";
                    dataItemCalibracion[e.ColumnIndex, e.RowIndex].Value = string.Format("{0:#,0.00###}", Convert.ToDecimal(Obtenido));

                    decimal Esperado = Convert.ToDecimal(dataItemCalibracion[3, e.RowIndex].Value);
                    Decimal Diferencia = Convert.ToDecimal(Obtenido) - Esperado;
                    dataItemCalibracion[6, e.RowIndex].Value = Diferencia;

                }
                catch (Exception)
                {
                    //throw;
                }

        }

        private void dataItemCalibracion_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCheckBoxCell cellSelecion = (DataGridViewCheckBoxCell)dataItemCalibracion[0, dataItemCalibracion.CurrentRow.Index];
                if (Convert.ToBoolean(cellSelecion.Value == DBNull.Value ? false : cellSelecion.Value))
                    dataItemCalibracion.DefaultCellStyle.SelectionBackColor = Color.FromArgb(153, 180, 51);
                else
                    dataItemCalibracion.DefaultCellStyle.SelectionBackColor = Color.White;
            }
            catch
            {
                return;
            }

        }

        private void dataItemCalibracion_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataItemCalibracion.CurrentRow.Index == -1)
                return;

            if (dataItemCalibracion.CurrentCell.ColumnIndex == 4 || dataItemCalibracion.CurrentCell.ColumnIndex == 6)
            {
                TextBox TxtActual = e.Control as TextBox;
                TxtActual.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            }

        }

        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox TxtActual = (TextBox)sender;
            Funciones.Formato_Decimal(TxtActual, e);
        }

        private void TxtObserva_Enter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 152, 0);
            panel1.Height += 1;
        }

        private void TxtObserva_Leave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Height -= 1;
        }

        private void textOtros_Enter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, 152, 0);
            panel2.Height += 1;
        }

        private void textOtros_Leave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Height -= 1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string rpta = "";

            if (btnAgregar.Text == "&Agregar")
            {
                rpta = NCalibracion.Insertar(Convert.ToInt32(DataIdentidad.Cells[0].Value),
                                                    Convert.ToInt32(txtId.Text),
                                                    Convert.ToInt32(txtCalibra.Text),
                                                    Convert.ToDateTime(dtpFecCalib.Text),
                                                    Convert.ToString(TxtObserva.Text.Trim()),
                                                    DataDetalleCalibracion,
                                                    Convert.ToDateTime(dtpProxCalib.Text));
            }
            else if (btnAgregar.Text == "Actualizar")
            {
                rpta = NCalibracion.Actualizar(Convert.ToInt32(DataCalibracion.Cells[6].Value),
                                                    Convert.ToInt32(DataIdentidad.Cells[0].Value),
                                                    Convert.ToInt32(txtId.Text),
                                                    Convert.ToInt32(txtCalibra.Text),
                                                    Convert.ToDateTime(dtpFecCalib.Text),
                                                    Convert.ToString(TxtObserva.Text.Trim()),
                                                    DataDetalleCalibracion,
                                                    Convert.ToDateTime(dtpProxCalib.Text));

            }
            else
            { btnCancelar.PerformClick(); }

            if (btnAgregar.Text != "Ok")
                if (rpta == "OK")
                {
                    EnviarEvento(IdentidadGridRow);
                    MetroFramework.MetroMessageBox.Show(this, "La Verificacion fue " + btnAgregar.Text == "&Agregar" ? "Registrada" : "Actualizada" + " Exitosamente",
                                                    "Verificacion de Instrumento",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information,
                                                    370);
                    btnAgregar.Text = "Ok";

                }
                else
                {
                    MessageBox.Show(rpta, "Sistema de Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmImpresionEtiquetas oForm = new FrmImpresionEtiquetas();

            oForm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Text != "&Agregar")
            {
                try
                {
                    //NEtiquetas.DtEtiquetas.ImportRow(((DataTable)dataCalibracion.DataSource).Rows[dataCalibracion.CurrentRow.Index]);

                    DataRow dr = NEtiquetas.DtEtiquetas.NewRow();

                    dr[0] = Convert.ToInt32(DataIdentidad.Cells[0].Value);
                    dr[1] = txtCodInstru.Text.Trim();
                    dr[2] = txtDescInstru.Text.Trim();
                    dr[3] = Convert.ToInt32(txtId.Text);
                    dr[4] = Convert.ToInt32(txtCalibra.Text);
                    dr[5] = Convert.ToDateTime(dtpFecCalib.Text);
                    dr[6] = Funciones.ProximaFechaCalibracion(Convert.ToInt32(DataIdentidad.Cells[0].Value)
                                                              , txtEstado.Text
                                                              , Convert.ToDateTime(dtpFecCalib.Text));
                    dr[7] = txtCodEmp.Text.Trim();
                    dr[8] = txtNomEmp.Text.Trim();
                    dr[9] = 0;
                    dr[10] = 0.0;


                    NEtiquetas.DtEtiquetas.Rows.Add(dr);
                    NEtiquetas.InsertarDTtoDB();

                }
                catch (Exception) { }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe Registrar la Verificación antes de Agregarla a la Lista de Etiquetas",
                                                   "Verificacion de Instrumento",
                                                   MessageBoxButtons.OK,
                                                   MessageBoxIcon.Information,
                                                   370);
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtpProxCalib.Text = Convert.ToString(Funciones.ProximaFechaCalibracion(Convert.ToInt32(DataIdentidad.Cells[0].Value), txtEstado.Text.Trim(), dtpFecCalib.Value));
            DtpFecVenc.Text = Convert.ToString(Funciones.ProximaFechaCalibracion(Convert.ToInt32(DataIdentidad.Cells[0].Value), txtEstado.Text.Trim(), dtpFecCalib.Value));
        }

        /// <summary>
        /// PROCEDIMIENTOS Y FUNCIONES
        /// </summary>

        private void CargarEncabezado()
        {
            DataTable DTInstru = new DataTable();
            DTInstru = NInstrumento.Buscar(Convert.ToInt32(DataIdentidad.Cells[0].Value));
            txtCodInstru.Text = Convert.ToString(DTInstru.Rows[0][1]);
            txtDescInstru.Text = Convert.ToString(DTInstru.Rows[0][2]);
            txtItemSelec.Text = txtCodInstru.Text.Trim() + "  -  " + txtDescInstru.Text.Trim();

            txtId.Text = Convert.ToString(DataIdentidad.Cells[1].Value);
            txtEstado.Text = Convert.ToString(DataIdentidad.Cells[3].Value);
            txtCodEmp.Text = Convert.ToString(DataIdentidad.Cells[4].Value);
            txtNomEmp.Text = Convert.ToString(DataIdentidad.Cells[5].Value);
            txtCertificado.Text = Convert.ToString(DataIdentidad.Cells[9].Value);
            txtMarca.Text = Convert.ToString(DataIdentidad.Cells[10].Value);
            textOtros.Text = Convert.ToString(DataIdentidad.Cells[12].Value);

            if (AccionEnviada == "Nuevo")
            {
                txtCalibra.Text = Convert.ToString(NCalibracion.ProximoCodigoIndividual(Convert.ToInt32(DataIdentidad.Cells[0].Value), Convert.ToInt32(DataIdentidad.Cells[1].Value)));
                dtpFecCalib.Text = Convert.ToString(DataIdentidad.Cells[8].Value);
                dtpProxCalib.Text = Convert.ToString(Funciones.ProximaFechaCalibracion(Convert.ToInt32(DataIdentidad.Cells[0].Value), txtEstado.Text.Trim(), dtpFecCalib.Value));
                DtpFecVenc.Text = Convert.ToString(Funciones.ProximaFechaCalibracion(Convert.ToInt32(DataIdentidad.Cells[0].Value), txtEstado.Text.Trim(), dtpFecCalib.Value));
            }
            else if (AccionEnviada == "Actualizar")
            {
                txtCalibra.Text = Convert.ToString(DataCalibracion.Cells[3].Value);
                dtpFecCalib.Text = Convert.ToString(DataCalibracion.Cells[4].Value);
                dtpProxCalib.Text = Convert.ToString(Funciones.ProximaFechaCalibracion(Convert.ToInt32(DataIdentidad.Cells[0].Value), txtEstado.Text.Trim(), dtpFecCalib.Value));
                DtpFecVenc.Text = Convert.ToString(Funciones.ProximaFechaCalibracion(Convert.ToInt32(DataIdentidad.Cells[0].Value), txtEstado.Text.Trim(), dtpFecCalib.Value));
                TxtObserva.Text = Convert.ToString(DataCalibracion.Cells[5].Value);

                btnAgregar.Text = "Actualizar";
            }

        }

        private void CargarDetalles()
        {
            dataItemCalibracion.AutoGenerateColumns = false;
            if (AccionEnviada == "Nuevo")
            {
                DataDetalleCalibracion = NCalibracion.BuscarDetalles(0, 0, 0);
                int item = 0;

                foreach (DataRow row in DataItemsCalibracion.Rows)
                {
                    DataRow dr = DataDetalleCalibracion.NewRow();

                    dr[0] = Convert.ToInt32(DataIdentidad.Cells[0].Value);
                    dr[1] = Convert.ToInt32(DataIdentidad.Cells[1].Value);
                    dr[2] = Convert.ToInt32(txtCalibra.Text);
                    dr[3] = item += 1;
                    dr[4] = row["Metodo"].ToString();
                    dr[5] = row["Unidad"].ToString();
                    dr[6] = row["Rango"].ToString();
                    dr[7] = row["Resolucion"].ToString();
                    dr[8] = row["Criterio"].ToString();
                    dr[9] = 0.00;
                    dr[10] = 0 - Convert.ToDecimal(row["Rango"]);
                    dr[11] = "";
                    dr[12] = txtCodInstru.Text;
                    dr[13] = "false";

                    DataDetalleCalibracion.Rows.Add(dr);

                }

                dataItemCalibracion.Columns[0].DataPropertyName = "Seleccionado";
                dataItemCalibracion.Columns[1].DataPropertyName = "id_Item";
                dataItemCalibracion.Columns[4].DataPropertyName = "MediObtenida";
                dataItemCalibracion.Columns[6].DataPropertyName = "DiferObtenida";
                dataItemCalibracion.Columns[7].DataPropertyName = "Estado";
                dataItemCalibracion.DataSource = DataDetalleCalibracion;//DataItemsCalibracion;
                //dataItemCalibracion.ClearSelection();
            }
            else if (AccionEnviada == "Actualizar")
            {
                DataTable DTDeta = NCalibracion.BuscarDetalles(Convert.ToInt32(DataCalibracion.Cells[3].Value)
                                                               , Convert.ToInt32(DataIdentidad.Cells[1].Value)
                                                               , Convert.ToInt32(DataIdentidad.Cells[0].Value));
                dataItemCalibracion.Columns[0].DataPropertyName = "Seleccionado";
                dataItemCalibracion.Columns[1].DataPropertyName = "id_Item";
                dataItemCalibracion.Columns[4].DataPropertyName = "MediObtenida";
                dataItemCalibracion.Columns[6].DataPropertyName = "DiferObtenida";
                dataItemCalibracion.Columns[7].DataPropertyName = "Estado";

                dataItemCalibracion.DataSource = DTDeta;
                DataDetalleCalibracion = DTDeta;

            }

            for (int i = 0; i <= dataItemCalibracion.ColumnCount - 1; i++)
            {
                dataItemCalibracion.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

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

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
using System.Drawing.Drawing2D;
using MaterialSkin.Controls;

namespace CapaPresentacion
{
    public partial class FrmInstrumentosPrecision : Form
    {
        private FrmInstrumentosPrecision instance;
        private bool BuscandoenDGV = false;
        private DataTable DTIntrumentos;
        private DataTable DTIntrumentosEmpleado;
        private DataTable DTIndividualizacion;
        private DataTable DTIndividualizaFiltro;
        private Panel pnlParent;
        private StatusStrip StatusBarBottom;
        private string[] DatosEmpleadoSelecc;
        private String Id;


        public delegate void LaunchEvent();
        public event LaunchEvent EnviarEvento;


        public FrmInstrumentosPrecision(ref Panel prmPnlParent, ref StatusStrip prmStatusBarBottom, String prmId)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            //skinManager.AddFormToManage((MaterialForm)this);
            skinManager.ROBOTO_MEDIUM_10 = new Font("Segoe UI Light", 10);
            skinManager.ROBOTO_MEDIUM_11 = new Font("Segoe UI Light", 11);
            skinManager.ROBOTO_MEDIUM_12 = new Font("Segoe UI Light", 12);
            skinManager.ROBOTO_REGULAR_11 = new Font("Segoe UI Light", 10);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500, MaterialSkin.Primary.LightBlue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            InitializeComponent();

            this.pnlParent = prmPnlParent;
            this.Id = prmId;
            this.StatusBarBottom = prmStatusBarBottom;
            instance = this;
        }

        private void FrmInstrumentosPrecision_Shown(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.SuspendLayout();
            this.DoubleBuffered = true;

            ListarInstrumentos();
            ListarItemComprobacion();
            ListarIndividualizacion();
            ListarCalibracion();
            cmbBaja.SelectedItem = "Activos";
            comboBox1.SelectedItem = "Activos";
            comboBox2.SelectedIndex = 0;

            //NEtiquetas.Eliminar();
            NEtiquetas.DtEtiquetas.Clear();
            NEtiquetas.DtEtiquetas = NEtiquetas.Listar();
            NEtiquetas.BsEtiquetas.DataSource = NEtiquetas.DtEtiquetas;

            this.ResumeLayout();
        }
        private void FrmInstrumentosPrecision_Load(object sender, EventArgs e)
        {

        }
        private void FrmInstrumentosPrecision_Paint(object sender, PaintEventArgs e)
        {
            //Visuales.FondoDegradado(this, e);
            //Visuales.LineaCabecera(this, e);
        }
        private void FrmInstrumentosPrecision_Resize(object sender, EventArgs e)
        {
            double dWGrp1 = 48.6217;
            double dHGrp1 = 32.5126;
            groupBox1.Width = Convert.ToInt32(Math.Round((dWGrp1 * this.Size.Width) / 100, 0));
            groupBox1.Height = Convert.ToInt32(Math.Round((dHGrp1 * this.Size.Height) / 100, 0));

            groupBox2.Left = groupBox1.Left + groupBox1.Width + 14;
            groupBox2.Width = this.Size.Width - groupBox2.Left - 14; //Convert.ToInt32(Math.Round((dWGrp2 * this.Size.Width) / 100, 0));
            groupBox2.Height = groupBox1.Height;
            //groupBox2.Anchor = (AnchorStyles.Right | AnchorStyles.Top);

            txtItemSelec.Top = groupBox1.Top + groupBox1.Height + 5;

            double dWGrp3 = 62.0980;
            double dHGrp3 = 57.1777;
            groupBox3.Width = Convert.ToInt32(Math.Round((dWGrp3 * this.Size.Width) / 100, 0));
            groupBox3.Height = Convert.ToInt32(Math.Round((dHGrp3 * this.Size.Height) / 100, 0));
            groupBox3.Top = txtItemSelec.Top + txtItemSelec.Height + 1;

            groupBox4.Left = groupBox3.Left + groupBox3.Width + 14;
            groupBox4.Width = this.Size.Width - groupBox4.Left - 14;//Convert.ToInt32(Math.Round((dWGrp4 * this.Size.Width) / 100, 0));
            groupBox4.Height = groupBox3.Height;//Convert.ToInt32(Math.Round((dHGrp4 * this.Size.Height) / 100, 0));
            groupBox4.Top = groupBox3.Top;

        }
        private void FrmInstrumentosPrecision_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pnlParent != null)
            {
                this.StatusBarBottom.Visible = false;
                if (EnviarEvento != null)
                {
                    EnviarEvento();
                }
                pnlParent.Visible = true;
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarInstrumento Instrumento = new FrmAgregarInstrumento(this);
            Instrumento.ShowDialog();

        }
        private void btnItems_Click(object sender, EventArgs e)
        {
            FrmItemsComprobacion Item = new FrmItemsComprobacion();
            Item.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmIndividualizacion Individualizacion = new FrmIndividualizacion(dataIndividualizacion.RowCount == 0 ?
                                                         dataInstrumentos.Rows[dataInstrumentos.SelectedRows[0].Index] :
                                                         dataIndividualizacion.Rows[dataIndividualizacion.SelectedRows[0].Index], "Agregar");
            Individualizacion.EnviarEvento += new FrmIndividualizacion.EnvEvent(ListarIndividualizacion); // Metodo Delegate para enviar ejecucion de evento desde FrmIndividualizacion
            Individualizacion.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataIndividualizacion.RowCount > 0)
            {
                FrmIndividualizacion Individualizacion = new FrmIndividualizacion(dataIndividualizacion.Rows[dataIndividualizacion.SelectedRows[0].Index], "Actualizar");
                Individualizacion.EnviarEvento += new FrmIndividualizacion.EnvEvent(ListarIndividualizacion); // Metodo Delegate para enviar ejecucion de evento desde FrmIndividualizacion
                Individualizacion.ShowDialog();
            }

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void eliminarInstrumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rpta = "";
            int nId = Convert.ToInt32(dataInstrumentos.Rows[dataInstrumentos.CurrentRow.Index].Cells[0].Value);
            string nCodigo = Convert.ToString(dataInstrumentos[1, dataInstrumentos.CurrentRow.Index].Value);

            if (MetroFramework.MetroMessageBox.Show(this,
                                                "Inactivar el Instrumento '" +
                                                Convert.ToString(dataInstrumentos[2, dataInstrumentos.CurrentRow.Index].Value) +
                                                "'",
                                                "Sistema Mantenimiento",
                                                MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.Question,
                                                370) == DialogResult.OK)
            {
                rpta = NInstrumento.Eliminar(nId, nCodigo);
                ListarInstrumentos();
            }
        }
        private void dataInstrumentos_MouseClick(object sender, MouseEventArgs e)
        {
            //ClickGridInstrumentos = true;
            int currentMouseOverRow = dataInstrumentos.HitTest(e.X, e.Y).RowIndex;
            int currentMouseOverCol = dataInstrumentos.HitTest(e.X, e.Y).ColumnIndex;

            if (currentMouseOverCol > -1)
            {
                dataInstrumentos.CurrentCell = dataInstrumentos[currentMouseOverCol, currentMouseOverRow < 0 ? 0 : currentMouseOverRow];

                ListarItemComprobacion();
                //ListarIndividualizacion(); // La actualizacion del Grid de Individualizacion se hace en el evento SelectionChanged

                if (e.Button == MouseButtons.Right)
                {
                    try
                    {
                        dataInstrumentos.Rows[(currentMouseOverRow)].Selected = true;
                        this.contextMenuInstru.Show(dataInstrumentos, new Point(e.X, e.Y));
                        this.contextMenuInstru.Show(Cursor.Position);
                        //menu_contextual.Show(dataItems, new Point(e.X, e.Y));

                        switch (Convert.ToString(dataInstrumentos[5, currentMouseOverRow].Value))
                        {
                            case "I":
                                contextMenuInstru.Items[0].Enabled = false;
                                contextMenuInstru.Items[1].Enabled = true;
                                break;
                            default:
                                contextMenuInstru.Items[0].Enabled = true;
                                contextMenuInstru.Items[1].Enabled = false;
                                break;
                        }


                    }
                    catch (Exception) { }
                }
            }
        }
        private void dataInstrumentos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewComboBoxCell comboboxColumn1 = (DataGridViewComboBoxCell)dataInstrumentos.Rows[e.RowIndex].Cells[3];
                DataGridViewComboBoxCell comboboxColumn2 = (DataGridViewComboBoxCell)dataInstrumentos.Rows[e.RowIndex].Cells[4];

                if (e.ColumnIndex == comboboxColumn1.ColumnIndex || e.ColumnIndex == comboboxColumn2.ColumnIndex) //check if combobox column
                {
                    string rpta = NInstrumento.Actualizar(Convert.ToInt32(dataInstrumentos[0, dataInstrumentos.CurrentRow.Index].Value),
                                                           Convert.ToString(dataInstrumentos[1, dataInstrumentos.CurrentRow.Index].Value),
                                                           Convert.ToString(dataInstrumentos[2, dataInstrumentos.CurrentRow.Index].Value),
                                                           Convert.ToString(dataInstrumentos[3, dataInstrumentos.CurrentRow.Index].Value),
                                                           Convert.ToString(dataInstrumentos[4, dataInstrumentos.CurrentRow.Index].Value),
                                                           "A");
                    if (rpta != "OK")
                    {
                        this.MensajeError(rpta);
                    }
                    // object selectedValue = dataInstrumentos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                }
            }

        }
        private void btnAsociarItem_Click(object sender, EventArgs e)
        {
            FrmItemsInstrumento AsociarItem = new FrmItemsInstrumento(Convert.ToInt32(dataInstrumentos.Rows[dataInstrumentos.CurrentRow.Index].Cells[0].Value));
            AsociarItem.EnviarEvento += new FrmItemsInstrumento.EnvEvent(ListarItemComprobacion); // Metodo Delegate para enviar datos desde FrmEmplado
            AsociarItem.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FrmCalibracion Calibracion = new FrmCalibracion(dataIndividualizacion.Rows[dataIndividualizacion.SelectedRows[0].Index],
                                                            (DataTable)dataItemsComp.DataSource,
                                                            dataCalibracion.Rows.Count == 0 ? null : dataCalibracion.Rows[dataCalibracion.SelectedRows[0].Index],
                                                            "Nuevo");
            Calibracion.IdentidadGridRow = dataIndividualizacion.SelectedRows[0].Index;
            Calibracion.EnviarEvento += new FrmCalibracion.EnvEvent(ListarIndividualizacion);
            //Calibracion.EnviarEvento += new FrmCalibracion.EnvEvent(ListarCalibracion);
            Calibracion.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(dataCalibracion.Rows.Count > 0)
            {
                FrmCalibracion Calibracion = new FrmCalibracion(dataIndividualizacion.Rows[dataIndividualizacion.SelectedRows[0].Index],
                                                            (DataTable)dataItemsComp.DataSource,
                                                            dataCalibracion.Rows[dataCalibracion.SelectedRows[0].Index],
                                                            "Actualizar");
                Calibracion.EnviarEvento += new FrmCalibracion.EnvEvent(ListarIndividualizacion); // Metodo Delegate para enviar ejecucion de evento desde FrmIndividualizacion
                Calibracion.ShowDialog();
            }
        }
        private void dataInstrumentos_SelectionChanged(object sender, EventArgs e)
        {
            if (!BuscandoenDGV)
            {
                ListarItemComprobacion();
                ListarIndividualizacion();

            }
        }
        private void btnBuscarInstru_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                if (this.txtInstru.Text == string.Empty)
                {
                    dataInstrumentos.DataSource = DTIntrumentos;
                    //errorIcono.SetError(txtInstru, "Ingrese Parte del Codigo o Descripcion a Buscar");
                }
                else
                {
                    FiltrarInstrumentos();
                    //if (!BuscarDGV_LINQ(txtInstru.Text.ToUpper(), "2", dataInstrumentos))
                    //{
                    //    BuscarDGV_LINQ(txtInstru.Text.ToUpper(), "1", dataInstrumentos);
                    //}
                }
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                txtInstru.Text = "";
                FrmEmpleado Empleado = new FrmEmpleado();
                Empleado.EnvEmple += new FrmEmpleado.EnviarEmpleado(CargarDatosEmpleado); // Metodo Delegate para enviar datos desde FrmEmplado
                Empleado.TextButtton = "Filtrar";
                Empleado.TipoListado = "Identidad";
                Empleado.ShowDialog();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //dataInstrumentos.DataSource = DTIntrumentos;
            comboBox2.SelectedIndex = 0;
            ListarInstrumentos();
            FiltrarInstrumentos("Estado");
        }

        private void txtInstru_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorIcono.SetError(txtInstru, "");
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnBuscarInstru.PerformClick();
            }
        }
        private void cmbBaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    FiltrarIndividualizacion(cmbBaja.SelectedIndex);
                    break;
                case 1:
                    FiltrarIndividualizacionEmpleado(cmbBaja.SelectedIndex, DatosEmpleadoSelecc[0]);
                    break;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarInstrumentos("Estado");
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInstru.Text = "";
            if (comboBox2.SelectedIndex == 1)
            {
                FrmEmpleado Empleado = new FrmEmpleado();
                Empleado.EnvEmple += new FrmEmpleado.EnviarEmpleado(CargarDatosEmpleado); // Metodo Delegate para enviar datos desde FrmEmplado
                Empleado.TextButtton = "Filtrar";
                Empleado.TipoListado = "Identidad";
                Empleado.ShowDialog();
            }
        }
        private void dataIndividualizacion_SelectionChanged(object sender, EventArgs e)
        {
            ListarCalibracion();
            if (DTIndividualizaFiltro.Rows.Count == 0)
            {
                button4.Enabled = false;
                return;
            }
            else
                button4.Enabled = true;

        }
        private void dataIndividualizacion_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dataIndividualizacion.HitTest(e.X, e.Y).RowIndex;
            int currentMouseOverCol = dataIndividualizacion.HitTest(e.X, e.Y).ColumnIndex;

            if (currentMouseOverCol > -1)
            {
                dataIndividualizacion.CurrentCell = dataIndividualizacion[currentMouseOverCol, currentMouseOverRow < 0 ? 0 : currentMouseOverRow];

                if (e.Button == MouseButtons.Right)
                {
                    try
                    {
                        dataIndividualizacion.Rows[(currentMouseOverRow)].Selected = true;
                        this.contextMenuIdent.Show(dataIndividualizacion, new Point(e.X, e.Y));
                        this.contextMenuIdent.Show(Cursor.Position);
                        //menu_contextual.Show(dataItems, new Point(e.X, e.Y));

                        switch (Convert.ToString(dataIndividualizacion[3, currentMouseOverRow].Value))
                        {
                            case "Baja":
                                contextMenuIdent.Items[0].Enabled = false;
                                contextMenuIdent.Items[1].Enabled = true;
                                break;
                            default:
                                contextMenuIdent.Items[0].Enabled = true;
                                contextMenuIdent.Items[1].Enabled = false;
                                break;
                        }
                    }
                    catch (Exception) { }
                }
            }
        }
        private void dataCalibracion_MouseClick(object sender, MouseEventArgs e)
        {
            //ClickGridInstrumentos = true;
            int currentMouseOverRow = dataCalibracion.HitTest(e.X, e.Y).RowIndex;
            int currentMouseOverCol = dataCalibracion.HitTest(e.X, e.Y).ColumnIndex;

            if (currentMouseOverCol > -1)
            {
                dataCalibracion.CurrentCell = dataCalibracion[currentMouseOverCol, currentMouseOverRow < 0 ? 0 : currentMouseOverRow];

                if (e.Button == MouseButtons.Right)
                {
                    try
                    {
                        dataCalibracion.Rows[(currentMouseOverRow)].Selected = true;
                        this.ContextMenuCalibra.Show(dataCalibracion, new Point(e.X, e.Y));
                        this.ContextMenuCalibra.Show(Cursor.Position);
                        //menu_contextual.Show(dataItems, new Point(e.X, e.Y));
                    }
                    catch (Exception) { }
                }
            }
        }
        private void dataCalibracion_SelectionChanged(object sender, EventArgs e)
        {
            if (dataCalibracion.Rows.Count == 0)
            {
                button3.Enabled = false;
                return;
            }
            else
                button3.Enabled = true;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///  FUNIONES Y PROCEDIMIENTOS
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// Carga el DataGrid dataInstrumentos
        /// </summary>
        public void ListarInstrumentos()
        {
            // Asignar los datos a combos de frecuencia
            DataGridViewComboBoxColumn cmbfrecuencia = dataInstrumentos.Columns[3] as DataGridViewComboBoxColumn;

            cmbfrecuencia.DataSource = NFrecuencia.Listar();
            cmbfrecuencia.DisplayMember = "Descripcion";
            cmbfrecuencia.ValueMember = "Descripcion";

            cmbfrecuencia = dataInstrumentos.Columns[4] as DataGridViewComboBoxColumn;
            cmbfrecuencia.DataSource = NFrecuencia.Listar();
            cmbfrecuencia.DisplayMember = "Descripcion";
            cmbfrecuencia.ValueMember = "Descripcion";

            dataInstrumentos.AutoGenerateColumns = false;
            dataInstrumentos.DataSource = NInstrumento.Listar();
            dataInstrumentos.Columns[1].ReadOnly = true;
            dataInstrumentos.Columns[2].ReadOnly = true;
            dataInstrumentos.Columns[3].HeaderText = "Verif. Nvo.";
            dataInstrumentos.Columns[4].HeaderText = "Verif. Usa.";
            var colEdo = new DataGridViewTextBoxColumn();
            colEdo.HeaderText = "Estado";
            colEdo.Width = 50;
            colEdo.DataPropertyName = "Estado";
            dataInstrumentos.Columns.Add(colEdo);

            dataInstrumentos.AutoResizeColumns();
            DTIntrumentos = (DataTable)dataInstrumentos.DataSource;

        }
        /// <summary>
        /// Carga el DataGrid dataItemsCompaa
        /// </summary>
        private void ListarItemComprobacion()
        {
            if (dataInstrumentos.SelectedRows.Count > 0)
            {
                int indice = dataInstrumentos.SelectedRows[0].Index;
                dataItemsComp.DataSource = NInstruItems.ListarAsignados(Convert.ToInt32(dataInstrumentos[0, indice].Value));
                dataItemsComp.AutoResizeColumns();
                dataItemsComp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataItemsComp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataItemsComp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataItemsComp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataItemsComp.Columns[3].DefaultCellStyle.Format = "#,0.00###";
                dataItemsComp.Columns[4].DefaultCellStyle.Format = "#,0.00###";
                dataItemsComp.Columns[5].DefaultCellStyle.Format = "#,0.00###";
            }

        }
        /// <summary>
        /// Carga el DataGrid dataIndividualizacion
        /// </summary>
        private void ListarIndividualizacion(int SelecRow = 0)
        {
            if (dataInstrumentos.SelectedRows.Count > 0)
            {
                int indice = dataInstrumentos.SelectedRows[0].Index;
                txtItemSelec.Text = Convert.ToString(dataInstrumentos[2, indice].Value);
                DTIndividualizacion = NIdentInstrumento.Listar(Convert.ToInt32(dataInstrumentos[0, indice].Value));
                DTIndividualizaFiltro = DTIndividualizacion.Clone();
                switch (comboBox2.SelectedIndex)
                {
                    case 1:
                        FiltrarIndividualizacionEmpleado(cmbBaja.SelectedIndex, DatosEmpleadoSelecc[0]);
                        break;
                    default:
                        FiltrarIndividualizacion(cmbBaja.SelectedIndex);
                        break;
                }
                dataIndividualizacion.AutoResizeColumns();
                if (SelecRow > 0)
                    dataIndividualizacion.SelectRowAndSroll(SelecRow);
            }

        }
        /// <summary>
        /// Carga el DataGrid dataIndividualizacion
        /// </summary>
        private void ListarCalibracion()
        {
            if (dataIndividualizacion.SelectedRows.Count > 0)
            {
                int indice = dataIndividualizacion.SelectedRows[0].Index;
                txtResponsable.Text = Convert.ToString(dataIndividualizacion[4, indice].Value) + " - "
                                      + Convert.ToString(dataIndividualizacion[5, indice].Value);
                dataCalibracion.DataSource = NCalibracion.Listar(Convert.ToInt32(dataIndividualizacion[0, indice].Value),
                                                                 Convert.ToInt32(dataIndividualizacion[1, indice].Value));

            }
            else
            {
                txtResponsable.Text = "-";
                //dataCalibracion.DataSource = null;
                DataTable DT = (DataTable)dataCalibracion.DataSource;
                if (DT != null)
                    DT.Clear();
                // if (dataCalibracion.Rows.Count > 0) dataCalibracion.Rows.Clear();
            }
        }
        /// <summary>
        /// Filta el DataGRid dataIndividualizacion de acuerdo al Estado del la Individualizacion
        /// </summary>
        /// <param name="IndiceCombo"></param>
        private void FiltrarIndividualizacion(int IndiceCombo)
        {
            try
            {
                DTIndividualizaFiltro = (from DataRow dr in DTIndividualizacion.Rows
                                         where (IndiceCombo == 0 ? dr[3].ToString() != "Baja"
                                                                 : IndiceCombo == 1 ? dr[3].ToString() == "Baja"
                                                                                    : true)
                                         select dr).CopyToDataTable();
            }
            catch { }

            dataIndividualizacion.DataSource = DTIndividualizaFiltro;
        }

        private void FiltrarIndividualizacionEmpleado(int IndiceCombo, String RUT)
        {
            try
            {
                DTIndividualizaFiltro = (from DataRow dr in DTIndividualizacion.Rows
                                         where dr[4].ToString() == RUT
                                                && (IndiceCombo == 0 ? dr[3].ToString() != "Baja"
                                                                 : IndiceCombo == 1 ? dr[3].ToString() == "Baja"
                                                                                    : true)
                                         select dr).CopyToDataTable();
            }
            catch { }

            dataIndividualizacion.DataSource = DTIndividualizaFiltro;
        }
        /// <summary>
        ///   Buscar la primera coincidencia de una cadena en un DataGrid en una columna determinada
        ///   selecciona el row y ubica el scroll en dicha linea.
        /// </summary>
        /// <param name="TextoABuscar"></param>
        /// <param name="Columna"></param>
        /// <param name="grid"></param>
        /// <returns></returns>
        private bool BuscarDGV_LINQ(string TextoABuscar, string Columna, DataGridView grid)
        {
            BuscandoenDGV = true;
            bool encontrado = false;
            if (TextoABuscar == string.Empty) return false;
            if (grid.RowCount == 0) return false;
            //grid.ClearSelection();
            if (Columna == string.Empty)
            {
                IEnumerable<DataGridViewRow> obj = (from DataGridViewRow row in grid.Rows.Cast<DataGridViewRow>()
                                                    from DataGridViewCell cells in row.Cells
                                                    where cells.OwningRow.Equals(row) && Convert.ToString(cells.Value).Contains(TextoABuscar)
                                                    select row);
                if (obj.Any())
                {
                    BuscandoenDGV = false;
                    grid.Rows[obj.FirstOrDefault().Index].Selected = true;
                    grid.FirstDisplayedScrollingRowIndex = obj.FirstOrDefault().Index;
                    grid.CurrentCell = grid[Convert.ToInt32(Columna), obj.FirstOrDefault().Index];
                    return true;
                }

            }
            else
            {
                IEnumerable<DataGridViewRow> obj = (from DataGridViewRow row in grid.Rows.Cast<DataGridViewRow>()
                                                    where Convert.ToString(row.Cells[Convert.ToInt32(Columna)].Value).Contains(TextoABuscar)
                                                    select row);
                if (obj.Any())
                {
                    BuscandoenDGV = false;
                    grid.Rows[obj.FirstOrDefault().Index].Selected = true;
                    grid.FirstDisplayedScrollingRowIndex = obj.FirstOrDefault().Index;
                    grid.CurrentCell = grid[Convert.ToInt32(Columna), obj.FirstOrDefault().Index];
                    return true;
                }

            }
            BuscandoenDGV = false;
            return encontrado;


        }

        private void FiltrarInstrumentos(String TipoFiltro = null)
        {
            DataTable dtf = null;
            var results = from myRow in DTIntrumentos.AsEnumerable()
                          where (1 == 2)
                          select myRow; // Inicializar en vacio

            if (TipoFiltro == null || TipoFiltro == "Busqueda")
            {
                results = from myRow in DTIntrumentos.AsEnumerable()
                          where ((!String.IsNullOrEmpty(myRow.Field<string>("Codigo"))
                                  && myRow.Field<string>("Codigo").ToUpper().Contains(txtInstru.Text.Trim().ToUpper()))
                                  || (!String.IsNullOrEmpty(myRow.Field<string>("Descripcion"))
                                      && myRow.Field<string>("Descripcion").ToUpper().Contains(txtInstru.Text.Trim().ToUpper())))
                          orderby myRow[0]
                          select myRow;
            }
            else if (TipoFiltro == "Estado")
            {
                string sEstado = "T";
                switch (comboBox1.Text)
                {
                    case "Activos":
                        sEstado = "A";
                        break;
                    case "Inactivos":
                        sEstado = "I";
                        break;
                }

                if (sEstado == "T")
                    dataInstrumentos.DataSource = DTIntrumentos;
                else
                    results = from myRow in DTIntrumentos.AsEnumerable()
                              where ((!String.IsNullOrEmpty(myRow.Field<string>("Estado"))
                                      && myRow.Field<string>("Estado").ToUpper().Contains(sEstado)))
                              orderby myRow[0]
                              select myRow;
            }
            else if (TipoFiltro == "Empleado")
            {
                DTIntrumentosEmpleado = NInstrumento.ListarPorEmpleado(DatosEmpleadoSelecc[0]);
                results = from myRow in DTIntrumentosEmpleado.AsEnumerable()
                          select myRow;
            }

            if (results.Any())
            {
                dtf = results.CopyToDataTable();
                if (dtf.Rows.Count > 0)
                    dataInstrumentos.DataSource = dtf;
            }

        }
        /// <summary>
        /// Mostrar Mensaje de Confirmación
        /// </summary>
        /// <param name="mensaje"></param>
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Mostrar Mensaje de Error
        /// </summary>
        /// <param name="mensaje"></param>
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void darDeBajaAIndividualizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBajaIndividualizacion DarBaja = new FrmBajaIndividualizacion(dataIndividualizacion.Rows[dataIndividualizacion.SelectedRows[0].Index], "Registro");
            DarBaja.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmBajaIndividualizacion DarBaja = new FrmBajaIndividualizacion(dataIndividualizacion.Rows[dataIndividualizacion.SelectedRows[0].Index], "Consulta");
            DarBaja.ShowDialog();
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
        private void CargarDatosEmpleado(string[] DatosEmpleado)
        {
            DatosEmpleadoSelecc = DatosEmpleado;

            txtInstru.Text = DatosEmpleado[0] + " ; " + DatosEmpleado[1];
            FiltrarInstrumentos("Empleado");
        }

        private void cmbBaja_DrawItem(object sender, DrawItemEventArgs e)
        {
            var combo = sender as ComboBox;

            try
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 174, 219)), e.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
                }

                e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                              e.Font,
                                              new SolidBrush(Color.Black),
                                              new Point(e.Bounds.X, e.Bounds.Y));
                e.DrawFocusRectangle();
            }
            catch (Exception) { }

        }


        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenuStrip Menu = button6.ContextMenuStrip;

            if (Menu != null && e.Button == MouseButtons.Left)
            {
                //Point menuLocation;

                //menuLocation = new Point(0, button6.Height);

                //Menu.Show(button6, menuLocation);

                Point screenPoint = button6.PointToScreen(new Point(button6.Left, button6.Bottom));
                if (screenPoint.Y + Menu.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
                    Menu.Show(button6, new Point(0, -Menu.Size.Height));
                else
                    Menu.Show(button6, new Point(0, button6.Height));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmImpresionEtiquetas oForm = new FrmImpresionEtiquetas();
            oForm.ShowDialog();
        }

        private void opcion1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                //NEtiquetas.DtEtiquetas.ImportRow(((DataTable)dataCalibracion.DataSource).Rows[dataCalibracion.CurrentRow.Index]);

                DataRow dr = NEtiquetas.DtEtiquetas.NewRow();

                int indice = dataCalibracion.CurrentRow.Index;

                dr[0] = Convert.ToInt32(dataCalibracion[0, indice].Value);
                dr[1] = Convert.ToString(dataCalibracion[1, indice].Value).Trim();
                dr[2] = dataInstrumentos[2, dataInstrumentos.CurrentRow.Index].Value.ToString().Trim();
                dr[3] = Convert.ToInt32(dataCalibracion[2, indice].Value);
                dr[4] = Convert.ToInt32(dataCalibracion[3, indice].Value);
                dr[5] = Convert.ToDateTime(dataCalibracion[4, indice].Value);
                dr[6] = Funciones.ProximaFechaCalibracion(Convert.ToInt32(dataIndividualizacion[0, dataIndividualizacion.CurrentRow.Index].Value)
                                                          , Convert.ToString(dataIndividualizacion[3, dataIndividualizacion.CurrentRow.Index].Value)
                                                          , Convert.ToDateTime(dataCalibracion[4, indice].Value));
                dr[7] = Convert.ToString(dataIndividualizacion[4, dataIndividualizacion.CurrentRow.Index].Value).Trim();
                dr[8] = Convert.ToString(dataIndividualizacion[5, dataIndividualizacion.CurrentRow.Index].Value).Trim();
                dr[9] = Convert.ToInt32(dataCalibracion[6, indice].Value);
                dr[10] = 0.0;

                NEtiquetas.DtEtiquetas.Rows.Add(dr);
                NEtiquetas.InsertarDTtoDB();
            }
            catch (Exception) { }

        }

       


    }
}

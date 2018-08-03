using Pabo.Calendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtrasAppsMindumas
{
    public partial class Frm_DiasFeriados : MetroFramework.Forms.MetroForm
    {
        private Frm_DiasFeriados instance;
        private DataTable dtFeriados;
        private DataTable dtTipos;
        private Panel pnlParent;
        private StatusStrip StatusBarBottom;
        private String Id;
        private DateTime DiaActual;
        private int MesActual;
        private int AñoActual;
        private DateItem[] InfoDiaActual;
        private DateTime DiaActualGrid;
        private DateTime InicioMesActual;
        private DateTime FinMesActual;

        public ConexionBL conexion { get; set; } = new ConexionBL();
        public SqlCommand cmd { get; set; }

        public delegate void LaunchEvent();
        public event LaunchEvent EnviarEvento;

        public Frm_DiasFeriados(ref Panel prmPnlParent, ref StatusStrip prmStatusBarBottom, String prmId)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            //skinManager.AddFormToManage((MaterialForm)this);
            skinManager.ROBOTO_MEDIUM_10 = new Font("Segoe UI Light", 10);
            skinManager.ROBOTO_MEDIUM_11 = new Font("Segoe UI Light", 11);
            skinManager.ROBOTO_MEDIUM_12 = new Font("Segoe UI Light", 12);
            skinManager.ROBOTO_REGULAR_11 = new Font("Segoe UI Light", 10);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500, MaterialSkin.Primary.LightBlue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            InitializeComponent();

            this.pnlParent = prmPnlParent;
            this.Id = prmId;
            this.StatusBarBottom = prmStatusBarBottom;
            instance = this;
        }

        private void Frm_DiasFeriados_Load(object sender, EventArgs e)
        {
            DiaActual = DateTime.Now;
            MonthCalendar3.ActiveMonth.Month = DiaActual.Month;
            MonthCalendar3.ActiveMonth.Year = DiaActual.Year;
            MesActual = MonthCalendar3.ActiveMonth.Month;
            AñoActual = MonthCalendar3.ActiveMonth.Year;
            InicioMesActual = new DateTime(AñoActual, MesActual, 01);
            FinMesActual = new DateTime(AñoActual, MesActual, System.DateTime.DaysInMonth(AñoActual, MesActual));

            CargarComboTipo();
            CargarDiasFeriadosGrid();
            CargarCalendario();

        }

        private void Frm_DiasFeriados_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonthCalendar3_DayClick(object sender, Pabo.Calendar.DayClickEventArgs e)
        {
            if (DiaActual.Month != MesActual) return;

            DiaActual = Convert.ToDateTime(e.Date);
            InfoDiaActual = MonthCalendar3.GetDateInfo(DiaActual);

            if (DiaActual != DiaActualGrid)
            {
                TxtFecha.Text = DiaActual.ToLongDateString().ToUpper();
                TxtDescripcion.Text = "";
                txtComentario.Text = "";
                MetroComboBox2.SelectedIndex = 0;

                if (InfoDiaActual.Length > 0)
                {
                    MetroGrid1.SearchAndSelectValue(DiaActual.ToShortDateString().ToString(), "0");
                    CargarDatosFecha();
                }
            }
            else
                CargarDatosFecha();

        }

        private void MetroGrid1_SelectionChanged(object sender, EventArgs e)
        {
            CargarDatosFecha();
        }

        private void MetroGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                CargarDatosFecha();
                if(MesActual != DiaActualGrid.Month)
                {
                    MonthCalendar3.ActiveMonth.Month = DiaActualGrid.Month;
                    MonthCalendar3.ActiveMonth.Year = DiaActualGrid.Year;
                }
                MonthCalendar3.SelectDate(DiaActualGrid);
                DiaActual = DiaActualGrid ;
                InfoDiaActual = MonthCalendar3.GetDateInfo(DiaActual);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (DiaActual.Month == MesActual)
            {
                if (InfoDiaActual.Length > 0)
                {
                    EliminarDiaFeriadoDB(DiaActual);
                    RegistrarDiaFeriadoDB(DiaActual);
                    CargarDiasFeriadosGrid(DiaActual);
                }
                else
                {
                    AgregarDiaFeriadoCalendario();
                    RegistrarDiaFeriadoDB(DiaActual);
                    CargarDiasFeriadosGrid(DiaActual);
                }
                
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (InfoDiaActual.Length > 0)
                if (MetroFramework.MetroMessageBox.Show(this, "¿Confirmar la Eliminación del Feriado '" + DiaActual.ToLongDateString().Trim() + "'?, Esta Acción es Irreversible.",
                                          "Eliminacion de Registro",
                                          MessageBoxButtons.OKCancel,
                                          MessageBoxIcon.Question,
                                          370) == DialogResult.OK)
                {
                    EliminarDiasFeriado();
                    EliminarDiaFeriadoDB(DiaActual);
                    CargarDiasFeriadosGrid();
                }
        }
        private void CargarDiasFeriadosGrid(DateTime? FechaSelec = null)
        {
            DateTime dInicio = new DateTime(AñoActual, 01, 01);
            DateTime dFin = new DateTime(AñoActual, 12, 31);
            dtFeriados = dtFeriados.ExecuteQuey(@"EXEC [SAC_Mindugar].[dbo].[Feriados_Info_Consultar] 
                                                 '" + dInicio.ToString("yyyyMMdd") + "','" + dFin.ToString("yyyyMMdd") + "'");

            MetroGrid1.DataSource = dtFeriados;

            MetroGrid1.Columns[0].ReadOnly = true;
            MetroGrid1.Columns[1].ReadOnly = true;
            MetroGrid1.Columns[2].ReadOnly = true;
            MetroGrid1.Columns[3].ReadOnly = true;
            MetroGrid1.Columns[4].Visible = false;

            MetroGrid1.AutoResizeColumns();

            if (FechaSelec.HasValue)
                MetroGrid1.SearchAndSelectValue(Convert.ToDateTime(FechaSelec).ToShortDateString().ToString(), "0");

        }

        private void CargarDatosFecha()
        {
            DiaActualGrid = Convert.ToDateTime(MetroGrid1.Rows[MetroGrid1.CurrentCell.RowIndex].Cells[0].Value);
            TxtFecha.Text = Convert.ToDateTime(MetroGrid1.Rows[MetroGrid1.CurrentCell.RowIndex].Cells[0].Value).ToLongDateString().ToUpper();
            TxtDescripcion.Text = MetroGrid1.Rows[MetroGrid1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtComentario.Text = MetroGrid1.Rows[MetroGrid1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            MetroComboBox2.SelectedValue = MetroGrid1.Rows[MetroGrid1.CurrentCell.RowIndex].Cells[4].Value.ToString();
        }

        private void RegistrarDiaFeriadoDB(DateTime fechaFeriado)
        {
            SqlConnection conn = conexion.sqlConexion;

            cmd = new SqlCommand("[Feriados_Info_Insertar]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            cmd.Parameters.Add(new SqlParameter("@Fecha", fechaFeriado));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", TxtDescripcion.Text.Trim()));
            cmd.Parameters.Add(new SqlParameter("@Comentario", txtComentario.Text.Trim()));
            cmd.Parameters.Add(new SqlParameter("@Tipo", MetroComboBox2.SelectedValue.ToString().Trim()));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        private void EliminarDiaFeriadoDB(DateTime fechaFeriado)
        {
            SqlConnection conn = conexion.sqlConexion;

            cmd = new SqlCommand("[Feriados_Info_Eliminar]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            cmd.Parameters.Add(new SqlParameter("@Fecha", fechaFeriado));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        private void CargarComboTipo()
        {
            dtTipos = new DataTable();
            dtTipos.Columns.Add("Tipo", typeof(String));
            dtTipos.Columns.Add("TipoDesc", typeof(String));

            dtTipos.Rows.Add("G", "General");
            dtTipos.Rows.Add("A", "Almuerzo");

            MetroComboBox2.DataSource = dtTipos.Copy();
            MetroComboBox2.DisplayMember = "TipoDesc";
            MetroComboBox2.ValueMember = "Tipo";
            MetroComboBox2.SelectedIndex = 0;
        }

        private void PopUp_MouseEnter(object sender, EventArgs e)
        {
            var Obj = (dynamic)sender;
            Obj.Left = Obj.Left - 3;
            Obj.Top = Obj.Top - 3;
            Obj.Height = Obj.Height + 6;
            Obj.Width = Obj.Width + 6;
        }
        private void PopUp_MouseLeave(object sender, EventArgs e)
        {
            var Obj = (dynamic)sender;
            Obj.Left = Obj.Left + 3;
            Obj.Top = Obj.Top + 3;
            Obj.Height = Obj.Height - 6;
            Obj.Width = Obj.Width - 6;
        }

        private void AgregarDiaFeriadoCalendario()
        {
            DateItem di = new DateItem();
            DateItem[] d2 = MonthCalendar3.GetDateInfo(DiaActual);
            string ftipo = MetroComboBox2.SelectedValue.ToString().Trim();

            if (d2.Length == 0)
            {
                di.Date = DiaActual;
                di.DateColor = Color.Black;
                di.BackColor1 = ftipo == "G" ? Color.FromArgb(0, 174, 219) : Color.FromArgb(78, 163, 26);
                di.Text = ftipo == "G" ? "FG" : "FA";
                di.TextColor = Color.White;
                di.DateColor = Color.White;

                MonthCalendar3.AddDateInfo(di);
                if (DiaActual == DateTime.Now.Date) MonthCalendar3.TodayColor = Color.FromArgb(80, 199, 230);
            }
        }

        private void EliminarDiasFeriado()
        {
            MonthCalendar3.RemoveDateInfo(DiaActual);
            if (DiaActual.Date == DateTime.Now.Date) MonthCalendar3.TodayColor = Color.Transparent;
        }

        private void CargarCalendario()
        {
            DateItem[] di2 = new DateItem[0];
            int index = 0;
            DataTable dtCalendario;

            dtCalendario = dtFeriados.ExecuteQuey(@"EXEC [SAC_Mindugar].[dbo].[Feriados_Info_Consultar] 
                                                  '" + InicioMesActual.ToString("yyyyMMdd") + "','" + FinMesActual.ToString("yyyyMMdd") + "'");

            Array.Resize(ref di2, index);
            di2.Initialize();

            try
            {
                if (dtCalendario.Rows.Count > 0)
                {
                    foreach (DataRow row in dtCalendario.Rows)
                    {
                        Array.Resize(ref di2, index + 1);
                        di2.Initialize();
                        di2[index] = new DateItem();
                        di2[index].Date = Convert.ToDateTime(row["Feriado"]);
                        di2[index].DateColor = Color.Black;
                        di2[index].BackColor1 = row["Tipo"].ToString().Trim() == "G" ? Color.FromArgb(0, 174, 219) : Color.FromArgb(78, 163, 26);
                        di2[index].Text = row["Tipo"].ToString().Trim() == "G" ? "FG" : "FA";
                        di2[index].TextColor = Color.White;
                        di2[index].DateColor = Color.White;

                        if (Convert.ToDateTime(row["Feriado"]) == DateTime.Now.Date) MonthCalendar3.TodayColor = Color.FromArgb(80, 199, 230);
                        index += 1;
                    }
                    if (di2.Length > 0) MonthCalendar3.AddDateInfo(di2);
                }
            }
            catch { }


        }

        private void MonthCalendar3_MonthChanged(object sender, MonthChangedEventArgs e)
        {
            int AñoInicial = AñoActual;
            
            MesActual = MonthCalendar3.ActiveMonth.Month;
            AñoActual = MonthCalendar3.ActiveMonth.Year;
            InicioMesActual = new DateTime(AñoActual, MesActual, 01);
            FinMesActual = new DateTime(AñoActual, MesActual, System.DateTime.DaysInMonth(AñoActual, MesActual));
            DiaActual = InicioMesActual;

            if (MonthCalendar3.ActiveMonth.Year != AñoInicial)
                CargarDiasFeriadosGrid();

            CargarCalendario();
        }

        private void Frm_DiasFeriados_LocationChanged(object sender, EventArgs e)
        {
            return;
        }
    }
}

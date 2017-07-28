﻿using System;
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
    public partial class FrmIndividualizacion : MetroFramework.Forms.MetroForm// Form
    {
        public delegate void EnvEvent();
        public event EnvEvent EnviarEvento;

        private DataGridViewRow IDInstrumento;
        private string AccionEnviada;
        private string FrecNuevo;
        private string FrecUsado;
        private int Cont;

        private AnimationManager _animationManager;

        public FrmIndividualizacion(DataGridViewRow IDInstrument, string Accion)
        {
            IDInstrumento = IDInstrument;
            AccionEnviada = Accion;
            FrecNuevo = "";
            FrecUsado = "";
            Cont = 0;
            InitializeComponent();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500, MaterialSkin.Primary.LightBlue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

        }

        private void FrmIndividualizacion_Load(object sender, EventArgs e)
        {
            CargaEncabezado();
            if (AccionEnviada == "Agregar")
            {
                CargaDatosNuevo();
            }
            else
            {
                btnAgregar.Text = "&Actualizar";
                CargaDatosActuales();
            }


        }

        private void FrmIndividualizacion_Paint(object sender, PaintEventArgs e)
        {
            //Visuales.FondoDegradado(this, e);
            //Visuales.LineaCabecera(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEmpleado Empleado = new FrmEmpleado();
            Empleado.EnvEmple += new FrmEmpleado.EnviarEmpleado(CargarDatosEmpleado); // Metodo Delegate para enviar datos desde FrmEmplado
            Empleado.ShowDialog();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstado.Text.Trim() != string.Empty)
            {
                errorIcono.SetError(cmbEstado, "");
                DateTime Fecha = AccionEnviada == "Agregar" ? Convert.ToDateTime(dtpIngreso.Text) : Convert.ToDateTime(txtUltCalib.Text);

                if (AccionEnviada == "Agregar" || Cont > 0)
                    dtpProxCalib.Text = Convert.ToString(Funciones.ProximaFechaCalibracion(Convert.ToInt32(IDInstrumento.Cells[0].Value), cmbEstado.Text.Trim(), Fecha));
                else
                    Cont += 1;

                if (cmbEstado.Text.Trim() == "Nuevo")
                    lblFrecuencia.Text = "Frecuencia: " + FrecNuevo;
                else
                    lblFrecuencia.Text = "Frecuencia: " + FrecUsado;
            }
        }

        private void txtCodEmp_TextChanged(object sender, EventArgs e)
        {
            if (txtCodEmp.Text.Trim() != string.Empty)
                errorIcono.SetError(txtCodEmp, "");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string rpta = "";

            if (ValidarCampos())
            {

                if (btnAgregar.Text == "&Agregar")
                {
                    rpta = NIdentInstrumento.Insertar(Convert.ToInt32(IDInstrumento.Cells[0].Value),
                                                        Convert.ToInt32(txtId.Text),
                                                        Convert.ToInt32(txtCalibra.Text),
                                                        Convert.ToDateTime(txtUltCalib.Text.Trim() == string.Empty ? "01/01/1900" : txtUltCalib.Text),
                                                        Convert.ToDateTime(dtpIngreso.Text),
                                                        Convert.ToString(cmbEstado.SelectedItem),
                                                        Convert.ToDateTime(dtpProxCalib.Text),
                                                        Convert.ToString(txtCodEmp.Text),
                                                        Convert.ToString(txtNomEmp.Text),
                                                        Convert.ToString(txtCertificado.Text),
                                                        Convert.ToString(txtMarca.Text));
                }
                else
                {
                    rpta = NIdentInstrumento.Actualizar(Convert.ToInt32(IDInstrumento.Cells[11].Value),
                                                        Convert.ToInt32(IDInstrumento.Cells[0].Value),
                                                        Convert.ToInt32(txtId.Text),
                                                        Convert.ToInt32(txtCalibra.Text),
                                                        Convert.ToDateTime(txtUltCalib.Text),
                                                        Convert.ToDateTime(dtpIngreso.Text),
                                                        Convert.ToString(cmbEstado.SelectedItem),
                                                        Convert.ToDateTime(dtpProxCalib.Text),
                                                        Convert.ToString(txtCodEmp.Text),
                                                        Convert.ToString(txtNomEmp.Text),
                                                        Convert.ToString(txtCertificado.Text),
                                                        Convert.ToString(txtMarca.Text));
                }
            }

            if (rpta == "OK")
            {
                EnviarEvento();
                btnCancelar.PerformClick();
            }
            else
            {
                MessageBox.Show(rpta, "Sistema de Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///  FUNCIONES Y PROCEDIMIENTOS
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CargaEncabezado()
        {
            DataTable DTInstru = new DataTable();
            DTInstru = NInstrumento.Buscar(Convert.ToInt32(IDInstrumento.Cells[0].Value));
            txtCodInstru.Text = Convert.ToString(DTInstru.Rows[0][1]);
            txtDescInstru.Text = Convert.ToString(DTInstru.Rows[0][2]);
            txtItemSelec.Text = txtCodInstru.Text.Trim() + "  -  " + txtDescInstru.Text.Trim();
            FrecNuevo = Convert.ToString(DTInstru.Rows[0][3]);
            FrecUsado = Convert.ToString(DTInstru.Rows[0][4]);

            if (txtItemSelec.Text.Trim().Length > 50)
            {
                txtItemSelec.Font = new Font("Segoe UI", 13, FontStyle.Bold, GraphicsUnit.Pixel);
                txtItemSelec.Top += 4;
            }

                txtCodInstru.Enabled = false;
            txtDescInstru.Enabled = false;

            txtCodInstru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtDescInstru.BackColor = System.Drawing.SystemColors.ControlLightLight;

        }

        public void CargarDatosEmpleado(string[] DatosEmpleado)
        {
            txtCodEmp.Text = DatosEmpleado[0];
            txtNomEmp.Text = DatosEmpleado[1];
        }

        private void CargaDatosNuevo()
        {
            txtId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtId.Text = Convert.ToString(CargaProximaIdentidad());
            txtCalibra.Text = Convert.ToString(NCalibracion.ProximoCodigoIndividual(Convert.ToInt32(IDInstrumento.Cells[0].Value), CargaProximaIdentidad()));
            txtCalibra.BackColor = System.Drawing.SystemColors.ControlLightLight;
        }

        private void CargaDatosActuales()
        {
            txtId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtId.Text = Convert.ToString(IDInstrumento.Cells[1].Value) ;
            txtCalibra.Text = Convert.ToString(IDInstrumento.Cells[2].Value);
            txtCalibra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtCodEmp.Text = Convert.ToString(IDInstrumento.Cells[4].Value);
            txtNomEmp.Text = Convert.ToString(IDInstrumento.Cells[5].Value);
            txtUltCalib.Text = Convert.ToDateTime(IDInstrumento.Cells[6].Value).ToString("dd/MM/yyyy");
            dtpIngreso.Text = Convert.ToString(IDInstrumento.Cells[7].Value);
            dtpProxCalib.Text = Convert.ToString(IDInstrumento.Cells[8].Value);
            txtCertificado.Text = Convert.ToString(IDInstrumento.Cells[9].Value);
            txtMarca.Text = Convert.ToString(IDInstrumento.Cells[10].Value);
            cmbEstado.SelectedItem = Convert.ToString(IDInstrumento.Cells[3].Value);
        }

        private int CargaProximaIdentidad()
        {
            return NIdentInstrumento.ProximoCodigoIndividual(Convert.ToInt32(IDInstrumento.Cells[0].Value));
        }
        
        private bool ValidarCampos()
        {
            bool valido = true;

            if (cmbEstado.SelectedIndex == -1)
            {
                errorIcono.SetError(cmbEstado, "Ingrese Un Estado");
                valido = false;
            }
            else if (txtCodEmp.Text.Trim() == String.Empty)
            {
                errorIcono.SetError(txtCodEmp, "Ingrese Un Responsable del Instrumento");
                valido = false;
            }
            //else if (txtCertificado.Text.Trim() == String.Empty)
            //{
            //    errorIcono.SetError(txtCertificado, "Ingrese Un Numero de Certificado");
            //    valido = false;
            //}
            //else if (txtMarca.Text.Trim() == String.Empty)
            //{
            //    errorIcono.SetError(txtMarca, "Ingrese la Marca Asociada al Instrumento");
            //    valido = false;
            //}

            return valido;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddTextBoxAnimation(TextBox sender)
        {
            sender.Refresh();
            TextBox _baseTextBox = sender;
            var g = Graphics.FromHwnd(sender.Handle);
            //g.Clear(Parent.BackColor);

            var lineY = _baseTextBox.Bottom - 3;
            Brush DIVIDERS_BLACK_BRUSH = new SolidBrush(Color.FromArgb(224, 224, 224));
            Brush PrimaryBrush = new SolidBrush(Color.FromArgb(255, 152, 0));


            if (!_animationManager.IsAnimating())
            {
                //No animation
                g.FillRectangle(_baseTextBox.Focused ? PrimaryBrush : DIVIDERS_BLACK_BRUSH, _baseTextBox.Location.X, lineY, _baseTextBox.Width, _baseTextBox.Focused ? 2 : 1);
            }
            else
            {
                //Animate
                int animationWidth = (int)(_baseTextBox.Width * _animationManager.GetProgress());
                int halfAnimationWidth = animationWidth / 2;
                int animationStart = _baseTextBox.Location.X + _baseTextBox.Width / 2;

                //Unfocused background
                g.FillRectangle(DIVIDERS_BLACK_BRUSH, _baseTextBox.Location.X, lineY, _baseTextBox.Width, 1);

                //Animated focus transition
                g.FillRectangle(PrimaryBrush, animationStart - halfAnimationWidth, lineY, animationWidth, 2);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Height -= 1;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, 152, 0);
            panel2.Height += 1;
        }
    }
}

using CapaNegocios.Logicas.Sistema;
using Presentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Sistema
{
    public partial class Empleado : Form
    {
        private EmpleadosLogica contexto;
        public Empleado()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Normal;
        }

        public void InicializarModulo()
        {
            LimpiarControles();
            InstanciarContexto();   
            ListarCatalogos();
            ListarRegistros();
        }

        public void LimpiarControles()
        {
            ThemeConfig.LimpiarControles(this);
        }

        public void ListarCatalogos()
        {
            contexto.ListarCatalogos();
            cbxPuesto.DataSource = contexto.LstPuesto;
            cbxPuesto.DisplayMember = "Nombre";
            cbxPuesto.ValueMember = "Id";
            cbxPuesto.SelectedIndex = -1;
            cbxEstado.DataSource = contexto.LstEstado;
            cbxEstado.DisplayMember = "Nombre";
            cbxEstado.SelectedIndex = -1;
            cbxEstado.ValueMember = "Id";

        }

        public void InstanciarContexto()
        {
            contexto = new EmpleadosLogica();
        }

        public void Guardar()
        {

            if (cbxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("El campo ESTADO es OBLIGATORIO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("El campo PUESTO es OBLIGATORIO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contexto.ObjEmpleado == null)
            {
                contexto.InstanciarEmpleado();
            }

            contexto.ObjPersona.Nombres = txtNombres.Text;  
            contexto.ObjPersona.ApellidoPaterno = txtApellidoPaterno.Text;
            contexto.ObjPersona.ApellidoMaterno = txtApellidoMaterno.Text;
            contexto.ObjPersona.FechaNacimiento = dtpFechaNacimiento.Value;

            contexto.ObjEmpleado.ESTADOId = (int)cbxEstado.SelectedValue;
            contexto.ObjEmpleado.PUESTOId = (int)cbxPuesto.SelectedValue;   
            contexto.ObjEmpleado.Rfc = txtRfc.Text;
            contexto.ObjEmpleado.FechaIngreso = dtpFechaIngreso.Value;
            contexto.Guardar();


            MessageBox.Show("Registro guardado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InicializarModulo();

        }

        private void Apariencias()
        {
            dgvRegistros.Columns[0].Visible = false;
            dgvRegistros.Columns[1].HeaderText = "RFC";
            dgvRegistros.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[2].HeaderText = "FECHA INGRESO";
            dgvRegistros.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[3].HeaderText = "ESTADO";
            dgvRegistros.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[4].Visible = false;
            dgvRegistros.Columns[5].HeaderText = "PUESTO";
            dgvRegistros.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[6].Visible = false;
            dgvRegistros.Columns[7].Visible = false;
            dgvRegistros.Columns[8].HeaderText = "NOMBRE(S)";
            dgvRegistros.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[8].HeaderText = "A. PATERNO";
            dgvRegistros.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[8].HeaderText = "A. MATERNO";
            dgvRegistros.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tsTotalRegistros.Text = contexto.LstEmpleado.Count.ToString("N0");

        }

        private void ListarRegistros()
        {
            dgvRegistros.DataSource = null;
            contexto.Listar();
            dgvRegistros.DataSource = contexto.LstEmpleado;
            Apariencias();
        }

        private void Empleado_Shown(object sender, EventArgs e)
        {
            ThemeConfig.ThemeControls(this);
            this.MaximizeBox = false;
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            InicializarModulo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarModulo();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

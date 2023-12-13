using CapaNegocios.Logicas.Venta;
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

namespace Presentacion.Ventas
{
    public partial class formClientes : Form
    {
        private formClientesLogica contexto;

        public formClientes()
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
            cbxEstado.DataSource = contexto.LstEstado;
            cbxEstado.DisplayMember = "Nombre";
            cbxEstado.SelectedIndex = -1;
            cbxEstado.ValueMember = "Id";

        }

        public void InstanciarContexto()
        {
            contexto = new formClientesLogica();
        }

        public void Guardar()
        {

            if (cbxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("El campo ESTADO es OBLIGATORIO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }          

            if (contexto.ObjClsCliente == null)
            {
                contexto.InstanciarCliente();
            }
            else
            {                
                contexto.ObjCliente = contexto.ObtenerCliente(contexto.ObjClsCliente.Id);
                contexto.ObjPersona = contexto.ObtenerPersona(contexto.ObjCliente.PERSONAId);
            }

            contexto.ObjPersona.Nombres = txtNombre.Text;
            contexto.ObjPersona.ApellidoPaterno = txtAPaterno.Text; 
            contexto.ObjPersona.ApellidoMaterno = txtAMaterno.Text;
            contexto.ObjPersona.FechaNacimiento = dtpFechaNacimiento.Value;

            contexto.ObjCliente.ESTADOId = (int)cbxEstado.SelectedValue;
            contexto.ObjCliente.RazonSocial = txtRazonSocial.Text;
            contexto.ObjCliente.RFC = txtRfc.Text;
            contexto.ObjCliente.FechaRegistro = DateTime.Now;
            contexto.ObjCliente.Clave = txtClave.Text;  
            contexto.Guardar();



            MessageBox.Show("Registro guardado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InicializarModulo();

        }

        private void Apariencias()
        {
            dgvRegistros.Columns[0].Visible = false;
            dgvRegistros.Columns[1].HeaderText = "CLAVE";
            dgvRegistros.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[2].HeaderText = "NOMBRE";
            dgvRegistros.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[3].Visible = false;
            dgvRegistros.Columns[4].Visible = false;
            dgvRegistros.Columns[5].Visible = false;
            dgvRegistros.Columns[6].HeaderText = "ESTADO";
            dgvRegistros.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[7].HeaderText = "RFC";
            dgvRegistros.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[8].HeaderText = "RAZON SOCIAL";
            dgvRegistros.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[9].Visible = false;
            dgvRegistros.Columns[10].HeaderText = "FECHA REGISTRO";
            dgvRegistros.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[11].Visible = false;
            dgvRegistros.Columns[12].Visible = false;

            tsTotalRegistros.Text = contexto.LstCliente.Count.ToString("N0");

        }

        private void ListarRegistros()
        {
            dgvRegistros.DataSource = null;
            contexto.Listar();
            dgvRegistros.DataSource = contexto.LstCliente;
            Apariencias();
        }

        private void filtrar(int column, string termino)
        {
            if (contexto.Filtrar(column, termino))
            {
                contexto.indexAux = contexto.index;
                dgvRegistros.Rows[contexto.index].Cells[column].Selected = true;
                dgvRegistros.FirstDisplayedScrollingRowIndex = contexto.index;
            }
        }

        private void ordenar(int column)
        {
            txtBuscar.Clear();
            txtBuscar.Focus();
            contexto.Ordenar(column);
            dgvRegistros.DataSource = contexto.LstClienteAux;
            Apariencias();
        }

        private void setData()
        {
            txtAMaterno.Text = contexto.ObjClsCliente.ApellidoMaterno;
            txtAPaterno.Text = contexto.ObjClsCliente.ApellidoPaterno;
            txtNombre.Text = contexto.ObjClsCliente.Nombres;
            txtRfc.Text = contexto.ObjClsCliente.RFC;
            cbxEstado.SelectedValue = contexto.ObjClsCliente.EstadoId;
            dtpFechaNacimiento.Value = contexto.ObjClsCliente.FechaNacimiento;
            txtFechaRegistro.Text = contexto.ObjClsCliente.FechaRegistro.ToString("dd-MM-yyyy");
            txtClave.Text = contexto.ObjClsCliente.Clave;
        }

        private void formClientes_Load(object sender, EventArgs e)
        {
            InicializarModulo();
        }

        private void formClientes_Shown(object sender, EventArgs e)
        {
            ThemeConfig.ThemeControls(this);
            this.MaximizeBox = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarModulo();
        }

        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contexto.Column == e.ColumnIndex) return;
            contexto.Column = e.ColumnIndex;
            ordenar(contexto.Column);
        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRegistros.DataSource == null) return;

            contexto.ObjClsCliente = contexto.ObtenerClienteData((int)dgvRegistros.CurrentRow.Cells[0].Value);

            setData();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (dgvRegistros.Rows.Count <= 0) return;

            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                contexto.index = -1;
                return;
            }

            filtrar(contexto.Column, txtBuscar.Text);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.DataSource == null) return;

            contexto.ObjClsCliente = contexto.ObtenerClienteData((int)dgvRegistros.CurrentRow.Cells[0].Value);

            setData();
        }
    }
}

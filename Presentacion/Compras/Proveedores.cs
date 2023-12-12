using CapaNegocios.Logicas.Compras;
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

namespace Presentacion.Compras
{
    public partial class Proveedores : Form
    {
        private ProveedoresLogica contexto;
        private int rowIndexSeleccionado = -1;
        public Proveedores()
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
            cbxEstado.ValueMember = "Id";
            cbxEstado.SelectedIndex = -1;            

        }

        public void InstanciarContexto()
        {
            contexto = new ProveedoresLogica();
        }

        public void Guardar()
        {

            if (cbxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("El campo ESTADO es OBLIGATORIO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contexto.ObjProveedor == null)
            {
                contexto.InstanciarProveedor();
            }

            contexto.ObjRepresentante.Nombres = txtNombres.Text;
            contexto.ObjRepresentante.ApellidoPaterno = txtAPaterno.Text;
            contexto.ObjRepresentante.ApellidoMaterno = txtAMaterno.Text;
            contexto.ObjRepresentante.FechaNacimiento = dtpFechaNacimiento.Value;

            contexto.ObjProveedor.Clave = txtClave.Text;           
            contexto.ObjProveedor.RazonSocial = txtRazonSocial.Text;
            contexto.ObjProveedor.FechaRegistro = DateTime.Now;
            contexto.ObjProveedor.ESTADOId = (int)cbxEstado.SelectedValue;

            contexto.Guardar();


            MessageBox.Show("Registro guardado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InicializarModulo();

        }

        private void Apariencias()
        {
            dgvRegistros.Columns[0].Visible = false;
            dgvRegistros.Columns[1].HeaderText = "CLAVE";
            dgvRegistros.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[2].HeaderText = "RAZÓN SOCIAL";
            dgvRegistros.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[3].HeaderText = "ESTADO";
            dgvRegistros.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[4].Visible = false;


            tsTotalRegistros.Text = contexto.LstProveedor.Count.ToString("N0");

        }

        private void ListarRegistros()
        {
            dgvRegistros.DataSource = null;
            contexto.ListarProveedores();
            dgvRegistros.DataSource = contexto.LstProveedor;
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
            dgvRegistros.DataSource = contexto.LstProveedorAux;
            Apariencias();
        }

        private void Modificar()
        {
            if (dgvRegistros.DataSource == null) return;
            rowIndexSeleccionado = (int)dgvRegistros.CurrentRow.Cells[0].Value;
            contexto.ObjProveedor = contexto.ObtenerProveedor(rowIndexSeleccionado);
            if (contexto.ObjProveedor != null)
            {
                txtClave.Text = contexto.ObjProveedor.Clave;
                txtFechaRegistro.Text = contexto.ObjProveedor.FechaRegistro.ToString("dd/MM/yyyy");
                txtRazonSocial.Text = contexto.ObjProveedor.RazonSocial.TrimEnd();
                cbxEstado.SelectedValue = contexto.ObjProveedor.ESTADOId;
                contexto.ObjRepresentante = contexto.ObjProveedor.PERSONA;
                txtNombres.Text = contexto.ObjRepresentante.Nombres;
                txtAPaterno.Text = contexto.ObjRepresentante.ApellidoPaterno;
                txtAMaterno.Text = contexto.ObjRepresentante.ApellidoMaterno;
                dtpFechaNacimiento.Value = contexto.ObjRepresentante.FechaNacimiento;
                
            }
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

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar();
        }

        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contexto.Column == e.ColumnIndex) return;
            contexto.Column = e.ColumnIndex;
            ordenar(contexto.Column);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarModulo();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            InicializarModulo();
        }

        private void Proveedores_Shown(object sender, EventArgs e)
        {
            ThemeConfig.ThemeControls(this);
            this.MaximizeBox = false;
        }
    }
}

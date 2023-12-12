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
    public partial class Marcas : Form
    {
        private int _idProveedorSeleccionado = 0;
        private MarcaLogica contexto;
        private int rowIndexSeleccionado = -1;
        public Marcas()
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
            contexto = new MarcaLogica();
        }

        public void Guardar()
        {

            if (cbxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("El campo ESTADO es OBLIGATORIO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           

            if (contexto.ObjMarca == null)
            {
                contexto.InstanciarMarca();
            }

            if (_idProveedorSeleccionado <= 0)
            {
                MessageBox.Show("No ha seleccionado ningún EMPLEADO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            contexto.ObjMarca.PROVEEDORId = _idProveedorSeleccionado;
            contexto.ObjMarca.Nombre = txtNombre.Text;
            contexto.ObjMarca.Clave = txtClave.Text;
            contexto.ObjMarca.FechaRegistro = DateTime.Now;
            contexto.ObjMarca.ESTADOId = (int)cbxEstado.SelectedValue;
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
            dgvRegistros.Columns[3].HeaderText = "PROVEEDOR";
            dgvRegistros.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[4].HeaderText = "ESTADO";
            dgvRegistros.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[5].Visible = false;


            tsTotalRegistros.Text = contexto.LstMarca.Count.ToString("N0");

        }

        private void ListarRegistros()
        {
            dgvRegistros.DataSource = null;
            contexto.ListarMarca();
            dgvRegistros.DataSource = contexto.LstMarca;
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
            dgvRegistros.DataSource = contexto.LstMarca;
            Apariencias();
        }

        private void Modificar()
        {
            if (dgvRegistros.DataSource == null) return;
            rowIndexSeleccionado = (int)dgvRegistros.CurrentRow.Cells[0].Value;
            contexto.ObjMarca = contexto.ObtenerMarca(rowIndexSeleccionado);
            if (contexto.ObjMarca != null)
            {
                _idProveedorSeleccionado = contexto.ObjMarca.PROVEEDORId;
                txtClave.Text = contexto.ObjMarca.Clave;
                txtFechaRegistro.Text = contexto.ObjMarca.FechaRegistro.ToString("dd/MM/yyyy");
                txtNombre.Text = contexto.ObjMarca.Nombre;
                cbxEstado.SelectedValue = contexto.ObjMarca.ESTADOId;
                txtRazonSocial.Text = contexto.ObjMarca.PROVEEDOR.RazonSocial;
               
            }
        }


        private void Marcas_Load(object sender, EventArgs e)
        {
            InicializarModulo();
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contexto.Column == e.ColumnIndex) return;
            contexto.Column = e.ColumnIndex;
            ordenar(contexto.Column);
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            var bus = new Busquedas.busPROVEEDORES();
            bus.ShowDialog();
            if (bus.ObjEntidad == null)
            {
                MessageBox.Show("No se selecciono ningún registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (bus.ObjEntidad.EstadoId == 8)//esto varia segun la captura del registro
            {
                MessageBox.Show("El registro seleccionado esta DESACTIVADO.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtRazonSocial.Text = bus.ObjEntidad.RazonSocial;
            _idProveedorSeleccionado = bus.ObjEntidad.Id;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarModulo();
        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar();
        }

        private void Marcas_Shown(object sender, EventArgs e)
        {
            ThemeConfig.ThemeControls(this);
            this.MaximizeBox = false;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar();
        }
    }
}

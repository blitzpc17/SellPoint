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
    public partial class Usuarios : Form
    {
        private int _idEmpleadoSeleccionado=0;
        private UsuarioLogica contexto;
        private int rowIndexSeleccionado = -1;
        public Usuarios()
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
            cbxEstados.DataSource = contexto.LstEstado;
            cbxEstados.DisplayMember = "Nombre";
            cbxEstados.ValueMember = "Id";
            cbxEstados.SelectedIndex = -1;
            cbxRoles.DataSource = contexto.LstRol;
            cbxRoles.DisplayMember = "Nombre";            
            cbxRoles.ValueMember = "Id";
            cbxRoles.SelectedIndex = -1;

        }

        public void InstanciarContexto()
        {
            contexto = new UsuarioLogica();
        }

        public void Guardar()
        {

            if (cbxEstados.SelectedIndex == -1)
            {
                MessageBox.Show("El campo ESTADO es OBLIGATORIO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbxRoles.SelectedIndex == -1)
            {
                MessageBox.Show("El campo ROLES es OBLIGATORIO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contexto.ObjUsuario == null)
            {
                contexto.InstanciarUsuario();
            }

            if (_idEmpleadoSeleccionado <= 0)
            {
                MessageBox.Show("No ha seleccionado ningún EMPLEADO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            contexto.ObjUsuario.EMPLEADOId = _idEmpleadoSeleccionado;
            contexto.ObjUsuario.Alias = txtAlias.Text;
            contexto.ObjUsuario.Password = txtPassword.Text;    
            contexto.ObjUsuario.FechaRegistro = DateTime.Now;
            contexto.ObjUsuario.ESTADOId = (int)cbxEstados.SelectedValue;
            contexto.ObjUsuario.ROLId = (int)cbxRoles.SelectedValue;
            contexto.Guardar();


            MessageBox.Show("Registro guardado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InicializarModulo();

        }

        private void Apariencias()
        {
            dgvRegistros.Columns[0].Visible = false;
            dgvRegistros.Columns[1].HeaderText = "ALIAS";
            dgvRegistros.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[2].HeaderText = "ROL";
            dgvRegistros.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[3].HeaderText = "ESTADO";
            dgvRegistros.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           

            tsTotalRegistros.Text = contexto.LstUsuario.Count.ToString("N0");

        }

        private void ListarRegistros()
        {
            dgvRegistros.DataSource = null;
            contexto.ListarUsuarios();
            dgvRegistros.DataSource = contexto.LstUsuario;
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
            dgvRegistros.DataSource = contexto.LstUsuario;
            Apariencias();
        }

        private void Modificar()
        {
            if (dgvRegistros.DataSource == null) return;
            rowIndexSeleccionado = (int)dgvRegistros.CurrentRow.Cells[0].Value;
            contexto.ObjUsuario = contexto.ObtenerUsuario(rowIndexSeleccionado);
            if (contexto.ObjUsuario != null)
            {
                _idEmpleadoSeleccionado = contexto.ObjUsuario.EMPLEADOId;
                txtAlias.Text = contexto.ObjUsuario.Alias;
                txtFechaRegistro.Text = contexto.ObjUsuario.FechaRegistro.ToString("dd/MM/yyyy");
                txtPassword.Text = contexto.ObjUsuario.Password;
                cbxEstados.SelectedValue = contexto.ObjUsuario.ESTADOId;
                cbxRoles.SelectedValue = contexto.ObjUsuario.ROLId;
                txtEmpleado.Text = contexto.ObjUsuario.EMPLEADO.PERSONA.Nombres + " " + contexto.ObjUsuario.EMPLEADO.PERSONA.ApellidoPaterno + " " + contexto.ObjUsuario.EMPLEADO.PERSONA.ApellidoMaterno;
            }
        }

        private void Usuarios_Shown(object sender, EventArgs e)
        {
            ThemeConfig.ThemeControls(this);
            this.MaximizeBox = false;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            var bus = new Busquedas.busEMPLEADOS();
            bus.ShowDialog();
            if (bus.ObjEntidad == null)
            {
                MessageBox.Show("No se selecciono ningún registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if (bus.ObjEntidad.EstadoId == 2)//esto varia segun la captura del registro
            {
                MessageBox.Show("El registro seleccionado esta DESACTIVADO.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtEmpleado.Text = (bus.ObjEntidad.Nombres+" "+bus.ObjEntidad.ApellidoPaterno+" "+bus.ObjEntidad.ApellidoMaterno);
            _idEmpleadoSeleccionado = bus.ObjEntidad.EmpleadoId;

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

        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contexto.Column == e.ColumnIndex) return;
            contexto.Column = e.ColumnIndex;
            ordenar(contexto.Column);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarModulo();    
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            InicializarModulo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar();
        }
    }
}

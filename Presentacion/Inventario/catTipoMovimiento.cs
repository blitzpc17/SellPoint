using CapaNegocios.Logicas.Inventario;
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

namespace Presentacion.Inventario
{
    public partial class catTipoMovimiento : Form
    {
        private TipoMovimientoLogica contexto;
        public catTipoMovimiento()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Normal;
        }
        private void InicializarForm()
        {
            LimpiarControles();
            InstanciarContextos();
            ListarRegistros();
            cbxTipo.SelectedIndex = 0;
            contexto.Column = 1;
        }

        private void InstanciarContextos()
        {
            contexto = new TipoMovimientoLogica();
        }

        private void LimpiarControles()
        {
            ThemeConfig.LimpiarControles(this);
        }

        private void Apariencias()
        {
            dgvRegistros.Columns[0].Visible = false;
            dgvRegistros.Columns[1].HeaderText = "Nombre";
            dgvRegistros.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[2].HeaderText = "Tipo";
            dgvRegistros.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRegistros.Columns[3].HeaderText = "Estado";
            dgvRegistros.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tsTotalRegistros.Text = contexto.LstTIPO_MOVIMIENTO.Count.ToString("N0");
        }

        private void ListarRegistros()
        {
            dgvRegistros.DataSource = null;
            contexto.LstTIPO_MOVIMIENTO = contexto.ListarTipos();
            dgvRegistros.DataSource = contexto.LstTIPO_MOVIMIENTO;
            Apariencias();
        }

        private void Guardar()
        {
            if (cbxTipo.SelectedIndex == 0)
            {
                MessageBox.Show("No asigno el TIPO.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo NOMBRE es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contexto.ObjTipoMov == null)
            {
                contexto.InstanciarTIPO_MOVIMIENTO();
            }            

            contexto.ObjTipoMov.Nombre = txtNombre.Text;
            contexto.ObjTipoMov.Tipo = cbxTipo.SelectedIndex==1?true:false;

            contexto.Guardar();

            MessageBox.Show("Registro guardado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InicializarForm();

        }

        private void catRoles_Load(object sender, EventArgs e)
        {
            InicializarForm();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            
        }

        private void catRoles_Shown(object sender, EventArgs e)
        {
            ThemeConfig.ThemeControls(this);
            this.MaximizeBox = false;
        }

        private void filtrar(int column, string termino)
        {
            if (contexto.Filtrar(column, termino))
            {
                contexto.indexAux = contexto.index;          
                dgvRegistros.FirstDisplayedScrollingRowIndex = contexto.index;
                dgvRegistros.Rows[contexto.index].Selected = true;
            }
        }

        private void ordenar(int column)
        {
            contexto.Ordenar(column);
            dgvRegistros.DataSource = contexto.LstTIPO_MOVIMIENTOAux;
            Apariencias();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (dgvRegistros.Rows.Count <= 0) return;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                contexto.index = -1;
                return;
            }

            filtrar(contexto.Column, txtNombre.Text);
        }

        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contexto.Column == e.ColumnIndex) return;
            contexto.Column = e.ColumnIndex;
            ordenar(contexto.Column);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarForm();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.DataSource == null) return;

            contexto.ObjTipoMov = contexto.Obtener((int)dgvRegistros.CurrentRow.Cells[0].Value);

            setData();
        }

        private void setData()
        {
            if (contexto.ObjTipoMov != null)
            {
                txtNombre.Text = contexto.ObjTipoMov.Nombre.ToString();
                cbxTipo.SelectedIndex = contexto.ObjTipoMov.Tipo ? 1 : 2;
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.DataSource == null) return;

            if (MessageBox.Show("Se cambiará el estado del registro. ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                EliminarRegistro();
                InicializarForm();
            }
        }

        private void EliminarRegistro()
        {
            contexto.ObjTipoMov = contexto.Obtener((int)dgvRegistros.CurrentRow.Cells[0].Value);
            contexto.ObjTipoMov.Baja = !contexto.ObjTipoMov.Baja;
            contexto.Guardar();
            MessageBox.Show("Registro "+(contexto.ObjTipoMov.Baja?"ACTIVADO":"DESACTIVADO") +" correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

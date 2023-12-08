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
    public partial class catRoles : Form
    {
        private catRolesLogica contexto;
        public catRoles()
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
        }

        private void InstanciarContextos()
        {
            contexto = new catRolesLogica();
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
            dgvRegistros.Columns[2].Visible = false;
            tsTotalRegistros.Text = contexto.LstRol.Count.ToString("N0");

            contexto.Column = 1;

        }

        private void ListarRegistros()
        {
            dgvRegistros.DataSource = null;
            contexto.Listar();
            dgvRegistros.DataSource = contexto.LstRol;
            Apariencias();  
        }

        private void Guardar()
        {
            if (contexto.ObjRol == null)
            {
                contexto.InstanciarRol();
            }

            contexto.ObjRol.Nombre = txtNombre.Text;

            contexto.Guardar();


        }

        private void catRoles_Load(object sender, EventArgs e)
        {
            InicializarForm();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            InicializarForm();
        }

        private void catRoles_Shown(object sender, EventArgs e)
        {
            ThemeConfig.ThemeControls(this);
            this.MaximizeBox = false;
        }

        private void filtrar(int column, string termino)
        {
            if(contexto.Filtrar(column, termino))
            {
                contexto.indexAux = contexto.index;
                dgvRegistros.FirstDisplayedScrollingRowIndex = contexto.index;
                // dgvRegistros.Rows[contexto.indexAux].Selected = false;
                // dgvRegistros.Rows[contexto.index].Selected = true;
            }
            else
            {
                txtNombre.Text = termino.Substring(0, termino.Length - 1);
            }
        }

        private void ordenar(int column)
        {
            contexto.Ordenar(column);
            dgvRegistros.DataSource = contexto.LstRolAux;
            Apariencias();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            filtrar(contexto.Column, txtNombre.Text);
        }

        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contexto.Column = e.ColumnIndex;
            ordenar(contexto.Column);   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarForm();
        }
    }
}

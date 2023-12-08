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
    public partial class MDIMain : Form
    {
        private int childFormNumber = 0;

        public MDIMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void rOLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catRoles cat = new catRoles();
            cat.MdiParent = this;
            cat.Show();
        }

        private void pUESTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catPuestos cat = new catPuestos();
            cat.MdiParent = this;
            cat.Show();
        }

        private void eSTADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catEstados cat = new catEstados();
            cat.MdiParent = this;
            cat.Show();
        }

        private void capturaYConsultaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Usuarios form = new Usuarios();
            form.MdiParent = this;
            form.Show();
        }

        private void capturaYConsultaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Empleado form = new Empleado();
            form.MdiParent = this;
            form.Show();
        }

        private void modulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulo form = new Modulo();
            form.MdiParent = this;
            form.Show();
        }

        private void moduloPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuloPermisos form = new ModuloPermisos();
            form.MdiParent = this;
            form.Show();
        }

        private void controlPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlPermisos form = new ControlPermisos();
            form.MdiParent = this;
            form.Show();
        }

        private void capturaYConsultaToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Modulo form = new Modulo();
            form.MdiParent = this;
            form.Show();
        }
    }
}

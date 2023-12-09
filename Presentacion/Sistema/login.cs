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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Shown(object sender, EventArgs e)
        {
            ThemeConfig.ThemeControls(this);
            this.MaximizeBox = false;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            MDIMain mDIMain = new MDIMain();
            Hide();
            mDIMain.WindowState = FormWindowState.Maximized;
            mDIMain.ShowDialog();
            Close();
            
        }
    }
}

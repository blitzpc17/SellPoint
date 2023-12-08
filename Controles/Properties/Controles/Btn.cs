
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Controles
{
    public class Btn:Button
    {
        public Btn()
        {
            CargarTheme();

        }

        private void CargarTheme()
        {
            BackColor = ThemeConfig.Secundario;
            Width = 110;
            Height = 35;
            FlatStyle = FlatStyle.Flat;
        }
    }
}

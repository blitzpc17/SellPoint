using Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls.Controles
{
    public class Btn:Button
    {
        public Btn()
        {
            CargarTheme();

        }

        private void CargarTheme()
        {
            BackColor = ThemeColors.Secundario;
            Width = 110;
            Height = 35;
            FlatStyle = FlatStyle.Flat;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls.Controles
{
    public class Lbl:Label
    {
        public Lbl()
        {
            CargarTheme();
        }

        public void CargarTheme()
        {
            Width = 110;
            Height = 30;
            ForeColor = ThemeColors.Enfasis;
        }
    }
}

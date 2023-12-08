using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls.Controles
{
    public class Txt:TextBox
    {
        public Txt()
        {
            CargarTheme();
        }

        public void CargarTheme()
        {
            Width = 210;
            Height = 30;
        }
    }
}

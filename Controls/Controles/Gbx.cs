using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls.Controles
{
    public class Gbx : GroupBox
    {
        public Gbx(){

            CargarTheme();
        
        }


        private void CargarTheme()
        {
            ForeColor = ThemeColors.Enfasis;              
        }
    }
}

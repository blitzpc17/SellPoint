using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Utilidades
{
    public static class ThemeConfig
    {
        public static Color Principal = Color.FromArgb(34, 34, 103);
        public static Color Secundario = Color.FromArgb(32, 33, 79);
        public static Color Enfasis = Color.FromArgb(239, 174, 215);

        public static void ThemeControls(Form frm)
        {
            frm.ForeColor = Enfasis;
            frm.BackColor = Principal;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Normal;

            foreach (Control ctrl in frm.Controls)
            {
                if(ctrl is GroupBox)
                {
                    ((GroupBox)ctrl).ForeColor = Enfasis;

                    if (((GroupBox)ctrl).Controls.Count > 0)
                    {
                        foreach(Control ctrlG in ((GroupBox)ctrl).Controls)
                        {
                            if(ctrlG is Label)
                            {
                                ((Label)ctrlG).ForeColor = Enfasis;
                                ((Label)ctrlG).BackColor = Principal;   
                            }
                            else if(ctrlG is Button)
                            {
                                ((Button)ctrlG).BackColor = Secundario;
                                ((Button)ctrlG).Padding = new Padding(3, 0, 3, 0);
                            }
                            else if(ctrlG is ToolStrip)
                            {
                                ((ToolStrip)ctrlG).ForeColor=Enfasis;
                                ((ToolStrip)ctrlG).BackColor = Secundario;
                            }else if (ctrlG is DataGridView )
                            {
                                ((DataGridView)ctrlG).BackgroundColor = Secundario;
                                ((DataGridView)ctrlG).ForeColor = Secundario;
                                ((DataGridView)ctrlG).MultiSelect = false;

                                if (((DataGridView)ctrlG).ContextMenuStrip != null)
                                {
                                    ((DataGridView)ctrlG).ContextMenuStrip.BackColor = Secundario;
                                    ((DataGridView)ctrlG).ContextMenuStrip.ForeColor = Enfasis;
                                }
                            }else if(ctrlG is TextBox)
                            {
                                ((TextBox)ctrlG).CharacterCasing = CharacterCasing.Upper;
                            }
                        }
                    }

                }
                else if (ctrl is Button)
                {
                    ((Button)ctrl).BackColor = Secundario;
                    ((Button)ctrl).ForeColor=Enfasis;
                    ((Button)ctrl).Padding = new Padding(3, 0, 3, 0);
                }
                else if(ctrl is ContextMenuStrip)
                {
                    ((ContextMenuStrip)ctrl).BackColor = Secundario;
                    ((ContextMenuStrip)ctrl).ForeColor = Enfasis;
                }
            }
        }

        public static void LimpiarControles(Form frm)
        {
            foreach(Control ctrl in frm.Controls)
            {
                if(ctrl is GroupBox)
                {
                    foreach (Control ctrlG in ((GroupBox)ctrl).Controls)
                    {
                        if(ctrlG is TextBox)
                        {
                            ((TextBox)ctrlG).Clear();
                        }
                    }
                }
            }
        }


    }
}

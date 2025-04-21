using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Facturacion_Farmacia.utilidades
{
    internal class EstilosGenerales
    {

        public void PanelAzulOscuro(Panel panel)
        {
            panel.BackColor = System.Drawing.ColorTranslator.FromHtml("#477A8F");
        }

        public void PanelAzulCentral(Panel panel)
        {
            panel.BackColor = System.Drawing.ColorTranslator.FromHtml("#89D6F7");
        }

        public void LabelBlanco(Label label)
        {
            label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
        }

        public void LabelNegro(Label label)
        {
            label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        }
        /*
        public void HeredarEventosDelPanel(Panel panel, Label label)
        {
            label.MouseEnter += (s, e) => panel.OnMouseEnter(e);
            label.MouseLeave += (s, e) => panel.OnMouseLeave(e);
            label.Click += (s, e) => panel.OnClick(e);
        }
        */
    }
}

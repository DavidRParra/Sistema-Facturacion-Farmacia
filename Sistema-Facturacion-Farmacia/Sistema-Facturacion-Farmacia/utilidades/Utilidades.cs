using Sistema_Facturacion_Farmacia.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Facturacion_Farmacia.utilidades
{
    internal class Utilidades
    {

        public void MostrarPanel(Panel panel, Form form)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            panel.Controls.Add(form);
            form.Show();
        }
    }
}

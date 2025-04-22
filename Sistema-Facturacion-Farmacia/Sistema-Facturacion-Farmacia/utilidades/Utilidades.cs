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
        EstilosGenerales style=new EstilosGenerales();
        public void MostrarPanel(Panel panel, Form form, List<Panel> lista, Panel panel2)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            panel.Controls.Add(form);
            form.Show();
            lista.Remove(panel2);
            foreach (Panel item in lista ) {
                System.Console.WriteLine(item);
                style.PanelAzulCentral(item);
                Label label = item.Controls.OfType<Label>().FirstOrDefault();
                style.LabelNegro(label);
            }
            lista.Add(panel2);
        }

        public void LimpiarTextBox(List<TextBox> lista)
        {
            foreach (TextBox item in lista) {
                item.Clear();
            }
        }
    }
}

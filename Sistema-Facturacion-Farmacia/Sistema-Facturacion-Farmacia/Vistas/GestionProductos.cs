using Sistema_Facturacion_Farmacia.Vistas.SubVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Facturacion_Farmacia.Vistas
{
    public partial class GestionProductos : Form
    {
        public GestionProductos()
        {
            InitializeComponent();
        }

        private void btn_AgregarLaboratorio_Click(object sender, EventArgs e)
        {
            AgregarLaboratorio form = new AgregarLaboratorio();
            form.ShowDialog();
        }

        private void btn_AgregarCategoria_Click(object sender, EventArgs e)
        {
            AgregarCategoria form = new AgregarCategoria();
            form.ShowDialog();
        }
    }
}

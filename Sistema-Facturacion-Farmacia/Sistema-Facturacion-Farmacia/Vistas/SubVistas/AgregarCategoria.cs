﻿using Sistema_Facturacion_Farmacia.utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Facturacion_Farmacia.Vistas.SubVistas
{
    public partial class AgregarCategoria : Form
    {
        private Imagen img = new Imagen();
        public AgregarCategoria()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            img.Img_PictureBox(Cerrar_IMG, img.CERRAR);
            img.Img_PictureBox(Logo_IMG, img.LOGO_SALUD);
        }

        private void Cerrar_IMG_MouseEnter(object sender, EventArgs e)
        {
            img.Agrandar_PictureBox(Cerrar_IMG);
        }

        private void Cerrar_IMG_MouseLeave(object sender, EventArgs e)
        {
            img.Redimensionar_PictureBox(Cerrar_IMG);
        }

        private void Cerrar_IMG_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

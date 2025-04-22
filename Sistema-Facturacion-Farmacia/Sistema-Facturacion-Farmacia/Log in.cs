using Sistema_Facturacion_Farmacia.utilidades;
using Sistema_Facturacion_Farmacia.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Facturacion_Farmacia
{
    public partial class Form1 : Form
    {
        Imagen img = new Imagen();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            img.Img_PictureBox(User_IMG, img.USUARIO);
            img.Img_PictureBox(Logo_IMG, img.LOGO_SALUD);
            img.Img_PictureBox(Cerrar_IMG, img.CERRAR);
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
            Application.Exit();
        }

        private void btn_RegistrarUsuario_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            
            registro.Show();
            this.Close();

            

        }

        private void btn_InicioSesion_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Facturacion_Farmacia.utilidades
{
    internal class Imagen
    {
        public Image CERRAR = Properties.Resources.cerrar;
        public Image CERRAR_SESION = Properties.Resources.cerrar_sesion;
        public Image LOGO_SALUD = Properties.Resources.LogoSalud;
        public Image MINIMIZAR = Properties.Resources.minimizar_signo;
        public Image USUARIO = Properties.Resources.usuario;
        public Image INICIO = Properties.Resources.capsula;



        public void Img_PictureBox(PictureBox pictureBox, Image imagen)
        {
            if (imagen == null)
            {
                MessageBox.Show($"La imagen de la imagen no existe o no se encuentra");
                return;
            }

            if (pictureBox.Image != null) 
            { 
                pictureBox.Image.Dispose();
            }


            try {
                
                Image imagenRedimensionada = new Bitmap(imagen, pictureBox.Width, pictureBox.Height);

                pictureBox.Image = imagenRedimensionada;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                
            } catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Agrandar_PictureBox(PictureBox pictureBox)
        {
            int h = pictureBox.Height;
            int w = pictureBox.Width;
            int centroX = pictureBox.Left + w / 2;
            int centroY = pictureBox.Top + h / 2;

            pictureBox.Size = new Size(w + 4, h + 4);

            pictureBox.Left = centroX - pictureBox.Width / 2;
            pictureBox.Top = centroY - pictureBox.Height / 2;
        }

        public void Redimensionar_PictureBox(PictureBox pictureBox)
        {
            int h = pictureBox.Height;
            int w = pictureBox.Width;
            int centroX = pictureBox.Left + w / 2;
            int centroY = pictureBox.Top + h / 2;

            pictureBox.Size = new Size(w - 4, h - 4);

            pictureBox.Left = centroX - pictureBox.Width / 2;
            pictureBox.Top = centroY - pictureBox.Height / 2;
        }
    }
}

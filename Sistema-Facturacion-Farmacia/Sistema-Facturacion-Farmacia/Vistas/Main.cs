using Sistema_Facturacion_Farmacia.utilidades;
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
    public partial class Main : Form
    {
        private EstilosGenerales style = new EstilosGenerales();
        private Imagen img= new Imagen();
        private Utilidades utilidades = new Utilidades();
        private Boolean facturar_producto = false;
        private Boolean gestion_clientes = false;
        private Boolean gestion_productos = false;
        private Boolean gestion_facturas = false;
        private Boolean gestion_proveedores = false;
        private Boolean ver_datos = false;

        private List<Panel> panel = new List<Panel>();
        
        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            img.Img_PictureBox(Logo_IMG, img.LOGO_SALUD);
            img.Img_PictureBox(Cerrar_IMG, img.CERRAR);
            img.Img_PictureBox(CerrarSesion_IMG, img.CERRAR_SESION);
            img.Img_PictureBox(Inicio_IMG, img.INICIO);

            //Agregar paneles al List<Panele> panel
            panel.Add(Panel_FacturarProducto);
            panel.Add(Panel_GestionClientes);
            panel.Add(Panel_GestionFacturas);
            panel.Add(Panel_GestionProductos);
            panel.Add(Panel_GestionProveedores);
            panel.Add(Panel_VerDatos);
            
            //Heredando controladores a los Label de cada Panel del menu de opciones
            foreach (Control ctrl in Panel_FacturarProducto.Controls)
            {
                ctrl.MouseEnter += Panel_FacturarProducto_MouseEnter;
                ctrl.MouseLeave += Panel_FacturarProducto_MouseLeave;
                ctrl.Click += Panel_FacturarProducto_Click;
            }

            foreach (Control ctrl in Panel_GestionProductos.Controls)
            {
                ctrl.MouseEnter += Panel_GestionProductos_MouseEnter;
                ctrl.MouseLeave += Panel_GestionProductos_MouseLeave;
                ctrl.Click += Panel_GestionProductos_Click;
            }

            foreach (Control ctrl in Panel_GestionClientes.Controls)
            {
                ctrl.MouseEnter += Panel_GestionClientes_MouseEnter;
                ctrl.MouseLeave += Panel_GestionClientes_MouseLeave;
                ctrl.Click += Panel_GestionClientes_Click;

            }

            foreach (Control ctrl in Panel_GestionFacturas.Controls)
            {
                ctrl.MouseEnter += Panel_GestionFacturas_MouseEnter;
                ctrl.MouseLeave += Panel_GestionFacturas_MouseLeave;
                ctrl.Click += Panel_GestionFacturas_Click;
            }

            foreach (Control ctrl in Panel_GestionProveedores.Controls)
            {
                ctrl.MouseEnter += Panel_GestionProveedores_MouseEnter;
                ctrl.MouseLeave += Panel_GestionProveedores_MouseLeave;
                ctrl.Click += Panel_GestionProveedores_Click;
            }

            foreach (Control ctrl in Panel_VerDatos.Controls)
            {
                ctrl.MouseEnter += Panel_VerDatos_MouseEnter;
                ctrl.MouseLeave += Panel_VerDatos_MouseLeave;
                ctrl.Click += Panel_VerDatos_Click;
            }

            foreach (Control ctrl in Panel_CerrarSesion.Controls)
            {
                ctrl.MouseEnter += Panel_CerrarSesion_MouseEnter;
                ctrl.MouseLeave += Panel_CerrarSesion_MouseLeave;
                ctrl.Click += Panel_CerrarSesion_Click;
            }
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

        private void Panel_FacturarProducto_MouseEnter(object sender, EventArgs e)
        {
            if (!facturar_producto) 
            {
                style.PanelAzulOscuro(Panel_FacturarProducto);
                style.LabelBlanco(lb_FacturarProducto);
            }
            
        }

        private void Panel_FacturarProducto_MouseLeave(object sender, EventArgs e)
        {
            if (!facturar_producto)
            {
                style.PanelAzulCentral(Panel_FacturarProducto);
                style.LabelNegro(lb_FacturarProducto);
            }
            
        }

        private void Panel_GestionClientes_MouseEnter(object sender, EventArgs e)
        {
            if (!gestion_clientes)
            {
                style.PanelAzulOscuro(Panel_GestionClientes);
                style.LabelBlanco(lb_GestionClientes);
            }
            
        }

        private void Panel_GestionClientes_MouseLeave(object sender, EventArgs e)
        {
            if (!gestion_clientes)
            {
                style.PanelAzulCentral(Panel_GestionClientes);
                style.LabelNegro(lb_GestionClientes);
            }
        }

        private void Panel_GestionFacturas_MouseEnter(object sender, EventArgs e)
        {
            if (!gestion_facturas)
            {
                style.PanelAzulOscuro(Panel_GestionFacturas);
                style.LabelBlanco(lb_GestionFacturas);
            }
            
        }

        private void Panel_GestionFacturas_MouseLeave(object sender, EventArgs e)
        {
            if (!gestion_facturas)
            {
                style.PanelAzulCentral(Panel_GestionFacturas);
                style.LabelNegro(lb_GestionFacturas);
            }
            
        }

        private void Panel_GestionProveedores_MouseEnter(object sender, EventArgs e)
        {
            if (!gestion_proveedores)
            {
                style.PanelAzulOscuro(Panel_GestionProveedores);
                style.LabelBlanco(lb_GestionProveedores);
            }
            
        }

        private void Panel_GestionProveedores_MouseLeave(object sender, EventArgs e)
        {
            if (!gestion_proveedores)
            {
                style.PanelAzulCentral(Panel_GestionProveedores);
                style.LabelNegro(lb_GestionProveedores);
            }
            
        }

        private void Panel_VerDatos_MouseEnter(object sender, EventArgs e)
        {
            if (!ver_datos)
            {
                style.PanelAzulOscuro(Panel_VerDatos);
                style.LabelBlanco(lb_VerDatos);
            }
            
        }

        private void Panel_VerDatos_MouseLeave(object sender, EventArgs e)
        {
            if (!ver_datos)
            {
                style.PanelAzulCentral(Panel_VerDatos);
                style.LabelNegro(lb_VerDatos);
            }
            
        }

        private void Panel_GestionProductos_MouseEnter(object sender, EventArgs e)
        {
            if (!gestion_productos)
            {
                style.PanelAzulOscuro(Panel_GestionProductos);
                style.LabelBlanco(lb_GestionProductos);
            }
            
        }

        private void Panel_GestionProductos_MouseLeave(object sender, EventArgs e)
        {
            if (!gestion_productos)
            {
                style.PanelAzulCentral(Panel_GestionProductos);
                style.LabelNegro(lb_GestionProductos);
            }
            
        }

        private void Panel_CerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            style.PanelAzulOscuro(Panel_CerrarSesion);
            style.LabelBlanco(lb_CerrarSesion);
            img.Agrandar_PictureBox(CerrarSesion_IMG);
        }

        private void Panel_CerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            style.PanelAzulCentral(Panel_CerrarSesion);
            style.LabelNegro(lb_CerrarSesion);
            img.Redimensionar_PictureBox(CerrarSesion_IMG);
        }

        private void Panel_FacturarProducto_Click(object sender, EventArgs e)
        {
            facturar_producto = true;
            gestion_clientes = false;
            gestion_productos = false;
            gestion_facturas = false;
            gestion_proveedores = false;
            ver_datos = false;

            utilidades.MostrarPanel(Panel_Principal, new FacturarProductos(), panel, Panel_FacturarProducto);

        }

        private void Panel_GestionClientes_Click(object sender, EventArgs e)
        {
            gestion_clientes = true;
            facturar_producto = false;
            gestion_productos = false;
            gestion_facturas = false;
            gestion_proveedores = false;
            ver_datos = false;

            utilidades.MostrarPanel(Panel_Principal, new GestionClientes(), panel, Panel_GestionClientes);

        }

        private void Panel_GestionProductos_Click(object sender, EventArgs e)
        {
            gestion_productos=true;
            facturar_producto=false;
            gestion_clientes=false;
            gestion_facturas = false;
            gestion_proveedores = false;
            ver_datos = false;

            utilidades.MostrarPanel(Panel_Principal, new GestionProductos(), panel, Panel_GestionProductos);
        }

        private void Panel_GestionFacturas_Click(object sender, EventArgs e)
        {
            gestion_facturas=true;
            gestion_productos=false;
            gestion_clientes=false;
            gestion_proveedores = false;
            ver_datos = false;
            facturar_producto = false;

            utilidades.MostrarPanel(Panel_Principal, new GestionFacturas(), panel, Panel_GestionFacturas);

        }

        private void Panel_GestionProveedores_Click(object sender, EventArgs e)
        {
            gestion_proveedores = true;
            gestion_facturas = false;
            gestion_productos = false;
            gestion_clientes = false;
            ver_datos = false;
            facturar_producto = false;

            utilidades.MostrarPanel(Panel_Principal, new GestionProveedores(), panel, Panel_GestionProveedores);
        }

        private void Panel_VerDatos_Click(object sender, EventArgs e)
        {
            ver_datos = true;
            gestion_proveedores = false;
            gestion_facturas = false;
            gestion_productos = false;
            gestion_clientes = false;
            facturar_producto = false;

            //utilidades.MostrarPanel(Panel_Principal, new VerDatos(), panel, Panel_GestionProductos);

        }

        private void Panel_CerrarSesion_Click(object sender, EventArgs e)
        {

        }


        
    }
}

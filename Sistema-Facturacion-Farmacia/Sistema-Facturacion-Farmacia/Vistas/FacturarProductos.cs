using Sistema_Facturacion_Farmacia.utilidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Facturacion_Farmacia.Vistas
{
    public partial class FacturarProductos : Form
    {
        private string connectionString = "Server=?;DataBase=FACTURACION_FARMACIA;Trusted_Connection=True;";
        private string ITBISProdActual = "";
        Utilidades util = new Utilidades();
        private List<TextBox> lista = new List<TextBox>();

        public FacturarProductos()
        {
            InitializeComponent();
            ListaClientes();
            lista = new List<TextBox> {
                tb_CantidadDisponible,
                tb_CantidadFacturar,
                tb_CodigoDeBarra,
                tb_Controlado,
                tb_Descripcion,
                tb_Laboratorio,
                tb_Nombre,
                tb_Descuento,
                tb_Precio,
                tb_FechaDeVencimiento
            };

        }

        private void tb_CodigoDeBarra_KeyPress(object sender, KeyPressEventArgs e)
        {

            
            if (e.KeyChar == (char)Keys.Enter)
            {
                tb_Descuento.Clear();
                tb_CantidadFacturar.Clear();

                string query = $"select distinct\r\nprd.Nombre as Nombre,\r\nlbt.Nombre as Laboratorio,\r\nprd.Controlado as Controlado,\r\nprd.Stock_Actual as Stock,\r\nprd.ITBIS as ITBIS,\r\nprd.Codigo_Barra as Codigo,\r\nFORMAT(prd.Fecha_Vencimiento, 'dd-MM-yyyy') as Vence,\r\nprd.Descripcion as Descripcion,\r\nprd.Precio_Venta as Precio\r\n\r\n\r\nfrom \r\nPRODUCTO prd,\r\nLABORATORIO lbt\r\n\r\nwhere 1=1\r\nAND prd.ID_Laboratorio = lbt.ID\r\nAND prd.Codigo_Barra = '{tb_CodigoDeBarra.Text.Trim().ToString()}'";
                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    try
                    {
                        connection.Open();
                        SqlCommand comand = new SqlCommand(query, connection);
                        SqlDataReader reader = comand.ExecuteReader();
                        if (reader.Read())

                        {
                            tb_Nombre.Text = reader["Nombre"].ToString();
                            tb_Laboratorio.Text = reader["Laboratorio"].ToString();
                            if (reader["Controlado"].ToString() == "1")
                            {
                                tb_Controlado.Text = "Si";
                            }
                            else
                            {
                                tb_Controlado.Text = "No";
                            }
                            tb_Precio.Text = reader["Precio"].ToString();
                            tb_CantidadDisponible.Text = reader["Stock"].ToString();
                            tb_FechaDeVencimiento.Text = reader["Vence"].ToString();
                            tb_Descripcion.Text = reader["Descripcion"].ToString();
                            ITBISProdActual = reader["ITBIS"].ToString();
                        }
                        else
                        {
                            return;
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    
                }
            }
        }
    
        private void ListaClientes()
        {
            string query = "Select \r\nNombre,\r\nApellido\r\n\r\nfrom \r\nCLIENTE";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try {
                    conn.Open();
                    SqlCommand comand = new SqlCommand(query, conn);
                    SqlDataReader reader = comand.ExecuteReader();
                    cb_clientes.Items.Add("Clientes...");
                    if (reader.Read())
                    {

                        while (reader.Read())
                        {
                            string nombre_Completo = reader["Nombre"].ToString() + " " + reader["Apellido"].ToString();
                            cb_clientes.Items.Add(nombre_Completo);
                        }
                    }
                } catch (Exception ex){
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            float subtotal = float.Parse(tb_CantidadFacturar.Text) * float.Parse(tb_Precio.Text);
            subtotal -= (subtotal * float.Parse(tb_Descuento.Text))/100.00f;
            string ITBISConfirmacion;
            if (ITBISProdActual.Equals("1"))
            {
                ITBISConfirmacion = "Tiene";
            }else{
                ITBISConfirmacion= "No Tiene";
            }
            List <string[]> datos = new List<string[]>()
            {
                new string[] { tb_Nombre.Text, tb_Laboratorio.Text, tb_CantidadFacturar.Text, tb_Precio.Text, ITBISConfirmacion, tb_Descuento.Text, subtotal.ToString() }
            };
            Tabla.Rows.Add(datos[0]);
            tb_Total.Text = (float.Parse(tb_Total.Text) + float.Parse(subtotal.ToString())).ToString();
            util.LimpiarTextBox(lista);

        }


        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_Facturacion_Farmacia
{
    internal class Connection
    {
        public void connection()
        {
            string connectionString = "Server=?;DataBase=FACTURACION_FARMACIA;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("\"Conexion exitosa");

                    string query = "SELECT * FROM CLIENTE";
                    SqlCommand comand = new SqlCommand(query, connection);
                    SqlDataReader reader = comand.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"Nombre: {reader["Nombre"]} {reader["Apellido"]}, Direccion: {reader["Direccion"]}\n");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Clases
{
    public class Pagos
    {
        Conexion miConexion = new Conexion();
        public Pagos() { }
        public int Id { get; set; }
        public string Cliente { get; set; }
        public int Habitacion { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public int Total { get; set; }
        public Pagos(string cliente, int habitacion, string tipo, DateTime fecha, int total) 
        {
            Cliente = cliente;
            Habitacion = habitacion;
            Tipo = tipo;
            Fecha = fecha;
            Total = total;
        }
        public void GuardarDB()
        {

            try
            {
                using (MySqlConnection conexion = miConexion.ObtenerConexion())
                {
                    if (miConexion.AbrirConexion())
                    {
                        string consulta = "INSERT INTO pagos (Cliente, Habitacion, Tipo, Fecha, Total) VALUES (@Cliente, @Habitacion, @Tipo, @Fecha, @Total)";

                        using (var comando = new MySqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Cliente", Cliente);
                            comando.Parameters.AddWithValue("@Habitacion", Habitacion);
                            comando.Parameters.AddWithValue("@Tipo", Tipo);
                            comando.Parameters.AddWithValue("@Fecha", Fecha);
                            comando.Parameters.AddWithValue("@Total", Total);

                            comando.ExecuteNonQuery();
                        }

                        miConexion.CerrarConexion();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pago: " + ex.Message);
            }
        }

    }
}

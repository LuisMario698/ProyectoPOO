using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public class Reservas
    {
        Conexion miConexion;
        public int Id {  get; set; }
        public string Cliente { get; set; }
        public string Habitacion { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha_Entrada { get; set; }
        public DateTime Fecha_Salida { get; set; }

        public Reservas(int id, string cliente, string habitacion, DateTime entrada, DateTime salida) 
        {
            Id = id;
            Cliente = cliente;
            Habitacion = habitacion;
            Fecha_Entrada = entrada;
            Fecha_Salida = salida;
        }
        public Reservas(string cliente, string habitacion, DateTime entrada, DateTime salida)
        {
            Cliente = cliente;
            Habitacion = habitacion;
            Fecha_Entrada = entrada;
            Fecha_Salida = salida;
        }
        public Reservas() { }
        public void GuardarDB()
        {
            miConexion = new Conexion();
            var conexion = miConexion.ObtenerConexion();

            string consulta = "INSERT INTO reservas (Cliente, Habitacion, Fecha_entrada, Fecha_salida) VALUES (@Cliente, @Habitacion, @Entrada, @Salida)";

            using (var comando = new MySqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@Cliente", Cliente);
                comando.Parameters.AddWithValue("@Habitacion", Habitacion);
                comando.Parameters.AddWithValue("@Entrada", Fecha_Entrada);
                comando.Parameters.AddWithValue("@Salida", Fecha_Salida);

                comando.ExecuteNonQuery();

                miConexion.CerrarConexion(); // Cerrar la conexión aquí

            }
        }
        public bool CancelarReservaPorId(int id)
        {
            bool eliminado = false;
            miConexion = new Conexion();
            try
            {
                using (MySqlConnection conn = miConexion.ObtenerConexion())
                {
                    string consulta = "DELETE FROM reservas WHERE Id = @Id";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        eliminado = filasAfectadas > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al cancelar la reservacion: {ex.Message}");
            }
            finally
            {
                miConexion.CerrarConexion();
            }

            return eliminado;
        }
        
    }
}

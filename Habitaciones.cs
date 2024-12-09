using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public class Habitaciones
    {
        private Conexion miConexion;

        public Habitaciones()
        {
            miConexion = new Conexion();
        }

        // Método para obtener todas las habitaciones
        public DataTable ObtenerHabitaciones()
        {
            DataTable dtHabitaciones = new DataTable();
            try
            {
                using (var conexion = miConexion.ObtenerConexion())
                {
                    string consulta = "SELECT * FROM habitaciones";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion);
                    adapter.Fill(dtHabitaciones);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las habitaciones: " + ex.Message);
            }
            return dtHabitaciones;
        }

        // Método para agregar una nueva habitación
        public bool AgregarHabitacion(string tipo, string estado, int numero, decimal precio)
        {
            try
            {
                using (var conexion = miConexion.ObtenerConexion())
                {
                    string consulta = "INSERT INTO habitaciones (Tipo, Estado, Numero, Precio) VALUES (@Tipo, @Estado, @Numero, @Precio)";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Estado", estado);
                    cmd.Parameters.AddWithValue("@Numero", numero);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la habitación: " + ex.Message);
                return false;
            }
        }

        // Método para eliminar una habitación por número
        public bool EliminarHabitacion(int numero)
        {
            try
            {
                using (var conexion = miConexion.ObtenerConexion())
                {
                    string consulta = "DELETE FROM habitaciones WHERE Numero = @Numero";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@Numero", numero);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la habitación: " + ex.Message);
                return false;
            }
        }

        // Método para modificar una habitación
        public bool ModificarHabitacion(string tipo, string estado, int numero, decimal precio)
        {
            try
            {
                using (var conexion = miConexion.ObtenerConexion())
                {
                    string consulta = "UPDATE habitaciones SET Tipo = @Tipo, Estado = @Estado, Precio = @Precio WHERE Numero = @Numero";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Estado", estado);
                    cmd.Parameters.AddWithValue("@Numero", numero);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la habitación: " + ex.Message);
                return false;
            }
        }
    }
}

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
        private Conexion conexion;

        public Habitaciones()
        {
            conexion = new Conexion();  // Crear instancia de la clase Conexion
        }

        // Método para agregar una habitación
        public bool AgregarHabitacion(string tipo, string estado, decimal numero, decimal precio)
        {
            try
            {
                MySqlConnection conn = conexion.ObtenerConexion();
                string query = "INSERT INTO Habitaciones (Tipo, Estado, Numero, Precio) VALUES (@Tipo, @Estado, @Numero, @Precio)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Estado", estado);
                    cmd.Parameters.AddWithValue("@Numero", numero);
                    cmd.Parameters.AddWithValue("@Precio", precio);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Si se agregaron filas correctamente, devuelve verdadero
                    return rowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al agregar la habitación: " + ex.Message);
                return false;
            }
        }

        // Método para eliminar una habitación
        public bool EliminarHabitacion(int numero)
        {
            try
            {
                MySqlConnection conn = conexion.ObtenerConexion();
                string query = "DELETE FROM Habitaciones WHERE Numero = @Numero";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Numero", numero);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar la habitación: " + ex.Message);
                return false;
            }
        }
        public bool ModificarPrecio(int numeroViejo, decimal precio)
        {
            try
            {
                MySqlConnection conn = conexion.ObtenerConexion();
                string query = "UPDATE Habitaciones SET Precio = @Precio WHERE Numero = @Numero";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Numero", numeroViejo);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar el precio: " + ex.Message);
                return false;
            }
        }
        public bool ModificarNumero(int numeroViejo, int numeroNuevo)
        {
            try
            {
                MySqlConnection conn = conexion.ObtenerConexion();
                string query = "UPDATE Habitaciones SET Numero = @NumeroNuevo WHERE Numero = @NumeroViejo";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NumeroNuevo", numeroNuevo);
                    cmd.Parameters.AddWithValue("@NumeroViejo", numeroViejo);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar el número: " + ex.Message);
                return false;
            }
        }

        // Método para modificar una habitación
        public bool ModificarHabitacion(string tipo, string estado, int numeroNuevo, decimal precio, int numeroViejo)
        {
            try
            {
                MySqlConnection conn = conexion.ObtenerConexion();
                string query = @"
            UPDATE Habitaciones 
            SET Tipo = @Tipo, Estado = @Estado, Numero = @NumeroNuevo, Precio = @Precio
            WHERE Numero = @NumeroViejo";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Estado", estado);
                    cmd.Parameters.AddWithValue("@NumeroNuevo", numeroNuevo);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@NumeroViejo", numeroViejo);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar la habitación: " + ex.Message);
                return false;
            }
        }
        // Método para obtener todas las habitaciones y cargarlas en el DataTable
        public DataTable ObtenerHabitaciones()
        {
            try
            {
                MySqlConnection conn = conexion.ObtenerConexion();
                string query = "SELECT Tipo, Estado, Numero, Precio FROM Habitaciones";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al obtener las habitaciones: " + ex.Message);
                return null;
            }
        }
    }







    public class Estandar : Habitaciones
    {

    }
}

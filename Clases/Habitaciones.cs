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
        public bool AgregarHabitacion(string tipo, string estado, int numero, decimal precio)
        {
            try
            {
                using (MySqlConnection conn = conexion.ObtenerConexion())
                {
                    if (conexion.AbrirConexion())
                    {
                        // Verificar si la habitación ya existe usando el nuevo método
                        if (HabitacionExiste(numero))
                        {
                            MessageBox.Show("Ya existe una habitación con ese número.");
                            return false;
                        }

                        // Si no existe, procede a agregarla
                        string consultaAgregar = "INSERT INTO Habitaciones (Tipo, Estado, Numero, Precio) VALUES (@Tipo, @Estado, @Numero, @Precio)";
                        using (MySqlCommand cmdAgregar = new MySqlCommand(consultaAgregar, conn))
                        {
                            cmdAgregar.Parameters.AddWithValue("@Tipo", tipo);
                            cmdAgregar.Parameters.AddWithValue("@Estado", estado);
                            cmdAgregar.Parameters.AddWithValue("@Numero", numero);
                            cmdAgregar.Parameters.AddWithValue("@Precio", precio);

                            int rowsAffected = cmdAgregar.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al agregar la habitación: " + ex.Message);
                return false;
            }
        }
        private bool HabitacionExiste(int numero)
        {
            try
            {
                // No necesitas crear una nueva conexión aquí
                // using (MySqlConnection conn = conexion.ObtenerConexion()) 
                // {
                if (conexion.AbrirConexion())
                {
                    string consulta = "SELECT EXISTS(SELECT 1 FROM Habitaciones WHERE Numero = @Numero)";
                    // Usa la conexión existente (conexion.conexion)
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion.conexion))
                    {
                        cmd.Parameters.AddWithValue("@Numero", numero);
                        bool existe = Convert.ToBoolean(cmd.ExecuteScalar());
                        return existe;
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                    return false;
                }
                // } // Elimina este bloque using
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al verificar la habitación: " + ex.Message);
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
                MySqlConnection conn = conexion.ObtenerConexion(); // Obtiene la conexión de la instancia de Conexion
                string query = "SELECT Tipo, Estado, Numero, Precio FROM Habitaciones";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                if (conexion.AbrirConexion()) // Abre la conexión
                {
                    da.Fill(dt);
                    conexion.CerrarConexion(); // Cierra la conexión
                    return dt;
                }
                else
                {
                    MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                    return null;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al obtener las habitaciones: " + ex.Message);
                return null;
            }
        }
    }
}

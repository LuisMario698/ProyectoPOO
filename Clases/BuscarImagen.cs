using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public class BuscarImagen
    {
        private string connectionString = "Server=localhost; Database=cooking; Uid=root; Pwd=;"; // Cambia esto a tu cadena de conexión

        public Image ObtenerImagenPorId(int id)
        {
            Image imagenCliente = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Actualiza el nombre de la columna a Fot_Productos
                string query = "SELECT Identificacion FROM clientes WHERE Id = @Id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        connection.Open(); // Intenta abrir la conexión
                        var result = command.ExecuteScalar(); // Ejecuta la consulta

                        if (result != null)
                        {
                            byte[] imageData = (byte[])result; // Convierte el resultado a byte[]

                            // Verifica que imageData no sea nulo o vacío
                            if (imageData != null && imageData.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    imagenCliente = Image.FromStream(ms); // Crea la imagen a partir del stream
                                }
                            }
                            else
                            {
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el cliente con ese ID.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Error de conexión: {ex.Message}"); // Manejo de errores de conexión
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}"); // Manejo de otros errores
                    }
                }
            }

            return imagenCliente; // Retorna la imagen (o null si no se encontró)
        }
        public bool Existe(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM clientes WHERE Id = @Id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0; // Retorna verdadero si existe al menos un producto
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Error de conexión: {ex.Message}");
                        return false;
                    }
                }
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto.Habitaciones;

namespace Proyecto
{
    public partial class formReservas : Form
    {
        private Habitaciones habitaciones;
        Conexion miConexion;
        Reservas miReserva;
        public string activa = "Activa";
        public int idSeleccionado {  get; set; }


        public formReservas()
        {
            InitializeComponent();

            







            dgvReservas.AutoGenerateColumns = false; // Desactiva la generación automática

            // Configura las columnas y vincúlalas a los nombres del DataTable
            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id", // Nombre de la columna en el DataTable
                HeaderText = "ID"
            });
            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cliente",
                DataPropertyName = "Cliente", // Nombre de la columna en el DataTable
                HeaderText = "Cliente"
            });
            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Habitacion",
                DataPropertyName = "Habitacion", // Nombre de la columna en el DataTable
                HeaderText = "Habitacion"
            });
            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fecha_entrada",
                DataPropertyName = "Fecha_entrada", // Nombre de la columna en el DataTable
                HeaderText = "Entrada"
            });
            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fecha_salida",
                DataPropertyName = "Fecha_salida", // Nombre de la columna en el DataTable
                HeaderText = "Salida"
            });
            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                DataPropertyName = "Estado", // Nombre de la columna en el DataTable
                HeaderText = "Estado"
            });

            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservas.Columns[0].Width = 30;
            dgvReservas.Columns[1].Width = 80;
            dgvReservas.Columns[2].Width = 80;
            dgvReservas.Columns[3].Width = 100;

            dgvReservas.ColumnHeadersHeight = 40;


            habitaciones = new Habitaciones();
            dpEntrada.Enabled = false;
        }

        private void formReservas_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarDatosEnComboBoxClientes();
            CargarDatosEnComboBoxHabitaciones();
        }
        private void CargarDatos()
        {
            miConexion = new Conexion();

            try
            {
                using (MySqlConnection conexion = miConexion.ObtenerConexion())
                {
                    if (miConexion.AbrirConexion())
                    {
                        string consulta = "SELECT Id, Cliente, Habitacion, Fecha_entrada, Fecha_salida, Estado FROM reservas";
                        MySqlCommand comando = new MySqlCommand(consulta, conexion);

                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);

                        dgvReservas.DataSource = dt;
                        dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void cbHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionada = dgvReservas.Rows[e.RowIndex];

                    // Validar y convertir el ID
                    if (filaSeleccionada.Cells["Id"].Value != null &&
                        int.TryParse(filaSeleccionada.Cells["Id"].Value.ToString(), out int id))
                    {
                        idSeleccionado = id; // Asigna el ID seleccionado
                        MessageBox.Show($"ID seleccionado: {idSeleccionado}");

                        // Validar y obtener otros valores
                        string cliente = filaSeleccionada.Cells["Cliente"].Value?.ToString() ?? string.Empty;
                        int habitacion;
                        if (int.TryParse(filaSeleccionada.Cells["Habitacion"].Value?.ToString(), out habitacion))
                        {
                            // La conversión a int fue exitosa, puedes usar 'valorInt' aquí

                            DateTime entrada;
                            DateTime salida;
                            if (DateTime.TryParse(filaSeleccionada.Cells["Fecha_entrada"].Value?.ToString(), out entrada))
                            {
                                if (DateTime.TryParse(filaSeleccionada.Cells["Fecha_salida"].Value?.ToString(), out salida))
                                {
                                    // La conversión a DateTime fue exitosa, puedes usar 'valorDateTime' aquí
                                    MessageBox.Show($"Seleccionaste la reserva: {id}\nCliente: {cliente}\nHabitacion: {habitacion}\nFecha de Entrada: {entrada}\nFecha de Salida: {salida}");
                                }
                                else 
                                {
                                
                                }
                            }
                            else
                            {

                            }
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("El ID de la reservacion no es válido.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado > 0)
            {
                miReserva = new Reservas();
                bool resultado = miReserva.CancelarReservaPorId(idSeleccionado);

                if (resultado)
                {
                    MessageBox.Show("Reservacion cancelada correctamente.");
                    //dgvClientesEliminar.Rows.Clear();
                    // Aquí puedes refrescar el DataGridView u otras acciones necesarias
                }
                else
                {
                    MessageBox.Show("No se pudo cancelar la reservacion. Puede que no exista.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una reservacion a cancelar.");
            }
            CargarDatos();
        }
        public void ActualizarEstadoCliente(int id)
        {
            miConexion = new Conexion();
            using (MySqlConnection conexion = miConexion.ObtenerConexion())
            {
                if (miConexion.AbrirConexion())
                {
                    string consulta = "UPDATE clientes SET Estado = @Estado WHERE Id = @Id";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    // Agrega los parámetros para evitar la inyección SQL
                    comando.Parameters.AddWithValue("@Estado", "Ocupado");
                    comando.Parameters.AddWithValue("@Id", id);

                    // Ejecuta el comando
                    comando.ExecuteNonQuery();

                    miConexion.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                }
            }
        }
        public void ActualizarEstadoHabitacion(int id)
        {
            miConexion = new Conexion();
            using (MySqlConnection conexion = miConexion.ObtenerConexion())
            {
                if (miConexion.AbrirConexion())
                {
                    string consulta = "UPDATE habitaciones SET Estado = @Estado WHERE Numero = @Numero";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    // Agrega los parámetros para evitar la inyección SQL
                    comando.Parameters.AddWithValue("@Estado", "Ocupada");
                    comando.Parameters.AddWithValue("@Numero", id);

                    // Ejecuta el comando
                    comando.ExecuteNonQuery();

                    miConexion.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                }
            }
        }
        private void btnReservar_Click(object sender, EventArgs e)
        {
            string cliente = cbClientes.Text;
            DateTime entrada = dpEntrada.Date;
            DateTime salida = dpSalida.Date;
            // Obtiene el elemento seleccionado del ComboBox
            if (cbClientes.SelectedItem != null)
            {
                
                if (cbHabitaciones.SelectedItem != null)
                {
                    
                    

                    try
                    {
                        string habitacion = cbHabitaciones.Text;

                        // Divide el string en un array usando el guion como delimitador
                        string[] valoresHabitacion = habitacion.Split('-');

                        // Accede a los valores separados
                        if (valoresHabitacion.Length == 2)
                        {
                            int idHabitacion = int.Parse(valoresHabitacion[0].Trim());
                            string nombre = valoresHabitacion[1].Trim();

                            // Ahora puedes usar las variables "id" y "nombre" como necesites
                            MessageBox.Show($"ID: {idHabitacion}, Nombre: {nombre}");
                            ActualizarEstadoHabitacion(idHabitacion);
                        }

                        string elementoSeleccionado = cbClientes.SelectedItem.ToString();

                        // Divide el string en un array usando el guion como delimitador
                        string[] valores = elementoSeleccionado.Split('-');

                        // Accede a los valores separados
                        if (valores.Length == 2)
                        {
                            int idCliente = int.Parse(valores[0].Trim());
                            string nombre = valores[1].Trim();

                            // Ahora puedes usar las variables "id" y "nombre" como necesites
                            MessageBox.Show($"ID: {idCliente}, Nombre: {nombre}");
                            ActualizarEstadoCliente(idCliente);
                        }


                        if (miConexion.AbrirConexion())
                        {

                            // Crear una instancia de InventarioProducto
                            Reservas reserva = new Reservas(cliente, habitacion, entrada, salida, activa);

                            // Llamar al método GuardarEnBaseDeDatos
                            reserva.GuardarDB();

                            // Mostrar un mensaje de confirmación
                            MessageBox.Show("Reserva guardada correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // miConexion.CerrarConexion();
                            //dgvClientes.Rows.Clear();
                            CargarDatos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                        }
                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar la reservacion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    MessageBox.Show("Por favor, selecciona una habitacion del ComboBox.");
                }
            }
            else { 
                
                MessageBox.Show("Por favor, selecciona un cliente del ComboBox.");
            }


        }
        private void CargarDatosEnComboBoxClientes()
        {
            miConexion = new Conexion();

            try
            {
                using (MySqlConnection conexion = miConexion.ObtenerConexion())
                {
                    if (miConexion.AbrirConexion())
                    {
                        string consulta = "SELECT Id, Nombre FROM clientes WHERE Estado = 'Disponible'";
                        MySqlCommand comando = new MySqlCommand(consulta, conexion);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Obtiene el ID y el nombre por separado
                                int id = reader.GetInt32("Id");
                                string nombre = reader.GetString("Nombre");

                                // Concatena el ID y el nombre en un string
                                string cliente = $"{id} - {nombre}";

                                // Agrega el string al ComboBox
                                cbClientes.Items.Add(cliente);
                            }
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
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
        private void CargarDatosEnComboBoxHabitaciones()
        {
            miConexion = new Conexion();

            try
            {
                using (MySqlConnection conexion = miConexion.ObtenerConexion())
                {
                    if (miConexion.AbrirConexion())
                    {
                        string consulta = "SELECT Numero, Tipo FROM habitaciones WHERE Estado = 'Disponible'";
                        MySqlCommand comando = new MySqlCommand(consulta, conexion);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Agrega el nombre del cliente al ComboBox
                                int numero = reader.GetInt32("Numero");
                                string tipo = reader.GetString("Tipo");
                                string habitacion = $"{numero} - {tipo}";
                                cbHabitaciones.Items.Add(habitacion);
                            }
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
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        
    }
}

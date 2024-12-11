using MySql.Data.MySqlClient;
using Proyecto.Clases;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Xceed.Words.NET;
using System.IO;
using Xceed.Document.NET;
using System.Drawing;

namespace Proyecto
{
    public partial class formPagos : Form
    {
        private Habitaciones habitaciones;
        Conexion miConexion;
        public int clienteSeleccionado {  get; set; }
        public int habitacionSeleccionda { get; set; }
        public int idSeleccionado { get; set; }
        public string dpEntrada {  get; set; }
        public string dpSalida { get; set; }
        public string dpInstancia { get; set; }

        HabitacionEstandar estandar = new HabitacionEstandar();
        HabitacionSuite suite = new HabitacionSuite();
        HabitacionDeluxe deluxe = new HabitacionDeluxe();
        public formPagos()
        {
            InitializeComponent();

            checkLimpieza.Enabled = false;
            txtComidas.Enabled = false;
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
                Name = "Instancia",
                DataPropertyName = "Instancia", // Nombre de la columna en el DataTable
                HeaderText = "Instancia"
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
        }

        private void formPagos_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ActualizarTotal();
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
                        string consulta = "SELECT Id, Cliente, Habitacion, Fecha_entrada, Fecha_salida, Instancia, Estado FROM reservas";
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

                        string clienteSele = filaSeleccionada.Cells["Cliente"].Value?.ToString();
                        string habitacionSele = filaSeleccionada.Cells["Habitacion"].Value?.ToString();

                        // Extraer el número de la cadena "cliente"
                        if (!string.IsNullOrEmpty(clienteSele))
                        {
                            string[] partesCliente = clienteSele.Split('-');
                            if (partesCliente.Length > 0 && int.TryParse(partesCliente[0].Trim(), out int idCliente))
                            {
                                // Aquí tienes el ID del cliente en la variable "idCliente"
                                clienteSeleccionado = idCliente;
                                MessageBox.Show("ID del cliente: " + idCliente);
                                lblIdCliente.Text = clienteSeleccionado.ToString();
                                lblNombreCliente.Text = ObtenerNombreCliente(clienteSeleccionado);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo obtener el ID del cliente.");
                            }
                        }

                        // Extraer el número de la cadena "habitacion"
                        if (!string.IsNullOrEmpty(habitacionSele))
                        {
                            string[] partesHabitacion = habitacionSele.Split('-');
                            if (partesHabitacion.Length > 0 && int.TryParse(partesHabitacion[0].Trim(), out int numeroHabitacion))
                            {
                                // Aquí tienes el número de la habitación en la variable "numeroHabitacion"
                                habitacionSeleccionda = numeroHabitacion;
                                MessageBox.Show("Número de habitación: " + numeroHabitacion);
                                lblIdHabitacion.Text = habitacionSeleccionda.ToString();
                                lblTipoHabitacion.Text = ObtenerTipoHabitacion(habitacionSeleccionda);
                                lblPrecioHabitacion.Text = ObtenerPrecioHabitacion(habitacionSeleccionda).ToString();
                                
                                
                                
                            }
                            else
                            {
                                MessageBox.Show("No se pudo obtener el número de habitación.");
                            }
                        }
                        idSeleccionado = id; // Asigna el ID seleccionado
                        MessageBox.Show($"ID seleccionado: {idSeleccionado}");
                        lblReservaSeleccionada.Text = filaSeleccionada.Cells[0].Value?.ToString() ?? string.Empty;
                        lblInstanciaTotal.Text = filaSeleccionada.Cells[5].Value?.ToString() ?? string.Empty;
                        int instancia = Convert.ToInt32(lblInstanciaTotal.Text);
                        decimal precio = ObtenerPrecioHabitacion(habitacionSeleccionda);
                        lblSubtotal.Text = (precio * instancia).ToString();
                        ActualizarTotal();
                        dpInstancia = instancia.ToString();

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
                                    dpEntrada = entrada.ToString();
                                    dpSalida = salida.ToString();
                                    // La conversión a DateTime fue exitosa, puedes usar 'valorDateTime' aquí
                                    MessageBox.Show($"Seleccionaste la reserva: {id}\nCliente: {cliente}\nHabitacion: {habitacion}\nFecha de Entrada: {entrada}\nFecha de Salida: {salida}");
                                    ActualizarTotal();
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

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ActualizarEstadoCliente(int id, string estado)
        {
            miConexion = new Conexion();
            using (MySqlConnection conexion = miConexion.ObtenerConexion())
            {
                if (miConexion.AbrirConexion())
                {
                    string consulta = "UPDATE clientes SET Estado = @Estado WHERE Id = @Id";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    // Agrega los parámetros para evitar la inyección SQL
                    comando.Parameters.AddWithValue("@Estado", estado);
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
        public void ActualizarEstadoHabitacion(int id, string estado)
        {
            miConexion = new Conexion();
            using (MySqlConnection conexion = miConexion.ObtenerConexion())
            {
                if (miConexion.AbrirConexion())
                {
                    string consulta = "UPDATE habitaciones SET Estado = @Estado WHERE Numero = @Numero";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    // Agrega los parámetros para evitar la inyección SQL
                    comando.Parameters.AddWithValue("@Estado", estado);
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
        private decimal ObtenerPrecioHabitacion(int habitacion)
        {
            miConexion = new Conexion();
            decimal precio = 0;

            try
            {
                using (MySqlConnection conexion = miConexion.ObtenerConexion())
                {
                    if (miConexion.AbrirConexion())
                    {
                        string consulta = "SELECT Precio FROM habitaciones WHERE Numero = @Id";

                        using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Id", habitacion);

                            object resultado = comando.ExecuteScalar();
                            if (resultado != null)
                            {
                                if (decimal.TryParse(resultado.ToString(), out precio))
                                {
                                    // El precio se obtuvo correctamente
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo convertir el precio a un valor decimal.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ninguna habitación con ese número.");
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
                MessageBox.Show("Error al obtener el precio de la habitación: " + ex.Message);
            }

            return precio;
        }
        private string ObtenerTipoHabitacion(int habitacion)
        {
            miConexion = new Conexion();
            string tipoHabitacion = "";

            try
            {
                using (MySqlConnection conexion = miConexion.ObtenerConexion())
                {
                    if (miConexion.AbrirConexion())
                    {
                        string consulta = "SELECT Tipo FROM habitaciones WHERE Numero = @Id";

                        using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Id", habitacion);

                            using (MySqlDataReader reader = comando.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    tipoHabitacion = reader["Tipo"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró ninguna habitación con ese número.");
                                }
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
                MessageBox.Show("Error al obtener el tipo de habitación: " + ex.Message);
            }

            return tipoHabitacion;
        }

        private string ObtenerNombreCliente(int idCliente)
        {
            miConexion = new Conexion();
            string nombreCliente = "";

            try
            {
                using (MySqlConnection conexion = miConexion.ObtenerConexion())
                {
                    if (miConexion.AbrirConexion())
                    {
                        string consulta = "SELECT Nombre FROM clientes WHERE Id = @Id";

                        using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Id", idCliente);

                            using (MySqlDataReader reader = comando.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    nombreCliente = reader["Nombre"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró ningún cliente con ese ID.");
                                }
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
                MessageBox.Show("Error al obtener el nombre del cliente: " + ex.Message);
            }

            return nombreCliente;
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void checkLimpieza_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLimpieza.Checked)
            {
                MessageBox.Show("La habitación se marcó como limpia.");
                if(lblTipoHabitacion.Text == "Estandar")
                {
                    decimal gastosLimpieza = estandar.CalcularGastosLimpieza(true);
                    lblTotalLimpieza.Text = gastosLimpieza.ToString();
                }
                if (lblTipoHabitacion.Text == "Suite")
                {
                    decimal gastosLimpieza = suite.CalcularGastosLimpieza(true);
                    lblTotalLimpieza.Text = gastosLimpieza.ToString();
                }
                if(lblTipoHabitacion.Text == "Deluxe")
                {
                    decimal gastosLimpieza = deluxe.CalcularGastosLimpieza(true);
                    lblTotalLimpieza.Text = gastosLimpieza.ToString();
                }
            }
            else
            {
                MessageBox.Show("La habitación se desmarcó como limpia.");
                if (lblTipoHabitacion.Text == "Estandar")
                {
                    decimal gastosLimpieza = estandar.CalcularGastosLimpieza(false);
                    lblTotalLimpieza.Text = gastosLimpieza.ToString();
                }
                if (lblTipoHabitacion.Text == "Suite")
                {
                    decimal gastosLimpieza = suite.CalcularGastosLimpieza(false);
                    lblTotalLimpieza.Text = gastosLimpieza.ToString();
                }
                if (lblTipoHabitacion.Text == "Deluxe")
                {
                    decimal gastosLimpieza = deluxe.CalcularGastosLimpieza(false);
                    lblTotalLimpieza.Text = gastosLimpieza.ToString();
                }
            }
            ActualizarTotal();
        }
        private void IncrementarReservasCliente(int idCliente)
        {
            miConexion = new Conexion();

            try
            {
                using (MySqlConnection conexion = miConexion.ObtenerConexion())
                {
                    if (miConexion.AbrirConexion())
                    {
                        string consulta = "UPDATE clientes SET Reservas = Reservas + 1 WHERE Id = @Id";
                        using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Id", idCliente);
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
                MessageBox.Show("Error al actualizar las reservas del cliente: " + ex.Message);
            }
        }

        private void txtComidas_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtComidas.Text, out int comida)) // Intenta convertir el texto a entero
            {
                if (lblTipoHabitacion.Text == "Estandar")
                {
                    decimal gastosComida = estandar.CalcularGastosComida(comida);
                    lblTotalComida.Text = gastosComida.ToString();
                }
                if (lblTipoHabitacion.Text == "Suite")
                {
                    decimal gastosComida = suite.CalcularGastosComida(comida);
                    lblTotalComida.Text = gastosComida.ToString();
                }
                if (lblTipoHabitacion.Text == "Deluxe")
                {
                    decimal gastosComida = deluxe.CalcularGastosComida(comida);
                    lblTotalComida.Text = gastosComida.ToString();
                }
            }
            else
            {
                // Manejar el caso donde el TextBox no contiene un número válido
                lblTotalComida.Text = "0"; // O mostrar un mensaje de error
            }
            ActualizarTotal();
        }
        private void ActualizarTotal()
        {
            try
            {
                // Convertir los valores a decimal (o el tipo de dato que corresponda)
                decimal comida = decimal.Parse(lblTotalComida.Text);
                decimal limpieza = decimal.Parse(lblTotalLimpieza.Text);
                decimal subtotal = decimal.Parse(lblSubtotal.Text);

                decimal total = comida + limpieza + subtotal;
                lblTotal.Text = total.ToString();
            }
            catch (FormatException)
            {
                // Manejar el error si alguno de los valores no se puede convertir a decimal
                MessageBox.Show("Error al calcular el total. Asegúrate de que los valores sean numéricos.");
            }
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            string cliente = $"{lblIdCliente.Text} - {lblNombreCliente.Text}";
            int habitacion = int.Parse(lblIdHabitacion.Text);
            string tipo = lblTipoHabitacion.Text;
            DateTime fecha = DateTime.Now;
            int total = int.Parse(lblTotal.Text);

            // Crea una instancia de la clase Pagos
            Pagos pago = new Pagos(cliente, habitacion, tipo, fecha, total);

            // Guarda el pago en la base de datos
            pago.GuardarDB();

            MessageBox.Show("Pago realizado correctamente.");
            if (idSeleccionado > 0)
            {
                Reservas miReserva = new Reservas();
                bool resultado = miReserva.CancelarReservaPorId(idSeleccionado);



                if (resultado)
                {
                    MessageBox.Show("Reservacion finalizada.");

                    ActualizarEstadoCliente(clienteSeleccionado, "Disponible");
                    ActualizarEstadoHabitacion(habitacionSeleccionda, "Disponible");
                    IncrementarReservasCliente(clienteSeleccionado);
                    

                    //dgvClientesEliminar.Rows.Clear();
                    // Aquí puedes refrescar el DataGridView u otras acciones necesarias
                    try
                    {
                        // Crea un nuevo documento Word
                        using (var document = DocX.Create("Comprobante de Pago.docx"))
                        {
                            // Agrega un título con formato
                            // Agrega un título con formato
                            var titulo = document.InsertParagraph("Comprobante de Pago - Hotel Cooking");
                            titulo.FontSize(20);
                            titulo.Bold();
                            titulo.Alignment = Alignment.center;

                            // Agrega la información del pago con formato
                            document.InsertParagraph($"Cliente: {lblNombreCliente.Text} (ID: {lblIdCliente.Text})").FontSize(12);
                            document.InsertParagraph($"Habitación: {lblIdHabitacion.Text} ({lblTipoHabitacion.Text})").FontSize(12);
                            document.InsertParagraph($"Fecha de entrada: {dpEntrada}").FontSize(12);
                            document.InsertParagraph($"Fecha de salida: {dpSalida}").FontSize(12);

                            // Calcula la instancia (número de días)
                            
                            document.InsertParagraph($"Instancia (días): {dpInstancia}").FontSize(12);

                            // Calcula el precio por día
                            decimal precioPorDia = decimal.Parse(lblSubtotal.Text) / Convert.ToInt32(dpInstancia);
                            document.InsertParagraph($"Precio por día: {precioPorDia}").FontSize(12);

                            document.InsertParagraph(); // Agrega un espacio en blanco

                            // Agrega los detalles del pago con formato
                            document.InsertParagraph($"Subtotal de habitación: {lblSubtotal.Text}").FontSize(12);
                            document.InsertParagraph($"Total de comida: {lblTotalComida.Text}").FontSize(12);
                            document.InsertParagraph($"Total de limpieza: {lblTotalLimpieza.Text}").FontSize(12);
                            document.InsertParagraph($"Total: {lblTotal.Text}").FontSize(12).Bold();
                            // Crea un SaveFileDialog
                            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                            saveFileDialog1.Filter = "Documentos Word (*.docx)|*.docx|Todos los archivos (*.*)|*.*";
                            saveFileDialog1.Title = "Guardar comprobante de pago";
                            saveFileDialog1.FileName = "Comprobante de Pago.docx";

                            // Muestra el SaveFileDialog
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                // Guarda el documento en la ubicación seleccionada por el usuario
                                document.SaveAs(saveFileDialog1.FileName);

                                MessageBox.Show("Comprobante de pago guardado correctamente en:\n" + saveFileDialog1.FileName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el comprobante de pago: " + ex.Message);
                    }
                    /*try
                    {
                        if (dgvReservas.SelectedRows.Count > 0)
                        {
                            // Obtener el ID de la reserva seleccionada
                            int idReserva = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells[0].Value);
                            MessageBox.Show($"ID de la reserva seleccionada: {idReserva}");

                            // Buscar la reserva en la lista
                            Reserva reservaSeleccionada = ReservaManager.ObtenerReservas().Find(r => r.Id == idReserva);

                            // Verificar si la reserva existe
                            if (reservaSeleccionada != null)
                            {
                                SaveFileDialog saveFileDialog = new SaveFileDialog
                                {
                                    Filter = "Documentos Word (*.docx)|*.docx",
                                    Title = "Guardar Nota de Pago"
                                };

                                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    // Crear el documento Word
                                    using (var doc = Xceed.Words.NET.DocX.Create(saveFileDialog.FileName))
                                    {
                                        // Título de la nota de pago
                                        doc.InsertParagraph("Nota de Pago")
                                            .FontSize(20)
                                            .Bold()
                                            .Color(System.Drawing.Color.DarkBlue)
                                            .Alignment = Alignment.center;

                                        doc.InsertParagraph("\n");

                                        // Información de la reserva
                                        doc.InsertParagraph("Detalles de la Reserva")
                                            .FontSize(16)
                                            .Bold()
                                            .Alignment = Alignment.left;

                                        doc.InsertParagraph($"ID Reserva: {reservaSeleccionada.Id}")
                                            .FontSize(12);

                                        doc.InsertParagraph($"Cliente: {reservaSeleccionada.NombreCliente}")
                                            .FontSize(12);

                                        doc.InsertParagraph($"Habitación: {reservaSeleccionada.Habitacion}")
                                            .FontSize(12);

                                        doc.InsertParagraph($"Fecha Ingreso: {reservaSeleccionada.FechaIngreso:yyyy-MM-dd}")
                                            .FontSize(12);

                                        doc.InsertParagraph($"Fecha Salida: {reservaSeleccionada.FechaSalida:yyyy-MM-dd}")
                                            .FontSize(12);

                                        // Calcular el costo de la habitación (precio arbitrario)
                                        int diasEstancia = (reservaSeleccionada.FechaSalida - reservaSeleccionada.FechaIngreso).Days;
                                        decimal precioPorNoche = 100; // Valor arbitrario por noche
                                        decimal total = diasEstancia * precioPorNoche;

                                        doc.InsertParagraph("\n");

                                        // Total a pagar
                                        doc.InsertParagraph("Total a Pagar")
                                            .FontSize(16)
                                            .Bold()
                                            .Alignment = Alignment.left;

                                        doc.InsertParagraph($"Costo por Noche: ${precioPorNoche} MXN")
                                            .FontSize(12);

                                        doc.InsertParagraph($"Días de Estancia: {diasEstancia} días")
                                            .FontSize(12);

                                        doc.InsertParagraph($"Total: ${total} MXN")
                                            .FontSize(12)
                                            .Bold()
                                            .Color(System.Drawing.Color.Green);

                                        doc.InsertParagraph("\n");

                                        // Agradecimiento
                                        doc.InsertParagraph("Gracias por su preferencia. Esperamos su pronta visita.")
                                            .FontSize(12)
                                            .Italic()
                                            .Alignment = Alignment.center;

                                        // Guardar el documento
                                        doc.Save();
                                    }

                                    MessageBox.Show("Nota de pago generada exitosamente en formato Word.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró la reserva seleccionada.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una reserva para generar la nota de pago.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar la nota de pago: " + ex.Message);
                    }
                    */
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
    }
}

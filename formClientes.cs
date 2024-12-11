using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto.Habitaciones;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto
{
    public partial class formClientes : Form
    {
        Conexion miConexion;
        Clientes miCliente;
        Clientes enlace;
        private bool conexionAbierta = false;
        public string rutaIdentificacion = "";
        public int idSeleccionado { get; set; }
        public formClientes()
        {
            InitializeComponent();
            btnRegistrar.BaseColor = Color.FromArgb(255, 193, 54);
            btnRegistrar.BorderSize = 0;
            btnRegistrar.ForeColor = Color.Black;
            btnEliminar.BaseColor = Color.FromArgb(255, 193, 54);
            btnEliminar.BorderSize = 0;
            btnEliminar.ForeColor = Color.Black;
            btnModificar.BaseColor = Color.FromArgb(255, 193, 54);
            btnModificar.BorderSize = 0;
            btnModificar.ForeColor = Color.Black;



            // Desactivar la generación automática de columnas
            dgvClientes.AutoGenerateColumns = false; // Desactiva la generación automática

            // Configura las columnas y vincúlalas a los nombres del DataTable
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id", // Nombre de la columna en el DataTable
                HeaderText = "ID"
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                DataPropertyName = "Nombre", // Nombre de la columna en el DataTable
                HeaderText = "Nombre"
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Numero_Telefonico",
                DataPropertyName = "Numero_telefonico", // Nombre de la columna en el DataTable
                HeaderText = "Teléfono"
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Correo",
                DataPropertyName = "Correo", // Nombre de la columna en el DataTable
                HeaderText = "Correo"
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                DataPropertyName = "Estado", // Nombre de la columna en el DataTable
                HeaderText = "Estado"
            });

            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.Columns[0].Width = 30;
            dgvClientes.Columns[1].Width = 150;
            dgvClientes.Columns[2].Width = 100;

            dgvClientes.ColumnHeadersHeight = 40;

            //---------------------------------------------------------------------------------------------------
            dgvClientesModificar.AutoGenerateColumns = false; // Desactiva la generación automática

            // Configura las columnas y vincúlalas a los nombres del DataTable
            dgvClientesModificar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id", // Nombre de la columna en el DataTable
                HeaderText = "ID"
            });
            dgvClientesModificar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                DataPropertyName = "Nombre", // Nombre de la columna en el DataTable
                HeaderText = "Nombre"
            });
            dgvClientesModificar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Numero_Telefonico",
                DataPropertyName = "Numero_telefonico", // Nombre de la columna en el DataTable
                HeaderText = "Telefono"
            });
            dgvClientesModificar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Correo",
                DataPropertyName = "Correo", // Nombre de la columna en el DataTable
                HeaderText = "Correo"
            });
            dgvClientesModificar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                DataPropertyName = "Estado", // Nombre de la columna en el DataTable
                HeaderText = "Estado"
            });

            dgvClientesModificar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientesModificar.Columns[0].Width = 30;
            dgvClientesModificar.Columns[1].Width = 150;
            dgvClientesModificar.Columns[2].Width = 100;

            dgvClientesModificar.ColumnHeadersHeight = 40;

            //---------------------------------------------------------------------------------------------------

            // Desactivar la generación automática de columnas
            dgvClientesEliminar.AutoGenerateColumns = false; // Desactiva la generación automática

            // Configura las columnas y vincúlalas a los nombres del DataTable
            dgvClientesEliminar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id", // Nombre de la columna en el DataTable
                HeaderText = "ID"
            });
            dgvClientesEliminar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                DataPropertyName = "Nombre", // Nombre de la columna en el DataTable
                HeaderText = "Nombre"
            });
            dgvClientesEliminar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Numero_Telefonico",
                DataPropertyName = "Numero_telefonico", // Nombre de la columna en el DataTable
                HeaderText = "Teléfono"
            });
            dgvClientesEliminar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Correo",
                DataPropertyName = "Correo", // Nombre de la columna en el DataTable
                HeaderText = "Correo"
            });
            dgvClientesEliminar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                DataPropertyName = "Estado", // Nombre de la columna en el DataTable
                HeaderText = "Estado"
            });

            dgvClientesEliminar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientesEliminar.Columns[0].Width = 30;
            dgvClientesEliminar.Columns[1].Width = 150;
            dgvClientesEliminar.Columns[2].Width = 100;

            dgvClientesEliminar.ColumnHeadersHeight = 40;
        }


        private void formClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarDatosModificar();
            CargarDatosEliminar();
            // Carga la imagen en el PictureBox
            pb1.Image = Properties.Resources.file;

            // Ajusta la imagen al tamaño del PictureBox
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.SizeMode = PictureBoxSizeMode.Zoom;

            pbIdentificacionNueva.Visible = true;
            pbArchivos.Enabled = false;
            pbArchivos.Visible = false;


            pbIdentificacionAntes.Enabled = false;
            pbIdentificacionAntes.SizeMode = PictureBoxSizeMode.Zoom;
            pbIdentificacionNueva.Enabled = false;
            pbIdentificacionNueva.SizeMode = PictureBoxSizeMode.Zoom;

            pbFlecha1.Image = Properties.Resources.flecha;
            pbFlecha1.SizeMode = PictureBoxSizeMode.Zoom;
            pbFlecha2.Image = Properties.Resources.flecha;
            pbFlecha2.SizeMode = PictureBoxSizeMode.Zoom;
            pbFlecha3.Image = Properties.Resources.flecha;
            pbFlecha3.SizeMode = PictureBoxSizeMode.Zoom;
            pbArchivos.Image = Properties.Resources.file;
            pbArchivos.SizeMode = PictureBoxSizeMode.Zoom;

        }
        //------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------CONSULTA----------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------
        private void CargarDatos()
        {
            miConexion = new Conexion();

            try
            {
                using (MySqlConnection conexion = miConexion.ObtenerConexion())
                {
                    if (miConexion.AbrirConexion())
                    {
                        string consulta = "SELECT Id, Nombre, Numero_telefonico, Correo, Estado FROM clientes";
                        MySqlCommand comando = new MySqlCommand(consulta, conexion);

                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);

                        dgvClientes.DataSource = dt;
                        dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
        private void txtNombreConsulta_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox
            string filtro = txtNombreConsulta.Text;

            // Obtener el DataTable del DataView (si existe)
            DataTable dt = null;
            if (dgvClientes.DataSource is DataView dataView)
            {
                dt = dataView.Table;
            }
            else if (dgvClientes.DataSource is DataTable dataTable)
            {
                dt = dataTable;
            }
            else
            {
                // Si no hay DataSource, crear uno nuevo
                dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Numero_telefonico", typeof(string));
                dt.Columns.Add("Correo", typeof(string));
                dgvClientes.DataSource = dt;
            }

            // Crear un nuevo DataView a partir del DataTable original
            DataView dv = new DataView(dt);

            // Aplicar el filtro al DataView, solo si el TextBox no está vacío
            if (!string.IsNullOrEmpty(filtro))
            {
                dv.RowFilter = $"Nombre LIKE '%{filtro}%'"; // Filtrar por la columna "Nombre"
            }

            // Asignar el DataView (filtrado o no) al DataGridView
            dgvClientes.DataSource = dv;

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------CONSULTA----------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------REGISTRAR---------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                if (string.IsNullOrEmpty(txtCorreo.Text))
                {
                    if (string.IsNullOrEmpty(txtTelefono.Text))
                    {
                        string nombre = txtNombre.Text;
                        string telefono = txtTelefono.Text;
                        string correo = txtCorreo.Text;

                        if (EsCorreoValido(correo))
                        {
                            MessageBox.Show("El correo electrónico es válido.");


                            if (!string.IsNullOrEmpty(rutaIdentificacion))
                            {

                                byte[] identificacion = File.ReadAllBytes(rutaIdentificacion);
                                try
                                {

                                    if (miConexion.AbrirConexion())
                                    {

                                        // Crear una instancia de InventarioProducto
                                        Clientes cliente = new Clientes(nombre, telefono, correo, identificacion, "Disponible");

                                        // Llamar al método GuardarEnBaseDeDatos
                                        cliente.GuardarDB();

                                        // Mostrar un mensaje de confirmación
                                        MessageBox.Show("Cliente guardado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // miConexion.CerrarConexion();
                                        //dgvClientes.Rows.Clear();
                                        CargarDatos();
                                        CargarDatosEliminar();
                                        CargarDatosModificar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Error al guardar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                            else
                            {
                                MessageBox.Show("Por favor selecciona una imagen.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El correo electrónico no es válido.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Llene todos los parametros.");
                    }
                }
                else
                {
                    MessageBox.Show("Llene todos los parametros.");
                }
            }
            else
            {
                MessageBox.Show("Llene todos los parametros.");
            }
        }
        private void pb1_Click(object sender, EventArgs e)
        {
            // Aquí puedes poner el código que se ejecutará al hacer clic en la imagen
            MessageBox.Show("¡Has hecho clic en la imagen!");

            // Crea una instancia de OpenFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Configura las propiedades del OpenFileDialog (opcional)
            openFileDialog1.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.Title = "Selecciona una imagen";

            // Muestra el OpenFileDialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Si el usuario selecciona un archivo, obtén la ruta del archivo

                string rutaArchivo = openFileDialog1.FileName;
                rutaIdentificacion = rutaArchivo;

                // Haz algo con la ruta del archivo, por ejemplo, mostrar la imagen en el PictureBox
                pb.Image = Image.FromFile(rutaArchivo);
            }
        }


        private void tabConsultar_Click(object sender, EventArgs e)
        {

        }
        //------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------REGISTRAR---------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------MODIFICAR---------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------
        private void CargarDatosModificar()
        {
            miConexion = new Conexion();
            try
            {
                using (MySqlConnection conexion = miConexion.ObtenerConexion())
                {
                    if (miConexion.AbrirConexion())
                    {
                        string consulta = "SELECT Id, Nombre, Numero_telefonico, Correo, Estado FROM clientes";
                        MySqlCommand comando = new MySqlCommand(consulta, conexion);

                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);

                        dgvClientesModificar.DataSource = dt;
                        dgvClientesModificar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
        private void dgvClientesModificar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionada = dgvClientesModificar.Rows[e.RowIndex];

                    // Obtener el estado del cliente
                    string estado = filaSeleccionada.Cells["Estado"].Value?.ToString() ?? string.Empty;

                    // Validar si el cliente está ocupado
                    if (estado == "Ocupado")
                    {
                        MessageBox.Show("No se puede modificar un cliente ocupado.");
                        return; // Salir del método si el cliente está ocupado
                    }

                    // Validar y convertir el ID
                    if (filaSeleccionada.Cells["Id"].Value != null &&
                        int.TryParse(filaSeleccionada.Cells["Id"].Value.ToString(), out int id))
                    {
                        idSeleccionado = id; // Asigna el ID seleccionado
                        MessageBox.Show($"ID seleccionado: {idSeleccionado}");

                        // Validar y obtener otros valores
                        string nombre = filaSeleccionada.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                        string telefono = filaSeleccionada.Cells["Numero_telefonico"].Value?.ToString() ?? string.Empty;
                        string correo = filaSeleccionada.Cells["Correo"].Value?.ToString() ?? string.Empty;

                        // Mostrar información del cliente
                        MessageBox.Show($"Seleccionaste el cliente: {nombre}\nTelefono: {telefono}\nCorreo: {correo}");

                        // Mostrar los datos en los TextBox
                        txtNombreAntes.Text = nombre;
                        txtNombreAntes.Enabled = false;
                        txtTelefonoAntes.Text = telefono;
                        txtTelefonoAntes.Enabled = false;
                        txtCorreoAntes.Text = correo;
                        txtCorreoAntes.Enabled = false;

                        txtNombreNuevo.Text = nombre;
                        txtTelefonoNuevo.Text = telefono;
                        txtCorreoNuevo.Text = correo;

                        // Obtener la imagen del cliente
                        BuscarImagen imagen = new BuscarImagen();

                        if (imagen.Existe(idSeleccionado))
                        {
                            Image imagenEncontrada = imagen.ObtenerImagenPorId(idSeleccionado);

                            if (imagenEncontrada != null)
                            {
                                pbIdentificacionAntes.Image = imagenEncontrada;
                            }
                            else
                            {
                                MessageBox.Show("No se encontró la imagen para el cliente seleccionado.");
                                pbIdentificacionAntes.Image = Properties.Resources.equis;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"No hay ningún cliente con el ID: {idSeleccionado}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El ID del cliente no es válido.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}");
            }
        }



        private void dgvClientesModificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabModificar_Click(object sender, EventArgs e)
        {

        }

        private void tabEliminar_Click(object sender, EventArgs e)
        {

        }




        //------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------MODIFICAR---------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------ELIMINAR----------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------


        private void CargarDatosEliminar()
        {
            miConexion = new Conexion();

            try
            {
                using (MySqlConnection conexion = miConexion.ObtenerConexion())
                {
                    if (miConexion.AbrirConexion())
                    {
                        string consulta = "SELECT Id, Nombre, Numero_telefonico, Correo, Estado FROM clientes";
                        MySqlCommand comando = new MySqlCommand(consulta, conexion);

                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);

                        dgvClientesEliminar.DataSource = dt;
                        dgvClientesEliminar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        private void txtNombreModificar_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox
            string filtro = txtNombreModificar.Text;

            // Obtener el DataTable del DataView (si existe)
            DataTable dt = null;
            if (dgvClientesModificar.DataSource is DataView dataView)
            {
                dt = dataView.Table;
            }
            else if (dgvClientesModificar.DataSource is DataTable dataTable)
            {
                dt = dataTable;
            }
            else
            {
                // Si no hay DataSource, crear uno nuevo
                dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Numero_telefonico", typeof(string));
                dt.Columns.Add("Correo", typeof(string));
                dt.Columns.Add("Estado", typeof(string));
                dgvClientesModificar.DataSource = dt;
            }

            // Crear un nuevo DataView a partir del DataTable original
            DataView dv = new DataView(dt);

            // Aplicar el filtro al DataView, solo si el TextBox no está vacío
            if (!string.IsNullOrEmpty(filtro))
            {
                dv.RowFilter = $"Nombre LIKE '%{filtro}%'"; // Filtrar por la columna "Nombre"
            }

            // Asignar el DataView (filtrado o no) al DataGridView
            dgvClientesModificar.DataSource = dv;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado > 0)
            {
                miCliente = new Clientes();
                bool resultado = miCliente.EliminarClientePorId(idSeleccionado);

                if (resultado)
                {
                    MessageBox.Show("Cliente eliminado correctamente.");
                    //dgvClientesEliminar.Rows.Clear();
                    // Aquí puedes refrescar el DataGridView u otras acciones necesarias

                    CargarDatos();
                    CargarDatosEliminar();
                    CargarDatosModificar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Producto. Puede que no exista.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un Producto a eliminar.");
            }
            CargarDatosEliminar();
        }

        private void dgvClientesEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionada = dgvClientesEliminar.Rows[e.RowIndex];
                    object valorCelda = filaSeleccionada.Cells["Estado"].Value;

                    // Verifica si valorCelda es nulo
                    string valorEstado = valorCelda?.ToString() ?? string.Empty;

                    // Validar y convertir el ID
                    if (valorEstado == "Disponible")
                    {
                        if (filaSeleccionada.Cells["Id"].Value != null &&
                            int.TryParse(filaSeleccionada.Cells["Id"].Value.ToString(), out int id))
                        {
                            idSeleccionado = id; // Asigna el ID seleccionado
                            MessageBox.Show("El id seleccionado fue " + idSeleccionado);

                            // Aquí puedes llamar al método para eliminar el cliente
                            // ...
                        }
                        else
                        {
                            MessageBox.Show("El ID del producto no es válido.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar un cliente que este ocupado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}");
            }
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void switchIdentificacion_CheckedChanged(object sender, EventArgs e)
        {
            if (switchIdentificacion.Checked)
            {
                // Si está activado, oculta el botón
                pbArchivos.Visible = true;
                pbArchivos.Enabled = true;
                pbIdentificacionNueva.Visible = true;
                pbIdentificacionNueva.Enabled = true;
            }
            else
            {
                // Si está desactivado, muestra el botón
                pbArchivos.Visible = false;
                pbArchivos.Enabled = false;
                pbIdentificacionNueva.Visible = false;
                pbIdentificacionNueva.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos vacíos
                if (string.IsNullOrEmpty(txtNombreNuevo.Text) ||
                    string.IsNullOrEmpty(txtTelefonoNuevo.Text) ||
                    string.IsNullOrEmpty(txtCorreoNuevo.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
                    return;
                }

                string correo = txtCorreoNuevo.Text;
                if (EsCorreoValido(correo))
                {
                    // ... (Aquí puedes realizar otras acciones, como guardar el correo o habilitar otro control) ...

                    if (switchIdentificacion.Checked)
                    {
                        if (!string.IsNullOrEmpty(rutaIdentificacion))
                        {
                            try
                            {
                                int id = idSeleccionado;
                                byte[] identificacion = File.ReadAllBytes(rutaIdentificacion);
                                string nombre = txtNombreNuevo.Text;
                                string telefono = txtTelefonoNuevo.Text;

                                // Crea una instancia de la clase Clientes (si es necesario)
                                Clientes enlace = new Clientes();

                                // Llamar al método de actualización en la base de datos
                                if (miConexion.AbrirConexion())
                                {
                                    bool resultado = enlace.ActualizarCliente(id, nombre, telefono, correo, identificacion);
                                    miConexion.CerrarConexion();

                                    if (resultado)
                                    {
                                        MessageBox.Show("Cliente actualizado correctamente.");
                                        CargarDatos();
                                        CargarDatosEliminar();
                                        CargarDatosModificar();
                                        // ... (código para limpiar los controles) ...
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al actualizar el cliente.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al actualizar el cliente: {ex.Message}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor selecciona una imagen.");
                        }
                    }
                    else
                    {
                        try
                        {
                            int id = idSeleccionado;
                            string nombre = txtNombreNuevo.Text;
                            string telefono = txtTelefonoNuevo.Text;

                            // Crea una instancia de la clase Clientes (si es necesario)
                            Clientes enlace = new Clientes();

                            // Llamar al método de actualización en la base de datos
                            if (miConexion.AbrirConexion())
                            {
                                bool resultado = enlace.ActualizarClienteSinFoto(id, nombre, telefono, correo);
                                miConexion.CerrarConexion();

                                if (resultado)
                                {
                                    MessageBox.Show("Cliente actualizado correctamente.");
                                    CargarDatos();
                                    CargarDatosEliminar();
                                    CargarDatosModificar();
                                    // ... (código para limpiar los controles) ...
                                }
                                else
                                {
                                    MessageBox.Show("Error al actualizar el cliente.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al actualizar el cliente: {ex.Message}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El correo electrónico no es válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}");
            }
        }

        private void pbArchivos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Has hecho clic en la imagen!");

            // Crea una instancia de OpenFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Configura las propiedades del OpenFileDialog (opcional)
            openFileDialog1.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.Title = "Selecciona una imagen";

            // Muestra el OpenFileDialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Si el usuario selecciona un archivo, obtén la ruta del archivo

                string rutaArchivo = openFileDialog1.FileName;
                rutaIdentificacion = rutaArchivo;

                // Haz algo con la ruta del archivo, por ejemplo, mostrar la imagen en el PictureBox
                pbIdentificacionNueva.Image = Image.FromFile(rutaArchivo);
                pbIdentificacionNueva.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void tabRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientesEliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtClientesEliminar_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox
            string filtro = txtClientesEliminar.Text;

            // Obtener el DataTable del DataView (si existe)
            DataTable dt = null;
            if (dgvClientesEliminar.DataSource is DataView dataView)
            {
                dt = dataView.Table;
            }
            else if (dgvClientesEliminar.DataSource is DataTable dataTable)
            {
                dt = dataTable;
            }
            else
            {
                // Si no hay DataSource, crear uno nuevo
                dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Numero_telefonico", typeof(string));
                dt.Columns.Add("Correo", typeof(string));
                dt.Columns.Add("Estado", typeof(string));
                dgvClientesEliminar.DataSource = dt;
            }

            // Crear un nuevo DataView a partir del DataTable original
            DataView dv = new DataView(dt);

            // Aplicar el filtro al DataView, solo si el TextBox no está vacío
            if (!string.IsNullOrEmpty(filtro))
            {
                dv.RowFilter = $"Nombre LIKE '%{filtro}%'"; // Filtrar por la columna "Nombre"
            }

            // Asignar el DataView (filtrado o no) al DataGridView
            dgvClientesEliminar.DataSource = dv;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora la tecla presionada si no es un número
            }
        }

        private void txtTelefonoNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora la tecla presionada si no es un número
            }
        }
        private bool EsCorreoValido(string correo)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(correo);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

private void tcClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcClientes.SelectedIndex == 0) 
            {
                LimpiarModificar();
            }
            if (tcClientes.SelectedIndex == 1)
            {
                LimpiarModificar();
            }
            if (tcClientes.SelectedIndex == 2)
            {
                LimpiarModificar();
            }
            if (tcClientes.SelectedIndex == 3)
            {
                LimpiarModificar();
            }
        }
        private void LimpiarModificar()
        {
            txtNombreNuevo.Text = "";
            txtCorreoNuevo.Text = "";
            txtTelefonoNuevo.Text = "";
            pbIdentificacionNueva.Image = null;
            pbIdentificacionAntes.Image = null;
            txtNombreAntes.Text = "";
            txtCorreoAntes.Text = "";
            txtTelefonoAntes.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            pb.Image = null;
            pb1.Image = null;
        }

        //------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------ELIMINAR----------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------
    }
}

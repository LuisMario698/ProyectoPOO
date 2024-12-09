using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        private bool conexionAbierta = false;
        public string rutaIdentificacion = "";
        public int idSeleccionado {  get; set; }
        public formClientes()
        {
            InitializeComponent();
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
                        string consulta = "SELECT Id, Nombre, Numero_telefonico, Correo FROM clientes";
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
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            if (!string.IsNullOrEmpty(rutaIdentificacion))
            {
                byte[] identificacion = File.ReadAllBytes(rutaIdentificacion);
                try
                {

                    if (miConexion.AbrirConexion())
                    {

                        // Crear una instancia de InventarioProducto
                        Clientes cliente = new Clientes(nombre, telefono, correo, identificacion);

                        // Llamar al método GuardarEnBaseDeDatos
                        cliente.GuardarDB();

                        // Mostrar un mensaje de confirmación
                        MessageBox.Show("Cliente guardado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    MessageBox.Show($"Error al guardar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Por favor selecciona una imagen.");
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
                        string consulta = "SELECT Id, Nombre, Numero_telefonico, Correo FROM clientes";
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

                        
                           
                            // Mostrar información del producto
                        MessageBox.Show($"Seleccionaste el producto: {nombre}\nTelefono: {telefono}\nCorreo: {correo}");

                        formClientesModificar modificar = new formClientesModificar
                        {
                            idRecivido = idSeleccionado,
                            Nombre = nombre,
                            Telefono = telefono,
                            Correo = correo
                        };

                        // Obtener la imagen del producto
                        BuscarImagen imagen = new BuscarImagen();

                        if (imagen.Existe(idSeleccionado))
                        {
                            Image imagenEncontrada = imagen.ObtenerImagenPorId(idSeleccionado);

                            if (imagenEncontrada != null)
                            {
                                modificar.Identificacion = imagenEncontrada; // Asignar la imagen encontrada
                            }
                            else
                            {
                                MessageBox.Show("No se encontró la imagen para el cliente seleccionado.");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"No hay ningún cliente con el ID: {idSeleccionado}");
                        }

                        modificar.ShowDialog();
                        modificar.Activate();
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
                        string consulta = "SELECT Id, Nombre, Numero_telefonico, Correo FROM clientes";
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
                    MessageBox.Show("Producto eliminado correctamente.");
                    //dgvClientesEliminar.Rows.Clear();
                    // Aquí puedes refrescar el DataGridView u otras acciones necesarias
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

                    // Validar y convertir el ID
                    if (filaSeleccionada.Cells["Id"].Value != null &&
                        int.TryParse(filaSeleccionada.Cells["Id"].Value.ToString(), out int id))
                    {
                        idSeleccionado = id; // Asigna el ID seleccionado
                        MessageBox.Show("El id seleccionado fue " + idSeleccionado);
                    }
                    else
                    {
                        MessageBox.Show("El ID del producto no es válido.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}");
            }
        }

        //------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------ELIMINAR----------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------
    }
}

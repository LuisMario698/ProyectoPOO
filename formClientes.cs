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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto
{
    public partial class formClientes : Form
    {
        Conexion miConexion;
        private bool conexionAbierta = false;
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

            CargarDatos();

        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            formHabitaciones habitaciones = new formHabitaciones();
            habitaciones.ShowDialog();
        }

        private void formClientes_Load(object sender, EventArgs e)
        {
            
            // Carga la imagen en el PictureBox
            pb1.Image = Image.FromFile("C:/Users/LuisM/Downloads/file.png");

            // Ajusta la imagen al tamaño del PictureBox
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
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

                // Haz algo con la ruta del archivo, por ejemplo, mostrar la imagen en el PictureBox
                pb.Image = Image.FromFile(rutaArchivo);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            int telefono = Convert.ToInt32(txtTelefono.Text);


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
    }
}

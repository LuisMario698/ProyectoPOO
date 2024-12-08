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
    public partial class formClientes : Form
    {
        Conexion miConexion;
        public formClientes()
        {
            InitializeComponent();
            dgvClientes.ColumnCount = 4;
            dgvClientes.Columns[0].Name = "Id";
            dgvClientes.Columns[1].Name = "Nombre";
            dgvClientes.Columns[2].Name = "Numero Telefonico";
            dgvClientes.Columns[3].Name = "Correo Electronico";

            dgvClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
                int id;
                string nombre = "";
                int telefono;
                string correo = "";

                MySqlDataReader mySqlDataReader = null;
                string consulta = "select * from clientes";

                if (miConexion.ObtenerConexion() != null)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta, miConexion.ObtenerConexion());
                    mySqlDataReader = mySqlCommand.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {
                        id = mySqlDataReader.GetInt32("Id");
                        nombre = mySqlDataReader.GetString("Nombre");
                        telefono = mySqlDataReader.GetInt32("Numero_telefonico");
                        correo = mySqlDataReader.GetString("Correo");
                        dgvClientes.Rows.Add(id, nombre, telefono, correo);
                    }
                }
                else
                {
                    MessageBox.Show("Error al conectar");
                }
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
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
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto
{
    public partial class formClientesModificar : Form
    {
        Clientes enlace;
        public int idRecivido {  get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public Image Identificacion { get; set; }
        public string rutaIdentificacion { get; set; }
        public formClientesModificar()
        {
            InitializeComponent();
            

            this.CenterToScreen();
        }

        private void formClientesModificar_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            pbIdentificacion.Visible = true;
            pbArchivos.Enabled = false;
            pbArchivos.Visible = false;

            txtNombre.Text = Nombre;
            txtNombre.Enabled = false;
            txtTelefono.Text = Telefono;
            txtTelefono.Enabled = false;
            txtCorreo.Text = Correo;
            txtCorreo.Enabled = false;
            
            txtNombreNuevo.Text = Nombre;
            txtTelefonoNuevo.Text = Telefono;
            txtCorreoNuevo.Text = Correo;

            pbIdentificacion.Enabled = false;

            pbFlecha1.Image = Properties.Resources.flecha;
            pbFlecha1.SizeMode = PictureBoxSizeMode.Zoom;
            pbFlecha2.Image = Properties.Resources.flecha;
            pbFlecha2.SizeMode = PictureBoxSizeMode.Zoom;
            pbFlecha3.Image = Properties.Resources.flecha;
            pbFlecha3.SizeMode = PictureBoxSizeMode.Zoom;
            pbArchivos.Image = Properties.Resources.file;
            pbArchivos.SizeMode = PictureBoxSizeMode.Zoom;

            if (Identificacion != null)
            {
                pbIdentificacion.Image = Identificacion;
                pbIdentificacion.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                // Mostrar un mensaje de error o una imagen por defecto
                MessageBox.Show("No se ha cargado ninguna imagen.");
                // O bien:
                pbIdentificacion.Image = Properties.Resources.equis;
                pbIdentificacion.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void pnHeader_WorkingArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbArchivos_Click(object sender, EventArgs e)
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
                pbIdentificacionNueva.Image = Image.FromFile(rutaArchivo);
                pbIdentificacionNueva.SizeMode = PictureBoxSizeMode.Zoom;
            }
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
            // Validar que el ID esté presente y sea válido
            if (switchIdentificacion.Checked)
            {
                if (!string.IsNullOrEmpty(rutaIdentificacion))
                {
                    int id = idRecivido;
                    byte[] identificacion = File.ReadAllBytes(rutaIdentificacion);
                    string nombre = txtNombreNuevo.Text;
                    string telefono = txtTelefonoNuevo.Text;
                    string correo = txtCorreoNuevo.Text;
                    enlace = new Clientes();
                    // Llamar al método de actualización en la base de datos
                    bool resultado = enlace.ActualizarCliente(id, nombre, telefono, correo, identificacion);

                    if (resultado)
                    {
                        MessageBox.Show("Cliente actualizado correctamente.");
                        this.Close();
                        formClientes regresar = new formClientes();
                        regresar.TopMost = true;
                        regresar.Show();
                        regresar.Activate();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el cliente.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor selecciona una imagen.");
                }
            }
            else
            {
                int id = idRecivido;
                string nombre = txtNombreNuevo.Text;
                string telefono = txtTelefonoNuevo.Text;
                string correo = txtCorreoNuevo.Text;
                enlace = new Clientes();
                // Llamar al método de actualización en la base de datos
                bool resultado = enlace.ActualizarClienteSinFoto(id, nombre, telefono, correo);

                if (resultado)
                {
                    MessageBox.Show("Producto actualizado correctamente.");
                    //formClientes regresar = new formClientes();

                    this.Close();

                    /*regresar.TopMost = true;
                    regresar.Show();
                    regresar.Activate();
                    */
                }
                else
                {
                    MessageBox.Show("Error al actualizar el producto.");
                }
            }
        }

        private void txtNombreNuevo_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreNuevo.Text.Length == 10)
            {
                btnModificar.Enabled = true; // Habilita el botón
            }
            else
            {
                btnModificar.Enabled = false; // Deshabilita el botón
            }
        }

        private void txtTelefonoNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora la tecla presionada si no es un número
            }

            // Verifica si el TextBox ya tiene 10 dígitos
            if (txtTelefonoNuevo.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora la tecla presionada si ya hay 10 dígitos
            }
        }

        private void txtCorreoNuevo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Intenta crear un MailAddress con el texto del TextBox
                MailAddress mailAddress = new MailAddress(txtCorreoNuevo.Text);

                btnModificar.Enabled = true; // Habilita el botón si el correo es válido
            }
            catch (FormatException)
            {
                btnModificar.Enabled = false; // Deshabilita el botón si el correo no es válido
            }
        }

        private void txtNombreNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y espacios
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Ignorar la tecla si no es una letra o un espacio
            }
        }
    }
}

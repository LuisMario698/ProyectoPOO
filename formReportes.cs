using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Proyecto.Habitaciones;

namespace Proyecto
{
    public partial class formReportes : Form
    {
        private Conexion miConexion;

        public formReportes()
        {
            InitializeComponent();
            ConfigurarDataGridViews();
        }

        private void formReportes_Load(object sender, EventArgs e)
        {
            CargarHabitaciones();
            CargarReservas();
            CargarClientes();
        }

        private void ConfigurarDataGridViews()
        {

            // Configurar DataGridView para Ingresos
            dgvReservas.ColumnCount = 3;
            dgvReservas.Columns[0].Name = "Fecha";
            dgvReservas.Columns[1].Name = "Reserva ID";
            dgvReservas.Columns[2].Name = "Total";
            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configurar DataGridView para Clientes
            dgvClientes.ColumnCount = 2;
            dgvClientes.Columns[0].Name = "Nombre";
            dgvClientes.Columns[1].Name = "Reservas";
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void CargarHabitaciones()
        {
            miConexion = new Conexion();
            try
            {
                using (MySqlConnection conexion = miConexion.ObtenerConexion())
                {
                    string consulta = "SELECT Numero, Tipo, Estado FROM habitaciones";
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    dgvHabitaciones.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar habitaciones: " + ex.Message);
            }
        }

        private void CargarReservas()
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

                        // Cerrar la conexión después de cargar los datos
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


        private void CargarClientes()
        {
            try
            {
                // Limpiar el DataGridView antes de cargar los nuevos datos
                dgvClientes.Rows.Clear();

                // Establecer la conexión a la base de datos
                using (var conexion = miConexion.ObtenerConexion())
                {
                    // Definir la consulta SQL para obtener los clientes
                    string query = "SELECT id_cliente, nombre, apellido, email, telefono FROM clientes";

                    // Crear un comando y establecer la consulta y la conexión
                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    // Abrir la conexión
                    conexion.Open();

                    // Ejecutar la consulta y obtener los resultados
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Recorrer los resultados y agregar las filas al DataGridView
                    while (reader.Read())
                    {
                        // Añadir una fila con los datos de cada cliente
                        dgvClientes.Rows.Add(reader["id_cliente"], reader["nombre"], reader["apellido"], reader["email"], reader["telefono"]);
                    }

                    // Cerrar el lector de datos
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }


        private void ExportarDataGridViewAExcel(DataGridView dgv, string nombreArchivo)
        {
            try
            {
                // Crear la aplicación de Excel
                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                // Agregar encabezados de columna
                for (int i = 1; i <= dgv.Columns.Count; i++)
                {
                    excelApp.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                }

                // Agregar datos de las celdas
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
                    }
                }

                // Configurar formato de columnas
                excelApp.Columns.AutoFit();

                // Guardar archivo
                var saveFileDialog = new SaveFileDialog
                {
                    FileName = nombreArchivo,
                    DefaultExt = ".xlsx",
                    Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    excelApp.ActiveWorkbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Datos exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Cerrar la aplicación de Excel
                excelApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mostrar opciones para exportar
            var opcion = MessageBox.Show(
                "¿Qué reporte deseas exportar?\n\n" +
                "Sí: Habitaciones\n" +
                "No: Ingresos\n" +
                "Cancelar: Clientes",
                "Seleccionar Reporte",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            switch (opcion)
            {
                case DialogResult.Yes: // Exportar Habitaciones
                    ExportarDataGridViewAExcel(dgvHabitaciones, "Reporte_Habitaciones");
                    break;

                case DialogResult.No: // Exportar Ingresos
                    ExportarDataGridViewAExcel(dgvReservas, "Reporte_Ingresos");
                    break;

                case DialogResult.Cancel: // Exportar Clientes
                    ExportarDataGridViewAExcel(dgvClientes, "Reporte_Clientes");
                    break;

                default:
                    MessageBox.Show("Exportación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}

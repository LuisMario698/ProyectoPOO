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
                Name = "Reservas",
                DataPropertyName = "Reservas", // Nombre de la columna en el DataTable
                HeaderText = "Reservas"
            });

            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvClientes.Columns[0].Width = 30;

            dgvClientes.ColumnHeadersHeight = 40;

            dgvHabitaciones.AutoGenerateColumns = false; // Desactiva la generación automática

            // Configura las columnas y vincúlalas a los nombres del DataTable
            dgvHabitaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Numero",
                DataPropertyName = "Numero", // Nombre de la columna en el DataTable
                HeaderText = "Numero"
            });
            dgvHabitaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Tipo",
                DataPropertyName = "Tipo", // Nombre de la columna en el DataTable
                HeaderText = "Tipo"
            });
            dgvHabitaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                DataPropertyName = "Estado", // Nombre de la columna en el DataTable
                HeaderText = "Estado"
            });

            dgvHabitaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvClientes.Columns[0].Width = 30;

            dgvHabitaciones.ColumnHeadersHeight = 40;
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
            dgvReservas.AutoGenerateColumns = false; // Desactiva la generación automática

            // Configura las columnas y vincúlalas a los nombres del DataTable
            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fecha",
                DataPropertyName = "Fecha", // Nombre de la columna en el DataTable
                HeaderText = "Fecha"
            });
            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id", // Nombre de la columna en el DataTable
                HeaderText = "Id"
            });
            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Total",
                DataPropertyName = "Total", // Nombre de la columna en el DataTable
                HeaderText = "Total"
            });

            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvReservas.ColumnHeadersHeight = 40;

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
                        string consulta = "SELECT Fecha, Id, Total FROM pagos";
                        MySqlCommand comando = new MySqlCommand(consulta, conexion);

                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);

                        dgvReservas.DataSource = dt;
                        dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                        decimal sumaTotal = 0;
                        foreach (DataGridViewRow row in dgvReservas.Rows)
                        {
                            if (row.Cells["Total"].Value != null &&
                                decimal.TryParse(row.Cells["Total"].Value.ToString(), out decimal totalFila))
                            {
                                sumaTotal += totalFila;
                            }
                        }

                        // Mostrar la suma en el Label
                        lblTotalPagado.Text = sumaTotal.ToString();

                        miConexion.CerrarConexion();
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
            miConexion = new Conexion();

            try
            {
                using (MySqlConnection conexion = miConexion.ObtenerConexion())
                {
                    if (miConexion.AbrirConexion())
                    {
                        string consulta = "SELECT Id, Nombre, Reservas FROM clientes";
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
            // Crear un menú contextual con las opciones de los reportes
            ContextMenuStrip menu = new ContextMenuStrip();

            // Agregar las opciones del menú para los reportes
            menu.Items.Add("Clientes", null, (senderMenu, eMenu) => ExportarDataGridViewAExcel(dgvClientes, "Reporte_Clientes"));
            menu.Items.Add("Habitaciones", null, (senderMenu, eMenu) => ExportarDataGridViewAExcel(dgvHabitaciones, "Reporte_Habitaciones"));
            menu.Items.Add("Reservas", null, (senderMenu, eMenu) => ExportarDataGridViewAExcel(dgvReservas, "Reporte_Reservas"));

            // Mostrar el menú en la posición del cursor (puedes ajustar la posición si lo deseas)
            menu.Show(Cursor.Position);

        }
    }
}

using MySql.Data.MySqlClient;
using PrevioClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrevioClubDeportivo.InterfazGrafica
{
    public partial class frmVencimientosDelDia : Form
    {
        public frmVencimientosDelDia()
        {
            InitializeComponent();
        }

        private void frmVencimientosDelDia_Load(object sender, EventArgs e)
        {
            CargarSociosConCuotasVencidasHoy();
            ActualizarSociosMorosos();
        }

        /* Función que pregunta si queres salir */
        private bool ConfirmarSalida()
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro que deseas salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            return (respuesta == DialogResult.Yes);
        }

        /* Utilizamos una variable de control para evitar la recursión involuntaria*/
        private bool estaCerrando = false;

        /* Cuando cerramos el formulario principal, cerramos la aplicación */
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!estaCerrando && e.CloseReason == CloseReason.UserClosing)
            {
                /* Primero cancela el cierre automático */
                e.Cancel = true;

                if (ConfirmarSalida())
                {
                    /* Marca que estamos cerrando */
                    estaCerrando = true;
                    /* Cierra la aplicación */
                    Application.Exit();
                }
            }
            else
            {
                /* Permite el cierre normal si no es por usuario */
                base.OnFormClosing(e);
            }
        }

        private void CargarSociosConCuotasVencidasHoy()
        {
            try
            {
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    // Consulta para obtener socios con cuotas que vencen hoy
                    string query = @"SELECT 
                    s.numeroSocio,
                    s.tipoSocio,
                    per.nombre,
                    per.apellido,
                    per.tipoDocumento,
                    per.nroDocumento,
                    p.vencimiento,
                    IFNULL(DATEDIFF(p.vencimiento, CURDATE()), 0) AS diasVencimiento
                    FROM Pagos p
                    JOIN Socios s ON p.numeroSocio = s.numeroSocio
                    JOIN Personas per ON s.idPersona = per.idPersona
                    WHERE p.vencimiento = CURDATE()
                    AND s.tipoSocio = 'SOCIO'
                    ORDER BY p.vencimiento";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    // Configurar el DataGridView si hay datos
                    dtgvVencimientos.DataSource = dt;
                    ConfigurarColumnasDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar socios con cuotas vencidas: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                dtgvVencimientos.DataSource = null;
            }
        }

        private void ConfigurarColumnasDataGridView()
        {
            // Verificar si el DataGridView tiene datos (no crear un nuevo DataTable)
            if (dtgvVencimientos.Rows.Count > 0 && dtgvVencimientos.DataSource != null)
            {
                // Mostrar todas las columnas primero
                foreach (DataGridViewColumn col in dtgvVencimientos.Columns)
                {
                    col.Visible = true;
                }

                // Renombrar columnas
                dtgvVencimientos.Columns["numeroSocio"].HeaderText = "N° Socio";
                dtgvVencimientos.Columns["tipoSocio"].HeaderText = "Tipo Socio";
                dtgvVencimientos.Columns["nombre"].HeaderText = "Nombre";
                dtgvVencimientos.Columns["apellido"].HeaderText = "Apellido";
                dtgvVencimientos.Columns["tipoDocumento"].HeaderText = "Tipo Doc.";
                dtgvVencimientos.Columns["nroDocumento"].HeaderText = "N° Doc.";
                dtgvVencimientos.Columns["vencimiento"].HeaderText = "Vencimiento";
                dtgvVencimientos.Columns["diasVencimiento"].HeaderText = "Días Venc.";

                // Configurar formato de columnas
                dtgvVencimientos.Columns["vencimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";

                // Configurar ancho de columnas
                dtgvVencimientos.Columns["numeroSocio"].Width = 100;
                dtgvVencimientos.Columns["tipoSocio"].Width = 100;
                dtgvVencimientos.Columns["nombre"].Width = 100;
                dtgvVencimientos.Columns["apellido"].Width = 100;
                dtgvVencimientos.Columns["vencimiento"].Width = 100;
                dtgvVencimientos.Columns["diasVencimiento"].Width = 100;

                // Formato condicional para resaltar vencimientos
                dtgvVencimientos.CellFormatting += (sender, e) =>
                {
                    if (e.ColumnIndex == dtgvVencimientos.Columns["diasVencimiento"].Index && e.Value != null)
                    {
                        try
                        {
                            if (e.Value == DBNull.Value || string.IsNullOrWhiteSpace(e.Value.ToString()))
                            {
                                e.Value = "N/A";
                                return;
                            }

                            if (int.TryParse(e.Value.ToString(), out int dias))
                            {
                                if (dias == 0)
                                {
                                    e.Value = $" {dias} días - HOY";
                                }
                                else
                                {
                                    e.Value = dias.ToString();
                                }
                            }
                            else
                            {
                                e.Value = "N/A";
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Error al formatear celda: {ex.Message}");
                            e.Value = "Error";
                            e.CellStyle.BackColor = Color.LightGray;
                        }
                    }
                };
            }
            else
            {
                // Limpiar el DataGridView completamente
                dtgvVencimientos.DataSource = null;
                dtgvVencimientos.Columns.Clear();

                // Crear una columna para el mensaje
                DataGridViewTextBoxColumn columnaMensaje = new DataGridViewTextBoxColumn();
                columnaMensaje.Name = "mensaje";
                columnaMensaje.HeaderText = "No existen vencimientos en el día";
                dtgvVencimientos.Columns.Add(columnaMensaje);

                // Agregar una fila vacía para que se vea el mensaje
                dtgvVencimientos.Rows.Add();

                // Configurar el estilo del encabezado
                dtgvVencimientos.Columns["mensaje"].HeaderCell.Style.Font = new Font("Arial", 16, FontStyle.Italic);
                dtgvVencimientos.Columns["mensaje"].HeaderCell.Style.ForeColor = Color.DarkBlue;
                dtgvVencimientos.Columns["mensaje"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvVencimientos.Columns["mensaje"].Width = 841;

                // Ocultar encabezados de fila
                dtgvVencimientos.RowHeadersVisible = false;
            }
        }

        private void ActualizarSociosMorosos()
        {
            try
            {
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    // Consulta para actualizar socios y adherentes con cuotas vencidas hace más de 1 día
                    string updateQuery = @"
                        UPDATE Socios s
                        JOIN (
                            SELECT p.numeroSocio, MAX(p.vencimiento) as ultimoVencimiento
                            FROM Pagos p
                            GROUP BY p.numeroSocio
                            ) ult ON s.numeroSocio = ult.numeroSocio
                        SET s.tipoSocio = CASE
                                    WHEN s.tipoSocio = 'SOCIO' THEN 'INACTIVO'
                                    WHEN s.tipoSocio = 'NO_SOCIO' THEN 'INACTIVO'
                                    END,
                                    s.estadoCuota = 'VENCIDA'
                        WHERE DATEDIFF(CURDATE(), ult.ultimoVencimiento) >= 1
                        AND (s.tipoSocio = 'SOCIO' OR s.tipoSocio = 'NO_SOCIO')";

                    

                    MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Se actualizaron {rowsAffected} Socios/No Socios a INACTIVOS.",
                                      "Actualización exitosa",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);

                        //Recargamos la lista de socios para reflejar los cambios
                        CargarSociosConCuotasVencidasHoy();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar Socios/No Socios a INACTIVOS: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (ConfirmarSalida())
            {
                /* Regresa al formulario principal */
                frmHome home = new frmHome();
                home.Show();
                /* Ocultamos el formulario Registrar Socio*/
                this.Hide();
            }
            /* Si elige "No", no hace nada (se queda en el formulario actual) */
        }
    }
}

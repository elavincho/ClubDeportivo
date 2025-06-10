using MySql.Data.MySqlClient;
using PrevioClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrevioClubDeportivo.InterfazGrafica
{
    public partial class frmListaDeSocios : Form
    {
        public frmListaDeSocios()
        {
            InitializeComponent();
        }

        private void frmListaDeSocios_Load(object sender, EventArgs e)
        {
            CargarTodosLosSocios();
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
        
        private void CargarTodosLosSocios()
        {
            try
            {
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    // Consulta para obtener todos los socios
                    string query = @"SELECT 
                s.numeroSocio,
                s.tipoSocio,
                per.nombre,
                per.apellido,
                per.tipoDocumento,
                per.nroDocumento,
                per.fechaNacimiento,
                per.direccion,
                per.email,
                per.telefono,
                s.fechaAlta,
                s.fechaPago,
                s.estadoCuota,
                IFNULL(apt.vtoAptoFisico, 'No tiene') AS vtoAptoFisico,
                IFNULL(apt.nombreMedico, '') AS nombreMedico,
                IFNULL(apt.matricula, '') AS matricula,
                IFNULL(apt.esApto, '') AS esApto
                FROM Socios s
                JOIN Personas per ON s.idPersona = per.idPersona
                LEFT JOIN AptoFisico apt ON s.numeroSocio = apt.numeroSocio
                ORDER BY s.numeroSocio";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Configurar el DataGridView
                    dtgvListaSocios.DataSource = dt;
                    ConfigurarColumnasDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de socios: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                dtgvListaSocios.DataSource = null;
            }
        }

        private void ConfigurarColumnasDataGridView()
        {
            // Verificar si el DataGridView tiene datos
            if (dtgvListaSocios.Rows.Count > 0 && dtgvListaSocios.DataSource != null)
            {
                // Mostrar todas las columnas primero
                foreach (DataGridViewColumn col in dtgvListaSocios.Columns)
                {
                    col.Visible = true;
                }

                // Renombrar columnas
                dtgvListaSocios.Columns["numeroSocio"].HeaderText = "N° Socio";
                dtgvListaSocios.Columns["tipoSocio"].HeaderText = "Tipo Socio";
                dtgvListaSocios.Columns["nombre"].HeaderText = "Nombre";
                dtgvListaSocios.Columns["apellido"].HeaderText = "Apellido";
                dtgvListaSocios.Columns["tipoDocumento"].HeaderText = "Tipo Doc.";
                dtgvListaSocios.Columns["nroDocumento"].HeaderText = "N° Doc.";
                dtgvListaSocios.Columns["fechaNacimiento"].HeaderText = "Fecha Nac.";
                dtgvListaSocios.Columns["direccion"].HeaderText = "Dirección";
                dtgvListaSocios.Columns["email"].HeaderText = "Email";
                dtgvListaSocios.Columns["telefono"].HeaderText = "Teléfono";
                dtgvListaSocios.Columns["fechaAlta"].HeaderText = "Fecha Alta";
                dtgvListaSocios.Columns["estadoCuota"].HeaderText = "Estado Cuota";
                dtgvListaSocios.Columns["vtoAptoFisico"].HeaderText = "Vto. Apt. Físico";
                dtgvListaSocios.Columns["nombreMedico"].HeaderText = "Médico";
                dtgvListaSocios.Columns["matricula"].HeaderText = "Matrícula";
                dtgvListaSocios.Columns["esApto"].HeaderText = "Apto";

                // Configurar formato de columnas de fecha
                dtgvListaSocios.Columns["fechaNacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dtgvListaSocios.Columns["fechaAlta"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dtgvListaSocios.Columns["fechaPago"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dtgvListaSocios.Columns["vtoAptoFisico"].DefaultCellStyle.Format = "dd/MM/yyyy";

                // Configurar ancho de columnas
                dtgvListaSocios.Columns["numeroSocio"].Width = 70;
                dtgvListaSocios.Columns["tipoSocio"].Width = 80;
                dtgvListaSocios.Columns["nombre"].Width = 100;
                dtgvListaSocios.Columns["apellido"].Width = 100;
                dtgvListaSocios.Columns["direccion"].Width = 140;
                dtgvListaSocios.Columns["email"].Width = 140;
                dtgvListaSocios.Columns["fechaNacimiento"].Width = 90;
                dtgvListaSocios.Columns["fechaAlta"].Width = 90;
                dtgvListaSocios.Columns["fechaPago"].Width = 90;
                dtgvListaSocios.Columns["vtoAptoFisico"].Width = 100;

                // Opcional: Ocultar columnas que no son relevantes
                dtgvListaSocios.Columns["matricula"].Visible = false;
                dtgvListaSocios.Columns["nombreMedico"].Visible = false;
                dtgvListaSocios.Columns["esApto"].Visible = false;
                dtgvListaSocios.Columns["estadoCuota"].Visible = false;
                dtgvListaSocios.Columns["fechaPago"].Visible = false;
            }
            else
            {
                // Limpiar el DataGridView completamente
                dtgvListaSocios.DataSource = null;
                dtgvListaSocios.Columns.Clear();

                // Crear una columna para el mensaje
                DataGridViewTextBoxColumn columnaMensaje = new DataGridViewTextBoxColumn();
                columnaMensaje.Name = "mensaje";
                columnaMensaje.HeaderText = "No hay socios registrados";
                dtgvListaSocios.Columns.Add(columnaMensaje);

                // Agregar una fila vacía para que se vea el mensaje
                dtgvListaSocios.Rows.Add();

                // Configurar el estilo del encabezado
                dtgvListaSocios.Columns["mensaje"].HeaderCell.Style.Font = new Font("Arial", 16, FontStyle.Italic);
                dtgvListaSocios.Columns["mensaje"].HeaderCell.Style.ForeColor = Color.DarkBlue;
                dtgvListaSocios.Columns["mensaje"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvListaSocios.Columns["mensaje"].Width = 841;

                // Ocultar encabezados de fila
                dtgvListaSocios.RowHeadersVisible = false;
            }
        }
    }
}

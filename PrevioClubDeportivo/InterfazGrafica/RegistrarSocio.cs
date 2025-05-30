using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PrevioClubDeportivo.Datos;
using PrevioClubDeportivo.Entidades;
using PrevioClubDeportivo.InterfazGrafica;

namespace PrevioClubDeportivo
{
    public partial class frmRegistrarSocio : Form
    {
        public frmRegistrarSocio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (ConfirmarSalida())
            {
                /* Cierra completamente la aplicación */
                Application.Exit();
            }
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            /* Ocultar el formulario Registrar Socios */
            this.Hide();

            /* Abrimos el formulario principal */
            frmHome home = new frmHome();
            home.Show();
        }

        private void btnCobrarCuota_Click(object sender, EventArgs e)
        {
            /* Ocultamos el formulario Registrar Socio */
            this.Hide();

            /* Abrimos el formulario Cobrar Cuota */
            frmCobrarCuota cobrarCuota = new frmCobrarCuota();
            cobrarCuota.Show();
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

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    Socio nuevoSocio = ObtenerSocioDesdeFormulario();
                    if (!VerificarAptoFisicoExistente(nuevoSocio.numeroSocio))
                    {
                        MessageBox.Show("No existe un apto físico registrado para este número de socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    GuardarSocio(nuevoSocio);
                    MessageBox.Show("Socio registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    int proximoNumero = generadorNumerosSocios.ObtenerProximoNumero();
                    txtNroSocio.Text = proximoNumero.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"El Socio ya se encuentra registrado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Socio ObtenerSocioDesdeFormulario()
        {

            /* Creamos el socio */
            Socio socio = new Socio
            {
                /* Atributos heredados de Persona */
                nombre = txtNombre.Text.Trim(),
                apellido = txtApellido.Text.Trim(),
                tipoDocumento = lstTipoDoc.SelectedItem?.ToString() ?? "DNI",
                nroDocumento = txtNroDocumento.Text.Trim(),
                fechaNacimiento = dtpFecNac.Value,
                direccion = txtDireccion.Text.Trim(),
                email = txtEmail.Text.Trim(),
                telefono = txtTelefono.Text.Trim(),

                /* Atributos de Socio*/
                numeroSocio = int.Parse(txtNroSocio.Text),
                tipoSocio = lstTipoSocio.SelectedItem?.ToString() ?? "INACTIVO",
                fechaAlta = dtpFechaAlta.Value,
                fechaPago = dtpFechaPago.Value,
                estadoCuota = lstEstadoPago.SelectedItem?.ToString() ?? "IMPAGO"
            };

            return socio;
        }


        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtApellido.Text) ||
        string.IsNullOrWhiteSpace(txtNroDocumento.Text) ||
        string.IsNullOrWhiteSpace(txtDireccion.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text) ||
        string.IsNullOrWhiteSpace(txtTelefono.Text) ||
        lstTipoDoc.SelectedIndex == -1 ||
        lstTipoSocio.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtNroSocio.Text, out _))
            {
                MessageBox.Show("El número de socio debe ser un valor numérico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /* Limpiar Formulario */
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNroDocumento.Clear();
            dtpFecNac.Value = DateTime.Now;
            txtDireccion.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtNroSocio.Clear();
            lstTipoSocio.SelectedIndex = 0;
            dtpFechaAlta.Value = DateTime.Now;
            dtpFechaPago.Value = DateTime.Now;
            lstEstadoPago.SelectedIndex = 0;
        }


        private void GuardarSocio(Socio socio)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Primero insertamos la persona
                    string queryPersona = @"INSERT INTO Personas 
                          (nombre, apellido, tipoDocumento, nroDocumento, fechaNacimiento, direccion, email, telefono) 
                          VALUES 
                          (@nombre, @apellido, @tipoDocumento, @nroDocumento, @fechaNacimiento, @direccion, @email, @telefono);
                          SELECT LAST_INSERT_ID();";

                    MySqlCommand cmdPersona = new MySqlCommand(queryPersona, connection, transaction);
                    cmdPersona.Parameters.AddWithValue("@nombre", socio.nombre);
                    cmdPersona.Parameters.AddWithValue("@apellido", socio.apellido);
                    cmdPersona.Parameters.AddWithValue("@tipoDocumento", socio.tipoDocumento);
                    cmdPersona.Parameters.AddWithValue("@nroDocumento", socio.nroDocumento);
                    cmdPersona.Parameters.AddWithValue("@fechaNacimiento", socio.fechaNacimiento);
                    cmdPersona.Parameters.AddWithValue("@direccion", socio.direccion ?? (object)DBNull.Value);
                    cmdPersona.Parameters.AddWithValue("@email", socio.email ?? (object)DBNull.Value);
                    cmdPersona.Parameters.AddWithValue("@telefono", socio.telefono ?? (object)DBNull.Value);

                    int idPersona = Convert.ToInt32(cmdPersona.ExecuteScalar());

                    // Insertamos el socio
                    string querySocio = @"INSERT INTO Socios 
                        (idPersona, numeroSocio, tipoSocio, fechaAlta, fechaPago, estadoCuota) 
                        VALUES 
                        (@idPersona, @numeroSocio, @tipoSocio, @fechaAlta, @fechaPago, @estadoCuota)";

                    MySqlCommand cmdSocio = new MySqlCommand(querySocio, connection, transaction);
                    cmdSocio.Parameters.AddWithValue("@idPersona", idPersona);
                    cmdSocio.Parameters.AddWithValue("@numeroSocio", socio.numeroSocio);
                    cmdSocio.Parameters.AddWithValue("@tipoSocio", socio.tipoSocio);
                    cmdSocio.Parameters.AddWithValue("@fechaAlta", socio.fechaAlta);
                    cmdSocio.Parameters.AddWithValue("@fechaPago", socio.fechaPago);
                    cmdSocio.Parameters.AddWithValue("@estadoCuota", socio.estadoCuota);

                    cmdSocio.ExecuteNonQuery();

                    transaction.Commit();

                    //MessageBox.Show($"Socio registrado con número: {socio.numeroSocio}");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error al guardar el socio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private void frmRegistrarSocio_Load(object sender, EventArgs e)
        {
            /* Configuración del ListBox*/

            /* Configurar lstTipoDoc */
            lstTipoDoc.Items.Add("DNI");
            lstTipoDoc.Items.Add("PASAPORTE");
            lstTipoDoc.Items.Add("CEDULA");
            lstTipoDoc.SelectedIndex = 0;

            /* Configurar lstTipoSocio */
            lstTipoSocio.Items.Add("INACTIVO");
            lstTipoSocio.Items.Add("ACTIVO");
            lstTipoSocio.Items.Add("ADHERENTE");
            lstTipoSocio.SelectedIndex = 0;

            /* Configurar lstEstadoPago */
            lstEstadoPago.Items.Add("IMPAGO");
            lstEstadoPago.Items.Add("AL DIA");
            lstEstadoPago.Items.Add("VENCIDO");
            lstEstadoPago.SelectedIndex = 0;

            /* Personalizamos el formato de la fecha*/
            dtpFechaAlta.CustomFormat = "dd/MM/yyyy";
            dtpFechaPago.CustomFormat = "dd/MM/yyyy";
            dtpFecNac.CustomFormat = "dd/MM/yyyy";

            try
            {
                int proximoNumero = generadorNumerosSocios.ObtenerProximoNumero();
                txtNroSocio.Text = proximoNumero.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar EL número: {ex.Message}");
            }
        }

        public class generadorNumerosSocios
        {
            public static int ObtenerProximoNumero()
            {
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    // Bloqueo de tabla para evitar concurrencia (opcional para entornos multi-usuario)
                    string queryLock = "LOCK TABLES Socios READ";
                    new MySqlCommand(queryLock, connection).ExecuteNonQuery();

                    try
                    {
                        string query = "SELECT COALESCE(MAX(numeroSocio), 0) FROM Socios";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        int ultimoNumero = Convert.ToInt32(cmd.ExecuteScalar());

                        return ultimoNumero + 1;
                    }
                    finally
                    {
                        // Liberar el bloqueo
                        string queryUnlock = "UNLOCK TABLES";
                        new MySqlCommand(queryUnlock, connection).ExecuteNonQuery();
                    }
                }
            }
        }

        private void btnCargarAptoFisico_Click(object sender, EventArgs e)
        {
            /* Ocultamos el formulario Registrar Socio */
            //this.Hide();

            /* Abrimos el formulario Apto Físico */
            frmAptoFisico aptoFisico = new frmAptoFisico();
            aptoFisico.Show();
        }

        private bool VerificarAptoFisicoExistente(int numeroSocio)
        {
            try
            {
                using (var connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    const string query = "SELECT 1 FROM AptoFisico WHERE numeroSocio = @numeroSocio LIMIT 1";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@numeroSocio", numeroSocio);
                        return cmd.ExecuteScalar() != null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar apto físico: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnEntregarCarnet_Click(object sender, EventArgs e)
        {
            /* Ocultamos el formulario Registrar Socio */
            this.Hide();

            /* Abrimos el formulario Carnet */
            frmCarnet carnet = new frmCarnet();
            carnet.Show();
        }

        private void btnVencimientosDelDia_Click(object sender, EventArgs e)
        {
            /* Ocultamos el formulario Registrar Socio */
            this.Hide();

            /* Abrimos el formulario Vencimientos del día */
            frmVencimientosDelDia vencimientos = new frmVencimientosDelDia();
            vencimientos.Show();
        }
    }
}

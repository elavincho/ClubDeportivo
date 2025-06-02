using MySql.Data.MySqlClient;
using PrevioClubDeportivo.Datos;
using System;
using System.Windows.Forms;

namespace PrevioClubDeportivo.InterfazGrafica
{
    public partial class frmCobrarCuota : Form
    {
        public frmCobrarCuota()
        {
            InitializeComponent();
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

        private void btnCobrar_Click(object sender, EventArgs e)
        {

            /* ************************* PROVISORIO ********************************  */
            /* Abrimos el formulario Comprobante de pago */
            frmComprobantePago comprobante = new frmComprobantePago();
            comprobante.Show();

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


        public class generadorNumeroComprobante
        {
            public static int ObtenerProximoNumero()
            {
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    // Bloqueo de tabla para evitar concurrencia (opcional para entornos multi-usuario)
                    string queryLock = "LOCK TABLES Pagos READ";
                    new MySqlCommand(queryLock, connection).ExecuteNonQuery();

                    try
                    {
                        string query = "SELECT COALESCE(MAX(nroComprobante), 0) FROM Pagos";
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

        private void frmCobrarCuota_Load(object sender, EventArgs e)
        {

            dtpFecha.Value = DateTime.Now;

            dtpFecha.CustomFormat = "dd/MM/yy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpVencimiento.CustomFormat = "dd/MM/yy";
            dtpVencimiento.Format = DateTimePickerFormat.Custom;


            try
            {
                int proximoNumero = generadorNumeroComprobante.ObtenerProximoNumero();
                txtNroComprobante.Text = proximoNumero.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar EL número: {ex.Message}");
            }
        }

        private void txtNroSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (!string.IsNullOrEmpty(txtNroSocio.Text))
                {

                    using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                    {

                        try
                        {
                            if (!int.TryParse(txtNroSocio.Text, out int numeroSocio))
                            {
                                MessageBox.Show("El número de socio debe ser un valor numérico válido.");
                                txtNombre.Text = "";
                                txtApellido.Text = "";
                                //esAptoValido = false;
                                return;
                            }

                            connection.Open();
                            string query = "SELECT p.nombre, p.apellido, af.esApto, af.vtoAptoFisico " +
                                          "FROM Personas p " +
                                          "JOIN Socios s ON p.idPersona = s.idPersona " +
                                          "LEFT JOIN AptoFisico af ON s.numeroSocio = af.numeroSocio " +
                                          "WHERE s.numeroSocio = @numeroSocio";
                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@numeroSocio", numeroSocio);
                            MySqlDataReader reader = cmd.ExecuteReader();

                            if (reader.Read())
                            {
                                txtNombre.Text = reader["nombre"].ToString();
                                txtApellido.Text = reader["apellido"].ToString();

                                /*if (reader["esApto"] != DBNull.Value)
                                {
                                    string esApto = reader["esApto"].ToString();
                                    DateTime vtoApto = Convert.ToDateTime(reader["vtoAptoFisico"]);
                                    if (esApto == "Apto" && vtoApto >= DateTime.Now)
                                    {
                                        esAptoValido = true;
                                    }
                                    else
                                    {
                                        esAptoValido = false;
                                        MessageBox.Show("El socio no está apto físicamente o el apto físico ha vencido.");
                                    }
                                }
                                else
                                {
                                    esAptoValido = false;
                                    MessageBox.Show("El socio no tiene un apto físico registrado.");
                                }*/
                            }
                            else
                            {
                                txtNombre.Text = "";
                                txtApellido.Text = "";
                                //esAptoValido = false;
                                MessageBox.Show("Socio no encontrado.");
                            }
                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                            //esAptoValido = false;
                        }
                        finally
                        {
                            if (connection.State == System.Data.ConnectionState.Open)
                                connection.Close();
                        }
                    }
                }
                else
                {
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    //esAptoValido = false;
                    MessageBox.Show("Por favor, ingrese un número de socio.");
                }
            }
        }

        private void rbMensual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMensual.Checked)
            {
                lstActividad.Enabled = false;
                lstActividad.Items.Clear();
                lstActividad.Items.Add("LIBRE");
                lstActividad.SelectedIndex = 0;
                txtImporte.Text = "20000";
                dtpVencimiento.Value = DateTime.Now.AddMonths(1);
            }
        }

        private void rbDiaria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDiaria.Checked)
            {
                lstActividad.Enabled = true;
                lstActividad.Items.Clear();
                lstActividad.Items.AddRange(new string[] { "Yoga", "Boxeo", "Pilates", "Spinning", "Musculacion", "Cardio" });
                lstActividad.SelectedIndex = -1;
                txtImporte.Text = "10000";
                dtpVencimiento.Value = DateTime.Now;
            }
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                lstCuotas.Items.Clear();
                lstCuotas.Items.Add("1");
                lstCuotas.SelectedIndex = 0;
            }
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTarjeta.Checked)
            {
                lstCuotas.Items.Clear();
                lstCuotas.Items.AddRange(new string[] { "1", "3", "6" });
                lstCuotas.SelectedIndex = 0;
            }
        }

        private void rbQR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQR.Checked)
            {
                lstCuotas.Items.Clear();
                lstCuotas.Items.AddRange(new string[] { "1", "3", "6" });
                lstCuotas.SelectedIndex = 0;
            }
        }
    }
}

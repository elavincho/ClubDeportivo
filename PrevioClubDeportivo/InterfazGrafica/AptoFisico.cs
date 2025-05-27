using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PrevioClubDeportivo.Datos;
using PrevioClubDeportivo.Entidades;

namespace PrevioClubDeportivo.InterfazGrafica
{
    public partial class frmAptoFisico : Form
    {
        public frmAptoFisico()
        {
            InitializeComponent();
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
                    /* Ocultamos el formulario Apto Físico*/
                    this.Hide();
                }
            }
            else
            {
                /* Permite el cierre normal si no es por usuario */
                base.OnFormClosing(e);
            }
        }

        private void frmAptoFisico_Load(object sender, EventArgs e)
        {
            /* Configuración del ListBox*/

            /* Configuración lstTipoDoc */
            lstEsApto.Items.Add("SELECCIONE");
            lstEsApto.Items.Add("NO");
            lstEsApto.Items.Add("SI");
            lstEsApto.SelectedIndex = 0;


            /* Personalizamos el formato de la fecha*/
            dtpVencimiento.CustomFormat = "dd/MM/yyyy";

            /* Configurar fecha de vencimiento a 1 año desde hoy */
            dtpVencimiento.Value = DateTime.Today.AddYears(1);

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
                /* Ocultamos el formulario Apto Físico*/
                this.Hide();
            }
            /* Si elige "No", no hace nada (se queda en el formulario actual) */
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    AptFisico nuevoAptoFisico = ObtenerAptoFisicoDesdeFormulario();
                    GuardarAptoFisico(nuevoAptoFisico);
                    MessageBox.Show("Apto Físico guardado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /* Ocultar el formulario Apto Físico */
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Existe un Apto Físico con este número de socio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            /* Ocultar el formulario Apto Físico */
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


        private AptFisico ObtenerAptoFisicoDesdeFormulario()
        {
            /* Creamos el Apto Físico */
            AptFisico aptoFisico = new AptFisico();

            aptoFisico.numeroSocio = int.Parse(txtNroSocio.Text);
            aptoFisico.esApto = lstEsApto.SelectedItem?.ToString();
            aptoFisico.vtoAptoFisico = dtpVencimiento.Value;

            return aptoFisico;
        }

        private bool ValidarCampos()
        {
            if (lstEsApto.SelectedIndex == 0 && lstEsApto.Items.Contains("SELECCIONE"))
            {
                MessageBox.Show("Por favor seleccione SI o NO para el campo 'Es Apto'.", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }



        private void GuardarAptoFisico(AptFisico aptFisico)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Insertamos el Apto Físico
                    string queryAptoFisico = @"INSERT INTO AptoFisico 
                        (idAptoFisico, numeroSocio, esApto, vtoAptoFisico) 
                        VALUES 
                        (@idAptoFisico, @numeroSocio, @esApto, @vtoAptoFisico)";

                    MySqlCommand cmdAptoFisico = new MySqlCommand(queryAptoFisico, connection, transaction);
                    cmdAptoFisico.Parameters.AddWithValue("@idAptoFisico", aptFisico.idAptoFisico);
                    cmdAptoFisico.Parameters.AddWithValue("@numeroSocio", aptFisico.numeroSocio);
                    cmdAptoFisico.Parameters.AddWithValue("@esApto", aptFisico.esApto);
                    cmdAptoFisico.Parameters.AddWithValue("@vtoAptoFisico", aptFisico.vtoAptoFisico);


                    cmdAptoFisico.ExecuteNonQuery();

                    transaction.Commit();

                    //MessageBox.Show($"Apto físico registrado con número de socio: {socio.numeroSocio}");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    //MessageBox.Show($"Error al guardar el Apto Físico: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
            }
        }
    }
}

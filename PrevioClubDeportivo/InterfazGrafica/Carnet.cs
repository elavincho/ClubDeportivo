using MySql.Data.MySqlClient;
using PrevioClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrevioClubDeportivo.InterfazGrafica
{
    public partial class frmCarnet : Form
    {
        public frmCarnet()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (ConfirmarSalida())
            {
                /* Regresa al formulario principal */
                frmHome home = new frmHome();
                home.Show();
                /* Ocultamos el formulario Entregar Carnet*/
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
                    /* Ocultamos el formulario Carnet*/
                    this.Hide();
                    /* Regresa al formulario principal */
                    frmHome home = new frmHome();
                    home.Show();
                }
            }
            else
            {
                /* Permite el cierre normal si no es por usuario */
                base.OnFormClosing(e);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNroSocio.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de socio.", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCamposSocio();
                return;
            }
            else if (!int.TryParse(txtNroSocio.Text, out int numeroSocio))
            {
                MessageBox.Show("El número de socio debe ser válido.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCamposSocio();
                return;
            }
            else if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar los campos obligatorios.", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCamposSocio();
                return;
            }
            else
            {
                // Imprimimos el carnet
                ImprimirFormularioCompleto();
            }
        }

        private void ImprimirFormularioCompleto()
        {
            // Guardar el estado original de los controles
            Dictionary<Control, bool> controlesOriginales = new Dictionary<Control, bool>();

            try
            {
                // Ocultar los controles que no quieres imprimir
                List<Control> controlesAOcultar = this.Controls
                    .OfType<Button>()
                    .Where(b => b.Name == "btnImprimir" || b.Name == "btnCerrar")
                    .Cast<Control>()
                    .ToList();

                foreach (Control control in controlesAOcultar)
                {
                    controlesOriginales[control] = control.Visible;
                    control.Visible = false;
                }

                PrintDocument pd = new PrintDocument();
                pd.PrintPage += (sender, e) =>
                {
                    Bitmap bmp = new Bitmap(this.Width, this.Height);
                    this.DrawToBitmap(bmp, this.ClientRectangle);

                    // Ajustar la imagen al área imprimible
                    RectangleF destRect = e.MarginBounds;
                    float ratio = Math.Min(
                        destRect.Width / bmp.Width,
                        destRect.Height / bmp.Height);

                    RectangleF srcRect = new RectangleF(0, 0, bmp.Width, bmp.Height);
                    destRect = new RectangleF(
                        destRect.X,
                        destRect.Y,
                        bmp.Width * ratio,
                        bmp.Height * ratio);

                    e.Graphics.DrawImage(bmp, destRect, srcRect, GraphicsUnit.Pixel);
                };

                PrintPreviewDialog preview = new PrintPreviewDialog();
                preview.Document = pd;
                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Restaurar la visibilidad original de los controles
                foreach (var kvp in controlesOriginales)
                {
                    kvp.Key.Visible = kvp.Value;
                }
            }
        }

        private void txtNroSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (string.IsNullOrEmpty(txtNroSocio.Text))
                {
                    MessageBox.Show("Por favor, ingrese un número de socio.", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCamposSocio();
                    return;
                }

                if (!int.TryParse(txtNroSocio.Text, out int numeroSocio))
                {
                    MessageBox.Show("El número de socio debe ser válido.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCamposSocio();
                    return;
                }

                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    try
                    {
                        connection.Open();

                        // Consulta para obtener el estado del socio
                        string queryEstado = "SELECT estadoCuota FROM Socios WHERE numeroSocio = @numeroSocio";

                        MySqlCommand cmdEstado = new MySqlCommand(queryEstado, connection);
                        cmdEstado.Parameters.AddWithValue("@numeroSocio", numeroSocio);

                        object resultado = cmdEstado.ExecuteScalar();

                        if (resultado == null)
                        {
                            MessageBox.Show("Socio no encontrado.", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LimpiarCamposSocio();
                            return;
                        }

                        // Si el socio está activo, cargar el resto de la información
                        string queryDatos = @"SELECT 
                                    per.nombre, per.apellido, s.numeroSocio, 
                                    s.tipoSocio, p.actividad, p.vencimiento
                                    FROM Socios s
                                    JOIN Personas per ON s.idPersona = per.idPersona
                                    LEFT JOIN Pagos p ON s.numeroSocio = p.numeroSocio
                                    WHERE s.numeroSocio = @numeroSocio
                                    ORDER BY p.fechaPago DESC
                                    LIMIT 1";

                        MySqlCommand cmdDatos = new MySqlCommand(queryDatos, connection);
                        cmdDatos.Parameters.AddWithValue("@numeroSocio", numeroSocio);

                        using (MySqlDataReader reader = cmdDatos.ExecuteReader())
                        {
                            LimpiarCamposSocio();

                            if (reader.Read())
                            {
                                // Verificar si el socio está inactivo primero
                                if (reader["tipoSocio"].ToString() == "INACTIVO")
                                {
                                    DialogResult result = MessageBox.Show(
                                        "El socio está INACTIVO. Debe pagar la cuota antes de imprimir el carnet.\n\n¿Desea proceder al pago ahora?",
                                        "Socio Inactivo",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning);

                                    if (result == DialogResult.Yes)
                                    {
                                        // Abrir formulario de pago
                                        AbrirFormularioPago(numeroSocio);
                                    }
                                    return; // No continuar con el proceso actual
                                }

                                txtNombre.Text = reader["nombre"].ToString();
                                txtApellido.Text = reader["apellido"].ToString();
                                txtTipo.Text = reader["tipoSocio"].ToString();
                                txtActividad.Text = reader.IsDBNull(reader.GetOrdinal("actividad")) ?
                                string.Empty : reader["actividad"].ToString();
                                dtpVencimiento.Text = reader.IsDBNull(reader.GetOrdinal("vencimiento")) ?
                                DateTime.Now.ToString("dd/MM/yyyy") :
                                Convert.ToDateTime(reader["vencimiento"]).ToString("dd/MM/yyyy");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al consultar socio: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimpiarCamposSocio();
                    }
                }
            }
        }

        private void LimpiarCamposSocio()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTipo.Text = "";
            txtActividad.Text = "";
            dtpVencimiento.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void AbrirFormularioPago(int numeroSocio)
        {
            // Instanciamos el formulario de pago y pasamos el número de socio
            frmCobrarCuota cobrarCuota = new frmCobrarCuota();
            cobrarCuota.CargarDatosSocio(numeroSocio); // Método que debes crear para precargar datos
            cobrarCuota.ShowDialog();
        }

        private void frmCarnet_Load(object sender, EventArgs e)
        {
            
            dtpVencimiento.CustomFormat = "dd/MM/yyyy";
        }
    }
}

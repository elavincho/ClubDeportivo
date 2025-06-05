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
            // Imprimimos el carnet
            ImprimirFormularioCompleto();

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
                                return;
                            }

                            connection.Open();
                            string query = @"SELECT per.nombre, per.apellido, s.numeroSocio, s.tipoSocio, p.actividad, p.vencimiento
                                FROM Socios s
                                JOIN Personas per ON s.idPersona = per.idPersona
                                LEFT JOIN Pagos p ON s.numeroSocio = p.numeroSocio
                                WHERE s.numeroSocio = @numeroSocio
                                ORDER BY p.fechaPago DESC
                                LIMIT 1";


                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@numeroSocio", numeroSocio);
                            MySqlDataReader reader = cmd.ExecuteReader();

                            if (reader.Read())
                            {
                                txtNombre.Text = reader["nombre"].ToString();
                                txtApellido.Text = reader["apellido"].ToString();
                                txtNroSocio.Text = reader["numeroSocio"].ToString();
                                txtTipo.Text = reader["tipoSocio"].ToString();
                                txtActividad.Text = reader["actividad"].ToString();
                                dtpVencimiento.Text = Convert.ToDateTime(reader["vencimiento"]).ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                txtNombre.Text = "";
                                txtApellido.Text = "";
                                MessageBox.Show("Socio no encontrado.");
                            }
                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
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
                    MessageBox.Show("Por favor, ingrese un número de socio.");
                }
            }
        }
    }
}

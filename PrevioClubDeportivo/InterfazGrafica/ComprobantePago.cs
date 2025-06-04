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
    public partial class frmComprobantePago : Form
    {

        public frmComprobantePago(int numeroComprobante)
        {
            InitializeComponent();
            CargarDatosComprobante(numeroComprobante);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (ConfirmarSalida())
            {
                /* Ocultamos el formulario Comprobante de Pago*/
                this.Hide();
            }
            /* Si elige "No", no hace nada (se queda en el formulario actual) */
        }

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
       

        private void btnImprimir_Click(object sender, EventArgs e)
        {
           
                MessageBox.Show($"Imprimir comprobante");
            // Imprimir el comprobante
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

        private void CargarDatosComprobante(int numeroComprobante)
        {
            try
            {
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    // Consulta modificada para incluir datos de Personas
                    string query = @"SELECT 
                            p.nroComprobante, p.fechaPago, s.tipoSocio, p.actividad, 
                            p.metodoPago, p.importe, p.cuotas, p.vencimiento,
                            s.numeroSocio,
                            per.nombre, per.apellido, per.tipoDocumento, per.nroDocumento,
                            per.fechaNacimiento, per.direccion, per.email, per.telefono
                        FROM Pagos p
                        JOIN Socios s ON p.numeroSocio = s.numeroSocio
                        JOIN Personas per ON s.idPersona = per.idPersona
                        WHERE p.nroComprobante = @nroComprobante";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nroComprobante", numeroComprobante);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                // Asignar datos a los controles
                                txtNroComprobante.Text = reader["nroComprobante"].ToString();
                                dtpFecha.Text = Convert.ToDateTime(reader["fechaPago"]).ToString("dd/MM/yyyy");
                                txtNombre.Text = reader["nombre"].ToString();
                                txtApellido.Text = reader["apellido"].ToString();
                                txtNroSocio.Text = reader["numeroSocio"].ToString();
                                txtTipo.Text = reader["tipoSocio"].ToString();
                                txtActividad.Text = reader["actividad"].ToString();
                                txtMetodoPago.Text = reader["metodoPago"].ToString();
                                txtImporte.Text = Convert.ToDecimal(reader["importe"]).ToString("C");
                                txtCuotas.Text = reader["cuotas"].ToString();
                                dtpVencimiento.Text = Convert.ToDateTime(reader["vencimiento"]).ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el comprobante especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar comprobante: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }




    }


}


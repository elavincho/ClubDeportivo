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
            // Lógica para imprimir el comprobante
            //printDocument1.Print();
        }
            
        


        private void CargarDatosComprobante(int numeroComprobante)
        {
            try
            {
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    string query = @"SELECT p.*, s.nombre, s.apellido 
                               FROM Pagos p
                               JOIN Socios s ON p.numeroSocio = s.numeroSocio
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
                                txtTipo.Text = reader["tipo"].ToString();
                                txtActividad.Text = reader["actividad"].ToString();
                                txtMetodoPago.Text = reader["metodoPago"].ToString();
                                txtImporte.Text = Convert.ToDecimal(reader["importe"]).ToString("C");
                                txtCuotas.Text = reader["cuotas"].ToString();
                                dtpVencimiento.Text = Convert.ToDateTime(reader["vencimiento"]).ToString("dd/MM/yyyy");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar comprobante: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

      
    }


}


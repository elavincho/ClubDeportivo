using System;
using System.Windows.Forms;
using PrevioClubDeportivo.Entidades;
using PrevioClubDeportivo.InterfazGrafica;

namespace PrevioClubDeportivo
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();

            /* Mostramos la información del usuario aquí */
            lblUsuario.Text = $"{SesionUsuario.nombreUsuario}";

            lblRol.Text = $"{SesionUsuario.rol}";

        }

        private void frmRegistrarSocio_Load(object sender, EventArgs e)
        {

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

        private void btnRegistrarSocios_Click(object sender, EventArgs e)
        {
            /* Ocultamos el formulario Home */
            this.Hide();

            /* Abrimos el formulario Registrar Socios */
            frmRegistrarSocio registrarSocio = new frmRegistrarSocio();
            registrarSocio.Show();
        }

        private void btnCobrarCuota_Click(object sender, EventArgs e)
        {
            /* Ocultamos el formulario Home */
            this.Hide();

            /* Abrimos el formulario Cobrar Cuota */
            frmCobrarCuota cobrarCuota = new frmCobrarCuota();
            cobrarCuota.Show();
        }

        private void btnEntregarCarnet_Click(object sender, EventArgs e)
        {
            /* Ocultamos el formulario Home */
            this.Hide();

            /* Abrimos el formulario Carnet */
            frmCarnet carnet = new frmCarnet();
            carnet.Show();
        }

        private void btnVencimientoDelDia_Click(object sender, EventArgs e)
        {
            /* Ocultamos el formulario Home */
            this.Hide();

            /* Abrimos el formulario Vencimientos del día */
            frmVencimientosDelDia vencimientos = new frmVencimientosDelDia();
            vencimientos.Show();
        }
    }
}

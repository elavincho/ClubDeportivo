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
    public partial class frmVencimientosDelDia : Form
    {
        public frmVencimientosDelDia()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            /* Ocultar el formulario Vencimientos del día */
            this.Hide();

            /* Abrimos el formulario principal */
            frmHome home = new frmHome();
            home.Show();
        }

        private void btnRegistrarSocios_Click(object sender, EventArgs e)
        {
            /* Ocultar el formulario Vencimientos del día */
            this.Hide();

            /* Abrimos el formulario Registrar Socios */
            frmRegistrarSocio registrarSocio = new frmRegistrarSocio();
            registrarSocio.Show();
        }

        private void btnCobrarCuota_Click(object sender, EventArgs e)
        {
            /* Ocultar el formulario Vencimientos del día */
            this.Hide();

            /* Abrimos el formulario Cobrar Cuota */
            frmCobrarCuota cobrarCuota = new frmCobrarCuota();
            cobrarCuota.Show();
        }

        private void btnEntregarCarnet_Click(object sender, EventArgs e)
        {
            /* Ocultar el formulario Vencimientos del día */
            this.Hide();

            /* Abrimos el formulario Entregar Carnet */
            frmCobrarCuota cobrarCuota = new frmCobrarCuota();
            frmCarnet carnet = new frmCarnet();
            carnet.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (ConfirmarSalida())
            {
                /* Cierra completamente la aplicación */
                Application.Exit();
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





    }
}

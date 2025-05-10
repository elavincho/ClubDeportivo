using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            /* Cierra completamente la aplicación */
            Application.Exit();
        }

        /* Cuando cerramos el formulario principal, cerramos la aplicación */
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
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
    }
}

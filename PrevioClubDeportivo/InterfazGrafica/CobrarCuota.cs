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
    public partial class frmCobrarCuota : Form
    {
        public frmCobrarCuota()
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
            /* Ocultar el formulario Cobrar Cuota */
            this.Hide();

            /* Abrimos el formulario principal */
            frmHome home = new frmHome();
            home.Show();
        }

        private void btnRegistrarSocios_Click(object sender, EventArgs e)
        {
            /* Ocultamos el formulario Cobrar Cuota */
            this.Hide();

            /* Abrimos el formulario Registrar Socios */
            frmRegistrarSocio registrarSocio = new frmRegistrarSocio();
            registrarSocio.Show();
        }
    }
}

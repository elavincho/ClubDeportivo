using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using PrevioClubDeportivo.Entidades;

namespace PrevioClubDeportivo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña");
                return;
            }

            try
            {
                DataTable tablaLogin = new DataTable();
                Entidades.Usuarios dato = new Entidades.Usuarios();
                tablaLogin = dato.Log_Usuario(txtUsuario.Text, txtContrasena.Text);

                if (tablaLogin != null && tablaLogin.Rows.Count > 0)
                {
                    // Almacenar información del usuario
                    SesionUsuario.nombreUsuario = txtUsuario.Text;
                    SesionUsuario.rol = tablaLogin.Rows[0]["NombreRol"].ToString();


                    // Es necesario????????
                    //string rol = tablaLogin.Rows[0]["NombreRol"].ToString();
                    //MessageBox.Show($"Ingreso exitoso. Rol: {rol}");

                    // Ocultar el formulario de login
                    this.Hide();

                    // Abrimos el formulario principal
                    frmHome home = new frmHome();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            /* Cierra completamente la aplicación */
            Application.Exit();
        }
    }
}

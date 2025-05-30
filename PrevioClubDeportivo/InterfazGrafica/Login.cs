using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
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
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text) ||
                txtUsuario.Text == "Ingrese su Usuario" || txtContrasena.Text == "Ingrese su Contraseña")
            {
                MessageBox.Show(
                    "Por favor ingrese usuario y contraseña",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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

                    // Ocultar el formulario de login
                    this.Hide();

                    // Abrimos el formulario principal
                    frmHome home = new frmHome();
                    home.Show();
                }
                else
                {
                    MessageBox.Show(
                        "Usuario y/o Contraseña incorrectos",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error atrapado en la excepción: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            /* Cierra completamente la aplicación */
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando llega al foco */

            if (txtUsuario.Text == "Ingrese su Usuario")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando se va el foco*/

            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingrese su Usuario";
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando llega al foco */

            if (txtContrasena.Text == "Ingrese su Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            /* Este evento se ejecuta cuando se va el foco*/

            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Ingrese su Contraseña";
                txtContrasena.UseSystemPasswordChar = false;
            }
        }
    }
}

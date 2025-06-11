using MySql.Data.MySqlClient;
using PrevioClubDeportivo.Datos;
using PrevioClubDeportivo.Entidades;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace PrevioClubDeportivo.InterfazGrafica
{
    public partial class frmCobrarCuota : Form
    {
        private decimal importe;

        public frmCobrarCuota()
        {
            InitializeComponent();
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

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    CobrarCuota cuota = ObtenerDatosDesdeFormulario();
                    cuota.fechaPago = DateTime.Now; // Asegurar fecha actual

                    if (ValidarPagoExistente(cuota))
                    {
                        return; // Ya mostró mensaje de error en ValidarPagoExistente
                    }

                    GuardarCuota(cuota);
                    LimpiarFormulario();
                    txtNroComprobante.Text = generadorNumeroComprobante.ObtenerProximoNumero().ToString();

                    // 1. Primero obtener el próximo número de comprobante
                    int numeroComprobante = generadorNumeroComprobante.ObtenerProximoNumero() - 1;

                    // Mostrar el comprobante con el número de comprobante
                    this.Hide(); // Ocultar el formulario actual
                    frmComprobantePago comprobante = new frmComprobantePago(numeroComprobante);
                    comprobante.ShowDialog();
                    this.Show(); // Volver a mostrar cuando se cierre el comprobante
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private bool ValidarPagoExistente(CobrarCuota cuota)
        {
            // Validación básica de parámetros
            if (cuota == null || cuota.numeroSocio <= 0)
            {
                MessageBox.Show("Datos del socio no válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (string.IsNullOrEmpty(cuota.tipo) || (cuota.tipo != "MENSUAL" && cuota.tipo != "DIARIA"))
            {
                MessageBox.Show("Tipo de pago no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            try
            {
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    string query;
                    MySqlCommand cmd;
                    bool existePago = false;
                    string tipoConflicto = string.Empty;

                    if (cuota.tipo == "MENSUAL")
                    {
                        // Verificar primero pagos mensuales
                        query = @"SELECT tipo FROM Pagos 
                        WHERE numeroSocio = @numeroSocio 
                        AND tipo = 'MENSUAL'
                        AND YEAR(fechaPago) = YEAR(@fechaPago)
                        AND MONTH(fechaPago) = MONTH(@fechaPago)
                        LIMIT 1";

                        cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@numeroSocio", cuota.numeroSocio);
                        cmd.Parameters.AddWithValue("@fechaPago", cuota.fechaPago);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                existePago = true;
                                tipoConflicto = reader["tipo"].ToString();
                            }
                        }

                        // Si no hay mensual, verificar diarios
                        if (!existePago)
                        {
                            query = @"SELECT tipo FROM Pagos 
                            WHERE numeroSocio = @numeroSocio 
                            AND tipo = 'DIARIA'
                            AND YEAR(fechaPago) = YEAR(@fechaPago)
                            AND MONTH(fechaPago) = MONTH(@fechaPago)
                            LIMIT 1";

                            cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@numeroSocio", cuota.numeroSocio);
                            cmd.Parameters.AddWithValue("@fechaPago", cuota.fechaPago);

                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    existePago = true;
                                    tipoConflicto = reader["tipo"].ToString();
                                }
                            }
                        }
                    }
                    else // Pago Diario
                    {
                        if (string.IsNullOrEmpty(cuota.actividad))
                        {
                            MessageBox.Show("Debe seleccionar una actividad para pagos diarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return true;
                        }

                        // Verificar primero pagos diarios para la misma actividad
                        query = @"SELECT tipo FROM Pagos 
                        WHERE numeroSocio = @numeroSocio 
                        AND tipo = 'DIARIA'
                        AND actividad = @actividad
                        AND DATE(fechaPago) = DATE(@fechaPago)
                        LIMIT 1";

                        cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@numeroSocio", cuota.numeroSocio);
                        cmd.Parameters.AddWithValue("@fechaPago", cuota.fechaPago);
                        cmd.Parameters.AddWithValue("@actividad", cuota.actividad);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                existePago = true;
                                tipoConflicto = reader["tipo"].ToString();
                            }
                        }

                        // Si no hay diario, verificar mensual
                        if (!existePago)
                        {
                            query = @"SELECT tipo FROM Pagos 
                            WHERE numeroSocio = @numeroSocio 
                            AND tipo = 'MENSUAL'
                            AND YEAR(fechaPago) = YEAR(@fechaPago)
                            AND MONTH(fechaPago) = MONTH(@fechaPago)
                            LIMIT 1";

                            cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@numeroSocio", cuota.numeroSocio);
                            cmd.Parameters.AddWithValue("@fechaPago", cuota.fechaPago);

                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    existePago = true;
                                    tipoConflicto = reader["tipo"].ToString();
                                }
                            }
                        }
                    }

                    if (existePago)
                    {
                        string mensaje;
                        if (tipoConflicto == "MENSUAL")
                        {
                            mensaje = "El socio tiene un pago MENSUAL registrado.";
                        }
                        else if (tipoConflicto == "DIARIA" && cuota.tipo == "DIARIA")
                        {
                            mensaje = "El socio tiene un pago DIARIO registrado.";
                        }
                        else if (tipoConflicto == "DIARIA" && cuota.tipo == "MENSUAL")
                        {
                            mensaje = "El socio tiene un pago DIARIO registrado.";
                        }
                        else
                        {
                            mensaje = "Ya existe un pago registrado que conflictúa con este registro.";
                        }

                        MessageBox.Show(mensaje, "Pago duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar pago existente: {ex.Message}\n\nDetalles técnicos:\n{ex.StackTrace}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

       
        private CobrarCuota ObtenerDatosDesdeFormulario()
        {

            // Obtener el RadioButton seleccionado del GroupBox
            RadioButton rbSeleccionadoMetodo = gbMetodoPago.Controls.OfType<RadioButton>()
                                              .FirstOrDefault(rb => rb.Checked);

            // Obtener el RadioButton seleccionado para el tipo (asumiendo que se llama gbTipoCuota)
            RadioButton rbSeleccionadoTipo = gbTipo.Controls.OfType<RadioButton>()
                                          .FirstOrDefault(rb => rb.Checked);

            /* Instanciamos la Cuota */
            CobrarCuota cuota = new CobrarCuota
            {
                // Si no se selecciona ningún RadioButton, devuelve una cadena vacía (o un valor por defecto)
                metodoPago = rbSeleccionadoMetodo?.Text ?? "",
                tipo = rbSeleccionadoTipo?.Text ?? "",

                nroComprobante = int.Parse(txtNroComprobante.Text),
                numeroSocio = int.Parse(txtNroSocio.Text),
                actividad = lstActividad.SelectedItem?.ToString(),
                vencimiento = dtpVencimiento.Value,
                cuotas = lstCuotas.SelectedItem?.ToString() ?? "1"
            };

            return cuota;
        }


        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNroSocio.Text) ||
        string.IsNullOrWhiteSpace(txtApellido.Text) ||
        string.IsNullOrWhiteSpace(txtNombre.Text) ||
        !decimal.TryParse(txtImporte.Text, out importe) ||
        lstCuotas.SelectedIndex == -1 || lstCuotas.SelectedItem == null ||
        !rbEfectivo.Checked && !rbQR.Checked && !rbTarjeta.Checked ||
        lstActividad.SelectedIndex == -1 || lstActividad.SelectedItem == null ||
        !rbMensual.Checked && !rbDiaria.Checked)
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /* Limpiar Formulario */
        private void LimpiarFormulario()
        {
            txtNroSocio.Clear();
            txtNombre.Clear();
            txtApellido.Clear();

        }

        private int GuardarCuota(CobrarCuota cuota)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Asignar fecha de pago actual si no está asignada
                    cuota.fechaPago = DateTime.Now;

                    string insertPagoQuery = @"INSERT INTO Pagos 
                (nroComprobante, numeroSocio, tipo, actividad, importe, metodoPago, cuotas, fechaPago, vencimiento) 
                VALUES (@nroComprobante, @numeroSocio, @tipo, @actividad, @importe, @metodoPago, @cuotas, @fechaPago, @vencimiento);
                SELECT LAST_INSERT_ID();";

                    // Obtener el próximo número de comprobante
                    int proximoNumero = generadorNumeroComprobante.ObtenerProximoNumero();

                    using (MySqlCommand cmd = new MySqlCommand(insertPagoQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@nroComprobante", proximoNumero);
                        cmd.Parameters.AddWithValue("@numeroSocio", cuota.numeroSocio);
                        cmd.Parameters.AddWithValue("@tipo", cuota.tipo);
                        cmd.Parameters.AddWithValue("@actividad", cuota.actividad ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@importe", importe);
                        cmd.Parameters.AddWithValue("@metodoPago", cuota.metodoPago);
                        cmd.Parameters.AddWithValue("@cuotas", int.Parse(cuota.cuotas));
                        cmd.Parameters.AddWithValue("@fechaPago", cuota.fechaPago);
                        cmd.Parameters.AddWithValue("@vencimiento", cuota.vencimiento);

                        int nroComprobante = Convert.ToInt32(cmd.ExecuteScalar());
                        txtNroComprobante.Text = nroComprobante.ToString();
                    }

                    // Actualizar la tabla Socios
                    string updateSocioQuery = @"UPDATE Socios 
                SET tipoSocio = @tipoSocio, 
                    fechaPago = @fechaPago, 
                    estadoCuota = @estadoCuota 
                WHERE numeroSocio = @numeroSocio";

                    using (MySqlCommand updateCmd = new MySqlCommand(updateSocioQuery, connection, transaction))
                    {
                        updateCmd.Parameters.AddWithValue("@tipoSocio", rbMensual.Checked ? "Activo" : "Adherente");
                        updateCmd.Parameters.AddWithValue("@fechaPago", cuota.fechaPago);
                        updateCmd.Parameters.AddWithValue("@estadoCuota", "Al día");
                        updateCmd.Parameters.AddWithValue("@numeroSocio", cuota.numeroSocio);
                        updateCmd.ExecuteNonQuery();
                    }

                    // Confirmar la transacción si todo salió bien
                    transaction.Commit();
                    
                    MessageBox.Show("Pago registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return proximoNumero; // Esto debe devolver el número de comprobante
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error al registrar el pago: {ex.Message}");
                    throw;
                }
                
            }
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (ConfirmarSalida())
            {
                /* Regresa al formulario principal */
                frmHome home = new frmHome();
                home.Show();
                /* Ocultamos el formulario Registrar Socio*/
                this.Hide();
            }
            /* Si elige "No", no hace nada (se queda en el formulario actual) */
        }


        public class generadorNumeroComprobante
        {
            public static int ObtenerProximoNumero()
            {
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    // Bloqueo de tabla para evitar concurrencia (opcional para entornos multi-usuario)
                    string queryLock = "LOCK TABLES Pagos READ";
                    new MySqlCommand(queryLock, connection).ExecuteNonQuery();

                    try
                    {
                        string query = "SELECT COALESCE(MAX(nroComprobante), 0) FROM Pagos";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        int ultimoNumero = Convert.ToInt32(cmd.ExecuteScalar());

                        return ultimoNumero + 1;
                    }
                    finally
                    {
                        // Liberar el bloqueo
                        string queryUnlock = "UNLOCK TABLES";
                        new MySqlCommand(queryUnlock, connection).ExecuteNonQuery();
                    }
                }
            }
        }

        private void frmCobrarCuota_Load(object sender, EventArgs e)
        {

            dtpFecha.Value = DateTime.Now;

            dtpFecha.CustomFormat = "dd/MM/yy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpVencimiento.CustomFormat = "dd/MM/yy";
            dtpVencimiento.Format = DateTimePickerFormat.Custom;
            

            try
            {
                int proximoNumero = generadorNumeroComprobante.ObtenerProximoNumero();
                txtNroComprobante.Text = proximoNumero.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar EL número: {ex.Message}");
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
                                MessageBox.Show("El número de socio debe ser válido.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtNombre.Text = "";
                                txtApellido.Text = "";
                                return;
                            }

                            connection.Open();
                            string query = "SELECT p.nombre, p.apellido, af.esApto, af.vtoAptoFisico " +
                                          "FROM Personas p " +
                                          "JOIN Socios s ON p.idPersona = s.idPersona " +
                                          "LEFT JOIN AptoFisico af ON s.numeroSocio = af.numeroSocio " +
                                          "WHERE s.numeroSocio = @numeroSocio";
                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@numeroSocio", numeroSocio);
                            MySqlDataReader reader = cmd.ExecuteReader();

                            if (reader.Read())
                            {
                                txtNombre.Text = reader["nombre"].ToString();
                                txtApellido.Text = reader["apellido"].ToString();
                            }
                            else
                            {
                                txtNombre.Text = "";
                                txtApellido.Text = "";
                                MessageBox.Show("Socio no encontrado.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Por favor, ingrese un número de socio.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void rbMensual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMensual.Checked)
            {
                lstActividad.Enabled = false;
                lstActividad.Items.Clear();
                lstActividad.Items.Add("LIBRE");
                lstActividad.SelectedIndex = 0;
                txtImporte.Text = "20000";
                dtpVencimiento.Value = DateTime.Now.AddMonths(1);
            }
        }

        private void rbDiaria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDiaria.Checked)
            {
                lstActividad.Enabled = true;
                lstActividad.Items.Clear();
                lstActividad.Items.AddRange(new string[] { "Yoga", "Boxeo", "Pilates", "Spinning", "Musculacion", "Cardio" });
                lstActividad.SelectedIndex = -1;
                txtImporte.Text = "10000";
                dtpVencimiento.Value = DateTime.Now;
            }
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                lstCuotas.Items.Clear();
                lstCuotas.Items.Add("1");
                lstCuotas.SelectedIndex = 0;
            }
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTarjeta.Checked)
            {
                lstCuotas.Items.Clear();
                lstCuotas.Items.AddRange(new string[] { "1", "3", "6" });
                lstCuotas.SelectedIndex = 0;
            }
        }

        private void rbQR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQR.Checked)
            {
                lstCuotas.Items.Clear();
                lstCuotas.Items.AddRange(new string[] { "1", "3", "6" });
                lstCuotas.SelectedIndex = 0;
            }
        }

        public void CargarDatosSocio(int numeroSocio)
        {
            // Implementa la carga de datos del socio
            txtNroSocio.Text = numeroSocio.ToString();
        }

        private void frmCobrarCuota_Shown(object sender, EventArgs e)
        {
            /* Colocamos el Foco en el número de socio*/
            txtNroSocio.Focus();
        }
    }
}

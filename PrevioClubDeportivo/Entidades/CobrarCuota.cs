using System;
using System.Windows.Forms;

namespace PrevioClubDeportivo.Entidades
{
    internal class CobrarCuota
    {

        /* Atributos */
        public int idcuota;
        public int nroComprobante { get; set; }
        public int numeroSocio { get; set; }
        public string tipo { get; set; }
        public string actividad { get; set; }
        public decimal importe { get; set; }
        public string metodoPago { get; set; }
        public string cuotas { get; set; }
        public DateTime fechaPago { get; set; }
        public DateTime vencimiento { get; set; }

        /* Constructor con parametros*/
        public CobrarCuota(int idcuota, int nroComprobante, int numeroSocio, string tipo, string actividad, decimal importe, string metodoPago, string cuotas, DateTime fechaPago, DateTime vencimiento)
        {
            this.idcuota = idcuota;
            this.nroComprobante = nroComprobante;
            this.numeroSocio = numeroSocio;
            this.tipo = tipo;
            this.actividad = actividad;
            this.importe = importe;
            this.metodoPago = metodoPago;
            this.cuotas = cuotas;
            this.fechaPago = fechaPago;
            this.vencimiento = vencimiento;
        }

        /* Constructor vacio*/
        public CobrarCuota()
        {
        }

        /* To String*/
        public override string ToString()
        {
            return "Fecha: " + fechaPago + " N° Comprobante: " + nroComprobante + " N° Socio: " + numeroSocio + " Tipo: " + tipo + " Actividad: " + actividad + " Importe: " + importe + " Método Pago: " + metodoPago + " Cuotas: " + cuotas + " Vencimiento: " + vencimiento;
        }
    }
}

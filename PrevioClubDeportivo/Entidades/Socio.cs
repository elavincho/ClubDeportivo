using System;

namespace PrevioClubDeportivo.Entidades
{
    /* La clase socio hereda atributos de la clase persona*/
    internal class Socio : Persona
    {
        /* Atributos con Get y Set*/

        public int idSocio;
        public int numeroSocio { get; set; }
        public string tipoSocio { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaPago { get; set; }
        public string estadoCuota { get; set; }

        /* Constructor con Parametros */
        public Socio(int idSocio, int numeroSocio, string tipoSocio, DateTime fechaAlta, DateTime fechaPago, string estadoCuota)
        {
            this.idSocio = idSocio;
            this.numeroSocio = numeroSocio;
            this.tipoSocio = tipoSocio;
            this.fechaAlta = fechaAlta;
            this.fechaPago = fechaPago;
            this.estadoCuota = estadoCuota;
        }

        /* Constructor Vacio */
        public Socio()
        {
        }

        /* To String */
        public override string ToString()
        {
            return "N° Socio: " + numeroSocio + " Tipo Socio: " + tipoSocio + " Fecha Alta: " + fechaAlta + " Fecha Pago: " + fechaPago + " Estado Cuota: " + estadoCuota;
        }
    }
}

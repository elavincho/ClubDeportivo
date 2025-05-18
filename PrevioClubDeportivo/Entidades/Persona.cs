using System;

namespace PrevioClubDeportivo.Entidades
{
    internal class Persona
    {
        /* Atributos con get y set*/
        public int idPersona { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }

        /* Contructor con parametros*/
        public Persona(int idPersona, string nombre, string apellido, string tipoDocumento, string nroDocumento, DateTime fechaNacimiento, string direccion, string email, string telefono)
        {
            this.idPersona = idPersona;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipoDocumento = tipoDocumento;
            this.nroDocumento = nroDocumento;
            this.fechaNacimiento = fechaNacimiento;
            this.direccion = direccion;
            this.email = email;
            this.telefono = telefono;
        }

        /*Constructor vacio*/
        public Persona()
        {
        }

        /* To String*/
        public override string ToString()
        {
            return "Nombre: " + nombre + " Apellido: " + apellido + " Tipo Documento: " + tipoDocumento + " N° Documento: " + nroDocumento + " Fecha Nacimiento: " + fechaNacimiento + " Dirección: " + direccion + " Email: " + email + " Teléfono: " + telefono;
        }
    }
}

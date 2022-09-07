using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Veterinaria.Dominio
{
    internal class Atenciones
    {
        public Atenciones(int idAtencion, Mascota mascota, DateTime fecha, string descripcion, double importe)
        {
            this.idAtencion = idAtencion;
            Mascota = mascota;
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.importe = importe;
        }

        public int idAtencion { get; set; }
        public Mascota Mascota { get; set; }
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }
        public double importe { get; set; }

        public override string ToString()
        {
            return Mascota.pId_mascota + " - " + fecha + " - " + importe;
        }

        public string MostrarDescripcion()
        {
            return  Mascota.pId_mascota + " - " + descripcion;
        }
    }
}

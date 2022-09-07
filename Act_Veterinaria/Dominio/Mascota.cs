using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Veterinaria.Dominio
{
    internal class Mascota
    {
        private int id_mascota, edad, id_tipo;
        private string nombre;


        public Cliente Cliente { get; set; }

        public int pId_mascota
        {
            get { return id_mascota; }
            set { id_mascota = value; }
        }

        public int pEdad
        {
            get { return edad; }
            set { edad = value; }
        }

        public int pId_tipo
        {
            get { return id_tipo; }
            set { id_tipo = value; }
        }

        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Mascota(int id_mascota, int edad, int id_tipo, string nombre, Cliente cliente)
        {
            this.id_mascota = id_mascota;
            this.edad = edad;
            this.id_tipo = id_tipo;
            this.nombre = nombre;
            Cliente = cliente;
        }
        public Mascota()
        {
            this.pEdad=0;
            this.pId_tipo = 0;
            this.pId_mascota=0;
            this.Cliente=null;
            this.pNombre="";
        }

        public override string ToString()
        {
            return id_mascota + " - " + nombre;
        }
    }
}

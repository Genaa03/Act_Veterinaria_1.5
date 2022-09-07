using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Veterinaria.Dominio
{
    internal class Cliente
    {
        private int cod_cliente, sexo;
        private string nombre;

        public int pCod_cliente
        {
            get { return cod_cliente; }
            set { cod_cliente = value; }
        }

        public int pSexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Cliente()
        {
            cod_cliente = 0;
            nombre = "";
            sexo = 0;
        }
        public Cliente(int cod_cliente, int sexo, string nombre)
        {
            this.cod_cliente = cod_cliente;
            this.sexo = sexo;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return cod_cliente + " - " + nombre;
        }
    }
}

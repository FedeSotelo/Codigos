using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaConWF
{
    class Persona
    {
        //atributos
        private string ape, nom, docu, codigo;

        //Propiedades
        public string Apellido
        {
            get { return ape; }
            set { ape = value.ToUpper(); }
        }
        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Documento
        {
            get { return docu; }
            set { docu = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        //metodo
        public void GenerarCodigo()
        {
            Codigo = Nombre.Substring(0, 3) + Apellido.Substring(0, 3) + Documento;
        }

    }
}

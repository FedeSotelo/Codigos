using System;
using System.Collections.Generic;
using System.Text;

namespace WFConClasesyFuncionesCadena
{
    class ClaseWF
    {
        //atributos
        private string nombre, apellido, conca, largo;
        private int legajo;

        //Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value.ToUpper(); }
        }
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public string Concatenado
        {
            get { return conca; }
            set { conca = value; }
        }

        public void GenerarConcatenado()
        {
            this.Concatenado = string.Concat(nombre, "-", apellido);
        }

        public string Largo
        {
            get { return largo; }
            set { largo = value; }
        }

        public void GenerarLargo()
        {
            this.Largo = Apellido.Length.ToString();
        }


        /*generar una propiedad que me traiga las tres primeras letras del
        nombre + las tres ultimas letras delapellido + el legajo */

    }
}

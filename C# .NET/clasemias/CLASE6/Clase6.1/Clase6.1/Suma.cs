﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6._1
{
    internal class Suma : Operacion
    {

        public void Operar()
        {
            Resultado = Nro1 + Nro2;


        }


        public void Imprimir()
        {
            Console.WriteLine("El resultado de la suma de " + this.Nro1 + " y " + this.Nro2 + " es: " + this.Resultado);

        }


    }
}

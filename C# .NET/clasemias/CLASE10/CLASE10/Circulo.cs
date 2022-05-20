using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE10
{
    internal class Circulo:Ifigura
    {
        public int Radio { get; set; }


        public double CalcularArea()
        {


            return Math.PI * Radio * Radio;
        }

        public void Imprimir()
        {

            Console.Write("El area/Radio del circulo es" + CalcularArea());
        }


    }
}

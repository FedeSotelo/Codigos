using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaz2
{
    class Rectangulo:IFigura
    {
        //propiedades
        public int Base { get; set; }
        public int Altura { get; set; }

        public double CalcularArea()
        {
            return Base * Altura;
        }

        public void DatosRectangulo()
        {
            Console.WriteLine("Base: {0} - Altura: {1} ", Base, Altura);
        }
    }
}

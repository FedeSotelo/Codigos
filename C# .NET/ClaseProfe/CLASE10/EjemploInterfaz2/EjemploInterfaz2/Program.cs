using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaz2
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigura F1 = new Circulo { Radio = 5 };
            IFigura F2 = new Rectangulo { Base=10,Altura=8 };

            IFigura[] figu = new IFigura[] { F1, F2 };

            foreach(var figuras in figu)
            {
                Console.WriteLine(figuras.CalcularArea());                
            }

            Circulo c = F1 as Circulo;
            Console.WriteLine("Datos del Circulo!!!");
            c.DatosCirculos();

            Rectangulo r = F2 as Rectangulo;
            Console.WriteLine("Datos del Rectangulo!!!");
            r.DatosRectangulo();

            Console.ReadKey();
        }
    }
}

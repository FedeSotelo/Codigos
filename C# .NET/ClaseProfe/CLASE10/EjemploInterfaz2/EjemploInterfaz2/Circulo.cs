using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaz2
{
    class Circulo:IFigura
    {
        //propiedades
        public int Radio { get; set;}

        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public void DatosCirculos()
        {
            Console.WriteLine("Radio: {0}", Radio);
        }
    }
}

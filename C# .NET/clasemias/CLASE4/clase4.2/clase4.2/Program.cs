using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*Crear una clase llamada Prisma.
             * Crear 2 constructores uno por default y otro por parametros
             * Crear 3 propiedades de lectura y escritura (Ancho, Alto, Espesor)
             * Crear 1 propiedad de lectura llamada Area.
             * Crear otra propiedad de lectura llamada Volumen.
             * Crear un metodo llamado CalcularVolumen que no devuelva datos.
             * Crear otro metodo que se llame calcularArea donde instancie a otro metodo llamado 
             * calcularRectangulo (que calculara con dos elementos alto y el ancho))
             * 
             * Crear dos objetos prisma1 y prisma2.
             * 
             */


            Prisma prisma1 = new Prisma();
            prisma1.CalcularArea();
            prisma1.CalcularVolumen();
            Prisma prisma2 = new Prisma(3,5,9);
            prisma2.CalcularArea();
            prisma1.CalcularVolumen();


            Console.WriteLine("area= {0}, volumen {1}", prisma1.Area, prisma1.Volumen);
            Console.WriteLine("area= {0}, volumen {1}", prisma2.Area, prisma2.Volumen);

            Console.ReadKey();



        }
    }
}

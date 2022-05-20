using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro lib1 = new Libro(".net", 4500, 1000, "informatica", "ricardo darin", "planeta", "libreria" );
            lib1.ImprimirDatos();

            DVD dvd1 = new DVD("Babasonicos", 4500, 2000, "Rock", "Diego rodriguez", "2002");
            dvd1.ImprimirDatos();




            Console.ReadKey();
        }
    }
}

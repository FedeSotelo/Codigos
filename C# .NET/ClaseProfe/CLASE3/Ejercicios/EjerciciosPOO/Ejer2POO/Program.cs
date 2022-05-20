using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Trabajador trab1 = new Trabajador();
            trab1.Imprimir();
            Trabajador trab2 = new Trabajador("luis", "gonzalez", "z", 1000, 2000);
            trab2.Imprimir();
            Console.ReadKey();

        }
    }
}

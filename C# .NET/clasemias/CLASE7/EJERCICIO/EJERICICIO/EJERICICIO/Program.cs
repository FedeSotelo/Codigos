using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERICICIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Secretario secre1 = new Secretario("Hernan", "Gomez", "44574783", 2003, 40000, "114536747");
            secre1.Imprimir();


            Vendedor vende1 = new Vendedor("Gustavo", "Richar", "64565423", 1990, 2000, 90, 50);
            vende1.Imprimir();


            Console.ReadKey();
        }
    }
}

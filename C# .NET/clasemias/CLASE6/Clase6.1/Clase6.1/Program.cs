using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Suma sum1 = new Suma();
            sum1.Nro1 = 10; sum1.Nro2 = 20;
            sum1.Operar();
            sum1.Imprimir();


            Resta res1 = new Resta();
            res1.Nro1 = 10; res1.Nro2 = 5;
            res1.Operar();
            res1.Imprimir();

            Console.ReadKey();


        }
    }
}

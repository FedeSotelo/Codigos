using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona per1 = new Persona("Luis", "Gomez","44525674", 2002);
            per1.Imprimir();

            Estudiante est1 = new Estudiante("Lucas", "Gomez", "44342344", 2002, 2, 0089, 5, "Sistemas");
            est1.Imprimir();
            Console.ReadKey();

        }
    }
}

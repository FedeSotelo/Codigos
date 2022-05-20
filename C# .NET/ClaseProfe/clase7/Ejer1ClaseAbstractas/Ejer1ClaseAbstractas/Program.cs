using System;

namespace Ejer1ClaseAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Producto prod1 = new Producto();
            Libro miLibro1 = new Libro("Aprendiendo c sharp",1500,1000,"Informatica", "Pedro Luero" );
            miLibro1.ImprimirDatos();
            Console.ReadKey();
        }
    }
}

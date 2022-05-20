using System;
using System.Collections; //coleccion no generica

namespace EjemploArraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nombres = new ArrayList();
            nombres.Add("Juan");
            nombres.Add("Analia");
            nombres.Add("Pedro");

            //impresion de foreach
            foreach(string cadena in nombres)
            {
                Console.WriteLine(" Los nombres son: " + cadena);
            }

            //Acceder a una posicion
            Console.WriteLine("El nombre en la posicion 2 es: " + nombres[1]);

            //ordenar la lista
            nombres.Sort();
            foreach (string cadena in nombres)
            {
                Console.WriteLine(" Los nombres son: " + cadena);
            }

            //insert
            nombres.Insert(0, "Alan");
            foreach (string cadena in nombres)
            {
                Console.WriteLine(" Los nombres son: " + cadena);
            }

            Console.WriteLine(" Cantidad de Registros: " + nombres.Count);

            Console.WriteLine("Borrar un registro ");
            nombres.Remove("Alan");
            nombres.RemoveAt(2);

            foreach (string cadena in nombres)
            {
                Console.WriteLine(" Los nombres son: " + cadena);
            }


            Console.ReadKey();
        }
    }
}

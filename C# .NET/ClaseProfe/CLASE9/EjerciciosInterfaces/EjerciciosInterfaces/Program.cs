using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Define un método de comparación específico de tipo generalizado que implementa un tipo
             * de valor o una clase para ordenar u ordenar sus instancias.*/

            //objetos
            Producto p1 = new Producto { Codigo = "A1", Precio = 123 };
            Producto p2 = new Producto { Codigo = "A2", Precio = 34 };
            Producto p3 = new Producto { Codigo = "A3", Precio = 250 };

            Producto[] productos = new Producto[] { p1, p2, p3 }; //array de objetos
            Array.Sort(productos);
            foreach (var prod in productos)
                Console.WriteLine("Codigo: {0}, Precio: {1}", prod.Codigo, prod.Precio);

            Console.ReadKey();
        }
    }
}

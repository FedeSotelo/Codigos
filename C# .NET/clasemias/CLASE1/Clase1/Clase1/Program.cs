using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string cadena = "Carlos Alberto Gutierrez";
            int largo = cadena.Length;
            Console.WriteLine("La cantidad de caracteres es: " + largo);

            string mayusculas;
            mayusculas = cadena.ToUpper();
            Console.WriteLine("La cadena en mayuscula es: " + mayusculas);


            string extraer;
            extraer = cadena.Substring(7, 7);
            Console.WriteLine("La cadena de extraer es: " + extraer);


            int primeraOcurrencia;
            primeraOcurrencia = cadena.IndexOf('e');

             Console.WriteLine("La primera letra e esta en la posicion: " + primeraOcurrencia);







            /*
             Una importante empresa de articulos deportivos, realiza n operaciones.

            De cada operacion se ingresan los siguientes datos:

            - Nombre del Producto(P: Pelotas, Z:zapatillas, G:equipo de gimnasia)
            - Zona (N:Norte, S:Sur, O:Oeste, E:este)
            - Cantidad comprada.

            Si el producto es P, el precio sera 700, si es Z, el precio sera 1200, si es G, 
            su precio sera 550 sino 0;

            Se Pide:
            1) Cantidad vendida de cada producto.
            2) cantidad de compras por zonas.
            3) facturacion por cada producto.
            4) facturacion pot cada zona.
            5) cantidad de personas que compraropn pelotas de la zona norte y sur.

            */

            int n; 
            n = int.Parse(Console.ReadLine());


            for ( int i= 0; i < n; i++)
            {

               
            }

            /*
            char fin =  'S';
             while (fin  == 'N')
            {





                Console.WriteLine("¿Quiere seguir ingresando datos? S/N");
                fin = char.Parse(Console.ReadLine());


            }

             Console.WriteLine("--Impresion resultados ---")
            */



            Console.ReadLine();

            

        }
    }
}

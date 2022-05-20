using System;
using System.Text;

namespace Ejer1Repaso
{
    class Program
    {
        static void Main(string[] args)
        {

            string cadena = "Carlos Alberto Gutierrez";
            int largo = cadena.Length;

            Console.WriteLine("La Cantidad de caracteres es: " + largo);

            string mayusculas;
            mayusculas = cadena.ToUpper();
            Console.WriteLine("La Cadena convertida a Mayusculas es: " + mayusculas);

            string extraer;
            extraer = cadena.Substring(7, 7);
            Console.WriteLine("La Cadena extraida es: " + extraer);

            int primeraOcurrencia;
            primeraOcurrencia = cadena.IndexOf('e');
            Console.WriteLine("La primera Letra E esta en la posicion: " + primeraOcurrencia);

        }
    }
}

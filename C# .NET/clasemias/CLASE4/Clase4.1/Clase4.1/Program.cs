using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Propiedades  || poner validar en pdf


            /*Crear una clase llamada Productos que tenga tres atributos privados
             * nombreProducto, precio y cantidad
             * Acceder a los atributos atraves de propiedades.
             * Generar una propiedad de solo lectura para hacer el calculo del Subtotal
             * Crear otra propiedad de sola lectura que calcule el IVA
             * Calcular el Precio a Pagar
             * Crear 2 metodos(CargarDatos y otro imprimir) */

            Productos prod1 = new Productos();
            prod1.CargarDatos();
            prod1.Imprimir();

            Console.ReadKey();
        }
    }
}

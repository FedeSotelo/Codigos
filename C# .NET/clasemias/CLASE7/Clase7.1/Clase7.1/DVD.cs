using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7._1
{
    internal class DVD:Producto
    {
        //atributos propios
        public string generodvd, cantante, año;
        
        //constructor

        public DVD(string pnombre, double pprecio, double pcosto, string pgenerodvd, string pcantante, string paño):base(pnombre, pprecio, pcosto)
        {

            generodvd = pgenerodvd;
            cantante = pcantante;
            año = paño;


        }

        //imprimir
        public override void ImprimirDatos()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("---Datos del DVD ---");
            Console.WriteLine("Nombre del DVD " + NombreProducto + " Cantante " + cantante);
            Console.WriteLine($"Precio: {Precio}, Costo: {Costo}");
            Console.WriteLine($"Año de estreno: {año}, Genero: {generodvd}");
        }



    }
}

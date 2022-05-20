using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4._1
{
    internal class Productos
    {

        private string nombreProducto;
        private double precio;
        private int cantidad;



        //propiedades

        public string NombreProducto
        {
            get  { return nombreProducto;  } 
            set { nombreProducto = value.ToUpper(); }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }

        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        //Generar una propiedad de solo lectura para hacer el calculo del Subtotal

        public double SubTotal
        {
            get { return precio * cantidad; }

        }

        public double IVA
        {
            get { return precio * 1.21; }
        }




        public void CargarDatos()
        {

            Console.WriteLine("--Carga de Datos--");
            Console.Write("Ingrese Nombre del Producto: ");
            NombreProducto = Console.ReadLine();
            Console.Write("Ingrese el Precio: ");
            Precio = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la Cantidad: ");
            Cantidad = int.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("-- RESULTADOS --");
            Console.WriteLine($"Nombre del Producto {NombreProducto}");
            Console.WriteLine($"Precio:  {Precio}");
            Console.WriteLine($"Cantidad:  {Cantidad}");
            Console.WriteLine("------------------------");

            Console.WriteLine($"SubTotal:  {SubTotal}");
            Console.WriteLine($"IVA 21%:  {IVA}");
            //Console.WriteLine($"TOTAL A PAGAR:  {}");

        }






    }
}

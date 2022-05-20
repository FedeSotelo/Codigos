using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7._1
{
    internal class Libro:Producto
    {
        //Atributo Propios
        public string nombreLibro, autor, distribuidora, rubro;
        public int cantPaginas;
        public double isbn;

        public Libro(string pnombre, double pprecio, double pcosto, string pnombrel, string pautor, string pdistribuidora, string prubro):base( pnombre, pprecio, pcosto)
        {
            nombreLibro = pnombrel;
            autor = pautor;
            distribuidora= pdistribuidora;
            rubro = prubro;


        }


        public override void ImprimirDatos()  //Este metodo tiene que estar si o si porque es abstracto.
        {
            Console.WriteLine("---Datos del libro ---");
            Console.WriteLine("Nombre del libro "+ NombreProducto + " autor " + autor);
            Console.WriteLine($"Precio: {Precio}, Costo: {Costo}");
            Console.WriteLine($"Distribuidora: {distribuidora}, Rubro: {rubro}, Tipo de libro: {nombreLibro}");

        }

    }
}

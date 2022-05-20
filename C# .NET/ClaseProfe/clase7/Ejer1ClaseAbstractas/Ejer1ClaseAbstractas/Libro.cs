using System;
using System.Collections.Generic;
using System.Text;

namespace Ejer1ClaseAbstractas
{
    class Libro:Producto
    {
        //Atributo Propios
        public string nombreLibro, autor;//, distribuidora, rubro;

        //public int cantPaginas;
        //public double isbn;

        public Libro(string pnombre, double pprecio, double pcosto, string pnombreL, string pautor)
            :base(pnombre, pprecio, pcosto)
        {
            nombreLibro = pnombreL;
            autor = pautor;
        }
        public override string ImprimirDatos()
        {
            return " --- Datos del Libro --- \n" + " Nombre del Libro :  \n " + this.NombreProducto +
                " Autor: \n " + this.autor + "Precio: \n " + this.Precio + " Costo: \n " + this.Costo + "Rubro:\n" + this.nombreLibro +  "\n";


        }
    }
}
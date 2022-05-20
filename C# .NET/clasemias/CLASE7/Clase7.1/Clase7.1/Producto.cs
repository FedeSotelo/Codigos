using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7._1
{
    abstract internal class Producto
    {
        //Propiedades autoimplementadas
        public double Precio { get; set; }
        public double Costo { get; set; }
        public string NombreProducto { get; set; }



        //constructor
        public Producto (string pnombre, double pprecio, double pcosto)
        {
            NombreProducto = pnombre;
            Precio = pprecio;
            Costo = pcosto;

        }


       //Metodo Abstracto
        public abstract void ImprimirDatos();

        //Propiedad abstracta
       // public abstract int Codigo { get; set; }
        



    }


}

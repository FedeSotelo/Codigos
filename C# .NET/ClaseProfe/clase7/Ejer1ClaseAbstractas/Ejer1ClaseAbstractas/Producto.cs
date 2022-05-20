using System;
using System.Collections.Generic;
using System.Text;

namespace Ejer1ClaseAbstractas
{
    abstract class Producto
    {
        
        //Propiedades autoimplementadas
        public double Precio { get; set; }
        public double Costo { get; set; }

        public string NombreProducto { get; set; }

        public Producto(string pnombre, double pprecio, double pcosto)
        {
            NombreProducto = pnombre;
            Precio = pprecio;
            Costo = pcosto;
        }

        //Metodo Abstracto
        public abstract string ImprimirDatos();

        //Propiedad abstracta
        public abstract int Codigo { get; set; }
        
    }

}

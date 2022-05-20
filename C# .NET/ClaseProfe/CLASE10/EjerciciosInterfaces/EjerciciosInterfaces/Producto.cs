using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosInterfaces
{
    class Producto:IComparable<Producto>
    {
        public string Codigo { get; set; }
        public decimal Precio { get; set; }

        public int CompareTo(Producto otros)  //implementar este metodo
        {
            //if (Precio > otros.Precio) return 1;
            //if (Precio == otros.Precio) return 0;
            //return -1;

            return Precio.CompareTo(otros.Precio);
        }

    }
}

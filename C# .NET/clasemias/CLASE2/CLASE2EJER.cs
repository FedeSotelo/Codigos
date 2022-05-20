using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2_3Ejercicio
{
    internal class Program
    {

        public static int AsignarCaja()
        {

            //Validaciones Funciones
            int nro_caja= 0;
            do
            {
                if(nro_caja <0 || nro_caja > 3)
                {
                    Console.WriteLine("opcion invalida!!!");
                }
                Console.WriteLine("ingresen nro de caja ( 1 , 2 , 3): ");
                nro_caja = int.Parse(Console.ReadLine());
            }
            while (nro_caja < 0 || nro_caja > 3);



            return nro_caja ; 
        }





        static void Main(string[] args)
        {
            /*
            *Un Supermercado realiza un estudio sobres sus ventas.Para ello cuenta con tres cajas.
             *Se ingresan los siguientes datos:
             *
             *Nro de Caja(1,2,3)
             *Turno(Mañana, Tarde)
             * Nombre de la Cajera
             * Importe de la Compra
             *
             * Se pide:
            *1) Recaudacion por Caja
           * 2) Cantidad de Tickets emitidos por turno.
             *3) Caja de mayor Recaudacion
             *4) Caja de menor Recaudacion
             *5) Recaudacion Total
             *
             *Todos los puntos con Funciones */



            int nro_Caja =0;

            while (nro_Caja!=0)
            {
                nro_Caja = AsignarCaja();




            }




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioComplicadoclase2
{
    internal class Program

    {
        public static int AsignarCaja()
        {
            int nro_caja = 0;
            do
            {
                if (nro_caja < 0 || nro_caja > 3)
                {
                    Console.WriteLine("Opcion Invalida!!!");
                }
                Console.WriteLine("Ingrese Nro de Caja (1,2,3):");
                nro_caja = int.Parse(Console.ReadLine());

            } while (nro_caja < 0 || nro_caja > 3);

            return nro_caja;
        }
       /* public static void Turno()
        {
            char turnoM = 'M';
            char turnoT = 'T';

        }
       */
        static void Main(string[] args)
        {


            /* consignas 
            * 
            * Un Supermercado realiza un estudio sobres sus ventas. Para ello cuenta con tres cajas.
            * Se ingresan los siguientes datos:
            * 
            * Nro de Caja(1,2,3)
            * Turno (Mañana, Tarde)
            * Nombre de la Cajera
            * Importe de la Compra
            * 
            * Se pide:
            * 1) Recaudacion por Caja
            * 2) Cantidad de Tickets emitidos por turno.
            * 3) Caja de mayor Recaudacion
            * 4) Caja de menor Recaudacion
            * 5) Recaudacion Total 
            * 
            * Todos los puntos con Funciones */
            int nro_Caja = 0;

            while (nro_Caja != 0)
            {
                nro_Caja = AsignarCaja();



            }
        }
    }
}

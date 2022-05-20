using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3._1
{
    internal class Program
    {
        static int recCaja1=0, recCaja2=0, recCaja3=0; //SON PARAMETROS GLOBALES



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
        public static string AsignarTurno()
        {
            string turno = "M";

            do
            {
                if (turno != "M" || turno != "T")
                {
                    Console.WriteLine("Opcion invalida");
                }
                Console.WriteLine("Ingrese Turno (M/T): ");
                turno = Console.ReadLine().ToUpper();



            }
            while (turno !="M" ||turno != "T");

            return turno; 


        }
        public static string AsignarNombre()
        {
            string nombreCajera;

            Console.WriteLine("Ingrese su nombre");
            nombreCajera = Console.ReadLine();

            return nombreCajera;
        }
        public static int AsignarImporte()
        {
            int importe;

            do
            {
                Console.WriteLine("Ingrese el importe");
                importe = int.Parse(Console.ReadLine());



            }
            while (importe <=0);  //Valida que el importe sea positivo

            return importe;
        }

        public static void RecaudacionPorCaja(int nrocaja, int importe)
        {
            switch (nrocaja)
            {
                case 1:
                    recCaja1 += importe;
                    break;

                case 2:
                    recCaja2 += importe;

                    break;

                case 3:
                    recCaja3 += importe;

                    break;


                default:
                    Console.WriteLine("Invalido");
                    break;


            }

        }

        public static Boolean Validaciones (int nrocaja, string turno, string nombreCajera, int importe)
        {
            int errores = 0;


            if (nrocaja <= 0 || nrocaja > 3)
            {
                errores++;
                Console.WriteLine("Caja invalida");
            }

        }




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
            int nro_Caja = 0,importe=0;
            string turno, nombreCajera;

            while (nro_Caja != 1)
            {





                nro_Caja = AsignarCaja();
                if (nro_Caja != 0)
                {
                    turno = AsignarTurno();
                    nombreCajera = AsignarNombre();
                    importe = AsignarImporte();


                    if (Validaciones(nro_Caja, turno, nombreCajera, importe))
                    {

                    }

                    RecaudacionPorCaja(nro_Caja, importe);




                }
                Console.WriteLine("-- RESULTADOS --");
                Console.WriteLine("La Recaudacion de la caja 1 es: " + recCaja1);
                Console.WriteLine("La Recaudacion de la caja 2 es: " + recCaja2);
                Console.WriteLine("La Recaudacion de la caja 3 es: " + recCaja3);


                
            }

            Console.ReadKey();

        }
    }
}

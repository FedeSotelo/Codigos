using System;

namespace Clase2_Ejercicio2_Funciones
{
    class Program
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





        public static string Turno()
        {
            string turno;
            Console.WriteLine("Ingrese su turno");
            turno = Console.ReadLine().Substring(0,1).ToUpper();

                Console.WriteLine("Su turno es: " + turno);

                
           

            return turno;

        }




        
        public static string NombreCajera()
        {
            
            Console.WriteLine("Ingrese su nombre");
            string nombreCajera = Console.ReadLine();


            return nombreCajera;

        }



        public static float ImporteCompra()
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

 

        public static int CantidadTickets(int turno)
        {
                int ticketTarde=0, ticketMañana=0;

                turno = int.Parse(Console.ReadLine());
            switch (turno)
            {
                    case T:
                        ticketTarde++;


                        break;


                     case M:
                        ticketMañana++;
                        break;

                            default: 
                            Console.WriteLine ("Incorrecto");
                            break;
            
            }  
        }
      
        public static int CajaMayorRecau()

        {
           

            return 0;   

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
            int nro_Caja = 0;
            float importe= 0;
            string turno;
            
            
            while (nro_Caja != 1)
            {
                
                nro_Caja=  AsignarCaja();
                 turno = Turno();
                importe= ImporteCompra();
                RecaudacionPorCaja(nro_Caja,importe);
                 CantidadTickets(turno);
                
                   
                    
              Console.WriteLine("-- RESULTADOS --");
                Console.WriteLine("La Recaudacion de la caja 1 es: " + recCaja1);
                Console.WriteLine("La Recaudacion de la caja 2 es: " + recCaja2);
                Console.WriteLine("La Recaudacion de la caja 3 es: " + recCaja3);
                
            }
            



            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE2
{
    internal class Program
    {



       
        static void Main(string[] args)
        {
            /*
            string cadena = "Carlos Alberto Gutierrez";
            int largo = cadena.Length;
            Console.WriteLine("La cantidad de caracteres es: " + largo);

            string mayusculas;
            mayusculas = cadena.ToUpper();
            Console.WriteLine("La cadena en mayuscula es: " + mayusculas);


            string extraer;
            extraer = cadena.Substring(7, 7);
            Console.WriteLine("La cadena de extraer es: " + extraer);


            int primeraOcurrencia;
            primeraOcurrencia = cadena.IndexOf('e');

            Console.WriteLine("La primera letra e esta en la posicion: " + primeraOcurrencia);
            */






            /*
             
              |-- EJERCICIO --|

             Una importante empresa de articulos deportivos, realiza n operaciones.

            De cada operacion se ingresan los siguientes datos:

            - Nombre del Producto(P: Pelotas, Z:zapatillas, G:equipo de gimnasia)
            - Zona (N:Norte, S:Sur, O:Oeste, E:este)
            - Cantidad comprada.

            Si el producto es P, el precio sera 700, si es Z, el precio sera 1200, si es G, 
            su precio sera 550 sino 0;

            Se Pide:
            1) Cantidad vendida de cada producto.
            2) cantidad de compras por zonas.
            3) facturacion por cada producto.
            4) facturacion pot cada zona.
            5) cantidad de personas que compraropn pelotas de la zona norte y sur.

            */


            /*
            int n;
            n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {

               

            }
            */


            string nombreProducto;
            string zona;
            int cantidadC,cantP =0, cantZ=0, cantE=0,cNorte=0, cSur=0, cOeste=0, cEste=0,precio, persNorte=0, persSur=0,totalPersNorte=0, totalPersSur=0;
            double subtP=0, subtZ=0, subtE=0, subTotal=0, facNorte=0, facSur=0, facOeste=0, facEste=0, subTotalZonas=0;



            char fin =  'S';    // pelotas // la primera letra en 0
            
             while (fin != 'N')
            {

                Console.WriteLine("Ingrese el nombre del producto -Zapatillas - Pelotas - Equipos - :");
                nombreProducto = Console.ReadLine().Substring(0, 1).ToUpper();



                Console.WriteLine("Ingrese la Zona (Norte - Sur - Este - Oeste) :");
               zona = Console.ReadLine().Substring(0, 1).ToUpper();


                Console.WriteLine("Ingrese la cantidad comprada :");
                cantidadC = int.Parse(Console.ReadLine());




                // 1) Cantidad vendida de cada producto.
                if (nombreProducto == "P")  //el hecho de poner toupper hace que lo ponga en mayuscula
                {

                    cantP = cantP + cantidadC; // cantP += cantidadC
                    precio = 700;
                    subtP = precio * cantP;

                    
                }
                else if (nombreProducto == "Z")
                {
                    cantZ = cantZ + cantidadC; // cantZ += cantidadC
                    precio = 1200;
                    subtZ = precio * cantZ;

                    
                }
                else if (nombreProducto == "E")
                {
                    cantE = cantE + cantidadC;  // cantE += cantidadC
                    precio = 550;
                    subtE = precio * cantE;


                    

                }
                else
                {
                    Console.WriteLine("no corresponde a ningun producto");
                }

               
              

                subTotal = subtP + subtE + subtZ;
                subTotalZonas = facEste + facNorte + facOeste + facSur ;

                totalPersNorte= persNorte;
                totalPersSur=persSur;




                //2) cantidad de compras por zonas.

                switch (zona)
                {
                    case "N":
                                cNorte++;

                               facNorte =  subtE + subtP + subtZ ;
                                persNorte = cNorte;

                                 
                        
                       
                                break;
                    case "S":
                                cSur++;

                                  facSur =  subtE + subtP + subtZ ;
                                    persSur=cSur;

                      
                                break;
                    case "O":
                                cOeste++;

                                 facOeste =  subtE + subtP + subtZ ;

                                
                                break;
                    case "E":
                                cEste++;

                                 facEste =  subtE + subtP + subtZ ;                           
                                
                                break;
                    default:
                                Console.WriteLine("No existe esa Zona!!!");
                                break;
                }

                

               // 5) cantidad de personas que compraropn pelotas de la zona norte y sur.









              Console.WriteLine("¿Quiere seguir ingresando datos? S/N");
                fin = char.Parse(Console.ReadLine().ToUpper());
                
                

               


            }

            Console.WriteLine("--Impresion resultados ---");
            Console.WriteLine($"Cantidad Comprada Pelotas  {cantP}");
            Console.WriteLine($"Cantidad Comprada Zapatillas  {cantZ}");
            Console.WriteLine($"Cantidad Comprada Equipo de Gimnasia  {cantE}");

            Console.WriteLine($"Cantidad Comprada Zona Norte  {cNorte}");
            Console.WriteLine($"Cantidad Comprada Zona Sur  {cSur}");
            Console.WriteLine($"Cantidad Comprada Zona Oeste  {cOeste}");
            Console.WriteLine($"Cantidad Comprada Zona Este  {cEste}");

            Console.WriteLine($"Facturacion Pelotas  {subtP}");
            Console.WriteLine($"Facturacion Zapatilla  {subtZ}");
            Console.WriteLine($"Facturacion Equipo de Gimnasia  {subtE}");

            Console.WriteLine($"Facturacion total  {subTotal}");

            Console.WriteLine("---------------------------------");

            Console.WriteLine("facturacion zona norte: " + facNorte);
            Console.WriteLine("facturacion zona ESTE: " + facEste);
            Console.WriteLine("facturacion zona Sur: " + facSur);
            Console.WriteLine("facturacion zona Oeste: " + facOeste);
            Console.WriteLine("facturacion total Zonas: " + subTotalZonas);

            Console.WriteLine("cantidad de personas Norte: " + totalPersNorte);
            Console.WriteLine("Cantidad de personas Sur: " + totalPersSur);

            Console.ReadLine();

        }
    }
}

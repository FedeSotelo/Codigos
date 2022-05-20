using System;

namespace Ejercicio2Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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
            5) cantidad de personas que compraron pelotas de la zona norte y sur.
                       
            /*inn = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
            }*/
            string nombreProducto, zona;
            int cantidadC, cantP=0, cantZ=0, cantE=0, cNorte=0, cSur=0, cOeste=0, cEste=0,precio;
            double subtP = 0, subtZ = 0, subtE = 0, subTotal=0, facNorte=0, facSur=0, facOeste=0, facEste=0, TotalNorte=0;
            char fin = 'N'; 
            
            while(fin !='S')
            {
                Console.WriteLine("Ingrese el Nombre del Producto (Zapatillas - Pelotas - Equipos :");
                nombreProducto = Console.ReadLine().Substring(0, 1).ToUpper();

                Console.WriteLine("Ingrese la Zona(Norte , Sur, Este , Oeste) :");
                zona = Console.ReadLine().Substring(0, 1).ToUpper();

                Console.WriteLine("Ingrese la Cantidad Comprada :");
                cantidadC = int.Parse(Console.ReadLine());

                //1) Cantidad vendida de cada producto.
                 if (nombreProducto == "P")  //el hecho de poner toupper hace que lo ponga en mayuscula
                {

                    cantP = cantP + cantidadC; // cantP += cantidadC
                    precio = 700;
                    subtP = precio * cantP;

                    facNorte = precio * cantP;
                    facEste = precio * cantP;
                    facOeste = precio * cantP;
                    facSur = precio * cantP;
                }
                else if (nombreProducto == "Z")
                {
                    cantZ = cantZ + cantidadC; // cantZ += cantidadC
                    precio = 1200;
                    subtZ = precio * cantZ;

                    facNorte = precio * cantZ;
                    facEste = precio * cantZ;
                    facOeste = precio * cantZ;
                    facSur = precio * cantZ;
                }
                else if (nombreProducto == "E")
                {
                    cantE = cantE + cantidadC;  // cantE += cantidadC
                    precio = 550;
                    subtE = precio * cantE;

                    facNorte = precio * cantE;
                    facEste = precio * cantE;
                    facOeste = precio * cantE;
                    facSur = precio * cantE;

                }
                else
                {
                    Console.WriteLine("no corresponde a ningun producto");
                }

                subTotal = subtE + subtZ + subtP;

               
                //2) cantidad de compras por zonas.
                switch (zona)
                {
                    case "N":
                                cNorte++;
                                break;
                    case "S":
                                cSur++;
                                break;
                    case "O":
                                cOeste++;
                                break;
                    case "E":
                                cEste++;
                                break;
                    default:
                                Console.WriteLine("No existe esa Zona!!!");
                                break;
                }

                Console.WriteLine("¿Quiere seguir ingresando Datos(S/N):");
                fin = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("--- Impresion de Resultados ---");
            Console.WriteLine("Cantidad Comprada Pelotas " + cantP);
            Console.WriteLine("Cantidad Comprada Zapatillas " + cantZ);
            Console.WriteLine("Cantidad Comprada Equipos " + cantE);
            Console.WriteLine("Cantidad Comprada Zona Norte " + cNorte);
            Console.WriteLine("Cantidad Comprada Zona Sur " + cSur);
            Console.WriteLine("Cantidad Comprada Zona Este " + cEste);
            Console.WriteLine("Cantidad Comprada Zona Oeste " + cOeste);
            Console.WriteLine("Facturacion Pelotas " + subtP);
            Console.WriteLine("Facturacion Zapatillas " + subtZ);
            Console.WriteLine("Facturacion Equipos " + subtE);
            Console.WriteLine("Facturacion Total " + subTotal);

        }
    }
}

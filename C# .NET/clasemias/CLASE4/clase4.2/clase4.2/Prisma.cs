using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase4._2
{
    class Prisma
    {

        /*Crear una clase llamada Prisma.
           * Crear 2 constructores uno por default y otro por parametros
           * Crear 3 propiedades de lectura y escritura (Ancho, Alto, Espesor)
           * Crear 1 propiedad de lectura llamada Area.
           * Crear otra propiedad de lectura llamada Volumen.
           * Crear un metodo llamado CalcularVolumen que no devuelva datos.
           * Crear otro metodo que se llame calcularArea donde instancie a otro metodo llamado 
           * calcularRectangulo (que calculara con dos elementos alto y el ancho))
           * 
           * Crear dos objetos prisma1 y prisma2.
           * 
           */
        private int ancho, alto, espresor, area, volumen;


        //CONSTRUCTOR DEFAULT
        public Prisma()
        {
            Console.WriteLine("--Ingrese los datos--");
            Console.Write("Ingrese el ancho ");
            ancho=int.Parse(Console.ReadLine());
            Console.Write("Ingrese el alto ");
            alto = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el espresor ");
            espresor = int.Parse(Console.ReadLine());
        }
        //CONSTRUCTOR PARAMETROS
        public Prisma(int pancho, int palto, int pespresor)
        {
            ancho = pancho;
            alto = palto;
            espresor = pespresor;


        }
        //PROPIEDADES LECTURA Y ESCRITURA
        public int Ancho
        {
            get { return ancho; }
            set {
                if (value <= 0)
                {
                    ancho = 1;
                }
                else
                {
                    ancho = value;  
                }
            }


        }
        public int Alto
        {
            get { return alto; }
            set {
                if (value <= 0)
                {
                    alto = 1;
                }
                else
                {
                    alto = value;
                }
            }


        }
        public int Espresor
        {
            get { return espresor; }
            set {
                if (value <= 0)
                {
                    espresor = 1;
                }
                else
                {
                    espresor = value;
                }
            }


        }

        //PROPIEDAD SOLO LECTURA


        public int Area
        {
            get { return area; }
        }
        public int Volumen
        {
            get { return volumen; }
        }



        //METODOS

        //NO RECIBE PARAMETROS Y NO DEVUELVE UN RESULTADO
        public void CalcularVolumen()
        {
            volumen = ancho * alto * espresor;
        }

        public void CalcularArea()
        {
            int a1 = 0, a2 = 0, a3 = 0;

            a1 = 2 * CalcularRectangulo(ancho, alto);
            a2 = 2 * CalcularRectangulo(ancho, alto);
            a3 = 2 * CalcularRectangulo(ancho, alto);

            area = a1 + a2 + a3;


        }

        //RECIBE PARAMETROS Y DEVUELVE UN RESULTADO
        public int CalcularRectangulo(int anc, int alt)
        {


            return anc * alt;

        }

       

    }
}

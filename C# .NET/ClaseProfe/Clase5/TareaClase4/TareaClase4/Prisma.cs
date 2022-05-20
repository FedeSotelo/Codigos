using System;
using System.Collections.Generic;
using System.Text;

namespace TareaClase4
{
    class Prisma
    {
        //atributos
        private int ancho, alto, espesor, area, volumen;

        //Constructor por Default
        public Prisma()
        {
            
            Console.WriteLine(" --Ingreso de Datos--");
            Console.WriteLine();
            Console.Write("Ingrese el Ancho: ");
            ancho = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el Alto: ");
            alto = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el Espesor: ");
            espesor = int.Parse(Console.ReadLine());
        }
        //Constructor Por parametros
        public Prisma(int pancho, int palto,int pespesor)
        {
            ancho =pancho;            
            alto = palto;           
            espesor = pespesor;
        }

        //Propiedades de Lectura y Escritura
        public int Ancho
        {
            get { return ancho; }
            set { 
                    if(value<=0)
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
            set
            {
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

        public int Espesor
        {
            get { return espesor; }
            set
            {
                if (value <= 0)
                {
                    espesor = 1;
                }
                else
                {
                    espesor = value;
                }
            }
        }
        //Propiedades de Solo Lectura
        public int Area
        {
            get { return area; }
        }

        public int Volumen
        {
            get { return volumen; }
        }

        //Metodo que no recibe parametros y no devuelve un resultado
        public void CalcularVolumen()
        {
            volumen = ancho * alto * espesor;
        }
        //Metodo que recibe parametros y devuelve un resultado
        public int CalcularRectangulo(int anc, int alt)
        {
             return anc * alt;
        }

        public void CalcularArea()
        {
            int a1 = 0, a2 = 0, a3 = 0;

            a1 = 2 * CalcularRectangulo(ancho, alto);
            a2 = 2 * CalcularRectangulo(ancho, alto);
            a3 = 2 * CalcularRectangulo(ancho, alto);

            area = a1 + a2 + a3;
        }
    }
}

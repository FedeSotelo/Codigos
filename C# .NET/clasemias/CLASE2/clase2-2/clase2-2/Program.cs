using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2_2
{
    internal class Program
    {

        public static void Suma()
        {
            int n1, n2;

            float s = 0;

            Console.Write("ingrese el Numero 1 : ");
            n1= int.Parse(Console.ReadLine());
            Console.Write("ingrese el Numero 2 : ");
            n2 = int.Parse(Console.ReadLine());


            s = n1 + n2;

            Console.Write("El resultado de la Suma es {0}", s);
        }

        public static float Resta()
        {

            int n1, n2;

            float r = 0;

            Console.Write("ingrese el Numero 1 : ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese el Numero 2 : ");
            n2 = int.Parse(Console.ReadLine());


            r = n1 - n2;

            Console.Write("El resultado de la Resta es {0}", r);

            return r;
        }

        public static void Multiplicacion (int n1, int n2)
        {

            float multi = 0;

            multi = n1 * n2;

      

            Console.Write("El resultado de la Multiplicacion de {0} por {1} es : {2}", n1, n2, multi);


            return ;
        }



        static void Main(string[] args)
        {

            int opcion =0;

            Console.WriteLine("Menu Principal ---");
            Console.WriteLine("1 - suma");
            Console.WriteLine("2 - resta");
            Console.WriteLine("3 - multiplicacion");
            Console.WriteLine("4 - division");

            do
            {
                Console.WriteLine("Eliga una Opcion!!! : ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Suma();  //aca se llama al procedimiento
                }else if (opcion == 2)
                {
                    float resu = 0;
                    resu= Resta(); //aca se llama a la funcion
                    Console.WriteLine("El resultado de la resta es {0}", resu);
                }
                else if( opcion == 3)
                {

                    int nro1, nro2;

                    
                    Console.Write("ingrese el Numero 1 : ");
                    nro1 = int.Parse(Console.ReadLine());
                    Console.Write("ingrese el Numero 2 : ");
                    nro2 = int.Parse(Console.ReadLine());

                    Multiplicacion(nro1, nro2);


                }
                else if (opcion == 4)
                {

                }




            }
            while (opcion != 0);


        }
    }
}

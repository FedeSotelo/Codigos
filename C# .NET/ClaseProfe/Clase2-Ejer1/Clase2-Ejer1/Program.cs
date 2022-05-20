using System;

namespace Clase2_Ejer1
{
    class Program
    {

        public static void Suma()
        {
            int n1, n2;
            float s = 0;

            Console.Write("Ingrese el Numero 1:");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el Numero 2:");
            n2= int.Parse(Console.ReadLine());
            s = n1 + n2;
            Console.WriteLine("El resultado de la Suma es {0}", s);
        }


        public static float Resta()
        {
            int n1, n2;
            float r = 0;
            Console.Write("Ingrese el Numero 1:");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el Numero 2:");
            n2 = int.Parse(Console.ReadLine());
            r = n1 - n2;
            return r;
        }

        public static void Multiplicacion(int n1, int n2)
        {
            float multi = 0;
            multi = n1 * n2;
            Console.WriteLine("El resultado de la Multiplicacion de {0} por {1} es: {2}", n1, n2, multi);
        }

        static void Main(string[] args)
        {

            int opcion = 0;
            Console.WriteLine("Menu Principal ---");
            Console.WriteLine(" 1 - Suma ");
            Console.WriteLine(" 2 - Resta ");
            Console.WriteLine(" 3 - Multiplicacion ");
            Console.WriteLine(" 4 - ision ");

            do
            {
                Console.Write("Elija una Opcion!!!! : ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Suma();
                }
                else if (opcion == 2)
                {
                    float resu = 0;
                    resu = Resta();
                    Console.WriteLine("El resultado de la Resta es {0}", resu);
                }
                else if (opcion == 3)
                {

                    int nro1, nro2;
                    Console.Write("Ingrese el Numero 1:");
                    nro1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el Numero 2:");
                    nro2 = int.Parse(Console.ReadLine());
                    Multiplicacion(nro1, nro2);
                }


                } while (opcion != 0);


        }
    }
}

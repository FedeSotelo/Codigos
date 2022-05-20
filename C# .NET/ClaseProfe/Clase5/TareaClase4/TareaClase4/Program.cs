using System;

namespace TareaClase4
{
    class Program
    {
        static void Main(string[] args)
        {
            Prisma obj1 = new Prisma();
            Prisma obj2 = new Prisma(3,5,7);
            obj1.CalcularArea();
            obj1.CalcularVolumen();
            obj2.CalcularArea();
            obj2.CalcularVolumen();
            Console.WriteLine("area={0}, volumen={1}", obj1.Area, obj1.Volumen);
            Console.WriteLine("area={0}, volumen={1}", obj2.Area, obj2.Volumen);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase3._2POO
{
    internal class Alumno
    {
        //Atributos o campos
        private string nombre, apellido;
        private int legajo;

        //Caracteristicas de un alumno


        //Construcctor por default

        public Alumno()
        {
            legajo = 1500;
            nombre = "Federico";
            apellido = "Sotelo";

        }
        //Construcctor por parametros

        public Alumno(int pLegajo, string pNombre, string pApellido)
        {
            legajo = pLegajo;
            nombre = pNombre;
            apellido = pApellido;

        }



        public void Imprimir()
        {
            Console.WriteLine("El legajo es: {0} y su nombre es: {1} y su apellido es : {2}", legajo, nombre, apellido);
        }





        static void Main(string[] args)
        {

            Alumno alu1 = new Alumno(); //Creando objeto que instancia al Constructor por default
            Alumno alu2 = new Alumno(100, "luis", "gomez"); //Creando objeto que instancia al Constructor por parametros
            alu1.Imprimir();
            alu2.Imprimir();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    class Alumno
    {
        //creando atributos
        private string nombre, apellido;
        private int legajo, edad;

        //Constructor por Default
        public Alumno()
        {
            nombre = "Juan";
            apellido = "martinez";
            legajo = 2109;
            edad = 45;
        }

        public Alumno(string pnombre, string papellido, int plegajo, int pedad)
        {
            nombre = pnombre;
            apellido = papellido;
            legajo = plegajo;
            edad = pedad;
        }
        //metodo
        public void Imprimir()
        {
            Console.WriteLine("Su Nombre es: " + this.nombre + " y su apellido es: " + this.apellido + " y su edad es: " + this.edad +
                " y su legajo es:" + this.legajo);
        }
        static void Main(string[] args)
        {
            Alumno Alu1 = new Alumno();//llamamndo al constructor por default
            Alu1.Imprimir();
            Alumno Alu2 = new Alumno("Luis", "perez",1502,55); //constructor por Parametros
            Alu2.Imprimir();
            Console.ReadKey();
        }
    }
}

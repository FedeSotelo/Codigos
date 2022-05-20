using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERICICIO
{
    internal class Secretario:Empleado
    {
        private string numerodetelefono;

        public Secretario(string pnombre, string papellido, string pdni, int pañoingreso, double psalario, string pnumtelefono):base(pnombre, papellido, pdni,pañoingreso, psalario)
        {
            numerodetelefono = pnumtelefono;


        }


        public string NumeroTelefono
        {
            get { return numerodetelefono; }
            set {  numerodetelefono = value; }
        }


        public override void Imprimir()
        {
            Console.WriteLine("---Datos del Secretario---");
            Console.WriteLine($"Su nombre es {Nombre}, con apellido {Apellido}, con dni {Dni}|| Ingreso el {AñoDeIngreso} , su salario es {Salario}, Su numero de telefono es {NumeroTelefono},");
            Console.WriteLine($"Su antiguedad es {Antiguedad} años, Se incremento su salario en {IncrementarSalario()} ");

            Console.WriteLine("------------------------------");
            
        }
        
        public override int Antiguedad
        {
            get { return DateTime.Now.Year - AñoDeIngreso; }

            set
            {
                AñoDeIngreso = DateTime.Now.Year - value;
            }
        }
        

        public override double IncrementarSalario()
        {
            int añios = Antiguedad;
            double aumentoTotal = 0.0;
            for (int i = 0; i < añios; i++)
            {
                aumentoTotal += Salario * 0.05;
            }
            return aumentoTotal;

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJercicioTareaClase7
{
    class Secretario:Empleado
    {
        private string NroTelefono;

        /*constructor
        public Secretario(string pnombre, string papellido, string pdni, int paño, double psalario, string pnroTelefono)
            :base(pnombre, papellido, pdni,paño,psalario)
        {
            NroTelefono = pnroTelefono;
        }*/

        public override int Antiguedad 
        { get { return DateTime.Now.Year - añoIngreso; }

            set {
                añoIngreso = DateTime.Now.Year - value; } 
        }

        public override double Incrementarsalario()
        {
            int añios = Antiguedad;
            double aumentoTotal = 0.0;
            for(int i=0;i< añios; i++)
            {
                aumentoTotal += salario * 0.05;
            }
            return aumentoTotal;
        }

        public override void Imprimir()
        {
            Console.WriteLine("Datos del Secretario --- ");
            Console.WriteLine("El Nombre es: " + );
        }
    }
}

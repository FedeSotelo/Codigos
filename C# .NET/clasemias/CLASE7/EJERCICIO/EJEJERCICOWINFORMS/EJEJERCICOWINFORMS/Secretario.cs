using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEJERCICOWINFORMS
{
    internal class Secretario : Empleado
    {

        private double salarioactualizado; 
         private string numerodetelefono;

        /*
        
        public Secretario(string pnom, string pape, string pdni, string pañoingreso, double psalario, string pnumtelefono, int pantiguedad) : base(pnom, pape, pdni, psalario)
        {
            NumeroTelefono = pnumtelefono;
            Antiguedad = pantiguedad;


        }
        */

        public string NumeroTelefono
        { get { return numerodetelefono; }
            
            set { numerodetelefono = value; } 
        
        }


        public override int Antiguedad
        { 
            get { return DateTime.Now.Year - AñoDeIngreso; } 
            set { AñoDeIngreso = DateTime.Now.Year - value; }
        }



        public double Salarioactualizado
        {
            get { return salarioactualizado;}
            set { salarioactualizado = value; }
        }

        
        public override double IncrementarSalario()
        {
            int años = Antiguedad;
            double aumentoTotal = 0.0;

            for (double i = 0; i >años; i++)
            {
                aumentoTotal += (Salario * 0.05);
            }

            return aumentoTotal;
        }
        



        /*
        public override void Imprimir()
        {
            
            //hacer console.writeline;

        }

       */
    }
}

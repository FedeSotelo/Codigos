using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEJERCICOWINFORMS
{
    internal abstract class Empleado
    {
        private string nombre, apellido, dni ;
        private int añoingreso;
        private double salario, salarioacobrar;

        /*
        public Empleado(string pnom, string pape, string pdni, double psalario, int pañoingreso)
        {
            nombre = pnom;
           apellido = pape;    
            dni = pdni;
            salario = psalario;
            añoingreso = pañoingreso;
            salarioacobrar = 0.0;

        }
        
        */

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value.ToUpper(); }
        }
        public string Dni
        { get { return dni; }
            set { dni = value; }
        }
        

        public int AñoDeIngreso 
        {
            get { return añoingreso; } 
            set { añoingreso=value; }
        
        }


        public double Salario { get; set; }


        
        public abstract double IncrementarSalario();
       

        /*
        public abstract void Imprimir();
        */

        public abstract int Antiguedad { get; set; }






    }
}

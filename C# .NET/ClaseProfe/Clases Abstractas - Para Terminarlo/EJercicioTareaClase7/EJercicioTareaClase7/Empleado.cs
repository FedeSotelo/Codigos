using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJercicioTareaClase7
{
    abstract class Empleado
    {
        private string nombre, apellidos, DNI;
        private int añoIngreso;
        private double salario;
        private double SalarioACobrar;
        
        /*Constructor
        public Empleado(string pnombre, string papellido, string pdni, int paño, double psalario)
        {
            nombre = pnombre;
            apellidos = papellido;
            DNI = pdni;
            añoIngreso = paño;
            salario = psalario;
            SalarioACobrar = 0.0;
        }*/
        public abstract void Imprimir();
        public abstract double Incrementarsalario();

        //Propiedad abstracta
        public abstract int Antiguedad { get; set; }
        public abstract int Nombre { get; set; }
    }
}

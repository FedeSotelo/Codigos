using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERICICIO
{
    internal abstract class Empleado
    {
        private string nombre, apellido, dni;
        private double salario;
        private int añoingreso;


        public Empleado( string pnombre, string papellido, string pdni, int pañoingreso, double psalario)
        {
            nombre = pnombre;
            apellido = papellido;
            dni = pdni;
            salario = psalario;
            añoingreso = pañoingreso;
            


        }



        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        
        public int AñoDeIngreso
        {
            get { return añoingreso; }
            set { añoingreso = value; }
        }

        

      //Metodos abstractas
        public abstract void Imprimir();

        public abstract double IncrementarSalario();
        //Propiedad abstracta
        public abstract  int Antiguedad { get; set; }
        


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERICICIO
{
    internal class Vendedor : Empleado
    {

        private int nrovendedor, cantidadventas;
        private double porcentajecantventas;


        public Vendedor(string pnombre, string papellido, string pdni, int pañoingreso, double psalario, int pnrovendedor, int pcantidadventas) : base(pnombre, papellido, pdni, pañoingreso, psalario)
        {
            nrovendedor = pnrovendedor;
            cantidadventas = pcantidadventas;
            

        }




        public int NroVendedor
        {
            get { return nrovendedor; }
            set { nrovendedor = value;}
        }
        
        public int Cantidadventas
        {
            get { return cantidadventas;}
            set { cantidadventas = value;}
        }
        
        public double PorcentajeCantVentas
        {
            get { return porcentajecantventas; }
            set { porcentajecantventas = value; }
        }

        public void Porcentaje()
        {

        }




        public override void Imprimir()
        {
            Console.WriteLine("---Datos del Secretario---");
            Console.WriteLine($"Su nombre es {Nombre}, con apellido {Apellido}, con dni {Dni}, Numero de vendedor {NroVendedor}|| Ingreso el año {AñoDeIngreso} , su salario es {Salario}, Cantidad de ventas totales {Cantidadventas}");
            Console.WriteLine($"Su antiguedad es {Antiguedad} años, Se incremento su salario a {IncrementarSalario()} ");

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
            int años = Antiguedad;
            double aumentoTotalSalario = 0.0;
            double aumentoTotalVentas = 0.0;
            double aumentoTotal = 0.0;
            double cantventas = Cantidadventas;
            for (int i = 0; i < años; i++)
            {
                aumentoTotalSalario += Salario * 0.10;
                aumentoTotalVentas += cantventas * 0.05;

                aumentoTotal = aumentoTotalSalario + aumentoTotalVentas;

                

            }
            return aumentoTotal;

        }
    }
}

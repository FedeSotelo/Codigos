using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase4._0
{
    internal class Trabajador
    {
        //declaracion de los atributos
        private string nombre,apellido,sector;
        private double sueldo1, sueldo2;

        //Constructor por default 
        public Trabajador()
        {
            nombre = "hernan";
        apellido= "perez";
        sector= "S";
        sueldo1= 4500;
        sueldo2= 5000;

        }

        //Constructor por parametros 
        public Trabajador(string pnombre, string papellido, string psector, double psueldo1, double psueldo2 )
        {
            nombre = pnombre;
            apellido = papellido;
            sector = psector;
            sueldo1 = psueldo1;
            sueldo2 = psueldo2;

        }



        //metodos

        public double TotalSueldo()
        {
            return sueldo1 + sueldo2;   
        }

        public string TipoSector()
        {
            string tiposector;
            if (this.sector == "A" || this.sector == "a")
            {
                tiposector = "Administrativo";
            }
            else if (this.sector == "P" || this.sector == "p")
            {
                tiposector = "Produccion";

            }
            else if(this.sector == "S" || this.sector == "s")
            {
                tiposector = "Secretaria";
            }
            else
            {
                tiposector = "Invalido";
            }
            return tiposector;

        }

        public void Imprimir()
        {

            Console.WriteLine($"Datos del Trabajador: Su nombre es: {this.nombre} su apellido es: {this.apellido} y su sector {this.TipoSector()} y su sueldo a cobrar es: {this.TotalSueldo()}");
        }

        

    }
}

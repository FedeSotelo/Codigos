using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2POO
{
    class Trabajador
    {
        /*
         *1)	Generar una Clase que se llame ClaseTrabajador y que tenga los siguientes atributos (Nombre, Apellido, Sector, Sueldo1, Sueldo2)
2)	Generar un Constructor por Default que inicialice los atributos.
3)	Crear un segundo Constructor que sea por Parámetros que inicialice los siguientes atributos.
-	Nombre: juan, Apellido: Gonzalez; Sector: A; Sueldo1: 4500; Sueldo2: 5000.
4)	Crear un Método llamado TotalSueldo que sume los sueldos y los muestre.
5)	Crear un Método llamado TipoSector, que si ingreso A me informe Administrativo si es P, me informe Producción y si es S, es Secretaria.
6)	Crear un Método llamado Imprimir que muestre un mensaje que diga:
“Su nombre es “ + atributo + “ y su apellido es: “ + atributo 2 + “ y su edad es “ + atributo3 + “ y trabaja en el sector “ + atributo4 + “ y el sueldo Total es: + atributo5.
7)	Crear dos objetos llamados Trab1 y Trab2.
8)	A los dos objetos instanciarles el método Imprimir.   */

        //atributos
        private string nombre, apellido, sector;
        private double sueldo1, sueldo2;

        //constructor por default
        public Trabajador()
        {
            nombre = "javier";
            apellido = "perez";
            sector = "a";
            sueldo1 = 4500;
            sueldo2 = 4000;
        }

        public Trabajador(string pnombre, string papellido, string psector, double psueldo1, double psueldo2)
        {
            nombre = pnombre;
            apellido = papellido;
            sector = psector;
            sueldo1 = psueldo1;
            sueldo2 = psueldo2;
        }
        public void Imprimir()
        {
            Console.WriteLine("Su Nombre es: " + this.nombre + " y su apellido es: " + this.apellido + " y su Sector es: " + this.sector +
              " y el Tipo de Sector es: " + this.TipoSector() +  " y el Sueldo a Cobrar es:" + this.TotalSueldo());
        }

        public double TotalSueldo()
        {
            return sueldo1 + sueldo2;
        }

        public string TipoSector()
        {
            string Vsector;
            if(sector=="A" || sector=="a")
            {
                Vsector = "Administrativo";
            }
            else if (sector == "P" || sector == "p")
            {
                Vsector = "Produccion";
            }
            else if (sector == "S" || sector == "s")
            {
                Vsector = "Secretaria";
            }
            else
            {
                Vsector = "Sector No Valido ";
            }

            return Vsector;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER
{
    internal class Trabajador
    {
        private string nombre, apellido, sector;
        private int sueldo1, sueldo2;


        public  Trabajador()
        {
            nombre = "Hernan";
            apellido = "Enrique";
            sector = "S";
            sueldo1 = 6000;
            sueldo2 = 8000;


        }
        public  Trabajador(string pNombre, string pApellido, string pSector,int pSueldo1, int pSueldo2)
        {

            nombre = pNombre;   
            apellido = pApellido;
            sector = pSector;
            sueldo1 = pSueldo1;
            sueldo2 = pSueldo2;
            

        }


        public double TotalSueldo()
        {
            

            double totalSueldo= sueldo1 + sueldo2;

           
            //  return sueldo1 + sueldo2; directamente

            return totalSueldo;
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

        public void Imprimir()
        {
             Console.WriteLine("Su Nombre es: " + this.nombre + " y su apellido es: " + this.apellido + " y su Sector es: " + this.sector +
              " y el Tipo de Sector es: " + this.TipoSector() +  " y el Sueldo a Cobrar es:" + this.TotalSueldo());
        }


        static void Main(string[] args)
        {


            /*
            -1)	Generar una Clase que se llame ClaseTrabajador y que tenga los siguientes atributos(Nombre, Apellido, Sector, Sueldo1, Sueldo2)
           -  2)	Generar un Constructor por Default que inicialice los atributos.
             -   3)	Crear un segundo Constructor que sea por Parámetros que inicialice los siguientes atributos.
            - Nombre: juan, Apellido: Gonzalez; Sector: A; Sueldo1: 4500; Sueldo2: 5000.
          -  4)	Crear un Método llamado TotalSueldo que sume los sueldos y los muestre.
           - 5)	Crear un Método llamado TipoSector, que si ingreso A me informe Administrativo si es P, me informe Producción y si es S, es Secretaria.
           - 6)	Crear un Método llamado Imprimir que muestre un mensaje que diga:
           - “Su nombre es “ +atributo + “ y su apellido es: “ +atributo 2 + “ y su edad es “ +atributo3 + “ y trabaja en el sector “ +atributo4 + “ y el sueldo Total es: +atributo5.
            7)	Crear dos objetos llamados Trab1 y Trab2.
            8)	A los dos objetos instanciarles el método Imprimir.   */

            

           Trabajador Trab1 = new Trabajador();
            Trab1.Imprimir();

            Trabajador Trab2 = new Trabajador("juan", "Gonzalez", "A", 4500, 5000);
            Trab2.Imprimir();

            Console.ReadKey();


        }
    }
}

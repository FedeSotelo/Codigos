using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase4._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
           Ejercicio1:

1)	Generar una Clase que se llame ClaseTrabajador y que tenga los siguientes atributos (Nombre, Apellido, Sector, Sueldo1, Sueldo2)
2)	Generar un Constructor por Default que inicialice los atributos.
3)	Crear un segundo Constructor que sea por Parámetros que inicialice los siguientes atributos.
-	Nombre: juan, Apellido: Gonzalez; Sector: A; Sueldo1: 4500; Sueldo2: 5000.
4)	Crear un Método llamado TotalSueldo que sume los sueldos y los muestre.
5)	Crear un Método llamado TipoSector, que si ingreso A me informe Administrativo si es P, me informe Producción y si es S, es Secretaria y sino No Valida!!!
6)	Crear un Método llamado Imprimir que muestre un mensaje que diga:
“Su nombre es “ + atributo + “ y su apellido es: “ + atributo 2 + “ y su edad es “ + atributo3 + “ y trabaja en el sector “ + atributo4 + “ y el sueldo Total es: + atributo5.
7)	Crear dos objetos llamados Trab1 y Trab2.

        */

            Trabajador trab1 = new Trabajador(); //Constructor por default

            Trabajador trab2 = new Trabajador("juan", "Gonzalez", "A", 4500,700);

            trab1.Imprimir();
            trab2.Imprimir();


            Console.ReadKey();

        }
    }
}

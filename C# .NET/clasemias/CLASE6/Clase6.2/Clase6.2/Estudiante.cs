using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6._2
{
    internal class Estudiante : Persona
    {
        //Atributos propios del estudiante
        private int legajo;
        private int añoCarr;
        private int materiasACursar;
        private string carrera;




        //constructor La palabra clave base se utiliza para obtener acceso a los miembros de la clase base desde una clase derivada. 

        //:base hay que ponerlo con atributos del constructor madre.
        //los primeros atributos tienen que coincidir con los ultimos despues del :base

        public Estudiante(string nombre, string apellido, string dni, int año, int pleg, int pañoCar, int pmat, string pcarr):base(nombre,apellido, dni, año) 
        {
            legajo = pleg;
            añoCarr = pañoCar;
            materiasACursar = pmat;
            carrera = pcarr;


        }

        //Propiedades
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public int AñoCar
        {
            get { return añoCarr; }
            set { añoCarr = value; }
        }
        public int MateriasACursar
        {
            get { return materiasACursar; }
            set { materiasACursar = value; }
        }
        
        //Metodo imprimir me traiga los siguientes campos(nombre, apellido, año, carrera,
        //polimorfirmo override
        //para que no se redefinen hay que poner override en la clase hija y en la clase madre hay que poner virtual
        public override void Imprimir()
        {
            Console.WriteLine($"{Nombre} {Apellido}, apellido concatenado: {ApeNom} , edad: {Edad}, dni: {Dni}, legajo: {Legajo}, carrera: {Carrera}");

        }


    }
}

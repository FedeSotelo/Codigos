using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6._2
{
    internal class Persona //Clase Madre
    {
        //Atributos 
        private string nombre, apellido,dni;
        private int  año;

        //Constructor
        public Persona(string pnombre, string papellido, string pdni, int paño)
        { 
            nombre = pnombre;
            apellido = papellido;
            dni = pdni;
            año = paño;
            

        }

        //Propiedades lectura y escritura

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value.ToUpper(); }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        


        //propiedad que me traiga concatenado el nombre y apellido

        public string ApeNom
        {
            get {

                return string.Concat(Nombre, "-", Apellido);
                    
                }
            
        }
        

        //propiedad que me traiga la Edad
        public int Edad
        {
            get { return DateTime.Now.Year - año; }    //Calcular edad || funciones fecha y hora
            set { año = value; }
        }



        //Metodo que se llame Imprimir
        //polimorfirmo virtual
        //para que no se redefinen hay que poner virutal en la clase madre y override en la clase hija
        public virtual void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre} Apellido: {Apellido} apellido concatenado: {ApeNom} , y su edad es: {Edad}, con dni {Dni}");

        }






    }
}

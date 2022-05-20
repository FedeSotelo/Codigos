using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaConWF
{
    class Empleado:Persona
    {
        //Atributos
        private string tipoContrato;
        private int bonos, vtasRealizadas;
        private double sueldo, sueldoT;

        //Propiedades
        public string TipoContrato
        {
            get { return tipoContrato; }
            set { tipoContrato = value.Substring(0,1).ToUpper(); }
        }
        public int VentasRealizadas
        {
            get { return vtasRealizadas; }
            set { vtasRealizadas = value; }
        }

        public int Bonos
        {
            get { return bonos; }
            set { bonos = value; }
        }
        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public double SueldoTotales
        {
            get { return sueldoT; }
            set { sueldoT = value; }
        }

        //Metodos
        public void CalcularSueldo()
        {
            if(TipoContrato== "C")
            {
                this.Sueldo = 4500;
            }
            else if (TipoContrato == "N")
                {
                    this.Sueldo = 7500;
                }
                else
                {
                    this.Sueldo = 0;
                }
        }

        public void CalcularBonos()
        {
            if(this.VentasRealizadas>=50)
            {
                Bonos = 800;
            }
            else
            {
                Bonos = 500;
            }
        }

        public void CalcularSueldoTotal()
        {
            SueldoTotales = Sueldo + Bonos;
        }
        

    }
}

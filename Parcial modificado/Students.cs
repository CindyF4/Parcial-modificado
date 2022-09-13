using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_modificado
{
    class Students
    {
        private string _nombre;
        private int _edad;
        private double _nota1;
        private double _nota2;
        private double _parcial;
        private double _promedio;

        public Students(string nombre, int edad, double nota1, double nota2, double parcial, double promedio)
        {
            this._nombre = nombre;
            this._edad = edad;
            this._nota1 = nota1;
            this._nota2 = nota2;
            this._parcial = parcial;
            this._promedio = promedio;
        }

        public string getData()
        {
            return "Nombre: " + _nombre + " Edad: " + _edad + " Nota1:" + _nota1 + " Nota2: " + _nota2 + " Parcial: " + Parcial + " Promedio: " + Promedio;
        }
    }
}

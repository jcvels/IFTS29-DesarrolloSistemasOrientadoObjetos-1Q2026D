using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraerEncapsular
{
    internal class Empleado
    {
        private string nombre;
        private int edad;
        private string cargo;

        public Empleado(string nombre, int edad, string cargo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.cargo = cargo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
     
        public int Edad { get => edad; set => edad = value; }
        
        public string Cargo { get => cargo; set => cargo = value; }

        public void mostrarInformacion()
        {
            Console.WriteLine($"Nombre: {this.nombre} Edad: {this.Edad} Cargo: {this.cargo}.");
        }
    }
}

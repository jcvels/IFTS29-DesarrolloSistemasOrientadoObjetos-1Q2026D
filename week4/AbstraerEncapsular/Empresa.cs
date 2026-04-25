using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraerEncapsular
{
    internal class Empresa
    {
        private string nombre;
        private Empleado empleado;

        public Empresa(string nombre, Empleado empleado)
        {
            this.nombre = nombre;
            this.Empleado = empleado;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        
        public Empleado Empleado { get => empleado; set => empleado = value; }

        public void mostrarInformacionEmpresa()
        {
            Console.WriteLine($"Empresa {this.nombre}.");
            this.empleado.mostrarInformacion();
        }
    }
}

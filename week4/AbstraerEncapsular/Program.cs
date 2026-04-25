using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraerEncapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var empleado = new Empleado("Jorge", 41, "CEO");
            var empresa = new Empresa("MiEmpresa", empleado);

            empresa.mostrarInformacionEmpresa();
        }
    }
}

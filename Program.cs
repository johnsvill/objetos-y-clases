using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_y_clases
{
    class Program
    {
        static void Main(string[] args)
        {
            clsEmpleados empleado;
            empleado = new clsEmpleados();
            empleado.edad = 25;
            empleado.nombre = "Jonathan Villeda";
            empleado.sueldoDiario = 100.5m;
            decimal total;
            total = empleado.calculaSalario(30);
            Console.WriteLine("El salario mensual del empleado " + empleado.nombre);
            Console.WriteLine("es: " + total.ToString("C"));
            Console.ReadKey();
        }
    }
}

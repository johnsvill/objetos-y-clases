using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_y_clases
{
    public class clsEmpleados
    {
        public clsEmpleados()
        {
            Nombre = "";
            sueldoDiario = 0.0m;
            edad = 0;
        }
        private string _Nombre;
        public string Nombre
        {
           get{ return _Nombre; }
           set{ _Nombre = value;}
        }
        public decimal Sueldodiario { get; set; }
        public int Edad { get; set; }
        public decimal sueldoDiario;
        public int edad;
        public decimal calculaSalario(int numeroDias)
        {
            return sueldoDiario * numeroDias;
        }

    }
}

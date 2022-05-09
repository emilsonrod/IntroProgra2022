using ClasesCribaEratos.ClasesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCribaEratos.ClasesHija
{
    class EmpleadoPlanta : Empleado
    {
        public string CodigoAsegurado { get; set; }
        public double SueldoFijo { get; set; }

        public override double CalcularSalario(int horasTrabajadas)
        {
            return SueldoFijo;
        }

        public override string MostrarSalario(int horasTrabajadas)
        {
            return string.Format("Soy el empleado planta {0} {1}, con codigo empleado {2}, mi sueldo es {3}",
                Nombre, Apellido, CodigoEmpleado, CalcularSalario(horasTrabajadas));
        }

        public override string ToString()
        {
            return string.Format("Soy el empleado planta {0} {1}, con codigo empleado {2}, mi sueldo es {3}",
                Nombre, Apellido, CodigoEmpleado, CalcularSalario(176));
        }
    }
}
